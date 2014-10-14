// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultOHLCDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.OHLCDataset", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultOHLCDataset : AbstractXYDataset, OHLCDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface
  {
    private IComparable key;
    private OHLCDataItem[] data;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultOHLCDataset(IComparable key, OHLCDataItem[] data)
    {
      DefaultOHLCDataset defaultOhlcDataset = this;
      this.key = key;
      this.data = data;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultOHLCDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultOHLCDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable((ushort) 223)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getClose(int series, int item)
    {
      return this.data[item].getClose();
    }

    [LineNumberTable((ushort) 133)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getHigh(int series, int item)
    {
      return this.data[item].getHigh();
    }

    [LineNumberTable((ushort) 163)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getLow(int series, int item)
    {
      return this.data[item].getLow();
    }

    [LineNumberTable((ushort) 193)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getOpen(int series, int item)
    {
      return this.data[item].getOpen();
    }

    [LineNumberTable((ushort) 253)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getVolume(int series, int item)
    {
      return this.data[item].getVolume();
    }

    public override IComparable getSeriesKey(int series)
    {
      return this.key;
    }

    [LineNumberTable((ushort) 97)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(this.data[item].getDate().getTime());
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getXDate(int series, int item)
    {
      return this.data[item].getDate();
    }

    [LineNumberTable((ushort) 121)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.getClose(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHighValue(int series, int item)
    {
      double num = double.NaN;
      Number high = this.getHigh(series, item);
      if (high != null)
        num = high.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowValue(int series, int item)
    {
      double num = double.NaN;
      Number low = this.getLow(series, item);
      if (low != null)
        num = low.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getOpenValue(int series, int item)
    {
      double num = double.NaN;
      Number open = this.getOpen(series, item);
      if (open != null)
        num = open.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCloseValue(int series, int item)
    {
      double num = double.NaN;
      Number close = this.getClose(series, item);
      if (close != null)
        num = close.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVolumeValue(int series, int item)
    {
      double num = double.NaN;
      Number volume = this.getVolume(series, item);
      if (volume != null)
        num = volume.doubleValue();
      return num;
    }

    public override int getSeriesCount()
    {
      return 1;
    }

    [LineNumberTable((ushort) 291)]
    public override int getItemCount(int series)
    {
      return this.data.Length;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sortDataByDate()
    {
      Arrays.sort((object[]) this.data);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 195, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is DefaultOHLCDataset))
        return false;
      DefaultOHLCDataset defaultOhlcDataset = (DefaultOHLCDataset) obj;
      return Object.instancehelper_equals((object) this.key, (object) defaultOhlcDataset.key) && Arrays.equals((object[]) this.data, (object[]) defaultOhlcDataset.data);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 108, (byte) 114, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultOHLCDataset defaultOhlcDataset = (DefaultOHLCDataset) base.clone();
      defaultOhlcDataset.data = new OHLCDataItem[this.data.Length];
      ByteCodeHelper.arraycopy((object) this.data, 0, (object) defaultOhlcDataset.data, 0, this.data.Length);
      return (object) defaultOhlcDataset;
    }
  }
}
