// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.AbstractPieLabelDistributor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public abstract class AbstractPieLabelDistributor : Object, Serializable.__Interface, ISerializable
  {
    protected internal List labels;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractPieLabelDistributor()
    {
      base.\u002Ector();
      AbstractPieLabelDistributor labelDistributor = this;
      this.labels = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractPieLabelDistributor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractPieLabelDistributor obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PieLabelRecord getPieLabelRecord(int index)
    {
      return (PieLabelRecord) this.labels.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 99, (byte) 144, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPieLabelRecord(PieLabelRecord record)
    {
      if (record == null)
      {
        string str = "Null 'record' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.labels.add((object) record);
    }

    [LineNumberTable((ushort) 93)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.labels.size();
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.labels.clear();
    }

    public abstract void distributeLabels(double d1, double d2);

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
