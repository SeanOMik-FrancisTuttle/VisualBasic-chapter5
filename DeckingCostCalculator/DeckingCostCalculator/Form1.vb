' Program Name: Decking Dock Calculator Application
' Author:       Sean Ervin
' Date:         September 4, 2019
' Purpose:      This windows application computes the estimated cost of desking based on the
'               number of square feet and the following cost per square foot: Lumber - $2.35 per square foot;
'               Redwood - $7.75 per square foot; Composite - $8.50 per square foot.
Public Class frmDeckingCostCalc
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' The btnCalculate event handler calculated the estimated cost of
        ' desking based on the square footage and the decking type.
        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.75D
        Dim decCompositeCost As Decimal = 8.5D

        ' Did user enter a numberic value?
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)

            ' Is Square Footage greater than zero
            If decFootage > 0 Then
                ' Determine cost per square foot
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedWood.Checked Then
                    decCostPerSquareFoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If

                ' Calculate and display the cost estimate
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decFootage.ToString() & ". Enter a Positive Number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the Square Footage of Decking", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the Clear button. it
        ' clears the square footage text box and the cost estimate label, resets the radio
        ' buttons with Lumber selected, and sets the focus to the square footage text box.
        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radLumber.Checked = True
        radRedWood.Checked = False
        radComposite.Checked = False
        txtFootage.Focus()
    End Sub

    Private Sub FrmDeckingCostCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of 
        ' the program. It sets the focus to the square footage text box and
        ' clears the cost estimate label.

        txtFootage.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class
