// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.StandardDialRange
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
  public class StandardDialRange : AbstractDialLayer, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 345515648249364904L;
    private int scaleIndex;
    private double lowerBound;
    private double upperBound;
    [NonSerialized]
    private Paint paint;
    private double innerRadius;
    private double outerRadius;

    [LineNumberTable(new byte[] {(byte) 64, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 105, (byte) 105, (byte) 112, (byte) 112, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialRange(double lower, double upper, Paint paint)
    {
      StandardDialRange standardDialRange = this;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.scaleIndex = 0;
        this.lowerBound = lower;
        this.upperBound = upper;
        this.innerRadius = 0.48;
        this.outerRadius = 0.52;
        this.paint = paint;
      }
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardDialRange()
      : this(0.0, 100.0, (Paint) Color.white)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardDialRange([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardDialRange obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardDialRange obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int getScaleIndex()
    {
      return this.scaleIndex;
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setScaleIndex(int index)
    {
      this.scaleIndex = index;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getLowerBound()
    {
      return this.lowerBound;
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 106, (byte) 176, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLowerBound(double bound)
    {
      if (bound >= this.upperBound)
      {
        string str = "Lower bound must be less than upper bound.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lowerBound = bound;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getUpperBound()
    {
      return this.upperBound;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 106, (byte) 176, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpperBound(double bound)
    {
      if (bound <= this.lowerBound)
      {
        string str = "Lower bound must be less than upper bound.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.upperBound = bound;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 102, (byte) 176, (byte) 105, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBounds(double lower, double upper)
    {
      if (lower >= upper)
      {
        string str = "Lower must be less than upper.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lowerBound = lower;
        this.upperBound = upper;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual double getInnerRadius()
    {
      return this.innerRadius;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInnerRadius(double radius)
    {
      this.innerRadius = radius;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getOuterRadius()
    {
      return this.outerRadius;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 180, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOuterRadius(double radius)
    {
      this.outerRadius = radius;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public override bool isClippedToWindow()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 147, (byte) 179, (byte) 109, (byte) 99, (byte) 191, (byte) 11, (byte) 110, (byte) 143, (byte) 142, (byte) 175, (byte) 108, (byte) 112, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      Rectangle2D rectangle2D1 = DialPlot.rectangleByRadius(frame, this.innerRadius, this.innerRadius);
      Rectangle2D rectangle2D2 = DialPlot.rectangleByRadius(frame, this.outerRadius, this.outerRadius);
      DialScale scale = plot.getScale(this.scaleIndex);
      if (scale == null)
      {
        string str = new StringBuffer().append("No scale for scaleIndex = ").append(this.scaleIndex).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
      {
        double num1 = scale.valueToAngle(this.lowerBound);
        double num2 = scale.valueToAngle(this.upperBound);
        Arc2D.Double double1 = new Arc2D.Double(rectangle2D1, num1, num2 - num1, 0);
        Arc2D.Double double2 = new Arc2D.Double(rectangle2D2, num2, num1 - num2, 0);
        g2.setPaint(this.paint);
        g2.setStroke((Stroke) new BasicStroke(2f));
        g2.draw((Shape) double1);
        g2.draw((Shape) double2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardDialRange))
        return false;
      StandardDialRange standardDialRange = (StandardDialRange) obj;
      if (this.scaleIndex != standardDialRange.scaleIndex || this.lowerBound != standardDialRange.lowerBound || (this.upperBound != standardDialRange.upperBound || !PaintUtilities.equal(this.paint, standardDialRange.paint)) || (this.innerRadius != standardDialRange.innerRadius || this.outerRadius != standardDialRange.outerRadius))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 15, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.lowerBound);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.upperBound);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.innerRadius);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.outerRadius);
      return 37 * (37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32))) + HashUtilities.hashCodeForPaint(this.paint);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 407)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 62, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
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
