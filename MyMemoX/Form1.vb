Public Class Form1
  Const ApplicationName = "MyMemo"

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Text = ApplicationName
    TextBoxMain.Multiline = True
    TextBoxMain.ScrollBars = ScrollBars.Vertical
    TextBoxMain.Dock = DockStyle.Fill
  End Sub

  Private Sub MenuItemExit_Click(sender As Object, e As EventArgs) Handles MenuItemExit.Click
    Me.Close()
  End Sub

  Private Sub MenuItemFileOpen_Click(sender As Object, e As EventArgs) Handles MenuItemFileOpen.Click
    OpenFileDialog1.FileName = ""
    OpenFileDialog1.ShowDialog()
    loadfile(OpenFileDialog1.FileName)
  End Sub

  Private Sub LoadFile(value As String)
    TextBoxMain.Text = System.IO.File.ReadAllText(value, System.Text.Encoding.GetEncoding("Shift_JIS"))
  End Sub

End Class
