<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChecaIE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChecaIE))
        Me.grbIE = New System.Windows.Forms.GroupBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnChecaIE = New System.Windows.Forms.Button()
        Me.chkIsento = New System.Windows.Forms.CheckBox()
        Me.txtChecaIE = New System.Windows.Forms.TextBox()
        Me.lblChecaIE = New System.Windows.Forms.Label()
        Me.grbIE2 = New System.Windows.Forms.GroupBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnAcheEstado = New System.Windows.Forms.Button()
        Me.txtChecaIE2 = New System.Windows.Forms.TextBox()
        Me.lblIE2 = New System.Windows.Forms.Label()
        Me.lblExplicacao = New System.Windows.Forms.Label()
        Me.grbIE.SuspendLayout()
        Me.grbIE2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbIE
        '
        Me.grbIE.Controls.Add(Me.cboEstado)
        Me.grbIE.Controls.Add(Me.btnChecaIE)
        Me.grbIE.Controls.Add(Me.chkIsento)
        Me.grbIE.Controls.Add(Me.txtChecaIE)
        Me.grbIE.Controls.Add(Me.lblChecaIE)
        Me.grbIE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grbIE.Location = New System.Drawing.Point(12, 12)
        Me.grbIE.Name = "grbIE"
        Me.grbIE.Size = New System.Drawing.Size(278, 74)
        Me.grbIE.TabIndex = 0
        Me.grbIE.TabStop = False
        Me.grbIE.Text = "Inscrição Estadual 1 - CERTO!"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás ", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins"})
        Me.cboEstado.Location = New System.Drawing.Point(85, 46)
        Me.cboEstado.MaxDropDownItems = 10
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(100, 21)
        Me.cboEstado.TabIndex = 7
        '
        'btnChecaIE
        '
        Me.btnChecaIE.ForeColor = System.Drawing.Color.Black
        Me.btnChecaIE.Location = New System.Drawing.Point(191, 44)
        Me.btnChecaIE.Name = "btnChecaIE"
        Me.btnChecaIE.Size = New System.Drawing.Size(81, 23)
        Me.btnChecaIE.TabIndex = 6
        Me.btnChecaIE.Text = "&Checa IE"
        Me.btnChecaIE.UseVisualStyleBackColor = True
        '
        'chkIsento
        '
        Me.chkIsento.AutoSize = True
        Me.chkIsento.ForeColor = System.Drawing.Color.Black
        Me.chkIsento.Location = New System.Drawing.Point(191, 21)
        Me.chkIsento.Name = "chkIsento"
        Me.chkIsento.Size = New System.Drawing.Size(55, 17)
        Me.chkIsento.TabIndex = 5
        Me.chkIsento.Text = "&Isento"
        Me.chkIsento.UseVisualStyleBackColor = True
        '
        'txtChecaIE
        '
        Me.txtChecaIE.Location = New System.Drawing.Point(85, 19)
        Me.txtChecaIE.Name = "txtChecaIE"
        Me.txtChecaIE.Size = New System.Drawing.Size(100, 20)
        Me.txtChecaIE.TabIndex = 4
        Me.txtChecaIE.Text = "250768135"
        '
        'lblChecaIE
        '
        Me.lblChecaIE.AutoSize = True
        Me.lblChecaIE.ForeColor = System.Drawing.Color.Black
        Me.lblChecaIE.Location = New System.Drawing.Point(6, 22)
        Me.lblChecaIE.Name = "lblChecaIE"
        Me.lblChecaIE.Size = New System.Drawing.Size(73, 13)
        Me.lblChecaIE.TabIndex = 3
        Me.lblChecaIE.Text = "Digite um I.E.:"
        '
        'grbIE2
        '
        Me.grbIE2.Controls.Add(Me.lblEstado)
        Me.grbIE2.Controls.Add(Me.btnAcheEstado)
        Me.grbIE2.Controls.Add(Me.txtChecaIE2)
        Me.grbIE2.Controls.Add(Me.lblIE2)
        Me.grbIE2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grbIE2.Location = New System.Drawing.Point(12, 206)
        Me.grbIE2.Name = "grbIE2"
        Me.grbIE2.Size = New System.Drawing.Size(278, 74)
        Me.grbIE2.TabIndex = 1
        Me.grbIE2.TabStop = False
        Me.grbIE2.Text = "Inscrição Estadual 2 - ERRADO!"
        '
        'lblEstado
        '
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(85, 45)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(187, 20)
        Me.lblEstado.TabIndex = 8
        '
        'btnAcheEstado
        '
        Me.btnAcheEstado.ForeColor = System.Drawing.Color.Black
        Me.btnAcheEstado.Location = New System.Drawing.Point(191, 17)
        Me.btnAcheEstado.Name = "btnAcheEstado"
        Me.btnAcheEstado.Size = New System.Drawing.Size(81, 23)
        Me.btnAcheEstado.TabIndex = 7
        Me.btnAcheEstado.Text = "&Ache Estado"
        Me.btnAcheEstado.UseVisualStyleBackColor = True
        '
        'txtChecaIE2
        '
        Me.txtChecaIE2.Location = New System.Drawing.Point(85, 19)
        Me.txtChecaIE2.Name = "txtChecaIE2"
        Me.txtChecaIE2.Size = New System.Drawing.Size(100, 20)
        Me.txtChecaIE2.TabIndex = 5
        Me.txtChecaIE2.Text = "76105790"
        '
        'lblIE2
        '
        Me.lblIE2.AutoSize = True
        Me.lblIE2.ForeColor = System.Drawing.Color.Black
        Me.lblIE2.Location = New System.Drawing.Point(6, 22)
        Me.lblIE2.Name = "lblIE2"
        Me.lblIE2.Size = New System.Drawing.Size(73, 13)
        Me.lblIE2.TabIndex = 4
        Me.lblIE2.Text = "Digite um I.E.:"
        '
        'lblExplicacao
        '
        Me.lblExplicacao.ForeColor = System.Drawing.Color.Maroon
        Me.lblExplicacao.Location = New System.Drawing.Point(12, 124)
        Me.lblExplicacao.Name = "lblExplicacao"
        Me.lblExplicacao.Size = New System.Drawing.Size(278, 79)
        Me.lblExplicacao.TabIndex = 2
        Me.lblExplicacao.Text = resources.GetString("lblExplicacao.Text")
        '
        'frmChecaIE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 290)
        Me.Controls.Add(Me.lblExplicacao)
        Me.Controls.Add(Me.grbIE2)
        Me.Controls.Add(Me.grbIE)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChecaIE"
        Me.ShowIcon = False
        Me.Text = "Checagem do IE por Estado"
        Me.grbIE.ResumeLayout(False)
        Me.grbIE.PerformLayout()
        Me.grbIE2.ResumeLayout(False)
        Me.grbIE2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbIE As System.Windows.Forms.GroupBox
    Friend WithEvents grbIE2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExplicacao As System.Windows.Forms.Label
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents btnChecaIE As System.Windows.Forms.Button
    Friend WithEvents chkIsento As System.Windows.Forms.CheckBox
    Friend WithEvents txtChecaIE As System.Windows.Forms.TextBox
    Friend WithEvents lblChecaIE As System.Windows.Forms.Label
    Friend WithEvents txtChecaIE2 As System.Windows.Forms.TextBox
    Friend WithEvents lblIE2 As System.Windows.Forms.Label
    Friend WithEvents btnAcheEstado As System.Windows.Forms.Button
    Friend WithEvents lblEstado As System.Windows.Forms.Label

End Class
