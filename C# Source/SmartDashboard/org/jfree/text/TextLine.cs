// Decompiled with JetBrains decompiler
// Type: org.jfree.text.TextLine
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.util;
using org.jfree.ui;
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
  public class TextLine : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7100085690160465444L;
    private List fragments;

    [LineNumberTable(new byte[] {(byte) 61, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 107, (byte) 105, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextLine(string text, Font font, Paint paint)
    {
      base.\u002Ector();
      TextLine textLine = this;
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
        this.fragments = (List) new ArrayList();
        this.fragments.add((object) new TextFragment(text, font, paint));
      }
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 104, (byte) 107, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextLine(string text, Font font)
    {
      base.\u002Ector();
      TextLine textLine = this;
      this.fragments = (List) new ArrayList();
      this.fragments.add((object) new TextFragment(text, font));
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextLine()
    {
      base.\u002Ector();
      TextLine textLine = this;
      this.fragments = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextLine(string text)
      : this(text, TextFragment.__\u003C\u003EDEFAULT_FONT)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextLine([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextLine obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 102, (byte) 102, (byte) 108, (byte) 104, (byte) 108, (byte) 105, (byte) 107, (byte) 111, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D calculateDimensions(Graphics2D g2)
    {
      double width = 0.0;
      double height = 0.0;
      Iterator iterator = this.fragments.iterator();
      while (iterator.hasNext())
      {
        Size2D size2D = ((TextFragment) iterator.next()).calculateDimensions(g2);
        width += size2D.getWidth();
        height = Math.max(height, size2D.getHeight());
      }
      return new Size2D(width, height);
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 99, (byte) 106, (byte) 108, (byte) 104, (byte) 108, (byte) 105, (byte) 219, (byte) 108, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, float anchorX, float anchorY, TextAnchor anchor, float rotateX, float rotateY, double angle)
    {
      float anchorX1 = anchorX;
      float num = this.calculateBaselineOffset(g2, anchor);
      Iterator iterator = this.fragments.iterator();
      while (iterator.hasNext())
      {
        TextFragment textFragment = (TextFragment) iterator.next();
        Size2D size2D = textFragment.calculateDimensions(g2);
        textFragment.draw(g2, anchorX1, anchorY + num, TextAnchor.__\u003C\u003EBASELINE_LEFT, rotateX, rotateY, angle);
        anchorX1 += (float) size2D.getWidth();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 102, (byte) 108, (byte) 104, (byte) 108, (byte) 143, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private float calculateBaselineOffset([In] Graphics2D obj0, [In] TextAnchor obj1)
    {
      float num = 0.0f;
      Iterator iterator = this.fragments.iterator();
      while (iterator.hasNext())
      {
        TextFragment textFragment = (TextFragment) iterator.next();
        num = Math.max(num, textFragment.calculateBaselineOffset(obj0, obj1));
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addFragment(TextFragment fragment)
    {
      this.fragments.add((object) fragment);
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeFragment(TextFragment fragment)
    {
      this.fragments.remove((object) fragment);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 98, (byte) 110, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TextFragment getFirstTextFragment()
    {
      TextFragment textFragment = (TextFragment) null;
      if (this.fragments.size() > 0)
        textFragment = (TextFragment) this.fragments.get(0);
      return textFragment;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 98, (byte) 110, (byte) 190})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TextFragment getLastTextFragment()
    {
      TextFragment textFragment = (TextFragment) null;
      if (this.fragments.size() > 0)
        textFragment = (TextFragment) this.fragments.get(this.fragments.size() - 1);
      return textFragment;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj == this)
        return true;
      if (!(obj is TextLine))
        return false;
      return (Object.instancehelper_equals((object) this.fragments, (object) ((TextLine) obj).fragments) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 272)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.fragments != null)
        return Object.instancehelper_hashCode((object) this.fragments);
      else
        return 0;
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
