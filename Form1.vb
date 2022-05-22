﻿Public Class tictactoeVB
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

End Class
