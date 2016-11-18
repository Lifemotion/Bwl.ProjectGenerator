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
        Me.licenseApache = New System.Windows.Forms.RadioButton()
        Me.licenseNone = New System.Windows.Forms.RadioButton()
        Me.gbBasic = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.basicProjectPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.basicProjectAuthor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.basicProjectName = New System.Windows.Forms.TextBox()
        Me.gbVS = New System.Windows.Forms.GroupBox()
        Me.gbFormType = New System.Windows.Forms.GroupBox()
        Me.vsStandardForm = New System.Windows.Forms.RadioButton()
        Me.vsAutoUi = New System.Windows.Forms.RadioButton()
        Me.vsFormAppBase = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.vsBwlUniversalOrm = New System.Windows.Forms.CheckBox()
        Me.vsBwlVideo = New System.Windows.Forms.CheckBox()
        Me.vsBwlImaging = New System.Windows.Forms.CheckBox()
        Me.vsBwlHardwareSimplSerial = New System.Windows.Forms.CheckBox()
        Me.vsBwlHardwareSerial = New System.Windows.Forms.CheckBox()
        Me.vsBwlNetworkTransport = New System.Windows.Forms.CheckBox()
        Me.vsBwlFramework = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.vsFw45 = New System.Windows.Forms.RadioButton()
        Me.vsFw40 = New System.Windows.Forms.RadioButton()
        Me.vsLibraryConsole = New System.Windows.Forms.RadioButton()
        Me.vsLibraryTestGui = New System.Windows.Forms.RadioButton()
        Me.vsLibraryGui = New System.Windows.Forms.RadioButton()
        Me.vsConsole = New System.Windows.Forms.RadioButton()
        Me.vsGui = New System.Windows.Forms.RadioButton()
        Me.vsNone = New System.Windows.Forms.RadioButton()
        Me.gbAS = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.asBwlIr = New System.Windows.Forms.CheckBox()
        Me.asBwlSpi = New System.Windows.Forms.CheckBox()
        Me.asBwlI2c = New System.Windows.Forms.CheckBox()
        Me.asBwlAdc = New System.Windows.Forms.CheckBox()
        Me.asBwlSimplSerial = New System.Windows.Forms.CheckBox()
        Me.asBwlUart = New System.Windows.Forms.CheckBox()
        Me.asBwlTools = New System.Windows.Forms.CheckBox()
        Me.asBwlStrings = New System.Windows.Forms.CheckBox()
        Me.asProjectC = New System.Windows.Forms.RadioButton()
        Me.asNone = New System.Windows.Forms.RadioButton()
        Me.bGenerate = New System.Windows.Forms.Button()
        Me.bUpdateRepos = New System.Windows.Forms.Button()
        Me.gbLicense.SuspendLayout()
        Me.gbBasic.SuspendLayout()
        Me.gbVS.SuspendLayout()
        Me.gbFormType.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.basicProjectPath.Text = "C:\Users\heart\Desktop\test"
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
        Me.basicProjectAuthor.Text = "Cat Max"
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
        'basicProjectName
        '
        Me.basicProjectName.Location = New System.Drawing.Point(94, 19)
        Me.basicProjectName.Name = "basicProjectName"
        Me.basicProjectName.Size = New System.Drawing.Size(215, 20)
        Me.basicProjectName.TabIndex = 0
        Me.basicProjectName.Text = "Bwl.ImgTest"
        '
        'gbVS
        '
        Me.gbVS.Controls.Add(Me.gbFormType)
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
        'gbFormType
        '
        Me.gbFormType.Controls.Add(Me.vsStandardForm)
        Me.gbFormType.Controls.Add(Me.vsAutoUi)
        Me.gbFormType.Controls.Add(Me.vsFormAppBase)
        Me.gbFormType.Location = New System.Drawing.Point(9, 220)
        Me.gbFormType.Name = "gbFormType"
        Me.gbFormType.Size = New System.Drawing.Size(199, 75)
        Me.gbFormType.TabIndex = 9
        Me.gbFormType.TabStop = False
        Me.gbFormType.Text = "Gui Type"
        '
        'vsStandardForm
        '
        Me.vsStandardForm.AutoSize = True
        Me.vsStandardForm.Location = New System.Drawing.Point(6, 19)
        Me.vsStandardForm.Name = "vsStandardForm"
        Me.vsStandardForm.Size = New System.Drawing.Size(94, 17)
        Me.vsStandardForm.TabIndex = 4
        Me.vsStandardForm.Text = "Standard Form"
        Me.vsStandardForm.UseVisualStyleBackColor = True
        '
        'vsAutoUi
        '
        Me.vsAutoUi.AutoSize = True
        Me.vsAutoUi.Location = New System.Drawing.Point(103, 42)
        Me.vsAutoUi.Name = "vsAutoUi"
        Me.vsAutoUi.Size = New System.Drawing.Size(58, 17)
        Me.vsAutoUi.TabIndex = 3
        Me.vsAutoUi.Text = "AutoUI"
        Me.vsAutoUi.UseVisualStyleBackColor = True
        '
        'vsFormAppBase
        '
        Me.vsFormAppBase.AutoSize = True
        Me.vsFormAppBase.Checked = True
        Me.vsFormAppBase.Location = New System.Drawing.Point(6, 42)
        Me.vsFormAppBase.Name = "vsFormAppBase"
        Me.vsFormAppBase.Size = New System.Drawing.Size(91, 17)
        Me.vsFormAppBase.TabIndex = 2
        Me.vsFormAppBase.TabStop = True
        Me.vsFormAppBase.Text = "FormAppBase"
        Me.vsFormAppBase.UseVisualStyleBackColor = True
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
        'vsFw40
        '
        Me.vsFw40.AutoSize = True
        Me.vsFw40.Enabled = False
        Me.vsFw40.Location = New System.Drawing.Point(6, 19)
        Me.vsFw40.Name = "vsFw40"
        Me.vsFw40.Size = New System.Drawing.Size(40, 17)
        Me.vsFw40.TabIndex = 2
        Me.vsFw40.Text = "4.0"
        Me.vsFw40.UseVisualStyleBackColor = True
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
        Me.GroupBox9.Controls.Add(Me.asBwlIr)
        Me.GroupBox9.Controls.Add(Me.asBwlSpi)
        Me.GroupBox9.Controls.Add(Me.asBwlI2c)
        Me.GroupBox9.Controls.Add(Me.asBwlAdc)
        Me.GroupBox9.Controls.Add(Me.asBwlSimplSerial)
        Me.GroupBox9.Controls.Add(Me.asBwlUart)
        Me.GroupBox9.Controls.Add(Me.asBwlTools)
        Me.GroupBox9.Controls.Add(Me.asBwlStrings)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 65)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(198, 248)
        Me.GroupBox9.TabIndex = 8
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "References"
        '
        'asBwlIr
        '
        Me.asBwlIr.AutoSize = True
        Me.asBwlIr.Location = New System.Drawing.Point(10, 180)
        Me.asBwlIr.Name = "asBwlIr"
        Me.asBwlIr.Size = New System.Drawing.Size(53, 17)
        Me.asBwlIr.TabIndex = 8
        Me.asBwlIr.Text = "bwl_ir"
        Me.asBwlIr.UseVisualStyleBackColor = True
        '
        'asBwlSpi
        '
        Me.asBwlSpi.AutoSize = True
        Me.asBwlSpi.Enabled = False
        Me.asBwlSpi.Location = New System.Drawing.Point(10, 157)
        Me.asBwlSpi.Name = "asBwlSpi"
        Me.asBwlSpi.Size = New System.Drawing.Size(61, 17)
        Me.asBwlSpi.TabIndex = 7
        Me.asBwlSpi.Text = "bwl_spi"
        Me.asBwlSpi.UseVisualStyleBackColor = True
        '
        'asBwlI2c
        '
        Me.asBwlI2c.AutoSize = True
        Me.asBwlI2c.Location = New System.Drawing.Point(10, 134)
        Me.asBwlI2c.Name = "asBwlI2c"
        Me.asBwlI2c.Size = New System.Drawing.Size(62, 17)
        Me.asBwlI2c.TabIndex = 6
        Me.asBwlI2c.Text = "bwl_i2c"
        Me.asBwlI2c.UseVisualStyleBackColor = True
        '
        'asBwlAdc
        '
        Me.asBwlAdc.AutoSize = True
        Me.asBwlAdc.Location = New System.Drawing.Point(10, 111)
        Me.asBwlAdc.Name = "asBwlAdc"
        Me.asBwlAdc.Size = New System.Drawing.Size(66, 17)
        Me.asBwlAdc.TabIndex = 5
        Me.asBwlAdc.Text = "bwl_adc"
        Me.asBwlAdc.UseVisualStyleBackColor = True
        '
        'asBwlSimplSerial
        '
        Me.asBwlSimplSerial.AutoSize = True
        Me.asBwlSimplSerial.Location = New System.Drawing.Point(10, 88)
        Me.asBwlSimplSerial.Name = "asBwlSimplSerial"
        Me.asBwlSimplSerial.Size = New System.Drawing.Size(95, 17)
        Me.asBwlSimplSerial.TabIndex = 4
        Me.asBwlSimplSerial.Text = "bwl_simplserial"
        Me.asBwlSimplSerial.UseVisualStyleBackColor = True
        '
        'asBwlUart
        '
        Me.asBwlUart.AutoSize = True
        Me.asBwlUart.Checked = True
        Me.asBwlUart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.asBwlUart.Location = New System.Drawing.Point(10, 65)
        Me.asBwlUart.Name = "asBwlUart"
        Me.asBwlUart.Size = New System.Drawing.Size(66, 17)
        Me.asBwlUart.TabIndex = 3
        Me.asBwlUart.Text = "bwl_uart"
        Me.asBwlUart.UseVisualStyleBackColor = True
        '
        'asBwlTools
        '
        Me.asBwlTools.AutoSize = True
        Me.asBwlTools.Checked = True
        Me.asBwlTools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.asBwlTools.Location = New System.Drawing.Point(10, 42)
        Me.asBwlTools.Name = "asBwlTools"
        Me.asBwlTools.Size = New System.Drawing.Size(70, 17)
        Me.asBwlTools.TabIndex = 2
        Me.asBwlTools.Text = "bwl_tools"
        Me.asBwlTools.UseVisualStyleBackColor = True
        '
        'asBwlStrings
        '
        Me.asBwlStrings.AutoSize = True
        Me.asBwlStrings.Checked = True
        Me.asBwlStrings.CheckState = System.Windows.Forms.CheckState.Checked
        Me.asBwlStrings.Location = New System.Drawing.Point(10, 19)
        Me.asBwlStrings.Name = "asBwlStrings"
        Me.asBwlStrings.Size = New System.Drawing.Size(78, 17)
        Me.asBwlStrings.TabIndex = 0
        Me.asBwlStrings.Text = "bwl_strings"
        Me.asBwlStrings.UseVisualStyleBackColor = True
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
        'bGenerate
        '
        Me.bGenerate.Location = New System.Drawing.Point(953, 33)
        Me.bGenerate.Name = "bGenerate"
        Me.bGenerate.Size = New System.Drawing.Size(75, 69)
        Me.bGenerate.TabIndex = 6
        Me.bGenerate.Text = "Generate"
        Me.bGenerate.UseVisualStyleBackColor = True
        '
        'bUpdateRepos
        '
        Me.bUpdateRepos.Location = New System.Drawing.Point(953, 403)
        Me.bUpdateRepos.Name = "bUpdateRepos"
        Me.bUpdateRepos.Size = New System.Drawing.Size(75, 69)
        Me.bUpdateRepos.TabIndex = 7
        Me.bUpdateRepos.Text = "Update Repositories"
        Me.bUpdateRepos.UseVisualStyleBackColor = True
        '
        'ProjectGeneratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 677)
        Me.Controls.Add(Me.bUpdateRepos)
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
        Me.Controls.SetChildIndex(Me.bUpdateRepos, 0)
        Me.gbLicense.ResumeLayout(False)
        Me.gbLicense.PerformLayout()
        Me.gbBasic.ResumeLayout(False)
        Me.gbBasic.PerformLayout()
        Me.gbVS.ResumeLayout(False)
        Me.gbVS.PerformLayout()
        Me.gbFormType.ResumeLayout(False)
        Me.gbFormType.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
    Friend WithEvents gbFormType As GroupBox
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
    Friend WithEvents asBwlIr As CheckBox
    Friend WithEvents asBwlSpi As CheckBox
    Friend WithEvents asBwlI2c As CheckBox
    Friend WithEvents asBwlAdc As CheckBox
    Friend WithEvents asBwlSimplSerial As CheckBox
    Friend WithEvents asBwlUart As CheckBox
    Friend WithEvents asBwlTools As CheckBox
    Friend WithEvents asBwlStrings As CheckBox
    Friend WithEvents asProjectC As RadioButton
    Friend WithEvents asNone As RadioButton
    Friend WithEvents bGenerate As Button
    Friend WithEvents vsStandardForm As RadioButton
    Friend WithEvents bUpdateRepos As Button
End Class
