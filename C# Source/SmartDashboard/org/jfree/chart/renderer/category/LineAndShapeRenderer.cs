// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.LineAndShapeRenderer
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
  public class LineAndShapeRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -197749519869226398L;
    [Obsolete]
    private Boolean linesVisible;
    private BooleanList seriesLinesVisible;
    private bool baseLinesVisible;
    [Obsolete]
    private Boolean shapesVisible;
    private BooleanList seriesShapesVisible;
    private bool baseShapesVisible;
    [Obsolete]
    private Boolean shapesFilled;
    private BooleanList seriesShapesFilled;
    private bool baseShapesFilled;
    private bool useFillPaint;
    private bool drawOutlines;
    private bool useOutlinePaint;
    private bool useSeriesOffset;
    private double itemMargin;

    [HideFromJava]
    static LineAndShapeRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 85, (byte) 132, (byte) 104, (byte) 103, (byte) 107, (byte) 103, (byte) 103, (byte) 107, (byte) 103, (byte) 103, (byte) 107, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineAndShapeRenderer(bool lines, bool shapes)
    {
      int num1 = lines ? 1 : 0;
      int num2 = shapes ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      LineAndShapeRenderer andShapeRenderer = this;
      this.linesVisible = (Boolean) null;
      this.seriesLinesVisible = new BooleanList();
      this.baseLinesVisible = num1 != 0;
      this.shapesVisible = (Boolean) null;
      this.seriesShapesVisible = new BooleanList();
      this.baseShapesVisible = num2 != 0;
      this.shapesFilled = (Boolean) null;
      this.seriesShapesFilled = new BooleanList();
      this.baseShapesFilled = true;
      this.useFillPaint = false;
      this.drawOutlines = true;
      this.useOutlinePaint = false;
      this.useSeriesOffset = false;
      this.itemMargin = 0.0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineAndShapeRenderer()
      : this(true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LineAndShapeRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LineAndShapeRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LineAndShapeRenderer obj0)
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

    public virtual bool getBaseLinesVisible()
    {
      return this.baseLinesVisible;
    }

    public virtual bool getBaseShapesVisible()
    {
      return this.baseShapesVisible;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 63, (byte) 130, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLinesVisible(bool visible)
    {
      this.setLinesVisible(BooleanUtilities.valueOf(visible));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 29, (byte) 98, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesVisible(bool visible)
    {
      this.setShapesVisible(BooleanUtilities.valueOf(visible));
    }

    [LineNumberTable((ushort) 332)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesLinesVisible(int series)
    {
      return this.seriesLinesVisible.getBoolean(series);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 187, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLinesVisible(Boolean visible)
    {
      this.linesVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 231, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesLinesVisible(int series, Boolean flag)
    {
      this.seriesLinesVisible.setBoolean(series, flag);
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 467)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesShapesVisible(int series)
    {
      return this.seriesShapesVisible.getBoolean(series);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 67, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesVisible(Boolean visible)
    {
      this.shapesVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 123, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesVisible(int series, Boolean flag)
    {
      this.seriesShapesVisible.setBoolean(series, flag);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 234, (byte) 104, (byte) 206, (byte) 109, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getSeriesShapesFilled(int series)
    {
      if (this.shapesFilled != null)
      {
        return (this.shapesFilled.booleanValue() ? 1 : 0) != 0;
      }
      else
      {
        Boolean boolean = this.seriesShapesFilled.getBoolean(series);
        if (boolean == null)
          return this.baseShapesFilled;
        return (boolean.booleanValue() ? 1 : 0) != 0;
      }
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 40, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(Boolean filled)
    {
      this.shapesFilled = filled;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 54, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, Boolean filled)
    {
      this.seriesShapesFilled.setBoolean(series, filled);
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemLineVisible(int series, int item)
    {
      Boolean boolean = this.linesVisible ?? this.getSeriesLinesVisible(series);
      if (boolean == null)
        return this.baseLinesVisible;
      return (boolean.booleanValue() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemShapeVisible(int series, int item)
    {
      Boolean boolean = this.shapesVisible ?? this.getSeriesShapesVisible(series);
      if (boolean == null)
        return this.baseShapesVisible;
      return (boolean.booleanValue() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 590)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemShapeFilled(int series, int item)
    {
      return (this.getSeriesShapesFilled(series) ? 1 : 0) != 0;
    }

    [Obsolete]
    public virtual Boolean getLinesVisible()
    {
      return this.linesVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 53, (byte) 162, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesLinesVisible(int series, bool visible)
    {
      int num = visible ? 1 : 0;
      this.setSeriesLinesVisible(series, BooleanUtilities.valueOf(num != 0));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 47, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseLinesVisible(bool flag)
    {
      this.baseLinesVisible = flag;
      this.fireChangeEvent();
    }

    [Obsolete]
    public virtual Boolean getShapesVisible()
    {
      return this.shapesVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 22, (byte) 66, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesVisible(int series, bool visible)
    {
      int num = visible ? 1 : 0;
      this.setSeriesShapesVisible(series, BooleanUtilities.valueOf(num != 0));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 13, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShapesVisible(bool flag)
    {
      this.baseShapesVisible = flag;
      this.fireChangeEvent();
    }

    public virtual bool getDrawOutlines()
    {
      return this.drawOutlines;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 6, (byte) 130, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 255, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseOutlinePaint(bool use)
    {
      this.useOutlinePaint = use;
      this.fireChangeEvent();
    }

    [Obsolete]
    public virtual Boolean getShapesFilled()
    {
      return this.shapesFilled;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 158, (byte) 237, (byte) 130, (byte) 99, (byte) 173, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(bool filled)
    {
      if (filled)
        this.setShapesFilled((Boolean) Boolean.TRUE);
      else
        this.setShapesFilled((Boolean) Boolean.FALSE);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 225, (byte) 162, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, bool filled)
    {
      int num = filled ? 1 : 0;
      this.setSeriesShapesFilled(series, BooleanUtilities.valueOf(num != 0));
    }

    public virtual bool getBaseShapesFilled()
    {
      return this.baseShapesFilled;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 219, (byte) 130, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 158, (byte) 212, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseFillPaint(bool flag)
    {
      this.useFillPaint = flag;
      this.fireChangeEvent();
    }

    public virtual bool getUseSeriesOffset()
    {
      return this.useSeriesOffset;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 205, (byte) 162, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 183, (byte) 114, (byte) 144, (byte) 105, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 200, (byte) 103, (byte) 99, (byte) 162, (byte) 120, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 150, (byte) 104, (byte) 150, (byte) 105, (byte) 106, (byte) 106, (byte) 255, (byte) 58, (byte) 69, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 110, (byte) 104, (byte) 131})]
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
      int num1 = this.drawOutlines ? 1 : 0;
      Paint outlinePaint = !this.useOutlinePaint ? paint1 : this.getItemOutlinePaint(series, 0);
      Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
      int num2 = this.getItemLineVisible(series, 0) ? 1 : 0;
      int num3 = this.getItemShapeVisible(series, 0) ? 1 : 0;
      LegendItem.__\u003Cclinit\u003E();
      LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, num3 != 0, shape, this.getItemShapeFilled(series, 0), fillPaint, num1 != 0, outlinePaint, outlineStroke, num2 != 0, (Shape) new Line2D.Double(-7.0, 0.0, 7.0, 0.0), this.getItemStroke(series, 0), this.getItemPaint(series, 0));
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

    public override int getPassCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 23, (byte) 108, (byte) 193, (byte) 152, (byte) 193, (byte) 108, (byte) 99, (byte) 161, (byte) 105, (byte) 100, (byte) 129, (byte) 135, (byte) 200, (byte) 104, (byte) 255, (byte) 6, (byte) 69, (byte) 186, (byte) 105, (byte) 180, (byte) 118, (byte) 103, (byte) 111, (byte) 135, (byte) 138, (byte) 104, (byte) 255, (byte) 8, (byte) 71, (byte) 220, (byte) 180, (byte) 99, (byte) 104, (byte) 145, (byte) 104, (byte) 143, (byte) 112, (byte) 112, (byte) 232, (byte) 69, (byte) 104, (byte) 108, (byte) 104, (byte) 143, (byte) 104, (byte) 173, (byte) 111, (byte) 108, (byte) 104, (byte) 178, (byte) 144, (byte) 136, (byte) 104, (byte) 104, (byte) 178, (byte) 144, (byte) 112, (byte) 232, (byte) 69, (byte) 108, (byte) 104, (byte) 189, (byte) 104, (byte) 251, (byte) 70, (byte) 107, (byte) 255, (byte) 8, (byte) 69, (byte) 104, (byte) 100, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column) || !this.getItemLineVisible(row, column) && !this.getItemShapeVisible(row, column))
        return;
      Number number1 = dataset.getValue(row, column);
      if (number1 == null)
        return;
      int visibleSeriesIndex = state.getVisibleSeriesIndex(row);
      if (visibleSeriesIndex < 0)
        return;
      int visibleSeriesCount = state.getVisibleSeriesCount();
      PlotOrientation orientation = plot.getOrientation();
      double num1 = !this.useSeriesOffset ? domainAxis.getCategoryMiddle(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) : domainAxis.getCategorySeriesMiddle(column, dataset.getColumnCount(), visibleSeriesIndex, visibleSeriesCount, this.itemMargin, dataArea, plot.getDomainAxisEdge());
      double d1 = number1.doubleValue();
      double num2 = rangeAxis.valueToJava2D(d1, dataArea, plot.getRangeAxisEdge());
      if (pass == 0 && this.getItemLineVisible(row, column) && column != 0)
      {
        Number number2 = dataset.getValue(row, column - 1);
        if (number2 != null)
        {
          double d2 = number2.doubleValue();
          double num3 = !this.useSeriesOffset ? domainAxis.getCategoryMiddle(column - 1, this.getColumnCount(), dataArea, plot.getDomainAxisEdge()) : domainAxis.getCategorySeriesMiddle(column - 1, dataset.getColumnCount(), visibleSeriesIndex, visibleSeriesCount, this.itemMargin, dataArea, plot.getDomainAxisEdge());
          double num4 = rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge());
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
      Shape shape = this.getItemShape(row, column);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        shape = ShapeUtilities.createTranslatedShape(shape, num2, num1);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        shape = ShapeUtilities.createTranslatedShape(shape, num1, num2);
      if (this.getItemShapeVisible(row, column))
      {
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
      if (this.isItemLabelVisible(row, column))
      {
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          this.drawItemLabel(g2, orientation, dataset, row, column, num2, num1, d1 < 0.0);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          this.drawItemLabel(g2, orientation, dataset, row, column, num1, num2, d1 < 0.0);
      }
      int datasetIndex = plot.indexOf(dataset);
      this.updateCrosshairValues(state.getCrosshairState(), dataset.getRowKey(row), dataset.getColumnKey(column), d1, datasetIndex, num1, num2, orientation);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, shape);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 165, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LineAndShapeRenderer))
        return false;
      LineAndShapeRenderer andShapeRenderer = (LineAndShapeRenderer) obj;
      if (this.baseLinesVisible != andShapeRenderer.baseLinesVisible || !ObjectUtilities.equal((object) this.seriesLinesVisible, (object) andShapeRenderer.seriesLinesVisible) || (!ObjectUtilities.equal((object) this.linesVisible, (object) andShapeRenderer.linesVisible) || this.baseShapesVisible != andShapeRenderer.baseShapesVisible) || (!ObjectUtilities.equal((object) this.seriesShapesVisible, (object) andShapeRenderer.seriesShapesVisible) || !ObjectUtilities.equal((object) this.shapesVisible, (object) andShapeRenderer.shapesVisible) || (!ObjectUtilities.equal((object) this.shapesFilled, (object) andShapeRenderer.shapesFilled) || !ObjectUtilities.equal((object) this.seriesShapesFilled, (object) andShapeRenderer.seriesShapesFilled))) || (this.baseShapesFilled != andShapeRenderer.baseShapesFilled || this.useOutlinePaint != andShapeRenderer.useOutlinePaint || (this.useSeriesOffset != andShapeRenderer.useSeriesOffset || this.itemMargin != andShapeRenderer.itemMargin)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 223, (byte) 108, (byte) 150, (byte) 150, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      LineAndShapeRenderer andShapeRenderer = (LineAndShapeRenderer) base.clone();
      andShapeRenderer.seriesLinesVisible = (BooleanList) this.seriesLinesVisible.clone();
      andShapeRenderer.seriesShapesVisible = (BooleanList) this.seriesShapesVisible.clone();
      andShapeRenderer.seriesShapesFilled = (BooleanList) this.seriesShapesFilled.clone();
      return (object) andShapeRenderer;
    }
  }
}
