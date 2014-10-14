// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.StandardXYItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.awt.image;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
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
  public class StandardXYItemRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -3271351259436865995L;
    public const int SHAPES = 1;
    public const int LINES = 2;
    public const int SHAPES_AND_LINES = 3;
    public const int IMAGES = 4;
    public const int DISCONTINUOUS = 8;
    public const int DISCONTINUOUS_LINES = 10;
    private bool baseShapesVisible;
    private bool plotLines;
    private bool plotImages;
    private bool plotDiscontinuous;
    private UnitType gapThresholdType;
    private double gapThreshold;
    [Obsolete]
    private Boolean shapesFilled;
    private BooleanList seriesShapesFilled;
    private bool baseShapesFilled;
    private bool drawSeriesLineAsPath;
    [NonSerialized]
    private Shape legendLine;

    [HideFromJava]
    static StandardXYItemRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemRenderer(int type, XYToolTipGenerator toolTipGenerator)
      : this(type, toolTipGenerator, (XYURLGenerator) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 232, (byte) 159, (byte) 177, (byte) 171, (byte) 236, (byte) 160, (byte) 77, (byte) 103, (byte) 103, (byte) 101, (byte) 135, (byte) 101, (byte) 135, (byte) 101, (byte) 135, (byte) 101, (byte) 167, (byte) 103, (byte) 107, (byte) 103, (byte) 127, (byte) 8, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemRenderer(int type, XYToolTipGenerator toolTipGenerator, XYURLGenerator urlGenerator)
    {
      StandardXYItemRenderer standardXyItemRenderer = this;
      this.gapThresholdType = UnitType.__\u003C\u003ERELATIVE;
      this.gapThreshold = 1.0;
      this.setBaseToolTipGenerator(toolTipGenerator);
      this.setURLGenerator(urlGenerator);
      if ((type & 1) != 0)
        this.baseShapesVisible = true;
      if ((type & 2) != 0)
        this.plotLines = true;
      if ((type & 4) != 0)
        this.plotImages = true;
      if ((type & 8) != 0)
        this.plotDiscontinuous = true;
      this.shapesFilled = (Boolean) null;
      this.seriesShapesFilled = new BooleanList();
      this.baseShapesFilled = true;
      this.legendLine = (Shape) new Line2D.Double(-7.0, 0.0, 7.0, 0.0);
      this.drawSeriesLineAsPath = false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemRenderer()
      : this(2, (XYToolTipGenerator) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemRenderer(int type)
      : this(type, (XYToolTipGenerator) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardXYItemRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardXYItemRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardXYItemRenderer obj0)
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

    public virtual bool getPlotLines()
    {
      return this.plotLines;
    }

    public virtual bool getBaseShapesVisible()
    {
      return this.baseShapesVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 23, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlotLines(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.plotLines ? 1 : 0) == num)
        return;
      this.plotLines = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 64, (byte) 130, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseShapesVisible(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.baseShapesVisible ? 1 : 0) == num)
        return;
      this.baseShapesVisible = num != 0;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 33, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(Boolean filled)
    {
      this.shapesFilled = filled;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 225, (byte) 104, (byte) 206, (byte) 109, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getItemShapeFilled(int series, int item)
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

    public virtual bool getPlotDiscontinuous()
    {
      return this.plotDiscontinuous;
    }

    public virtual double getGapThreshold()
    {
      return this.gapThreshold;
    }

    public virtual bool getPlotImages()
    {
      return this.plotImages;
    }

    protected internal virtual Image getImage(Plot plot, int series, int item, double x, double y)
    {
      return (Image) null;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 237, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Point getImageHotspot(Plot plot, int series, int item, double x, double y, Image image)
    {
      int height = image.getHeight((ImageObserver) null);
      return new Point(image.getWidth((ImageObserver) null) / 2, height / 2);
    }

    [Obsolete]
    public virtual Boolean getShapesFilled()
    {
      return this.shapesFilled;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 46, (byte) 98, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapesFilled(bool filled)
    {
      this.setShapesFilled(BooleanUtilities.valueOf(filled));
    }

    [LineNumberTable((ushort) 416)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Boolean getSeriesShapesFilled(int series)
    {
      return this.seriesShapesFilled.getBoolean(series);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 59, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesShapesFilled(int series, Boolean flag)
    {
      this.seriesShapesFilled.setBoolean(series, flag);
      this.fireChangeEvent();
    }

    public virtual bool getBaseShapesFilled()
    {
      return this.baseShapesFilled;
    }

    public virtual void setBaseShapesFilled(bool flag)
    {
      this.baseShapesFilled = flag;
    }

    public virtual UnitType getGapThresholdType()
    {
      return this.gapThresholdType;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 133, (byte) 99, (byte) 176, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGapThresholdType(UnitType thresholdType)
    {
      if (thresholdType == null)
      {
        string str = "Null 'thresholdType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.gapThresholdType = thresholdType;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 161, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGapThreshold(double t)
    {
      this.gapThreshold = t;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 3, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlotImages(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.plotImages ? 1 : 0) == num)
        return;
      this.plotImages = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 253, (byte) 130, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlotDiscontinuous(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.plotDiscontinuous ? 1 : 0) == num)
        return;
      this.plotDiscontinuous = num != 0;
      this.fireChangeEvent();
    }

    public virtual bool getDrawSeriesLineAsPath()
    {
      return this.drawSeriesLineAsPath;
    }

    public virtual void setDrawSeriesLineAsPath(bool flag)
    {
      this.drawSeriesLineAsPath = flag;
    }

    public virtual Shape getLegendLine()
    {
      return this.legendLine;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 6, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 162, (byte) 22, (byte) 103, (byte) 99, (byte) 130, (byte) 98, (byte) 104, (byte) 102, (byte) 109, (byte) 142, (byte) 99, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 106, (byte) 105, (byte) 100, (byte) 105, (byte) 223, (byte) 27, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 103, (byte) 103, (byte) 109, (byte) 167})]
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
        Shape shape = this.lookupLegendShape(series);
        int num = this.getItemShapeFilled(series, 0) ? 1 : 0;
        Paint paint1 = this.lookupSeriesPaint(series);
        Paint linePaint = paint1;
        Stroke stroke = this.lookupSeriesStroke(series);
        LegendItem.__\u003Cclinit\u003E();
        legendItem = new LegendItem(label, description, toolTipText, urlText, this.baseShapesVisible, shape, num != 0, paint1, num == 0, paint1, stroke, this.plotLines, this.legendLine, stroke, linePaint);
        legendItem.setLabelFont(this.lookupLegendTextFont(series));
        Paint paint2 = this.lookupLegendTextPaint(series);
        if (paint2 != null)
          legendItem.setLabelPaint(paint2);
        legendItem.setDataset((Dataset) dataset);
        legendItem.setDatasetIndex(datasetIndex);
        legendItem.setSeriesKey(dataset.getSeriesKey(series));
        legendItem.setSeriesIndex(series);
      }
      return legendItem;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 155, (byte) 104, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      StandardXYItemRenderer.State state = new StandardXYItemRenderer.State(info);
      state.seriesPath = new GeneralPath();
      StandardXYItemRenderer.State.access\u0024002(state, -1);
      return (XYItemRendererState) state;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 193, (byte) 171, (byte) 98, (byte) 98, (byte) 100, (byte) 173, (byte) 104, (byte) 108, (byte) 108, (byte) 104, (byte) 168, (byte) 110, (byte) 110, (byte) 114, (byte) 162, (byte) 105, (byte) 105, (byte) 111, (byte) 143, (byte) 107, (byte) 107, (byte) 104, (byte) 139, (byte) 108, (byte) 105, (byte) 201, (byte) 158, (byte) 101, (byte) 101, (byte) 104, (byte) 101, (byte) 133, (byte) 137, (byte) 178, (byte) 144, (byte) 104, (byte) 130, (byte) 136, (byte) 111, (byte) 139, (byte) 110, (byte) 110, (byte) 173, (byte) 133, (byte) 141, (byte) 112, (byte) 112, (byte) 120, (byte) 99, (byte) 171, (byte) 107, (byte) 109, (byte) 112, (byte) 109, (byte) 185, (byte) 223, (byte) 2, (byte) 103, (byte) 143, (byte) 207, (byte) 159, (byte) 5, (byte) 161, (byte) 104, (byte) 181, (byte) 104, (byte) 211, (byte) 110, (byte) 236, (byte) 74, (byte) 99, (byte) 161, (byte) 139, (byte) 108, (byte) 104, (byte) 175, (byte) 104, (byte) 173, (byte) 106, (byte) 108, (byte) 170, (byte) 168, (byte) 195, (byte) 107, (byte) 114, (byte) 103, (byte) 148, (byte) 159, (byte) 9, (byte) 255, (byte) 13, (byte) 71, (byte) 100, (byte) 100, (byte) 104, (byte) 100, (byte) 196, (byte) 108, (byte) 219, (byte) 107, (byte) 107, (byte) 213, (byte) 111, (byte) 191, (byte) 28})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      int num1 = this.getItemVisible(series, item) ? 1 : 0;
      object obj1 = (object) null;
      EntityCollection entityCollection = (EntityCollection) null;
      if (info != null)
        entityCollection = info.getOwner().getEntityCollection();
      PlotOrientation orientation = plot.getOrientation();
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      double xvalue1 = dataset.getXValue(series, item);
      double yvalue1 = dataset.getYValue(series, item);
      if (Double.isNaN(xvalue1) || Double.isNaN(yvalue1))
        num1 = 0;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num2 = domainAxis.valueToJava2D(xvalue1, dataArea, domainAxisEdge);
      double num3 = rangeAxis.valueToJava2D(yvalue1, dataArea, rangeAxisEdge);
      if (this.getPlotLines())
      {
        if (this.drawSeriesLineAsPath)
        {
          StandardXYItemRenderer.State state1 = (StandardXYItemRenderer.State) state;
          if (state1.getSeriesIndex() != series)
          {
            ((Path2D) state1.seriesPath).reset();
            StandardXYItemRenderer.State.access\u0024102(state1, false);
            state1.setSeriesIndex(series);
          }
          if (num1 != 0 && !Double.isNaN(num2) && !Double.isNaN(num3))
          {
            float num4 = (float) num2;
            float num5 = (float) num3;
            if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            {
              num4 = (float) num3;
              num5 = (float) num2;
            }
            if (state1.isLastPointGood())
              ((Path2D.Float) state1.seriesPath).lineTo(num4, num5);
            else
              ((Path2D.Float) state1.seriesPath).moveTo(num4, num5);
            state1.setLastPointGood(true);
          }
          else
            state1.setLastPointGood(false);
          if (item == dataset.getItemCount(series) - 1 && StandardXYItemRenderer.State.access\u0024000(state1) == series)
          {
            g2.setStroke(this.lookupSeriesStroke(series));
            g2.setPaint(this.lookupSeriesPaint(series));
            g2.draw((Shape) state1.seriesPath);
          }
        }
        else if (item != 0 && num1 != 0)
        {
          double xvalue2 = dataset.getXValue(series, item - 1);
          double yvalue2 = dataset.getYValue(series, item - 1);
          if (!Double.isNaN(xvalue2) && !Double.isNaN(yvalue2))
          {
            int num4 = 1;
            if (this.getPlotDiscontinuous())
            {
              int itemCount = dataset.getItemCount(series);
              double xvalue3 = dataset.getXValue(series, 0);
              double xvalue4 = dataset.getXValue(series, itemCount - 1);
              num4 = this.gapThresholdType != UnitType.__\u003C\u003EABSOLUTE ? (Math.abs(xvalue1 - xvalue2) <= (xvalue4 - xvalue3) / (double) itemCount * this.getGapThreshold() ? 1 : 0) : (Math.abs(xvalue1 - xvalue2) <= this.gapThreshold ? 1 : 0);
            }
            if (num4 != 0)
            {
              double num5 = domainAxis.valueToJava2D(xvalue2, dataArea, domainAxisEdge);
              double num6 = rangeAxis.valueToJava2D(yvalue2, dataArea, rangeAxisEdge);
              if (Double.isNaN(num5) || Double.isNaN(num6) || (Double.isNaN(num2) || Double.isNaN(num3)))
                return;
              if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
                state.workingLine.setLine(num6, num5, num3, num2);
              else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
                state.workingLine.setLine(num5, num6, num2, num3);
              if (state.workingLine.intersects(dataArea))
                g2.draw((Shape) state.workingLine);
            }
          }
        }
      }
      if (num1 == 0)
        return;
      if (this.getBaseShapesVisible())
      {
        Shape shape = this.getItemShape(series, item);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num3, num2);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          shape = ShapeUtilities.createTranslatedShape(shape, num2, num3);
        if (shape.intersects(dataArea))
        {
          if (this.getItemShapeFilled(series, item))
            g2.fill(shape);
          else
            g2.draw(shape);
        }
        obj1 = (object) shape;
      }
      if (this.getPlotImages())
      {
        Image image = this.getImage((Plot) plot, series, item, num2, num3);
        if (image != null)
        {
          Point imageHotspot = this.getImageHotspot((Plot) plot, series, item, num2, num3, image);
          ((Graphics) g2).drawImage(image, ByteCodeHelper.d2i(num2 - imageHotspot.getX()), ByteCodeHelper.d2i(num3 - imageHotspot.getY()), (ImageObserver) null);
          obj1 = (object) new Rectangle2D.Double(num2 - imageHotspot.getX(), num3 - imageHotspot.getY(), (double) image.getWidth((ImageObserver) null), (double) image.getHeight((ImageObserver) null));
        }
      }
      double x = num2;
      double y = num3;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        x = num3;
        y = num2;
      }
      if (this.isItemLabelVisible(series, item))
        this.drawItemLabel(g2, orientation, dataset, series, item, x, y, yvalue1 < 0.0);
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, xvalue1, yvalue1, domainAxisIndex, rangeAxisIndex, num2, num3, orientation);
      if (entityCollection == null || !AbstractXYItemRenderer.isPointInRect(dataArea, x, y))
        return;
      EntityCollection entities = entityCollection;
      object obj2 = obj1;
      XYDataset xyDataset1 = dataset;
      int num7 = series;
      int num8 = item;
      double num9 = x;
      double num10 = y;
      double num11 = num9;
      int num12 = num8;
      int num13 = num7;
      XYDataset xyDataset2 = xyDataset1;
      Shape area;
      if (obj2 != null)
      {
        Shape shape = obj2 as Shape;
        if (shape == null)
          throw new IncompatibleClassChangeError();
        area = shape;
      }
      else
        area = (Shape) null;
      XYDataset dataset1 = xyDataset2;
      int series1 = num13;
      int num14 = num12;
      double entityX = num11;
      double entityY = num10;
      this.addEntity(entities, area, dataset1, series1, num14, entityX, entityY);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 132, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardXYItemRenderer))
        return false;
      StandardXYItemRenderer standardXyItemRenderer = (StandardXYItemRenderer) obj;
      if (this.baseShapesVisible != standardXyItemRenderer.baseShapesVisible || this.plotLines != standardXyItemRenderer.plotLines || (this.plotImages != standardXyItemRenderer.plotImages || this.plotDiscontinuous != standardXyItemRenderer.plotDiscontinuous) || (this.gapThresholdType != standardXyItemRenderer.gapThresholdType || this.gapThreshold != standardXyItemRenderer.gapThreshold || (!ObjectUtilities.equal((object) this.shapesFilled, (object) standardXyItemRenderer.shapesFilled) || !this.seriesShapesFilled.equals((object) standardXyItemRenderer.seriesShapesFilled))) || (this.baseShapesFilled != standardXyItemRenderer.baseShapesFilled || this.drawSeriesLineAsPath != standardXyItemRenderer.drawSeriesLineAsPath || !ShapeUtilities.equal(this.legendLine, standardXyItemRenderer.legendLine)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 184, (byte) 108, (byte) 150, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      StandardXYItemRenderer standardXyItemRenderer = (StandardXYItemRenderer) base.clone();
      standardXyItemRenderer.seriesShapesFilled = (BooleanList) this.seriesShapesFilled.clone();
      standardXyItemRenderer.legendLine = ShapeUtilities.clone(this.legendLine);
      return (object) standardXyItemRenderer;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 253, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendLine = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 9, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendLine, obj0);
    }

    [InnerClass]
    [SourceFile("StandardXYItemRenderer.java")]
    public class State : XYItemRendererState
    {
      public GeneralPath seriesPath;
      private int seriesIndex;
      private bool lastPointGood;

      [LineNumberTable(new byte[] {(byte) 162, (byte) 91, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public State(PlotRenderingInfo info)
        : base(info)
      {
      }

      [LineNumberTable((ushort) 697)]
      internal static int access\u0024002([In] StandardXYItemRenderer.State obj0, [In] int obj1)
      {
        StandardXYItemRenderer.State state1 = obj0;
        int num1 = obj1;
        StandardXYItemRenderer.State state2 = state1;
        int num2 = num1;
        state2.seriesIndex = num1;
        return num2;
      }

      public virtual int getSeriesIndex()
      {
        return this.seriesIndex;
      }

      [LineNumberTable((ushort) 697)]
      internal static bool access\u0024102([In] StandardXYItemRenderer.State obj0, [In] bool obj1)
      {
        int num1 = obj1 ? 1 : 0;
        StandardXYItemRenderer.State state1 = obj0;
        int num2 = num1;
        StandardXYItemRenderer.State state2 = state1;
        int num3 = num2;
        state2.lastPointGood = num2 != 0;
        return num3 != 0;
      }

      public virtual void setSeriesIndex(int index)
      {
        this.seriesIndex = index;
      }

      public virtual bool isLastPointGood()
      {
        return this.lastPointGood;
      }

      public virtual void setLastPointGood(bool good)
      {
        this.lastPointGood = good;
      }

      [LineNumberTable((ushort) 697)]
      internal static int access\u0024000([In] StandardXYItemRenderer.State obj0)
      {
        return obj0.seriesIndex;
      }
    }
  }
}
