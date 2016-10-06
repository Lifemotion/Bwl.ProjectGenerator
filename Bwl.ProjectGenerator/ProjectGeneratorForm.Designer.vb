<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectGeneratorForm

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbLicense = New System.Windows.Forms.GroupBox()
        Me.licenseNone = New System.Windows.Forms.RadioButton()
        Me.gbBasic = New System.Windows.Forms.GroupBox()
        Me.basicProjectName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.basicProjectAuthor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.basicProjectPath = New System.Windows.Forms.TextBox()
        Me.licenseApache = New System.Windows.Forms.RadioButton()
        Me.gbVS = New System.Windows.Forms.GroupBox()
        Me.vsNone = New System.Windows.Forms.RadioButton()
        Me.vsGui = New System.Windows.Forms.RadioButton()
        Me.vsConsole = New System.Windows.Forms.RadioButton()
        Me.vsLibraryTestGui = New System.Windows.Forms.RadioButton()
        Me.vsLibraryGui = New System.Windows.Forms.RadioButton()
        Me.vsLibraryConsole = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.vsFw40 = New System.Windows.Forms.RadioButton()
        Me.vsFw45 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.vsFormAppBase = New System.Windows.Forms.RadioButton()
        Me.vsAutoUi = New System.Windows.Forms.RadioButton()
        Me.vsBwlFramework = New System.Windows.Forms.CheckBox()
        Me.vsBwlNetworkTransport = New System.Windows.Forms.CheckBox()
        Me.vsBwlHardwareSerial = New System.Windows.Forms.CheckBox()
        Me.vsBwlHardwareSimplSerial = New System.Windows.Forms.CheckBox()
        Me.vsBwlImaging = New System.Windows.Forms.CheckBox()
        Me.vsBwlVideo = New System.Windows.Forms.CheckBox()
        Me.vsBwlUniversalOrm = New System.Windows.Forms.CheckBox()
        Me.gbAS = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.asProjectC = New System.Windows.Forms.RadioButton()
        Me.asNone = New System.Windows.Forms.RadioButton()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.bGenerate = New System.Windows.Forms.Button()
        Me.gbLicense.SuspendLayout()
        Me.gbBasic.SuspendLayout()
        Me.gbVS.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.gbAS.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.Location = New System.Drawing.Point(2, 475)
        Me.logWriter.Size = New System.Drawing.Size(1036, 201)
        '
        'gbLicense
        '
        Me.gbLicense.Controls.Add(Me.licenseApache)
        Me.gbLicense.Controls.Add(Me.licenseNone)
        Me.gbLicense.Location = New System.Drawing.Point(812, 108)
        Me.gbLicense.Name = "gbLicense"
        Me.gbLicense.Size = New System.Drawing.Size(215, 66)
        Me.gbLicense.TabIndex = 2
        Me.gbLicense.TabStop = False
        Me.gbLicense.Text = "License"
        '
        'licenseNone
        '
        Me.licenseNone.AutoSize = True
        Me.licenseNone.Location = New System.Drawing.Point(6, 19)
        Me.licenseNone.Name = "licenseNone"
        Me.licenseNone.Size = New System.Drawing.Size(55, 17)
        Me.licenseNone.TabIndex = 0
        Me.licenseNone.Text = "(none)"
        Me.licenseNone.UseVisualStyleBackColor = True
        '
        'gbBasic
        '
        Me.gbBasic.Controls.Add(Me.Label3)
        Me.gbBasic.Controls.Add(Me.basicProjectPath)
        Me.gbBasic.Controls.Add(Me.Label2)
        Me.gbBasic.Controls.Add(Me.basicProjectAuthor)
        Me.gbBasic.Controls.Add(Me.Label1)
        Me.gbBasic.Controls.Add(Me.basicProjectName)
        Me.gbBasic.Location = New System.Drawing.Point(12, 27)
        Me.gbBasic.Name = "gbBasic"
        Me.gbBasic.Size = New System.Drawing.Size(933, 75)
        Me.gbBasic.TabIndex = 3
        Me.gbBasic.TabStop = False
        Me.gbBasic.Text = "Basic"
        '
        'basicProjectName
        '
        Me.basicProjectName.Location = New System.Drawing.Point(94, 19)
        Me.basicProjectName.Name = "basicProjectName"
        Me.basicProjectName.Size = New System.Drawing.Size(215, 20)
        Me.basicProjectName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Project Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Project Author"
        '
        'basicProjectAuthor
        '
        Me.basicProjectAuthor.Location = New System.Drawing.Point(403, 19)
        Me.basicProjectAuthor.Name = "basicProjectAuthor"
        Me.basicProjectAuthor.Size = New System.Drawing.Size(215, 20)
        Me.basicProjectAuthor.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Project Path"
        '
        'basicProjectPath
        '
        Me.basicProjectPath.Location = New System.Drawing.Point(94, 46)
        Me.basicProjectPath.Name = "basicProjectPath"
        Me.basicProjectPath.Size = New System.Drawing.Size(830, 20)
        Me.basicProjectPath.TabIndex = 4
        '
        'licenseApache
        '
        Me.licenseApache.AutoSize = True
        Me.licenseApache.Checked = True
        Me.licenseApache.Location = New System.Drawing.Point(6, 42)
        Me.licenseApache.Name = "licenseApache"
        Me.licenseApache.Size = New System.Drawing.Size(80, 17)
        Me.licenseApache.TabIndex = 1
        Me.licenseApache.TabStop = True
        Me.licenseApache.Text = "Apache 2.0"
        Me.licenseApache.UseVisualStyleBackColor = True
        '
        'gbVS
        '
        Me.gbVS.Controls.Add(Me.GroupBox6)
        Me.gbVS.Controls.Add(Me.GroupBox5)
        Me.gbVS.Controls.Add(Me.GroupBox4)
        Me.gbVS.Controls.Add(Me.vsLibraryConsole)
        Me.gbVS.Controls.Add(Me.vsLibraryTestGui)
        Me.gbVS.Controls.Add(Me.vsLibraryGui)
        Me.gbVS.Controls.Add(Me.vsConsole)
        Me.gbVS.Controls.Add(Me.vsGui)
        Me.gbVS.Controls.Add(Me.vsNone)
        Me.gbVS.Location = New System.Drawing.Point(12, 108)
        Me.gbVS.Name = "gbVS"
        Me.gbVS.Size = New System.Drawing.Size(425, 364)
        Me.gbVS.TabIndex = 4
        Me.gbVS.TabStop = False
        Me.gbVS.Text = "Visual Studio Projects"
        '
        'vsNone
        '
        Me.vsNone.AutoSize = True
        Me.vsNone.Location = New System.Drawing.Point(6, 19)
        Me.vsNone.Name = "vsNone"
        Me.vsNone.Size = New System.Drawing.Size(55, 17)
        Me.vsNone.TabIndex = 1
        Me.vsNone.Text = "(none)"
        Me.vsNone.UseVisualStyleBackColor = True
        '
        'vsGui
        '
        Me.vsGui.AutoSize = True
        Me.vsGui.Checked = True
        Me.vsGui.Location = New System.Drawing.Point(6, 42)
        Me.vsGui.Name = "vsGui"
        Me.vsGui.Size = New System.Drawing.Size(63, 17)
        Me.vsGui.TabIndex = 2
        Me.vsGui.TabStop = True
        Me.vsGui.Text = "Gui App"
        Me.vsGui.UseVisualStyleBackColor = True
        '
        'vsConsole
        '
        Me.vsConsole.AutoSize = True
        Me.vsConsole.Location = New System.Drawing.Point(6, 65)
        Me.vsConsole.Name = "vsConsole"
        Me.vsConsole.Size = New System.Drawing.Size(85, 17)
        Me.vsConsole.TabIndex = 3
        Me.vsConsole.Text = "Console App"
        Me.vsConsole.UseVisualStyleBackColor = True
        '
        'vsLibraryTestGui
        '
        Me.vsLibraryTestGui.AutoSize = True
        Me.vsLibraryTestGui.Location = New System.Drawing.Point(6, 111)
        Me.vsLibraryTestGui.Name = "vsLibraryTestGui"
        Me.vsLibraryTestGui.Size = New System.Drawing.Size(130, 17)
        Me.vsLibraryTestGui.TabIndex = 5
        Me.vsLibraryTestGui.Text = "Library + Test Gui App"
        Me.vsLibraryTestGui.UseVisualStyleBackColor = True
        '
        'vsLibraryGui
        '
        Me.vsLibraryGui.AutoSize = True
        Me.vsLibraryGui.Location = New System.Drawing.Point(6, 88)
        Me.vsLibraryGui.Name = "vsLibraryGui"
        Me.vsLibraryGui.Size = New System.Drawing.Size(106, 17)
        Me.vsLibraryGui.TabIndex = 4
        Me.vsLibraryGui.Text = "Library + Gui App"
        Me.vsLibraryGui.UseVisualStyleBackColor = True
        '
        'vsLibraryConsole
        '
        Me.vsLibraryConsole.AutoSize = True
        Me.vsLibraryConsole.Location = New System.Drawing.Point(6, 134)
        Me.vsLibraryConsole.Name = "vsLibraryConsole"
        Me.vsLibraryConsole.Size = New System.Drawing.Size(128, 17)
        Me.vsLibraryConsole.TabIndex = 6
        Me.vsLibraryConsole.Text = "Library + Console App"
        Me.vsLibraryConsole.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.vsFw45)
        Me.GroupBox4.Controls.Add(Me.vsFw40)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 167)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(199, 47)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Framework"
        '
        'vsFw40
        '
        Me.vsFw40.AutoSize = True
        Me.vsFw40.Location = New System.Drawing.Point(6, 19)
        Me.vsFw40.Name = "vsFw40"
        Me.vsFw40.Size = New System.Drawing.Size(40, 17)
        Me.vsFw40.TabIndex = 2
        Me.vsFw40.Text = "4.0"
        Me.vsFw40.UseVisualStyleBackColor = True
        '
        'vsFw45
        '
        Me.vsFw45.AutoSize = True
        Me.vsFw45.Checked = True
        Me.vsFw45.Location = New System.Drawing.Point(52, 19)
        Me.vsFw45.Name = "vsFw45"
        Me.vsFw45.Size = New System.Drawing.Size(40, 17)
        Me.vsFw45.TabIndex = 3
        Me.vsFw45.TabStop = True
        Me.vsFw45.Text = "4.5"
        Me.vsFw45.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.vsBwlUniversalOrm)
        Me.GroupBox5.Controls.Add(Me.vsBwlVideo)
        Me.GroupBox5.Controls.Add(Me.vsBwlImaging)
        Me.GroupBox5.Controls.Add(Me.vsBwlHardwareSimplSerial)
        Me.GroupBox5.Controls.Add(Me.vsBwlHardwareSerial)
        Me.GroupBox5.Controls.Add(Me.vsBwlNetworkTransport)
        Me.GroupBox5.Controls.Add(Me.vsBwlFramework)
        Me.GroupBox5.Location = New System.Drawing.Point(218, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(198, 195)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "References"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.vsAutoUi)
        Me.GroupBox6.Controls.Add(Me.vsFormAppBase)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 220)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(199, 47)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Gui Type"
        '
        'vsFormAppBase
        '
        Me.vsFormAppBase.AutoSize = True
        Me.vsFormAppBase.Checked = True
        Me.vsFormAppBase.Location = New System.Drawing.Point(6, 19)
        Me.vsFormAppBase.Name = "vsFormAppBase"
        Me.vsFormAppBase.Size = New System.Drawing.Size(91, 17)
        Me.vsFormAppBase.TabIndex = 2
        Me.vsFormAppBase.TabStop = True
        Me.vsFormAppBase.Text = "FormAppBase"
        Me.vsFormAppBase.UseVisualStyleBackColor = True
        '
        'vsAutoUi
        '
        Me.vsAutoUi.AutoSize = True
        Me.vsAutoUi.Location = New System.Drawing.Point(102, 19)
        Me.vsAutoUi.Name = "vsAutoUi"
        Me.vsAutoUi.Size = New System.Drawing.Size(58, 17)
        Me.vsAutoUi.TabIndex = 3
        Me.vsAutoUi.Text = "AutoUI"
        Me.vsAutoUi.UseVisualStyleBackColor = True
        '
        'vsBwlFramework
        '
        Me.vsBwlFramework.AutoSize = True
        Me.vsBwlFramework.Checked = True
        Me.vsBwlFramework.CheckState = System.Windows.Forms.CheckState.Checked
        Me.vsBwlFramework.Enabled = False
        Me.vsBwlFramework.Location = New System.Drawing.Point(10, 19)
        Me.vsBwlFramework.Name = "vsBwlFramework"
        Me.vsBwlFramework.Size = New System.Drawing.Size(98, 17)
        Me.vsBwlFramework.TabIndex = 0
        Me.vsBwlFramework.Text = "Bwl.Framework"
        Me.vsBwlFramework.UseVisualStyleBackColor = True
        '
        'vsBwlNetworkTransport
        '
        Me.vsBwlNetworkTransport.AutoSize = True
        Me.vsBwlNetworkTransport.Location = New System.Drawing.Point(10, 42)
        Me.vsBwlNetworkTransport.Name = "vsBwlNetworkTransport"
        Me.vsBwlNetworkTransport.Size = New System.Drawing.Size(134, 17)
        Me.vsBwlNetworkTransport.TabIndex = 2
        Me.vsBwlNetworkTransport.Text = "Bwl.Network.Transport"
        Me.vsBwlNetworkTransport.UseVisualStyleBackColor = True
        '
        'vsBwlHardwareSerial
        '
        Me.vsBwlHardwareSerial.AutoSize = True
        Me.vsBwlHardwareSerial.Location = New System.Drawing.Point(10, 65)
        Me.vsBwlHardwareSerial.Name = "vsBwlHardwareSerial"
        Me.vsBwlHardwareSerial.Size = New System.Drawing.Size(121, 17)
        Me.vsBwlHardwareSerial.TabIndex = 3
        Me.vsBwlHardwareSerial.Text = "Bwl.Hardware.Serial"
        Me.vsBwlHardwareSerial.UseVisualStyleBackColor = True
        '
        'vsBwlHardwareSimplSerial
        '
        Me.vsBwlHardwareSimplSerial.AutoSize = True
        Me.vsBwlHardwareSimplSerial.Location = New System.Drawing.Point(10, 88)
        Me.vsBwlHardwareSimplSerial.Name = "vsBwlHardwareSimplSerial"
        Me.vsBwlHardwareSimplSerial.Size = New System.Drawing.Size(146, 17)
        Me.vsBwlHardwareSimplSerial.TabIndex = 4
        Me.vsBwlHardwareSimplSerial.Text = "Bwl.Hardware.SimplSerial"
        Me.vsBwlHardwareSimplSerial.UseVisualStyleBackColor = True
        '
        'vsBwlImaging
        '
        Me.vsBwlImaging.AutoSize = True
        Me.vsBwlImaging.Location = New System.Drawing.Point(10, 111)
        Me.vsBwlImaging.Name = "vsBwlImaging"
        Me.vsBwlImaging.Size = New System.Drawing.Size(83, 17)
        Me.vsBwlImaging.TabIndex = 5
        Me.vsBwlImaging.Text = "Bwl.Imaging"
        Me.vsBwlImaging.UseVisualStyleBackColor = True
        '
        'vsBwlVideo
        '
        Me.vsBwlVideo.AutoSize = True
        Me.vsBwlVideo.Location = New System.Drawing.Point(10, 134)
        Me.vsBwlVideo.Name = "vsBwlVideo"
        Me.vsBwlVideo.Size = New System.Drawing.Size(73, 17)
        Me.vsBwlVideo.TabIndex = 6
        Me.vsBwlVideo.Text = "Bwl.Video"
        Me.vsBwlVideo.UseVisualStyleBackColor = True
        '
        'vsBwlUniversalOrm
        '
        Me.vsBwlUniversalOrm.AutoSize = True
        Me.vsBwlUniversalOrm.Location = New System.Drawing.Point(10, 157)
        Me.vsBwlUniversalOrm.Name = "vsBwlUniversalOrm"
        Me.vsBwlUniversalOrm.Size = New System.Drawing.Size(115, 17)
        Me.vsBwlUniversalOrm.TabIndex = 7
        Me.vsBwlUniversalOrm.Text = "Bwl.UniversalORM"
        Me.vsBwlUniversalOrm.UseVisualStyleBackColor = True
        '
        'gbAS
        '
        Me.gbAS.Controls.Add(Me.GroupBox9)
        Me.gbAS.Controls.Add(Me.asProjectC)
        Me.gbAS.Controls.Add(Me.asNone)
        Me.gbAS.Location = New System.Drawing.Point(448, 108)
        Me.gbAS.Name = "gbAS"
        Me.gbAS.Size = New System.Drawing.Size(216, 364)
        Me.gbAS.TabIndex = 5
        Me.gbAS.TabStop = False
        Me.gbAS.Text = "Atmel Studio Project"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.CheckBox15)
        Me.GroupBox9.Controls.Add(Me.CheckBox8)
        Me.GroupBox9.Controls.Add(Me.CheckBox9)
        Me.GroupBox9.Controls.Add(Me.CheckBox10)
        Me.GroupBox9.Controls.Add(Me.CheckBox11)
        Me.GroupBox9.Controls.Add(Me.CheckBox12)
        Me.GroupBox9.Controls.Add(Me.CheckBox13)
        Me.GroupBox9.Controls.Add(Me.CheckBox14)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 65)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(198, 248)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "References"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(10, 157)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "bwl_spi"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(10, 134)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox9.TabIndex = 6
        Me.CheckBox9.Text = "bwl_i2c"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(10, 111)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox10.TabIndex = 5
        Me.CheckBox10.Text = "bwl_adc"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(10, 88)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox11.TabIndex = 4
        Me.CheckBox11.Text = "bwl_simplserial"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(10, 65)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(66, 17)
        Me.CheckBox12.TabIndex = 3
        Me.CheckBox12.Text = "bwl_uart"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(10, 42)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox13.TabIndex = 2
        Me.CheckBox13.Text = "bwl_tools"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(10, 19)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(78, 17)
        Me.CheckBox14.TabIndex = 0
        Me.CheckBox14.Text = "bwl_strings"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'asProjectC
        '
        Me.asProjectC.AutoSize = True
        Me.asProjectC.Location = New System.Drawing.Point(6, 42)
        Me.asProjectC.Name = "asProjectC"
        Me.asProjectC.Size = New System.Drawing.Size(97, 17)
        Me.asProjectC.TabIndex = 2
        Me.asProjectC.Text = "Atmel C Project"
        Me.asProjectC.UseVisualStyleBackColor = True
        '
        'asNone
        '
        Me.asNone.AutoSize = True
        Me.asNone.Checked = True
        Me.asNone.Location = New System.Drawing.Point(6, 19)
        Me.asNone.Name = "asNone"
        Me.asNone.Size = New System.Drawing.Size(55, 17)
        Me.asNone.TabIndex = 1
        Me.asNone.TabStop = True
        Me.asNone.Text = "(none)"
        Me.asNone.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(10, 180)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox15.TabIndex = 8
        Me.CheckBox15.Text = "bwl_ir"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'bGenerate
        '
        Me.bGenerate.Location = New System.Drawing.Point(953, 33)
        Me.bGenerate.Name = "bGenerate"
        Me.bGenerate.Size = New System.Drawing.Size(75, 69)
        Me.bGenerate.TabIndex = 6
        Me.bGenerate.Text = "Generate"
        Me.bGenerate.UseVisualStyleBackColor = True
        '
        'ProjectGeneratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 677)
        Me.Controls.Add(Me.bGenerate)
        Me.Controls.Add(Me.gbAS)
        Me.Controls.Add(Me.gbVS)
        Me.Controls.Add(Me.gbBasic)
        Me.Controls.Add(Me.gbLicense)
        Me.Name = "ProjectGeneratorForm"
        Me.Text = "Bwl Project Generator"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.gbLicense, 0)
        Me.Controls.SetChildIndex(Me.gbBasic, 0)
        Me.Controls.SetChildIndex(Me.gbVS, 0)
        Me.Controls.SetChildIndex(Me.gbAS, 0)
        Me.Controls.SetChildIndex(Me.bGenerate, 0)
        Me.gbLicense.ResumeLayout(False)
        Me.gbLicense.PerformLayout()
        Me.gbBasic.ResumeLayout(False)
        Me.gbBasic.PerformLayout()
        Me.gbVS.ResumeLayout(False)
        Me.gbVS.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.gbAS.ResumeLayout(False)
        Me.gbAS.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbLicense As GroupBox
    Friend WithEvents licenseNone As RadioButton
    Friend WithEvents gbBasic As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents basicProjectPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents basicProjectAuthor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents basicProjectName As TextBox
    Friend WithEvents licenseApache As RadioButton
    Friend WithEvents gbVS As GroupBox
    Friend WithEvents vsLibraryConsole As RadioButton
    Friend WithEvents vsLibraryTestGui As RadioButton
    Friend WithEvents vsLibraryGui As RadioButton
    Friend WithEvents vsConsole As RadioButton
    Friend WithEvents vsGui As RadioButton
    Friend WithEvents vsNone As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents vsFw45 As RadioButton
    Friend WithEvents vsFw40 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents vsAutoUi As RadioButton
    Friend WithEvents vsFormAppBase As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents vsBwlUniversalOrm As CheckBox
    Friend WithEvents vsBwlVideo As CheckBox
    Friend WithEvents vsBwlImaging As CheckBox
    Friend WithEvents vsBwlHardwareSimplSerial As CheckBox
    Friend WithEvents vsBwlHardwareSerial As CheckBox
    Friend WithEvents vsBwlNetworkTransport As CheckBox
    Friend WithEvents vsBwlFramework As CheckBox
    Friend WithEvents gbAS As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents asProjectC As RadioButton
    Friend WithEvents asNone As RadioButton
    Friend WithEvents bGenerate As Button
End Class
