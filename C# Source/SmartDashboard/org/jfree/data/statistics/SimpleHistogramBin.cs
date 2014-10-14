// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.SimpleHistogramBin
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
  [Implements(new string[] {"java.lang.Comparable", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class SimpleHistogramBin : Object, Comparable, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 3480862537505941742L;
    private double lowerBound;
    private double upperBound;
    private bool includeLowerBound;
    private bool includeUpperBound;
    private int itemCount;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 101, (byte) 104, (byte) 102, (byte) 144, (byte) 105, (byte) 105, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleHistogramBin(double lowerBound, double upperBound, bool includeLowerBound, bool includeUpperBound)
    {
      int num1 = includeLowerBound ? 1 : 0;
      int num2 = includeUpperBound ? 1 : 0;
      base.\u002Ector();
      SimpleHistogramBin simpleHistogramBin = this;
      if (lowerBound >= upperBound)
      {
        string str = "Invalid bounds";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.lowerBound = lowerBound;
        this.upperBound = upperBound;
        this.includeLowerBound = num1 != 0;
        this.includeUpperBound = num2 != 0;
        this.itemCount = 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleHistogramBin(double lowerBound, double upperBound)
      : this(lowerBound, upperBound, true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SimpleHistogramBin([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SimpleHistogramBin obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SimpleHistogramBin obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual double getLowerBound()
    {
      return this.lowerBound;
    }

    public virtual double getUpperBound()
    {
      return this.upperBound;
    }

    public virtual int getItemCount()
    {
      return this.itemCount;
    }

    public virtual void setItemCount(int count)
    {
      this.itemCount = count;
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 105, (byte) 130, (byte) 106, (byte) 130, (byte) 106, (byte) 130, (byte) 106, (byte) 135, (byte) 106, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool accepts(double value)
    {
      if (Double.isNaN(value) || value < this.lowerBound || value > this.upperBound)
        return false;
      if (value == this.lowerBound)
        return this.includeLowerBound;
      if (value == this.upperBound)
        return this.includeUpperBound;
      else
        return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 149, (byte) 110, (byte) 149})]
    public virtual bool overlapsWith(SimpleHistogramBin bin)
    {
      if (this.upperBound < bin.lowerBound || this.lowerBound > bin.upperBound)
        return false;
      if (this.upperBound == bin.lowerBound)
        return this.includeUpperBound && bin.includeLowerBound;
      else
        return this.lowerBound != bin.upperBound || this.includeLowerBound && bin.includeUpperBound;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 162, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual int compareTo(object obj)
    {
      if (!(obj is SimpleHistogramBin))
        return 0;
      SimpleHistogramBin simpleHistogramBin = (SimpleHistogramBin) obj;
      if (this.lowerBound < simpleHistogramBin.lowerBound)
        return -1;
      if (this.lowerBound > simpleHistogramBin.lowerBound)
        return 1;
      if (this.upperBound < simpleHistogramBin.upperBound)
        return -1;
      return this.upperBound > simpleHistogramBin.upperBound ? 1 : 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (!(obj is SimpleHistogramBin))
        return false;
      SimpleHistogramBin simpleHistogramBin = (SimpleHistogramBin) obj;
      return this.lowerBound == simpleHistogramBin.lowerBound && this.upperBound == simpleHistogramBin.upperBound && (this.includeLowerBound == simpleHistogramBin.includeLowerBound && this.includeUpperBound == simpleHistogramBin.includeUpperBound) && this.itemCount == simpleHistogramBin.itemCount;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 263)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
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
