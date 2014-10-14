// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.XYTextAnnotation
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
using org.jfree.text;
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
  public class XYTextAnnotation : AbstractXYAnnotation, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal static Font __\u003C\u003EDEFAULT_FONT = new Font("SansSerif", 0, 10);
    internal static Paint __\u003C\u003EDEFAULT_PAINT = (Paint) Color.black;
    internal static TextAnchor __\u003C\u003EDEFAULT_TEXT_ANCHOR = TextAnchor.__\u003C\u003ECENTER;
    internal static TextAnchor __\u003C\u003EDEFAULT_ROTATION_ANCHOR = TextAnchor.__\u003C\u003ECENTER;
    private const long serialVersionUID = -2946063342782506328L;
    public const double DEFAULT_ROTATION_ANGLE = 0.0;
    private string text;
    private Font font;
    [NonSerialized]
    private Paint paint;
    private double x;
    private double y;
    private TextAnchor textAnchor;
    private TextAnchor rotationAnchor;
    private double rotationAngle;
    [NonSerialized]
    private Paint backgroundPaint;
    private bool outlineVisible;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;

    [Modifiers]
    public static Font DEFAULT_FONT
    {
      [HideFromJava] get
      {
        return XYTextAnnotation.__\u003C\u003EDEFAULT_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_PAINT
    {
      [HideFromJava] get
      {
        return XYTextAnnotation.__\u003C\u003EDEFAULT_PAINT;
      }
    }

    [Modifiers]
    public static TextAnchor DEFAULT_TEXT_ANCHOR
    {
      [HideFromJava] get
      {
        return XYTextAnnotation.__\u003C\u003EDEFAULT_TEXT_ANCHOR;
      }
    }

    [Modifiers]
    public static TextAnchor DEFAULT_ROTATION_ANCHOR
    {
      [HideFromJava] get
      {
        return XYTextAnnotation.__\u003C\u003EDEFAULT_ROTATION_ANCHOR;
      }
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 210, (byte) 170, (byte) 170})]
    static XYTextAnnotation()
    {
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 107, (byte) 107, (byte) 105, (byte) 105, (byte) 107, (byte) 107, (byte) 172, (byte) 103, (byte) 103, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYTextAnnotation(string text, double x, double y)
    {
      XYTextAnnotation xyTextAnnotation = this;
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.text = text;
        this.font = XYTextAnnotation.__\u003C\u003EDEFAULT_FONT;
        this.paint = XYTextAnnotation.__\u003C\u003EDEFAULT_PAINT;
        this.x = x;
        this.y = y;
        this.textAnchor = XYTextAnnotation.__\u003C\u003EDEFAULT_TEXT_ANCHOR;
        this.rotationAnchor = XYTextAnnotation.__\u003C\u003EDEFAULT_ROTATION_ANCHOR;
        this.rotationAngle = 0.0;
        this.backgroundPaint = (Paint) null;
        this.outlineVisible = false;
        this.outlinePaint = (Paint) Color.black;
        this.outlineStroke = (Stroke) new BasicStroke(0.5f);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYTextAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYTextAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYTextAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.font = font;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.paint = paint;
    }

    public virtual Font getFont()
    {
      return this.font;
    }

    public virtual string getText()
    {
      return this.text;
    }

    public virtual TextAnchor getTextAnchor()
    {
      return this.textAnchor;
    }

    public virtual double getRotationAngle()
    {
      return this.rotationAngle;
    }

    public virtual TextAnchor getRotationAnchor()
    {
      return this.rotationAnchor;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setText(string text)
    {
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.text = text;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTextAnchor(TextAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.textAnchor = anchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRotationAnchor(TextAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.rotationAnchor = anchor;
    }

    public virtual void setRotationAngle(double angle)
    {
      this.rotationAngle = angle;
    }

    public virtual double getX()
    {
      return this.x;
    }

    public virtual void setX(double x)
    {
      this.x = x;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual void setY(double y)
    {
      this.y = y;
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    public virtual void setBackgroundPaint(Paint paint)
    {
      this.backgroundPaint = paint;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.outlinePaint = paint;
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 94, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.outlineStroke = stroke;
    }

    public virtual bool isOutlineVisible()
    {
      return this.outlineVisible;
    }

    public virtual void setOutlineVisible(bool visible)
    {
      this.outlineVisible = visible;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 139, (byte) 103, (byte) 141, (byte) 173, (byte) 145, (byte) 178, (byte) 104, (byte) 99, (byte) 99, (byte) 164, (byte) 108, (byte) 191, (byte) 4, (byte) 104, (byte) 108, (byte) 136, (byte) 108, (byte) 159, (byte) 2, (byte) 104, (byte) 108, (byte) 108, (byte) 168, (byte) 104, (byte) 104, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, XYPlot plot, Rectangle2D dataArea, ValueAxis domainAxis, ValueAxis rangeAxis, int rendererIndex, PlotRenderingInfo info)
    {
      PlotOrientation orientation = plot.getOrientation();
      RectangleEdge re1 = Plot.resolveDomainAxisLocation(plot.getDomainAxisLocation(), orientation);
      RectangleEdge re2 = Plot.resolveRangeAxisLocation(plot.getRangeAxisLocation(), orientation);
      float x = (float) domainAxis.valueToJava2D(this.x, dataArea, re1);
      float y = (float) rangeAxis.valueToJava2D(this.y, dataArea, re2);
      if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
      {
        float num = x;
        x = y;
        y = num;
      }
      ((Graphics) g2).setFont(this.getFont());
      Shape hotspot = TextUtilities.calculateRotatedStringBounds(this.getText(), g2, x, y, this.getTextAnchor(), this.getRotationAngle(), this.getRotationAnchor());
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill(hotspot);
      }
      g2.setPaint(this.getPaint());
      TextUtilities.drawRotatedString(this.getText(), g2, x, y, this.getTextAnchor(), this.getRotationAngle(), this.getRotationAnchor());
      if (this.outlineVisible)
      {
        g2.setStroke(this.outlineStroke);
        g2.setPaint(this.outlinePaint);
        g2.draw(hotspot);
      }
      string toolTipText = this.getToolTipText();
      string url = this.getURL();
      if (toolTipText == null && url == null)
        return;
      this.addEntity(info, hotspot, rendererIndex, toolTipText, url);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYTextAnnotation))
        return false;
      XYTextAnnotation xyTextAnnotation = (XYTextAnnotation) obj;
      if (!String.instancehelper_equals(this.text, (object) xyTextAnnotation.text) || this.x != xyTextAnnotation.x || (this.y != xyTextAnnotation.y || !this.font.equals((object) xyTextAnnotation.font)) || (!PaintUtilities.equal(this.paint, xyTextAnnotation.paint) || !this.rotationAnchor.equals((object) xyTextAnnotation.rotationAnchor) || (this.rotationAngle != xyTextAnnotation.rotationAngle || !this.textAnchor.equals((object) xyTextAnnotation.textAnchor))) || (this.outlineVisible != xyTextAnnotation.outlineVisible || !PaintUtilities.equal(this.backgroundPaint, xyTextAnnotation.backgroundPaint) || (!PaintUtilities.equal(this.outlinePaint, xyTextAnnotation.outlinePaint) || !Object.instancehelper_equals((object) this.outlineStroke, (object) xyTextAnnotation.outlineStroke))))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 241, (byte) 102, (byte) 111, (byte) 111, (byte) 113, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 113, (byte) 113, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 37 * String.instancehelper_hashCode(this.text);
      int num2 = 37 * (37 * this.font.hashCode()) + HashUtilities.hashCodeForPaint(this.paint);
      long num3 = Double.doubleToLongBits(this.x);
      int num4 = 37 * num2 + (int) (num3 ^ (long) ((ulong) num3 >> 32));
      long num5 = Double.doubleToLongBits(this.y);
      int num6 = 37 * (37 * (37 * num4 + (int) (num5 ^ (long) ((ulong) num5 >> 32))) + this.textAnchor.hashCode()) + this.rotationAnchor.hashCode();
      long num7 = Double.doubleToLongBits(this.rotationAngle);
      return 37 * num6 + (int) (num7 ^ (long) ((ulong) num7 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 634)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 19, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 36, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
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
