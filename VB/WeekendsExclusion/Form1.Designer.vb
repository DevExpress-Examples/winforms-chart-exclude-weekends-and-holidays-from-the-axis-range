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
			Dim stockSeriesLabel1 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
			Dim stockSeriesLabel2 As New DevExpress.XtraCharts.StockSeriesLabel()
			Dim stockSeriesView2 As New DevExpress.XtraCharts.StockSeriesView()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Label.Angle = -35
			xyDiagram1.AxisX.Label.Antialiasing = True
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.Visible = False
			xyDiagram1.AxisY.Range.AlwaysShowZeroLevel = False
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			stockSeriesLabel1.Visible = False
			series1.Label = stockSeriesLabel1
			series1.Name = "Series 1"
			series1.View = stockSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			stockSeriesLabel2.Visible = True
			Me.chartControl1.SeriesTemplate.Label = stockSeriesLabel2
			Me.chartControl1.SeriesTemplate.View = stockSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(426, 213)
			Me.chartControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(426, 213)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(stockSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

