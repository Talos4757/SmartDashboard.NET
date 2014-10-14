// Decompiled with JetBrains decompiler
// Type: org.jfree.text.TextFragment
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.font;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.text
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class TextFragment : Object, Serializable.__Interface, ISerializable
  {
    internal static Font __\u003C\u003EDEFAULT_FONT = new Font("Serif", 0, 12);
    internal static Paint __\u003C\u003EDEFAULT_PAINT = (Paint) Color.black;
    internal static LogContext __\u003C\u003Elogger = Log.createContext(TextFragment.class\u0024org\u0024jfree\u0024text\u0024TextFragment != null ? TextFragment.class\u0024org\u0024jfree\u0024text\u0024TextFragment : (TextFragment.class\u0024org\u0024jfree\u0024text\u0024TextFragment = TextFragment.class\u0024("org.jfree.text.TextFragment")));
    private const long serialVersionUID = 4465945952903143262L;
    private string text;
    private Font font;
    [NonSerialized]
    private Paint paint;
    private float baselineOffset;
    internal static Class class\u0024org\u0024jfree\u0024text\u0024TextFragment;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static Font DEFAULT_FONT
    {
      [HideFromJava] get
      {
        return TextFragment.__\u003C\u003EDEFAULT_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_PAINT
    {
      [HideFromJava] get
      {
        return TextFragment.__\u003C\u003EDEFAULT_PAINT;
      }
    }

    [Modifiers]
    protected internal static LogContext logger
    {
      [HideFromJava] get
      {
        return TextFragment.__\u003C\u003Elogger;
      }
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 178, (byte) 234, (byte) 82})]
    static TextFragment()
    {
    }

    [LineNumberTable(new byte[] {(byte) 83, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextFragment(string text, Font font, Paint paint)
      : this(text, font, paint, 0.0f)
    {
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextFragment(string text, Font font, Paint paint, float baselineOffset)
    {
      base.\u002Ector();
      TextFragment textFragment = this;
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (font == null)
      {
        string str = "Null 'font' argument.";
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
        this.text = text;
        this.font = font;
        this.paint = paint;
        this.baselineOffset = baselineOffset;
      }
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextFragment(string text)
      : this(text, TextFragment.__\u003C\u003EDEFAULT_FONT, TextFragment.__\u003C\u003EDEFAULT_PAINT)
    {
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextFragment(string text, Font font)
      : this(text, font, TextFragment.__\u003C\u003EDEFAULT_PAINT)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextFragment([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextFragment obj0)
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

    [LineNumberTable((ushort) 104)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, TextFragment.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
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

    public virtual float getBaselineOffset()
    {
      return this.baselineOffset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 108, (byte) 108, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, float anchorX, float anchorY, TextAnchor anchor, float rotateX, float rotateY, double angle)
    {
      ((Graphics) g2).setFont(this.font);
      g2.setPaint(this.paint);
      TextUtilities.drawRotatedString(this.text, g2, anchorX, anchorY + this.baselineOffset, anchor, angle, rotateX, rotateY);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 109, (byte) 142, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D calculateDimensions(Graphics2D g2)
    {
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.font);
      Rectangle2D textBounds = TextUtilities.getTextBounds(this.text, g2, fontMetrics);
      return new Size2D(((RectangularShape) textBounds).getWidth(), ((RectangularShape) textBounds).getHeight());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 102, (byte) 109, (byte) 109, (byte) 152, (byte) 137, (byte) 184, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual float calculateBaselineOffset(Graphics2D g2, TextAnchor anchor)
    {
      float num = 0.0f;
      LineMetrics lineMetrics = ((Graphics) g2).getFontMetrics(this.font).getLineMetrics("ABCxyz", (Graphics) g2);
      if (anchor == TextAnchor.__\u003C\u003ETOP_LEFT || anchor == TextAnchor.__\u003C\u003ETOP_CENTER || anchor == TextAnchor.__\u003C\u003ETOP_RIGHT)
        num = lineMetrics.getAscent();
      else if (anchor == TextAnchor.__\u003C\u003EBOTTOM_LEFT || anchor == TextAnchor.__\u003C\u003EBOTTOM_CENTER || anchor == TextAnchor.__\u003C\u003EBOTTOM_RIGHT)
        num = -lineMetrics.getDescent() - lineMetrics.getLeading();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj == this)
        return true;
      if (!(obj is TextFragment))
        return false;
      TextFragment textFragment = (TextFragment) obj;
      return String.instancehelper_equals(this.text, (object) textFragment.text) && this.font.equals((object) textFragment.font) && Object.instancehelper_equals((object) this.paint, (object) textFragment.paint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 119, (byte) 124, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (29 * (this.text == null ? 0 : String.instancehelper_hashCode(this.text)) + (this.font == null ? 0 : this.font.hashCode())) + (this.paint == null ? 0 : Object.instancehelper_hashCode((object) this.paint));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 200, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TextFragment.__\u003CcallerID\u003E == null)
        TextFragment.__\u003CcallerID\u003E = (CallerID) new TextFragment.__\u003CCallerID\u003E();
      return TextFragment.__\u003CcallerID\u003E;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
