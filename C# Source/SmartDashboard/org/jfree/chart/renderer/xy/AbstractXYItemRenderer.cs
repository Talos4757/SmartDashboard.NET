// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.AbstractXYItemRenderer
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
using org.jfree.chart.annotations;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class AbstractXYItemRenderer : AbstractRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 8019124836026607990L;
    private XYPlot plot;
    private ObjectList itemLabelGeneratorList;
    private XYItemLabelGenerator baseItemLabelGenerator;
    private ObjectList toolTipGeneratorList;
    private XYToolTipGenerator baseToolTipGenerator;
    private XYURLGenerator urlGenerator;
    private List backgroundAnnotations;
    private List foregroundAnnotations;
    private XYSeriesLabelGenerator legendItemLabelGenerator;
    private XYSeriesLabelGenerator legendItemToolTipGenerator;
    private XYSeriesLabelGenerator legendItemURLGenerator;
    [Obsolete]
    private XYItemLabelGenerator itemLabelGenerator;
    [Obsolete]
    private XYToolTipGenerator toolTipGenerator;

    [HideFromJava]
    static AbstractXYItemRenderer()
    {
      AbstractRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 104, (byte) 103, (byte) 107, (byte) 103, (byte) 107, (byte) 103, (byte) 107, (byte) 107, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractXYItemRenderer()
    {
      AbstractXYItemRenderer abstractXyItemRenderer = this;
      this.itemLabelGenerator = (XYItemLabelGenerator) null;
      this.itemLabelGeneratorList = new ObjectList();
      this.toolTipGenerator = (XYToolTipGenerator) null;
      this.toolTipGeneratorList = new ObjectList();
      this.urlGenerator = (XYURLGenerator) null;
      this.backgroundAnnotations = (List) new ArrayList();
      this.foregroundAnnotations = (List) new ArrayList();
      this.legendItemLabelGenerator = (XYSeriesLabelGenerator) new StandardXYSeriesLabelGenerator("{0}");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractXYItemRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractXYItemRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractXYItemRenderer obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 67, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseToolTipGenerator(XYToolTipGenerator generator)
    {
      this.baseToolTipGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 89, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setURLGenerator(XYURLGenerator urlGenerator)
    {
      this.urlGenerator = urlGenerator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 53, (byte) 103, (byte) 107, (byte) 161, (byte) 103, (byte) 98, (byte) 147, (byte) 104, (byte) 184, (byte) 104, (byte) 214, (byte) 104, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainLine(Graphics2D g2, XYPlot plot, ValueAxis axis, Rectangle2D dataArea, double value, Paint paint, Stroke stroke)
    {
      if (!axis.getRange().contains(value))
        return;
      PlotOrientation orientation = plot.getOrientation();
      Line2D.Double @double = (Line2D.Double) null;
      double num = axis.valueToJava2D(value, dataArea, plot.getDomainAxisEdge());
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      g2.setPaint(paint);
      g2.setStroke(stroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 166, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getAnnotations()
    {
      ArrayList arrayList = new ArrayList((Collection) this.foregroundAnnotations);
      ((List) arrayList).addAll((Collection) this.backgroundAnnotations);
      return (Collection) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 113, (byte) 99, (byte) 144, (byte) 109, (byte) 109, (byte) 136, (byte) 109, (byte) 109, (byte) 200, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(XYAnnotation annotation, Layer layer)
    {
      if (annotation == null)
      {
        string str = "Null 'annotation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (layer.equals((object) Layer.__\u003C\u003EFOREGROUND))
      {
        this.foregroundAnnotations.add((object) annotation);
        this.fireChangeEvent();
      }
      else if (layer.equals((object) Layer.__\u003C\u003EBACKGROUND))
      {
        this.backgroundAnnotations.add((object) annotation);
        this.fireChangeEvent();
      }
      else
      {
        string str = "Unknown layer.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 237, (byte) 98, (byte) 99, (byte) 130, (byte) 104, (byte) 102, (byte) 103, (byte) 102, (byte) 105, (byte) 14, (byte) 230, (byte) 69, (byte) 203})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Range findDomainBounds(XYDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
        return (Range) null;
      if (this.getDataBoundsIncludesVisibleSeriesOnly())
      {
        ArrayList arrayList = new ArrayList();
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          if (this.isSeriesVisible(index))
            ((List) arrayList).add((object) dataset.getSeriesKey(index));
        }
        return DatasetUtilities.findDomainBounds(dataset, (List) arrayList, num != 0);
      }
      else
        return DatasetUtilities.findDomainBounds(dataset, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 225, (byte) 66, (byte) 99, (byte) 130, (byte) 107, (byte) 102, (byte) 103, (byte) 102, (byte) 105, (byte) 14, (byte) 230, (byte) 71, (byte) 99, (byte) 104, (byte) 100, (byte) 99, (byte) 106, (byte) 101, (byte) 143, (byte) 100, (byte) 169, (byte) 100, (byte) 185, (byte) 205})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Range findRangeBounds(XYDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
        return (Range) null;
      if (this.getDataBoundsIncludesVisibleSeriesOnly())
      {
        ArrayList arrayList = new ArrayList();
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          if (this.isSeriesVisible(index))
            ((List) arrayList).add((object) dataset.getSeriesKey(index));
        }
        Range xRange = (Range) null;
        XYPlot plot = this.getPlot();
        if (plot != null)
        {
          ValueAxis valueAxis = (ValueAxis) null;
          int indexOf = plot.getIndexOf((XYItemRenderer) this);
          if (indexOf >= 0)
            valueAxis = this.plot.getDomainAxisForDataset(indexOf);
          if (valueAxis != null)
            xRange = valueAxis.getRange();
        }
        if (xRange == null)
          xRange = new Range(double.NegativeInfinity, double.PositiveInfinity);
        return DatasetUtilities.findRangeBounds(dataset, (List) arrayList, xRange, num != 0);
      }
      else
        return DatasetUtilities.findRangeBounds(dataset, num != 0);
    }

    public virtual XYPlot getPlot()
    {
      return this.plot;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 141, (byte) 98, (byte) 103, (byte) 102, (byte) 104, (byte) 102, (byte) 142, (byte) 99, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 149, (byte) 105, (byte) 109, (byte) 100, (byte) 136, (byte) 109, (byte) 103, (byte) 103, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendItem getLegendItem(int datasetIndex, int series)
    {
      LegendItem legendItem = (LegendItem) null;
      XYPlot plot = this.getPlot();
      if (plot != null)
      {
        XYDataset dataset = plot.getDataset(datasetIndex);
        if (dataset != null)
        {
          string label = this.legendItemLabelGenerator.generateLabel(dataset, series);
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
          legendItem = new LegendItem(label, description, toolTipText, urlText, shape, fillPaint, outlineStroke, outlinePaint);
          Paint paint = this.lookupLegendTextPaint(series);
          legendItem.setLabelFont(this.lookupLegendTextFont(series));
          if (paint != null)
            legendItem.setLabelPaint(paint);
          legendItem.setSeriesKey(dataset.getSeriesKey(series));
          legendItem.setSeriesIndex(series);
          legendItem.setDataset((Dataset) dataset);
          legendItem.setDatasetIndex(datasetIndex);
        }
      }
      return legendItem;
    }

    public virtual XYSeriesLabelGenerator getLegendItemToolTipGenerator()
    {
      return this.legendItemToolTipGenerator;
    }

    public virtual XYSeriesLabelGenerator getLegendItemURLGenerator()
    {
      return this.legendItemURLGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 51, (byte) 98, (byte) 104, (byte) 179, (byte) 104, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Point2D calculateDomainMarkerTextAnchorPoint(Graphics2D g2, PlotOrientation orientation, Rectangle2D dataArea, Rectangle2D markerArea, RectangleInsets markerOffset, LengthAdjustmentType labelOffsetType, RectangleAnchor anchor)
    {
      Rectangle2D rectangle = (Rectangle2D) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        rectangle = markerOffset.createAdjustedRectangle(markerArea, LengthAdjustmentType.__\u003C\u003ECONTRACT, labelOffsetType);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        rectangle = markerOffset.createAdjustedRectangle(markerArea, labelOffsetType, LengthAdjustmentType.__\u003C\u003ECONTRACT);
      return RectangleAnchor.coordinates(rectangle, anchor);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 248, (byte) 98, (byte) 104, (byte) 179, (byte) 104, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Point2D calculateRangeMarkerTextAnchorPoint([In] Graphics2D obj0, [In] PlotOrientation obj1, [In] Rectangle2D obj2, [In] Rectangle2D obj3, [In] RectangleInsets obj4, [In] LengthAdjustmentType obj5, [In] RectangleAnchor obj6)
    {
      Rectangle2D rectangle = (Rectangle2D) null;
      if (obj1 == PlotOrientation.__\u003C\u003EHORIZONTAL)
        rectangle = obj4.createAdjustedRectangle(obj3, obj5, LengthAdjustmentType.__\u003C\u003ECONTRACT);
      else if (obj1 == PlotOrientation.__\u003C\u003EVERTICAL)
        rectangle = obj4.createAdjustedRectangle(obj3, LengthAdjustmentType.__\u003C\u003ECONTRACT, obj5);
      return RectangleAnchor.coordinates(rectangle, obj6);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 195, (byte) 104, (byte) 199, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYItemLabelGenerator getItemLabelGenerator(int series, int item)
    {
      if (this.itemLabelGenerator != null)
        return this.itemLabelGenerator;
      else
        return (XYItemLabelGenerator) this.itemLabelGeneratorList.get(series) ?? this.baseItemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 104, (byte) 199, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYToolTipGenerator getToolTipGenerator(int series, int item)
    {
      if (this.toolTipGenerator != null)
        return this.toolTipGenerator;
      else
        return (XYToolTipGenerator) this.toolTipGeneratorList.get(series) ?? this.baseToolTipGenerator;
    }

    public virtual XYURLGenerator getURLGenerator()
    {
      return this.urlGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 174, (byte) 100, (byte) 176, (byte) 131, (byte) 109, (byte) 141, (byte) 248, (byte) 69, (byte) 204, (byte) 141, (byte) 236, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateCrosshairValues(CrosshairState crosshairState, double x, double y, int domainAxisIndex, int rangeAxisIndex, double transX, double transY, PlotOrientation orientation)
    {
      if (orientation == null)
      {
        string str = "Null 'orientation' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (crosshairState == null)
          return;
        if (this.plot.isDomainCrosshairLockedOnData())
        {
          if (this.plot.isRangeCrosshairLockedOnData())
            crosshairState.updateCrosshairPoint(x, y, domainAxisIndex, rangeAxisIndex, transX, transY, orientation);
          else
            crosshairState.updateCrosshairX(x, domainAxisIndex);
        }
        else
        {
          if (!this.plot.isRangeCrosshairLockedOnData())
            return;
          crosshairState.updateCrosshairY(y, rangeAxisIndex);
        }
      }
    }

    public virtual int getPassCount()
    {
      return 1;
    }

    public virtual void setPlot(XYPlot plot)
    {
      this.plot = plot;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      return new XYItemRendererState(info);
    }

    [LineNumberTable((ushort) 330)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYItemLabelGenerator getSeriesItemLabelGenerator(int series)
    {
      return (XYItemLabelGenerator) this.itemLabelGeneratorList.get(series);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelGenerator(int series, XYItemLabelGenerator generator)
    {
      this.itemLabelGeneratorList.set(series, (object) generator);
      this.fireChangeEvent();
    }

    public virtual XYItemLabelGenerator getBaseItemLabelGenerator()
    {
      return this.baseItemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelGenerator(XYItemLabelGenerator generator)
    {
      this.baseItemLabelGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 401)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYToolTipGenerator getSeriesToolTipGenerator(int series)
    {
      return (XYToolTipGenerator) this.toolTipGeneratorList.get(series);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesToolTipGenerator(int series, XYToolTipGenerator generator)
    {
      this.toolTipGeneratorList.set(series, (object) generator);
      this.fireChangeEvent();
    }

    public virtual XYToolTipGenerator getBaseToolTipGenerator()
    {
      return this.baseToolTipGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addAnnotation(XYAnnotation annotation)
    {
      this.addAnnotation(annotation, Layer.__\u003C\u003EFOREGROUND);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 140, (byte) 109, (byte) 111, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeAnnotation(XYAnnotation annotation)
    {
      int num = this.foregroundAnnotations.remove((object) annotation) & this.backgroundAnnotations.remove((object) annotation) ? 1 : 0;
      this.fireChangeEvent();
      return num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 107, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAnnotations()
    {
      this.foregroundAnnotations.clear();
      this.backgroundAnnotations.clear();
      this.fireChangeEvent();
    }

    public virtual XYSeriesLabelGenerator getLegendItemLabelGenerator()
    {
      return this.legendItemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 191, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemLabelGenerator(XYSeriesLabelGenerator generator)
    {
      if (generator == null)
      {
        string str = "Null 'generator' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendItemLabelGenerator = generator;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 219, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemToolTipGenerator(XYSeriesLabelGenerator generator)
    {
      this.legendItemToolTipGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 243, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemURLGenerator(XYSeriesLabelGenerator generator)
    {
      this.legendItemURLGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 629)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range findDomainBounds(XYDataset dataset)
    {
      return this.findDomainBounds(dataset, false);
    }

    [LineNumberTable((ushort) 676)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range findRangeBounds(XYDataset dataset)
    {
      return this.findRangeBounds(dataset, false);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 110, (byte) 104, (byte) 136, (byte) 102, (byte) 109, (byte) 109, (byte) 99, (byte) 103, (byte) 104, (byte) 106, (byte) 107, (byte) 100, (byte) 232, (byte) 60, (byte) 232, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendItemCollection getLegendItems()
    {
      if (this.plot == null)
      {
        return new LegendItemCollection();
      }
      else
      {
        LegendItemCollection legendItemCollection = new LegendItemCollection();
        int indexOf = this.plot.getIndexOf((XYItemRenderer) this);
        XYDataset dataset = this.plot.getDataset(indexOf);
        if (dataset != null)
        {
          int seriesCount = dataset.getSeriesCount();
          for (int series = 0; series < seriesCount; ++series)
          {
            if (this.isSeriesVisibleInLegend(series))
            {
              LegendItem legendItem = this.getLegendItem(indexOf, series);
              if (legendItem != null)
                legendItemCollection.add(legendItem);
            }
          }
        }
        return legendItemCollection;
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 193, (byte) 147, (byte) 179, (byte) 109, (byte) 223, (byte) 6, (byte) 191, (byte) 4, (byte) 135, (byte) 99, (byte) 103, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fillDomainGridBand(Graphics2D g2, XYPlot plot, ValueAxis axis, Rectangle2D dataArea, double start, double end)
    {
      double num1 = axis.valueToJava2D(start, dataArea, plot.getDomainAxisEdge());
      double num2 = axis.valueToJava2D(end, dataArea, plot.getDomainAxisEdge());
      Rectangle2D.Double @double = plot.getOrientation() != PlotOrientation.__\u003C\u003EVERTICAL ? new Rectangle2D.Double(((RectangularShape) dataArea).getMinX(), Math.min(num1, num2), ((RectangularShape) dataArea).getWidth(), Math.abs(num2 - num1)) : new Rectangle2D.Double(Math.min(num1, num2), ((RectangularShape) dataArea).getMinY(), Math.abs(num2 - num1), ((RectangularShape) dataArea).getWidth());
      Paint domainTickBandPaint = plot.getDomainTickBandPaint();
      if (domainTickBandPaint == null)
        return;
      g2.setPaint(domainTickBandPaint);
      g2.fill((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 229, (byte) 147, (byte) 147, (byte) 109, (byte) 223, (byte) 6, (byte) 191, (byte) 4, (byte) 135, (byte) 99, (byte) 103, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fillRangeGridBand(Graphics2D g2, XYPlot plot, ValueAxis axis, Rectangle2D dataArea, double start, double end)
    {
      double num1 = axis.valueToJava2D(start, dataArea, plot.getRangeAxisEdge());
      double num2 = axis.valueToJava2D(end, dataArea, plot.getRangeAxisEdge());
      Rectangle2D.Double @double = plot.getOrientation() != PlotOrientation.__\u003C\u003EVERTICAL ? new Rectangle2D.Double(Math.min(num1, num2), ((RectangularShape) dataArea).getMinY(), Math.abs(num2 - num1), ((RectangularShape) dataArea).getHeight()) : new Rectangle2D.Double(((RectangularShape) dataArea).getMinX(), Math.min(num1, num2), ((RectangularShape) dataArea).getWidth(), Math.abs(num2 - num1));
      Paint rangeTickBandPaint = plot.getRangeTickBandPaint();
      if (rangeTickBandPaint == null)
        return;
      g2.setPaint(rangeTickBandPaint);
      g2.fill((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 10, (byte) 103, (byte) 107, (byte) 161, (byte) 103, (byte) 147, (byte) 98, (byte) 104, (byte) 184, (byte) 104, (byte) 214, (byte) 104, (byte) 104, (byte) 115, (byte) 115, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainGridLine(Graphics2D g2, XYPlot plot, ValueAxis axis, Rectangle2D dataArea, double value)
    {
      if (!axis.getRange().contains(value))
        return;
      PlotOrientation orientation = plot.getOrientation();
      double num = axis.valueToJava2D(value, dataArea, plot.getDomainAxisEdge());
      Line2D.Double @double = (Line2D.Double) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      Paint domainGridlinePaint = plot.getDomainGridlinePaint();
      Stroke domainGridlineStroke = plot.getDomainGridlineStroke();
      g2.setPaint(domainGridlinePaint == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT : domainGridlinePaint);
      g2.setStroke(domainGridlineStroke == null ? Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE : domainGridlineStroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 97, (byte) 103, (byte) 107, (byte) 161, (byte) 103, (byte) 98, (byte) 115, (byte) 104, (byte) 184, (byte) 104, (byte) 214, (byte) 104, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeLine(Graphics2D g2, XYPlot plot, ValueAxis axis, Rectangle2D dataArea, double value, Paint paint, Stroke stroke)
    {
      if (!axis.getRange().contains(value))
        return;
      PlotOrientation orientation = plot.getOrientation();
      Line2D.Double @double = (Line2D.Double) null;
      double num = axis.valueToJava2D(value, dataArea, plot.getRangeAxisEdge());
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      g2.setPaint(paint);
      g2.setStroke(stroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 135, (byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 161, (byte) 177, (byte) 104, (byte) 99, (byte) 105, (byte) 185, (byte) 105, (byte) 215, (byte) 104, (byte) 147, (byte) 109, (byte) 109, (byte) 136, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 3, (byte) 223, (byte) 1, (byte) 104, (byte) 101, (byte) 108, (byte) 105, (byte) 105, (byte) 106, (byte) 104, (byte) 108, (byte) 161, (byte) 146, (byte) 147, (byte) 108, (byte) 140, (byte) 104, (byte) 99, (byte) 137, (byte) 113, (byte) 113, (byte) 222, (byte) 137, (byte) 113, (byte) 113, (byte) 252, (byte) 69, (byte) 104, (byte) 147, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 100, (byte) 141, (byte) 104, (byte) 130, (byte) 136, (byte) 168, (byte) 120, (byte) 108, (byte) 103, (byte) 106, (byte) 106, (byte) 109, (byte) 109, (byte) 106, (byte) 111, (byte) 136, (byte) 107, (byte) 111, (byte) 136, (byte) 133, (byte) 103, (byte) 106, (byte) 106, (byte) 109, (byte) 109, (byte) 106, (byte) 111, (byte) 136, (byte) 107, (byte) 111, (byte) 232, (byte) 69, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 0, (byte) 223, (byte) 1, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainMarker(Graphics2D g2, XYPlot plot, ValueAxis domainAxis, Marker marker, Rectangle2D dataArea)
    {
      if (marker is ValueMarker)
      {
        double d = ((ValueMarker) marker).getValue();
        if (!domainAxis.getRange().contains(d))
          return;
        double num = domainAxis.valueToJava2D(d, dataArea, plot.getDomainAxisEdge());
        PlotOrientation orientation = plot.getOrientation();
        Line2D.Double @double = (Line2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
        g2.setPaint(marker.getPaint());
        g2.setStroke(marker.getStroke());
        g2.draw((Shape) @double);
        string label = marker.getLabel();
        RectangleAnchor labelAnchor = marker.getLabelAnchor();
        if (label != null)
        {
          Font labelFont = marker.getLabelFont();
          ((Graphics) g2).setFont(labelFont);
          g2.setPaint(marker.getLabelPaint());
          Point2D point2D = this.calculateDomainMarkerTextAnchorPoint(g2, orientation, dataArea, ((Line2D) @double).getBounds2D(), marker.getLabelOffset(), LengthAdjustmentType.__\u003C\u003EEXPAND, labelAnchor);
          TextUtilities.drawAlignedString(label, g2, (float) point2D.getX(), (float) point2D.getY(), marker.getLabelTextAnchor());
        }
        g2.setComposite(composite);
      }
      else
      {
        if (!(marker is IntervalMarker))
          return;
        IntervalMarker intervalMarker = (IntervalMarker) marker;
        double startValue = intervalMarker.getStartValue();
        double endValue = intervalMarker.getEndValue();
        Range range = domainAxis.getRange();
        if (!range.intersects(startValue, endValue))
          return;
        double num1 = domainAxis.valueToJava2D(startValue, dataArea, plot.getDomainAxisEdge());
        double num2 = domainAxis.valueToJava2D(endValue, dataArea, plot.getDomainAxisEdge());
        double num3 = Math.min(num1, num2);
        double num4 = Math.max(num1, num2);
        PlotOrientation orientation = plot.getOrientation();
        Rectangle2D.Double double1 = (Rectangle2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double num5 = Math.max(num3, ((RectangularShape) dataArea).getMinY());
          double num6 = Math.min(num4, ((RectangularShape) dataArea).getMaxY());
          double1 = new Rectangle2D.Double(((RectangularShape) dataArea).getMinX(), num5, ((RectangularShape) dataArea).getWidth(), num6 - num5);
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          double num5 = Math.max(num3, ((RectangularShape) dataArea).getMinX());
          double num6 = Math.min(num4, ((RectangularShape) dataArea).getMaxX());
          double1 = new Rectangle2D.Double(num5, ((RectangularShape) dataArea).getMinY(), num6 - num5, ((RectangularShape) dataArea).getHeight());
        }
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
        Paint paint = marker.getPaint();
        if (paint is GradientPaint)
        {
          GradientPaint gp = (GradientPaint) paint;
          GradientPaintTransformer paintTransformer = intervalMarker.getGradientPaintTransformer();
          if (paintTransformer != null)
            gp = paintTransformer.transform(gp, (Shape) double1);
          g2.setPaint((Paint) gp);
        }
        else
          g2.setPaint(paint);
        g2.fill((Shape) double1);
        if (intervalMarker.getOutlinePaint() != null && intervalMarker.getOutlineStroke() != null)
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            Line2D.Double double2 = new Line2D.Double();
            double minY = ((RectangularShape) dataArea).getMinY();
            double maxY = ((RectangularShape) dataArea).getMaxY();
            g2.setPaint(intervalMarker.getOutlinePaint());
            g2.setStroke(intervalMarker.getOutlineStroke());
            if (range.contains(startValue))
            {
              ((Line2D) double2).setLine(num1, minY, num1, maxY);
              g2.draw((Shape) double2);
            }
            if (range.contains(endValue))
            {
              ((Line2D) double2).setLine(num2, minY, num2, maxY);
              g2.draw((Shape) double2);
            }
          }
          else
          {
            Line2D.Double double2 = new Line2D.Double();
            double minX = ((RectangularShape) dataArea).getMinX();
            double maxX = ((RectangularShape) dataArea).getMaxX();
            g2.setPaint(intervalMarker.getOutlinePaint());
            g2.setStroke(intervalMarker.getOutlineStroke());
            if (range.contains(startValue))
            {
              ((Line2D) double2).setLine(minX, num1, maxX, num1);
              g2.draw((Shape) double2);
            }
            if (range.contains(endValue))
            {
              ((Line2D) double2).setLine(minX, num2, maxX, num2);
              g2.draw((Shape) double2);
            }
          }
        }
        string label = marker.getLabel();
        RectangleAnchor labelAnchor = marker.getLabelAnchor();
        if (label != null)
        {
          Font labelFont = marker.getLabelFont();
          ((Graphics) g2).setFont(labelFont);
          g2.setPaint(marker.getLabelPaint());
          Point2D point2D = this.calculateDomainMarkerTextAnchorPoint(g2, orientation, dataArea, (Rectangle2D) double1, marker.getLabelOffset(), marker.getLabelOffsetType(), labelAnchor);
          TextUtilities.drawAlignedString(label, g2, (float) point2D.getX(), (float) point2D.getY(), marker.getLabelTextAnchor());
        }
        g2.setComposite(composite);
      }
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 79, (byte) 108, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 161, (byte) 145, (byte) 104, (byte) 99, (byte) 105, (byte) 185, (byte) 105, (byte) 215, (byte) 104, (byte) 147, (byte) 109, (byte) 109, (byte) 136, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 3, (byte) 223, (byte) 1, (byte) 104, (byte) 101, (byte) 108, (byte) 105, (byte) 105, (byte) 106, (byte) 104, (byte) 108, (byte) 161, (byte) 146, (byte) 147, (byte) 108, (byte) 140, (byte) 104, (byte) 99, (byte) 137, (byte) 113, (byte) 113, (byte) 222, (byte) 137, (byte) 113, (byte) 113, (byte) 252, (byte) 69, (byte) 104, (byte) 147, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 100, (byte) 141, (byte) 104, (byte) 130, (byte) 136, (byte) 168, (byte) 120, (byte) 108, (byte) 103, (byte) 106, (byte) 106, (byte) 109, (byte) 109, (byte) 106, (byte) 111, (byte) 136, (byte) 107, (byte) 111, (byte) 136, (byte) 133, (byte) 103, (byte) 106, (byte) 106, (byte) 109, (byte) 109, (byte) 106, (byte) 111, (byte) 136, (byte) 107, (byte) 111, (byte) 232, (byte) 69, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 0, (byte) 223, (byte) 1, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeMarker(Graphics2D g2, XYPlot plot, ValueAxis rangeAxis, Marker marker, Rectangle2D dataArea)
    {
      if (marker is ValueMarker)
      {
        double d = ((ValueMarker) marker).getValue();
        if (!rangeAxis.getRange().contains(d))
          return;
        double num = rangeAxis.valueToJava2D(d, dataArea, plot.getRangeAxisEdge());
        PlotOrientation orientation = plot.getOrientation();
        Line2D.Double @double = (Line2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
        g2.setPaint(marker.getPaint());
        g2.setStroke(marker.getStroke());
        g2.draw((Shape) @double);
        string label = marker.getLabel();
        RectangleAnchor labelAnchor = marker.getLabelAnchor();
        if (label != null)
        {
          Font labelFont = marker.getLabelFont();
          ((Graphics) g2).setFont(labelFont);
          g2.setPaint(marker.getLabelPaint());
          Point2D point2D = this.calculateRangeMarkerTextAnchorPoint(g2, orientation, dataArea, ((Line2D) @double).getBounds2D(), marker.getLabelOffset(), LengthAdjustmentType.__\u003C\u003EEXPAND, labelAnchor);
          TextUtilities.drawAlignedString(label, g2, (float) point2D.getX(), (float) point2D.getY(), marker.getLabelTextAnchor());
        }
        g2.setComposite(composite);
      }
      else
      {
        if (!(marker is IntervalMarker))
          return;
        IntervalMarker intervalMarker = (IntervalMarker) marker;
        double startValue = intervalMarker.getStartValue();
        double endValue = intervalMarker.getEndValue();
        Range range = rangeAxis.getRange();
        if (!range.intersects(startValue, endValue))
          return;
        double num1 = rangeAxis.valueToJava2D(startValue, dataArea, plot.getRangeAxisEdge());
        double num2 = rangeAxis.valueToJava2D(endValue, dataArea, plot.getRangeAxisEdge());
        double num3 = Math.min(num1, num2);
        double num4 = Math.max(num1, num2);
        PlotOrientation orientation = plot.getOrientation();
        Rectangle2D.Double double1 = (Rectangle2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double num5 = Math.max(num3, ((RectangularShape) dataArea).getMinX());
          double num6 = Math.min(num4, ((RectangularShape) dataArea).getMaxX());
          double1 = new Rectangle2D.Double(num5, ((RectangularShape) dataArea).getMinY(), num6 - num5, ((RectangularShape) dataArea).getHeight());
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          double num5 = Math.max(num3, ((RectangularShape) dataArea).getMinY());
          double num6 = Math.min(num4, ((RectangularShape) dataArea).getMaxY());
          double1 = new Rectangle2D.Double(((RectangularShape) dataArea).getMinX(), num5, ((RectangularShape) dataArea).getWidth(), num6 - num5);
        }
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
        Paint paint = marker.getPaint();
        if (paint is GradientPaint)
        {
          GradientPaint gp = (GradientPaint) paint;
          GradientPaintTransformer paintTransformer = intervalMarker.getGradientPaintTransformer();
          if (paintTransformer != null)
            gp = paintTransformer.transform(gp, (Shape) double1);
          g2.setPaint((Paint) gp);
        }
        else
          g2.setPaint(paint);
        g2.fill((Shape) double1);
        if (intervalMarker.getOutlinePaint() != null && intervalMarker.getOutlineStroke() != null)
        {
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            Line2D.Double double2 = new Line2D.Double();
            double minX = ((RectangularShape) dataArea).getMinX();
            double maxX = ((RectangularShape) dataArea).getMaxX();
            g2.setPaint(intervalMarker.getOutlinePaint());
            g2.setStroke(intervalMarker.getOutlineStroke());
            if (range.contains(startValue))
            {
              ((Line2D) double2).setLine(minX, num1, maxX, num1);
              g2.draw((Shape) double2);
            }
            if (range.contains(endValue))
            {
              ((Line2D) double2).setLine(minX, num2, maxX, num2);
              g2.draw((Shape) double2);
            }
          }
          else
          {
            Line2D.Double double2 = new Line2D.Double();
            double minY = ((RectangularShape) dataArea).getMinY();
            double maxY = ((RectangularShape) dataArea).getMaxY();
            g2.setPaint(intervalMarker.getOutlinePaint());
            g2.setStroke(intervalMarker.getOutlineStroke());
            if (range.contains(startValue))
            {
              ((Line2D) double2).setLine(num1, minY, num1, maxY);
              g2.draw((Shape) double2);
            }
            if (range.contains(endValue))
            {
              ((Line2D) double2).setLine(num2, minY, num2, maxY);
              g2.draw((Shape) double2);
            }
          }
        }
        string label = marker.getLabel();
        RectangleAnchor labelAnchor = marker.getLabelAnchor();
        if (label != null)
        {
          Font labelFont = marker.getLabelFont();
          ((Graphics) g2).setFont(labelFont);
          g2.setPaint(marker.getLabelPaint());
          Point2D point2D = this.calculateRangeMarkerTextAnchorPoint(g2, orientation, dataArea, (Rectangle2D) double1, marker.getLabelOffset(), marker.getLabelOffsetType(), labelAnchor);
          TextUtilities.drawAlignedString(label, g2, (float) point2D.getX(), (float) point2D.getY(), marker.getLabelTextAnchor());
        }
        g2.setComposite(composite);
      }
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 14, (byte) 172, (byte) 149, (byte) 108, (byte) 145, (byte) 150, (byte) 149, (byte) 108, (byte) 177, (byte) 149, (byte) 108, (byte) 145, (byte) 150, (byte) 149, (byte) 108, (byte) 177, (byte) 109, (byte) 182, (byte) 109, (byte) 182, (byte) 109, (byte) 214, (byte) 150, (byte) 182, (byte) 109, (byte) 182, (byte) 109, (byte) 182, (byte) 109, (byte) 214})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object clone()
    {
      AbstractXYItemRenderer abstractXyItemRenderer = (AbstractXYItemRenderer) base.clone();
      if (this.itemLabelGenerator != null && this.itemLabelGenerator is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.itemLabelGenerator;
        abstractXyItemRenderer.itemLabelGenerator = (XYItemLabelGenerator) publicCloneable.clone();
      }
      abstractXyItemRenderer.itemLabelGeneratorList = (ObjectList) this.itemLabelGeneratorList.clone();
      if (this.baseItemLabelGenerator != null && this.baseItemLabelGenerator is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.baseItemLabelGenerator;
        abstractXyItemRenderer.baseItemLabelGenerator = (XYItemLabelGenerator) publicCloneable.clone();
      }
      if (this.toolTipGenerator != null && this.toolTipGenerator is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.toolTipGenerator;
        abstractXyItemRenderer.toolTipGenerator = (XYToolTipGenerator) publicCloneable.clone();
      }
      abstractXyItemRenderer.toolTipGeneratorList = (ObjectList) this.toolTipGeneratorList.clone();
      if (this.baseToolTipGenerator != null && this.baseToolTipGenerator is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.baseToolTipGenerator;
        abstractXyItemRenderer.baseToolTipGenerator = (XYToolTipGenerator) publicCloneable.clone();
      }
      if (abstractXyItemRenderer.legendItemLabelGenerator is PublicCloneable)
        abstractXyItemRenderer.legendItemLabelGenerator = (XYSeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemLabelGenerator);
      if (abstractXyItemRenderer.legendItemToolTipGenerator is PublicCloneable)
        abstractXyItemRenderer.legendItemToolTipGenerator = (XYSeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemToolTipGenerator);
      if (abstractXyItemRenderer.legendItemURLGenerator is PublicCloneable)
        abstractXyItemRenderer.legendItemURLGenerator = (XYSeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemURLGenerator);
      abstractXyItemRenderer.foregroundAnnotations = (List) ObjectUtilities.deepClone((Collection) this.foregroundAnnotations);
      abstractXyItemRenderer.backgroundAnnotations = (List) ObjectUtilities.deepClone((Collection) this.backgroundAnnotations);
      if (abstractXyItemRenderer.legendItemLabelGenerator is PublicCloneable)
        abstractXyItemRenderer.legendItemLabelGenerator = (XYSeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemLabelGenerator);
      if (abstractXyItemRenderer.legendItemToolTipGenerator is PublicCloneable)
        abstractXyItemRenderer.legendItemToolTipGenerator = (XYSeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemToolTipGenerator);
      if (abstractXyItemRenderer.legendItemURLGenerator is PublicCloneable)
        abstractXyItemRenderer.legendItemURLGenerator = (XYSeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemURLGenerator);
      return (object) abstractXyItemRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 85, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractXYItemRenderer))
        return false;
      AbstractXYItemRenderer abstractXyItemRenderer = (AbstractXYItemRenderer) obj;
      if (!ObjectUtilities.equal((object) this.itemLabelGenerator, (object) abstractXyItemRenderer.itemLabelGenerator) || !this.itemLabelGeneratorList.equals((object) abstractXyItemRenderer.itemLabelGeneratorList) || (!ObjectUtilities.equal((object) this.baseItemLabelGenerator, (object) abstractXyItemRenderer.baseItemLabelGenerator) || !ObjectUtilities.equal((object) this.toolTipGenerator, (object) abstractXyItemRenderer.toolTipGenerator)) || (!this.toolTipGeneratorList.equals((object) abstractXyItemRenderer.toolTipGeneratorList) || !ObjectUtilities.equal((object) this.baseToolTipGenerator, (object) abstractXyItemRenderer.baseToolTipGenerator) || (!ObjectUtilities.equal((object) this.urlGenerator, (object) abstractXyItemRenderer.urlGenerator) || !Object.instancehelper_equals((object) this.foregroundAnnotations, (object) abstractXyItemRenderer.foregroundAnnotations))) || (!Object.instancehelper_equals((object) this.backgroundAnnotations, (object) abstractXyItemRenderer.backgroundAnnotations) || !ObjectUtilities.equal((object) this.legendItemLabelGenerator, (object) abstractXyItemRenderer.legendItemLabelGenerator) || (!ObjectUtilities.equal((object) this.legendItemToolTipGenerator, (object) abstractXyItemRenderer.legendItemToolTipGenerator) || !ObjectUtilities.equal((object) this.legendItemURLGenerator, (object) abstractXyItemRenderer.legendItemURLGenerator))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 144, (byte) 98, (byte) 103, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DrawingSupplier getDrawingSupplier()
    {
      DrawingSupplier drawingSupplier = (DrawingSupplier) null;
      XYPlot plot = this.getPlot();
      if (plot != null)
        drawingSupplier = plot.getDrawingSupplier();
      return drawingSupplier;
    }

    [LineNumberTable(new byte[] {(byte) 157, (byte) 251, (byte) 67, (byte) 107, (byte) 102, (byte) 107, (byte) 107, (byte) 103, (byte) 103, (byte) 173, (byte) 98, (byte) 99, (byte) 174, (byte) 204, (byte) 150, (byte) 255, (byte) 16, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItemLabel(Graphics2D g2, PlotOrientation orientation, XYDataset dataset, int series, int item, double x, double y, bool negative)
    {
      int num = negative ? 1 : 0;
      XYItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(series, item);
      if (itemLabelGenerator == null)
        return;
      Font itemLabelFont = this.getItemLabelFont(series, item);
      Paint itemLabelPaint = this.getItemLabelPaint(series, item);
      ((Graphics) g2).setFont(itemLabelFont);
      g2.setPaint(itemLabelPaint);
      string text = itemLabelGenerator.generateLabel(dataset, series, item);
      ItemLabelPosition itemLabelPosition = num != 0 ? this.getNegativeItemLabelPosition(series, item) : this.getPositiveItemLabelPosition(series, item);
      Point2D point2D = this.calculateLabelAnchorPoint(itemLabelPosition.getItemLabelAnchor(), x, y, orientation);
      TextUtilities.drawRotatedString(text, g2, (float) point2D.getX(), (float) point2D.getY(), itemLabelPosition.getTextAnchor(), itemLabelPosition.getAngle(), itemLabelPosition.getRotationAnchor());
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 7, (byte) 98, (byte) 110, (byte) 142, (byte) 110, (byte) 206, (byte) 144, (byte) 104, (byte) 108, (byte) 148, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawAnnotations(Graphics2D g2, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, Layer layer, PlotRenderingInfo info)
    {
      Iterator iterator;
      if (layer.equals((object) Layer.__\u003C\u003EFOREGROUND))
        iterator = this.foregroundAnnotations.iterator();
      else if (layer.equals((object) Layer.__\u003C\u003EBACKGROUND))
      {
        iterator = this.backgroundAnnotations.iterator();
      }
      else
      {
        string str = "Unknown layer.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      while (iterator.hasNext())
        ((XYAnnotation) iterator.next()).draw(g2, this.plot, dataArea, domainAxis, rangeAxis, 0, info);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 43, (byte) 108, (byte) 129, (byte) 98, (byte) 104, (byte) 104, (byte) 109, (byte) 114, (byte) 180, (byte) 178, (byte) 98, (byte) 108, (byte) 100, (byte) 141, (byte) 99, (byte) 104, (byte) 146, (byte) 159, (byte) 24, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void addEntity(EntityCollection entities, Shape area, XYDataset dataset, int series, int item, double entityX, double entityY)
    {
      if (!this.getItemCreateEntity(series, item))
        return;
      object obj1 = (object) area;
      if ((Shape) obj1 == null)
      {
        double num1 = (double) this.getDefaultEntityRadius();
        double num2 = num1 * 2.0;
        obj1 = this.getPlot().getOrientation() != PlotOrientation.__\u003C\u003EVERTICAL ? (object) new Ellipse2D.Double(entityY - num1, entityX - num1, num2, num2) : (object) new Ellipse2D.Double(entityX - num1, entityY - num1, num2, num2);
      }
      string str1 = (string) null;
      XYToolTipGenerator toolTipGenerator = this.getToolTipGenerator(series, item);
      if (toolTipGenerator != null)
        str1 = toolTipGenerator.generateToolTip(dataset, series, item);
      string str2 = (string) null;
      if (this.getURLGenerator() != null)
        str2 = this.getURLGenerator().generateURL(dataset, series, item);
      object obj2 = obj1;
      XYDataset xyDataset1 = dataset;
      int num3 = series;
      int num4 = item;
      string str3 = str1;
      string str4 = str2;
      string str5 = str3;
      int num5 = num4;
      int num6 = num3;
      XYDataset xyDataset2 = xyDataset1;
      Shape area1;
      if (obj2 != null)
      {
        Shape shape = obj2 as Shape;
        if (shape == null)
          throw new IncompatibleClassChangeError();
        area1 = shape;
      }
      else
        area1 = (Shape) null;
      XYDataset dataset1 = xyDataset2;
      int series1 = num6;
      int num7 = num5;
      string toolTipText = str5;
      string urlText = str4;
      XYItemEntity xyItemEntity = new XYItemEntity(area1, dataset1, series1, num7, toolTipText, urlText);
      entities.add((ChartEntity) xyItemEntity);
    }

    [LineNumberTable((ushort) 1736)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isPointInRect(Rectangle2D rect, double x, double y)
    {
      return x >= ((RectangularShape) rect).getMinX() && x <= ((RectangularShape) rect).getMaxX() && (y >= ((RectangularShape) rect).getMinY() && y <= ((RectangularShape) rect).getMaxY());
    }

    [Obsolete]
    public virtual XYItemLabelGenerator getItemLabelGenerator()
    {
      return this.itemLabelGenerator;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 138, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelGenerator(XYItemLabelGenerator generator)
    {
      this.itemLabelGenerator = generator;
      this.fireChangeEvent();
    }

    [Obsolete]
    public virtual XYToolTipGenerator getToolTipGenerator()
    {
      return this.toolTipGenerator;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 172, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setToolTipGenerator(XYToolTipGenerator generator)
    {
      this.toolTipGenerator = generator;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 197, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateCrosshairValues(CrosshairState crosshairState, double x, double y, double transX, double transY, PlotOrientation orientation)
    {
      this.updateCrosshairValues(crosshairState, x, y, 0, 0, transX, transY, orientation);
    }

    [HideFromReflection]
    public abstract void drawItem([In] Graphics2D obj0, [In] XYItemRendererState obj1, [In] Rectangle2D obj2, [In] PlotRenderingInfo obj3, [In] XYPlot obj4, [In] ValueAxis obj5, [In] ValueAxis obj6, [In] XYDataset obj7, [In] int obj8, [In] int obj9, [In] CrosshairState obj10, [In] int obj11);
  }
}
