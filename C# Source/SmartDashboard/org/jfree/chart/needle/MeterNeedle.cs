// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.needle.MeterNeedle
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
using org.jfree.io;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.needle
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public abstract class MeterNeedle : Object, Serializable.__Interface, ISerializable
  {
    protected internal static AffineTransform transform = new AffineTransform();
    private const long serialVersionUID = 5203064851510951052L;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;
    [NonSerialized]
    private Paint fillPaint;
    [NonSerialized]
    private Paint highlightPaint;
    private int size;
    private double rotateX;
    private double rotateY;

    [LineNumberTable((ushort) 101)]
    static MeterNeedle()
    {
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 232, (byte) 27, (byte) 171, (byte) 176, (byte) 167, (byte) 167, (byte) 167, (byte) 176, (byte) 240, (byte) 84, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeterNeedle(Paint outline, Paint fill, Paint highlight)
    {
      base.\u002Ector();
      MeterNeedle meterNeedle = this;
      this.outlinePaint = (Paint) Color.black;
      this.outlineStroke = (Stroke) new BasicStroke(2f);
      this.fillPaint = (Paint) null;
      this.highlightPaint = (Paint) null;
      this.size = 5;
      this.rotateX = 0.5;
      this.rotateY = 0.5;
      this.fillPaint = fill;
      this.highlightPaint = highlight;
      this.outlinePaint = outline;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeterNeedle()
      : this((Paint) null, (Paint) null, (Paint) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MeterNeedle([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MeterNeedle obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 102, (byte) 223, (byte) 15, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D plotArea, double angle)
    {
      Point2D.Double @double = new Point2D.Double();
      @double.setLocation(((RectangularShape) plotArea).getMinX() + this.rotateX * ((RectangularShape) plotArea).getWidth(), ((RectangularShape) plotArea).getMinY() + this.rotateY * ((RectangularShape) plotArea).getHeight());
      this.draw(g2, plotArea, (Point2D) @double, angle);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 103, (byte) 135, (byte) 145, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D plotArea, Point2D rotate, double angle)
    {
      Color color = ((Graphics) g2).getColor();
      Stroke stroke = g2.getStroke();
      this.drawNeedle(g2, plotArea, rotate, Math.toRadians(angle));
      g2.setStroke(stroke);
      g2.setPaint((Paint) color);
    }

    protected internal abstract void drawNeedle(Graphics2D gd, Rectangle2D rd, Point2D pd, double d);

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    public virtual void setOutlinePaint(Paint p)
    {
      if (p == null)
        return;
      this.outlinePaint = p;
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    public virtual void setOutlineStroke(Stroke s)
    {
      if (s == null)
        return;
      this.outlineStroke = s;
    }

    public virtual Paint getFillPaint()
    {
      return this.fillPaint;
    }

    public virtual void setFillPaint(Paint p)
    {
      if (p == null)
        return;
      this.fillPaint = p;
    }

    public virtual Paint getHighlightPaint()
    {
      return this.highlightPaint;
    }

    public virtual void setHighlightPaint(Paint p)
    {
      if (p == null)
        return;
      this.highlightPaint = p;
    }

    public virtual double getRotateX()
    {
      return this.rotateX;
    }

    public virtual void setRotateX(double x)
    {
      this.rotateX = x;
    }

    public virtual void setRotateY(double y)
    {
      this.rotateY = y;
    }

    public virtual double getRotateY()
    {
      return this.rotateY;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D plotArea)
    {
      this.draw(g2, plotArea, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 194, (byte) 104, (byte) 108, (byte) 167, (byte) 104, (byte) 108, (byte) 108, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void defaultDisplay(Graphics2D g2, Shape shape)
    {
      if (this.fillPaint != null)
      {
        g2.setPaint(this.fillPaint);
        g2.fill(shape);
      }
      if (this.outlinePaint == null)
        return;
      g2.setStroke(this.outlineStroke);
      g2.setPaint(this.outlinePaint);
      g2.draw(shape);
    }

    public virtual int getSize()
    {
      return this.size;
    }

    public virtual void setSize(int pixels)
    {
      this.size = pixels;
    }

    public virtual AffineTransform getTransform()
    {
      return MeterNeedle.transform;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MeterNeedle))
        return false;
      MeterNeedle meterNeedle = (MeterNeedle) obj;
      return PaintUtilities.equal(this.outlinePaint, meterNeedle.outlinePaint) && ObjectUtilities.equal((object) this.outlineStroke, (object) meterNeedle.outlineStroke) && (PaintUtilities.equal(this.fillPaint, meterNeedle.fillPaint) && PaintUtilities.equal(this.highlightPaint, meterNeedle.highlightPaint)) && (this.size == meterNeedle.size && this.rotateX == meterNeedle.rotateX && this.rotateY == meterNeedle.rotateY);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 113, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(193, this.fillPaint), this.highlightPaint), this.outlinePaint), this.outlineStroke), this.rotateX), this.rotateY), this.size);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 41, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
      SerialUtilities.writePaint(this.highlightPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.fillPaint = SerialUtilities.readPaint(obj0);
      this.highlightPaint = SerialUtilities.readPaint(obj0);
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
