// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.SamplingXYLineRenderer
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
  public class SamplingXYLineRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    [NonSerialized]
    private Shape legendLine;

    [HideFromJava]
    static SamplingXYLineRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 104, (byte) 127, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SamplingXYLineRenderer()
    {
      SamplingXYLineRenderer samplingXyLineRenderer = this;
      this.legendLine = (Shape) new Line2D.Double(-7.0, 0.0, 7.0, 0.0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SamplingXYLineRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SamplingXYLineRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SamplingXYLineRenderer obj0)
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

    public virtual Shape getLegendLine()
    {
      return this.legendLine;
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
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

    public override int getPassCount()
    {
      return 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 234, (byte) 69, (byte) 104, (byte) 107, (byte) 107, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset data, PlotRenderingInfo info)
    {
      double num = 72.0;
      return (XYItemRendererState) new SamplingXYLineRenderer.State(info)
      {
        seriesPath = new GeneralPath(),
        intervalPath = new GeneralPath(),
        dX = (72.0 / num)
      };
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 108, (byte) 129, (byte) 104, (byte) 168, (byte) 109, (byte) 109, (byte) 109, (byte) 141, (byte) 136, (byte) 120, (byte) 101, (byte) 101, (byte) 105, (byte) 105, (byte) 101, (byte) 133, (byte) 108, (byte) 124, (byte) 112, (byte) 112, (byte) 124, (byte) 156, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 176, (byte) 119, (byte) 119, (byte) 205, (byte) 112, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 104, (byte) 130, (byte) 168, (byte) 139, (byte) 111, (byte) 99, (byte) 105, (byte) 102, (byte) 137, (byte) 112, (byte) 112, (byte) 109, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(yvalue, dataArea, rangeAxisEdge);
      SamplingXYLineRenderer.State state1 = (SamplingXYLineRenderer.State) state;
      if (!Double.isNaN(num1) && !Double.isNaN(num2))
      {
        float num3 = (float) num1;
        float num4 = (float) num2;
        if (plot.getOrientation() == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          num3 = (float) num2;
          num4 = (float) num1;
        }
        if (state1.lastPointGood)
        {
          if (Math.abs((double) num3 - state1.lastX) > state1.dX)
          {
            ((Path2D.Float) state1.seriesPath).lineTo(num3, num4);
            if (state1.lowY < state1.highY)
            {
              ((Path2D.Float) state1.intervalPath).moveTo((float) state1.lastX, (float) state1.lowY);
              ((Path2D.Float) state1.intervalPath).lineTo((float) state1.lastX, (float) state1.highY);
            }
            state1.lastX = (double) num3;
            state1.openY = (double) num4;
            state1.highY = (double) num4;
            state1.lowY = (double) num4;
            state1.closeY = (double) num4;
          }
          else
          {
            state1.highY = Math.max(state1.highY, (double) num4);
            state1.lowY = Math.min(state1.lowY, (double) num4);
            state1.closeY = (double) num4;
          }
        }
        else
        {
          ((Path2D.Float) state1.seriesPath).moveTo(num3, num4);
          state1.lastX = (double) num3;
          state1.openY = (double) num4;
          state1.highY = (double) num4;
          state1.lowY = (double) num4;
          state1.closeY = (double) num4;
        }
        state1.lastPointGood = true;
      }
      else
        state1.lastPointGood = false;
      if (item != state1.getLastItemIndex())
        return;
      PathIterator pathIterator = ((Path2D.Float) state1.seriesPath).getPathIterator((AffineTransform) null);
      int num5 = 0;
      while (!pathIterator.isDone())
      {
        ++num5;
        pathIterator.next();
      }
      g2.setStroke(this.getItemStroke(series, item));
      g2.setPaint(this.getItemPaint(series, item));
      g2.draw((Shape) state1.seriesPath);
      g2.draw((Shape) state1.intervalPath);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 103, (byte) 99, (byte) 162, (byte) 98, (byte) 104, (byte) 102, (byte) 109, (byte) 142, (byte) 103, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 109, (byte) 103, (byte) 103, (byte) 167})]
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
        legendItem = new LegendItem(this.getLegendItemLabelGenerator().generateLabel(dataset, series));
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
    [LineNumberTable(new byte[] {(byte) 161, (byte) 5, (byte) 108, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      SamplingXYLineRenderer samplingXyLineRenderer = (SamplingXYLineRenderer) base.clone();
      if (this.legendLine != null)
        samplingXyLineRenderer.legendLine = ShapeUtilities.clone(this.legendLine);
      return (object) samplingXyLineRenderer;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is SamplingXYLineRenderer && base.equals(obj) && ShapeUtilities.equal(this.legendLine, ((SamplingXYLineRenderer) obj).legendLine);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendLine = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendLine, obj0);
    }

    [InnerClass]
    [SourceFile("SamplingXYLineRenderer.java")]
    public class State : XYItemRendererState
    {
      internal GeneralPath seriesPath;
      internal GeneralPath intervalPath;
      internal double dX;
      internal double lastX;
      internal double openY;
      internal double highY;
      internal double lowY;
      internal double closeY;
      internal bool lastPointGood;

      [LineNumberTable(new byte[] {(byte) 122, (byte) 233, (byte) 35, (byte) 236, (byte) 70, (byte) 172, (byte) 172, (byte) 172, (byte) 236, (byte) 79})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public State(PlotRenderingInfo info)
        : base(info)
      {
        SamplingXYLineRenderer.State state = this;
        this.dX = 1.0;
        this.openY = 0.0;
        this.highY = 0.0;
        this.lowY = 0.0;
        this.closeY = 0.0;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 107, (byte) 103, (byte) 145})]
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
