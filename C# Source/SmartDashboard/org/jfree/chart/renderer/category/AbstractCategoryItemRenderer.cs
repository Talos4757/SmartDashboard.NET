// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.AbstractCategoryItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.category
{
  [Implements(new string[] {"org.jfree.chart.renderer.category.CategoryItemRenderer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class AbstractCategoryItemRenderer : AbstractRenderer, CategoryItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 1247553218442497391L;
    private CategoryPlot plot;
    private ObjectList itemLabelGeneratorList;
    private CategoryItemLabelGenerator baseItemLabelGenerator;
    private ObjectList toolTipGeneratorList;
    private CategoryToolTipGenerator baseToolTipGenerator;
    private ObjectList itemURLGeneratorList;
    private CategoryURLGenerator baseItemURLGenerator;
    private CategorySeriesLabelGenerator legendItemLabelGenerator;
    private CategorySeriesLabelGenerator legendItemToolTipGenerator;
    private CategorySeriesLabelGenerator legendItemURLGenerator;
    [NonSerialized]
    private int rowCount;
    [NonSerialized]
    private int columnCount;
    [Obsolete]
    private CategoryItemLabelGenerator itemLabelGenerator;
    [Obsolete]
    private CategoryToolTipGenerator toolTipGenerator;
    [Obsolete]
    private CategoryURLGenerator itemURLGenerator;

    [HideFromJava]
    static AbstractCategoryItemRenderer()
    {
      AbstractRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 104, (byte) 103, (byte) 107, (byte) 103, (byte) 107, (byte) 103, (byte) 107, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractCategoryItemRenderer()
    {
      AbstractCategoryItemRenderer categoryItemRenderer = this;
      this.itemLabelGenerator = (CategoryItemLabelGenerator) null;
      this.itemLabelGeneratorList = new ObjectList();
      this.toolTipGenerator = (CategoryToolTipGenerator) null;
      this.toolTipGeneratorList = new ObjectList();
      this.itemURLGenerator = (CategoryURLGenerator) null;
      this.itemURLGeneratorList = new ObjectList();
      this.legendItemLabelGenerator = (CategorySeriesLabelGenerator) new StandardCategorySeriesLabelGenerator();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractCategoryItemRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractCategoryItemRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractCategoryItemRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseToolTipGenerator(CategoryToolTipGenerator generator)
    {
      this.baseToolTipGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 142, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemURLGenerator(CategoryURLGenerator generator)
    {
      this.baseItemURLGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 195, (byte) 103, (byte) 107, (byte) 161, (byte) 103, (byte) 98, (byte) 115, (byte) 104, (byte) 184, (byte) 104, (byte) 214, (byte) 104, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeLine(Graphics2D g2, CategoryPlot plot, ValueAxis axis, Rectangle2D dataArea, double value, Paint paint, Stroke stroke)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 104, (byte) 199, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryItemLabelGenerator getSeriesItemLabelGenerator(int series)
    {
      if (this.itemLabelGenerator != null)
        return this.itemLabelGenerator;
      else
        return (CategoryItemLabelGenerator) this.itemLabelGeneratorList.get(series) ?? this.baseItemLabelGenerator;
    }

    [LineNumberTable((ushort) 393)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryToolTipGenerator getSeriesToolTipGenerator(int series)
    {
      return (CategoryToolTipGenerator) this.toolTipGeneratorList.get(series);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 93, (byte) 104, (byte) 199, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryURLGenerator getSeriesItemURLGenerator(int series)
    {
      if (this.itemURLGenerator != null)
        return this.itemURLGenerator;
      else
        return (CategoryURLGenerator) this.itemURLGeneratorList.get(series) ?? this.baseItemURLGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlot(CategoryPlot plot)
    {
      if (plot == null)
      {
        string str = "Null 'plot' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.plot = plot;
    }

    [LineNumberTable((ushort) 549)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual CategoryItemRendererState createState(PlotRenderingInfo info)
    {
      return new CategoryItemRendererState(info);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 242, (byte) 130, (byte) 99, (byte) 130, (byte) 104, (byte) 102, (byte) 103, (byte) 102, (byte) 105, (byte) 14, (byte) 230, (byte) 69, (byte) 203})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Range findRangeBounds(CategoryDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
        return (Range) null;
      if (this.getDataBoundsIncludesVisibleSeriesOnly())
      {
        ArrayList arrayList = new ArrayList();
        int rowCount = dataset.getRowCount();
        for (int index = 0; index < rowCount; ++index)
        {
          if (this.isSeriesVisible(index))
            ((List) arrayList).add((object) dataset.getRowKey(index));
        }
        return DatasetUtilities.findRangeBounds(dataset, (List) arrayList, num != 0);
      }
      else
        return DatasetUtilities.findRangeBounds(dataset, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 238, (byte) 98, (byte) 104, (byte) 179, (byte) 104, (byte) 177})]
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 16, (byte) 98, (byte) 104, (byte) 179, (byte) 104, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Point2D calculateRangeMarkerTextAnchorPoint(Graphics2D g2, PlotOrientation orientation, Rectangle2D dataArea, Rectangle2D markerArea, RectangleInsets markerOffset, LengthAdjustmentType labelOffsetType, RectangleAnchor anchor)
    {
      Rectangle2D rectangle = (Rectangle2D) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        rectangle = markerOffset.createAdjustedRectangle(markerArea, labelOffsetType, LengthAdjustmentType.__\u003C\u003ECONTRACT);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        rectangle = markerOffset.createAdjustedRectangle(markerArea, LengthAdjustmentType.__\u003C\u003ECONTRACT, labelOffsetType);
      return RectangleAnchor.coordinates(rectangle, anchor);
    }

    public virtual CategoryPlot getPlot()
    {
      return this.plot;
    }

    [LineNumberTable((ushort) 284)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryItemLabelGenerator getItemLabelGenerator(int row, int column)
    {
      return this.getSeriesItemLabelGenerator(row);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 43, (byte) 103, (byte) 99, (byte) 194, (byte) 114, (byte) 162, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 149, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 110, (byte) 104, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendItem getLegendItem(int datasetIndex, int series)
    {
      CategoryPlot plot = this.getPlot();
      if (plot == null)
        return (LegendItem) null;
      if (!this.isSeriesVisible(series) || !this.isSeriesVisibleInLegend(series))
        return (LegendItem) null;
      CategoryDataset dataset = plot.getDataset(datasetIndex);
      string label = this.legendItemLabelGenerator.generateLabel(dataset, series);
      string description = label;
      string toolTipText = (string) null;
      if (this.legendItemToolTipGenerator != null)
        toolTipText = this.legendItemToolTipGenerator.generateLabel(dataset, series);
      string urlText = (string) null;
      if (this.legendItemURLGenerator != null)
        urlText = this.legendItemURLGenerator.generateLabel(dataset, series);
      Shape shape = this.lookupLegendShape(series);
      Paint fillPaint = this.lookupSeriesPaint(series);
      Paint outlinePaint = this.lookupSeriesOutlinePaint(series);
      Stroke outlineStroke = this.lookupSeriesOutlineStroke(series);
      LegendItem legendItem = new LegendItem(label, description, toolTipText, urlText, shape, fillPaint, outlineStroke, outlinePaint);
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 98, (byte) 104, (byte) 169, (byte) 104, (byte) 99, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryToolTipGenerator getToolTipGenerator(int row, int column)
    {
      return this.toolTipGenerator == null ? this.getSeriesToolTipGenerator(row) ?? this.baseToolTipGenerator : this.toolTipGenerator;
    }

    [LineNumberTable((ushort) 448)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryURLGenerator getItemURLGenerator(int row, int column)
    {
      return this.getSeriesItemURLGenerator(row);
    }

    public virtual int getPassCount()
    {
      return 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 210, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemLabelGenerator(int series, CategoryItemLabelGenerator generator)
    {
      this.itemLabelGeneratorList.set(series, (object) generator);
      this.fireChangeEvent();
    }

    public virtual CategoryItemLabelGenerator getBaseItemLabelGenerator()
    {
      return this.baseItemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 235, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseItemLabelGenerator(CategoryItemLabelGenerator generator)
    {
      this.baseItemLabelGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 37, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesToolTipGenerator(int series, CategoryToolTipGenerator generator)
    {
      this.toolTipGeneratorList.set(series, (object) generator);
      this.fireChangeEvent();
    }

    public virtual CategoryToolTipGenerator getBaseToolTipGenerator()
    {
      return this.baseToolTipGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 118, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesItemURLGenerator(int series, CategoryURLGenerator generator)
    {
      this.itemURLGeneratorList.set(series, (object) generator);
      this.fireChangeEvent();
    }

    public virtual CategoryURLGenerator getBaseItemURLGenerator()
    {
      return this.baseItemURLGenerator;
    }

    public virtual int getRowCount()
    {
      return this.rowCount;
    }

    public virtual int getColumnCount()
    {
      return this.columnCount;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 203, (byte) 103, (byte) 105, (byte) 99, (byte) 108, (byte) 174, (byte) 103, (byte) 135, (byte) 105, (byte) 108, (byte) 98, (byte) 109, (byte) 106, (byte) 101, (byte) 228, (byte) 61, (byte) 232, (byte) 70, (byte) 104, (byte) 139, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, CategoryPlot plot, int rendererIndex, PlotRenderingInfo info)
    {
      this.setPlot(plot);
      CategoryDataset dataset = plot.getDataset(rendererIndex);
      if (dataset != null)
      {
        this.rowCount = dataset.getRowCount();
        this.columnCount = dataset.getColumnCount();
      }
      else
      {
        this.rowCount = 0;
        this.columnCount = 0;
      }
      CategoryItemRendererState state = this.createState(info);
      int[] numArray = new int[this.rowCount];
      int length = 0;
      for (int series = 0; series < this.rowCount; ++series)
      {
        if (this.isSeriesVisible(series))
        {
          numArray[length] = series;
          ++length;
        }
      }
      int[] visibleSeries = new int[length];
      ByteCodeHelper.arraycopy_primitive_4((Array) numArray, 0, (Array) visibleSeries, 0, length);
      state.setVisibleSeriesArray(visibleSeries);
      return state;
    }

    [LineNumberTable((ushort) 609)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range findRangeBounds(CategoryDataset dataset)
    {
      return this.findRangeBounds(dataset, false);
    }

    [LineNumberTable((ushort) 662)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getItemMiddle(IComparable rowKey, IComparable columnKey, CategoryDataset dataset, CategoryAxis axis, Rectangle2D area, RectangleEdge edge)
    {
      return axis.getCategoryMiddle(columnKey, dataset.getColumnKeys(), area, edge);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 53, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawBackground(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea)
    {
      plot.drawBackground(g2, dataArea);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 70, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawOutline(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea)
    {
      plot.drawOutline(g2, dataArea);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 95, (byte) 98, (byte) 135, (byte) 104, (byte) 186, (byte) 104, (byte) 216, (byte) 103, (byte) 99, (byte) 134, (byte) 135, (byte) 103, (byte) 99, (byte) 134, (byte) 135, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainGridline(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea, double value)
    {
      Line2D.Double @double = (Line2D.Double) null;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), value, ((RectangularShape) dataArea).getMaxX(), value);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Line2D.Double(value, ((RectangularShape) dataArea).getMinY(), value, ((RectangularShape) dataArea).getMaxY());
      Paint paint = plot.getDomainGridlinePaint() ?? CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      g2.setPaint(paint);
      Stroke stroke = plot.getDomainGridlineStroke() ?? CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      g2.setStroke(stroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 141, (byte) 103, (byte) 107, (byte) 161, (byte) 103, (byte) 115, (byte) 98, (byte) 104, (byte) 184, (byte) 104, (byte) 214, (byte) 104, (byte) 100, (byte) 135, (byte) 136, (byte) 104, (byte) 100, (byte) 135, (byte) 136, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeGridline(Graphics2D g2, CategoryPlot plot, ValueAxis axis, Rectangle2D dataArea, double value)
    {
      if (!axis.getRange().contains(value))
        return;
      PlotOrientation orientation = plot.getOrientation();
      double num = axis.valueToJava2D(value, dataArea, plot.getRangeAxisEdge());
      Line2D.Double @double = (Line2D.Double) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
      Paint paint = plot.getRangeGridlinePaint() ?? CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_PAINT;
      g2.setPaint(paint);
      Stroke stroke = plot.getRangeGridlineStroke() ?? CategoryPlot.__\u003C\u003EDEFAULT_GRIDLINE_STROKE;
      g2.setStroke(stroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 236, (byte) 104, (byte) 110, (byte) 104, (byte) 100, (byte) 161, (byte) 103, (byte) 179, (byte) 104, (byte) 98, (byte) 108, (byte) 184, (byte) 99, (byte) 105, (byte) 187, (byte) 105, (byte) 185, (byte) 109, (byte) 109, (byte) 104, (byte) 105, (byte) 133, (byte) 184, (byte) 184, (byte) 99, (byte) 105, (byte) 190, (byte) 105, (byte) 188, (byte) 109, (byte) 104, (byte) 164, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 191, (byte) 0, (byte) 223, (byte) 1, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawDomainMarker(Graphics2D g2, CategoryPlot plot, CategoryAxis axis, CategoryMarker marker, Rectangle2D dataArea)
    {
      IComparable key = marker.getKey();
      CategoryDataset dataset = plot.getDataset(plot.getIndexOf((CategoryItemRenderer) this));
      int columnIndex = dataset.getColumnIndex(key);
      if (columnIndex < 0)
        return;
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
      PlotOrientation orientation = plot.getOrientation();
      Rectangle2D markerArea;
      if (marker.getDrawAsLine())
      {
        double categoryMiddle = axis.getCategoryMiddle(columnIndex, dataset.getColumnCount(), dataArea, plot.getDomainAxisEdge());
        Line2D.Double @double = (Line2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), categoryMiddle, ((RectangularShape) dataArea).getMaxX(), categoryMiddle);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          @double = new Line2D.Double(categoryMiddle, ((RectangularShape) dataArea).getMinY(), categoryMiddle, ((RectangularShape) dataArea).getMaxY());
        g2.setPaint(marker.getPaint());
        g2.setStroke(marker.getStroke());
        g2.draw((Shape) @double);
        markerArea = ((Line2D) @double).getBounds2D();
      }
      else
      {
        double categoryStart = axis.getCategoryStart(columnIndex, dataset.getColumnCount(), dataArea, plot.getDomainAxisEdge());
        double categoryEnd = axis.getCategoryEnd(columnIndex, dataset.getColumnCount(), dataArea, plot.getDomainAxisEdge());
        Rectangle2D.Double @double = (Rectangle2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          @double = new Rectangle2D.Double(((RectangularShape) dataArea).getMinX(), categoryStart, ((RectangularShape) dataArea).getWidth(), categoryEnd - categoryStart);
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          @double = new Rectangle2D.Double(categoryStart, ((RectangularShape) dataArea).getMinY(), categoryEnd - categoryStart, ((RectangularShape) dataArea).getHeight());
        g2.setPaint(marker.getPaint());
        g2.fill((Shape) @double);
        markerArea = (Rectangle2D) @double;
      }
      string label = marker.getLabel();
      RectangleAnchor labelAnchor = marker.getLabelAnchor();
      if (label != null)
      {
        Font labelFont = marker.getLabelFont();
        ((Graphics) g2).setFont(labelFont);
        g2.setPaint(marker.getLabelPaint());
        Point2D point2D = this.calculateDomainMarkerTextAnchorPoint(g2, orientation, dataArea, markerArea, marker.getLabelOffset(), marker.getLabelOffsetType(), labelAnchor);
        TextUtilities.drawAlignedString(label, g2, (float) point2D.getX(), (float) point2D.getY(), marker.getLabelTextAnchor());
      }
      g2.setComposite(composite);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 66, (byte) 108, (byte) 104, (byte) 104, (byte) 135, (byte) 105, (byte) 161, (byte) 103, (byte) 179, (byte) 104, (byte) 146, (byte) 99, (byte) 105, (byte) 187, (byte) 105, (byte) 217, (byte) 109, (byte) 109, (byte) 136, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 3, (byte) 223, (byte) 1, (byte) 103, (byte) 101, (byte) 108, (byte) 105, (byte) 105, (byte) 106, (byte) 104, (byte) 108, (byte) 161, (byte) 104, (byte) 179, (byte) 146, (byte) 147, (byte) 108, (byte) 140, (byte) 104, (byte) 99, (byte) 137, (byte) 113, (byte) 113, (byte) 222, (byte) 137, (byte) 113, (byte) 113, (byte) 220, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 100, (byte) 141, (byte) 104, (byte) 130, (byte) 136, (byte) 168, (byte) 120, (byte) 108, (byte) 103, (byte) 106, (byte) 106, (byte) 109, (byte) 109, (byte) 106, (byte) 111, (byte) 136, (byte) 107, (byte) 111, (byte) 136, (byte) 133, (byte) 103, (byte) 106, (byte) 106, (byte) 109, (byte) 109, (byte) 106, (byte) 111, (byte) 136, (byte) 107, (byte) 111, (byte) 232, (byte) 69, (byte) 105, (byte) 105, (byte) 100, (byte) 105, (byte) 104, (byte) 109, (byte) 223, (byte) 0, (byte) 223, (byte) 1, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawRangeMarker(Graphics2D g2, CategoryPlot plot, ValueAxis axis, Marker marker, Rectangle2D dataArea)
    {
      if (marker is ValueMarker)
      {
        double d = ((ValueMarker) marker).getValue();
        if (!axis.getRange().contains(d))
          return;
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
        PlotOrientation orientation = plot.getOrientation();
        double num = axis.valueToJava2D(d, dataArea, plot.getRangeAxisEdge());
        Line2D.Double @double = (Line2D.Double) null;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          @double = new Line2D.Double(num, ((RectangularShape) dataArea).getMinY(), num, ((RectangularShape) dataArea).getMaxY());
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          @double = new Line2D.Double(((RectangularShape) dataArea).getMinX(), num, ((RectangularShape) dataArea).getMaxX(), num);
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
        Range range = axis.getRange();
        if (!range.intersects(startValue, endValue))
          return;
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, marker.getAlpha()));
        double num1 = axis.valueToJava2D(startValue, dataArea, plot.getRangeAxisEdge());
        double num2 = axis.valueToJava2D(endValue, dataArea, plot.getRangeAxisEdge());
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

    [LineNumberTable(new byte[] {(byte) 164, (byte) 95, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractCategoryItemRenderer))
        return false;
      AbstractCategoryItemRenderer categoryItemRenderer = (AbstractCategoryItemRenderer) obj;
      if (!ObjectUtilities.equal((object) this.itemLabelGenerator, (object) categoryItemRenderer.itemLabelGenerator) || !ObjectUtilities.equal((object) this.itemLabelGeneratorList, (object) categoryItemRenderer.itemLabelGeneratorList) || (!ObjectUtilities.equal((object) this.baseItemLabelGenerator, (object) categoryItemRenderer.baseItemLabelGenerator) || !ObjectUtilities.equal((object) this.toolTipGenerator, (object) categoryItemRenderer.toolTipGenerator)) || (!ObjectUtilities.equal((object) this.toolTipGeneratorList, (object) categoryItemRenderer.toolTipGeneratorList) || !ObjectUtilities.equal((object) this.baseToolTipGenerator, (object) categoryItemRenderer.baseToolTipGenerator) || (!ObjectUtilities.equal((object) this.itemURLGenerator, (object) categoryItemRenderer.itemURLGenerator) || !ObjectUtilities.equal((object) this.itemURLGeneratorList, (object) categoryItemRenderer.itemURLGeneratorList))) || (!ObjectUtilities.equal((object) this.baseItemURLGenerator, (object) categoryItemRenderer.baseItemURLGenerator) || !ObjectUtilities.equal((object) this.legendItemLabelGenerator, (object) categoryItemRenderer.legendItemLabelGenerator) || (!ObjectUtilities.equal((object) this.legendItemToolTipGenerator, (object) categoryItemRenderer.legendItemToolTipGenerator) || !ObjectUtilities.equal((object) this.legendItemURLGenerator, (object) categoryItemRenderer.legendItemURLGenerator))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 160, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 170, (byte) 98, (byte) 103, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DrawingSupplier getDrawingSupplier()
    {
      DrawingSupplier drawingSupplier = (DrawingSupplier) null;
      CategoryPlot plot = this.getPlot();
      if (plot != null)
        drawingSupplier = plot.getDrawingSupplier();
      return drawingSupplier;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 201, (byte) 100, (byte) 176, (byte) 99, (byte) 141, (byte) 215, (byte) 209})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateCrosshairValues(CategoryCrosshairState crosshairState, IComparable rowKey, IComparable columnKey, double value, int datasetIndex, double transX, double transY, PlotOrientation orientation)
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
        if (this.plot.isRangeCrosshairLockedOnData())
          crosshairState.updateCrosshairPoint(rowKey, columnKey, value, datasetIndex, transX, transY, orientation);
        else
          crosshairState.updateCrosshairX(rowKey, columnKey, datasetIndex, transX, orientation);
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 55, (byte) 99, (byte) 139, (byte) 102, (byte) 107, (byte) 107, (byte) 103, (byte) 103, (byte) 109, (byte) 98, (byte) 99, (byte) 174, (byte) 140, (byte) 150, (byte) 255, (byte) 16, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawItemLabel(Graphics2D g2, PlotOrientation orientation, CategoryDataset dataset, int row, int column, double x, double y, bool negative)
    {
      int num = negative ? 1 : 0;
      CategoryItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(row, column);
      if (itemLabelGenerator == null)
        return;
      Font itemLabelFont = this.getItemLabelFont(row, column);
      Paint itemLabelPaint = this.getItemLabelPaint(row, column);
      ((Graphics) g2).setFont(itemLabelFont);
      g2.setPaint(itemLabelPaint);
      string text = itemLabelGenerator.generateLabel(dataset, row, column);
      ItemLabelPosition itemLabelPosition = num != 0 ? this.getNegativeItemLabelPosition(row, column) : this.getPositiveItemLabelPosition(row, column);
      Point2D point2D = this.calculateLabelAnchorPoint(itemLabelPosition.getItemLabelAnchor(), x, y, orientation);
      TextUtilities.drawRotatedString(text, g2, (float) point2D.getX(), (float) point2D.getY(), itemLabelPosition.getTextAnchor(), itemLabelPosition.getAngle(), itemLabelPosition.getRotationAnchor());
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 16, (byte) 172, (byte) 104, (byte) 109, (byte) 108, (byte) 145, (byte) 130, (byte) 240, (byte) 69, (byte) 104, (byte) 214, (byte) 104, (byte) 109, (byte) 140, (byte) 145, (byte) 130, (byte) 240, (byte) 69, (byte) 104, (byte) 109, (byte) 108, (byte) 113, (byte) 130, (byte) 240, (byte) 69, (byte) 104, (byte) 214, (byte) 104, (byte) 109, (byte) 140, (byte) 145, (byte) 130, (byte) 240, (byte) 69, (byte) 104, (byte) 109, (byte) 108, (byte) 113, (byte) 130, (byte) 240, (byte) 69, (byte) 104, (byte) 214, (byte) 104, (byte) 109, (byte) 140, (byte) 113, (byte) 130, (byte) 240, (byte) 69, (byte) 109, (byte) 182, (byte) 109, (byte) 182, (byte) 109, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      AbstractCategoryItemRenderer categoryItemRenderer = (AbstractCategoryItemRenderer) base.clone();
      if (this.itemLabelGenerator != null)
      {
        if (this.itemLabelGenerator is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) this.itemLabelGenerator;
          categoryItemRenderer.itemLabelGenerator = (CategoryItemLabelGenerator) publicCloneable.clone();
        }
        else
        {
          string str = "ItemLabelGenerator not cloneable.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new CloneNotSupportedException(str);
        }
      }
      if (this.itemLabelGeneratorList != null)
        categoryItemRenderer.itemLabelGeneratorList = (ObjectList) this.itemLabelGeneratorList.clone();
      if (this.baseItemLabelGenerator != null)
      {
        if (this.baseItemLabelGenerator is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) this.baseItemLabelGenerator;
          categoryItemRenderer.baseItemLabelGenerator = (CategoryItemLabelGenerator) publicCloneable.clone();
        }
        else
        {
          string str = "ItemLabelGenerator not cloneable.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new CloneNotSupportedException(str);
        }
      }
      if (this.toolTipGenerator != null)
      {
        if (this.toolTipGenerator is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) this.toolTipGenerator;
          categoryItemRenderer.toolTipGenerator = (CategoryToolTipGenerator) publicCloneable.clone();
        }
        else
        {
          string str = "Tool tip generator not cloneable.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new CloneNotSupportedException(str);
        }
      }
      if (this.toolTipGeneratorList != null)
        categoryItemRenderer.toolTipGeneratorList = (ObjectList) this.toolTipGeneratorList.clone();
      if (this.baseToolTipGenerator != null)
      {
        if (this.baseToolTipGenerator is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) this.baseToolTipGenerator;
          categoryItemRenderer.baseToolTipGenerator = (CategoryToolTipGenerator) publicCloneable.clone();
        }
        else
        {
          string str = "Base tool tip generator not cloneable.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new CloneNotSupportedException(str);
        }
      }
      if (this.itemURLGenerator != null)
      {
        if (this.itemURLGenerator is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) this.itemURLGenerator;
          categoryItemRenderer.itemURLGenerator = (CategoryURLGenerator) publicCloneable.clone();
        }
        else
        {
          string str = "Item URL generator not cloneable.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new CloneNotSupportedException(str);
        }
      }
      if (this.itemURLGeneratorList != null)
        categoryItemRenderer.itemURLGeneratorList = (ObjectList) this.itemURLGeneratorList.clone();
      if (this.baseItemURLGenerator != null)
      {
        if (this.baseItemURLGenerator is PublicCloneable)
        {
          PublicCloneable publicCloneable = (PublicCloneable) this.baseItemURLGenerator;
          categoryItemRenderer.baseItemURLGenerator = (CategoryURLGenerator) publicCloneable.clone();
        }
        else
        {
          string str = "Base item URL generator not cloneable.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new CloneNotSupportedException(str);
        }
      }
      if (this.legendItemLabelGenerator is PublicCloneable)
        categoryItemRenderer.legendItemLabelGenerator = (CategorySeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemLabelGenerator);
      if (this.legendItemToolTipGenerator is PublicCloneable)
        categoryItemRenderer.legendItemToolTipGenerator = (CategorySeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemToolTipGenerator);
      if (this.legendItemURLGenerator is PublicCloneable)
        categoryItemRenderer.legendItemURLGenerator = (CategorySeriesLabelGenerator) ObjectUtilities.clone((object) this.legendItemURLGenerator);
      return (object) categoryItemRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 130, (byte) 104, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual CategoryAxis getDomainAxis(CategoryPlot plot, int index)
    {
      return plot.getDomainAxis(index) ?? plot.getDomainAxis();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 146, (byte) 104, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual ValueAxis getRangeAxis(CategoryPlot plot, int index)
    {
      return plot.getRangeAxis(index) ?? plot.getRangeAxis();
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 162, (byte) 104, (byte) 136, (byte) 102, (byte) 109, (byte) 109, (byte) 99, (byte) 103, (byte) 104, (byte) 106, (byte) 107, (byte) 100, (byte) 232, (byte) 60, (byte) 232, (byte) 74})]
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
        int indexOf = this.plot.getIndexOf((CategoryItemRenderer) this);
        CategoryDataset dataset = this.plot.getDataset(indexOf);
        if (dataset != null)
        {
          int rowCount = dataset.getRowCount();
          for (int series = 0; series < rowCount; ++series)
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

    public virtual CategorySeriesLabelGenerator getLegendItemLabelGenerator()
    {
      return this.legendItemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 204, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemLabelGenerator(CategorySeriesLabelGenerator generator)
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

    public virtual CategorySeriesLabelGenerator getLegendItemToolTipGenerator()
    {
      return this.legendItemToolTipGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 232, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemToolTipGenerator(CategorySeriesLabelGenerator generator)
    {
      this.legendItemToolTipGenerator = generator;
      this.fireChangeEvent();
    }

    public virtual CategorySeriesLabelGenerator getLegendItemURLGenerator()
    {
      return this.legendItemURLGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 1, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemURLGenerator(CategorySeriesLabelGenerator generator)
    {
      this.legendItemURLGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 17, (byte) 100, (byte) 144, (byte) 107, (byte) 129, (byte) 98, (byte) 106, (byte) 99, (byte) 139, (byte) 98, (byte) 106, (byte) 99, (byte) 139, (byte) 155, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void addItemEntity(EntityCollection entities, CategoryDataset dataset, int row, int column, Shape hotspot)
    {
      if (hotspot == null)
      {
        string str = "Null 'hotspot' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.getItemCreateEntity(row, column))
          return;
        string toolTipText = (string) null;
        CategoryToolTipGenerator toolTipGenerator = this.getToolTipGenerator(row, column);
        if (toolTipGenerator != null)
          toolTipText = toolTipGenerator.generateToolTip(dataset, row, column);
        string urlText = (string) null;
        CategoryURLGenerator itemUrlGenerator = this.getItemURLGenerator(row, column);
        if (itemUrlGenerator != null)
          urlText = itemUrlGenerator.generateURL(dataset, row, column);
        CategoryItemEntity categoryItemEntity = new CategoryItemEntity(hotspot, toolTipText, urlText, dataset, dataset.getRowKey(row), dataset.getColumnKey(column));
        entities.add((ChartEntity) categoryItemEntity);
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 57, (byte) 108, (byte) 129, (byte) 98, (byte) 99, (byte) 104, (byte) 109, (byte) 114, (byte) 180, (byte) 178, (byte) 98, (byte) 108, (byte) 100, (byte) 141, (byte) 99, (byte) 108, (byte) 100, (byte) 142, (byte) 159, (byte) 36, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void addEntity(EntityCollection entities, Shape hotspot, CategoryDataset dataset, int row, int column, double entityX, double entityY)
    {
      if (!this.getItemCreateEntity(row, column))
        return;
      object obj1 = (object) hotspot;
      if (hotspot == null)
      {
        double num1 = (double) this.getDefaultEntityRadius();
        double num2 = num1 * 2.0;
        obj1 = this.getPlot().getOrientation() != PlotOrientation.__\u003C\u003EVERTICAL ? (object) new Ellipse2D.Double(entityY - num1, entityX - num1, num2, num2) : (object) new Ellipse2D.Double(entityX - num1, entityY - num1, num2, num2);
      }
      string str1 = (string) null;
      CategoryToolTipGenerator toolTipGenerator = this.getToolTipGenerator(row, column);
      if (toolTipGenerator != null)
        str1 = toolTipGenerator.generateToolTip(dataset, row, column);
      string str2 = (string) null;
      CategoryURLGenerator itemUrlGenerator = this.getItemURLGenerator(row, column);
      if (itemUrlGenerator != null)
        str2 = itemUrlGenerator.generateURL(dataset, row, column);
      object obj2 = obj1;
      string str3 = str1;
      string str4 = str2;
      CategoryDataset categoryDataset1 = dataset;
      IComparable rowKey1 = dataset.getRowKey(row);
      IComparable columnKey1 = dataset.getColumnKey(column);
      IComparable comparable = rowKey1;
      CategoryDataset categoryDataset2 = categoryDataset1;
      string str5 = str4;
      string str6 = str3;
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
      string toolTipText = str6;
      string urlText = str5;
      CategoryDataset dataset1 = categoryDataset2;
      IComparable rowKey2 = comparable;
      IComparable columnKey2 = columnKey1;
      CategoryItemEntity categoryItemEntity = new CategoryItemEntity(area, toolTipText, urlText, dataset1, rowKey2, columnKey2);
      entities.add((ChartEntity) categoryItemEntity);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 121, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelGenerator(CategoryItemLabelGenerator generator)
    {
      this.itemLabelGenerator = generator;
      this.fireChangeEvent();
    }

    [Obsolete]
    public virtual CategoryToolTipGenerator getToolTipGenerator()
    {
      return this.toolTipGenerator;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 156, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setToolTipGenerator(CategoryToolTipGenerator generator)
    {
      this.toolTipGenerator = generator;
      this.fireChangeEvent();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 166, (byte) 172, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemURLGenerator(CategoryURLGenerator generator)
    {
      this.itemURLGenerator = generator;
      this.fireChangeEvent();
    }

    [HideFromReflection]
    public abstract void drawItem([In] Graphics2D obj0, [In] CategoryItemRendererState obj1, [In] Rectangle2D obj2, [In] CategoryPlot obj3, [In] CategoryAxis obj4, [In] ValueAxis obj5, [In] CategoryDataset obj6, [In] int obj7, [In] int obj8, [In] int obj9);
  }
}
