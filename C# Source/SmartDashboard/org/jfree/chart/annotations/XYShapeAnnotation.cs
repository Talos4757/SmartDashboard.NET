// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYShapeAnnotation
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
  public class XYShapeAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -8553218317600684041L;
    [NonSerialized]
    private Shape shape;
    [NonSerialized]
    private Stroke stroke;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Paint fillPaint;

    [LineNumberTable(new byte[] {(byte) 73, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYShapeAnnotation(Shape shape, Stroke stroke, Paint outlinePaint)
      : this(shape, stroke, outlinePaint, (Paint) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYShapeAnnotation(Shape shape, Stroke stroke, Paint outlinePaint, Paint fillPaint)
    {
      XYShapeAnnotation xyShapeAnnotation = this;
      if (shape == null)
      {
        string str = "Null 'shape' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.shape = shape;
        this.stroke = stroke;
        this.outlinePaint = outlinePaint;
        this.fillPaint = fillPaint;
      }
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYShapeAnnotation(Shape shape)
      : this(shape, (Stroke) new BasicStroke(1f), (Paint) Color.black)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYShapeAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYShapeAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYShapeAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 113, (byte) 103, (byte) 141, (byte) 237, (byte) 69, (byte) 108, (byte) 105, (byte) 105, (byte) 110, (byte) 110, (byte) 110, (byte) 139, (byte) 105, (byte) 105, (byte) 110, (byte) 110, (byte) 110, (byte) 171, (byte) 99, (byte) 104, (byte) 159, (byte) 6, (byte) 153, (byte) 111, (byte) 107, (byte) 98, (byte) 104, (byte) 121, (byte) 175, (byte) 104, (byte) 108, (byte) 168, (byte) 112, (byte) 108, (byte) 108, (byte) 136, (byte) 154})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      Rectangle2D bounds2D = this.shape.getBounds2D();
      double minX = ((RectangularShape) bounds2D).getMinX();
      double maxX = ((RectangularShape) bounds2D).getMaxX();
      double num1 = domainAxis.valueToJava2D(minX, dataArea, re1);
      double num2 = (domainAxis.valueToJava2D(maxX, dataArea, re1) - num1) / (maxX - minX);
      double num3 = num1 - minX * num2;
      double maxY = ((RectangularShape) bounds2D).getMaxY();
      double minY = ((RectangularShape) bounds2D).getMinY();
      double num4 = rangeAxis.valueToJava2D(maxY, dataArea, re2);
      double num5 = (rangeAxis.valueToJava2D(minY, dataArea, re2) - num4) / (minY - maxY);
      double num6 = num4 - num5 * maxY;
      Shape hotspot = (Shape) null;
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        AffineTransform affineTransform = new AffineTransform(0.0f, 1f, 1f, 0.0f, 0.0f, 0.0f);
        hotspot = new AffineTransform(num5, 0.0, 0.0, num2, num6, num3).createTransformedShape(affineTransform.createTransformedShape(this.shape));
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        hotspot = new AffineTransform(num2, 0.0, 0.0, num5, num3, num6).createTransformedShape(this.shape);
      if (this.fillPaint != null)
      {
        g2.setPaint(this.fillPaint);
        g2.fill(hotspot);
      }
      if (this.stroke != null && this.outlinePaint != null)
      {
        g2.setPaint(this.outlinePaint);
        g2.setStroke(this.stroke);
        g2.draw(hotspot);
      }
      this.addEntity(info, hotspot, rendererIndex, this.getToolTipText(), this.getURL());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 100, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYShapeAnnotation))
        return false;
      XYShapeAnnotation xyShapeAnnotation = (XYShapeAnnotation) obj;
      return Object.instancehelper_equals((object) this.shape, (object) xyShapeAnnotation.shape) && ObjectUtilities.equal((object) this.stroke, (object) xyShapeAnnotation.stroke) && (PaintUtilities.equal(this.outlinePaint, xyShapeAnnotation.outlinePaint) && PaintUtilities.equal(this.fillPaint, xyShapeAnnotation.fillPaint));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 142, (byte) 102, (byte) 113, (byte) 104, (byte) 145, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num = 37 * 193 + Object.instancehelper_hashCode((object) this.shape);
      if (this.stroke != null)
        num = 37 * num + Object.instancehelper_hashCode((object) this.stroke);
      return 37 * (37 * num + HashUtilities.hashCodeForPaint(this.outlinePaint)) + HashUtilities.hashCodeForPaint(this.fillPaint);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 275)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape(this.shape, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.shape = SerialUtilities.readShape(obj0);
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
