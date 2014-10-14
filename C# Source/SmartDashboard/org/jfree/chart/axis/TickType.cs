// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.TickType
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

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class TickType : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static TickType __\u003C\u003EMAJOR = new TickType("MAJOR");
    internal static TickType __\u003C\u003EMINOR = new TickType("MINOR");
    private string name;

    [Modifiers]
    public static TickType MAJOR
    {
      [HideFromJava] get
      {
        return TickType.__\u003C\u003EMAJOR;
      }
    }

    [Modifiers]
    public static TickType MINOR
    {
      [HideFromJava] get
      {
        return TickType.__\u003C\u003EMINOR;
      }
    }

    [LineNumberTable(new byte[] {(byte) 4, (byte) 175})]
    static TickType()
    {
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TickType([In] string obj0)
    {
      base.\u002Ector();
      TickType tickType = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TickType([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TickType obj0)
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

    [LineNumberTable(new byte[] {(byte) 39, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return this == obj || obj is TickType && String.instancehelper_equals(this.name, (object) ((TickType) obj).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 61, (byte) 98, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      TickType tickType = (TickType) null;
      if (this.equals((object) TickType.__\u003C\u003EMAJOR))
        tickType = TickType.__\u003C\u003EMAJOR;
      else if (this.equals((object) TickType.__\u003C\u003EMINOR))
        tickType = TickType.__\u003C\u003EMINOR;
      return (object) tickType;
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
