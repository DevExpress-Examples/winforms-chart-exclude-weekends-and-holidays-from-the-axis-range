Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...
#End Region ' #usings

Namespace WeekendsExclusion
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim series1 As Series = chartControl1.Series(0)
			series1.ArgumentScaleType = ScaleType.DateTime

			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 1), New Object() { 24.00, 25.00, 25.00, 24.875 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 2), New Object() { 23.625, 25.125, 24.00, 24.875 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 3), New Object() { 26.25, 28.25, 26.75, 27.00 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 4), New Object() { 26.50, 27.875, 26.875, 27.25 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 7), New Object() { 26.375, 27.50, 27.375, 26.75 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 8), New Object() { 25.75, 26.875, 26.75, 26.00 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 9), New Object() { 25.75, 26.75, 26.125, 26.25 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 10), New Object() { 25.75, 26.375, 26.375, 25.875 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 11), New Object() { 24.875, 26.125, 26.00, 25.375 }))
			series1.Points.Add(New SeriesPoint(New DateTime(1994, 3, 14), New Object() { 25.125, 26.00, 25.625, 25.75 }))

'			#Region "#code"
Dim axisX As AxisX = (CType(chartControl1.Diagram, XYDiagram)).AxisX

' Exclude holidays from the axis scale.
axisX.WorkdaysOnly = True

' Specify custom working days.
axisX.WorkdaysOptions.Workdays = Weekday.Sunday Or Weekday.Monday Or _ 
    Weekday.Tuesday Or Weekday.Wednesday Or Weekday.Thursday Or Weekday.Friday

' Specify holidays
axisX.WorkdaysOptions.Holidays.AddRange(New KnownDate() { _ 
    New KnownDate("Custom Holiday 1", New DateTime(1994, 3, 2, 0, 0, 0, 0)), _ 
    New KnownDate("Custom Holiday 2", New DateTime(1994, 4, 2, 0, 0, 0, 0))})

' Specify strict working days.
' Thay will have a priority over the holidays specified.
axisX.WorkdaysOptions.ExactWorkdays.Add(New KnownDate _ 
    ("Community Work Day", New DateTime(1994, 3, 2, 0, 0, 0, 0)))
'			#End Region ' #code
		End Sub

	End Class
End Namespace
