// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultIntervalXYDataset
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
  [Implements(new string[] {"org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultIntervalXYDataset : AbstractIntervalXYDataset, PublicCloneable, Cloneable.__Interface
  {
    private List seriesKeys;
    private List seriesList;

    [LineNumberTable(new byte[] {(byte) 34, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultIntervalXYDataset()
    {
      DefaultIntervalXYDataset intervalXyDataset = this;
      this.seriesKeys = (List) new ArrayList();
      this.seriesList = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultIntervalXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultIntervalXYDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable((ushort) 95)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.seriesList.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndXValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[2][item];
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndYValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[5][item];
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartXValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[1][item];
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartYValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[4][item];
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[0][item];
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return ((double[][]) this.seriesList.get(series))[3][item];
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (IComparable) this.seriesKeys.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 109, (byte) 144, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return ((double[][]) this.seriesList.get(series))[0].Length;
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 285)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getEndXValue(series, item));
    }

    [LineNumberTable((ushort) 306)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getEndYValue(series, item));
    }

    [LineNumberTable((ushort) 327)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getStartXValue(series, item));
    }

    [LineNumberTable((ushort) 348)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getStartYValue(series, item));
    }

    [LineNumberTable((ushort) 369)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 390)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getYValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 99, (byte) 176, (byte) 99, (byte) 144, (byte) 101, (byte) 176, (byte) 101, (byte) 191, (byte) 4, (byte) 176, (byte) 104, (byte) 100, (byte) 109, (byte) 175, (byte) 109, (byte) 141, (byte) 111})]
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
      else if (data.Length != 6)
      {
        string str = "The 'data' array must have length == 6.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int length = data[0].Length;
        if (length != data[1].Length || length != data[2].Length || (length != data[3].Length || length != data[4].Length) || length != data[5].Length)
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
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 119, (byte) 119, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 130, (byte) 101, (byte) 101, (byte) 107, (byte) 226, (byte) 33, (byte) 233, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultIntervalXYDataset))
        return false;
      DefaultIntervalXYDataset intervalXyDataset = (DefaultIntervalXYDataset) obj;
      if (!Object.instancehelper_equals((object) this.seriesKeys, (object) intervalXyDataset.seriesKeys))
        return false;
      for (int index = 0; index < this.seriesList.size(); ++index)
      {
        double[][] numArray1 = (double[][]) this.seriesList.get(index);
        double[][] numArray2 = (double[][]) intervalXyDataset.seriesList.get(index);
        if (!Arrays.equals(numArray1[0], numArray2[0]) || !Arrays.equals(numArray1[1], numArray2[1]) || (!Arrays.equals(numArray1[2], numArray2[2]) || !Arrays.equals(numArray1[3], numArray2[3])) || (!Arrays.equals(numArray1[4], numArray2[4]) || !Arrays.equals(numArray1[5], numArray2[5])))
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 135, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Object.instancehelper_hashCode((object) this.seriesKeys) + Object.instancehelper_hashCode((object) this.seriesList);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 140, (byte) 113, (byte) 118, (byte) 115, (byte) 119, (byte) 100, (byte) 101, (byte) 101, (byte) 101, (byte) 101, (byte) 101, (byte) 105, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 108, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 255, (byte) 17, (byte) 44, (byte) 233, (byte) 87})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultIntervalXYDataset intervalXyDataset = (DefaultIntervalXYDataset) base.clone();
      intervalXyDataset.seriesKeys = (List) new ArrayList((Collection) this.seriesKeys);
      intervalXyDataset.seriesList = (List) new ArrayList(this.seriesList.size());
      for (int index1 = 0; index1 < this.seriesList.size(); ++index1)
      {
        double[][] numArray1 = (double[][]) this.seriesList.get(index1);
        double[] numArray2 = numArray1[0];
        double[] numArray3 = numArray1[1];
        double[] numArray4 = numArray1[2];
        double[] numArray5 = numArray1[3];
        double[] numArray6 = numArray1[4];
        double[] numArray7 = numArray1[5];
        double[] numArray8 = new double[numArray2.Length];
        double[] numArray9 = new double[numArray3.Length];
        double[] numArray10 = new double[numArray4.Length];
        double[] numArray11 = new double[numArray5.Length];
        double[] numArray12 = new double[numArray6.Length];
        double[] numArray13 = new double[numArray7.Length];
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray2, 0, (Array) numArray8, 0, numArray2.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray3, 0, (Array) numArray9, 0, numArray3.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray4, 0, (Array) numArray10, 0, numArray4.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray5, 0, (Array) numArray11, 0, numArray5.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray6, 0, (Array) numArray12, 0, numArray6.Length);
        ByteCodeHelper.arraycopy_primitive_8((Array) numArray7, 0, (Array) numArray13, 0, numArray7.Length);
        List list = intervalXyDataset.seriesList;
        int num = index1;
        double[][] numArray14 = new double[6][];
        int index2 = 0;
        double[] numArray15 = numArray8;
        numArray14[index2] = numArray15;
        int index3 = 1;
        double[] numArray16 = numArray9;
        numArray14[index3] = numArray16;
        int index4 = 2;
        double[] numArray17 = numArray10;
        numArray14[index4] = numArray17;
        int index5 = 3;
        double[] numArray18 = numArray11;
        numArray14[index5] = numArray18;
        int index6 = 4;
        double[] numArray19 = numArray12;
        numArray14[index6] = numArray19;
        int index7 = 5;
        double[] numArray20 = numArray13;
        numArray14[index7] = numArray20;
        list.add(num, (object) numArray14);
      }
      return (object) intervalXyDataset;
    }
  }
}
