// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.ShipNeedle
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
  public class ShipNeedle : MeterNeedle, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 149554868169435612L;

    [HideFromJava]
    static ShipNeedle()
    {
      MeterNeedle.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShipNeedle()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ShipNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ShipNeedle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ShipNeedle obj0)
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

    [LineNumberTable(new byte[] {(byte) 26, (byte) 102, (byte) 159, (byte) 32, (byte) 159, (byte) 32, (byte) 102, (byte) 119, (byte) 127, (byte) 2, (byte) 140, (byte) 141, (byte) 122, (byte) 172, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawNeedle(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      GeneralPath generalPath = new GeneralPath();
      ((Path2D) generalPath).append((Shape) new Arc2D.Double(-9.0, -7.0, 10.0, 14.0, 0.0, 25.5, 0), true);
      ((Path2D) generalPath).append((Shape) new Arc2D.Double(0.0, -7.0, 10.0, 14.0, 154.5, 25.5, 0), true);
      ((Path2D) generalPath).closePath();
      this.getTransform().setToTranslation(((RectangularShape) plotArea).getMinX(), ((RectangularShape) plotArea).getMaxY());
      this.getTransform().scale(((RectangularShape) plotArea).getWidth(), ((RectangularShape) plotArea).getHeight() / 3.0);
      ((Path2D.Float) generalPath).transform(this.getTransform());
      if (rotate != null && angle != 0.0)
      {
        this.getTransform().setToRotation(angle, rotate.getX(), rotate.getY());
        ((Path2D.Float) generalPath).transform(this.getTransform());
      }
      this.defaultDisplay(g2, (Shape) generalPath);
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 113, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object @object)
    {
      return @object != null && (@object == this || base.equals(@object) && @object is ShipNeedle);
    }

    [LineNumberTable((ushort) 121)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 133)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }
  }
}
