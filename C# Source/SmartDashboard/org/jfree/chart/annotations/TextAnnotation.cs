// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.annotations.TextAnnotation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.chart;
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
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class TextAnnotation : Object, Serializable.__Interface, ISerializable
  {
    internal static Font __\u003C\u003EDEFAULT_FONT = new Font("SansSerif", 0, 10);
    internal static Paint __\u003C\u003EDEFAULT_PAINT = (Paint) Color.black;
    internal static TextAnchor __\u003C\u003EDEFAULT_TEXT_ANCHOR = TextAnchor.__\u003C\u003ECENTER;
    internal static TextAnchor __\u003C\u003EDEFAULT_ROTATION_ANCHOR = TextAnchor.__\u003C\u003ECENTER;
    private const long serialVersionUID = 7008912287533127432L;
    public const double DEFAULT_ROTATION_ANGLE = 0.0;
    private string text;
    private Font font;
    [NonSerialized]
    private Paint paint;
    private TextAnchor textAnchor;
    private TextAnchor rotationAnchor;
    private double rotationAngle;

    [Modifiers]
    public static Font DEFAULT_FONT
    {
      [HideFromJava] get
      {
        return TextAnnotation.__\u003C\u003EDEFAULT_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_PAINT
    {
      [HideFromJava] get
      {
        return TextAnnotation.__\u003C\u003EDEFAULT_PAINT;
      }
    }

    [Modifiers]
    public static TextAnchor DEFAULT_TEXT_ANCHOR
    {
      [HideFromJava] get
      {
        return TextAnnotation.__\u003C\u003EDEFAULT_TEXT_ANCHOR;
      }
    }

    [Modifiers]
    public static TextAnchor DEFAULT_ROTATION_ANCHOR
    {
      [HideFromJava] get
      {
        return TextAnnotation.__\u003C\u003EDEFAULT_ROTATION_ANCHOR;
      }
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 210, (byte) 170, (byte) 170})]
    static TextAnnotation()
    {
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal TextAnnotation(string text)
    {
      base.\u002Ector();
      TextAnnotation textAnnotation = this;
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.text = text;
        this.font = TextAnnotation.__\u003C\u003EDEFAULT_FONT;
        this.paint = TextAnnotation.__\u003C\u003EDEFAULT_PAINT;
        this.textAnchor = TextAnnotation.__\u003C\u003EDEFAULT_TEXT_ANCHOR;
        this.rotationAnchor = TextAnnotation.__\u003C\u003EDEFAULT_ROTATION_ANCHOR;
        this.rotationAngle = 0.0;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextAnnotation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextAnnotation obj0)
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

    public virtual string getText()
    {
      return this.text;
    }

    public virtual Font getFont()
    {
      return this.font;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    public virtual TextAnchor getTextAnchor()
    {
      return this.textAnchor;
    }

    public virtual TextAnchor getRotationAnchor()
    {
      return this.rotationAnchor;
    }

    public virtual double getRotationAngle()
    {
      return this.rotationAngle;
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 99, (byte) 144, (byte) 103})]
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

    [LineNumberTable(new byte[] {(byte) 122, (byte) 99, (byte) 144, (byte) 103})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 99, (byte) 144, (byte) 103})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 99, (byte) 144, (byte) 103})]
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

    public virtual void setRotationAnchor(TextAnchor anchor)
    {
      this.rotationAnchor = anchor;
    }

    public virtual void setRotationAngle(double angle)
    {
      this.rotationAngle = angle;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 100, (byte) 162, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 110, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TextAnnotation))
        return false;
      TextAnnotation textAnnotation = (TextAnnotation) obj;
      return ObjectUtilities.equal((object) this.text, (object) textAnnotation.getText()) && ObjectUtilities.equal((object) this.font, (object) textAnnotation.getFont()) && (PaintUtilities.equal(this.paint, textAnnotation.getPaint()) && ObjectUtilities.equal((object) this.textAnchor, (object) textAnnotation.getTextAnchor())) && (ObjectUtilities.equal((object) this.rotationAnchor, (object) textAnnotation.getRotationAnchor()) && this.rotationAngle == textAnnotation.getRotationAngle());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 102, (byte) 113, (byte) 113, (byte) 113, (byte) 108, (byte) 109, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 37 * (37 * (37 * 193 + this.font.hashCode()) + HashUtilities.hashCodeForPaint(this.paint)) + this.rotationAnchor.hashCode();
      long num2 = Double.doubleToLongBits(this.rotationAngle);
      return 37 * (37 * (37 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32))) + String.instancehelper_hashCode(this.text)) + this.textAnchor.hashCode();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 225, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 102, (byte) 108})]
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
