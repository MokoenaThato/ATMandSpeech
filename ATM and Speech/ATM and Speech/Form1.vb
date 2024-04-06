Imports System
Imports System.Numerics


Public Class Form1
    'declare variables
    Dim acc_num As String = "1234567"
    Dim psw As String = "1234"
    Dim attempts As Integer = 3
    Dim userPsw As String
    Dim userAcc As String
    Dim spi As Object = CreateObject("SAPI.spvoice") 'speech

    'declare variables
    Public accounts As New Dictionary(Of String, String)() From {
    {"1234567", "1234"},
    {"2434433", "0788"},
    {"9076546", "2222"},
    {"6643535", "5453"}
    }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spi.Speak("Hello there, Welcome to JLK Bank, the log in page will appear. Please enter your valid information to proceed")
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userAcc = TextBox1.Text
        userPsw = TextBox2.Text


        If userAcc.Length = 7 And userPsw.Length = 4 Then
            If accounts.ContainsKey(userAcc) Then
                If accounts(userAcc) = userPsw Then
                    MessageBox.Show("Hello there, you have logged in successfully. We're now taking you to the transaction screen")
                    spi.Speak("Hello there, you have logged in successfully. We're now taking you to the transaction screen")
                    Dim frm2 As New ATM

                    frm2.Show()
                    'main page
                Else
                    attempts -= 1
                    MessageBox.Show("Incorrect Password, Please Try Again. Attempts Left: " + attempts.ToString)
                    spi.Speak("Hello there, you have entered incorrect information, Please try again. You have " + attempts.ToString() + " attempts left")

                    TextBox1.Clear()
                    TextBox2.Clear()

                    TextBox1.Focus()
                End If
            End If
        Else
            MessageBox.Show("Incorrect Information, The Account Number Length Should Be 8 Digits and Account Pin 4 digits")
            spi.Speak("Incorrect Information, The Account Number Length Should Be 8 Digits and Account Pin 4 digits")

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        End If

        If attempts = 0 Then
            MessageBox.Show("You have entered incorrect details three times, you have been blocked")
            spi.Speak("You have entered incorrect details three times, you have been blocked")
        End If
    End Sub
End Class
