// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.StackedXYAreaRenderer
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
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StackedXYAreaRenderer : XYAreaRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 5217394318178570889L;
    [NonSerialized]
    private Paint shapePaint;
    [NonSerialized]
    private Stroke shapeStroke;

    [HideFromJava]
    static StackedXYAreaRenderer()
    {
      XYAreaRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYAreaRenderer(int type)
      : this(type, (XYToolTipGenerator) null, (XYURLGenerator) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 235, (byte) 25, (byte) 231, (byte) 70, (byte) 231, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYAreaRenderer(int type, XYToolTipGenerator labelGenerator, XYURLGenerator urlGenerator)
      : base(type, labelGenerator, urlGenerator)
    {
      StackedXYAreaRenderer stackedXyAreaRenderer = this;
      this.shapePaint = (Paint) null;
      this.shapeStroke = (Stroke) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackedXYAreaRenderer()
      : this(4)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackedXYAreaRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StackedXYAreaRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StackedXYAreaRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 161, (byte) 254, (byte) 102, (byte) 102, (byte) 106, (byte) 104, (byte) 229, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double getPreviousHeight(TableXYDataset dataset, int series, int index)
    {
      double num = 0.0;
      for (int i1 = 0; i1 < series; ++i1)
      {
        double yvalue = dataset.getYValue(i1, index);
        if (!Double.isNaN(yvalue))
          num += yvalue;
      }
      return num;
    }

    public virtual Paint getShapePaint()
    {
      return this.shapePaint;
    }

    public virtual Stroke getShapeStroke()
    {
      return this.shapeStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapePaint(Paint shapePaint)
    {
      this.shapePaint = shapePaint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setShapeStroke(Stroke shapeStroke)
    {
      this.shapeStroke = shapeStroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 222, (byte) 168, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      StackedXYAreaRenderer.StackedXYAreaRendererState areaRendererState = new StackedXYAreaRenderer.StackedXYAreaRendererState(info);
      areaRendererState.setProcessVisibleItemsOnly(false);
      return (XYItemRendererState) areaRendererState;
    }

    public override int getPassCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 99, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      return DatasetUtilities.findStackedRangeBounds((TableXYDataset) dataset);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 104, (byte) 199, (byte) 104, (byte) 167, (byte) 110, (byte) 110, (byte) 99, (byte) 105, (byte) 103, (byte) 195, (byte) 110, (byte) 148, (byte) 215, (byte) 108, (byte) 140, (byte) 167, (byte) 135, (byte) 107, (byte) 140, (byte) 171, (byte) 212, (byte) 104, (byte) 187, (byte) 104, (byte) 249, (byte) 70, (byte) 104, (byte) 117, (byte) 159, (byte) 4, (byte) 110, (byte) 98, (byte) 104, (byte) 217, (byte) 107, (byte) 136, (byte) 112, (byte) 112, (byte) 112, (byte) 148, (byte) 183, (byte) 104, (byte) 181, (byte) 104, (byte) 179, (byte) 236, (byte) 70, (byte) 157, (byte) 180, (byte) 136, (byte) 187, (byte) 136, (byte) 249, (byte) 70, (byte) 100, (byte) 104, (byte) 105, (byte) 110, (byte) 159, (byte) 4, (byte) 194, (byte) 104, (byte) 104, (byte) 172, (byte) 104, (byte) 110, (byte) 110, (byte) 204, (byte) 107, (byte) 107, (byte) 184, (byte) 101, (byte) 200, (byte) 99, (byte) 107, (byte) 108, (byte) 110, (byte) 180, (byte) 110, (byte) 178, (byte) 103, (byte) 104, (byte) 174, (byte) 136, (byte) 104, (byte) 174, (byte) 136, (byte) 210, (byte) 110, (byte) 191, (byte) 20, (byte) 110, (byte) 255, (byte) 18, (byte) 70, (byte) 107, (byte) 104, (byte) 117, (byte) 99, (byte) 140, (byte) 100, (byte) 143, (byte) 99, (byte) 104, (byte) 179, (byte) 159, (byte) 27, (byte) 235, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      PlotOrientation orientation = plot.getOrientation();
      StackedXYAreaRenderer.StackedXYAreaRendererState areaRendererState = (StackedXYAreaRenderer.StackedXYAreaRendererState) state;
      TableXYDataset dataset1 = (TableXYDataset) dataset;
      int itemCount = dataset1.getItemCount();
      double xvalue1 = dataset.getXValue(series, item);
      double num1 = dataset.getYValue(series, item);
      int num2 = 0;
      if (Double.isNaN(num1))
      {
        num1 = 0.0;
        num2 = 1;
      }
      double previousHeight1 = this.getPreviousHeight(dataset1, series, item);
      double num3 = domainAxis.valueToJava2D(xvalue1, dataArea, plot.getDomainAxisEdge());
      double num4 = rangeAxis.valueToJava2D(num1 + previousHeight1, dataArea, plot.getRangeAxisEdge());
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      if (pass == 0)
      {
        if (item == 0)
        {
          areaRendererState.setSeriesArea(new Polygon());
          areaRendererState.setLastSeriesPoints(areaRendererState.getCurrentSeriesPoints());
          areaRendererState.setCurrentSeriesPoints(new Stack());
          double num5 = rangeAxis.valueToJava2D(previousHeight1, dataArea, plot.getRangeAxisEdge());
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num5));
          else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(num5), ByteCodeHelper.d2i(num3));
        }
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          Point point = new Point(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num4));
          areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(point.getX()), ByteCodeHelper.d2i(point.getY()));
          areaRendererState.getCurrentSeriesPoints().push((object) point);
        }
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(num4), ByteCodeHelper.d2i(num3));
        if (this.getPlotLines() && item > 0)
        {
          double xvalue2 = dataset.getXValue(series, item - 1);
          double yvalue = dataset.getYValue(series, item - 1);
          double previousHeight2 = this.getPreviousHeight(dataset1, series, item - 1);
          double num5 = domainAxis.valueToJava2D(xvalue2, dataArea, plot.getDomainAxisEdge());
          double num6 = rangeAxis.valueToJava2D(yvalue + previousHeight2, dataArea, plot.getRangeAxisEdge());
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            areaRendererState.getLine().setLine(num5, num6, num3, num4);
          else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            areaRendererState.getLine().setLine(num6, num5, num4, num3);
          g2.draw((Shape) areaRendererState.getLine());
        }
        if (this.getPlotArea() && item > 0 && item == itemCount - 1)
        {
          double num5 = rangeAxis.valueToJava2D(previousHeight1, dataArea, plot.getRangeAxisEdge());
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
            areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(num3), ByteCodeHelper.d2i(num5));
          else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
            areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(num5), ByteCodeHelper.d2i(num3));
          if (series != 0)
          {
            Stack lastSeriesPoints = areaRendererState.getLastSeriesPoints();
            while (!lastSeriesPoints.empty())
            {
              Point point = (Point) lastSeriesPoints.pop();
              areaRendererState.getSeriesArea().addPoint(ByteCodeHelper.d2i(point.getX()), ByteCodeHelper.d2i(point.getY()));
            }
          }
          g2.setPaint(itemPaint);
          g2.setStroke(itemStroke);
          g2.fill((Shape) areaRendererState.getSeriesArea());
          if (this.isOutline())
          {
            g2.setStroke(this.lookupSeriesOutlineStroke(series));
            g2.setPaint(this.lookupSeriesOutlinePaint(series));
            g2.draw((Shape) areaRendererState.getSeriesArea());
          }
        }
        int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
        int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
        this.updateCrosshairValues(crosshairState, xvalue1, previousHeight1 + num1, domainAxisIndex, rangeAxisIndex, num3, num4, orientation);
      }
      else
      {
        if (pass != 1)
          return;
        object obj1 = (object) null;
        if (this.getPlotShapes())
        {
          obj1 = (object) this.getItemShape(series, item);
          if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
            obj1 = (object) ShapeUtilities.createTranslatedShape((Shape) obj1, num3, num4);
          else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
            obj1 = (object) ShapeUtilities.createTranslatedShape((Shape) obj1, num4, num3);
          if (num2 == 0)
          {
            if (this.getShapePaint() != null)
              g2.setPaint(this.getShapePaint());
            else
              g2.setPaint(itemPaint);
            if (this.getShapeStroke() != null)
              g2.setStroke(this.getShapeStroke());
            else
              g2.setStroke(itemStroke);
            g2.draw((Shape) obj1);
          }
        }
        else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EVERTICAL)
          obj1 = (object) new Rectangle2D.Double(num3 - 3.0, num4 - 3.0, 6.0, 6.0);
        else if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
          obj1 = (object) new Rectangle2D.Double(num4 - 3.0, num3 - 3.0, 6.0, 6.0);
        if (state.getInfo() == null)
          return;
        EntityCollection entityCollection = state.getEntityCollection();
        if (entityCollection == null || obj1 == null || num2 != 0)
          return;
        string str1 = (string) null;
        XYToolTipGenerator toolTipGenerator = this.getToolTipGenerator(series, item);
        if (toolTipGenerator != null)
          str1 = toolTipGenerator.generateToolTip(dataset, series, item);
        string str2 = (string) null;
        if (this.getURLGenerator() != null)
          str2 = this.getURLGenerator().generateURL(dataset, series, item);
        object obj2 = obj1;
        XYDataset xyDataset1 = dataset;
        int num5 = series;
        int num6 = item;
        string str3 = str1;
        string str4 = str2;
        string str5 = str3;
        int num7 = num6;
        int num8 = num5;
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
        XYDataset dataset2 = xyDataset2;
        int series1 = num8;
        int num9 = num7;
        string toolTipText = str5;
        string urlText = str4;
        XYItemEntity xyItemEntity = new XYItemEntity(area, dataset2, series1, num9, toolTipText, urlText);
        entityCollection.add((ChartEntity) xyItemEntity);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 16, (byte) 100, (byte) 130, (byte) 113, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StackedXYAreaRenderer) || !base.equals(obj))
        return false;
      StackedXYAreaRenderer stackedXyAreaRenderer = (StackedXYAreaRenderer) obj;
      return PaintUtilities.equal(this.shapePaint, stackedXyAreaRenderer.shapePaint) && ObjectUtilities.equal((object) this.shapeStroke, (object) stackedXyAreaRenderer.shapeStroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 666)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 53, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.shapePaint = SerialUtilities.readPaint(obj0);
      this.shapeStroke = SerialUtilities.readStroke(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 66, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.shapePaint, obj0);
      SerialUtilities.writeStroke(this.shapeStroke, obj0);
    }

    [InnerClass]
    [SourceFile("StackedXYAreaRenderer.java")]
    [Modifiers]
    internal sealed class StackedXYAreaRendererState : XYItemRendererState
    {
      private Polygon seriesArea;
      private Line2D line;
      private Stack lastSeriesPoints;
      private Stack currentSeriesPoints;

      [LineNumberTable(new byte[] {(byte) 98, (byte) 105, (byte) 103, (byte) 107, (byte) 107, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public StackedXYAreaRendererState([In] PlotRenderingInfo obj0)
        : base(obj0)
      {
        StackedXYAreaRenderer.StackedXYAreaRendererState areaRendererState = this;
        this.seriesArea = (Polygon) null;
        this.line = (Line2D) new Line2D.Double();
        this.lastSeriesPoints = new Stack();
        this.currentSeriesPoints = new Stack();
      }

      public virtual Polygon getSeriesArea()
      {
        return this.seriesArea;
      }

      public virtual void setSeriesArea([In] Polygon obj0)
      {
        this.seriesArea = obj0;
      }

      public virtual Line2D getLine()
      {
        return this.line;
      }

      public virtual Stack getCurrentSeriesPoints()
      {
        return this.currentSeriesPoints;
      }

      public virtual void setCurrentSeriesPoints([In] Stack obj0)
      {
        this.currentSeriesPoints = obj0;
      }

      public virtual Stack getLastSeriesPoints()
      {
        return this.lastSeriesPoints;
      }

      public virtual void setLastSeriesPoints([In] Stack obj0)
      {
        this.lastSeriesPoints = obj0;
      }
    }
  }
}
