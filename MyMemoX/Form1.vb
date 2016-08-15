Public Class Form1

  Private FileNameValue As String

  Private Property FileName As String
    Get
      Return FileNameValue
    End Get
    Set(value As String)
      FileNameValue = value
      Edited = False
    End Set
  End Property

  Private EditedValue As Boolean

  Private Property Edited As Boolean
    Get
      Return EditedValue
    End Get
    Set(value As Boolean)
      EditedValue = value
      UpdateStatus()
    End Set
  End Property

  Private Sub UpdateStatus()
    Dim s = ApplicationName
    If FileName <> "" Then
      s &= " - " & FileName
    End If
    If Edited Then s &= "(変更あり)"
    Me.Text = s

    If FileName = "" OrElse Not Edited OrElse TextBoxMain.TextLength = 0 Then
      MenuItemSave.Enabled = False
    Else
      MenuItemSave.Enabled = True
    End If

    If Not Edited OrElse TextBoxMain.TextLength = 0 Then
      MenuItemFileSaveAs.Enabled = False
    Else
      MenuItemFileSaveAs.Enabled = True
    End If
  End Sub

  Const ApplicationName = "MyMemo"


  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    FileName = ""
    TextBoxMain.Multiline = True
    TextBoxMain.ScrollBars = ScrollBars.Vertical
    TextBoxMain.Dock = DockStyle.Fill
    SaveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*"
  End Sub

  Private Sub MenuItemExit_Click(sender As Object, e As EventArgs) Handles MenuItemExit.Click
    Me.Close()
  End Sub

  Private Sub MenuItemFileOpen_Click(sender As Object, e As EventArgs) Handles MenuItemFileOpen.Click
    OpenFileDialog1.FileName = ""
    If DialogResult.OK = OpenFileDialog1.ShowDialog Then
      LoadFile(OpenFileDialog1.FileName)
      TextBoxMain.Select(0, 0)
    End If
  End Sub

  Private Sub LoadFile(value As String)
    TextBoxMain.Text = System.IO.File.ReadAllText(value, System.Text.Encoding.GetEncoding("Shift_JIS"))
    FileName = value
  End Sub

  Private Sub MenuItemFileSaveAs_Click(sender As Object, e As EventArgs) Handles MenuItemFileSaveAs.Click
    SaveFileDialog1.FileName = System.IO.Path.GetFileName(FileName)
    If DialogResult.OK = SaveFileDialog1.ShowDialog Then
      SaveFile(SaveFileDialog1.FileName)
    End If
  End Sub

  Private Sub SaveFile(value As String)
    System.IO.File.WriteAllText(value, TextBoxMain.Text, System.Text.Encoding.GetEncoding("Shift_JIS"))
    FileName = value
  End Sub

  Private Sub MenuItemSave_Click(sender As Object, e As EventArgs) Handles MenuItemSave.Click
    SaveFile(FileName)
  End Sub

  Private Sub TextBoxMain_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMain.TextChanged
    Edited = True
  End Sub

  Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    If Not AskGiveUpText() Then e.Cancel = True
  End Sub

  Private Function AskGiveUpText() As Boolean
    If Not Edited OrElse TextBoxMain.TextLength = 0 Then Return True
    If DialogResult.Yes = MessageBox.Show("編集内容を破棄しますか？", ApplicationName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
    If Not AskGiveUpText() Then Exit Sub
    TextBoxMain.Clear()
    FileName = ""
  End Sub
End Class
