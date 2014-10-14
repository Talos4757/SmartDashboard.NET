// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYTitleAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.block;
using org.jfree.chart.plot;
using org.jfree.chart.title;
using org.jfree.chart.util;
using org.jfree.data;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYTitleAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -4364694501921559958L;
    private XYCoordinateType coordinateType;
    private double x;
    private double y;
    private double maxWidth;
    private double maxHeight;
    private Title title;
    private RectangleAnchor anchor;

    [LineNumberTable(new byte[] {(byte) 78, (byte) 104, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 107, (byte) 105, (byte) 105, (byte) 108, (byte) 108, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYTitleAnnotation(double x, double y, Title title, RectangleAnchor anchor)
    {
      XYTitleAnnotation xyTitleAnnotation = this;
      if (title == null)
      {
        string str = "Null 'title' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.coordinateType = XYCoordinateType.__\u003C\u003ERELATIVE;
        this.x = x;
        this.y = y;
        this.maxWidth = 0.0;
        this.maxHeight = 0.0;
        this.title = title;
        this.anchor = anchor;
      }
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYTitleAnnotation(double x, double y, Title title)
      : this(x, y, title, RectangleAnchor.__\u003C\u003ECENTER)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYTitleAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYTitleAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYTitleAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual XYCoordinateType getCoordinateType()
    {
      return this.coordinateType;
    }

    public virtual double getX()
    {
      return this.x;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual Title getTitle()
    {
      return this.title;
    }

    public virtual RectangleAnchor getTitleAnchor()
    {
      return this.anchor;
    }

    public virtual double getMaxWidth()
    {
      return this.maxWidth;
    }

    public virtual void setMaxWidth(double max)
    {
      this.maxWidth = max;
    }

    public virtual double getMaxHeight()
    {
      return this.maxHeight;
    }

    public virtual void setMaxHeight(double max)
    {
      this.maxHeight = max;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 103, (byte) 103, (byte) 103, (byte) 136, (byte) 137, (byte) 105, (byte) 105, (byte) 102, (byte) 102, (byte) 109, (byte) 121, (byte) 187, (byte) 114, (byte) 179, (byte) 142, (byte) 143, (byte) 103, (byte) 103, (byte) 104, (byte) 100, (byte) 134, (byte) 104, (byte) 100, (byte) 164, (byte) 105, (byte) 105, (byte) 109, (byte) 109, (byte) 140, (byte) 109, (byte) 172, (byte) 109, (byte) 104, (byte) 136, (byte) 191, (byte) 5, (byte) 112, (byte) 159, (byte) 0, (byte) 143, (byte) 110, (byte) 110, (byte) 123, (byte) 103, (byte) 100, (byte) 110, (byte) 168, (byte) 114, (byte) 103, (byte) 105, (byte) 105, (byte) 184, (byte) 104, (byte) 104, (byte) 104, (byte) 255, (byte) 10, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      AxisLocation domainAxisLocation = plot.getDomainAxisLocation();
      AxisLocation rangeAxisLocation = plot.getRangeAxisLocation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(domainAxisLocation, orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(rangeAxisLocation, orientation);
      Range range1 = domainAxis.getRange();
      Range range2 = rangeAxis.getRange();
      double d1;
      double d2;
      if (this.coordinateType == XYCoordinateType.__\u003C\u003ERELATIVE)
      {
        d1 = range1.getLowerBound() + this.x * range1.getLength();
        d2 = range2.getLowerBound() + this.y * range2.getLength();
      }
      else
      {
        d1 = domainAxis.valueToJava2D(this.x, dataArea, re1);
        d2 = rangeAxis.valueToJava2D(this.y, dataArea, re2);
      }
      float num1 = (float) domainAxis.valueToJava2D(d1, dataArea, re1);
      float num2 = (float) rangeAxis.valueToJava2D(d2, dataArea, re2);
      float num3 = 0.0f;
      float num4 = 0.0f;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num3 = num2;
        num4 = num1;
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        num3 = num1;
        num4 = num2;
      }
      double upper1 = ((RectangularShape) dataArea).getWidth();
      double upper2 = ((RectangularShape) dataArea).getHeight();
      if (this.coordinateType == XYCoordinateType.__\u003C\u003ERELATIVE)
      {
        if (this.maxWidth > 0.0)
          upper1 *= this.maxWidth;
        if (this.maxHeight > 0.0)
          upper2 *= this.maxHeight;
      }
      if (this.coordinateType == XYCoordinateType.__\u003C\u003EDATA)
      {
        upper1 = this.maxWidth;
        upper2 = this.maxHeight;
      }
      RectangleConstraint.__\u003Cclinit\u003E();
      RectangleConstraint constraint = new RectangleConstraint(new Range(0.0, upper1), new Range(0.0, upper2));
      Size2D size2D = this.title.arrange(g2, constraint);
      Rectangle2D.Double @double = new Rectangle2D.Double(0.0, 0.0, size2D.width, size2D.height);
      Point2D point2D = RectangleAnchor.coordinates((Rectangle2D) @double, this.anchor);
      float num5 = num3 - (float) point2D.getX();
      float num6 = num4 - (float) point2D.getY();
      ((Rectangle2D) @double).setRect((double) num5, (double) num6, ((RectangularShape) @double).getWidth(), ((RectangularShape) @double).getHeight());
      BlockParams blockParams = new BlockParams();
      if (info != null && info.getOwner().getEntityCollection() != null)
        blockParams.setGenerateEntities(true);
      object obj = this.title.draw(g2, (Rectangle2D) @double, (object) blockParams);
      if (info == null)
        return;
      if (obj is EntityBlockResult)
      {
        EntityBlockResult entityBlockResult = (EntityBlockResult) obj;
        info.getOwner().getEntityCollection().addAll(entityBlockResult.getEntityCollection());
      }
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, (Shape) new Rectangle2D.Float(num5, num6, (float) size2D.width, (float) size2D.height), rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 221, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYTitleAnnotation))
        return false;
      XYTitleAnnotation xyTitleAnnotation = (XYTitleAnnotation) obj;
      if (this.coordinateType != xyTitleAnnotation.coordinateType || this.x != xyTitleAnnotation.x || (this.y != xyTitleAnnotation.y || this.maxWidth != xyTitleAnnotation.maxWidth) || (this.maxHeight != xyTitleAnnotation.maxHeight || !ObjectUtilities.equal((object) this.title, (object) xyTitleAnnotation.title) || !this.anchor.equals((object) xyTitleAnnotation.anchor)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 2, (byte) 102, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(193, (object) this.anchor), (object) this.coordinateType), this.x), this.y), this.maxWidth), this.maxHeight), (object) this.title);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 391)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
