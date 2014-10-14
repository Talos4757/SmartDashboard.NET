// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.ArcDialFrame
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
  public class ArcDialFrame : AbstractDialLayer, DialFrame, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = -4089176959553523499L;
    [NonSerialized]
    private Paint backgroundPaint;
    [NonSerialized]
    private Paint foregroundPaint;
    [NonSerialized]
    private Stroke stroke;
    private double startAngle;
    private double extent;
    private double innerRadius;
    private double outerRadius;

    [LineNumberTable(new byte[] {(byte) 78, (byte) 104, (byte) 107, (byte) 116, (byte) 112, (byte) 112, (byte) 112, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArcDialFrame(double startAngle, double extent)
    {
      ArcDialFrame arcDialFrame = this;
      this.backgroundPaint = (Paint) Color.gray;
      this.foregroundPaint = (Paint) new Color(100, 100, 150);
      this.stroke = (Stroke) new BasicStroke(2f);
      this.innerRadius = 0.25;
      this.outerRadius = 0.75;
      this.startAngle = startAngle;
      this.extent = extent;
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArcDialFrame()
      : this(0.0, 180.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ArcDialFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ArcDialFrame obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ArcDialFrame obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 217, (byte) 147, (byte) 147, (byte) 148, (byte) 156, (byte) 103, (byte) 104, (byte) 119, (byte) 105, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape getWindow(Rectangle2D frame)
    {
      Rectangle2D rectangle2D1 = DialPlot.rectangleByRadius(frame, this.innerRadius, this.innerRadius);
      Rectangle2D rectangle2D2 = DialPlot.rectangleByRadius(frame, this.outerRadius, this.outerRadius);
      Arc2D.Double double1 = new Arc2D.Double(rectangle2D1, this.startAngle, this.extent, 0);
      Arc2D.Double double2 = new Arc2D.Double(rectangle2D2, this.startAngle + this.extent, -this.extent, 0);
      GeneralPath generalPath = new GeneralPath();
      Point2D startPoint = ((Arc2D) double1).getStartPoint();
      ((Path2D.Float) generalPath).moveTo((float) startPoint.getX(), (float) startPoint.getY());
      ((Path2D) generalPath).append((Shape) double1, true);
      ((Path2D) generalPath).append((Shape) double2, true);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 106, (byte) 106, (byte) 183, (byte) 183, (byte) 159, (byte) 4, (byte) 191, (byte) 12, (byte) 103, (byte) 105, (byte) 119, (byte) 106, (byte) 106, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Shape getOuterWindow(Rectangle2D frame)
    {
      double num1 = 0.02;
      double num2 = 1.5;
      Rectangle2D rectangle2D1 = DialPlot.rectangleByRadius(frame, this.innerRadius - num1, this.innerRadius - num1);
      Rectangle2D rectangle2D2 = DialPlot.rectangleByRadius(frame, this.outerRadius + num1, this.outerRadius + num1);
      Arc2D.Double double1 = new Arc2D.Double(rectangle2D1, this.startAngle - num2, this.extent + 2.0 * num2, 0);
      Arc2D.Double double2 = new Arc2D.Double(rectangle2D2, this.startAngle + num2 + this.extent, -this.extent - 2.0 * num2, 0);
      GeneralPath generalPath = new GeneralPath();
      Point2D startPoint = ((Arc2D) double1).getStartPoint();
      ((Path2D.Float) generalPath).moveTo((float) startPoint.getX(), (float) startPoint.getY());
      ((Path2D) generalPath).append((Shape) double1, true);
      ((Path2D) generalPath).append((Shape) double2, true);
      ((Path2D) generalPath).closePath();
      return (Shape) generalPath;
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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

    public virtual double getInnerRadius()
    {
      return this.innerRadius;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 105, (byte) 144, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInnerRadius(double radius)
    {
      if (radius < 0.0)
      {
        string str = "Negative 'radius' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.innerRadius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getOuterRadius()
    {
      return this.outerRadius;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 105, (byte) 144, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOuterRadius(double radius)
    {
      if (radius < 0.0)
      {
        string str = "Negative 'radius' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.outerRadius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getStartAngle()
    {
      return this.startAngle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartAngle(double angle)
    {
      this.startAngle = angle;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getExtent()
    {
      return this.extent;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExtent(double extent)
    {
      this.extent = extent;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 104, (byte) 136, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 135, (byte) 108, (byte) 108, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      Shape window = this.getWindow(frame);
      Shape outerWindow = this.getOuterWindow(frame);
      Area area1 = new Area(outerWindow);
      Area area2 = new Area(window);
      area1.subtract(area2);
      g2.setPaint((Paint) Color.lightGray);
      g2.fill((Shape) area1);
      g2.setStroke(this.stroke);
      g2.setPaint(this.foregroundPaint);
      g2.draw(window);
      g2.draw(outerWindow);
    }

    public override bool isClippedToWindow()
    {
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ArcDialFrame))
        return false;
      ArcDialFrame arcDialFrame = (ArcDialFrame) obj;
      if (!PaintUtilities.equal(this.backgroundPaint, arcDialFrame.backgroundPaint) || !PaintUtilities.equal(this.foregroundPaint, arcDialFrame.foregroundPaint) || (this.startAngle != arcDialFrame.startAngle || this.extent != arcDialFrame.extent) || (this.innerRadius != arcDialFrame.innerRadius || this.outerRadius != arcDialFrame.outerRadius || !Object.instancehelper_equals((object) this.stroke, (object) arcDialFrame.stroke)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 91, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 145, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.startAngle);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.extent);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.innerRadius);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.outerRadius);
      return 37 * (37 * (37 * (37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32))) + HashUtilities.hashCodeForPaint(this.backgroundPaint)) + HashUtilities.hashCodeForPaint(this.foregroundPaint)) + Object.instancehelper_hashCode((object) this.stroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 487)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 128, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
      SerialUtilities.writePaint(this.foregroundPaint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 144, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
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
