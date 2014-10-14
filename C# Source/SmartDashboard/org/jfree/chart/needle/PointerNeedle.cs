// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.PointerNeedle
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
  public class PointerNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -4744677345334729606L;

    [HideFromJava]
    static PointerNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointerNeedle()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PointerNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] PointerNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PointerNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 25, (byte) 102, (byte) 102, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 118, (byte) 150, (byte) 105, (byte) 105, (byte) 106, (byte) 134, (byte) 105, (byte) 106, (byte) 106, (byte) 134, (byte) 141, (byte) 122, (byte) 108, (byte) 172, (byte) 104, (byte) 108, (byte) 167, (byte) 104, (byte) 108, (byte) 167, (byte) 104, (byte) 108, (byte) 108, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      GeneralPath generalPath1 = new GeneralPath();
      GeneralPath generalPath2 = new GeneralPath();
      float num1 = (float) ((RectangularShape) plotArea).getMinX();
      float num2 = (float) ((RectangularShape) plotArea).getMinY();
      float num3 = (float) ((RectangularShape) plotArea).getMaxX();
      float num4 = (float) ((RectangularShape) plotArea).getMaxY();
      float num5 = num1 + (float) (((RectangularShape) plotArea).getWidth() / 2.0);
      float num6 = num2 + (float) (((RectangularShape) plotArea).getHeight() / 2.0);
      ((Path2D.Float) generalPath1).moveTo(num1, num6);
      ((Path2D.Float) generalPath1).lineTo(num5, num2);
      ((Path2D.Float) generalPath1).lineTo(num3, num6);
      ((Path2D) generalPath1).closePath();
      ((Path2D.Float) generalPath2).moveTo(num1, num6);
      ((Path2D.Float) generalPath2).lineTo(num5, num4);
      ((Path2D.Float) generalPath2).lineTo(num3, num6);
      ((Path2D) generalPath2).closePath();
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        ((Path2D.Float) generalPath1).transform(this.getTransform());
        ((Path2D.Float) generalPath2).transform(this.getTransform());
      }
      if (this.getFillPaint() != null)
      {
        g2.setPaint(this.getFillPaint());
        g2.fill((Shape) generalPath1);
      }
      if (this.getHighlightPaint() != null)
      {
        g2.setPaint(this.getHighlightPaint());
        g2.fill((Shape) generalPath2);
      }
      if (this.getOutlinePaint() == null)
        return;
      g2.setStroke(this.getOutlineStroke());
      g2.setPaint(this.getOutlinePaint());
      g2.draw((Shape) generalPath1);
      g2.draw((Shape) generalPath2);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is PointerNeedle && base.equals(obj);
    }

    [LineNumberTable((ushort) 145)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 157)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
