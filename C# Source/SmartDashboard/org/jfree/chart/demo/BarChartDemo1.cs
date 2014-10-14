// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.demo.BarChartDemo1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using javax.swing;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.chart.renderer.category;
using org.jfree.data.category;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.demo
{
  [Serializable]
  public class BarChartDemo1 : ApplicationFrame
  {
    [HideFromJava]
    static BarChartDemo1()
    {
      ApplicationFrame.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 105, (byte) 102, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 117, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarChartDemo1(string title)
      : base(title)
    {
      BarChartDemo1 barChartDemo1 = this;
      ChartPanel chartPanel = new ChartPanel(BarChartDemo1.createChart(BarChartDemo1.createDataset()));
      chartPanel.setFillZoomRectangle(true);
      chartPanel.setMouseWheelEnabled(true);
      ((JComponent) chartPanel).setPreferredSize(new Dimension(500, 270));
      this.setContentPane((Container) chartPanel);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BarChartDemo1([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 102, (byte) 102, (byte) 166, (byte) 102, (byte) 103, (byte) 103, (byte) 103, (byte) 167, (byte) 135, (byte) 110, (byte) 115, (byte) 115, (byte) 115, (byte) 147, (byte) 114, (byte) 115, (byte) 115, (byte) 115, (byte) 147, (byte) 114, (byte) 115, (byte) 115, (byte) 115, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static CategoryDataset createDataset()
    {
      string str1 = "First";
      string str2 = "Second";
      string str3 = "Third";
      string str4 = "Category 1";
      string str5 = "Category 2";
      string str6 = "Category 3";
      string str7 = "Category 4";
      string str8 = "Category 5";
      DefaultCategoryDataset defaultCategoryDataset = new DefaultCategoryDataset();
      defaultCategoryDataset.addValue(1.0, (IComparable) str1, (IComparable) str4);
      defaultCategoryDataset.addValue(4.0, (IComparable) str1, (IComparable) str5);
      defaultCategoryDataset.addValue(3.0, (IComparable) str1, (IComparable) str6);
      defaultCategoryDataset.addValue(5.0, (IComparable) str1, (IComparable) str7);
      defaultCategoryDataset.addValue(5.0, (IComparable) str1, (IComparable) str8);
      defaultCategoryDataset.addValue(5.0, (IComparable) str2, (IComparable) str4);
      defaultCategoryDataset.addValue(7.0, (IComparable) str2, (IComparable) str5);
      defaultCategoryDataset.addValue(6.0, (IComparable) str2, (IComparable) str6);
      defaultCategoryDataset.addValue(8.0, (IComparable) str2, (IComparable) str7);
      defaultCategoryDataset.addValue(4.0, (IComparable) str2, (IComparable) str8);
      defaultCategoryDataset.addValue(4.0, (IComparable) str3, (IComparable) str4);
      defaultCategoryDataset.addValue(3.0, (IComparable) str3, (IComparable) str5);
      defaultCategoryDataset.addValue(2.0, (IComparable) str3, (IComparable) str6);
      defaultCategoryDataset.addValue(3.0, (IComparable) str3, (IComparable) str7);
      defaultCategoryDataset.addValue(6.0, (IComparable) str3, (IComparable) str8);
      return (CategoryDataset) defaultCategoryDataset;
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 254, (byte) 78, (byte) 171, (byte) 236, (byte) 75, (byte) 108, (byte) 171, (byte) 108, (byte) 167, (byte) 159, (byte) 10, (byte) 159, (byte) 10, (byte) 159, (byte) 10, (byte) 105, (byte) 105, (byte) 137, (byte) 104, (byte) 245, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static JFreeChart createChart([In] CategoryDataset obj0)
    {
      JFreeChart barChart = ChartFactory.createBarChart("Bar Chart Demo 1", "Category", "Value", obj0, PlotOrientation.__\u003C\u003EVERTICAL, true, true, false);
      barChart.setBackgroundPaint((Paint) Color.white);
      CategoryPlot categoryPlot = (CategoryPlot) barChart.getPlot();
      categoryPlot.getRangeAxis().setStandardTickUnits(NumberAxis.createIntegerTickUnits());
      BarRenderer barRenderer = (BarRenderer) categoryPlot.getRenderer();
      barRenderer.setDrawBarOutline(false);
      GradientPaint gradientPaint1 = new GradientPaint(0.0f, 0.0f, (Color) Color.blue, 0.0f, 0.0f, new Color(0, 0, 64));
      GradientPaint gradientPaint2 = new GradientPaint(0.0f, 0.0f, (Color) Color.green, 0.0f, 0.0f, new Color(0, 64, 0));
      GradientPaint gradientPaint3 = new GradientPaint(0.0f, 0.0f, (Color) Color.red, 0.0f, 0.0f, new Color(64, 0, 0));
      barRenderer.setSeriesPaint(0, (Paint) gradientPaint1);
      barRenderer.setSeriesPaint(1, (Paint) gradientPaint2);
      barRenderer.setSeriesPaint(2, (Paint) gradientPaint3);
      categoryPlot.getDomainAxis().setCategoryLabelPositions(CategoryLabelPositions.createUpRotationLabelPositions(Math.PI / 6.0));
      return barChart;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 107, (byte) 102, (byte) 102, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      BarChartDemo1 barChartDemo1 = new BarChartDemo1("Bar Chart Demo 1");
      ((Window) barChartDemo1).pack();
      RefineryUtilities.centerFrameOnScreen((Window) barChartDemo1);
      ((Window) barChartDemo1).setVisible(true);
    }
  }
}
