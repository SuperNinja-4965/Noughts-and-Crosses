<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Player1Box = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Player2Box = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.BeginGameBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.NameLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Browse = New MaterialSkin.Controls.MaterialFlatButton()
        Me.OpenGameDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 3
        '
        'Player1Box
        '
        Me.Player1Box.Depth = 0
        Me.Player1Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1Box.Hint = ""
        Me.Player1Box.Location = New System.Drawing.Point(4, 91)
        Me.Player1Box.MaxLength = 32767
        Me.Player1Box.MouseState = MaterialSkin.MouseState.HOVER
        Me.Player1Box.Name = "Player1Box"
        Me.Player1Box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Player1Box.SelectedText = ""
        Me.Player1Box.SelectionLength = 0
        Me.Player1Box.SelectionStart = 0
        Me.Player1Box.Size = New System.Drawing.Size(156, 23)
        Me.Player1Box.TabIndex = 5
        Me.Player1Box.TabStop = False
        Me.Player1Box.UseSystemPasswordChar = False
        '
        'Player2Box
        '
        Me.Player2Box.Depth = 0
        Me.Player2Box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2Box.Hint = ""
        Me.Player2Box.Location = New System.Drawing.Point(166, 91)
        Me.Player2Box.MaxLength = 32767
        Me.Player2Box.MouseState = MaterialSkin.MouseState.HOVER
        Me.Player2Box.Name = "Player2Box"
        Me.Player2Box.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Player2Box.SelectedText = ""
        Me.Player2Box.SelectionLength = 0
        Me.Player2Box.SelectionStart = 0
        Me.Player2Box.Size = New System.Drawing.Size(156, 23)
        Me.Player2Box.TabIndex = 6
        Me.Player2Box.TabStop = False
        Me.Player2Box.UseSystemPasswordChar = False
        '
        'BeginGameBtn
        '
        Me.BeginGameBtn.AutoSize = True
        Me.BeginGameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BeginGameBtn.Depth = 0
        Me.BeginGameBtn.Icon = Nothing
        Me.BeginGameBtn.Location = New System.Drawing.Point(329, 91)
        Me.BeginGameBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BeginGameBtn.MaximumSize = New System.Drawing.Size(102, 23)
        Me.BeginGameBtn.MinimumSize = New System.Drawing.Size(102, 23)
        Me.BeginGameBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.BeginGameBtn.Name = "BeginGameBtn"
        Me.BeginGameBtn.Primary = False
        Me.BeginGameBtn.Size = New System.Drawing.Size(102, 23)
        Me.BeginGameBtn.TabIndex = 7
        Me.BeginGameBtn.Text = "Begin Game"
        Me.BeginGameBtn.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Depth = 0
        Me.NameLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(4, 68)
        Me.NameLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(231, 19)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Player 1:                           Player 2:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(4, 117)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(165, 19)
        Me.MaterialLabel1.TabIndex = 9
        Me.MaterialLabel1.Text = "Or Open a Saved Game:"
        '
        'Browse
        '
        Me.Browse.AutoSize = True
        Me.Browse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Browse.Depth = 0
        Me.Browse.Icon = Nothing
        Me.Browse.Location = New System.Drawing.Point(176, 116)
        Me.Browse.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Browse.MaximumSize = New System.Drawing.Size(102, 23)
        Me.Browse.MinimumSize = New System.Drawing.Size(102, 23)
        Me.Browse.MouseState = MaterialSkin.MouseState.HOVER
        Me.Browse.Name = "Browse"
        Me.Browse.Primary = False
        Me.Browse.Size = New System.Drawing.Size(102, 23)
        Me.Browse.TabIndex = 10
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'OpenGameDialog
        '
        Me.OpenGameDialog.DefaultExt = "*.NandC"
        Me.OpenGameDialog.Filter = "N and C File | *.NandC"
        Me.OpenGameDialog.Title = "Open an Old Game"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 143)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.BeginGameBtn)
        Me.Controls.Add(Me.Player2Box)
        Me.Controls.Add(Me.Player1Box)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Padding = New System.Windows.Forms.Padding(0, 64, 0, 0)
        Me.Text = "Noughts and Crosses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Player1Box As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Player2Box As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents BeginGameBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents NameLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Browse As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents OpenGameDialog As OpenFileDialog
End Class
