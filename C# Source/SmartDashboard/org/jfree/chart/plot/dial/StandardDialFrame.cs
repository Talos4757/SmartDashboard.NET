// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.StandardDialFrame
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
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialFrame", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardDialFrame : AbstractDialLayer, DialFrame, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 1016585407507121596L;
    private double radius;
    [NonSerialized]
    private Paint backgroundPaint;
    [NonSerialized]
    private Paint foregroundPaint;
    [NonSerialized]
    private Stroke stroke;

    [LineNumberTable(new byte[] {(byte) 49, (byte) 104, (byte) 107, (byte) 107, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialFrame()
    {
      StandardDialFrame standardDialFrame = this;
      this.backgroundPaint = (Paint) Color.gray;
      this.foregroundPaint = (Paint) Color.black;
      this.stroke = (Stroke) new BasicStroke(2f);
      this.radius = 0.95;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardDialFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardDialFrame obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardDialFrame obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape getWindow(Rectangle2D frame)
    {
      Rectangle2D rectangle2D = DialPlot.rectangleByRadius(frame, this.radius, this.radius);
      return (Shape) new Ellipse2D.Double(((RectangularShape) rectangle2D).getX(), ((RectangularShape) rectangle2D).getY(), ((RectangularShape) rectangle2D).getWidth(), ((RectangularShape) rectangle2D).getHeight());
    }

    public virtual double getRadius()
    {
      return this.radius;
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 105, (byte) 176, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadius(double radius)
    {
      if (radius <= 0.0)
      {
        string str = "The 'radius' must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.radius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.backgroundPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getForegroundPaint()
    {
      return this.foregroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setForegroundPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.foregroundPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Stroke getStroke()
    {
      return this.stroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.stroke = stroke;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public override bool isClippedToWindow()
    {
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 136, (byte) 159, (byte) 8, (byte) 190, (byte) 103, (byte) 104, (byte) 104, (byte) 108, (byte) 135, (byte) 108, (byte) 108, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      Shape window = this.getWindow(frame);
      Rectangle2D rectangle2D = DialPlot.rectangleByRadius(frame, this.radius + 0.02, this.radius + 0.02);
      Ellipse2D.Double @double = new Ellipse2D.Double(((RectangularShape) rectangle2D).getX(), ((RectangularShape) rectangle2D).getY(), ((RectangularShape) rectangle2D).getWidth(), ((RectangularShape) rectangle2D).getHeight());
      Area area1 = new Area((Shape) @double);
      Area area2 = new Area(window);
      area1.subtract(area2);
      g2.setPaint(this.backgroundPaint);
      g2.fill((Shape) area1);
      g2.setStroke(this.stroke);
      g2.setPaint(this.foregroundPaint);
      g2.draw(window);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardDialFrame))
        return false;
      StandardDialFrame standardDialFrame = (StandardDialFrame) obj;
      if (!PaintUtilities.equal(this.backgroundPaint, standardDialFrame.backgroundPaint) || !PaintUtilities.equal(this.foregroundPaint, standardDialFrame.foregroundPaint) || (this.radius != standardDialFrame.radius || !Object.instancehelper_equals((object) this.stroke, (object) standardDialFrame.stroke)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 102, (byte) 108, (byte) 109, (byte) 145, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.radius);
      return 37 * (37 * (37 * (37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32))) + HashUtilities.hashCodeForPaint(this.backgroundPaint)) + HashUtilities.hashCodeForPaint(this.foregroundPaint)) + Object.instancehelper_hashCode((object) this.stroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 327)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
      SerialUtilities.writePaint(this.foregroundPaint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 240, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.foregroundPaint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
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
