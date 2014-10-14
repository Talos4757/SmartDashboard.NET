// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.VerticalAlignment
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

namespace org.jfree.ui
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class VerticalAlignment : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static VerticalAlignment __\u003C\u003ETOP = new VerticalAlignment("VerticalAlignment.TOP");
    internal static VerticalAlignment __\u003C\u003EBOTTOM = new VerticalAlignment("VerticalAlignment.BOTTOM");
    internal static VerticalAlignment __\u003C\u003ECENTER = new VerticalAlignment("VerticalAlignment.CENTER");
    private const long serialVersionUID = 7272397034325429853L;
    private string name;

    [Modifiers]
    public static VerticalAlignment TOP
    {
      [HideFromJava] get
      {
        return VerticalAlignment.__\u003C\u003ETOP;
      }
    }

    [Modifiers]
    public static VerticalAlignment BOTTOM
    {
      [HideFromJava] get
      {
        return VerticalAlignment.__\u003C\u003EBOTTOM;
      }
    }

    [Modifiers]
    public static VerticalAlignment CENTER
    {
      [HideFromJava] get
      {
        return VerticalAlignment.__\u003C\u003ECENTER;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 207, (byte) 207})]
    static VerticalAlignment()
    {
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private VerticalAlignment([In] string obj0)
    {
      base.\u002Ector();
      VerticalAlignment verticalAlignment = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected VerticalAlignment([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] VerticalAlignment obj0)
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

    [LineNumberTable(new byte[] {(byte) 52, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is VerticalAlignment && String.instancehelper_equals(this.name, (object) ((VerticalAlignment) o).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 123)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 84, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) VerticalAlignment.__\u003C\u003ETOP))
        return (object) VerticalAlignment.__\u003C\u003ETOP;
      if (this.equals((object) VerticalAlignment.__\u003C\u003EBOTTOM))
        return (object) VerticalAlignment.__\u003C\u003EBOTTOM;
      if (this.equals((object) VerticalAlignment.__\u003C\u003ECENTER))
        return (object) VerticalAlignment.__\u003C\u003ECENTER;
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
