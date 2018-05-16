<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlProperties = New System.Windows.Forms.Panel()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.txtModelName = New System.Windows.Forms.TextBox()
        Me.txtFWVersion = New System.Windows.Forms.TextBox()
        Me.txtHostName = New System.Windows.Forms.TextBox()
        Me.lblReaderID = New System.Windows.Forms.Label()
        Me.lblModelName = New System.Windows.Forms.Label()
        Me.lblFWVersion = New System.Windows.Forms.Label()
        Me.lblHostName = New System.Windows.Forms.Label()
        Me.txtInputHost = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.dgvTagData = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASCII = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RSSI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstSeen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastSeen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Antenna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbReaderIP = New System.Windows.Forms.Label()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.nudFOVTimeout = New System.Windows.Forms.NumericUpDown()
        Me.lblFOVTimeout = New System.Windows.Forms.Label()
        Me.nudDuration = New System.Windows.Forms.NumericUpDown()
        Me.lblStopTagDetection = New System.Windows.Forms.Label()
        Me.nudPeriod = New System.Windows.Forms.NumericUpDown()
        Me.lblTagDetectionPeriod = New System.Windows.Forms.Label()
        Me.txtInputPort = New System.Windows.Forms.TextBox()
        Me.lblReaderPort = New System.Windows.Forms.Label()
        Me.pnlProperties.SuspendLayout()
        CType(Me.dgvTagData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettings.SuspendLayout()
        CType(Me.nudFOVTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlProperties
        '
        Me.pnlProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlProperties.Controls.Add(Me.txtIPAddress)
        Me.pnlProperties.Controls.Add(Me.txtModelName)
        Me.pnlProperties.Controls.Add(Me.txtFWVersion)
        Me.pnlProperties.Controls.Add(Me.txtHostName)
        Me.pnlProperties.Controls.Add(Me.lblReaderID)
        Me.pnlProperties.Controls.Add(Me.lblModelName)
        Me.pnlProperties.Controls.Add(Me.lblFWVersion)
        Me.pnlProperties.Controls.Add(Me.lblHostName)
        Me.pnlProperties.Location = New System.Drawing.Point(14, 68)
        Me.pnlProperties.Name = "pnlProperties"
        Me.pnlProperties.Size = New System.Drawing.Size(305, 138)
        Me.pnlProperties.TabIndex = 0
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Enabled = False
        Me.txtIPAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPAddress.Location = New System.Drawing.Point(135, 101)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(154, 22)
        Me.txtIPAddress.TabIndex = 7
        '
        'txtModelName
        '
        Me.txtModelName.Enabled = False
        Me.txtModelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelName.Location = New System.Drawing.Point(135, 72)
        Me.txtModelName.Name = "txtModelName"
        Me.txtModelName.Size = New System.Drawing.Size(154, 22)
        Me.txtModelName.TabIndex = 6
        '
        'txtFWVersion
        '
        Me.txtFWVersion.Enabled = False
        Me.txtFWVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFWVersion.Location = New System.Drawing.Point(135, 41)
        Me.txtFWVersion.Name = "txtFWVersion"
        Me.txtFWVersion.Size = New System.Drawing.Size(154, 22)
        Me.txtFWVersion.TabIndex = 5
        '
        'txtHostName
        '
        Me.txtHostName.Enabled = False
        Me.txtHostName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHostName.Location = New System.Drawing.Point(135, 11)
        Me.txtHostName.Name = "txtHostName"
        Me.txtHostName.Size = New System.Drawing.Size(154, 22)
        Me.txtHostName.TabIndex = 4
        '
        'lblReaderID
        '
        Me.lblReaderID.AutoSize = True
        Me.lblReaderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReaderID.Location = New System.Drawing.Point(17, 104)
        Me.lblReaderID.Name = "lblReaderID"
        Me.lblReaderID.Size = New System.Drawing.Size(70, 16)
        Me.lblReaderID.TabIndex = 3
        Me.lblReaderID.Text = "Reader ID"
        '
        'lblModelName
        '
        Me.lblModelName.AutoSize = True
        Me.lblModelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelName.Location = New System.Drawing.Point(17, 75)
        Me.lblModelName.Name = "lblModelName"
        Me.lblModelName.Size = New System.Drawing.Size(86, 16)
        Me.lblModelName.TabIndex = 2
        Me.lblModelName.Text = "Model Name"
        '
        'lblFWVersion
        '
        Me.lblFWVersion.AutoSize = True
        Me.lblFWVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFWVersion.Location = New System.Drawing.Point(17, 44)
        Me.lblFWVersion.Name = "lblFWVersion"
        Me.lblFWVersion.Size = New System.Drawing.Size(112, 16)
        Me.lblFWVersion.TabIndex = 1
        Me.lblFWVersion.Text = "Firmware Version"
        '
        'lblHostName
        '
        Me.lblHostName.AutoSize = True
        Me.lblHostName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostName.Location = New System.Drawing.Point(17, 14)
        Me.lblHostName.Name = "lblHostName"
        Me.lblHostName.Size = New System.Drawing.Size(76, 16)
        Me.lblHostName.TabIndex = 0
        Me.lblHostName.Text = "Host Name"
        '
        'txtInputHost
        '
        Me.txtInputHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputHost.Location = New System.Drawing.Point(16, 31)
        Me.txtInputHost.Name = "txtInputHost"
        Me.txtInputHost.Size = New System.Drawing.Size(155, 22)
        Me.txtInputHost.TabIndex = 1
        Me.txtInputHost.Text = "192.168.1.130"
        Me.txtInputHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(256, 30)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(348, 30)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 3
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'dgvTagData
        '
        Me.dgvTagData.AllowUserToAddRows = False
        Me.dgvTagData.AllowUserToOrderColumns = True
        Me.dgvTagData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTagData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.EPC, Me.ASCII, Me.RSSI, Me.FirstSeen, Me.LastSeen, Me.Count, Me.Antenna, Me.EventType})
        Me.dgvTagData.Location = New System.Drawing.Point(13, 215)
        Me.dgvTagData.Name = "dgvTagData"
        Me.dgvTagData.ReadOnly = True
        Me.dgvTagData.RowTemplate.ReadOnly = True
        Me.dgvTagData.Size = New System.Drawing.Size(603, 162)
        Me.dgvTagData.TabIndex = 4
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 30
        '
        'EPC
        '
        Me.EPC.HeaderText = "EPC (HEX)"
        Me.EPC.Name = "EPC"
        Me.EPC.ReadOnly = True
        Me.EPC.Width = 150
        '
        'ASCII
        '
        Me.ASCII.HeaderText = "EPC (ASCII)"
        Me.ASCII.Name = "ASCII"
        Me.ASCII.ReadOnly = True
        '
        'RSSI
        '
        Me.RSSI.HeaderText = "RSSI"
        Me.RSSI.Name = "RSSI"
        Me.RSSI.ReadOnly = True
        Me.RSSI.Width = 40
        '
        'FirstSeen
        '
        Me.FirstSeen.HeaderText = "First Seen"
        Me.FirstSeen.Name = "FirstSeen"
        Me.FirstSeen.ReadOnly = True
        '
        'LastSeen
        '
        Me.LastSeen.HeaderText = "Last Seen"
        Me.LastSeen.Name = "LastSeen"
        Me.LastSeen.ReadOnly = True
        '
        'Count
        '
        Me.Count.HeaderText = "Count"
        Me.Count.Name = "Count"
        Me.Count.ReadOnly = True
        Me.Count.Width = 50
        '
        'Antenna
        '
        Me.Antenna.HeaderText = "Antenna"
        Me.Antenna.Name = "Antenna"
        Me.Antenna.ReadOnly = True
        Me.Antenna.Width = 50
        '
        'EventType
        '
        Me.EventType.HeaderText = "Event"
        Me.EventType.Name = "EventType"
        Me.EventType.ReadOnly = True
        '
        'lbReaderIP
        '
        Me.lbReaderIP.AutoSize = True
        Me.lbReaderIP.Location = New System.Drawing.Point(13, 14)
        Me.lbReaderIP.Name = "lbReaderIP"
        Me.lbReaderIP.Size = New System.Drawing.Size(158, 13)
        Me.lbReaderIP.TabIndex = 5
        Me.lbReaderIP.Text = "Reader Hostname / IP Address "
        '
        'pnlSettings
        '
        Me.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSettings.Controls.Add(Me.nudFOVTimeout)
        Me.pnlSettings.Controls.Add(Me.lblFOVTimeout)
        Me.pnlSettings.Controls.Add(Me.nudDuration)
        Me.pnlSettings.Controls.Add(Me.lblStopTagDetection)
        Me.pnlSettings.Controls.Add(Me.nudPeriod)
        Me.pnlSettings.Controls.Add(Me.lblTagDetectionPeriod)
        Me.pnlSettings.Location = New System.Drawing.Point(330, 70)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(283, 134)
        Me.pnlSettings.TabIndex = 6
        '
        'nudFOVTimeout
        '
        Me.nudFOVTimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFOVTimeout.Location = New System.Drawing.Point(234, 73)
        Me.nudFOVTimeout.Name = "nudFOVTimeout"
        Me.nudFOVTimeout.Size = New System.Drawing.Size(38, 22)
        Me.nudFOVTimeout.TabIndex = 8
        Me.nudFOVTimeout.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblFOVTimeout
        '
        Me.lblFOVTimeout.AutoSize = True
        Me.lblFOVTimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFOVTimeout.Location = New System.Drawing.Point(8, 72)
        Me.lblFOVTimeout.Name = "lblFOVTimeout"
        Me.lblFOVTimeout.Size = New System.Drawing.Size(87, 16)
        Me.lblFOVTimeout.TabIndex = 7
        Me.lblFOVTimeout.Tag = ""
        Me.lblFOVTimeout.Text = "FOV Timeout"
        '
        'nudDuration
        '
        Me.nudDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDuration.Location = New System.Drawing.Point(234, 44)
        Me.nudDuration.Name = "nudDuration"
        Me.nudDuration.Size = New System.Drawing.Size(38, 22)
        Me.nudDuration.TabIndex = 6
        Me.nudDuration.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStopTagDetection
        '
        Me.lblStopTagDetection.AutoSize = True
        Me.lblStopTagDetection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopTagDetection.Location = New System.Drawing.Point(8, 46)
        Me.lblStopTagDetection.Name = "lblStopTagDetection"
        Me.lblStopTagDetection.Size = New System.Drawing.Size(161, 16)
        Me.lblStopTagDetection.TabIndex = 5
        Me.lblStopTagDetection.Tag = ""
        Me.lblStopTagDetection.Text = "Detect Tag for N seconds"
        '
        'nudPeriod
        '
        Me.nudPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPeriod.Location = New System.Drawing.Point(234, 15)
        Me.nudPeriod.Name = "nudPeriod"
        Me.nudPeriod.Size = New System.Drawing.Size(38, 22)
        Me.nudPeriod.TabIndex = 4
        Me.nudPeriod.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblTagDetectionPeriod
        '
        Me.lblTagDetectionPeriod.AutoSize = True
        Me.lblTagDetectionPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagDetectionPeriod.Location = New System.Drawing.Point(8, 18)
        Me.lblTagDetectionPeriod.Name = "lblTagDetectionPeriod"
        Me.lblTagDetectionPeriod.Size = New System.Drawing.Size(226, 16)
        Me.lblTagDetectionPeriod.TabIndex = 0
        Me.lblTagDetectionPeriod.Text = "Start Tag detection every N seconds"
        '
        'txtInputPort
        '
        Me.txtInputPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputPort.Location = New System.Drawing.Point(186, 32)
        Me.txtInputPort.Name = "txtInputPort"
        Me.txtInputPort.Size = New System.Drawing.Size(45, 22)
        Me.txtInputPort.TabIndex = 7
        Me.txtInputPort.Text = "5084"
        '
        'lblReaderPort
        '
        Me.lblReaderPort.AutoSize = True
        Me.lblReaderPort.Location = New System.Drawing.Point(186, 13)
        Me.lblReaderPort.Name = "lblReaderPort"
        Me.lblReaderPort.Size = New System.Drawing.Size(26, 13)
        Me.lblReaderPort.TabIndex = 8
        Me.lblReaderPort.Text = "Port"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 389)
        Me.Controls.Add(Me.lblReaderPort)
        Me.Controls.Add(Me.txtInputPort)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.lbReaderIP)
        Me.Controls.Add(Me.dgvTagData)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtInputHost)
        Me.Controls.Add(Me.pnlProperties)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmMain"
        Me.Text = "RFID Reader App"
        Me.pnlProperties.ResumeLayout(False)
        Me.pnlProperties.PerformLayout()
        CType(Me.dgvTagData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        CType(Me.nudFOVTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlProperties As Panel
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents txtModelName As TextBox
    Friend WithEvents txtFWVersion As TextBox
    Friend WithEvents txtHostName As TextBox
    Friend WithEvents lblReaderID As Label
    Friend WithEvents lblModelName As Label
    Friend WithEvents lblFWVersion As Label
    Friend WithEvents lblHostName As Label
    Friend WithEvents txtInputHost As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents dgvTagData As DataGridView
    Friend WithEvents lbReaderIP As Label
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents lblTagDetectionPeriod As Label
    Friend WithEvents nudPeriod As NumericUpDown
    Friend WithEvents nudDuration As NumericUpDown
    Friend WithEvents lblStopTagDetection As Label
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents EPC As DataGridViewTextBoxColumn
    Friend WithEvents ASCII As DataGridViewTextBoxColumn
    Friend WithEvents RSSI As DataGridViewTextBoxColumn
    Friend WithEvents FirstSeen As DataGridViewTextBoxColumn
    Friend WithEvents LastSeen As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
    Friend WithEvents Antenna As DataGridViewTextBoxColumn
    Friend WithEvents EventType As DataGridViewTextBoxColumn
    Friend WithEvents txtInputPort As TextBox
    Friend WithEvents lblReaderPort As Label
    Friend WithEvents nudFOVTimeout As NumericUpDown
    Friend WithEvents lblFOVTimeout As Label
End Class
