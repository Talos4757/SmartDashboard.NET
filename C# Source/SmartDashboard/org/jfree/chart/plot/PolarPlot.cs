// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PolarPlot
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
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.renderer;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
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
  [Implements(new string[] {"org.jfree.chart.plot.ValueAxisPlot", "org.jfree.chart.plot.Zoomable", "org.jfree.chart.event.RendererChangeListener", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class PolarPlot : Plot, ValueAxisPlot, Zoomable, RendererChangeListener, EventListener, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 3794383185924179525L;
    private const int MARGIN = 20;
    private const double ANNOTATION_MARGIN = 7.0;
    public const double DEFAULT_ANGLE_TICK_UNIT_SIZE = 45.0;
    internal static Stroke __\u003C\u003EDEFAULT_GRIDLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_GRIDLINE_PAINT;
    protected internal static ResourceBundle localizationResources;
    private List angleTicks;
    private ValueAxis axis;
    private XYDataset dataset;
    private PolarItemRenderer renderer;
    private TickUnit angleTickUnit;
    private bool angleLabelsVisible;
    private Font angleLabelFont;
    [NonSerialized]
    private Paint angleLabelPaint;
    private bool angleGridlinesVisible;
    [NonSerialized]
    private Stroke angleGridlineStroke;
    [NonSerialized]
    private Paint angleGridlinePaint;
    private bool radiusGridlinesVisible;
    [NonSerialized]
    private Stroke radiusGridlineStroke;
    [NonSerialized]
    private Paint radiusGridlinePaint;
    private List cornerTextItems;

    [Modifiers]
    public static Stroke DEFAULT_GRIDLINE_STROKE
    {
      [HideFromJava] get
      {
        return PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_GRIDLINE_PAINT
    {
      [HideFromJava] get
      {
        return PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 133, (byte) 255, (byte) 18, (byte) 69, (byte) 170})]
    static PolarPlot()
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
      PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE = (Stroke) new BasicStroke((float) num1, num2, num3, (float) num4, numArray, (float) num7);
      PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT = (Paint) Color.gray;
      PolarPlot.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.plot.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolarPlot()
      : this((XYDataset) null, (ValueAxis) null, (PolarItemRenderer) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 232, (byte) 17, (byte) 167, (byte) 179, (byte) 235, (byte) 85, (byte) 235, (byte) 86, (byte) 103, (byte) 104, (byte) 140, (byte) 148, (byte) 103, (byte) 104, (byte) 108, (byte) 172, (byte) 103, (byte) 104, (byte) 108, (byte) 172, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolarPlot(XYDataset dataset, ValueAxis radiusAxis, PolarItemRenderer renderer)
    {
      PolarPlot polarPlot = this;
      this.angleLabelsVisible = true;
      this.angleLabelFont = new Font("SansSerif", 0, 12);
      this.angleLabelPaint = (Paint) Color.black;
      this.cornerTextItems = (List) new ArrayList();
      this.dataset = dataset;
      if (this.dataset != null)
        this.dataset.addChangeListener((DatasetChangeListener) this);
      this.angleTickUnit = (TickUnit) new NumberTickUnit(45.0);
      this.axis = radiusAxis;
      if (this.axis != null)
      {
        this.axis.setPlot((Plot) this);
        this.axis.addChangeListener((AxisChangeListener) this);
      }
      this.renderer = renderer;
      if (this.renderer != null)
      {
        this.renderer.setPlot(this);
        this.renderer.addChangeListener((RendererChangeListener) this);
      }
      this.angleGridlinesVisible = true;
      this.angleGridlineStroke = PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.angleGridlinePaint = PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      this.radiusGridlinesVisible = true;
      this.radiusGridlineStroke = PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      this.radiusGridlinePaint = PolarPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PolarPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PolarPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PolarPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 234, (byte) 103, (byte) 99, (byte) 199, (byte) 103, (byte) 104, (byte) 113, (byte) 204, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(XYDataset dataset)
    {
      XYDataset xyDataset = this.dataset;
      if (xyDataset != null)
        xyDataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (this.dataset != null)
      {
        this.setDatasetGroup(this.dataset.getGroup());
        this.dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) this.dataset));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 195, (byte) 99, (byte) 199, (byte) 104, (byte) 172, (byte) 103, (byte) 104, (byte) 107, (byte) 140, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxis(ValueAxis axis)
    {
      if (axis != null)
        axis.setPlot((Plot) this);
      if (this.axis != null)
        this.axis.removeChangeListener((AxisChangeListener) this);
      this.axis = axis;
      if (this.axis != null)
      {
        this.axis.configure();
        this.axis.addChangeListener((AxisChangeListener) this);
      }
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 17, (byte) 104, (byte) 172, (byte) 103, (byte) 104, (byte) 140, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderer(PolarItemRenderer renderer)
    {
      if (this.renderer != null)
        this.renderer.removeChangeListener((RendererChangeListener) this);
      this.renderer = renderer;
      if (this.renderer != null)
        this.renderer.setPlot(this);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 8, (byte) 105, (byte) 104, (byte) 102, (byte) 108, (byte) 108, (byte) 130, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoom(double percent)
    {
      if (percent > 0.0)
      {
        this.axis.setUpperBound(this.getMaxRadius() * percent);
        this.getAxis().setAutoRange(false);
      }
      else
        this.getAxis().setAutoRange(true);
    }

    public virtual ValueAxis getAxis()
    {
      return this.axis;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.angleLabelFont = font;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 127, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.angleLabelPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 213, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleGridlinePaint(Paint paint)
    {
      this.angleGridlinePaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 41, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadiusGridlinePaint(Paint paint)
    {
      this.radiusGridlinePaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 44, (byte) 104, (byte) 171, (byte) 104, (byte) 174, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void datasetChanged(DatasetChangeEvent @event)
    {
      if (this.axis != null)
        this.axis.configure();
      if (this.getParent() != null)
        this.getParent().datasetChanged(@event);
      else
        base.datasetChanged(@event);
    }

    [LineNumberTable((ushort) 816)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawAxis(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea)
    {
      return this.axis.draw(g2, ((RectangularShape) dataArea).getMinY(), plotArea, dataArea, RectangleEdge.__\u003C\u003ETOP, (PlotRenderingInfo) null);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 53, (byte) 102, (byte) 146, (byte) 191, (byte) 8, (byte) 232, (byte) 60, (byte) 241, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List refreshAngleTicks()
    {
      ArrayList arrayList = new ArrayList();
      double num = 0.0;
      while (num < 360.0)
      {
        NumberTick numberTick = new NumberTick((Number) new Double(num), this.angleTickUnit.valueToString(num), TextAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER, 0.0);
        ((List) arrayList).add((object) numberTick);
        num += this.angleTickUnit.getSize();
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 233, (byte) 104, (byte) 193, (byte) 104, (byte) 103, (byte) 103, (byte) 102, (byte) 239, (byte) 70, (byte) 104, (byte) 103, (byte) 103, (byte) 102, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawGridlines(Graphics2D g2, Rectangle2D dataArea, List angularTicks, List radialTicks)
    {
      if (this.renderer == null)
        return;
      if (this.isAngleGridlinesVisible() && (this.getAngleGridlineStroke() != null && this.getAngleGridlinePaint() != null))
        this.renderer.drawAngularGridLines(g2, this, angularTicks, dataArea);
      if (!this.isRadiusGridlinesVisible() || (this.getRadiusGridlineStroke() == null || this.getRadiusGridlinePaint() == null))
        return;
      this.renderer.drawRadialGridLines(g2, this, this.axis, radialTicks, dataArea);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 209, (byte) 109, (byte) 108, (byte) 102, (byte) 54, (byte) 198, (byte) 130, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void render(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info)
    {
      if (!DatasetUtilities.isEmptyOrNull(this.dataset))
      {
        int seriesCount = this.dataset.getSeriesCount();
        for (int i = 0; i < seriesCount; ++i)
          this.renderer.drawSeries(g2, dataArea, info, this, this.dataset, i);
      }
      else
        this.drawNoDataMessage(g2, dataArea);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 146, (byte) 109, (byte) 161, (byte) 107, (byte) 102, (byte) 102, (byte) 116, (byte) 108, (byte) 104, (byte) 107, (byte) 111, (byte) 107, (byte) 130, (byte) 107, (byte) 107, (byte) 102, (byte) 134, (byte) 107, (byte) 107, (byte) 127, (byte) 1, (byte) 111, (byte) 118, (byte) 110, (byte) 144, (byte) 109, (byte) 118, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawCornerTextItems(Graphics2D g2, Rectangle2D area)
    {
      if (this.cornerTextItems.isEmpty())
        return;
      ((Graphics) g2).setColor((Color) Color.black);
      double num1 = 0.0;
      double num2 = 0.0;
      Iterator iterator1 = this.cornerTextItems.iterator();
      while (iterator1.hasNext())
      {
        string text = (string) iterator1.next();
        FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics();
        Rectangle2D textBounds = TextUtilities.getTextBounds(text, g2, fontMetrics);
        num1 = Math.max(num1, ((RectangularShape) textBounds).getWidth());
        num2 += ((RectangularShape) textBounds).getHeight();
      }
      double num3 = 14.0;
      double num4 = 7.0;
      double num5 = num1 + num3;
      double num6 = num2 + num4;
      double num7 = ((RectangularShape) area).getMaxX() - num5;
      double num8 = ((RectangularShape) area).getMaxY() - num6;
      ((Graphics) g2).drawRect(ByteCodeHelper.d2i(num7), ByteCodeHelper.d2i(num8), ByteCodeHelper.d2i(num5), ByteCodeHelper.d2i(num6));
      double num9 = num7 + 7.0;
      Iterator iterator2 = this.cornerTextItems.iterator();
      while (iterator2.hasNext())
      {
        string text = (string) iterator2.next();
        Rectangle2D textBounds = TextUtilities.getTextBounds(text, g2, ((Graphics) g2).getFontMetrics());
        num8 += ((RectangularShape) textBounds).getHeight();
        g2.drawString(text, ByteCodeHelper.d2i(num9), ByteCodeHelper.d2i(num8));
      }
    }

    public virtual bool isAngleGridlinesVisible()
    {
      return this.angleGridlinesVisible;
    }

    public virtual Stroke getAngleGridlineStroke()
    {
      return this.angleGridlineStroke;
    }

    public virtual Paint getAngleGridlinePaint()
    {
      return this.angleGridlinePaint;
    }

    public virtual bool isRadiusGridlinesVisible()
    {
      return this.radiusGridlinesVisible;
    }

    public virtual Stroke getRadiusGridlineStroke()
    {
      return this.radiusGridlineStroke;
    }

    public virtual Paint getRadiusGridlinePaint()
    {
      return this.radiusGridlinePaint;
    }

    [LineNumberTable((ushort) 1254)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMaxRadius()
    {
      return this.axis.getUpperBound();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 99, (byte) 144, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addCornerTextItem(string text)
    {
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.cornerTextItems.add((object) text);
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 109, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeCornerTextItem(string text)
    {
      if (!this.cornerTextItems.remove((object) text))
        return;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 110, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearCornerTextItems()
    {
      if (this.cornerTextItems.size() <= 0)
        return;
      this.cornerTextItems.clear();
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 288)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return PolarPlot.localizationResources.getString("Polar_Plot");
    }

    public virtual XYDataset getDataset()
    {
      return this.dataset;
    }

    public virtual PolarItemRenderer getRenderer()
    {
      return this.renderer;
    }

    public virtual TickUnit getAngleTickUnit()
    {
      return this.angleTickUnit;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleTickUnit(TickUnit unit)
    {
      if (unit == null)
      {
        string str = "Null 'unit' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.angleTickUnit = unit;
        this.fireChangeEvent();
      }
    }

    public virtual bool isAngleLabelsVisible()
    {
      return this.angleLabelsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 31, (byte) 130, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleLabelsVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.angleLabelsVisible ? 1 : 0) == num)
        return;
      this.angleLabelsVisible = num != 0;
      this.fireChangeEvent();
    }

    public virtual Font getAngleLabelFont()
    {
      return this.angleLabelFont;
    }

    public virtual Paint getAngleLabelPaint()
    {
      return this.angleLabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 10, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.angleGridlinesVisible ? 1 : 0) == num)
        return;
      this.angleGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 187, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngleGridlineStroke(Stroke stroke)
    {
      this.angleGridlineStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 246, (byte) 162, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadiusGridlinesVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.radiusGridlinesVisible ? 1 : 0) == num)
        return;
      this.radiusGridlinesVisible = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 14, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadiusGridlineStroke(Stroke stroke)
    {
      this.radiusGridlineStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 91, (byte) 117, (byte) 117, (byte) 102, (byte) 193, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 98, (byte) 100, (byte) 200, (byte) 104, (byte) 159, (byte) 19, (byte) 151, (byte) 108, (byte) 104, (byte) 104, (byte) 136, (byte) 103, (byte) 178, (byte) 108, (byte) 181, (byte) 138, (byte) 104, (byte) 136, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (((RectangularShape) area).getWidth() <= 10.0 || ((RectangularShape) area).getHeight() <= 10.0)
        return;
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      Rectangle2D rectangle2D = area;
      if (info != null)
        info.setDataArea(rectangle2D);
      this.drawBackground(g2, rectangle2D);
      double num = Math.min(((RectangularShape) rectangle2D).getWidth() / 2.0, ((RectangularShape) rectangle2D).getHeight() / 2.0) - 20.0;
      Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) rectangle2D).getCenterX(), ((RectangularShape) rectangle2D).getCenterY(), num, num);
      AxisState axisState = this.drawAxis(g2, area, (Rectangle2D) @double);
      if (this.renderer != null)
      {
        Shape clip = ((Graphics) g2).getClip();
        Composite composite = g2.getComposite();
        g2.clip((Shape) rectangle2D);
        g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
        this.angleTicks = this.refreshAngleTicks();
        this.drawGridlines(g2, rectangle2D, this.angleTicks, axisState.getTicks());
        this.render(g2, rectangle2D, info);
        ((Graphics) g2).setClip(clip);
        g2.setComposite(composite);
      }
      this.drawOutline(g2, rectangle2D);
      this.drawCornerTextItems(g2, rectangle2D);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 27, (byte) 98, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDataRange(ValueAxis axis)
    {
      Range range = (Range) null;
      if (this.dataset != null)
        range = Range.combine((Range) null, DatasetUtilities.findRangeBounds(this.dataset));
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 64, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void rendererChanged(RendererChangeEvent @event)
    {
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 74, (byte) 130, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSeriesCount()
    {
      int num = 0;
      if (this.dataset != null)
        num = this.dataset.getSeriesCount();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 90, (byte) 166, (byte) 104, (byte) 104, (byte) 108, (byte) 102, (byte) 109, (byte) 7, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection = new LegendItemCollection();
      if (this.dataset != null && this.renderer != null)
      {
        int seriesCount = this.dataset.getSeriesCount();
        for (int i = 0; i < seriesCount; ++i)
        {
          LegendItem legendItem = this.renderer.getLegendItem(i);
          legendItemCollection.add(legendItem);
        }
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 113, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 179, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PolarPlot))
        return false;
      PolarPlot polarPlot = (PolarPlot) obj;
      if (!ObjectUtilities.equal((object) this.axis, (object) polarPlot.axis) || !ObjectUtilities.equal((object) this.renderer, (object) polarPlot.renderer) || (!this.angleTickUnit.equals((object) polarPlot.angleTickUnit) || this.angleGridlinesVisible != polarPlot.angleGridlinesVisible) || (this.angleLabelsVisible != polarPlot.angleLabelsVisible || !this.angleLabelFont.equals((object) polarPlot.angleLabelFont) || (!PaintUtilities.equal(this.angleLabelPaint, polarPlot.angleLabelPaint) || !ObjectUtilities.equal((object) this.angleGridlineStroke, (object) polarPlot.angleGridlineStroke))) || (!PaintUtilities.equal(this.angleGridlinePaint, polarPlot.angleGridlinePaint) || this.radiusGridlinesVisible != polarPlot.radiusGridlinesVisible || (!ObjectUtilities.equal((object) this.radiusGridlineStroke, (object) polarPlot.radiusGridlineStroke) || !PaintUtilities.equal(this.radiusGridlinePaint, polarPlot.radiusGridlinePaint)) || !Object.instancehelper_equals((object) this.cornerTextItems, (object) polarPlot.cornerTextItems)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 177, (byte) 108, (byte) 104, (byte) 118, (byte) 108, (byte) 172, (byte) 104, (byte) 172, (byte) 104, (byte) 214, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      PolarPlot polarPlot = (PolarPlot) base.clone();
      if (this.axis != null)
      {
        polarPlot.axis = (ValueAxis) ObjectUtilities.clone((object) this.axis);
        polarPlot.axis.setPlot((Plot) polarPlot);
        polarPlot.axis.addChangeListener((AxisChangeListener) polarPlot);
      }
      if (polarPlot.dataset != null)
        polarPlot.dataset.addChangeListener((DatasetChangeListener) polarPlot);
      if (this.renderer != null)
        polarPlot.renderer = (PolarItemRenderer) ObjectUtilities.clone((object) this.renderer);
      polarPlot.cornerTextItems = (List) new ArrayList((Collection) this.cornerTextItems);
      return (object) polarPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 206, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.angleGridlineStroke, obj0);
      SerialUtilities.writePaint(this.angleGridlinePaint, obj0);
      SerialUtilities.writeStroke(this.radiusGridlineStroke, obj0);
      SerialUtilities.writePaint(this.radiusGridlinePaint, obj0);
      SerialUtilities.writePaint(this.angleLabelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 225, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 104, (byte) 108, (byte) 172, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.angleGridlineStroke = SerialUtilities.readStroke(obj0);
      this.angleGridlinePaint = SerialUtilities.readPaint(obj0);
      this.radiusGridlineStroke = SerialUtilities.readStroke(obj0);
      this.radiusGridlinePaint = SerialUtilities.readPaint(obj0);
      this.angleLabelPaint = SerialUtilities.readPaint(obj0);
      if (this.axis != null)
      {
        this.axis.setPlot((Plot) this);
        this.axis.addChangeListener((AxisChangeListener) this);
      }
      if (this.dataset == null)
        return;
      this.dataset.addChangeListener((DatasetChangeListener) this);
    }

    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo state, Point2D source)
    {
    }

    public virtual void zoomDomainAxes(double factor, PlotRenderingInfo state, Point2D source, bool useAnchor)
    {
    }

    public virtual void zoomDomainAxes(double lowerPercent, double upperPercent, PlotRenderingInfo state, Point2D source)
    {
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 38, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo state, Point2D source)
    {
      this.zoom(factor);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 100, (byte) 131, (byte) 163, (byte) 104, (byte) 153, (byte) 110, (byte) 130, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
      if (useAnchor)
      {
        double anchorValue = this.axis.java2DToValue(source.getX(), info.getDataArea(), RectangleEdge.__\u003C\u003EBOTTOM);
        this.axis.resizeRange(factor, anchorValue);
      }
      else
        this.axis.resizeRange(factor);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 80, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zoomRangeAxes(double lowerPercent, double upperPercent, PlotRenderingInfo state, Point2D source)
    {
      this.zoom((upperPercent + lowerPercent) / 2.0);
    }

    public virtual bool isDomainZoomable()
    {
      return false;
    }

    public virtual bool isRangeZoomable()
    {
      return true;
    }

    [LineNumberTable((ushort) 1245)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PlotOrientation getOrientation()
    {
      return PlotOrientation.__\u003C\u003EHORIZONTAL;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 134, (byte) 147, (byte) 114, (byte) 114, (byte) 114, (byte) 147, (byte) 102, (byte) 103, (byte) 140, (byte) 113, (byte) 145, (byte) 110, (byte) 105, (byte) 140, (byte) 118, (byte) 150, (byte) 148, (byte) 180, (byte) 105, (byte) 137, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Point translateValueThetaRadiusToJava2D(double angleDegrees, double radius, Rectangle2D dataArea)
    {
      double num1 = Math.toRadians(angleDegrees - 90.0);
      double num2 = ((RectangularShape) dataArea).getMinX() + 20.0;
      double num3 = ((RectangularShape) dataArea).getMaxX() - 20.0;
      double num4 = ((RectangularShape) dataArea).getMinY() + 20.0;
      double num5 = ((RectangularShape) dataArea).getMaxY() - 20.0;
      double num6 = num3 - num2;
      double num7 = num5 - num4;
      double num8 = Math.min(num6, num7);
      double num9 = num2 + num6 / 2.0;
      double num10 = num4 + num7 / 2.0;
      double lowerBound = this.axis.getLowerBound();
      double maxRadius = this.getMaxRadius();
      double num11 = Math.max(radius, lowerBound);
      double num12 = num8 / 2.0 * Math.cos(num1);
      double num13 = num8 / 2.0 * Math.sin(num1);
      return new Point(Math.round((float) (num9 + num12 * (num11 - lowerBound) / (maxRadius - lowerBound))), Math.round((float) (num10 + num13 * (num11 - lowerBound) / (maxRadius - lowerBound))));
    }
  }
}
