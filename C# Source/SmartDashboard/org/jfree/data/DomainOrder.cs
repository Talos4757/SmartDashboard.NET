// Decompiled with JetBrains decompiler
// Type: org.jfree.data.DomainOrder
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
  public sealed class DomainOrder : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static DomainOrder __\u003C\u003ENONE = new DomainOrder("DomainOrder.NONE");
    internal static DomainOrder __\u003C\u003EASCENDING = new DomainOrder("DomainOrder.ASCENDING");
    internal static DomainOrder __\u003C\u003EDESCENDING = new DomainOrder("DomainOrder.DESCENDING");
    private const long serialVersionUID = 4902774943512072627L;
    private string name;

    [Modifiers]
    public static DomainOrder NONE
    {
      [HideFromJava] get
      {
        return DomainOrder.__\u003C\u003ENONE;
      }
    }

    [Modifiers]
    public static DomainOrder ASCENDING
    {
      [HideFromJava] get
      {
        return DomainOrder.__\u003C\u003EASCENDING;
      }
    }

    [Modifiers]
    public static DomainOrder DESCENDING
    {
      [HideFromJava] get
      {
        return DomainOrder.__\u003C\u003EDESCENDING;
      }
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 175, (byte) 207})]
    static DomainOrder()
    {
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DomainOrder([In] string obj0)
    {
      base.\u002Ector();
      DomainOrder domainOrder = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DomainOrder([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DomainOrder obj0)
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

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is DomainOrder && String.instancehelper_equals(this.name, (object) ((DomainOrder) obj).toString());
    }

    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 76, (byte) 109, (byte) 134, (byte) 109, (byte) 134, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      if (this.equals((object) DomainOrder.__\u003C\u003EASCENDING))
        return (object) DomainOrder.__\u003C\u003EASCENDING;
      if (this.equals((object) DomainOrder.__\u003C\u003EDESCENDING))
        return (object) DomainOrder.__\u003C\u003EDESCENDING;
      if (this.equals((object) DomainOrder.__\u003C\u003ENONE))
        return (object) DomainOrder.__\u003C\u003ENONE;
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
