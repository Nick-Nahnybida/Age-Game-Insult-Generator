Public Class btnMeany

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intAge As Integer


        intAge = CInt(txtUserInput.Text)

        Try
            ' Determine the output
            Select Case intAge
                Case Is < 18
                    lblResult.Text = "Where are your parents?"

                Case 18 To 25
                    lblResult.Text = "Are you in your parents' basement?"

                Case 26
                    lblResult.Text = "Shouldn't you be working or something?"

                Case 27 To 35
                    lblResult.Text = "Getting a promotion any time soon?"

                Case 36 To 45
                    lblResult.Text = "How's that family coming huh?"

                Case 46 To 55
                    lblResult.Text = "Mid life crisis coming shortly"

                Case 56 To 75
                    lblResult.Text = "Which kid is trying to avoid you now?"

                Case Is >= 75
                    lblResult.Text = "How many pills a day are you up to?"
            End Select
        Catch
        End Try
        'If intAge <= 18 Then
        '    lblResult.Text = "Where are your parents?"

        'ElseIf intAge > 18 And intAge <= 25 Then
        '    lblResult.Text = "Are you in your parents' basement?"

        'ElseIf intAge = 26 Then
        '    lblResult.Text = "Shouldn't you be working or something?"

        'ElseIf intAge > 26 And intAge <= 35 Then
        '    lblResult.Text = "Getting a promotion any time soon?"

        'ElseIf intAge >= 36 And intAge <= 45 Then
        '    lblResult.Text = "How's that family coming huh?"

        'ElseIf intAge >= 46 And intAge <= 55 Then
        '    lblResult.Text = "Mid life crisis coming shortly"

        'ElseIf intAge >= 56 And intAge <= 75 Then
        '    lblResult.Text = "Which kid is trying to avoid you now?"

        'ElseIf intAge >= 75 Then
        '    lblResult.Text = "How many pills a day are you up to?"
        'End If
    End Sub
End Class
