<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDisplay
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDisplay))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EVENTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EVENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COORDINATORNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADMINDISPLAYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CloudDataSet = New mainproject.cloudDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.EventIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLEGEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegeventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ADMINDISPLAYTableAdapter = New mainproject.cloudDataSetTableAdapters.ADMINDISPLAYTableAdapter()
        Me.RegeventTableAdapter = New mainproject.cloudDataSetTableAdapters.regeventTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADMINDISPLAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegeventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EVENTIDDataGridViewTextBoxColumn, Me.EVENTNAMEDataGridViewTextBoxColumn, Me.VENUEDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn, Me.COORDINATORNAMEDataGridViewTextBoxColumn, Me.CONTACTNUMBERDataGridViewTextBoxColumn, Me.CollegeidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ADMINDISPLAYBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 103)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(776, 406)
        Me.DataGridView1.TabIndex = 0
        '
        'EVENTIDDataGridViewTextBoxColumn
        '
        Me.EVENTIDDataGridViewTextBoxColumn.DataPropertyName = "EVENTID"
        Me.EVENTIDDataGridViewTextBoxColumn.HeaderText = "EVENTID"
        Me.EVENTIDDataGridViewTextBoxColumn.Name = "EVENTIDDataGridViewTextBoxColumn"
        '
        'EVENTNAMEDataGridViewTextBoxColumn
        '
        Me.EVENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EVENTNAME"
        Me.EVENTNAMEDataGridViewTextBoxColumn.HeaderText = "EVENTNAME"
        Me.EVENTNAMEDataGridViewTextBoxColumn.Name = "EVENTNAMEDataGridViewTextBoxColumn"
        Me.EVENTNAMEDataGridViewTextBoxColumn.Width = 140
        '
        'VENUEDataGridViewTextBoxColumn
        '
        Me.VENUEDataGridViewTextBoxColumn.DataPropertyName = "VENUE"
        Me.VENUEDataGridViewTextBoxColumn.HeaderText = "VENUE"
        Me.VENUEDataGridViewTextBoxColumn.Name = "VENUEDataGridViewTextBoxColumn"
        Me.VENUEDataGridViewTextBoxColumn.Width = 150
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        Me.DATEDataGridViewTextBoxColumn.Width = 140
        '
        'COORDINATORNAMEDataGridViewTextBoxColumn
        '
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.DataPropertyName = "COORDINATORNAME"
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.HeaderText = "COORDINATORNAME"
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.Name = "COORDINATORNAMEDataGridViewTextBoxColumn"
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.Width = 180
        '
        'CONTACTNUMBERDataGridViewTextBoxColumn
        '
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CONTACTNUMBER"
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.HeaderText = "CONTACTNUMBER"
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.Name = "CONTACTNUMBERDataGridViewTextBoxColumn"
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.Width = 150
        '
        'CollegeidDataGridViewTextBoxColumn
        '
        Me.CollegeidDataGridViewTextBoxColumn.DataPropertyName = "collegeid"
        Me.CollegeidDataGridViewTextBoxColumn.HeaderText = "COLLEGEID"
        Me.CollegeidDataGridViewTextBoxColumn.Name = "CollegeidDataGridViewTextBoxColumn"
        '
        'ADMINDISPLAYBindingSource
        '
        Me.ADMINDISPLAYBindingSource.DataMember = "ADMINDISPLAY"
        Me.ADMINDISPLAYBindingSource.DataSource = Me.CloudDataSet
        '
        'CloudDataSet
        '
        Me.CloudDataSet.DataSetName = "cloudDataSet"
        Me.CloudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeight = 30
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventIDDataGridViewTextBoxColumn1, Me.EventnameDataGridViewTextBoxColumn1, Me.VenueDataGridViewTextBoxColumn1, Me.EventdateDataGridViewTextBoxColumn, Me.CollegenameDataGridViewTextBoxColumn, Me.RegIDDataGridViewTextBoxColumn, Me.TeamnameDataGridViewTextBoxColumn, Me.ContactnumberDataGridViewTextBoxColumn1, Me.DepartmentDataGridViewTextBoxColumn, Me.EmailIDDataGridViewTextBoxColumn, Me.COLEGEIDDataGridViewTextBoxColumn, Me.REGCOLLEGEIDDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.RegeventBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(824, 103)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Mongolian Baiti", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(624, 384)
        Me.DataGridView2.TabIndex = 1
        '
        'EventIDDataGridViewTextBoxColumn1
        '
        Me.EventIDDataGridViewTextBoxColumn1.DataPropertyName = "eventID"
        Me.EventIDDataGridViewTextBoxColumn1.HeaderText = "EVENTID"
        Me.EventIDDataGridViewTextBoxColumn1.Name = "EventIDDataGridViewTextBoxColumn1"
        '
        'EventnameDataGridViewTextBoxColumn1
        '
        Me.EventnameDataGridViewTextBoxColumn1.DataPropertyName = "eventname"
        Me.EventnameDataGridViewTextBoxColumn1.HeaderText = "EVENTNAME"
        Me.EventnameDataGridViewTextBoxColumn1.Name = "EventnameDataGridViewTextBoxColumn1"
        '
        'VenueDataGridViewTextBoxColumn1
        '
        Me.VenueDataGridViewTextBoxColumn1.DataPropertyName = "venue"
        Me.VenueDataGridViewTextBoxColumn1.HeaderText = "VENUE"
        Me.VenueDataGridViewTextBoxColumn1.Name = "VenueDataGridViewTextBoxColumn1"
        '
        'EventdateDataGridViewTextBoxColumn
        '
        Me.EventdateDataGridViewTextBoxColumn.DataPropertyName = "eventdate"
        Me.EventdateDataGridViewTextBoxColumn.HeaderText = "EVENTDATE"
        Me.EventdateDataGridViewTextBoxColumn.Name = "EventdateDataGridViewTextBoxColumn"
        '
        'CollegenameDataGridViewTextBoxColumn
        '
        Me.CollegenameDataGridViewTextBoxColumn.DataPropertyName = "collegename"
        Me.CollegenameDataGridViewTextBoxColumn.HeaderText = "COLLEGENAME"
        Me.CollegenameDataGridViewTextBoxColumn.Name = "CollegenameDataGridViewTextBoxColumn"
        Me.CollegenameDataGridViewTextBoxColumn.Width = 130
        '
        'RegIDDataGridViewTextBoxColumn
        '
        Me.RegIDDataGridViewTextBoxColumn.DataPropertyName = "regID"
        Me.RegIDDataGridViewTextBoxColumn.HeaderText = "REGISTERID"
        Me.RegIDDataGridViewTextBoxColumn.Name = "RegIDDataGridViewTextBoxColumn"
        '
        'TeamnameDataGridViewTextBoxColumn
        '
        Me.TeamnameDataGridViewTextBoxColumn.DataPropertyName = "teamname"
        Me.TeamnameDataGridViewTextBoxColumn.HeaderText = "TEAMNAME"
        Me.TeamnameDataGridViewTextBoxColumn.Name = "TeamnameDataGridViewTextBoxColumn"
        '
        'ContactnumberDataGridViewTextBoxColumn1
        '
        Me.ContactnumberDataGridViewTextBoxColumn1.DataPropertyName = "contactnumber"
        Me.ContactnumberDataGridViewTextBoxColumn1.HeaderText = "CONTACTNUMBER"
        Me.ContactnumberDataGridViewTextBoxColumn1.Name = "ContactnumberDataGridViewTextBoxColumn1"
        Me.ContactnumberDataGridViewTextBoxColumn1.Width = 120
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'EmailIDDataGridViewTextBoxColumn
        '
        Me.EmailIDDataGridViewTextBoxColumn.DataPropertyName = "emailID"
        Me.EmailIDDataGridViewTextBoxColumn.HeaderText = "EMAILID"
        Me.EmailIDDataGridViewTextBoxColumn.Name = "EmailIDDataGridViewTextBoxColumn"
        Me.EmailIDDataGridViewTextBoxColumn.Width = 130
        '
        'COLEGEIDDataGridViewTextBoxColumn
        '
        Me.COLEGEIDDataGridViewTextBoxColumn.DataPropertyName = "COLEGEID"
        Me.COLEGEIDDataGridViewTextBoxColumn.HeaderText = "COLLEGEID"
        Me.COLEGEIDDataGridViewTextBoxColumn.Name = "COLEGEIDDataGridViewTextBoxColumn"
        '
        'REGCOLLEGEIDDataGridViewTextBoxColumn
        '
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.DataPropertyName = "REGCOLLEGEID"
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.HeaderText = "REGISTEREDCOLLEGEID"
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.Name = "REGCOLLEGEIDDataGridViewTextBoxColumn"
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.Width = 140
        '
        'RegeventBindingSource
        '
        Me.RegeventBindingSource.DataMember = "regevent"
        Me.RegeventBindingSource.DataSource = Me.CloudDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LIST OF EVENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1078, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "LIST OF PARTICIPANTS"
        '
        'ADMINDISPLAYTableAdapter
        '
        Me.ADMINDISPLAYTableAdapter.ClearBeforeFill = True
        '
        'RegeventTableAdapter
        '
        Me.RegeventTableAdapter.ClearBeforeFill = True
        '
        'adminDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1460, 540)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "adminDisplay"
        Me.Text = "admindisplay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADMINDISPLAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegeventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CloudDataSet As mainproject.cloudDataSet
    Friend WithEvents ADMINDISPLAYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ADMINDISPLAYTableAdapter As mainproject.cloudDataSetTableAdapters.ADMINDISPLAYTableAdapter
    Friend WithEvents EVENTIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EVENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COORDINATORNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegeidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegeventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegeventTableAdapter As mainproject.cloudDataSetTableAdapters.regeventTableAdapter
    Friend WithEvents EventIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenueDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeamnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactnumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLEGEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGCOLLEGEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
