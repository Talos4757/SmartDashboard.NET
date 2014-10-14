// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimeSeriesDataItem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.lang.Cloneable", "java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class TimeSeriesDataItem : Object, Cloneable.__Interface, Comparable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -2235346966016401302L;
    private RegularTimePeriod period;
    private Number value;

    [LineNumberTable(new byte[] {(byte) 57, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesDataItem(RegularTimePeriod period, double value)
      : this(period, (Number) new Double(value))
    {
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeSeriesDataItem(RegularTimePeriod period, Number value)
    {
      base.\u002Ector();
      TimeSeriesDataItem timeSeriesDataItem = this;
      if (period == null)
      {
        string str = "Null 'period' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.period = period;
        this.value = value;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimeSeriesDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TimeSeriesDataItem obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimeSeriesDataItem obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual RegularTimePeriod getPeriod()
    {
      return this.period;
    }

    public virtual Number getValue()
    {
      return this.value;
    }

    public virtual void setValue(Number value)
    {
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 130, (byte) 217, (byte) 2, (byte) 97, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      object obj = (object) null;
      CloneNotSupportedException supportedException;
      try
      {
        obj = base.clone();
        goto label_4;
      }
      catch (CloneNotSupportedException ex)
      {
        int num = 1;
        supportedException = (CloneNotSupportedException) ByteCodeHelper.MapException<CloneNotSupportedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      Throwable.instancehelper_printStackTrace((Exception) supportedException);
label_4:
      return obj;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 104, (byte) 115, (byte) 162, (byte) 104, (byte) 162, (byte) 104, (byte) 115, (byte) 162, (byte) 104, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (this == o)
        return true;
      if (!(o is TimeSeriesDataItem))
        return false;
      TimeSeriesDataItem timeSeriesDataItem = (TimeSeriesDataItem) o;
      if (this.period != null)
      {
        if (!Object.instancehelper_equals((object) this.period, (object) timeSeriesDataItem.period))
          return false;
      }
      else if (timeSeriesDataItem.period != null)
        return false;
      if (this.value != null)
      {
        if (!Object.instancehelper_equals((object) this.value, (object) timeSeriesDataItem.value))
          return false;
      }
      else if (timeSeriesDataItem.value != null)
        return false;
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 119, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (this.period == null ? 0 : Object.instancehelper_hashCode((object) this.period)) + (this.value == null ? 0 : Object.instancehelper_hashCode((object) this.value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 104, (byte) 103, (byte) 114, (byte) 226, (byte) 70, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object o1)
    {
      return !(o1 is TimeSeriesDataItem) ? 1 : this.getPeriod().compareTo((object) ((TimeSeriesDataItem) o1).getPeriod());
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
