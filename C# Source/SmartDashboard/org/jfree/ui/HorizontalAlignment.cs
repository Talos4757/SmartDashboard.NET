// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.HorizontalAlignment
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
  public sealed class HorizontalAlignment : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static HorizontalAlignment __\u003C\u003ELEFT = new HorizontalAlignment("HorizontalAlignment.LEFT");
    internal static HorizontalAlignment __\u003C\u003ERIGHT = new HorizontalAlignment("HorizontalAlignment.RIGHT");
    internal static HorizontalAlignment __\u003C\u003ECENTER = new HorizontalAlignment("HorizontalAlignment.CENTER");
    private const long serialVersionUID = -8249740987565309567L;
    private string name;

    [Modifiers]
    public static HorizontalAlignment LEFT
    {
      [HideFromJava] get
      {
        return HorizontalAlignment.__\u003C\u003ELEFT;
      }
    }

    [Modifiers]
    public static HorizontalAlignment RIGHT
    {
      [HideFromJava] get
      {
        return HorizontalAlignment.__\u003C\u003ERIGHT;
      }
    }

    [Modifiers]
    public static HorizontalAlignment CENTER
    {
      [HideFromJava] get
      {
        return HorizontalAlignment.__\u003C\u003ECENTER;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 207, (byte) 207})]
    static HorizontalAlignment()
    {
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private HorizontalAlignment([In] string obj0)
    {
      base.\u002Ector();
      HorizontalAlignment horizontalAlignment = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HorizontalAlignment([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HorizontalAlignment obj0)
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

    [LineNumberTable(new byte[] {(byte) 51, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is HorizontalAlignment && String.instancehelper_equals(this.name, (object) ((HorizontalAlignment) obj).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 81, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      HorizontalAlignment horizontalAlignment = (HorizontalAlignment) null;
      if (this.equals((object) HorizontalAlignment.__\u003C\u003ELEFT))
        horizontalAlignment = HorizontalAlignment.__\u003C\u003ELEFT;
      else if (this.equals((object) HorizontalAlignment.__\u003C\u003ERIGHT))
        horizontalAlignment = HorizontalAlignment.__\u003C\u003ERIGHT;
      else if (this.equals((object) HorizontalAlignment.__\u003C\u003ECENTER))
        horizontalAlignment = HorizontalAlignment.__\u003C\u003ECENTER;
      return (object) horizontalAlignment;
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
