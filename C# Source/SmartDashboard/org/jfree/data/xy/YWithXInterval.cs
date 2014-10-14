// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.YWithXInterval
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
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class YWithXInterval : Object, Serializable.__Interface, ISerializable
  {
    private double y;
    private double xLow;
    private double xHigh;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 105, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public YWithXInterval(double y, double xLow, double xHigh)
    {
      base.\u002Ector();
      YWithXInterval ywithXinterval = this;
      this.y = y;
      this.xLow = xLow;
      this.xHigh = xHigh;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected YWithXInterval([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] YWithXInterval obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual double getXLow()
    {
      return this.xLow;
    }

    public virtual double getXHigh()
    {
      return this.xHigh;
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is YWithXInterval))
        return false;
      YWithXInterval ywithXinterval = (YWithXInterval) obj;
      return this.y == ywithXinterval.y && this.xLow == ywithXinterval.xLow && this.xHigh == ywithXinterval.xHigh;
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
