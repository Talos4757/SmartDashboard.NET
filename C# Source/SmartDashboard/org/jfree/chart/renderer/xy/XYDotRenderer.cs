// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYDotRenderer
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
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYItemRenderer", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class XYDotRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, PublicCloneable, Cloneable.__Interface
  {
    private const long serialVersionUID = -2764344339073566425L;
    private int dotWidth;
    private int dotHeight;
    [NonSerialized]
    private Shape legendShape;

    [HideFromJava]
    static XYDotRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 104, (byte) 103, (byte) 103, (byte) 127, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDotRenderer()
    {
      XYDotRenderer xyDotRenderer = this;
      this.dotWidth = 1;
      this.dotHeight = 1;
      this.legendShape = (Shape) new Rectangle2D.Double(-3.0, -3.0, 6.0, 6.0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYDotRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYDotRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual Shape getLegendShape()
    {
      return this.legendShape;
    }

    public virtual int getDotWidth()
    {
      return this.dotWidth;
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 100, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDotWidth(int w)
    {
      if (w < 1)
      {
        string str = "Requires w > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dotWidth = w;
        this.fireChangeEvent();
      }
    }

    public virtual int getDotHeight()
    {
      return this.dotHeight;
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 100, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDotHeight(int h)
    {
      if (h < 1)
      {
        string str = "Requires h > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dotHeight = h;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendShape(Shape shape)
    {
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendShape = shape;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 108, (byte) 193, (byte) 109, (byte) 109, (byte) 117, (byte) 117, (byte) 107, (byte) 105, (byte) 105, (byte) 144, (byte) 176, (byte) 112, (byte) 105, (byte) 105, (byte) 191, (byte) 3, (byte) 105, (byte) 223, (byte) 1, (byte) 107, (byte) 107, (byte) 214})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double num1 = (double) (this.dotWidth - 1) / 2.0;
      double num2 = (double) (this.dotHeight - 1) / 2.0;
      if (Double.isNaN(yvalue))
        return;
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double transX = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge) - num1;
      double transY = rangeAxis.valueToJava2D(yvalue, dataArea, rangeAxisEdge) - num2;
      g2.setPaint(this.getItemPaint(series, item));
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        ((Graphics) g2).fillRect(ByteCodeHelper.d2i(transY), ByteCodeHelper.d2i(transX), this.dotHeight, this.dotWidth);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        ((Graphics) g2).fillRect(ByteCodeHelper.d2i(transX), ByteCodeHelper.d2i(transY), this.dotWidth, this.dotHeight);
      int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
      int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
      this.updateCrosshairValues(crosshairState, xvalue, yvalue, domainAxisIndex, rangeAxisIndex, transX, transY, orientation);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 174, (byte) 103, (byte) 99, (byte) 162, (byte) 104, (byte) 99, (byte) 162, (byte) 98, (byte) 109, (byte) 142, (byte) 99, (byte) 99, (byte) 104, (byte) 175, (byte) 99, (byte) 104, (byte) 175, (byte) 105, (byte) 154, (byte) 109, (byte) 105, (byte) 100, (byte) 136, (byte) 109, (byte) 103, (byte) 103, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItem getLegendItem(int datasetIndex, int series)
    {
      XYPlot plot = this.getPlot();
      if (plot == null)
        return (LegendItem) null;
      XYDataset dataset = plot.getDataset(datasetIndex);
      if (dataset == null)
        return (LegendItem) null;
      LegendItem legendItem = (LegendItem) null;
      if (this.getItemVisible(series, 0))
      {
        string label = this.getLegendItemLabelGenerator().generateLabel(dataset, series);
        string description = label;
        string toolTipText = (string) null;
        if (this.getLegendItemToolTipGenerator() != null)
          toolTipText = this.getLegendItemToolTipGenerator().generateLabel(dataset, series);
        string urlText = (string) null;
        if (this.getLegendItemURLGenerator() != null)
          urlText = this.getLegendItemURLGenerator().generateLabel(dataset, series);
        Paint fillPaint = this.lookupSeriesPaint(series);
        LegendItem.__\u003Cclinit\u003E();
        legendItem = new LegendItem(label, description, toolTipText, urlText, this.getLegendShape(), fillPaint);
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 232, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYDotRenderer))
        return false;
      XYDotRenderer xyDotRenderer = (XYDotRenderer) obj;
      if (this.dotWidth != xyDotRenderer.dotWidth || this.dotHeight != xyDotRenderer.dotHeight || !ShapeUtilities.equal(this.legendShape, xyDotRenderer.legendShape))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 373)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 16, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.legendShape = SerialUtilities.readShape(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.legendShape, obj0);
    }
  }
}
