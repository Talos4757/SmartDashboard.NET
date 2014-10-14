// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.WindDataItem
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

namespace org.jfree.data.xy
{
  [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable"})]
  [SourceFile("DefaultWindDataset.java")]
  [Modifiers]
  [Serializable]
  internal sealed class WindDataItem : Object, Comparable, Serializable.__Interface, ISerializable
  {
    private Number x;
    private Number windDir;
    private Number windForce;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 232, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindDataItem([In] Number obj0, [In] Number obj1, [In] Number obj2)
    {
      base.\u002Ector();
      WindDataItem windDataItem = this;
      this.x = obj0;
      this.windDir = obj1;
      this.windForce = obj2;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WindDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    public virtual Number getX()
    {
      return this.x;
    }

    public virtual Number getWindDirection()
    {
      return this.windDir;
    }

    public virtual Number getWindForce()
    {
      return this.windForce;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 17, (byte) 104, (byte) 103, (byte) 120, (byte) 130, (byte) 115, (byte) 162, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo([In] object obj0)
    {
      if (obj0 is WindDataItem)
      {
        WindDataItem windDataItem = (WindDataItem) obj0;
        if (this.x.doubleValue() > windDataItem.x.doubleValue())
          return 1;
        return Object.instancehelper_equals((object) this.x, (object) windDataItem.x) ? 0 : -1;
      }
      else
      {
        string str = "WindDataItem.compareTo(error)";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ClassCastException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals([In] object obj0)
    {
      if (this == obj0 || !(obj0 is WindDataItem))
        return false;
      WindDataItem windDataItem = (WindDataItem) obj0;
      return Object.instancehelper_equals((object) this.x, (object) windDataItem.x) && Object.instancehelper_equals((object) this.windDir, (object) windDataItem.windDir) && Object.instancehelper_equals((object) this.windForce, (object) windDataItem.windForce);
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
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
