// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.MeanAndStandardDeviation
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class MeanAndStandardDeviation : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7413468697315721515L;
    private Number mean;
    private Number standardDeviation;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeanAndStandardDeviation(Number mean, Number standardDeviation)
    {
      base.\u002Ector();
      MeanAndStandardDeviation standardDeviation1 = this;
      this.mean = mean;
      this.standardDeviation = standardDeviation;
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeanAndStandardDeviation(double mean, double standardDeviation)
      : this((Number) new Double(mean), (Number) new Double(standardDeviation))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MeanAndStandardDeviation([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MeanAndStandardDeviation obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Number getMean()
    {
      return this.mean;
    }

    public virtual Number getStandardDeviation()
    {
      return this.standardDeviation;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMeanValue()
    {
      double num = double.NaN;
      if (this.mean != null)
        num = this.mean.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 84, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getStandardDeviationValue()
    {
      double num = double.NaN;
      if (this.standardDeviation != null)
        num = this.standardDeviation.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 179, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MeanAndStandardDeviation))
        return false;
      MeanAndStandardDeviation standardDeviation = (MeanAndStandardDeviation) obj;
      return ObjectUtilities.equal((object) this.mean, (object) standardDeviation.mean) && ObjectUtilities.equal((object) this.standardDeviation, (object) standardDeviation.standardDeviation);
    }

    [LineNumberTable((ushort) 175)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("[").append((object) this.mean).append(", ").append((object) this.standardDeviation).append("]").toString();
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
