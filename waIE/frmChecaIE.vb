' ---------------
' Dois Exemplos:
' 250768135 - SC
' 76105790  - RJ
' ---------------

Public Class frmChecaIE
    Dim clsP As New clsPrincipal
    Dim clsC As New clsChecaIE

    Private Sub txtChecaIE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChecaIE.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

    Private Sub txtChecaIE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChecaIE2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

    Private Sub chkIsento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsento.CheckedChanged

        If chkIsento.Checked Then
            txtChecaIE.Text = "ISENTO"
            txtChecaIE.ReadOnly = True
        Else
            txtChecaIE.Text = ""
            txtChecaIE.ReadOnly = False
        End If

    End Sub

    Private Sub frmChecaIE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboEstado.SelectedIndex = 23
    End Sub

    Private Sub btnChecaIE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChecaIE.Click
        Dim blnChecaIE As Boolean
        Dim strUF As String

        'Não precisa desta checagem caso a combobox for "Style = 2 - Dropdown List".
        '    If cboEstado.Text = "" Then
        '        MsgBox "POR FAVOR, ESCOLHA UM ESTADO!", vbCritical, "ESCOLHA UM ESTADO"
        '        Exit Sub
        '    End If

        If txtChecaIE.Text = "" Then
            MsgBox("POR FAVOR, PREENCHA UMA INSCRIÇÃO ESTADUAL!", vbCritical, "PREENCHA UMA I.E.")
            Exit Sub
        End If

        strUF = ConverteEstado(cboEstado.Text)
        blnChecaIE = clsC.ChecaInscrE(strUF, txtChecaIE.Text)
        MsgBox("A checagem foi: " & blnChecaIE)
    End Sub

    Private Function ConverteEstado(ByVal strUFESTADO As String) As String
        Dim strRetorno As String = ""

        For bytNumero = 0 To UBound(clsP.strUFe)

            If strUFESTADO = clsP.strUFe(bytNumero) Then
                strRetorno = clsP.strUF(bytNumero)
            End If

        Next

        Return strRetorno
    End Function

    Private Sub btnAcheEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcheEstado.Click
        Dim bytEstado As Byte

        If txtChecaIE2.Text = "" Then
            MsgBox("POR FAVOR, PREENCHA UMA INSCRIÇÃO ESTADUAL 2!", vbCritical, "PREENCHA UMA I.E.2")
            Exit Sub
        End If

        bytEstado = clsC.AchaEstado(txtChecaIE2.Text)

        If bytEstado < 99 Then
            lblEstado.Text = clsP.strUFe(bytEstado)
        Else
            lblEstado.Text = "NÃO ENCONTRADO!"
        End If
    End Sub

End Class
