<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tictactoeVB
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.howToPlayMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.topLeftButton = New System.Windows.Forms.Button()
        Me.topMidButton = New System.Windows.Forms.Button()
        Me.topRightButton = New System.Windows.Forms.Button()
        Me.leftMidButton = New System.Windows.Forms.Button()
        Me.midButton = New System.Windows.Forms.Button()
        Me.rightMidButton = New System.Windows.Forms.Button()
        Me.botLeftButton = New System.Windows.Forms.Button()
        Me.botMidButton = New System.Windows.Forms.Button()
        Me.botRightButton = New System.Windows.Forms.Button()
        Me.tictactoeLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.helpMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newGame, Me.exitGame})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'newGame
        '
        Me.newGame.Name = "newGame"
        Me.newGame.Size = New System.Drawing.Size(180, 22)
        Me.newGame.Text = "New game"
        '
        'exitGame
        '
        Me.exitGame.Name = "exitGame"
        Me.exitGame.Size = New System.Drawing.Size(180, 22)
        Me.exitGame.Text = "Exit"
        '
        'helpMenu
        '
        Me.helpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.howToPlayMenu})
        Me.helpMenu.Name = "helpMenu"
        Me.helpMenu.Size = New System.Drawing.Size(44, 20)
        Me.helpMenu.Text = "Help"
        '
        'howToPlayMenu
        '
        Me.howToPlayMenu.Name = "howToPlayMenu"
        Me.howToPlayMenu.Size = New System.Drawing.Size(180, 22)
        Me.howToPlayMenu.Text = "How to play"
        '
        'topLeftButton
        '
        Me.topLeftButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLeftButton.Location = New System.Drawing.Point(108, 110)
        Me.topLeftButton.Name = "topLeftButton"
        Me.topLeftButton.Size = New System.Drawing.Size(75, 75)
        Me.topLeftButton.TabIndex = 1
        Me.topLeftButton.TabStop = False
        Me.topLeftButton.UseVisualStyleBackColor = True
        '
        'topMidButton
        '
        Me.topMidButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topMidButton.Location = New System.Drawing.Point(199, 110)
        Me.topMidButton.Name = "topMidButton"
        Me.topMidButton.Size = New System.Drawing.Size(75, 75)
        Me.topMidButton.TabIndex = 2
        Me.topMidButton.TabStop = False
        Me.topMidButton.UseVisualStyleBackColor = True
        '
        'topRightButton
        '
        Me.topRightButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topRightButton.Location = New System.Drawing.Point(291, 110)
        Me.topRightButton.Name = "topRightButton"
        Me.topRightButton.Size = New System.Drawing.Size(75, 75)
        Me.topRightButton.TabIndex = 3
        Me.topRightButton.TabStop = False
        Me.topRightButton.UseVisualStyleBackColor = True
        '
        'leftMidButton
        '
        Me.leftMidButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leftMidButton.Location = New System.Drawing.Point(108, 201)
        Me.leftMidButton.Name = "leftMidButton"
        Me.leftMidButton.Size = New System.Drawing.Size(75, 75)
        Me.leftMidButton.TabIndex = 4
        Me.leftMidButton.TabStop = False
        Me.leftMidButton.UseVisualStyleBackColor = True
        '
        'midButton
        '
        Me.midButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.midButton.Location = New System.Drawing.Point(199, 201)
        Me.midButton.Name = "midButton"
        Me.midButton.Size = New System.Drawing.Size(75, 75)
        Me.midButton.TabIndex = 5
        Me.midButton.TabStop = False
        Me.midButton.UseVisualStyleBackColor = True
        '
        'rightMidButton
        '
        Me.rightMidButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rightMidButton.Location = New System.Drawing.Point(291, 201)
        Me.rightMidButton.Name = "rightMidButton"
        Me.rightMidButton.Size = New System.Drawing.Size(75, 75)
        Me.rightMidButton.TabIndex = 6
        Me.rightMidButton.TabStop = False
        Me.rightMidButton.UseVisualStyleBackColor = True
        '
        'botLeftButton
        '
        Me.botLeftButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLeftButton.Location = New System.Drawing.Point(108, 291)
        Me.botLeftButton.Name = "botLeftButton"
        Me.botLeftButton.Size = New System.Drawing.Size(75, 75)
        Me.botLeftButton.TabIndex = 7
        Me.botLeftButton.TabStop = False
        Me.botLeftButton.UseVisualStyleBackColor = True
        '
        'botMidButton
        '
        Me.botMidButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botMidButton.Location = New System.Drawing.Point(199, 291)
        Me.botMidButton.Name = "botMidButton"
        Me.botMidButton.Size = New System.Drawing.Size(75, 75)
        Me.botMidButton.TabIndex = 8
        Me.botMidButton.TabStop = False
        Me.botMidButton.UseVisualStyleBackColor = True
        '
        'botRightButton
        '
        Me.botRightButton.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRightButton.Location = New System.Drawing.Point(291, 291)
        Me.botRightButton.Name = "botRightButton"
        Me.botRightButton.Size = New System.Drawing.Size(75, 75)
        Me.botRightButton.TabIndex = 9
        Me.botRightButton.TabStop = False
        Me.botRightButton.UseVisualStyleBackColor = True
        '
        'tictactoeLabel
        '
        Me.tictactoeLabel.AutoSize = True
        Me.tictactoeLabel.Font = New System.Drawing.Font("Lucida Bright", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tictactoeLabel.Location = New System.Drawing.Point(138, 51)
        Me.tictactoeLabel.Name = "tictactoeLabel"
        Me.tictactoeLabel.Size = New System.Drawing.Size(203, 36)
        Me.tictactoeLabel.TabIndex = 10
        Me.tictactoeLabel.Text = "Tic Tac Toe"
        '
        'tictactoeVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 441)
        Me.Controls.Add(Me.tictactoeLabel)
        Me.Controls.Add(Me.botRightButton)
        Me.Controls.Add(Me.botMidButton)
        Me.Controls.Add(Me.botLeftButton)
        Me.Controls.Add(Me.rightMidButton)
        Me.Controls.Add(Me.midButton)
        Me.Controls.Add(Me.leftMidButton)
        Me.Controls.Add(Me.topRightButton)
        Me.Controls.Add(Me.topMidButton)
        Me.Controls.Add(Me.topLeftButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tictactoeVB"
        Me.Text = "Tic Tac Toe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents newGame As ToolStripMenuItem
    Friend WithEvents exitGame As ToolStripMenuItem
    Friend WithEvents helpMenu As ToolStripMenuItem
    Friend WithEvents howToPlayMenu As ToolStripMenuItem
    Friend WithEvents topLeftButton As Button
    Friend WithEvents topMidButton As Button
    Friend WithEvents topRightButton As Button
    Friend WithEvents leftMidButton As Button
    Friend WithEvents midButton As Button
    Friend WithEvents rightMidButton As Button
    Friend WithEvents botLeftButton As Button
    Friend WithEvents botMidButton As Button
    Friend WithEvents botRightButton As Button
    Friend WithEvents tictactoeLabel As Label
End Class
