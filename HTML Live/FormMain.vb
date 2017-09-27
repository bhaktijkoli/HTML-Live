'ICON 
'https://www.iconfinder.com/icons/313112/html_html5_icon

Imports FastColoredTextBoxNS

Public Class FormMain

    Dim file As String = ""


    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtWeb.TextChanged
        Web.DocumentText = txtWeb.Text
    End Sub

    'Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show(Me, "Are you sure you want to exit the application ?", Me.Text, vbYesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub

    ' New
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtWeb.Clear()
        file = ""
        Me.Text = My.Application.Info.Title
    End Sub

    'Open
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OFD1.ShowDialog = DialogResult.OK Then
            txtWeb.Text = My.Computer.FileSystem.ReadAllText(OFD1.FileName)
            file = OFD1.FileName
            Me.Text = My.Application.Info.Title + " - " + file
            OFD1.FileName = ""
        End If
    End Sub

    'Save
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If My.Computer.FileSystem.FileExists(file) Then
            My.Computer.FileSystem.WriteAllText(file, txtWeb.Text, False)
        Else
            SaveAsToolStripMenuItem.PerformClick()
        End If
    End Sub

    'Save As
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SFD1.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SFD1.FileName, txtWeb.Text, False)
            file = SFD1.FileName
            Me.Text = My.Application.Info.Title + " - " + file
            SFD1.FileName = ""
        End If
    End Sub

    Private Sub BootstrapV37ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BootstrapV37ToolStripMenuItem.Click
        txtWeb.Text = My.Settings.BootstrapTemplate
    End Sub

    ' Edit opening
    Private Sub EditToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.DropDownOpening
        If txtWeb.UndoEnabled Then
            UndoToolStripMenuItem.Enabled = True
        Else
            UndoToolStripMenuItem.Enabled = False
        End If
        If txtWeb.RedoEnabled Then
            RedoToolStripMenuItem.Enabled = True
        Else
            RedoToolStripMenuItem.Enabled = False
        End If
        If txtWeb.SelectedText.Length > 0 Then
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
            DeleteToolStripMenuItem.Enabled = True
        Else
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
            DeleteToolStripMenuItem.Enabled = False
        End If
        If My.Computer.Clipboard.ContainsText Then
            PasteToolStripMenuItem.Enabled = True
        Else
            PasteToolStripMenuItem.Enabled = False
        End If
    End Sub
    'Undo
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        txtWeb.Undo()
    End Sub
    'Redo
    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        txtWeb.Redo()
    End Sub
    ' Cut
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtWeb.Cut()
    End Sub
    ' Copy
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtWeb.Copy()
    End Sub
    ' Paste
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtWeb.Paste()
    End Sub
    ' Delete
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        txtWeb.SelectedText = ""
    End Sub
    ' View Opening
    Private Sub ViewToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.DropDownOpening
        If panelSplit.Orientation = Orientation.Horizontal Then
            LayoutToolStripMenuItem.Text = "&Vertical"
        Else
            LayoutToolStripMenuItem.Text = "&Horizontal"
        End If
    End Sub
    ' Layout
    Private Sub LayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LayoutToolStripMenuItem.Click
        If panelSplit.Orientation = Orientation.Horizontal Then
            panelSplit.Orientation = Orientation.Vertical
        Else
            panelSplit.Orientation = Orientation.Horizontal
        End If
    End Sub
End Class
