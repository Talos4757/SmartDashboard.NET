// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Compass
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using org.jfree.chart;
using org.jfree.chart.plot;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable"})]
  [Serializable]
  public class Compass : AbstractTableWidget, NumberBindable
  {
    internal static DataType[] __\u003C\u003ETYPES;
    internal DoubleProperty __\u003C\u003Ecircumference;
    internal ColorProperty __\u003C\u003EringColor;
    private JPanel chartPanel;
    private DefaultValueDataset data;
    private CompassPlot m_compass;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return Compass.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public DoubleProperty circumference
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ecircumference;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ecircumference = value;
      }
    }

    [Modifiers]
    public ColorProperty ringColor
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EringColor;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EringColor = value;
      }
    }

    [LineNumberTable((ushort) 24)]
    static Compass()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[2];
      int index1 = 0;
      DataType dataType = DataType.__\u003C\u003ENUMBER;
      dataTypeArray[index1] = dataType;
      int index2 = 1;
      NamedDataType namedDataType = GyroType.get();
      dataTypeArray[index2] = (DataType) namedDataType;
      Compass.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 168, (byte) 122, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Compass()
    {
      Compass compass = this;
      this.__\u003C\u003Ecircumference = new DoubleProperty((PropertyHolder) this, "Circumference", 360.0);
      this.__\u003C\u003EringColor = new ColorProperty((PropertyHolder) this, "Ring Color", (Color) Color.YELLOW);
      this.data = new DefaultValueDataset(0.0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Compass([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 127, (byte) 9, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateValue(double value)
    {
      this.data.setValue((Number) Double.valueOf(value + this.m_compass.getRevolutionDistance() / 2.0));
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 122, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void doubleChanged(ITable source, string key, double value, bool isNew)
    {
      if (!String.instancehelper_equals(key, (object) "angle") && !String.instancehelper_equals(key, (object) "Value"))
        return;
      this.updateValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 139, (byte) 118, (byte) 108, (byte) 113, (byte) 145, (byte) 125, (byte) 108, (byte) 154, (byte) 209, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      CompassPlot.__\u003Cclinit\u003E();
      this.m_compass = new CompassPlot((ValueDataset) this.data);
      this.m_compass.setSeriesNeedle(7);
      this.m_compass.setSeriesPaint(0, (Paint) Color.RED);
      this.m_compass.setSeriesOutlinePaint(0, (Paint) Color.RED);
      JFreeChart.__\u003Cclinit\u003E();
      this.chartPanel = (JPanel) new ChartPanel(new JFreeChart(this.getFieldName(), JFreeChart.__\u003C\u003EDEFAULT_TITLE_FONT, (Plot) this.m_compass, false));
      ((JComponent) this.chartPanel).setPreferredSize(new Dimension(250, 150));
      ((Container) this).add((Component) this.chartPanel, (object) "Center");
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 104, (byte) 108, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(double value)
    {
      if (this.table != null)
        base.setValue((object) (ITable) null);
      this.updateValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 105, (byte) 127, (byte) 9, (byte) 123, (byte) 103, (byte) 107, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003Ecircumference)
      {
        double num = this.data.getValue().doubleValue() - this.m_compass.getRevolutionDistance() / 2.0;
        this.m_compass.setRevolutionDistance(this.__\u003C\u003Ecircumference.getValue().doubleValue());
        this.updateValue(num);
      }
      else
      {
        if (property != this.__\u003C\u003EringColor)
          return;
        this.m_compass.setRosePaint((Paint) this.__\u003C\u003EringColor.getValue());
      }
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBindableValue(double value)
    {
      this.doubleChanged(this.table, "Value", value, true);
    }
  }
}
