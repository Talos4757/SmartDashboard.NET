// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.ThermometerPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.plot.ValueAxisPlot", "org.jfree.chart.plot.Zoomable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class ThermometerPlot : Plot, ValueAxisPlot, Zoomable, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 4087093313147984390L;
    public const int UNITS_NONE = 0;
    public const int UNITS_FAHRENHEIT = 1;
    public const int UNITS_CELCIUS = 2;
    public const int UNITS_KELVIN = 3;
    public const int NONE = 0;
    public const int RIGHT = 1;
    public const int LEFT = 2;
    public const int BULB = 3;
    public const int NORMAL = 0;
    public const int WARNING = 1;
    public const int CRITICAL = 2;
    [Obsolete]
    protected internal const int BULB_RADIUS = 40;
    [Obsolete]
    protected internal const int BULB_DIAMETER = 80;
    [Obsolete]
    protected internal const int COLUMN_RADIUS = 20;
    [Obsolete]
    protected internal const int COLUMN_DIAMETER = 40;
    [Obsolete]
    protected internal const int GAP_RADIUS = 5;
    [Obsolete]
    protected internal const int GAP_DIAMETER = 10;
    protected internal const int AXIS_GAP = 10;
    internal static string[] __\u003C\u003EUNITS;
    protected internal const int RANGE_LOW = 0;
    protected internal const int RANGE_HIGH = 1;
    protected internal const int DISPLAY_LOW = 2;
    protected internal const int DISPLAY_HIGH = 3;
    protected internal const double DEFAULT_LOWER_BOUND = 0.0;
    protected internal const double DEFAULT_UPPER_BOUND = 100.0;
    protected internal const int DEFAULT_BULB_RADIUS = 40;
    protected internal const int DEFAULT_COLUMN_RADIUS = 20;
    protected internal const int DEFAULT_GAP = 5;
    private ValueDataset dataset;
    private ValueAxis rangeAxis;
    private double lowerBound;
    private double upperBound;
    private int bulbRadius;
    private int columnRadius;
    private int gap;
    private RectangleInsets padding;
    [NonSerialized]
    private Stroke thermometerStroke;
    [NonSerialized]
    private Paint thermometerPaint;
    private int units;
    private int valueLocation;
    private int axisLocation;
    private Font valueFont;
    [NonSerialized]
    private Paint valuePaint;
    private NumberFormat valueFormat;
    [NonSerialized]
    private Paint mercuryPaint;
    private bool showValueLines;
    private int subrange;
    private double[][] subrangeInfo;
    private bool followDataInSubranges;
    private bool useSubrangePaint;
    [NonSerialized]
    private Paint[] subrangePaint;
    private bool subrangeIndicatorsVisible;
    [NonSerialized]
    private Stroke subrangeIndicatorStroke;
    [NonSerialized]
    private Stroke rangeIndicatorStroke;
    protected internal static ResourceBundle localizationResources;

    [Modifiers]
    protected internal static string[] UNITS
    {
      [HideFromJava] get
      {
        return ThermometerPlot.__\u003C\u003EUNITS;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 83, (byte) 69, (byte) 255, (byte) 12, (byte) 160, (byte) 146})]
    static ThermometerPlot()
    {
      Plot.__\u003Cclinit\u003E();
      string[] strArray = new string[4];
      int index1 = 0;
      string str1 = "";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "°F";
      strArray[index2] = str2;
      int index3 = 2;
      string str3 = "°C";
      strArray[index3] = str3;
      int index4 = 3;
      string str4 = "°K";
      strArray[index4] = str4;
      ThermometerPlot.__\u003C\u003EUNITS = strArray;
      ThermometerPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermometerPlot()
      : this((ValueDataset) new DefaultValueDataset())
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 30, (byte) 232, (byte) 159, (byte) 141, (byte) 172, (byte) 240, (byte) 71, (byte) 232, (byte) 71, (byte) 232, (byte) 71, (byte) 231, (byte) 72, (byte) 176, (byte) 171, (byte) 167, (byte) 167, (byte) 167, (byte) 179, (byte) 171, (byte) 171, (byte) 171, (byte) 167, (byte) 167, (byte) 255, (byte) 160, (byte) 80, (byte) 74, (byte) 231, (byte) 70, (byte) 167, (byte) 223, (byte) 5, (byte) 167, (byte) 176, (byte) 240, (byte) 87, (byte) 159, (byte) 26, (byte) 103, (byte) 99, (byte) 135, (byte) 103, (byte) 107, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermometerPlot(ValueDataset dataset)
    {
      ThermometerPlot thermometerPlot = this;
      this.lowerBound = 0.0;
      this.upperBound = 100.0;
      this.bulbRadius = 40;
      this.columnRadius = 20;
      this.gap = 5;
      this.thermometerStroke = (Stroke) new BasicStroke(1f);
      this.thermometerPaint = (Paint) Color.black;
      this.units = 2;
      this.valueLocation = 3;
      this.axisLocation = 2;
      this.valueFont = new Font("SansSerif", 1, 16);
      this.valuePaint = (Paint) Color.white;
      this.valueFormat = (NumberFormat) new DecimalFormat();
      this.mercuryPaint = (Paint) Color.lightGray;
      this.showValueLines = false;
      this.subrange = -1;
      double[][] numArray1 = new double[3][];
      int index1 = 0;
      double[] numArray2 = new double[4];
      int index2 = 0;
      double num1 = 0.0;
      numArray2[index2] = num1;
      int index3 = 1;
      double num2 = 50.0;
      numArray2[index3] = num2;
      int index4 = 2;
      double num3 = 0.0;
      numArray2[index4] = num3;
      int index5 = 3;
      double num4 = 50.0;
      numArray2[index5] = num4;
      numArray1[index1] = numArray2;
      int index6 = 1;
      double[] numArray3 = new double[4];
      int index7 = 0;
      double num5 = 50.0;
      numArray3[index7] = num5;
      int index8 = 1;
      double num6 = 75.0;
      numArray3[index8] = num6;
      int index9 = 2;
      double num7 = 50.0;
      numArray3[index9] = num7;
      int index10 = 3;
      double num8 = 75.0;
      numArray3[index10] = num8;
      numArray1[index6] = numArray3;
      int index11 = 2;
      double[] numArray4 = new double[4];
      int index12 = 0;
      double num9 = 75.0;
      numArray4[index12] = num9;
      int index13 = 1;
      double num10 = 100.0;
      numArray4[index13] = num10;
      int index14 = 2;
      double num11 = 75.0;
      numArray4[index14] = num11;
      int index15 = 3;
      double num12 = 100.0;
      numArray4[index15] = num12;
      numArray1[index11] = numArray4;
      this.subrangeInfo = numArray1;
      this.followDataInSubranges = false;
      this.useSubrangePaint = true;
      Paint[] paintArray = new Paint[3];
      int index16 = 0;
      // ISSUE: variable of the null type
      __Null local1 = Color.green;
      paintArray[index16] = (Paint) local1;
      int index17 = 1;
      // ISSUE: variable of the null type
      __Null local2 = Color.orange;
      paintArray[index17] = (Paint) local2;
      int index18 = 2;
      // ISSUE: variable of the null type
      __Null local3 = Color.red;
      paintArray[index18] = (Paint) local3;
      this.subrangePaint = paintArray;
      this.subrangeIndicatorsVisible = true;
      this.subrangeIndicatorStroke = (Stroke) new BasicStroke(2f);
      this.rangeIndicatorStroke = (Stroke) new BasicStroke(3f);
      RectangleInsets.__\u003Cclinit\u003E();
      this.padding = new RectangleInsets(UnitType.__\u003C\u003ERELATIVE, 0.05, 0.05, 0.05, 0.05);
      this.dataset = dataset;
      if (dataset != null)
        dataset.addChangeListener((DatasetChangeListener) this);
      NumberAxis numberAxis = new NumberAxis((string) null);
      numberAxis.setStandardTickUnits(NumberAxis.createIntegerTickUnits());
      numberAxis.setAxisLineVisible(false);
      numberAxis.setPlot((Plot) this);
      numberAxis.addChangeListener((AxisChangeListener) this);
      this.rangeAxis = (ValueAxis) numberAxis;
      this.setAxisRange();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ThermometerPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ThermometerPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ThermometerPlot obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 149, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueFont(Font f)
    {
      if (f == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.valueFont.equals((object) f))
          return;
        this.valueFont = f;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 0, (byte) 99, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setThermometerPaint(Paint paint)
    {
      if (paint == null)
        return;
      this.thermometerPaint = paint;
      this.fireChangeEvent();
    }

    public virtual ValueAxis getRangeAxis()
    {
      return this.rangeAxis;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 103, (byte) 99, (byte) 199, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(ValueDataset dataset)
    {
      ValueDataset valueDataset = this.dataset;
      if (valueDataset != null)
        valueDataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (dataset != null)
      {
        this.setDatasetGroup(dataset.getGroup());
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 196, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueFormat(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.valueFormat = formatter;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 175, (byte) 105, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(double lower, double upper)
    {
      this.lowerBound = lower;
      this.upperBound = upper;
      this.setAxisRange();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 11, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubrangeInfo(int range, double low, double hi)
    {
      this.setSubrangeInfo(range, low, hi, low, hi);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 27, (byte) 104, (byte) 107, (byte) 109, (byte) 102, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubrangeInfo(int range, double rangeLow, double rangeHigh, double displayLow, double displayHigh)
    {
      if (range < 0 || range >= 3)
        return;
      this.setSubrange(range, rangeLow, rangeHigh);
      this.setDisplayRange(range, displayLow, displayHigh);
      this.setAxisRange();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 89, (byte) 104, (byte) 103, (byte) 168, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueLocation(int location)
    {
      if (location >= 0 && location < 4)
      {
        this.valueLocation = location;
        this.fireChangeEvent();
      }
      else
      {
        string str = "Location not recognised.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 178, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValuePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (Object.instancehelper_equals((object) this.valuePaint, (object) paint))
          return;
        this.valuePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 35, (byte) 109, (byte) 105, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUnits(int u)
    {
      if (u < 0 || u >= ThermometerPlot.__\u003C\u003EUNITS.Length || this.units == u)
        return;
      this.units = u;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 146, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFollowDataInSubranges(bool flag)
    {
      this.followDataInSubranges = flag;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 158, (byte) 178, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShowValueLines(bool b)
    {
      this.showValueLines = b;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 121, (byte) 104, (byte) 103, (byte) 168, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLocation(int location)
    {
      if (location >= 0 && location < 3)
      {
        this.axisLocation = location;
        this.fireChangeEvent();
      }
      else
      {
        string str = "Location not recognised.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    public virtual int getAxisLocation()
    {
      return this.axisLocation;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 49, (byte) 113, (byte) 255, (byte) 17, (byte) 69, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setAxisRange()
    {
      if (this.subrange >= 0 && this.followDataInSubranges)
        this.rangeAxis.setRange(new Range(this.subrangeInfo[this.subrange][2], this.subrangeInfo[this.subrange][3]));
      else
        this.rangeAxis.setRange(this.lowerBound, this.upperBound);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 240, (byte) 107, (byte) 108, (byte) 99, (byte) 104, (byte) 106, (byte) 137, (byte) 106, (byte) 137, (byte) 106, (byte) 169, (byte) 135, (byte) 166, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void datasetChanged(DatasetChangeEvent @event)
    {
      if (this.dataset != null)
      {
        Number number = this.dataset.getValue();
        if (number != null)
        {
          double num = number.doubleValue();
          this.subrange = !this.inSubrange(0, num) ? (!this.inSubrange(1, num) ? (!this.inSubrange(2, num) ? -1 : 2) : 1) : 0;
          this.setAxisRange();
        }
      }
      base.datasetChanged(@event);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 44, (byte) 104, (byte) 108, (byte) 140})]
    public virtual void setSubrange(int range, double low, double high)
    {
      if (range < 0 || range >= 3)
        return;
      this.subrangeInfo[range][1] = high;
      this.subrangeInfo[range][0] = low;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 59, (byte) 191, (byte) 1, (byte) 102, (byte) 108, (byte) 174, (byte) 108, (byte) 236, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDisplayRange(int range, double low, double high)
    {
      if (range < 0 || range >= this.subrangeInfo.Length || (!ThermometerPlot.isValidNumber(high) || !ThermometerPlot.isValidNumber(low)))
        return;
      if (high > low)
      {
        this.subrangeInfo[range][3] = high;
        this.subrangeInfo[range][2] = low;
      }
      else
      {
        this.subrangeInfo[range][3] = low;
        this.subrangeInfo[range][2] = high;
      }
    }

    [LineNumberTable((ushort) 1480)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static bool isValidNumber(double d)
    {
      return !Double.isNaN(d) && !Double.isInfinite(d);
    }

    public virtual int getBulbRadius()
    {
      return this.bulbRadius;
    }

    public virtual int getColumnRadius()
    {
      return this.columnRadius;
    }

    [LineNumberTable((ushort) 1072)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getBulbDiameter()
    {
      return this.getBulbRadius() * 2;
    }

    [LineNumberTable((ushort) 1112)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnDiameter()
    {
      return this.getColumnRadius() * 2;
    }

    public virtual int getGap()
    {
      return this.gap;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 110, (byte) 103, (byte) 104, (byte) 114, (byte) 106, (byte) 139, (byte) 106, (byte) 139, (byte) 106, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Paint getCurrentPaint()
    {
      Paint paint = this.mercuryPaint;
      if (this.useSubrangePaint)
      {
        double num = this.dataset.getValue().doubleValue();
        if (this.inSubrange(0, num))
          paint = this.subrangePaint[0];
        else if (this.inSubrange(1, num))
          paint = this.subrangePaint[1];
        else if (this.inSubrange(2, num))
          paint = this.subrangePaint[2];
      }
      return paint;
    }

    [LineNumberTable((ushort) 1492)]
    private bool inSubrange([In] int obj0, [In] double obj1)
    {
      return obj1 > this.subrangeInfo[obj0][0] && obj1 <= this.subrangeInfo[obj0][1];
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 228, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 102, (byte) 130, (byte) 103, (byte) 109, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool equal([In] double[][] obj0, [In] double[][] obj1)
    {
      if (obj0 == null)
      {
        return obj1 == null;
      }
      else
      {
        if (obj1 == null || obj0.Length != obj1.Length)
          return false;
        for (int index = 0; index < obj0.Length; ++index)
        {
          if (!Arrays.equals(obj0[index], obj1[index]))
            return false;
        }
        return true;
      }
    }

    public virtual ValueDataset getDataset()
    {
      return this.dataset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 99, (byte) 176, (byte) 140, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeAxis(ValueAxis axis)
    {
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeAxis.removeChangeListener((AxisChangeListener) this);
        axis.setPlot((Plot) this);
        axis.addChangeListener((AxisChangeListener) this);
        this.rangeAxis = axis;
        this.fireChangeEvent();
      }
    }

    public virtual double getLowerBound()
    {
      return this.lowerBound;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 140, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLowerBound(double lower)
    {
      this.lowerBound = lower;
      this.setAxisRange();
    }

    public virtual double getUpperBound()
    {
      return this.upperBound;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 164, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpperBound(double upper)
    {
      this.upperBound = upper;
      this.setAxisRange();
    }

    public virtual RectangleInsets getPadding()
    {
      return this.padding;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 201, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPadding(RectangleInsets padding)
    {
      if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.padding = padding;
        this.fireChangeEvent();
      }
    }

    public virtual Stroke getThermometerStroke()
    {
      return this.thermometerStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 229, (byte) 99, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setThermometerStroke(Stroke s)
    {
      if (s == null)
        return;
      this.thermometerStroke = s;
      this.fireChangeEvent();
    }

    public virtual Paint getThermometerPaint()
    {
      return this.thermometerPaint;
    }

    public virtual int getUnits()
    {
      return this.units;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 52, (byte) 99, (byte) 161, (byte) 109, (byte) 107, (byte) 121, (byte) 103, (byte) 231, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUnits(string u)
    {
      if (u == null)
        return;
      u = String.instancehelper_trim(String.instancehelper_toUpperCase(u));
      for (int u1 = 0; u1 < ThermometerPlot.__\u003C\u003EUNITS.Length; ++u1)
      {
        if (String.instancehelper_equals(u, (object) String.instancehelper_trim(String.instancehelper_toUpperCase(ThermometerPlot.__\u003C\u003EUNITS[u1]))))
        {
          this.setUnits(u1);
          u1 = ThermometerPlot.__\u003C\u003EUNITS.Length;
        }
      }
    }

    public virtual int getValueLocation()
    {
      return this.valueLocation;
    }

    public virtual Font getValueFont()
    {
      return this.valueFont;
    }

    public virtual Paint getValuePaint()
    {
      return this.valuePaint;
    }

    public virtual Paint getMercuryPaint()
    {
      return this.mercuryPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 223, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMercuryPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.mercuryPaint = paint;
        this.fireChangeEvent();
      }
    }

    [Obsolete]
    public virtual bool getShowValueLines()
    {
      return this.showValueLines;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 85, (byte) 110, (byte) 169})]
    public virtual Paint getSubrangePaint(int range)
    {
      if (range >= 0 && range < this.subrangePaint.Length)
        return this.subrangePaint[range];
      else
        return this.mercuryPaint;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 103, (byte) 145, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubrangePaint(int range, Paint paint)
    {
      if (range < 0 || range >= this.subrangePaint.Length || paint == null)
        return;
      this.subrangePaint[range] = paint;
      this.fireChangeEvent();
    }

    public virtual bool getFollowDataInSubranges()
    {
      return this.followDataInSubranges;
    }

    public virtual bool getUseSubrangePaint()
    {
      return this.useSubrangePaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 140, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseSubrangePaint(bool flag)
    {
      this.useSubrangePaint = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 177, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBulbRadius(int r)
    {
      this.bulbRadius = r;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 217, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setColumnRadius(int r)
    {
      this.columnRadius = r;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 3, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGap(int gap)
    {
      this.gap = gap;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 21, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 98, (byte) 98, (byte) 100, (byte) 200, (byte) 104, (byte) 104, (byte) 168, (byte) 109, (byte) 109, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 118, (byte) 118, (byte) 191, (byte) 2, (byte) 191, (byte) 2, (byte) 223, (byte) 26, (byte) 104, (byte) 104, (byte) 137, (byte) 223, (byte) 35, (byte) 255, (byte) 77, (byte) 70, (byte) 105, (byte) 104, (byte) 137, (byte) 123, (byte) 115, (byte) 183, (byte) 113, (byte) 111, (byte) 102, (byte) 106, (byte) 116, (byte) 118, (byte) 168, (byte) 137, (byte) 109, (byte) 159, (byte) 6, (byte) 104, (byte) 169, (byte) 108, (byte) 168, (byte) 107, (byte) 108, (byte) 173, (byte) 108, (byte) 107, (byte) 110, (byte) 151, (byte) 121, (byte) 110, (byte) 200, (byte) 108, (byte) 107, (byte) 110, (byte) 151, (byte) 121, (byte) 110, (byte) 200, (byte) 108, (byte) 107, (byte) 110, (byte) 151, (byte) 121, (byte) 110, (byte) 232, (byte) 69, (byte) 118, (byte) 100, (byte) 104, (byte) 171, (byte) 134, (byte) 151, (byte) 108, (byte) 151, (byte) 152, (byte) 226, (byte) 69, (byte) 108, (byte) 151, (byte) 248, (byte) 72, (byte) 108, (byte) 108, (byte) 104, (byte) 158, (byte) 159, (byte) 6, (byte) 133, (byte) 111, (byte) 107, (byte) 157, (byte) 130, (byte) 111, (byte) 109, (byte) 157, (byte) 226, (byte) 70, (byte) 108, (byte) 172, (byte) 104, (byte) 159, (byte) 9, (byte) 107, (byte) 255, (byte) 10, (byte) 69, (byte) 108, (byte) 104, (byte) 136, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      RoundRectangle2D.Double double1 = new RoundRectangle2D.Double();
      RoundRectangle2D.Double double2 = new RoundRectangle2D.Double();
      RoundRectangle2D.Double double3 = new RoundRectangle2D.Double();
      Ellipse2D.Double double4 = new Ellipse2D.Double();
      Ellipse2D.Double double5 = new Ellipse2D.Double();
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      this.drawBackground(g2, area);
      Rectangle2D area1 = (Rectangle2D) ((RectangularShape) area).clone();
      this.padding.trim(area1);
      int num1 = ByteCodeHelper.d2i(((RectangularShape) area1).getX() + ((RectangularShape) area1).getWidth() / 2.0);
      int num2 = ByteCodeHelper.d2i(((RectangularShape) area1).getY() + ((RectangularShape) area1).getHeight() / 2.0);
      int num3 = ByteCodeHelper.d2i(((RectangularShape) area1).getMinY() + (double) this.getBulbRadius());
      int num4 = ByteCodeHelper.d2i(((RectangularShape) area1).getMaxY() - (double) this.getBulbDiameter());
      Rectangle2D.Double double6 = new Rectangle2D.Double((double) (num1 - this.getColumnRadius()), (double) num3, (double) this.getColumnRadius(), (double) (num4 - num3));
      ((RectangularShape) double4).setFrame((double) (num1 - this.getBulbRadius()), (double) num4, (double) this.getBulbDiameter(), (double) this.getBulbDiameter());
      ((RoundRectangle2D) double1).setRoundRect((double) (num1 - this.getColumnRadius()), ((RectangularShape) area1).getMinY(), (double) this.getColumnDiameter(), (double) (num4 + this.getBulbDiameter() - num3), (double) this.getColumnDiameter(), (double) this.getColumnDiameter());
      Area area2 = new Area((Shape) double4);
      Area area3 = new Area((Shape) double1);
      area2.add(area3);
      ((RectangularShape) double5).setFrame((double) (num1 - this.getBulbRadius() + this.getGap()), (double) (num4 + this.getGap()), (double) (this.getBulbDiameter() - this.getGap() * 2), (double) (this.getBulbDiameter() - this.getGap() * 2));
      ((RoundRectangle2D) double2).setRoundRect((double) (num1 - this.getColumnRadius() + this.getGap()), ((RectangularShape) area1).getMinY() + (double) this.getGap(), (double) (this.getColumnDiameter() - this.getGap() * 2), (double) (num4 + this.getBulbDiameter() - this.getGap() * 2 - num3), (double) (this.getColumnDiameter() - this.getGap() * 2), (double) (this.getColumnDiameter() - this.getGap() * 2));
      Area area4 = new Area((Shape) double5);
      Area area5 = new Area((Shape) double2);
      area4.add(area5);
      if (this.dataset != null && this.dataset.getValue() != null)
      {
        double d1 = this.dataset.getValue().doubleValue();
        double num5 = this.rangeAxis.valueToJava2D(d1, (Rectangle2D) double6, RectangleEdge.__\u003C\u003ELEFT);
        int num6 = this.getColumnDiameter() - this.getGap() * 2;
        int num7 = this.getColumnRadius() - this.getGap();
        int num8 = num6 / 2;
        int num9 = (int) Math.round(num5);
        if ((double) num9 < (double) this.getGap() + ((RectangularShape) area1).getMinY())
        {
          num9 = ByteCodeHelper.d2i((double) this.getGap() + ((RectangularShape) area1).getMinY());
          num8 = this.getBulbRadius();
        }
        Area area6 = new Area((Shape) double5);
        if (num9 < num4 + this.getBulbRadius())
        {
          ((RoundRectangle2D) double3).setRoundRect((double) (num1 - num7), (double) num9, (double) num6, (double) (num4 + this.getBulbRadius() - num9), (double) num8, (double) num8);
          Area area7 = new Area((Shape) double3);
          area6.add(area7);
        }
        g2.setPaint(this.getCurrentPaint());
        g2.fill((Shape) area6);
        if (this.subrangeIndicatorsVisible)
        {
          g2.setStroke(this.subrangeIndicatorStroke);
          Range range = this.rangeAxis.getRange();
          double d2 = this.subrangeInfo[0][0];
          if (range.contains(d2))
          {
            double num10 = (double) (num1 + this.getColumnRadius() + 2);
            double num11 = this.rangeAxis.valueToJava2D(d2, (Rectangle2D) double6, RectangleEdge.__\u003C\u003ELEFT);
            Line2D.Double double7 = new Line2D.Double(num10, num11, num10 + 10.0, num11);
            g2.setPaint(this.subrangePaint[0]);
            g2.draw((Shape) double7);
          }
          double d3 = this.subrangeInfo[1][0];
          if (range.contains(d3))
          {
            double num10 = (double) (num1 + this.getColumnRadius() + 2);
            double num11 = this.rangeAxis.valueToJava2D(d3, (Rectangle2D) double6, RectangleEdge.__\u003C\u003ELEFT);
            Line2D.Double double7 = new Line2D.Double(num10, num11, num10 + 10.0, num11);
            g2.setPaint(this.subrangePaint[1]);
            g2.draw((Shape) double7);
          }
          double d4 = this.subrangeInfo[2][0];
          if (range.contains(d4))
          {
            double num10 = (double) (num1 + this.getColumnRadius() + 2);
            double num11 = this.rangeAxis.valueToJava2D(d4, (Rectangle2D) double6, RectangleEdge.__\u003C\u003ELEFT);
            Line2D.Double double7 = new Line2D.Double(num10, num11, num10 + 10.0, num11);
            g2.setPaint(this.subrangePaint[2]);
            g2.draw((Shape) double7);
          }
        }
        if (this.rangeAxis != null && this.axisLocation != 0)
        {
          int num10 = 10;
          if (this.showValueLines)
            num10 += this.getColumnDiameter();
          int num11 = this.axisLocation;
          int num12 = 1;
          if (num11 == num12)
          {
            double d2 = (double) (num1 + this.getColumnRadius());
            Rectangle2D.Double double7 = new Rectangle2D.Double(d2, (double) num3, (double) num10, (double) (num4 - num3 + 1));
            this.rangeAxis.draw(g2, d2, area, (Rectangle2D) double7, RectangleEdge.__\u003C\u003ERIGHT, (PlotRenderingInfo) null);
          }
          else
          {
            int num13 = 2;
            if (num11 != num13)
              ;
            double d2 = (double) (num1 - this.getColumnRadius());
            Rectangle2D.Double double7 = new Rectangle2D.Double(d2, (double) num3, (double) num10, (double) (num4 - num3 + 1));
            this.rangeAxis.draw(g2, d2, area, (Rectangle2D) double7, RectangleEdge.__\u003C\u003ELEFT, (PlotRenderingInfo) null);
          }
        }
        ((Graphics) g2).setFont(this.valueFont);
        g2.setPaint(this.valuePaint);
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics();
        switch (this.valueLocation)
        {
          case 1:
            g2.drawString(this.valueFormat.format(d1), num1 + this.getColumnRadius() + this.getGap(), num2);
            break;
          case 2:
            string str1 = this.valueFormat.format(d1);
            int num14 = fontMetrics.stringWidth(str1);
            g2.drawString(str1, num1 - this.getColumnRadius() - this.getGap() - num14, num2);
            break;
          case 3:
            string str2 = this.valueFormat.format(d1);
            int num15 = fontMetrics.stringWidth(str2) / 2;
            g2.drawString(str2, num1 - num15, num4 + this.getBulbRadius() + this.getGap());
            break;
        }
      }
      g2.setPaint(this.thermometerPaint);
      ((Graphics) g2).setFont(this.valueFont);
      FontMetrics fontMetrics1 = ((Graphics) g2).getFontMetrics();
      int num16 = num1 - this.getColumnRadius() - this.getGap() * 2 - fontMetrics1.stringWidth(ThermometerPlot.__\u003C\u003EUNITS[this.units]);
      if ((double) num16 > ((RectangularShape) area).getMinX())
        g2.drawString(ThermometerPlot.__\u003C\u003EUNITS[this.units], num16, ByteCodeHelper.d2i(((RectangularShape) area).getMinY() + 20.0));
      g2.setStroke(this.thermometerStroke);
      g2.draw((Shape) area2);
      g2.draw((Shape) area4);
      this.drawOutline(g2, area);
    }

    public override void zoom(double percent)
    {
    }

    [LineNumberTable((ushort) 1369)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return ThermometerPlot.localizationResources.getString("Thermometer_Plot");
    }

    [Obsolete]
    [LineNumberTable((ushort) 1411)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinimumVerticalDataValue()
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.lowerBound);
    }

    [Obsolete]
    [LineNumberTable((ushort) 1425)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaximumVerticalDataValue()
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.upperBound);
    }

    [LineNumberTable((ushort) 1436)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDataRange(ValueAxis axis)
    {
      return new Range(this.lowerBound, this.upperBound);
    }

    public override LegendItemCollection getLegendItems()
    {
      return (LegendItemCollection) null;
    }

    [LineNumberTable((ushort) 1468)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PlotOrientation getOrientation()
    {
      return PlotOrientation.__\u003C\u003EVERTICAL;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 135, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 105, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 108, (byte) 151, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ThermometerPlot))
        return false;
      ThermometerPlot thermometerPlot = (ThermometerPlot) obj;
      if (!base.equals(obj) || !ObjectUtilities.equal((object) this.rangeAxis, (object) thermometerPlot.rangeAxis) || (this.axisLocation != thermometerPlot.axisLocation || this.lowerBound != thermometerPlot.lowerBound) || (this.upperBound != thermometerPlot.upperBound || !ObjectUtilities.equal((object) this.padding, (object) thermometerPlot.padding) || (!ObjectUtilities.equal((object) this.thermometerStroke, (object) thermometerPlot.thermometerStroke) || !PaintUtilities.equal(this.thermometerPaint, thermometerPlot.thermometerPaint))) || (this.units != thermometerPlot.units || this.valueLocation != thermometerPlot.valueLocation || (!ObjectUtilities.equal((object) this.valueFont, (object) thermometerPlot.valueFont) || !PaintUtilities.equal(this.valuePaint, thermometerPlot.valuePaint)) || (!ObjectUtilities.equal((object) this.valueFormat, (object) thermometerPlot.valueFormat) || !PaintUtilities.equal(this.mercuryPaint, thermometerPlot.mercuryPaint) || (this.showValueLines != thermometerPlot.showValueLines || this.subrange != thermometerPlot.subrange))) || (this.followDataInSubranges != thermometerPlot.followDataInSubranges || !ThermometerPlot.equal(this.subrangeInfo, thermometerPlot.subrangeInfo) || (this.useSubrangePaint != thermometerPlot.useSubrangePaint || this.bulbRadius != thermometerPlot.bulbRadius) || (this.columnRadius != thermometerPlot.columnRadius || this.gap != thermometerPlot.gap)))
        return false;
      for (int index = 0; index < this.subrangePaint.Length; ++index)
      {
        if (!PaintUtilities.equal(this.subrangePaint[index], thermometerPlot.subrangePaint[index]))
          return false;
      }
      return true;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 254, (byte) 140, (byte) 104, (byte) 140, (byte) 118, (byte) 104, (byte) 108, (byte) 140, (byte) 118, (byte) 155})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      ThermometerPlot thermometerPlot = (ThermometerPlot) base.clone();
      if (thermometerPlot.dataset != null)
        thermometerPlot.dataset.addChangeListener((DatasetChangeListener) thermometerPlot);
      thermometerPlot.rangeAxis = (ValueAxis) ObjectUtilities.clone((object) this.rangeAxis);
      if (thermometerPlot.rangeAxis != null)
      {
        thermometerPlot.rangeAxis.setPlot((Plot) thermometerPlot);
        thermometerPlot.rangeAxis.addChangeListener((AxisChangeListener) thermometerPlot);
      }
      thermometerPlot.valueFormat = (NumberFormat) this.valueFormat.clone();
      thermometerPlot.subrangePaint = (Paint[]) this.subrangePaint.Clone();
      return (object) thermometerPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 23, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 46, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.thermometerStroke, obj0);
      SerialUtilities.writePaint(this.thermometerPaint, obj0);
      SerialUtilities.writePaint(this.valuePaint, obj0);
      SerialUtilities.writePaint(this.mercuryPaint, obj0);
      SerialUtilities.writeStroke(this.subrangeIndicatorStroke, obj0);
      SerialUtilities.writeStroke(this.rangeIndicatorStroke, obj0);
      for (int index = 0; index < 3; ++index)
        SerialUtilities.writePaint(this.subrangePaint[index], obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 45, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 46, (byte) 166, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.thermometerStroke = SerialUtilities.readStroke(obj0);
      this.thermometerPaint = SerialUtilities.readPaint(obj0);
      this.valuePaint = SerialUtilities.readPaint(obj0);
      this.mercuryPaint = SerialUtilities.readPaint(obj0);
      this.subrangeIndicatorStroke = SerialUtilities.readStroke(obj0);
      this.rangeIndicatorStroke = SerialUtilities.readStroke(obj0);
      this.subrangePaint = new Paint[3];
      for (int index = 0; index < 3; ++index)
        this.subrangePaint[index] = SerialUtilities.readPaint(obj0);
      if (this.rangeAxis == null)
        return;
      this.rangeAxis.addChangeListener((AxisChangeListener) this);
    }

    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo state, Point2D source)
    {
    }

    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo state, Point2D source, bool useAnchor)
    {
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 98, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo state, Point2D source)
    {
      this.rangeAxis.resizeRange(factor);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 114, (byte) 158, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo state, Point2D source, bool useAnchor)
    {
      double anchorValue = this.getRangeAxis().java2DToValue(source.getY(), state.getDataArea(), RectangleEdge.__\u003C\u003ELEFT);
      this.rangeAxis.resizeRange(factor, anchorValue);
    }

    public virtual void zoomDomainAxes(double lowerPercent, double upperPercent, PlotRenderingInfo state, Point2D source)
    {
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 142, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double lowerPercent, double upperPercent, PlotRenderingInfo state, Point2D source)
    {
      this.rangeAxis.zoomRange(lowerPercent, upperPercent);
    }

    public virtual bool isDomainZoomable()
    {
      return false;
    }

    public virtual bool isRangeZoomable()
    {
      return true;
    }
  }
}
