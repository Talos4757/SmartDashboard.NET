// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYStepRenderer
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
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data.xy;
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
  public class XYStepRenderer : XYLineAndShapeRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -8918141928884796108L;
    private double stepPoint;

    [HideFromJava]
    static XYStepRenderer()
    {
      XYLineAndShapeRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 232, (byte) 45, (byte) 236, (byte) 84, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYStepRenderer(XYToolTipGenerator toolTipGenerator, XYURLGenerator urlGenerator)
    {
      XYStepRenderer xyStepRenderer = this;
      this.stepPoint = 1.0;
      this.setBaseToolTipGenerator(toolTipGenerator);
      this.setURLGenerator(urlGenerator);
      this.setBaseShapesVisible(false);
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYStepRenderer()
      : this((XYToolTipGenerator) null, (XYURLGenerator) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYStepRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYStepRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYStepRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 207, (byte) 159, (byte) 8, (byte) 129, (byte) 113, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawLine([In] Graphics2D obj0, [In] Line2D obj1, [In] double obj2, [In] double obj3, [In] double obj4, [In] double obj5)
    {
      if (Double.isNaN(obj2) || Double.isNaN(obj4) || (Double.isNaN(obj3) || Double.isNaN(obj5)))
        return;
      obj1.setLine(obj2, obj3, obj4, obj5);
      obj0.draw((Shape) obj1);
    }

    public virtual double getStepPoint()
    {
      return this.stepPoint;
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 114, (byte) 176, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStepPoint(double stepPoint)
    {
      if (stepPoint < 0.0 || stepPoint > 1.0)
      {
        string str = "Requires stepPoint in [0.0;1.0]";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.stepPoint = stepPoint;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 108, (byte) 161, (byte) 136, (byte) 107, (byte) 107, (byte) 103, (byte) 167, (byte) 109, (byte) 142, (byte) 105, (byte) 105, (byte) 110, (byte) 191, (byte) 4, (byte) 143, (byte) 112, (byte) 112, (byte) 143, (byte) 191, (byte) 4, (byte) 107, (byte) 166, (byte) 250, (byte) 70, (byte) 146, (byte) 149, (byte) 149, (byte) 149, (byte) 133, (byte) 107, (byte) 134, (byte) 247, (byte) 69, (byte) 146, (byte) 149, (byte) 149, (byte) 245, (byte) 70, (byte) 107, (byte) 107, (byte) 212, (byte) 104, (byte) 100, (byte) 243, (byte) 70, (byte) 133, (byte) 108, (byte) 100, (byte) 100, (byte) 104, (byte) 100, (byte) 132, (byte) 221})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getItemVisible(series, item))
        return;
      PlotOrientation orientation = plot.getOrientation();
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      double xvalue1 = dataset.getXValue(series, item);
      double yvalue1 = dataset.getYValue(series, item);
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = domainAxis.valueToJava2D(xvalue1, dataArea, domainAxisEdge);
      double num2 = !Double.isNaN(yvalue1) ? rangeAxis.valueToJava2D(yvalue1, dataArea, rangeAxisEdge) : double.NaN;
      if (pass == 0 && item > 0)
      {
        double xvalue2 = dataset.getXValue(series, item - 1);
        double yvalue2 = dataset.getYValue(series, item - 1);
        double num3 = domainAxis.valueToJava2D(xvalue2, dataArea, domainAxisEdge);
        double num4 = !Double.isNaN(yvalue2) ? rangeAxis.valueToJava2D(yvalue2, dataArea, rangeAxisEdge) : double.NaN;
        if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          if (num4 == num2)
          {
            this.drawLine(g2, state.workingLine, num4, num3, num2, num1);
          }
          else
          {
            double num5 = num3 + this.getStepPoint() * (num1 - num3);
            this.drawLine(g2, state.workingLine, num4, num3, num4, num5);
            this.drawLine(g2, state.workingLine, num4, num5, num2, num5);
            this.drawLine(g2, state.workingLine, num2, num5, num2, num1);
          }
        }
        else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          if (num4 == num2)
          {
            this.drawLine(g2, state.workingLine, num3, num4, num1, num2);
          }
          else
          {
            double num5 = num3 + this.getStepPoint() * (num1 - num3);
            this.drawLine(g2, state.workingLine, num3, num4, num5, num4);
            this.drawLine(g2, state.workingLine, num5, num4, num5, num2);
            this.drawLine(g2, state.workingLine, num5, num2, num1, num2);
          }
        }
        int domainAxisIndex = plot.getDomainAxisIndex(domainAxis);
        int rangeAxisIndex = plot.getRangeAxisIndex(rangeAxis);
        this.updateCrosshairValues(crosshairState, xvalue1, yvalue1, domainAxisIndex, rangeAxisIndex, num1, num2, orientation);
        EntityCollection entityCollection = state.getEntityCollection();
        if (entityCollection != null)
          this.addEntity(entityCollection, (Shape) null, dataset, series, item, num1, num2);
      }
      if (pass != 1 || !this.isItemLabelVisible(series, item))
        return;
      double x = num1;
      double y = num2;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        x = num2;
        y = num1;
      }
      this.drawItemLabel(g2, orientation, dataset, series, item, x, y, yvalue1 < 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYLineAndShapeRenderer) || this.stepPoint != ((XYStepRenderer) obj).stepPoint)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 356)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(base.hashCode(), this.stepPoint);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 367)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
