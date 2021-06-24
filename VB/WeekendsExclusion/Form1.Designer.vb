Imports Microsoft.VisualBasic
Imports System
Namespace WeekendsExclusion
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Dim xyDiagram3 As New DevExpress.XtraCharts.XYDiagram()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesView5 As New DevExpress.XtraCharts.StockSeriesView()
			Dim stockSeriesView6 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle3 As New DevExpress.XtraCharts.ChartTitle()
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim stockSeriesView3 As New DevExpress.XtraCharts.StockSeriesView()
			Dim stockSeriesView4 As New DevExpress.XtraCharts.StockSeriesView()
			Dim chartTitle2 As New DevExpress.XtraCharts.ChartTitle()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.chartControl2 = New DevExpress.XtraCharts.ChartControl()
			Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.chartControl0 = New DevExpress.XtraCharts.ChartControl()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.chartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl0, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.AutoLayout = False
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Label.Angle = -35
			xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.Visible = False
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl1.Location = New System.Drawing.Point(12, 255)
			Me.chartControl1.Name = "chartControl1"
			series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series1.Name = "Series 1"
			series1.View = stockSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.SeriesTemplate.View = stockSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(941, 256)
			Me.chartControl1.TabIndex = 0
			chartTitle1.Text = "Chart with WorkdaysOptions"
			Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.chartControl0)
			Me.layoutControl1.Controls.Add(Me.chartControl2)
			Me.layoutControl1.Controls.Add(Me.chartControl1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(604, 156, 650, 400)
			Me.layoutControl1.Root = Me.Root
			Me.layoutControl1.Size = New System.Drawing.Size(965, 749)
			Me.layoutControl1.TabIndex = 1
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' chartControl2
			' 
			Me.chartControl2.AutoLayout = False
			xyDiagram3.AxisX.GridLines.Visible = True
			xyDiagram3.AxisX.Label.Angle = -35
			xyDiagram3.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			xyDiagram3.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram3.AxisY.GridLines.Visible = False
			xyDiagram3.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram3.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chartControl2.Diagram = xyDiagram3
			Me.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl2.Location = New System.Drawing.Point(12, 515)
			Me.chartControl2.Name = "chartControl2"
			series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series3.Name = "Series 1"
			series3.View = stockSeriesView5
			Me.chartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3}
			Me.chartControl2.SeriesTemplate.View = stockSeriesView6
			Me.chartControl2.Size = New System.Drawing.Size(941, 221)
			Me.chartControl2.TabIndex = 4
			chartTitle3.Text = "Chart with SkipRangesWithoutPoints"
			Me.chartControl2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle3})
			' 
			' Root
			' 
			Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.Root.GroupBordersVisible = False
			Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleSeparator1, Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
			Me.Root.Name = "Root"
			Me.Root.Size = New System.Drawing.Size(965, 749)
			Me.Root.TextVisible = False
			' 
			' simpleSeparator1
			' 
			Me.simpleSeparator1.AllowHotTrack = False
			Me.simpleSeparator1.Location = New System.Drawing.Point(0, 728)
			Me.simpleSeparator1.Name = "simpleSeparator1"
			Me.simpleSeparator1.Size = New System.Drawing.Size(945, 1)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.chartControl1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 243)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(945, 260)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.chartControl2
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 503)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(945, 225)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' chartControl0
			' 
			Me.chartControl0.AutoLayout = False
			xyDiagram2.AxisX.GridLines.Visible = True
			xyDiagram2.AxisX.Label.Angle = -35
			xyDiagram2.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.GridLines.Visible = False
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
			Me.chartControl0.Diagram = xyDiagram2
			Me.chartControl0.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.chartControl0.Location = New System.Drawing.Point(12, 12)
			Me.chartControl0.Name = "chartControl0"
			series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
			series2.Name = "Series 1"
			series2.View = stockSeriesView3
			Me.chartControl0.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			Me.chartControl0.SeriesTemplate.View = stockSeriesView4
			Me.chartControl0.Size = New System.Drawing.Size(941, 239)
			Me.chartControl0.TabIndex = 5
			chartTitle2.Text = "Original Chart"
			Me.chartControl0.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle2})
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.chartControl0
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(945, 243)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(965, 749)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(xyDiagram3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl0, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private chartControl2 As DevExpress.XtraCharts.ChartControl
		Private Root As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private chartControl0 As DevExpress.XtraCharts.ChartControl
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

