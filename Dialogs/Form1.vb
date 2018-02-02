Public Class Dialogs

    Private Sub Dialogs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim msg = "Are you sure you want to close?"

        If MsgBox(msg, MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If

        'Below is C# (doesn't work)
        'If MessageBox.Show(msg, Me.Text, MessageBoxButtons.YesNo) = WindowsFormsSection.Forms.DialogResult.No Then
        '    e.Cancel = True
        'End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Oranges")
        ListBox1.Items.Add("Grapes")
        ListBox1.Items.Add("Bananas")
        ListBox1.Items.Add("Peaches")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            Dim msg = "Please select an item from the list box."
            'MsgBox(msg)
            MessageBox.Show(msg, Me.Text) 'This is C#
            Exit Sub
        End If
        Label1.Text = ListBox1.Text
    End Sub




End Class
