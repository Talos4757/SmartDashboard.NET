// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.LineNeedle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.needle
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class LineNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 6215321387896748945L;

    [HideFromJava]
    static LineNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineNeedle()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LineNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LineNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LineNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 25, (byte) 134, (byte) 121, (byte) 148, (byte) 130, (byte) 141, (byte) 122, (byte) 178, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      Line2D.Double @double = new Line2D.Double();
      double num = ((RectangularShape) plotArea).getMinX() + ((RectangularShape) plotArea).getWidth() / 2.0;
      ((Line2D) @double).setLine(num, ((RectangularShape) plotArea).getMinY(), num, ((RectangularShape) plotArea).getMaxY());
      object obj1 = (object) @double;
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        obj1 = (object) this.getTransform().createTransformedShape((Shape) obj1);
      }
      Graphics2D g2_1 = g2;
      object obj2 = obj1;
      Shape shape1;
      if (obj2 != null)
      {
        Shape shape2 = obj2 as Shape;
        if (shape2 == null)
          throw new IncompatibleClassChangeError();
        shape1 = shape2;
      }
      else
        shape1 = (Shape) null;
      this.defaultDisplay(g2_1, shape1);
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LineNeedle))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
