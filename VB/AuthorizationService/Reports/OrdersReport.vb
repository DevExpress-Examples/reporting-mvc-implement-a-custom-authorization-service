Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for OrdersReport
''' </summary>
Public Class OrdersReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private xrLabel1 As XRLabel
    Private xrLabel2 As XRLabel
    Private xrLabel3 As XRLabel
    Private xrLabel4 As XRLabel
    Private xrLabel5 As XRLabel
    Private xrLabel6 As XRLabel
    Private xrLabel7 As XRLabel
    Private xrLabel8 As XRLabel
    Private xrLine1 As XRLine
    Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private pageFooterBand1 As PageFooterBand
    Private xrPageInfo1 As XRPageInfo
    Private xrPageInfo2 As XRPageInfo
    Private reportHeaderBand1 As ReportHeaderBand
    Private xrLabel9 As XRLabel
    Private Title As XRControlStyle
    Private FieldCaption As XRControlStyle
    Private PageInfo As XRControlStyle
    Private DataField As XRControlStyle
    Private DetailReport As DetailReportBand
    Private Detail1 As DetailBand
    Private xrLabel12 As XRLabel
    Private xrLabel11 As XRLabel
    Private xrLabel10 As XRLabel
    Private GroupHeader1 As GroupHeaderBand
    Private xrLabel15 As XRLabel
    Private xrLabel14 As XRLabel
    Private xrLabel13 As XRLabel

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column1 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table1 As New DevExpress.DataAccess.Sql.Table()
        Dim column2 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column3 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column4 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column5 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column6 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column7 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column8 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column9 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column10 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column11 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column12 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column13 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression13 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column14 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression14 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column15 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table2 As New DevExpress.DataAccess.Sql.Table()
        Dim column16 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column17 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column18 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression18 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column19 As New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression19 As New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLine1})
        Me.Detail.Dpi = 100.0F
        Me.Detail.HeightF = 104.0F
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' TopMargin
        ' 
        Me.TopMargin.Dpi = 100.0F
        Me.TopMargin.HeightF = 100.0F
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' BottomMargin
        ' 
        Me.BottomMargin.Dpi = 100.0F
        Me.BottomMargin.HeightF = 100.0F
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' sqlDataSource1
        ' 
        Me.sqlDataSource1.ConnectionName = "nwind"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        columnExpression1.ColumnName = "OrderID"
        table1.Name = "Orders"
        columnExpression1.Table = table1
        column1.Expression = columnExpression1
        columnExpression2.ColumnName = "CustomerID"
        columnExpression2.Table = table1
        column2.Expression = columnExpression2
        columnExpression3.ColumnName = "EmployeeID"
        columnExpression3.Table = table1
        column3.Expression = columnExpression3
        columnExpression4.ColumnName = "OrderDate"
        columnExpression4.Table = table1
        column4.Expression = columnExpression4
        columnExpression5.ColumnName = "RequiredDate"
        columnExpression5.Table = table1
        column5.Expression = columnExpression5
        columnExpression6.ColumnName = "ShippedDate"
        columnExpression6.Table = table1
        column6.Expression = columnExpression6
        columnExpression7.ColumnName = "ShipVia"
        columnExpression7.Table = table1
        column7.Expression = columnExpression7
        columnExpression8.ColumnName = "Freight"
        columnExpression8.Table = table1
        column8.Expression = columnExpression8
        columnExpression9.ColumnName = "ShipName"
        columnExpression9.Table = table1
        column9.Expression = columnExpression9
        columnExpression10.ColumnName = "ShipAddress"
        columnExpression10.Table = table1
        column10.Expression = columnExpression10
        columnExpression11.ColumnName = "ShipCity"
        columnExpression11.Table = table1
        column11.Expression = columnExpression11
        columnExpression12.ColumnName = "ShipRegion"
        columnExpression12.Table = table1
        column12.Expression = columnExpression12
        columnExpression13.ColumnName = "ShipPostalCode"
        columnExpression13.Table = table1
        column13.Expression = columnExpression13
        columnExpression14.ColumnName = "ShipCountry"
        columnExpression14.Table = table1
        column14.Expression = columnExpression14
        selectQuery1.Columns.Add(column1)
        selectQuery1.Columns.Add(column2)
        selectQuery1.Columns.Add(column3)
        selectQuery1.Columns.Add(column4)
        selectQuery1.Columns.Add(column5)
        selectQuery1.Columns.Add(column6)
        selectQuery1.Columns.Add(column7)
        selectQuery1.Columns.Add(column8)
        selectQuery1.Columns.Add(column9)
        selectQuery1.Columns.Add(column10)
        selectQuery1.Columns.Add(column11)
        selectQuery1.Columns.Add(column12)
        selectQuery1.Columns.Add(column13)
        selectQuery1.Columns.Add(column14)
        selectQuery1.MetaSerializable = "140|20|100|275"
        selectQuery1.Name = "Orders"
        selectQuery1.Tables.Add(table1)
        columnExpression15.ColumnName = "OrderID"
        table2.Name = "OrderDetails"
        columnExpression15.Table = table2
        column15.Expression = columnExpression15
        columnExpression16.ColumnName = "ProductID"
        columnExpression16.Table = table2
        column16.Expression = columnExpression16
        columnExpression17.ColumnName = "UnitPrice"
        columnExpression17.Table = table2
        column17.Expression = columnExpression17
        columnExpression18.ColumnName = "Quantity"
        columnExpression18.Table = table2
        column18.Expression = columnExpression18
        columnExpression19.ColumnName = "Discount"
        columnExpression19.Table = table2
        column19.Expression = columnExpression19
        selectQuery2.Columns.Add(column15)
        selectQuery2.Columns.Add(column16)
        selectQuery2.Columns.Add(column17)
        selectQuery2.Columns.Add(column18)
        selectQuery2.Columns.Add(column19)
        selectQuery2.MetaSerializable = "20|20|100|122"
        selectQuery2.Name = "OrderDetails"
        selectQuery2.Tables.Add(table2)
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
        masterDetailInfo1.DetailQueryName = "OrderDetails"
        relationColumnInfo1.NestedKeyColumn = "OrderID"
        relationColumnInfo1.ParentKeyColumn = "OrderID"
        masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
        masterDetailInfo1.MasterQueryName = "Orders"
        Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        ' 
        ' xrLabel1
        ' 
        Me.xrLabel1.Dpi = 100.0F
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 9.0F)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(162.0F, 18.0F)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Shipped Date"
        ' 
        ' xrLabel2
        ' 
        Me.xrLabel2.Dpi = 100.0F
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 33.0F)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(162.0F, 18.0F)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.Text = "Ship Address"
        ' 
        ' xrLabel4
        ' 
        Me.xrLabel4.Dpi = 100.0F
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 81.0F)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(162.0F, 18.0F)
        Me.xrLabel4.StyleName = "FieldCaption"
        Me.xrLabel4.Text = "Order Date"
        ' 
        ' xrLabel5
        ' 
        Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShippedDate")})
        Me.xrLabel5.Dpi = 100.0F
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(174.0F, 9.0F)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(470.0F, 18.0F)
        Me.xrLabel5.StyleName = "DataField"
        Me.xrLabel5.Text = "xrLabel5"
        ' 
        ' xrLabel6
        ' 
        Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.ShipAddress")})
        Me.xrLabel6.Dpi = 100.0F
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(174.0F, 33.0F)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(470.0F, 18.0F)
        Me.xrLabel6.StyleName = "DataField"
        Me.xrLabel6.Text = "xrLabel6"
        ' 
        ' xrLabel8
        ' 
        Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderDate")})
        Me.xrLabel8.Dpi = 100.0F
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(174.0F, 81.0F)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(470.0F, 18.0F)
        Me.xrLabel8.StyleName = "DataField"
        Me.xrLabel8.Text = "xrLabel8"
        ' 
        ' xrLine1
        ' 
        Me.xrLine1.Dpi = 100.0F
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 3.0F)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(638.0F, 2.0F)
        ' 
        ' pageFooterBand1
        ' 
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.Dpi = 100.0F
        Me.pageFooterBand1.HeightF = 29.00001F
        Me.pageFooterBand1.Name = "pageFooterBand1"
        ' 
        ' xrPageInfo1
        ' 
        Me.xrPageInfo1.Dpi = 100.0F
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.999999F, 6.00001F)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(271.3333F, 23.0F)
        Me.xrPageInfo1.StyleName = "PageInfo"
        ' 
        ' xrPageInfo2
        ' 
        Me.xrPageInfo2.Dpi = 100.0F
        Me.xrPageInfo2.Format = "Page {0} of {1}"
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0F, 6.0F)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0F, 23.0F)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        ' 
        ' reportHeaderBand1
        ' 
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel9})
        Me.reportHeaderBand1.Dpi = 100.0F
        Me.reportHeaderBand1.HeightF = 51.0F
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        ' 
        ' xrLabel9
        ' 
        Me.xrLabel9.Dpi = 100.0F
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 6.0F)
        Me.xrLabel9.Multiline = True
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(638.0F, 33.0F)
        Me.xrLabel9.StyleName = "Title"
        Me.xrLabel9.Text = "Orders Report" & ControlChars.CrLf
        ' 
        ' Title
        ' 
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0F
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0F, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        ' 
        ' FieldCaption
        ' 
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0F
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        ' 
        ' PageInfo
        ' 
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0F
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0F, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        ' 
        ' DataField
        ' 
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0F
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0F)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        ' 
        ' xrLabel3
        ' 
        Me.xrLabel3.Dpi = 100.0F
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6.0F, 57.0F)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(162.0F, 18.0F)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.Text = "Order ID"
        ' 
        ' xrLabel7
        ' 
        Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrderID")})
        Me.xrLabel7.Dpi = 100.0F
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174.0F, 57.0F)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(470.0F, 18.0F)
        Me.xrLabel7.StyleName = "DataField"
        Me.xrLabel7.Text = "xrLabel7"
        ' 
        ' DetailReport
        ' 
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1})
        Me.DetailReport.DataMember = "Orders.OrdersOrderDetails"
        Me.DetailReport.DataSource = Me.sqlDataSource1
        Me.DetailReport.Dpi = 100.0F
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        ' 
        ' Detail1
        ' 
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel12, Me.xrLabel11, Me.xrLabel10})
        Me.Detail1.Dpi = 100.0F
        Me.Detail1.HeightF = 23.0F
        Me.Detail1.KeepTogether = True
        Me.Detail1.MultiColumn.ColumnCount = 2
        Me.Detail1.Name = "Detail1"
        ' 
        ' xrLabel10
        ' 
        Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.ProductID")})
        Me.xrLabel10.Dpi = 100.0F
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(320.8333F, 0F)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0F)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(100.0F, 23.0F)
        Me.xrLabel10.Text = "xrLabel10"
        ' 
        ' xrLabel11
        ' 
        Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.Quantity")})
        Me.xrLabel11.Dpi = 100.0F
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(420.8333F, 0F)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0F)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(100.0F, 23.0F)
        Me.xrLabel11.Text = "xrLabel11"
        ' 
        ' xrLabel12
        ' 
        Me.xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.UnitPrice")})
        Me.xrLabel12.Dpi = 100.0F
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(520.8333F, 0F)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0F)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(123.1667F, 23.0F)
        Me.xrLabel12.Text = "xrLabel12"
        ' 
        ' GroupHeader1
        ' 
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel15, Me.xrLabel14, Me.xrLabel13})
        Me.GroupHeader1.Dpi = 100.0F
        Me.GroupHeader1.HeightF = 23.0F
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        ' 
        ' xrLabel13
        ' 
        Me.xrLabel13.Dpi = 100.0F
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(320.8332F, 0F)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(100.0F, 23.0F)
        Me.xrLabel13.Text = "ProductID"
        ' 
        ' xrLabel14
        ' 
        Me.xrLabel14.Dpi = 100.0F
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(420.8333F, 0F)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(100.0F, 23.0F)
        Me.xrLabel14.Text = "Quantity"
        ' 
        ' xrLabel15
        ' 
        Me.xrLabel15.Dpi = 100.0F
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(520.8333F, 0F)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(123.1667F, 23.0F)
        Me.xrLabel15.Text = "UnitPrice"
        ' 
        ' OrdersReport
        ' 
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1, Me.reportHeaderBand1, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "Orders"
        Me.DataSource = Me.sqlDataSource1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "16.2"
        DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
End Class
