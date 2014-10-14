// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYLineAndShapeRenderer
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
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYLineAndShapeRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -7435246895986425885L;
    [Obsolete]
    private Boolean linesVisible;
    private BooleanList seriesLinesVisible;
    private bool baseLinesVisible;
    [NonSerialized]
    private Shape legendLine;
    [Obsolete]
    private Boolean shapesVisible;
    private BooleanList seriesShapesVisible;
    private bool baseShapesVisible;
    [Obsolete]
    private Boolean shapesFilled;
    private BooleanList seriesShapesFilled;
    private bool baseShapesFilled;
    private bool drawOutlines;
    private bool useFillPaint;
    private bool useOutlinePaint;
    private bool drawSeriesLineAsPath;

    [HideFromJava]
    static XYLineAndShapeRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 92, (byte) 164, (byte) 104, (byte) 103, (byte) 107, (byte) 103, (byte) 159, (byte) 8, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 167, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYLineAndShapeRenderer(bool lines, bool shapes)
    {
      int num1 = lines ? 1 : 0;
      int num2 = shapes ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      XYLineAndShapeRenderer andShapeRenderer = this;
      this.linesVisible = (Boolean) null;
      this.seriesLinesVisible = new BooleanList();
      this.baseLinesVisible = num1 != 0;
      this.legendLine = (Shape) new Line2D.Double(-7.0, 0.0, 7.0, 0.0);
      this.shapesVisible = (Boolean) null;
      this.seriesShapesVisible = new BooleanList();
      this.baseShapesVisible = num2 != 0;
      this.shapesFilled = (Boolean) null;
      this.useFillPaint = false;
      this.seriesShapesFilled = new BooleanList();
      this.baseShapesFilled = true;
      this.drawOutlines = true;
      this.useOutlinePaint = false;
      this.drawSeriesLineAsPath = false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYLineAndShapeRenderer()
      : this(true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYLineAndShapeRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYLineAndShapeRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYLineAndShapeRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 2, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShapesVisible(bool flag)
    {
      this.baseShapesVisible = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 229, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShapesFilled(bool flag)
    {
      this.baseShapesFilled = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 81, (byte) 162, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawSeriesLineAsPath(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.drawSeriesLineAsPath ? 1 : 0) == num)
        return;
      this.drawSeriesLineAsPath = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 347)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesLinesVisible(int series)
    {
      return this.seriesLinesVisible.getBoolean(series);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 202, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLinesVisible(Boolean visible)
    {
      this.linesVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesLinesVisible(int series, Boolean flag)
    {
      this.seriesLinesVisible.setBoolean(series, flag);
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 510)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesShapesVisible(int series)
    {
      return this.seriesShapesVisible.getBoolean(series);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 111, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesVisible(Boolean visible)
    {
      this.shapesVisible = visible;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 166, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesVisible(int series, Boolean flag)
    {
      this.seriesShapesVisible.setBoolean(series, flag);
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 628)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesShapesFilled(int series)
    {
      return this.seriesShapesFilled.getBoolean(series);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 243, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(Boolean filled)
    {
      this.shapesFilled = filled;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 28, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, Boolean flag)
    {
      this.seriesShapesFilled.setBoolean(series, flag);
      this.fireChangeEvent();
    }

    protected internal virtual bool isLinePass(int pass)
    {
      return pass == 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemLineVisible(int series, int item)
    {
      Boolean boolean = this.linesVisible ?? this.getSeriesLinesVisible(series);
      if (boolean == null)
        return this.baseLinesVisible;
      return (boolean.booleanValue() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 189, (byte) 103, (byte) 167, (byte) 109, (byte) 109, (byte) 110, (byte) 142, (byte) 136, (byte) 120, (byte) 101, (byte) 101, (byte) 104, (byte) 105, (byte) 101, (byte) 133, (byte) 105, (byte) 178, (byte) 144, (byte) 104, (byte) 130, (byte) 168, (byte) 139, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawPrimaryLineAsPath(XYItemRendererState state, Graphics2D g2, XYPlot plot, XYDataset dataset, int pass, int series, int item, ValueAxis domainAxis, ValueAxis rangeAxis, Rectangle2D dataArea)
    {
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(yvalue, dataArea, rangeAxisEdge);
      XYLineAndShapeRenderer.State state1 = (XYLineAndShapeRenderer.State) state;
      if (!Double.isNaN(num1) && !Double.isNaN(num2))
      {
        float num3 = (float) num1;
        float num4 = (float) num2;
        if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          num3 = (float) num2;
          num4 = (float) num1;
        }
        if (state1.isLastPointGood())
          ((Path2D.Float) state1.seriesPath).lineTo(num3, num4);
        else
          ((Path2D.Float) state1.seriesPath).moveTo(num3, num4);
        state1.setLastPointGood(true);
      }
      else
        state1.setLastPointGood(false);
      if (item != state1.getLastItemIndex())
        return;
      this.drawFirstPassShape(g2, pass, series, item, (Shape) state1.seriesPath);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 98, (byte) 100, (byte) 193, (byte) 109, (byte) 109, (byte) 112, (byte) 161, (byte) 111, (byte) 111, (byte) 112, (byte) 161, (byte) 104, (byte) 136, (byte) 111, (byte) 143, (byte) 111, (byte) 175, (byte) 159, (byte) 5, (byte) 161, (byte) 104, (byte) 105, (byte) 149, (byte) 105, (byte) 179, (byte) 111, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawPrimaryLine(XYItemRendererState state, Graphics2D g2, XYPlot plot, XYDataset dataset, int pass, int series, int item, ValueAxis domainAxis, ValueAxis rangeAxis, Rectangle2D dataArea)
    {
      if (item == 0)
        return;
      double xvalue1 = dataset.getXValue(series, item);
      double yvalue1 = dataset.getYValue(series, item);
      if (Double.isNaN(yvalue1) || Double.isNaN(xvalue1))
        return;
      double xvalue2 = dataset.getXValue(series, item - 1);
      double yvalue2 = dataset.getYValue(series, item - 1);
      if (Double.isNaN(yvalue2) || Double.isNaN(xvalue2))
        return;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = domainAxis.valueToJava2D(xvalue2, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(yvalue2, dataArea, rangeAxisEdge);
      double num3 = domainAxis.valueToJava2D(xvalue1, dataArea, domainAxisEdge);
      double num4 = rangeAxis.valueToJava2D(yvalue1, dataArea, rangeAxisEdge);
      if (Double.isNaN(num1) || Double.isNaN(num2) || (Double.isNaN(num3) || Double.isNaN(num4)))
        return;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        state.workingLine.setLine(num2, num1, num4, num3);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        state.workingLine.setLine(num1, num2, num3, num4);
      if (!state.workingLine.intersects(dataArea))
        return;
      this.drawFirstPassShape(g2, pass, series, item, (Shape) state.workingLine);
    }

    protected internal virtual bool isItemPass(int pass)
    {
      return pass == 1;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 254, (byte) 162, (byte) 108, (byte) 108, (byte) 112, (byte) 161, (byte) 103, (byte) 104, (byte) 104, (byte) 111, (byte) 143, (byte) 111, (byte) 108, (byte) 104, (byte) 175, (byte) 104, (byte) 173, (byte) 99, (byte) 110, (byte) 108, (byte) 104, (byte) 178, (byte) 144, (byte) 136, (byte) 104, (byte) 104, (byte) 178, (byte) 144, (byte) 112, (byte) 232, (byte) 69, (byte) 100, (byte) 100, (byte) 104, (byte) 100, (byte) 196, (byte) 108, (byte) 217, (byte) 106, (byte) 106, (byte) 243, (byte) 69, (byte) 113, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawSecondaryPass(Graphics2D g2, XYPlot plot, XYDataset dataset, int pass, int series, int item, ValueAxis domainAxis, Rectangle2D dataArea, ValueAxis rangeAxis, CrosshairState crosshairState, EntityCollection entities)
    {
      Shape area = (Shape) null;
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      if (Double.isNaN(yvalue) || Double.isNaN(xvalue))
        return;
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(yvalue, dataArea, rangeAxisEdge);
      if (this.getItemShapeVisible(series, item))
      {
        Shape shape = this.getItemShape(series, item);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num2, num1);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num1, num2);
        area = shape;
        if (shape.intersects(dataArea))
        {
          if (this.getItemShapeFilled(series, item))
          {
            if (this.useFillPaint)
              g2.setPaint(this.getItemFillPaint(series, item));
            else
              g2.setPaint(this.getItemPaint(series, item));
            g2.fill(shape);
          }
          if (this.drawOutlines)
          {
            if (this.getUseOutlinePaint())
              g2.setPaint(this.getItemOutlinePaint(series, item));
            else
              g2.setPaint(this.getItemPaint(series, item));
            g2.setStroke(this.getItemOutlineStroke(series, item));
            g2.draw(shape);
          }
        }
      }
      double num3 = num1;
      double num4 = num2;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num3 = num2;
        num4 = num1;
      }
      if (this.isItemLabelVisible(series, item))
        this.drawItemLabel(g2, orientation, dataset, series, item, num3, num4, yvalue < 0.0);
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, xvalue, yvalue, domainAxisIndex, rangeAxisIndex, num1, num2, orientation);
      if (entities == null || !AbstractXYItemRenderer.isPointInRect(dataArea, num3, num4))
        return;
      this.addEntity(entities, area, dataset, series, item, num3, num4);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 154, (byte) 111, (byte) 111, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawFirstPassShape(Graphics2D g2, int pass, int series, int item, Shape shape)
    {
      g2.setStroke(this.getItemStroke(series, item));
      g2.setPaint(this.getItemPaint(series, item));
      g2.draw(shape);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemShapeVisible(int series, int item)
    {
      Boolean boolean = this.shapesVisible ?? this.getSeriesShapesVisible(series);
      if (boolean == null)
        return this.baseShapesVisible;
      return (boolean.booleanValue() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 210, (byte) 103, (byte) 99, (byte) 136, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemShapeFilled(int series, int item)
    {
      Boolean boolean = this.shapesFilled ?? this.getSeriesShapesFilled(series);
      if (boolean == null)
        return this.baseShapesFilled;
      return (boolean.booleanValue() ? 1 : 0) != 0;
    }

    public virtual bool getUseOutlinePaint()
    {
      return this.useOutlinePaint;
    }

    public virtual bool getDrawSeriesLineAsPath()
    {
      return this.drawSeriesLineAsPath;
    }

    public override int getPassCount()
    {
      return 2;
    }

    [Obsolete]
    public virtual Boolean getLinesVisible()
    {
      return this.linesVisible;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 59, (byte) 98, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLinesVisible(bool visible)
    {
      this.setLinesVisible(BooleanUtilities.valueOf(visible));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 49, (byte) 130, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesLinesVisible(int series, bool visible)
    {
      int num = visible ? 1 : 0;
      this.setSeriesLinesVisible(series, BooleanUtilities.valueOf(num != 0));
    }

    public virtual bool getBaseLinesVisible()
    {
      return this.baseLinesVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 43, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseLinesVisible(bool flag)
    {
      this.baseLinesVisible = flag;
      this.fireChangeEvent();
    }

    public virtual Shape getLegendLine()
    {
      return this.legendLine;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 51, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendLine(Shape line)
    {
      if (line == null)
      {
        string str = "Null 'line' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendLine = line;
        this.fireChangeEvent();
      }
    }

    [Obsolete]
    public virtual Boolean getShapesVisible()
    {
      return this.shapesVisible;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 18, (byte) 66, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesVisible(bool visible)
    {
      this.setShapesVisible(BooleanUtilities.valueOf(visible));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 12, (byte) 162, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesVisible(int series, bool visible)
    {
      int num = visible ? 1 : 0;
      this.setSeriesShapesVisible(series, BooleanUtilities.valueOf(num != 0));
    }

    public virtual bool getBaseShapesVisible()
    {
      return this.baseShapesVisible;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 158, (byte) 248, (byte) 98, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(bool filled)
    {
      this.setShapesFilled(BooleanUtilities.valueOf(filled));
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 238, (byte) 98, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, bool flag)
    {
      int num = flag ? 1 : 0;
      this.setSeriesShapesFilled(series, BooleanUtilities.valueOf(num != 0));
    }

    public virtual bool getBaseShapesFilled()
    {
      return this.baseShapesFilled;
    }

    public virtual bool getDrawOutlines()
    {
      return this.drawOutlines;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 222, (byte) 162, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawOutlines(bool flag)
    {
      this.drawOutlines = flag;
      this.fireChangeEvent();
    }

    public virtual bool getUseFillPaint()
    {
      return this.useFillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 214, (byte) 130, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseFillPaint(bool flag)
    {
      this.useFillPaint = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 206, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseOutlinePaint(bool flag)
    {
      this.useOutlinePaint = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 235, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      return (XYItemRendererState) new XYLineAndShapeRenderer.State(info)
      {
        seriesPath = new GeneralPath()
      };
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 17, (byte) 108, (byte) 193, (byte) 106, (byte) 111, (byte) 104, (byte) 217, (byte) 249, (byte) 70, (byte) 170, (byte) 98, (byte) 100, (byte) 173, (byte) 187})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      if (this.isLinePass(pass))
      {
        if (!this.getItemLineVisible(series, item))
          return;
        if (this.drawSeriesLineAsPath)
          this.drawPrimaryLineAsPath(state, g2, plot, dataset, pass, series, item, domainAxis, rangeAxis, dataArea);
        else
          this.drawPrimaryLine(state, g2, plot, dataset, pass, series, item, domainAxis, rangeAxis, dataArea);
      }
      else
      {
        if (!this.isItemPass(pass))
          return;
        EntityCollection entities = (EntityCollection) null;
        if (info != null)
          entities = info.getOwner().getEntityCollection();
        this.drawSecondaryPass(g2, plot, dataset, pass, series, item, domainAxis, dataArea, rangeAxis, crosshairState, entities);
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 83, (byte) 103, (byte) 99, (byte) 162, (byte) 98, (byte) 104, (byte) 102, (byte) 109, (byte) 142, (byte) 99, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 106, (byte) 105, (byte) 106, (byte) 186, (byte) 104, (byte) 186, (byte) 105, (byte) 106, (byte) 105, (byte) 105, (byte) 255, (byte) 13, (byte) 69, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 109, (byte) 103, (byte) 103, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      XYPlot plot = this.getPlot();
      if (plot == null)
        return (LegendItem) null;
      LegendItem legendItem = (LegendItem) null;
      XYDataset dataset = plot.getDataset(datasetIndex);
      if (dataset != null && this.getItemVisible(series, 0))
      {
        string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
        string description = label;
        string toolTipText = (string) null;
        if (this.getLegendItemToolTipGenerator() != null)
          toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
        string urlText = (string) null;
        if (this.getLegendItemURLGenerator() != null)
          urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
        int num1 = this.getItemShapeVisible(series, 0) ? 1 : 0;
        Shape shape = this.lookupLegendShape(series);
        int num2 = this.getItemShapeFilled(series, 0) ? 1 : 0;
        Paint fillPaint = !this.useFillPaint ? this.lookupSeriesPaint(series) : this.lookupSeriesFillPaint(series);
        int num3 = this.drawOutlines ? 1 : 0;
        Paint outlinePaint = !this.useOutlinePaint ? this.lookupSeriesPaint(series) : this.lookupSeriesOutlinePaint(series);
        Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
        int num4 = this.getItemLineVisible(series, 0) ? 1 : 0;
        Stroke lineStroke = this.lookupSeriesStroke(series);
        Paint linePaint = this.lookupSeriesPaint(series);
        LegendItem.__\u003Cclinit\u003E();
        legendItem = new LegendItem(label, description, toolTipText, urlText, num1 != 0, shape, num2 != 0, fillPaint, num3 != 0, outlinePaint, outlineStroke, num4 != 0, this.legendLine, lineStroke, linePaint);
        legendItem.setLabelFont(this.lookupLegendTextFont(series));
        Paint paint = this.lookupLegendTextPaint(series);
        if (paint != null)
          legendItem.setLabelPaint(paint);
        legendItem.setSeriesKey(dataset.getSeriesKey(series));
        legendItem.setSeriesIndex(series);
        legendItem.setDataset((Dataset) dataset);
        legendItem.setDatasetIndex(datasetIndex);
      }
      return legendItem;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 148, (byte) 108, (byte) 150, (byte) 104, (byte) 145, (byte) 150, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYLineAndShapeRenderer andShapeRenderer = (XYLineAndShapeRenderer) base.clone();
      andShapeRenderer.seriesLinesVisible = (BooleanList) this.seriesLinesVisible.clone();
      if (this.legendLine != null)
        andShapeRenderer.legendLine = ShapeUtilities.clone(this.legendLine);
      andShapeRenderer.seriesShapesVisible = (BooleanList) this.seriesShapesVisible.clone();
      andShapeRenderer.seriesShapesFilled = (BooleanList) this.seriesShapesFilled.clone();
      return (object) andShapeRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 169, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 179, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 179, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 179, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYLineAndShapeRenderer) || !base.equals(obj))
        return false;
      XYLineAndShapeRenderer andShapeRenderer = (XYLineAndShapeRenderer) obj;
      return ObjectUtilities.equal((object) this.linesVisible, (object) andShapeRenderer.linesVisible) && ObjectUtilities.equal((object) this.seriesLinesVisible, (object) andShapeRenderer.seriesLinesVisible) && (this.baseLinesVisible == andShapeRenderer.baseLinesVisible && ShapeUtilities.equal(this.legendLine, andShapeRenderer.legendLine)) && (ObjectUtilities.equal((object) this.shapesVisible, (object) andShapeRenderer.shapesVisible) && ObjectUtilities.equal((object) this.seriesShapesVisible, (object) andShapeRenderer.seriesShapesVisible) && (this.baseShapesVisible == andShapeRenderer.baseShapesVisible && ObjectUtilities.equal((object) this.shapesFilled, (object) andShapeRenderer.shapesFilled))) && (ObjectUtilities.equal((object) this.seriesShapesFilled, (object) andShapeRenderer.seriesShapesFilled) && this.baseShapesFilled == andShapeRenderer.baseShapesFilled && (this.drawOutlines == andShapeRenderer.drawOutlines && this.useOutlinePaint == andShapeRenderer.useOutlinePaint) && (this.useFillPaint == andShapeRenderer.useFillPaint && this.drawSeriesLineAsPath == andShapeRenderer.drawSeriesLineAsPath));
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 240, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendLine = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 252, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendLine, obj0);
    }

    [InnerClass]
    [SourceFile("XYLineAndShapeRenderer.java")]
    public class State : XYItemRendererState
    {
      public GeneralPath seriesPath;
      private bool lastPointGood;

      [LineNumberTable(new byte[] {(byte) 162, (byte) 169, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public State(PlotRenderingInfo info)
        : base(info)
      {
      }

      public virtual bool isLastPointGood()
      {
        return this.lastPointGood;
      }

      public virtual void setLastPointGood(bool good)
      {
        this.lastPointGood = good;
      }

      [LineNumberTable(new byte[] {(byte) 162, (byte) 205, (byte) 107, (byte) 103, (byte) 145})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void startSeriesPass(XYDataset dataset, int series, int firstItem, int lastItem, int pass, int passCount)
      {
        ((Path2D) this.seriesPath).reset();
        this.lastPointGood = false;
        base.startSeriesPass(dataset, series, firstItem, lastItem, pass, passCount);
      }
    }
  }
}
