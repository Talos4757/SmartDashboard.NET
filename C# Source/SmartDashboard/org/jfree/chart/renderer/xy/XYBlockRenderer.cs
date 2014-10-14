// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYBlockRenderer
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
using org.jfree.chart.renderer;
using org.jfree.data;
using org.jfree.data.general;
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
  public class XYBlockRenderer : AbstractXYItemRenderer, XYItemRenderer, LegendItemSource, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private double blockWidth;
    private double blockHeight;
    private RectangleAnchor blockAnchor;
    private double xOffset;
    private double yOffset;
    private PaintScale paintScale;

    [HideFromJava]
    static XYBlockRenderer()
    {
      AbstractXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 232, (byte) 38, (byte) 236, (byte) 69, (byte) 236, (byte) 70, (byte) 235, (byte) 80, (byte) 102, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBlockRenderer()
    {
      XYBlockRenderer xyBlockRenderer = this;
      this.blockWidth = 1.0;
      this.blockHeight = 1.0;
      this.blockAnchor = RectangleAnchor.__\u003C\u003ECENTER;
      this.updateOffsets();
      this.paintScale = (PaintScale) new LookupPaintScale();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYBlockRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYBlockRenderer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYBlockRenderer obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 114, (byte) 108, (byte) 145, (byte) 114, (byte) 120, (byte) 145, (byte) 114, (byte) 110, (byte) 145, (byte) 114, (byte) 108, (byte) 157, (byte) 114, (byte) 120, (byte) 157, (byte) 114, (byte) 110, (byte) 157, (byte) 114, (byte) 108, (byte) 144, (byte) 114, (byte) 120, (byte) 144, (byte) 114, (byte) 110, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateOffsets()
    {
      if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_LEFT))
      {
        this.xOffset = 0.0;
        this.yOffset = 0.0;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM))
      {
        this.xOffset = -this.blockWidth / 2.0;
        this.yOffset = 0.0;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003EBOTTOM_RIGHT))
      {
        this.xOffset = -this.blockWidth;
        this.yOffset = 0.0;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003ELEFT))
      {
        this.xOffset = 0.0;
        this.yOffset = -this.blockHeight / 2.0;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003ECENTER))
      {
        this.xOffset = -this.blockWidth / 2.0;
        this.yOffset = -this.blockHeight / 2.0;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003ERIGHT))
      {
        this.xOffset = -this.blockWidth;
        this.yOffset = -this.blockHeight / 2.0;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003ETOP_LEFT))
      {
        this.xOffset = 0.0;
        this.yOffset = -this.blockHeight;
      }
      else if (this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003ETOP))
      {
        this.xOffset = -this.blockWidth / 2.0;
        this.yOffset = -this.blockHeight;
      }
      else
      {
        if (!this.blockAnchor.equals((object) RectangleAnchor.__\u003C\u003ETOP_RIGHT))
          return;
        this.xOffset = -this.blockWidth;
        this.yOffset = -this.blockHeight;
      }
    }

    public virtual double getBlockWidth()
    {
      return this.blockWidth;
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 105, (byte) 176, (byte) 105, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBlockWidth(double width)
    {
      if (width <= 0.0)
      {
        string str = "The 'width' argument must be > 0.0";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.blockWidth = width;
        this.updateOffsets();
        this.fireChangeEvent();
      }
    }

    public virtual double getBlockHeight()
    {
      return this.blockHeight;
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 105, (byte) 176, (byte) 105, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBlockHeight(double height)
    {
      if (height <= 0.0)
      {
        string str = "The 'height' argument must be > 0.0";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.blockHeight = height;
        this.updateOffsets();
        this.fireChangeEvent();
      }
    }

    public virtual RectangleAnchor getBlockAnchor()
    {
      return this.blockAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 99, (byte) 144, (byte) 110, (byte) 129, (byte) 103, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBlockAnchor(RectangleAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.blockAnchor.equals((object) anchor))
          return;
        this.blockAnchor = anchor;
        this.updateOffsets();
        this.fireChangeEvent();
      }
    }

    public virtual PaintScale getPaintScale()
    {
      return this.paintScale;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 99, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaintScale(PaintScale scale)
    {
      if (scale == null)
      {
        string str = "Null 'scale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paintScale = scale;
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 99, (byte) 104, (byte) 99, (byte) 162, (byte) 255, (byte) 10, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findDomainBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      Range domainBounds = DatasetUtilities.findDomainBounds(dataset, false);
      if (domainBounds == null)
        return (Range) null;
      return new Range(domainBounds.getLowerBound() + this.xOffset, domainBounds.getUpperBound() + this.blockWidth + this.xOffset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 99, (byte) 104, (byte) 99, (byte) 162, (byte) 255, (byte) 10, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range findRangeBounds(XYDataset dataset)
    {
      if (dataset == null)
        return (Range) null;
      Range rangeBounds = DatasetUtilities.findRangeBounds(dataset, false);
      if (rangeBounds == null)
        return (Range) null;
      return new Range(rangeBounds.getLowerBound() + this.yOffset, rangeBounds.getUpperBound() + this.blockHeight + this.yOffset);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 109, (byte) 109, (byte) 102, (byte) 105, (byte) 146, (byte) 109, (byte) 154, (byte) 154, (byte) 159, (byte) 2, (byte) 191, (byte) 2, (byte) 105, (byte) 110, (byte) 255, (byte) 16, (byte) 69, (byte) 223, (byte) 14, (byte) 103, (byte) 104, (byte) 112, (byte) 136, (byte) 104, (byte) 100, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      double xvalue = dataset.getXValue(series, item);
      double yvalue = dataset.getYValue(series, item);
      double d = 0.0;
      if (dataset is XYZDataset)
        d = ((XYZDataset) dataset).getZValue(series, item);
      Paint paint = this.paintScale.getPaint(d);
      double num1 = domainAxis.valueToJava2D(xvalue + this.xOffset, dataArea, plot.getDomainAxisEdge());
      double num2 = rangeAxis.valueToJava2D(yvalue + this.yOffset, dataArea, plot.getRangeAxisEdge());
      double num3 = domainAxis.valueToJava2D(xvalue + this.blockWidth + this.xOffset, dataArea, plot.getDomainAxisEdge());
      double num4 = rangeAxis.valueToJava2D(yvalue + this.blockHeight + this.yOffset, dataArea, plot.getRangeAxisEdge());
      Rectangle2D.Double @double = !plot.getOrientation().equals((object) PlotOrientation.__\u003C\u003EHORIZONTAL) ? new Rectangle2D.Double(Math.min(num1, num3), Math.min(num2, num4), Math.abs(num3 - num1), Math.abs(num4 - num2)) : new Rectangle2D.Double(Math.min(num2, num4), Math.min(num1, num3), Math.abs(num4 - num2), Math.abs(num1 - num3));
      g2.setPaint(paint);
      g2.fill((Shape) @double);
      g2.setStroke((Stroke) new BasicStroke(1f));
      g2.draw((Shape) @double);
      EntityCollection entityCollection = state.getEntityCollection();
      if (entityCollection == null)
        return;
      this.addEntity(entityCollection, (Shape) @double, dataset, series, item, 0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYBlockRenderer))
        return false;
      XYBlockRenderer xyBlockRenderer = (XYBlockRenderer) obj;
      if (this.blockHeight != xyBlockRenderer.blockHeight || this.blockWidth != xyBlockRenderer.blockWidth || (!this.blockAnchor.equals((object) xyBlockRenderer.blockAnchor) || !Object.instancehelper_equals((object) this.paintScale, (object) xyBlockRenderer.paintScale)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 71, (byte) 108, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYBlockRenderer xyBlockRenderer = (XYBlockRenderer) base.clone();
      if (this.paintScale is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.paintScale;
        xyBlockRenderer.paintScale = (PaintScale) publicCloneable.clone();
      }
      return (object) xyBlockRenderer;
    }
  }
}
