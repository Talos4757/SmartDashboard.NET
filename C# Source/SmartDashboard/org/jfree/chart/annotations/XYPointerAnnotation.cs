// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYPointerAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.annotations
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYPointerAnnotation : XYTextAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -4031161445009858551L;
    public const double DEFAULT_TIP_RADIUS = 10.0;
    public const double DEFAULT_BASE_RADIUS = 30.0;
    public const double DEFAULT_LABEL_OFFSET = 3.0;
    public const double DEFAULT_ARROW_LENGTH = 5.0;
    public const double DEFAULT_ARROW_WIDTH = 3.0;
    private double angle;
    private double tipRadius;
    private double baseRadius;
    private double arrowLength;
    private double arrowWidth;
    [NonSerialized]
    private Stroke arrowStroke;
    [NonSerialized]
    private Paint arrowPaint;
    private double labelOffset;

    [HideFromJava]
    static XYPointerAnnotation()
    {
      XYTextAnnotation.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 109, (byte) 106, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYPointerAnnotation(string label, double x, double y, double angle)
      : base(label, x, y)
    {
      XYPointerAnnotation pointerAnnotation = this;
      this.angle = angle;
      this.tipRadius = 10.0;
      this.baseRadius = 30.0;
      this.arrowLength = 5.0;
      this.arrowWidth = 3.0;
      this.labelOffset = 3.0;
      this.arrowStroke = (Stroke) new BasicStroke(1f);
      this.arrowPaint = (Paint) Color.black;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYPointerAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYPointerAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYPointerAnnotation obj0)
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

    public virtual double getAngle()
    {
      return this.angle;
    }

    public virtual void setAngle(double angle)
    {
      this.angle = angle;
    }

    public virtual double getTipRadius()
    {
      return this.tipRadius;
    }

    public virtual void setTipRadius(double radius)
    {
      this.tipRadius = radius;
    }

    public virtual double getBaseRadius()
    {
      return this.baseRadius;
    }

    public virtual void setBaseRadius(double radius)
    {
      this.baseRadius = radius;
    }

    public virtual double getLabelOffset()
    {
      return this.labelOffset;
    }

    public virtual void setLabelOffset(double offset)
    {
      this.labelOffset = offset;
    }

    public virtual double getArrowLength()
    {
      return this.arrowLength;
    }

    public virtual void setArrowLength(double length)
    {
      this.arrowLength = length;
    }

    public virtual double getArrowWidth()
    {
      return this.arrowWidth;
    }

    public virtual void setArrowWidth(double width)
    {
      this.arrowWidth = width;
    }

    public virtual Stroke getArrowStroke()
    {
      return this.arrowStroke;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setArrowStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.arrowStroke = stroke;
    }

    public virtual Paint getArrowPaint()
    {
      return this.arrowPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setArrowPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.arrowPaint = paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 103, (byte) 141, (byte) 141, (byte) 113, (byte) 114, (byte) 104, (byte) 99, (byte) 99, (byte) 132, (byte) 119, (byte) 152, (byte) 119, (byte) 152, (byte) 120, (byte) 152, (byte) 159, (byte) 3, (byte) 191, (byte) 3, (byte) 159, (byte) 3, (byte) 191, (byte) 3, (byte) 103, (byte) 109, (byte) 109, (byte) 109, (byte) 135, (byte) 108, (byte) 108, (byte) 111, (byte) 104, (byte) 168, (byte) 158, (byte) 159, (byte) 0, (byte) 108, (byte) 191, (byte) 7, (byte) 104, (byte) 108, (byte) 136, (byte) 108, (byte) 191, (byte) 5, (byte) 104, (byte) 108, (byte) 108, (byte) 168, (byte) 104, (byte) 104, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      double num1 = domainAxis.valueToJava2D(this.getX(), dataArea, re1);
      double num2 = rangeAxis.valueToJava2D(this.getY(), dataArea, re2);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        double num3 = num1;
        num1 = num2;
        num2 = num3;
      }
      double num4 = num1 + Math.cos(this.angle) * this.baseRadius;
      double num5 = num2 + Math.sin(this.angle) * this.baseRadius;
      double num6 = num1 + Math.cos(this.angle) * this.tipRadius;
      double num7 = num2 + Math.sin(this.angle) * this.tipRadius;
      double num8 = num6 + Math.cos(this.angle) * this.arrowLength;
      double num9 = num7 + Math.sin(this.angle) * this.arrowLength;
      double num10 = num8 + Math.cos(this.angle + Math.PI / 2.0) * this.arrowWidth;
      double num11 = num9 + Math.sin(this.angle + Math.PI / 2.0) * this.arrowWidth;
      double num12 = num8 - Math.cos(this.angle + Math.PI / 2.0) * this.arrowWidth;
      double num13 = num9 - Math.sin(this.angle + Math.PI / 2.0) * this.arrowWidth;
      GeneralPath generalPath = new GeneralPath();
      ((Path2D.Float) generalPath).moveTo((float) num6, (float) num7);
      ((Path2D.Float) generalPath).lineTo((float) num10, (float) num11);
      ((Path2D.Float) generalPath).lineTo((float) num12, (float) num13);
      ((Path2D) generalPath).closePath();
      g2.setStroke(this.arrowStroke);
      g2.setPaint(this.arrowPaint);
      Line2D.Double @double = new Line2D.Double(num4, num5, num6, num7);
      g2.draw((Shape) @double);
      g2.fill((Shape) generalPath);
      double num14 = num1 + Math.cos(this.angle) * (this.baseRadius + this.labelOffset);
      double num15 = num2 + Math.sin(this.angle) * (this.baseRadius + this.labelOffset);
      ((Graphics) g2).setFont(this.getFont());
      Shape hotspot = TextUtilities.calculateRotatedStringBounds(this.getText(), g2, (float) num14, (float) num15, this.getTextAnchor(), this.getRotationAngle(), this.getRotationAnchor());
      if (this.getBackgroundPaint() != null)
      {
        g2.setPaint(this.getBackgroundPaint());
        g2.fill(hotspot);
      }
      g2.setPaint(this.getPaint());
      TextUtilities.drawRotatedString(this.getText(), g2, (float) num14, (float) num15, this.getTextAnchor(), this.getRotationAngle(), this.getRotationAnchor());
      if (this.isOutlineVisible())
      {
        g2.setStroke(this.getOutlineStroke());
        g2.setPaint(this.getOutlinePaint());
        g2.draw(hotspot);
      }
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, hotspot, rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 78, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYPointerAnnotation))
        return false;
      XYPointerAnnotation pointerAnnotation = (XYPointerAnnotation) obj;
      if (this.angle != pointerAnnotation.angle || this.tipRadius != pointerAnnotation.tipRadius || (this.baseRadius != pointerAnnotation.baseRadius || this.arrowLength != pointerAnnotation.arrowLength) || (this.arrowWidth != pointerAnnotation.arrowWidth || !Object.instancehelper_equals((object) this.arrowPaint, (object) pointerAnnotation.arrowPaint) || (!ObjectUtilities.equal((object) this.arrowStroke, (object) pointerAnnotation.arrowStroke) || this.labelOffset != pointerAnnotation.labelOffset)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 118, (byte) 103, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 113, (byte) 113, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = base.hashCode();
      long num2 = Double.doubleToLongBits(this.angle);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.tipRadius);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.baseRadius);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.arrowLength);
      int num9 = 37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32));
      long num10 = Double.doubleToLongBits(this.arrowWidth);
      int num11 = ((37 * num9 + (int) (num10 ^ (long) ((ulong) num10 >> 32))) * 37 + HashUtilities.hashCodeForPaint(this.arrowPaint)) * 37 + Object.instancehelper_hashCode((object) this.arrowStroke);
      long num12 = Double.doubleToLongBits(this.labelOffset);
      int num13 = 37 * num11 + (int) (num12 ^ (long) ((ulong) num12 >> 32));
      return base.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 514)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 155, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.arrowPaint, obj0);
      SerialUtilities.writeStroke(this.arrowStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 170, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.arrowPaint = SerialUtilities.readPaint(obj0);
      this.arrowStroke = SerialUtilities.readStroke(obj0);
    }
  }
}
