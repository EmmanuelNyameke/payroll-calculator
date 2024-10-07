<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayroll
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
        picCalculator = New PictureBox()
        lblHeading = New Label()
        lblIncome = New Label()
        txtIncome = New TextBox()
        lblFICATax = New Label()
        lblFederalTax = New Label()
        lblStateTax = New Label()
        lblFICA = New Label()
        lblFederal = New Label()
        lblState = New Label()
        lblInfo = New Label()
        btnCalcNetPay = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblAmountsInfo = New Label()
        lblFICADeduct = New Label()
        lblSateDeduct = New Label()
        lblFederalDeduct = New Label()
        lblStateDisplay = New Label()
        lblFederalDisplay = New Label()
        lblFICADisplay = New Label()
        lblNet = New Label()
        lblNetPay = New Label()
        lblSummation = New Label()
        CType(picCalculator, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picCalculator
        ' 
        picCalculator.Dock = DockStyle.Left
        picCalculator.Image = My.Resources.Resources.Payroll
        picCalculator.Location = New Point(0, 0)
        picCalculator.Name = "picCalculator"
        picCalculator.Size = New Size(380, 512)
        picCalculator.SizeMode = PictureBoxSizeMode.StretchImage
        picCalculator.TabIndex = 0
        picCalculator.TabStop = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(556, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(154, 19)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Payroll Calculator"
        ' 
        ' lblIncome
        ' 
        lblIncome.AutoSize = True
        lblIncome.Location = New Point(473, 203)
        lblIncome.Name = "lblIncome"
        lblIncome.Size = New Size(103, 14)
        lblIncome.TabIndex = 2
        lblIncome.Text = "Biweekly Income:"
        ' 
        ' txtIncome
        ' 
        txtIncome.Location = New Point(603, 201)
        txtIncome.Name = "txtIncome"
        txtIncome.Size = New Size(63, 22)
        txtIncome.TabIndex = 3
        txtIncome.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblFICATax
        ' 
        lblFICATax.AutoSize = True
        lblFICATax.Location = New Point(538, 77)
        lblFICATax.Name = "lblFICATax"
        lblFICATax.Size = New Size(60, 14)
        lblFICATax.TabIndex = 4
        lblFICATax.Text = "FICA Tax:"
        ' 
        ' lblFederalTax
        ' 
        lblFederalTax.AutoSize = True
        lblFederalTax.Location = New Point(538, 115)
        lblFederalTax.Name = "lblFederalTax"
        lblFederalTax.Size = New Size(74, 14)
        lblFederalTax.TabIndex = 5
        lblFederalTax.Text = "Federal Tax:"
        ' 
        ' lblStateTax
        ' 
        lblStateTax.AutoSize = True
        lblStateTax.Location = New Point(538, 156)
        lblStateTax.Name = "lblStateTax"
        lblStateTax.Size = New Size(65, 14)
        lblStateTax.TabIndex = 6
        lblStateTax.Text = "State Tax:"
        ' 
        ' lblFICA
        ' 
        lblFICA.AutoSize = True
        lblFICA.Location = New Point(625, 77)
        lblFICA.Name = "lblFICA"
        lblFICA.Size = New Size(27, 14)
        lblFICA.TabIndex = 7
        lblFICA.Text = "Tax"
        ' 
        ' lblFederal
        ' 
        lblFederal.AutoSize = True
        lblFederal.Location = New Point(625, 115)
        lblFederal.Name = "lblFederal"
        lblFederal.Size = New Size(27, 14)
        lblFederal.TabIndex = 9
        lblFederal.Text = "Tax"
        ' 
        ' lblState
        ' 
        lblState.AutoSize = True
        lblState.Location = New Point(625, 156)
        lblState.Name = "lblState"
        lblState.Size = New Size(27, 14)
        lblState.TabIndex = 10
        lblState.Text = "Tax"
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(422, 46)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(365, 18)
        lblInfo.TabIndex = 11
        lblInfo.Text = "Taxes to be deducted from two-week pay period"
        ' 
        ' btnCalcNetPay
        ' 
        btnCalcNetPay.BackColor = Color.White
        btnCalcNetPay.Location = New Point(456, 455)
        btnCalcNetPay.Name = "btnCalcNetPay"
        btnCalcNetPay.Size = New Size(92, 45)
        btnCalcNetPay.TabIndex = 12
        btnCalcNetPay.Text = "Calculate Net Pay"
        btnCalcNetPay.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Location = New Point(566, 455)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(92, 45)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.White
        btnExit.Location = New Point(685, 455)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(92, 45)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblAmountsInfo
        ' 
        lblAmountsInfo.AutoSize = True
        lblAmountsInfo.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        lblAmountsInfo.Location = New Point(486, 251)
        lblAmountsInfo.Name = "lblAmountsInfo"
        lblAmountsInfo.Size = New Size(224, 18)
        lblAmountsInfo.TabIndex = 15
        lblAmountsInfo.Text = "Tax Amounts After Deduction"
        ' 
        ' lblFICADeduct
        ' 
        lblFICADeduct.AutoSize = True
        lblFICADeduct.Location = New Point(538, 278)
        lblFICADeduct.Name = "lblFICADeduct"
        lblFICADeduct.Size = New Size(60, 14)
        lblFICADeduct.TabIndex = 16
        lblFICADeduct.Text = "FICA Tax:"
        ' 
        ' lblSateDeduct
        ' 
        lblSateDeduct.AutoSize = True
        lblSateDeduct.Location = New Point(538, 360)
        lblSateDeduct.Name = "lblSateDeduct"
        lblSateDeduct.Size = New Size(65, 14)
        lblSateDeduct.TabIndex = 18
        lblSateDeduct.Text = "State Tax:"
        ' 
        ' lblFederalDeduct
        ' 
        lblFederalDeduct.AutoSize = True
        lblFederalDeduct.Location = New Point(538, 319)
        lblFederalDeduct.Name = "lblFederalDeduct"
        lblFederalDeduct.Size = New Size(74, 14)
        lblFederalDeduct.TabIndex = 17
        lblFederalDeduct.Text = "Federal Tax:"
        ' 
        ' lblStateDisplay
        ' 
        lblStateDisplay.AutoSize = True
        lblStateDisplay.Location = New Point(625, 360)
        lblStateDisplay.Name = "lblStateDisplay"
        lblStateDisplay.Size = New Size(27, 14)
        lblStateDisplay.TabIndex = 21
        lblStateDisplay.Text = "Tax"
        ' 
        ' lblFederalDisplay
        ' 
        lblFederalDisplay.AutoSize = True
        lblFederalDisplay.Location = New Point(625, 319)
        lblFederalDisplay.Name = "lblFederalDisplay"
        lblFederalDisplay.Size = New Size(27, 14)
        lblFederalDisplay.TabIndex = 20
        lblFederalDisplay.Text = "Tax"
        ' 
        ' lblFICADisplay
        ' 
        lblFICADisplay.AutoSize = True
        lblFICADisplay.Location = New Point(625, 278)
        lblFICADisplay.Name = "lblFICADisplay"
        lblFICADisplay.Size = New Size(27, 14)
        lblFICADisplay.TabIndex = 19
        lblFICADisplay.Text = "Tax"
        ' 
        ' lblNet
        ' 
        lblNet.AutoSize = True
        lblNet.Location = New Point(542, 423)
        lblNet.Name = "lblNet"
        lblNet.Size = New Size(54, 14)
        lblNet.TabIndex = 22
        lblNet.Text = "Net Pay:"
        ' 
        ' lblNetPay
        ' 
        lblNetPay.AutoSize = True
        lblNetPay.Location = New Point(629, 423)
        lblNetPay.Name = "lblNetPay"
        lblNetPay.Size = New Size(26, 14)
        lblNetPay.TabIndex = 23
        lblNetPay.Text = "Pay"
        ' 
        ' lblSummation
        ' 
        lblSummation.AutoSize = True
        lblSummation.Font = New Font("Tahoma", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        lblSummation.Location = New Point(428, 391)
        lblSummation.Name = "lblSummation"
        lblSummation.Size = New Size(357, 18)
        lblSummation.TabIndex = 24
        lblSummation.Text = "Tax Amounts Deducted From BiWeekly Income "
        ' 
        ' frmPayroll
        ' 
        AcceptButton = btnCalcNetPay
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = btnClear
        ClientSize = New Size(799, 512)
        Controls.Add(lblSummation)
        Controls.Add(lblNetPay)
        Controls.Add(lblNet)
        Controls.Add(lblStateDisplay)
        Controls.Add(lblFederalDisplay)
        Controls.Add(lblFICADisplay)
        Controls.Add(lblSateDeduct)
        Controls.Add(lblFederalDeduct)
        Controls.Add(lblFICADeduct)
        Controls.Add(lblAmountsInfo)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalcNetPay)
        Controls.Add(lblInfo)
        Controls.Add(lblState)
        Controls.Add(lblFederal)
        Controls.Add(lblFICA)
        Controls.Add(lblStateTax)
        Controls.Add(lblFederalTax)
        Controls.Add(lblFICATax)
        Controls.Add(txtIncome)
        Controls.Add(lblIncome)
        Controls.Add(lblHeading)
        Controls.Add(picCalculator)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmPayroll"
        Text = "Payroll Calculator"
        CType(picCalculator, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picCalculator As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents lblFICATax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFederal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnCalcNetPay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAmountsInfo As Label
    Friend WithEvents lblFICADeduct As Label
    Friend WithEvents lblSateDeduct As Label
    Friend WithEvents lblFederalDeduct As Label
    Friend WithEvents lblStateDisplay As Label
    Friend WithEvents lblFederalDisplay As Label
    Friend WithEvents lblFICADisplay As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblSummation As Label

End Class
