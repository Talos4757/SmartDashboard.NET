// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.GroupedStackedBarRenderer
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
  public class GroupedStackedBarRenderer : StackedBarRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private new const long serialVersionUID = -2725921399005922939L;
    private KeyToGroupMap seriesToGroupMap;

    [HideFromJava]
    static GroupedStackedBarRenderer()
    {
      StackedBarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GroupedStackedBarRenderer()
    {
      GroupedStackedBarRenderer stackedBarRenderer = this;
      this.seriesToGroupMap = new KeyToGroupMap();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GroupedStackedBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] GroupedStackedBarRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GroupedStackedBarRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 102, (byte) 104, (byte) 170, (byte) 136, (byte) 152, (byte) 108, (byte) 191, (byte) 12, (byte) 104, (byte) 100, (byte) 147, (byte) 143, (byte) 159, (byte) 12, (byte) 130, (byte) 223, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override double calculateBarW0(CategoryPlot plot, PlotOrientation orientation, Rectangle2D dataArea, CategoryAxis domainAxis, CategoryItemRendererState state, int row, int column)
    {
      double space = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? ((RectangularShape) dataArea).getWidth() : ((RectangularShape) dataArea).getHeight();
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      int groupCount = this.seriesToGroupMap.getGroupCount();
      int groupIndex = this.seriesToGroupMap.getGroupIndex(this.seriesToGroupMap.getGroup(plot.getDataset(plot.getIndexOf((CategoryItemRenderer) this)).getRowKey(row)));
      int columnCount = this.getColumnCount();
      double num1;
      if (groupCount > 1)
      {
        double num2 = space * this.getItemMargin() / (double) (columnCount * (groupCount - 1));
        double num3 = this.calculateSeriesWidth(space, domainAxis, columnCount, groupCount);
        num1 = categoryStart + (double) groupIndex * (num3 + num2) + num3 / 2.0 - state.getBarWidth() / 2.0;
      }
      else
        num1 = domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) - state.getBarWidth() / 2.0;
      return num1;
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesToGroupMap(KeyToGroupMap map)
    {
      if (map == null)
      {
        string str = "Null 'map' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesToGroupMap = map;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 99, (byte) 130, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      else
        return DatasetUtilities.findStackedRangeBounds(dataset, this.seriesToGroupMap);
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 104, (byte) 104, (byte) 102, (byte) 103, (byte) 102, (byte) 104, (byte) 138, (byte) 104, (byte) 136, (byte) 107, (byte) 109, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 101, (byte) 137, (byte) 101, (byte) 169, (byte) 190, (byte) 101, (byte) 182, (byte) 210})]
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
      int groupCount = this.seriesToGroupMap.getGroupCount();
      int columnCount = dataset.getColumnCount();
      int num3 = groupCount * columnCount;
      double num4 = 0.0;
      double num5 = 0.0;
      if (columnCount > 1)
        num4 = domainAxisForDataset.getCategoryMargin();
      if (groupCount > 1)
        num5 = this.getItemMargin();
      double num6 = num1 * (1.0 - domainAxisForDataset.getLowerMargin() - domainAxisForDataset.getUpperMargin() - num4 - num5);
      if (num3 > 0)
        state.setBarWidth(Math.min(num6 / (double) num3, num2));
      else
        state.setBarWidth(Math.min(num6, num2));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 108, (byte) 99, (byte) 161, (byte) 104, (byte) 149, (byte) 104, (byte) 180, (byte) 103, (byte) 135, (byte) 108, (byte) 156, (byte) 109, (byte) 100, (byte) 106, (byte) 105, (byte) 170, (byte) 232, (byte) 54, (byte) 235, (byte) 82, (byte) 106, (byte) 137, (byte) 104, (byte) 112, (byte) 169, (byte) 201, (byte) 112, (byte) 169, (byte) 167, (byte) 105, (byte) 104, (byte) 143, (byte) 211, (byte) 143, (byte) 177, (byte) 108, (byte) 184, (byte) 98, (byte) 104, (byte) 213, (byte) 179, (byte) 149, (byte) 140, (byte) 112, (byte) 251, (byte) 69, (byte) 104, (byte) 104, (byte) 100, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      double num1 = number1.doubleValue();
      IComparable group = this.seriesToGroupMap.getGroup(dataset.getRowKey(row));
      PlotOrientation orientation = plot.getOrientation();
      double num2 = this.calculateBarW0(plot, orientation, dataArea, domainAxis, state, row, column);
      double d1 = 0.0;
      double d2 = 0.0;
      for (int index = 0; index < row; ++index)
      {
        if (Object.instancehelper_equals((object) group, (object) this.seriesToGroupMap.getGroup(dataset.getRowKey(index))))
        {
          Number number2 = dataset.getValue(index, column);
          if (number2 != null)
          {
            double num3 = number2.doubleValue();
            if (num3 > 0.0)
              d1 += num3;
            else
              d2 += num3;
          }
        }
      }
      int num4 = num1 > 0.0 ? 1 : 0;
      int num5 = rangeAxis.isInverted() ? 1 : 0;
      RectangleEdge re = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (num4 != 0 && num5 == 0 || num4 == 0 && num5 != 0 ? RectangleEdge.__\u003C\u003EBOTTOM : RectangleEdge.__\u003C\u003ETOP) : (num4 != 0 && num5 != 0 || num4 == 0 && num5 == 0 ? RectangleEdge.__\u003C\u003ERIGHT : RectangleEdge.__\u003C\u003ELEFT);
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num6;
      double num7;
      if (num1 > 0.0)
      {
        num6 = rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
        num7 = rangeAxis.valueToJava2D(d1 + num1, dataArea, rangeAxisEdge);
      }
      else
      {
        num6 = rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
        num7 = rangeAxis.valueToJava2D(d2 + num1, dataArea, rangeAxisEdge);
      }
      double num8 = Math.min(num6, num7);
      double num9 = Math.max(Math.abs(num7 - num6), this.getMinimumBarLength());
      Rectangle2D.Double @double = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? new Rectangle2D.Double(num2, num8, state.getBarWidth(), num9) : new Rectangle2D.Double(num8, num2, num9, state.getBarWidth());
      this.getBarPainter().paintBar(g2, (BarRenderer) this, row, column, (RectangularShape) @double, re);
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator != null && this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, dataset, row, column, plot, itemLabelGenerator, (Rectangle2D) @double, num1 < 0.0);
      if (state.getInfo() == null)
        return;
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is GroupedStackedBarRenderer) || !this.seriesToGroupMap.equals((object) ((GroupedStackedBarRenderer) obj).seriesToGroupMap))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
