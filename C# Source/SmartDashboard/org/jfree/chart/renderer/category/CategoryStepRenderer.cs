// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.CategoryStepRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.data.general;
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
  public class CategoryStepRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -5121079703118261470L;
    public const int STAGGER_WIDTH = 5;
    private bool stagger;

    [HideFromJava]
    static CategoryStepRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 109, (byte) 130, (byte) 232, (byte) 49, (byte) 231, (byte) 80, (byte) 103, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryStepRenderer(bool stagger)
    {
      int num = stagger ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      CategoryStepRenderer categoryStepRenderer = this;
      this.stagger = false;
      this.stagger = num != 0;
      this.setBaseLegendShape((Shape) new Rectangle2D.Double(-4.0, -3.0, 8.0, 6.0));
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryStepRenderer()
      : this(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryStepRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryStepRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryStepRenderer obj0)
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

    public virtual bool getStagger()
    {
      return this.stagger;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 104, (byte) 119, (byte) 142, (byte) 104, (byte) 119, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawLine(Graphics2D g2, CategoryStepRenderer.State state, PlotOrientation orientation, double x0, double y0, double x1, double y1)
    {
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        state.line.setLine(x0, y0, x1, y1);
        g2.draw((Shape) state.line);
      }
      else
      {
        if (orientation != PlotOrientation.__\u003C\u003EHORIZONTAL)
          return;
        state.line.setLine(y0, x0, y1, x1);
        g2.draw((Shape) state.line);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 103, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStagger(bool shouldStagger)
    {
      this.stagger = shouldStagger;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 103, (byte) 99, (byte) 194, (byte) 114, (byte) 162, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 137, (byte) 145, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 110, (byte) 104, (byte) 104, (byte) 104})]
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
      LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, shape, fillPaint);
      legendItem.setLabelFont(this.lookupLegendTextFont(series));
      Paint paint = this.lookupLegendTextPaint(series);
      if (paint != null)
        legendItem.setLabelPaint(paint);
      legendItem.setSeriesKey(dataset.getRowKey(series));
      legendItem.setSeriesIndex(series);
      legendItem.setDataset((Dataset) dataset);
      legendItem.setDatasetIndex(datasetIndex);
      return legendItem;
    }

    [LineNumberTable((ushort) 222)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override CategoryItemRendererState createState(PlotRenderingInfo info)
    {
      return (CategoryItemRendererState) new CategoryStepRenderer.State(info);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 108, (byte) 161, (byte) 108, (byte) 99, (byte) 129, (byte) 168, (byte) 153, (byte) 153, (byte) 112, (byte) 152, (byte) 112, (byte) 144, (byte) 103, (byte) 111, (byte) 135, (byte) 106, (byte) 156, (byte) 156, (byte) 114, (byte) 148, (byte) 104, (byte) 102, (byte) 105, (byte) 139, (byte) 136, (byte) 181, (byte) 212, (byte) 213, (byte) 108, (byte) 254, (byte) 69, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 185, (byte) 159, (byte) 2, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column))
        return;
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      PlotOrientation orientation = plot.getOrientation();
      double num1 = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double categoryMiddle = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double x1 = 2.0 * categoryMiddle - num1;
      double num2 = rangeAxis.valueToJava2D(number1.doubleValue(), dataArea, plot.getRangeAxisEdge());
      g2.setPaint(this.getItemPaint(row, column));
      g2.setStroke(this.getItemStroke(row, column));
      if (column != 0)
      {
        Number number2 = dataset.getValue(row, column - 1);
        if (number2 != null)
        {
          double d = number2.doubleValue();
          double categoryStart = domainAxis.getCategoryStart(column - 1, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
          double x0 = 2.0 * domainAxis.getCategoryMiddle(column - 1, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - categoryStart;
          double num3 = rangeAxis.valueToJava2D(d, dataArea, plot.getRangeAxisEdge());
          if (this.getStagger())
          {
            int num4 = row * 5;
            if ((double) num4 > num1 - x0)
              num4 = ByteCodeHelper.d2i(num1 - x0);
            num1 = x0 + (double) num4;
          }
          this.drawLine(g2, (CategoryStepRenderer.State) state, orientation, x0, num3, num1, num3);
          this.drawLine(g2, (CategoryStepRenderer.State) state, orientation, num1, num3, num1, num2);
        }
      }
      this.drawLine(g2, (CategoryStepRenderer.State) state, orientation, num1, num2, x1, num2);
      if (this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, orientation, dataset, row, column, categoryMiddle, num2, number1.doubleValue() < 0.0);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      Rectangle2D.Double @double = new Rectangle2D.Double();
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        ((Rectangle2D) @double).setRect(num1, num2, x1 - num1, 4.0);
      else
        ((Rectangle2D) @double).setRect(num2 - 2.0, num1, 4.0, x1 - num1);
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryStepRenderer) || this.stagger != ((CategoryStepRenderer) obj).stagger)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [InnerClass]
    [SourceFile("CategoryStepRenderer.java")]
    public class State : CategoryItemRendererState
    {
      public Line2D line;

      [LineNumberTable(new byte[] {(byte) 53, (byte) 105, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public State(PlotRenderingInfo info)
        : base(info)
      {
        CategoryStepRenderer.State state = this;
        this.line = (Line2D) new Line2D.Double();
      }
    }
  }
}
