Public Class tictactoeVB
    Dim playturn As Boolean = True

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitGame.Click
        Application.Exit()
    End Sub

    Private Sub newGame_Click(sender As Object, e As EventArgs) Handles newGame.Click
        topLeftButton.Enabled = True
        topMidButton.Enabled = True
        topRightButton.Enabled = True
        leftMidButton.Enabled = True
        midButton.Enabled = True
        rightMidButton.Enabled = True
        botLeftButton.Enabled = True
        botMidButton.Enabled = True
        botRightButton.Enabled = True

        topLeftButton.Text = ""
        topMidButton.Text = ""
        topRightButton.Text = ""
        leftMidButton.Text = ""
        midButton.Text = ""
        rightMidButton.Text = ""
        botLeftButton.Text = ""
        botMidButton.Text = ""
        botRightButton.Text = ""

        topLeftButton.BackColor = Color.DarkSalmon
        topMidButton.BackColor = Color.DarkSalmon
        topRightButton.BackColor = Color.DarkSalmon
        leftMidButton.BackColor = Color.DarkSalmon
        midButton.BackColor = Color.DarkSalmon
        rightMidButton.BackColor = Color.DarkSalmon
        botLeftButton.BackColor = Color.DarkSalmon
        botMidButton.BackColor = Color.DarkSalmon
        botRightButton.BackColor = Color.DarkSalmon
    End Sub

    Private Sub howToPlayMenu_Click(sender As Object, e As EventArgs) Handles howToPlayMenu.Click
        MessageBox.Show("The game is played by 2 people taking turns. One person is X, and other person is O. The winning condition of the game is to have a diagonal, row, or column of matching symbols.")
    End Sub

    Private Sub buttonFalse()
        topLeftButton.Enabled = False
        topMidButton.Enabled = False
        topRightButton.Enabled = False
        leftMidButton.Enabled = False
        midButton.Enabled = False
        rightMidButton.Enabled = False
        botLeftButton.Enabled = False
        botMidButton.Enabled = False
        botRightButton.Enabled = False
    End Sub

    Private Sub checkWinner()
        'For X
        If topLeftButton.Text = "X" And topMidButton.Text = "X" And topRightButton.Text = "X" Then
            topLeftButton.BackColor = System.Drawing.Color.White
            topMidButton.BackColor = System.Drawing.Color.White
            topRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If topLeftButton.Text = "X" And midButton.Text = "X" And botRightButton.Text = "X" Then
            topLeftButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            botRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If topLeftButton.Text = "X" And leftMidButton.Text = "X" And botLeftButton.Text = "X" Then
            topLeftButton.BackColor = System.Drawing.Color.White
            leftMidButton.BackColor = System.Drawing.Color.White
            botLeftButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If leftMidButton.Text = "X" And midButton.Text = "X" And rightMidButton.Text = "X" Then
            leftMidButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            rightMidButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If topMidButton.Text = "X" And midButton.Text = "X" And botMidButton.Text = "X" Then
            topMidButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            botMidButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If botLeftButton.Text = "X" And midButton.Text = "X" And topRightButton.Text = "X" Then
            botLeftButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            topRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If botLeftButton.Text = "X" And botMidButton.Text = "X" And botRightButton.Text = "X" Then
            botLeftButton.BackColor = System.Drawing.Color.White
            botMidButton.BackColor = System.Drawing.Color.White
            botRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        If topRightButton.Text = "X" And rightMidButton.Text = "X" And botRightButton.Text = "X" Then
            topRightButton.BackColor = System.Drawing.Color.White
            rightMidButton.BackColor = System.Drawing.Color.White
            botRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("X is the Winner!")
            buttonFalse()
        End If

        'For O
        If topLeftButton.Text = "O" And topMidButton.Text = "O" And topRightButton.Text = "P" Then
            topLeftButton.BackColor = System.Drawing.Color.White
            topMidButton.BackColor = System.Drawing.Color.White
            topRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If topLeftButton.Text = "O" And midButton.Text = "O" And botRightButton.Text = "O" Then
            topLeftButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            botRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If topLeftButton.Text = "O" And leftMidButton.Text = "O" And botLeftButton.Text = "O" Then
            topLeftButton.BackColor = System.Drawing.Color.White
            leftMidButton.BackColor = System.Drawing.Color.White
            botLeftButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If leftMidButton.Text = "O" And midButton.Text = "O" And rightMidButton.Text = "O" Then
            leftMidButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            rightMidButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If topMidButton.Text = "O" And midButton.Text = "O" And botMidButton.Text = "O" Then
            topMidButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            botMidButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If botLeftButton.Text = "O" And midButton.Text = "O" And topRightButton.Text = "O" Then
            botLeftButton.BackColor = System.Drawing.Color.White
            midButton.BackColor = System.Drawing.Color.White
            topRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If botLeftButton.Text = "O" And botMidButton.Text = "O" And botRightButton.Text = "O" Then
            botLeftButton.BackColor = System.Drawing.Color.White
            botMidButton.BackColor = System.Drawing.Color.White
            botRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If

        If topRightButton.Text = "O" And rightMidButton.Text = "O" And botRightButton.Text = "O" Then
            topRightButton.BackColor = System.Drawing.Color.White
            rightMidButton.BackColor = System.Drawing.Color.White
            botRightButton.BackColor = System.Drawing.Color.White
            MessageBox.Show("O is the Winner!")
            buttonFalse()
        End If
    End Sub

    Private Sub topLeftButton_Click(sender As Object, e As EventArgs) Handles topLeftButton.Click
        If playturn = False Then
            topLeftButton.Text = "O"
            playturn = True
        Else
            topLeftButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        topLeftButton.Enabled = False
    End Sub

    Private Sub topMidButton_Click(sender As Object, e As EventArgs) Handles topMidButton.Click
        If playturn = False Then
            topMidButton.Text = "O"
            playturn = True
        Else
            topMidButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        topMidButton.Enabled = False
    End Sub

    Private Sub topRightButton_Click(sender As Object, e As EventArgs) Handles topRightButton.Click
        If playturn = False Then
            topRightButton.Text = "O"
            playturn = True
        Else
            topRightButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        topRightButton.Enabled = False
    End Sub

    Private Sub leftMidButton_Click(sender As Object, e As EventArgs) Handles leftMidButton.Click
        If playturn = False Then
            leftMidButton.Text = "O"
            playturn = True
        Else
            leftMidButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        leftMidButton.Enabled = False
    End Sub

    Private Sub midButton_Click(sender As Object, e As EventArgs) Handles midButton.Click
        If playturn = False Then
            midButton.Text = "O"
            playturn = True
        Else
            midButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        midButton.Enabled = False
    End Sub

    Private Sub rightMidButton_Click(sender As Object, e As EventArgs) Handles rightMidButton.Click
        If playturn = False Then
            rightMidButton.Text = "O"
            playturn = True
        Else
            rightMidButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        rightMidButton.Enabled = False
    End Sub

    Private Sub botLeftButton_Click(sender As Object, e As EventArgs) Handles botLeftButton.Click
        If playturn = False Then
            botLeftButton.Text = "O"
            playturn = True
        Else
            botLeftButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        botLeftButton.Enabled = False
    End Sub

    Private Sub botMidButton_Click(sender As Object, e As EventArgs) Handles botMidButton.Click
        If playturn = False Then
            botMidButton.Text = "O"
            playturn = True
        Else
            botMidButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        botMidButton.Enabled = False
    End Sub

    Private Sub botRightButton_Click(sender As Object, e As EventArgs) Handles botRightButton.Click
        If playturn = False Then
            botRightButton.Text = "O"
            playturn = True
        Else
            botRightButton.Text = "X"
            playturn = False
        End If
        checkWinner()
        botRightButton.Enabled = False
    End Sub
End Class
