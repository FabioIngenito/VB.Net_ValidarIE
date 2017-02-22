﻿Public Class clsPrincipal

    Public strUFe(0 To 26) As String
    Public strUF(0 To 26) As String
    Public bytNumero As Byte

    Private pNomeEstado As String
    Private pSiglaEstado As String

    ''' <summary>
    ''' O construtor da classe carregando as arrays
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        strUFe(0) = "Acre"
        strUFe(1) = "Alagoas"
        strUFe(2) = "Amapá"
        strUFe(3) = "Amazonas"
        strUFe(4) = "Bahia"
        strUFe(5) = "Ceará"
        strUFe(6) = "Distrito Federal"
        strUFe(7) = "Espírito Santo"
        strUFe(8) = "Goiás"
        strUFe(9) = "Maranhão"
        strUFe(10) = "Mato Grosso"
        strUFe(11) = "Mato Grosso do Sul"
        strUFe(12) = "Minas Gerais"
        strUFe(13) = "Pará"
        strUFe(14) = "Paraíba"
        strUFe(15) = "Paraná"
        strUFe(16) = "Pernambuco"
        strUFe(17) = "Piauí"
        strUFe(18) = "Rio de Janeiro"
        strUFe(19) = "Rio Grande do Norte"
        strUFe(20) = "Rio Grande do Sul"
        strUFe(21) = "Rondônia"
        strUFe(22) = "Roraima"
        strUFe(23) = "Santa Catarina"
        strUFe(24) = "São Paulo"
        strUFe(25) = "Sergipe"
        strUFe(26) = "Tocantins"

        strUF(0) = "AC"
        strUF(1) = "AL"
        strUF(2) = "AP"
        strUF(3) = "AM"
        strUF(4) = "BA"
        strUF(5) = "CE"
        strUF(6) = "DF"
        strUF(7) = "ES"
        strUF(8) = "GO"
        strUF(9) = "MA"
        strUF(10) = "MT"
        strUF(11) = "MS"
        strUF(12) = "MG"
        strUF(13) = "PA"
        strUF(14) = "PB"
        strUF(15) = "PR"
        strUF(16) = "PE"
        strUF(17) = "PI"
        strUF(18) = "RJ"
        strUF(19) = "RN"
        strUF(20) = "RS"
        strUF(21) = "RO"
        strUF(22) = "RR"
        strUF(23) = "SC"
        strUF(24) = "SP"
        strUF(25) = "SE"
        strUF(26) = "TO"
    End Sub

    ''' <summary>
    ''' Nome do estado por extenso
    ''' </summary>
    ''' <value></value>
    ''' <returns>Nome do Estado</returns>
    ''' <remarks></remarks>
    Public Property NomeEstado() As String
        Get
            Return pNomeEstado
        End Get
        Set(ByVal value As String)
            pNomeEstado = value
        End Set
    End Property

    ''' <summary>
    ''' Sigla do Estado - UF
    ''' </summary>
    ''' <value></value>
    ''' <returns>Sigla do Estado</returns>
    ''' <remarks></remarks>
    Public Property SiglaEstado() As String
        Get
            Return pSiglaEstado
        End Get
        Set(ByVal value As String)
            pSiglaEstado = value
        End Set
    End Property

End Class
