﻿Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text
        Dim result As String

        Dim str_bmi As Double = str1 / str2 ^ 2

        result = Format(str_bmi, "0.00")

        If str_bmi < 18.5 Then
            MessageBox.Show("BMI  :  " + result + "  Underweight")

        ElseIf str_bmi <= 24.9 And str_bmi >= 18.5 Then
            MessageBox.Show("BMI  :  " + result + "  Normal weight")

        ElseIf str_bmi <= 29.9 And str_bmi >= 25 Then
            MessageBox.Show("BMI  :  " + result + "  Overweight")

        ElseIf str_bmi >= 30 Then
            MessageBox.Show("BMI  :  " + result + "  Obesity")

        Else
            MessageBox.Show("Please insert number")

        End If


    End Sub
End Class