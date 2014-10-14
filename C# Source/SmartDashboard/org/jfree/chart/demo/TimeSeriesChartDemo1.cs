// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.demo.TimeSeriesChartDemo1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.text;
using javax.swing;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.chart.renderer.xy;
using org.jfree.data.time;
using org.jfree.data.xy;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.demo
{
  [Serializable]
  public class TimeSeriesChartDemo1 : ApplicationFrame
  {
    [HideFromJava]
    static TimeSeriesChartDemo1()
    {
      ApplicationFrame.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 105, (byte) 107, (byte) 117, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesChartDemo1(string title)
      : base(title)
    {
      TimeSeriesChartDemo1 seriesChartDemo1 = this;
      ChartPanel chartPanel = (ChartPanel) TimeSeriesChartDemo1.createDemoPanel();
      ((JComponent) chartPanel).setPreferredSize(new Dimension(500, 270));
      this.setContentPane((Container) chartPanel);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeSeriesChartDemo1([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 107, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JPanel createDemoPanel()
    {
      ChartPanel chartPanel = new ChartPanel(TimeSeriesChartDemo1.createChart(TimeSeriesChartDemo1.createDataset()));
      chartPanel.setFillZoomRectangle(true);
      chartPanel.setMouseWheelEnabled(true);
      return (JPanel) chartPanel;
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 107, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 123, (byte) 123, (byte) 123, (byte) 123, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 154, (byte) 107, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 123, (byte) 123, (byte) 123, (byte) 123, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 122, (byte) 250, (byte) 74, (byte) 102, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static XYDataset createDataset()
    {
      TimeSeries series1 = new TimeSeries((IComparable) "L&G European Index Trust");
      series1.add((RegularTimePeriod) new Month(2, 2001), 181.8);
      series1.add((RegularTimePeriod) new Month(3, 2001), 167.3);
      series1.add((RegularTimePeriod) new Month(4, 2001), 153.8);
      series1.add((RegularTimePeriod) new Month(5, 2001), 167.6);
      series1.add((RegularTimePeriod) new Month(6, 2001), 158.8);
      series1.add((RegularTimePeriod) new Month(7, 2001), 148.3);
      series1.add((RegularTimePeriod) new Month(8, 2001), 153.9);
      series1.add((RegularTimePeriod) new Month(9, 2001), 142.7);
      series1.add((RegularTimePeriod) new Month(10, 2001), 123.2);
      series1.add((RegularTimePeriod) new Month(11, 2001), 131.8);
      series1.add((RegularTimePeriod) new Month(12, 2001), 139.6);
      series1.add((RegularTimePeriod) new Month(1, 2002), 142.9);
      series1.add((RegularTimePeriod) new Month(2, 2002), 138.7);
      series1.add((RegularTimePeriod) new Month(3, 2002), 137.3);
      series1.add((RegularTimePeriod) new Month(4, 2002), 143.9);
      series1.add((RegularTimePeriod) new Month(5, 2002), 139.8);
      series1.add((RegularTimePeriod) new Month(6, 2002), 137.0);
      series1.add((RegularTimePeriod) new Month(7, 2002), 132.8);
      TimeSeries series2 = new TimeSeries((IComparable) "L&G UK Index Trust");
      series2.add((RegularTimePeriod) new Month(2, 2001), 129.6);
      series2.add((RegularTimePeriod) new Month(3, 2001), 123.2);
      series2.add((RegularTimePeriod) new Month(4, 2001), 117.2);
      series2.add((RegularTimePeriod) new Month(5, 2001), 124.1);
      series2.add((RegularTimePeriod) new Month(6, 2001), 122.6);
      series2.add((RegularTimePeriod) new Month(7, 2001), 119.2);
      series2.add((RegularTimePeriod) new Month(8, 2001), 116.5);
      series2.add((RegularTimePeriod) new Month(9, 2001), 112.7);
      series2.add((RegularTimePeriod) new Month(10, 2001), 101.5);
      series2.add((RegularTimePeriod) new Month(11, 2001), 106.1);
      series2.add((RegularTimePeriod) new Month(12, 2001), 110.3);
      series2.add((RegularTimePeriod) new Month(1, 2002), 111.7);
      series2.add((RegularTimePeriod) new Month(2, 2002), 111.0);
      series2.add((RegularTimePeriod) new Month(3, 2002), 109.6);
      series2.add((RegularTimePeriod) new Month(4, 2002), 113.2);
      series2.add((RegularTimePeriod) new Month(5, 2002), 111.6);
      series2.add((RegularTimePeriod) new Month(6, 2002), 108.8);
      series2.add((RegularTimePeriod) new Month(7, 2002), 101.6);
      TimeSeriesCollection seriesCollection = new TimeSeriesCollection();
      seriesCollection.addSeries(series1);
      seriesCollection.addSeries(series2);
      return (XYDataset) seriesCollection;
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 249, (byte) 74, (byte) 139, (byte) 108, (byte) 107, (byte) 107, (byte) 107, (byte) 127, (byte) 16, (byte) 103, (byte) 135, (byte) 103, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 167, (byte) 109, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static JFreeChart createChart([In] XYDataset obj0)
    {
      JFreeChart timeSeriesChart = ChartFactory.createTimeSeriesChart("Legal & General Unit Trust Prices", "Date", "Price Per Unit", obj0, true, true, false);
      timeSeriesChart.setBackgroundPaint((Paint) Color.white);
      XYPlot xyPlot = (XYPlot) timeSeriesChart.getPlot();
      xyPlot.setBackgroundPaint((Paint) Color.lightGray);
      xyPlot.setDomainGridlinePaint((Paint) Color.white);
      xyPlot.setRangeGridlinePaint((Paint) Color.white);
      xyPlot.setAxisOffset(new RectangleInsets(5.0, 5.0, 5.0, 5.0));
      xyPlot.setDomainCrosshairVisible(true);
      xyPlot.setRangeCrosshairVisible(true);
      XYItemRenderer renderer = xyPlot.getRenderer();
      if (renderer is XYLineAndShapeRenderer)
      {
        XYLineAndShapeRenderer andShapeRenderer = (XYLineAndShapeRenderer) renderer;
        andShapeRenderer.setBaseShapesVisible(true);
        andShapeRenderer.setBaseShapesFilled(true);
        andShapeRenderer.setDrawSeriesLineAsPath(true);
      }
      ((DateAxis) xyPlot.getDomainAxis()).setDateFormatOverride((DateFormat) new SimpleDateFormat("MMM-yyyy"));
      return timeSeriesChart;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 139, (byte) 102, (byte) 102, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      TimeSeriesChartDemo1 seriesChartDemo1 = new TimeSeriesChartDemo1("Time Series Chart Demo 1");
      ((Window) seriesChartDemo1).pack();
      RefineryUtilities.centerFrameOnScreen((Window) seriesChartDemo1);
      ((Window) seriesChartDemo1).setVisible(true);
    }
  }
}
