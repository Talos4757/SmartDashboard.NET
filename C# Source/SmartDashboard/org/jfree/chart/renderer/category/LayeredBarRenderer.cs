// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.LayeredBarRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
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
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class LayeredBarRenderer : BarRenderer, Serializable.__Interface
  {
    private const long serialVersionUID = -8716572894780469487L;
    protected internal ObjectList seriesBarWidthList;

    [HideFromJava]
    static LayeredBarRenderer()
    {
      BarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LayeredBarRenderer()
    {
      LayeredBarRenderer layeredBarRenderer = this;
      this.seriesBarWidthList = new ObjectList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LayeredBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LayeredBarRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 108, (byte) 99, (byte) 193, (byte) 104, (byte) 102, (byte) 104, (byte) 105, (byte) 105, (byte) 101, (byte) 129, (byte) 99, (byte) 100, (byte) 164, (byte) 104, (byte) 101, (byte) 165, (byte) 100, (byte) 228, (byte) 69, (byte) 100, (byte) 129, (byte) 98, (byte) 101, (byte) 195, (byte) 105, (byte) 110, (byte) 110, (byte) 108, (byte) 173, (byte) 191, (byte) 12, (byte) 168, (byte) 103, (byte) 102, (byte) 103, (byte) 107, (byte) 105, (byte) 132, (byte) 108, (byte) 127, (byte) 0, (byte) 101, (byte) 181, (byte) 223, (byte) 18, (byte) 108, (byte) 104, (byte) 114, (byte) 151, (byte) 123, (byte) 168, (byte) 153, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 200, (byte) 140, (byte) 112, (byte) 249, (byte) 69, (byte) 104, (byte) 100, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHorizontalItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column)
    {
      Number number = dataset.getValue(row, column);
      if (number == null)
        return;
      double d1 = number.doubleValue();
      double d2 = 0.0;
      double lowerClip = this.getLowerClip();
      double upperClip = this.getUpperClip();
      if (upperClip <= 0.0)
      {
        if (d1 >= upperClip)
          return;
        d2 = upperClip;
        if (d1 <= lowerClip)
          d1 = lowerClip;
      }
      else if (lowerClip <= 0.0)
      {
        if (d1 >= upperClip)
          d1 = upperClip;
        else if (d1 <= lowerClip)
          d1 = lowerClip;
      }
      else
      {
        if (d1 <= lowerClip)
          return;
        d2 = lowerClip;
        if (d1 >= upperClip)
          d1 = upperClip;
      }
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      double num2 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      double num3 = Math.min(num1, num2);
      double num4 = Math.abs(num2 - num1);
      double num5 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      int rowCount = this.getRowCount();
      double num6 = 0.0;
      double num7 = 1.0;
      double seriesBarWidth = this.getSeriesBarWidth(row);
      if (!Double.isNaN(seriesBarWidth))
        num7 = seriesBarWidth;
      double num8 = num7 * state.getBarWidth();
      double num9 = num5 + (1.0 - num7) * state.getBarWidth() / 2.0;
      if (rowCount > 1)
        num6 = num8 * 0.2 / (double) (rowCount - 1);
      Rectangle2D.Double @double = new Rectangle2D.Double(num3, num9 + (double) (rowCount - 1 - row) * num6, num4, num8 - (double) (rowCount - 1 - row) * num6 * 2.0);
      object obj1 = (object) this.getItemPaint(row, column);
      GradientPaintTransformer paintTransformer = this.getGradientPaintTransformer();
      if (paintTransformer != null && (Paint) obj1 is GradientPaint)
        obj1 = (object) paintTransformer.transform((GradientPaint) obj1, (Shape) @double);
      Graphics2D graphics2D = g2;
      object obj2 = obj1;
      Paint paint1;
      if (obj2 != null)
      {
        Paint paint2 = obj2 as Paint;
        if (paint2 == null)
          throw new IncompatibleClassChangeError();
        paint1 = paint2;
      }
      else
        paint1 = (Paint) null;
      graphics2D.setPaint(paint1);
      g2.fill((Shape) @double);
      if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
      {
        Stroke itemOutlineStroke = this.getItemOutlineStroke(row, column);
        Paint itemOutlinePaint = this.getItemOutlinePaint(row, column);
        if (itemOutlineStroke != null && itemOutlinePaint != null)
        {
          g2.setStroke(itemOutlineStroke);
          g2.setPaint(itemOutlinePaint);
          g2.draw((Shape) @double);
        }
      }
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, num1 > num2);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 247, (byte) 108, (byte) 99, (byte) 193, (byte) 191, (byte) 11, (byte) 167, (byte) 104, (byte) 103, (byte) 105, (byte) 137, (byte) 105, (byte) 101, (byte) 129, (byte) 100, (byte) 104, (byte) 165, (byte) 105, (byte) 101, (byte) 165, (byte) 101, (byte) 229, (byte) 69, (byte) 101, (byte) 129, (byte) 105, (byte) 101, (byte) 195, (byte) 105, (byte) 111, (byte) 110, (byte) 140, (byte) 104, (byte) 173, (byte) 103, (byte) 102, (byte) 103, (byte) 107, (byte) 105, (byte) 132, (byte) 108, (byte) 125, (byte) 132, (byte) 180, (byte) 191, (byte) 15, (byte) 108, (byte) 104, (byte) 114, (byte) 151, (byte) 123, (byte) 168, (byte) 153, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 232, (byte) 69, (byte) 111, (byte) 142, (byte) 140, (byte) 112, (byte) 249, (byte) 69, (byte) 104, (byte) 100, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawVerticalItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column)
    {
      Number number = dataset.getValue(row, column);
      if (number == null)
        return;
      double num1 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      int rowCount = this.getRowCount();
      double d1 = number.doubleValue();
      double d2 = 0.0;
      double lowerClip = this.getLowerClip();
      double upperClip = this.getUpperClip();
      if (upperClip <= 0.0)
      {
        if (d1 >= upperClip)
          return;
        d2 = upperClip;
        if (d1 <= lowerClip)
          d1 = lowerClip;
      }
      else if (lowerClip <= 0.0)
      {
        if (d1 >= upperClip)
          d1 = upperClip;
        else if (d1 <= lowerClip)
          d1 = lowerClip;
      }
      else
      {
        if (d1 <= lowerClip)
          return;
        d2 = this.getLowerClip();
        if (d1 >= upperClip)
          d1 = upperClip;
      }
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num2 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      double num3 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      double num4 = Math.min(num3, num2);
      state.getBarWidth();
      double num5 = Math.abs(num3 - num2);
      double num6 = 0.0;
      double num7 = 1.0;
      double seriesBarWidth = this.getSeriesBarWidth(row);
      if (!Double.isNaN(seriesBarWidth))
        num7 = seriesBarWidth;
      double num8 = num7 * state.getBarWidth();
      double num9 = num1 + (1.0 - num7) * state.getBarWidth() / 2.0;
      if (rowCount > 1)
        num6 = num8 * 0.2 / (double) (rowCount - 1);
      Rectangle2D.Double @double = new Rectangle2D.Double(num9 + (double) (rowCount - 1 - row) * num6, num4, num8 - (double) (rowCount - 1 - row) * num6 * 2.0, num5);
      object obj1 = (object) this.getItemPaint(row, column);
      GradientPaintTransformer paintTransformer = this.getGradientPaintTransformer();
      if (paintTransformer != null && (Paint) obj1 is GradientPaint)
        obj1 = (object) paintTransformer.transform((GradientPaint) obj1, (Shape) @double);
      Graphics2D graphics2D = g2;
      object obj2 = obj1;
      Paint paint1;
      if (obj2 != null)
      {
        Paint paint2 = obj2 as Paint;
        if (paint2 == null)
          throw new IncompatibleClassChangeError();
        paint1 = paint2;
      }
      else
        paint1 = (Paint) null;
      graphics2D.setPaint(paint1);
      g2.fill((Shape) @double);
      if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
      {
        Stroke itemOutlineStroke = this.getItemOutlineStroke(row, column);
        Paint itemOutlinePaint = this.getItemOutlinePaint(row, column);
        if (itemOutlineStroke != null && itemOutlinePaint != null)
        {
          g2.setStroke(itemOutlineStroke);
          g2.setPaint(itemOutlinePaint);
          g2.draw((Shape) @double);
        }
      }
      double num10 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      double num11 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, num10 > num11);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 106, (byte) 114, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getSeriesBarWidth(int series)
    {
      double num = double.NaN;
      Number number = (Number) this.seriesBarWidthList.get(series);
      if (number != null)
        num = number.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesBarWidth(int series, double width)
    {
      this.seriesBarWidthList.set(series, (object) new Double(width));
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 105, (byte) 104, (byte) 102, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 105, (byte) 137, (byte) 108, (byte) 103, (byte) 100, (byte) 137, (byte) 156, (byte) 102, (byte) 218, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void calculateBarWidth(CategoryPlot plot, Rectangle2D dataArea, int rendererIndex, CategoryItemRendererState state)
    {
      CategoryAxis domainAxis = this.getDomainAxis(plot, rendererIndex);
      CategoryDataset dataset = plot.getDataset(rendererIndex);
      if (dataset == null)
        return;
      int columnCount = dataset.getColumnCount();
      int rowCount = dataset.getRowCount();
      double num1 = 0.0;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num1 = ((RectangularShape) dataArea).getHeight();
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        num1 = ((RectangularShape) dataArea).getWidth();
      double num2 = num1 * this.getMaximumBarWidth();
      double num3 = 0.0;
      if (columnCount > 1)
        num3 = domainAxis.getCategoryMargin();
      double num4 = num1 * (1.0 - domainAxis.getLowerMargin() - domainAxis.getUpperMargin() - num3);
      if (rowCount * columnCount > 0)
        state.setBarWidth(Math.min(num4 / (double) dataset.getColumnCount(), num2));
      else
        state.setBarWidth(Math.min(num4, num2));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 104, (byte) 104, (byte) 183, (byte) 104, (byte) 215})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset data, int row, int column, int pass)
    {
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        this.drawHorizontalItem(g2, state, dataArea, plot, domainAxis, rangeAxis, data, row, column);
      }
      else
      {
        if (orientation != PlotOrientation.__\u003C\u003EVERTICAL)
          return;
        this.drawVerticalItem(g2, state, dataArea, plot, domainAxis, rangeAxis, data, row, column);
      }
    }
  }
}
