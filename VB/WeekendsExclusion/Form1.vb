Imports DevExpress.XtraCharts
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WeekendsExclusion
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
'			#Region "OriginalChart"
			Dim series0 As Series = chartControl0.Series(0)
			series0.ArgumentScaleType = ScaleType.DateTime
			series0.DataSource = CreateChartData()
			series0.SetFinancialDataMembers("Argument", "Low", "High", "Open", "Close")
'			#End Region

'			#Region "Chart1"
			Dim series1 As Series = chartControl1.Series(0)
			series1.ArgumentScaleType = ScaleType.DateTime
			series1.DataSource = CreateChartData()
			series1.SetFinancialDataMembers("Argument", "Low", "High", "Open", "Close")

			Dim dateTimeScaleOptions As DateTimeScaleOptions = CType(chartControl1.Diagram, XYDiagram).AxisX.DateTimeScaleOptions

			' Enables workday options.
			dateTimeScaleOptions.WorkdaysOnly = True

			' Specifies custom work days.
			' In this example, Sunday is a work day and Saturday is a day off.
			dateTimeScaleOptions.WorkdaysOptions.Workdays = Weekday.Sunday Or Weekday.Monday Or Weekday.Tuesday Or Weekday.Wednesday Or Weekday.Thursday Or Weekday.Friday

			' Specifies custom holidays.
			' In this example, March 8th (Monday) is an additional holiday.
			dateTimeScaleOptions.WorkdaysOptions.Holidays.Add(New KnownDate("Custom Holiday", New DateTime(2021, 3, 8, 0, 0, 0, 0)))

			' Specifies work days, which have priority over specified holidays.
			' In this example, March 6th (Saturday) is an additional work day.
			dateTimeScaleOptions.WorkdaysOptions.ExactWorkdays.Add(New KnownDate("Community Work Day", New DateTime(2021, 3, 6, 0, 0, 0, 0)))
'			#End Region

'			#Region "Chart2"
			Dim series2 As Series = chartControl2.Series(0)
			series2.ArgumentScaleType = ScaleType.DateTime
			series2.DataSource = CreateChartData()
			series2.SetFinancialDataMembers("Argument", "Low", "High", "Open", "Close")

			Dim dateTimeScaleOptions2 As DateTimeScaleOptions = CType(chartControl2.Diagram, XYDiagram).AxisX.DateTimeScaleOptions

			' Excludes all axis ranges without data points.
			' In this example, March 8th has no data points to display and is not displayed on the X-axis.
			dateTimeScaleOptions2.SkipRangesWithoutPoints = True
'			#End Region
		End Sub

		Private Function CreateChartData() As DataTable
			' Create an empty table.
			Dim table As New DataTable("Table1")

			' Add two columns to the table.
			table.Columns.Add("Argument", GetType(DateTime))
			table.Columns.Add("Low", GetType(Double))
			table.Columns.Add("High", GetType(Double))
			table.Columns.Add("Open", GetType(Double))
			table.Columns.Add("Close", GetType(Double))

			table.Rows.Add(New DateTime(2021, 3, 1), 24.00, 25.00, 25.00, 24.875)
			table.Rows.Add(New DateTime(2021, 3, 2), 23.625, 25.125, 24.00, 24.875)
			table.Rows.Add(New DateTime(2021, 3, 3), 26.25, 28.25, 26.75, 27.00)
			table.Rows.Add(New DateTime(2021, 3, 4), 26.50, 27.875, 26.875, 27.25)
			table.Rows.Add(New DateTime(2021, 3, 5), 25.75, 26.875, 26.75, 26.00)
			table.Rows.Add(New DateTime(2021, 3, 6), 26.375, 27.50, 27.375, 26.75)
			table.Rows.Add(New DateTime(2021, 3, 7), 25.25, 26.1, 25.725, 25.85)
			table.Rows.Add(New DateTime(2021, 3, 9), 25.75, 26.75, 26.125, 26.25)
			table.Rows.Add(New DateTime(2021, 3, 10), 25.75, 26.375, 26.375, 25.875)
			table.Rows.Add(New DateTime(2021, 3, 11), 24.875, 26.125, 26.00, 25.375)
			table.Rows.Add(New DateTime(2021, 3, 12), 25.125, 26.00, 25.625, 25.75)

			Return table
		End Function
	End Class
End Namespace
