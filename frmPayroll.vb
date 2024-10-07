' Program name: Payroll Calculator
' Date: September 23, 2024
' Author: K Bola
' Purpose: This program will compute and display FICA tax, federal tax and state tax for a two-week pay period
Imports System.Security.Cryptography
Imports System.Windows.Forms.ComponentModel.Com2Interop

Public Class frmPayroll
    ' Declaring Variables and Initializing const
    Const _cdecFICATax As Decimal = 0.0765D
    Const _cdecFederalTax As Decimal = 0.22D
    Const _cdecStateTax As Decimal = 0.04D
    Dim strBiweeklyIncome As String
    Dim intBiweeklyIncome As Integer
    Dim cdecFICATaxAmount As Decimal
    Dim cdecFederalTaxAmount As Decimal
    Dim cdecStateTaxAmount As Decimal
    Dim cdecDeductions As Decimal
    Dim cdecNetPay As Decimal
    Private Sub btnCalcNetPay_Click(sender As Object, e As EventArgs) Handles btnCalcNetPay.Click
        strBiweeklyIncome = txtIncome.Text
        intBiweeklyIncome = Convert.ToInt32(strBiweeklyIncome)
        cdecFICATaxAmount = intBiweeklyIncome * _cdecFICATax
        lblFICADisplay.Text = cdecFICATaxAmount.ToString("C2")
        cdecFederalTaxAmount = intBiweeklyIncome * _cdecFederalTax
        lblFederalDisplay.Text = cdecFederalTaxAmount.ToString("C2")
        cdecStateTaxAmount = intBiweeklyIncome * _cdecStateTax
        lblStateDisplay.Text = cdecStateTaxAmount.ToString("C2")
        cdecDeductions = intBiweeklyIncome - cdecFICATaxAmount - cdecFederalTaxAmount - cdecStateTaxAmount
        cdecNetPay = cdecDeductions
        lblNetPay.Text = cdecNetPay.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncome.Clear()
        txtIncome.Focus()
        lblFICADisplay.Text = ""
        lblFederalDisplay.Text = ""
        lblStateDisplay.Text = ""
        lblNetPay.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFICA.Text = _cdecFICATax.ToString("C2")
        lblFederal.Text = _cdecFederalTax.ToString("C2")
        lblState.Text = _cdecStateTax.ToString("C2")
        txtIncome.Focus()
        lblFICADisplay.Text = ""
        lblFederalDisplay.Text = ""
        lblStateDisplay.Text = ""
        lblNetPay.Text = ""
    End Sub
End Class
