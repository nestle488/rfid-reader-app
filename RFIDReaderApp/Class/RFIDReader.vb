Imports Symbol.RFID3

Imports System.ComponentModel

Public Class clsRFIDReader
#Region "Variables"
    Private RFIDReader As RFIDReader             'RFIDReader object
    Private RFIDHostName As String = "127.0.0.1" 'IP Address or hostname of RFID Reader
    Private RFIDHostPort As String = "5084"      'RFID reader listening port
    Private TimeOut As UInteger = 5000           'Timeout in Milliseconds
    Private SysInfo As SystemInfo
    Private TagCount As UInteger = 0
    Private RFIDTagDetectPeriod As UShort = 3
    Private RFIDTagDetectDuration As UShort = 1
    Private RFIDFOVTimeout As UShort = 1
    Private WithEvents ReadTags As BackgroundWorker
    Public Sub New()

    End Sub

#End Region

    Public Property Hostname As String
        Get
            Return RFIDHostName
        End Get
        Set(value As String)
            RFIDHostName = value

        End Set

    End Property

    Public Property HostPort As String
        Get
            Return RFIDHostPort
        End Get
        Set(value As String)
            RFIDHostPort = value

        End Set

    End Property

    Public Property TagDetectPeriod As UShort
        Get
            Return RFIDTagDetectPeriod
        End Get
        Set(value As UShort)
            RFIDTagDetectPeriod = value

        End Set

    End Property

    Public Property TagDetectDuration As UShort
        Get
            Return RFIDTagDetectDuration
        End Get
        Set(value As UShort)
            RFIDTagDetectDuration = value

        End Set

    End Property

    Public Property FOVTimeout As UShort
        Get
            Return RFIDFOVTimeout
        End Get
        Set(value As UShort)
            RFIDFOVTimeout = value
        End Set
    End Property


#Region "Public Methods"
    ''' ===========================================================================
    ''' <name>Connect</name>
    ''' <summary>
    ''' Connect to an RFID Reader
    ''' </summary>
    ''' <returns>True if connection is successful else return False</returns>
    ''' ===========================================================================
    Public Function Connect() As Boolean
        Try
            RFIDReader = New RFIDReader(RFIDHostName, RFIDHostPort, TimeOut)
            RFIDReader.Connect()

            If RFIDReader.IsConnected Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub ReadProperties(props As Dictionary(Of String, String))
        props.Add("HostName", RFIDReader.HostName)
        props.Add("FirmwareVerion", RFIDReader.ReaderCapabilities.FirwareVersion)
        props.Add("ModelName", RFIDReader.ReaderCapabilities.ModelName)


    End Sub

    Public Sub StartInventory()
        ReadTags = New BackgroundWorker
        ReadTags.WorkerReportsProgress = True
        ReadTags.WorkerSupportsCancellation = True
        ReadTags.RunWorkerAsync()

    End Sub

    Private Sub ReadTags_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles ReadTags.DoWork

        Dim triggerInfo As New TriggerInfo

        AddHandler RFIDReader.Events.ReadNotify, AddressOf Events_ReadNotify
        RFIDReader.Events.AttachTagDataWithReadEvent = True
        'RFIDReader.Events.NotifyAccessStartEvent = True
        'RFIDReader.Events.NotifyInventoryStartEvent = True
        'RFIDReader.Events.NotifyDebugInfoEvent = True

        'readAccessTag = {}
        triggerInfo.EnableTagEventReport = True
        triggerInfo.TagEventReportInfo.ReportNewTagEvent = TAG_EVENT_REPORT_TRIGGER.MODERATED
        triggerInfo.TagEventReportInfo.ReportTagBackToVisibilityEvent = TAG_EVENT_REPORT_TRIGGER.MODERATED
        triggerInfo.TagEventReportInfo.ReportTagInvisibleEvent = TAG_EVENT_REPORT_TRIGGER.MODERATED
        triggerInfo.TagEventReportInfo.NewTagEventModeratedTimeoutMilliseconds = 1000
        triggerInfo.TagEventReportInfo.TagBackToVisibilityModeratedTimeoutMilliseconds = 1000
        triggerInfo.TagEventReportInfo.TagInvisibleEventModeratedTimeoutMilliseconds = RFIDFOVTimeout * 1000 'FOV timeout
        triggerInfo.StartTrigger.Type = START_TRIGGER_TYPE.START_TRIGGER_TYPE_PERIODIC
        triggerInfo.StartTrigger.Periodic.Period = RFIDTagDetectPeriod * 1000 'Start tag detection every N seconds
        triggerInfo.StartTrigger.Periodic.StartTime = Now
        triggerInfo.StopTrigger.Type = STOP_TRIGGER_TYPE.STOP_TRIGGER_TYPE_DURATION
        triggerInfo.StopTrigger.Duration = RFIDTagDetectDuration * 1000 'Detect tags for N seconds
        RFIDReader.Actions.Inventory.Perform(Nothing, triggerInfo, Nothing)
        ' RFIDReader.Actions.Inventory.Stop()
        ' readAccessTag = RFIDReader.Actions.GetReadTags(10)
        'ReadTags.ReportProgress(0, readAccessTag)

        Do
        Loop Until ReadTags.CancellationPending

    End Sub

    Private Sub ReadTags_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles ReadTags.ProgressChanged
        Dim tagdata As TagData = e.UserState
        If Not IsNothing(e.UserState) Then
            TagCount = TagCount + 1
            frmMain.dgvTagData.Rows.Add(TagCount,
                    tagdata.TagID,
                    HexToAscii(tagdata.TagID),
                    tagdata.PeakRSSI,
                    tagdata.SeenTime.UTCTime.FirstSeenTimeStamp,
                    tagdata.SeenTime.UTCTime.LastSeenTimeStamp,
                    tagdata.TagSeenCount,
                    tagdata.AntennaID,
                    tagdata.TagEvent)
        End If

    End Sub


    Private Function HexToAscii(hex As String) As String
        Dim strAscii As String = ""
        For i As Short = 0 To hex.Length - 2 Step 2
            strAscii = strAscii + (System.Convert.ToChar(Int32.Parse(hex.Substring(i, 2), System.Globalization.NumberStyles.HexNumber)))
        Next
        Return (strAscii)

    End Function


    Public Sub Events_ReadNotify(sender As Object, e As Events.ReadEventArgs)
        ReadTags.ReportProgress(0, e.ReadEventData.TagData)
    End Sub

    Public Function Disconnect() As Boolean
        Try
            ReadTags.CancelAsync()
            RFIDReader.Disconnect()
            Return True

        Catch ex As Exception
            Return False

        End Try
    End Function
#End Region

End Class
