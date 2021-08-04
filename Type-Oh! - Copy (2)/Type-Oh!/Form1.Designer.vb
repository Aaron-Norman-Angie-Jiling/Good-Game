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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewText = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnGetApi = New System.Windows.Forms.Button()
        Me.lblNotAt = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(135, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(924, 164)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " "
        '
        'btnNewText
        '
        Me.btnNewText.Location = New System.Drawing.Point(462, 634)
        Me.btnNewText.Name = "btnNewText"
        Me.btnNewText.Size = New System.Drawing.Size(191, 59)
        Me.btnNewText.TabIndex = 1
        Me.btnNewText.Text = "Get a text"
        Me.btnNewText.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInput.Location = New System.Drawing.Point(133, 280)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(926, 220)
        Me.txtInput.TabIndex = 2
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(474, 733)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(150, 46)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(988, 747)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 46)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(79, 705)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 46)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(513, 538)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(27, 32)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "0"
        '
        'btnGetApi
        '
        Me.btnGetApi.Location = New System.Drawing.Point(183, 538)
        Me.btnGetApi.Name = "btnGetApi"
        Me.btnGetApi.Size = New System.Drawing.Size(150, 46)
        Me.btnGetApi.TabIndex = 7
        Me.btnGetApi.Text = "Fetch API"
        Me.btnGetApi.UseVisualStyleBackColor = True
        '
        'lblNotAt
        '
        Me.lblNotAt.AutoSize = True
        Me.lblNotAt.Location = New System.Drawing.Point(771, 538)
        Me.lblNotAt.Name = "lblNotAt"
        Me.lblNotAt.Size = New System.Drawing.Size(254, 32)
        Me.lblNotAt.TabIndex = 8
        Me.lblNotAt.Text = "Words Not Attempted:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(60, 781)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 46)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(966, 230)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(120, 32)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "0 seconds"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1199, 863)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblNotAt)
        Me.Controls.Add(Me.btnGetApi)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnNewText)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNewText As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents btnGetApi As Button
    Friend WithEvents lblNotAt As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
End Class
