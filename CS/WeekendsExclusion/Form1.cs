#region #usings
using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...
#endregion #usings

namespace WeekendsExclusion {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Series series1 = chartControl1.Series[0];
            series1.ArgumentScaleType = ScaleType.DateTime;

            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 1),
        new object[] { 24.00, 25.00, 25.00, 24.875 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 2),
                new object[] { 23.625, 25.125, 24.00, 24.875 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 3),
                new object[] { 26.25, 28.25, 26.75, 27.00 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 4),
                new object[] { 26.50, 27.875, 26.875, 27.25 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 7),
                new object[] { 26.375, 27.50, 27.375, 26.75 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 8),
                new object[] { 25.75, 26.875, 26.75, 26.00 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 9),
                new object[] { 25.75, 26.75, 26.125, 26.25 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 10),
                new object[] { 25.75, 26.375, 26.375, 25.875 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 11),
                new object[] { 24.875, 26.125, 26.00, 25.375 }));
            series1.Points.Add(new SeriesPoint(new DateTime(1994, 3, 14),
                new object[] { 25.125, 26.00, 25.625, 25.75 }));

#region #code
AxisX axisX = ((XYDiagram)chartControl1.Diagram).AxisX;

// Exclude holidays from the axis scale.
axisX.WorkdaysOnly = true;

// Specify custom working days.
axisX.WorkdaysOptions.Workdays = Weekday.Sunday | Weekday.Monday | Weekday.Tuesday |
    Weekday.Wednesday | Weekday.Thursday | Weekday.Friday;

// Specify holidays
axisX.WorkdaysOptions.Holidays.AddRange(new KnownDate[] {
    new KnownDate("Custom Holiday 1", new DateTime(1994, 3, 2, 0, 0, 0, 0)),
    new KnownDate("Custom Holiday 2", new DateTime(1994, 4, 2, 0, 0, 0, 0))});

// Specify strict working days.
// Thay will have a priority over the holidays specified.
axisX.WorkdaysOptions.ExactWorkdays.Add(
    new KnownDate("Community Work Day", new DateTime(1994, 3, 2, 0, 0, 0, 0)));
#endregion #code
        }

    }
}
