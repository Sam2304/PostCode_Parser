<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostCode_Parser_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_select_input = New System.Windows.Forms.Button()
        Me.grb_input_files = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updown_column_header_row = New System.Windows.Forms.NumericUpDown()
        Me.cb_postcode_column = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_input_location = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_scan_fields = New System.Windows.Forms.Button()
        Me.grb_out_files = New System.Windows.Forms.GroupBox()
        Me.tb_output_file_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.check_kml = New System.Windows.Forms.CheckBox()
        Me.check_CSV = New System.Windows.Forms.CheckBox()
        Me.tb_output_location = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_select_output = New System.Windows.Forms.Button()
        Me.tc_files_fields_tabsheet = New System.Windows.Forms.TabControl()
        Me.tabpage_file_controls = New System.Windows.Forms.TabPage()
        Me.tabpage_field_selection = New System.Windows.Forms.TabPage()
        Me.btn_move_field_down = New System.Windows.Forms.Button()
        Me.btn_move_field_up = New System.Windows.Forms.Button()
        Me.btn_remove_all_fields = New System.Windows.Forms.Button()
        Me.btn_select_all_fields = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkedlist_selected_fields = New System.Windows.Forms.CheckedListBox()
        Me.btn_process_files = New System.Windows.Forms.Button()
        Me.progbar = New System.Windows.Forms.ProgressBar()
        Me.fbrowser_output = New System.Windows.Forms.FolderBrowserDialog()
        Me.Imported_Data_Store = New System.Data.DataSet()
        Me.grb_input_files.SuspendLayout()
        CType(Me.updown_column_header_row, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_out_files.SuspendLayout()
        Me.tc_files_fields_tabsheet.SuspendLayout()
        Me.tabpage_file_controls.SuspendLayout()
        Me.tabpage_field_selection.SuspendLayout()
        CType(Me.Imported_Data_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_select_input
        '
        Me.btn_select_input.Location = New System.Drawing.Point(365, 35)
        Me.btn_select_input.Name = "btn_select_input"
        Me.btn_select_input.Size = New System.Drawing.Size(128, 20)
        Me.btn_select_input.TabIndex = 0
        Me.btn_select_input.Text = "Change Input File"
        Me.btn_select_input.UseVisualStyleBackColor = True
        '
        'grb_input_files
        '
        Me.grb_input_files.Controls.Add(Me.Label3)
        Me.grb_input_files.Controls.Add(Me.updown_column_header_row)
        Me.grb_input_files.Controls.Add(Me.cb_postcode_column)
        Me.grb_input_files.Controls.Add(Me.Label2)
        Me.grb_input_files.Controls.Add(Me.tb_input_location)
        Me.grb_input_files.Controls.Add(Me.Label1)
        Me.grb_input_files.Controls.Add(Me.btn_scan_fields)
        Me.grb_input_files.Controls.Add(Me.btn_select_input)
        Me.grb_input_files.Location = New System.Drawing.Point(15, 18)
        Me.grb_input_files.Name = "grb_input_files"
        Me.grb_input_files.Size = New System.Drawing.Size(573, 146)
        Me.grb_input_files.TabIndex = 1
        Me.grb_input_files.TabStop = False
        Me.grb_input_files.Text = "Input Files"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Row Containing Column Headers"
        '
        'updown_column_header_row
        '
        Me.updown_column_header_row.Location = New System.Drawing.Point(10, 74)
        Me.updown_column_header_row.Name = "updown_column_header_row"
        Me.updown_column_header_row.Size = New System.Drawing.Size(349, 20)
        Me.updown_column_header_row.TabIndex = 7
        '
        'cb_postcode_column
        '
        Me.cb_postcode_column.FormattingEnabled = True
        Me.cb_postcode_column.Location = New System.Drawing.Point(10, 119)
        Me.cb_postcode_column.Name = "cb_postcode_column"
        Me.cb_postcode_column.Size = New System.Drawing.Size(349, 21)
        Me.cb_postcode_column.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Column for Postcode Field"
        '
        'tb_input_location
        '
        Me.tb_input_location.Location = New System.Drawing.Point(10, 35)
        Me.tb_input_location.Name = "tb_input_location"
        Me.tb_input_location.Size = New System.Drawing.Size(349, 20)
        Me.tb_input_location.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Location of Input File"
        '
        'btn_scan_fields
        '
        Me.btn_scan_fields.Location = New System.Drawing.Point(365, 120)
        Me.btn_scan_fields.Name = "btn_scan_fields"
        Me.btn_scan_fields.Size = New System.Drawing.Size(128, 20)
        Me.btn_scan_fields.TabIndex = 2
        Me.btn_scan_fields.Text = "Import Data"
        Me.btn_scan_fields.UseVisualStyleBackColor = True
        '
        'grb_out_files
        '
        Me.grb_out_files.Controls.Add(Me.tb_output_file_name)
        Me.grb_out_files.Controls.Add(Me.Label6)
        Me.grb_out_files.Controls.Add(Me.check_kml)
        Me.grb_out_files.Controls.Add(Me.check_CSV)
        Me.grb_out_files.Controls.Add(Me.tb_output_location)
        Me.grb_out_files.Controls.Add(Me.Label4)
        Me.grb_out_files.Controls.Add(Me.btn_select_output)
        Me.grb_out_files.Location = New System.Drawing.Point(15, 170)
        Me.grb_out_files.Name = "grb_out_files"
        Me.grb_out_files.Size = New System.Drawing.Size(573, 157)
        Me.grb_out_files.TabIndex = 3
        Me.grb_out_files.TabStop = False
        Me.grb_out_files.Text = "Output Files"
        '
        'tb_output_file_name
        '
        Me.tb_output_file_name.Location = New System.Drawing.Point(10, 73)
        Me.tb_output_file_name.Name = "tb_output_file_name"
        Me.tb_output_file_name.Size = New System.Drawing.Size(349, 20)
        Me.tb_output_file_name.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Name out Output File(s)"
        '
        'check_kml
        '
        Me.check_kml.AutoSize = True
        Me.check_kml.Location = New System.Drawing.Point(10, 128)
        Me.check_kml.Name = "check_kml"
        Me.check_kml.Size = New System.Drawing.Size(168, 17)
        Me.check_kml.TabIndex = 9
        Me.check_kml.Text = "Do You Require KML Output?"
        Me.check_kml.UseVisualStyleBackColor = True
        '
        'check_CSV
        '
        Me.check_CSV.AutoSize = True
        Me.check_CSV.Location = New System.Drawing.Point(10, 105)
        Me.check_CSV.Name = "check_CSV"
        Me.check_CSV.Size = New System.Drawing.Size(167, 17)
        Me.check_CSV.TabIndex = 8
        Me.check_CSV.Text = "Do You Require CSV Output?"
        Me.check_CSV.UseVisualStyleBackColor = True
        '
        'tb_output_location
        '
        Me.tb_output_location.Location = New System.Drawing.Point(10, 34)
        Me.tb_output_location.Name = "tb_output_location"
        Me.tb_output_location.Size = New System.Drawing.Size(349, 20)
        Me.tb_output_location.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Location of Output File"
        '
        'btn_select_output
        '
        Me.btn_select_output.Location = New System.Drawing.Point(365, 34)
        Me.btn_select_output.Name = "btn_select_output"
        Me.btn_select_output.Size = New System.Drawing.Size(128, 20)
        Me.btn_select_output.TabIndex = 5
        Me.btn_select_output.Text = "Change Output Location"
        Me.btn_select_output.UseVisualStyleBackColor = True
        '
        'tc_files_fields_tabsheet
        '
        Me.tc_files_fields_tabsheet.Controls.Add(Me.tabpage_file_controls)
        Me.tc_files_fields_tabsheet.Controls.Add(Me.tabpage_field_selection)
        Me.tc_files_fields_tabsheet.Location = New System.Drawing.Point(12, 12)
        Me.tc_files_fields_tabsheet.Name = "tc_files_fields_tabsheet"
        Me.tc_files_fields_tabsheet.SelectedIndex = 0
        Me.tc_files_fields_tabsheet.Size = New System.Drawing.Size(618, 362)
        Me.tc_files_fields_tabsheet.TabIndex = 4
        '
        'tabpage_file_controls
        '
        Me.tabpage_file_controls.Controls.Add(Me.grb_input_files)
        Me.tabpage_file_controls.Controls.Add(Me.grb_out_files)
        Me.tabpage_file_controls.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_file_controls.Name = "tabpage_file_controls"
        Me.tabpage_file_controls.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_file_controls.Size = New System.Drawing.Size(610, 336)
        Me.tabpage_file_controls.TabIndex = 0
        Me.tabpage_file_controls.Text = "Document Settings"
        Me.tabpage_file_controls.UseVisualStyleBackColor = True
        '
        'tabpage_field_selection
        '
        Me.tabpage_field_selection.Controls.Add(Me.btn_move_field_down)
        Me.tabpage_field_selection.Controls.Add(Me.btn_move_field_up)
        Me.tabpage_field_selection.Controls.Add(Me.btn_remove_all_fields)
        Me.tabpage_field_selection.Controls.Add(Me.btn_select_all_fields)
        Me.tabpage_field_selection.Controls.Add(Me.Label5)
        Me.tabpage_field_selection.Controls.Add(Me.checkedlist_selected_fields)
        Me.tabpage_field_selection.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_field_selection.Name = "tabpage_field_selection"
        Me.tabpage_field_selection.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_field_selection.Size = New System.Drawing.Size(610, 336)
        Me.tabpage_field_selection.TabIndex = 1
        Me.tabpage_field_selection.Text = "Field Selection"
        Me.tabpage_field_selection.UseVisualStyleBackColor = True
        '
        'btn_move_field_down
        '
        Me.btn_move_field_down.Location = New System.Drawing.Point(446, 200)
        Me.btn_move_field_down.Name = "btn_move_field_down"
        Me.btn_move_field_down.Size = New System.Drawing.Size(158, 23)
        Me.btn_move_field_down.TabIndex = 5
        Me.btn_move_field_down.Text = "Move Selection Up List"
        Me.btn_move_field_down.UseVisualStyleBackColor = True
        '
        'btn_move_field_up
        '
        Me.btn_move_field_up.Location = New System.Drawing.Point(446, 229)
        Me.btn_move_field_up.Name = "btn_move_field_up"
        Me.btn_move_field_up.Size = New System.Drawing.Size(158, 23)
        Me.btn_move_field_up.TabIndex = 4
        Me.btn_move_field_up.Text = "Move Selection Down List"
        Me.btn_move_field_up.UseVisualStyleBackColor = True
        '
        'btn_remove_all_fields
        '
        Me.btn_remove_all_fields.Location = New System.Drawing.Point(9, 229)
        Me.btn_remove_all_fields.Name = "btn_remove_all_fields"
        Me.btn_remove_all_fields.Size = New System.Drawing.Size(192, 23)
        Me.btn_remove_all_fields.TabIndex = 3
        Me.btn_remove_all_fields.Text = "Deselect All Fields"
        Me.btn_remove_all_fields.UseVisualStyleBackColor = True
        '
        'btn_select_all_fields
        '
        Me.btn_select_all_fields.Location = New System.Drawing.Point(9, 200)
        Me.btn_select_all_fields.Name = "btn_select_all_fields"
        Me.btn_select_all_fields.Size = New System.Drawing.Size(192, 23)
        Me.btn_select_all_fields.TabIndex = 2
        Me.btn_select_all_fields.Text = "Select All Fields"
        Me.btn_select_all_fields.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Select Fields For Inclusion in Output File"
        '
        'checkedlist_selected_fields
        '
        Me.checkedlist_selected_fields.FormattingEnabled = True
        Me.checkedlist_selected_fields.Items.AddRange(New Object() {"Test Item 1", "Test Item 2", "Test Item 3", "Check Listings?"})
        Me.checkedlist_selected_fields.Location = New System.Drawing.Point(9, 25)
        Me.checkedlist_selected_fields.Name = "checkedlist_selected_fields"
        Me.checkedlist_selected_fields.Size = New System.Drawing.Size(595, 169)
        Me.checkedlist_selected_fields.TabIndex = 0
        '
        'btn_process_files
        '
        Me.btn_process_files.Location = New System.Drawing.Point(11, 380)
        Me.btn_process_files.Name = "btn_process_files"
        Me.btn_process_files.Size = New System.Drawing.Size(619, 40)
        Me.btn_process_files.TabIndex = 5
        Me.btn_process_files.Text = "Process Files"
        Me.btn_process_files.UseVisualStyleBackColor = True
        '
        'progbar
        '
        Me.progbar.Location = New System.Drawing.Point(12, 426)
        Me.progbar.Name = "progbar"
        Me.progbar.Size = New System.Drawing.Size(618, 23)
        Me.progbar.TabIndex = 6
        Me.progbar.Visible = False
        '
        'fbrowser_output
        '
        Me.fbrowser_output.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.fbrowser_output.ShowNewFolderButton = False
        '
        'Imported_Data_Store
        '
        Me.Imported_Data_Store.DataSetName = "NewDataSet"
        '
        'PostCode_Parser_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 459)
        Me.Controls.Add(Me.progbar)
        Me.Controls.Add(Me.btn_process_files)
        Me.Controls.Add(Me.tc_files_fields_tabsheet)
        Me.Name = "PostCode_Parser_Main"
        Me.Text = "PostCode Parser"
        Me.grb_input_files.ResumeLayout(False)
        Me.grb_input_files.PerformLayout()
        CType(Me.updown_column_header_row, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_out_files.ResumeLayout(False)
        Me.grb_out_files.PerformLayout()
        Me.tc_files_fields_tabsheet.ResumeLayout(False)
        Me.tabpage_file_controls.ResumeLayout(False)
        Me.tabpage_field_selection.ResumeLayout(False)
        Me.tabpage_field_selection.PerformLayout()
        CType(Me.Imported_Data_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_select_input As System.Windows.Forms.Button
    Friend WithEvents grb_input_files As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents updown_column_header_row As System.Windows.Forms.NumericUpDown
    Friend WithEvents cb_postcode_column As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_input_location As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_scan_fields As System.Windows.Forms.Button
    Friend WithEvents grb_out_files As System.Windows.Forms.GroupBox
    Friend WithEvents check_kml As System.Windows.Forms.CheckBox
    Friend WithEvents check_CSV As System.Windows.Forms.CheckBox
    Friend WithEvents tb_output_location As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_select_output As System.Windows.Forms.Button
    Friend WithEvents tc_files_fields_tabsheet As System.Windows.Forms.TabControl
    Friend WithEvents tabpage_file_controls As System.Windows.Forms.TabPage
    Friend WithEvents tabpage_field_selection As System.Windows.Forms.TabPage
    Friend WithEvents btn_remove_all_fields As System.Windows.Forms.Button
    Friend WithEvents btn_select_all_fields As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents checkedlist_selected_fields As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_process_files As System.Windows.Forms.Button
    Friend WithEvents progbar As System.Windows.Forms.ProgressBar
    Friend WithEvents tb_output_file_name As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_move_field_down As System.Windows.Forms.Button
    Friend WithEvents btn_move_field_up As System.Windows.Forms.Button
    Friend WithEvents fbrowser_output As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Imported_Data_Store As System.Data.DataSet

End Class
