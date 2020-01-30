Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles labelF.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelA.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles labelB.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        labelA.Visible = True
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = True
        labelE.Visible = True
        labelF.Visible = True
        labelG.Visible = True
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        labelA.Visible = False
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = False
        labelE.Visible = False
        labelF.Visible = False
        labelG.Visible = False
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        labelA.Visible = True
        labelB.Visible = True
        labelC.Visible = False
        labelD.Visible = True
        labelE.Visible = True
        labelF.Visible = False
        labelG.Visible = True
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        labelA.Visible = True
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = True
        labelE.Visible = False
        labelF.Visible = False
        labelG.Visible = True
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        labelA.Visible = False
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = False
        labelE.Visible = False
        labelF.Visible = True
        labelG.Visible = True
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        labelA.Visible = True
        labelB.Visible = False
        labelC.Visible = True
        labelD.Visible = True
        labelE.Visible = False
        labelF.Visible = True
        labelG.Visible = True
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        labelA.Visible = True
        labelB.Visible = False
        labelC.Visible = True
        labelD.Visible = True
        labelE.Visible = True
        labelF.Visible = True
        labelG.Visible = True
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        labelA.Visible = True
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = False
        labelE.Visible = False
        labelF.Visible = False
        labelG.Visible = False
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        labelA.Visible = True
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = True
        labelE.Visible = True
        labelF.Visible = True
        labelG.Visible = True
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        labelA.Visible = True
        labelB.Visible = True
        labelC.Visible = True
        labelD.Visible = True
        labelE.Visible = False
        labelF.Visible = True
        labelG.Visible = True
    End Sub
End Class
