<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

  'Windows フォーム デザイナーで必要です。
  Private components As System.ComponentModel.IContainer

  'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
  'Windows フォーム デザイナーを使用して変更できます。  
  'コード エディターを使って変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.MenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemFileOpen = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemSave = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemEditUndo = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.MenuItemEditCut = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemEditCopy = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemEditPaste = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemEditDelete = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
    Me.設定SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemSettingFont = New System.Windows.Forms.ToolStripMenuItem()
    Me.TextBoxMain = New System.Windows.Forms.TextBox()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.FontDialog1 = New System.Windows.Forms.FontDialog()
    Me.MenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemHelpReadMe = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemHelpWeb = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuItemHelpVersion = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFile, Me.MenuItemEdit, Me.設定SToolStripMenuItem, Me.MenuItemHelp})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'MenuItemFile
    '
    Me.MenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MenuItemFileOpen, Me.MenuItemSave, Me.MenuItemFileSaveAs, Me.ToolStripSeparator1, Me.MenuItemExit})
    Me.MenuItemFile.Name = "MenuItemFile"
    Me.MenuItemFile.Size = New System.Drawing.Size(66, 20)
    Me.MenuItemFile.Text = "ファイル(&F)"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
    Me.ToolStripMenuItem1.Text = "新規(&N)"
    '
    'MenuItemFileOpen
    '
    Me.MenuItemFileOpen.Name = "MenuItemFileOpen"
    Me.MenuItemFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
    Me.MenuItemFileOpen.Size = New System.Drawing.Size(186, 22)
    Me.MenuItemFileOpen.Text = "開く(&O)..."
    '
    'MenuItemSave
    '
    Me.MenuItemSave.Name = "MenuItemSave"
    Me.MenuItemSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.MenuItemSave.Size = New System.Drawing.Size(186, 22)
    Me.MenuItemSave.Text = "上書き保存(&S)"
    '
    'MenuItemFileSaveAs
    '
    Me.MenuItemFileSaveAs.Name = "MenuItemFileSaveAs"
    Me.MenuItemFileSaveAs.Size = New System.Drawing.Size(186, 22)
    Me.MenuItemFileSaveAs.Text = "名前を付けて保存(&A)..."
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
    '
    'MenuItemExit
    '
    Me.MenuItemExit.Name = "MenuItemExit"
    Me.MenuItemExit.Size = New System.Drawing.Size(186, 22)
    Me.MenuItemExit.Text = "終了(&X)"
    '
    'MenuItemEdit
    '
    Me.MenuItemEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemEditUndo, Me.ToolStripSeparator2, Me.MenuItemEditCut, Me.MenuItemEditCopy, Me.MenuItemEditPaste, Me.MenuItemEditDelete, Me.MenuItemEditSelectAll})
    Me.MenuItemEdit.Name = "MenuItemEdit"
    Me.MenuItemEdit.Size = New System.Drawing.Size(57, 20)
    Me.MenuItemEdit.Text = "編集(&E)"
    '
    'MenuItemEditUndo
    '
    Me.MenuItemEditUndo.Name = "MenuItemEditUndo"
    Me.MenuItemEditUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
    Me.MenuItemEditUndo.Size = New System.Drawing.Size(183, 22)
    Me.MenuItemEditUndo.Text = "元に戻す(&U)"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
    '
    'MenuItemEditCut
    '
    Me.MenuItemEditCut.Name = "MenuItemEditCut"
    Me.MenuItemEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
    Me.MenuItemEditCut.Size = New System.Drawing.Size(183, 22)
    Me.MenuItemEditCut.Text = "切り取り(&X)"
    '
    'MenuItemEditCopy
    '
    Me.MenuItemEditCopy.Name = "MenuItemEditCopy"
    Me.MenuItemEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
    Me.MenuItemEditCopy.Size = New System.Drawing.Size(183, 22)
    Me.MenuItemEditCopy.Text = "コピー(&C)"
    '
    'MenuItemEditPaste
    '
    Me.MenuItemEditPaste.Name = "MenuItemEditPaste"
    Me.MenuItemEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
    Me.MenuItemEditPaste.Size = New System.Drawing.Size(183, 22)
    Me.MenuItemEditPaste.Text = "貼り付け(&P)"
    '
    'MenuItemEditDelete
    '
    Me.MenuItemEditDelete.Name = "MenuItemEditDelete"
    Me.MenuItemEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
    Me.MenuItemEditDelete.Size = New System.Drawing.Size(183, 22)
    Me.MenuItemEditDelete.Text = "削除(&L)"
    '
    'MenuItemEditSelectAll
    '
    Me.MenuItemEditSelectAll.Name = "MenuItemEditSelectAll"
    Me.MenuItemEditSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
    Me.MenuItemEditSelectAll.Size = New System.Drawing.Size(183, 22)
    Me.MenuItemEditSelectAll.Text = "すべて選択(&A)"
    '
    '設定SToolStripMenuItem
    '
    Me.設定SToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemSettingFont})
    Me.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem"
    Me.設定SToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
    Me.設定SToolStripMenuItem.Text = "設定(&S)"
    '
    'MenuItemSettingFont
    '
    Me.MenuItemSettingFont.Name = "MenuItemSettingFont"
    Me.MenuItemSettingFont.Size = New System.Drawing.Size(121, 22)
    Me.MenuItemSettingFont.Text = "フォント(&F)"
    '
    'TextBoxMain
    '
    Me.TextBoxMain.Location = New System.Drawing.Point(42, 38)
    Me.TextBoxMain.Name = "TextBoxMain"
    Me.TextBoxMain.Size = New System.Drawing.Size(100, 19)
    Me.TextBoxMain.TabIndex = 1
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'MenuItemHelp
    '
    Me.MenuItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemHelpReadMe, Me.MenuItemHelpWeb, Me.MenuItemHelpVersion})
    Me.MenuItemHelp.Name = "MenuItemHelp"
    Me.MenuItemHelp.Size = New System.Drawing.Size(65, 20)
    Me.MenuItemHelp.Text = "ヘルプ(&H)"
    '
    'MenuItemHelpReadMe
    '
    Me.MenuItemHelpReadMe.Name = "MenuItemHelpReadMe"
    Me.MenuItemHelpReadMe.Size = New System.Drawing.Size(200, 22)
    Me.MenuItemHelpReadMe.Text = "README.TXTの表示(&R)..."
    '
    'MenuItemHelpWeb
    '
    Me.MenuItemHelpWeb.Name = "MenuItemHelpWeb"
    Me.MenuItemHelpWeb.Size = New System.Drawing.Size(200, 22)
    Me.MenuItemHelpWeb.Text = "Webサイトの表示(&W)..."
    '
    'MenuItemHelpVersion
    '
    Me.MenuItemHelpVersion.Name = "MenuItemHelpVersion"
    Me.MenuItemHelpVersion.Size = New System.Drawing.Size(200, 22)
    Me.MenuItemHelpVersion.Text = "バージョン情報(&V)..."
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 261)
    Me.Controls.Add(Me.TextBoxMain)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents MenuItemFile As ToolStripMenuItem
  Friend WithEvents MenuItemExit As ToolStripMenuItem
  Friend WithEvents TextBoxMain As TextBox
  Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
  Friend WithEvents MenuItemFileOpen As ToolStripMenuItem
  Friend WithEvents MenuItemSave As ToolStripMenuItem
  Friend WithEvents MenuItemFileSaveAs As ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
  Friend WithEvents OpenFileDialog1 As OpenFileDialog
  Friend WithEvents SaveFileDialog1 As SaveFileDialog
  Friend WithEvents 設定SToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents MenuItemSettingFont As ToolStripMenuItem
  Friend WithEvents FontDialog1 As FontDialog
  Friend WithEvents MenuItemEdit As ToolStripMenuItem
  Friend WithEvents MenuItemEditUndo As ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
  Friend WithEvents MenuItemEditCut As ToolStripMenuItem
  Friend WithEvents MenuItemEditCopy As ToolStripMenuItem
  Friend WithEvents MenuItemEditPaste As ToolStripMenuItem
  Friend WithEvents MenuItemEditDelete As ToolStripMenuItem
  Friend WithEvents MenuItemEditSelectAll As ToolStripMenuItem
  Friend WithEvents MenuItemHelp As ToolStripMenuItem
  Friend WithEvents MenuItemHelpReadMe As ToolStripMenuItem
  Friend WithEvents MenuItemHelpWeb As ToolStripMenuItem
  Friend WithEvents MenuItemHelpVersion As ToolStripMenuItem
End Class
