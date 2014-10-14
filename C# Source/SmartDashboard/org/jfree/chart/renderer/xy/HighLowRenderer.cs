// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.HighLowRenderer
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
using org.jfree.data;
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
  public class HighLowRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -8135673815876552516L;
    private bool drawOpenTicks;
    private bool drawCloseTicks;
    [NonSerialized]
    private Paint openTickPaint;
    [NonSerialized]
    private Paint closeTickPaint;
    private double tickLength;

    [HideFromJava]
    static HighLowRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 104, (byte) 103, (byte) 103, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HighLowRenderer()
    {
      HighLowRenderer highLowRenderer = this;
      this.drawOpenTicks = true;
      this.drawCloseTicks = true;
      this.tickLength = 2.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HighLowRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] HighLowRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HighLowRenderer obj0)
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

    public virtual double getTickLength()
    {
      return this.tickLength;
    }

    public virtual bool getDrawOpenTicks()
    {
      return this.drawOpenTicks;
    }

    public virtual bool getDrawCloseTicks()
    {
      return this.drawCloseTicks;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 99, (byte) 66, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawOpenTicks(bool draw)
    {
      this.drawOpenTicks = draw;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 98, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawCloseTicks(bool draw)
    {
      this.drawCloseTicks = draw;
      this.fireChangeEvent();
    }

    public virtual Paint getOpenTickPaint()
    {
      return this.openTickPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOpenTickPaint(Paint paint)
    {
      this.openTickPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Paint getCloseTickPaint()
    {
      return this.closeTickPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCloseTickPaint(Paint paint)
    {
      this.closeTickPaint = paint;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLength(double length)
    {
      this.tickLength = length;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      return DatasetUtilities.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 218, (byte) 109, (byte) 111, (byte) 129, (byte) 210, (byte) 98, (byte) 98, (byte) 100, (byte) 173, (byte) 105, (byte) 137, (byte) 108, (byte) 108, (byte) 104, (byte) 136, (byte) 108, (byte) 137, (byte) 110, (byte) 110, (byte) 120, (byte) 143, (byte) 143, (byte) 105, (byte) 113, (byte) 191, (byte) 12, (byte) 105, (byte) 113, (byte) 255, (byte) 10, (byte) 70, (byte) 105, (byte) 105, (byte) 133, (byte) 107, (byte) 110, (byte) 108, (byte) 143, (byte) 104, (byte) 174, (byte) 136, (byte) 105, (byte) 182, (byte) 105, (byte) 244, (byte) 70, (byte) 107, (byte) 110, (byte) 108, (byte) 143, (byte) 104, (byte) 174, (byte) 136, (byte) 105, (byte) 182, (byte) 105, (byte) 244, (byte) 70, (byte) 197, (byte) 104, (byte) 112, (byte) 112, (byte) 110, (byte) 123, (byte) 129, (byte) 148, (byte) 111, (byte) 111, (byte) 105, (byte) 148, (byte) 105, (byte) 242, (byte) 69, (byte) 99, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      double xvalue1 = dataset.getXValue(series, item);
      if (!domainAxis.getRange().contains(xvalue1))
        return;
      double num1 = domainAxis.valueToJava2D(xvalue1, dataArea, plot.getDomainAxisEdge());
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      if (dataset is OHLCDataset)
      {
        OHLCDataset ohlcDataset = (OHLCDataset) dataset;
        double highValue = ohlcDataset.getHighValue(series, item);
        double lowValue = ohlcDataset.getLowValue(series, item);
        if (!Double.isNaN(highValue) && !Double.isNaN(lowValue))
        {
          double num2 = rangeAxis.valueToJava2D(highValue, dataArea, rangeAxisEdge);
          double num3 = rangeAxis.valueToJava2D(lowValue, dataArea, rangeAxisEdge);
          if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          {
            g2.draw((Shape) new Line2D.Double(num3, num1, num2, num1));
            @double = new Rectangle2D.Double(Math.min(num3, num2), num1 - 1.0, Math.abs(num2 - num3), 2.0);
          }
          else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            g2.draw((Shape) new Line2D.Double(num1, num3, num1, num2));
            @double = new Rectangle2D.Double(num1 - 1.0, Math.min(num3, num2), 2.0, Math.abs(num2 - num3));
          }
        }
        double num4 = this.getTickLength();
        if (domainAxis.isInverted())
          num4 = -num4;
        if (this.getDrawOpenTicks())
        {
          double openValue = ohlcDataset.getOpenValue(series, item);
          if (!Double.isNaN(openValue))
          {
            double num2 = rangeAxis.valueToJava2D(openValue, dataArea, rangeAxisEdge);
            if (this.openTickPaint != null)
              g2.setPaint(this.openTickPaint);
            else
              g2.setPaint(itemPaint);
            if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
              g2.draw((Shape) new Line2D.Double(num2, num1 + num4, num2, num1));
            else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
              g2.draw((Shape) new Line2D.Double(num1 - num4, num2, num1, num2));
          }
        }
        if (this.getDrawCloseTicks())
        {
          double closeValue = ohlcDataset.getCloseValue(series, item);
          if (!Double.isNaN(closeValue))
          {
            double num2 = rangeAxis.valueToJava2D(closeValue, dataArea, rangeAxisEdge);
            if (this.closeTickPaint != null)
              g2.setPaint(this.closeTickPaint);
            else
              g2.setPaint(itemPaint);
            if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
              g2.draw((Shape) new Line2D.Double(num2, num1, num2, num1 - num4));
            else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
              g2.draw((Shape) new Line2D.Double(num1, num2, num1 + num4, num2));
          }
        }
      }
      else if (item > 0)
      {
        double xvalue2 = dataset.getXValue(series, item - 1);
        double yvalue1 = dataset.getYValue(series, item - 1);
        double yvalue2 = dataset.getYValue(series, item);
        if (Double.isNaN(xvalue2) || Double.isNaN(yvalue1) || Double.isNaN(yvalue2))
          return;
        double num2 = domainAxis.valueToJava2D(xvalue2, dataArea, plot.getDomainAxisEdge());
        double num3 = rangeAxis.valueToJava2D(yvalue1, dataArea, rangeAxisEdge);
        double num4 = rangeAxis.valueToJava2D(yvalue2, dataArea, rangeAxisEdge);
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
          g2.draw((Shape) new Line2D.Double(num3, num2, num4, num1));
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          g2.draw((Shape) new Line2D.Double(num2, num3, num1, num4));
      }
      if (entities == null)
        return;
      this.addEntity(entities, (Shape) @double, dataset, series, item, 0.0, 0.0);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 463)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 104, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is HighLowRenderer))
        return false;
      HighLowRenderer highLowRenderer = (HighLowRenderer) obj;
      return this.drawOpenTicks == highLowRenderer.drawOpenTicks && this.drawCloseTicks == highLowRenderer.drawCloseTicks && (PaintUtilities.equal(this.openTickPaint, highLowRenderer.openTickPaint) && PaintUtilities.equal(this.closeTickPaint, highLowRenderer.closeTickPaint)) && (this.tickLength == highLowRenderer.tickLength && base.equals(obj));
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 142, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.openTickPaint = SerialUtilities.readPaint(obj0);
      this.closeTickPaint = SerialUtilities.readPaint(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 155, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.openTickPaint, obj0);
      SerialUtilities.writePaint(this.closeTickPaint, obj0);
    }
  }
}
