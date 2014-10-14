// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.ScatterRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.data.statistics;
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
  public class ScatterRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private BooleanList seriesShapesFilled;
    private bool baseShapesFilled;
    private bool useFillPaint;
    private bool drawOutlines;
    private bool useOutlinePaint;
    private bool useSeriesOffset;
    private double itemMargin;

    [HideFromJava]
    static ScatterRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 104, (byte) 107, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScatterRenderer()
    {
      ScatterRenderer scatterRenderer = this;
      this.seriesShapesFilled = new BooleanList();
      this.baseShapesFilled = true;
      this.useFillPaint = false;
      this.drawOutlines = false;
      this.useOutlinePaint = false;
      this.useSeriesOffset = true;
      this.itemMargin = 0.2;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ScatterRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ScatterRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ScatterRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 109, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getSeriesShapesFilled(int series)
    {
      Boolean boolean = this.seriesShapesFilled.getBoolean(series);
      if (boolean == null)
        return this.baseShapesFilled;
      return (boolean.booleanValue() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 268)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemShapeFilled(int series, int item)
    {
      return (this.getSeriesShapesFilled(series) ? 1 : 0) != 0;
    }

    public virtual bool getUseSeriesOffset()
    {
      return this.useSeriesOffset;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseSeriesOffset(bool offset)
    {
      this.useSeriesOffset = offset;
      this.fireChangeEvent();
    }

    public virtual double getItemMargin()
    {
      return this.itemMargin;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 114, (byte) 144, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemMargin(double margin)
    {
      if (margin < 0.0 || margin >= 1.0)
      {
        string str = "Requires 0.0 <= margin < 1.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.itemMargin = margin;
        this.fireChangeEvent();
      }
    }

    public virtual bool getDrawOutlines()
    {
      return this.drawOutlines;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 86, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawOutlines(bool flag)
    {
      this.drawOutlines = flag;
      this.fireChangeEvent();
    }

    public virtual bool getUseOutlinePaint()
    {
      return this.useOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 80, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseOutlinePaint(bool use)
    {
      this.useOutlinePaint = use;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 183, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, Boolean filled)
    {
      this.seriesShapesFilled.setBoolean(series, filled);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 65, (byte) 98, (byte) 146, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, bool filled)
    {
      int num = filled ? 1 : 0;
      this.seriesShapesFilled.setBoolean(series, BooleanUtilities.valueOf(num != 0));
      this.fireChangeEvent();
    }

    public virtual bool getBaseShapesFilled()
    {
      return this.baseShapesFilled;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 60, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShapesFilled(bool flag)
    {
      this.baseShapesFilled = flag;
      this.fireChangeEvent();
    }

    public virtual bool getUseFillPaint()
    {
      return this.useFillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 54, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseFillPaint(bool flag)
    {
      this.useFillPaint = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 7, (byte) 108, (byte) 129, (byte) 105, (byte) 100, (byte) 129, (byte) 135, (byte) 136, (byte) 104, (byte) 108, (byte) 100, (byte) 129, (byte) 105, (byte) 172, (byte) 104, (byte) 255, (byte) 6, (byte) 69, (byte) 186, (byte) 112, (byte) 106, (byte) 180, (byte) 108, (byte) 104, (byte) 143, (byte) 104, (byte) 141, (byte) 108, (byte) 104, (byte) 178, (byte) 144, (byte) 136, (byte) 104, (byte) 104, (byte) 178, (byte) 144, (byte) 112, (byte) 232, (byte) 23, (byte) 235, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column))
        return;
      int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
      if (visibleSeriesIndex < 0)
        return;
      int visibleSeriesCount = state.getVisibleSeriesCount();
      PlotOrientation orientation = plot.getOrientation();
      List values = ((MultiValueCategoryDataset) dataset).getValues(row, column);
      if (values == null)
        return;
      int num1 = values.size();
      for (int index = 0; index < num1; ++index)
      {
        double num2 = !this.useSeriesOffset ? domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) : domainAxis.getCategorySeriesMiddle(column, dataset.getColumnCount(), visibleSeriesIndex, visibleSeriesCount, this.itemMargin, dataArea, plot.getDomainAxisEdge());
        double d = ((Number) values.get(index)).doubleValue();
        double num3 = rangeAxis.valueToJava2D(d, dataArea, plot.getRangeAxisEdge());
        Shape shape = this.getItemShape(row, column);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num3, num2);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num2, num3);
        if (this.getItemShapeFilled(row, column))
        {
          if (this.useFillPaint)
            g2.setPaint(this.getItemFillPaint(row, column));
          else
            g2.setPaint(this.getItemPaint(row, column));
          g2.fill(shape);
        }
        if (this.drawOutlines)
        {
          if (this.useOutlinePaint)
            g2.setPaint(this.getItemOutlinePaint(row, column));
          else
            g2.setPaint(this.getItemPaint(row, column));
          g2.setStroke(this.getItemOutlineStroke(row, column));
          g2.draw(shape);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 103, (byte) 99, (byte) 162, (byte) 120, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 150, (byte) 104, (byte) 150, (byte) 105, (byte) 255, (byte) 56, (byte) 69, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 110, (byte) 104, (byte) 131})]
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
      Paint paint1 = this.lookupSeriesPaint(series);
      Paint fillPaint = !this.useFillPaint ? paint1 : this.getItemFillPaint(series, 0);
      int num = this.drawOutlines ? 1 : 0;
      Paint outlinePaint = !this.useOutlinePaint ? paint1 : this.getItemOutlinePaint(series, 0);
      Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
      LegendItem.__\u003Cclinit\u003E();
      LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, true, shape, this.getItemShapeFilled(series, 0), fillPaint, num != 0, outlinePaint, outlineStroke, false, (Shape) new Line2D.Double(-7.0, 0.0, 7.0, 0.0), this.getItemStroke(series, 0), this.getItemPaint(series, 0));
      legendItem.setLabelFont(this.lookupLegendTextFont(series));
      Paint paint2 = this.lookupLegendTextPaint(series);
      if (paint2 != null)
        legendItem.setLabelPaint(paint2);
      legendItem.setDataset((Dataset) dataset);
      legendItem.setDatasetIndex(datasetIndex);
      legendItem.setSeriesKey(dataset.getRowKey(series));
      legendItem.setSeriesIndex(series);
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 136, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ScatterRenderer))
        return false;
      ScatterRenderer scatterRenderer = (ScatterRenderer) obj;
      if (!ObjectUtilities.equal((object) this.seriesShapesFilled, (object) scatterRenderer.seriesShapesFilled) || this.baseShapesFilled != scatterRenderer.baseShapesFilled || (this.useFillPaint != scatterRenderer.useFillPaint || this.drawOutlines != scatterRenderer.drawOutlines) || (this.useOutlinePaint != scatterRenderer.useOutlinePaint || this.useSeriesOffset != scatterRenderer.useSeriesOffset || this.itemMargin != scatterRenderer.itemMargin))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 176, (byte) 108, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      ScatterRenderer scatterRenderer = (ScatterRenderer) base.clone();
      scatterRenderer.seriesShapesFilled = (BooleanList) this.seriesShapesFilled.clone();
      return (object) scatterRenderer;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 202, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
    }
  }
}
