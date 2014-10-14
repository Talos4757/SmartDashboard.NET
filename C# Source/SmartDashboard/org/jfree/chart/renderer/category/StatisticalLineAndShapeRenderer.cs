// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.StatisticalLineAndShapeRenderer
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
using org.jfree.data;
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
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StatisticalLineAndShapeRenderer : LineAndShapeRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -3557517173697777579L;
    [NonSerialized]
    private Paint errorIndicatorPaint;
    [NonSerialized]
    private Stroke errorIndicatorStroke;

    [HideFromJava]
    static StatisticalLineAndShapeRenderer()
    {
      LineAndShapeRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 164, (byte) 106, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StatisticalLineAndShapeRenderer(bool linesVisible, bool shapesVisible)
      : base(linesVisible, shapesVisible)
    {
      StatisticalLineAndShapeRenderer andShapeRenderer = this;
      this.errorIndicatorPaint = (Paint) null;
      this.errorIndicatorStroke = (Stroke) null;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StatisticalLineAndShapeRenderer()
      : this(true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StatisticalLineAndShapeRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StatisticalLineAndShapeRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StatisticalLineAndShapeRenderer obj0)
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

    public virtual Paint getErrorIndicatorPaint()
    {
      return this.errorIndicatorPaint;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorIndicatorPaint(Paint paint)
    {
      this.errorIndicatorPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Stroke getErrorIndicatorStroke()
    {
      return this.errorIndicatorStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorIndicatorStroke(Stroke stroke)
    {
      this.errorIndicatorStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 202)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      return this.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 108, (byte) 225, (byte) 69, (byte) 105, (byte) 153, (byte) 161, (byte) 105, (byte) 100, (byte) 129, (byte) 135, (byte) 136, (byte) 107, (byte) 99, (byte) 129, (byte) 201, (byte) 104, (byte) 255, (byte) 6, (byte) 70, (byte) 186, (byte) 248, (byte) 70, (byte) 108, (byte) 143, (byte) 105, (byte) 138, (byte) 151, (byte) 251, (byte) 69, (byte) 214, (byte) 151, (byte) 251, (byte) 69, (byte) 214, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 174, (byte) 144, (byte) 103, (byte) 108, (byte) 111, (byte) 104, (byte) 127, (byte) 4, (byte) 104, (byte) 127, (byte) 4, (byte) 173, (byte) 111, (byte) 104, (byte) 127, (byte) 4, (byte) 104, (byte) 127, (byte) 4, (byte) 232, (byte) 69, (byte) 99, (byte) 119, (byte) 108, (byte) 105, (byte) 143, (byte) 105, (byte) 141, (byte) 132, (byte) 108, (byte) 104, (byte) 178, (byte) 144, (byte) 136, (byte) 104, (byte) 104, (byte) 178, (byte) 144, (byte) 112, (byte) 168, (byte) 108, (byte) 105, (byte) 191, (byte) 3, (byte) 105, (byte) 255, (byte) 1, (byte) 70, (byte) 118, (byte) 135, (byte) 110, (byte) 167, (byte) 138, (byte) 104, (byte) 255, (byte) 8, (byte) 71, (byte) 220, (byte) 180, (byte) 99, (byte) 105, (byte) 145, (byte) 105, (byte) 143, (byte) 112, (byte) 112, (byte) 232, (byte) 69, (byte) 133, (byte) 104, (byte) 100, (byte) 214})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column))
        return;
      if (!(dataset is StatisticalCategoryDataset))
      {
        base.drawItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, row, column, pass);
      }
      else
      {
        int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
        if (visibleSeriesIndex < 0)
          return;
        int visibleSeriesCount = state.getVisibleSeriesCount();
        StatisticalCategoryDataset statisticalCategoryDataset = (StatisticalCategoryDataset) dataset;
        Number meanValue = statisticalCategoryDataset.getMeanValue(row, column);
        if (meanValue == null)
          return;
        PlotOrientation orientation = plot.getOrientation();
        double num1 = !this.getUseSeriesOffset() ? domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) : domainAxis.getCategorySeriesMiddle(column, dataset.getColumnCount(), visibleSeriesIndex, visibleSeriesCount, this.getItemMargin(), dataArea, plot.getDomainAxisEdge());
        double num2 = rangeAxis.valueToJava2D(meanValue.doubleValue(), dataArea, plot.getRangeAxisEdge());
        Number stdDevValue = statisticalCategoryDataset.getStdDevValue(row, column);
        if (pass == 1 && stdDevValue != null)
        {
          RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
          double num3 = stdDevValue.doubleValue();
          double num4 = meanValue.doubleValue() + num3 <= rangeAxis.getRange().getUpperBound() ? rangeAxis.valueToJava2D(meanValue.doubleValue() + num3, dataArea, rangeAxisEdge) : rangeAxis.valueToJava2D(rangeAxis.getRange().getUpperBound(), dataArea, rangeAxisEdge);
          double num5 = meanValue.doubleValue() + num3 >= rangeAxis.getRange().getLowerBound() ? rangeAxis.valueToJava2D(meanValue.doubleValue() - num3, dataArea, rangeAxisEdge) : rangeAxis.valueToJava2D(rangeAxis.getRange().getLowerBound(), dataArea, rangeAxisEdge);
          if (this.errorIndicatorPaint != null)
            g2.setPaint(this.errorIndicatorPaint);
          else
            g2.setPaint(this.getItemPaint(row, column));
          if (this.errorIndicatorStroke != null)
            g2.setStroke(this.errorIndicatorStroke);
          else
            g2.setStroke(this.getItemOutlineStroke(row, column));
          Line2D.Double @double = new Line2D.Double();
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          {
            ((Line2D) @double).setLine(num5, num1, num4, num1);
            g2.draw((Shape) @double);
            ((Line2D) @double).setLine(num5, num1 - 5.0, num5, num1 + 5.0);
            g2.draw((Shape) @double);
            ((Line2D) @double).setLine(num4, num1 - 5.0, num4, num1 + 5.0);
            g2.draw((Shape) @double);
          }
          else
          {
            ((Line2D) @double).setLine(num1, num5, num1, num4);
            g2.draw((Shape) @double);
            ((Line2D) @double).setLine(num1 - 5.0, num4, num1 + 5.0, num4);
            g2.draw((Shape) @double);
            ((Line2D) @double).setLine(num1 - 5.0, num5, num1 + 5.0, num5);
            g2.draw((Shape) @double);
          }
        }
        Shape hotspot = (Shape) null;
        if (pass == 1 && this.getItemShapeVisible(row, column))
        {
          Shape shape = this.getItemShape(row, column);
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            shape = ShapeUtilities.createTranslatedShape(shape, num2, num1);
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            shape = ShapeUtilities.createTranslatedShape(shape, num1, num2);
          hotspot = shape;
          if (this.getItemShapeFilled(row, column))
          {
            if (this.getUseFillPaint())
              g2.setPaint(this.getItemFillPaint(row, column));
            else
              g2.setPaint(this.getItemPaint(row, column));
            g2.fill(shape);
          }
          if (this.getDrawOutlines())
          {
            if (this.getUseOutlinePaint())
              g2.setPaint(this.getItemOutlinePaint(row, column));
            else
              g2.setPaint(this.getItemPaint(row, column));
            g2.setStroke(this.getItemOutlineStroke(row, column));
            g2.draw(shape);
          }
          if (this.isItemLabelVisible(row, column))
          {
            if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
              this.drawItemLabel(g2, orientation, dataset, row, column, num2, num1, meanValue.doubleValue() < 0.0);
            else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
              this.drawItemLabel(g2, orientation, dataset, row, column, num1, num2, meanValue.doubleValue() < 0.0);
          }
        }
        if (pass == 0 && this.getItemLineVisible(row, column) && column != 0)
        {
          Number number = statisticalCategoryDataset.getValue(row, column - 1);
          if (number != null)
          {
            double d = number.doubleValue();
            double num3 = !this.getUseSeriesOffset() ? domainAxis.getCategoryMiddle(column - 1, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) : domainAxis.getCategorySeriesMiddle(column - 1, dataset.getColumnCount(), visibleSeriesIndex, visibleSeriesCount, this.getItemMargin(), dataArea, plot.getDomainAxisEdge());
            double num4 = rangeAxis.valueToJava2D(d, dataArea, plot.getRangeAxisEdge());
            Line2D.Double @double = (Line2D.Double) null;
            if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
              @double = new Line2D.Double(num4, num3, num2, num1);
            else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
              @double = new Line2D.Double(num3, num4, num1, num2);
            g2.setPaint(this.getItemPaint(row, column));
            g2.setStroke(this.getItemStroke(row, column));
            g2.draw((Shape) @double);
          }
        }
        if (pass != 1)
          return;
        EntityCollection entityCollection = state.getEntityCollection();
        if (entityCollection == null)
          return;
        this.addEntity(entityCollection, hotspot, dataset, row, column, num1, num2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StatisticalLineAndShapeRenderer))
        return false;
      StatisticalLineAndShapeRenderer andShapeRenderer = (StatisticalLineAndShapeRenderer) obj;
      if (!PaintUtilities.equal(this.errorIndicatorPaint, andShapeRenderer.errorIndicatorPaint) || !ObjectUtilities.equal((object) this.errorIndicatorStroke, (object) andShapeRenderer.errorIndicatorStroke))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 90, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(base.hashCode(), this.errorIndicatorPaint);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 103, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.errorIndicatorPaint, obj0);
      SerialUtilities.writeStroke(this.errorIndicatorStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 118, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.errorIndicatorPaint = SerialUtilities.readPaint(obj0);
      this.errorIndicatorStroke = SerialUtilities.readStroke(obj0);
    }
  }
}
