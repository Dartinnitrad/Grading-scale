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
        TextBox1 = New TextBox()
        Label1 = New Label()
        txtmarks = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtgrade = New TextBox()
        btnEvaluate = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(353, 218)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(364, 37)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(216, 223)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 31)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' txtmarks
        ' 
        txtmarks.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtmarks.Location = New Point(353, 218)
        txtmarks.Margin = New Padding(4, 5, 4, 5)
        txtmarks.Name = "txtmarks"
        txtmarks.Size = New Size(364, 37)
        txtmarks.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(181, 218)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 30)
        Label2.TabIndex = 2
        Label2.Text = "Enter Marks"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(181, 323)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 30)
        Label3.TabIndex = 4
        Label3.Text = "Grade"
        ' 
        ' txtgrade
        ' 
        txtgrade.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtgrade.Location = New Point(297, 317)
        txtgrade.Margin = New Padding(4, 5, 4, 5)
        txtgrade.Name = "txtgrade"
        txtgrade.Size = New Size(364, 37)
        txtgrade.TabIndex = 3
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluate.Location = New Point(353, 425)
        btnEvaluate.Margin = New Padding(4, 5, 4, 5)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(154, 72)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "EVALUATE"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(127, 62)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(712, 51)
        Label4.TabIndex = 6
        Label4.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(891, 627)
        Controls.Add(Label4)
        Controls.Add(btnEvaluate)
        Controls.Add(Label3)
        Controls.Add(txtgrade)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtmarks)
        Controls.Add(TextBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Daniel Martin Malavu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmarks As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents Label4 As Label

End Class
