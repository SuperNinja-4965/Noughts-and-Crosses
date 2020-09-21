<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameSamePlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnTracker = New System.Windows.Forms.ToolStripMenuItem()
        Me.Moveslbl = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player1lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.Player2lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.GridBtn11 = New System.Windows.Forms.Button()
        Me.GridBtn21 = New System.Windows.Forms.Button()
        Me.GridBtn31 = New System.Windows.Forms.Button()
        Me.GridBtn12 = New System.Windows.Forms.Button()
        Me.GridBtn22 = New System.Windows.Forms.Button()
        Me.GridBtn32 = New System.Windows.Forms.Button()
        Me.GridBtn13 = New System.Windows.Forms.Button()
        Me.GridBtn23 = New System.Windows.Forms.Button()
        Me.GridBtn33 = New System.Windows.Forms.Button()
        Me.OpenGameDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveGameDialog = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TurnTracker, Me.Moveslbl})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 64)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(327, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.NewGameSamePlayersToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveGameToolStripMenuItem, Me.OpenGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'NewGameSamePlayersToolStripMenuItem
        '
        Me.NewGameSamePlayersToolStripMenuItem.Name = "NewGameSamePlayersToolStripMenuItem"
        Me.NewGameSamePlayersToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewGameSamePlayersToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.NewGameSamePlayersToolStripMenuItem.Text = "New Game (Same Players)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(284, 6)
        '
        'SaveGameToolStripMenuItem
        '
        Me.SaveGameToolStripMenuItem.Name = "SaveGameToolStripMenuItem"
        Me.SaveGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveGameToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.SaveGameToolStripMenuItem.Text = "Save Game"
        '
        'OpenGameToolStripMenuItem
        '
        Me.OpenGameToolStripMenuItem.Name = "OpenGameToolStripMenuItem"
        Me.OpenGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenGameToolStripMenuItem.Size = New System.Drawing.Size(287, 22)
        Me.OpenGameToolStripMenuItem.Text = "Open Game"
        '
        'TurnTracker
        '
        Me.TurnTracker.AutoToolTip = True
        Me.TurnTracker.Name = "TurnTracker"
        Me.TurnTracker.Size = New System.Drawing.Size(83, 20)
        Me.TurnTracker.Text = "Turn Tracker"
        '
        'Moveslbl
        '
        Me.Moveslbl.AutoToolTip = True
        Me.Moveslbl.Name = "Moveslbl"
        Me.Moveslbl.Size = New System.Drawing.Size(57, 20)
        Me.Moveslbl.Text = "Moves:"
        '
        'Player1lbl
        '
        Me.Player1lbl.AutoSize = True
        Me.Player1lbl.Depth = 0
        Me.Player1lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Player1lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Player1lbl.Location = New System.Drawing.Point(3, 90)
        Me.Player1lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Player1lbl.Name = "Player1lbl"
        Me.Player1lbl.Size = New System.Drawing.Size(176, 19)
        Me.Player1lbl.TabIndex = 1
        Me.Player1lbl.Text = "Player1 (Name): Crosses"
        '
        'Player2lbl
        '
        Me.Player2lbl.AutoSize = True
        Me.Player2lbl.Depth = 0
        Me.Player2lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Player2lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Player2lbl.Location = New System.Drawing.Point(3, 109)
        Me.Player2lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.Player2lbl.Name = "Player2lbl"
        Me.Player2lbl.Size = New System.Drawing.Size(177, 19)
        Me.Player2lbl.TabIndex = 2
        Me.Player2lbl.Text = "Player2 (Name): Noughts"
        '
        'GridBtn11
        '
        Me.GridBtn11.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn11.FlatAppearance.BorderSize = 0
        Me.GridBtn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn11.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn11.ForeColor = System.Drawing.Color.White
        Me.GridBtn11.Location = New System.Drawing.Point(7, 138)
        Me.GridBtn11.Name = "GridBtn11"
        Me.GridBtn11.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn11.TabIndex = 3
        Me.GridBtn11.Text = "X"
        Me.GridBtn11.UseVisualStyleBackColor = False
        '
        'GridBtn21
        '
        Me.GridBtn21.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn21.FlatAppearance.BorderSize = 0
        Me.GridBtn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn21.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn21.ForeColor = System.Drawing.Color.White
        Me.GridBtn21.Location = New System.Drawing.Point(113, 138)
        Me.GridBtn21.Name = "GridBtn21"
        Me.GridBtn21.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn21.TabIndex = 4
        Me.GridBtn21.Text = "X"
        Me.GridBtn21.UseVisualStyleBackColor = False
        '
        'GridBtn31
        '
        Me.GridBtn31.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn31.FlatAppearance.BorderSize = 0
        Me.GridBtn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn31.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn31.ForeColor = System.Drawing.Color.White
        Me.GridBtn31.Location = New System.Drawing.Point(219, 138)
        Me.GridBtn31.Name = "GridBtn31"
        Me.GridBtn31.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn31.TabIndex = 5
        Me.GridBtn31.Text = "X"
        Me.GridBtn31.UseVisualStyleBackColor = False
        '
        'GridBtn12
        '
        Me.GridBtn12.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn12.FlatAppearance.BorderSize = 0
        Me.GridBtn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn12.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn12.ForeColor = System.Drawing.Color.White
        Me.GridBtn12.Location = New System.Drawing.Point(7, 244)
        Me.GridBtn12.Name = "GridBtn12"
        Me.GridBtn12.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn12.TabIndex = 6
        Me.GridBtn12.Text = "X"
        Me.GridBtn12.UseVisualStyleBackColor = False
        '
        'GridBtn22
        '
        Me.GridBtn22.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn22.FlatAppearance.BorderSize = 0
        Me.GridBtn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn22.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn22.ForeColor = System.Drawing.Color.White
        Me.GridBtn22.Location = New System.Drawing.Point(113, 244)
        Me.GridBtn22.Name = "GridBtn22"
        Me.GridBtn22.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn22.TabIndex = 7
        Me.GridBtn22.Text = "X"
        Me.GridBtn22.UseVisualStyleBackColor = False
        '
        'GridBtn32
        '
        Me.GridBtn32.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn32.FlatAppearance.BorderSize = 0
        Me.GridBtn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn32.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn32.ForeColor = System.Drawing.Color.White
        Me.GridBtn32.Location = New System.Drawing.Point(219, 244)
        Me.GridBtn32.Name = "GridBtn32"
        Me.GridBtn32.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn32.TabIndex = 8
        Me.GridBtn32.Text = "X"
        Me.GridBtn32.UseVisualStyleBackColor = False
        '
        'GridBtn13
        '
        Me.GridBtn13.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn13.FlatAppearance.BorderSize = 0
        Me.GridBtn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn13.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn13.ForeColor = System.Drawing.Color.White
        Me.GridBtn13.Location = New System.Drawing.Point(7, 350)
        Me.GridBtn13.Name = "GridBtn13"
        Me.GridBtn13.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn13.TabIndex = 9
        Me.GridBtn13.Text = "X"
        Me.GridBtn13.UseVisualStyleBackColor = False
        '
        'GridBtn23
        '
        Me.GridBtn23.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn23.FlatAppearance.BorderSize = 0
        Me.GridBtn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn23.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn23.ForeColor = System.Drawing.Color.White
        Me.GridBtn23.Location = New System.Drawing.Point(113, 350)
        Me.GridBtn23.Name = "GridBtn23"
        Me.GridBtn23.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn23.TabIndex = 10
        Me.GridBtn23.Text = "X"
        Me.GridBtn23.UseVisualStyleBackColor = False
        '
        'GridBtn33
        '
        Me.GridBtn33.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.GridBtn33.FlatAppearance.BorderSize = 0
        Me.GridBtn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GridBtn33.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold)
        Me.GridBtn33.ForeColor = System.Drawing.Color.White
        Me.GridBtn33.Location = New System.Drawing.Point(219, 350)
        Me.GridBtn33.Name = "GridBtn33"
        Me.GridBtn33.Size = New System.Drawing.Size(100, 100)
        Me.GridBtn33.TabIndex = 11
        Me.GridBtn33.Text = "X"
        Me.GridBtn33.UseVisualStyleBackColor = False
        '
        'OpenGameDialog
        '
        Me.OpenGameDialog.DefaultExt = "*.NandC"
        Me.OpenGameDialog.Filter = "N and C File | *.NandC"
        Me.OpenGameDialog.Title = "Open an Old Game"
        '
        'SaveGameDialog
        '
        Me.SaveGameDialog.DefaultExt = "NandC"
        Me.SaveGameDialog.Filter = "N and C File | *.NandC"
        Me.SaveGameDialog.Title = "Save the Current Game"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 459)
        Me.Controls.Add(Me.GridBtn33)
        Me.Controls.Add(Me.GridBtn23)
        Me.Controls.Add(Me.GridBtn13)
        Me.Controls.Add(Me.GridBtn32)
        Me.Controls.Add(Me.GridBtn22)
        Me.Controls.Add(Me.GridBtn12)
        Me.Controls.Add(Me.GridBtn31)
        Me.Controls.Add(Me.GridBtn21)
        Me.Controls.Add(Me.GridBtn11)
        Me.Controls.Add(Me.Player2lbl)
        Me.Controls.Add(Me.Player1lbl)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "Game"
        Me.Padding = New System.Windows.Forms.Padding(0, 64, 0, 0)
        Me.Text = "Noughts and Crosses"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Player1lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Player2lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TurnTracker As ToolStripMenuItem
    Friend WithEvents GridBtn11 As Button
    Friend WithEvents GridBtn21 As Button
    Friend WithEvents GridBtn31 As Button
    Friend WithEvents GridBtn12 As Button
    Friend WithEvents GridBtn22 As Button
    Friend WithEvents GridBtn32 As Button
    Friend WithEvents GridBtn13 As Button
    Friend WithEvents GridBtn23 As Button
    Friend WithEvents GridBtn33 As Button
    Friend WithEvents Moveslbl As ToolStripMenuItem
    Friend WithEvents NewGameSamePlayersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenGameDialog As OpenFileDialog
    Friend WithEvents SaveGameDialog As SaveFileDialog
End Class
