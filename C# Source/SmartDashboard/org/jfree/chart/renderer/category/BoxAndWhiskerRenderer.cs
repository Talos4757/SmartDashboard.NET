// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.category.BoxAndWhiskerRenderer
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
using org.jfree.chart.plot;
using org.jfree.chart.renderer;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.data.statistics;
using org.jfree.io;
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
  public class BoxAndWhiskerRenderer : AbstractCategoryItemRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 632027470694481177L;
    [NonSerialized]
    private Paint artifactPaint;
    private bool fillBox;
    private double itemMargin;
    private double maximumBarWidth;
    private bool medianVisible;
    private bool meanVisible;

    [HideFromJava]
    static BoxAndWhiskerRenderer()
    {
      AbstractCategoryItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 104, (byte) 107, (byte) 103, (byte) 112, (byte) 108, (byte) 103, (byte) 103, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerRenderer()
    {
      BoxAndWhiskerRenderer andWhiskerRenderer = this;
      this.artifactPaint = (Paint) Color.black;
      this.fillBox = true;
      this.itemMargin = 0.2;
      this.maximumBarWidth = 1.0;
      this.medianVisible = true;
      this.meanVisible = true;
      this.setBaseLegendShape((Shape) new Rectangle2D.Double(-4.0, -4.0, 8.0, 8.0));
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BoxAndWhiskerRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BoxAndWhiskerRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BoxAndWhiskerRenderer obj0)
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

    public virtual double getMaximumBarWidth()
    {
      return this.maximumBarWidth;
    }

    public virtual double getItemMargin()
    {
      return this.itemMargin;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 174, (byte) 168, (byte) 153, (byte) 153, (byte) 138, (byte) 99, (byte) 104, (byte) 136, (byte) 101, (byte) 153, (byte) 214, (byte) 113, (byte) 118, (byte) 194, (byte) 117, (byte) 168, (byte) 112, (byte) 108, (byte) 136, (byte) 137, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 99, (byte) 156, (byte) 148, (byte) 148, (byte) 148, (byte) 148, (byte) 182, (byte) 115, (byte) 218, (byte) 115, (byte) 218, (byte) 159, (byte) 3, (byte) 104, (byte) 136, (byte) 112, (byte) 112, (byte) 200, (byte) 108, (byte) 102, (byte) 107, (byte) 108, (byte) 103, (byte) 148, (byte) 179, (byte) 154, (byte) 159, (byte) 10, (byte) 104, (byte) 232, (byte) 70, (byte) 104, (byte) 108, (byte) 100, (byte) 148, (byte) 250, (byte) 70, (byte) 108, (byte) 104, (byte) 100, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawHorizontalItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column)
    {
      BoxAndWhiskerCategoryDataset whiskerCategoryDataset = (BoxAndWhiskerCategoryDataset) dataset;
      double categoryEnd = domainAxis.getCategoryEnd(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double num1 = Math.abs(categoryEnd - categoryStart);
      double num2 = categoryStart;
      int rowCount = this.getRowCount();
      int columnCount = this.getColumnCount();
      double num3;
      if (rowCount > 1)
      {
        double num4 = ((RectangularShape) dataArea).getHeight() * this.getItemMargin() / (double) (columnCount * (rowCount - 1));
        double num5 = state.getBarWidth() * (double) rowCount + num4 * (double) (rowCount - 1);
        double num6 = (num1 - num5) / 2.0;
        num3 = num2 + num6 + (double) row * (state.getBarWidth() + num4);
      }
      else
      {
        double num4 = (num1 - state.getBarWidth()) / 2.0;
        num3 = num2 + num4;
      }
      g2.setPaint(this.getItemPaint(row, column));
      Stroke itemStroke = this.getItemStroke(row, column);
      g2.setStroke(itemStroke);
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      Number q1Value = whiskerCategoryDataset.getQ1Value(row, column);
      Number q3Value = whiskerCategoryDataset.getQ3Value(row, column);
      Number maxRegularValue = whiskerCategoryDataset.getMaxRegularValue(row, column);
      Number minRegularValue = whiskerCategoryDataset.getMinRegularValue(row, column);
      Rectangle2D.Double double1 = (Rectangle2D.Double) null;
      if (q1Value != null && q3Value != null && (maxRegularValue != null && minRegularValue != null))
      {
        double num4 = rangeAxis.valueToJava2D(q1Value.doubleValue(), dataArea, rangeAxisEdge);
        double num5 = rangeAxis.valueToJava2D(q3Value.doubleValue(), dataArea, rangeAxisEdge);
        double num6 = rangeAxis.valueToJava2D(maxRegularValue.doubleValue(), dataArea, rangeAxisEdge);
        double num7 = rangeAxis.valueToJava2D(minRegularValue.doubleValue(), dataArea, rangeAxisEdge);
        double num8 = num3 + state.getBarWidth() / 2.0;
        g2.draw((Shape) new Line2D.Double(num6, num8, num5, num8));
        g2.draw((Shape) new Line2D.Double(num6, num3, num6, num3 + state.getBarWidth()));
        g2.draw((Shape) new Line2D.Double(num7, num8, num4, num8));
        g2.draw((Shape) new Line2D.Double(num7, num3, num7, num3 + state.getBarWidth()));
        double1 = new Rectangle2D.Double(Math.min(num4, num5), num3, Math.abs(num4 - num5), state.getBarWidth());
        if (this.fillBox)
          g2.fill((Shape) double1);
        g2.setStroke(this.getItemOutlineStroke(row, column));
        g2.setPaint(this.getItemOutlinePaint(row, column));
        g2.draw((Shape) double1);
      }
      g2.setPaint(this.artifactPaint);
      if (this.meanVisible)
      {
        Number meanValue = whiskerCategoryDataset.getMeanValue(row, column);
        if (meanValue != null)
        {
          double num4 = rangeAxis.valueToJava2D(meanValue.doubleValue(), dataArea, rangeAxisEdge);
          double num5 = state.getBarWidth() / 4.0;
          if (num4 > ((RectangularShape) dataArea).getMinX() - num5 && num4 < ((RectangularShape) dataArea).getMaxX() + num5)
          {
            Ellipse2D.Double double2 = new Ellipse2D.Double(num4 - num5, num3 + num5, num5 * 2.0, num5 * 2.0);
            g2.fill((Shape) double2);
            g2.draw((Shape) double2);
          }
        }
      }
      if (this.medianVisible)
      {
        Number medianValue = whiskerCategoryDataset.getMedianValue(row, column);
        if (medianValue != null)
        {
          double num4 = rangeAxis.valueToJava2D(medianValue.doubleValue(), dataArea, rangeAxisEdge);
          g2.draw((Shape) new Line2D.Double(num4, num3, num4, num3 + state.getBarWidth()));
        }
      }
      if (state.getInfo() == null || double1 == null)
        return;
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) double1);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 61, (byte) 168, (byte) 153, (byte) 153, (byte) 133, (byte) 99, (byte) 104, (byte) 136, (byte) 101, (byte) 153, (byte) 214, (byte) 113, (byte) 118, (byte) 194, (byte) 117, (byte) 168, (byte) 166, (byte) 108, (byte) 104, (byte) 108, (byte) 136, (byte) 135, (byte) 137, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 99, (byte) 156, (byte) 148, (byte) 148, (byte) 148, (byte) 148, (byte) 182, (byte) 115, (byte) 218, (byte) 115, (byte) 218, (byte) 159, (byte) 3, (byte) 104, (byte) 136, (byte) 112, (byte) 112, (byte) 168, (byte) 172, (byte) 107, (byte) 108, (byte) 103, (byte) 148, (byte) 179, (byte) 154, (byte) 191, (byte) 10, (byte) 104, (byte) 232, (byte) 70, (byte) 104, (byte) 108, (byte) 100, (byte) 148, (byte) 250, (byte) 70, (byte) 151, (byte) 183, (byte) 168, (byte) 115, (byte) 103, (byte) 231, (byte) 70, (byte) 108, (byte) 103, (byte) 113, (byte) 118, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 107, (byte) 141, (byte) 107, (byte) 141, (byte) 107, (byte) 143, (byte) 191, (byte) 7, (byte) 107, (byte) 143, (byte) 191, (byte) 5, (byte) 231, (byte) 40, (byte) 235, (byte) 93, (byte) 114, (byte) 110, (byte) 106, (byte) 130, (byte) 105, (byte) 105, (byte) 110, (byte) 105, (byte) 137, (byte) 105, (byte) 211, (byte) 139, (byte) 162, (byte) 105, (byte) 223, (byte) 9, (byte) 105, (byte) 255, (byte) 9, (byte) 69, (byte) 108, (byte) 104, (byte) 100, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawVerticalItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column)
    {
      BoxAndWhiskerCategoryDataset whiskerCategoryDataset = (BoxAndWhiskerCategoryDataset) dataset;
      double categoryEnd = domainAxis.getCategoryEnd(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double categoryStart = domainAxis.getCategoryStart(column, this.getColumnCount(), dataArea, plot.getDomainAxisEdge());
      double num1 = categoryEnd - categoryStart;
      double num2 = categoryStart;
      int rowCount = this.getRowCount();
      int columnCount = this.getColumnCount();
      double num3;
      if (rowCount > 1)
      {
        double num4 = ((RectangularShape) dataArea).getWidth() * this.getItemMargin() / (double) (columnCount * (rowCount - 1));
        double num5 = state.getBarWidth() * (double) rowCount + num4 * (double) (rowCount - 1);
        double num6 = (num1 - num5) / 2.0;
        num3 = num2 + num6 + (double) row * (state.getBarWidth() + num4);
      }
      else
      {
        double num4 = (num1 - state.getBarWidth()) / 2.0;
        num3 = num2 + num4;
      }
      Paint itemPaint = this.getItemPaint(row, column);
      g2.setPaint(itemPaint);
      Stroke itemStroke = this.getItemStroke(row, column);
      g2.setStroke(itemStroke);
      double num7 = 0.0;
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      Number q1Value = whiskerCategoryDataset.getQ1Value(row, column);
      Number q3Value = whiskerCategoryDataset.getQ3Value(row, column);
      Number maxRegularValue1 = whiskerCategoryDataset.getMaxRegularValue(row, column);
      Number minRegularValue1 = whiskerCategoryDataset.getMinRegularValue(row, column);
      Rectangle2D.Double double1 = (Rectangle2D.Double) null;
      if (q1Value != null && q3Value != null && (maxRegularValue1 != null && minRegularValue1 != null))
      {
        double num4 = rangeAxis.valueToJava2D(q1Value.doubleValue(), dataArea, rangeAxisEdge);
        double num5 = rangeAxis.valueToJava2D(q3Value.doubleValue(), dataArea, rangeAxisEdge);
        double num6 = rangeAxis.valueToJava2D(maxRegularValue1.doubleValue(), dataArea, rangeAxisEdge);
        double num8 = rangeAxis.valueToJava2D(minRegularValue1.doubleValue(), dataArea, rangeAxisEdge);
        double num9 = num3 + state.getBarWidth() / 2.0;
        g2.draw((Shape) new Line2D.Double(num9, num6, num9, num5));
        g2.draw((Shape) new Line2D.Double(num3, num6, num3 + state.getBarWidth(), num6));
        g2.draw((Shape) new Line2D.Double(num9, num8, num9, num4));
        g2.draw((Shape) new Line2D.Double(num3, num8, num3 + state.getBarWidth(), num8));
        double1 = new Rectangle2D.Double(num3, Math.min(num4, num5), state.getBarWidth(), Math.abs(num4 - num5));
        if (this.fillBox)
          g2.fill((Shape) double1);
        g2.setStroke(this.getItemOutlineStroke(row, column));
        g2.setPaint(this.getItemOutlinePaint(row, column));
        g2.draw((Shape) double1);
      }
      g2.setPaint(this.artifactPaint);
      if (this.meanVisible)
      {
        Number meanValue = whiskerCategoryDataset.getMeanValue(row, column);
        if (meanValue != null)
        {
          double num4 = rangeAxis.valueToJava2D(meanValue.doubleValue(), dataArea, rangeAxisEdge);
          num7 = state.getBarWidth() / 4.0;
          if (num4 > ((RectangularShape) dataArea).getMinY() - num7 && num4 < ((RectangularShape) dataArea).getMaxY() + num7)
          {
            Ellipse2D.Double double2 = new Ellipse2D.Double(num3 + num7, num4 - num7, num7 * 2.0, num7 * 2.0);
            g2.fill((Shape) double2);
            g2.draw((Shape) double2);
          }
        }
      }
      if (this.medianVisible)
      {
        Number medianValue = whiskerCategoryDataset.getMedianValue(row, column);
        if (medianValue != null)
        {
          double num4 = rangeAxis.valueToJava2D(medianValue.doubleValue(), dataArea, rangeAxisEdge);
          g2.draw((Shape) new Line2D.Double(num3, num4, num3 + state.getBarWidth(), num4));
        }
      }
      double num10 = rangeAxis.valueToJava2D(rangeAxis.getUpperBound(), dataArea, rangeAxisEdge) + num7;
      double num11 = rangeAxis.valueToJava2D(rangeAxis.getLowerBound(), dataArea, rangeAxisEdge) - num7;
      g2.setPaint(itemPaint);
      double radius = state.getBarWidth() / 3.0;
      ArrayList arrayList = new ArrayList();
      OutlierListCollection outlierListCollection = new OutlierListCollection();
      List outliers = whiskerCategoryDataset.getOutliers(row, column);
      if (outliers != null)
      {
        for (int index = 0; index < outliers.size(); ++index)
        {
          double d = ((Number) outliers.get(index)).doubleValue();
          Number minOutlier = whiskerCategoryDataset.getMinOutlier(row, column);
          Number maxOutlier = whiskerCategoryDataset.getMaxOutlier(row, column);
          Number minRegularValue2 = whiskerCategoryDataset.getMinRegularValue(row, column);
          Number maxRegularValue2 = whiskerCategoryDataset.getMaxRegularValue(row, column);
          if (d > maxOutlier.doubleValue())
            outlierListCollection.setHighFarOut(true);
          else if (d < minOutlier.doubleValue())
            outlierListCollection.setLowFarOut(true);
          else if (d > maxRegularValue2.doubleValue())
          {
            double yCoord = rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
            ((List) arrayList).add((object) new Outlier(num3 + state.getBarWidth() / 2.0, yCoord, radius));
          }
          else if (d < minRegularValue2.doubleValue())
          {
            double yCoord = rangeAxis.valueToJava2D(d, dataArea, rangeAxisEdge);
            ((List) arrayList).add((object) new Outlier(num3 + state.getBarWidth() / 2.0, yCoord, radius));
          }
          Collections.sort((List) arrayList);
        }
        Iterator iterator1 = ((List) arrayList).iterator();
        while (iterator1.hasNext())
        {
          Outlier outlier = (Outlier) iterator1.next();
          outlierListCollection.add(outlier);
        }
        Iterator iterator2 = outlierListCollection.iterator();
        while (iterator2.hasNext())
        {
          OutlierList outlierList = (OutlierList) iterator2.next();
          Point2D point = outlierList.getAveragedOutlier().getPoint();
          if (outlierList.isMultiple())
            this.drawMultipleEllipse(point, state.getBarWidth(), radius, g2);
          else
            this.drawEllipse(point, radius, g2);
        }
        if (outlierListCollection.isHighFarOut())
          this.drawHighFarOut(num7 / 2.0, g2, num3 + state.getBarWidth() / 2.0, num10);
        if (outlierListCollection.isLowFarOut())
          this.drawLowFarOut(num7 / 2.0, g2, num3 + state.getBarWidth() / 2.0, num11);
      }
      if (state.getInfo() == null || double1 == null)
        return;
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addItemEntity(entityCollection, dataset, row, column, (Shape) double1);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 31, (byte) 159, (byte) 7, (byte) 159, (byte) 4, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawMultipleEllipse([In] Point2D obj0, [In] double obj1, [In] double obj2, [In] Graphics2D obj3)
    {
      Ellipse2D.Double double1 = new Ellipse2D.Double(obj0.getX() - obj1 / 2.0 + obj2, obj0.getY(), obj2, obj2);
      Ellipse2D.Double double2 = new Ellipse2D.Double(obj0.getX() + obj1 / 2.0, obj0.getY(), obj2, obj2);
      obj3.draw((Shape) double1);
      obj3.draw((Shape) double2);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 15, (byte) 159, (byte) 4, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawEllipse([In] Point2D obj0, [In] double obj1, [In] Graphics2D obj2)
    {
      Ellipse2D.Double @double = new Ellipse2D.Double(obj0.getX() + obj1 / 2.0, obj0.getY(), obj1, obj1);
      obj2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 49, (byte) 110, (byte) 125, (byte) 121, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawHighFarOut([In] double obj0, [In] Graphics2D obj1, [In] double obj2, [In] double obj3)
    {
      double num = obj0 * 2.0;
      obj1.draw((Shape) new Line2D.Double(obj2 - num, obj3 + num, obj2 + num, obj3 + num));
      obj1.draw((Shape) new Line2D.Double(obj2 - num, obj3 + num, obj2, obj3));
      obj1.draw((Shape) new Line2D.Double(obj2 + num, obj3 + num, obj2, obj3));
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 65, (byte) 110, (byte) 125, (byte) 121, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawLowFarOut([In] double obj0, [In] Graphics2D obj1, [In] double obj2, [In] double obj3)
    {
      double num = obj0 * 2.0;
      obj1.draw((Shape) new Line2D.Double(obj2 - num, obj3 - num, obj2 + num, obj3 - num));
      obj1.draw((Shape) new Line2D.Double(obj2 - num, obj3 - num, obj2, obj3));
      obj1.draw((Shape) new Line2D.Double(obj2 + num, obj3 - num, obj2, obj3));
    }

    public virtual Paint getArtifactPaint()
    {
      return this.artifactPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    public virtual bool getFillBox()
    {
      return this.fillBox;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 86, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillBox(bool flag)
    {
      this.fillBox = flag;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemMargin(double margin)
    {
      this.itemMargin = margin;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumBarWidth(double percent)
    {
      this.maximumBarWidth = percent;
      this.fireChangeEvent();
    }

    public virtual bool isMeanVisible()
    {
      return this.meanVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 65, (byte) 98, (byte) 105, (byte) 129, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMeanVisible(bool visible)
    {
      int num = visible ? 1 : 0;
      if ((this.meanVisible ? 1 : 0) == num)
        return;
      this.meanVisible = num != 0;
      this.fireChangeEvent();
    }

    public virtual bool isMedianVisible()
    {
      return this.medianVisible;
    }

    public virtual void setMedianVisible(bool visible)
    {
      this.medianVisible = visible;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 103, (byte) 99, (byte) 194, (byte) 114, (byte) 162, (byte) 104, (byte) 142, (byte) 98, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 149, (byte) 110, (byte) 105, (byte) 100, (byte) 137, (byte) 104, (byte) 104, (byte) 110, (byte) 104})]
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

    [LineNumberTable((ushort) 407)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(CategoryDataset dataset)
    {
      return base.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 174, (byte) 106, (byte) 105, (byte) 102, (byte) 103, (byte) 104, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 105, (byte) 137, (byte) 108, (byte) 103, (byte) 103, (byte) 100, (byte) 137, (byte) 101, (byte) 137, (byte) 191, (byte) 0, (byte) 103, (byte) 223, (byte) 1, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override CategoryItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, CategoryPlot plot, int rendererIndex, PlotRenderingInfo info)
    {
      CategoryItemRendererState itemRendererState = base.initialise(g2, dataArea, plot, rendererIndex, info);
      CategoryAxis domainAxis = this.getDomainAxis(plot, rendererIndex);
      CategoryDataset dataset = plot.getDataset(rendererIndex);
      if (dataset != null)
      {
        int columnCount = dataset.getColumnCount();
        int rowCount = dataset.getRowCount();
        double num1 = 0.0;
        PlotOrientation orientation = plot.getOrientation();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          num1 = ((RectangularShape) dataArea).getHeight();
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          num1 = ((RectangularShape) dataArea).getWidth();
        double num2 = num1 * this.getMaximumBarWidth();
        double num3 = 0.0;
        double num4 = 0.0;
        if (columnCount > 1)
          num3 = domainAxis.getCategoryMargin();
        if (rowCount > 1)
          num4 = this.getItemMargin();
        double num5 = num1 * (1.0 - domainAxis.getLowerMargin() - domainAxis.getUpperMargin() - num3 - num4);
        if (rowCount * columnCount > 0)
          itemRendererState.setBarWidth(Math.min(num5 / (double) (dataset.getColumnCount() * dataset.getRowCount()), num2));
        else
          itemRendererState.setBarWidth(Math.min(num5, num2));
      }
      return itemRendererState;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 125, (byte) 108, (byte) 161, (byte) 105, (byte) 240, (byte) 69, (byte) 136, (byte) 104, (byte) 183, (byte) 104, (byte) 215})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, CategoryItemRendererState state, Rectangle2D dataArea, CategoryPlot plot, CategoryAxis domainAxis, ValueAxis rangeAxis, CategoryDataset dataset, int row, int column, int pass)
    {
      if (!this.getItemVisible(row, column))
        return;
      if (!(dataset is BoxAndWhiskerCategoryDataset))
      {
        string str = "BoxAndWhiskerRenderer.drawItem() : the data should be of type BoxAndWhiskerCategoryDataset only.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        PlotOrientation orientation = plot.getOrientation();
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          this.drawHorizontalItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, row, column);
        }
        else
        {
          if (orientation != PlotOrientation.__\u003C\u003EVERTICAL)
            return;
          this.drawVerticalItem(g2, state, dataArea, plot, domainAxis, rangeAxis, dataset, row, column);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 79, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BoxAndWhiskerRenderer))
        return false;
      BoxAndWhiskerRenderer andWhiskerRenderer = (BoxAndWhiskerRenderer) obj;
      if (this.fillBox != andWhiskerRenderer.fillBox || this.itemMargin != andWhiskerRenderer.itemMargin || (this.maximumBarWidth != andWhiskerRenderer.maximumBarWidth || this.meanVisible != andWhiskerRenderer.meanVisible) || (this.medianVisible != andWhiskerRenderer.medianVisible || !PaintUtilities.equal(this.artifactPaint, andWhiskerRenderer.artifactPaint)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 115, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.artifactPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 129, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.artifactPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
