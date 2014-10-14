// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.SpiderWebPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.font;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.urls;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class SpiderWebPlot : Plot, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -5376340422031599463L;
    public const double DEFAULT_HEAD = 0.01;
    public const double DEFAULT_AXIS_LABEL_GAP = 0.1;
    public const double DEFAULT_INTERIOR_GAP = 0.25;
    public const double MAX_INTERIOR_GAP = 0.4;
    public const double DEFAULT_START_ANGLE = 90.0;
    internal static Font __\u003C\u003EDEFAULT_LABEL_FONT;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_PAINT;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT;
    internal static Stroke __\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE;
    internal static Paint __\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT;
    public const double DEFAULT_MAX_VALUE = -1.0;
    protected internal double headPercent;
    private double interiorGap;
    private double axisLabelGap;
    [NonSerialized]
    private Paint axisLinePaint;
    [NonSerialized]
    private Stroke axisLineStroke;
    private CategoryDataset dataset;
    private double maxValue;
    private TableOrder dataExtractOrder;
    private double startAngle;
    private Rotation direction;
    [NonSerialized]
    private Shape legendItemShape;
    [NonSerialized]
    private Paint seriesPaint;
    private PaintList seriesPaintList;
    [NonSerialized]
    private Paint baseSeriesPaint;
    [NonSerialized]
    private Paint seriesOutlinePaint;
    private PaintList seriesOutlinePaintList;
    [NonSerialized]
    private Paint baseSeriesOutlinePaint;
    [NonSerialized]
    private Stroke seriesOutlineStroke;
    private StrokeList seriesOutlineStrokeList;
    [NonSerialized]
    private Stroke baseSeriesOutlineStroke;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    private CategoryItemLabelGenerator labelGenerator;
    private bool webFilled;
    private CategoryToolTipGenerator toolTipGenerator;
    private CategoryURLGenerator urlGenerator;

    [Modifiers]
    public static Font DEFAULT_LABEL_FONT
    {
      [HideFromJava] get
      {
        return SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_PAINT
    {
      [HideFromJava] get
      {
        return SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_BACKGROUND_PAINT
    {
      [HideFromJava] get
      {
        return SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_OUTLINE_PAINT
    {
      [HideFromJava] get
      {
        return SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT;
      }
    }

    [Modifiers]
    public static Stroke DEFAULT_LABEL_OUTLINE_STROKE
    {
      [HideFromJava] get
      {
        return SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_LABEL_SHADOW_PAINT
    {
      [HideFromJava] get
      {
        return SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 106, (byte) 101, (byte) 210, (byte) 170, (byte) 217, (byte) 170, (byte) 207})]
    static SpiderWebPlot()
    {
      Plot.__\u003Cclinit\u003E();
      SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_FONT = new Font("SansSerif", 0, 10);
      SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_PAINT = (Paint) Color.black;
      SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_BACKGROUND_PAINT = (Paint) new Color((int) byte.MaxValue, (int) byte.MaxValue, 192);
      SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_PAINT = (Paint) Color.black;
      SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_OUTLINE_STROKE = (Stroke) new BasicStroke(0.5f);
      SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_SHADOW_PAINT = (Paint) Color.lightGray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpiderWebPlot(CategoryDataset dataset)
      : this(dataset, TableOrder.__\u003C\u003EBY_ROW)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 173, (byte) 232, (byte) 31, (byte) 231, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 99, (byte) 167, (byte) 103, (byte) 112, (byte) 112, (byte) 107, (byte) 144, (byte) 112, (byte) 112, (byte) 107, (byte) 144, (byte) 103, (byte) 107, (byte) 135, (byte) 103, (byte) 107, (byte) 139, (byte) 103, (byte) 107, (byte) 139, (byte) 107, (byte) 107, (byte) 139, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpiderWebPlot(CategoryDataset dataset, TableOrder extract)
    {
      SpiderWebPlot spiderWebPlot = this;
      this.webFilled = true;
      if (extract == null)
      {
        string str = "Null 'extract' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dataset = dataset;
        if (dataset != null)
          dataset.addChangeListener((DatasetChangeListener) this);
        this.dataExtractOrder = extract;
        this.headPercent = 0.01;
        this.axisLabelGap = 0.1;
        this.axisLinePaint = (Paint) Color.black;
        this.axisLineStroke = (Stroke) new BasicStroke(1f);
        this.interiorGap = 0.25;
        this.startAngle = 90.0;
        this.direction = Rotation.__\u003C\u003ECLOCKWISE;
        this.maxValue = -1.0;
        this.seriesPaint = (Paint) null;
        this.seriesPaintList = new PaintList();
        this.baseSeriesPaint = (Paint) null;
        this.seriesOutlinePaint = (Paint) null;
        this.seriesOutlinePaintList = new PaintList();
        this.baseSeriesOutlinePaint = Plot.__\u003C\u003EDEFAULT_OUTLINE_PAINT;
        this.seriesOutlineStroke = (Stroke) null;
        this.seriesOutlineStrokeList = new StrokeList();
        this.baseSeriesOutlineStroke = Plot.__\u003C\u003EDEFAULT_OUTLINE_STROKE;
        this.labelFont = SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_FONT;
        this.labelPaint = SpiderWebPlot.__\u003C\u003EDEFAULT_LABEL_PAINT;
        this.labelGenerator = (CategoryItemLabelGenerator) new StandardCategoryItemLabelGenerator();
        this.legendItemShape = Plot.__\u003C\u003EDEFAULT_LEGEND_ITEM_CIRCLE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpiderWebPlot()
      : this((CategoryDataset) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SpiderWebPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SpiderWebPlot obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SpiderWebPlot obj0)
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

    [LineNumberTable(new byte[] {(byte) 163, (byte) 75, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelFont = font;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 102, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.labelPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 243, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.axisLinePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual CategoryDataset getDataset()
    {
      return this.dataset;
    }

    public virtual Shape getLegendItemShape()
    {
      return this.legendItemShape;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 63, (byte) 104, (byte) 199, (byte) 109, (byte) 99, (byte) 103, (byte) 99, (byte) 103, (byte) 109, (byte) 98, (byte) 130, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSeriesPaint(int series)
    {
      if (this.seriesPaint != null)
        return this.seriesPaint;
      Paint paint = this.seriesPaintList.getPaint(series);
      if (paint == null)
      {
        DrawingSupplier drawingSupplier = this.getDrawingSupplier();
        if (drawingSupplier != null)
        {
          Paint nextPaint = drawingSupplier.getNextPaint();
          this.seriesPaintList.setPaint(series, nextPaint);
          paint = nextPaint;
        }
        else
          paint = this.baseSeriesPaint;
      }
      return paint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 157, (byte) 104, (byte) 167, (byte) 109, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getSeriesOutlinePaint(int series)
    {
      if (this.seriesOutlinePaint != null)
        return this.seriesOutlinePaint;
      else
        return this.seriesOutlinePaintList.getPaint(series) ?? this.baseSeriesOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 236, (byte) 104, (byte) 199, (byte) 109, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getSeriesOutlineStroke(int series)
    {
      if (this.seriesOutlineStroke != null)
        return this.seriesOutlineStroke;
      else
        return this.seriesOutlineStrokeList.getStroke(series) ?? this.baseSeriesOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 106, (byte) 102, (byte) 130, (byte) 102, (byte) 102, (byte) 105, (byte) 99, (byte) 104, (byte) 105, (byte) 232, (byte) 59, (byte) 38, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void calculateMaxValue([In] int obj0, [In] int obj1)
    {
      for (int series = 0; series < obj0; ++series)
      {
        for (int cat = 0; cat < obj1; ++cat)
        {
          Number plotValue = this.getPlotValue(series, cat);
          if (plotValue != null)
          {
            double num = plotValue.doubleValue();
            if (num > this.maxValue)
              this.maxValue = num;
          }
        }
      }
    }

    public virtual double getInteriorGap()
    {
      return this.interiorGap;
    }

    public virtual double getStartAngle()
    {
      return this.startAngle;
    }

    public virtual Rotation getDirection()
    {
      return this.direction;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 245, (byte) 105, (byte) 124, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Point2D getWebPoint(Rectangle2D bounds, double angle, double length)
    {
      double num1 = Math.toRadians(angle);
      double num2 = Math.cos(num1) * length * ((RectangularShape) bounds).getWidth() / 2.0;
      double num3 = -Math.sin(num1) * length * ((RectangularShape) bounds).getHeight() / 2.0;
      return (Point2D) new Point2D.Double(((RectangularShape) bounds).getX() + num2 + ((RectangularShape) bounds).getWidth() / 2.0, ((RectangularShape) bounds).getY() + num3 + ((RectangularShape) bounds).getHeight() / 2.0);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 28, (byte) 135, (byte) 98, (byte) 141, (byte) 214, (byte) 180, (byte) 110, (byte) 110, (byte) 137, (byte) 175, (byte) 136, (byte) 145, (byte) 108, (byte) 108, (byte) 151, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawLabel(Graphics2D g2, Rectangle2D plotArea, double value, int cat, double startAngle, double extent)
    {
      FontRenderContext fontRenderContext = g2.getFontRenderContext();
      string str = this.dataExtractOrder != TableOrder.__\u003C\u003EBY_ROW ? this.labelGenerator.generateRowLabel(this.dataset, cat) : this.labelGenerator.generateColumnLabel(this.dataset, cat);
      Point2D point2D = this.calculateLabelLocation(this.getLabelFont().getStringBounds(str, fontRenderContext), (double) this.getLabelFont().getLineMetrics(str, fontRenderContext).getAscent(), plotArea, startAngle);
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, 1f));
      g2.setPaint(this.getLabelPaint());
      ((Graphics) g2).setFont(this.getLabelFont());
      g2.drawString(str, (float) point2D.getX(), (float) point2D.getY());
      g2.setComposite(composite);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 141, (byte) 134, (byte) 98, (byte) 100, (byte) 205, (byte) 138, (byte) 138, (byte) 102, (byte) 137, (byte) 204, (byte) 255, (byte) 7, (byte) 78, (byte) 148, (byte) 222, (byte) 106, (byte) 106, (byte) 138, (byte) 191, (byte) 24, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 136, (byte) 102, (byte) 100, (byte) 109, (byte) 100, (byte) 165, (byte) 99, (byte) 132, (byte) 99, (byte) 104, (byte) 215, (byte) 99, (byte) 104, (byte) 215, (byte) 223, (byte) 49, (byte) 223, (byte) 14, (byte) 232, (byte) 159, (byte) 182, (byte) 233, (byte) 160, (byte) 82, (byte) 106, (byte) 104, (byte) 110, (byte) 199, (byte) 104, (byte) 145, (byte) 103, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawRadarPoly(Graphics2D g2, Rectangle2D plotArea, Point2D centre, PlotRenderingInfo info, int series, int catCount, double headH, double headW)
    {
      Polygon polygon = new Polygon();
      EntityCollection entityCollection = (EntityCollection) null;
      if (info != null)
        entityCollection = info.getOwner().getEntityCollection();
      for (int cat = 0; cat < catCount; ++cat)
      {
        Number plotValue = this.getPlotValue(series, cat);
        if (plotValue != null)
        {
          double num1 = plotValue.doubleValue();
          if (num1 >= 0.0)
          {
            double angle = this.getStartAngle() + this.getDirection().getFactor() * (double) cat * 360.0 / (double) catCount;
            Point2D webPoint = this.getWebPoint(plotArea, angle, num1 / this.maxValue);
            polygon.addPoint(ByteCodeHelper.d2i(webPoint.getX()), ByteCodeHelper.d2i(webPoint.getY()));
            Paint seriesPaint = this.getSeriesPaint(series);
            Paint seriesOutlinePaint = this.getSeriesOutlinePaint(series);
            Stroke seriesOutlineStroke = this.getSeriesOutlineStroke(series);
            Ellipse2D.Double @double = new Ellipse2D.Double(webPoint.getX() - headW / 2.0, webPoint.getY() - headH / 2.0, headW, headH);
            g2.setPaint(seriesPaint);
            g2.fill((Shape) @double);
            g2.setStroke(seriesOutlineStroke);
            g2.setPaint(seriesOutlinePaint);
            g2.draw((Shape) @double);
            if (entityCollection != null)
            {
              int num2;
              int num3;
              if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_ROW)
              {
                num2 = series;
                num3 = cat;
              }
              else
              {
                num2 = cat;
                num3 = series;
              }
              string toolTipText = (string) null;
              if (this.toolTipGenerator != null)
                toolTipText = this.toolTipGenerator.generateToolTip(this.dataset, num2, num3);
              string urlText = (string) null;
              if (this.urlGenerator != null)
                urlText = this.urlGenerator.generateURL(this.dataset, num2, num3);
              Rectangle.__\u003Cclinit\u003E();
              CategoryItemEntity categoryItemEntity = new CategoryItemEntity((Shape) new Rectangle(ByteCodeHelper.d2i(webPoint.getX() - headW), ByteCodeHelper.d2i(webPoint.getY() - headH), ByteCodeHelper.d2i(headW * 2.0), ByteCodeHelper.d2i(headH * 2.0)), toolTipText, urlText, this.dataset, this.dataset.getRowKey(num2), this.dataset.getColumnKey(num3));
              entityCollection.add((ChartEntity) categoryItemEntity);
            }
          }
        }
      }
      Paint seriesPaint1 = this.getSeriesPaint(series);
      g2.setPaint(seriesPaint1);
      g2.setStroke(this.getSeriesOutlineStroke(series));
      g2.draw((Shape) polygon);
      if (!this.webFilled)
        return;
      g2.setComposite((Composite) AlphaComposite.getInstance(3, 0.1f));
      g2.fill((Shape) polygon);
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 6, (byte) 98, (byte) 109, (byte) 144, (byte) 109, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Number getPlotValue(int series, int cat)
    {
      Number number = (Number) null;
      if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_ROW)
        number = this.dataset.getValue(series, cat);
      else if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_COLUMN)
        number = this.dataset.getValue(cat, series);
      return number;
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 73, (byte) 112, (byte) 135, (byte) 151, (byte) 183, (byte) 107, (byte) 139, (byte) 106, (byte) 172, (byte) 106, (byte) 182, (byte) 106, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Point2D calculateLabelLocation(Rectangle2D labelBounds, double ascent, Rectangle2D plotArea, double startAngle)
    {
      Point2D endPoint = ((Arc2D) new Arc2D.Double(plotArea, startAngle, 0.0, 0)).getEndPoint();
      double num1 = -(endPoint.getX() - ((RectangularShape) plotArea).getCenterX()) * this.axisLabelGap;
      double num2 = -(endPoint.getY() - ((RectangularShape) plotArea).getCenterY()) * this.axisLabelGap;
      double num3 = endPoint.getX() - num1;
      double num4 = endPoint.getY() - num2;
      if (num3 < ((RectangularShape) plotArea).getCenterX())
        num3 -= ((RectangularShape) labelBounds).getWidth();
      if (num3 == ((RectangularShape) plotArea).getCenterX())
        num3 -= ((RectangularShape) labelBounds).getWidth() / 2.0;
      if (num4 > ((RectangularShape) plotArea).getCenterY())
        num4 += ascent;
      return (Point2D) new Point2D.Double(num3, num4);
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    public override string getPlotType()
    {
      return "Spider Web Plot";
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 244, (byte) 104, (byte) 204, (byte) 103, (byte) 99, (byte) 108, (byte) 199, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(CategoryDataset dataset)
    {
      if (this.dataset != null)
        this.dataset.removeChangeListener((DatasetChangeListener) this);
      this.dataset = dataset;
      if (dataset != null)
      {
        this.setDatasetGroup(dataset.getGroup());
        dataset.addChangeListener((DatasetChangeListener) this);
      }
      this.datasetChanged(new DatasetChangeEvent((object) this, (Dataset) dataset));
    }

    public virtual bool isWebFilled()
    {
      return this.webFilled;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 44, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWebFilled(bool flag)
    {
      this.webFilled = flag;
      this.fireChangeEvent();
    }

    public virtual TableOrder getDataExtractOrder()
    {
      return this.dataExtractOrder;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 50, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataExtractOrder(TableOrder order)
    {
      if (order == null)
      {
        string str = "Null 'order' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dataExtractOrder = order;
        this.fireChangeEvent();
      }
    }

    public virtual double getHeadPercent()
    {
      return this.headPercent;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setHeadPercent(double percent)
    {
      this.headPercent = percent;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartAngle(double angle)
    {
      this.startAngle = angle;
      this.fireChangeEvent();
    }

    public virtual double getMaxValue()
    {
      return this.maxValue;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 132, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaxValue(double value)
    {
      this.maxValue = value;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 157, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDirection(Rotation direction)
    {
      if (direction == null)
      {
        string str = "Null 'direction' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.direction = direction;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 186, (byte) 118, (byte) 176, (byte) 106, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInteriorGap(double percent)
    {
      if (percent < 0.0 || percent > 0.4)
      {
        string str = "Percentage outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.interiorGap == percent)
          return;
        this.interiorGap = percent;
        this.fireChangeEvent();
      }
    }

    public virtual double getAxisLabelGap()
    {
      return this.axisLabelGap;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 216, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLabelGap(double gap)
    {
      this.axisLabelGap = gap;
      this.fireChangeEvent();
    }

    public virtual Paint getAxisLinePaint()
    {
      return this.axisLinePaint;
    }

    public virtual Stroke getAxisLineStroke()
    {
      return this.axisLineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 17, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisLineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.axisLineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getSeriesPaint()
    {
      return this.seriesPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 47, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPaint(Paint paint)
    {
      this.seriesPaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 94, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesPaint(int series, Paint paint)
    {
      this.seriesPaintList.setPaint(series, paint);
      this.fireChangeEvent();
    }

    public virtual Paint getBaseSeriesPaint()
    {
      return this.baseSeriesPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 118, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseSeriesPaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Paint getSeriesOutlinePaint()
    {
      return this.seriesOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlinePaint(Paint paint)
    {
      this.seriesOutlinePaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 176, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlinePaint(int series, Paint paint)
    {
      this.seriesOutlinePaintList.setPaint(series, paint);
      this.fireChangeEvent();
    }

    public virtual Paint getBaseSeriesOutlinePaint()
    {
      return this.baseSeriesOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 196, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseSeriesOutlinePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual Stroke getSeriesOutlineStroke()
    {
      return this.seriesOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 222, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlineStroke(Stroke stroke)
    {
      this.seriesOutlineStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 1, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesOutlineStroke(int series, Stroke stroke)
    {
      this.seriesOutlineStrokeList.setStroke(series, stroke);
      this.fireChangeEvent();
    }

    public virtual Stroke getBaseSeriesOutlineStroke()
    {
      return this.baseSeriesOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 21, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBaseSeriesOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.baseSeriesOutlineStroke = stroke;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 48, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemShape(Shape shape)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendItemShape = shape;
        this.fireChangeEvent();
      }
    }

    public virtual CategoryItemLabelGenerator getLabelGenerator()
    {
      return this.labelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 129, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelGenerator(CategoryItemLabelGenerator generator)
    {
      if (generator == null)
      {
        string str = "Null 'generator' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.labelGenerator = generator;
    }

    public virtual CategoryToolTipGenerator getToolTipGenerator()
    {
      return this.toolTipGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 159, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setToolTipGenerator(CategoryToolTipGenerator generator)
    {
      this.toolTipGenerator = generator;
      this.fireChangeEvent();
    }

    public virtual CategoryURLGenerator getURLGenerator()
    {
      return this.urlGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 187, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setURLGenerator(CategoryURLGenerator generator)
    {
      this.urlGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 197, (byte) 102, (byte) 104, (byte) 162, (byte) 98, (byte) 109, (byte) 142, (byte) 109, (byte) 172, (byte) 102, (byte) 98, (byte) 103, (byte) 136, (byte) 107, (byte) 109, (byte) 132, (byte) 105, (byte) 105, (byte) 105, (byte) 149, (byte) 109, (byte) 104, (byte) 100, (byte) 165})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection = new LegendItemCollection();
      if (this.getDataset() == null)
        return legendItemCollection;
      List list = (List) null;
      if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_ROW)
        list = this.dataset.getRowKeys();
      else if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_COLUMN)
        list = this.dataset.getColumnKeys();
      if (list != null)
      {
        int series = 0;
        Iterator iterator = list.iterator();
        Shape legendItemShape = this.getLegendItemShape();
        while (iterator.hasNext())
        {
          string label = Object.instancehelper_toString(iterator.next());
          string description = label;
          Paint seriesPaint = this.getSeriesPaint(series);
          Paint seriesOutlinePaint = this.getSeriesOutlinePaint(series);
          Stroke seriesOutlineStroke = this.getSeriesOutlineStroke(series);
          LegendItem legendItem = new LegendItem(label, description, (string) null, (string) null, legendItemShape, seriesPaint, seriesOutlineStroke, seriesOutlinePaint);
          legendItem.setDataset((Dataset) this.getDataset());
          legendItemCollection.add(legendItem);
          ++series;
        }
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 11, (byte) 103, (byte) 135, (byte) 100, (byte) 104, (byte) 168, (byte) 104, (byte) 136, (byte) 135, (byte) 103, (byte) 103, (byte) 178, (byte) 112, (byte) 132, (byte) 109, (byte) 108, (byte) 175, (byte) 108, (byte) 205, (byte) 113, (byte) 233, (byte) 70, (byte) 112, (byte) 144, (byte) 118, (byte) 118, (byte) 108, (byte) 140, (byte) 112, (byte) 176, (byte) 118, (byte) 120, (byte) 120, (byte) 111, (byte) 143, (byte) 127, (byte) 6, (byte) 175, (byte) 108, (byte) 191, (byte) 8, (byte) 145, (byte) 107, (byte) 108, (byte) 108, (byte) 104, (byte) 255, (byte) 0, (byte) 54, (byte) 235, (byte) 78, (byte) 104, (byte) 53, (byte) 200, (byte) 130, (byte) 136, (byte) 103, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      this.getInsets().trim(area);
      if (info != null)
      {
        info.setPlotArea(area);
        info.setDataArea(area);
      }
      this.drawBackground(g2, area);
      this.drawOutline(g2, area);
      Shape clip = ((Graphics) g2).getClip();
      g2.clip((Shape) area);
      Composite composite = g2.getComposite();
      g2.setComposite((Composite) AlphaComposite.getInstance(3, this.getForegroundAlpha()));
      if (!DatasetUtilities.isEmptyOrNull(this.dataset))
      {
        int num1;
        int catCount;
        if (this.dataExtractOrder == TableOrder.__\u003C\u003EBY_ROW)
        {
          num1 = this.dataset.getRowCount();
          catCount = this.dataset.getColumnCount();
        }
        else
        {
          num1 = this.dataset.getColumnCount();
          catCount = this.dataset.getRowCount();
        }
        if (this.maxValue == -1.0)
          this.calculateMaxValue(num1, catCount);
        double num2 = ((RectangularShape) area).getWidth() * this.getInteriorGap();
        double num3 = ((RectangularShape) area).getHeight() * this.getInteriorGap();
        double num4 = ((RectangularShape) area).getX() + num2 / 2.0;
        double num5 = ((RectangularShape) area).getY() + num3 / 2.0;
        double num6 = ((RectangularShape) area).getWidth() - num2;
        double num7 = ((RectangularShape) area).getHeight() - num3;
        double headW = ((RectangularShape) area).getWidth() * this.headPercent;
        double headH = ((RectangularShape) area).getHeight() * this.headPercent;
        double num8 = Math.min(num6, num7) / 2.0;
        double num9 = (num4 + num4 + num6) / 2.0 - num8;
        double num10 = (num5 + num5 + num7) / 2.0 - num8;
        double num11 = 2.0 * num8;
        double num12 = 2.0 * num8;
        Point2D.Double double1 = new Point2D.Double(num9 + num11 / 2.0, num10 + num12 / 2.0);
        Rectangle2D.Double double2 = new Rectangle2D.Double(num9, num10, num11, num12);
        for (int cat = 0; cat < catCount; ++cat)
        {
          double num13 = this.getStartAngle() + this.getDirection().getFactor() * (double) cat * 360.0 / (double) catCount;
          Point2D webPoint = this.getWebPoint((Rectangle2D) double2, num13, 1.0);
          Line2D.Double double3 = new Line2D.Double((Point2D) double1, webPoint);
          g2.setPaint(this.axisLinePaint);
          g2.setStroke(this.axisLineStroke);
          g2.draw((Shape) double3);
          this.drawLabel(g2, (Rectangle2D) double2, 0.0, cat, num13, 360.0 / (double) catCount);
        }
        for (int series = 0; series < num1; ++series)
          this.drawRadarPoly(g2, (Rectangle2D) double2, (Point2D) double1, info, series, catCount, headH, headW);
      }
      else
        this.drawNoDataMessage(g2, area);
      ((Graphics) g2).setClip(clip);
      g2.setComposite(composite);
      this.drawOutline(g2, area);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 107, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is SpiderWebPlot) || !base.equals(obj))
        return false;
      SpiderWebPlot spiderWebPlot = (SpiderWebPlot) obj;
      return this.dataExtractOrder.equals((object) spiderWebPlot.dataExtractOrder) && this.headPercent == spiderWebPlot.headPercent && (this.interiorGap == spiderWebPlot.interiorGap && this.startAngle == spiderWebPlot.startAngle) && (this.direction.equals((object) spiderWebPlot.direction) && this.maxValue == spiderWebPlot.maxValue && (this.webFilled == spiderWebPlot.webFilled && this.axisLabelGap == spiderWebPlot.axisLabelGap)) && (PaintUtilities.equal(this.axisLinePaint, spiderWebPlot.axisLinePaint) && Object.instancehelper_equals((object) this.axisLineStroke, (object) spiderWebPlot.axisLineStroke) && (ShapeUtilities.equal(this.legendItemShape, spiderWebPlot.legendItemShape) && PaintUtilities.equal(this.seriesPaint, spiderWebPlot.seriesPaint)) && (this.seriesPaintList.equals((object) spiderWebPlot.seriesPaintList) && PaintUtilities.equal(this.baseSeriesPaint, spiderWebPlot.baseSeriesPaint) && (PaintUtilities.equal(this.seriesOutlinePaint, spiderWebPlot.seriesOutlinePaint) && this.seriesOutlinePaintList.equals((object) spiderWebPlot.seriesOutlinePaintList)))) && (PaintUtilities.equal(this.baseSeriesOutlinePaint, spiderWebPlot.baseSeriesOutlinePaint) && ObjectUtilities.equal((object) this.seriesOutlineStroke, (object) spiderWebPlot.seriesOutlineStroke) && (this.seriesOutlineStrokeList.equals((object) spiderWebPlot.seriesOutlineStrokeList) && Object.instancehelper_equals((object) this.baseSeriesOutlineStroke, (object) spiderWebPlot.baseSeriesOutlineStroke)) && (this.labelFont.equals((object) spiderWebPlot.labelFont) && PaintUtilities.equal(this.labelPaint, spiderWebPlot.labelPaint) && (Object.instancehelper_equals((object) this.labelGenerator, (object) spiderWebPlot.labelGenerator) && ObjectUtilities.equal((object) this.toolTipGenerator, (object) spiderWebPlot.toolTipGenerator))) && ObjectUtilities.equal((object) this.urlGenerator, (object) spiderWebPlot.urlGenerator));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 211, (byte) 108, (byte) 113, (byte) 118, (byte) 150, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      SpiderWebPlot spiderWebPlot = (SpiderWebPlot) base.clone();
      spiderWebPlot.legendItemShape = ShapeUtilities.clone(this.legendItemShape);
      spiderWebPlot.seriesPaintList = (PaintList) this.seriesPaintList.clone();
      spiderWebPlot.seriesOutlinePaintList = (PaintList) this.seriesOutlinePaintList.clone();
      spiderWebPlot.seriesOutlineStrokeList = (StrokeList) this.seriesOutlineStrokeList.clone();
      return (object) spiderWebPlot;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 229, (byte) 134, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendItemShape, obj0);
      SerialUtilities.writePaint(this.seriesPaint, obj0);
      SerialUtilities.writePaint(this.baseSeriesPaint, obj0);
      SerialUtilities.writePaint(this.seriesOutlinePaint, obj0);
      SerialUtilities.writePaint(this.baseSeriesOutlinePaint, obj0);
      SerialUtilities.writeStroke(this.seriesOutlineStroke, obj0);
      SerialUtilities.writeStroke(this.baseSeriesOutlineStroke, obj0);
      SerialUtilities.writePaint(this.labelPaint, obj0);
      SerialUtilities.writePaint(this.axisLinePaint, obj0);
      SerialUtilities.writeStroke(this.axisLineStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 253, (byte) 134, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendItemShape = SerialUtilities.readShape(obj0);
      this.seriesPaint = SerialUtilities.readPaint(obj0);
      this.baseSeriesPaint = SerialUtilities.readPaint(obj0);
      this.seriesOutlinePaint = SerialUtilities.readPaint(obj0);
      this.baseSeriesOutlinePaint = SerialUtilities.readPaint(obj0);
      this.seriesOutlineStroke = SerialUtilities.readStroke(obj0);
      this.baseSeriesOutlineStroke = SerialUtilities.readStroke(obj0);
      this.labelPaint = SerialUtilities.readPaint(obj0);
      this.axisLinePaint = SerialUtilities.readPaint(obj0);
      this.axisLineStroke = SerialUtilities.readStroke(obj0);
      if (this.dataset == null)
        return;
      this.dataset.addChangeListener((DatasetChangeListener) this);
    }
  }
}
