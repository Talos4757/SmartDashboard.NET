// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultWindDataset
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
  [Implements(new string[] {"org.jfree.data.xy.WindDataset", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultWindDataset : AbstractXYDataset, WindDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface
  {
    private List seriesKeys;
    private List allSeriesData;

    [LineNumberTable(new byte[] {(byte) 78, (byte) 104, (byte) 99, (byte) 144, (byte) 106, (byte) 176, (byte) 103, (byte) 99, (byte) 140, (byte) 105, (byte) 102, (byte) 102, (byte) 108, (byte) 106, (byte) 135, (byte) 105, (byte) 171, (byte) 105, (byte) 105, (byte) 115, (byte) 130, (byte) 168, (byte) 111, (byte) 111, (byte) 242, (byte) 46, (byte) 235, (byte) 86, (byte) 102, (byte) 237, (byte) 38, (byte) 233, (byte) 93})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultWindDataset(List seriesKeys, object[][][] data)
    {
      DefaultWindDataset defaultWindDataset = this;
      if (seriesKeys == null)
      {
        string str = "Null 'seriesKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (seriesKeys.size() != data.Length)
      {
        string str = "The number of series keys does not match the number of series in the data array.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesKeys = seriesKeys;
        int length1 = data.Length;
        this.allSeriesData = (List) new ArrayList(length1);
        for (int index1 = 0; index1 < length1; ++index1)
        {
          ArrayList arrayList = new ArrayList();
          int length2 = data[index1].Length;
          for (int index2 = 0; index2 < length2; ++index2)
          {
            object obj = data[index1][index2][0];
            if (obj != null)
            {
              Number number1;
              if (obj is Number)
                number1 = (Number) obj;
              else if (obj is Date)
              {
                Date date = (Date) obj;
                Long.__\u003Cclinit\u003E();
                number1 = (Number) new Long(date.getTime());
              }
              else
                number1 = (Number) new Integer(0);
              Number number2 = (Number) data[index1][index2][1];
              Number number3 = (Number) data[index1][index2][2];
              ((List) arrayList).add((object) new WindDataItem(number1, number2, number3));
            }
          }
          Collections.sort((List) arrayList);
          this.allSeriesData.add(index1, (object) arrayList);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultWindDataset()
    {
      DefaultWindDataset defaultWindDataset = this;
      this.seriesKeys = (List) new ArrayList();
      this.allSeriesData = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultWindDataset(object[][][] data)
      : this(DefaultWindDataset.seriesNameListFromDataArray((object[][]) data), data)
    {
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultWindDataset(string[] seriesNames, object[][][] data)
      : this(Arrays.asList((object[]) seriesNames), data)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultWindDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultWindDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 99, (byte) 103, (byte) 102, (byte) 63, (byte) 4, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List seriesNameListFromDataArray(object[][] data)
    {
      int length = data.Length;
      ArrayList arrayList = new ArrayList(length);
      for (int index = 0; index < length; ++index)
        ((List) arrayList).add((object) new StringBuffer().append("Series ").append(index + 1).toString());
      return (List) arrayList;
    }

    [LineNumberTable((ushort) 177)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.allSeriesData.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getWindForce(int series, int item)
    {
      return ((WindDataItem) ((List) this.allSeriesData.get(series)).get(item)).getWindForce();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 109, (byte) 191, (byte) 6, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      if (series < 0 || series >= this.getSeriesCount())
      {
        string str = new StringBuffer().append("Invalid series index: ").append(series).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return ((List) this.allSeriesData.get(series)).size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 109, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (IComparable) this.seriesKeys.get(series);
      string str = new StringBuffer().append("Invalid series index: ").append(series).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return ((WindDataItem) ((List) this.allSeriesData.get(series)).get(item)).getX();
    }

    [LineNumberTable((ushort) 238)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.getWindForce(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getWindDirection(int series, int item)
    {
      return ((WindDataItem) ((List) this.allSeriesData.get(series)).get(item)).getWindDirection();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is DefaultWindDataset))
        return false;
      DefaultWindDataset defaultWindDataset = (DefaultWindDataset) obj;
      return Object.instancehelper_equals((object) this.seriesKeys, (object) defaultWindDataset.seriesKeys) && Object.instancehelper_equals((object) this.allSeriesData, (object) defaultWindDataset.allSeriesData);
    }
  }
}
