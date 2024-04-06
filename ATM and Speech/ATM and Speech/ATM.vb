Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ATM
    Private balance As Decimal = 500.0
    Dim spi As Object = CreateObject("SAPI.spvoice") 'speech

    Private Sub UpdateBalanceLabel()
        spi.Speak("Hello your available balance is " + balance.ToString("0.00"))
        Label17.Text = " Available Balance: R" & balance.ToString("0.00")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "6"
        spi.Speak("You pressed 6")
    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TabControl1.SelectedTab = TabPage2
        spi.Speak("You selected the change pin option")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        UpdateBalanceLabel()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TabControl1.SelectedTab = TabPage3
        spi.Speak("You selected the withdrawal option")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TabControl1.SelectedTab = TabPage1
        spi.Speak("You selected the transfere option")
        TextBox2.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim IExit As DialogResult

        spi.Speak("Confirm if you want to exit, select yes or no")
        IExit = MessageBox.Show("confirm if you want to exit ", "ATM ", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If IExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
        spi.Speak("You pressed 1")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "2"
        spi.Speak("You pressed 2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
        spi.Speak("You pressed 3")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text + "4"
        spi.Speak("You pressed 4")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text + "5"
        spi.Speak("You pressed 5")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + "7"
        spi.Speak("You pressed 7")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "8"
        spi.Speak("You pressed 8")


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "9"
        spi.Speak("You pressed 9")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
        spi.Speak("You pressed 0")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label17.Text = " "
        TextBox1.Text = ""
        TextBox2.Text = ""
        AccNumTb.Text = ""
        spi.Speak("You pressed the clear button")
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        UpdateBalanceLabel()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim withdrawalAmount As Decimal

        If Decimal.TryParse(TextBox1.Text, withdrawalAmount) Then
            ' Check if the withdrawal amount is valid
            If withdrawalAmount > 0 AndAlso withdrawalAmount <= balance Then
                ' Update the balance
                balance -= withdrawalAmount
                ' Display the updated balance
                UpdateBalanceLabel()
                ' Optionally, you might want to perform additional actions such as updating the database

                MessageBox.Show("You Have Successfully withdrawn R" + withdrawalAmount.ToString())
                spi.Speak("You Have Successfully withdrawn " + withdrawalAmount.ToString() + "Rands")

            Else
                MessageBox.Show("Invalid withdrawal amount or insufficient balance.")
                spi.Speak("Invalid withdrawal amount or insufficient balance.")
            End If
        Else
            MessageBox.Show("Please enter a valid withdrawal amount.")
            spi.Speak("Please enter a valid withdrawal amount.")
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim TransferAmount As Decimal
        Dim accNum As String = AccNumTb.Text
        If Decimal.TryParse(TextBox2.Text, TransferAmount) Then
            ' Check if the withdrawal amount is valid
            If (TransferAmount > 0 And TransferAmount <= balance) And balance > 1000 Then
                ' Update the balance
                balance -= TransferAmount

                ' Display the updated balance
                UpdateBalanceLabel()
                ' Optionally, you might want to perform additional actions such as updating the database
                MessageBox.Show("You Have Successfully Tranfered R" + TransferAmount.ToString + " to this account number " + accNum)
                spi.Speak("You Have Successfully Tranfered " + TransferAmount.ToString + "Rands " + " to this account number " + accNum)
            Else
                MessageBox.Show("Invalid Transfer amount or insufficient balance.")
                spi.Speak("Invalid Transfer amount or insufficient balance.")
            End If
        Else
            MessageBox.Show("Please enter a valid Transfer amount.")
            spi.Speak("Please enter a valid Transfer amount.")
        End If
    End Sub



    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim accNum As String = TbAccNum.Text
        Dim currPin As String = TbCurrPin.Text
        Dim newPin As String = TbNewPin.Text

        Dim frm1 As New Form1

        If frm1.accounts.ContainsKey(accNum) Then
            frm1.accounts(accNum) = newPin
            TbAccNum.Text = ""
            TbCurrPin.Text = ""
            TbNewPin.Text = ""
        End If

        MessageBox.Show("You have successfully updated your pin")
        spi.Speak("You have successfully updated your pin")

        MessageBox.Show("Your new updated PIN is: " + frm1.accounts(accNum))
        spi.Speak("Your new updated PIN is: " + frm1.accounts(accNum).ToString())

    End Sub

End Class
