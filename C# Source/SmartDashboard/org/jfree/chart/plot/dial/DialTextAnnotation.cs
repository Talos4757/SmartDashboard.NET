// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialTextAnnotation
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
  public class DialTextAnnotation : AbstractDialLayer, DialLayer, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 3065267524054428071L;
    private string label;
    private Font font;
    [NonSerialized]
    private Paint paint;
    private double angle;
    private double radius;
    private TextAnchor anchor;

    [LineNumberTable(new byte[] {(byte) 52, (byte) 104, (byte) 99, (byte) 144, (byte) 112, (byte) 112, (byte) 115, (byte) 107, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DialTextAnnotation(string label)
    {
      DialTextAnnotation dialTextAnnotation = this;
      if (label == null)
      {
        string str = "Null 'label' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.angle = -90.0;
        this.radius = 0.3;
        this.font = new Font("Dialog", 1, 14);
        this.paint = (Paint) Color.black;
        this.label = label;
        this.anchor = TextAnchor.__\u003C\u003ETOP_CENTER;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DialTextAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DialTextAnnotation obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DialTextAnnotation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual string getLabel()
    {
      return this.label;
    }

    [LineNumberTable(new byte[] {(byte) 84, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLabel(string label)
    {
      if (label == null)
      {
        string str = "Null 'label' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.label = label;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual Font getFont()
    {
      return this.font;
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
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

    public virtual double getAngle()
    {
      return this.angle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 105, (byte) 110})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 105, (byte) 176, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRadius(double radius)
    {
      if (radius < 0.0)
      {
        string str = "The 'radius' cannot be negative.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.radius = radius;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public virtual TextAnchor getAnchor()
    {
      return this.anchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAnchor(TextAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.anchor = anchor;
        this.notifyListeners(new DialLayerChangeEvent((DialLayer) this));
      }
    }

    public override bool isClippedToWindow()
    {
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 147, (byte) 115, (byte) 103, (byte) 108, (byte) 108, (byte) 191, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, DialPlot plot, Rectangle2D frame, Rectangle2D view)
    {
      Point2D startPoint = ((Arc2D) new Arc2D.Double(DialPlot.rectangleByRadius(frame, this.radius, this.radius), this.angle, 0.0, 0)).getStartPoint();
      g2.setPaint(this.paint);
      ((Graphics) g2).setFont(this.font);
      TextUtilities.drawAlignedString(this.label, g2, (float) startPoint.getX(), (float) startPoint.getY(), this.anchor);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 210, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DialTextAnnotation))
        return false;
      DialTextAnnotation dialTextAnnotation = (DialTextAnnotation) obj;
      if (!String.instancehelper_equals(this.label, (object) dialTextAnnotation.label) || !this.font.equals((object) dialTextAnnotation.font) || (!PaintUtilities.equal(this.paint, dialTextAnnotation.paint) || this.radius != dialTextAnnotation.radius) || (this.angle != dialTextAnnotation.angle || !this.anchor.equals((object) dialTextAnnotation.anchor)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 244, (byte) 102, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 108, (byte) 109, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num1 = 37 * (37 * (37 * (37 * 193 + HashUtilities.hashCodeForPaint(this.paint)) + this.font.hashCode()) + String.instancehelper_hashCode(this.label)) + this.anchor.hashCode();
      long num2 = Double.doubleToLongBits(this.angle);
      int num3 = 37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = Double.doubleToLongBits(this.radius);
      return 37 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 379)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
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
