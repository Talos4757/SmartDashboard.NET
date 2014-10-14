// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.demo.PieChartDemo1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using org.jfree.chart;
using org.jfree.chart.plot;
using org.jfree.data.general;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.demo
{
  [Serializable]
  public class PieChartDemo1 : ApplicationFrame
  {
    [HideFromJava]
    static PieChartDemo1()
    {
      ApplicationFrame.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 105, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PieChartDemo1(string title)
      : base(title)
    {
      PieChartDemo1 pieChartDemo1 = this;
      this.setContentPane((Container) PieChartDemo1.createDemoPanel());
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PieChartDemo1([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JPanel createDemoPanel()
    {
      return (JPanel) new ChartPanel(PieChartDemo1.createChart(PieChartDemo1.createDataset()));
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 102, (byte) 121, (byte) 121, (byte) 121, (byte) 121, (byte) 121, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static PieDataset createDataset()
    {
      DefaultPieDataset defaultPieDataset = new DefaultPieDataset();
      defaultPieDataset.setValue((IComparable) "One", (Number) new Double(43.2));
      defaultPieDataset.setValue((IComparable) "Two", (Number) new Double(10.0));
      defaultPieDataset.setValue((IComparable) "Three", (Number) new Double(27.5));
      defaultPieDataset.setValue((IComparable) "Four", (Number) new Double(17.5));
      defaultPieDataset.setValue((IComparable) "Five", (Number) new Double(11.0));
      defaultPieDataset.setValue((IComparable) "Six", (Number) new Double(19.4));
      return (PieDataset) defaultPieDataset;
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 239, (byte) 72, (byte) 108, (byte) 103, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static JFreeChart createChart([In] PieDataset obj0)
    {
      JFreeChart pieChart = ChartFactory.createPieChart("Pie Chart Demo 1", obj0, true, true, false);
      PiePlot piePlot = (PiePlot) pieChart.getPlot();
      piePlot.setSectionOutlinesVisible(false);
      piePlot.setNoDataMessage("No data available");
      return pieChart;
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 107, (byte) 102, (byte) 102, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      PieChartDemo1 pieChartDemo1 = new PieChartDemo1("Pie Chart Demo 1");
      ((Window) pieChartDemo1).pack();
      RefineryUtilities.centerFrameOnScreen((Window) pieChartDemo1);
      ((Window) pieChartDemo1).setVisible(true);
    }
  }
}
