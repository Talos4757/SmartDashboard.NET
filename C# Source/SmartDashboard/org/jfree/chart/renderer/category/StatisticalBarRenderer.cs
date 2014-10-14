// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.StatisticalBarRenderer
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
using org.jfree.data.category;
using org.jfree.data.statistics;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"org.jfree.chart.renderer.category.CategoryItemRenderer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StatisticalBarRenderer : BarRenderer, CategoryItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -4986038395414039117L;
    [NonSerialized]
    private Paint errorIndicatorPaint;
    [NonSerialized]
    private Stroke errorIndicatorStroke;

    [HideFromJava]
    static StatisticalBarRenderer()
    {
      BarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 104, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StatisticalBarRenderer()
    {
      StatisticalBarRenderer statisticalBarRenderer = this;
      this.errorIndicatorPaint = (Paint) Color.gray;
      this.errorIndicatorStroke = (Stroke) new BasicStroke(1f);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StatisticalBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StatisticalBarRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StatisticalBarRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorIndicatorPaint(Paint paint)
    {
      this.errorIndicatorPaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 142, (byte) 168, (byte) 179, (byte) 152, (byte) 103, (byte) 100, (byte) 151, (byte) 113, (byte) 130, (byte) 206, (byte) 109, (byte) 100, (byte) 129, (byte) 106, (byte) 103, (byte) 105, (byte) 137, (byte) 105, (byte) 102, (byte) 129, (byte) 100, (byte) 105, (byte) 166, (byte) 105, (byte) 102, (byte) 166, (byte) 102, (byte) 230, (byte) 69, (byte) 102, (byte) 129, (byte) 105, (byte) 102, (byte) 196, (byte) 105, (byte) 111, (byte) 143, (byte) 140, (byte) 105, (byte) 141, (byte) 142, (byte) 108, (byte) 104, (byte) 114, (byte) 151, (byte) 123, (byte) 168, (byte) 153, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 232, (byte) 69, (byte) 109, (byte) 103, (byte) 106, (byte) 151, (byte) 183, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 174, (byte) 144, (byte) 98, (byte) 159, (byte) 8, (byte) 104, (byte) 159, (byte) 8, (byte) 104, (byte) 159, (byte) 8, (byte) 168, (byte) 140, (byte) 112, (byte) 252, (byte) 69, (byte) 104, (byte) 100, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHorizontalItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, StatisticalCategoryDataset dataset, int visibleRow, int row, int column)
    {
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, domainAxisEdge);
      int num1 = state.getVisibleSeriesCount() < 0 ? this.getRowCount() : state.getVisibleSeriesCount();
      int columnCount = this.getColumnCount();
      double num2;
      if (num1 > 1)
      {
        double num3 = ((RectangularShape) dataArea).getHeight() * this.getItemMargin() / (double) (columnCount * (num1 - 1));
        num2 = categoryStart + (double) visibleRow * (state.getBarWidth() + num3);
      }
      else
        num2 = categoryStart + (double) visibleRow * state.getBarWidth();
      Number meanValue = dataset.getMeanValue(row, column);
      if (meanValue == null)
        return;
      double d1 = meanValue.doubleValue();
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
      double num4 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      double num5 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      double num6 = Math.min(num5, num4);
      double barWidth = state.getBarWidth();
      double num7 = Math.abs(num5 - num4);
      Rectangle2D.Double double1 = new Rectangle2D.Double(num6, num2, num7, barWidth);
      object obj1 = (object) this.getItemPaint(row, column);
      GradientPaintTransformer paintTransformer = this.getGradientPaintTransformer();
      if (paintTransformer != null && (Paint) obj1 is GradientPaint)
        obj1 = (object) paintTransformer.transform((GradientPaint) obj1, (Shape) double1);
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
      g2.fill((Shape) double1);
      if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
      {
        Stroke itemOutlineStroke = this.getItemOutlineStroke(row, column);
        Paint itemOutlinePaint = this.getItemOutlinePaint(row, column);
        if (itemOutlineStroke != null && itemOutlinePaint != null)
        {
          g2.setStroke(itemOutlineStroke);
          g2.setPaint(itemOutlinePaint);
          g2.draw((Shape) double1);
        }
      }
      Number stdDevValue = dataset.getStdDevValue(row, column);
      if (stdDevValue != null)
      {
        double num3 = stdDevValue.doubleValue();
        double num8 = rangeAxis.valueToJava2D(meanValue.doubleValue() + num3, dataArea, rangeAxisEdge);
        double num9 = rangeAxis.valueToJava2D(meanValue.doubleValue() - num3, dataArea, rangeAxisEdge);
        if (this.errorIndicatorPaint != null)
          g2.setPaint(this.errorIndicatorPaint);
        else
          g2.setPaint(this.getItemOutlinePaint(row, column));
        if (this.errorIndicatorStroke != null)
          g2.setStroke(this.errorIndicatorStroke);
        else
          g2.setStroke(this.getItemOutlineStroke(row, column));
        Line2D.Double double2 = new Line2D.Double(num9, num2 + barWidth / 2.0, num8, num2 + barWidth / 2.0);
        g2.draw((Shape) double2);
        Line2D.Double double3 = new Line2D.Double(num8, num2 + barWidth * 0.25, num8, num2 + barWidth * 0.75);
        g2.draw((Shape) double3);
        Line2D.Double double4 = new Line2D.Double(num9, num2 + barWidth * 0.25, num9, num2 + barWidth * 0.75);
        g2.draw((Shape) double4);
      }
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, (CategoryDataset) dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) double1, d1 < 0.0);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, (CategoryDataset) dataset, row, column, (Shape) double1);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 47, (byte) 168, (byte) 179, (byte) 152, (byte) 103, (byte) 100, (byte) 151, (byte) 113, (byte) 130, (byte) 206, (byte) 109, (byte) 100, (byte) 161, (byte) 106, (byte) 103, (byte) 105, (byte) 137, (byte) 105, (byte) 102, (byte) 129, (byte) 100, (byte) 105, (byte) 166, (byte) 105, (byte) 102, (byte) 166, (byte) 102, (byte) 230, (byte) 69, (byte) 102, (byte) 129, (byte) 105, (byte) 102, (byte) 196, (byte) 105, (byte) 111, (byte) 143, (byte) 140, (byte) 105, (byte) 141, (byte) 142, (byte) 108, (byte) 104, (byte) 114, (byte) 151, (byte) 123, (byte) 136, (byte) 153, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 232, (byte) 69, (byte) 109, (byte) 103, (byte) 106, (byte) 151, (byte) 183, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 174, (byte) 176, (byte) 98, (byte) 159, (byte) 8, (byte) 104, (byte) 159, (byte) 28, (byte) 104, (byte) 159, (byte) 28, (byte) 168, (byte) 140, (byte) 112, (byte) 252, (byte) 69, (byte) 104, (byte) 100, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawVerticalItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, StatisticalCategoryDataset dataset, int visibleRow, int row, int column)
    {
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, domainAxisEdge);
      int num1 = state.getVisibleSeriesCount() < 0 ? this.getRowCount() : state.getVisibleSeriesCount();
      int columnCount = this.getColumnCount();
      double num2;
      if (num1 > 1)
      {
        double num3 = ((RectangularShape) dataArea).getWidth() * this.getItemMargin() / (double) (columnCount * (num1 - 1));
        num2 = categoryStart + (double) visibleRow * (state.getBarWidth() + num3);
      }
      else
        num2 = categoryStart + (double) visibleRow * state.getBarWidth();
      Number meanValue = dataset.getMeanValue(row, column);
      if (meanValue == null)
        return;
      double d1 = meanValue.doubleValue();
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
      double num4 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      double num5 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      double num6 = Math.min(num5, num4);
      double barWidth = state.getBarWidth();
      double num7 = Math.abs(num5 - num4);
      Rectangle2D.Double double1 = new Rectangle2D.Double(num2, num6, barWidth, num7);
      object obj1 = (object) this.getItemPaint(row, column);
      GradientPaintTransformer paintTransformer = this.getGradientPaintTransformer();
      if (paintTransformer != null && (Paint) obj1 is GradientPaint)
        obj1 = (object) paintTransformer.transform((GradientPaint) obj1, (Shape) double1);
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
      g2.fill((Shape) double1);
      if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
      {
        Stroke itemOutlineStroke = this.getItemOutlineStroke(row, column);
        Paint itemOutlinePaint = this.getItemOutlinePaint(row, column);
        if (itemOutlineStroke != null && itemOutlinePaint != null)
        {
          g2.setStroke(itemOutlineStroke);
          g2.setPaint(itemOutlinePaint);
          g2.draw((Shape) double1);
        }
      }
      Number stdDevValue = dataset.getStdDevValue(row, column);
      if (stdDevValue != null)
      {
        double num3 = stdDevValue.doubleValue();
        double num8 = rangeAxis.valueToJava2D(meanValue.doubleValue() + num3, dataArea, rangeAxisEdge);
        double num9 = rangeAxis.valueToJava2D(meanValue.doubleValue() - num3, dataArea, rangeAxisEdge);
        if (this.errorIndicatorPaint != null)
          g2.setPaint(this.errorIndicatorPaint);
        else
          g2.setPaint(this.getItemOutlinePaint(row, column));
        if (this.errorIndicatorStroke != null)
          g2.setStroke(this.errorIndicatorStroke);
        else
          g2.setStroke(this.getItemOutlineStroke(row, column));
        Line2D.Double double2 = new Line2D.Double(num2 + barWidth / 2.0, num9, num2 + barWidth / 2.0, num8);
        g2.draw((Shape) double2);
        Line2D.Double double3 = new Line2D.Double(num2 + barWidth / 2.0 - 5.0, num8, num2 + barWidth / 2.0 + 5.0, num8);
        g2.draw((Shape) double3);
        Line2D.Double double4 = new Line2D.Double(num2 + barWidth / 2.0 - 5.0, num9, num2 + barWidth / 2.0 + 5.0, num9);
        g2.draw((Shape) double4);
      }
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, (CategoryDataset) dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) double1, d1 < 0.0);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, (CategoryDataset) dataset, row, column, (Shape) double1);
    }

    public virtual Paint getErrorIndicatorPaint()
    {
      return this.errorIndicatorPaint;
    }

    public virtual Stroke getErrorIndicatorStroke()
    {
      return this.errorIndicatorStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorIndicatorStroke(Stroke stroke)
    {
      this.errorIndicatorStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 105, (byte) 100, (byte) 161, (byte) 105, (byte) 176, (byte) 136, (byte) 104, (byte) 104, (byte) 183, (byte) 104, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset data, int row, int column, int pass)
    {
      int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
      if (visibleSeriesIndex < 0)
        return;
      if (!(data is StatisticalCategoryDataset))
      {
        string str = "Requires StatisticalCategoryDataset.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        StatisticalCategoryDataset dataset = (StatisticalCategoryDataset) data;
        PlotOrientation orientation = plot.getOrientation();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          this.drawHorizontalItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, visibleSeriesIndex, row, column);
        }
        else
        {
          if (orientation != PlotOrientation.__\u003C\u003EVERTICAL)
            return;
          this.drawVerticalItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, visibleSeriesIndex, row, column);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 191, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StatisticalBarRenderer))
        return false;
      StatisticalBarRenderer statisticalBarRenderer = (StatisticalBarRenderer) obj;
      if (!PaintUtilities.equal(this.errorIndicatorPaint, statisticalBarRenderer.errorIndicatorPaint) || !ObjectUtilities.equal((object) this.errorIndicatorStroke, (object) statisticalBarRenderer.errorIndicatorStroke))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 217, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.errorIndicatorPaint, obj0);
      SerialUtilities.writeStroke(this.errorIndicatorStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 232, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.errorIndicatorPaint = SerialUtilities.readPaint(obj0);
      this.errorIndicatorStroke = SerialUtilities.readStroke(obj0);
    }
  }
}
