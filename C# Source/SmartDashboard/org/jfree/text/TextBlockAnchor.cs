// Decompiled with JetBrains decompiler
// Type: org.jfree.text.TextBlockAnchor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
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
  public sealed class TextBlockAnchor : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static TextBlockAnchor __\u003C\u003ETOP_LEFT = new TextBlockAnchor("TextBlockAnchor.TOP_LEFT");
    internal static TextBlockAnchor __\u003C\u003ETOP_CENTER = new TextBlockAnchor("TextBlockAnchor.TOP_CENTER");
    internal static TextBlockAnchor __\u003C\u003ETOP_RIGHT = new TextBlockAnchor("TextBlockAnchor.TOP_RIGHT");
    internal static TextBlockAnchor __\u003C\u003ECENTER_LEFT = new TextBlockAnchor("TextBlockAnchor.CENTER_LEFT");
    internal static TextBlockAnchor __\u003C\u003ECENTER = new TextBlockAnchor("TextBlockAnchor.CENTER");
    internal static TextBlockAnchor __\u003C\u003ECENTER_RIGHT = new TextBlockAnchor("TextBlockAnchor.CENTER_RIGHT");
    internal static TextBlockAnchor __\u003C\u003EBOTTOM_LEFT = new TextBlockAnchor("TextBlockAnchor.BOTTOM_LEFT");
    internal static TextBlockAnchor __\u003C\u003EBOTTOM_CENTER = new TextBlockAnchor("TextBlockAnchor.BOTTOM_CENTER");
    internal static TextBlockAnchor __\u003C\u003EBOTTOM_RIGHT = new TextBlockAnchor("TextBlockAnchor.BOTTOM_RIGHT");
    private const long serialVersionUID = -3045058380983401544L;
    private string name;

    [Modifiers]
    public static TextBlockAnchor TOP_LEFT
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003ETOP_LEFT;
      }
    }

    [Modifiers]
    public static TextBlockAnchor TOP_CENTER
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003ETOP_CENTER;
      }
    }

    [Modifiers]
    public static TextBlockAnchor TOP_RIGHT
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003ETOP_RIGHT;
      }
    }

    [Modifiers]
    public static TextBlockAnchor CENTER_LEFT
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003ECENTER_LEFT;
      }
    }

    [Modifiers]
    public static TextBlockAnchor CENTER
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003ECENTER;
      }
    }

    [Modifiers]
    public static TextBlockAnchor CENTER_RIGHT
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003ECENTER_RIGHT;
      }
    }

    [Modifiers]
    public static TextBlockAnchor BOTTOM_LEFT
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT;
      }
    }

    [Modifiers]
    public static TextBlockAnchor BOTTOM_CENTER
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER;
      }
    }

    [Modifiers]
    public static TextBlockAnchor BOTTOM_RIGHT
    {
      [HideFromJava] get
      {
        return TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 207, (byte) 239, (byte) 69, (byte) 239, (byte) 69, (byte) 239, (byte) 69, (byte) 207, (byte) 239, (byte) 69, (byte) 207, (byte) 207})]
    static TextBlockAnchor()
    {
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextBlockAnchor([In] string obj0)
    {
      base.\u002Ector();
      TextBlockAnchor textBlockAnchor = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextBlockAnchor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextBlockAnchor obj0)
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

    [LineNumberTable(new byte[] {(byte) 80, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is TextBlockAnchor && String.instancehelper_equals(this.name, (object) ((TextBlockAnchor) o).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 151)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 112, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) TextBlockAnchor.__\u003C\u003ETOP_CENTER))
        return (object) TextBlockAnchor.__\u003C\u003ETOP_CENTER;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003ETOP_LEFT))
        return (object) TextBlockAnchor.__\u003C\u003ETOP_LEFT;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003ETOP_RIGHT))
        return (object) TextBlockAnchor.__\u003C\u003ETOP_RIGHT;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003ECENTER))
        return (object) TextBlockAnchor.__\u003C\u003ECENTER;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003ECENTER_LEFT))
        return (object) TextBlockAnchor.__\u003C\u003ECENTER_LEFT;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003ECENTER_RIGHT))
        return (object) TextBlockAnchor.__\u003C\u003ECENTER_RIGHT;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER))
        return (object) TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT))
        return (object) TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT;
      if (this.equals((object) TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT))
        return (object) TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT;
      else
        return (object) null;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    object IObjectReference.IObjectReference\u002EGetRealObject([In] StreamingContext obj0)
    {
      return this.readResolve();
    }
  }
}
