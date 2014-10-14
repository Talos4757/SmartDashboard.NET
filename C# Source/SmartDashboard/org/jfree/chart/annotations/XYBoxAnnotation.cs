// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYBoxAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYBoxAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 6764703772526757457L;
    private double x0;
    private double y0;
    private double x1;
    private double y1;
    [NonSerialized]
    private Stroke stroke;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Paint fillPaint;

    [LineNumberTable(new byte[] {(byte) 73, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBoxAnnotation(double x0, double y0, double x1, double y1, Stroke stroke, Paint outlinePaint)
      : this(x0, y0, x1, y1, stroke, outlinePaint, (Paint) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 104, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBoxAnnotation(double x0, double y0, double x1, double y1, Stroke stroke, Paint outlinePaint, Paint fillPaint)
    {
      XYBoxAnnotation xyBoxAnnotation = this;
      this.x0 = x0;
      this.y0 = y0;
      this.x1 = x1;
      this.y1 = y1;
      this.stroke = stroke;
      this.outlinePaint = outlinePaint;
      this.fillPaint = fillPaint;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 127, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBoxAnnotation(double x0, double y0, double x1, double y1)
      : this(x0, y0, x1, y1, (Stroke) new BasicStroke(1f), (Paint) Color.black)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYBoxAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYBoxAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYBoxAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 103, (byte) 141, (byte) 173, (byte) 145, (byte) 114, (byte) 146, (byte) 146, (byte) 99, (byte) 104, (byte) 182, (byte) 104, (byte) 211, (byte) 104, (byte) 108, (byte) 168, (byte) 112, (byte) 108, (byte) 108, (byte) 136, (byte) 154})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      double num1 = domainAxis.valueToJava2D(this.x0, dataArea, re1);
      double num2 = rangeAxis.valueToJava2D(this.y0, dataArea, re2);
      double num3 = domainAxis.valueToJava2D(this.x1, dataArea, re1);
      double num4 = rangeAxis.valueToJava2D(this.y1, dataArea, re2);
      Rectangle2D.Double @double = (Rectangle2D.Double) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        @double = new Rectangle2D.Double(num2, num3, num4 - num2, num1 - num3);
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        @double = new Rectangle2D.Double(num1, num4, num3 - num1, num2 - num4);
      if (this.fillPaint != null)
      {
        g2.setPaint(this.fillPaint);
        g2.fill((Shape) @double);
      }
      if (this.stroke != null && this.outlinePaint != null)
      {
        g2.setPaint(this.outlinePaint);
        g2.setStroke(this.stroke);
        g2.draw((Shape) @double);
      }
      this.addEntity(info, (Shape) @double, rendererIndex, this.getToolTipText(), this.getURL());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 96, (byte) 100, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYBoxAnnotation))
        return false;
      XYBoxAnnotation xyBoxAnnotation = (XYBoxAnnotation) obj;
      return this.x0 == xyBoxAnnotation.x0 && this.y0 == xyBoxAnnotation.y0 && (this.x1 == xyBoxAnnotation.x1 && this.y1 == xyBoxAnnotation.y1) && (ObjectUtilities.equal((object) this.stroke, (object) xyBoxAnnotation.stroke) && PaintUtilities.equal(this.outlinePaint, xyBoxAnnotation.outlinePaint) && PaintUtilities.equal(this.fillPaint, xyBoxAnnotation.fillPaint));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      long num1 = Double.doubleToLongBits(this.x0);
      int num2 = (int) (num1 ^ (long) ((ulong) num1 >> 32));
      long num3 = Double.doubleToLongBits(this.x1);
      int num4 = 29 * num2 + (int) (num3 ^ (long) ((ulong) num3 >> 32));
      long num5 = Double.doubleToLongBits(this.y0);
      int num6 = 29 * num4 + (int) (num5 ^ (long) ((ulong) num5 >> 32));
      long num7 = Double.doubleToLongBits(this.y1);
      return 29 * num6 + (int) (num7 ^ (long) ((ulong) num7 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 274)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.stroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.stroke = SerialUtilities.readStroke(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.fillPaint = SerialUtilities.readPaint(obj0);
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
