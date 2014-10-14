// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.ohlc.OHLCSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.time;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time.ohlc
{
  [Serializable]
  public class OHLCSeries : ComparableObjectSeries
  {
    [LineNumberTable(new byte[] {(byte) 14, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OHLCSeries(IComparable key)
      : base(key, true, false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected OHLCSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ComparableObjectItem getDataItem(int index)
    {
      return base.getDataItem(index);
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RegularTimePeriod getPeriod(int index)
    {
      return ((OHLCItem) this.getDataItem(index)).getPeriod();
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 105, (byte) 109, (byte) 120, (byte) 208, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(RegularTimePeriod period, double open, double high, double low, double close)
    {
      if (this.getItemCount() > 0)
      {
        OHLCItem ohlcItem = (OHLCItem) this.getDataItem(0);
        if (!Object.instancehelper_equals((object) Object.instancehelper_getClass((object) period), (object) Object.instancehelper_getClass((object) ohlcItem.getPeriod())))
        {
          string str = "Can't mix RegularTimePeriod class types.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
      }
      base.add((ComparableObjectItem) new OHLCItem(period, open, high, low, close), true);
    }
  }
}
