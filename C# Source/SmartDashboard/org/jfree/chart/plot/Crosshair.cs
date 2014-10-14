// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.Crosshair
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.beans;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.labels;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class Crosshair : Object, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private bool visible;
    private double value;
    [NonSerialized]
    private Paint paint;
    [NonSerialized]
    private Stroke stroke;
    private bool labelVisible;
    private RectangleAnchor labelAnchor;
    private CrosshairLabelGenerator labelGenerator;
    private double labelXOffset;
    private double labelYOffset;
    private Font labelFont;
    [NonSerialized]
    private Paint labelPaint;
    [NonSerialized]
    private Paint labelBackgroundPaint;
    private bool labelOutlineVisible;
    [NonSerialized]
    private Stroke labelOutlineStroke;
    [NonSerialized]
    private Paint labelOutlinePaint;
    [NonSerialized]
    private PropertyChangeSupport pcs;

    [LineNumberTable(new byte[] {(byte) 95, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Crosshair(double value)
      : this(value, (Paint) Color.black, (Stroke) new BasicStroke(1f))
    {
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 105, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 112, (byte) 112, (byte) 115, (byte) 107, (byte) 116, (byte) 103, (byte) 107, (byte) 112, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Crosshair(double value, Paint paint, Stroke stroke)
    {
      base.\u002Ector();
      Crosshair crosshair = this;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.visible = true;
        this.value = value;
        this.paint = paint;
        this.stroke = stroke;
        this.labelVisible = false;
        this.labelGenerator = (CrosshairLabelGenerator) new StandardCrosshairLabelGenerator();
        this.labelAnchor = RectangleAnchor.__\u003C\u003EBOTTOM_LEFT;
        this.labelXOffset = 3.0;
        this.labelYOffset = 3.0;
        this.labelFont = new Font("Tahoma", 0, 12);
        this.labelPaint = (Paint) Color.black;
        this.labelBackgroundPaint = (Paint) new Color(0, 0, (int) byte.MaxValue, 63);
        this.labelOutlineVisible = true;
        this.labelOutlinePaint = (Paint) Color.black;
        this.labelOutlineStroke = (Stroke) new BasicStroke(0.5f);
        this.pcs = new PropertyChangeSupport((object) this);
      }
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Crosshair()
      : this(0.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Crosshair([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Crosshair obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Crosshair obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getValue()
    {
      return this.value;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 253, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPropertyChangeListener(PropertyChangeListener l)
    {
      this.pcs.addPropertyChangeListener(l);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 6, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removePropertyChangeListener(PropertyChangeListener l)
    {
      this.pcs.removePropertyChangeListener(l);
    }

    public virtual bool isVisible()
    {
      return this.visible;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    public virtual Stroke getStroke()
    {
      return this.stroke;
    }

    public virtual bool isLabelVisible()
    {
      return this.labelVisible;
    }

    public virtual CrosshairLabelGenerator getLabelGenerator()
    {
      return this.labelGenerator;
    }

    public virtual RectangleAnchor getLabelAnchor()
    {
      return this.labelAnchor;
    }

    public virtual Paint getLabelBackgroundPaint()
    {
      return this.labelBackgroundPaint;
    }

    public virtual Paint getLabelOutlinePaint()
    {
      return this.labelOutlinePaint;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 130, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setVisible(bool visible)
    {
      int num1 = visible ? 1 : 0;
      int num2 = this.visible ? 1 : 0;
      this.visible = num1 != 0;
      this.pcs.firePropertyChange("visible", num2 != 0, num1 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 113, (byte) 105, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(double value)
    {
      Double.__\u003Cclinit\u003E();
      Double @double = new Double(this.value);
      this.value = value;
      this.pcs.firePropertyChange("value", (object) @double, (object) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      Paint paint1 = this.paint;
      this.paint = paint;
      this.pcs.firePropertyChange("paint", (object) paint1, (object) paint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStroke(Stroke stroke)
    {
      Stroke stroke1 = this.stroke;
      this.stroke = stroke;
      this.pcs.firePropertyChange("stroke", (object) stroke1, (object) stroke);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 71, (byte) 66, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelVisible(bool visible)
    {
      int num1 = visible ? 1 : 0;
      int num2 = this.labelVisible ? 1 : 0;
      this.labelVisible = num1 != 0;
      this.pcs.firePropertyChange("labelVisible", num2 != 0, num1 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelGenerator(CrosshairLabelGenerator generator)
    {
      if (generator == null)
      {
        string str = "Null 'generator' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        CrosshairLabelGenerator crosshairLabelGenerator = this.labelGenerator;
        this.labelGenerator = generator;
        this.pcs.firePropertyChange("labelGenerator", (object) crosshairLabelGenerator, (object) generator);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelAnchor(RectangleAnchor anchor)
    {
      RectangleAnchor rectangleAnchor = this.labelAnchor;
      this.labelAnchor = anchor;
      this.pcs.firePropertyChange("labelAnchor", (object) rectangleAnchor, (object) anchor);
    }

    public virtual double getLabelXOffset()
    {
      return this.labelXOffset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 113, (byte) 105, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelXOffset(double offset)
    {
      Double.__\u003Cclinit\u003E();
      Double @double = new Double(this.labelXOffset);
      this.labelXOffset = offset;
      this.pcs.firePropertyChange("labelXOffset", (object) @double, (object) new Double(offset));
    }

    public virtual double getLabelYOffset()
    {
      return this.labelYOffset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 1, (byte) 113, (byte) 105, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelYOffset(double offset)
    {
      Double.__\u003Cclinit\u003E();
      Double @double = new Double(this.labelYOffset);
      this.labelYOffset = offset;
      this.pcs.firePropertyChange("labelYOffset", (object) @double, (object) new Double(offset));
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 22, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Font font1 = this.labelFont;
        this.labelFont = font;
        this.pcs.firePropertyChange("labelFont", (object) font1, (object) font);
      }
    }

    public virtual Paint getLabelPaint()
    {
      return this.labelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Paint paint1 = this.labelPaint;
        this.labelPaint = paint;
        this.pcs.firePropertyChange("labelPaint", (object) paint1, (object) paint);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelBackgroundPaint(Paint paint)
    {
      Paint paint1 = this.labelBackgroundPaint;
      this.labelBackgroundPaint = paint;
      this.pcs.firePropertyChange("labelBackgroundPaint", (object) paint1, (object) paint);
    }

    public virtual bool isLabelOutlineVisible()
    {
      return this.labelOutlineVisible;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 27, (byte) 130, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOutlineVisible(bool visible)
    {
      int num1 = visible ? 1 : 0;
      int num2 = this.labelOutlineVisible ? 1 : 0;
      this.labelOutlineVisible = num1 != 0;
      this.pcs.firePropertyChange("labelOutlineVisible", num2 != 0, num1 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 113, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOutlinePaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Paint paint1 = this.labelOutlinePaint;
        this.labelOutlinePaint = paint;
        this.pcs.firePropertyChange("labelOutlinePaint", (object) paint1, (object) paint);
      }
    }

    public virtual Stroke getLabelOutlineStroke()
    {
      return this.labelOutlineStroke;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 137, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabelOutlineStroke(Stroke stroke)
    {
      if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Stroke stroke1 = this.labelOutlineStroke;
        this.labelOutlineStroke = stroke;
        this.pcs.firePropertyChange("labelOutlineStroke", (object) stroke1, (object) stroke);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 153, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Crosshair))
        return false;
      Crosshair crosshair = (Crosshair) obj;
      return this.visible == crosshair.visible && this.value == crosshair.value && (PaintUtilities.equal(this.paint, crosshair.paint) && Object.instancehelper_equals((object) this.stroke, (object) crosshair.stroke)) && (this.labelVisible == crosshair.labelVisible && Object.instancehelper_equals((object) this.labelGenerator, (object) crosshair.labelGenerator) && (this.labelAnchor.equals((object) crosshair.labelAnchor) && this.labelXOffset == crosshair.labelXOffset)) && (this.labelYOffset == crosshair.labelYOffset && this.labelFont.equals((object) crosshair.labelFont) && (PaintUtilities.equal(this.labelPaint, crosshair.labelPaint) && PaintUtilities.equal(this.labelBackgroundPaint, crosshair.labelBackgroundPaint)) && (this.labelOutlineVisible == crosshair.labelOutlineVisible && PaintUtilities.equal(this.labelOutlinePaint, crosshair.labelOutlinePaint) && Object.instancehelper_equals((object) this.labelOutlineStroke, (object) crosshair.labelOutlineStroke)));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 216, (byte) 98, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(7, this.visible), this.value), this.paint), this.stroke), this.labelVisible), (object) this.labelAnchor), (object) this.labelGenerator), this.labelXOffset), this.labelYOffset), (object) this.labelFont), this.labelPaint), this.labelBackgroundPaint), this.labelOutlineVisible), this.labelOutlineStroke), this.labelOutlinePaint);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 614)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 17, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
      SerialUtilities.writePaint(this.labelPaint, obj0);
      SerialUtilities.writePaint(this.labelBackgroundPaint, obj0);
      SerialUtilities.writeStroke(this.labelOutlineStroke, obj0);
      SerialUtilities.writePaint(this.labelOutlinePaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 36, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
      this.labelPaint = SerialUtilities.readPaint(obj0);
      this.labelBackgroundPaint = SerialUtilities.readPaint(obj0);
      this.labelOutlineStroke = SerialUtilities.readStroke(obj0);
      this.labelOutlinePaint = SerialUtilities.readPaint(obj0);
      this.pcs = new PropertyChangeSupport((object) this);
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
