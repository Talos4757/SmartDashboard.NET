// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.GradientXYBarPainter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
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
  public class GradientXYBarPainter : Object, XYBarPainter, Serializable.__Interface, ISerializable
  {
    private double g1;
    private double g2;
    private double g3;

    [LineNumberTable(new byte[] {(byte) 27, (byte) 127, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GradientXYBarPainter()
      : this(0.1, 0.2, 0.8)
    {
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 104, (byte) 105, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GradientXYBarPainter(double g1, double g2, double g3)
    {
      base.\u002Ector();
      GradientXYBarPainter gradientXyBarPainter = this;
      this.g1 = g1;
      this.g2 = g2;
      this.g3 = g3;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GradientXYBarPainter([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GradientXYBarPainter obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 103, (byte) 104, (byte) 114, (byte) 114, (byte) 116, (byte) 157, (byte) 152, (byte) 153, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rectangle2D[] splitVerticalBar([In] RectangularShape obj0, [In] double obj1, [In] double obj2, [In] double obj3)
    {
      Rectangle2D[] rectangle2DArray = new Rectangle2D[4];
      double minX = obj0.getMinX();
      double num1 = Math.rint(minX + obj0.getWidth() * obj1);
      double num2 = Math.rint(minX + obj0.getWidth() * obj2);
      double num3 = Math.rint(minX + obj0.getWidth() * obj3);
      rectangle2DArray[0] = (Rectangle2D) new Rectangle2D.Double(obj0.getMinX(), obj0.getMinY(), num1 - minX, obj0.getHeight());
      rectangle2DArray[1] = (Rectangle2D) new Rectangle2D.Double(num1, obj0.getMinY(), num2 - num1, obj0.getHeight());
      rectangle2DArray[2] = (Rectangle2D) new Rectangle2D.Double(num2, obj0.getMinY(), num3 - num2, obj0.getHeight());
      rectangle2DArray[3] = (Rectangle2D) new Rectangle2D.Double(num3, obj0.getMinY(), obj0.getMaxX() - num3, obj0.getHeight());
      return rectangle2DArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 103, (byte) 104, (byte) 114, (byte) 114, (byte) 116, (byte) 157, (byte) 152, (byte) 153, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rectangle2D[] splitHorizontalBar([In] RectangularShape obj0, [In] double obj1, [In] double obj2, [In] double obj3)
    {
      Rectangle2D[] rectangle2DArray = new Rectangle2D[4];
      double minY = obj0.getMinY();
      double num1 = Math.rint(minY + obj0.getHeight() * obj1);
      double num2 = Math.rint(minY + obj0.getHeight() * obj2);
      double num3 = Math.rint(minY + obj0.getHeight() * obj3);
      rectangle2DArray[0] = (Rectangle2D) new Rectangle2D.Double(obj0.getMinX(), obj0.getMinY(), obj0.getWidth(), num1 - minY);
      rectangle2DArray[1] = (Rectangle2D) new Rectangle2D.Double(obj0.getMinX(), num1, obj0.getWidth(), num2 - num1);
      rectangle2DArray[2] = (Rectangle2D) new Rectangle2D.Double(obj0.getMinX(), num2, obj0.getWidth(), num3 - num2);
      rectangle2DArray[3] = (Rectangle2D) new Rectangle2D.Double(obj0.getMinX(), num3, obj0.getWidth(), obj0.getMaxY() - num3);
      return rectangle2DArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 83, (byte) 131, (byte) 104, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 102, (byte) 102, (byte) 99, (byte) 134, (byte) 141, (byte) 105, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 173, (byte) 105, (byte) 99, (byte) 134, (byte) 102, (byte) 102, (byte) 138, (byte) 105, (byte) 102, (byte) 99, (byte) 134, (byte) 102, (byte) 136})]
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

    [LineNumberTable(new byte[] {(byte) 57, (byte) 170, (byte) 104, (byte) 103, (byte) 137, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 130, (byte) 102, (byte) 235, (byte) 69, (byte) 104, (byte) 161, (byte) 117, (byte) 156, (byte) 159, (byte) 12, (byte) 104, (byte) 138, (byte) 159, (byte) 12, (byte) 104, (byte) 138, (byte) 159, (byte) 8, (byte) 104, (byte) 138, (byte) 159, (byte) 8, (byte) 104, (byte) 106, (byte) 101, (byte) 117, (byte) 156, (byte) 191, (byte) 12, (byte) 104, (byte) 138, (byte) 159, (byte) 12, (byte) 104, (byte) 138, (byte) 159, (byte) 8, (byte) 104, (byte) 138, (byte) 159, (byte) 8, (byte) 104, (byte) 234, (byte) 69, (byte) 104, (byte) 107, (byte) 107, (byte) 104, (byte) 104, (byte) 104, (byte) 202})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paintBar(Graphics2D g2, XYBarRenderer renderer, int row, int column, RectangularShape bar, RectangleEdge @base)
    {
      Paint itemPaint = renderer.getItemPaint(row, column);
      Color color1;
      Color color2;
      if (itemPaint is Color)
      {
        color1 = (Color) itemPaint;
        color2 = color1.brighter();
      }
      else if (itemPaint is GradientPaint)
      {
        GradientPaint gradientPaint = (GradientPaint) itemPaint;
        color1 = gradientPaint.getColor1();
        color2 = gradientPaint.getColor2();
      }
      else
      {
        color1 = (Color) Color.blue;
        color2 = ((Color) Color.blue).brighter();
      }
      if (color1.getAlpha() == 0)
        return;
      if (@base == RectangleEdge.__\u003C\u003ETOP || @base == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        Rectangle2D[] rectangle2DArray = this.splitVerticalBar(bar, this.g1, this.g2, this.g3);
        GradientPaint gradientPaint1 = new GradientPaint((float) ((RectangularShape) rectangle2DArray[0]).getMinX(), 0.0f, color1, (float) ((RectangularShape) rectangle2DArray[0]).getMaxX(), 0.0f, (Color) Color.white);
        g2.setPaint((Paint) gradientPaint1);
        g2.fill((Shape) rectangle2DArray[0]);
        GradientPaint gradientPaint2 = new GradientPaint((float) ((RectangularShape) rectangle2DArray[1]).getMinX(), 0.0f, (Color) Color.white, (float) ((RectangularShape) rectangle2DArray[1]).getMaxX(), 0.0f, color1);
        g2.setPaint((Paint) gradientPaint2);
        g2.fill((Shape) rectangle2DArray[1]);
        GradientPaint gradientPaint3 = new GradientPaint((float) ((RectangularShape) rectangle2DArray[2]).getMinX(), 0.0f, color1, (float) ((RectangularShape) rectangle2DArray[2]).getMaxX(), 0.0f, color2);
        g2.setPaint((Paint) gradientPaint3);
        g2.fill((Shape) rectangle2DArray[2]);
        GradientPaint gradientPaint4 = new GradientPaint((float) ((RectangularShape) rectangle2DArray[3]).getMinX(), 0.0f, color2, (float) ((RectangularShape) rectangle2DArray[3]).getMaxX(), 0.0f, color1);
        g2.setPaint((Paint) gradientPaint4);
        g2.fill((Shape) rectangle2DArray[3]);
      }
      else if (@base == RectangleEdge.__\u003C\u003ELEFT || @base == RectangleEdge.__\u003C\u003ERIGHT)
      {
        Rectangle2D[] rectangle2DArray = this.splitHorizontalBar(bar, this.g1, this.g2, this.g3);
        GradientPaint gradientPaint1 = new GradientPaint(0.0f, (float) ((RectangularShape) rectangle2DArray[0]).getMinY(), color1, 0.0f, (float) ((RectangularShape) rectangle2DArray[0]).getMaxX(), (Color) Color.white);
        g2.setPaint((Paint) gradientPaint1);
        g2.fill((Shape) rectangle2DArray[0]);
        GradientPaint gradientPaint2 = new GradientPaint(0.0f, (float) ((RectangularShape) rectangle2DArray[1]).getMinY(), (Color) Color.white, 0.0f, (float) ((RectangularShape) rectangle2DArray[1]).getMaxY(), color1);
        g2.setPaint((Paint) gradientPaint2);
        g2.fill((Shape) rectangle2DArray[1]);
        GradientPaint gradientPaint3 = new GradientPaint(0.0f, (float) ((RectangularShape) rectangle2DArray[2]).getMinY(), color1, 0.0f, (float) ((RectangularShape) rectangle2DArray[2]).getMaxY(), color2);
        g2.setPaint((Paint) gradientPaint3);
        g2.fill((Shape) rectangle2DArray[2]);
        GradientPaint gradientPaint4 = new GradientPaint(0.0f, (float) ((RectangularShape) rectangle2DArray[3]).getMinY(), color2, 0.0f, (float) ((RectangularShape) rectangle2DArray[3]).getMaxY(), color1);
        g2.setPaint((Paint) gradientPaint4);
        g2.fill((Shape) rectangle2DArray[3]);
      }
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 90, (byte) 131, (byte) 106, (byte) 104, (byte) 103, (byte) 104, (byte) 193, (byte) 152, (byte) 107, (byte) 137})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is GradientXYBarPainter))
        return false;
      GradientXYBarPainter gradientXyBarPainter = (GradientXYBarPainter) obj;
      return this.g1 == gradientXyBarPainter.g1 && this.g2 == gradientXyBarPainter.g2 && this.g3 == gradientXyBarPainter.g3;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 254, (byte) 99, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(37, this.g1), this.g2), this.g3);
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
