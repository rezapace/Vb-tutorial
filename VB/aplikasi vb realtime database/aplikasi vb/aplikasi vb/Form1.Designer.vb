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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Maintenen = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TBSuhu = New System.Windows.Forms.TextBox()
        Me.TBOprate = New System.Windows.Forms.TextBox()
        Me.TBDates = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBJenis = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TBJenis)
        Me.Panel1.Controls.Add(Me.Maintenen)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.TBSuhu)
        Me.Panel1.Controls.Add(Me.TBOprate)
        Me.Panel1.Controls.Add(Me.TBDates)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(33, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 291)
        Me.Panel1.TabIndex = 0
        '
        'Maintenen
        '
        Me.Maintenen.AutoSize = True
        Me.Maintenen.Location = New System.Drawing.Point(44, 12)
        Me.Maintenen.Name = "Maintenen"
        Me.Maintenen.Size = New System.Drawing.Size(56, 13)
        Me.Maintenen.TabIndex = 10
        Me.Maintenen.Text = "maintenen"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(48, 223)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(144, 36)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "up to server"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TBSuhu
        '
        Me.TBSuhu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSuhu.Location = New System.Drawing.Point(261, 161)
        Me.TBSuhu.Name = "TBSuhu"
        Me.TBSuhu.Size = New System.Drawing.Size(285, 26)
        Me.TBSuhu.TabIndex = 8
        '
        'TBOprate
        '
        Me.TBOprate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBOprate.Location = New System.Drawing.Point(261, 129)
        Me.TBOprate.Name = "TBOprate"
        Me.TBOprate.Size = New System.Drawing.Size(285, 26)
        Me.TBOprate.TabIndex = 7
        '
        'TBDates
        '
        Me.TBDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBDates.Location = New System.Drawing.Point(261, 57)
        Me.TBDates.Name = "TBDates"
        Me.TBDates.Size = New System.Drawing.Size(285, 26)
        Me.TBDates.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Suhu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Waktu beroprasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Mesin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'TBJenis
        '
        Me.TBJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBJenis.Location = New System.Drawing.Point(261, 93)
        Me.TBJenis.Name = "TBJenis"
        Me.TBJenis.Size = New System.Drawing.Size(285, 26)
        Me.TBJenis.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 332)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents TBSuhu As TextBox
    Friend WithEvents TBOprate As TextBox
    Friend WithEvents TBDates As TextBox
    Friend WithEvents Label5 As Label

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Friend WithEvents Maintenen As Label
    Friend WithEvents TBJenis As TextBox
End Class
