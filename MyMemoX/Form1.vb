Public Class Form1
  Const ApplicationName = "MyMemo"
  Const RegistryKey As String = "Software\NikkeiSoftware\" & ApplicationName
  Private FilePath As String
  Private FileNameValue As String
  Private PrintString As String

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
    Dim b = TextBoxMain.TextLength = 0
    MenuItemFilePrint.Enabled = Not b
    MenuItemFilePrintPreview.Enabled = Not b

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
    PrintDialog1.Document = PrintDocument1
    PrintPreviewDialog1.Document = PrintDocument1
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

  Private Sub MenuItemHelpReadMe_Click(sender As Object, e As EventArgs) Handles MenuItemHelpReadMe.Click
    Dim s As String = IO.Path.GetDirectoryName(Application.ExecutablePath)
    s = IO.Path.Combine(s, "README.TXT")
    If IO.File.Exists(s) Then
      Process.Start(s)
    Else
      MessageBox.Show(s & "が見つかりません", ApplicationName)
    End If
  End Sub

  Private Sub MenuItemHelpWeb_Click(sender As Object, e As EventArgs) Handles MenuItemHelpWeb.Click
    Process.Start("http://www.yahoo.co.jp/")
  End Sub

  Private Sub MenuItemHelpVersion_Click(sender As Object, e As EventArgs) Handles MenuItemHelpVersion.Click
    MessageBox.Show(ApplicationName & " 0.01" & vbCrLf & "(c)2016 Shimanuki Takayoshi", "バージョン情報")
  End Sub

  Private Sub MenuItemFilePrint_Click(sender As Object, e As EventArgs) Handles MenuItemFilePrint.Click
    If DialogResult.OK = PrintDialog1.ShowDialog Then
      SetPrintDocument1()
      PrintDocument1.Print()
    End If
  End Sub

  Private Sub SetPrintDocument1()
    PrintString = TextBoxMain.Text
    PrintDocument1.DefaultPageSettings.Margins = New Printing.Margins(20, 60, 20, 60)
    PrintDocument1.DocumentName = FileName
  End Sub

  Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    Dim charactersOnPage As Integer = 0
    Dim linePerPage As Integer = 0
    e.Graphics.MeasureString(PrintString, TextBoxMain.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, charactersOnPage, linePerPage)
    e.Graphics.DrawString(PrintString, TextBoxMain.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)
    PrintString = PrintString.Substring(charactersOnPage)
    If PrintString.Length > 0 Then
      e.HasMorePages = True
    Else
      e.HasMorePages = False
      PrintString = TextBoxMain.Text
    End If
  End Sub

  Private Sub MenuItemFilePrintPreview_Click(sender As Object, e As EventArgs) Handles MenuItemFilePrintPreview.Click
    SetPrintDocument1()
    PrintPreviewDialog1.ShowDialog()
  End Sub
End Class
