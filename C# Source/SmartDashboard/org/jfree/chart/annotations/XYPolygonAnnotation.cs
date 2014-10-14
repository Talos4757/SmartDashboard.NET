// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYPolygonAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
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
  public class XYPolygonAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -6984203651995900036L;
    private double[] polygon;
    [NonSerialized]
    private Stroke stroke;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Paint fillPaint;

    [LineNumberTable(new byte[] {(byte) 67, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYPolygonAnnotation(double[] polygon, Stroke stroke, Paint outlinePaint)
      : this(polygon, stroke, outlinePaint, (Paint) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 104, (byte) 99, (byte) 144, (byte) 111, (byte) 176, (byte) 118, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYPolygonAnnotation(double[] polygon, Stroke stroke, Paint outlinePaint, Paint fillPaint)
    {
      XYPolygonAnnotation polygonAnnotation = this;
      if (polygon == null)
      {
        string str = "Null 'polygon' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int length = polygon.Length;
        int num1 = 2;
        int num2 = -1;
        if ((num1 != num2 ? length % num1 : 0) != 0)
        {
          string str = "The 'polygon' array must contain an even number of items.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          this.polygon = (double[]) polygon.Clone();
          this.stroke = stroke;
          this.outlinePaint = outlinePaint;
          this.fillPaint = fillPaint;
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYPolygonAnnotation(double[] polygon)
      : this(polygon, (Stroke) new BasicStroke(1f), (Paint) Color.black)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYPolygonAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYPolygonAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYPolygonAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 159)]
    public virtual double[] getPolygonCoordinates()
    {
      return (double[]) this.polygon.Clone();
    }

    public virtual Paint getFillPaint()
    {
      return this.fillPaint;
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.stroke;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 106, (byte) 129, (byte) 103, (byte) 141, (byte) 173, (byte) 102, (byte) 148, (byte) 148, (byte) 107, (byte) 108, (byte) 110, (byte) 149, (byte) 151, (byte) 236, (byte) 59, (byte) 232, (byte) 71, (byte) 139, (byte) 107, (byte) 108, (byte) 110, (byte) 149, (byte) 151, (byte) 236, (byte) 59, (byte) 232, (byte) 71, (byte) 198, (byte) 104, (byte) 108, (byte) 167, (byte) 112, (byte) 108, (byte) 108, (byte) 135, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      if (this.polygon.Length < 4)
        return;
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      GeneralPath generalPath = new GeneralPath();
      double num1 = domainAxis.valueToJava2D(this.polygon[0], dataArea, re1);
      double num2 = rangeAxis.valueToJava2D(this.polygon[1], dataArea, re2);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        ((Path2D.Float) generalPath).moveTo((float) num2, (float) num1);
        int index = 2;
        while (index < this.polygon.Length)
        {
          double num3 = domainAxis.valueToJava2D(this.polygon[index], dataArea, re1);
          double num4 = rangeAxis.valueToJava2D(this.polygon[index + 1], dataArea, re2);
          ((Path2D.Float) generalPath).lineTo((float) num4, (float) num3);
          index += 2;
        }
        ((Path2D) generalPath).closePath();
      }
      else if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        ((Path2D.Float) generalPath).moveTo((float) num1, (float) num2);
        int index = 2;
        while (index < this.polygon.Length)
        {
          double num3 = domainAxis.valueToJava2D(this.polygon[index], dataArea, re1);
          double num4 = rangeAxis.valueToJava2D(this.polygon[index + 1], dataArea, re2);
          ((Path2D.Float) generalPath).lineTo((float) num3, (float) num4);
          index += 2;
        }
        ((Path2D) generalPath).closePath();
      }
      if (this.fillPaint != null)
      {
        g2.setPaint(this.fillPaint);
        g2.fill((Shape) generalPath);
      }
      if (this.stroke != null && this.outlinePaint != null)
      {
        g2.setPaint(this.outlinePaint);
        g2.setStroke(this.stroke);
        g2.draw((Shape) generalPath);
      }
      this.addEntity(info, (Shape) generalPath, rendererIndex, this.getToolTipText(), this.getURL());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 100, (byte) 162, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYPolygonAnnotation))
        return false;
      XYPolygonAnnotation polygonAnnotation = (XYPolygonAnnotation) obj;
      return Arrays.equals(this.polygon, polygonAnnotation.polygon) && ObjectUtilities.equal((object) this.stroke, (object) polygonAnnotation.stroke) && (PaintUtilities.equal(this.outlinePaint, polygonAnnotation.outlinePaint) && PaintUtilities.equal(this.fillPaint, polygonAnnotation.fillPaint));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 102, (byte) 145, (byte) 113, (byte) 145, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num = 37 * (37 * (37 * 193 + HashUtilities.hashCodeForDoubleArray(this.polygon)) + HashUtilities.hashCodeForPaint(this.fillPaint)) + HashUtilities.hashCodeForPaint(this.outlinePaint);
      if (this.stroke != null)
        num = 37 * num + Object.instancehelper_hashCode((object) this.stroke);
      return num;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 326)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 102, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeStroke(this.stroke, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writePaint(this.fillPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 102, (byte) 108, (byte) 108, (byte) 108})]
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
