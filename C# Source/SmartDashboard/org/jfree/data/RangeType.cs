// Decompiled with JetBrains decompiler
// Type: org.jfree.data.RangeType
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

namespace org.jfree.data
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class RangeType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static RangeType __\u003C\u003EFULL = new RangeType("RangeType.FULL");
    internal static RangeType __\u003C\u003EPOSITIVE = new RangeType("RangeType.POSITIVE");
    internal static RangeType __\u003C\u003ENEGATIVE = new RangeType("RangeType.NEGATIVE");
    private const long serialVersionUID = -9073319010650549239L;
    private string name;

    [Modifiers]
    public static RangeType FULL
    {
      [HideFromJava] get
      {
        return RangeType.__\u003C\u003EFULL;
      }
    }

    [Modifiers]
    public static RangeType POSITIVE
    {
      [HideFromJava] get
      {
        return RangeType.__\u003C\u003EPOSITIVE;
      }
    }

    [Modifiers]
    public static RangeType NEGATIVE
    {
      [HideFromJava] get
      {
        return RangeType.__\u003C\u003ENEGATIVE;
      }
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 175, (byte) 207})]
    static RangeType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private RangeType([In] string obj0)
    {
      base.\u002Ector();
      RangeType rangeType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RangeType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] RangeType obj0)
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

    [LineNumberTable(new byte[] {(byte) 47, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is RangeType && String.instancehelper_equals(this.name, (object) ((RangeType) obj).toString());
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 116)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 77, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) RangeType.__\u003C\u003EFULL))
        return (object) RangeType.__\u003C\u003EFULL;
      if (this.equals((object) RangeType.__\u003C\u003EPOSITIVE))
        return (object) RangeType.__\u003C\u003EPOSITIVE;
      if (this.equals((object) RangeType.__\u003C\u003ENEGATIVE))
        return (object) RangeType.__\u003C\u003ENEGATIVE;
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
