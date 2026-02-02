Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for OrdersReport
''' </summary>
Public Class OrdersReport
    Inherits XtraReport

    Private Detail As DetailBand

    Private TopMargin As TopMarginBand

    Private BottomMargin As BottomMarginBand

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
        If disposing AndAlso components IsNot Nothing Then
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
        components = New System.ComponentModel.Container()
        Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim selectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim columnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim masterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
        Detail = New DetailBand()
        TopMargin = New TopMarginBand()
        BottomMargin = New BottomMarginBand()
        sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(components)
        xrLabel1 = New XRLabel()
        xrLabel2 = New XRLabel()
        xrLabel4 = New XRLabel()
        xrLabel5 = New XRLabel()
        xrLabel6 = New XRLabel()
        xrLabel8 = New XRLabel()
        xrLine1 = New XRLine()
        pageFooterBand1 = New PageFooterBand()
        xrPageInfo1 = New XRPageInfo()
        xrPageInfo2 = New XRPageInfo()
        reportHeaderBand1 = New ReportHeaderBand()
        xrLabel9 = New XRLabel()
        Title = New XRControlStyle()
        FieldCaption = New XRControlStyle()
        PageInfo = New XRControlStyle()
        DataField = New XRControlStyle()
        xrLabel3 = New XRLabel()
        xrLabel7 = New XRLabel()
        DetailReport = New DetailReportBand()
        Detail1 = New DetailBand()
        xrLabel10 = New XRLabel()
        xrLabel11 = New XRLabel()
        xrLabel12 = New XRLabel()
        GroupHeader1 = New GroupHeaderBand()
        xrLabel13 = New XRLabel()
        xrLabel14 = New XRLabel()
        xrLabel15 = New XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Detail.Controls.AddRange(New XRControl() {xrLabel1, xrLabel2, xrLabel3, xrLabel4, xrLabel5, xrLabel6, xrLabel7, xrLabel8, xrLine1})
        Detail.Dpi = 100F
        Detail.HeightF = 104F
        Detail.Name = "Detail"
        Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' TopMargin
        ' 
        TopMargin.Dpi = 100F
        TopMargin.HeightF = 100F
        TopMargin.Name = "TopMargin"
        TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' BottomMargin
        ' 
        BottomMargin.Dpi = 100F
        BottomMargin.HeightF = 100F
        BottomMargin.Name = "BottomMargin"
        BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' sqlDataSource1
        ' 
        sqlDataSource1.ConnectionName = "nwind"
        sqlDataSource1.Name = "sqlDataSource1"
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
        sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1, selectQuery2})
        masterDetailInfo1.DetailQueryName = "OrderDetails"
        relationColumnInfo1.NestedKeyColumn = "OrderID"
        relationColumnInfo1.ParentKeyColumn = "OrderID"
        masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
        masterDetailInfo1.MasterQueryName = "Orders"
        sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {masterDetailInfo1})
        sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        ' 
        ' xrLabel1
        ' 
        xrLabel1.Dpi = 100F
        xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 9F)
        xrLabel1.Name = "xrLabel1"
        xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel1.SizeF = New System.Drawing.SizeF(162F, 18F)
        xrLabel1.StyleName = "FieldCaption"
        xrLabel1.Text = "Shipped Date"
        ' 
        ' xrLabel2
        ' 
        xrLabel2.Dpi = 100F
        xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6F, 33F)
        xrLabel2.Name = "xrLabel2"
        xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel2.SizeF = New System.Drawing.SizeF(162F, 18F)
        xrLabel2.StyleName = "FieldCaption"
        xrLabel2.Text = "Ship Address"
        ' 
        ' xrLabel4
        ' 
        xrLabel4.Dpi = 100F
        xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(6F, 81F)
        xrLabel4.Name = "xrLabel4"
        xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel4.SizeF = New System.Drawing.SizeF(162F, 18F)
        xrLabel4.StyleName = "FieldCaption"
        xrLabel4.Text = "Order Date"
        ' 
        ' xrLabel5
        ' 
        xrLabel5.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.ShippedDate")})
        xrLabel5.Dpi = 100F
        xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(174F, 9F)
        xrLabel5.Name = "xrLabel5"
        xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel5.SizeF = New System.Drawing.SizeF(470F, 18F)
        xrLabel5.StyleName = "DataField"
        xrLabel5.Text = "xrLabel5"
        ' 
        ' xrLabel6
        ' 
        xrLabel6.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.ShipAddress")})
        xrLabel6.Dpi = 100F
        xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(174F, 33F)
        xrLabel6.Name = "xrLabel6"
        xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel6.SizeF = New System.Drawing.SizeF(470F, 18F)
        xrLabel6.StyleName = "DataField"
        xrLabel6.Text = "xrLabel6"
        ' 
        ' xrLabel8
        ' 
        xrLabel8.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.OrderDate")})
        xrLabel8.Dpi = 100F
        xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(174F, 81F)
        xrLabel8.Name = "xrLabel8"
        xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel8.SizeF = New System.Drawing.SizeF(470F, 18F)
        xrLabel8.StyleName = "DataField"
        xrLabel8.Text = "xrLabel8"
        ' 
        ' xrLine1
        ' 
        xrLine1.Dpi = 100F
        xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 3F)
        xrLine1.Name = "xrLine1"
        xrLine1.SizeF = New System.Drawing.SizeF(638F, 2F)
        ' 
        ' pageFooterBand1
        ' 
        pageFooterBand1.Controls.AddRange(New XRControl() {xrPageInfo1, xrPageInfo2})
        pageFooterBand1.Dpi = 100F
        pageFooterBand1.HeightF = 29.00001F
        pageFooterBand1.Name = "pageFooterBand1"
        ' 
        ' xrPageInfo1
        ' 
        xrPageInfo1.Dpi = 100F
        xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.999999F, 6.00001F)
        xrPageInfo1.Name = "xrPageInfo1"
        xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        xrPageInfo1.SizeF = New System.Drawing.SizeF(271.3333F, 23F)
        xrPageInfo1.StyleName = "PageInfo"
        ' 
        ' xrPageInfo2
        ' 
        xrPageInfo2.Dpi = 100F
        xrPageInfo2.Format = "Page {0} of {1}"
        xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
        xrPageInfo2.Name = "xrPageInfo2"
        xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
        xrPageInfo2.StyleName = "PageInfo"
        xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        ' 
        ' reportHeaderBand1
        ' 
        reportHeaderBand1.Controls.AddRange(New XRControl() {xrLabel9})
        reportHeaderBand1.Dpi = 100F
        reportHeaderBand1.HeightF = 51F
        reportHeaderBand1.Name = "reportHeaderBand1"
        ' 
        ' xrLabel9
        ' 
        xrLabel9.Dpi = 100F
        xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
        xrLabel9.Multiline = True
        xrLabel9.Name = "xrLabel9"
        xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel9.SizeF = New System.Drawing.SizeF(638F, 33F)
        xrLabel9.StyleName = "Title"
        xrLabel9.Text = "Orders Report" & Microsoft.VisualBasic.Constants.vbCrLf
        ' 
        ' Title
        ' 
        Title.BackColor = System.Drawing.Color.Transparent
        Title.BorderColor = System.Drawing.Color.Black
        Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Title.BorderWidth = 1F
        Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
        Title.ForeColor = System.Drawing.Color.Maroon
        Title.Name = "Title"
        ' 
        ' FieldCaption
        ' 
        FieldCaption.BackColor = System.Drawing.Color.Transparent
        FieldCaption.BorderColor = System.Drawing.Color.Black
        FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        FieldCaption.BorderWidth = 1F
        FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
        FieldCaption.ForeColor = System.Drawing.Color.Maroon
        FieldCaption.Name = "FieldCaption"
        ' 
        ' PageInfo
        ' 
        PageInfo.BackColor = System.Drawing.Color.Transparent
        PageInfo.BorderColor = System.Drawing.Color.Black
        PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        PageInfo.BorderWidth = 1F
        PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
        PageInfo.ForeColor = System.Drawing.Color.Black
        PageInfo.Name = "PageInfo"
        ' 
        ' DataField
        ' 
        DataField.BackColor = System.Drawing.Color.Transparent
        DataField.BorderColor = System.Drawing.Color.Black
        DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        DataField.BorderWidth = 1F
        DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
        DataField.ForeColor = System.Drawing.Color.Black
        DataField.Name = "DataField"
        DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        ' 
        ' xrLabel3
        ' 
        xrLabel3.Dpi = 100F
        xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6F, 57F)
        xrLabel3.Name = "xrLabel3"
        xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel3.SizeF = New System.Drawing.SizeF(162F, 18F)
        xrLabel3.StyleName = "FieldCaption"
        xrLabel3.Text = "Order ID"
        ' 
        ' xrLabel7
        ' 
        xrLabel7.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.OrderID")})
        xrLabel7.Dpi = 100F
        xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174F, 57F)
        xrLabel7.Name = "xrLabel7"
        xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel7.SizeF = New System.Drawing.SizeF(470F, 18F)
        xrLabel7.StyleName = "DataField"
        xrLabel7.Text = "xrLabel7"
        ' 
        ' DetailReport
        ' 
        DetailReport.Bands.AddRange(New Band() {Detail1, GroupHeader1})
        DetailReport.DataMember = "Orders.OrdersOrderDetails"
        DetailReport.DataSource = sqlDataSource1
        DetailReport.Dpi = 100F
        DetailReport.Level = 0
        DetailReport.Name = "DetailReport"
        ' 
        ' Detail1
        ' 
        Detail1.Controls.AddRange(New XRControl() {xrLabel12, xrLabel11, xrLabel10})
        Detail1.Dpi = 100F
        Detail1.HeightF = 23F
        Detail1.KeepTogether = True
        Detail1.MultiColumn.ColumnCount = 2
        Detail1.Name = "Detail1"
        ' 
        ' xrLabel10
        ' 
        xrLabel10.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.ProductID")})
        xrLabel10.Dpi = 100F
        xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(320.8333F, 0F)
        xrLabel10.Name = "xrLabel10"
        xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
        xrLabel10.SizeF = New System.Drawing.SizeF(100F, 23F)
        xrLabel10.Text = "xrLabel10"
        ' 
        ' xrLabel11
        ' 
        xrLabel11.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.Quantity")})
        xrLabel11.Dpi = 100F
        xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(420.8333F, 0F)
        xrLabel11.Name = "xrLabel11"
        xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
        xrLabel11.SizeF = New System.Drawing.SizeF(100F, 23F)
        xrLabel11.Text = "xrLabel11"
        ' 
        ' xrLabel12
        ' 
        xrLabel12.DataBindings.AddRange(New XRBinding() {New XRBinding("Text", Nothing, "Orders.OrdersOrderDetails.UnitPrice")})
        xrLabel12.Dpi = 100F
        xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(520.8333F, 0F)
        xrLabel12.Name = "xrLabel12"
        xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
        xrLabel12.SizeF = New System.Drawing.SizeF(123.1667F, 23F)
        xrLabel12.Text = "xrLabel12"
        ' 
        ' GroupHeader1
        ' 
        GroupHeader1.Controls.AddRange(New XRControl() {xrLabel15, xrLabel14, xrLabel13})
        GroupHeader1.Dpi = 100F
        GroupHeader1.HeightF = 23F
        GroupHeader1.KeepTogether = True
        GroupHeader1.Name = "GroupHeader1"
        GroupHeader1.RepeatEveryPage = True
        ' 
        ' xrLabel13
        ' 
        xrLabel13.Dpi = 100F
        xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(320.8332F, 0F)
        xrLabel13.Name = "xrLabel13"
        xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel13.SizeF = New System.Drawing.SizeF(100F, 23F)
        xrLabel13.Text = "ProductID"
        ' 
        ' xrLabel14
        ' 
        xrLabel14.Dpi = 100F
        xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(420.8333F, 0F)
        xrLabel14.Name = "xrLabel14"
        xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel14.SizeF = New System.Drawing.SizeF(100F, 23F)
        xrLabel14.Text = "Quantity"
        ' 
        ' xrLabel15
        ' 
        xrLabel15.Dpi = 100F
        xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(520.8333F, 0F)
        xrLabel15.Name = "xrLabel15"
        xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        xrLabel15.SizeF = New System.Drawing.SizeF(123.1667F, 23F)
        xrLabel15.Text = "UnitPrice"
        ' 
        ' OrdersReport
        ' 
        Bands.AddRange(New Band() {Detail, TopMargin, BottomMargin, pageFooterBand1, reportHeaderBand1, DetailReport})
        ComponentStorage.AddRange(New System.ComponentModel.IComponent() {sqlDataSource1})
        DataMember = "Orders"
        DataSource = sqlDataSource1
        StyleSheet.AddRange(New XRControlStyle() {Title, FieldCaption, PageInfo, DataField})
        Version = "16.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
#End Region
End Class
