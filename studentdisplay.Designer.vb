<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentdisplay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentdisplay))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CollegenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLEGEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegeventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CloudDataSet = New mainproject.cloudDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegeventTableAdapter = New mainproject.cloudDataSetTableAdapters.regeventTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegeventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 32
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventIDDataGridViewTextBoxColumn, Me.EventnameDataGridViewTextBoxColumn, Me.VenueDataGridViewTextBoxColumn, Me.EventdateDataGridViewTextBoxColumn, Me.CollegenameDataGridViewTextBoxColumn, Me.RegIDDataGridViewTextBoxColumn, Me.TeamnameDataGridViewTextBoxColumn, Me.ContactnumberDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.EmailIDDataGridViewTextBoxColumn, Me.COLEGEIDDataGridViewTextBoxColumn, Me.REGCOLLEGEIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegeventBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1737, 399)
        Me.DataGridView1.TabIndex = 0
        '
        'EventIDDataGridViewTextBoxColumn
        '
        Me.EventIDDataGridViewTextBoxColumn.DataPropertyName = "eventID"
        Me.EventIDDataGridViewTextBoxColumn.HeaderText = "EVENT ID"
        Me.EventIDDataGridViewTextBoxColumn.Name = "EventIDDataGridViewTextBoxColumn"
        '
        'EventnameDataGridViewTextBoxColumn
        '
        Me.EventnameDataGridViewTextBoxColumn.DataPropertyName = "eventname"
        Me.EventnameDataGridViewTextBoxColumn.HeaderText = "EVENTNAME"
        Me.EventnameDataGridViewTextBoxColumn.Name = "EventnameDataGridViewTextBoxColumn"
        Me.EventnameDataGridViewTextBoxColumn.Width = 130
        '
        'VenueDataGridViewTextBoxColumn
        '
        Me.VenueDataGridViewTextBoxColumn.DataPropertyName = "venue"
        Me.VenueDataGridViewTextBoxColumn.HeaderText = "VENUE"
        Me.VenueDataGridViewTextBoxColumn.Name = "VenueDataGridViewTextBoxColumn"
        '
        'EventdateDataGridViewTextBoxColumn
        '
        Me.EventdateDataGridViewTextBoxColumn.DataPropertyName = "eventdate"
        Me.EventdateDataGridViewTextBoxColumn.HeaderText = "EVENTDATE"
        Me.EventdateDataGridViewTextBoxColumn.Name = "EventdateDataGridViewTextBoxColumn"
        Me.EventdateDataGridViewTextBoxColumn.Width = 120
        '
        'CollegenameDataGridViewTextBoxColumn
        '
        Me.CollegenameDataGridViewTextBoxColumn.DataPropertyName = "collegename"
        Me.CollegenameDataGridViewTextBoxColumn.HeaderText = "COLLEGENAME"
        Me.CollegenameDataGridViewTextBoxColumn.Name = "CollegenameDataGridViewTextBoxColumn"
        Me.CollegenameDataGridViewTextBoxColumn.Width = 150
        '
        'RegIDDataGridViewTextBoxColumn
        '
        Me.RegIDDataGridViewTextBoxColumn.DataPropertyName = "regID"
        Me.RegIDDataGridViewTextBoxColumn.HeaderText = "REGID"
        Me.RegIDDataGridViewTextBoxColumn.Name = "RegIDDataGridViewTextBoxColumn"
        '
        'TeamnameDataGridViewTextBoxColumn
        '
        Me.TeamnameDataGridViewTextBoxColumn.DataPropertyName = "teamname"
        Me.TeamnameDataGridViewTextBoxColumn.HeaderText = "TEAMNAME"
        Me.TeamnameDataGridViewTextBoxColumn.Name = "TeamnameDataGridViewTextBoxColumn"
        Me.TeamnameDataGridViewTextBoxColumn.Width = 130
        '
        'ContactnumberDataGridViewTextBoxColumn
        '
        Me.ContactnumberDataGridViewTextBoxColumn.DataPropertyName = "contactnumber"
        Me.ContactnumberDataGridViewTextBoxColumn.HeaderText = "CONTACTNO"
        Me.ContactnumberDataGridViewTextBoxColumn.Name = "ContactnumberDataGridViewTextBoxColumn"
        Me.ContactnumberDataGridViewTextBoxColumn.Width = 120
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "DEPARTMENT"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.Width = 120
        '
        'EmailIDDataGridViewTextBoxColumn
        '
        Me.EmailIDDataGridViewTextBoxColumn.DataPropertyName = "emailID"
        Me.EmailIDDataGridViewTextBoxColumn.HeaderText = "EMAIL ID"
        Me.EmailIDDataGridViewTextBoxColumn.Name = "EmailIDDataGridViewTextBoxColumn"
        Me.EmailIDDataGridViewTextBoxColumn.Width = 130
        '
        'COLEGEIDDataGridViewTextBoxColumn
        '
        Me.COLEGEIDDataGridViewTextBoxColumn.DataPropertyName = "COLEGEID"
        Me.COLEGEIDDataGridViewTextBoxColumn.HeaderText = "COLLEGEID"
        Me.COLEGEIDDataGridViewTextBoxColumn.Name = "COLEGEIDDataGridViewTextBoxColumn"
        Me.COLEGEIDDataGridViewTextBoxColumn.Width = 120
        '
        'REGCOLLEGEIDDataGridViewTextBoxColumn
        '
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.DataPropertyName = "REGCOLLEGEID"
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.HeaderText = "REGCOLLEGEID"
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.Name = "REGCOLLEGEIDDataGridViewTextBoxColumn"
        Me.REGCOLLEGEIDDataGridViewTextBoxColumn.Width = 130
        '
        'RegeventBindingSource
        '
        Me.RegeventBindingSource.DataMember = "regevent"
        Me.RegeventBindingSource.DataSource = Me.CloudDataSet
        '
        'CloudDataSet
        '
        Me.CloudDataSet.DataSetName = "cloudDataSet"
        Me.CloudDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1770, 500)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(744, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MY EVENTS"
        '
        'RegeventTableAdapter
        '
        Me.RegeventTableAdapter.ClearBeforeFill = True
        '
        'studentdisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1770, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "studentdisplay"
        Me.Text = "studentdisplay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegeventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloudDataSet As mainproject.cloudDataSet
    Friend WithEvents RegeventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegeventTableAdapter As mainproject.cloudDataSetTableAdapters.regeventTableAdapter
    Friend WithEvents EventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CollegenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeamnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLEGEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGCOLLEGEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
