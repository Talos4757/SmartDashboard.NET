// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.YIntervalRenderer
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
using org.jfree.data;
using org.jfree.data.xy;
using org.jfree.text;
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
  public class YIntervalRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -2951586537224143260L;
    private XYItemLabelGenerator additionalItemLabelGenerator;

    [HideFromJava]
    static YIntervalRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public YIntervalRenderer()
    {
      YIntervalRenderer yintervalRenderer = this;
      this.additionalItemLabelGenerator = (XYItemLabelGenerator) null;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected YIntervalRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] YIntervalRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] YIntervalRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 104, (byte) 161, (byte) 107, (byte) 107, (byte) 103, (byte) 103, (byte) 177, (byte) 107, (byte) 149, (byte) 223, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void drawAdditionalItemLabel([In] Graphics2D obj0, [In] PlotOrientation obj1, [In] XYDataset obj2, [In] int obj3, [In] int obj4, [In] double obj5, [In] double obj6)
    {
      if (this.additionalItemLabelGenerator == null)
        return;
      Font itemLabelFont = this.getItemLabelFont(obj3, obj4);
      Paint itemLabelPaint = this.getItemLabelPaint(obj3, obj4);
      ((Graphics) obj0).setFont(itemLabelFont);
      obj0.setPaint(itemLabelPaint);
      string text = this.additionalItemLabelGenerator.generateLabel(obj2, obj3, obj4);
      ItemLabelPosition itemLabelPosition = this.getNegativeItemLabelPosition(obj3, obj4);
      Point2D point2D = this.calculateLabelAnchorPoint(itemLabelPosition.getItemLabelAnchor(), obj5, obj6, obj1);
      TextUtilities.drawRotatedString(text, obj0, (float) point2D.getX(), (float) point2D.getY(), itemLabelPosition.getTextAnchor(), itemLabelPosition.getAngle(), itemLabelPosition.getRotationAnchor());
    }

    public virtual XYItemLabelGenerator getAdditionalItemLabelGenerator()
    {
      return this.additionalItemLabelGenerator;
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAdditionalItemLabelGenerator(XYItemLabelGenerator generator)
    {
      this.additionalItemLabelGenerator = generator;
      this.fireChangeEvent();
    }

    [LineNumberTable((ushort) 156)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      return this.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 98, (byte) 100, (byte) 173, (byte) 136, (byte) 108, (byte) 108, (byte) 141, (byte) 105, (byte) 137, (byte) 110, (byte) 110, (byte) 143, (byte) 108, (byte) 140, (byte) 99, (byte) 108, (byte) 99, (byte) 99, (byte) 105, (byte) 105, (byte) 111, (byte) 109, (byte) 143, (byte) 105, (byte) 111, (byte) 109, (byte) 141, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 232, (byte) 70, (byte) 108, (byte) 148, (byte) 243, (byte) 69, (byte) 99, (byte) 223, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      EntityCollection entities = (EntityCollection) null;
      if (info != null)
        entities = info.getOwner().getEntityCollection();
      IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
      double xvalue = ntervalXyDataset.getXValue(series, item);
      double startYvalue = ntervalXyDataset.getStartYValue(series, item);
      double endYvalue = ntervalXyDataset.getEndYValue(series, item);
      RectangleEdge domainAxisEdge = plot.getDomainAxisEdge();
      RectangleEdge rangeAxisEdge = plot.getRangeAxisEdge();
      double num1 = domainAxis.valueToJava2D(xvalue, dataArea, domainAxisEdge);
      double num2 = rangeAxis.valueToJava2D(startYvalue, dataArea, rangeAxisEdge);
      double num3 = rangeAxis.valueToJava2D(endYvalue, dataArea, rangeAxisEdge);
      Paint itemPaint = this.getItemPaint(series, item);
      Stroke itemStroke = this.getItemStroke(series, item);
      Line2D.Double @double = (Line2D.Double) null;
      Shape itemShape = this.getItemShape(series, item);
      Shape shape1 = (Shape) null;
      Shape shape2 = (Shape) null;
      PlotOrientation orientation = plot.getOrientation();
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        @double = new Line2D.Double(num2, num1, num3, num1);
        shape1 = ShapeUtilities.createTranslatedShape(itemShape, num3, num1);
        shape2 = ShapeUtilities.createTranslatedShape(itemShape, num2, num1);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        @double = new Line2D.Double(num1, num2, num1, num3);
        shape1 = ShapeUtilities.createTranslatedShape(itemShape, num1, num3);
        shape2 = ShapeUtilities.createTranslatedShape(itemShape, num1, num2);
      }
      g2.setPaint(itemPaint);
      g2.setStroke(itemStroke);
      g2.draw((Shape) @double);
      g2.fill(shape1);
      g2.fill(shape2);
      if (this.isItemLabelVisible(series, item))
      {
        this.drawItemLabel(g2, orientation, dataset, series, item, num1, num3, false);
        this.drawAdditionalItemLabel(g2, orientation, dataset, series, item, num1, num2);
      }
      if (entities == null)
        return;
      this.addEntity(entities, (Shape) ((Line2D) @double).getBounds(), dataset, series, item, 0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is YIntervalRenderer) || !ObjectUtilities.equal((object) this.additionalItemLabelGenerator, (object) ((YIntervalRenderer) obj).additionalItemLabelGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 320)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }
  }
}
