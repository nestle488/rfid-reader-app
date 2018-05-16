Imports System.ComponentModel

Public Class frmMain
    Private rfid As New clsRFIDReader
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        'Set hostname / IP address of the reader
        rfid.Hostname = txtInputHost.Text

        'Set Reader port
        rfid.HostPort = txtInputPort.Text

        'Connect to RFID reader
        If rfid.Connect Then
            btnConnect.Enabled = False
            btnDisconnect.Enabled = True

            Dim props As New Dictionary(Of String, String)
            rfid.ReadProperties(props)
            txtHostName.Text = props.Item("HostName")
            txtFWVersion.Text = props.Item("FirmwareVerion")
            txtModelName.Text = props.Item("ModelName")
            txtIPAddress.Text = props.Item("ReaderID")
            rfid.TagDetectPeriod = nudPeriod.Value
            rfid.TagDetectDuration = nudDuration.Value
            rfid.FOVTimeout = nudFOVTimeout.Value

            'Start RFID Tag Inventory
            rfid.StartInventory()

        Else
            MsgBox("Connection Failed", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        rfid.Disconnect()
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click

        rfid.Disconnect()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnDisconnect.Enabled = False

    End Sub

End Class