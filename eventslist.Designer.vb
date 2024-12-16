<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eventslist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eventslist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.ADMINDISPLAYTableAdapter = New mainproject.cloudDataSetTableAdapters.ADMINDISPLAYTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADMINDISPLAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(-16, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1586, 533)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(34, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(1340, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "LOG IN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(579, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LIST OF EVENTS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Sitka Small", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 32
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EVENTIDDataGridViewTextBoxColumn, Me.EVENTNAMEDataGridViewTextBoxColumn, Me.VENUEDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn, Me.COORDINATORNAMEDataGridViewTextBoxColumn, Me.CONTACTNUMBERDataGridViewTextBoxColumn, Me.CollegeidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ADMINDISPLAYBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(34, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1284, 367)
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
        Me.VENUEDataGridViewTextBoxColumn.Width = 120
        '
        'DATEDataGridViewTextBoxColumn
        '
        Me.DATEDataGridViewTextBoxColumn.DataPropertyName = "DATE"
        Me.DATEDataGridViewTextBoxColumn.HeaderText = "DATE"
        Me.DATEDataGridViewTextBoxColumn.Name = "DATEDataGridViewTextBoxColumn"
        Me.DATEDataGridViewTextBoxColumn.Width = 130
        '
        'COORDINATORNAMEDataGridViewTextBoxColumn
        '
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.DataPropertyName = "COORDINATORNAME"
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.HeaderText = "COORDINATORNAME"
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.Name = "COORDINATORNAMEDataGridViewTextBoxColumn"
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.Width = 190
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
        Me.CollegeidDataGridViewTextBoxColumn.HeaderText = "COLLEGE ID"
        Me.CollegeidDataGridViewTextBoxColumn.Name = "CollegeidDataGridViewTextBoxColumn"
        Me.CollegeidDataGridViewTextBoxColumn.Width = 120
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
        'ADMINDISPLAYTableAdapter
        '
        Me.ADMINDISPLAYTableAdapter.ClearBeforeFill = True
        '
        'eventslist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1523, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "eventslist"
        Me.Text = "eventslist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADMINDISPLAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
