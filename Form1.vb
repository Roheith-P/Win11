Imports CefSharp
Imports CefSharp.WinForms

Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private WithEvents browser As ChromiumWebBrowser
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim setting As New CefSettings
        setting.RemoteDebuggingPort = 8088
        CefSharp.Cef.Initialize(setting)
        browser = New ChromiumWebBrowser("https://win11.blueedge.me/") With {
            .Dock = DockStyle.Fill
        }
        Panel1.Controls.Add(browser)
    End Sub
End Class
