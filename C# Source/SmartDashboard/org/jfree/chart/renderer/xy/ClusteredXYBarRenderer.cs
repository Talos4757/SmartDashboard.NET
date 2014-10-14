// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.ClusteredXYBarRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.entity;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.data;
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
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class ClusteredXYBarRenderer : XYBarRenderer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 5864462149177133147L;
    private bool centerBarAtStartValue;

    [HideFromJava]
    static ClusteredXYBarRenderer()
    {
      XYBarRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 98, (byte) 106, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClusteredXYBarRenderer(double margin, bool centerBarAtStartValue)
    {
      int num = centerBarAtStartValue ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(margin);
      ClusteredXYBarRenderer clusteredXyBarRenderer = this;
      this.centerBarAtStartValue = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClusteredXYBarRenderer()
      : this(0.0, false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ClusteredXYBarRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ClusteredXYBarRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ClusteredXYBarRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 120, (byte) 99, (byte) 144, (byte) 106, (byte) 106, (byte) 167, (byte) 105, (byte) 105, (byte) 108, (byte) 108, (byte) 108, (byte) 114, (byte) 104, (byte) 104, (byte) 106, (byte) 234, (byte) 57, (byte) 11, (byte) 233, (byte) 77, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Range findDomainBoundsWithOffset(IntervalXYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double startXvalue = dataset.getStartXValue(index, i2);
            double endXvalue = dataset.getEndXValue(index, i2);
            double num1 = (endXvalue - startXvalue) / 2.0;
            double num2 = startXvalue - num1;
            double num3 = endXvalue - num1;
            lower = Math.min(lower, num2);
            upper = Math.max(upper, num3);
          }
        }
        if (lower > upper)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    public override int getPassCount()
    {
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 99, (byte) 162, (byte) 104, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findDomainBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      if (this.centerBarAtStartValue)
        return this.findDomainBoundsWithOffset((IntervalXYDataset) dataset);
      else
        return base.findDomainBounds(dataset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 200, (byte) 104, (byte) 108, (byte) 174, (byte) 104, (byte) 140, (byte) 112, (byte) 161, (byte) 146, (byte) 179, (byte) 105, (byte) 109, (byte) 143, (byte) 109, (byte) 143, (byte) 104, (byte) 100, (byte) 104, (byte) 146, (byte) 105, (byte) 105, (byte) 108, (byte) 104, (byte) 178, (byte) 140, (byte) 137, (byte) 105, (byte) 137, (byte) 99, (byte) 108, (byte) 108, (byte) 104, (byte) 107, (byte) 100, (byte) 108, (byte) 109, (byte) 111, (byte) 101, (byte) 105, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 107, (byte) 100, (byte) 143, (byte) 106, (byte) 137, (byte) 105, (byte) 112, (byte) 169, (byte) 201, (byte) 112, (byte) 169, (byte) 167, (byte) 108, (byte) 191, (byte) 2, (byte) 104, (byte) 149, (byte) 108, (byte) 140, (byte) 251, (byte) 69, (byte) 100, (byte) 142, (byte) 100, (byte) 255, (byte) 1, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
      double d1;
      double d2;
      if (this.getUseYInterval())
      {
        d1 = ntervalXyDataset.getStartYValue(series, item);
        d2 = ntervalXyDataset.getEndYValue(series, item);
      }
      else
      {
        d1 = this.getBase();
        d2 = ntervalXyDataset.getYValue(series, item);
      }
      if (Double.isNaN(d1) || Double.isNaN(d2))
        return;
      double num1 = rangeAxis.valueToJava2D(d1, dataArea, plot.getRangeAxisEdge());
      double num2 = rangeAxis.valueToJava2D(d2, dataArea, plot.getRangeAxisEdge());
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      double startXvalue = ntervalXyDataset.getStartXValue(series, item);
      double num3 = domainAxis.valueToJava2D(startXvalue, dataArea, domainAxisEdge);
      double endXvalue = ntervalXyDataset.getEndXValue(series, item);
      double num4 = domainAxis.valueToJava2D(endXvalue, dataArea, domainAxisEdge) - num3;
      double num5 = num3;
      if (this.centerBarAtStartValue)
        num5 -= num4 / 2.0;
      if (this.getMargin() > 0.0)
      {
        double num6 = num4 * this.getMargin();
        num4 -= num6;
        num5 += num6 / 2.0;
      }
      double num7 = Math.abs(num1 - num2);
      PlotOrientation orientation = plot.getOrientation();
      int seriesCount = dataset.getSeriesCount();
      double num8 = num4 / (double) seriesCount;
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num6 = num5 + num8 * (double) series;
        double num9 = num6 + num8;
        double num10 = Math.min(num1, num2);
        double num11 = num7;
        double num12 = Math.min(num6, num9);
        double num13 = Math.abs(num9 - num6);
        @double = new Rectangle2D.Double(num10, num12, num11, num13);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        double num6 = num5 + num8 * (double) series;
        double num9 = num6 + num8;
        double num10 = Math.min(num6, num9);
        double num11 = Math.abs(num9 - num6);
        double num12 = Math.min(num1, num2);
        double num13 = num7;
        @double = new Rectangle2D.Double(num10, num12, num11, num13);
      }
      int num14 = d2 > 0.0 ? 1 : 0;
      int num15 = rangeAxis.isInverted() ? 1 : 0;
      RectangleEdge re = orientation != PlotOrientation.__\u003C\u003EHORIZONTAL ? (num14 != 0 && num15 == 0 || num14 == 0 && num15 != 0 ? RectangleEdge.__\u003C\u003EBOTTOM : RectangleEdge.__\u003C\u003ETOP) : (num14 != 0 && num15 != 0 || num14 == 0 && num15 == 0 ? RectangleEdge.__\u003C\u003ERIGHT : RectangleEdge.__\u003C\u003ELEFT);
      if (pass == 0 && this.getShadowsVisible())
        this.getBarPainter().paintBarShadow(g2, (XYBarRenderer) this, series, item, (RectangularShape) @double, re, !this.getUseYInterval());
      if (pass != 1)
        return;
      this.getBarPainter().paintBar(g2, (XYBarRenderer) this, series, item, (RectangularShape) @double, re);
      if (this.isItemLabelVisible(series, item))
      {
        XYItemLabelGenerator itemLabelGenerator = this.getItemLabelGenerator(series, item);
        this.drawItemLabel(g2, dataset, series, item, plot, itemLabelGenerator, (Rectangle2D) @double, d2 < 0.0);
      }
      if (info == null)
        return;
      EntityCollection entityCollection = info.getOwner().getEntityCollection();
      if (entityCollection == null)
        return;
      this.addEntity(entityCollection, (Shape) @double, dataset, series, item, ((RectangularShape) @double).getCenterX(), ((RectangularShape) @double).getCenterY());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ClusteredXYBarRenderer) || this.centerBarAtStartValue != ((ClusteredXYBarRenderer) obj).centerBarAtStartValue)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 377)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
