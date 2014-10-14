// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.LongNeedle
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
  public class LongNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -4319985779783688159L;

    [HideFromJava]
    static LongNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LongNeedle()
    {
      LongNeedle longNeedle = this;
      this.setRotateY(0.8);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LongNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LongNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LongNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 33, (byte) 102, (byte) 102, (byte) 134, (byte) 104, (byte) 105, (byte) 105, (byte) 169, (byte) 118, (byte) 119, (byte) 115, (byte) 102, (byte) 132, (byte) 105, (byte) 106, (byte) 106, (byte) 134, (byte) 106, (byte) 106, (byte) 106, (byte) 134, (byte) 105, (byte) 106, (byte) 106, (byte) 106, (byte) 134, (byte) 99, (byte) 99, (byte) 131, (byte) 141, (byte) 122, (byte) 109, (byte) 109, (byte) 205, (byte) 104, (byte) 108, (byte) 187, (byte) 104, (byte) 108, (byte) 123, (byte) 219, (byte) 107, (byte) 108, (byte) 108, (byte) 123, (byte) 123, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      GeneralPath generalPath1 = new GeneralPath();
      GeneralPath generalPath2 = new GeneralPath();
      GeneralPath generalPath3 = new GeneralPath();
      float num1 = (float) ((RectangularShape) plotArea).getMinX();
      float num2 = (float) ((RectangularShape) plotArea).getMinY();
      float num3 = (float) ((RectangularShape) plotArea).getMaxX();
      float num4 = (float) ((RectangularShape) plotArea).getMaxY();
      float num5 = num1 + (float) (((RectangularShape) plotArea).getWidth() * 0.5);
      float num6 = num2 + (float) (((RectangularShape) plotArea).getHeight() * 0.8);
      float num7 = num4 - 2f * (num4 - num6);
      if ((double) num7 < (double) num2)
        num7 = num2;
      ((Path2D.Float) generalPath1).moveTo(num1, num6);
      ((Path2D.Float) generalPath1).lineTo(num5, num2);
      ((Path2D.Float) generalPath1).lineTo(num5, num7);
      ((Path2D) generalPath1).closePath();
      ((Path2D.Float) generalPath2).moveTo(num3, num6);
      ((Path2D.Float) generalPath2).lineTo(num5, num2);
      ((Path2D.Float) generalPath2).lineTo(num5, num7);
      ((Path2D) generalPath2).closePath();
      ((Path2D.Float) generalPath3).moveTo(num1, num6);
      ((Path2D.Float) generalPath3).lineTo(num5, num4);
      ((Path2D.Float) generalPath3).lineTo(num3, num6);
      ((Path2D.Float) generalPath3).lineTo(num5, num7);
      ((Path2D) generalPath3).closePath();
      object obj1 = (object) generalPath1;
      object obj2 = (object) generalPath2;
      object obj3 = (object) generalPath3;
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        obj1 = (object) ((Path2D) generalPath1).createTransformedShape(MeterNeedle.transform);
        obj2 = (object) ((Path2D) generalPath2).createTransformedShape(MeterNeedle.transform);
        obj3 = (object) ((Path2D) generalPath3).createTransformedShape(MeterNeedle.transform);
      }
      if (this.getHighlightPaint() != null)
      {
        g2.setPaint(this.getHighlightPaint());
        Graphics2D graphics2D = g2;
        object obj4 = obj3;
        Shape shape1;
        if (obj4 != null)
        {
          Shape shape2 = obj4 as Shape;
          if (shape2 == null)
            throw new IncompatibleClassChangeError();
          shape1 = shape2;
        }
        else
          shape1 = (Shape) null;
        graphics2D.fill(shape1);
      }
      if (this.getFillPaint() != null)
      {
        g2.setPaint(this.getFillPaint());
        Graphics2D graphics2D1 = g2;
        object obj4 = obj1;
        Shape shape1;
        if (obj4 != null)
        {
          Shape shape2 = obj4 as Shape;
          if (shape2 == null)
            throw new IncompatibleClassChangeError();
          shape1 = shape2;
        }
        else
          shape1 = (Shape) null;
        graphics2D1.fill(shape1);
        Graphics2D graphics2D2 = g2;
        object obj5 = obj2;
        Shape shape3;
        if (obj5 != null)
        {
          Shape shape2 = obj5 as Shape;
          if (shape2 == null)
            throw new IncompatibleClassChangeError();
          shape3 = shape2;
        }
        else
          shape3 = (Shape) null;
        graphics2D2.fill(shape3);
      }
      if (this.getOutlinePaint() == null)
        return;
      g2.setStroke(this.getOutlineStroke());
      g2.setPaint(this.getOutlinePaint());
      Graphics2D graphics2D3 = g2;
      object obj6 = obj1;
      Shape shape4;
      if (obj6 != null)
      {
        Shape shape1 = obj6 as Shape;
        if (shape1 == null)
          throw new IncompatibleClassChangeError();
        shape4 = shape1;
      }
      else
        shape4 = (Shape) null;
      graphics2D3.draw(shape4);
      Graphics2D graphics2D4 = g2;
      object obj7 = obj2;
      Shape shape5;
      if (obj7 != null)
      {
        Shape shape1 = obj7 as Shape;
        if (shape1 == null)
          throw new IncompatibleClassChangeError();
        shape5 = shape1;
      }
      else
        shape5 = (Shape) null;
      graphics2D4.draw(shape5);
      Graphics2D graphics2D5 = g2;
      object obj8 = obj3;
      Shape shape6;
      if (obj8 != null)
      {
        Shape shape1 = obj8 as Shape;
        if (shape1 == null)
          throw new IncompatibleClassChangeError();
        shape6 = shape1;
      }
      else
        shape6 = (Shape) null;
      graphics2D5.draw(shape6);
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LongNeedle))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 172)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 184)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
