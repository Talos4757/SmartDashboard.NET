// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.WindNeedle
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
  public class WindNeedle : ArrowNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -2861061368907167834L;

    [HideFromJava]
    static WindNeedle()
    {
      ArrowNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindNeedle()
      : base(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WindNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] WindNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] WindNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 29, (byte) 108, (byte) 140, (byte) 105, (byte) 134, (byte) 98, (byte) 159, (byte) 2, (byte) 140, (byte) 191, (byte) 2, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      base.drawNeedle(g2, plotArea, rotate, angle);
      if (rotate == null || plotArea == null)
        return;
      int num = this.getSize() * 3;
      Rectangle2D.Double @double = new Rectangle2D.Double();
      Point2D rotate1 = rotate;
      ((Rectangle2D) @double).setRect(((RectangularShape) plotArea).getMinX() - (double) num, ((RectangularShape) plotArea).getMinY(), ((RectangularShape) plotArea).getWidth(), ((RectangularShape) plotArea).getHeight());
      base.drawNeedle(g2, (Rectangle2D) @double, rotate1, angle);
      ((Rectangle2D) @double).setRect(((RectangularShape) plotArea).getMinX() + (double) num, ((RectangularShape) plotArea).getMinY(), ((RectangularShape) plotArea).getWidth(), ((RectangularShape) plotArea).getHeight());
      base.drawNeedle(g2, (Rectangle2D) @double, rotate1, angle);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 113, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object @object)
    {
      return @object != null && (@object == this || base.equals(@object) && @object is WindNeedle);
    }

    [LineNumberTable((ushort) 124)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }
  }
}
