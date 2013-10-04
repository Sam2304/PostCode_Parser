Public Class PostCode_Parser_Main

    Private Sub select_input(sender As System.Object, e As System.EventArgs) Handles btn_select_input.Click
        Dim fbrowse_input As New OpenFileDialog, fpath As Array
        fbrowse_input.InitialDirectory = "\\WREFORD-TS\Swam Ltd Main Files\TENDERING\LOGS"
        If fbrowse_input.ShowDialog = Windows.Forms.DialogResult.OK Then
            tb_input_location.Text = fbrowse_input.FileName
            tb_output_location.Text = fbrowse_input.FileName

            fpath = Split(fbrowse_input.FileName, "\")
            fpath = Split(fpath(UBound(fpath)), ".")
            tb_output_file_name.Text = fpath(LBound(fpath))
        End If
    End Sub

    Private Sub PostCode_Parser_Main_Layout(sender As System.Object, e As System.Windows.Forms.LayoutEventArgs) Handles MyBase.Layout
        'fbrowse_input.RootFolder =
        'fbrowse_output.RootFolder = "\\WREFORD-TS\Swam Ltd Main Files\TENDERING\LOGS"
    End Sub

    Private Sub btn_select_output_Click(sender As System.Object, e As System.EventArgs) Handles btn_select_output.Click
        Dim Location As String
        Dim fbrowse_output As New OpenFileDialog

        'fbrowse_output.ShowDialog
        'fbrowse_output.InitialDirectory = "\\WREFORD-TS\Swam Ltd Main Files\TENDERING\LOGS"
        If fbrowser_output.ShowDialog = Windows.Forms.DialogResult.OK Then
            Location = fbrowser_output.SelectedPath
            tb_output_location.Text = Location
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

        For counter = 0 To checkedlist_selected_fields.Items.Count - 1
            Debug.Print(checkedlist_selected_fields.Items.Item(counter).ToString)
            checkedlist_selected_fields.SetItemChecked(counter, True)
        Next


    End Sub

    Private Sub btn_remove_all_fields_Click(sender As System.Object, e As System.EventArgs) Handles btn_remove_all_fields.Click
        'Sub to deselect all items in the checked list box control
        Dim itema As Integer
        Debug.Print("There are: " & checkedlist_selected_fields.CheckedItems.Count & " items selected in the control")

        For itema = 0 To checkedlist_selected_fields.CheckedItems.Count - 1
            checkedlist_selected_fields.SetItemCheckState(itema, CheckState.Unchecked)
        Next
    End Sub

    Private Sub btn_move_field_down_Click(sender As System.Object, e As System.EventArgs) Handles btn_move_field_down.Click
        'Moves an item up in the list
        Dim selected_item As Integer = checkedlist_selected_fields.SelectedIndex
        Dim sel_text As String = checkedlist_selected_fields.SelectedItem.ToString
        Dim sel_checked As Boolean = checkedlist_selected_fields.GetItemChecked(selected_item)

        If checkedlist_selected_fields.SelectedItem = "" Then
            Exit Sub
        End If
        If selected_item = 0 Then
            Exit Sub
        End If

        checkedlist_selected_fields.Items.RemoveAt(selected_item)
        checkedlist_selected_fields.Items.Insert(selected_item - 1, sel_text)
        If sel_checked Then
            checkedlist_selected_fields.SetItemCheckState(selected_item - 1, CheckState.Checked)
        Else
            checkedlist_selected_fields.SetItemCheckState(selected_item - 1, CheckState.Unchecked)
        End If
        checkedlist_selected_fields.SetSelected(selected_item - 1, True)
    End Sub

    Private Sub btn_move_field_up_Click(sender As System.Object, e As System.EventArgs) Handles btn_move_field_up.Click
        'Moves an item down in the list
        Dim selected_item As Integer = checkedlist_selected_fields.SelectedIndex
        Dim sel_text As String = checkedlist_selected_fields.SelectedItem.ToString
        Dim sel_checked As Boolean = checkedlist_selected_fields.GetItemChecked(selected_item)

        If checkedlist_selected_fields.SelectedItem = "" Then
            Exit Sub
        End If
        If selected_item = checkedlist_selected_fields.Items.Count - 1 Then
            Exit Sub
        End If

        checkedlist_selected_fields.Items.RemoveAt(selected_item)
        checkedlist_selected_fields.Items.Insert(selected_item + 1, sel_text)
        If sel_checked Then
            checkedlist_selected_fields.SetItemCheckState(selected_item + 1, CheckState.Checked)
        Else
            checkedlist_selected_fields.SetItemCheckState(selected_item + 1, CheckState.Unchecked)
        End If
        checkedlist_selected_fields.SetSelected(selected_item + 1, True)
    End Sub
End Class
