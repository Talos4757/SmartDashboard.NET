// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYBarRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
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

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYBarRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 770559577251370036L;
    private static XYBarPainter defaultBarPainter;
    private static bool defaultShadowsVisible;
    private double @base;
    private bool useYInterval;
    private double margin;
    private bool drawBarOutline;
    private GradientPaintTransformer gradientPaintTransformer;
    [NonSerialized]
    private Shape legendBar;
    private ItemLabelPosition positiveItemLabelPositionFallback;
    private ItemLabelPosition negativeItemLabelPositionFallback;
    private XYBarPainter barPainter;
    private bool shadowsVisible;
    private double shadowXOffset;
    private double shadowYOffset;
    private double barAlignmentFactor;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 101, (byte) 234, (byte) 94})]
    static XYBarRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
      XYBarRenderer.defaultBarPainter = (XYBarPainter) new GradientXYBarPainter();
      XYBarRenderer.defaultShadowsVisible = true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBarRenderer()
      : this(0.0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 104, (byte) 105, (byte) 108, (byte) 103, (byte) 107, (byte) 103, (byte) 127, (byte) 16, (byte) 107, (byte) 107, (byte) 112, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBarRenderer(double margin)
    {
      XYBarRenderer xyBarRenderer = this;
      this.margin = margin;
      this.@base = 0.0;
      this.useYInterval = false;
      this.gradientPaintTransformer = (GradientPaintTransformer) new StandardGradientPaintTransformer();
      this.drawBarOutline = false;
      this.legendBar = (Shape) new Rectangle2D.Double(-3.0, -5.0, 6.0, 10.0);
      this.barPainter = XYBarRenderer.getDefaultBarPainter();
      this.shadowsVisible = XYBarRenderer.getDefaultShadowsVisible();
      this.shadowXOffset = 4.0;
      this.shadowYOffset = 4.0;
      this.barAlignmentFactor = -1.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYBarRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYBarRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 99, (byte) 144, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setDefaultBarPainter(XYBarPainter painter)
    {
      if (painter == null)
      {
        string str = "Null 'painter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        XYBarRenderer.defaultBarPainter = painter;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 221, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBarPainter(XYBarPainter painter)
    {
      if (painter == null)
      {
        string str = "Null 'painter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.barPainter = painter;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 243, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowVisible(bool visible)
    {
      this.shadowsVisible = visible;
      this.fireChangeEvent();
    }

    public static XYBarPainter getDefaultBarPainter()
    {
      return XYBarRenderer.defaultBarPainter;
    }

    public static bool getDefaultShadowsVisible()
    {
      return XYBarRenderer.defaultShadowsVisible;
    }

    public virtual GradientPaintTransformer getGradientPaintTransformer()
    {
      return this.gradientPaintTransformer;
    }

    public virtual double getMargin()
    {
      return this.margin;
    }

    public virtual bool getShadowsVisible()
    {
      return this.shadowsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 154, (byte) 163, (byte) 100, (byte) 129, (byte) 108, (byte) 99, (byte) 161, (byte) 106, (byte) 103, (byte) 106, (byte) 167, (byte) 98, (byte) 99, (byte) 173, (byte) 203, (byte) 184, (byte) 114, (byte) 255, (byte) 15, (byte) 69, (byte) 100, (byte) 112, (byte) 99, (byte) 170, (byte) 136, (byte) 100, (byte) 248, (byte) 73, (byte) 100, (byte) 255, (byte) 15, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItemLabel(Graphics2D g2, XYDataset dataset, int series, int item, XYPlot plot, XYItemLabelGenerator generator, Rectangle2D bar, bool negative)
    {
      int num = negative ? 1 : 0;
      if (generator == null)
        return;
      string text = generator.generateLabel(dataset, series, item);
      if (text == null)
        return;
      Font itemLabelFont = this.getItemLabelFont(series, item);
      ((Graphics) g2).setFont(itemLabelFont);
      Paint itemLabelPaint = this.getItemLabelPaint(series, item);
      g2.setPaint(itemLabelPaint);
      ItemLabelPosition itemLabelPosition = num != 0 ? this.getNegativeItemLabelPosition(series, item) : this.getPositiveItemLabelPosition(series, item);
      Point2D point2D = this.calculateLabelAnchorPoint(itemLabelPosition.getItemLabelAnchor(), bar, plot.getOrientation());
      if (this.isInternalAnchor(itemLabelPosition.getItemLabelAnchor()))
      {
        Shape shape = TextUtilities.calculateRotatedStringBounds(text, g2, (float) point2D.getX(), (float) point2D.getY(), itemLabelPosition.getTextAnchor(), itemLabelPosition.getAngle(), itemLabelPosition.getRotationAnchor());
        if (shape != null && !((RectangularShape) bar).contains(shape.getBounds2D()))
        {
          itemLabelPosition = num != 0 ? this.getNegativeItemLabelPositionFallback() : this.getPositiveItemLabelPositionFallback();
          if (itemLabelPosition != null)
            point2D = this.calculateLabelAnchorPoint(itemLabelPosition.getItemLabelAnchor(), bar, plot.getOrientation());
        }
      }
      if (itemLabelPosition == null)
        return;
      TextUtilities.drawRotatedString(text, g2, (float) point2D.getX(), (float) point2D.getY(), itemLabelPosition.getTextAnchor(), itemLabelPosition.getAngle(), itemLabelPosition.getRotationAnchor());
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 167, (byte) 98, (byte) 104, (byte) 106, (byte) 104, (byte) 107, (byte) 105, (byte) 107, (byte) 105, (byte) 139, (byte) 107, (byte) 105, (byte) 107, (byte) 105, (byte) 107, (byte) 105, (byte) 139, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 104, (byte) 139, (byte) 104, (byte) 139, (byte) 104, (byte) 139, (byte) 104, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Point2D calculateLabelAnchorPoint([In] ItemLabelAnchor obj0, [In] Rectangle2D obj1, [In] PlotOrientation obj2)
    {
      Point2D.Double @double = (Point2D.Double) null;
      double labelAnchorOffset = this.getItemLabelAnchorOffset();
      double num1 = ((RectangularShape) obj1).getX() - labelAnchorOffset;
      double x = ((RectangularShape) obj1).getX();
      double num2 = ((RectangularShape) obj1).getX() + labelAnchorOffset;
      double centerX = ((RectangularShape) obj1).getCenterX();
      double num3 = ((RectangularShape) obj1).getMaxX() - labelAnchorOffset;
      double maxX = ((RectangularShape) obj1).getMaxX();
      double num4 = ((RectangularShape) obj1).getMaxX() + labelAnchorOffset;
      double num5 = ((RectangularShape) obj1).getMaxY() + labelAnchorOffset;
      double maxY = ((RectangularShape) obj1).getMaxY();
      double num6 = ((RectangularShape) obj1).getMaxY() - labelAnchorOffset;
      double centerY = ((RectangularShape) obj1).getCenterY();
      double num7 = ((RectangularShape) obj1).getMinY() + labelAnchorOffset;
      double minY = ((RectangularShape) obj1).getMinY();
      double num8 = ((RectangularShape) obj1).getMinY() - labelAnchorOffset;
      if (obj0 == ItemLabelAnchor.__\u003C\u003ECENTER)
        @double = new Point2D.Double(centerX, centerY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE1)
        @double = new Point2D.Double(num3, num7);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE2)
        @double = new Point2D.Double(num3, num7);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE3)
        @double = new Point2D.Double(num3, centerY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE4)
        @double = new Point2D.Double(num3, num6);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE5)
        @double = new Point2D.Double(num3, num6);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE6)
        @double = new Point2D.Double(centerX, num6);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE7)
        @double = new Point2D.Double(num2, num6);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE8)
        @double = new Point2D.Double(num2, num6);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE9)
        @double = new Point2D.Double(num2, centerY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE10)
        @double = new Point2D.Double(num2, num7);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE11)
        @double = new Point2D.Double(num2, num7);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE12)
        @double = new Point2D.Double(centerX, num7);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE1)
        @double = new Point2D.Double(maxX, num8);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE2)
        @double = new Point2D.Double(num4, minY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE3)
        @double = new Point2D.Double(num4, centerY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE4)
        @double = new Point2D.Double(num4, maxY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE5)
        @double = new Point2D.Double(maxX, num5);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE6)
        @double = new Point2D.Double(centerX, num5);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE7)
        @double = new Point2D.Double(x, num5);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE8)
        @double = new Point2D.Double(num1, maxY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE9)
        @double = new Point2D.Double(num1, centerY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE10)
        @double = new Point2D.Double(num1, minY);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE11)
        @double = new Point2D.Double(x, num8);
      else if (obj0 == ItemLabelAnchor.__\u003C\u003EOUTSIDE12)
        @double = new Point2D.Double(centerX, num8);
      return (Point2D) @double;
    }

    [LineNumberTable((ushort) 1155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isInternalAnchor([In] ItemLabelAnchor obj0)
    {
      return obj0 == ItemLabelAnchor.__\u003C\u003ECENTER || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE1 || (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE2 || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE3) || (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE4 || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE5 || (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE6 || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE7)) || (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE8 || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE9 || (obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE10 || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE11) || obj0 == ItemLabelAnchor.__\u003C\u003EINSIDE12);
    }

    public virtual ItemLabelPosition getPositiveItemLabelPositionFallback()
    {
      return this.positiveItemLabelPositionFallback;
    }

    public virtual ItemLabelPosition getNegativeItemLabelPositionFallback()
    {
      return this.negativeItemLabelPositionFallback;
    }

    public static void setDefaultShadowsVisible(bool visible)
    {
      XYBarRenderer.defaultShadowsVisible = visible;
    }

    public virtual double getBase()
    {
      return this.@base;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBase(double @base)
    {
      this.@base = @base;
      this.fireChangeEvent();
    }

    public virtual bool getUseYInterval()
    {
      return this.useYInterval;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 41, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseYInterval(bool use)
    {
      int num = use ? 1 : 0;
      if ((this.useYInterval ? 1 : 0) == num)
        return;
      this.useYInterval = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMargin(double margin)
    {
      this.margin = margin;
      this.fireChangeEvent();
    }

    public virtual bool isDrawBarOutline()
    {
      return this.drawBarOutline;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 29, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawBarOutline(bool draw)
    {
      this.drawBarOutline = draw;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 111, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGradientPaintTransformer(GradientPaintTransformer transformer)
    {
      this.gradientPaintTransformer = transformer;
      this.fireChangeEvent();
    }

    public virtual Shape getLegendBar()
    {
      return this.legendBar;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 136, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendBar(Shape bar)
    {
      if (bar == null)
      {
        string str = "Null 'bar' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendBar = bar;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 168, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositiveItemLabelPositionFallback(ItemLabelPosition position)
    {
      this.positiveItemLabelPositionFallback = position;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 197, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativeItemLabelPositionFallback(ItemLabelPosition position)
    {
      this.negativeItemLabelPositionFallback = position;
      this.fireChangeEvent();
    }

    public virtual XYBarPainter getBarPainter()
    {
      return this.barPainter;
    }

    public virtual double getShadowXOffset()
    {
      return this.shadowXOffset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 18, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowXOffset(double offset)
    {
      this.shadowXOffset = offset;
      this.fireChangeEvent();
    }

    public virtual double getShadowYOffset()
    {
      return this.shadowYOffset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 42, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowYOffset(double offset)
    {
      this.shadowYOffset = offset;
      this.fireChangeEvent();
    }

    public virtual double getBarAlignmentFactor()
    {
      return this.barAlignmentFactor;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 67, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBarAlignmentFactor(double factor)
    {
      this.barAlignmentFactor = factor;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 89, (byte) 105, (byte) 143, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset dataset, PlotRenderingInfo info)
    {
      XYBarRenderer.XYBarRendererState barRendererState = new XYBarRenderer.XYBarRendererState(this, info);
      ValueAxis rangeAxisForDataset = plot.getRangeAxisForDataset(plot.indexOf(dataset));
      barRendererState.setG2Base(rangeAxisForDataset.valueToJava2D(this.@base, dataArea, plot.getRangeAxisEdge()));
      return (XYItemRendererState) barRendererState;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 108, (byte) 98, (byte) 103, (byte) 102, (byte) 104, (byte) 102, (byte) 103, (byte) 106, (byte) 100, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 104, (byte) 216, (byte) 178, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 103, (byte) 103, (byte) 109, (byte) 103, (byte) 104, (byte) 236, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      LegendItem legendItem = (LegendItem) null;
      XYPlot plot = this.getPlot();
      if (plot != null)
      {
        XYDataset dataset = plot.getDataset(datasetIndex);
        if (dataset != null)
        {
          string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
          string description = label;
          string toolTipText = (string) null;
          if (this.getLegendItemToolTipGenerator() != null)
            toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
          string urlText = (string) null;
          if (this.getLegendItemURLGenerator() != null)
            urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
          Shape shape = this.legendBar;
          Paint fillPaint = this.lookupSeriesPaint(series);
          Paint outlinePaint = this.lookupSeriesOutlinePaint(series);
          Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
          legendItem = !this.drawBarOutline ? new LegendItem(label, description, toolTipText, urlText, shape, fillPaint) : new LegendItem(label, description, toolTipText, urlText, shape, fillPaint, outlineStroke, outlinePaint);
          legendItem.setLabelFont(this.lookupLegendTextFont(series));
          Paint paint = this.lookupLegendTextPaint(series);
          if (paint != null)
            legendItem.setLabelPaint(paint);
          legendItem.setDataset((Dataset) dataset);
          legendItem.setDatasetIndex(datasetIndex);
          legendItem.setSeriesKey(dataset.getSeriesKey(series));
          legendItem.setSeriesIndex(series);
          if (this.getGradientPaintTransformer() != null)
            legendItem.setFillPaintTransformer(this.getGradientPaintTransformer());
        }
      }
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 187, (byte) 108, (byte) 129, (byte) 200, (byte) 104, (byte) 108, (byte) 174, (byte) 103, (byte) 140, (byte) 112, (byte) 129, (byte) 100, (byte) 112, (byte) 193, (byte) 112, (byte) 193, (byte) 146, (byte) 147, (byte) 107, (byte) 139, (byte) 109, (byte) 105, (byte) 129, (byte) 109, (byte) 105, (byte) 129, (byte) 102, (byte) 114, (byte) 193, (byte) 114, (byte) 225, (byte) 69, (byte) 122, (byte) 109, (byte) 104, (byte) 111, (byte) 168, (byte) 105, (byte) 143, (byte) 175, (byte) 183, (byte) 108, (byte) 109, (byte) 108, (byte) 104, (byte) 178, (byte) 99, (byte) 105, (byte) 137, (byte) 112, (byte) 112, (byte) 180, (byte) 137, (byte) 112, (byte) 112, (byte) 210, (byte) 106, (byte) 137, (byte) 105, (byte) 112, (byte) 169, (byte) 201, (byte) 112, (byte) 169, (byte) 167, (byte) 104, (byte) 191, (byte) 2, (byte) 149, (byte) 108, (byte) 140, (byte) 251, (byte) 69, (byte) 114, (byte) 110, (byte) 111, (byte) 148, (byte) 107, (byte) 107, (byte) 187, (byte) 104, (byte) 100, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
      double num1;
      double num2;
      if (this.useYInterval)
      {
        num1 = ntervalXyDataset.getStartYValue(series, item);
        num2 = ntervalXyDataset.getEndYValue(series, item);
      }
      else
      {
        num1 = this.@base;
        num2 = ntervalXyDataset.getYValue(series, item);
      }
      if (Double.isNaN(num1) || Double.isNaN(num2))
        return;
      if (num1 <= num2)
      {
        if (!rangeAxis.getRange().intersects(num1, num2))
          return;
      }
      else if (!rangeAxis.getRange().intersects(num2, num1))
        return;
      double num3 = rangeAxis.valueToJava2D(num1, dataArea, plot.getRangeAxisEdge());
      double num4 = rangeAxis.valueToJava2D(num2, dataArea, plot.getRangeAxisEdge());
      double num5 = Math.min(num3, num4);
      double num6 = Math.max(num3, num4);
      double num7 = ntervalXyDataset.getStartXValue(series, item);
      if (Double.isNaN(num7))
        return;
      double num8 = ntervalXyDataset.getEndXValue(series, item);
      if (Double.isNaN(num8))
        return;
      if (num7 <= num8)
      {
        if (!domainAxis.getRange().intersects(num7, num8))
          return;
      }
      else if (!domainAxis.getRange().intersects(num8, num7))
        return;
      if (this.barAlignmentFactor >= 0.0 && this.barAlignmentFactor <= 1.0)
      {
        double xvalue = ntervalXyDataset.getXValue(series, item);
        double num9 = num8 - num7;
        num7 = xvalue - num9 * this.barAlignmentFactor;
        num8 = num7 + num9;
      }
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      double num10 = domainAxis.valueToJava2D(num7, dataArea, domainAxisEdge);
      double num11 = domainAxis.valueToJava2D(num8, dataArea, domainAxisEdge);
      double num12 = Math.max(1.0, Math.abs(num11 - num10));
      double num13 = Math.min(num10, num11);
      if (this.getMargin() > 0.0)
      {
        double num9 = num12 * this.getMargin();
        num12 -= num9;
        num13 += num9 / 2.0;
      }
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num9 = Math.max(num5, ((RectangularShape) dataArea).getMinX());
        double num14 = Math.min(num6, ((RectangularShape) dataArea).getMaxX());
        @double = new Rectangle2D.Double(num9, num13, num14 - num9, num12);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double num9 = Math.max(num5, ((RectangularShape) dataArea).getMinY());
        double num14 = Math.min(num6, ((RectangularShape) dataArea).getMaxY());
        @double = new Rectangle2D.Double(num13, num9, num12, num14 - num9);
      }
      int num15 = num2 > 0.0 ? 1 : 0;
      int num16 = rangeAxis.isInverted() ? 1 : 0;
      RectangleEdge re = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (num15 != 0 && num16 == 0 || num15 == 0 && num16 != 0 ? RectangleEdge.__\u003C\u003EBOTTOM : RectangleEdge.__\u003C\u003ETOP) : (num15 != 0 && num16 != 0 || num15 == 0 && num16 == 0 ? RectangleEdge.__\u003C\u003ERIGHT : RectangleEdge.__\u003C\u003ELEFT);
      if (this.getShadowsVisible())
        this.barPainter.paintBarShadow(g2, this, series, item, (RectangularShape) @double, re, !this.useYInterval);
      this.barPainter.paintBar(g2, this, series, item, (RectangularShape) @double, re);
      if (this.isItemLabelVisible(series, item))
      {
        XYItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(series, item);
        this.drawItemLabel(g2, dataset, series, item, plot, itemLabelGenerator, (Rectangle2D) @double, num2 < 0.0);
      }
      double num17 = (num7 + num8) / 2.0;
      double yvalue = dataset.getYValue(series, item);
      double transX = domainAxis.valueToJava2D(num17, dataArea, domainAxisEdge);
      double transY = rangeAxis.valueToJava2D(yvalue, dataArea, plot.getRangeAxisEdge());
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, num17, yvalue, domainAxisIndex, rangeAxisIndex, transX, transY, plot.getOrientation());
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addEntity(entityCollection, (Shape) @double, dataset, series, item, 0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 43, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findDomainBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      return DatasetUtilities.findDomainBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 62, (byte) 99, (byte) 207})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      return DatasetUtilities.findRangeBounds(dataset, this.useYInterval);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 79, (byte) 108, (byte) 104, (byte) 182, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYBarRenderer xyBarRenderer = (XYBarRenderer) base.clone();
      if (this.gradientPaintTransformer != null)
        xyBarRenderer.gradientPaintTransformer = (GradientPaintTransformer) ObjectUtilities.clone((object) this.gradientPaintTransformer);
      xyBarRenderer.legendBar = ShapeUtilities.clone(this.legendBar);
      return (object) xyBarRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 96, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 179, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYBarRenderer))
        return false;
      XYBarRenderer xyBarRenderer = (XYBarRenderer) obj;
      if (this.@base != xyBarRenderer.@base || this.drawBarOutline != xyBarRenderer.drawBarOutline || (this.margin != xyBarRenderer.margin || this.useYInterval != xyBarRenderer.useYInterval) || (!ObjectUtilities.equal((object) this.gradientPaintTransformer, (object) xyBarRenderer.gradientPaintTransformer) || !ShapeUtilities.equal(this.legendBar, xyBarRenderer.legendBar) || (!ObjectUtilities.equal((object) this.positiveItemLabelPositionFallback, (object) xyBarRenderer.positiveItemLabelPositionFallback) || !ObjectUtilities.equal((object) this.negativeItemLabelPositionFallback, (object) xyBarRenderer.negativeItemLabelPositionFallback))) || (!Object.instancehelper_equals((object) this.barPainter, (object) xyBarRenderer.barPainter) || this.shadowsVisible != xyBarRenderer.shadowsVisible || (this.shadowXOffset != xyBarRenderer.shadowXOffset || this.shadowYOffset != xyBarRenderer.shadowYOffset) || this.barAlignmentFactor != xyBarRenderer.barAlignmentFactor))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 159, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendBar = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 171, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendBar, obj0);
    }

    [InnerClass]
    [SourceFile("XYBarRenderer.java")]
    public class XYBarRendererState : XYItemRendererState
    {
      private double g2Base;
      [Modifiers]
      private XYBarRenderer this\u00240;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 41, (byte) 135})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public XYBarRendererState(XYBarRenderer xybr, PlotRenderingInfo info)
        : base(info)
      {
        XYBarRenderer.XYBarRendererState barRendererState = this;
        this.this\u00240 = xybr;
      }

      public virtual void setG2Base(double value)
      {
        this.g2Base = value;
      }

      public virtual double getG2Base()
      {
        return this.g2Base;
      }
    }
  }
}
