Public Class Form1

    Private Sub CheckTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTopMost.CheckedChanged
        If CheckTopMost.Checked Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If

    End Sub

    Private Sub CheckTransparence_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTransparence.CheckedChanged
        If CheckTransparence.Checked Then
            Me.Opacity = 0.4
        Else
            Me.Opacity = 1
        End If

    End Sub

    Private Sub alignRight_CheckedChanged(sender As Object, e As EventArgs) Handles alignRight.CheckedChanged
        If alignRight.Checked Then
            ylinohyada.RightToLeft = Windows.Forms.RightToLeft.Yes
            ylinohyada.TextAlign = HorizontalAlignment.Left
            alignLeft.Checked = False
            ylinohyada.Focus()
        End If

    End Sub

    Private Sub alignLeft_CheckedChanged(sender As Object, e As EventArgs) Handles alignLeft.CheckedChanged
        If alignLeft.Checked Then
            ylinohyada.RightToLeft = Windows.Forms.RightToLeft.No
            ylinohyada.TextAlign = HorizontalAlignment.Left
            alignRight.Checked = False
            ylinohyada.Focus()
        End If
    End Sub

End Class
