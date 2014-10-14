// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYLineAnnotation
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
using org.jfree.chart.util;
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
  public class XYLineAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -80535465244091334L;
    private double x1;
    private double y1;
    private double x2;
    private double y2;
    [NonSerialized]
    private Stroke stroke;
    [NonSerialized]
    private Paint paint;

    [LineNumberTable(new byte[] {(byte) 82, (byte) 136, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYLineAnnotation(double x1, double y1, double x2, double y2, Stroke stroke, Paint paint)
    {
      XYLineAnnotation xyLineAnnotation = this;
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.stroke = stroke;
        this.paint = paint;
      }
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 127, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYLineAnnotation(double x1, double y1, double x2, double y2)
      : this(x1, y1, x2, y2, (Stroke) new BasicStroke(1f), (Paint) Color.black)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYLineAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYLineAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYLineAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 103, (byte) 141, (byte) 141, (byte) 102, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 145, (byte) 146, (byte) 146, (byte) 180, (byte) 104, (byte) 146, (byte) 145, (byte) 146, (byte) 178, (byte) 108, (byte) 108, (byte) 174, (byte) 106, (byte) 100, (byte) 168, (byte) 104, (byte) 104, (byte) 104, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      float num1 = 0.0f;
      float num2 = 0.0f;
      float num3 = 0.0f;
      float num4 = 0.0f;
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
      {
        num1 = (float) domainAxis.valueToJava2D(this.x1, dataArea, re1);
        num3 = (float) rangeAxis.valueToJava2D(this.y1, dataArea, re2);
        num2 = (float) domainAxis.valueToJava2D(this.x2, dataArea, re1);
        num4 = (float) rangeAxis.valueToJava2D(this.y2, dataArea, re2);
      }
      else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        num3 = (float) domainAxis.valueToJava2D(this.x1, dataArea, re1);
        num1 = (float) rangeAxis.valueToJava2D(this.y1, dataArea, re2);
        num4 = (float) domainAxis.valueToJava2D(this.x2, dataArea, re1);
        num2 = (float) rangeAxis.valueToJava2D(this.y2, dataArea, re2);
      }
      g2.setPaint(this.paint);
      g2.setStroke(this.stroke);
      Line2D.Float @float = new Line2D.Float(num1, num3, num2, num4);
      if (LineUtilities.clipLine((Line2D) @float, dataArea))
        g2.draw((Shape) @float);
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, ShapeUtilities.createLineRegion((Line2D) @float, 1f), rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 100, (byte) 130, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!base.equals(obj) || !(obj is XYLineAnnotation))
        return false;
      XYLineAnnotation xyLineAnnotation = (XYLineAnnotation) obj;
      return this.x1 == xyLineAnnotation.x1 && this.y1 == xyLineAnnotation.y1 && (this.x2 == xyLineAnnotation.x2 && this.y2 == xyLineAnnotation.y2) && (PaintUtilities.equal(this.paint, xyLineAnnotation.paint) && ObjectUtilities.equal((object) this.stroke, (object) xyLineAnnotation.stroke));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      long num1 = Double.doubleToLongBits(this.x1);
      int num2 = (int) (num1 ^ (long) ((ulong) num1 >> 32));
      long num3 = Double.doubleToLongBits(this.x2);
      int num4 = 29 * num2 + (int) (num3 ^ (long) ((ulong) num3 >> 32));
      long num5 = Double.doubleToLongBits(this.y1);
      int num6 = 29 * num4 + (int) (num5 ^ (long) ((ulong) num5 >> 32));
      long num7 = Double.doubleToLongBits(this.y2);
      return 29 * num6 + (int) (num7 ^ (long) ((ulong) num7 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 281)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
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
