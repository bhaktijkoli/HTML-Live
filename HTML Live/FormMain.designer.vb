<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.panelSplit = New System.Windows.Forms.SplitContainer()
        Me.txtWeb = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Web = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemplateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BootstrapV37ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.panelSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSplit.Panel1.SuspendLayout()
        Me.panelSplit.Panel2.SuspendLayout()
        Me.panelSplit.SuspendLayout()
        CType(Me.txtWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSplit
        '
        Me.panelSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSplit.Location = New System.Drawing.Point(0, 24)
        Me.panelSplit.Name = "panelSplit"
        '
        'panelSplit.Panel1
        '
        Me.panelSplit.Panel1.Controls.Add(Me.txtWeb)
        Me.panelSplit.Panel1MinSize = 100
        '
        'panelSplit.Panel2
        '
        Me.panelSplit.Panel2.Controls.Add(Me.Web)
        Me.panelSplit.Size = New System.Drawing.Size(795, 448)
        Me.panelSplit.SplitterDistance = 265
        Me.panelSplit.SplitterWidth = 10
        Me.panelSplit.TabIndex = 0
        '
        'txtWeb
        '
        Me.txtWeb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtWeb.AutoIndentCharsPatterns = ""
        Me.txtWeb.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.txtWeb.BackBrush = Nothing
        Me.txtWeb.CharHeight = 14
        Me.txtWeb.CharWidth = 8
        Me.txtWeb.CommentPrefix = Nothing
        Me.txtWeb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtWeb.IsReplaceMode = False
        Me.txtWeb.Language = FastColoredTextBoxNS.Language.HTML
        Me.txtWeb.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.txtWeb.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtWeb.LineNumberColor = System.Drawing.Color.Chocolate
        Me.txtWeb.Location = New System.Drawing.Point(0, 0)
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtWeb.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.txtWeb.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtWeb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeb.ServiceColors = CType(resources.GetObject("txtWeb.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.txtWeb.Size = New System.Drawing.Size(265, 448)
        Me.txtWeb.TabIndex = 0
        Me.txtWeb.Zoom = 100
        '
        'Web
        '
        Me.Web.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Web.IsWebBrowserContextMenuEnabled = False
        Me.Web.Location = New System.Drawing.Point(0, 0)
        Me.Web.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Web.Name = "Web"
        Me.Web.ScriptErrorsSuppressed = True
        Me.Web.Size = New System.Drawing.Size(520, 448)
        Me.Web.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.TemplateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(795, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As.."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(104, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LayoutToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'LayoutToolStripMenuItem
        '
        Me.LayoutToolStripMenuItem.Name = "LayoutToolStripMenuItem"
        Me.LayoutToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.LayoutToolStripMenuItem.Text = "Layout"
        '
        'TemplateToolStripMenuItem
        '
        Me.TemplateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BootstrapV37ToolStripMenuItem})
        Me.TemplateToolStripMenuItem.Name = "TemplateToolStripMenuItem"
        Me.TemplateToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.TemplateToolStripMenuItem.Text = "&Template"
        '
        'BootstrapV37ToolStripMenuItem
        '
        Me.BootstrapV37ToolStripMenuItem.Name = "BootstrapV37ToolStripMenuItem"
        Me.BootstrapV37ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.BootstrapV37ToolStripMenuItem.Text = "&Bootstrap v3.3.7"
        '
        'OFD1
        '
        Me.OFD1.Filter = "Web Page (*.html)|*.html|All files (*.*)|*.*"
        '
        'SFD1
        '
        Me.SFD1.Filter = "Web Page (*.html)|*.html|All files (*.*)|*.*"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 472)
        Me.Controls.Add(Me.panelSplit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = Global.HTML_Live.My.Resources.Resources.icon
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "HTML Live"
        Me.panelSplit.Panel1.ResumeLayout(False)
        Me.panelSplit.Panel2.ResumeLayout(False)
        CType(Me.panelSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSplit.ResumeLayout(False)
        CType(Me.txtWeb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelSplit As SplitContainer
    Friend WithEvents txtWeb As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Web As WebBrowser
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OFD1 As OpenFileDialog
    Friend WithEvents SFD1 As SaveFileDialog
    Friend WithEvents TemplateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BootstrapV37ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LayoutToolStripMenuItem As ToolStripMenuItem
End Class
