Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports System.Drawing.Printing
Imports CrystalDecisions.Shared
Imports Janus.Windows.GridEX.GridEXColumnCollection
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Public Class F1_LenteAyuda
    Public Stock As Decimal
    Public Cantidad As Decimal
    Public Producto As String
    Public bandera As Boolean
    Public CategoriaPrecio As Integer = 0
    Public idProducto As Integer = -1
    Public Precio As Integer = 0
    Public Paciente As Integer = 0
    Public Observacion As String
    Public TipoLente As Integer
    Public Modelo As Integer
    Public Marca As Integer
    Public ColorM As Integer

    Public Orden As Integer = 0

    Public cristales As DataTable
    Public cristalesX As DataTable


    Public Modificar As Boolean
    Public Nuevo As Boolean
    Private Sub F_Cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As New DataTable
        'table.Columns.Add("CercaI")
        'table.Columns.Add("CercaD")
        'table.Columns.Add("MedioI")
        'table.Columns.Add("MedioD")
        'table.Columns.Add("LejosI")
        'table.Columns.Add("LejosD")
        'GridEx1.PrimaryGrid.DataSource = table
        'GridEx1.PrimaryGrid.AutoExpandSetGroup = False
        tbCodigo.Text = TraerNumi().ToString
        CargarCombos()
        'tbCliente.Text = Producto
        tbFechaE.Value = Date.Now
        tbFechaI.Value = Date.Now
        tbFechaRX.Value = Date.Now
        tbHoraE.Value = DateAndTime.TimeOfDay
        tbHoraI.Value = DateAndTime.TimeOfDay
        'GridEx1.DefaultVisualStyles.RowStyles.SelectedMouseOver = GridEx1.BaseVisualStyles.RowStyles.ReadOnly
        AddNewColumns(table, New String() {"DISTANCIA", "OJO", "SPH", "CYL", "EJE", "PRISMA", "AD", "DIP", "ALT", "PRECIO"})

        'GridEx1.PrimaryGrid.DataSource = table
        'GridEx1.PrimaryGrid.DataMember = "Customers"
        GridEx1.DataSource = table
        GridEx1.RetrieveStructure()
        GridEx1.AlternatingColors = True
        With GridEx1.RootTable.Columns("DISTANCIA")
            .Width = 60
            .Visible = False


        End With
        With GridEx1.RootTable.Columns("OJO")
            .Width = 60
            .Visible = False

        End With
        With GridEx1.RootTable.Columns("SPH")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbSPH.DropDownList
            .TextAlignment = 3

        End With
        With GridEx1.RootTable.Columns("CYL")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbCYL.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("EJE")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbEje.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("PRISMA")
            .Width = 70
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("AD")
            .Caption = "ADD"
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbADD.DropDownList
            .TextAlignment = 3

        End With
        With GridEx1.RootTable.Columns("DIP")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbDip.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("ALT")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbAlt.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("PRECIO")
            .Width = 70
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = 3
        End With
        With GridEx1
            .GroupByBoxVisible = False
            'diseño de la grilla
            '.VisualStyle = VisualStyle.Office2007
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
        End With
        'lbStock.Text = "Stock Disponible = " + Str(Stock)
        'lbProducto.Text = Producto
        'tbCantidad.Focus()
        'AddHandler GridEx1.DataBindingComplete, AddressOf SuperGridControl1DataBindingComplete

        'GridEx1.PrimaryGrid.ShowCellInfo = False
        'GridEx1.PrimaryGrid.ShowRowInfo = False
        'GridEx1.PrimaryGrid.ShowRowHeaders = False
        'GridEx1.PrimaryGrid.ShowDropShadow = False
        table.Rows.Add(1, 1, "", "", "", "", "", "", "", 0.00)
        table.Rows.Add(1, 2, "", "", "", "", "", "", "", 0.00)
        table.Rows.Add(2, 1, "", "", "", "", "", "", "", 0.00)
        table.Rows.Add(2, 2, "", "", "", "", "", "", "", 0.00)
        table.Rows.Add(3, 1, "", "", "", "", "", "", "", 0.00)
        table.Rows.Add(3, 2, "", "", "", "", "", "", "", 0.00)
        'cbSPH.SelectedIndex = 26

        If Orden <> 0 Then
            If Modificar = False Then
                btImprimir.Visible = True
            End If
            CargarOrden(Orden)
        Else
            btImprimir.Visible = False
        End If
        If Modificar = False And Nuevo = False Then
            Deshabilitar()
        End If
    End Sub
    Private Sub Deshabilitar()
        cbCliente.ReadOnly = True
        cbDoctor.ReadOnly = True
        tbFechaRX.Enabled = False
        TextBoxX3.ReadOnly = True
        TextBoxX4.ReadOnly = True
        tbBoletaLab.ReadOnly = True
        tbFechaI.Enabled = False
        tbFechaE.Enabled = False
        tbHoraI.Enabled = False
        tbHoraE.Enabled = False
        cbTipoFiltro.ReadOnly = True
        cbTipoLente.ReadOnly = True
        cbTono.ReadOnly = True
        cbRevestimiento.ReadOnly = True
        cbColorC.ReadOnly = True
        cbDiseño.ReadOnly = True
        TextBoxX1.ReadOnly = True
        TextBoxX2.ReadOnly = True
        tbObservacion.ReadOnly = True

        ButtonX11.Enabled = False

        cbPuente.ReadOnly = True
        cbVertical.ReadOnly = True
        cbDiametro.ReadOnly = True

        btnAgregar.Visible = False
    End Sub
    Private Sub CargarGrillaDetalle(dt As DataTable)
        GridEx1.DataSource = dt
        GridEx1.RetrieveStructure()
        GridEx1.AlternatingColors = True
        With GridEx1.RootTable.Columns("DISTANCIA")
            .Width = 60
            .Visible = False


        End With
        With GridEx1.RootTable.Columns("OJO")
            .Width = 60
            .Visible = False

        End With
        With GridEx1.RootTable.Columns("SPH")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbSPH.DropDownList
            .TextAlignment = 3
            .FormatMode = GridEXFormatCondition.Equals(0, "")
        End With
        With GridEx1.RootTable.Columns("CYL")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbCYL.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("EJE")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbEje.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("PRISMA")
            .Width = 70
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("AD")
            .Caption = "ADD"
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbADD.DropDownList
            .TextAlignment = 3

        End With
        With GridEx1.RootTable.Columns("DIP")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbDip.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("ALT")
            .Width = 60
            .Visible = True
            .EditType = EditType.MultiColumnDropDown
            .DropDown = cbAlt.DropDownList
            .TextAlignment = 3
        End With
        With GridEx1.RootTable.Columns("PRECIO")
            .Width = 70
            .Visible = True
            .FormatString = "0.00"
            .TextAlignment = 3
        End With
        With GridEx1
            .GroupByBoxVisible = False
            'diseño de la grilla
            '.VisualStyle = VisualStyle.Office2007
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
        End With
    End Sub
    Private Sub CargarOrden(cod As Integer)
        Dim dt As DataTable = TraerOrdenUnica(Orden)
        With dt.Rows(0)
            Paciente = .Item("oacli")
            cbCliente.Value = .Item("oacli")
            tbBoletaLab.Text = .Item("oabol")
            tbObservacion.Text = .Item("oaobs")
            cbMaterial.Value = .Item("material")
            cbTipoLente.Value = .Item("TipoLente")
            cbColorC.Value = .Item("color")
            cbRevestimiento.Value = .Item("revestimiento")
            cbDiseño.Value = .Item("diseño")
            cbTipoFiltro.Value = .Item("tipoFiltro")
            If .Item("oamonest") = 1 Then
                cbMonturaPropia.Checked = True
                tbMonturaPropia.Text = .Item("oamonP")
            Else
                cbMonturaPropia.Checked = False
                idProducto = .Item("codMontura")
                tbTipoLente.Text = .Item("MTipoLente")
                tbMarca.Text = .Item("marca")
                tbModelo.Text = .Item("modelo")
                tbColor2.Text = .Item("MColor")
                tbColorAux.Text = .Item("coloraux")
                tbBarra.Text = .Item("barra")
            End If

            TextBoxX1.Text = .Item("oacurv")
            TextBoxX2.Text = .Item("oadiamC")
            tbFechaRX.Value = .Item("oafrx")
            tbFechaE.Value = .Item("oaffe")
            tbFechaI.Value = .Item("oaffi")
            tbHoraE.Value = .Item("oafhe")
            tbHoraI.Value = .Item("oafhi")
            cbDoctor.Value = .Item("oadoc")
            cbPuente.Value = .Item("oapuem")
            cbVertical.Value = .Item("oavert")
            cbTamaño.Value = .Item("tamaño")
            cbTono.Value = .Item("oaton")
            cbDiametro.Value = .Item("oadiam")
            tbCodigo.Text = .Item("oanumi")

            Dim dt1 As DataTable = TraerDetalleOrdenUnica(cod)
            LimpiarGrilla(dt1)
            CargarGrillaDetalle(dt1)
        End With
    End Sub

    Private Sub LimpiarGrilla(ByRef dt As DataTable)
        'For i = 2 To dt.Columns.Count - 1 Step 1
        '    GridEx1.Col = i
        '    For j = 0 To dt.Rows.Count - 1 Step 1
        '        If dt.Rows(j).Item(i).ToString = "0.00" Then
        '            dt.Rows(j).Item(i) = String.Empty
        '        End If
        '    Next
        'Next
    End Sub
    Private Sub CargarCombos()
        '_prCargarComboTipoMaterial(cbTipoLente)
        _prCargarComboMaterial(cbMaterial)
        '_prCargarComboDiseño(cbDiseño)
        '_prCargarComboColor(cbColorC)
        _prCargarComboTipoFiltro(cbTipoFiltro)
        _prCargarComboRevestimiento(cbRevestimiento)
        '_prCargarComboColor(cbColorC)
        '_prCargarComboColor(cbColorC)
        _prCargarComboTipoLente(cbTipoLente)

        '_prCargarComboMarca(cbMarca)
        '_prCargarComboModelo(cbModelo)
        '_prCargarComboColor2(cbColor2)
        _prCargarComboADD(cbADD)
        _prCargarComboSHP(cbSPH)
        _prCargarComboCYL(cbCYL)
        _prCargarComboEje(cbEje)
        _prCargarComboAlt(cbAlt)
        _prCargarComboDip(cbDip)
        _prCargarComboTamaño(cbTamaño)
        _prCargarComboPuente(cbPuente)
        _prCargarComboVertical(cbVertical)
        _prCargarComboDiametro(cbDiametro)
        _prCargarComboLibreria(cbDoctor, "12", "1")

        _CargarComboPaciente(cbCliente)
    End Sub
    Private Sub _prCargarComboSHP(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarSHP()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 70
            .DropDownList.Columns("ycdes3").Caption = "MEDIDA"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With

        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub _prCargarComboCYL(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarCYL()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 70
            .DropDownList.Columns("ycdes3").Caption = "MEDIDA"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub _prCargarComboADD(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarADD()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 70
            .DropDownList.Columns("ycdes3").Caption = "MEDIDA"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub _prCargarComboEje(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 0 To 180 Step 1
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("ycdes3").Width = 70
            .DropDownList.Columns("ycdes3").Caption = "MEDIDA"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With

        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub _prCargarComboAlt(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 8 To 45 Step 1
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()

            .DropDownList.Columns.Add("ycdes3").Width = 70
            .DropDownList.Columns("ycdes3").Caption = "MEDIDA"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With

        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub

    Private Sub _prCargarComboDip(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 25 To 40 Step 1
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()

            .DropDownList.Columns.Add("ycdes3").Width = 70
            .DropDownList.Columns("ycdes3").Caption = "MEDIDA"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With

        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub

    Private Sub _prCargarComboMaterial(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarMaterial()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 200
            .DropDownList.Columns("ycdes3").Caption = "MATERIAL"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With

        mCombo.Value = 17
    End Sub

    Private Sub _prCargarComboTono(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarTono(cbTipoFiltro.Value)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "TONO"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        mCombo.SelectedIndex = 0
    End Sub


    Private Sub _prCargarComboTipoMaterial(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarTipoMaterial()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = " TIPO MATERIAL"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        mCombo.Value = 21
    End Sub

    Private Sub _prCargarComboDiseño(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarDiseño(cbTipoLente.Value)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "DISEÑO"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False

        End With
        mCombo.SelectedIndex = 0
    End Sub
    Private Sub _prCargarComboColor(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarColor(cbTipoFiltro.Value)
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "COLOR"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        mCombo.SelectedIndex = 0
    End Sub

    Private Sub _prCargarComboTipoFiltro(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarTipoFiltro()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "TIPO DE FILTRO"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        mCombo.SelectedIndex = 0
    End Sub
    Private Sub _prCargarComboRevestimiento(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarRevestimiento()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "REVESTIMIENTO"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        mCombo.Value = 5
    End Sub

    Private Sub _CargarComboPaciente(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarPacientes()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("ydnumi").Width = 60
            .DropDownList.Columns("ydnumi").Caption = "COD"
            .DropDownList.Columns.Add("yddesc").Width = 490
            .DropDownList.Columns("yddesc").Caption = "PACIENTE"
            .ValueMember = "ydnumi"
            .DisplayMember = "yddesc"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("ydnumi").Visible = False
        End With
        mCombo.SelectedIndex = 0
    End Sub
    Private Sub _prCargarComboColor2(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarColor2()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "COLOR"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
    End Sub

    Private Sub _prCargarComboTipoLente(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarTipoLente()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "TIPO LENTE"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        mCombo.Value = 21
    End Sub

    Private Sub _prCargarComboMarca(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarMarca()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "MARCA"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
    End Sub

    Private Sub _prCargarComboModelo(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarModelo()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "MODELO"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
    End Sub
    Private Sub _prCargarComboPuente(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 1 To 20 Step 1
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 162
            .DropDownList.Columns("ycdes3").Caption = "PUENTE"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub

    Private Sub _prCargarComboTamaño(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 38 To 60 Step 2
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 162
            .DropDownList.Columns("ycdes3").Caption = "TAMAÑO"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub _prCargarComboVertical(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 25 To 70 Step 1
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 162
            .DropDownList.Columns("ycdes3").Caption = "VERTICAL"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub _prCargarComboDiametro(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        AddNewColumns(dt, New String() {"ycdes3"})
        For i = 25 To 70 Step 1
            dt.Rows.Add(i)
        Next
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 162
            .DropDownList.Columns("ycdes3").Caption = "VERTICAL"
            .ValueMember = "ycdes3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .TextAlignment = 3
            .Refresh()
        End With
        With mCombo.DropDownList
            .Columns("yccod3").Visible = False
        End With
        With mCombo.DropDownList
            .Columns("ycdes3").TextAlignment = 3
        End With
    End Sub
    Private Sub SuperGridControl1DataBindingComplete(ByVal sender As Object, ByVal e As GridDataBindingCompleteEventArgs)
        'Dim panel As GridPanel = GridEx1.PrimaryGrid
        'Dim columns As GridColumnCollection = panel.Columns
        'columns("SPH").DisplayIndex = 0
        'columns("CYL").DisplayIndex = 1
        'columns("EJE").DisplayIndex = 2
        'columns("PRISMA").DisplayIndex = 3
        'columns("ADD").DisplayIndex = 4
        'columns("DIP").DisplayIndex = 5
        'columns("ALT").DisplayIndex = 5

        'SetColumnTw(columns, "SPH", "SPH.", 60)
        'SetColumnTw(columns, "CYL", "CYL", 60)
        'SetColumnTw(columns, "EJE", "EJE", 60)
        'SetColumnTw(columns, "PRISMA", "PRISMA", 60)
        'SetColumnTw(columns, "ADD", "ADD", 60)
        'SetColumnTw(columns, "DIP", "DIP", 60)
        'SetColumnTw(columns, "ALT", "ALT", 60)



        'panel.ColumnHeader.GroupHeaders.Add(GetSlContactInfoHeader(columns))
        'panel.ColumnHeader.GroupHeaders.Add(GetSlContactInfoHeader2(columns))
        'panel.ColumnHeader.GroupHeaders.Add(GetSlContactInfoHeader3(columns))
    End Sub
    Private Sub AddNewColumns(ByVal table As DataTable, ByVal names As IEnumerable(Of String))
        For Each name As String In names
            Dim col As New DataColumn()
            col.ColumnName = name
            If name = "PRECIO" Then
                col.DataType = Type.GetType("System.Double")
            Else
                col.DataType = Type.GetType("System.String")
            End If


            table.Columns.Add(col)
        Next name
    End Sub

    Private Sub SetColumnTw(ByVal columns As GridColumnCollection, ByVal name As String, ByVal text As String, Optional ByVal width As Integer = 100)
        Dim col As GridColumn = columns(name)

        If col IsNot Nothing Then
            col.HeaderText = text
            col.Width = width
        End If
    End Sub
    Private Function GetSlContactInfoHeader(ByVal columns As GridColumnCollection) As ColumnGroupHeader
        Dim cgh As New ColumnGroupHeader()

        cgh.Name = "cerca"
        cgh.HeaderText = "CERCA"

        cgh.MinRowHeight = 20


        cgh.HeaderStyles.Default.Background = New Background(Color.LightYellow, Color.Khaki)
        cgh.HeaderStyles.MouseOver.Background = New Background(Color.Khaki, Color.LightYellow)

        ' Set the header's start and end Display Indecees

        cgh.StartDisplayIndex = GetDisplayIndex(columns, "cercai")
        cgh.EndDisplayIndex = GetDisplayIndex(columns, "cercad")

        Return (cgh)
    End Function
    Private Function GetSlContactInfoHeader2(ByVal columns As GridColumnCollection) As ColumnGroupHeader
        Dim cgh1 As New ColumnGroupHeader()

        cgh1.Name = "medio"
        cgh1.HeaderText = "INT."

        cgh1.MinRowHeight = 20


        cgh1.HeaderStyles.Default.Background = New Background(Color.LightYellow, Color.Khaki)
        cgh1.HeaderStyles.MouseOver.Background = New Background(Color.Khaki, Color.LightYellow)

        ' Set the header's start and end Display Indecees

        cgh1.StartDisplayIndex = GetDisplayIndex(columns, "medioi")
        cgh1.EndDisplayIndex = GetDisplayIndex(columns, "mediod")

        Return (cgh1)
    End Function
    Private Function GetSlContactInfoHeader3(ByVal columns As GridColumnCollection) As ColumnGroupHeader
        Dim cgh As New ColumnGroupHeader()

        cgh.Name = "lejos"
        cgh.HeaderText = "LEJOS."

        cgh.MinRowHeight = 20


        cgh.HeaderStyles.Default.Background = New Background(Color.LightYellow, Color.Khaki)
        cgh.HeaderStyles.MouseOver.Background = New Background(Color.Khaki, Color.LightYellow)

        ' Set the header's start and end Display Indecees

        cgh.StartDisplayIndex = GetDisplayIndex(columns, "lejosi")
        cgh.EndDisplayIndex = GetDisplayIndex(columns, "lejosd")

        Return (cgh)
    End Function

    Private Function GetDisplayIndex(ByVal columns As GridColumnCollection, ByVal name As String) As Integer
        Return (columns.GetDisplayIndex(columns(name)))
    End Function
    Private Sub tbCantidad_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbCantidad_KeyDown(sender As Object, e As KeyEventArgs)
        'If (e.KeyData = Keys.Escape) Then
        '    bandera = False
        '    Me.Close()
        'End If
        'If (e.KeyData = Keys.Enter) Then

        '    If (tbCantidad.Value > Stock) Then
        '        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '        ToastNotification.Show(Me, "La cantidad Ingresada " + Str(tbCantidad.Value) + " Es superior a la cantidad Disponible del Producto : " + Str(Stock), img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '        Return

        '    Else
        '        If (tbCantidad.Value <= 0) Then
        '            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '            ToastNotification.Show(Me, "La cantidad debe ser mayor a 0", img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '            Return

        '        Else
        '            If (CategoriaPrecio = 50) Then
        '                Dim dt As DataTable = L_fnGeneralProductosDescuentos(idProducto)

        '                Dim BanderaPrecio As Boolean = False
        '                For i As Integer = 0 To dt.Rows.Count - 1 Step 1
        '                    If (dt.Rows(i).Item("estadoDescuento") = True) Then
        '                        'If (tbCantidad.Value >= dt.Rows(i).Item("dacant1") And tbCantidad.Value <= dt.Rows(i).Item("dacant2")) Then
        '                        '    Cantidad = tbCantidad.Value
        '                        '    bandera = True
        '                        '    Precio = dt.Rows(i).Item("dapreciou")
        '                        '    BanderaPrecio = True
        '                        '    Me.Close()



        '                        'End If
        '                    End If


        '                Next
        '                If (BanderaPrecio = False) Then
        '                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 30, 30)
        '                    ToastNotification.Show(Me, "Cantidad ingresada no pertenece a la categoria mayorista".ToUpper, img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '                    Return
        '                End If


        '            Else
        '                'Cantidad = tbCantidad.Value
        '                bandera = True
        '                Me.Close()
        '            End If

        '        End If


        '    End If
        'End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        'If (tbCantidad.Value > Stock) Then
        '    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '    ToastNotification.Show(Me, "La cantidad Ingresada " + Str(tbCantidad.Value) + " Es superior a la cantidad Disponible del Producto : " + Str(Stock), img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '    Return

        'Else
        '    If (tbCantidad.Value <= 0) Then
        '        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
        '        ToastNotification.Show(Me, "La cantidad debe ser mayor a 0", img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '        Return

        '    Else
        '        If (CategoriaPrecio = 50) Then
        '            Dim dt As DataTable = L_fnGeneralProductosDescuentos(idProducto)

        '            Dim BanderaPrecio As Boolean = False
        '            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
        '                If (dt.Rows(i).Item("estadoDescuento") = True) Then
        '                    If (tbCantidad.Value >= dt.Rows(i).Item("dacant1") And tbCantidad.Value <= dt.Rows(i).Item("dacant2")) Then
        '                        Cantidad = tbCantidad.Value
        '                        bandera = True
        '                        Precio = dt.Rows(i).Item("dapreciou")
        '                        BanderaPrecio = True
        '                        Me.Close()



        '                    End If
        '                End If


        '            Next
        '            If (BanderaPrecio = False) Then
        '                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 30, 30)
        '                ToastNotification.Show(Me, "Cantidad ingresada no pertenece a la categoria mayorista".ToUpper, img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
        '                Return
        '            End If


        '        Else
        '            Cantidad = tbCantidad.Value
        '            bandera = True
        '            Me.Close()
        '        End If

        '    End If


        'End If
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
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        bandera = False
        Me.Close()
    End Sub

    Private Sub LabelX19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        bandera = False
        Me.Close()
    End Sub

    Private Function TraerMedidas(cod As Integer) As DataTable
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim tbsph = L_fnListarSHP()
        Dim tbcyl = L_fnListarCYL()
        Dim sph As Integer
        Dim cyl As Integer
        dt.Columns.Add("distancia")
        dt.Columns.Add("ojo")
        dt.Columns.Add("producto")
        dt.Columns.Add("SPH")
        dt.Columns.Add("CYL")
        dt.Columns.Add("precio")
        dt2.Columns.Add("distancia")
        dt2.Columns.Add("ojo")
        dt2.Columns.Add("Material")
        dt2.Columns.Add("id")
        dt2.Columns.Add("SPH")
        dt2.Columns.Add("CYL")
        dt2.Columns.Add("precio")


        For I = 0 To CType(GridEx1.DataSource, DataTable).Rows.Count - 1 Step 1
            If CType(GridEx1.DataSource, DataTable).Rows(I).Item("SPH") = "0.00" And CType(GridEx1.DataSource, DataTable).Rows(I).Item("CYL") = "0.00" Then
            Else
                Dim busca_renglon() As DataRow
                busca_renglon = tbsph.Select("ycdes3='" & CType(GridEx1.DataSource, DataTable).Rows(I).Item("SPH") & "'")
                If busca_renglon.Length > 0 Then
                    sph = (busca_renglon(0).Item(0))
                    'Resultado: Infante
                Else
                    sph = 1
                End If
                busca_renglon = tbcyl.Select("ycdes3='" & CType(GridEx1.DataSource, DataTable).Rows(I).Item("CYL") & "'")
                If busca_renglon.Length > 0 Then
                    cyl = (busca_renglon(0).Item(0))
                    'Resultado: Infante
                Else
                    cyl = 1
                End If
                Dim producto As String = TraerCristal(cbMaterial.Value, cbTipoLente.Value, cbDiseño.Value, cbColorC.Value, cbTipoFiltro.Value, cbRevestimiento.Value, sph, cyl)
                If producto = "NO EXISTE" Then
                    dt2.Rows.Add(CType(GridEx1.DataSource, DataTable).Rows(I).Item("DISTANCIA"), CType(GridEx1.DataSource, DataTable).Rows(I).Item("OJO"), cbMaterial.Text, cbMaterial.Value, CType(GridEx1.DataSource, DataTable).Rows(I).Item("SPH"), CType(GridEx1.DataSource, DataTable).Rows(I).Item("CYL"), CType(GridEx1.DataSource, DataTable).Rows(I).Item("PRECIO"))
                Else
                    dt.Rows.Add(CType(GridEx1.DataSource, DataTable).Rows(I).Item("DISTANCIA"), CType(GridEx1.DataSource, DataTable).Rows(I).Item("OJO"), producto, CType(GridEx1.DataSource, DataTable).Rows(I).Item("SPH"), CType(GridEx1.DataSource, DataTable).Rows(I).Item("CYL"), CType(GridEx1.DataSource, DataTable).Rows(I).Item("PRECIO"))
                End If
            End If

        Next
        If cod = 1 Then
            Return dt
        Else
            Return dt2
        End If
    End Function

    Private Sub CargarMontura()

    End Sub

    Private Sub LlenarVacio()
        For i = 2 To CType(GridEx1.DataSource, DataTable).Columns.Count - 1 Step 1
            GridEx1.Col = i
            For j = 0 To CType(GridEx1.DataSource, DataTable).Rows.Count - 1 Step 1
                If CType(GridEx1.DataSource, DataTable).Rows(j).Item(i).ToString = String.Empty Then
                    CType(GridEx1.DataSource, DataTable).Rows(j).Item(i) = "0.00"
                End If
            Next
        Next
    End Sub
    Private Sub ImprimirNota()
        Dim dt As DataTable = TraerOrden(CInt(tbCodigo.Text))
        bandera = True
        P_Global.Visualizador = New Visualizador
        Dim objrep As New R_NotaOrdenOptica
        '' GenerarNro(_dt)
        ''objrep.SetDataSource(Dt1Kardex)

        objrep.SetDataSource(dt)
        'objrep.SetParameterValue("Literal1", li)
        'If swTipoVenta.Value = True Then
        '    objrep.SetParameterValue("ENombre", "Nota de Entrega Nro. " + numi)
        'Else
        '    objrep.SetParameterValue("ENombre", "Nota de Crédito Nro. " + numi)
        'End If
        'objrep.SetParameterValue("ECiudadPais", _FechaPar)
        'objrep.SetParameterValue("Sucursal", cbSucursal.Text)
        objrep.SetParameterValue("estadoMontura", IIf(cbMonturaPropia.Checked, 1, 0))
        objrep.SetParameterValue("monturaPropia", tbMonturaPropia.Text)
        objrep.SetParameterValue("logo", gb_UbiLogo)
        P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
        P_Global.Visualizador.ShowDialog() 'Comentar
        P_Global.Visualizador.BringToFront() 'Comentar
    End Sub
    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Modificar = True Then
            Dim ef = New Efecto
            ef.tipo = 2
            ef.Header = "Los datos de la venta seran sobreescritos".ToUpper
            ef.Context = "mensaje principal".ToUpper
            ef.ShowDialog()
            'Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                LlenarVacio()
                Dim medidas As DataTable = TraerMedidas(1)
                Dim medidasX As DataTable = TraerMedidas(2)
                'TraerLente(cbMaterial.Value, cbTipoLente.Value, cbRevestimiento.Value, cbDiseño.Value, cbTipoFiltro.Value, cbColorC,)
                L_fnModificarOrden(CInt(tbCodigo.Text), IIf(cbCliente.SelectedIndex < 0 And cbCliente.Text <> String.Empty, 0, cbCliente.Value), cbCliente.Text, cbDoctor.Value, TextBoxX3.Text, TextBoxX4.Text, tbFechaRX.Value.ToString("dd/MM/yyyy"), tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaE.Value.ToString("dd/MM/yyyy"), tbHoraI.Value.ToString("HH:mm"),
                               tbHoraE.Value.ToString("HH:mm"), cbMaterial.Value, cbDiseño.Value, cbTipoLente.Value, cbTipoFiltro.Value, cbRevestimiento.Value, cbColorC.Value, cbTono.Value, idProducto, cbTamaño.Value, cbPuente.Text,
                              cbVertical.Text, cbDiametro.Text, TextBoxX1.Text, TextBoxX2.Text, tbObservacion.Text, tbBoletaLab.Text, CType(GridEx1.DataSource, DataTable), IIf(cbMonturaPropia.Checked = True, 1, 0), tbMonturaPropia.Text)
                CargarMontura()
                cristales = medidas
                cristalesX = medidasX
                Orden = CInt(tbCodigo.Text)
                Dim obs As String = ""
                CargarObservacion(obs)
                If cbMonturaPropia.Checked = True Then
                    idProducto = -1
                End If
                bandera = True
                Me.Close()
            End If
        Else
            LlenarVacio()
            Dim medidas As DataTable = TraerMedidas(1)
            Dim medidasX As DataTable = TraerMedidas(2)
            'TraerLente(cbMaterial.Value, cbTipoLente.Value, cbRevestimiento.Value, cbDiseño.Value, cbTipoFiltro.Value, cbColorC,)
            L_fnRegistrarOrden(IIf(cbCliente.SelectedIndex < 0 And cbCliente.Text <> String.Empty, 0, cbCliente.Value), cbCliente.Text, cbDoctor.Value, TextBoxX3.Text, TextBoxX4.Text, tbFechaRX.Value.ToString("dd/MM/yyyy"), tbFechaI.Value.ToString("dd/MM/yyyy"), tbFechaE.Value.ToString("dd/MM/yyyy"), tbHoraI.Value.ToString("HH:mm"),
                           tbHoraE.Value.ToString("HH:mm"), cbMaterial.Value, cbDiseño.Value, cbTipoLente.Value, cbTipoFiltro.Value, cbRevestimiento.Value, cbColorC.Value, cbTono.Value, idProducto, cbTamaño.Value, cbPuente.Text,
                          cbVertical.Text, cbDiametro.Text, TextBoxX1.Text, TextBoxX2.Text, tbObservacion.Text, tbBoletaLab.Text, CType(GridEx1.DataSource, DataTable), IIf(cbMonturaPropia.Checked = True, 1, 0), tbMonturaPropia.Text)
            CargarMontura()
            cristales = medidas
            cristalesX = medidasX
            Orden = CInt(tbCodigo.Text)
            Dim obs As String = ""
            CargarObservacion(obs)

            bandera = True
            Me.Close()
        End If


    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click

    End Sub

    Private Sub CargarObservacion(obs As String)
        obs = cbMaterial.Text
        If cbTipoLente.Value <> 1 Then
            obs = obs & " - " & cbTipoLente.Text
        End If
        If cbDiseño.Value <> 1 Then
            obs = obs & " - " & cbDiseño.Text
        End If

        If cbRevestimiento.Value <> 1 Then
            obs = obs & " - " & cbRevestimiento.Text
        End If
        If cbTipoFiltro.Value <> 1 Then
            obs = obs & " - " & cbTipoFiltro.Text
        End If
        If cbColorC.Value <> 1 Then
            obs = obs & " - " & cbColorC.Text
        End If
        If cbTono.Value <> 1 Then
            obs = obs & " - " & cbTono.Text
        End If

        Observacion = obs

    End Sub

    Private Sub btMaterial_Click(sender As Object, e As EventArgs)
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "10", "1", cbMaterial.Text, "") Then
            _prCargarComboLibreria(cbMaterial, "10", "1")
            cbMaterial.SelectedIndex = CType(cbMaterial.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btTipoMaterial_Click(sender As Object, e As EventArgs)
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "10", "2", cbTipoLente.Text, "") Then
            _prCargarComboLibreria(cbTipoLente, "10", "2")
            cbTipoLente.SelectedIndex = CType(cbTipoLente.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btColor_Click(sender As Object, e As EventArgs)
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "10", "4", cbColorC.Text, "") Then
            _prCargarComboLibreria(cbColorC, "10", "4")
            cbColorC.SelectedIndex = CType(cbColorC.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    Private Sub btRevestimiento_Click(sender As Object, e As EventArgs)
        Dim numi As String = ""

        If L_prLibreriaGrabar(numi, "10", "3", cbDiseño.Text, "") Then
            _prCargarComboLibreria(cbDiseño, "10", "3")
            cbDiseño.SelectedIndex = CType(cbDiseño.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub

    'Private Sub btTipoLente_Click(sender As Object, e As EventArgs)
    '    Dim numi As String = ""

    '    If L_prLibreriaGrabar(numi, "11", "1", cbTipoLente1.Text, "") Then
    '        _prCargarComboLibreria(cbTipoLente1, "11", "1")
    '        cbTipoLente1.SelectedIndex = CType(cbTipoLente1.DataSource, DataTable).Rows.Count - 1
    '    End If
    'End Sub

    'Private Sub btMarca_Click(sender As Object, e As EventArgs)
    '    Dim numi As String = ""

    '    If L_prLibreriaGrabar(numi, "11", "2", cbMarca.Text, "") Then
    '        _prCargarComboLibreria(cbMarca, "11", "2")
    '        cbMarca.SelectedIndex = CType(cbMarca.DataSource, DataTable).Rows.Count - 1
    '    End If
    'End Sub



    'Private Sub cbTipoLente_ValueChanged(sender As Object, e As EventArgs)
    '    If cbTipoLente1.SelectedIndex < 0 And cbTipoLente1.Text <> String.Empty Then
    '        btTipoLente.Visible = False
    '    Else
    '        btTipoLente.Visible = False
    '    End If
    'End Sub

    'Private Sub cbMarca_ValueChanged(sender As Object, e As EventArgs)
    '    If cbMarca.SelectedIndex < 0 And cbMarca.Text <> String.Empty Then
    '        btMarca.Visible = False
    '    Else
    '        btMarca.Visible = False
    '    End If
    'End Sub

    'Private Sub cbModelo_ValueChanged(sender As Object, e As EventArgs)
    '    If cbModelo.SelectedIndex < 0 And cbModelo.Text <> String.Empty Then
    '        btModelo.Visible = False
    '    Else
    '        btModelo.Visible = False
    '    End If
    'End Sub

    'Private Sub cbColor2_ValueChanged(sender As Object, e As EventArgs)
    '    If cbColor2.SelectedIndex < 0 And cbColor2.Text <> String.Empty Then
    '        btColor2.Visible = False
    '    Else
    '        btDoctor.Visible = False
    '    End If
    'End Sub

    'Private Sub btModelo_Click(sender As Object, e As EventArgs)
    '    Dim numi As String = ""

    '    If L_prLibreriaGrabar(numi, "11", "3", cbModelo.Text, "") Then
    '        _prCargarComboLibreria(cbModelo, "11", "3")
    '        cbModelo.SelectedIndex = CType(cbModelo.DataSource, DataTable).Rows.Count - 1
    '    End If
    'End Sub

    'Private Sub btColor2_Click(sender As Object, e As EventArgs)
    '    Dim numi As String = ""

    '    If L_prLibreriaGrabar(numi, "10", "4", cbColor2.Text, "") Then
    '        _prCargarComboLibreria(cbColor2, "10", "4")
    '        cbColor2.SelectedIndex = CType(cbColor2.DataSource, DataTable).Rows.Count - 1
    '    End If
    'End Sub

    Private Sub cbDoctor_ValueChanged(sender As Object, e As EventArgs) Handles cbDoctor.ValueChanged
        If cbDoctor.SelectedIndex < 0 And cbDoctor.Text <> String.Empty Then
            btDoctor.Visible = True
        Else
            btDoctor.Visible = False
        End If
    End Sub

    Private Sub btDoctor_Click(sender As Object, e As EventArgs) Handles btDoctor.Click
        Dim numi As String = ""
        If L_prLibreriaGrabar(numi, "12", "1", cbDoctor.Text, "") Then
            _prCargarComboLibreria(cbDoctor, "12", "1")
            cbDoctor.SelectedIndex = CType(cbDoctor.DataSource, DataTable).Rows.Count - 1
        End If
    End Sub


    Private Sub SeleccionarCategoria()
        Dim dt As DataTable

        dt = L_fnListarMonturas()
        '              a.ydnumi, a.ydcod, a.yddesc, a.yddctnum, a.yddirec
        ',a.ydtelf1 ,a.ydfnac 

        Dim listEstCeldas As New List(Of Modelo.Celda)
        listEstCeldas.Add(New Modelo.Celda("yfnumi,", False, "ID", 50))

        listEstCeldas.Add(New Modelo.Celda("yfcbarra,", False, "CodBarra", 50))
        listEstCeldas.Add(New Modelo.Celda("producto", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("yfgr1", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("TipoLente", True, "TIPO DE LENTE", 180))
        listEstCeldas.Add(New Modelo.Celda("yfgr2", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("Marca", True, "MARCA", 280))
        listEstCeldas.Add(New Modelo.Celda("yfgr3", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("Modelo", True, "MODELO".ToUpper, 150))
        listEstCeldas.Add(New Modelo.Celda("yfcprod", True, "CODIGO", 280))
        listEstCeldas.Add(New Modelo.Celda("yfgr4", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("color", True, "COLOR", 220))
        listEstCeldas.Add(New Modelo.Celda("yfgr6", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("tamaño", False, "TAMAÑO", 220))
        listEstCeldas.Add(New Modelo.Celda("yfgr7", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("colorA", True, "COLOR AUX", 220))
        Dim ef = New Efecto
        ef.tipo = 3
        ef.dt = dt
        ef.SeleclCol = 2
        ef.listEstCeldas = listEstCeldas
        ef.alto = 50
        ef.ancho = 350
        ef.Context = "Seleccione Montura".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row

            idProducto = Row.Cells("yfnumi").Value

            tbTipoLente.Text = Row.Cells("TipoLente").Value
            tbMarca.Text = Row.Cells("Marca").Value
            tbModelo.Text = Row.Cells("Modelo").Value
            tbColor2.Text = Row.Cells("color").Value
            tbBarra.Text = Row.Cells("yfcbarra").Value
            tbCodMontura.Text = Row.Cells("yfcprod").Value
            tbColorAux.Text = Row.Cells("colorA").Value

            TipoLente = Row.Cells("yfgr1").Value
            Marca = Row.Cells("yfgr2").Value
            Modelo = Row.Cells("yfgr3").Value
            ColorM = Row.Cells("yfgr4").Value

        End If
    End Sub
    Private Sub tbMontura_KeyDown(sender As Object, e As KeyEventArgs) Handles tbMontura.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            SeleccionarCategoria()
        End If
    End Sub

    Private Sub ButtonX11_Click(sender As Object, e As EventArgs) Handles ButtonX11.Click
        SeleccionarCategoria()
    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        ImprimirNota()
    End Sub

    Private Sub cbCYL_ValueChanged(sender As Object, e As EventArgs) Handles cbCYL.ValueChanged

    End Sub

    Private Sub cbSPH_ValueChanged(sender As Object, e As EventArgs) Handles cbSPH.ValueChanged

    End Sub

    Private Sub cbADD_ValueChanged(sender As Object, e As EventArgs) Handles cbADD.ValueChanged

    End Sub

    Private Sub GridEx1_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles GridEx1.CellValueChanged

    End Sub

    Private Sub cbCliente_ValueChanged(sender As Object, e As EventArgs) Handles cbCliente.ValueChanged
        If cbCliente.SelectedIndex < 0 And cbCliente.Text <> String.Empty Then
            TextBoxX3.Text = ""
            TextBoxX4.Text = ""
            'Paciente = -1
        Else
            Dim dt As DataTable = TraerDatosPaciente(cbCliente.Value)
            If dt.Rows.Count > 0 Then
                TextBoxX3.Text = dt.Rows(0).Item("sanom2")
                TextBoxX4.Text = dt.Rows(0).Item("saemail")
            End If
            'Paciente = cbCliente.Value
        End If
        Paciente = -1
    End Sub

    Private Sub GridEx1_EditingCell(sender As Object, e As EditingCellEventArgs) Handles GridEx1.EditingCell
        If Modificar = False And Nuevo = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub cbTipoLente_ValueChanged(sender As Object, e As EventArgs) Handles cbTipoLente.ValueChanged
        _prCargarComboDiseño(cbDiseño)
    End Sub

    Private Sub cbTipoFiltro_ValueChanged(sender As Object, e As EventArgs) Handles cbTipoFiltro.ValueChanged
        _prCargarComboColor(cbColorC)

        _prCargarComboTono(cbTono)
    End Sub

    Private Sub GridEx1_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GridEx1.FormattingRow

    End Sub

    Private Sub cbMonturaPropia_CheckedChanged(sender As Object, e As EventArgs) Handles cbMonturaPropia.CheckedChanged
        If cbMonturaPropia.Checked = True Then
            ButtonX11.Enabled = False
            LabelX12.Visible = False
            LabelX13.Visible = False
            LabelX14.Visible = False
            LabelX15.Visible = False
            LabelX24.Visible = False
            LabelX31.Visible = False
            LabelX32.Visible = False
            tbMonturaPropia.Visible = True

            tbBarra.Visible = False
            tbTipoLente.Visible = False
            tbCodMontura.Visible = False
            tbMarca.Visible = False
            tbModelo.Visible = False
            tbColor2.Visible = False
            tbColorAux.Visible = False
        Else
            ButtonX11.Enabled = True
            LabelX12.Visible = True
            LabelX13.Visible = True
            LabelX14.Visible = True
            LabelX15.Visible = True
            LabelX24.Visible = True
            LabelX31.Visible = True
            LabelX32.Visible = True
            tbMonturaPropia.Visible = False
            tbBarra.Visible = True
            tbTipoLente.Visible = True
            tbCodMontura.Visible = True
            tbMarca.Visible = True
            tbModelo.Visible = True
            tbColor2.Visible = True
            tbColorAux.Visible = True
        End If
    End Sub

    Private Sub GroupPanel1_Click(sender As Object, e As EventArgs) Handles GroupPanel1.Click

    End Sub

    Private Sub cbRevestimiento_ValueChanged(sender As Object, e As EventArgs) Handles cbRevestimiento.ValueChanged
        If cbMaterial.Value = 18 And cbRevestimiento.Value = 5 Then
            _CargarComboTipoFiltro2()
        Else
            _prCargarComboTipoFiltro(cbTipoFiltro)
        End If
    End Sub
    Private Sub _CargarComboTipoFiltro2()
        Dim dt As DataTable
        dt = L_fnListarTipoFiltro2()
        With cbTipoFiltro
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("yccod3").Width = 60
            .DropDownList.Columns("yccod3").Caption = "COD"
            .DropDownList.Columns.Add("ycdes3").Width = 167
            .DropDownList.Columns("ycdes3").Caption = "TIPO DE FILTRO"
            .ValueMember = "yccod3"
            .DisplayMember = "ycdes3"
            .DataSource = dt
            .Refresh()
        End With
        With cbTipoFiltro.DropDownList
            .Columns("yccod3").Visible = False
        End With
        cbTipoFiltro.SelectedIndex = 0

    End Sub

    Private Sub cbMaterial_ValueChanged(sender As Object, e As EventArgs) Handles cbMaterial.ValueChanged
        If cbMaterial.Value = 18 And cbRevestimiento.Value = 5 Then
            _CargarComboTipoFiltro2()
        Else
            _prCargarComboTipoFiltro(cbTipoFiltro)
        End If
    End Sub
End Class