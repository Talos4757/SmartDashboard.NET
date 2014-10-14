// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYErrorRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using org.jfree.chart.axis;
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
  [Serializable]
  public class XYErrorRenderer : XYLineAndShapeRenderer
  {
    internal const long serialVersionUID = 5162283570955172424L;
    private bool drawXError;
    private bool drawYError;
    private double capLength;
    [NonSerialized]
    private Paint errorPaint;
    [NonSerialized]
    private Stroke errorStroke;

    [HideFromJava]
    static XYErrorRenderer()
    {
      XYLineAndShapeRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 106, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYErrorRenderer()
      : base(false, true)
    {
      XYErrorRenderer xyErrorRenderer = this;
      this.drawXError = true;
      this.drawYError = true;
      this.errorPaint = (Paint) null;
      this.errorStroke = (Stroke) null;
      this.capLength = 4.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYErrorRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual bool getDrawXError()
    {
      return this.drawXError;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 106, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawXError(bool draw)
    {
      int num = draw ? 1 : 0;
      if ((this.drawXError ? 1 : 0) == num)
        return;
      this.drawXError = num != 0;
      this.fireChangeEvent();
    }

    public virtual bool getDrawYError()
    {
      return this.drawYError;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 99, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDrawYError(bool draw)
    {
      int num = draw ? 1 : 0;
      if ((this.drawYError ? 1 : 0) == num)
        return;
      this.drawYError = num != 0;
      this.fireChangeEvent();
    }

    public virtual double getCapLength()
    {
      return this.capLength;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCapLength(double length)
    {
      this.capLength = length;
      this.fireChangeEvent();
    }

    public virtual Paint getErrorPaint()
    {
      return this.errorPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorPaint(Paint paint)
    {
      this.errorPaint = paint;
      this.fireChangeEvent();
    }

    public virtual Stroke getErrorStroke()
    {
      return this.errorStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setErrorStroke(Stroke stroke)
    {
      this.errorStroke = stroke;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findDomainBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      return DatasetUtilities.findDomainBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      return DatasetUtilities.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 159, (byte) 3, (byte) 104, (byte) 104, (byte) 139, (byte) 108, (byte) 108, (byte) 109, (byte) 105, (byte) 110, (byte) 110, (byte) 180, (byte) 98, (byte) 98, (byte) 115, (byte) 104, (byte) 111, (byte) 117, (byte) 183, (byte) 111, (byte) 117, (byte) 149, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 104, (byte) 136, (byte) 139, (byte) 108, (byte) 108, (byte) 109, (byte) 105, (byte) 110, (byte) 110, (byte) 180, (byte) 98, (byte) 98, (byte) 115, (byte) 104, (byte) 111, (byte) 117, (byte) 183, (byte) 111, (byte) 117, (byte) 149, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 174, (byte) 144, (byte) 104, (byte) 104, (byte) 168, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (pass == 0 && dataset is IntervalXYDataset && this.getItemVisible(series, item))
      {
        IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
        PlotOrientation orientation = plot.getOrientation();
        if (this.drawXError)
        {
          double startXvalue = ntervalXyDataset.getStartXValue(series, item);
          double endXvalue = ntervalXyDataset.getEndXValue(series, item);
          double yvalue = ntervalXyDataset.getYValue(series, item);
          RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
          double num1 = domainAxis.valueToJava2D(startXvalue, dataArea, domainAxisEdge);
          double num2 = domainAxis.valueToJava2D(endXvalue, dataArea, domainAxisEdge);
          double num3 = rangeAxis.valueToJava2D(yvalue, dataArea, plot.getRangeAxisEdge());
          double num4 = this.capLength / 2.0;
          Line2D.Double double1;
          Line2D.Double double2;
          Line2D.Double double3;
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            double1 = new Line2D.Double(num1, num3, num2, num3);
            double2 = new Line2D.Double(num1, num3 - num4, num1, num3 + num4);
            double3 = new Line2D.Double(num2, num3 - num4, num2, num3 + num4);
          }
          else
          {
            double1 = new Line2D.Double(num3, num1, num3, num2);
            double2 = new Line2D.Double(num3 - num4, num1, num3 + num4, num1);
            double3 = new Line2D.Double(num3 - num4, num2, num3 + num4, num2);
          }
          if (this.errorPaint != null)
            g2.setPaint(this.errorPaint);
          else
            g2.setPaint(this.getItemPaint(series, item));
          if (this.errorStroke != null)
            g2.setStroke(this.errorStroke);
          else
            g2.setStroke(this.getItemStroke(series, item));
          g2.draw((Shape) double1);
          g2.draw((Shape) double2);
          g2.draw((Shape) double3);
        }
        if (this.drawYError)
        {
          double startYvalue = ntervalXyDataset.getStartYValue(series, item);
          double endYvalue = ntervalXyDataset.getEndYValue(series, item);
          double xvalue = ntervalXyDataset.getXValue(series, item);
          RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
          double num1 = rangeAxis.valueToJava2D(startYvalue, dataArea, rangeAxisEdge);
          double num2 = rangeAxis.valueToJava2D(endYvalue, dataArea, rangeAxisEdge);
          double num3 = domainAxis.valueToJava2D(xvalue, dataArea, plot.getDomainAxisEdge());
          double num4 = this.capLength / 2.0;
          Line2D.Double double1;
          Line2D.Double double2;
          Line2D.Double double3;
          if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
          {
            double1 = new Line2D.Double(num3, num1, num3, num2);
            double2 = new Line2D.Double(num3 - num4, num1, num3 + num4, num1);
            double3 = new Line2D.Double(num3 - num4, num2, num3 + num4, num2);
          }
          else
          {
            double1 = new Line2D.Double(num1, num3, num2, num3);
            double2 = new Line2D.Double(num1, num3 - num4, num1, num3 + num4);
            double3 = new Line2D.Double(num2, num3 - num4, num2, num3 + num4);
          }
          if (this.errorPaint != null)
            g2.setPaint(this.errorPaint);
          else
            g2.setPaint(this.getItemPaint(series, item));
          if (this.errorStroke != null)
            g2.setStroke(this.errorStroke);
          else
            g2.setStroke(this.getItemStroke(series, item));
          g2.draw((Shape) double1);
          g2.draw((Shape) double2);
          g2.draw((Shape) double3);
        }
      }
      base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState, pass);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYErrorRenderer))
        return false;
      XYErrorRenderer xyErrorRenderer = (XYErrorRenderer) obj;
      if (this.drawXError != xyErrorRenderer.drawXError || this.drawYError != xyErrorRenderer.drawYError || (this.capLength != xyErrorRenderer.capLength || !PaintUtilities.equal(this.errorPaint, xyErrorRenderer.errorPaint)) || !ObjectUtilities.equal((object) this.errorStroke, (object) xyErrorRenderer.errorStroke))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.errorPaint = SerialUtilities.readPaint(obj0);
      this.errorStroke = SerialUtilities.readStroke(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 90, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.errorPaint, obj0);
      SerialUtilities.writeStroke(this.errorStroke, obj0);
    }
  }
}
