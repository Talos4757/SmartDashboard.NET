// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.SimpleDial
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
using org.jfree.data;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class SimpleDial : AbstractNumberDatasetWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal DoubleProperty __\u003C\u003Emax;
    internal DoubleProperty __\u003C\u003Emin;
    internal DoubleProperty __\u003C\u003EtickInterval;
    [Modifiers]
    private JPanel chartPanel;
    [Modifiers]
    private MeterPlot m_meter;
    private Range m_plotRange;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return SimpleDial.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public DoubleProperty max
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Emax;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Emax = value;
      }
    }

    [Modifiers]
    public DoubleProperty min
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Emin;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Emin = value;
      }
    }

    [Modifiers]
    public DoubleProperty tickInterval
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EtickInterval;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EtickInterval = value;
      }
    }

    [LineNumberTable((ushort) 21)]
    static SimpleDial()
    {
      AbstractNumberDatasetWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      DataType dataType = DataType.__\u003C\u003ENUMBER;
      dataTypeArray[index] = dataType;
      SimpleDial.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 237, (byte) 55, (byte) 122, (byte) 118, (byte) 250, (byte) 73, (byte) 139, (byte) 118, (byte) 127, (byte) 12, (byte) 145, (byte) 125, (byte) 108, (byte) 154, (byte) 140, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleDial()
      : base(0.0)
    {
      SimpleDial simpleDial = this;
      this.__\u003C\u003Emax = new DoubleProperty((PropertyHolder) this, "Upper Limit", 100.0);
      this.__\u003C\u003Emin = new DoubleProperty((PropertyHolder) this, "Lower Limit", 0.0);
      this.__\u003C\u003EtickInterval = new DoubleProperty((PropertyHolder) this, "Tick Interval", 10.0);
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      MeterPlot.__\u003Cclinit\u003E();
      this.m_meter = new MeterPlot((ValueDataset) this.getDataset());
      this.m_plotRange = new Range(this.__\u003C\u003Emin.getValue().doubleValue(), this.__\u003C\u003Emax.getValue().doubleValue());
      this.m_meter.setRange(this.m_plotRange);
      JFreeChart.__\u003Cclinit\u003E();
      this.chartPanel = (JPanel) new ChartPanel(new JFreeChart(this.getFieldName(), JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) this.m_meter, false));
      ((JComponent) this.chartPanel).setPreferredSize(new Dimension(250, 150));
      this.propertyChanged((Property) this.__\u003C\u003EtickInterval);
      ((Container) this).add((Component) this.chartPanel, (object) "Center");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SimpleDial([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 114, (byte) 127, (byte) 12, (byte) 115, (byte) 105, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Emin || property == this.__\u003C\u003Emax)
      {
        this.m_plotRange = new Range(this.__\u003C\u003Emin.getValue().doubleValue(), this.__\u003C\u003Emax.getValue().doubleValue());
        this.m_meter.setRange(this.m_plotRange);
      }
      else
      {
        if (property != this.__\u003C\u003EtickInterval)
          return;
        this.m_meter.setTickSize(this.__\u003C\u003EtickInterval.getValue().doubleValue());
      }
    }

    public override void init()
    {
    }
  }
}
