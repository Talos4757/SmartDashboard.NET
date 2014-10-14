// Decompiled with JetBrains decompiler
// Type: org.jfree.data.contour.DefaultContourDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.contour
{
  [Implements(new string[] {"org.jfree.data.contour.ContourDataset"})]
  [Obsolete]
  [Serializable]
  public class DefaultContourDataset : AbstractXYZDataset, ContourDataset, XYZDataset, XYDataset, SeriesDataset, Dataset
  {
    protected internal IComparable seriesKey;
    protected internal Number[] xValues;
    protected internal Number[] yValues;
    protected internal Number[] zValues;
    protected internal int[] xIndex;
    internal bool[] dateAxis;

    [LineNumberTable(new byte[] {(byte) 42, (byte) 232, (byte) 43, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 236, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultContourDataset()
    {
      DefaultContourDataset defaultContourDataset = this;
      this.seriesKey = (IComparable) null;
      this.xValues = (Number[]) null;
      this.yValues = (Number[]) null;
      this.zValues = (Number[]) null;
      this.xIndex = (int[]) null;
      this.dateAxis = new bool[3];
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 232, (byte) 29, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 236, (byte) 86, (byte) 103, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultContourDataset(IComparable seriesKey, object[] xData, object[] yData, object[] zData)
    {
      DefaultContourDataset defaultContourDataset = this;
      this.seriesKey = (IComparable) null;
      this.xValues = (Number[]) null;
      this.yValues = (Number[]) null;
      this.zValues = (Number[]) null;
      this.xIndex = (int[]) null;
      this.dateAxis = new bool[3];
      this.seriesKey = seriesKey;
      this.initialize(xData, yData, zData);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultContourDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 104, (byte) 104, (byte) 104, (byte) 136, (byte) 107, (byte) 107, (byte) 113, (byte) 223, (byte) 43, (byte) 107, (byte) 120, (byte) 248, (byte) 57, (byte) 235, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getZValueRange(Range x, Range y)
    {
      double lowerBound1 = x.getLowerBound();
      double lowerBound2 = y.getLowerBound();
      double upperBound1 = x.getUpperBound();
      double upperBound2 = y.getUpperBound();
      double lower = 1E+20;
      double upper = -1E+20;
      for (int index = 0; index < this.zValues.Length; ++index)
      {
        if (this.xValues[index].doubleValue() >= lowerBound1 && this.xValues[index].doubleValue() <= upperBound1 && (this.yValues[index].doubleValue() >= lowerBound2 && this.yValues[index].doubleValue() <= upperBound2) && this.zValues[index] != null)
        {
          lower = Math.min(lower, this.zValues[index].doubleValue());
          upper = Math.max(upper, this.zValues[index].doubleValue());
        }
      }
      return new Range(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 109, (byte) 109, (byte) 237, (byte) 74, (byte) 102, (byte) 106, (byte) 111, (byte) 136, (byte) 106, (byte) 139, (byte) 106, (byte) 105, (byte) 106, (byte) 114, (byte) 130, (byte) 135, (byte) 216, (byte) 112, (byte) 141, (byte) 239, (byte) 43, (byte) 233, (byte) 91, (byte) 104, (byte) 174, (byte) 106, (byte) 56, (byte) 168, (byte) 142, (byte) 114, (byte) 102, (byte) 242, (byte) 60, (byte) 232, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void initialize(object[] xData, object[] yData, object[] zData)
    {
      this.xValues = (Number[]) new Double[xData.Length];
      this.yValues = (Number[]) new Double[yData.Length];
      this.zValues = (Number[]) new Double[zData.Length];
      Vector vector = new Vector();
      double num = 1.123452E+31;
      for (int index1 = 0; index1 < this.xValues.Length; ++index1)
      {
        if (xData[index1] != null)
        {
          Number number;
          if (xData[index1] is Number)
            number = (Number) xData[index1];
          else if (xData[index1] is Date)
          {
            this.dateAxis[0] = true;
            Date date = (Date) xData[index1];
            Long.__\u003Cclinit\u003E();
            number = (Number) new Long(date.getTime());
          }
          else
            number = (Number) new Integer(0);
          Number[] numberArray = this.xValues;
          int index2 = index1;
          Double.__\u003Cclinit\u003E();
          Double @double = new Double(number.doubleValue());
          numberArray[index2] = (Number) @double;
          if (num != this.xValues[index1].doubleValue())
          {
            vector.add((object) new Integer(index1));
            num = this.xValues[index1].doubleValue();
          }
        }
      }
      object[] objArray = vector.toArray();
      this.xIndex = new int[objArray.Length];
      for (int index = 0; index < objArray.Length; ++index)
        this.xIndex[index] = ((Integer) objArray[index]).intValue();
      for (int index = 0; index < this.yValues.Length; ++index)
      {
        this.yValues[index] = (Number) yData[index];
        if (zData[index] != null)
          this.zValues[index] = (Number) zData[index];
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 88, (byte) 109, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexX(int k)
    {
      int num = Arrays.binarySearch(this.xIndex, k);
      if (num >= 0)
        return num;
      else
        return -1 * num - 2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 159, (byte) 9, (byte) 103, (byte) 107, (byte) 54, (byte) 40, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object[][] formObjectArray(double[][] data)
    {
      int length1 = data.Length;
      int length2 = data[0].Length;
      int[] numArray = new int[2];
      int num1 = length2;
      numArray[1] = num1;
      int num2 = length1;
      numArray[0] = num2;
      // ISSUE: type reference
      Double[][] doubleArray1 = (Double[][]) ByteCodeHelper.multianewarray(__typeref (Double[][]), numArray);
      for (int index1 = 0; index1 < doubleArray1.Length; ++index1)
      {
        for (int index2 = 0; index2 < doubleArray1[index1].Length; ++index2)
        {
          Double[] doubleArray2 = doubleArray1[index1];
          int index3 = index2;
          Double.__\u003Cclinit\u003E();
          Double @double = new Double(data[index1][index2]);
          doubleArray2[index3] = @double;
        }
      }
      return (object[][]) doubleArray1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 104, (byte) 103, (byte) 48, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object[] formObjectArray(double[] data)
    {
      Double[] doubleArray1 = new Double[data.Length];
      for (int index1 = 0; index1 < doubleArray1.Length; ++index1)
      {
        Double[] doubleArray2 = doubleArray1;
        int index2 = index1;
        Double.__\u003Cclinit\u003E();
        Double @double = new Double(data[index1]);
        doubleArray2[index2] = @double;
      }
      return (object[]) doubleArray1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      if (series <= 0)
        return this.zValues.Length;
      string str = "Only one series for contour";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 106, (byte) 108, (byte) 106, (byte) 21, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMaxZValue()
    {
      double num = -1E+20;
      for (int index = 0; index < this.zValues.Length; ++index)
      {
        if (this.zValues[index] != null)
          num = Math.max(num, this.zValues[index].doubleValue());
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 106, (byte) 108, (byte) 106, (byte) 21, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMinZValue()
    {
      double num = 1E+20;
      for (int index = 0; index < this.zValues.Length; ++index)
      {
        if (this.zValues[index] != null)
          num = Math.min(num, this.zValues[index].doubleValue());
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 106, (byte) 108, (byte) 106, (byte) 21, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getMinZValue(double minX, double minY, double maxX, double maxY)
    {
      double num = 1E+20;
      for (int index = 0; index < this.zValues.Length; ++index)
      {
        if (this.zValues[index] != null)
          num = Math.min(num, this.zValues[index].doubleValue());
      }
      return num;
    }

    public override int getSeriesCount()
    {
      return 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 222, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      if (series <= 0)
        return this.seriesKey;
      string str = "Only one series for contour";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    public virtual int[] getXIndices()
    {
      return this.xIndex;
    }

    public virtual Number[] getXValues()
    {
      return this.xValues;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 0, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      if (series <= 0)
        return this.xValues[item];
      string str = "Only one series for contour";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 384)]
    public virtual Number getXValue(int item)
    {
      return this.xValues[item];
    }

    public virtual Number[] getYValues()
    {
      return this.yValues;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 36, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      if (series <= 0)
        return this.yValues[item];
      string str = "Only one series for contour";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    public virtual Number[] getZValues()
    {
      return this.zValues;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getZ(int series, int item)
    {
      if (series <= 0)
        return this.zValues[item];
      string str = "Only one series for contour";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 73, (byte) 109, (byte) 103, (byte) 42, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int[] indexX()
    {
      int[] numArray = new int[this.xValues.Length];
      for (int k = 0; k < numArray.Length; ++k)
        numArray[k] = this.indexX(k);
      return numArray;
    }

    [LineNumberTable((ushort) 476)]
    public virtual int indexY(int k)
    {
      int num1 = k;
      int length = this.xValues.Length;
      int num2 = -1;
      if (length == num2)
        return -num1;
      else
        return num1 / length;
    }

    [LineNumberTable((ushort) 488)]
    public virtual int indexZ(int i, int j)
    {
      return this.xValues.Length * j + i;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 104, (byte) 130})]
    public virtual bool isDateAxis(int axisNumber)
    {
      if (axisNumber < 0 || axisNumber > 2)
        return false;
      else
        return this.dateAxis[axisNumber];
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 141, (byte) 101, (byte) 176, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesKeys(IComparable[] seriesKeys)
    {
      if (seriesKeys.Length > 1)
      {
        string str = "Contours only support one series";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesKey = seriesKeys[0];
        this.fireDatasetChanged();
      }
    }
  }
}
