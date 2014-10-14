// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.IntervalBarRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Serializable]
  public class IntervalBarRenderer : BarRenderer
  {
    private const long serialVersionUID = -5068857361615528725L;

    [HideFromJava]
    static IntervalBarRenderer()
    {
      BarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalBarRenderer()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected IntervalBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 105, (byte) 100, (byte) 129, (byte) 184, (byte) 135, (byte) 136, (byte) 103, (byte) 135, (byte) 105, (byte) 169, (byte) 109, (byte) 100, (byte) 129, (byte) 212, (byte) 109, (byte) 100, (byte) 129, (byte) 180, (byte) 102, (byte) 100, (byte) 100, (byte) 100, (byte) 100, (byte) 99, (byte) 195, (byte) 169, (byte) 141, (byte) 103, (byte) 139, (byte) 149, (byte) 100, (byte) 151, (byte) 114, (byte) 130, (byte) 175, (byte) 132, (byte) 105, (byte) 109, (byte) 140, (byte) 139, (byte) 181, (byte) 100, (byte) 151, (byte) 114, (byte) 130, (byte) 175, (byte) 100, (byte) 135, (byte) 143, (byte) 104, (byte) 104, (byte) 146, (byte) 149, (byte) 140, (byte) 112, (byte) 244, (byte) 69, (byte) 104, (byte) 100, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawInterval(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, IntervalCategoryDataset dataset, int row, int column)
    {
      int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
      if (visibleSeriesIndex < 0)
        return;
      int num1 = state.getVisibleSeriesCount() < 0 ? this.getRowCount() : state.getVisibleSeriesCount();
      int columnCount = this.getColumnCount();
      PlotOrientation orientation = plot.getOrientation();
      double num2 = 0.0;
      double num3 = 0.0;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      Number endValue = dataset.getEndValue(row, column);
      if (endValue == null)
        return;
      double num4 = rangeAxis.valueToJava2D(endValue.doubleValue(), dataArea, rangeAxisEdge);
      Number startValue = dataset.getStartValue(row, column);
      if (startValue == null)
        return;
      double num5 = rangeAxis.valueToJava2D(startValue.doubleValue(), dataArea, rangeAxisEdge);
      if (num5 < num4)
      {
        double num6 = num5;
        num5 = num4;
        num4 = num6;
      }
      double num7 = state.getBarWidth();
      double num8 = Math.abs(num5 - num4);
      RectangleEdge re = RectangleEdge.__\u003C\u003ELEFT;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, domainAxisEdge);
        if (num1 > 1)
        {
          double num6 = ((RectangularShape) dataArea).getHeight() * this.getItemMargin() / (double) (columnCount * (num1 - 1));
          num3 = categoryStart + (double) visibleSeriesIndex * (state.getBarWidth() + num6);
        }
        else
          num3 = categoryStart + (double) visibleSeriesIndex * state.getBarWidth();
        num2 = num4;
        num8 = state.getBarWidth();
        num7 = Math.abs(num5 - num4);
        re = RectangleEdge.__\u003C\u003ELEFT;
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, domainAxisEdge);
        if (num1 > 1)
        {
          double num6 = ((RectangularShape) dataArea).getWidth() * this.getItemMargin() / (double) (columnCount * (num1 - 1));
          num2 = categoryStart + (double) visibleSeriesIndex * (state.getBarWidth() + num6);
        }
        else
          num2 = categoryStart + (double) visibleSeriesIndex * state.getBarWidth();
        num3 = num4;
        re = RectangleEdge.__\u003C\u003EBOTTOM;
      }
      Rectangle2D.Double @double = new Rectangle2D.Double(num2, num3, num7, num8);
      BarPainter barPainter = this.getBarPainter();
      if (this.getShadowsVisible())
        barPainter.paintBarShadow(g2, (BarRenderer) this, row, column, (RectangularShape) @double, re, false);
      this.getBarPainter().paintBar(g2, (BarRenderer) this, row, column, (RectangularShape) @double, re);
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, (CategoryDataset) dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, false);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, (CategoryDataset) dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 105, (byte) 104, (byte) 148, (byte) 130, (byte) 217})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (dataset is IntervalCategoryDataset)
      {
        IntervalCategoryDataset dataset1 = (IntervalCategoryDataset) dataset;
        this.drawInterval(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset1, row, column);
      }
      else
        base.drawItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, row, column, pass);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 100, (byte) 130, (byte) 104, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is IntervalBarRenderer))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
