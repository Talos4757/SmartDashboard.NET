﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.PinNeedle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
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
  public class PinNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -3787089953079863373L;

    [HideFromJava]
    static PinNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PinNeedle()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PinNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PinNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PinNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 27, (byte) 134, (byte) 140, (byte) 108, (byte) 157, (byte) 119, (byte) 101, (byte) 163, (byte) 112, (byte) 112, (byte) 109, (byte) 134, (byte) 102, (byte) 190, (byte) 105, (byte) 109, (byte) 141, (byte) 122, (byte) 173, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      GeneralPath generalPath = new GeneralPath();
      int num1 = ByteCodeHelper.d2i(((RectangularShape) plotArea).getMinY());
      int num2 = ByteCodeHelper.d2i(((RectangularShape) plotArea).getMaxY());
      int num3 = ByteCodeHelper.d2i(((RectangularShape) plotArea).getMinX() + ((RectangularShape) plotArea).getWidth() / 2.0);
      int num4 = ByteCodeHelper.d2i(((RectangularShape) plotArea).getWidth() / 10.0);
      if (num4 < 2)
        num4 = 2;
      ((Path2D.Float) generalPath).moveTo((float) (num3 - num4), (float) (num2 - num4));
      ((Path2D.Float) generalPath).lineTo((float) (num3 + num4), (float) (num2 - num4));
      ((Path2D.Float) generalPath).lineTo((float) num3, (float) (num1 + num4));
      ((Path2D) generalPath).closePath();
      int num5 = 4 * num4;
      Area area = new Area((Shape) new Ellipse2D.Double((double) (num3 - num5 / 2), ((RectangularShape) plotArea).getMaxY() - (double) num5, (double) num5, (double) num5));
      area.add(new Area((Shape) generalPath));
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        area.transform(this.getTransform());
      }
      this.defaultDisplay(g2, (Shape) area);
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is PinNeedle && base.equals(obj);
    }

    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
