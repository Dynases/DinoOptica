Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports Logica.AccesoLogica
Public Class F1_MontoPagar

    Public TotalVenta As Double
    Public Bandera As Boolean = False
    Public TotalBs As Double = 0
    Public TotalSus As Double = 0
    Public TotalTarjeta As Double = 0
    Public TotalQR As Double = 0
    Public Nit As String = ""
    Public RazonSocial As String = ""
    Public TipoCambio As Double = 0
    Public tipoVenta As Integer = 1
    Public Cobrado As Boolean
    Public Banc As Integer
    Public CostoEnvio As Double
    Public cambio As Double
    Public tipo As Integer = 0
    Public factura As String = ""


    Private Sub F1_MontoPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'cbCambioDolar.SelectedIndex = CType(cbCambioDolar.DataSource, DataTable).Rows.Count - 1
        'If tipo = 1 Then
        '    txtCambio1.Visible = False
        '    lbCambio.Visible = False
        'End If
        'If Cobrado = False Then
        '    txtMontoPagado1.Text = "0.00"
        '    txtCambio1.Text = "0.00"
        '    tbMontoBs.Value = 0
        '    tbMontoDolar.Value = 0

        'Else

        _prCargarComboLibreria(cbCambioDolar, 7, 1)
        'End If
        tbMontoBs.Value = 0
        tbMontoDolar.Value = 0
        tbMontoTarej.Value = 0
        tbMontoTarjetaCredito.Value = 0
        tbTotalPagar.Text = TotalVenta

        tbMontoBs.Focus()
    End Sub


    Private Sub tbMontoBs_ValueChanged(sender As Object, e As EventArgs)
        'tbMontoDolar.Value = 0
        'tbMontoTarej.Value = 0

        Dim diferencia As Double = tbMontoBs.Value - (TotalVenta)
        If (diferencia >= 0) Then
            'txtMontoPagado1.Text = (TotalVenta + tbCostoEnvio.Value).ToString
            txtCambio1.Text = Math.Round(diferencia, 2).ToString

        Else
            'txtMontoPagado1.Text = "0.00"
            txtCambio1.Text = "0.00"
        End If

    End Sub

    Private Sub tbMontoDolar_ValueChanged(sender As Object, e As EventArgs) Handles tbMontoDolar.ValueChanged
        tbMontoBs.Value = 0
        tbMontoTarej.Value = 0
        tbMontoTarjetaCredito.Value = 0
        If tbMontoDolar.Value <> 0 And tbMontoDolar.Text <> String.Empty Then
            tbTotal.Text = tbMontoBs.Value + (tbMontoDolar.Value * IIf(cbCambioDolar.Text = "", 0, Convert.ToDecimal(cbCambioDolar.Text))) + tbMontoTarej.Value + tbMontoTarjetaCredito.Value
            If Convert.ToDecimal(tbTotal.Text) <> 0 And Convert.ToDecimal(tbTotal.Text) >= Convert.ToDecimal(tbTotal.Text) Then
                txtCambio1.Text = Convert.ToDecimal(tbTotal.Text) - Convert.ToDecimal(tbTotal.Text)
            Else
                txtCambio1.Text = "0.00"
            End If
        Else
            txtCambio1.Text = "0.00"
            tbTotal.Text = "0.00"
        End If
    End Sub



    Private Sub tbMontoBs_KeyDown(sender As Object, e As KeyEventArgs)

        If (e.KeyData = Keys.Up) Then
            'tbRazonSocial.Focus()
        End If
        If (e.KeyData = Keys.Right) Then
            tbMontoDolar.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            'tbMontoDolar.Focus()
            btnContinuar.Focus()
        End If

        If (e.KeyData = Keys.Escape) Then
            TotalBs = 0
            TotalSus = 0
            TotalTarjeta = 0
            TotalQR = 0
            Bandera = False
            Me.Close()


        End If
        '    If (e.KeyData = Keys.Control + Keys.S) Then
        '        If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
        '            Bandera = True
        '            TotalBs = tbMontoBs.Value
        '            TotalSus = tbMontoDolar.Value
        '            TotalTarjeta = tbMontoTarej.Value
        '            Me.Close()

        '        Else
        '            ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '        End If


        '    End If
    End Sub

    Private Sub tbMontoDolar_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMontoDolar.KeyDown
        If (e.KeyData = Keys.Left) Then
            tbMontoBs.Focus()
        End If
        If (e.KeyData = Keys.Escape) Then
            TotalBs = 0
            TotalSus = 0
            TotalTarjeta = 0
            TotalQR = 0
            Bandera = False
            Me.Close()


        End If
        'If (e.KeyData = Keys.Control + Keys.S) Then
        '    If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
        '        Bandera = True
        '        TotalBs = tbMontoBs.Value
        '        TotalSus = tbMontoDolar.Value
        '        TotalTarjeta = tbMontoTarej.Value
        '        Me.Close()

        '    Else
        '        ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '    End If
        'End If
    End Sub

    Private Sub tbMontoTarej_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.KeyData = Keys.Up) Then
            tbMontoBs.Focus()
        End If
        If (e.KeyData = Keys.Enter) Then
            btnContinuar.Focus()
        End If
        If (e.KeyData = Keys.Left) Then
            tbMontoDolar.Focus()
        End If

        If (e.KeyData = Keys.Escape) Then
            TotalBs = 0
            TotalSus = 0
            TotalTarjeta = 0
            TotalQR = 0
            Bandera = False
            Me.Close()


        End If
        'If (e.KeyData = Keys.Control + Keys.S) Then
        '    If (tbMontoTarej.Value + tbMontoDolar.Value + tbMontoBs.Value >= TotalVenta) Then
        '        Bandera = True
        '        TotalBs = tbMontoBs.Value
        '        TotalSus = tbMontoDolar.Value
        '        TotalTarjeta = tbMontoTarej.Value
        '        Me.Close()

        '    Else
        '        ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
        '    End If
        'End If
    End Sub


    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click




        If (tbMontoBs.Value + tbMontoTarjetaCredito.Value + tbMontoTarej.Value + (tbMontoDolar.Value * CDbl(cbCambioDolar.Text)) >= (TotalVenta)) Then
            Bandera = True
            TotalBs = tbMontoBs.Value
            TotalSus = tbMontoDolar.Value
            TipoCambio = cbCambioDolar.Text
            TotalQR = tbMontoTarej.Value
            TotalTarjeta = tbMontoTarjetaCredito.Value
            'tipoVenta = 1
            factura = tbFactura.Text
            Me.Close()

        Else
            ToastNotification.Show(Me, "Debe Ingresar un Monto a Cobrar Valido igual o mayor A = " + Str(TotalVenta), My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
            tbMontoBs.Focus()
        End If



    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        TotalBs = 0
        TotalSus = 0
        TotalTarjeta = 0
        TotalQR = 0
        Bandera = False
        Me.Close()

    End Sub



    Private Sub cbCambioDolar_ValueChanged(sender As Object, e As EventArgs) Handles cbCambioDolar.ValueChanged
        If cbCambioDolar.SelectedIndex < 0 And cbCambioDolar.Text <> String.Empty Then
            btgrupo1.Visible = True
        Else
            btgrupo1.Visible = False
        End If
    End Sub

    Private Sub _prCargarComboLibreria(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo, cod1 As String, cod2 As String)
        Dim dt As New DataTable
        dt = L_prLibreriaClienteLGeneral(cod1, cod2, "")
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 70
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 200
            .DropDownList.Columns("ycdes3").Caption = "DESCRIPCION"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With

        mCombo.SelectedIndex = 0
    End Sub
    Private Sub btgrupo1_Click(sender As Object, e As EventArgs) Handles btgrupo1.Click
        Dim numi As String = ""



        If L_prLibreriaGrabar(numi, "7", "1", cbCambioDolar.Text, "") Then
            _prCargarComboLibreria(cbCambioDolar, "7", "1")
            cbCambioDolar.SelectedIndex = CType(cbCambioDolar.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub tbNit_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ToastNotification.Show(Me, "Solo puede digitar números".ToUpper, My.Resources.WARNING, 1200, eToastGlowColor.Red, eToastPosition.TopCenter)

        End If
    End Sub



    Private Sub tbRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Convert.ToChar(Keys.Back) = (e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub MostrarMensajeError(mensaje As String)
        ToastNotification.Show(Me,
                               mensaje.ToUpper,
                               My.Resources.WARNING,
                               4000,
                               eToastGlowColor.Red,
                               eToastPosition.TopCenter)
    End Sub

    Private Sub tbCostoEnvio_ValueChanged(sender As Object, e As EventArgs)
        tbTotal.Text = (TotalVenta).ToString
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DoubleInput2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub LabelX1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbMontoBs_ValueChanged_1(sender As Object, e As EventArgs) Handles tbMontoBs.ValueChanged
        tbMontoDolar.Value = 0
        'tbMontoTarej.Value = 0
        'tbMontoTarjetaCredito.Value = 0

        If tbMontoBs.Value <> 0 And tbMontoBs.Text <> String.Empty Then
            tbTotal.Text = tbMontoBs.Value + (tbMontoDolar.Value * IIf(cbCambioDolar.Text = "", 0, Convert.ToDecimal(cbCambioDolar.Text))) + tbMontoTarej.Value + tbMontoTarjetaCredito.Value

            If Convert.ToDecimal(tbTotal.Text) <> 0 And Convert.ToDecimal(tbTotal.Text) >= Convert.ToDecimal(tbTotalPagar.Text) Then
                txtCambio1.Text = Convert.ToDecimal(tbTotal.Text) - Convert.ToDecimal(tbTotalPagar.Text)
            Else
                txtCambio1.Text = "0.00"
                'txtMontoPagado1.Text = "0.00"
            End If
        End If

    End Sub

    Private Sub chbTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles chbTarjeta.CheckedChanged
        If chbTarjeta.Checked Then
            'tbMontoBs.Value = 0
            tbMontoDolar.Value = 0
            'tbMontoTarjetaCredito.Value = 0
            tbMontoTarej.Enabled = True
            tbMontoTarej.Value = Convert.ToDecimal(tbTotalPagar.Text) - tbMontoBs.Value - tbMontoTarjetaCredito.Value
            If tbMontoTarej.Value <> 0 And tbMontoTarej.Text <> String.Empty Then
                tbTotal.Text = tbMontoBs.Value + (tbMontoDolar.Value * IIf(cbCambioDolar.Text = "", 0, Convert.ToDecimal(cbCambioDolar.Text))) + tbMontoTarej.Value + tbMontoTarjetaCredito.Value
                If Convert.ToDecimal(tbTotal.Text) <> 0 And Convert.ToDecimal(tbTotal.Text) >= Convert.ToDecimal(tbTotalPagar.Text) Then
                    txtCambio1.Text = Convert.ToDecimal(tbTotal.Text) - Convert.ToDecimal(tbTotalPagar.Text)
                Else
                    txtCambio1.Text = "0.00"
                End If
            End If
            'tbMontoBs.Enabled = False
            tbMontoDolar.Enabled = False
            tbMontoTarej.IsInputReadOnly = True
            tbMontoTarej.Focus()
        Else
            'tbMontoBs.Enabled = True
            tbMontoDolar.Enabled = True
            tbMontoTarej.Value = 0
        End If
    End Sub

    Private Sub tbMontoTarjetaCredito_ValueChanged(sender As Object, e As EventArgs) Handles tbMontoTarjetaCredito.ValueChanged
        tbMontoDolar.Value = 0
        'tbMontoTarej.Value = 0
        'tbMontoBs.Value = 0

        If tbMontoTarjetaCredito.Value <> 0 And tbMontoTarjetaCredito.Text <> String.Empty Then
            tbTotal.Text = tbMontoBs.Value + (tbMontoDolar.Value * IIf(cbCambioDolar.Text = "", 0, Convert.ToDecimal(cbCambioDolar.Text))) + tbMontoTarej.Value + tbMontoTarjetaCredito.Value

            If Convert.ToDecimal(tbTotal.Text) <> 0 And Convert.ToDecimal(tbTotal.Text) >= Convert.ToDecimal(tbTotalPagar.Text) Then
                txtCambio1.Text = Convert.ToDecimal(tbTotal.Text) - Convert.ToDecimal(tbTotalPagar.Text)
            Else
                txtCambio1.Text = "0.00"
                    'txtMontoPagado1.Text = "0.00"
                End If
            End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class