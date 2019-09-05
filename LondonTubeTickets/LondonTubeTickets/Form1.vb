' Program Name: London Tube Tickets
' Author:       Sean Ervin
' Date:         September 5, 2019
' Purpose:      This windows application computes the estimated cost of riding depending on
'               the zone and how many tickets they need.
Public Class frmLondonTubeTickets
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' The btnCalculate event handler calculated the estimated cost of the tube rides
        ' based on the amount of people and the type of ticket.
        Dim decCost As Decimal
        Dim decTicketCost As Decimal

        ' Did user enter a numberic value?
        If IsNumeric(txtSize.Text) Then
            decCost = Convert.ToDecimal(txtSize.Text)

            ' Get the type of ticket they want
            If radZones13.Checked Then
                decTicketCost = 4.9
            ElseIf radZones15.Checked Then
                decTicketCost = 5.9
            ElseIf radZones16.Checked Then
                decTicketCost = 6
            End If

            ' Is Square Footage greater than zero
            If decCost > 0 Then
                ' Calculate and display the cost estimate
                decCost *= decTicketCost
                decCost *= 1.23 ' Convert to USD
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
        ' and sets the focus to the ticket amount text box.
        txtSize.Clear()
        lblCost.Text = ""
        radZones13.Checked = True
        radZones15.Checked = False
        radZones16.Checked = False
        txtSize.Focus()
    End Sub

    Private Sub FrmDeckingCostCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of 
        ' the program. It sets the focus to the group size text box and
        ' clears the cost label.

        txtSize.Focus()
        lblCost.Text = ""
    End Sub
End Class
