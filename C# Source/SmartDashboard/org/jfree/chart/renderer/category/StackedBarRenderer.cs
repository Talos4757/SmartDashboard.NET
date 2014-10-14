// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.StackedBarRenderer
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
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
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
  public class StackedBarRenderer : BarRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    internal const long serialVersionUID = 6402943811500067531L;
    private bool renderAsPercentages;

    [HideFromJava]
    static StackedBarRenderer()
    {
      BarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedBarRenderer()
      : this(false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 130, (byte) 104, (byte) 199, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedBarRenderer(bool renderAsPercentages)
    {
      int num = renderAsPercentages ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      StackedBarRenderer stackedBarRenderer = this;
      this.renderAsPercentages = num != 0;
      ItemLabelPosition position = new ItemLabelPosition(ItemLabelAnchor.__\u003C\u003ECENTER, TextAnchor.__\u003C\u003ECENTER);
      this.setBasePositiveItemLabelPosition(position);
      this.setBaseNegativeItemLabelPosition(position);
      this.setPositiveItemLabelPositionFallback((ItemLabelPosition) null);
      this.setNegativeItemLabelPositionFallback((ItemLabelPosition) null);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackedBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StackedBarRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StackedBarRenderer obj0)
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

    public virtual bool getRenderAsPercentages()
    {
      return this.renderAsPercentages;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 95, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRenderAsPercentages(bool asPercentages)
    {
      this.renderAsPercentages = asPercentages;
      this.fireChangeEvent();
    }

    public override int getPassCount()
    {
      return 3;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 99, (byte) 130, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      if (this.renderAsPercentages)
        return new Range(0.0, 1.0);
      else
        return DatasetUtilities.findStackedRangeBounds(dataset, this.getBase());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 104, (byte) 104, (byte) 102, (byte) 103, (byte) 102, (byte) 104, (byte) 138, (byte) 104, (byte) 136, (byte) 107, (byte) 104, (byte) 103, (byte) 101, (byte) 169, (byte) 187, (byte) 101, (byte) 182, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void calculateBarWidth(CategoryPlot plot, Rectangle2D dataArea, int rendererIndex, CategoryItemRendererState state)
    {
      CategoryAxis domainAxisForDataset = plot.getDomainAxisForDataset(rendererIndex);
      CategoryDataset dataset = plot.getDataset(rendererIndex);
      if (dataset == null)
        return;
      PlotOrientation orientation = plot.getOrientation();
      double num1 = 0.0;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num1 = ((RectangularShape) dataArea).getHeight();
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        num1 = ((RectangularShape) dataArea).getWidth();
      double num2 = num1 * this.getMaximumBarWidth();
      int columnCount = dataset.getColumnCount();
      double num3 = 0.0;
      if (columnCount > 1)
        num3 = domainAxisForDataset.getCategoryMargin();
      double num4 = num1 * (1.0 - domainAxisForDataset.getLowerMargin() - domainAxisForDataset.getUpperMargin() - num3);
      if (columnCount > 0)
        state.setBarWidth(Math.min(num4 / (double) columnCount, num2));
      else
        state.setBarWidth(Math.min(num4, num2));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 106, (byte) 193, (byte) 108, (byte) 99, (byte) 161, (byte) 104, (byte) 102, (byte) 104, (byte) 145, (byte) 165, (byte) 104, (byte) 223, (byte) 12, (byte) 105, (byte) 132, (byte) 108, (byte) 109, (byte) 110, (byte) 106, (byte) 104, (byte) 135, (byte) 105, (byte) 170, (byte) 232, (byte) 53, (byte) 235, (byte) 82, (byte) 106, (byte) 137, (byte) 104, (byte) 112, (byte) 169, (byte) 201, (byte) 112, (byte) 169, (byte) 199, (byte) 105, (byte) 100, (byte) 143, (byte) 211, (byte) 143, (byte) 177, (byte) 108, (byte) 184, (byte) 98, (byte) 104, (byte) 213, (byte) 179, (byte) 100, (byte) 107, (byte) 159, (byte) 3, (byte) 151, (byte) 133, (byte) 101, (byte) 181, (byte) 104, (byte) 100, (byte) 144, (byte) 98, (byte) 101, (byte) 140, (byte) 112, (byte) 221})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.isSeriesVisible(row))
        return;
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      double num1 = number1.doubleValue();
      double num2 = 0.0;
      if (this.renderAsPercentages)
      {
        num2 = DataUtilities.calculateColumnTotal((Values2D) dataset, column, state.getVisibleSeriesArray());
        num1 /= num2;
      }
      PlotOrientation orientation = plot.getOrientation();
      double num3 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      double @base = this.getBase();
      double d = @base;
      for (int index = 0; index < row; ++index)
      {
        Number number2 = dataset.getValue(index, column);
        if (number2 != null && this.isSeriesVisible(index))
        {
          double num4 = number2.doubleValue();
          if (this.renderAsPercentages)
            num4 /= num2;
          if (num4 > 0.0)
            @base += num4;
          else
            d += num4;
        }
      }
      int num5 = num1 > 0.0 ? 1 : 0;
      int num6 = rangeAxis.isInverted() ? 1 : 0;
      RectangleEdge re = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (num5 != 0 && num6 == 0 || num5 == 0 && num6 != 0 ? RectangleEdge.__\u003C\u003EBOTTOM : RectangleEdge.__\u003C\u003ETOP) : (num5 != 0 && num6 != 0 || num5 == 0 && num6 == 0 ? RectangleEdge.__\u003C\u003ERIGHT : RectangleEdge.__\u003C\u003ELEFT);
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num7;
      double num8;
      if (num5 != 0)
      {
        num7 = rangeAxis.valueToJava2D(@base, dataArea, rangeAxisEdge);
        num8 = rangeAxis.valueToJava2D(@base + num1, dataArea, rangeAxisEdge);
      }
      else
      {
        num7 = rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
        num8 = rangeAxis.valueToJava2D(d + num1, dataArea, rangeAxisEdge);
      }
      double num9 = Math.min(num7, num8);
      double num10 = Math.max(Math.abs(num8 - num7), this.getMinimumBarLength());
      Rectangle2D.Double @double = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? new Rectangle2D.Double(num3, num9, state.getBarWidth(), num10) : new Rectangle2D.Double(num9, num3, num10, state.getBarWidth());
      if (pass == 0)
      {
        if (!this.getShadowsVisible())
          return;
        int num4 = num5 != 0 && @base == this.getBase() || num5 == 0 && d == this.getBase() ? 1 : 0;
        this.getBarPainter().paintBarShadow(g2, (BarRenderer) this, row, column, (RectangularShape) @double, re, num4 != 0);
      }
      else if (pass == 1)
      {
        this.getBarPainter().paintBar(g2, (BarRenderer) this, row, column, (RectangularShape) @double, re);
        EntityCollection entityCollection = state.getEntityCollection();
        if (entityCollection == null)
          return;
        this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
      }
      else
      {
        if (pass != 2)
          return;
        CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
        if (itemLabelGenerator == null || !this.isItemLabelVisible(row, column))
          return;
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, num1 < 0.0);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 51, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StackedBarRenderer) || this.renderAsPercentages != ((StackedBarRenderer) obj).renderAsPercentages)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
