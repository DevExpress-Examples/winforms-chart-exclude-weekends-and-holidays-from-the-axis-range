namespace WeekendsExclusion {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView2 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView5 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView6 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView3 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView4 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chartControl0 = new DevExpress.XtraCharts.ChartControl();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AutoLayout = false;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Label.Angle = -35;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(12, 255);
            this.chartControl1.Name = "chartControl1";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Series 1";
            series1.View = stockSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = stockSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(941, 256);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Chart with WorkdaysOptions";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chartControl0);
            this.layoutControl1.Controls.Add(this.chartControl2);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(604, 156, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(965, 749);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chartControl2
            // 
            this.chartControl2.AutoLayout = false;
            xyDiagram3.AxisX.GridLines.Visible = true;
            xyDiagram3.AxisX.Label.Angle = -35;
            xyDiagram3.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.GridLines.Visible = false;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chartControl2.Diagram = xyDiagram3;
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(12, 515);
            this.chartControl2.Name = "chartControl2";
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series3.Name = "Series 1";
            series3.View = stockSeriesView5;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl2.SeriesTemplate.View = stockSeriesView6;
            this.chartControl2.Size = new System.Drawing.Size(941, 221);
            this.chartControl2.TabIndex = 4;
            chartTitle3.Text = "Chart with SkipRangesWithoutPoints";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleSeparator1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(965, 749);
            this.Root.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 728);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(945, 1);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 243);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(945, 260);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.chartControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 503);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(945, 225);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // chartControl0
            // 
            this.chartControl0.AutoLayout = false;
            xyDiagram2.AxisX.GridLines.Visible = true;
            xyDiagram2.AxisX.Label.Angle = -35;
            xyDiagram2.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.GridLines.Visible = false;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chartControl0.Diagram = xyDiagram2;
            this.chartControl0.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl0.Location = new System.Drawing.Point(12, 12);
            this.chartControl0.Name = "chartControl0";
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series2.Name = "Series 1";
            series2.View = stockSeriesView3;
            this.chartControl0.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl0.SeriesTemplate.View = stockSeriesView4;
            this.chartControl0.Size = new System.Drawing.Size(941, 239);
            this.chartControl0.TabIndex = 5;
            chartTitle2.Text = "Original Chart";
            this.chartControl0.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chartControl0;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(945, 243);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 749);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraCharts.ChartControl chartControl0;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

