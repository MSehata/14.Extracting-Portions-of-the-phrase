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
        btnLeftFunction = New Button()
        btnRightFunction = New Button()
        btnMidFunction = New Button()
        btnClose = New Button()
        lblHeading = New Label()
        lblEnterAPhrase = New Label()
        Label1 = New Label()
        txtEnterAPhrase = New TextBox()
        txtSelectedFunctionResult = New TextBox()
        SuspendLayout()
        ' 
        ' btnLeftFunction
        ' 
        btnLeftFunction.Location = New Point(125, 297)
        btnLeftFunction.Name = "btnLeftFunction"
        btnLeftFunction.Size = New Size(113, 53)
        btnLeftFunction.TabIndex = 0
        btnLeftFunction.Text = "Left Function"
        btnLeftFunction.UseVisualStyleBackColor = True
        ' 
        ' btnRightFunction
        ' 
        btnRightFunction.Location = New Point(563, 297)
        btnRightFunction.Name = "btnRightFunction"
        btnRightFunction.Size = New Size(113, 53)
        btnRightFunction.TabIndex = 0
        btnRightFunction.Text = "Right Function"
        btnRightFunction.UseVisualStyleBackColor = True
        ' 
        ' btnMidFunction
        ' 
        btnMidFunction.Location = New Point(337, 297)
        btnMidFunction.Name = "btnMidFunction"
        btnMidFunction.Size = New Size(113, 53)
        btnMidFunction.TabIndex = 0
        btnMidFunction.Text = "Mid Function"
        btnMidFunction.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(324, 389)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(137, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblHeading.ForeColor = SystemColors.Highlight
        lblHeading.Location = New Point(174, 22)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(455, 36)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Extract Part of a Phrase"
        ' 
        ' lblEnterAPhrase
        ' 
        lblEnterAPhrase.AutoSize = True
        lblEnterAPhrase.Location = New Point(136, 127)
        lblEnterAPhrase.Name = "lblEnterAPhrase"
        lblEnterAPhrase.Size = New Size(102, 20)
        lblEnterAPhrase.TabIndex = 2
        lblEnterAPhrase.Text = "Enter a Phrase"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(136, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 20)
        Label1.TabIndex = 2
        Label1.Text = "Selected Function Result"
        ' 
        ' txtEnterAPhrase
        ' 
        txtEnterAPhrase.Location = New Point(410, 120)
        txtEnterAPhrase.Name = "txtEnterAPhrase"
        txtEnterAPhrase.Size = New Size(297, 27)
        txtEnterAPhrase.TabIndex = 3
        ' 
        ' txtSelectedFunctionResult
        ' 
        txtSelectedFunctionResult.BackColor = SystemColors.ButtonFace
        txtSelectedFunctionResult.Location = New Point(410, 177)
        txtSelectedFunctionResult.Name = "txtSelectedFunctionResult"
        txtSelectedFunctionResult.Size = New Size(297, 27)
        txtSelectedFunctionResult.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtSelectedFunctionResult)
        Controls.Add(txtEnterAPhrase)
        Controls.Add(Label1)
        Controls.Add(lblEnterAPhrase)
        Controls.Add(lblHeading)
        Controls.Add(btnMidFunction)
        Controls.Add(btnClose)
        Controls.Add(btnRightFunction)
        Controls.Add(btnLeftFunction)
        Name = "Form1"
        Text = "Extract part of a Phrase"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLeftFunction As Button
    Friend WithEvents btnRightFunction As Button
    Friend WithEvents btnMidFunction As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblEnterAPhrase As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEnterAPhrase As TextBox
    Friend WithEvents txtSelectedFunctionResult As TextBox
End Class
