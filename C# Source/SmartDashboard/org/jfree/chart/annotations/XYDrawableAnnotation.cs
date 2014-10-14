// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYDrawableAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
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
  public class XYDrawableAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -6540812859722691020L;
    private double drawScaleFactor;
    private double x;
    private double y;
    private double displayWidth;
    private double displayHeight;
    private Drawable drawable;

    [LineNumberTable(new byte[] {(byte) 68, (byte) 136, (byte) 100, (byte) 144, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDrawableAnnotation(double x, double y, double displayWidth, double displayHeight, double drawScaleFactor, Drawable drawable)
    {
      XYDrawableAnnotation drawableAnnotation = this;
      if (drawable == null)
      {
        string str = "Null 'drawable' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.x = x;
        this.y = y;
        this.displayWidth = displayWidth;
        this.displayHeight = displayHeight;
        this.drawScaleFactor = drawScaleFactor;
        this.drawable = drawable;
      }
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYDrawableAnnotation(double x, double y, double width, double height, Drawable drawable)
      : this(x, y, width, height, 1.0, drawable)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYDrawableAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYDrawableAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYDrawableAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 103, (byte) 141, (byte) 141, (byte) 145, (byte) 146, (byte) 255, (byte) 27, (byte) 72, (byte) 104, (byte) 223, (byte) 12, (byte) 126, (byte) 159, (byte) 28, (byte) 110, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      float num1 = (float) domainAxis.valueToJava2D(this.x, dataArea, re1);
      float num2 = (float) rangeAxis.valueToJava2D(this.y, dataArea, re2);
      Rectangle2D.Double double1 = new Rectangle2D.Double((double) num1 - this.displayWidth / 2.0, (double) num2 - this.displayHeight / 2.0, this.displayWidth, this.displayHeight);
      AffineTransform transform = g2.getTransform();
      Rectangle2D.Double double2 = new Rectangle2D.Double(0.0, 0.0, this.displayWidth * this.drawScaleFactor, this.displayHeight * this.drawScaleFactor);
      g2.scale(1.0 / this.drawScaleFactor, 1.0 / this.drawScaleFactor);
      g2.translate(((double) num1 - this.displayWidth / 2.0) * this.drawScaleFactor, ((double) num2 - this.displayHeight / 2.0) * this.drawScaleFactor);
      this.drawable.draw(g2, (Rectangle2D) double2);
      g2.setTransform(transform);
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, (Shape) double1, rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 100, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYDrawableAnnotation))
        return false;
      XYDrawableAnnotation drawableAnnotation = (XYDrawableAnnotation) obj;
      return this.x == drawableAnnotation.x && this.y == drawableAnnotation.y && (this.displayWidth == drawableAnnotation.displayWidth && this.displayHeight == drawableAnnotation.displayHeight) && (this.drawScaleFactor == drawableAnnotation.drawScaleFactor && ObjectUtilities.equal((object) this.drawable, (object) drawableAnnotation.drawable));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      long num1 = Double.doubleToLongBits(this.x);
      int num2 = (int) (num1 ^ (long) ((ulong) num1 >> 32));
      long num3 = Double.doubleToLongBits(this.y);
      int num4 = 29 * num2 + (int) (num3 ^ (long) ((ulong) num3 >> 32));
      long num5 = Double.doubleToLongBits(this.displayWidth);
      int num6 = 29 * num4 + (int) (num5 ^ (long) ((ulong) num5 >> 32));
      long num7 = Double.doubleToLongBits(this.displayHeight);
      return 29 * num6 + (int) (num7 ^ (long) ((ulong) num7 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 254)]
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
