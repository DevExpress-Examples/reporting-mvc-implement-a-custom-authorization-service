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
    Private Title As XRControlStyle
    Private FieldCaption As XRControlStyle
    Private PageInfo As XRControlStyle
    Private DataField As XRControlStyle
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
            Dim selectQuery2 As New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column7 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table2 As New DevExpress.DataAccess.Sql.Table()
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
            Dim column15 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression15 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column16 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression16 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column17 As New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression17 As New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CategoriesReport))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox3 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
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
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrLabel2, Me.xrLabel3, Me.xrLabel6, Me.xrLabel7, Me.xrLabel8, Me.xrLabel9, Me.xrPictureBox3, Me.xrLine1})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 106.7917F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CategoryID"
            table1.Name = "Categories"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CategoryName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "Description"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "Picture"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Icon17"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "Icon25"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.MetaSerializable = "20|20|100|139"
            selectQuery1.Name = "Categories"
            selectQuery1.Tables.Add(table1)
            columnExpression7.ColumnName = "ProductID"
            table2.Name = "Products"
            columnExpression7.Table = table2
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "ProductName"
            columnExpression8.Table = table2
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "SupplierID"
            columnExpression9.Table = table2
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "CategoryID"
            columnExpression10.Table = table2
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "QuantityPerUnit"
            columnExpression11.Table = table2
            column11.Expression = columnExpression11
            columnExpression12.ColumnName = "UnitPrice"
            columnExpression12.Table = table2
            column12.Expression = columnExpression12
            columnExpression13.ColumnName = "UnitsInStock"
            columnExpression13.Table = table2
            column13.Expression = columnExpression13
            columnExpression14.ColumnName = "UnitsOnOrder"
            columnExpression14.Table = table2
            column14.Expression = columnExpression14
            columnExpression15.ColumnName = "ReorderLevel"
            columnExpression15.Table = table2
            column15.Expression = columnExpression15
            columnExpression16.ColumnName = "Discontinued"
            columnExpression16.Table = table2
            column16.Expression = columnExpression16
            columnExpression17.ColumnName = "EAN13"
            columnExpression17.Table = table2
            column17.Expression = columnExpression17
            selectQuery2.Columns.Add(column7)
            selectQuery2.Columns.Add(column8)
            selectQuery2.Columns.Add(column9)
            selectQuery2.Columns.Add(column10)
            selectQuery2.Columns.Add(column11)
            selectQuery2.Columns.Add(column12)
            selectQuery2.Columns.Add(column13)
            selectQuery2.Columns.Add(column14)
            selectQuery2.Columns.Add(column15)
            selectQuery2.Columns.Add(column16)
            selectQuery2.Columns.Add(column17)
            selectQuery2.MetaSerializable = "140|20|100|224"
            selectQuery2.Name = "Products"
            selectQuery2.Tables.Add(table2)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1, selectQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "Categories"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Dpi = 100F
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 9F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel1.StyleName = "FieldCaption"
            Me.xrLabel1.Text = "Category ID"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Dpi = 100F
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(6F, 33F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel2.StyleName = "FieldCaption"
            Me.xrLabel2.Text = "Category Name"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Dpi = 100F
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(6F, 57F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(162F, 18F)
            Me.xrLabel3.StyleName = "FieldCaption"
            Me.xrLabel3.Text = "Description"
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.Dpi = 100F
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(6F, 80F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(162F, 23F)
            Me.xrLabel6.StyleName = "FieldCaption"
            Me.xrLabel6.Text = "Picture"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryID")})
            Me.xrLabel7.Dpi = 100F
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(174F, 9F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel7.StyleName = "DataField"
            Me.xrLabel7.Text = "xrLabel7"
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel8.Dpi = 100F
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(174F, 33F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel8.StyleName = "DataField"
            Me.xrLabel8.Text = "xrLabel8"
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel9.Dpi = 100F
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(174F, 57F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(470F, 18F)
            Me.xrLabel9.StyleName = "DataField"
            Me.xrLabel9.Text = "xrLabel9"
            ' 
            ' xrPictureBox3
            ' 
            Me.xrPictureBox3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox3.Dpi = 100F
            Me.xrPictureBox3.LocationFloat = New DevExpress.Utils.PointFloat(174F, 80F)
            Me.xrPictureBox3.Name = "xrPictureBox3"
            Me.xrPictureBox3.SizeF = New System.Drawing.SizeF(470F, 23F)
            Me.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            Me.xrPictureBox3.StyleName = "DataField"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.Dpi = 100F
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 3F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(638F, 2F)
            ' 
            ' pageFooterBand1
            ' 
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.Dpi = 100F
            Me.pageFooterBand1.HeightF = 29F
            Me.pageFooterBand1.Name = "pageFooterBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Dpi = 100F
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Dpi = 100F
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel10})
            Me.reportHeaderBand1.Dpi = 100F
            Me.reportHeaderBand1.HeightF = 51F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel10
            ' 
            Me.xrLabel10.Dpi = 100F
            Me.xrLabel10.ForeColor = System.Drawing.Color.Crimson
            Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
            Me.xrLabel10.Multiline = True
            Me.xrLabel10.Name = "xrLabel10"
            Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel10.SizeF = New System.Drawing.SizeF(638F, 33F)
            Me.xrLabel10.StyleName = "Title"
            Me.xrLabel10.StylePriority.UseForeColor = False
            Me.xrLabel10.Text = "Categories Report" & ControlChars.CrLf
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
            Me.DetailReport.DataMember = "Categories.CategoriesProducts"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.Dpi = 100F
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel12, Me.xrCheckBox1, Me.xrLabel11})
            Me.Detail1.Dpi = 100F
            Me.Detail1.HeightF = 23F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
            Me.xrLabel11.Dpi = 100F
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(195.8333F, 23F)
            Me.xrLabel11.Text = "xrLabel11"
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("CheckState", Nothing, "Categories.CategoriesProducts.Discontinued")})
            Me.xrCheckBox1.Dpi = 100F
            Me.xrCheckBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(320.8333F, 0F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(100F, 23F)
            ' 
            ' xrLabel12
            ' 
            Me.xrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice")})
            Me.xrLabel12.Dpi = 100F
            Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
            Me.xrLabel12.Name = "xrLabel12"
            Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel12.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel12.Text = "xrLabel12"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel15, Me.xrLabel14, Me.xrLabel13})
            Me.GroupHeader1.Dpi = 100F
            Me.GroupHeader1.HeightF = 23.95833F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrLabel13
            ' 
            Me.xrLabel13.Dpi = 100F
            Me.xrLabel13.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel13.Name = "xrLabel13"
            Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel13.SizeF = New System.Drawing.SizeF(195.8333F, 23F)
            Me.xrLabel13.StylePriority.UseFont = False
            Me.xrLabel13.Text = "ProductName"
            ' 
            ' xrLabel14
            ' 
            Me.xrLabel14.Dpi = 100F
            Me.xrLabel14.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(320.8333F, 0F)
            Me.xrLabel14.Multiline = True
            Me.xrLabel14.Name = "xrLabel14"
            Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel14.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel14.StylePriority.UseFont = False
            Me.xrLabel14.Text = "Discontinued" & ControlChars.CrLf
            ' 
            ' xrLabel15
            ' 
            Me.xrLabel15.Dpi = 100F
            Me.xrLabel15.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(550F, 0F)
            Me.xrLabel15.Multiline = True
            Me.xrLabel15.Name = "xrLabel15"
            Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel15.SizeF = New System.Drawing.SizeF(100F, 23F)
            Me.xrLabel15.StylePriority.UseFont = False
            Me.xrLabel15.Text = "UnitPrice" & ControlChars.CrLf
            ' 
            ' CategoriesReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageFooterBand1, Me.reportHeaderBand1, Me.DetailReport})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "16.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
