Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for CategoriesReport
''' </summary>
Public Class CategoriesReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private xrLabel1 As XRLabel
    Private xrLabel2 As XRLabel
    Private xrLabel3 As XRLabel
    Private xrLabel6 As XRLabel
    Private xrLabel7 As XRLabel
    Private xrLabel8 As XRLabel
    Private xrLabel9 As XRLabel
    Private xrPictureBox3 As XRPictureBox
    Private xrLine1 As XRLine
    Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Private pageFooterBand1 As PageFooterBand
    Private xrPageInfo1 As XRPageInfo
    Private xrPageInfo2 As XRPageInfo
    Private reportHeaderBand1 As ReportHeaderBand
    Private xrLabel10 As XRLabel
    Friend WithEvents Title As XRControlStyle
    Friend WithEvents FieldCaption As XRControlStyle
    Friend WithEvents PageInfo As XRControlStyle
    Friend WithEvents DataField As XRControlStyle
    Private DetailReport As DetailReportBand
    Private Detail1 As DetailBand
    Private xrLabel12 As XRLabel
    Private xrCheckBox1 As XRCheckBox
    Private xrLabel11 As XRLabel
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
        Dim SelectQuery2 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
        Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Table2 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
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
        Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
        Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
        Dim MasterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriesReport))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLabel9, Me.xrPictureBox3, Me.xrLine1})
        Me.Detail.HeightF = 106.7917!
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
        Me.xrLabel1.Text = "Category ID"
        '
        'xrLabel2
        '
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 33.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
        Me.xrLabel2.StyleName = "FieldCaption"
        Me.xrLabel2.Text = "Category Name"
        '
        'xrLabel3
        '
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 57.0!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
        Me.xrLabel3.StyleName = "FieldCaption"
        Me.xrLabel3.Text = "Description"
        '
        'xrLabel6
        '
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 80.0!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(162.0!, 23.0!)
        Me.xrLabel6.StyleName = "FieldCaption"
        Me.xrLabel6.Text = "Picture"
        '
        'xrLabel7
        '
        Me.xrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryID]")})
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 9.0!)
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel7.StyleName = "DataField"
        Me.xrLabel7.Text = "xrLabel7"
        '
        'xrLabel8
        '
        Me.xrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")})
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 33.0!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel8.StyleName = "DataField"
        Me.xrLabel8.Text = "xrLabel8"
        '
        'xrLabel9
        '
        Me.xrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")})
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 57.0!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(470.0!, 18.0!)
        Me.xrLabel9.StyleName = "DataField"
        Me.xrLabel9.Text = "xrLabel9"
        '
        'xrPictureBox3
        '
        Me.xrPictureBox3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")})
        Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(174.0!, 80.0!)
        Me.xrPictureBox3.Name = "xrPictureBox3"
        Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(470.0!, 23.0!)
        Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me.xrPictureBox3.StyleName = "DataField"
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
        ColumnExpression1.ColumnName = "CategoryID"
        Table1.Name = "Categories"
        ColumnExpression1.Table = Table1
        Column1.Expression = ColumnExpression1
        ColumnExpression2.ColumnName = "CategoryName"
        ColumnExpression2.Table = Table1
        Column2.Expression = ColumnExpression2
        ColumnExpression3.ColumnName = "Description"
        ColumnExpression3.Table = Table1
        Column3.Expression = ColumnExpression3
        ColumnExpression4.ColumnName = "Picture"
        ColumnExpression4.Table = Table1
        Column4.Expression = ColumnExpression4
        ColumnExpression5.ColumnName = "Icon17"
        ColumnExpression5.Table = Table1
        Column5.Expression = ColumnExpression5
        ColumnExpression6.ColumnName = "Icon25"
        ColumnExpression6.Table = Table1
        Column6.Expression = ColumnExpression6
        SelectQuery1.Columns.Add(Column1)
        SelectQuery1.Columns.Add(Column2)
        SelectQuery1.Columns.Add(Column3)
        SelectQuery1.Columns.Add(Column4)
        SelectQuery1.Columns.Add(Column5)
        SelectQuery1.Columns.Add(Column6)
        SelectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""100"" Height=""139"" />"
        SelectQuery1.Name = "Categories"
        SelectQuery1.Tables.Add(Table1)
        ColumnExpression7.ColumnName = "ProductID"
        Table2.Name = "Products"
        ColumnExpression7.Table = Table2
        Column7.Expression = ColumnExpression7
        ColumnExpression8.ColumnName = "ProductName"
        ColumnExpression8.Table = Table2
        Column8.Expression = ColumnExpression8
        ColumnExpression9.ColumnName = "SupplierID"
        ColumnExpression9.Table = Table2
        Column9.Expression = ColumnExpression9
        ColumnExpression10.ColumnName = "CategoryID"
        ColumnExpression10.Table = Table2
        Column10.Expression = ColumnExpression10
        ColumnExpression11.ColumnName = "QuantityPerUnit"
        ColumnExpression11.Table = Table2
        Column11.Expression = ColumnExpression11
        ColumnExpression12.ColumnName = "UnitPrice"
        ColumnExpression12.Table = Table2
        Column12.Expression = ColumnExpression12
        ColumnExpression13.ColumnName = "UnitsInStock"
        ColumnExpression13.Table = Table2
        Column13.Expression = ColumnExpression13
        ColumnExpression14.ColumnName = "UnitsOnOrder"
        ColumnExpression14.Table = Table2
        Column14.Expression = ColumnExpression14
        ColumnExpression15.ColumnName = "ReorderLevel"
        ColumnExpression15.Table = Table2
        Column15.Expression = ColumnExpression15
        ColumnExpression16.ColumnName = "Discontinued"
        ColumnExpression16.Table = Table2
        Column16.Expression = ColumnExpression16
        ColumnExpression17.ColumnName = "EAN13"
        ColumnExpression17.Table = Table2
        Column17.Expression = ColumnExpression17
        SelectQuery2.Columns.Add(Column7)
        SelectQuery2.Columns.Add(Column8)
        SelectQuery2.Columns.Add(Column9)
        SelectQuery2.Columns.Add(Column10)
        SelectQuery2.Columns.Add(Column11)
        SelectQuery2.Columns.Add(Column12)
        SelectQuery2.Columns.Add(Column13)
        SelectQuery2.Columns.Add(Column14)
        SelectQuery2.Columns.Add(Column15)
        SelectQuery2.Columns.Add(Column16)
        SelectQuery2.Columns.Add(Column17)
        SelectQuery2.MetaSerializable = "<Meta X=""140"" Y=""20"" Width=""100"" Height=""224"" />"
        SelectQuery2.Name = "Products"
        SelectQuery2.Tables.Add(Table2)
        Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1, SelectQuery2})
        MasterDetailInfo1.DetailQueryName = "Products"
        RelationColumnInfo1.NestedKeyColumn = "CategoryID"
        RelationColumnInfo1.ParentKeyColumn = "CategoryID"
        MasterDetailInfo1.KeyColumns.Add(RelationColumnInfo1)
        MasterDetailInfo1.MasterQueryName = "Categories"
        Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {MasterDetailInfo1})
        Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
        '
        'pageFooterBand1
        '
        Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1, Me.xrPageInfo2})
        Me.pageFooterBand1.HeightF = 29.0!
        Me.pageFooterBand1.Name = "pageFooterBand1"
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
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
        Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel10})
        Me.reportHeaderBand1.HeightF = 51.0!
        Me.reportHeaderBand1.Name = "reportHeaderBand1"
        '
        'xrLabel10
        '
        Me.xrLabel10.ForeColor = System.Drawing.Color.Crimson
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
        Me.xrLabel10.Multiline = True
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
        Me.xrLabel10.StyleName = "Title"
        Me.xrLabel10.StylePriority.UseForeColor = False
        Me.xrLabel10.Text = "Categories Report" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.DetailReport.DataMember = "Categories.CategoriesProducts"
        Me.DetailReport.DataSource = Me.sqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel12, Me.xrCheckBox1, Me.xrLabel11})
        Me.Detail1.HeightF = 23.0!
        Me.Detail1.Name = "Detail1"
        '
        'xrLabel12
        '
        Me.xrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 0!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel12.Text = "xrLabel12"
        '
        'xrCheckBox1
        '
        Me.xrCheckBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckState", "[Discontinued]")})
        Me.xrCheckBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(320.8333!, 0!)
        Me.xrCheckBox1.Name = "xrCheckBox1"
        Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        '
        'xrLabel11
        '
        Me.xrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(195.8333!, 23.0!)
        Me.xrLabel11.Text = "xrLabel11"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel15, Me.xrLabel14, Me.xrLabel13})
        Me.GroupHeader1.HeightF = 23.95833!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrLabel15
        '
        Me.xrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 0!)
        Me.xrLabel15.Multiline = True
        Me.xrLabel15.Name = "xrLabel15"
        Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel15.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel15.StylePriority.UseFont = False
        Me.xrLabel15.Text = "UnitPrice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'xrLabel14
        '
        Me.xrLabel14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(320.8333!, 0!)
        Me.xrLabel14.Multiline = True
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrLabel14.StylePriority.UseFont = False
        Me.xrLabel14.Text = "Discontinued" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'xrLabel13
        '
        Me.xrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(195.8333!, 23.0!)
        Me.xrLabel13.StylePriority.UseFont = False
        Me.xrLabel13.Text = "ProductName"
        '
        'CategoriesReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1, Me.reportHeaderBand1, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
        Me.DataMember = "Categories"
        Me.DataSource = Me.sqlDataSource1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "18.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
End Class
