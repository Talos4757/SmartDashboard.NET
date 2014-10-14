// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.MeterPlot
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
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable", "java.lang.Cloneable"})]
  [Serializable]
  public class MeterPlot : Plot, Serializable.__Interface, Cloneable.__Interface
  {
    private const long serialVersionUID = 2987472457734470962L;
    [Modifiers]
    internal static Paint DEFAULT_DIAL_BACKGROUND_PAINT;
    [Modifiers]
    internal static Paint DEFAULT_NEEDLE_PAINT;
    [Modifiers]
    internal static Font DEFAULT_VALUE_FONT;
    [Modifiers]
    internal static Paint DEFAULT_VALUE_PAINT;
    public const int DEFAULT_METER_ANGLE = 270;
    public const float DEFAULT_BORDER_SIZE = 3f;
    public const float DEFAULT_CIRCLE_SIZE = 10f;
    internal static Font __\u003C\u003EDEFAULT_LABEL_FONT;
    private ValueDataset dataset;
    private DialShape shape;
    private int meterAngle;
    private Range range;
    private double tickSize;
    [NonSerialized]
    private Paint tickPaint;
    private string units;
    private Font valueFont;
    [NonSerialized]
    private Paint valuePaint;
    private bool drawBorder;
    [NonSerialized]
    private Paint dialOutlinePaint;
    [NonSerialized]
    private Paint dialBackgroundPaint;
    [NonSerialized]
    private Paint needlePaint;
    private bool tickLabelsVisible;
    private Font tickLabelFont;
    [NonSerialized]
    private Paint tickLabelPaint;
    private NumberFormat tickLabelFormat;
    protected internal static ResourceBundle localizationResources;
    private List intervals;

    [Modifiers]
    public static Font DEFAULT_LABEL_FONT
    {
      [HideFromJava] get
      {
        return MeterPlot.__\u003C\u003EDEFAULT_LABEL_FONT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 107, (byte) 69, (byte) 170, (byte) 170, (byte) 178, (byte) 234, (byte) 76, (byte) 242, (byte) 119})]
    static MeterPlot()
    {
      Plot.__\u003Cclinit\u003E();
      MeterPlot.DEFAULT_DIAL_BACKGROUND_PAINT = (Paint) Color.black;
      MeterPlot.DEFAULT_NEEDLE_PAINT = (Paint) Color.green;
      MeterPlot.DEFAULT_VALUE_FONT = new Font("SansSerif", 1, 12);
      MeterPlot.DEFAULT_VALUE_PAINT = (Paint) Color.yellow;
      MeterPlot.__\u003C\u003EDEFAULT_LABEL_FONT = new Font("SansSerif", 1, 10);
      MeterPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 104, (byte) 107, (byte) 107, (byte) 121, (byte) 112, (byte) 107, (byte) 107, (byte) 107, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeterPlot(ValueDataset dataset)
    {
      MeterPlot meterPlot = this;
      this.shape = DialShape.__\u003C\u003ECIRCLE;
      this.meterAngle = 270;
      this.range = new Range(0.0, 100.0);
      this.tickSize = 10.0;
      this.tickPaint = (Paint) Color.white;
      this.units = "Units";
      this.needlePaint = MeterPlot.DEFAULT_NEEDLE_PAINT;
      this.tickLabelsVisible = true;
      this.tickLabelFont = MeterPlot.__\u003C\u003EDEFAULT_LABEL_FONT;
      this.tickLabelPaint = (Paint) Color.black;
      this.tickLabelFormat = NumberFormat.getInstance();
      this.valueFont = MeterPlot.DEFAULT_VALUE_FONT;
      this.valuePaint = MeterPlot.DEFAULT_VALUE_PAINT;
      this.dialBackgroundPaint = MeterPlot.DEFAULT_DIAL_BACKGROUND_PAINT;
      this.intervals = (List) new ArrayList();
      this.setDataset(dataset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeterPlot()
      : this((ValueDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MeterPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MeterPlot obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] MeterPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 222, (byte) 99, (byte) 144, (byte) 109, (byte) 176, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRange(Range range)
    {
      if (range == null)
      {
        string str = "Null 'range' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (range.getLength() <= 0.0)
      {
        string str = "Range length must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.range = range;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 253, (byte) 105, (byte) 144, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickSize(double size)
    {
      if (size <= 0.0)
      {
        string str = "Requires 'size' > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickSize = size;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 12, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDialBackgroundPaint(Paint paint)
    {
      this.dialBackgroundPaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 214, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.valueFont = font;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 241, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
        this.valuePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 63, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDialOutlinePaint(Paint paint)
    {
      this.dialOutlinePaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNeedlePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.needlePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.tickLabelFont.equals((object) font))
          return;
        this.tickLabelFont = font;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 158, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (Object.instancehelper_equals((object) this.tickLabelPaint, (object) paint))
          return;
        this.tickLabelPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 90, (byte) 103, (byte) 99, (byte) 199, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 104, (byte) 137})]
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

    public virtual ValueDataset getDataset()
    {
      return this.dataset;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 146, (byte) 163, (byte) 100, (byte) 144, (byte) 107, (byte) 106, (byte) 133, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 112, (byte) 165, (byte) 165, (byte) 109, (byte) 99, (byte) 99, (byte) 204, (byte) 176, (byte) 104, (byte) 147, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fillArc(Graphics2D g2, Rectangle2D area, double minValue, double maxValue, Paint paint, bool dial)
    {
      int num1 = dial ? 1 : 0;
      if (paint == null)
      {
        string str = "Null 'paint' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num2 = this.valueToAngle(maxValue);
        double num3 = this.valueToAngle(minValue) - num2;
        double x = ((RectangularShape) area).getX();
        double y = ((RectangularShape) area).getY();
        double width = ((RectangularShape) area).getWidth();
        double height = ((RectangularShape) area).getHeight();
        int num4;
        if (this.shape == DialShape.__\u003C\u003EPIE)
          num4 = 2;
        else if (this.shape == DialShape.__\u003C\u003ECHORD)
          num4 = num1 == 0 || this.meterAngle <= 180 ? 2 : 1;
        else if (this.shape == DialShape.__\u003C\u003ECIRCLE)
        {
          num4 = 2;
          if (num1 != 0)
            num3 = 360.0;
        }
        else
        {
          string str = "DialShape not recognised.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalStateException(str);
        }
        g2.setPaint(paint);
        Arc2D.Double @double = new Arc2D.Double(x, y, width, height, num2, num3, num4);
        g2.fill((Shape) @double);
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 191, (byte) 105, (byte) 41, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTicks(Graphics2D g2, Rectangle2D meterArea, double minValue, double maxValue)
    {
      double num = minValue;
      while (num <= maxValue)
      {
        this.drawTick(g2, meterArea, num);
        num += this.tickSize;
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 62, (byte) 109, (byte) 109, (byte) 103, (byte) 103, (byte) 136, (byte) 100, (byte) 141, (byte) 99, (byte) 99, (byte) 172, (byte) 106, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawArcForInterval(Graphics2D g2, Rectangle2D meterArea, MeterInterval interval)
    {
      double lowerBound = interval.getRange().getLowerBound();
      double upperBound = interval.getRange().getUpperBound();
      Paint outlinePaint = interval.getOutlinePaint();
      Stroke outlineStroke = interval.getOutlineStroke();
      Paint backgroundPaint = interval.getBackgroundPaint();
      if (backgroundPaint != null)
        this.fillArc(g2, meterArea, lowerBound, upperBound, backgroundPaint, false);
      if (outlinePaint == null)
        return;
      if (outlineStroke != null)
        this.drawArc(g2, meterArea, lowerBound, upperBound, outlinePaint, outlineStroke);
      this.drawTick(g2, meterArea, lowerBound, true);
      this.drawTick(g2, meterArea, upperBound, true);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 27, (byte) 108, (byte) 108, (byte) 102, (byte) 104, (byte) 108, (byte) 99, (byte) 223, (byte) 23, (byte) 104, (byte) 111, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawValueLabel(Graphics2D g2, Rectangle2D area)
    {
      ((Graphics) g2).setFont(this.valueFont);
      g2.setPaint(this.valuePaint);
      string text = "No value";
      if (this.dataset != null)
      {
        Number number = this.dataset.getValue();
        if (number != null)
          text = new StringBuffer().append(this.tickLabelFormat.format(number.doubleValue())).append(" ").append(this.units).toString();
      }
      float x = (float) ((RectangularShape) area).getCenterX();
      float y = (float) ((RectangularShape) area).getCenterY() + 10f;
      TextUtilities.drawAlignedString(text, g2, x, y, TextAnchor.__\u003C\u003ETOP_CENTER);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 176, (byte) 113, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double valueToAngle(double value)
    {
      value -= this.range.getLowerBound();
      return (double) (180 + (this.meterAngle - 180) / 2) - value / this.range.getLength() * (double) this.meterAngle;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 94, (byte) 107, (byte) 106, (byte) 133, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 104, (byte) 136, (byte) 104, (byte) 145, (byte) 104, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawArc(Graphics2D g2, Rectangle2D area, double minValue, double maxValue, Paint paint, Stroke stroke)
    {
      double num1 = this.valueToAngle(maxValue);
      double num2 = this.valueToAngle(minValue) - num1;
      double x = ((RectangularShape) area).getX();
      double y = ((RectangularShape) area).getY();
      double width = ((RectangularShape) area).getWidth();
      double height = ((RectangularShape) area).getHeight();
      g2.setPaint(paint);
      g2.setStroke(stroke);
      if (paint == null || stroke == null)
        return;
      Arc2D.Double @double = new Arc2D.Double(x, y, width, height, num1, num2, 0);
      g2.setPaint(paint);
      g2.setStroke(stroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 123, (byte) 99, (byte) 138, (byte) 104, (byte) 136, (byte) 108, (byte) 144, (byte) 102, (byte) 134, (byte) 125, (byte) 143, (byte) 159, (byte) 3, (byte) 191, (byte) 3, (byte) 159, (byte) 3, (byte) 191, (byte) 3, (byte) 143, (byte) 136, (byte) 145, (byte) 111, (byte) 108, (byte) 140, (byte) 104, (byte) 172, (byte) 100, (byte) 100, (byte) 120, (byte) 153, (byte) 120, (byte) 141, (byte) 159, (byte) 17, (byte) 185, (byte) 151, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTick(Graphics2D g2, Rectangle2D meterArea, double value, bool label)
    {
      int num1 = label ? 1 : 0;
      double num2 = this.valueToAngle(value);
      double centerX = ((RectangularShape) meterArea).getCenterX();
      double centerY = ((RectangularShape) meterArea).getCenterY();
      g2.setPaint(this.tickPaint);
      g2.setStroke((Stroke) new BasicStroke(2f));
      double num3 = ((RectangularShape) meterArea).getWidth() / 2.0 + 3.0;
      double num4 = num3 - 15.0;
      double num5 = centerX + num3 * Math.cos(Math.PI * (num2 / 180.0));
      double num6 = centerY - num3 * Math.sin(Math.PI * (num2 / 180.0));
      double num7 = centerX + num4 * Math.cos(Math.PI * (num2 / 180.0));
      double num8 = centerY - num4 * Math.sin(Math.PI * (num2 / 180.0));
      Line2D.Double @double = new Line2D.Double(num5, num6, num7, num8);
      g2.draw((Shape) @double);
      if (!this.tickLabelsVisible || num1 == 0)
        return;
      string text = this.tickLabelFormat.format(value);
      ((Graphics) g2).setFont(this.tickLabelFont);
      g2.setPaint(this.tickLabelPaint);
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics();
      Rectangle2D textBounds = TextUtilities.getTextBounds(text, g2, fontMetrics);
      double num9 = num7;
      double num10 = num8;
      if (num2 == 90.0 || num2 == 270.0)
        num9 -= ((RectangularShape) textBounds).getWidth() / 2.0;
      else if (num2 < 90.0 || num2 > 270.0)
        num9 -= ((RectangularShape) textBounds).getWidth();
      double num11 = num2 > 135.0 && num2 < 225.0 || (num2 > 315.0 || num2 < 45.0) ? num10 - ((RectangularShape) textBounds).getHeight() / 2.0 : num10 + ((RectangularShape) textBounds).getHeight() / 2.0;
      g2.drawString(text, (float) num9, (float) num11);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 205, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTick(Graphics2D g2, Rectangle2D meterArea, double value)
    {
      this.drawTick(g2, meterArea, value, false);
    }

    public virtual DialShape getDialShape()
    {
      return this.shape;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDialShape(DialShape shape)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.shape = shape;
        this.fireChangeEvent();
      }
    }

    public virtual int getMeterAngle()
    {
      return this.meterAngle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 108, (byte) 191, (byte) 16, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMeterAngle(int angle)
    {
      if (angle < 1 || angle > 360)
      {
        string str = new StringBuffer().append("Invalid 'angle' (").append(angle).append(")").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.meterAngle = angle;
        this.fireChangeEvent();
      }
    }

    public virtual Range getRange()
    {
      return this.range;
    }

    public virtual double getTickSize()
    {
      return this.tickSize;
    }

    public virtual Paint getTickPaint()
    {
      return this.tickPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual string getUnits()
    {
      return this.units;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 52, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUnits(string units)
    {
      this.units = units;
      this.fireChangeEvent();
    }

    public virtual Paint getNeedlePaint()
    {
      return this.needlePaint;
    }

    public virtual bool getTickLabelsVisible()
    {
      return this.tickLabelsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 24, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelsVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.tickLabelsVisible ? 1 : 0) == num)
        return;
      this.tickLabelsVisible = num != 0;
      this.fireChangeEvent();
    }

    public virtual Font getTickLabelFont()
    {
      return this.tickLabelFont;
    }

    public virtual Paint getTickLabelPaint()
    {
      return this.tickLabelPaint;
    }

    public virtual NumberFormat getTickLabelFormat()
    {
      return this.tickLabelFormat;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 187, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFormat(NumberFormat format)
    {
      if (format == null)
      {
        string str = "Null 'format' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.tickLabelFormat = format;
        this.fireChangeEvent();
      }
    }

    public virtual Font getValueFont()
    {
      return this.valueFont;
    }

    public virtual Paint getValuePaint()
    {
      return this.valuePaint;
    }

    public virtual Paint getDialBackgroundPaint()
    {
      return this.dialBackgroundPaint;
    }

    public virtual bool getDrawBorder()
    {
      return this.drawBorder;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 232, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawBorder(bool draw)
    {
      this.drawBorder = draw;
      this.fireChangeEvent();
    }

    public virtual Paint getDialOutlinePaint()
    {
      return this.dialOutlinePaint;
    }

    [LineNumberTable((ushort) 742)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getIntervals()
    {
      return Collections.unmodifiableList(this.intervals);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 129, (byte) 99, (byte) 144, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addInterval(MeterInterval interval)
    {
      if (interval == null)
      {
        string str = "Null 'interval' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.intervals.add((object) interval);
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 143, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearIntervals()
    {
      this.intervals.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 153, (byte) 102, (byte) 108, (byte) 107, (byte) 108, (byte) 103, (byte) 99, (byte) 135, (byte) 191, (byte) 37, (byte) 109, (byte) 104, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection = new LegendItemCollection();
      Iterator iterator = this.intervals.iterator();
      while (iterator.hasNext())
      {
        MeterInterval meterInterval = (MeterInterval) iterator.next();
        Paint fillPaint = meterInterval.getBackgroundPaint() ?? meterInterval.getOutlinePaint();
        LegendItem.__\u003Cclinit\u003E();
        LegendItem legendItem = new LegendItem(meterInterval.getLabel(), meterInterval.getLabel(), (string) null, (string) null, (Shape) new Rectangle2D.Double(-4.0, -4.0, 8.0, 8.0), fillPaint);
        legendItem.setDataset((Dataset) this.getDataset());
        legendItemCollection.add(legendItem);
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 184, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 223, (byte) 39, (byte) 104, (byte) 200, (byte) 106, (byte) 106, (byte) 116, (byte) 117, (byte) 107, (byte) 223, (byte) 30, (byte) 118, (byte) 117, (byte) 120, (byte) 111, (byte) 143, (byte) 174, (byte) 223, (byte) 44, (byte) 106, (byte) 170, (byte) 104, (byte) 103, (byte) 110, (byte) 142, (byte) 104, (byte) 104, (byte) 104, (byte) 178, (byte) 104, (byte) 180, (byte) 109, (byte) 191, (byte) 11, (byte) 109, (byte) 105, (byte) 110, (byte) 107, (byte) 130, (byte) 105, (byte) 103, (byte) 106, (byte) 137, (byte) 114, (byte) 108, (byte) 144, (byte) 159, (byte) 9, (byte) 107, (byte) 159, (byte) 5, (byte) 191, (byte) 5, (byte) 103, (byte) 191, (byte) 21, (byte) 143, (byte) 143, (byte) 117, (byte) 149, (byte) 130, (byte) 159, (byte) 0, (byte) 191, (byte) 0, (byte) 117, (byte) 136, (byte) 223, (byte) 18, (byte) 200, (byte) 104, (byte) 168, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      area.setRect(((RectangularShape) area).getX() + 4.0, ((RectangularShape) area).getY() + 4.0, ((RectangularShape) area).getWidth() - 8.0, ((RectangularShape) area).getHeight() - 8.0);
      if (this.drawBorder)
        this.drawBackground(g2, area);
      double num1 = 6.0;
      double num2 = 6.0;
      double num3 = ((RectangularShape) area).getX() + num1 / 2.0;
      double num4 = ((RectangularShape) area).getY() + num2 / 2.0;
      double num5 = ((RectangularShape) area).getWidth() - num1;
      double num6 = ((RectangularShape) area).getHeight() - num2 + (this.meterAngle > 180 || this.shape == DialShape.__\u003C\u003ECIRCLE ? 0.0 : ((RectangularShape) area).getHeight() / 1.25);
      double num7 = Math.min(num5, num6) / 2.0;
      Rectangle2D.Double double1 = new Rectangle2D.Double((num3 + num3 + num5) / 2.0 - num7, (num4 + num4 + num6) / 2.0 - num7, 2.0 * num7, 2.0 * num7);
      Rectangle2D.Double double2 = new Rectangle2D.Double(((RectangularShape) double1).getX() - 4.0, ((RectangularShape) double1).getY() - 4.0, ((RectangularShape) double1).getWidth() + 8.0, ((RectangularShape) double1).getHeight() + 8.0);
      double centerX = ((RectangularShape) double1).getCenterX();
      double centerY = ((RectangularShape) double1).getCenterY();
      ValueDataset dataset = this.getDataset();
      if (dataset != null)
      {
        double lowerBound = this.range.getLowerBound();
        double upperBound = this.range.getUpperBound();
        Shape clip = ((Graphics) g2).getClip();
        g2.clip((Shape) double2);
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
        if (this.dialBackgroundPaint != null)
          this.fillArc(g2, (Rectangle2D) double2, lowerBound, upperBound, this.dialBackgroundPaint, true);
        this.drawTicks(g2, (Rectangle2D) double1, lowerBound, upperBound);
        this.drawArcForInterval(g2, (Rectangle2D) double1, new MeterInterval("", this.range, this.dialOutlinePaint, (Stroke) new BasicStroke(1f), (Paint) null));
        Iterator iterator = this.intervals.iterator();
        while (iterator.hasNext())
        {
          MeterInterval interval = (MeterInterval) iterator.next();
          this.drawArcForInterval(g2, (Rectangle2D) double1, interval);
        }
        Number number = dataset.getValue();
        if (number != null)
        {
          double num8 = number.doubleValue();
          this.drawValueLabel(g2, (Rectangle2D) double1);
          if (this.range.contains(num8))
          {
            g2.setPaint(this.needlePaint);
            g2.setStroke((Stroke) new BasicStroke(2f));
            double num9 = ((RectangularShape) double1).getWidth() / 2.0 + 3.0 + 15.0;
            double num10 = this.valueToAngle(num8);
            double num11 = centerX + num9 * Math.cos(Math.PI * (num10 / 180.0));
            double num12 = centerY - num9 * Math.sin(Math.PI * (num10 / 180.0));
            Polygon polygon = new Polygon();
            if (num10 > 135.0 && num10 < 225.0 || num10 < 45.0 && num10 > -45.0)
            {
              double num13 = centerY - 2.5;
              double num14 = centerY + 2.5;
              polygon.addPoint(ByteCodeHelper.d2i(centerX), ByteCodeHelper.d2i(num13));
              polygon.addPoint(ByteCodeHelper.d2i(centerX), ByteCodeHelper.d2i(num14));
            }
            else
            {
              polygon.addPoint(ByteCodeHelper.d2i(centerX - 2.5), ByteCodeHelper.d2i(centerY));
              polygon.addPoint(ByteCodeHelper.d2i(centerX + 2.5), ByteCodeHelper.d2i(centerY));
            }
            polygon.addPoint(ByteCodeHelper.d2i(num11), ByteCodeHelper.d2i(num12));
            g2.fill((Shape) polygon);
            Ellipse2D.Double double3 = new Ellipse2D.Double(centerX - 5.0, centerY - 5.0, 10.0, 10.0);
            g2.fill((Shape) double3);
          }
        }
        ((Graphics) g2).setClip(clip);
        g2.setComposite(composite);
      }
      if (!this.drawBorder)
        return;
      this.drawOutline(g2, area);
    }

    [LineNumberTable((ushort) 1187)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return MeterPlot.localizationResources.getString("Meter_Plot");
    }

    public override void zoom(double percent)
    {
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 72, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MeterPlot) || !base.equals(obj))
        return false;
      MeterPlot meterPlot = (MeterPlot) obj;
      return ObjectUtilities.equal((object) this.units, (object) meterPlot.units) && ObjectUtilities.equal((object) this.range, (object) meterPlot.range) && (ObjectUtilities.equal((object) this.intervals, (object) meterPlot.intervals) && PaintUtilities.equal(this.dialOutlinePaint, meterPlot.dialOutlinePaint)) && (this.shape == meterPlot.shape && PaintUtilities.equal(this.dialBackgroundPaint, meterPlot.dialBackgroundPaint) && (PaintUtilities.equal(this.needlePaint, meterPlot.needlePaint) && ObjectUtilities.equal((object) this.valueFont, (object) meterPlot.valueFont))) && (PaintUtilities.equal(this.valuePaint, meterPlot.valuePaint) && PaintUtilities.equal(this.tickPaint, meterPlot.tickPaint) && (this.tickSize == meterPlot.tickSize && this.tickLabelsVisible == meterPlot.tickLabelsVisible) && (ObjectUtilities.equal((object) this.tickLabelFont, (object) meterPlot.tickLabelFont) && PaintUtilities.equal(this.tickLabelPaint, meterPlot.tickLabelPaint) && (ObjectUtilities.equal((object) this.tickLabelFormat, (object) meterPlot.tickLabelFormat) && this.drawBorder == meterPlot.drawBorder))) && this.meterAngle == meterPlot.meterAngle;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 147, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.dialBackgroundPaint, obj0);
      SerialUtilities.writePaint(this.dialOutlinePaint, obj0);
      SerialUtilities.writePaint(this.needlePaint, obj0);
      SerialUtilities.writePaint(this.valuePaint, obj0);
      SerialUtilities.writePaint(this.tickPaint, obj0);
      SerialUtilities.writePaint(this.tickLabelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 166, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.dialBackgroundPaint = SerialUtilities.readPaint(obj0);
      this.dialOutlinePaint = SerialUtilities.readPaint(obj0);
      this.needlePaint = SerialUtilities.readPaint(obj0);
      this.valuePaint = SerialUtilities.readPaint(obj0);
      this.tickPaint = SerialUtilities.readPaint(obj0);
      this.tickLabelPaint = SerialUtilities.readPaint(obj0);
      if (this.dataset == null)
        return;
      this.dataset.addChangeListener((DatasetChangeListener) this);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 189, (byte) 108, (byte) 150, (byte) 113, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      MeterPlot meterPlot = (MeterPlot) base.clone();
      meterPlot.tickLabelFormat = (NumberFormat) this.tickLabelFormat.clone();
      meterPlot.intervals = (List) new ArrayList((Collection) this.intervals);
      if (meterPlot.dataset != null)
        meterPlot.dataset.addChangeListener((DatasetChangeListener) meterPlot);
      return (object) meterPlot;
    }
  }
}
