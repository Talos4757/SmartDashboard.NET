// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.Statistics
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.data.statistics
{
  public abstract class Statistics : Object
  {
    [LineNumberTable((ushort) 60)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Statistics()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 107, (byte) 98, (byte) 99, (byte) 144, (byte) 98, (byte) 102, (byte) 103, (byte) 107, (byte) 104, (byte) 100, (byte) 99, (byte) 202, (byte) 105, (byte) 105, (byte) 106, (byte) 105, (byte) 99, (byte) 202, (byte) 107, (byte) 196, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMean(Collection values, bool includeNullAndNaN)
    {
      int num1 = includeNullAndNaN ? 1 : 0;
      if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num2 = 0;
        double num3 = 0.0;
        Iterator iterator = values.iterator();
        while (iterator.hasNext())
        {
          object obj = iterator.next();
          if (obj == null)
          {
            if (num1 != 0)
              return double.NaN;
          }
          else if (obj is Number)
          {
            Number number = (Number) obj;
            if (Double.isNaN(number.doubleValue()))
            {
              if (num1 != 0)
                return double.NaN;
            }
            else
            {
              num3 += number.doubleValue();
              ++num2;
            }
          }
        }
        return num3 / (double) num2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 92, (byte) 100, (byte) 106, (byte) 107, (byte) 99, (byte) 108, (byte) 104, (byte) 104, (byte) 54, (byte) 168, (byte) 103, (byte) 131, (byte) 122, (byte) 103, (byte) 114, (byte) 100, (byte) 127, (byte) 10, (byte) 105, (byte) 133, (byte) 127, (byte) 6, (byte) 105, (byte) 165, (byte) 127, (byte) 10, (byte) 127, (byte) 8, (byte) 251, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMedian(List values, bool copyAndSort)
    {
      object obj1 = (object) values;
      int num1 = copyAndSort ? 1 : 0;
      double num2 = double.NaN;
      if ((List) obj1 != null)
      {
        if (num1 != 0)
        {
          int num3 = ((List) obj1).size();
          ArrayList arrayList = new ArrayList(num3);
          for (int index = 0; index < num3; ++index)
            ((List) arrayList).add(index, ((List) obj1).get(index));
          Collections.sort((List) arrayList);
          obj1 = (object) arrayList;
        }
        object obj2 = obj1;
        List list1;
        if (obj2 != null)
        {
          List list2 = obj2 as List;
          if (list2 == null)
            throw new IncompatibleClassChangeError();
          list1 = list2;
        }
        else
          list1 = (List) null;
        int num4 = list1.size();
        if (num4 > 0)
        {
          int num3 = num4;
          int num5 = 2;
          int num6 = -1;
          if ((num5 != num6 ? num3 % num5 : 0) == 1)
          {
            if (num4 > 1)
            {
              object obj3 = obj1;
              int num7 = (num4 - 1) / 2;
              List list2;
              if (obj3 != null)
              {
                List list3 = obj3 as List;
                if (list3 == null)
                  throw new IncompatibleClassChangeError();
                list2 = list3;
              }
              else
                list2 = (List) null;
              int num8 = num7;
              num2 = ((Number) list2.get(num8)).doubleValue();
            }
            else
            {
              object obj3 = obj1;
              int num7 = 0;
              List list2;
              if (obj3 != null)
              {
                List list3 = obj3 as List;
                if (list3 == null)
                  throw new IncompatibleClassChangeError();
                list2 = list3;
              }
              else
                list2 = (List) null;
              int num8 = num7;
              num2 = ((Number) list2.get(num8)).doubleValue();
            }
          }
          else
          {
            object obj3 = obj1;
            int num7 = num4 / 2 - 1;
            List list2;
            if (obj3 != null)
            {
              List list3 = obj3 as List;
              if (list3 == null)
                throw new IncompatibleClassChangeError();
              list2 = list3;
            }
            else
              list2 = (List) null;
            int num8 = num7;
            Number number1 = (Number) list2.get(num8);
            object obj4 = obj1;
            int num9 = num4 / 2;
            List list4;
            if (obj4 != null)
            {
              List list3 = obj4 as List;
              if (list3 == null)
                throw new IncompatibleClassChangeError();
              list4 = list3;
            }
            else
              list4 = (List) null;
            int num10 = num9;
            Number number2 = (Number) list4.get(num10);
            num2 = (number1.doubleValue() + number2.doubleValue()) / 2.0;
          }
        }
      }
      return num2;
    }

    [LineNumberTable((ushort) 247)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMedian(List values, int start, int end)
    {
      return Statistics.calculateMedian(values, start, end, true);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 120, (byte) 130, (byte) 99, (byte) 144, (byte) 134, (byte) 98, (byte) 135, (byte) 101, (byte) 173, (byte) 171, (byte) 108, (byte) 102, (byte) 228, (byte) 53, (byte) 230, (byte) 78, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMean(Number[] values, bool includeNullAndNaN)
    {
      int num1 = includeNullAndNaN ? 1 : 0;
      if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num2 = 0.0;
        int num3 = 0;
        for (int index = 0; index < values.Length; ++index)
        {
          double num4 = values[index] == null ? double.NaN : values[index].doubleValue();
          if (num1 != 0 || !Double.isNaN(num4))
          {
            num2 += num4;
            ++num3;
          }
        }
        return num2 / (double) num3;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 76, (byte) 130, (byte) 106, (byte) 99, (byte) 107, (byte) 102, (byte) 46, (byte) 166, (byte) 102, (byte) 105, (byte) 133, (byte) 103, (byte) 104, (byte) 112, (byte) 101, (byte) 149, (byte) 105, (byte) 130, (byte) 110, (byte) 105, (byte) 162, (byte) 117, (byte) 115, (byte) 251, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMedian(List values, int start, int end, bool copyAndSort)
    {
      int num1 = copyAndSort ? 1 : 0;
      double num2 = double.NaN;
      if (num1 != 0)
      {
        ArrayList arrayList = new ArrayList(end - start + 1);
        for (int index = start; index <= end; ++index)
          ((List) arrayList).add(values.get(index));
        Collections.sort((List) arrayList);
        num2 = Statistics.calculateMedian((List) arrayList, false);
      }
      else
      {
        int num3 = end - start + 1;
        if (num3 > 0)
        {
          int num4 = num3;
          int num5 = 2;
          int num6 = -1;
          num2 = (num5 != num6 ? num4 % num5 : 0) != 1 ? (((Number) values.get(start + num3 / 2 - 1)).doubleValue() + ((Number) values.get(start + num3 / 2)).doubleValue()) / 2.0 : (num3 <= 1 ? ((Number) values.get(start)).doubleValue() : ((Number) values.get(start + (num3 - 1) / 2)).doubleValue());
        }
      }
      return num2;
    }

    [LineNumberTable((ushort) 71)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMean(Number[] values)
    {
      return Statistics.calculateMean(values, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 254, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 102, (byte) 240, (byte) 76, (byte) 152, (byte) 108, (byte) 109, (byte) 123, (byte) 151, (byte) 237, (byte) 59, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getSlope(Number[] xData, Number[] yData)
    {
      if (xData == null)
      {
        string str = "Null 'xData' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (yData == null)
      {
        string str = "Null 'yData' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (xData.Length != yData.Length)
      {
        string str = "Array lengths must be equal.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        int index;
        for (index = 0; index < xData.Length; ++index)
        {
          num1 += xData[index].doubleValue();
          num2 += Math.pow(xData[index].doubleValue(), 2.0);
          num3 += yData[index].doubleValue() * xData[index].doubleValue();
          num4 += yData[index].doubleValue();
        }
        return (num3 - num1 * num4 / (double) index) / (num2 - num1 * num1 / (double) index);
      }
    }

    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMean(Collection values)
    {
      return Statistics.calculateMean(values, true);
    }

    [LineNumberTable((ushort) 185)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateMedian(List values)
    {
      return Statistics.calculateMedian(values, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 104, (byte) 134, (byte) 103, (byte) 108, (byte) 7, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getStdDev(Number[] data)
    {
      if (data == null)
      {
        string str = "Null 'data' array.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data.Length == 0)
      {
        string str = "Zero length 'data' array.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = Statistics.calculateMean(data);
        double num2 = 0.0;
        for (int index = 0; index < data.Length; ++index)
        {
          double num3 = data[index].doubleValue() - num1;
          num2 += num3 * num3;
        }
        return Math.sqrt(num2 / (double) (data.Length - 1));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 102, (byte) 208, (byte) 135, (byte) 139, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] getLinearFit(Number[] xData, Number[] yData)
    {
      if (xData == null)
      {
        string str = "Null 'xData' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (yData == null)
      {
        string str = "Null 'yData' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (xData.Length != yData.Length)
      {
        string str = "Statistics.getLinearFit(): array lengths must be equal.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double[] numArray = new double[2]
        {
          0.0,
          Statistics.getSlope(xData, yData)
        };
        numArray[0] = Statistics.calculateMean(yData) - numArray[1] * Statistics.calculateMean(xData);
        return numArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 44, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 102, (byte) 208, (byte) 99, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 107, (byte) 103, (byte) 102, (byte) 140, (byte) 103, (byte) 102, (byte) 140, (byte) 102, (byte) 102, (byte) 107, (byte) 105, (byte) 235, (byte) 51, (byte) 235, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getCorrelation(Number[] data1, Number[] data2)
    {
      if (data1 == null)
      {
        string str = "Null 'data1' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data2 == null)
      {
        string str = "Null 'data2' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (data1.Length != data2.Length)
      {
        string str = "'data1' and 'data2' arrays must have same length.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int length = data1.Length;
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        double num5 = 0.0;
        for (int index = 0; index < length; ++index)
        {
          double num6 = 0.0;
          if (data1[index] != null)
            num6 = data1[index].doubleValue();
          double num7 = 0.0;
          if (data2[index] != null)
            num7 = data2[index].doubleValue();
          num1 += num6;
          num2 += num7;
          num5 += num6 * num7;
          num3 += num6 * num6;
          num4 += num7 * num7;
        }
        return ((double) length * num5 - num1 * num2) / Math.pow(((double) length * num3 - num1 * num1) * ((double) length * num4 - num2 * num2), 0.5);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 95, (byte) 102, (byte) 176, (byte) 101, (byte) 240, (byte) 69, (byte) 127, (byte) 8, (byte) 106, (byte) 144, (byte) 103, (byte) 104, (byte) 49, (byte) 168, (byte) 104, (byte) 231, (byte) 56, (byte) 233, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[][] getMovingAverage(Number[] xData, Number[] yData, int period)
    {
      if (xData.Length != yData.Length)
      {
        string str = "Array lengths must be equal.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (period > xData.Length)
      {
        string str = "Period can't be longer than dataset.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num1 = xData.Length - period;
        int num2 = 2;
        int[] numArray1 = new int[2];
        int num3 = num2;
        numArray1[1] = num3;
        int num4 = num1;
        numArray1[0] = num4;
        // ISSUE: type reference
        double[][] numArray2 = (double[][]) ByteCodeHelper.multianewarray(__typeref (double[][]), numArray1);
        for (int index1 = 0; index1 < numArray2.Length; ++index1)
        {
          numArray2[index1][0] = xData[index1 + period].doubleValue();
          double num5 = 0.0;
          for (int index2 = 0; index2 < period; ++index2)
            num5 += yData[index1 + index2].doubleValue();
          double num6 = num5 / (double) period;
          numArray2[index1][1] = num6;
        }
        return numArray2;
      }
    }
  }
}
