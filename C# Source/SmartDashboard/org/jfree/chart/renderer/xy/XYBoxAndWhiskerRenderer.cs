// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYBoxAndWhiskerRenderer
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
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.data;
using org.jfree.data.statistics;
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
  public class XYBoxAndWhiskerRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -8020170108532232324L;
    private double boxWidth;
    [NonSerialized]
    private Paint boxPaint;
    private bool fillBox;
    [NonSerialized]
    private Paint artifactPaint;

    [HideFromJava]
    static XYBoxAndWhiskerRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 232, (byte) 46, (byte) 235, (byte) 83, (byte) 105, (byte) 107, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBoxAndWhiskerRenderer(double boxWidth)
    {
      XYBoxAndWhiskerRenderer andWhiskerRenderer = this;
      this.artifactPaint = (Paint) Color.black;
      this.boxWidth = boxWidth;
      this.boxPaint = (Paint) Color.green;
      this.fillBox = true;
      this.setBaseToolTipGenerator((XYToolTipGenerator) new BoxAndWhiskerXYToolTipGenerator());
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBoxAndWhiskerRenderer()
      : this(-1.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYBoxAndWhiskerRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYBoxAndWhiskerRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYBoxAndWhiskerRenderer obj0)
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

    public virtual Paint getBoxPaint()
    {
      return this.boxPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 98, (byte) 99, (byte) 172, (byte) 168, (byte) 107, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 184, (byte) 105, (byte) 147, (byte) 148, (byte) 148, (byte) 103, (byte) 100, (byte) 180, (byte) 148, (byte) 180, (byte) 105, (byte) 100, (byte) 105, (byte) 107, (byte) 104, (byte) 105, (byte) 106, (byte) 125, (byte) 109, (byte) 141, (byte) 102, (byte) 166, (byte) 196, (byte) 112, (byte) 108, (byte) 168, (byte) 115, (byte) 223, (byte) 14, (byte) 115, (byte) 223, (byte) 14, (byte) 98, (byte) 102, (byte) 223, (byte) 2, (byte) 191, (byte) 0, (byte) 104, (byte) 112, (byte) 136, (byte) 112, (byte) 112, (byte) 168, (byte) 108, (byte) 223, (byte) 14, (byte) 103, (byte) 175, (byte) 154, (byte) 191, (byte) 10, (byte) 104, (byte) 232, (byte) 71, (byte) 109, (byte) 181})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawHorizontalItem(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      BoxAndWhiskerXYDataset whiskerXyDataset = (BoxAndWhiskerXYDataset) dataset;
      Number x = whiskerXyDataset.getX(series, item);
      Number maxRegularValue = whiskerXyDataset.getMaxRegularValue(series, item);
      Number minRegularValue = whiskerXyDataset.getMinRegularValue(series, item);
      Number medianValue = whiskerXyDataset.getMedianValue(series, item);
      Number meanValue = whiskerXyDataset.getMeanValue(series, item);
      Number q1Value = whiskerXyDataset.getQ1Value(series, item);
      Number q3Value = whiskerXyDataset.getQ3Value(series, item);
      double entityY = domainAxis.valueToJava2D(x.doubleValue(), dataArea, plot.getDomainAxisEdge());
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = rangeAxis.valueToJava2D(maxRegularValue.doubleValue(), dataArea, rangeAxisEdge);
      double num2 = rangeAxis.valueToJava2D(minRegularValue.doubleValue(), dataArea, rangeAxisEdge);
      double num3 = rangeAxis.valueToJava2D(medianValue.doubleValue(), dataArea, rangeAxisEdge);
      double entityX = 0.0;
      if (meanValue != null)
        entityX = rangeAxis.valueToJava2D(meanValue.doubleValue(), dataArea, rangeAxisEdge);
      double num4 = rangeAxis.valueToJava2D(q1Value.doubleValue(), dataArea, rangeAxisEdge);
      double num5 = rangeAxis.valueToJava2D(q3Value.doubleValue(), dataArea, rangeAxisEdge);
      double boxWidth = this.getBoxWidth();
      double num6 = boxWidth;
      double height = ((RectangularShape) dataArea).getHeight();
      double num7 = 0.1;
      double num8 = height * num7;
      if (boxWidth <= 0.0)
      {
        int itemCount = whiskerXyDataset.getItemCount(series);
        double num9 = height / (double) itemCount * 4.5 / 7.0;
        num6 = num9 >= 3.0 ? (num9 <= num8 ? num9 : num8) : 3.0;
      }
      g2.setPaint(this.getItemPaint(series, item));
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setStroke(itemStroke);
      g2.draw((Shape) new Line2D.Double(num1, entityY, num5, entityY));
      g2.draw((Shape) new Line2D.Double(num1, entityY - num6 / 2.0, num1, entityY + num6 / 2.0));
      g2.draw((Shape) new Line2D.Double(num2, entityY, num4, entityY));
      g2.draw((Shape) new Line2D.Double(num2, entityY - num6 / 2.0, num2, entityY + num6 / 2.0));
      Rectangle2D.Double double1 = num4 >= num5 ? new Rectangle2D.Double(num5, entityY - num6 / 2.0, num4 - num5, num6) : new Rectangle2D.Double(num4, entityY - num6 / 2.0, num5 - num4, num6);
      if (this.fillBox)
      {
        g2.setPaint(this.lookupBoxPaint(series, item));
        g2.fill((Shape) double1);
      }
      g2.setStroke(this.getItemOutlineStroke(series, item));
      g2.setPaint(this.getItemOutlinePaint(series, item));
      g2.draw((Shape) double1);
      g2.setPaint(this.getArtifactPaint());
      g2.draw((Shape) new Line2D.Double(num3, entityY - num6 / 2.0, num3, entityY + num6 / 2.0));
      if (meanValue != null)
      {
        double num9 = num6 / 4.0;
        if (entityX > ((RectangularShape) dataArea).getMinX() - num9 && entityX < ((RectangularShape) dataArea).getMaxX() + num9)
        {
          Ellipse2D.Double double2 = new Ellipse2D.Double(entityX - num9, entityY - num9, num9 * 2.0, num9 * 2.0);
          g2.fill((Shape) double2);
          g2.draw((Shape) double2);
        }
      }
      if (entities == null || !((Shape) double1).intersects(dataArea))
        return;
      this.addEntity(entities, (Shape) double1, dataset, series, item, entityX, entityY);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 170, (byte) 98, (byte) 99, (byte) 172, (byte) 168, (byte) 107, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 184, (byte) 105, (byte) 147, (byte) 148, (byte) 148, (byte) 103, (byte) 100, (byte) 180, (byte) 148, (byte) 244, (byte) 69, (byte) 105, (byte) 100, (byte) 112, (byte) 107, (byte) 104, (byte) 105, (byte) 106, (byte) 125, (byte) 109, (byte) 141, (byte) 102, (byte) 166, (byte) 196, (byte) 112, (byte) 108, (byte) 168, (byte) 115, (byte) 223, (byte) 14, (byte) 115, (byte) 223, (byte) 14, (byte) 98, (byte) 102, (byte) 223, (byte) 2, (byte) 191, (byte) 0, (byte) 104, (byte) 112, (byte) 136, (byte) 112, (byte) 112, (byte) 168, (byte) 108, (byte) 191, (byte) 14, (byte) 103, (byte) 175, (byte) 103, (byte) 175, (byte) 154, (byte) 159, (byte) 10, (byte) 104, (byte) 200, (byte) 103, (byte) 231, (byte) 72, (byte) 113, (byte) 118, (byte) 147, (byte) 141, (byte) 147, (byte) 141, (byte) 147, (byte) 143, (byte) 149, (byte) 147, (byte) 143, (byte) 147, (byte) 231, (byte) 42, (byte) 235, (byte) 91, (byte) 114, (byte) 110, (byte) 106, (byte) 162, (byte) 151, (byte) 215, (byte) 105, (byte) 105, (byte) 110, (byte) 105, (byte) 137, (byte) 105, (byte) 175, (byte) 139, (byte) 162, (byte) 105, (byte) 173, (byte) 105, (byte) 205, (byte) 109, (byte) 181})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawVerticalItem(Graphics2D g2, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      BoxAndWhiskerXYDataset whiskerXyDataset = (BoxAndWhiskerXYDataset) dataset;
      Number x = whiskerXyDataset.getX(series, item);
      Number maxRegularValue = whiskerXyDataset.getMaxRegularValue(series, item);
      Number minRegularValue = whiskerXyDataset.getMinRegularValue(series, item);
      Number medianValue = whiskerXyDataset.getMedianValue(series, item);
      Number meanValue = whiskerXyDataset.getMeanValue(series, item);
      Number q1Value = whiskerXyDataset.getQ1Value(series, item);
      Number q3Value = whiskerXyDataset.getQ3Value(series, item);
      List outliers = whiskerXyDataset.getOutliers(series, item);
      double num1 = domainAxis.valueToJava2D(x.doubleValue(), dataArea, plot.getDomainAxisEdge());
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num2 = rangeAxis.valueToJava2D(maxRegularValue.doubleValue(), dataArea, rangeAxisEdge);
      double num3 = rangeAxis.valueToJava2D(minRegularValue.doubleValue(), dataArea, rangeAxisEdge);
      double num4 = rangeAxis.valueToJava2D(medianValue.doubleValue(), dataArea, rangeAxisEdge);
      double entityY = 0.0;
      if (meanValue != null)
        entityY = rangeAxis.valueToJava2D(meanValue.doubleValue(), dataArea, rangeAxisEdge);
      double num5 = rangeAxis.valueToJava2D(q1Value.doubleValue(), dataArea, rangeAxisEdge);
      double num6 = rangeAxis.valueToJava2D(q3Value.doubleValue(), dataArea, rangeAxisEdge);
      double boxWidth1 = this.getBoxWidth();
      double boxWidth2 = boxWidth1;
      double num7 = ((RectangularShape) dataArea).getMaxX() - ((RectangularShape) dataArea).getMinX();
      double num8 = 0.1;
      double num9 = num7 * num8;
      if (boxWidth1 <= 0.0)
      {
        int itemCount = whiskerXyDataset.getItemCount(series);
        double num10 = num7 / (double) itemCount * 4.5 / 7.0;
        boxWidth2 = num10 >= 3.0 ? (num10 <= num9 ? num10 : num9) : 3.0;
      }
      g2.setPaint(this.getItemPaint(series, item));
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setStroke(itemStroke);
      g2.draw((Shape) new Line2D.Double(num1, num2, num1, num6));
      g2.draw((Shape) new Line2D.Double(num1 - boxWidth2 / 2.0, num2, num1 + boxWidth2 / 2.0, num2));
      g2.draw((Shape) new Line2D.Double(num1, num3, num1, num5));
      g2.draw((Shape) new Line2D.Double(num1 - boxWidth2 / 2.0, num3, num1 + boxWidth2 / 2.0, num3));
      Rectangle2D.Double double1 = num5 <= num6 ? new Rectangle2D.Double(num1 - boxWidth2 / 2.0, num5, boxWidth2, num6 - num5) : new Rectangle2D.Double(num1 - boxWidth2 / 2.0, num6, boxWidth2, num5 - num6);
      if (this.fillBox)
      {
        g2.setPaint(this.lookupBoxPaint(series, item));
        g2.fill((Shape) double1);
      }
      g2.setStroke(this.getItemOutlineStroke(series, item));
      g2.setPaint(this.getItemOutlinePaint(series, item));
      g2.draw((Shape) double1);
      g2.setPaint(this.getArtifactPaint());
      g2.draw((Shape) new Line2D.Double(num1 - boxWidth2 / 2.0, num4, num1 + boxWidth2 / 2.0, num4));
      double aRadius = 0.0;
      double num11 = boxWidth2 / 3.0;
      if (meanValue != null)
      {
        aRadius = boxWidth2 / 4.0;
        if (entityY > ((RectangularShape) dataArea).getMinY() - aRadius && entityY < ((RectangularShape) dataArea).getMaxY() + aRadius)
        {
          Ellipse2D.Double double2 = new Ellipse2D.Double(num1 - aRadius, entityY - aRadius, aRadius * 2.0, aRadius * 2.0);
          g2.fill((Shape) double2);
          g2.draw((Shape) double2);
        }
      }
      ArrayList arrayList = new ArrayList();
      OutlierListCollection outlierListCollection = new OutlierListCollection();
      for (int index = 0; index < outliers.size(); ++index)
      {
        double d = ((Number) outliers.get(index)).doubleValue();
        if (d > whiskerXyDataset.getMaxOutlier(series, item).doubleValue())
          outlierListCollection.setHighFarOut(true);
        else if (d < whiskerXyDataset.getMinOutlier(series, item).doubleValue())
          outlierListCollection.setLowFarOut(true);
        else if (d > whiskerXyDataset.getMaxRegularValue(series, item).doubleValue())
        {
          double yCoord = rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          ((List) arrayList).add((object) new Outlier(num1, yCoord, num11));
        }
        else if (d < whiskerXyDataset.getMinRegularValue(series, item).doubleValue())
        {
          double yCoord = rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
          ((List) arrayList).add((object) new Outlier(num1, yCoord, num11));
        }
        Collections.sort((List) arrayList);
      }
      Iterator iterator1 = ((List) arrayList).iterator();
      while (iterator1.hasNext())
      {
        Outlier outlier = (Outlier) iterator1.next();
        outlierListCollection.add(outlier);
      }
      double m1 = rangeAxis.valueToJava2D(rangeAxis.getUpperBound(), dataArea, rangeAxisEdge) + aRadius;
      double m2 = rangeAxis.valueToJava2D(rangeAxis.getLowerBound(), dataArea, rangeAxisEdge) - aRadius;
      Iterator iterator2 = outlierListCollection.iterator();
      while (iterator2.hasNext())
      {
        OutlierList outlierList = (OutlierList) iterator2.next();
        Point2D point = outlierList.getAveragedOutlier().getPoint();
        if (outlierList.isMultiple())
          this.drawMultipleEllipse(point, boxWidth2, num11, g2);
        else
          this.drawEllipse(point, num11, g2);
      }
      if (outlierListCollection.isHighFarOut())
        this.drawHighFarOut(aRadius, g2, num1, m1);
      if (outlierListCollection.isLowFarOut())
        this.drawLowFarOut(aRadius, g2, num1, m2);
      if (entities == null || !((Shape) double1).intersects(dataArea))
        return;
      this.addEntity(entities, (Shape) double1, dataset, series, item, num1, entityY);
    }

    public virtual double getBoxWidth()
    {
      return this.boxWidth;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 103, (byte) 99, (byte) 226, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Paint lookupBoxPaint(int series, int item)
    {
      Paint boxPaint = this.getBoxPaint();
      if (boxPaint != null)
        return boxPaint;
      return this.getItemPaint(series, item);
    }

    public virtual Paint getArtifactPaint()
    {
      return this.artifactPaint;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 128, (byte) 159, (byte) 7, (byte) 159, (byte) 4, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawMultipleEllipse(Point2D point, double boxWidth, double oRadius, Graphics2D g2)
    {
      Ellipse2D.Double double1 = new Ellipse2D.Double(point.getX() - boxWidth / 2.0 + oRadius, point.getY(), oRadius, oRadius);
      Ellipse2D.Double double2 = new Ellipse2D.Double(point.getX() + boxWidth / 2.0, point.getY(), oRadius, oRadius);
      g2.draw((Shape) double1);
      g2.draw((Shape) double2);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 112, (byte) 159, (byte) 4, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawEllipse(Point2D point, double oRadius, Graphics2D g2)
    {
      Ellipse2D.Double @double = new Ellipse2D.Double(point.getX() + oRadius / 2.0, point.getY(), oRadius, oRadius);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 147, (byte) 110, (byte) 125, (byte) 121, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHighFarOut(double aRadius, Graphics2D g2, double xx, double m)
    {
      double num = aRadius * 2.0;
      g2.draw((Shape) new Line2D.Double(xx - num, m + num, xx + num, m + num));
      g2.draw((Shape) new Line2D.Double(xx - num, m + num, xx, m));
      g2.draw((Shape) new Line2D.Double(xx + num, m + num, xx, m));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 163, (byte) 110, (byte) 125, (byte) 121, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawLowFarOut(double aRadius, Graphics2D g2, double xx, double m)
    {
      double num = aRadius * 2.0;
      g2.draw((Shape) new Line2D.Double(xx - num, m - num, xx + num, m - num));
      g2.draw((Shape) new Line2D.Double(xx - num, m - num, xx, m));
      g2.draw((Shape) new Line2D.Double(xx + num, m - num, xx, m));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 106, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBoxWidth(double width)
    {
      if (width == this.boxWidth)
        return;
      this.boxWidth = width;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBoxPaint(Paint paint)
    {
      this.boxPaint = paint;
      this.fireChangeEvent();
    }

    public virtual bool getFillBox()
    {
      return this.fillBox;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 81, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillBox(bool flag)
    {
      this.fillBox = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setArtifactPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.artifactPaint = paint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable((ushort) 290)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      return this.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 235, (byte) 136, (byte) 104, (byte) 188, (byte) 104, (byte) 220})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        this.drawHorizontalItem(g2, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState, pass);
      }
      else
      {
        if (orientation != PlotOrientation.__\u003C\u003EVERTICAL)
          return;
        this.drawVerticalItem(g2, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState, pass);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 177, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYBoxAndWhiskerRenderer) || !base.equals(obj))
        return false;
      XYBoxAndWhiskerRenderer andWhiskerRenderer = (XYBoxAndWhiskerRenderer) obj;
      return this.boxWidth == andWhiskerRenderer.getBoxWidth() && PaintUtilities.equal(this.boxPaint, andWhiskerRenderer.boxPaint) && (PaintUtilities.equal(this.artifactPaint, andWhiskerRenderer.artifactPaint) && this.fillBox == andWhiskerRenderer.fillBox);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 211, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.boxPaint, obj0);
      SerialUtilities.writePaint(this.artifactPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 227, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.boxPaint = SerialUtilities.readPaint(obj0);
      this.artifactPaint = SerialUtilities.readPaint(obj0);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 866)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
