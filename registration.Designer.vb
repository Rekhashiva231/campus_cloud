﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ADMINDISPLAYTableAdapter = New mainproject.cloudDataSetTableAdapters.ADMINDISPLAYTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ADMINDISPLAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(54, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTRATION DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(54, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "EVENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(48, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TEAM NAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(47, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "COLLEGE NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(47, 455)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DEPARTMENT"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(371, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 26)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(371, 69)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(202, 26)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(371, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(202, 26)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(371, 262)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(202, 26)
        Me.TextBox4.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(64, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "EVENT ID"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(371, 303)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(202, 26)
        Me.TextBox5.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(47, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 22)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "CONTACT NUMBER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(54, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 22)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "REGISTER ID"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(371, 347)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(202, 26)
        Me.TextBox6.TabIndex = 25
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(371, 398)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(202, 26)
        Me.TextBox7.TabIndex = 26
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(371, 451)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(202, 26)
        Me.TextBox8.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(47, 504)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "EMAIL ID"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(371, 500)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(202, 26)
        Me.TextBox9.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(114, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 43)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EVENTIDDataGridViewTextBoxColumn, Me.EVENTNAMEDataGridViewTextBoxColumn, Me.VENUEDataGridViewTextBoxColumn, Me.DATEDataGridViewTextBoxColumn, Me.COORDINATORNAMEDataGridViewTextBoxColumn, Me.CONTACTNUMBERDataGridViewTextBoxColumn, Me.CollegeidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ADMINDISPLAYBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(466, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1042, 673)
        Me.DataGridView1.TabIndex = 31
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
        Me.EVENTNAMEDataGridViewTextBoxColumn.Width = 130
        '
        'VENUEDataGridViewTextBoxColumn
        '
        Me.VENUEDataGridViewTextBoxColumn.DataPropertyName = "VENUE"
        Me.VENUEDataGridViewTextBoxColumn.HeaderText = "VENUE"
        Me.VENUEDataGridViewTextBoxColumn.Name = "VENUEDataGridViewTextBoxColumn"
        Me.VENUEDataGridViewTextBoxColumn.Width = 130
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
        Me.COORDINATORNAMEDataGridViewTextBoxColumn.Width = 110
        '
        'CONTACTNUMBERDataGridViewTextBoxColumn
        '
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "CONTACTNUMBER"
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.HeaderText = "CONTACTNUMBER"
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.Name = "CONTACTNUMBERDataGridViewTextBoxColumn"
        Me.CONTACTNUMBERDataGridViewTextBoxColumn.Width = 120
        '
        'CollegeidDataGridViewTextBoxColumn
        '
        Me.CollegeidDataGridViewTextBoxColumn.DataPropertyName = "collegeid"
        Me.CollegeidDataGridViewTextBoxColumn.HeaderText = "COLLEGE ID"
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
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(371, 218)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(202, 26)
        Me.TextBox10.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(54, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 22)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "VENUE"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(371, 165)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(202, 26)
        Me.TextBox11.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(50, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 22)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "COLLEGE ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1508, 673)
        Me.Panel1.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.TextBox9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TextBox11)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox10)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 700)
        Me.Panel2.TabIndex = 38
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(305, 584)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 43)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ADMINDISPLAYTableAdapter
        '
        Me.ADMINDISPLAYTableAdapter.ClearBeforeFill = True
        '
        'registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1508, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "registration"
        Me.Text = "REGISTRATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ADMINDISPLAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloudDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
