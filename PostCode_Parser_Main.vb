Public Class PostCode_Parser_Main

    Private Sub select_input(sender As System.Object, e As System.EventArgs) Handles btn_select_input.Click
        Dim fbrowse_input As New OpenFileDialog
        fbrowse_input.InitialDirectory = "\\WREFORD-TS\Swam Ltd Main Files\TENDERING\LOGS"
        If fbrowse_input.ShowDialog = Windows.Forms.DialogResult.OK Then
            tb_input_location.Text = fbrowse_input.FileName

        End If
    End Sub

    Private Sub PostCode_Parser_Main_Layout(sender As System.Object, e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        'fbrowse_input.RootFolder =
        'fbrowse_output.RootFolder = "\\WREFORD-TS\Swam Ltd Main Files\TENDERING\LOGS"
    End Sub

    Private Sub btn_select_output_Click(sender As System.Object, e As System.EventArgs) Handles btn_select_output.Click
        Dim Location As String
        Dim fbrowse_output As New OpenFileDialog
        fbrowse_output.InitialDirectory = "\\WREFORD-TS\Swam Ltd Main Files\TENDERING\LOGS"
        If fbrowse_output.ShowDialog = Windows.Forms.DialogResult.OK Then
            Location = fbrowse_output.FileName
            MsgBox(Location)
        End If
    End Sub

    
    Private Sub btn_process_files_Click(sender As System.Object, e As System.EventArgs) Handles btn_process_files.Click
        progbar.Visible = True
        progbar.Value = 0
    End Sub

    Private Sub btn_scan_fields_Click(sender As System.Object, e As System.EventArgs) Handles btn_scan_fields.Click
        If tb_input_location.Text.Length < 1 Then
            Exit Sub
        End If

    End Sub

    Private Sub btn_select_all_fields_Click(sender As System.Object, e As System.EventArgs) Handles btn_select_all_fields.Click
        'Sub to check all items listed in the checked list object
        Dim counter As Integer
        'basic check to allow function to run
        Debug.Print("Items present:" & checkedlist_selected_fields.Items.Count)
        If checkedlist_selected_fields.Items.Count < 1 Then
            Debug.Print("There are no items to select")
            Exit Sub
        End If

        For counter = 0 To checkedlist_selected_fields.Items.Count
            checkedlist_selected_fields.Items.()
        Next


    End Sub
End Class
