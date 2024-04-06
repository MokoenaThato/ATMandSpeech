<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        lblHeading = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(131, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter Account Number :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(379, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(263, 31)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(131, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 25)
        Label2.TabIndex = 2
        Label2.Text = "Enter Password :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(379, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(263, 31)
        TextBox2.TabIndex = 3
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(254, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 41)
        Button1.TabIndex = 4
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblHeading
        ' 
        lblHeading.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeading.Location = New Point(274, 19)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(179, 67)
        lblHeading.TabIndex = 5
        lblHeading.Text = "JLK Bank"
        lblHeading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(747, 363)
        Controls.Add(lblHeading)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblHeading As Label

End Class
