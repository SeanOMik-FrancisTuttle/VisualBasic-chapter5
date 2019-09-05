' Program Name: Broadway Ticket Group Discount
' Author:       Sean Ervin
' Date:         September 5, 2019
' Purpose:      This windows application computes the estimated cost of the broadway tickets
'               with the discount applied based on the amount of people.
Public Class frmBroadwayTicketGroupDiscount
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' The btnCalculate event handler calculated the estimated cost of the the broadway 
        ' tickets with the discount applied based on the amount of people.
        Dim decCost As Decimal

        ' Did user enter a numberic value?
        If IsNumeric(txtSize.Text) Then
            decCost = Convert.ToDecimal(txtSize.Text)
            Dim intAmount As Integer = decCost

            If decCost < 9 Then
                decCost *= 249
            ElseIf decCost > 8 And decCost < 13 Then
                decCost *= 219
            ElseIf decCost > 12 And decCost < 25 Then
                decCost *= 199
            ElseIf decCost > 24 Then
                decCost *= 169
            End If

            ' Is amount of people positive
            If decCost > 0 Then
                ' Is amount fo people less than 100
                If intAmount < 100 Then
                    ' Calculate and display the cost estimate
                    lblCost.Text = decCost.ToString("C")
                Else
                    ' Display error message if user entered a number more than 99
                    MsgBox("You entered " & decCost.ToString() & ". Enter a number less than 100", , "Input Error")
                    txtSize.Text = ""
                    txtSize.Focus()
                End If
            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decCost.ToString() & ". Enter a Positive Number", , "Input Error")
                txtSize.Text = ""
                txtSize.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the Square Footage of Decking", , "Input Error")
            txtSize.Text = ""
            txtSize.Focus()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. it
        ' clears the group size text box and the cost label, and sets the focus
        ' to the ticket amount text box.
        txtSize.Clear()
        lblCost.Text = ""
        txtSize.Focus()
    End Sub

    Private Sub FrmDeckingCostCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of 
        ' the program. It sets the focus to the ticket amount text box and
        ' clears the cost label.

        txtSize.Focus()
        lblCost.Text = ""
    End Sub
End Class
