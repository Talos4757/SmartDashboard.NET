// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.CandlestickRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data;
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
  public class CandlestickRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 50390395841817121L;
    public const int WIDTHMETHOD_AVERAGE = 0;
    public const int WIDTHMETHOD_SMALLEST = 1;
    public const int WIDTHMETHOD_INTERVALDATA = 2;
    private int autoWidthMethod;
    private double autoWidthFactor;
    private double autoWidthGap;
    private double candleWidth;
    private double maxCandleWidthInMilliseconds;
    private double maxCandleWidth;
    [NonSerialized]
    private Paint upPaint;
    [NonSerialized]
    private Paint downPaint;
    private bool drawVolume;
    [NonSerialized]
    private Paint volumePaint;
    [NonSerialized]
    private double maxVolume;
    private bool useOutlinePaint;

    [HideFromJava]
    static CandlestickRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 96, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CandlestickRenderer()
      : this(-1.0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CandlestickRenderer(double candleWidth)
      : this(candleWidth, true, (XYToolTipGenerator) new HighLowItemLabelGenerator())
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 83, (byte) 162, (byte) 232, (byte) 159, (byte) 167, (byte) 231, (byte) 71, (byte) 176, (byte) 236, (byte) 70, (byte) 240, (byte) 160, (byte) 74, (byte) 103, (byte) 105, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CandlestickRenderer(double candleWidth, bool drawVolume, XYToolTipGenerator toolTipGenerator)
    {
      int num = drawVolume ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      CandlestickRenderer candlestickRenderer = this;
      this.autoWidthMethod = 0;
      this.autoWidthFactor = 9.0 / 14.0;
      this.autoWidthGap = 0.0;
      this.maxCandleWidthInMilliseconds = 72000000.0;
      this.setBaseToolTipGenerator(toolTipGenerator);
      this.candleWidth = candleWidth;
      this.drawVolume = num != 0;
      this.volumePaint = (Paint) Color.gray;
      this.upPaint = (Paint) Color.green;
      this.downPaint = (Paint) Color.red;
      this.useOutlinePaint = false;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CandlestickRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CandlestickRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CandlestickRenderer obj0)
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

    public virtual Paint getVolumePaint()
    {
      return this.volumePaint;
    }

    public virtual double getCandleWidth()
    {
      return this.candleWidth;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 106, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCandleWidth(double width)
    {
      if (width == this.candleWidth)
        return;
      this.candleWidth = width;
      this.fireChangeEvent();
    }

    public virtual double getMaxCandleWidthInMilliseconds()
    {
      return this.maxCandleWidthInMilliseconds;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaxCandleWidthInMilliseconds(double millis)
    {
      this.maxCandleWidthInMilliseconds = millis;
      this.fireChangeEvent();
    }

    public virtual int getAutoWidthMethod()
    {
      return this.autoWidthMethod;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 233, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidthMethod(int autoWidthMethod)
    {
      if (this.autoWidthMethod == autoWidthMethod)
        return;
      this.autoWidthMethod = autoWidthMethod;
      this.fireChangeEvent();
    }

    public virtual double getAutoWidthFactor()
    {
      return this.autoWidthFactor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 106, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidthFactor(double autoWidthFactor)
    {
      if (this.autoWidthFactor == autoWidthFactor)
        return;
      this.autoWidthFactor = autoWidthFactor;
      this.fireChangeEvent();
    }

    public virtual double getAutoWidthGap()
    {
      return this.autoWidthGap;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 41, (byte) 106, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidthGap(double autoWidthGap)
    {
      if (this.autoWidthGap == autoWidthGap)
        return;
      this.autoWidthGap = autoWidthGap;
      this.fireChangeEvent();
    }

    public virtual Paint getUpPaint()
    {
      return this.upPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 69, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpPaint(Paint paint)
    {
      this.upPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Paint getDownPaint()
    {
      return this.downPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 93, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDownPaint(Paint paint)
    {
      this.downPaint = paint;
      this.fireChangeEvent();
    }

    public virtual bool getDrawVolume()
    {
      return this.drawVolume;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 20, (byte) 162, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawVolume(bool flag)
    {
      int num = flag ? 1 : 0;
      if ((this.drawVolume ? 1 : 0) == num)
        return;
      this.drawVolume = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 153, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVolumePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.volumePaint = paint;
        this.fireChangeEvent();
      }
    }

    public virtual bool getUseOutlinePaint()
    {
      return this.useOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 3, (byte) 98, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUseOutlinePaint(bool use)
    {
      int num = use ? 1 : 0;
      if ((this.useOutlinePaint ? 1 : 0) == num)
        return;
      this.useOutlinePaint = num != 0;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 573)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      return this.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 229, (byte) 103, (byte) 104, (byte) 106, (byte) 103, (byte) 108, (byte) 108, (byte) 241, (byte) 69, (byte) 107, (byte) 105, (byte) 108, (byte) 142, (byte) 144, (byte) 110, (byte) 106, (byte) 233, (byte) 61, (byte) 8, (byte) 232, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override XYItemRendererState initialise(Graphics2D g2, Rectangle2D dataArea, XYPlot plot, XYDataset dataset, PlotRenderingInfo info)
    {
      ValueAxis domainAxis = plot.getDomainAxis();
      double lowerBound = domainAxis.getLowerBound();
      double d = lowerBound + this.maxCandleWidthInMilliseconds;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      double num = domainAxis.valueToJava2D(lowerBound, dataArea, domainAxisEdge);
      this.maxCandleWidth = Math.abs(domainAxis.valueToJava2D(d, dataArea, domainAxisEdge) - num);
      if (this.drawVolume)
      {
        OHLCDataset ohlcDataset = (OHLCDataset) dataset;
        this.maxVolume = 0.0;
        for (int index = 0; index < ohlcDataset.getSeriesCount(); ++index)
        {
          for (int i2 = 0; i2 < ohlcDataset.getItemCount(index); ++i2)
          {
            double volumeValue = ohlcDataset.getVolumeValue(index, i2);
            if (volumeValue > this.maxVolume)
              this.maxVolume = volumeValue;
          }
        }
      }
      return new XYItemRendererState(info);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 35, (byte) 104, (byte) 104, (byte) 132, (byte) 104, (byte) 164, (byte) 193, (byte) 98, (byte) 100, (byte) 173, (byte) 136, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 141, (byte) 105, (byte) 143, (byte) 105, (byte) 111, (byte) 111, (byte) 111, (byte) 207, (byte) 173, (byte) 104, (byte) 173, (byte) 135, (byte) 188, (byte) 106, (byte) 99, (byte) 178, (byte) 141, (byte) 197, (byte) 106, (byte) 107, (byte) 105, (byte) 105, (byte) 183, (byte) 109, (byte) 180, (byte) 228, (byte) 56, (byte) 232, (byte) 74, (byte) 162, (byte) 137, (byte) 189, (byte) 189, (byte) 205, (byte) 118, (byte) 108, (byte) 112, (byte) 122, (byte) 190, (byte) 108, (byte) 99, (byte) 104, (byte) 140, (byte) 140, (byte) 136, (byte) 107, (byte) 113, (byte) 173, (byte) 99, (byte) 105, (byte) 171, (byte) 105, (byte) 169, (byte) 139, (byte) 108, (byte) 104, (byte) 177, (byte) 99, (byte) 223, (byte) 3, (byte) 223, (byte) 4, (byte) 168, (byte) 104, (byte) 170, (byte) 168, (byte) 108, (byte) 108, (byte) 108, (byte) 172, (byte) 102, (byte) 99, (byte) 181, (byte) 243, (byte) 69, (byte) 102, (byte) 99, (byte) 181, (byte) 243, (byte) 69, (byte) 98, (byte) 98, (byte) 109, (byte) 108, (byte) 99, (byte) 159, (byte) 0, (byte) 222, (byte) 159, (byte) 0, (byte) 188, (byte) 102, (byte) 104, (byte) 174, (byte) 136, (byte) 170, (byte) 104, (byte) 174, (byte) 136, (byte) 136, (byte) 104, (byte) 170, (byte) 136, (byte) 168, (byte) 99, (byte) 187})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      PlotOrientation orientation = plot.getOrientation();
      int num1;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num1 = 1;
      }
      else
      {
        if (orientation != PlotOrientation.__\u003C\u003EVERTICAL)
          return;
        num1 = 0;
      }
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      OHLCDataset ohlcDataset = (OHLCDataset) dataset;
      double xvalue = ohlcDataset.getXValue(series, item);
      double highValue = ohlcDataset.getHighValue(series, item);
      double lowValue = ohlcDataset.getLowValue(series, item);
      double openValue = ohlcDataset.getOpenValue(series, item);
      double closeValue = ohlcDataset.getCloseValue(series, item);
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      double num2 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num3 = rangeAxis.valueToJava2D(highValue, dataArea, rangeAxisEdge);
      double num4 = rangeAxis.valueToJava2D(lowValue, dataArea, rangeAxisEdge);
      double num5 = rangeAxis.valueToJava2D(openValue, dataArea, rangeAxisEdge);
      double num6 = rangeAxis.valueToJava2D(closeValue, dataArea, rangeAxisEdge);
      double num7;
      double num8;
      if (this.candleWidth > 0.0)
      {
        num7 = this.candleWidth;
        num8 = this.candleWidth;
      }
      else
      {
        double num9 = 0.0;
        switch (this.autoWidthMethod)
        {
          case 0:
            int itemCount1 = ohlcDataset.getItemCount(series);
            num9 = num1 == 0 ? ((RectangularShape) dataArea).getWidth() / (double) itemCount1 : ((RectangularShape) dataArea).getHeight() / (double) itemCount1;
            break;
          case 1:
            int itemCount2 = ohlcDataset.getItemCount(series);
            double num10 = -1.0;
            num9 = ((RectangularShape) dataArea).getWidth();
            for (int i2 = 0; i2 < itemCount2; ++i2)
            {
              double num11 = domainAxis.valueToJava2D(ohlcDataset.getXValue(series, i2), dataArea, domainAxisEdge);
              if (num10 != -1.0)
                num9 = Math.min(num9, Math.abs(num11 - num10));
              num10 = num11;
            }
            break;
          case 2:
            IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
            double num12 = domainAxis.valueToJava2D(ntervalXyDataset.getStartXValue(series, item), dataArea, plot.getDomainAxisEdge());
            num9 = Math.abs(domainAxis.valueToJava2D(ntervalXyDataset.getEndXValue(series, item), dataArea, plot.getDomainAxisEdge()) - num12);
            break;
        }
        double num13 = Math.min((num9 - 2.0 * this.autoWidthGap) * this.autoWidthFactor, this.maxCandleWidth);
        num7 = Math.max(Math.min(1.0, this.maxCandleWidth), num13);
        num8 = Math.max(Math.min(3.0, this.maxCandleWidth), num13);
      }
      Paint itemPaint = this.getItemPaint(series, item);
      Paint paint = (Paint) null;
      if (this.useOutlinePaint)
        paint = this.getItemOutlinePaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setStroke(itemStroke);
      if (this.drawVolume)
      {
        double num9 = (double) ByteCodeHelper.d2i(ohlcDataset.getVolumeValue(series, item)) / this.maxVolume;
        double num10;
        double num11;
        if (num1 != 0)
        {
          num10 = ((RectangularShape) dataArea).getMinX();
          num11 = ((RectangularShape) dataArea).getMaxX();
        }
        else
        {
          num10 = ((RectangularShape) dataArea).getMinY();
          num11 = ((RectangularShape) dataArea).getMaxY();
        }
        double num12 = num9 * (num11 - num10);
        g2.setPaint(this.getVolumePaint());
        Composite composite = g2.getComposite();
        g2.setComposite((Composite) AlphaComposite.getInstance(3, 0.3f));
        if (num1 != 0)
          g2.fill((Shape) new Rectangle2D.Double(num10, num2 - num7 / 2.0, num12, num7));
        else
          g2.fill((Shape) new Rectangle2D.Double(num2 - num7 / 2.0, num11 - num12, num7, num12));
        g2.setComposite(composite);
      }
      if (this.useOutlinePaint)
        g2.setPaint(paint);
      else
        g2.setPaint(itemPaint);
      double num14 = Math.max(num5, num6);
      double num15 = Math.min(num5, num6);
      double num16 = Math.max(openValue, closeValue);
      double num17 = Math.min(openValue, closeValue);
      if (highValue > num16)
      {
        if (num1 != 0)
          g2.draw((Shape) new Line2D.Double(num3, num2, num14, num2));
        else
          g2.draw((Shape) new Line2D.Double(num2, num3, num2, num14));
      }
      if (lowValue < num17)
      {
        if (num1 != 0)
          g2.draw((Shape) new Line2D.Double(num4, num2, num15, num2));
        else
          g2.draw((Shape) new Line2D.Double(num2, num4, num2, num15));
      }
      double num18 = Math.abs(num3 - num4);
      double num19 = Math.min(num3, num4);
      Rectangle2D.Double double1;
      Rectangle2D.Double double2;
      if (num1 != 0)
      {
        double1 = new Rectangle2D.Double(num15, num2 - num8 / 2.0, num14 - num15, num8);
        double2 = new Rectangle2D.Double(num19, num2 - num8 / 2.0, num18, num8);
      }
      else
      {
        double1 = new Rectangle2D.Double(num2 - num8 / 2.0, num15, num8, num14 - num15);
        double2 = new Rectangle2D.Double(num2 - num8 / 2.0, num19, num8, num18);
      }
      if (closeValue > openValue)
      {
        if (this.upPaint != null)
          g2.setPaint(this.upPaint);
        else
          g2.setPaint(itemPaint);
        g2.fill((Shape) double1);
      }
      else
      {
        if (this.downPaint != null)
          g2.setPaint(this.downPaint);
        else
          g2.setPaint(itemPaint);
        g2.fill((Shape) double1);
      }
      if (this.useOutlinePaint)
        g2.setPaint(paint);
      else
        g2.setPaint(itemPaint);
      g2.draw((Shape) double1);
      if (entities == null)
        return;
      this.addEntity(entities, (Shape) double2, dataset, series, item, 0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 5, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 142, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CandlestickRenderer))
        return false;
      CandlestickRenderer candlestickRenderer = (CandlestickRenderer) obj;
      if (this.candleWidth != candlestickRenderer.candleWidth || !PaintUtilities.equal(this.upPaint, candlestickRenderer.upPaint) || (!PaintUtilities.equal(this.downPaint, candlestickRenderer.downPaint) || this.drawVolume != candlestickRenderer.drawVolume) || (this.maxCandleWidthInMilliseconds != candlestickRenderer.maxCandleWidthInMilliseconds || this.autoWidthMethod != candlestickRenderer.autoWidthMethod || (this.autoWidthFactor != candlestickRenderer.autoWidthFactor || this.autoWidthGap != candlestickRenderer.autoWidthGap)) || (this.useOutlinePaint != candlestickRenderer.useOutlinePaint || !PaintUtilities.equal(this.volumePaint, candlestickRenderer.volumePaint)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 936)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 65, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.upPaint, obj0);
      SerialUtilities.writePaint(this.downPaint, obj0);
      SerialUtilities.writePaint(this.volumePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 81, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.upPaint = SerialUtilities.readPaint(obj0);
      this.downPaint = SerialUtilities.readPaint(obj0);
      this.volumePaint = SerialUtilities.readPaint(obj0);
    }

    [Obsolete]
    public virtual bool drawVolume()
    {
      return this.drawVolume;
    }
  }
}
