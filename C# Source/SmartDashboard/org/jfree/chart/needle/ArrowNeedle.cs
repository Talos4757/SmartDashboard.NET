// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.ArrowNeedle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.needle
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class ArrowNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -5334056511213782357L;
    private bool isArrowAtTop;

    [HideFromJava]
    static ArrowNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 162, (byte) 232, (byte) 56, (byte) 231, (byte) 73, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrowNeedle(bool isArrowAtTop)
    {
      int num = isArrowAtTop ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      ArrowNeedle arrowNeedle = this;
      this.isArrowAtTop = true;
      this.isArrowAtTop = num != 0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ArrowNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ArrowNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ArrowNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 44, (byte) 102, (byte) 130, (byte) 121, (byte) 104, (byte) 104, (byte) 142, (byte) 103, (byte) 104, (byte) 105, (byte) 175, (byte) 105, (byte) 141, (byte) 114, (byte) 114, (byte) 135, (byte) 109, (byte) 122, (byte) 176, (byte) 131, (byte) 156, (byte) 109, (byte) 177, (byte) 132, (byte) 158})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      Line2D.Float @float = new Line2D.Float();
      float num1 = (float) (((RectangularShape) plotArea).getMinX() + ((RectangularShape) plotArea).getWidth() / 2.0);
      float num2 = (float) ((RectangularShape) plotArea).getMinY();
      float num3 = (float) ((RectangularShape) plotArea).getMaxY();
      ((Line2D) @float).setLine((double) num1, (double) num2, (double) num1, (double) num3);
      GeneralPath generalPath = new GeneralPath();
      float num4;
      if (this.isArrowAtTop)
      {
        ((Path2D.Float) generalPath).moveTo(num1, num2);
        num4 = num2 + (float) (4 * this.getSize());
      }
      else
      {
        ((Path2D.Float) generalPath).moveTo(num1, num3);
        num4 = num3 - (float) (4 * this.getSize());
      }
      ((Path2D.Float) generalPath).lineTo(num1 + (float) this.getSize(), num4);
      ((Path2D.Float) generalPath).lineTo(num1 - (float) this.getSize(), num4);
      ((Path2D) generalPath).closePath();
      object obj1;
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        obj1 = (object) this.getTransform().createTransformedShape((Shape) @float);
      }
      else
        obj1 = (object) @float;
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
      object obj3 = rotate == null || angle == 0.0 ? (object) generalPath : (object) this.getTransform().createTransformedShape((Shape) generalPath);
      Graphics2D g2_2 = g2;
      object obj4 = obj3;
      Shape shape3;
      if (obj4 != null)
      {
        Shape shape2 = obj4 as Shape;
        if (shape2 == null)
          throw new IncompatibleClassChangeError();
        shape3 = shape2;
      }
      else
        shape3 = (Shape) null;
      this.defaultDisplay(g2_2, shape3);
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is ArrowNeedle && base.equals(obj) && this.isArrowAtTop == ((ArrowNeedle) obj).isArrowAtTop;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return HashUtilities.hashCode(base.hashCode(), this.isArrowAtTop);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 178)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
