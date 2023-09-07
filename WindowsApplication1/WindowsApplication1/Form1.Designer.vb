<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnCreateID = New System.Windows.Forms.Button()
        Me.BtnClearAll = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBGender = New System.Windows.Forms.ComboBox()
        Me.TBCity = New System.Windows.Forms.TextBox()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelRegistration = New System.Windows.Forms.Label()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVUserData = New System.Windows.Forms.DataGridView()
        Me.BtnClearSelection = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.CBSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBSearch = New System.Windows.Forms.TextBox()
        Me.LabelRecordView = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVUserData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnCreateID)
        Me.Panel1.Controls.Add(Me.BtnClearAll)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBGender)
        Me.Panel1.Controls.Add(Me.TBCity)
        Me.Panel1.Controls.Add(Me.TBID)
        Me.Panel1.Controls.Add(Me.TBName)
        Me.Panel1.Location = New System.Drawing.Point(32, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 292)
        Me.Panel1.TabIndex = 0
        '
        'BtnCreateID
        '
        Me.BtnCreateID.Location = New System.Drawing.Point(374, 109)
        Me.BtnCreateID.Name = "BtnCreateID"
        Me.BtnCreateID.Size = New System.Drawing.Size(81, 29)
        Me.BtnCreateID.TabIndex = 10
        Me.BtnCreateID.Text = "create id"
        Me.BtnCreateID.UseVisualStyleBackColor = True
        '
        'BtnClearAll
        '
        Me.BtnClearAll.Location = New System.Drawing.Point(167, 239)
        Me.BtnClearAll.Name = "BtnClearAll"
        Me.BtnClearAll.Size = New System.Drawing.Size(81, 29)
        Me.BtnClearAll.TabIndex = 9
        Me.BtnClearAll.Text = "clear all"
        Me.BtnClearAll.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(57, 239)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(81, 29)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "city"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama"
        '
        'CBGender
        '
        Me.CBGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGender.FormattingEnabled = True
        Me.CBGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.CBGender.Location = New System.Drawing.Point(111, 140)
        Me.CBGender.Name = "CBGender"
        Me.CBGender.Size = New System.Drawing.Size(245, 21)
        Me.CBGender.TabIndex = 3
        '
        'TBCity
        '
        Me.TBCity.Location = New System.Drawing.Point(111, 167)
        Me.TBCity.Name = "TBCity"
        Me.TBCity.Size = New System.Drawing.Size(245, 20)
        Me.TBCity.TabIndex = 2
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(111, 114)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(245, 20)
        Me.TBID.TabIndex = 1
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(111, 88)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(245, 20)
        Me.TBName.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LabelRegistration)
        Me.Panel2.Location = New System.Drawing.Point(32, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(953, 56)
        Me.Panel2.TabIndex = 0
        '
        'LabelRegistration
        '
        Me.LabelRegistration.AutoSize = True
        Me.LabelRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelRegistration.Location = New System.Drawing.Point(22, 21)
        Me.LabelRegistration.Name = "LabelRegistration"
        Me.LabelRegistration.Size = New System.Drawing.Size(89, 13)
        Me.LabelRegistration.TabIndex = 0
        Me.LabelRegistration.Text = "LabelRegistration"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGVUserData)
        Me.Panel3.Controls.Add(Me.BtnClearSelection)
        Me.Panel3.Controls.Add(Me.BtnRefresh)
        Me.Panel3.Controls.Add(Me.BtnDelete)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        Me.Panel3.Controls.Add(Me.CBSearchBy)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.TBSearch)
        Me.Panel3.Location = New System.Drawing.Point(32, 310)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(953, 417)
        Me.Panel3.TabIndex = 1
        '
        'DGVUserData
        '
        Me.DGVUserData.AllowUserToAddRows = False
        Me.DGVUserData.AllowUserToDeleteRows = False
        Me.DGVUserData.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.DGVUserData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGVUserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUserData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVUserData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DGVUserData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUserData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DGVUserData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col1, Me.Col2, Me.Col3, Me.Col4})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUserData.DefaultCellStyle = DataGridViewCellStyle18
        Me.DGVUserData.Location = New System.Drawing.Point(17, 147)
        Me.DGVUserData.Name = "DGVUserData"
        Me.DGVUserData.ReadOnly = True
        Me.DGVUserData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVUserData.RowHeadersVisible = False
        Me.DGVUserData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUserData.Size = New System.Drawing.Size(903, 244)
        Me.DGVUserData.TabIndex = 16
        '
        'BtnClearSelection
        '
        Me.BtnClearSelection.Location = New System.Drawing.Point(260, 107)
        Me.BtnClearSelection.Name = "BtnClearSelection"
        Me.BtnClearSelection.Size = New System.Drawing.Size(75, 23)
        Me.BtnClearSelection.TabIndex = 15
        Me.BtnClearSelection.Text = "clear"
        Me.BtnClearSelection.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(179, 107)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 14
        Me.BtnRefresh.Text = "refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(98, 107)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 13
        Me.BtnDelete.Text = "delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(17, 107)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 12
        Me.BtnEdit.Text = "edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'CBSearchBy
        '
        Me.CBSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSearchBy.FormattingEnabled = True
        Me.CBSearchBy.Items.AddRange(New Object() {"Name", "ID"})
        Me.CBSearchBy.Location = New System.Drawing.Point(699, 67)
        Me.CBSearchBy.Name = "CBSearchBy"
        Me.CBSearchBy.Size = New System.Drawing.Size(70, 21)
        Me.CBSearchBy.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(654, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "by id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "search here"
        '
        'TBSearch
        '
        Me.TBSearch.Location = New System.Drawing.Point(83, 64)
        Me.TBSearch.Name = "TBSearch"
        Me.TBSearch.Size = New System.Drawing.Size(553, 20)
        Me.TBSearch.TabIndex = 0
        '
        'LabelRecordView
        '
        Me.LabelRecordView.AutoSize = True
        Me.LabelRecordView.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelRecordView.Location = New System.Drawing.Point(12, 18)
        Me.LabelRecordView.Name = "LabelRecordView"
        Me.LabelRecordView.Size = New System.Drawing.Size(65, 13)
        Me.LabelRecordView.TabIndex = 1
        Me.LabelRecordView.Text = "RecordView"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LabelRecordView)
        Me.Panel4.Location = New System.Drawing.Point(32, 310)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(953, 46)
        Me.Panel4.TabIndex = 2
        '
        'Col1
        '
        Me.Col1.HeaderText = "Name"
        Me.Col1.Name = "Col1"
        Me.Col1.ReadOnly = True
        '
        'Col2
        '
        Me.Col2.HeaderText = "ID"
        Me.Col2.Name = "Col2"
        Me.Col2.ReadOnly = True
        '
        'Col3
        '
        Me.Col3.HeaderText = "Gender"
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        '
        'Col4
        '
        Me.Col4.HeaderText = "City"
        Me.Col4.Name = "Col4"
        Me.Col4.ReadOnly = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 739)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVUserData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CBGender As ComboBox
    Friend WithEvents TBCity As TextBox
    Friend WithEvents TBID As TextBox
    Friend WithEvents TBName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelRegistration As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCreateID As Button
    Friend WithEvents BtnClearAll As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelRecordView As Label
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DGVUserData As DataGridView
    Friend WithEvents BtnClearSelection As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents CBSearchBy As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Col1 As DataGridViewTextBoxColumn
    Friend WithEvents Col2 As DataGridViewTextBoxColumn
    Friend WithEvents Col3 As DataGridViewTextBoxColumn
    Friend WithEvents Col4 As DataGridViewTextBoxColumn
End Class
