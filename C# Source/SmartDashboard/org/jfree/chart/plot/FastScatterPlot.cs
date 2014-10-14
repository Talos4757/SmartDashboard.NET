// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.FastScatterPlot
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
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.data;
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
  [Implements(new string[] {"org.jfree.chart.plot.ValueAxisPlot", "org.jfree.chart.plot.Pannable", "org.jfree.chart.plot.Zoomable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class FastScatterPlot : Plot, ValueAxisPlot, Pannable, Zoomable, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 7871545897358563521L;
    internal static Stroke __\u003C\u003EDEFAULT_GRIDLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_GRIDLINE_PAINT;
    private float[][] data;
    private Range xDataRange;
    private Range yDataRange;
    private ValueAxis domainAxis;
    private ValueAxis rangeAxis;
    [NonSerialized]
    private Paint paint;
    private bool domainGridlinesVisible;
    [NonSerialized]
    private Stroke domainGridlineStroke;
    [NonSerialized]
    private Paint domainGridlinePaint;
    private bool rangeGridlinesVisible;
    [NonSerialized]
    private Stroke rangeGridlineStroke;
    [NonSerialized]
    private Paint rangeGridlinePaint;
    private bool domainPannable;
    private bool rangePannable;
    protected internal static ResourceBundle localizationResources;

    [Modifiers]
    public static Stroke DEFAULT_GRIDLINE_STROKE
    {
      [HideFromJava] get
      {
        return FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_GRIDLINE_PAINT
    {
      [HideFromJava] get
      {
        return FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 165, (byte) 255, (byte) 18, (byte) 69, (byte) 234, (byte) 119})]
    static FastScatterPlot()
    {
      Plot.__\u003Cclinit\u003E();
      double num1 = 0.5;
      int num2 = 0;
      int num3 = 2;
      double num4 = 0.0;
      float[] numArray = new float[2];
      int index1 = 0;
      double num5 = 2.0;
      numArray[index1] = (float) num5;
      int index2 = 1;
      double num6 = 2.0;
      numArray[index2] = (float) num6;
      double num7 = 0.0;
      FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE = (Stroke) new BasicStroke((float) num1, num2, num3, (float) num4, numArray, (float) num7);
      FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT = (Paint) Color.lightGray;
      FastScatterPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 103, (byte) 109, (byte) 109, (byte) 103, (byte) 108, (byte) 108, (byte) 103, (byte) 108, (byte) 140, (byte) 139, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastScatterPlot(float[][] data, ValueAxis domainAxis, ValueAxis rangeAxis)
    {
      FastScatterPlot fastScatterPlot = this;
      if (domainAxis == null)
      {
        string str = "Null 'domainAxis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rangeAxis == null)
      {
        string str = "Null 'rangeAxis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data = data;
        this.xDataRange = this.calculateXDataRange(data);
        this.yDataRange = this.calculateYDataRange(data);
        this.domainAxis = domainAxis;
        this.domainAxis.setPlot((Plot) this);
        this.domainAxis.addChangeListener((AxisChangeListener) this);
        this.rangeAxis = rangeAxis;
        this.rangeAxis.setPlot((Plot) this);
        this.rangeAxis.addChangeListener((AxisChangeListener) this);
        this.paint = (Paint) Color.red;
        this.domainGridlinesVisible = true;
        this.domainGridlinePaint = FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
        this.domainGridlineStroke = FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
        this.rangeGridlinesVisible = true;
        this.rangeGridlinePaint = FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
        this.rangeGridlineStroke = FastScatterPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 127, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastScatterPlot()
      : this((float[][]) null, (ValueAxis) new NumberAxis("X"), (ValueAxis) new NumberAxis("Y"))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FastScatterPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] FastScatterPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] FastScatterPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainGridlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 145, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeGridlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual ValueAxis getDomainAxis()
    {
      return this.domainAxis;
    }

    public virtual ValueAxis getRangeAxis()
    {
      return this.rangeAxis;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 91, (byte) 130, (byte) 102, (byte) 102, (byte) 102, (byte) 105, (byte) 103, (byte) 101, (byte) 131, (byte) 101, (byte) 227, (byte) 58, (byte) 230, (byte) 73, (byte) 100, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Range calculateXDataRange([In] float[][] obj0)
    {
      Range range = (Range) null;
      if (obj0 != null)
      {
        float num1 = float.PositiveInfinity;
        float num2 = float.NegativeInfinity;
        for (int index = 0; index < obj0[0].Length; ++index)
        {
          float num3 = obj0[0][index];
          if ((double) num3 < (double) num1)
            num1 = num3;
          if ((double) num3 > (double) num2)
            num2 = num3;
        }
        if ((double) num1 <= (double) num2)
          range = new Range((double) num1, (double) num2);
      }
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 123, (byte) 98, (byte) 102, (byte) 102, (byte) 102, (byte) 105, (byte) 103, (byte) 101, (byte) 131, (byte) 101, (byte) 227, (byte) 58, (byte) 230, (byte) 73, (byte) 100, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Range calculateYDataRange([In] float[][] obj0)
    {
      Range range = (Range) null;
      if (obj0 != null)
      {
        float num1 = float.PositiveInfinity;
        float num2 = float.NegativeInfinity;
        for (int index = 0; index < obj0[0].Length; ++index)
        {
          float num3 = obj0[1][index];
          if ((double) num3 < (double) num1)
            num1 = num3;
          if ((double) num3 > (double) num2)
            num2 = num3;
        }
        if ((double) num1 <= (double) num2)
          range = new Range((double) num1, (double) num2);
      }
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 20, (byte) 107, (byte) 103, (byte) 104, (byte) 108, (byte) 153, (byte) 148, (byte) 108, (byte) 108, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawDomainGridlines(Graphics2D g2, Rectangle2D dataArea, List ticks)
    {
      if (!this.isDomainGridlinesVisible())
        return;
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        double num = this.domainAxis.valueToJava2D(((ValueTick) iterator.next()).getValue(), dataArea, RectangleEdge.__\u003C\u003EBOTTOM);
        Line2D.Double @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
        g2.setPaint(this.getDomainGridlinePaint());
        g2.setStroke(this.getDomainGridlineStroke());
        g2.draw((Shape) @double);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 46, (byte) 107, (byte) 103, (byte) 104, (byte) 108, (byte) 153, (byte) 148, (byte) 108, (byte) 108, (byte) 103, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRangeGridlines(Graphics2D g2, Rectangle2D dataArea, List ticks)
    {
      if (!this.isRangeGridlinesVisible())
        return;
      Iterator iterator = ticks.iterator();
      while (iterator.hasNext())
      {
        double num = this.rangeAxis.valueToJava2D(((ValueTick) iterator.next()).getValue(), dataArea, RectangleEdge.__\u003C\u003ELEFT);
        Line2D.Double @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
        g2.setPaint(this.getRangeGridlinePaint());
        g2.setStroke(this.getRangeGridlineStroke());
        g2.draw((Shape) @double);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 230, (byte) 236, (byte) 79, (byte) 107, (byte) 113, (byte) 107, (byte) 203, (byte) 153, (byte) 154, (byte) 235, (byte) 54, (byte) 233, (byte) 81})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void render(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, CrosshairState crosshairState)
    {
      g2.setPaint(this.paint);
      if (this.data == null)
        return;
      for (int index = 0; index < this.data[0].Length; ++index)
      {
        float num1 = this.data[0][index];
        float num2 = this.data[1][index];
        int num3 = ByteCodeHelper.d2i(this.domainAxis.valueToJava2D((double) num1, dataArea, RectangleEdge.__\u003C\u003EBOTTOM));
        int num4 = ByteCodeHelper.d2i(this.rangeAxis.valueToJava2D((double) num2, dataArea, RectangleEdge.__\u003C\u003ELEFT));
        ((Graphics) g2).fillRect(num3, num4, 1, 1);
      }
    }

    public virtual bool isDomainGridlinesVisible()
    {
      return this.domainGridlinesVisible;
    }

    public virtual Paint getDomainGridlinePaint()
    {
      return this.domainGridlinePaint;
    }

    public virtual Stroke getDomainGridlineStroke()
    {
      return this.domainGridlineStroke;
    }

    public virtual bool isRangeGridlinesVisible()
    {
      return this.rangeGridlinesVisible;
    }

    public virtual Paint getRangeGridlinePaint()
    {
      return this.rangeGridlinePaint;
    }

    public virtual Stroke getRangeGridlineStroke()
    {
      return this.rangeGridlineStroke;
    }

    public virtual bool isDomainPannable()
    {
      return this.domainPannable;
    }

    public virtual bool isRangePannable()
    {
      return this.rangePannable;
    }

    [LineNumberTable((ushort) 231)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return FastScatterPlot.localizationResources.getString("Fast_Scatter_Plot");
    }

    public virtual float[][] getData()
    {
      return this.data;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setData(float[][] data)
    {
      this.data = data;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 264)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PlotOrientation getOrientation()
    {
      return PlotOrientation.__\u003C\u003EVERTICAL;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainAxis(ValueAxis axis)
    {
      if (axis == null)
      {
        string str = "Null 'axis' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainAxis = axis;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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
        this.rangeAxis = axis;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 232, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 48, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.domainGridlinesVisible ? 1 : 0) == num)
        return;
      this.domainGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 33, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.domainGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 27, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.rangeGridlinesVisible ? 1 : 0) == num)
        return;
      this.rangeGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 117, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeGridlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.rangeGridlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 169, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 102, (byte) 149, (byte) 149, (byte) 137, (byte) 100, (byte) 200, (byte) 136, (byte) 156, (byte) 157, (byte) 110, (byte) 143, (byte) 104, (byte) 136, (byte) 103, (byte) 178, (byte) 139, (byte) 104, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      AxisSpace space1 = new AxisSpace();
      AxisSpace space2 = this.domainAxis.reserveSpace(g2, (Plot) this, area, RectangleEdge.__\u003C\u003EBOTTOM, space1);
      Rectangle2D rectangle2D = this.rangeAxis.reserveSpace(g2, (Plot) this, area, RectangleEdge.__\u003C\u003ELEFT, space2).shrink(area, (Rectangle2D) null);
      if (info != null)
        info.setDataArea(rectangle2D);
      this.drawBackground(g2, rectangle2D);
      AxisState axisState1 = this.domainAxis.draw(g2, ((RectangularShape) rectangle2D).getMaxY(), area, rectangle2D, RectangleEdge.__\u003C\u003EBOTTOM, info);
      AxisState axisState2 = this.rangeAxis.draw(g2, ((RectangularShape) rectangle2D).getMinX(), area, rectangle2D, RectangleEdge.__\u003C\u003ELEFT, info);
      this.drawDomainGridlines(g2, rectangle2D, axisState1.getTicks());
      this.drawRangeGridlines(g2, rectangle2D, axisState2.getTicks());
      Shape clip = ((Graphics) g2).getClip();
      Composite composite = g2.getComposite();
      g2.clip((Shape) rectangle2D);
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
      this.render(g2, rectangle2D, info, (CrosshairState) null);
      ((Graphics) g2).setClip(clip);
      g2.setComposite(composite);
      this.drawOutline(g2, rectangle2D);
    }

    public virtual Range getDataRange(ValueAxis axis)
    {
      Range range = (Range) null;
      if (axis == this.domainAxis)
        range = this.xDataRange;
      else if (axis == this.rangeAxis)
        range = this.yDataRange;
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 153, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source)
    {
      this.domainAxis.resizeRange(factor);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 199, (byte) 99, (byte) 163, (byte) 104, (byte) 153, (byte) 110, (byte) 130, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
      if (useAnchor)
      {
        double anchorValue = this.domainAxis.java2DToValue(source.getX(), info.getDataArea(), RectangleEdge.__\u003C\u003EBOTTOM);
        this.domainAxis.resizeRange2(factor, anchorValue);
      }
      else
        this.domainAxis.resizeRange(factor);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 197, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomDomainAxes(double lowerPercent, double upperPercent, PlotRenderingInfo info, Point2D source)
    {
      this.domainAxis.zoomRange(lowerPercent, upperPercent);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 209, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo info, Point2D source)
    {
      this.rangeAxis.resizeRange(factor);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 185, (byte) 99, (byte) 163, (byte) 104, (byte) 153, (byte) 110, (byte) 130, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
      if (useAnchor)
      {
        double anchorValue = this.rangeAxis.java2DToValue(source.getY(), info.getDataArea(), RectangleEdge.__\u003C\u003ELEFT);
        this.rangeAxis.resizeRange2(factor, anchorValue);
      }
      else
        this.rangeAxis.resizeRange(factor);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 253, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double lowerPercent, double upperPercent, PlotRenderingInfo info, Point2D source)
    {
      this.rangeAxis.zoomRange(lowerPercent, upperPercent);
    }

    public virtual bool isDomainZoomable()
    {
      return true;
    }

    public virtual bool isRangeZoomable()
    {
      return true;
    }

    public virtual void setDomainPannable(bool pannable)
    {
      this.domainPannable = pannable;
    }

    public virtual void setRangePannable(bool pannable)
    {
      this.rangePannable = pannable;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 77, (byte) 112, (byte) 129, (byte) 114, (byte) 103, (byte) 109, (byte) 131, (byte) 159, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void panDomainAxes(double percent, PlotRenderingInfo info, Point2D source)
    {
      if (!this.isDomainPannable() || this.domainAxis == null)
        return;
      double length = this.domainAxis.getRange().getLength();
      double num = -percent * length;
      if (this.domainAxis.isInverted())
        num = -num;
      this.domainAxis.setRange(this.domainAxis.getLowerBound() + num, this.domainAxis.getUpperBound() + num);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 100, (byte) 112, (byte) 129, (byte) 114, (byte) 102, (byte) 109, (byte) 131, (byte) 159, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void panRangeAxes(double percent, PlotRenderingInfo info, Point2D source)
    {
      if (!this.isRangePannable() || this.rangeAxis == null)
        return;
      double length = this.rangeAxis.getRange().getLength();
      double num = percent * length;
      if (this.rangeAxis.isInverted())
        num = -num;
      this.rangeAxis.setRange(this.rangeAxis.getLowerBound() + num, this.rangeAxis.getUpperBound() + num);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 123, (byte) 100, (byte) 130, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 116, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is FastScatterPlot))
        return false;
      FastScatterPlot fastScatterPlot = (FastScatterPlot) obj;
      return this.domainPannable == fastScatterPlot.domainPannable && this.rangePannable == fastScatterPlot.rangePannable && (ArrayUtilities.equal(this.data, fastScatterPlot.data) && ObjectUtilities.equal((object) this.domainAxis, (object) fastScatterPlot.domainAxis)) && (ObjectUtilities.equal((object) this.rangeAxis, (object) fastScatterPlot.rangeAxis) && PaintUtilities.equal(this.paint, fastScatterPlot.paint) && (this.domainGridlinesVisible == fastScatterPlot.domainGridlinesVisible && PaintUtilities.equal(this.domainGridlinePaint, fastScatterPlot.domainGridlinePaint))) && ObjectUtilities.equal((object) this.domainGridlineStroke, (object) fastScatterPlot.domainGridlineStroke) && ((this.rangeGridlinesVisible ? 0 : 1) != (fastScatterPlot.rangeGridlinesVisible ? 1 : 0) && PaintUtilities.equal(this.rangeGridlinePaint, fastScatterPlot.rangeGridlinePaint) && ObjectUtilities.equal((object) this.rangeGridlineStroke, (object) fastScatterPlot.rangeGridlineStroke));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 186, (byte) 108, (byte) 104, (byte) 145, (byte) 104, (byte) 118, (byte) 108, (byte) 140, (byte) 104, (byte) 118, (byte) 108, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      FastScatterPlot fastScatterPlot = (FastScatterPlot) base.clone();
      if (this.data != null)
        fastScatterPlot.data = ArrayUtilities.clone(this.data);
      if (this.domainAxis != null)
      {
        fastScatterPlot.domainAxis = (ValueAxis) this.domainAxis.clone();
        fastScatterPlot.domainAxis.setPlot((Plot) fastScatterPlot);
        fastScatterPlot.domainAxis.addChangeListener((AxisChangeListener) fastScatterPlot);
      }
      if (this.rangeAxis != null)
      {
        fastScatterPlot.rangeAxis = (ValueAxis) this.rangeAxis.clone();
        fastScatterPlot.rangeAxis.setPlot((Plot) fastScatterPlot);
        fastScatterPlot.rangeAxis.addChangeListener((AxisChangeListener) fastScatterPlot);
      }
      return (object) fastScatterPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 212, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writeStroke(this.domainGridlineStroke, obj0);
      SerialUtilities.writePaint(this.domainGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.rangeGridlineStroke, obj0);
      SerialUtilities.writePaint(this.rangeGridlinePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 230, (byte) 134, (byte) 108, (byte) 108, (byte) 140, (byte) 108, (byte) 140, (byte) 104, (byte) 172, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.domainGridlineStroke = SerialUtilities.readStroke(obj0);
      this.domainGridlinePaint = SerialUtilities.readPaint(obj0);
      this.rangeGridlineStroke = SerialUtilities.readStroke(obj0);
      this.rangeGridlinePaint = SerialUtilities.readPaint(obj0);
      if (this.domainAxis != null)
        this.domainAxis.addChangeListener((AxisChangeListener) this);
      if (this.rangeAxis == null)
        return;
      this.rangeAxis.addChangeListener((AxisChangeListener) this);
    }
  }
}
