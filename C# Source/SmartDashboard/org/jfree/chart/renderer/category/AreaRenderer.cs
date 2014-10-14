// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.AreaRenderer
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
using org.jfree.chart.renderer;
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
  public class AreaRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -4231878281385812757L;
    private AreaRendererEndType endType;

    [HideFromJava]
    static AreaRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 104, (byte) 107, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AreaRenderer()
    {
      AreaRenderer areaRenderer = this;
      this.endType = AreaRendererEndType.__\u003C\u003ETAPER;
      this.setBaseLegendShape((Shape) new Rectangle2D.Double(-4.0, -4.0, 8.0, 8.0));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AreaRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AreaRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AreaRenderer obj0)
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

    public virtual AreaRendererEndType getEndType()
    {
      return this.endType;
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEndType(AreaRendererEndType type)
    {
      if (type == null)
      {
        string str = "Null 'type' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.endType = type;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 110, (byte) 103, (byte) 99, (byte) 194, (byte) 114, (byte) 162, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 149, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 110, (byte) 104})]
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
      LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, shape, fillPaint, outlineStroke, outlinePaint);
      legendItem.setLabelFont(this.lookupLegendTextFont(series));
      Paint paint = this.lookupLegendTextPaint(series);
      if (paint != null)
        legendItem.setLabelPaint(paint);
      legendItem.setDataset((Dataset) dataset);
      legendItem.setDatasetIndex(datasetIndex);
      legendItem.setSeriesKey(dataset.getRowKey(series));
      legendItem.setSeriesIndex(series);
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 108, (byte) 193, (byte) 108, (byte) 102, (byte) 104, (byte) 104, (byte) 104, (byte) 143, (byte) 143, (byte) 175, (byte) 106, (byte) 106, (byte) 138, (byte) 109, (byte) 100, (byte) 134, (byte) 108, (byte) 196, (byte) 137, (byte) 103, (byte) 101, (byte) 111, (byte) 100, (byte) 215, (byte) 103, (byte) 109, (byte) 111, (byte) 100, (byte) 215, (byte) 105, (byte) 111, (byte) 111, (byte) 111, (byte) 146, (byte) 112, (byte) 144, (byte) 135, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 141, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 135, (byte) 112, (byte) 168, (byte) 108, (byte) 255, (byte) 2, (byte) 69, (byte) 107, (byte) 255, (byte) 10, (byte) 69, (byte) 104, (byte) 100, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column))
        return;
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      int columnCount = dataset.getColumnCount();
      float num1 = (float) domainAxis.getCategoryStart(column, columnCount, dataArea, domainAxisEdge);
      float num2 = (float) domainAxis.getCategoryMiddle(column, columnCount, dataArea, domainAxisEdge);
      float num3 = (float) domainAxis.getCategoryEnd(column, columnCount, dataArea, domainAxisEdge);
      float num4 = (float) Math.round(num1);
      float num5 = (float) Math.round(num2);
      float num6 = (float) Math.round(num3);
      if (this.endType == AreaRendererEndType.__\u003C\u003ETRUNCATE)
      {
        if (column == 0)
          num4 = num5;
        else if (column == this.getColumnCount() - 1)
          num6 = num5;
      }
      double d1 = number1.doubleValue();
      double d2 = 0.0;
      if (column > 0)
      {
        Number number2 = dataset.getValue(row, column - 1);
        if (number2 != null)
          d2 = (number2.doubleValue() + d1) / 2.0;
      }
      double d3 = 0.0;
      if (column < dataset.getColumnCount() - 1)
      {
        Number number2 = dataset.getValue(row, column + 1);
        if (number2 != null)
          d3 = (number2.doubleValue() + d1) / 2.0;
      }
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      float num7 = (float) rangeAxis.valueToJava2D(d2, dataArea, rangeAxisEdge);
      float num8 = (float) rangeAxis.valueToJava2D(d1, dataArea, rangeAxisEdge);
      float num9 = (float) rangeAxis.valueToJava2D(d3, dataArea, rangeAxisEdge);
      float num10 = (float) rangeAxis.valueToJava2D(0.0, dataArea, rangeAxisEdge);
      g2.setPaint(this.getItemPaint(row, column));
      g2.setStroke(this.getItemStroke(row, column));
      GeneralPath generalPath = new GeneralPath();
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        ((Path2D.Float) generalPath).moveTo(num4, num10);
        ((Path2D.Float) generalPath).lineTo(num4, num7);
        ((Path2D.Float) generalPath).lineTo(num5, num8);
        ((Path2D.Float) generalPath).lineTo(num6, num9);
        ((Path2D.Float) generalPath).lineTo(num6, num10);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        ((Path2D.Float) generalPath).moveTo(num10, num4);
        ((Path2D.Float) generalPath).lineTo(num7, num4);
        ((Path2D.Float) generalPath).lineTo(num8, num5);
        ((Path2D.Float) generalPath).lineTo(num9, num6);
        ((Path2D.Float) generalPath).lineTo(num10, num6);
      }
      ((Path2D) generalPath).closePath();
      g2.setPaint(this.getItemPaint(row, column));
      g2.fill((Shape) generalPath);
      if (this.isItemLabelVisible(row, column))
        this.drawItemLabel(g2, orientation, dataset, row, column, (double) num5, (double) num8, number1.doubleValue() < 0.0);
      int datasetIndex = plot.indexOf(dataset);
      this.updateCrosshairValues(state.getCrosshairState(), dataset.getRowKey(row), dataset.getColumnKey(column), d1, datasetIndex, (double) num5, (double) num8, orientation);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) generalPath);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AreaRenderer) || !this.endType.equals((object) ((AreaRenderer) obj).endType))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 358)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
