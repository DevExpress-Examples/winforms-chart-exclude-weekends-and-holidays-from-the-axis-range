<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574652/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2365)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->

# Chart for WinForms - How to Exclude Weekends and Holidays from the Axis Range

This example demonstrates how you can exclude weekends and holidays from the X-axis range. This feature is useful for financial charting.

![](chart.png)

## Files to Review

* [Form1.cs](./CS/WeekendsExclusion/Form1.cs) (VB: [Form1.vb](./VB/WeekendsExclusion/Form1.vb))
## Example Overview

You can specify a custom week, or import holiday lists in Microsoft Outlook or in our native [XtraScheduler](https://docs.devexpress.com/WindowsForms/1729/controls-and-libraries/scheduler/visual-elements/scheduler-control) format.

The first chart excludes holidays and non-working days from the axis scale and shows how to set custom workdays and holidays. In this example, Sunday is a work day and Saturday is a day off, March 6th (Saturday) is an additional work day and March 8th (Monday) is an additional holiday. For this, use the [DateTimeScaleOptions.WorkdaysOnly](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.WorkdaysOnly) and [DateTimeScaleOptions.WorkdaysOptions](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.WorkdaysOptions) properties. 

The second chart shows how to exclude axis ranges without data points. In this example, March 8th has no data points to display and is not displayed on the X-axis. To do this, use the [DateTimeScaleOptions.SkipRangesWithoutPoints](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.DateTimeScaleOptions.SkipRangesWithoutPoints) property.

## Documentation

- [Work Time and Workday Configuration](https://docs.devexpress.com/WindowsForms/16474/controls-and-libraries/chart-control/data-representation/work-time-and-workday-configuration)
- [Financial Charting](https://docs.devexpress.com/WindowsForms/8946/controls-and-libraries/chart-control/data-representation/financial-charting)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-chart-exclude-weekends-and-holidays-from-the-axis-range&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-chart-exclude-weekends-and-holidays-from-the-axis-range&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
