// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.XYLine3DRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using org.jfree.chart;
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"org.jfree.chart.Effect3D", "java.io.Serializable"})]
  [Serializable]
  public class XYLine3DRenderer : XYLineAndShapeRenderer, Effect3D, Serializable.__Interface
  {
    private const long serialVersionUID = 588933208243446087L;
    public const double DEFAULT_X_OFFSET = 12.0;
    public const double DEFAULT_Y_OFFSET = 8.0;
    internal static Paint __\u003C\u003EDEFAULT_WALL_PAINT;
    private double xOffset;
    private double yOffset;
    [NonSerialized]
    private Paint wallPaint;

    [Modifiers]
    public static Paint DEFAULT_WALL_PAINT
    {
      [HideFromJava] get
      {
        return XYLine3DRenderer.__\u003C\u003EDEFAULT_WALL_PAINT;
      }
    }

    [LineNumberTable((ushort) 75)]
    static XYLine3DRenderer()
    {
      XYLineAndShapeRenderer.__\u003Cclinit\u003E();
      XYLine3DRenderer.__\u003C\u003EDEFAULT_WALL_PAINT = (Paint) new Color(221, 221, 221);
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 104, (byte) 107, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYLine3DRenderer()
    {
      XYLine3DRenderer xyLine3Drenderer = this;
      this.wallPaint = XYLine3DRenderer.__\u003C\u003EDEFAULT_WALL_PAINT;
      this.xOffset = 12.0;
      this.yOffset = 8.0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYLine3DRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYLine3DRenderer obj0)
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

    protected internal virtual bool isShadowPass(int pass)
    {
      return pass == 0;
    }

    public virtual Paint getWallPaint()
    {
      return this.wallPaint;
    }

    public virtual double getXOffset()
    {
      return this.xOffset;
    }

    public virtual double getYOffset()
    {
      return this.yOffset;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setXOffset(double xOffset)
    {
      this.xOffset = xOffset;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 81, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setYOffset(double yOffset)
    {
      this.yOffset = yOffset;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWallPaint(Paint paint)
    {
      this.wallPaint = paint;
      this.fireChangeEvent();
    }

    public override int getPassCount()
    {
      return 3;
    }

    protected internal override bool isLinePass(int pass)
    {
      return pass == 0 || pass == 1;
    }

    protected internal override bool isItemPass(int pass)
    {
      return pass == 2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 105, (byte) 104, (byte) 111, (byte) 108, (byte) 114, (byte) 104, (byte) 246, (byte) 69, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void drawFirstPassShape(Graphics2D g2, int pass, int series, int item, Shape shape)
    {
      if (this.isShadowPass(pass))
      {
        if (this.getWallPaint() == null)
          return;
        g2.setStroke(this.getItemStroke(series, item));
        g2.setPaint(this.getWallPaint());
        g2.translate(this.getXOffset(), this.getYOffset());
        g2.draw(shape);
        g2.translate(-this.getXOffset(), -this.getYOffset());
      }
      else
        base.drawFirstPassShape(g2, pass, series, item, shape);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYLine3DRenderer))
        return false;
      XYLine3DRenderer xyLine3Drenderer = (XYLine3DRenderer) obj;
      if (this.xOffset != xyLine3Drenderer.xOffset || this.yOffset != xyLine3Drenderer.yOffset || !PaintUtilities.equal(this.wallPaint, xyLine3Drenderer.wallPaint))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.wallPaint = SerialUtilities.readPaint(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.wallPaint, obj0);
    }
  }
}
