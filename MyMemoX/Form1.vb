Public Class Form1
  Const ApplicationName = "MyMemo"
  Const RegistryKey As String = "Software\NikkeiSoftware\" & ApplicationName
  Private FilePath As String
  Private FileNameValue As String

  Private Property FileName As String
    Get
      Return FileNameValue
    End Get
    Set(value As String)
      FileNameValue = value
      If value <> "" Then
        FilePath = IO.Path.GetDirectoryName(value)
      End If
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

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    FileName = ""
    TextBoxMain.Multiline = True
    TextBoxMain.ScrollBars = ScrollBars.Vertical
    TextBoxMain.Dock = DockStyle.Fill
    SaveFileDialog1.Filter = "テキスト文書|*.txt|すべてのファイル|*.*"
    If 1 < Environment.GetCommandLineArgs.Length Then
      LoadFile(Environment.GetCommandLineArgs(1))
    End If
    Dim regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey)
    FilePath = regKey.GetValue("FilePath", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
    FontDialog1.ShowEffects = False
    FontDialog1.AllowScriptChange = False
    Dim name As String = regKey.GetValue("FontName", "ＭＳ ゴシック")
    Dim size As Integer = regKey.GetValue("FontSize", 12)
    Dim bold As String = regKey.GetValue("FontBold", False)
    Dim italic As String = regKey.GetValue("FontItalic", False)
    Dim style As FontStyle
    If bold Then style = FontStyle.Bold
    If italic Then style = style Or FontStyle.Italic
    TextBoxMain.Font = New Font(name, size, style)
    Const initialWidth = 400
    Const initialHeight = 200
    Me.MinimumSize = New Size(initialWidth, initialHeight)
    MenuItemEdit_DropDownOpening(sender, e)
  End Sub

  Private Sub MenuItemExit_Click(sender As Object, e As EventArgs) Handles MenuItemExit.Click
    Me.Close()
  End Sub

  Private Sub MenuItemFileOpen_Click(sender As Object, e As EventArgs) Handles MenuItemFileOpen.Click
    OpenFileDialog1.InitialDirectory = FilePath
    OpenFileDialog1.FileName = ""
    If DialogResult.OK = OpenFileDialog1.ShowDialog Then
      LoadFile(OpenFileDialog1.FileName)
      TextBoxMain.Select(0, 0)
    End If
  End Sub

  Private Sub LoadFile(value As String)
    If System.IO.File.Exists(value) Then
      TextBoxMain.Text = System.IO.File.ReadAllText(value, System.Text.Encoding.GetEncoding("Shift_JIS"))
      TextBoxMain.Select(0, 0)
      FileName = value
    Else
      MessageBox.Show(value & "が見つかりません", ApplicationName)
    End If
    TextBoxMain.Text = System.IO.File.ReadAllText(value, System.Text.Encoding.GetEncoding("Shift_JIS"))
    FileName = value
  End Sub

  Private Sub MenuItemFileSaveAs_Click(sender As Object, e As EventArgs) Handles MenuItemFileSaveAs.Click
    SaveFileDialog1.InitialDirectory = FilePath
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

  Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Dim regKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegistryKey)
    regKey.SetValue("FilePath", FilePath)
    regKey.SetValue("FontName", TextBoxMain.Font.Name)
    regKey.SetValue("FontSize", TextBoxMain.Font.Size)
    regKey.SetValue("FontBold", TextBoxMain.Font.Bold)
    regKey.SetValue("FontItalic", TextBoxMain.Font.Italic)
  End Sub

  Private Sub MenuItemSettingFont_Click(sender As Object, e As EventArgs) Handles MenuItemSettingFont.Click
    FontDialog1.Font = TextBoxMain.Font
    If DialogResult.OK = FontDialog1.ShowDialog() Then
      TextBoxMain.Font = FontDialog1.Font
    End If
  End Sub

  Private Sub MenuItemEditUndo_Click(sender As Object, e As EventArgs) Handles MenuItemEditUndo.Click
    TextBoxMain.Undo()
  End Sub

  Private Sub MenuItemEditCut_Click(sender As Object, e As EventArgs) Handles MenuItemEditCut.Click
    TextBoxMain.Cut()
  End Sub

  Private Sub MenuItemEditCopy_Click(sender As Object, e As EventArgs) Handles MenuItemEditCopy.Click
    TextBoxMain.Copy()
  End Sub

  Private Sub MenuItemEditPaste_Click(sender As Object, e As EventArgs) Handles MenuItemEditPaste.Click
    TextBoxMain.Paste()
  End Sub

  Private Sub MenuItemEditDelete_Click(sender As Object, e As EventArgs) Handles MenuItemEditDelete.Click
    TextBoxMain.SelectedText = ""
  End Sub

  Private Sub MenuItemEditSelectAll_Click(sender As Object, e As EventArgs) Handles MenuItemEditSelectAll.Click
    TextBoxMain.SelectAll()
  End Sub

  Private Sub MenuItemEdit_DropDownOpening(sender As Object, e As EventArgs) Handles MenuItemEdit.DropDownOpening
    MenuItemEditPaste.Enabled = Clipboard.ContainsText
    Dim b = TextBoxMain.SelectionLength = 0
    MenuItemEditCut.Enabled = Not b
    MenuItemEditCopy.Enabled = Not b
    MenuItemEditDelete.Enabled = Not b
    b = TextBoxMain.TextLength = 0
    MenuItemEditSelectAll.Enabled = Not b
  End Sub

  Private Sub MenuItemEdit_DropDownClosed(sender As Object, e As EventArgs) Handles MenuItemEdit.DropDownClosed
    MenuItemEditDelete.Enabled = False
  End Sub
End Class
