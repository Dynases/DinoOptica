<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F1_MontoPagar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim cbCambioDolar_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F1_MontoPagar))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbTotalPagar = New DevComponents.DotNetBar.LabelX()
        Me.BtnSalir = New DevComponents.DotNetBar.ButtonX()
        Me.btnContinuar = New DevComponents.DotNetBar.ButtonX()
        Me.txtCambio1 = New DevComponents.DotNetBar.LabelX()
        Me.lbCambio = New DevComponents.DotNetBar.LabelX()
        Me.lbMontoPagado = New DevComponents.DotNetBar.LabelX()
        Me.tbTotal = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbMontoTarjetaCredito = New DevComponents.Editors.DoubleInput()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.tbMontoTarej = New DevComponents.Editors.DoubleInput()
        Me.chbTarjeta = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tbMontoBs = New DevComponents.Editors.DoubleInput()
        Me.cbCambioDolar = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.btgrupo1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbMontoDolar = New DevComponents.Editors.DoubleInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbFactura = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbMontoTarjetaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMontoTarej, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMontoBs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCambioDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMontoDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.GroupBox2.Controls.Add(Me.tbTotalPagar)
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.btnContinuar)
        Me.GroupBox2.Controls.Add(Me.txtCambio1)
        Me.GroupBox2.Controls.Add(Me.lbCambio)
        Me.GroupBox2.Controls.Add(Me.lbMontoPagado)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(0, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 140)
        Me.GroupBox2.TabIndex = 364
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monto Venta/Cambio:"
        '
        'tbTotalPagar
        '
        Me.tbTotalPagar.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbTotalPagar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotalPagar.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalPagar.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbTotalPagar.Location = New System.Drawing.Point(152, 17)
        Me.tbTotalPagar.Name = "tbTotalPagar"
        Me.tbTotalPagar.SingleLineColor = System.Drawing.SystemColors.Control
        Me.tbTotalPagar.Size = New System.Drawing.Size(120, 40)
        Me.tbTotalPagar.TabIndex = 372
        Me.tbTotalPagar.Text = "0.00"
        Me.tbTotalPagar.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BtnSalir
        '
        Me.BtnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnSalir.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.BtnSalir.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.DinoM.My.Resources.Resources.cancel
        Me.BtnSalir.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.BtnSalir.Location = New System.Drawing.Point(262, 89)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 39)
        Me.BtnSalir.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.BtnSalir.TabIndex = 371
        Me.BtnSalir.Text = "Salir"
        '
        'btnContinuar
        '
        Me.btnContinuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnContinuar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnContinuar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar.Image = Global.DinoM.My.Resources.Resources.checked
        Me.btnContinuar.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnContinuar.Location = New System.Drawing.Point(383, 89)
        Me.btnContinuar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(110, 39)
        Me.btnContinuar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnContinuar.TabIndex = 3
        Me.btnContinuar.Text = "Continuar"
        '
        'txtCambio1
        '
        Me.txtCambio1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCambio1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCambio1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio1.ForeColor = System.Drawing.Color.YellowGreen
        Me.txtCambio1.Location = New System.Drawing.Point(383, 21)
        Me.txtCambio1.Name = "txtCambio1"
        Me.txtCambio1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.txtCambio1.Size = New System.Drawing.Size(110, 40)
        Me.txtCambio1.TabIndex = 368
        Me.txtCambio1.Text = "0.00"
        Me.txtCambio1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lbCambio
        '
        Me.lbCambio.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbCambio.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCambio.ForeColor = System.Drawing.Color.White
        Me.lbCambio.Location = New System.Drawing.Point(296, 21)
        Me.lbCambio.Name = "lbCambio"
        Me.lbCambio.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbCambio.Size = New System.Drawing.Size(80, 40)
        Me.lbCambio.TabIndex = 367
        Me.lbCambio.Text = "Cambio Bs.:"
        '
        'lbMontoPagado
        '
        Me.lbMontoPagado.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lbMontoPagado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbMontoPagado.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoPagado.ForeColor = System.Drawing.Color.White
        Me.lbMontoPagado.Location = New System.Drawing.Point(8, 24)
        Me.lbMontoPagado.Name = "lbMontoPagado"
        Me.lbMontoPagado.SingleLineColor = System.Drawing.SystemColors.Control
        Me.lbMontoPagado.Size = New System.Drawing.Size(130, 33)
        Me.lbMontoPagado.TabIndex = 366
        Me.lbMontoPagado.Text = "Total a Pagar Bs. :"
        '
        'tbTotal
        '
        Me.tbTotal.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotal.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.ForeColor = System.Drawing.Color.YellowGreen
        Me.tbTotal.Location = New System.Drawing.Point(373, 131)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.SingleLineColor = System.Drawing.SystemColors.Control
        Me.tbTotal.Size = New System.Drawing.Size(120, 40)
        Me.tbTotal.TabIndex = 369
        Me.tbTotal.Text = "0.00"
        Me.tbTotal.TextAlignment = System.Drawing.StringAlignment.Far
        Me.tbTotal.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.GroupBox1.Controls.Add(Me.tbFactura)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.tbMontoTarjetaCredito)
        Me.GroupBox1.Controls.Add(Me.LabelX22)
        Me.GroupBox1.Controls.Add(Me.tbMontoTarej)
        Me.GroupBox1.Controls.Add(Me.tbTotal)
        Me.GroupBox1.Controls.Add(Me.chbTarjeta)
        Me.GroupBox1.Controls.Add(Me.tbMontoBs)
        Me.GroupBox1.Controls.Add(Me.cbCambioDolar)
        Me.GroupBox1.Controls.Add(Me.btgrupo1)
        Me.GroupBox1.Controls.Add(Me.LabelX20)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.tbMontoDolar)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 188)
        Me.GroupBox1.TabIndex = 362
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formas de Pago:"
        '
        'tbMontoTarjetaCredito
        '
        '
        '
        '
        Me.tbMontoTarjetaCredito.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoTarjetaCredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoTarjetaCredito.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoTarjetaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoTarjetaCredito.ForeColor = System.Drawing.Color.Black
        Me.tbMontoTarjetaCredito.Increment = 1.0R
        Me.tbMontoTarjetaCredito.Location = New System.Drawing.Point(152, 142)
        Me.tbMontoTarjetaCredito.MinValue = 0R
        Me.tbMontoTarjetaCredito.Name = "tbMontoTarjetaCredito"
        Me.tbMontoTarjetaCredito.Size = New System.Drawing.Size(118, 23)
        Me.tbMontoTarjetaCredito.TabIndex = 386
        Me.tbMontoTarjetaCredito.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX22.ForeColor = System.Drawing.Color.White
        Me.LabelX22.Location = New System.Drawing.Point(23, 147)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX22.Size = New System.Drawing.Size(110, 18)
        Me.LabelX22.TabIndex = 387
        Me.LabelX22.Text = "T. Credito. Bs.:"
        '
        'tbMontoTarej
        '
        '
        '
        '
        Me.tbMontoTarej.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoTarej.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoTarej.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoTarej.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoTarej.ForeColor = System.Drawing.Color.Black
        Me.tbMontoTarej.Increment = 1.0R
        Me.tbMontoTarej.IsInputReadOnly = True
        Me.tbMontoTarej.Location = New System.Drawing.Point(152, 79)
        Me.tbMontoTarej.MinValue = 0R
        Me.tbMontoTarej.Name = "tbMontoTarej"
        Me.tbMontoTarej.Size = New System.Drawing.Size(118, 23)
        Me.tbMontoTarej.TabIndex = 379
        Me.tbMontoTarej.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'chbTarjeta
        '
        Me.chbTarjeta.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chbTarjeta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chbTarjeta.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chbTarjeta.Location = New System.Drawing.Point(24, 78)
        Me.chbTarjeta.Name = "chbTarjeta"
        Me.chbTarjeta.Size = New System.Drawing.Size(120, 30)
        Me.chbTarjeta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chbTarjeta.TabIndex = 382
        Me.chbTarjeta.Text = "QR:"
        Me.chbTarjeta.TextColor = System.Drawing.Color.White
        '
        'tbMontoBs
        '
        '
        '
        '
        Me.tbMontoBs.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoBs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoBs.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoBs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoBs.ForeColor = System.Drawing.Color.Black
        Me.tbMontoBs.Increment = 1.0R
        Me.tbMontoBs.Location = New System.Drawing.Point(152, 50)
        Me.tbMontoBs.MinValue = 0R
        Me.tbMontoBs.Name = "tbMontoBs"
        Me.tbMontoBs.Size = New System.Drawing.Size(118, 23)
        Me.tbMontoBs.TabIndex = 377
        Me.tbMontoBs.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'cbCambioDolar
        '
        Me.cbCambioDolar.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.cbCambioDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        cbCambioDolar_DesignTimeLayout.LayoutString = resources.GetString("cbCambioDolar_DesignTimeLayout.LayoutString")
        Me.cbCambioDolar.DesignTimeLayout = cbCambioDolar_DesignTimeLayout
        Me.cbCambioDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCambioDolar.Location = New System.Drawing.Point(149, 16)
        Me.cbCambioDolar.Name = "cbCambioDolar"
        Me.cbCambioDolar.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.cbCambioDolar.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.cbCambioDolar.SelectedIndex = -1
        Me.cbCambioDolar.SelectedItem = Nothing
        Me.cbCambioDolar.Size = New System.Drawing.Size(121, 22)
        Me.cbCambioDolar.TabIndex = 376
        Me.cbCambioDolar.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'btgrupo1
        '
        Me.btgrupo1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btgrupo1.BackColor = System.Drawing.Color.Transparent
        Me.btgrupo1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btgrupo1.Image = Global.DinoM.My.Resources.Resources.add
        Me.btgrupo1.ImageFixedSize = New System.Drawing.Size(25, 23)
        Me.btgrupo1.Location = New System.Drawing.Point(275, 16)
        Me.btgrupo1.Name = "btgrupo1"
        Me.btgrupo1.Size = New System.Drawing.Size(28, 23)
        Me.btgrupo1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btgrupo1.TabIndex = 369
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelX20.ForeColor = System.Drawing.Color.White
        Me.LabelX20.Location = New System.Drawing.Point(14, 20)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX20.Size = New System.Drawing.Size(90, 18)
        Me.LabelX20.TabIndex = 370
        Me.LabelX20.Text = "Tipo Cambio:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(23, 55)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX5.Size = New System.Drawing.Size(98, 18)
        Me.LabelX5.TabIndex = 64
        Me.LabelX5.Text = "M.Pagado Bs.:"
        '
        'tbMontoDolar
        '
        '
        '
        '
        Me.tbMontoDolar.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbMontoDolar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbMontoDolar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbMontoDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMontoDolar.ForeColor = System.Drawing.Color.Black
        Me.tbMontoDolar.Increment = 1.0R
        Me.tbMontoDolar.Location = New System.Drawing.Point(152, 108)
        Me.tbMontoDolar.MinValue = 0R
        Me.tbMontoDolar.Name = "tbMontoDolar"
        Me.tbMontoDolar.Size = New System.Drawing.Size(118, 26)
        Me.tbMontoDolar.TabIndex = 100
        Me.tbMontoDolar.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.White
        Me.LabelX6.Location = New System.Drawing.Point(24, 114)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX6.Size = New System.Drawing.Size(97, 18)
        Me.LabelX6.TabIndex = 66
        Me.LabelX6.Text = "M. Pagado $:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        Me.LabelX1.Location = New System.Drawing.Point(373, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX1.Size = New System.Drawing.Size(98, 18)
        Me.LabelX1.TabIndex = 388
        Me.LabelX1.Text = "Nro Factura:"
        '
        'tbFactura
        '
        '
        '
        '
        Me.tbFactura.Border.Class = "TextBoxBorder"
        Me.tbFactura.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFactura.Location = New System.Drawing.Point(373, 40)
        Me.tbFactura.Name = "tbFactura"
        Me.tbFactura.PreventEnterBeep = True
        Me.tbFactura.Size = New System.Drawing.Size(120, 21)
        Me.tbFactura.TabIndex = 389
        '
        'F1_MontoPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 328)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F1_MontoPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F1_MontoPagar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbMontoTarjetaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMontoTarej, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMontoBs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCambioDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMontoDolar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbMontoDolar As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCambio1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbCambio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbMontoPagado As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnContinuar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btgrupo1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbCambioDolar As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbMontoTarjetaCredito As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbMontoTarej As DevComponents.Editors.DoubleInput
    Friend WithEvents chbTarjeta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tbMontoBs As DevComponents.Editors.DoubleInput
    Friend WithEvents tbTotalPagar As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbFactura As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
