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
    Friend WithEvents Title As XRControlStyle
    Friend WithEvents FieldCaption As XRControlStyle
    Friend WithEvents PageInfo As XRControlStyle
    Friend WithEvents DataField As XRControlStyle
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
        Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column19 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression19 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim MasterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersReport))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLabel5, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLine1})
        Me.Detail.HeightF = 104.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLabel1
        '
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 9.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
        Me.xrLabel1.StyleName = "FieldCaption"
        Me.xrLabel1.Text = "Shipped Date"
        '
        'xrLabel2
        '
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 33.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.Text = "Ship Address"
        '
        'xrLabel3
        '
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 57.0!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.Text = "Order ID"
        '
        'xrLabel4
        '
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 81.0!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
        Me.xrLabel4.StyleName = "FieldCaption"
        Me.xrLabel4.Text = "Order Date"
        '
        'xrLabel5
        '
        Me.xrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShippedDate]")})
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 9.0!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel5.StyleName = "DataField"
        Me.xrLabel5.Text = "xrLabel5"
        '
        'xrLabel6
        '
        Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShipAddress]")})
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 33.0!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel6.StyleName = "DataField"
        Me.xrLabel6.Text = "xrLabel6"
        '
        'xrLabel7
        '
        Me.xrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 57.0!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel7.StyleName = "DataField"
        Me.xrLabel7.Text = "xrLabel7"
        '
        'xrLabel8
        '
        Me.xrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderDate]")})
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 81.0!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel8.StyleName = "DataField"
        Me.xrLabel8.Text = "xrLabel8"
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 3.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'sqlDataSource1
        '
        Me.sqlDataSource1.ConnectionName = "nwind"
        Me.sqlDataSource1.Name = "sqlDataSource1"
        ColumnExpression1.ColumnName = "OrderID"
        Table1.Name = "Orders"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "CustomerID"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "EmployeeID"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "OrderDate"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "RequiredDate"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "ShippedDate"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        ColumnExpression7.ColumnName = "ShipVia"
        ColumnExpression7.Table = Table1
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "Freight"
        ColumnExpression8.Table = Table1
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "ShipName"
        ColumnExpression9.Table = Table1
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "ShipAddress"
        ColumnExpression10.Table = Table1
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "ShipCity"
        ColumnExpression11.Table = Table1
        Column11.Expression = ColumnExpression11
        ColumnExpression12.ColumnName = "ShipRegion"
        ColumnExpression12.Table = Table1
        Column12.Expression = ColumnExpression12
        ColumnExpression13.ColumnName = "ShipPostalCode"
        ColumnExpression13.Table = Table1
        Column13.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "ShipCountry"
        ColumnExpression14.Table = Table1
        Column14.Expression = ColumnExpression14
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.Columns.Add(Column7)
        SelectQuery1.Columns.Add(Column8)
        SelectQuery1.Columns.Add(Column9)
        SelectQuery1.Columns.Add(Column10)
        SelectQuery1.Columns.Add(Column11)
        SelectQuery1.Columns.Add(Column12)
        SelectQuery1.Columns.Add(Column13)
        SelectQuery1.Columns.Add(Column14)
        SelectQuery1.MetaSerializable = "<Meta X=""140"" Y=""20"" Width=""100"" Height=""275"" />"
        SelectQuery1.Name = "Orders"
        SelectQuery1.Tables.Add(Table1)
        ColumnExpression15.ColumnName = "OrderID"
        Table2.Name = "OrderDetails"
        ColumnExpression15.Table = Table2
        Column15.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "ProductID"
        ColumnExpression16.Table = Table2
        Column16.Expression = ColumnExpression16
        ColumnExpression17.ColumnName = "UnitPrice"
        ColumnExpression17.Table = Table2
        Column17.Expression = ColumnExpression17
        ColumnExpression18.ColumnName = "Quantity"
        ColumnExpression18.Table = Table2
        Column18.Expression = ColumnExpression18
        ColumnExpression19.ColumnName = "Discount"
        ColumnExpression19.Table = Table2
        Column19.Expression = ColumnExpression19
        SelectQuery2.Columns.Add(Column15)
        SelectQuery2.Columns.Add(Column16)
        SelectQuery2.Columns.Add(Column17)
        SelectQuery2.Columns.Add(Column18)
        SelectQuery2.Columns.Add(Column19)
        SelectQuery2.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""100"" Height=""122"" />"
        SelectQuery2.Name = "OrderDetails"
        SelectQuery2.Tables.Add(Table2)
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2})
        MasterDetailInfo1.DetailQueryName = "OrderDetails"
        RelationColumnInfo1.NestedKeyColumn = "OrderID"
        RelationColumnInfo1.ParentKeyColumn = "OrderID"
        MasterDetailInfo1.KeyColumns.Add(RelationColumnInfo1)
        MasterDetailInfo1.MasterQueryName = "Orders"
        Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {MasterDetailInfo1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.HeightF = 29.00001!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5.999999!, 6.00001!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(271.3333!, 23.0!)
        Me.xrPageInfo1.StyleName = "PageInfo"
        '
        'xrPageInfo2
        '
        Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
        Me.xrPageInfo2.Name = "xrPageInfo2"
        Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        Me.xrPageInfo2.StyleName = "PageInfo"
        Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrPageInfo2.TextFormatString = "Page {0} of {1}"
        '
        'reportHeaderBand1
        '
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel9})
        Me.reportHeaderBand1.HeightF = 51.0!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel9
        '
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrLabel9.Multiline = True
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
        Me.xrLabel9.StyleName = "Title"
        Me.xrLabel9.Text = "Orders Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1.0!
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
        Me.FieldCaption.BorderColor = System.Drawing.Color.Black
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.FieldCaption.BorderWidth = 1.0!
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.PageInfo.BorderColor = System.Drawing.Color.Black
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1.0!
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.Black
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.Transparent
        Me.DataField.BorderColor = System.Drawing.Color.Black
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1.0!
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.Color.Black
        Me.DataField.Name = "DataField"
        Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1})
        Me.DetailReport.DataMember = "Orders.OrdersOrderDetails"
        Me.DetailReport.DataSource = Me.sqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel12, Me.xrLabel11, Me.xrLabel10})
        Me.Detail1.HeightF = 23.0!
        Me.Detail1.KeepTogether = True
        Me.Detail1.MultiColumn.ColumnCount = 2
        Me.Detail1.Name = "Detail1"
        '
        'xrLabel12
        '
        Me.xrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(520.8333!, 0!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(123.1667!, 23.0!)
        Me.xrLabel12.Text = "xrLabel12"
        '
        'xrLabel11
        '
        Me.xrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(420.8333!, 0!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel11.Text = "xrLabel11"
        '
        'xrLabel10
        '
        Me.xrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductID]")})
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(320.8333!, 0!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel10.Text = "xrLabel10"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel15, Me.xrLabel14, Me.xrLabel13})
        Me.GroupHeader1.HeightF = 23.0!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'xrLabel15
        '
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(520.8333!, 0!)
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(123.1667!, 23.0!)
        Me.xrLabel15.Text = "UnitPrice"
        '
        'xrLabel14
        '
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(420.8333!, 0!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel14.Text = "Quantity"
        '
        'xrLabel13
        '
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(320.8332!, 0!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel13.Text = "ProductID"
        '
        'OrdersReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1, Me.reportHeaderBand1, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "Orders"
        Me.DataSource = Me.sqlDataSource1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
End Class
