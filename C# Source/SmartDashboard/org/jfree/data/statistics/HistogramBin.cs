// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.HistogramBin
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

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class HistogramBin : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7614685080015589931L;
    private int count;
    private double startBoundary;
    private double endBoundary;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 102, (byte) 176, (byte) 103, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistogramBin(double startBoundary, double endBoundary)
    {
      base.\u002Ector();
      HistogramBin histogramBin = this;
      if (startBoundary > endBoundary)
      {
        string str = "HistogramBin():  startBoundary > endBoundary.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.count = 0;
        this.startBoundary = startBoundary;
        this.endBoundary = endBoundary;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HistogramBin([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] HistogramBin obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HistogramBin obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual int getCount()
    {
      return this.count;
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 110})]
    public virtual void incrementCount()
    {
      ++this.count;
    }

    public virtual double getStartBoundary()
    {
      return this.startBoundary;
    }

    public virtual double getEndBoundary()
    {
      return this.endBoundary;
    }

    public virtual double getBinWidth()
    {
      return this.endBoundary - this.startBoundary;
    }

    [LineNumberTable(new byte[] {(byte) 83, (byte) 99, (byte) 130, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 111, (byte) 111, (byte) 111, (byte) 142})]
    public virtual bool equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj == this)
        return true;
      if (!(obj is HistogramBin))
        return false;
      HistogramBin histogramBin = (HistogramBin) obj;
      return histogramBin.startBoundary == this.startBoundary && histogramBin.endBoundary == this.endBoundary && histogramBin.count == this.count;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 157)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
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
