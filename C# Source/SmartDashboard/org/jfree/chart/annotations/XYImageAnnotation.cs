// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYImageAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.awt.image;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
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
  public class XYImageAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -4364694501921559958L;
    private double x;
    private double y;
    [NonSerialized]
    private Image image;
    private RectangleAnchor anchor;

    [LineNumberTable(new byte[] {(byte) 71, (byte) 104, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 105, (byte) 105, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYImageAnnotation(double x, double y, Image image, RectangleAnchor anchor)
    {
      XYImageAnnotation xyImageAnnotation = this;
      if (image == null)
      {
        string str = "Null 'image' argument.";
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
        this.x = x;
        this.y = y;
        this.image = image;
        this.anchor = anchor;
      }
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYImageAnnotation(double x, double y, Image image)
      : this(x, y, image, RectangleAnchor.__\u003C\u003ECENTER)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYImageAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYImageAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYImageAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getX()
    {
      return this.x;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual Image getImage()
    {
      return this.image;
    }

    public virtual RectangleAnchor getImageAnchor()
    {
      return this.anchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 103, (byte) 103, (byte) 103, (byte) 136, (byte) 137, (byte) 146, (byte) 147, (byte) 103, (byte) 103, (byte) 104, (byte) 100, (byte) 134, (byte) 104, (byte) 100, (byte) 132, (byte) 110, (byte) 142, (byte) 119, (byte) 143, (byte) 110, (byte) 110, (byte) 156, (byte) 104, (byte) 104, (byte) 104, (byte) 191, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      AxisLocation domainAxisLocation = plot.getDomainAxisLocation();
      AxisLocation rangeAxisLocation = plot.getRangeAxisLocation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(domainAxisLocation, orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(rangeAxisLocation, orientation);
      float num1 = (float) domainAxis.valueToJava2D(this.x, dataArea, re1);
      float num2 = (float) rangeAxis.valueToJava2D(this.y, dataArea, re2);
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
      int width = this.image.getWidth((ImageObserver) null);
      int height = this.image.getHeight((ImageObserver) null);
      Point2D point2D = RectangleAnchor.coordinates((Rectangle2D) new Rectangle2D.Double(0.0, 0.0, (double) width, (double) height), this.anchor);
      float num5 = num3 - (float) point2D.getX();
      float num6 = num4 - (float) point2D.getY();
      ((Graphics) g2).drawImage(this.image, ByteCodeHelper.f2i(num5), ByteCodeHelper.f2i(num6), (ImageObserver) null);
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, (Shape) new Rectangle2D.Float(num5, num6, (float) width, (float) height), rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 100, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYImageAnnotation))
        return false;
      XYImageAnnotation xyImageAnnotation = (XYImageAnnotation) obj;
      return this.x == xyImageAnnotation.x && this.y == xyImageAnnotation.y && (ObjectUtilities.equal((object) this.image, (object) xyImageAnnotation.image) && this.anchor.equals((object) xyImageAnnotation.anchor));
    }

    [LineNumberTable((ushort) 277)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return Object.instancehelper_hashCode((object) this.image);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 288)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
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
