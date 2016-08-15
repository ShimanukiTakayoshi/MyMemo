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
    Me.TextBoxMain = New System.Windows.Forms.TextBox()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemFile})
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
End Class
