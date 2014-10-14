// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.OHLCDataItem
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

namespace org.jfree.data.xy
{
  [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable"})]
  [Serializable]
  public class OHLCDataItem : Object, Comparable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7753817154401169901L;
    private Date date;
    private Number open;
    private Number high;
    private Number low;
    private Number close;
    private Number volume;

    [LineNumberTable(new byte[] {(byte) 41, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 109, (byte) 109, (byte) 110, (byte) 110, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OHLCDataItem(Date date, double open, double high, double low, double close, double volume)
    {
      base.\u002Ector();
      OHLCDataItem ohlcDataItem = this;
      if (date == null)
      {
        string str = "Null 'date' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.date = date;
        this.open = (Number) new Double(open);
        this.high = (Number) new Double(high);
        this.low = (Number) new Double(low);
        this.close = (Number) new Double(close);
        this.volume = (Number) new Double(volume);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected OHLCDataItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] OHLCDataItem obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Date getDate()
    {
      return this.date;
    }

    public virtual Number getHigh()
    {
      return this.high;
    }

    public virtual Number getLow()
    {
      return this.low;
    }

    public virtual Number getOpen()
    {
      return this.open;
    }

    public virtual Number getClose()
    {
      return this.close;
    }

    public virtual Number getVolume()
    {
      return this.volume;
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is OHLCDataItem))
        return false;
      OHLCDataItem ohlcDataItem = (OHLCDataItem) obj;
      return this.date.equals((object) ohlcDataItem.date) && Object.instancehelper_equals((object) this.high, (object) ohlcDataItem.high) && (Object.instancehelper_equals((object) this.low, (object) ohlcDataItem.low) && Object.instancehelper_equals((object) this.open, (object) ohlcDataItem.open)) && Object.instancehelper_equals((object) this.close, (object) ohlcDataItem.close);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 104, (byte) 103, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object @object)
    {
      if (@object is OHLCDataItem)
      {
        return this.date.compareTo(((OHLCDataItem) @object).date);
      }
      else
      {
        string str = "OHLCDataItem.compareTo().";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ClassCastException(str);
      }
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
