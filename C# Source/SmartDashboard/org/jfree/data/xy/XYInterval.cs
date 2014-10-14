// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYInterval
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
  public class XYInterval : Object, Serializable.__Interface, ISerializable
  {
    private double xLow;
    private double xHigh;
    private double y;
    private double yLow;
    private double yHigh;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 105, (byte) 105, (byte) 105, (byte) 106, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYInterval(double xLow, double xHigh, double y, double yLow, double yHigh)
    {
      base.\u002Ector();
      XYInterval xyInterval = this;
      this.xLow = xLow;
      this.xHigh = xHigh;
      this.y = y;
      this.yLow = yLow;
      this.yHigh = yHigh;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYInterval([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYInterval obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getXLow()
    {
      return this.xLow;
    }

    public virtual double getXHigh()
    {
      return this.xHigh;
    }

    public virtual double getY()
    {
      return this.y;
    }

    public virtual double getYLow()
    {
      return this.yLow;
    }

    public virtual double getYHigh()
    {
      return this.yHigh;
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYInterval))
        return false;
      XYInterval xyInterval = (XYInterval) obj;
      return this.xLow == xyInterval.xLow && this.xHigh == xyInterval.xHigh && (this.y == xyInterval.y && this.yLow == xyInterval.yLow) && this.yHigh == xyInterval.yHigh;
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
