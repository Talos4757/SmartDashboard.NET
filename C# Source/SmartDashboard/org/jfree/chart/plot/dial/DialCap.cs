// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialCap
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
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialLayer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DialCap : AbstractDialLayer, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = -2929484264982524463L;
    private double radius;
    [NonSerialized]
    private Paint fillPaint;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;

    [LineNumberTable(new byte[] {(byte) 52, (byte) 104, (byte) 112, (byte) 107, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DialCap()
    {
      DialCap dialCap = this;
      this.radius = 0.05;
      this.fillPaint = (Paint) Color.white;
      this.outlinePaint = (Paint) Color.black;
      this.outlineStroke = (Stroke) new BasicStroke(2f);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DialCap([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DialCap obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DialCap obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getRadius()
    {
      return this.radius;
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 105, (byte) 144, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadius(double radius)
    {
      if (radius <= 0.0)
      {
        string str = "Requires radius > 0.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.radius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getFillPaint()
    {
      return this.fillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFillPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.fillPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.outlinePaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.outlineStroke = stroke;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public override bool isClippedToWindow()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 128, (byte) 140, (byte) 147, (byte) 158, (byte) 103, (byte) 108, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      g2.setPaint(this.fillPaint);
      Rectangle2D rectangle2D = DialPlot.rectangleByRadius(frame, this.radius, this.radius);
      Ellipse2D.Double @double = new Ellipse2D.Double(((RectangularShape) rectangle2D).getX(), ((RectangularShape) rectangle2D).getY(), ((RectangularShape) rectangle2D).getWidth(), ((RectangularShape) rectangle2D).getHeight());
      g2.fill((Shape) @double);
      g2.setPaint(this.outlinePaint);
      g2.setStroke(this.outlineStroke);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DialCap))
        return false;
      DialCap dialCap = (DialCap) obj;
      if (this.radius != dialCap.radius || !PaintUtilities.equal(this.fillPaint, dialCap.fillPaint) || (!PaintUtilities.equal(this.outlinePaint, dialCap.outlinePaint) || !Object.instancehelper_equals((object) this.outlineStroke, (object) dialCap.outlineStroke)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 102, (byte) 113, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return 37 * (37 * (37 * 193 + HashUtilities.hashCodeForPaint(this.fillPaint)) + HashUtilities.hashCodeForPaint(this.outlinePaint)) + Object.instancehelper_hashCode((object) this.outlineStroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 308)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.fillPaint, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 221, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.fillPaint = SerialUtilities.readPaint(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
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
