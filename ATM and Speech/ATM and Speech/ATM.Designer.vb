<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ATM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Button18 = New Button()
        Button17 = New Button()
        TabControl1 = New TabControl()
        TabPage3 = New TabPage()
        Button21 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TabPage1 = New TabPage()
        AccNumTb = New TextBox()
        Label6 = New Label()
        Button22 = New Button()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        TbAccNum = New TextBox()
        Label5 = New Label()
        BtnUpdate = New Button()
        TbNewPin = New TextBox()
        Label4 = New Label()
        TbCurrPin = New TextBox()
        Label3 = New Label()
        Panel2 = New Panel()
        Label17 = New Label()
        Transfer = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Panel3 = New Panel()
        Button20 = New Button()
        Button19 = New Button()
        Panel4 = New Panel()
        Button16 = New Button()
        Button15 = New Button()
        Button14 = New Button()
        Button13 = New Button()
        Button12 = New Button()
        Button11 = New Button()
        Button10 = New Button()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        lblHeading = New Label()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button18)
        Panel1.Controls.Add(Button17)
        Panel1.Location = New Point(46, 40)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(252, 280)
        Panel1.TabIndex = 0
        ' 
        ' Button18
        ' 
        Button18.Location = New Point(110, 155)
        Button18.Margin = New Padding(4)
        Button18.Name = "Button18"
        Button18.Size = New Size(118, 82)
        Button18.TabIndex = 17
        Button18.Text = "->"
        Button18.UseVisualStyleBackColor = True
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(110, 25)
        Button17.Margin = New Padding(4)
        Button17.Name = "Button17"
        Button17.Size = New Size(118, 86)
        Button17.TabIndex = 16
        Button17.Text = "->"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(1022, 40)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(650, 744)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Button21)
        TabPage3.Controls.Add(TextBox1)
        TabPage3.Controls.Add(Label1)
        TabPage3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(4)
        TabPage3.Size = New Size(642, 706)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Withdraw"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button21
        ' 
        Button21.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button21.Location = New Point(190, 180)
        Button21.Margin = New Padding(4)
        Button21.Name = "Button21"
        Button21.Size = New Size(229, 66)
        Button21.TabIndex = 8
        Button21.Text = "Withdraw"
        Button21.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(209, 54)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(330, 31)
        TextBox1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(12, 57)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 25)
        Label1.TabIndex = 0
        Label1.Text = "Withdrawal Amount:"
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(AccNumTb)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Button22)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(642, 706)
        TabPage1.TabIndex = 3
        TabPage1.Text = "Transfer"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' AccNumTb
        ' 
        AccNumTb.Location = New Point(236, 155)
        AccNumTb.Margin = New Padding(4)
        AccNumTb.Name = "AccNumTb"
        AccNumTb.Size = New Size(323, 31)
        AccNumTb.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(35, 155)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(163, 25)
        Label6.TabIndex = 3
        Label6.Text = "Account Number:"
        ' 
        ' Button22
        ' 
        Button22.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button22.Location = New Point(220, 254)
        Button22.Margin = New Padding(4)
        Button22.Name = "Button22"
        Button22.Size = New Size(247, 60)
        Button22.TabIndex = 2
        Button22.Text = "Transfer"
        Button22.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(236, 70)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(323, 31)
        TextBox2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(35, 70)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 25)
        Label2.TabIndex = 0
        Label2.Text = "Transfer Amount:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TbAccNum)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(BtnUpdate)
        TabPage2.Controls.Add(TbNewPin)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(TbCurrPin)
        TabPage2.Controls.Add(Label3)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(642, 706)
        TabPage2.TabIndex = 4
        TabPage2.Text = "Change Pin"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TbAccNum
        ' 
        TbAccNum.Location = New Point(214, 77)
        TbAccNum.Margin = New Padding(4)
        TbAccNum.Name = "TbAccNum"
        TbAccNum.Size = New Size(305, 31)
        TbAccNum.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(43, 80)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(163, 25)
        Label5.TabIndex = 5
        Label5.Text = "Account Number:"
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnUpdate.Location = New Point(166, 397)
        BtnUpdate.Margin = New Padding(4)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(305, 62)
        BtnUpdate.TabIndex = 4
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' TbNewPin
        ' 
        TbNewPin.Location = New Point(214, 283)
        TbNewPin.Margin = New Padding(4)
        TbNewPin.Name = "TbNewPin"
        TbNewPin.Size = New Size(305, 31)
        TbNewPin.TabIndex = 3
        TbNewPin.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(43, 286)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 25)
        Label4.TabIndex = 2
        Label4.Text = "New Pin:"
        ' 
        ' TbCurrPin
        ' 
        TbCurrPin.Location = New Point(214, 172)
        TbCurrPin.Margin = New Padding(4)
        TbCurrPin.Name = "TbCurrPin"
        TbCurrPin.Size = New Size(305, 31)
        TbCurrPin.TabIndex = 1
        TbCurrPin.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(43, 175)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 25)
        Label3.TabIndex = 0
        Label3.Text = "Current Pin:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Panel2.Controls.Add(Label17)
        Panel2.Controls.Add(Transfer)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Label13)
        Panel2.Location = New Point(306, 40)
        Panel2.Margin = New Padding(4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(419, 280)
        Panel2.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(152, 114)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(0, 25)
        Label17.TabIndex = 4
        ' 
        ' Transfer
        ' 
        Transfer.AutoSize = True
        Transfer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Transfer.Location = New Point(326, 189)
        Transfer.Margin = New Padding(4, 0, 4, 0)
        Transfer.Name = "Transfer"
        Transfer.Size = New Size(82, 25)
        Transfer.TabIndex = 3
        Transfer.Text = "Transfer"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label15.Location = New Point(16, 189)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(110, 25)
        Label15.TabIndex = 2
        Label15.Text = "Withdrawal"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label14.Location = New Point(307, 63)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(108, 25)
        Label14.TabIndex = 1
        Label14.Text = "Change pin"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label13.Location = New Point(16, 63)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(79, 25)
        Label13.TabIndex = 0
        Label13.Text = "Balance"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button20)
        Panel3.Controls.Add(Button19)
        Panel3.Location = New Point(732, 40)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(252, 280)
        Panel3.TabIndex = 2
        ' 
        ' Button20
        ' 
        Button20.Location = New Point(25, 164)
        Button20.Margin = New Padding(4)
        Button20.Name = "Button20"
        Button20.Size = New Size(118, 74)
        Button20.TabIndex = 17
        Button20.Text = "<-"
        Button20.UseVisualStyleBackColor = True
        ' 
        ' Button19
        ' 
        Button19.Location = New Point(25, 36)
        Button19.Margin = New Padding(4)
        Button19.Name = "Button19"
        Button19.Size = New Size(118, 79)
        Button19.TabIndex = 16
        Button19.Text = "<-"
        Button19.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button16)
        Panel4.Controls.Add(Button15)
        Panel4.Controls.Add(Button14)
        Panel4.Controls.Add(Button13)
        Panel4.Controls.Add(Button12)
        Panel4.Controls.Add(Button11)
        Panel4.Controls.Add(Button10)
        Panel4.Controls.Add(Button7)
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(Button3)
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(Button1)
        Panel4.Location = New Point(46, 328)
        Panel4.Margin = New Padding(4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(939, 456)
        Panel4.TabIndex = 2
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(141, 119)
        Button16.Margin = New Padding(4)
        Button16.Name = "Button16"
        Button16.Size = New Size(118, 86)
        Button16.TabIndex = 15
        Button16.Text = "4"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(316, 119)
        Button15.Margin = New Padding(4)
        Button15.Name = "Button15"
        Button15.Size = New Size(118, 86)
        Button15.TabIndex = 14
        Button15.Text = "5"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(490, 231)
        Button14.Margin = New Padding(4)
        Button14.Name = "Button14"
        Button14.Size = New Size(118, 86)
        Button14.TabIndex = 13
        Button14.Text = "9"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(490, 341)
        Button13.Margin = New Padding(4)
        Button13.Name = "Button13"
        Button13.Size = New Size(118, 86)
        Button13.TabIndex = 12
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(141, 231)
        Button12.Margin = New Padding(4)
        Button12.Name = "Button12"
        Button12.Size = New Size(118, 86)
        Button12.TabIndex = 11
        Button12.Text = "7"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(141, 341)
        Button11.Margin = New Padding(4)
        Button11.Name = "Button11"
        Button11.Size = New Size(118, 86)
        Button11.TabIndex = 10
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(316, 341)
        Button10.Margin = New Padding(4)
        Button10.Name = "Button10"
        Button10.Size = New Size(118, 86)
        Button10.TabIndex = 9
        Button10.Text = "0"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button7.Location = New Point(686, 231)
        Button7.Margin = New Padding(4)
        Button7.Name = "Button7"
        Button7.Size = New Size(118, 86)
        Button7.TabIndex = 6
        Button7.Text = "Clear"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(316, 231)
        Button6.Margin = New Padding(4)
        Button6.Name = "Button6"
        Button6.Size = New Size(118, 86)
        Button6.TabIndex = 5
        Button6.Text = "8"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(490, 119)
        Button5.Margin = New Padding(4)
        Button5.Name = "Button5"
        Button5.Size = New Size(118, 86)
        Button5.TabIndex = 4
        Button5.TabStop = False
        Button5.Text = "6"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(316, 18)
        Button4.Margin = New Padding(4)
        Button4.Name = "Button4"
        Button4.Size = New Size(118, 86)
        Button4.TabIndex = 3
        Button4.Text = "2"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(490, 18)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 86)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(686, 119)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 86)
        Button2.TabIndex = 1
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(141, 18)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 86)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' lblHeading
        ' 
        lblHeading.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblHeading.Location = New Point(934, -8)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(136, 44)
        lblHeading.TabIndex = 6
        lblHeading.Text = "JLK Bank"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ATM
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1688, 816)
        Controls.Add(lblHeading)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Margin = New Padding(4)
        Name = "ATM"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Transfer As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button21 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button22 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents TbNewPin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbCurrPin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbAccNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AccNumTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblHeading As Label
End Class
