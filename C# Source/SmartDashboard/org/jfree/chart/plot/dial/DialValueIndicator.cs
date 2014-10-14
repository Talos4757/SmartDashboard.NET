// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialValueIndicator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.text;
using org.jfree.chart;
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

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialLayer", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DialValueIndicator : AbstractDialLayer, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 803094354130942585L;
    private int datasetIndex;
    private double angle;
    private double radius;
    private RectangleAnchor frameAnchor;
    private Number templateValue;
    private NumberFormat formatter;
    private Font font;
    [NonSerialized]
    private Paint paint;
    [NonSerialized]
    private Paint backgroundPaint;
    [NonSerialized]
    private Stroke outlineStroke;
    [NonSerialized]
    private Paint outlinePaint;
    private RectangleInsets insets;
    private RectangleAnchor valueAnchor;
    private TextAnchor textAnchor;

    [LineNumberTable(new byte[] {(byte) 87, (byte) 104, (byte) 103, (byte) 112, (byte) 112, (byte) 107, (byte) 116, (byte) 112, (byte) 115, (byte) 107, (byte) 107, (byte) 112, (byte) 107, (byte) 127, (byte) 16, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DialValueIndicator(int datasetIndex)
    {
      DialValueIndicator dialValueIndicator = this;
      this.datasetIndex = datasetIndex;
      this.angle = -90.0;
      this.radius = 0.3;
      this.frameAnchor = RectangleAnchor.__\u003C\u003ECENTER;
      this.templateValue = (Number) new Double(100.0);
      this.formatter = (NumberFormat) new DecimalFormat("0.0");
      this.font = new Font("Dialog", 1, 14);
      this.paint = (Paint) Color.black;
      this.backgroundPaint = (Paint) Color.white;
      this.outlineStroke = (Stroke) new BasicStroke(1f);
      this.outlinePaint = (Paint) Color.blue;
      this.insets = new RectangleInsets(4.0, 4.0, 4.0, 4.0);
      this.valueAnchor = RectangleAnchor.__\u003C\u003ERIGHT;
      this.textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DialValueIndicator()
      : this(0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DialValueIndicator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DialValueIndicator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DialValueIndicator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int getDatasetIndex()
    {
      return this.datasetIndex;
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDatasetIndex(int index)
    {
      this.datasetIndex = index;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getAngle()
    {
      return this.angle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAngle(double angle)
    {
      this.angle = angle;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual double getRadius()
    {
      return this.radius;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadius(double radius)
    {
      this.radius = radius;
      this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
    }

    public virtual RectangleAnchor getFrameAnchor()
    {
      return this.frameAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFrameAnchor(RectangleAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.frameAnchor = anchor;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Number getTemplateValue()
    {
      return this.templateValue;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTemplateValue(Number value)
    {
      if (value == null)
      {
        string str = "Null 'value' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.templateValue = value;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual NumberFormat getNumberFormat()
    {
      return this.formatter;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNumberFormat(NumberFormat formatter)
    {
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.formatter = formatter;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Font getFont()
    {
      return this.font;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 213, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.font = font;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 240, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.paint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 11, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.backgroundPaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.outlineStroke = stroke;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.outlinePaint = paint;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual RectangleInsets getInsets()
    {
      return this.insets;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setInsets(RectangleInsets insets)
    {
      if (insets == null)
      {
        string str = "Null 'insets' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.insets = insets;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual RectangleAnchor getValueAnchor()
    {
      return this.valueAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 119, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValueAnchor(RectangleAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.valueAnchor = anchor;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual TextAnchor getTextAnchor()
    {
      return this.textAnchor;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 146, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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
      {
        this.textAnchor = anchor;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public override bool isClippedToWindow()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 177, (byte) 147, (byte) 115, (byte) 167, (byte) 109, (byte) 115, (byte) 171, (byte) 255, (byte) 13, (byte) 69, (byte) 175, (byte) 108, (byte) 168, (byte) 108, (byte) 108, (byte) 200, (byte) 111, (byte) 111, (byte) 111, (byte) 108, (byte) 108, (byte) 191, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      Point2D startPoint = ((Arc2D) new Arc2D.Double(DialPlot.rectangleByRadius(frame, this.radius, this.radius), this.angle, 0.0, 0)).getStartPoint();
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.font);
      Rectangle2D textBounds = TextUtilities.getTextBounds(((Format) this.formatter).format((object) this.templateValue), g2, fontMetrics);
      Rectangle2D rectangle = RectangleAnchor.createRectangle(new Size2D(((RectangularShape) textBounds).getWidth(), ((RectangularShape) textBounds).getHeight()), startPoint.getX(), startPoint.getY(), this.frameAnchor);
      Rectangle2D outsetRectangle = this.insets.createOutsetRectangle(rectangle);
      g2.setPaint(this.backgroundPaint);
      g2.fill((Shape) outsetRectangle);
      g2.setStroke(this.outlineStroke);
      g2.setPaint(this.outlinePaint);
      g2.draw((Shape) outsetRectangle);
      string text = this.formatter.format(plot.getValue(this.datasetIndex));
      Point2D point2D = RectangleAnchor.coordinates(rectangle, this.valueAnchor);
      g2.setPaint(this.paint);
      ((Graphics) g2).setFont(this.font);
      TextUtilities.drawAlignedString(text, g2, (float) point2D.getX(), (float) point2D.getY(), this.textAnchor);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 224, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DialValueIndicator))
        return false;
      DialValueIndicator dialValueIndicator = (DialValueIndicator) obj;
      if (this.datasetIndex != dialValueIndicator.datasetIndex || this.angle != dialValueIndicator.angle || (this.radius != dialValueIndicator.radius || !this.frameAnchor.equals((object) dialValueIndicator.frameAnchor)) || (!Object.instancehelper_equals((object) this.templateValue, (object) dialValueIndicator.templateValue) || !this.font.equals((object) dialValueIndicator.font) || (!PaintUtilities.equal(this.paint, dialValueIndicator.paint) || !PaintUtilities.equal(this.backgroundPaint, dialValueIndicator.backgroundPaint))) || (!Object.instancehelper_equals((object) this.outlineStroke, (object) dialValueIndicator.outlineStroke) || !PaintUtilities.equal(this.outlinePaint, dialValueIndicator.outlinePaint) || (!this.insets.equals((object) dialValueIndicator.insets) || !this.valueAnchor.equals((object) dialValueIndicator.valueAnchor)) || !this.textAnchor.equals((object) dialValueIndicator.textAnchor)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 24, (byte) 102, (byte) 113, (byte) 145, (byte) 145, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return 37 * (37 * (37 * (37 * 193 + HashUtilities.hashCodeForPaint(this.paint)) + HashUtilities.hashCodeForPaint(this.backgroundPaint)) + HashUtilities.hashCodeForPaint(this.outlinePaint)) + Object.instancehelper_hashCode((object) this.outlineStroke);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 669)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 54, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
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
    [LineNumberTable(new byte[] {(byte) 162, (byte) 71, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
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
