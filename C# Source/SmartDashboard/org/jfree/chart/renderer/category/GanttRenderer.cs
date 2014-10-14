// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.GanttRenderer
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
using org.jfree.data.gantt;
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
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class GanttRenderer : IntervalBarRenderer, Serializable.__Interface
  {
    private const long serialVersionUID = -4010349116350119512L;
    [NonSerialized]
    private Paint completePaint;
    [NonSerialized]
    private Paint incompletePaint;
    private double startPercent;
    private double endPercent;

    [HideFromJava]
    static GanttRenderer()
    {
      IntervalBarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 104, (byte) 103, (byte) 107, (byte) 107, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GanttRenderer()
    {
      GanttRenderer ganttRenderer = this;
      this.setIncludeBaseInRange(false);
      this.completePaint = (Paint) Color.green;
      this.incompletePaint = (Paint) Color.red;
      this.startPercent = 0.35;
      this.endPercent = 0.65;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GanttRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GanttRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 108, (byte) 99, (byte) 213, (byte) 104, (byte) 137, (byte) 168, (byte) 110, (byte) 100, (byte) 129, (byte) 211, (byte) 110, (byte) 100, (byte) 129, (byte) 179, (byte) 102, (byte) 100, (byte) 100, (byte) 164, (byte) 154, (byte) 109, (byte) 169, (byte) 99, (byte) 99, (byte) 110, (byte) 143, (byte) 137, (byte) 110, (byte) 143, (byte) 167, (byte) 99, (byte) 99, (byte) 142, (byte) 105, (byte) 105, (byte) 103, (byte) 106, (byte) 104, (byte) 190, (byte) 223, (byte) 16, (byte) 104, (byte) 223, (byte) 11, (byte) 255, (byte) 5, (byte) 71, (byte) 104, (byte) 182, (byte) 149, (byte) 100, (byte) 108, (byte) 136, (byte) 100, (byte) 108, (byte) 136, (byte) 153, (byte) 112, (byte) 112, (byte) 168, (byte) 137, (byte) 107, (byte) 107, (byte) 107, (byte) 190, (byte) 255, (byte) 13, (byte) 71, (byte) 104, (byte) 104, (byte) 100, (byte) 240, (byte) 159, (byte) 144, (byte) 233, (byte) 160, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTasks(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, GanttCategoryDataset dataset, int row, int column)
    {
      int subIntervalCount = dataset.getSubIntervalCount(row, column);
      if (subIntervalCount == 0)
        this.drawTask(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, row, column);
      PlotOrientation orientation = plot.getOrientation();
      for (int i3 = 0; i3 < subIntervalCount; ++i3)
      {
        RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
        Number startValue = dataset.getStartValue(row, column, i3);
        if (startValue == null)
          break;
        double num1 = rangeAxis.valueToJava2D(startValue.doubleValue(), dataArea, rangeAxisEdge);
        Number endValue = dataset.getEndValue(row, column, i3);
        if (endValue == null)
          break;
        double transY = rangeAxis.valueToJava2D(endValue.doubleValue(), dataArea, rangeAxisEdge);
        if (transY < num1)
        {
          double num2 = transY;
          transY = num1;
          num1 = num2;
        }
        double num3 = this.calculateBarW0(plot, plot.getOrientation(), dataArea, domainAxis, state, row, column);
        double num4 = Math.abs(transY - num1);
        double barWidth = state.getBarWidth();
        Rectangle2D.Double double1 = (Rectangle2D.Double) null;
        RectangleEdge re = (RectangleEdge) null;
        if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double1 = new Rectangle2D.Double(num1, num3, num4, barWidth);
          re = RectangleEdge.__\u003C\u003ELEFT;
        }
        else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          double1 = new Rectangle2D.Double(num3, num1, barWidth, num4);
          re = RectangleEdge.__\u003C\u003EBOTTOM;
        }
        Rectangle2D.Double double2 = (Rectangle2D.Double) null;
        Rectangle2D.Double double3 = (Rectangle2D.Double) null;
        Number percentComplete = dataset.getPercentComplete(row, column, i3);
        double startPercent = this.getStartPercent();
        double endPercent = this.getEndPercent();
        if (percentComplete != null)
        {
          double num2 = percentComplete.doubleValue();
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          {
            double2 = new Rectangle2D.Double(num1, num3 + startPercent * barWidth, num4 * num2, barWidth * (endPercent - startPercent));
            double3 = new Rectangle2D.Double(num1 + num4 * num2, num3 + startPercent * barWidth, num4 * (1.0 - num2), barWidth * (endPercent - startPercent));
          }
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            double2 = new Rectangle2D.Double(num3 + startPercent * barWidth, num1 + num4 * (1.0 - num2), barWidth * (endPercent - startPercent), num4 * num2);
            double3 = new Rectangle2D.Double(num3 + startPercent * barWidth, num1, barWidth * (endPercent - startPercent), num4 * (1.0 - num2));
          }
        }
        if (this.getShadowsVisible())
          this.getBarPainter().paintBarShadow(g2, (BarRenderer) this, row, column, (RectangularShape) double1, re, true);
        this.getBarPainter().paintBar(g2, (BarRenderer) this, row, column, (RectangularShape) double1, re);
        if (double2 != null)
        {
          g2.setPaint(this.getCompletePaint());
          g2.fill((Shape) double2);
        }
        if (double3 != null)
        {
          g2.setPaint(this.getIncompletePaint());
          g2.fill((Shape) double3);
        }
        if (this.isDrawBarOutline() && state.getBarWidth() > 3.0)
        {
          g2.setStroke(this.getItemStroke(row, column));
          g2.setPaint(this.getItemOutlinePaint(row, column));
          g2.draw((Shape) double1);
        }
        if (i3 == subIntervalCount - 1)
        {
          int datasetIndex = plot.indexOf((CategoryDataset) dataset);
          IComparable columnKey = dataset.getColumnKey(column);
          IComparable rowKey = dataset.getRowKey(row);
          double categorySeriesMiddle = domainAxis.getCategorySeriesMiddle(columnKey, rowKey, (CategoryDataset) dataset, this.getItemMargin(), dataArea, plot.getDomainAxisEdge());
          this.updateCrosshairValues(state.getCrosshairState(), dataset.getRowKey(row), dataset.getColumnKey(column), endValue.doubleValue(), datasetIndex, categorySeriesMiddle, transY, orientation);
        }
        if (state.getInfo() != null)
        {
          EntityCollection entityCollection = state.getEntityCollection();
          if (entityCollection != null)
            this.addItemEntity(entityCollection, (CategoryDataset) dataset, row, column, (Shape) double1);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 67, (byte) 104, (byte) 168, (byte) 108, (byte) 99, (byte) 129, (byte) 209, (byte) 109, (byte) 100, (byte) 129, (byte) 179, (byte) 101, (byte) 100, (byte) 99, (byte) 99, (byte) 100, (byte) 99, (byte) 163, (byte) 148, (byte) 105, (byte) 140, (byte) 99, (byte) 99, (byte) 104, (byte) 142, (byte) 137, (byte) 104, (byte) 143, (byte) 167, (byte) 99, (byte) 99, (byte) 109, (byte) 105, (byte) 105, (byte) 103, (byte) 106, (byte) 110, (byte) 189, (byte) 223, (byte) 15, (byte) 110, (byte) 191, (byte) 11, (byte) 255, (byte) 5, (byte) 71, (byte) 104, (byte) 182, (byte) 149, (byte) 100, (byte) 108, (byte) 136, (byte) 100, (byte) 108, (byte) 200, (byte) 153, (byte) 108, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 200, (byte) 140, (byte) 112, (byte) 244, (byte) 69, (byte) 107, (byte) 107, (byte) 107, (byte) 158, (byte) 255, (byte) 13, (byte) 70, (byte) 104, (byte) 100, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawTask(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, GanttCategoryDataset dataset, int row, int column)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      Number endValue = dataset.getEndValue(row, column);
      if (endValue == null)
        return;
      double num1 = rangeAxis.valueToJava2D(endValue.doubleValue(), dataArea, rangeAxisEdge);
      Number number = dataset.getStartValue(row, column);
      if (number == null)
        return;
      double transY = rangeAxis.valueToJava2D(number.doubleValue(), dataArea, rangeAxisEdge);
      if (transY < num1)
      {
        double num2 = transY;
        transY = num1;
        num1 = num2;
        number = endValue;
      }
      double num3 = this.calculateBarW0(plot, orientation, dataArea, domainAxis, state, row, column);
      double barWidth = state.getBarWidth();
      double num4 = Math.abs(transY - num1);
      Rectangle2D.Double double1 = (Rectangle2D.Double) null;
      RectangleEdge re = (RectangleEdge) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double1 = new Rectangle2D.Double(num1, num3, num4, barWidth);
        re = RectangleEdge.__\u003C\u003ELEFT;
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double1 = new Rectangle2D.Double(num3, transY, barWidth, num4);
        re = RectangleEdge.__\u003C\u003EBOTTOM;
      }
      Rectangle2D.Double double2 = (Rectangle2D.Double) null;
      Rectangle2D.Double double3 = (Rectangle2D.Double) null;
      Number percentComplete = dataset.getPercentComplete(row, column);
      double startPercent = this.getStartPercent();
      double endPercent = this.getEndPercent();
      if (percentComplete != null)
      {
        double num2 = percentComplete.doubleValue();
        if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double2 = new Rectangle2D.Double(num1, num3 + startPercent * barWidth, num4 * num2, barWidth * (endPercent - startPercent));
          double3 = new Rectangle2D.Double(num1 + num4 * num2, num3 + startPercent * barWidth, num4 * (1.0 - num2), barWidth * (endPercent - startPercent));
        }
        else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          double2 = new Rectangle2D.Double(num3 + startPercent * barWidth, transY + num4 * (1.0 - num2), barWidth * (endPercent - startPercent), num4 * num2);
          double3 = new Rectangle2D.Double(num3 + startPercent * barWidth, transY, barWidth * (endPercent - startPercent), num4 * (1.0 - num2));
        }
      }
      if (this.getShadowsVisible())
        this.getBarPainter().paintBarShadow(g2, (BarRenderer) this, row, column, (RectangularShape) double1, re, true);
      this.getBarPainter().paintBar(g2, (BarRenderer) this, row, column, (RectangularShape) double1, re);
      if (double2 != null)
      {
        g2.setPaint(this.getCompletePaint());
        g2.fill((Shape) double2);
      }
      if (double3 != null)
      {
        g2.setPaint(this.getIncompletePaint());
        g2.fill((Shape) double3);
      }
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
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, (CategoryDataset) dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) double1, false);
      int datasetIndex = plot.indexOf((CategoryDataset) dataset);
      IComparable columnKey = dataset.getColumnKey(column);
      IComparable rowKey = dataset.getRowKey(row);
      double categorySeriesMiddle = domainAxis.getCategorySeriesMiddle(columnKey, rowKey, (CategoryDataset) dataset, this.getItemMargin(), dataArea, plot.getDomainAxisEdge());
      this.updateCrosshairValues(state.getCrosshairState(), dataset.getRowKey(row), dataset.getColumnKey(column), number.doubleValue(), datasetIndex, categorySeriesMiddle, transY, orientation);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, (CategoryDataset) dataset, row, column, (Shape) double1);
    }

    public virtual double getStartPercent()
    {
      return this.startPercent;
    }

    public virtual double getEndPercent()
    {
      return this.endPercent;
    }

    public virtual Paint getCompletePaint()
    {
      return this.completePaint;
    }

    public virtual Paint getIncompletePaint()
    {
      return this.incompletePaint;
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCompletePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.completePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIncompletePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.incompletePaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartPercent(double percent)
    {
      this.startPercent = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEndPercent(double percent)
    {
      this.endPercent = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 105, (byte) 104, (byte) 148, (byte) 130, (byte) 217})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (dataset is GanttCategoryDataset)
      {
        GanttCategoryDataset dataset1 = (GanttCategoryDataset) dataset;
        this.drawTasks(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset1, row, column);
      }
      else
        base.drawItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, row, column, pass);
    }

    [LineNumberTable((ushort) 578)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getItemMiddle(IComparable rowKey, IComparable columnKey, CategoryDataset dataset, CategoryAxis axis, Rectangle2D area, RectangleEdge edge)
    {
      return axis.getCategorySeriesMiddle(columnKey, rowKey, dataset, this.getItemMargin(), area, edge);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 220, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is GanttRenderer))
        return false;
      GanttRenderer ganttRenderer = (GanttRenderer) obj;
      if (!PaintUtilities.equal(this.completePaint, ganttRenderer.completePaint) || !PaintUtilities.equal(this.incompletePaint, ganttRenderer.incompletePaint) || (this.startPercent != ganttRenderer.startPercent || this.endPercent != ganttRenderer.endPercent))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 250, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.completePaint, obj0);
      SerialUtilities.writePaint(this.incompletePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 9, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.completePaint = SerialUtilities.readPaint(obj0);
      this.incompletePaint = SerialUtilities.readPaint(obj0);
    }
  }
}
