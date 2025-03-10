﻿Public Class Form1
    Private ipSemesterList As New List(Of Double)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ipSemester As Double

        If Double.TryParse(TextBox1.Text, ipSemester) AndAlso ipSemester >= 0 AndAlso ipSemester <= 4 Then
            ipSemesterList.Add(ipSemester)

            Dim ipk As Double = ipSemesterList.Average()
            TextBox1.Text = ipk.ToString("0.00")

            Dim predikat As String = ""
            If ipk >= 3.01 Then
                predikat = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                predikat = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                predikat = "Cukup"
            Else
                predikat = "Tidak Lulus"
            End If
            Label3.Text = predikat


            TextBox2.Text = ipSemesterList.Average()

            'TextBox1.Clear()
            'TextBox1.Focus()
        Else
            MessageBox.Show("Masukkan IP Semester yang valid (0.00 - 4.00)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ipSemesterList.Clear()
        TextBox2.Text = ""
        Label3.Text = ""
        TextBox1.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
