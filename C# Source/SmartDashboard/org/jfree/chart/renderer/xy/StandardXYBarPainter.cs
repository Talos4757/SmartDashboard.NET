// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.StandardXYBarPainter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.renderer.xy.XYBarPainter", "java.io.Serializable"})]
  [Serializable]
  public class StandardXYBarPainter : Object, XYBarPainter, Serializable.__Interface, ISerializable
  {
    [LineNumberTable(new byte[] {(byte) 19, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYBarPainter()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardXYBarPainter([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardXYBarPainter obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 131, (byte) 104, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 102, (byte) 102, (byte) 99, (byte) 134, (byte) 141, (byte) 105, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 173, (byte) 105, (byte) 99, (byte) 134, (byte) 102, (byte) 102, (byte) 138, (byte) 105, (byte) 102, (byte) 99, (byte) 134, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rectangle2D createShadow([In] RectangularShape obj0, [In] double obj1, [In] double obj2, [In] RectangleEdge obj3, [In] bool obj4)
    {
      int num = obj4 ? 1 : 0;
      double minX = obj0.getMinX();
      double maxX = obj0.getMaxX();
      double minY = obj0.getMinY();
      double maxY = obj0.getMaxY();
      if (obj3 == RectangleEdge.__\u003C\u003ETOP)
      {
        minX += obj1;
        maxX += obj1;
        if (num == 0)
          minY += obj2;
        maxY += obj2;
      }
      else if (obj3 == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        minX += obj1;
        maxX += obj1;
        minY += obj2;
        if (num == 0)
          maxY += obj2;
      }
      else if (obj3 == RectangleEdge.__\u003C\u003ELEFT)
      {
        if (num == 0)
          minX += obj1;
        maxX += obj1;
        minY += obj2;
        maxY += obj2;
      }
      else if (obj3 == RectangleEdge.__\u003C\u003ERIGHT)
      {
        minX += obj1;
        if (num == 0)
          maxX += obj1;
        minY += obj2;
        maxY += obj2;
      }
      return (Rectangle2D) new Rectangle2D.Double(minX, minY, maxX - minX, maxY - minY);
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 106, (byte) 103, (byte) 112, (byte) 148, (byte) 122, (byte) 168, (byte) 136, (byte) 106, (byte) 106, (byte) 102, (byte) 103, (byte) 103, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintBar(Graphics2D g2, XYBarRenderer renderer, int row, int column, RectangularShape bar, RectangleEdge @base)
    {
      object obj1 = (object) renderer.getItemPaint(row, column);
      GradientPaintTransformer paintTransformer = renderer.getGradientPaintTransformer();
      if (paintTransformer != null && (Paint) obj1 is GradientPaint)
        obj1 = (object) paintTransformer.transform((GradientPaint) obj1, (Shape) bar);
      Graphics2D graphics2D = g2;
      object obj2 = obj1;
      Paint paint1;
      if (obj2 != null)
      {
        Paint paint2 = obj2 as Paint;
        if (paint2 == null)
          throw new IncompatibleClassChangeError();
        paint1 = paint2;
      }
      else
        paint1 = (Paint) null;
      graphics2D.setPaint(paint1);
      g2.fill((Shape) bar);
      if (!renderer.isDrawBarOutline())
        return;
      Stroke itemOutlineStroke = renderer.getItemOutlineStroke(row, column);
      Paint itemOutlinePaint = renderer.getItemOutlinePaint(row, column);
      if (itemOutlineStroke == null || itemOutlinePaint == null)
        return;
      g2.setStroke(itemOutlineStroke);
      g2.setPaint(itemOutlinePaint);
      g2.draw((Shape) bar);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 131, (byte) 106, (byte) 104, (byte) 103, (byte) 104, (byte) 193, (byte) 152, (byte) 107, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintBarShadow(Graphics2D g2, XYBarRenderer renderer, int row, int column, RectangularShape bar, RectangleEdge @base, bool pegShadow)
    {
      int num = pegShadow ? 1 : 0;
      Paint itemPaint = renderer.getItemPaint(row, column);
      if (itemPaint is Color && ((Color) itemPaint).getAlpha() == 0)
        return;
      Rectangle2D shadow = this.createShadow(bar, renderer.getShadowXOffset(), renderer.getShadowYOffset(), @base, num != 0);
      g2.setPaint((Paint) Color.gray);
      g2.fill((Shape) shadow);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is StandardXYBarPainter;
    }

    public virtual int hashCode()
    {
      return 37;
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
