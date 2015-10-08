<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.athleteDbLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.convertBtn = New System.Windows.Forms.Button()
        Me.meetDbLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.athleteDbDialog = New System.Windows.Forms.OpenFileDialog()
        Me.meetDbDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.meetName = New System.Windows.Forms.TextBox()
        Me.athleteDbBtn = New System.Windows.Forms.Button()
        Me.meetDbBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'athleteDbLocation
        '
        Me.athleteDbLocation.Location = New System.Drawing.Point(205, 36)
        Me.athleteDbLocation.Name = "athleteDbLocation"
        Me.athleteDbLocation.Size = New System.Drawing.Size(463, 20)
        Me.athleteDbLocation.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Athlete Reference Database"
        '
        'convertBtn
        '
        Me.convertBtn.Location = New System.Drawing.Point(205, 175)
        Me.convertBtn.Name = "convertBtn"
        Me.convertBtn.Size = New System.Drawing.Size(75, 23)
        Me.convertBtn.TabIndex = 2
        Me.convertBtn.Text = "Convert"
        Me.convertBtn.UseVisualStyleBackColor = True
        '
        'meetDbLocation
        '
        Me.meetDbLocation.Location = New System.Drawing.Point(205, 85)
        Me.meetDbLocation.Name = "meetDbLocation"
        Me.meetDbLocation.Size = New System.Drawing.Size(463, 20)
        Me.meetDbLocation.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Meet Results to Convert"
        '
        'athleteDbDialog
        '
        Me.athleteDbDialog.FileName = "athleteDbDialog"
        '
        'meetDbDialog
        '
        Me.meetDbDialog.FileName = "meetDbDialog"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Meet Name"
        '
        'meetName
        '
        Me.meetName.Location = New System.Drawing.Point(205, 133)
        Me.meetName.MaxLength = 20
        Me.meetName.Name = "meetName"
        Me.meetName.Size = New System.Drawing.Size(131, 20)
        Me.meetName.TabIndex = 6
        '
        'athleteDbBtn
        '
        Me.athleteDbBtn.Location = New System.Drawing.Point(674, 36)
        Me.athleteDbBtn.Name = "athleteDbBtn"
        Me.athleteDbBtn.Size = New System.Drawing.Size(75, 20)
        Me.athleteDbBtn.TabIndex = 7
        Me.athleteDbBtn.Text = "Choose"
        Me.athleteDbBtn.UseVisualStyleBackColor = True
        '
        'meetDbBtn
        '
        Me.meetDbBtn.Location = New System.Drawing.Point(674, 85)
        Me.meetDbBtn.Name = "meetDbBtn"
        Me.meetDbBtn.Size = New System.Drawing.Size(75, 20)
        Me.meetDbBtn.TabIndex = 8
        Me.meetDbBtn.Text = "Choose"
        Me.meetDbBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(342, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "(School mm-dd-yyy)"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 239)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.meetDbBtn)
        Me.Controls.Add(Me.athleteDbBtn)
        Me.Controls.Add(Me.meetName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.meetDbLocation)
        Me.Controls.Add(Me.convertBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.athleteDbLocation)
        Me.Name = "mainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Convert HyTek Swim Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents athleteDbLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents convertBtn As System.Windows.Forms.Button
    Friend WithEvents meetDbLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents athleteDbDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents meetDbDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents meetName As System.Windows.Forms.TextBox
    Friend WithEvents athleteDbBtn As System.Windows.Forms.Button
    Friend WithEvents meetDbBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
