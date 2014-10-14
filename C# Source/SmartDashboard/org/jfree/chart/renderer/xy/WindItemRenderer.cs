// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.WindItemRenderer
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
  public class WindItemRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 8078914101916976844L;

    [HideFromJava]
    static WindItemRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindItemRenderer()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WindItemRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] WindItemRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] WindItemRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 80, (byte) 136, (byte) 107, (byte) 107, (byte) 103, (byte) 199, (byte) 107, (byte) 108, (byte) 108, (byte) 138, (byte) 223, (byte) 4, (byte) 105, (byte) 105, (byte) 147, (byte) 146, (byte) 126, (byte) 141, (byte) 111, (byte) 143, (byte) 105, (byte) 105, (byte) 127, (byte) 5, (byte) 143, (byte) 104, (byte) 107, (byte) 147, (byte) 142, (byte) 103, (byte) 231, (byte) 69, (byte) 159, (byte) 14, (byte) 159, (byte) 14, (byte) 156, (byte) 111, (byte) 143, (byte) 111, (byte) 136, (byte) 159, (byte) 14, (byte) 159, (byte) 14, (byte) 156, (byte) 111, (byte) 143, (byte) 111, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D plotArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      WindDataset windDataset = (WindDataset) dataset;
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      Number x = windDataset.getX(series, item);
      Number windDirection = windDataset.getWindDirection(series, item);
      Number windForce = windDataset.getWindForce(series, item);
      double num1 = windForce.doubleValue();
      double num2 = Math.toRadians(windDirection.doubleValue() * -30.0 - 90.0);
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num3 = domainAxis.valueToJava2D(x.doubleValue(), plotArea, domainAxisEdge);
      double num4 = rangeAxis.valueToJava2D(0.0, plotArea, rangeAxisEdge);
      double d1 = x.doubleValue() + num1 * Math.cos(num2) * 8000000.0;
      double d2 = num1 * Math.sin(num2);
      double num5 = domainAxis.valueToJava2D(d1, plotArea, domainAxisEdge);
      double num6 = rangeAxis.valueToJava2D(d2, plotArea, rangeAxisEdge);
      string str = new StringBuffer().append(windDirection.intValue()).append("-").append(windForce.intValue()).toString();
      Line2D.Double double1 = new Line2D.Double(num3, num4, num5, num6);
      g2.draw((Shape) double1);
      g2.setPaint((Paint) Color.blue);
      ((Graphics) g2).setFont(new Font("Dialog", 1, 9));
      g2.drawString(str, (float) num3, (float) num4);
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      double num7 = Math.toRadians(windDirection.doubleValue() * -30.0 - 90.0 - 5.0);
      double d3 = windForce.doubleValue() * Math.cos(num7) * 8000000.0 * 0.8 + x.doubleValue();
      double d4 = windForce.doubleValue() * Math.sin(num7) * 0.8;
      Line2D.Double double2 = new Line2D.Double(domainAxis.valueToJava2D(d3, plotArea, domainAxisEdge), rangeAxis.valueToJava2D(d4, plotArea, rangeAxisEdge), num5, num6);
      g2.draw((Shape) double2);
      double num8 = Math.toRadians(windDirection.doubleValue() * -30.0 - 90.0 + 5.0);
      double d5 = windForce.doubleValue() * Math.cos(num8) * 8000000.0 * 0.8 + x.doubleValue();
      double d6 = windForce.doubleValue() * Math.sin(num8) * 0.8;
      Line2D.Double double3 = new Line2D.Double(domainAxis.valueToJava2D(d5, plotArea, domainAxisEdge), rangeAxis.valueToJava2D(d6, plotArea, rangeAxisEdge), num5, num6);
      g2.draw((Shape) double3);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 211)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
