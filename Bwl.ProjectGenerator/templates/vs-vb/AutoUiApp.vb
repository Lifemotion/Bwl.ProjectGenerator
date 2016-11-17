Imports Bwl.Framework

Public Module AutoUiApp
    Private _app As New AppBase
    Private _appForm As New AutoFormDescriptor(_app.AutoUI, "Form")
    Private WithEvents _autoButton As New AutoButton(_app.AutoUI, "Button")
    'Private WithEvents _autoTextbox As New AutoTextbox(_app.AutoUI, "Textbox")
    'Private WithEvents _autoListbox As New AutoListbox(_app.AutoUI, "Listbox")
    'Private WithEvents _autoBitmap As New AutoBitmap(_app.AutoUI, "Bitmap")

    Public Sub Main()
        Application.EnableVisualStyles()
        Application.Run(AutoUIForm.Create(_app))
    End Sub

    Private Sub _autoButton_Click(source As AutoButton) Handles _autoButton.Click
        _app.RootLogger.AddMessage("Button")
    End Sub
End Module
