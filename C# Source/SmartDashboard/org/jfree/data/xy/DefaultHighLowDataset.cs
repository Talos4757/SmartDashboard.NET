// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultHighLowDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
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
  public class DefaultHighLowDataset : AbstractXYDataset, OHLCDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface
  {
    private IComparable seriesKey;
    private Date[] date;
    private Number[] high;
    private Number[] low;
    private Number[] open;
    private Number[] close;
    private Number[] volume;

    [LineNumberTable(new byte[] {(byte) 52, (byte) 136, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 108, (byte) 109, (byte) 109, (byte) 109, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultHighLowDataset(IComparable seriesKey, Date[] date, double[] high, double[] low, double[] open, double[] close, double[] volume)
    {
      DefaultHighLowDataset defaultHighLowDataset = this;
      if (seriesKey == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (date == null)
      {
        string str = "Null 'date' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesKey = seriesKey;
        this.date = date;
        this.high = DefaultHighLowDataset.createNumberArray(high);
        this.low = DefaultHighLowDataset.createNumberArray(low);
        this.open = DefaultHighLowDataset.createNumberArray(open);
        this.close = DefaultHighLowDataset.createNumberArray(close);
        this.volume = DefaultHighLowDataset.createNumberArray(volume);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultHighLowDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultHighLowDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 104, (byte) 103, (byte) 48, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number[] createNumberArray(double[] data)
    {
      Number[] numberArray1 = new Number[data.Length];
      for (int index1 = 0; index1 < data.Length; ++index1)
      {
        Number[] numberArray2 = numberArray1;
        int index2 = index1;
        Double.__\u003Cclinit\u003E();
        Double @double = new Double(data[index1]);
        numberArray2[index2] = (Number) @double;
      }
      return numberArray1;
    }

    [LineNumberTable((ushort) 296)]
    public virtual Number getClose(int series, int item)
    {
      return this.close[item];
    }

    [LineNumberTable((ushort) 194)]
    public virtual Number getHigh(int series, int item)
    {
      return this.high[item];
    }

    [LineNumberTable((ushort) 228)]
    public virtual Number getLow(int series, int item)
    {
      return this.low[item];
    }

    [LineNumberTable((ushort) 262)]
    public virtual Number getOpen(int series, int item)
    {
      return this.open[item];
    }

    [LineNumberTable((ushort) 330)]
    public virtual Number getVolume(int series, int item)
    {
      return this.volume[item];
    }

    public override IComparable getSeriesKey(int series)
    {
      return this.seriesKey;
    }

    [LineNumberTable((ushort) 147)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(this.date[item].getTime());
    }

    [LineNumberTable((ushort) 163)]
    public virtual Date getXDate(int series, int item)
    {
      return this.date[item];
    }

    [LineNumberTable((ushort) 180)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.getClose(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHighValue(int series, int item)
    {
      double num = double.NaN;
      Number high = this.getHigh(series, item);
      if (high != null)
        num = high.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getLowValue(int series, int item)
    {
      double num = double.NaN;
      Number low = this.getLow(series, item);
      if (low != null)
        num = low.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getOpenValue(int series, int item)
    {
      double num = double.NaN;
      Number open = this.getOpen(series, item);
      if (open != null)
        num = open.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCloseValue(int series, int item)
    {
      double num = double.NaN;
      Number close = this.getClose(series, item);
      if (close != null)
        num = close.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 231, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
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

    [LineNumberTable((ushort) 372)]
    public override int getItemCount(int series)
    {
      return this.date.Length;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultHighLowDataset))
        return false;
      DefaultHighLowDataset defaultHighLowDataset = (DefaultHighLowDataset) obj;
      return Object.instancehelper_equals((object) this.seriesKey, (object) defaultHighLowDataset.seriesKey) && Arrays.equals((object[]) this.date, (object[]) defaultHighLowDataset.date) && (Arrays.equals((object[]) this.open, (object[]) defaultHighLowDataset.open) && Arrays.equals((object[]) this.high, (object[]) defaultHighLowDataset.high)) && (Arrays.equals((object[]) this.low, (object[]) defaultHighLowDataset.low) && Arrays.equals((object[]) this.close, (object[]) defaultHighLowDataset.close) && Arrays.equals((object[]) this.volume, (object[]) defaultHighLowDataset.volume));
    }
  }
}
