// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.CategoryPointerAnnotation
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
using org.jfree.data.category;
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
  public class CategoryPointerAnnotation : CategoryTextAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
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
    static CategoryPointerAnnotation()
    {
      CategoryTextAnnotation.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 108, (byte) 106, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryPointerAnnotation(string label, IComparable key, double value, double angle)
      : base(label, key, value)
    {
      CategoryPointerAnnotation pointerAnnotation = this;
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
    protected CategoryPointerAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryPointerAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryPointerAnnotation obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 198, (byte) 99, (byte) 144, (byte) 103})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 99, (byte) 144, (byte) 103})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 103, (byte) 141, (byte) 141, (byte) 103, (byte) 110, (byte) 104, (byte) 144, (byte) 114, (byte) 104, (byte) 100, (byte) 100, (byte) 132, (byte) 120, (byte) 152, (byte) 120, (byte) 152, (byte) 120, (byte) 152, (byte) 159, (byte) 3, (byte) 191, (byte) 3, (byte) 159, (byte) 3, (byte) 191, (byte) 3, (byte) 103, (byte) 109, (byte) 109, (byte) 109, (byte) 135, (byte) 108, (byte) 108, (byte) 111, (byte) 104, (byte) 168, (byte) 108, (byte) 108, (byte) 159, (byte) 0, (byte) 159, (byte) 0, (byte) 217})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, CategoryPlot plot, Rectangle2D dataArea, CategoryAxis domainAxis, ValueAxis rangeAxis)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge edge = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      CategoryDataset dataset = plot.getDataset();
      int columnIndex = dataset.getColumnIndex(this.getCategory());
      int columnCount = dataset.getColumnCount();
      double num1 = domainAxis.getCategoryMiddle(columnIndex, columnCount, dataArea, edge);
      double num2 = rangeAxis.valueToJava2D(this.getValue(), dataArea, re);
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
      ((Graphics) g2).setFont(this.getFont());
      g2.setPaint(this.getPaint());
      double num14 = num1 + Math.cos(this.angle) * (this.baseRadius + this.labelOffset);
      double num15 = num2 + Math.sin(this.angle) * (this.baseRadius + this.labelOffset);
      TextUtilities.drawAlignedString(this.getText(), g2, (float) num14, (float) num15, this.getTextAnchor());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryPointerAnnotation) || !base.equals(obj))
        return false;
      CategoryPointerAnnotation pointerAnnotation = (CategoryPointerAnnotation) obj;
      return this.angle == pointerAnnotation.angle && this.tipRadius == pointerAnnotation.tipRadius && (this.baseRadius == pointerAnnotation.baseRadius && this.arrowLength == pointerAnnotation.arrowLength) && (this.arrowWidth == pointerAnnotation.arrowWidth && Object.instancehelper_equals((object) this.arrowPaint, (object) pointerAnnotation.arrowPaint) && (ObjectUtilities.equal((object) this.arrowStroke, (object) pointerAnnotation.arrowStroke) && this.labelOffset == pointerAnnotation.labelOffset));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 97, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 113, (byte) 113, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 193;
      long num2 = Double.doubleToLongBits(this.angle);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.tipRadius);
      int num5 = 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = Double.doubleToLongBits(this.baseRadius);
      int num7 = 37 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = Double.doubleToLongBits(this.arrowLength);
      int num9 = 37 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32));
      long num10 = Double.doubleToLongBits(this.arrowWidth);
      int num11 = 37 * (37 * (37 * num9 + (int) (num10 ^ (long) ((ulong) num10 >> 32))) + HashUtilities.hashCodeForPaint(this.arrowPaint)) + Object.instancehelper_hashCode((object) this.arrowStroke);
      long num12 = Double.doubleToLongBits(this.labelOffset);
      return 37 * num11 + (int) (num12 ^ (long) ((ulong) num12 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 493)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 134, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.arrowPaint, obj0);
      SerialUtilities.writeStroke(this.arrowStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.arrowPaint = SerialUtilities.readPaint(obj0);
      this.arrowStroke = SerialUtilities.readStroke(obj0);
    }
  }
}
