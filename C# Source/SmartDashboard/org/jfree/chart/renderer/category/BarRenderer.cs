// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.BarRenderer
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
using org.jfree.data.category;
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

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class BarRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 6000649414965887481L;
    public const double DEFAULT_ITEM_MARGIN = 0.2;
    public const double BAR_OUTLINE_WIDTH_THRESHOLD = 3.0;
    private static BarPainter defaultBarPainter;
    private static bool defaultShadowsVisible;
    private double itemMargin;
    private bool drawBarOutline;
    private double maximumBarWidth;
    private double minimumBarLength;
    private GradientPaintTransformer gradientPaintTransformer;
    private ItemLabelPosition positiveItemLabelPositionFallback;
    private ItemLabelPosition negativeItemLabelPositionFallback;
    private double upperClip;
    private double lowerClip;
    private double @base;
    private bool includeBaseInRange;
    private BarPainter barPainter;
    private bool shadowsVisible;
    [NonSerialized]
    private Paint shadowPaint;
    private double shadowXOffset;
    private double shadowYOffset;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 165, (byte) 234, (byte) 94})]
    static BarRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
      BarRenderer.defaultBarPainter = (BarPainter) new GradientBarPainter();
      BarRenderer.defaultShadowsVisible = true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 104, (byte) 108, (byte) 103, (byte) 112, (byte) 103, (byte) 140, (byte) 103, (byte) 103, (byte) 107, (byte) 108, (byte) 127, (byte) 16, (byte) 107, (byte) 107, (byte) 107, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BarRenderer()
    {
      BarRenderer barRenderer = this;
      this.@base = 0.0;
      this.includeBaseInRange = true;
      this.itemMargin = 0.2;
      this.drawBarOutline = false;
      this.maximumBarWidth = 1.0;
      this.positiveItemLabelPositionFallback = (ItemLabelPosition) null;
      this.negativeItemLabelPositionFallback = (ItemLabelPosition) null;
      this.gradientPaintTransformer = (GradientPaintTransformer) new StandardGradientPaintTransformer();
      this.minimumBarLength = 0.0;
      this.setBaseLegendShape((Shape) new Rectangle2D.Double(-4.0, -4.0, 8.0, 8.0));
      this.barPainter = BarRenderer.getDefaultBarPainter();
      this.shadowsVisible = BarRenderer.getDefaultShadowsVisible();
      this.shadowPaint = (Paint) Color.gray;
      this.shadowXOffset = 4.0;
      this.shadowYOffset = 4.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BarRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BarRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 99, (byte) 144, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setDefaultBarPainter(BarPainter painter)
    {
      if (painter == null)
      {
        string str = "Null 'painter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        BarRenderer.defaultBarPainter = painter;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 231, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBarPainter(BarPainter painter)
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 241, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowVisible(bool visible)
    {
      this.shadowsVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 31, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.shadowPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 43, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawBarOutline(bool draw)
    {
      this.drawBarOutline = draw;
      this.fireChangeEvent();
    }

    public static BarPainter getDefaultBarPainter()
    {
      return BarRenderer.defaultBarPainter;
    }

    public static bool getDefaultShadowsVisible()
    {
      return BarRenderer.defaultShadowsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 155, (byte) 105, (byte) 104, (byte) 102, (byte) 103, (byte) 154, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 105, (byte) 137, (byte) 108, (byte) 103, (byte) 103, (byte) 100, (byte) 137, (byte) 100, (byte) 137, (byte) 191, (byte) 0, (byte) 102, (byte) 183, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void calculateBarWidth(CategoryPlot plot, Rectangle2D dataArea, int rendererIndex, CategoryItemRendererState state)
    {
      CategoryAxis domainAxis = this.getDomainAxis(plot, rendererIndex);
      CategoryDataset dataset = plot.getDataset(rendererIndex);
      if (dataset == null)
        return;
      int columnCount = dataset.getColumnCount();
      int num1 = state.getVisibleSeriesCount() < 0 ? dataset.getRowCount() : state.getVisibleSeriesCount();
      double num2 = 0.0;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num2 = ((RectangularShape) dataArea).getHeight();
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        num2 = ((RectangularShape) dataArea).getWidth();
      double num3 = num2 * this.getMaximumBarWidth();
      double num4 = 0.0;
      double num5 = 0.0;
      if (columnCount > 1)
        num4 = domainAxis.getCategoryMargin();
      if (num1 > 1)
        num5 = this.getItemMargin();
      double num6 = num2 * (1.0 - domainAxis.getLowerMargin() - domainAxis.getUpperMargin() - num4 - num5);
      if (num1 * columnCount > 0)
        state.setBarWidth(Math.min(num6 / (double) (num1 * columnCount), num3));
      else
        state.setBarWidth(Math.min(num6, num3));
    }

    public virtual double getMaximumBarWidth()
    {
      return this.maximumBarWidth;
    }

    public virtual double getItemMargin()
    {
      return this.itemMargin;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 226, (byte) 156, (byte) 100, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateSeriesWidth(double space, CategoryAxis axis, int categories, int series)
    {
      double num = 1.0 - this.getItemMargin() - axis.getLowerMargin() - axis.getUpperMargin();
      if (categories > 1)
        num -= axis.getCategoryMargin();
      return space * num / (double) (categories * series);
    }

    public virtual double getLowerClip()
    {
      return this.lowerClip;
    }

    public virtual double getUpperClip()
    {
      return this.upperClip;
    }

    public virtual bool isDrawBarOutline()
    {
      return this.drawBarOutline;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 213, (byte) 102, (byte) 104, (byte) 170, (byte) 136, (byte) 152, (byte) 154, (byte) 103, (byte) 100, (byte) 146, (byte) 142, (byte) 159, (byte) 13, (byte) 130, (byte) 223, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateBarW0(CategoryPlot plot, PlotOrientation orientation, Rectangle2D dataArea, CategoryAxis domainAxis, CategoryItemRendererState state, int row, int column)
    {
      double space = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? ((RectangularShape) dataArea).getWidth() : ((RectangularShape) dataArea).getHeight();
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      int series = state.getVisibleSeriesCount() < 0 ? this.getRowCount() : state.getVisibleSeriesCount();
      int columnCount = this.getColumnCount();
      double num1;
      if (series > 1)
      {
        double num2 = space * this.getItemMargin() / (double) (columnCount * (series - 1));
        double num3 = this.calculateSeriesWidth(space, domainAxis, columnCount, series);
        num1 = categoryStart + (double) row * (num3 + num2) + num3 / 2.0 - state.getBarWidth() / 2.0;
      }
      else
        num1 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      return num1;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 250, (byte) 104, (byte) 104, (byte) 111, (byte) 111, (byte) 100, (byte) 130, (byte) 100, (byte) 130, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double[] calculateBarL0L1(double value)
    {
      double lowerClip = this.getLowerClip();
      double upperClip = this.getUpperClip();
      double num1 = Math.min(this.@base, value);
      double num2 = Math.max(this.@base, value);
      if (num2 < lowerClip)
        return (double[]) null;
      if (num1 > upperClip)
        return (double[]) null;
      double num3 = Math.max(num1, lowerClip);
      double num4 = Math.min(num2, upperClip);
      double[] numArray = new double[2];
      int index1 = 0;
      double num5 = num3;
      numArray[index1] = num5;
      int index2 = 1;
      double num6 = num4;
      numArray[index2] = num6;
      return numArray;
    }

    public virtual double getMinimumBarLength()
    {
      return this.minimumBarLength;
    }

    public virtual bool getShadowsVisible()
    {
      return this.shadowsVisible;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 114, (byte) 131, (byte) 108, (byte) 99, (byte) 161, (byte) 106, (byte) 103, (byte) 106, (byte) 167, (byte) 98, (byte) 99, (byte) 173, (byte) 203, (byte) 184, (byte) 114, (byte) 255, (byte) 15, (byte) 69, (byte) 100, (byte) 112, (byte) 99, (byte) 170, (byte) 136, (byte) 100, (byte) 248, (byte) 73, (byte) 100, (byte) 255, (byte) 15, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItemLabel(Graphics2D g2, CategoryDataset data, int row, int column, CategoryPlot plot, CategoryItemLabelGenerator generator, Rectangle2D bar, bool negative)
    {
      int num = negative ? 1 : 0;
      string text = generator.generateLabel(data, row, column);
      if (text == null)
        return;
      Font itemLabelFont = this.getItemLabelFont(row, column);
      ((Graphics) g2).setFont(itemLabelFont);
      Paint itemLabelPaint = this.getItemLabelPaint(row, column);
      g2.setPaint(itemLabelPaint);
      ItemLabelPosition itemLabelPosition = num != 0 ? this.getNegativeItemLabelPosition(row, column) : this.getPositiveItemLabelPosition(row, column);
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 68, (byte) 98, (byte) 104, (byte) 106, (byte) 104, (byte) 107, (byte) 105, (byte) 107, (byte) 105, (byte) 139, (byte) 107, (byte) 105, (byte) 107, (byte) 105, (byte) 107, (byte) 105, (byte) 139, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 143, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 104, (byte) 139, (byte) 104, (byte) 139, (byte) 104, (byte) 139, (byte) 104, (byte) 170})]
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

    [LineNumberTable((ushort) 1312)]
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
      BarRenderer.defaultShadowsVisible = visible;
    }

    public virtual double getBase()
    {
      return this.@base;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 233, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBase(double @base)
    {
      this.@base = @base;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 4, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemMargin(double percent)
    {
      this.itemMargin = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumBarWidth(double percent)
    {
      this.maximumBarWidth = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 85, (byte) 105, (byte) 144, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMinimumBarLength(double min)
    {
      if (min < 0.0)
      {
        string str = "Requires 'min' >= 0.0";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.minimumBarLength = min;
        this.fireChangeEvent();
      }
    }

    public virtual GradientPaintTransformer getGradientPaintTransformer()
    {
      return this.gradientPaintTransformer;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 114, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGradientPaintTransformer(GradientPaintTransformer transformer)
    {
      this.gradientPaintTransformer = transformer;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 141, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPositiveItemLabelPositionFallback(ItemLabelPosition position)
    {
      this.positiveItemLabelPositionFallback = position;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 168, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNegativeItemLabelPositionFallback(ItemLabelPosition position)
    {
      this.negativeItemLabelPositionFallback = position;
      this.fireChangeEvent();
    }

    public virtual bool getIncludeBaseInRange()
    {
      return this.includeBaseInRange;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 0, (byte) 162, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIncludeBaseInRange(bool include)
    {
      int num = include ? 1 : 0;
      if ((this.includeBaseInRange ? 1 : 0) == num)
        return;
      this.includeBaseInRange = num != 0;
      this.fireChangeEvent();
    }

    public virtual BarPainter getBarPainter()
    {
      return this.barPainter;
    }

    public virtual Paint getShadowPaint()
    {
      return this.shadowPaint;
    }

    public virtual double getShadowXOffset()
    {
      return this.shadowXOffset;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 58, (byte) 105, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 82, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShadowYOffset(double offset)
    {
      this.shadowYOffset = offset;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 127, (byte) 206, (byte) 105, (byte) 114, (byte) 178, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CategoryItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, CategoryPlot plot, int rendererIndex, PlotRenderingInfo info)
    {
      CategoryItemRendererState state = base.initialise(g2, dataArea, plot, rendererIndex, info);
      ValueAxis rangeAxisForDataset = plot.getRangeAxisForDataset(rendererIndex);
      this.lowerClip = rangeAxisForDataset.getRange().getLowerBound();
      this.upperClip = rangeAxisForDataset.getRange().getUpperBound();
      this.calculateBarWidth(plot, dataArea, rendererIndex, state);
      return state;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 21, (byte) 99, (byte) 130, (byte) 103, (byte) 99, (byte) 104, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      Range range = DatasetUtilities.findRangeBounds(dataset);
      if (range != null && this.includeBaseInRange)
        range = Range.expandToInclude(range, this.@base);
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 43, (byte) 103, (byte) 99, (byte) 194, (byte) 114, (byte) 162, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 223, (byte) 24, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 110, (byte) 104, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      CategoryPlot plot = this.getPlot();
      if (plot == null)
        return (LegendItem) null;
      if (!this.isSeriesVisible(series) || !this.isSeriesVisibleInLegend(series))
        return (LegendItem) null;
      CategoryDataset dataset = plot.getDataset(datasetIndex);
      string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
      string description = label;
      string toolTipText = (string) null;
      if (this.getLegendItemToolTipGenerator() != null)
        toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
      string urlText = (string) null;
      if (this.getLegendItemURLGenerator() != null)
        urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
      Shape shape = this.lookupLegendShape(series);
      Paint fillPaint = this.lookupSeriesPaint(series);
      Paint outlinePaint = this.lookupSeriesOutlinePaint(series);
      Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
      LegendItem.__\u003Cclinit\u003E();
      LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, true, shape, true, fillPaint, this.isDrawBarOutline(), outlinePaint, outlineStroke, false, (Shape) new Line2D.Float(), (Stroke) new BasicStroke(1f), (Paint) Color.black);
      legendItem.setLabelFont(this.lookupLegendTextFont(series));
      Paint paint = this.lookupLegendTextPaint(series);
      if (paint != null)
        legendItem.setLabelPaint(paint);
      legendItem.setDataset((Dataset) dataset);
      legendItem.setDatasetIndex(datasetIndex);
      legendItem.setSeriesKey(dataset.getRowKey(series));
      legendItem.setSeriesIndex(series);
      if (this.gradientPaintTransformer != null)
        legendItem.setFillPaintTransformer(this.gradientPaintTransformer);
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 118, (byte) 105, (byte) 100, (byte) 161, (byte) 108, (byte) 99, (byte) 161, (byte) 104, (byte) 104, (byte) 147, (byte) 105, (byte) 100, (byte) 161, (byte) 105, (byte) 113, (byte) 241, (byte) 73, (byte) 110, (byte) 105, (byte) 108, (byte) 109, (byte) 103, (byte) 115, (byte) 140, (byte) 135, (byte) 104, (byte) 112, (byte) 100, (byte) 169, (byte) 201, (byte) 112, (byte) 100, (byte) 169, (byte) 231, (byte) 69, (byte) 98, (byte) 104, (byte) 219, (byte) 185, (byte) 104, (byte) 182, (byte) 149, (byte) 140, (byte) 112, (byte) 251, (byte) 69, (byte) 107, (byte) 255, (byte) 7, (byte) 69, (byte) 104, (byte) 100, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
      if (visibleSeriesIndex < 0)
        return;
      Number number = dataset.getValue(row, column);
      if (number == null)
        return;
      double num1 = number.doubleValue();
      PlotOrientation orientation = plot.getOrientation();
      double transX = this.calculateBarW0(plot, orientation, dataArea, domainAxis, state, visibleSeriesIndex, column);
      double[] numArray = this.calculateBarL0L1(num1);
      if (numArray == null)
        return;
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num2 = rangeAxis.valueToJava2D(numArray[0], dataArea, rangeAxisEdge);
      double num3 = rangeAxis.valueToJava2D(numArray[1], dataArea, rangeAxisEdge);
      int num4 = num1 >= this.@base ? 1 : 0;
      int num5 = rangeAxis.isInverted() ? 1 : 0;
      double transY = Math.min(num2, num3);
      double num6 = Math.abs(num3 - num2);
      double num7 = 0.0;
      if (num6 > 0.0 && num6 < this.getMinimumBarLength())
        num7 = this.getMinimumBarLength() - num6;
      double num8 = 0.0;
      RectangleEdge re;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        if (num4 != 0 && num5 != 0 || num4 == 0 && num5 == 0)
        {
          num8 = num7;
          re = RectangleEdge.__\u003C\u003ERIGHT;
        }
        else
          re = RectangleEdge.__\u003C\u003ELEFT;
      }
      else if (num4 != 0 && num5 == 0 || num4 == 0 && num5 != 0)
      {
        num8 = num7;
        re = RectangleEdge.__\u003C\u003EBOTTOM;
      }
      else
        re = RectangleEdge.__\u003C\u003ETOP;
      Rectangle2D.Double @double = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? new Rectangle2D.Double(transX, transY - num8, state.getBarWidth(), num6 + num7) : new Rectangle2D.Double(transY - num8, transX, num6 + num7, state.getBarWidth());
      if (this.getShadowsVisible())
        this.barPainter.paintBarShadow(g2, this, row, column, (RectangularShape) @double, re, true);
      this.barPainter.paintBar(g2, this, row, column, (RectangularShape) @double, re);
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, num1 < 0.0);
      int datasetIndex = plot.indexOf(dataset);
      this.updateCrosshairValues(state.getCrosshairState(), dataset.getRowKey(row), dataset.getColumnKey(column), num1, datasetIndex, transX, transY, orientation);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 197, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BarRenderer))
        return false;
      BarRenderer barRenderer = (BarRenderer) obj;
      if (this.@base != barRenderer.@base || this.itemMargin != barRenderer.itemMargin || (this.drawBarOutline != barRenderer.drawBarOutline || this.maximumBarWidth != barRenderer.maximumBarWidth) || (this.minimumBarLength != barRenderer.minimumBarLength || !ObjectUtilities.equal((object) this.gradientPaintTransformer, (object) barRenderer.gradientPaintTransformer) || (!ObjectUtilities.equal((object) this.positiveItemLabelPositionFallback, (object) barRenderer.positiveItemLabelPositionFallback) || !ObjectUtilities.equal((object) this.negativeItemLabelPositionFallback, (object) barRenderer.negativeItemLabelPositionFallback))) || (!Object.instancehelper_equals((object) this.barPainter, (object) barRenderer.barPainter) || this.shadowsVisible != barRenderer.shadowsVisible || (!PaintUtilities.equal(this.shadowPaint, barRenderer.shadowPaint) || this.shadowXOffset != barRenderer.shadowXOffset) || this.shadowYOffset != barRenderer.shadowYOffset))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 1, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.shadowPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 15, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.shadowPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
