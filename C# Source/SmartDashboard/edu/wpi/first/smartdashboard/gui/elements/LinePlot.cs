// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.LinePlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using IKVM.Attributes;
using java.awt;
using javax.swing;
using org.jfree.chart;
using org.jfree.chart.plot;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class LinePlot : AbstractValueWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal IntegerProperty __\u003C\u003EbufferSize;
    internal JPanel m_chartPanel;
    internal XYSeries m_data;
    internal XYDataset m_dataset;
    internal JFreeChart m_chart;
    internal int m_timeUnit;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return LinePlot.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public IntegerProperty bufferSize
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EbufferSize;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EbufferSize = value;
      }
    }

    [LineNumberTable((ushort) 21)]
    static LinePlot()
    {
      AbstractValueWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003ENUMBER;
      dataTypeArray[index] = dataType;
      LinePlot.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 168, (byte) 246, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LinePlot()
    {
      LinePlot linePlot = this;
      this.__\u003C\u003EbufferSize = new IntegerProperty((PropertyHolder) this, "Buffer Size (samples)", 5000);
      this.m_timeUnit = 0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LinePlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 139, (byte) 113, (byte) 145, (byte) 255, (byte) 5, (byte) 74, (byte) 108, (byte) 122, (byte) 145, (byte) 113, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.m_data = new XYSeries((IComparable) this.getFieldName());
      this.m_dataset = (XYDataset) new XYSeriesCollection(this.m_data);
      this.m_chartPanel = (JPanel) new ChartPanel(ChartFactory.createXYLineChart(this.getFieldName(), "Time (units)", "Data", this.m_dataset, PlotOrientation.__\u003C\u003EVERTICAL, false, true, false));
      ((JComponent) this.m_chartPanel).setPreferredSize(new Dimension(400, 300));
      ((JComponent) this.m_chartPanel).setBackground(((Component) this).getBackground());
      ((Container) this).add((Component) this.m_chartPanel, (object) "Center");
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 159, (byte) 2, (byte) 125, (byte) 173, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setValue(double value)
    {
      XYSeries xySeries = this.m_data;
      LinePlot linePlot1 = this;
      int num1 = linePlot1.m_timeUnit;
      LinePlot linePlot2 = linePlot1;
      int num2 = num1;
      linePlot2.m_timeUnit = num1 + 1;
      double x = (double) num2;
      double y = value;
      xySeries.add(x, y);
      if (this.m_data.getItemCount() > this.__\u003C\u003EbufferSize.getValue().intValue())
        this.m_data.remove(0);
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 137, (byte) 125, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property != this.__\u003C\u003EbufferSize)
        return;
      while (this.m_data.getItemCount() > this.__\u003C\u003EbufferSize.getValue().intValue())
        this.m_data.remove(0);
    }
  }
}
