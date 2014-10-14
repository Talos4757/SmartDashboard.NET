// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultXYZDataset
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
  [Implements(new string[] {"org.jfree.data.xy.XYZDataset", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultXYZDataset : AbstractXYZDataset, XYZDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface
  {
    private List seriesKeys;
    private List seriesList;

    [LineNumberTable(new byte[] {(byte) 31, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultXYZDataset()
    {
      DefaultXYZDataset defaultXyzDataset = this;
      this.seriesKeys = (List) new ArrayList();
      this.seriesList = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultXYZDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultXYZDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable((ushort) 92)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.seriesList.size();
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[0][item];
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[1][item];
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getZValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[2][item];
    }

    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int indexOf(IComparable seriesKey)
    {
      return this.seriesKeys.indexOf((object) seriesKey);
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (IComparable) this.seriesKeys.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 133)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DomainOrder getDomainOrder()
    {
      return DomainOrder.__\u003C\u003ENONE;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 109, (byte) 144, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return ((double[][]) this.seriesList.get(series))[0].Length;
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 195)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 238)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getYValue(series, item));
    }

    [LineNumberTable((ushort) 281)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getZ(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getZValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 99, (byte) 176, (byte) 99, (byte) 144, (byte) 101, (byte) 176, (byte) 148, (byte) 176, (byte) 104, (byte) 100, (byte) 109, (byte) 175, (byte) 109, (byte) 141, (byte) 111})]
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
      else if (data.Length != 3)
      {
        string str = "The 'data' array must have length == 3.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data[0].Length != data[1].Length || data[0].Length != data[2].Length)
      {
        string str = "The 'data' array must contain three arrays all having the same length.";
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 218, (byte) 104, (byte) 100, (byte) 109, (byte) 109, (byte) 143})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 119, (byte) 119, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 226, (byte) 48, (byte) 233, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultXYZDataset))
        return false;
      DefaultXYZDataset defaultXyzDataset = (DefaultXYZDataset) obj;
      if (!Object.instancehelper_equals((object) this.seriesKeys, (object) defaultXyzDataset.seriesKeys))
        return false;
      for (int index = 0; index < this.seriesList.size(); ++index)
      {
        double[][] numArray1 = (double[][]) this.seriesList.get(index);
        double[][] numArray2 = (double[][]) defaultXyzDataset.seriesList.get(index);
        if (!Arrays.equals(numArray1[0], numArray2[0]) || !Arrays.equals(numArray1[1], numArray2[1]) || !Arrays.equals(numArray1[2], numArray2[2]))
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Object.instancehelper_hashCode((object) this.seriesKeys) + Object.instancehelper_hashCode((object) this.seriesList);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 108, (byte) 113, (byte) 118, (byte) 115, (byte) 119, (byte) 100, (byte) 101, (byte) 101, (byte) 105, (byte) 106, (byte) 106, (byte) 108, (byte) 110, (byte) 110, (byte) 255, (byte) 2, (byte) 53, (byte) 233, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultXYZDataset defaultXyzDataset = (DefaultXYZDataset) base.clone();
      defaultXyzDataset.seriesKeys = (List) new ArrayList((Collection) this.seriesKeys);
      defaultXyzDataset.seriesList = (List) new ArrayList(this.seriesList.size());
      for (int index1 = 0; index1 < this.seriesList.size(); ++index1)
      {
        double[][] numArray1 = (double[][]) this.seriesList.get(index1);
        double[] numArray2 = numArray1[0];
        double[] numArray3 = numArray1[1];
        double[] numArray4 = numArray1[2];
        double[] numArray5 = new double[numArray2.Length];
        double[] numArray6 = new double[numArray3.Length];
        double[] numArray7 = new double[numArray4.Length];
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray2, 0, (Array) numArray5, 0, numArray2.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray3, 0, (Array) numArray6, 0, numArray3.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray4, 0, (Array) numArray7, 0, numArray4.Length);
        List list = defaultXyzDataset.seriesList;
        int num = index1;
        double[][] numArray8 = new double[3][];
        int index2 = 0;
        double[] numArray9 = numArray5;
        numArray8[index2] = numArray9;
        int index3 = 1;
        double[] numArray10 = numArray6;
        numArray8[index3] = numArray10;
        int index4 = 2;
        double[] numArray11 = numArray7;
        numArray8[index4] = numArray11;
        list.add(num, (object) numArray8);
      }
      return (object) defaultXyzDataset;
    }
  }
}
