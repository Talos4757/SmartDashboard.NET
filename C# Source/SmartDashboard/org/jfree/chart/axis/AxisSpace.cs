// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.AxisSpace
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class AxisSpace : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -2490732595134766305L;
    private double top;
    private double bottom;
    private double left;
    private double right;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AxisSpace()
    {
      base.\u002Ector();
      AxisSpace axisSpace = this;
      this.top = 0.0;
      this.bottom = 0.0;
      this.left = 0.0;
      this.right = 0.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AxisSpace([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AxisSpace obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AxisSpace obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getTop()
    {
      return this.top;
    }

    public virtual void setTop(double space)
    {
      this.top = space;
    }

    public virtual double getBottom()
    {
      return this.bottom;
    }

    public virtual void setBottom(double space)
    {
      this.bottom = space;
    }

    public virtual double getLeft()
    {
      return this.left;
    }

    public virtual void setLeft(double space)
    {
      this.left = space;
    }

    public virtual double getRight()
    {
      return this.right;
    }

    public virtual void setRight(double space)
    {
      this.right = space;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 99, (byte) 144, (byte) 104, (byte) 146, (byte) 104, (byte) 146, (byte) 104, (byte) 146, (byte) 104, (byte) 178, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double space, RectangleEdge edge)
    {
      if (edge == null)
      {
        string str = "Null 'edge' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (edge == RectangleEdge.__\u003C\u003ETOP)
        this.top += space;
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        this.bottom += space;
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        this.left += space;
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
      {
        this.right += space;
      }
      else
      {
        string str = "Unrecognised 'edge' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 120, (byte) 120, (byte) 120, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ensureAtLeast(AxisSpace space)
    {
      this.top = Math.max(this.top, space.top);
      this.bottom = Math.max(this.bottom, space.bottom);
      this.left = Math.max(this.left, space.left);
      this.right = Math.max(this.right, space.right);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 104, (byte) 109, (byte) 174, (byte) 104, (byte) 106, (byte) 171, (byte) 104, (byte) 106, (byte) 171, (byte) 104, (byte) 106, (byte) 203, (byte) 208})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ensureAtLeast(double space, RectangleEdge edge)
    {
      if (edge == RectangleEdge.__\u003C\u003ETOP)
      {
        if (this.top >= space)
          return;
        this.top = space;
      }
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        if (this.bottom >= space)
          return;
        this.bottom = space;
      }
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
      {
        if (this.left >= space)
          return;
        this.left = space;
      }
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
      {
        if (this.right >= space)
          return;
        this.right = space;
      }
      else
      {
        string str = "AxisSpace.ensureAtLeast(): unrecognised AxisLocation.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 99, (byte) 135, (byte) 255, (byte) 41, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D shrink(Rectangle2D area, Rectangle2D result)
    {
      if (result == null)
        result = (Rectangle2D) new Rectangle2D.Double();
      result.setRect(((RectangularShape) area).getX() + this.left, ((RectangularShape) area).getY() + this.top, ((RectangularShape) area).getWidth() - this.left - this.right, ((RectangularShape) area).getHeight() - this.top - this.bottom);
      return result;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 99, (byte) 135, (byte) 255, (byte) 41, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D expand(Rectangle2D area, Rectangle2D result)
    {
      if (result == null)
        result = (Rectangle2D) new Rectangle2D.Double();
      result.setRect(((RectangularShape) area).getX() - this.left, ((RectangularShape) area).getY() - this.top, ((RectangularShape) area).getWidth() + this.left + this.right, ((RectangularShape) area).getHeight() + this.top + this.bottom);
      return result;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 98, (byte) 104, (byte) 223, (byte) 4, (byte) 104, (byte) 255, (byte) 8, (byte) 69, (byte) 104, (byte) 223, (byte) 1, (byte) 104, (byte) 255, (byte) 6, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D reserved(Rectangle2D area, RectangleEdge edge)
    {
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        @double = new Rectangle2D.Double(((RectangularShape) area).getX(), ((RectangularShape) area).getY(), ((RectangularShape) area).getWidth(), this.top);
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        @double = new Rectangle2D.Double(((RectangularShape) area).getX(), ((RectangularShape) area).getMaxY() - this.top, ((RectangularShape) area).getWidth(), this.bottom);
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        @double = new Rectangle2D.Double(((RectangularShape) area).getX(), ((RectangularShape) area).getY(), this.left, ((RectangularShape) area).getHeight());
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        @double = new Rectangle2D.Double(((RectangularShape) area).getMaxX() - this.right, ((RectangularShape) area).getY(), this.right, ((RectangularShape) area).getHeight());
      return (Rectangle2D) @double;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 317)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AxisSpace))
        return false;
      AxisSpace axisSpace = (AxisSpace) obj;
      return this.top == axisSpace.top && this.bottom == axisSpace.bottom && (this.left == axisSpace.left && this.right == axisSpace.right);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 99, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 23;
      long num2 = Double.doubleToLongBits(this.top);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.bottom);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.left);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.right);
      return 37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32));
    }

    [LineNumberTable((ushort) 374)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append(base.toString()).append("[left=").append(this.left).append(",right=").append(this.right).append(",top=").append(this.top).append(",bottom=").append(this.bottom).append("]").toString();
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
