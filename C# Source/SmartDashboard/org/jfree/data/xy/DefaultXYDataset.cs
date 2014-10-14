// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultXYDataset : AbstractXYDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface
  {
    private List seriesKeys;
    private List seriesList;

    [LineNumberTable(new byte[] {(byte) 30, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultXYDataset()
    {
      DefaultXYDataset defaultXyDataset = this;
      this.seriesKeys = (List) new ArrayList();
      this.seriesList = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultXYDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable((ushort) 91)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.seriesList.size();
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[0][item];
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[1][item];
    }

    [LineNumberTable((ushort) 121)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int indexOf(IComparable seriesKey)
    {
      return this.seriesKeys.indexOf((object) seriesKey);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (IComparable) this.seriesKeys.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 132)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DomainOrder getDomainOrder()
    {
      return DomainOrder.__\u003C\u003ENONE;
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 109, (byte) 144, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return ((double[][]) this.seriesList.get(series))[0].Length;
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 194)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 237)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getYValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 99, (byte) 176, (byte) 99, (byte) 144, (byte) 101, (byte) 176, (byte) 106, (byte) 176, (byte) 104, (byte) 100, (byte) 109, (byte) 175, (byte) 109, (byte) 141, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(IComparable seriesKey, double[][] data)
    {
      if (seriesKey == null)
      {
        string str = "The 'seriesKey' cannot be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data == null)
      {
        string str = "The 'data' is null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data.Length != 2)
      {
        string str = "The 'data' array must have length == 2.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data[0].Length != data[1].Length)
      {
        string str = "The 'data' array must contain two arrays with equal length.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = this.indexOf(seriesKey);
        if (num == -1)
        {
          this.seriesKeys.add((object) seriesKey);
          this.seriesList.add((object) data);
        }
        else
        {
          this.seriesList.remove(num);
          this.seriesList.add(num, (object) data);
        }
        this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 104, (byte) 100, (byte) 109, (byte) 109, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(IComparable seriesKey)
    {
      int num = this.indexOf(seriesKey);
      if (num < 0)
        return;
      this.seriesKeys.remove(num);
      this.seriesList.remove(num);
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 119, (byte) 119, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 226, (byte) 53, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultXYDataset))
        return false;
      DefaultXYDataset defaultXyDataset = (DefaultXYDataset) obj;
      if (!Object.instancehelper_equals((object) this.seriesKeys, (object) defaultXyDataset.seriesKeys))
        return false;
      for (int index = 0; index < this.seriesList.size(); ++index)
      {
        double[][] numArray1 = (double[][]) this.seriesList.get(index);
        double[][] numArray2 = (double[][]) defaultXyDataset.seriesList.get(index);
        if (!Arrays.equals(numArray1[0], numArray2[0]) || !Arrays.equals(numArray1[1], numArray2[1]))
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Object.instancehelper_hashCode((object) this.seriesKeys) + Object.instancehelper_hashCode((object) this.seriesList);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 245, (byte) 108, (byte) 113, (byte) 118, (byte) 115, (byte) 119, (byte) 100, (byte) 101, (byte) 105, (byte) 106, (byte) 108, (byte) 110, (byte) 252, (byte) 56, (byte) 233, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultXYDataset defaultXyDataset = (DefaultXYDataset) base.clone();
      defaultXyDataset.seriesKeys = (List) new ArrayList((Collection) this.seriesKeys);
      defaultXyDataset.seriesList = (List) new ArrayList(this.seriesList.size());
      for (int index1 = 0; index1 < this.seriesList.size(); ++index1)
      {
        double[][] numArray1 = (double[][]) this.seriesList.get(index1);
        double[] numArray2 = numArray1[0];
        double[] numArray3 = numArray1[1];
        double[] numArray4 = new double[numArray2.Length];
        double[] numArray5 = new double[numArray3.Length];
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray2, 0, (Array) numArray4, 0, numArray2.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray3, 0, (Array) numArray5, 0, numArray3.Length);
        List list = defaultXyDataset.seriesList;
        int num = index1;
        double[][] numArray6 = new double[2][];
        int index2 = 0;
        double[] numArray7 = numArray4;
        numArray6[index2] = numArray7;
        int index3 = 1;
        double[] numArray8 = numArray5;
        numArray6[index3] = numArray8;
        list.add(num, (object) numArray6);
      }
      return (object) defaultXyDataset;
    }
  }
}
