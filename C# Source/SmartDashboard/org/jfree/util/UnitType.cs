// Decompiled with JetBrains decompiler
// Type: org.jfree.util.UnitType
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

namespace org.jfree.util
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class UnitType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static UnitType __\u003C\u003EABSOLUTE = new UnitType("UnitType.ABSOLUTE");
    internal static UnitType __\u003C\u003ERELATIVE = new UnitType("UnitType.RELATIVE");
    private const long serialVersionUID = 6531925392288519884L;
    private string name;

    [Modifiers]
    public static UnitType ABSOLUTE
    {
      [HideFromJava] get
      {
        return UnitType.__\u003C\u003EABSOLUTE;
      }
    }

    [Modifiers]
    public static UnitType RELATIVE
    {
      [HideFromJava] get
      {
        return UnitType.__\u003C\u003ERELATIVE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 175})]
    static UnitType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private UnitType([In] string obj0)
    {
      base.\u002Ector();
      UnitType unitType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected UnitType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] UnitType obj0)
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

    [LineNumberTable((ushort) 113)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is UnitType && String.instancehelper_equals(this.name, (object) ((UnitType) obj).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 74, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) UnitType.__\u003C\u003EABSOLUTE))
        return (object) UnitType.__\u003C\u003EABSOLUTE;
      if (this.equals((object) UnitType.__\u003C\u003ERELATIVE))
        return (object) UnitType.__\u003C\u003ERELATIVE;
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
