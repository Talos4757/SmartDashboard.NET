// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.PlumNeedle
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
  public class PlumNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -3082660488660600718L;

    [HideFromJava]
    static PlumNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlumNeedle()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PlumNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PlumNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PlumNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 25, (byte) 103, (byte) 104, (byte) 114, (byte) 141, (byte) 186, (byte) 111, (byte) 113, (byte) 145, (byte) 136, (byte) 141, (byte) 122, (byte) 173, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      Arc2D.Double @double = new Arc2D.Double(2);
      double height = ((RectangularShape) plotArea).getHeight();
      double num1 = ((RectangularShape) plotArea).getWidth() / 2.0;
      double num2 = 2.0 * height;
      ((Arc2D) @double).setFrame(((RectangularShape) plotArea).getMinX() + num1 - height, ((RectangularShape) plotArea).getMinY() - height, num2, num2);
      double num3 = Math.toDegrees(Math.asin(num1 / height));
      ((Arc2D) @double).setAngleStart(270.0 - num3);
      ((Arc2D) @double).setAngleExtent(2.0 * num3);
      Area area = new Area((Shape) @double);
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        area.transform(this.getTransform());
      }
      this.defaultDisplay(g2, (Shape) area);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is PlumNeedle && base.equals(obj);
    }

    [LineNumberTable((ushort) 124)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
