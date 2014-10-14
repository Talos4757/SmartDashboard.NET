// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.LevelRenderer
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
using org.jfree.chart.plot;
using org.jfree.data.category;
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
  public class LevelRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -8204856624355025117L;
    public const double DEFAULT_ITEM_MARGIN = 0.2;
    private double itemMargin;
    private double maxItemWidth;

    [HideFromJava]
    static LevelRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 104, (byte) 112, (byte) 140, (byte) 191, (byte) 0, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LevelRenderer()
    {
      LevelRenderer levelRenderer = this;
      this.itemMargin = 0.2;
      this.maxItemWidth = 1.0;
      this.setBaseLegendShape((Shape) new Rectangle2D.Float(-5f, -1f, 10f, 2f));
      this.setBaseOutlinePaint((Paint) new Color(0, 0, 0, 0));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LevelRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LevelRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LevelRenderer obj0)
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

    [Obsolete]
    public virtual double getMaxItemWidth()
    {
      return this.maxItemWidth;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaxItemWidth(double percent)
    {
      this.maxItemWidth = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 105, (byte) 104, (byte) 102, (byte) 103, (byte) 154, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 105, (byte) 137, (byte) 108, (byte) 103, (byte) 103, (byte) 100, (byte) 137, (byte) 100, (byte) 137, (byte) 191, (byte) 0, (byte) 102, (byte) 183, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void calculateItemWidth(CategoryPlot plot, Rectangle2D dataArea, int rendererIndex, CategoryItemRendererState state)
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
      double num3 = num2 * this.getMaximumItemWidth();
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

    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMaximumItemWidth()
    {
      return this.getMaxItemWidth();
    }

    public virtual double getItemMargin()
    {
      return this.itemMargin;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 15, (byte) 156, (byte) 100, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateSeriesWidth(double space, CategoryAxis axis, int categories, int series)
    {
      double num = 1.0 - this.getItemMargin() - axis.getLowerMargin() - axis.getUpperMargin();
      if (categories > 1)
        num -= axis.getCategoryMargin();
      return space * num / (double) (categories * series);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 102, (byte) 104, (byte) 170, (byte) 136, (byte) 152, (byte) 104, (byte) 100, (byte) 135, (byte) 103, (byte) 100, (byte) 146, (byte) 142, (byte) 159, (byte) 13, (byte) 130, (byte) 223, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateBarW0(CategoryPlot plot, PlotOrientation orientation, Rectangle2D dataArea, CategoryAxis domainAxis, CategoryItemRendererState state, int row, int column)
    {
      double space = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? ((RectangularShape) dataArea).getWidth() : ((RectangularShape) dataArea).getHeight();
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      int series = state.getVisibleSeriesCount();
      if (series < 0)
        series = this.getRowCount();
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

    [LineNumberTable(new byte[] {(byte) 85, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemMargin(double percent)
    {
      this.itemMargin = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumItemWidth(double percent)
    {
      this.setMaxItemWidth(percent);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 142, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CategoryItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, CategoryPlot plot, int rendererIndex, PlotRenderingInfo info)
    {
      CategoryItemRendererState state = base.initialise(g2, dataArea, plot, rendererIndex, info);
      this.calculateItemWidth(plot, dataArea, rendererIndex, state);
      return state;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 105, (byte) 100, (byte) 193, (byte) 108, (byte) 99, (byte) 161, (byte) 136, (byte) 104, (byte) 147, (byte) 105, (byte) 174, (byte) 98, (byte) 102, (byte) 102, (byte) 104, (byte) 100, (byte) 118, (byte) 216, (byte) 118, (byte) 100, (byte) 182, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 136, (byte) 140, (byte) 112, (byte) 250, (byte) 69, (byte) 107, (byte) 255, (byte) 7, (byte) 69, (byte) 104, (byte) 100, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
      if (visibleSeriesIndex < 0)
        return;
      Number number = dataset.getValue(row, column);
      if (number == null)
        return;
      double d = number.doubleValue();
      PlotOrientation orientation = plot.getOrientation();
      double transX = this.calculateBarW0(plot, orientation, dataArea, domainAxis, state, visibleSeriesIndex, column);
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double transY = rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
      double x;
      double y;
      Line2D.Double @double;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        x = transY;
        y = transX + state.getBarWidth() / 2.0;
        @double = new Line2D.Double(transY, transX, transY, transX + state.getBarWidth());
      }
      else
      {
        x = transX + state.getBarWidth() / 2.0;
        y = transY;
        @double = new Line2D.Double(transX, transY, transX + state.getBarWidth(), transY);
      }
      Stroke itemStroke = this.getItemStroke(row, column);
      Paint itemPaint = this.getItemPaint(row, column);
      g2.setStroke(itemStroke);
      g2.setPaint(itemPaint);
      g2.draw((Shape) @double);
      if (this.getItemLabelGenerator(row, column) != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, orientation, dataset, row, column, x, y, d < 0.0);
      int datasetIndex = plot.indexOf(dataset);
      this.updateCrosshairValues(state.getCrosshairState(), dataset.getRowKey(row), dataset.getColumnKey(column), d, datasetIndex, transX, transY, orientation);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) ((Line2D) @double).getBounds());
    }

    [LineNumberTable((ushort) 410)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getItemMiddle(IComparable rowKey, IComparable columnKey, CategoryDataset dataset, CategoryAxis axis, Rectangle2D area, RectangleEdge edge)
    {
      return axis.getCategorySeriesMiddle(columnKey, rowKey, dataset, this.itemMargin, area, edge);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 52, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LevelRenderer))
        return false;
      LevelRenderer levelRenderer = (LevelRenderer) obj;
      if (this.itemMargin != levelRenderer.itemMargin || this.maxItemWidth != levelRenderer.maxItemWidth)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 103, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(base.hashCode(), this.itemMargin), this.maxItemWidth);
    }
  }
}
