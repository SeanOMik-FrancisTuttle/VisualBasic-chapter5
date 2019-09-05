' Program Name: Comic Convention
' Author:       Sean Ervin
' Date:         September 4, 2019
' Purpose:      This windows application computes the estimated cost of attending the convention based
'               on the number people attending.
Public Class frmComicConvention
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' The btnCalculate event handler calculated the estimated cost of
        ' attending the convention based on the amount of people and the type of ticket.
        Dim decCost As Decimal
        Dim decTicketCost As Decimal

        ' Did user enter a numberic value?
        If IsNumeric(txtSize.Text) Then
            decCost = Convert.ToDecimal(txtSize.Text)

            ' Get the type of ticket they want
            If radConventionSuper.Checked Then
                decTicketCost = 380
            ElseIf radConventionAutograph.Checked Then
                decTicketCost = 275
            ElseIf radConvention.Checked Then
                decTicketCost = 209
            End If

            ' Is Square Footage greater than zero
            If decCost > 0 Then
                ' Calculate and display the cost estimate
                decCost *= decTicketCost
                lblCost.Text = decCost.ToString("C")
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
        ' clears the group size text box and the cost label, resets the radio buttons,
        ' and sets the focus to the group size text box.
        txtSize.Clear()
        lblCost.Text = ""
        radConventionSuper.Checked = True
        radConventionAutograph.Checked = False
        radConvention.Checked = False
        txtSize.Focus()
    End Sub

    Private Sub FrmLondonTubeTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of 
        ' the program. It sets the focus to the group size text box and
        ' clears the cost label.

        txtSize.Focus()
        lblCost.Text = ""
    End Sub
End Class
