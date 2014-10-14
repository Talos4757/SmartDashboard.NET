// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CompassPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.needle;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CompassPlot : Plot, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 6924382802125527395L;
    internal static Font __\u003C\u003EDEFAULT_LABEL_FONT;
    public const int NO_LABELS = 0;
    public const int VALUE_LABELS = 1;
    private int labelType;
    private Font labelFont;
    private bool drawBorder;
    [NonSerialized]
    private Paint roseHighlightPaint;
    [NonSerialized]
    private Paint rosePaint;
    [NonSerialized]
    private Paint roseCenterPaint;
    private Font compassFont;
    [NonSerialized]
    private Ellipse2D circle1;
    [NonSerialized]
    private Ellipse2D circle2;
    [NonSerialized]
    private Area a1;
    [NonSerialized]
    private Area a2;
    [NonSerialized]
    private Rectangle2D rect1;
    private ValueDataset[] datasets;
    private MeterNeedle[] seriesNeedle;
    protected internal static ResourceBundle localizationResources;
    protected internal double revolutionDistance;

    [Modifiers]
    public static Font DEFAULT_LABEL_FONT
    {
      [HideFromJava] get
      {
        return CompassPlot.__\u003C\u003EDEFAULT_LABEL_FONT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 114, (byte) 165, (byte) 242, (byte) 116})]
    static CompassPlot()
    {
      Plot.__\u003Cclinit\u003E();
      CompassPlot.__\u003C\u003EDEFAULT_LABEL_FONT = new Font("SansSerif", 1, 10);
      CompassPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 232, (byte) 5, (byte) 167, (byte) 171, (byte) 171, (byte) 171, (byte) 243, (byte) 82, (byte) 172, (byte) 236, (byte) 75, (byte) 240, (byte) 80, (byte) 99, (byte) 105, (byte) 135, (byte) 107, (byte) 107, (byte) 107, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompassPlot(ValueDataset dataset)
    {
      CompassPlot compassPlot = this;
      this.drawBorder = false;
      this.roseHighlightPaint = (Paint) Color.black;
      this.rosePaint = (Paint) Color.yellow;
      this.roseCenterPaint = (Paint) Color.white;
      this.compassFont = new Font("Arial", 0, 10);
      this.datasets = new ValueDataset[1];
      this.seriesNeedle = new MeterNeedle[1];
      this.revolutionDistance = 360.0;
      if (dataset != null)
      {
        this.datasets[0] = dataset;
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.circle1 = (Ellipse2D) new Ellipse2D.Double();
      this.circle2 = (Ellipse2D) new Ellipse2D.Double();
      this.rect1 = (Rectangle2D) new Rectangle2D.Double();
      this.setSeriesNeedle(0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompassPlot()
      : this((ValueDataset) new DefaultValueDataset())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CompassPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CompassPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CompassPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesNeedle(int type)
    {
      this.setSeriesNeedle(0, type);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 110, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPaint(int series, Paint paint)
    {
      if (series < 0 || series >= this.seriesNeedle.Length)
        return;
      this.seriesNeedle[series].setFillPaint(paint);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 110, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlinePaint(int series, Paint p)
    {
      if (series < 0 || series >= this.seriesNeedle.Length)
        return;
      this.seriesNeedle[series].setOutlinePaint(p);
    }

    public virtual double getRevolutionDistance()
    {
      return this.revolutionDistance;
    }

    public virtual void setRevolutionDistance(double size)
    {
      if (size <= 0.0)
        return;
      this.revolutionDistance = size;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRosePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rosePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 159, (byte) 20, (byte) 109, (byte) 108, (byte) 114, (byte) 133, (byte) 108, (byte) 133, (byte) 102, (byte) 111, (byte) 104, (byte) 133, (byte) 108, (byte) 133, (byte) 108, (byte) 133, (byte) 108, (byte) 130, (byte) 104, (byte) 113, (byte) 108, (byte) 130, (byte) 108, (byte) 108, (byte) 130, (byte) 109, (byte) 130, (byte) 108, (byte) 162, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesNeedle(int index, int type)
    {
      switch (type)
      {
        case 0:
          this.setSeriesNeedle(index, (MeterNeedle) new ArrowNeedle(true));
          this.setSeriesPaint(index, (Paint) Color.red);
          this.seriesNeedle[index].setHighlightPaint((Paint) Color.white);
          break;
        case 1:
          this.setSeriesNeedle(index, (MeterNeedle) new LineNeedle());
          break;
        case 2:
          LongNeedle longNeedle = new LongNeedle();
          longNeedle.setRotateY(0.5);
          this.setSeriesNeedle(index, (MeterNeedle) longNeedle);
          break;
        case 3:
          this.setSeriesNeedle(index, (MeterNeedle) new PinNeedle());
          break;
        case 4:
          this.setSeriesNeedle(index, (MeterNeedle) new PlumNeedle());
          break;
        case 5:
          this.setSeriesNeedle(index, (MeterNeedle) new PointerNeedle());
          break;
        case 6:
          this.setSeriesPaint(index, (Paint) null);
          this.setSeriesOutlineStroke(index, (Stroke) new BasicStroke(3f));
          this.setSeriesNeedle(index, (MeterNeedle) new ShipNeedle());
          break;
        case 7:
          this.setSeriesPaint(index, (Paint) Color.blue);
          this.setSeriesNeedle(index, (MeterNeedle) new WindNeedle());
          break;
        case 8:
          this.setSeriesNeedle(index, (MeterNeedle) new ArrowNeedle(true));
          break;
        case 9:
          this.setSeriesNeedle(index, (MeterNeedle) new MiddlePinNeedle());
          break;
        default:
          string str = "Unrecognised type.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 109, (byte) 137, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesNeedle(int index, MeterNeedle needle)
    {
      if (needle != null && index < this.seriesNeedle.Length)
        this.seriesNeedle[index] = needle;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 39, (byte) 110, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlineStroke(int series, Stroke stroke)
    {
      if (series < 0 || series >= this.seriesNeedle.Length)
        return;
      this.seriesNeedle[series].setOutlineStroke(stroke);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 165, (byte) 102, (byte) 106, (byte) 103, (byte) 103, (byte) 100, (byte) 100, (byte) 107, (byte) 11, (byte) 198, (byte) 104, (byte) 100, (byte) 142, (byte) 103, (byte) 104, (byte) 103, (byte) 135, (byte) 104, (byte) 100, (byte) 5, (byte) 198, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDataset(ValueDataset dataset, MeterNeedle needle)
    {
      if (dataset == null)
        return;
      int length1 = this.datasets.Length + 1;
      ValueDataset[] valueDatasetArray1 = new ValueDataset[length1];
      MeterNeedle[] meterNeedleArray1 = new MeterNeedle[length1];
      int index1 = length1 - 2;
      while (index1 >= 0)
      {
        valueDatasetArray1[index1] = this.datasets[index1];
        meterNeedleArray1[index1] = this.seriesNeedle[index1];
        index1 += -1;
      }
      int length2 = this.datasets.Length;
      valueDatasetArray1[length2] = dataset;
      meterNeedleArray1[length2] = needle == null ? meterNeedleArray1[length2 - 1] : needle;
      ValueDataset[] valueDatasetArray2 = this.datasets;
      MeterNeedle[] meterNeedleArray2 = this.seriesNeedle;
      this.datasets = valueDatasetArray1;
      this.seriesNeedle = meterNeedleArray1;
      int index2 = length2 - 1;
      while (index2 >= 0)
      {
        valueDatasetArray2[index2] = (ValueDataset) null;
        meterNeedleArray2[index2] = (MeterNeedle) null;
        index2 += -1;
      }
      dataset.addChangeListener((DatasetChangeListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 111, (byte) 106, (byte) 104, (byte) 134, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Font getCompassFont(int radius)
    {
      float num = (float) radius / 10f;
      if ((double) num < 8.0)
        num = 8f;
      return this.compassFont.deriveFont(num);
    }

    public virtual int getLabelType()
    {
      return this.labelType;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 103, (byte) 176, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelType(int type)
    {
      if (type != 0 && type != 1)
      {
        string str = "MeterPlot.setLabelType(int): unrecognised type.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.labelType == type)
          return;
        this.labelType = type;
        this.fireChangeEvent();
      }
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' not allowed.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFont = font;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getRosePaint()
    {
      return this.rosePaint;
    }

    public virtual Paint getRoseCenterPaint()
    {
      return this.roseCenterPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRoseCenterPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.roseCenterPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getRoseHighlightPaint()
    {
      return this.roseHighlightPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRoseHighlightPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.roseHighlightPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual bool getDrawBorder()
    {
      return this.drawBorder;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 51, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawBorder(bool status)
    {
      this.drawBorder = status;
      this.fireChangeEvent();
    }

    public virtual ValueDataset[] getDatasets()
    {
      return this.datasets;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 154, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDataset(ValueDataset dataset)
    {
      this.addDataset(dataset, (MeterNeedle) null);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 205, (byte) 98, (byte) 194, (byte) 100, (byte) 200, (byte) 103, (byte) 167, (byte) 104, (byte) 168, (byte) 118, (byte) 118, (byte) 98, (byte) 100, (byte) 130, (byte) 100, (byte) 133, (byte) 110, (byte) 142, (byte) 121, (byte) 223, (byte) 6, (byte) 108, (byte) 118, (byte) 118, (byte) 113, (byte) 140, (byte) 108, (byte) 103, (byte) 118, (byte) 108, (byte) 112, (byte) 103, (byte) 118, (byte) 103, (byte) 118, (byte) 103, (byte) 150, (byte) 102, (byte) 102, (byte) 111, (byte) 107, (byte) 116, (byte) 116, (byte) 116, (byte) 116, (byte) 238, (byte) 58, (byte) 236, (byte) 73, (byte) 108, (byte) 102, (byte) 99, (byte) 112, (byte) 107, (byte) 116, (byte) 116, (byte) 248, (byte) 60, (byte) 236, (byte) 73, (byte) 111, (byte) 107, (byte) 116, (byte) 148, (byte) 103, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 232, (byte) 54, (byte) 236, (byte) 78, (byte) 102, (byte) 105, (byte) 104, (byte) 122, (byte) 116, (byte) 116, (byte) 186, (byte) 101, (byte) 101, (byte) 187, (byte) 105, (byte) 98, (byte) 102, (byte) 107, (byte) 104, (byte) 139, (byte) 109, (byte) 150, (byte) 118, (byte) 112, (byte) 243, (byte) 56, (byte) 235, (byte) 76, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      if (this.drawBorder)
        this.drawBackground(g2, area);
      int num1 = ByteCodeHelper.d2i(((RectangularShape) area).getWidth() / 2.0);
      int num2 = ByteCodeHelper.d2i(((RectangularShape) area).getHeight() / 2.0);
      int num3 = num1;
      if (num2 < num1)
        num3 = num2;
      int radius = num3 - 1;
      int num4 = 2 * radius;
      int num5 = num1 + ByteCodeHelper.d2i(((RectangularShape) area).getMinX());
      int num6 = num2 + ByteCodeHelper.d2i(((RectangularShape) area).getMinY());
      ((RectangularShape) this.circle1).setFrame((double) (num5 - radius), (double) (num6 - radius), (double) num4, (double) num4);
      ((RectangularShape) this.circle2).setFrame((double) (num5 - radius + 15), (double) (num6 - radius + 15), (double) (num4 - 30), (double) (num4 - 30));
      g2.setPaint(this.rosePaint);
      Area.__\u003Cclinit\u003E();
      this.a1 = new Area((Shape) this.circle1);
      Area.__\u003Cclinit\u003E();
      this.a2 = new Area((Shape) this.circle2);
      this.a1.subtract(this.a2);
      g2.fill((Shape) this.a1);
      g2.setPaint(this.roseCenterPaint);
      int num7 = num4 - 30;
      ((Graphics) g2).fillOval(num5 - radius + 15, num6 - radius + 15, num7, num7);
      g2.setPaint(this.roseHighlightPaint);
      ((Graphics) g2).drawOval(num5 - radius, num6 - radius, num4, num4);
      int num8 = num4 - 20;
      ((Graphics) g2).drawOval(num5 - radius + 10, num6 - radius + 10, num8, num8);
      int num9 = num4 - 30;
      ((Graphics) g2).drawOval(num5 - radius + 15, num6 - radius + 15, num9, num9);
      int num10 = num4 - 80;
      ((Graphics) g2).drawOval(num5 - radius + 40, num6 - radius + 40, num10, num10);
      int num11 = radius - 20;
      int num12 = radius - 32;
      int num13 = 0;
      while (num13 < 360)
      {
        double num14 = Math.toRadians((double) num13);
        int num15 = num5 - ByteCodeHelper.d2i(Math.sin(num14) * (double) num12);
        int num16 = num5 - ByteCodeHelper.d2i(Math.sin(num14) * (double) num11);
        int num17 = num6 - ByteCodeHelper.d2i(Math.cos(num14) * (double) num12);
        int num18 = num6 - ByteCodeHelper.d2i(Math.cos(num14) * (double) num11);
        ((Graphics) g2).drawLine(num15, num17, num16, num18);
        num13 += 15;
      }
      g2.setPaint(this.roseHighlightPaint);
      int num19 = radius - 26;
      int num20 = 7;
      int num21 = 45;
      while (num21 < 360)
      {
        double num14 = Math.toRadians((double) num21);
        int num15 = num5 - ByteCodeHelper.d2i(Math.sin(num14) * (double) num19);
        int num16 = num6 - ByteCodeHelper.d2i(Math.cos(num14) * (double) num19);
        ((Graphics) g2).fillOval(num15 - num20, num16 - num20, 2 * num20, 2 * num20);
        num21 += 90;
      }
      int num22 = 0;
      while (num22 < 360)
      {
        double num14 = Math.toRadians((double) num22);
        int num15 = num5 - ByteCodeHelper.d2i(Math.sin(num14) * (double) num19);
        int num16 = num6 - ByteCodeHelper.d2i(Math.cos(num14) * (double) num19);
        Polygon polygon = new Polygon();
        polygon.addPoint(num15 - num20, num16);
        polygon.addPoint(num15, num16 + num20);
        polygon.addPoint(num15 + num20, num16);
        polygon.addPoint(num15, num16 - num20);
        ((Graphics) g2).fillPolygon(polygon);
        num22 += 90;
      }
      int num23 = radius - 42;
      Font compassFont = this.getCompassFont(radius);
      ((Graphics) g2).setFont(compassFont);
      g2.drawString("N", num5 - 5, num6 - num23 + compassFont.getSize());
      g2.drawString("S", num5 - 5, num6 + num23 - 5);
      g2.drawString("W", num5 - num23 + 5, num6 + 5);
      g2.drawString("E", num5 + num23 - compassFont.getSize(), num6 + 5);
      int num24 = radius / 2;
      int num25 = radius / 6;
      Rectangle2D.Double @double = new Rectangle2D.Double((double) (num5 - num25), (double) (num6 - num24), (double) (2 * num25), (double) (2 * num24));
      int length = this.seriesNeedle.Length;
      int index = this.datasets.Length - 1;
      while (index >= 0)
      {
        ValueDataset valueDataset = this.datasets[index];
        if (valueDataset != null && valueDataset.getValue() != null)
        {
          double angle = valueDataset.getValue().doubleValue() % this.revolutionDistance / this.revolutionDistance * 360.0;
          int num14 = index;
          int num15 = length;
          int num16 = -1;
          this.seriesNeedle[num15 != num16 ? num14 % num15 : 0].draw(g2, (Rectangle2D) @double, angle);
        }
        index += -1;
      }
      if (!this.drawBorder)
        return;
      this.drawOutline(g2, area);
    }

    [LineNumberTable((ushort) 707)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return CompassPlot.localizationResources.getString("Compass_Plot");
    }

    public override LegendItemCollection getLegendItems()
    {
      return (LegendItemCollection) null;
    }

    public override void zoom(double percent)
    {
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 127, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CompassPlot) || !base.equals(obj))
        return false;
      CompassPlot compassPlot = (CompassPlot) obj;
      return this.labelType == compassPlot.labelType && ObjectUtilities.equal((object) this.labelFont, (object) compassPlot.labelFont) && (this.drawBorder == compassPlot.drawBorder && PaintUtilities.equal(this.roseHighlightPaint, compassPlot.roseHighlightPaint)) && (PaintUtilities.equal(this.rosePaint, compassPlot.rosePaint) && PaintUtilities.equal(this.roseCenterPaint, compassPlot.roseCenterPaint) && (ObjectUtilities.equal((object) this.compassFont, (object) compassPlot.compassFont) && Arrays.equals((object[]) this.seriesNeedle, (object[]) compassPlot.seriesNeedle))) && this.getRevolutionDistance() == compassPlot.getRevolutionDistance();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 180, (byte) 108, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 104, (byte) 150, (byte) 123, (byte) 187, (byte) 108, (byte) 106, (byte) 14, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      CompassPlot compassPlot = (CompassPlot) base.clone();
      if (this.circle1 != null)
        compassPlot.circle1 = (Ellipse2D) ((RectangularShape) this.circle1).clone();
      if (this.circle2 != null)
        compassPlot.circle2 = (Ellipse2D) ((RectangularShape) this.circle2).clone();
      if (this.a1 != null)
        compassPlot.a1 = (Area) this.a1.clone();
      if (this.a2 != null)
        compassPlot.a2 = (Area) this.a2.clone();
      if (this.rect1 != null)
        compassPlot.rect1 = (Rectangle2D) ((RectangularShape) this.rect1).clone();
      compassPlot.datasets = (ValueDataset[]) this.datasets.Clone();
      compassPlot.seriesNeedle = (MeterNeedle[]) this.seriesNeedle.Clone();
      for (int index = 0; index < this.datasets.Length; ++index)
      {
        if (compassPlot.datasets[index] != null)
          compassPlot.datasets[index].addChangeListener((DatasetChangeListener) compassPlot);
      }
      return (object) compassPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 242, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.rosePaint, obj0);
      SerialUtilities.writePaint(this.roseCenterPaint, obj0);
      SerialUtilities.writePaint(this.roseHighlightPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 2, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.rosePaint = SerialUtilities.readPaint(obj0);
      this.roseCenterPaint = SerialUtilities.readPaint(obj0);
      this.roseHighlightPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
