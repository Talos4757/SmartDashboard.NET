// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.BoxAndWhiskerCalculator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.data.statistics
{
  public abstract class BoxAndWhiskerCalculator : Object
  {
    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerCalculator()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 162, (byte) 99, (byte) 208, (byte) 102, (byte) 108, (byte) 103, (byte) 104, (byte) 103, (byte) 104, (byte) 104, (byte) 106, (byte) 105, (byte) 174, (byte) 98, (byte) 130, (byte) 130, (byte) 153, (byte) 127, (byte) 2, (byte) 127, (byte) 2, (byte) 124, (byte) 156, (byte) 136, (byte) 114, (byte) 146, (byte) 114, (byte) 146, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 135, (byte) 123, (byte) 108, (byte) 110, (byte) 106, (byte) 102, (byte) 106, (byte) 111, (byte) 166, (byte) 102, (byte) 106, (byte) 108, (byte) 198, (byte) 108, (byte) 140, (byte) 108, (byte) 108, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxAndWhiskerItem calculateBoxAndWhiskerStatistics(List values, bool stripNullAndNaNItems)
    {
      int num1 = stripNullAndNaNItems ? 1 : 0;
      if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        object obj1;
        if (num1 != 0)
        {
          obj1 = (object) new ArrayList(values.size());
          ListIterator listIterator = values.listIterator();
          while (((Iterator) listIterator).hasNext())
          {
            object obj2 = ((Iterator) listIterator).next();
            if (obj2 is Number)
            {
              Number number = (Number) obj2;
              if (!Double.isNaN(number.doubleValue()))
                ((List) obj1).add((object) number);
            }
          }
        }
        else
          obj1 = (object) values;
        object obj3 = obj1;
        List list1;
        if (obj3 != null)
        {
          List list2 = obj3 as List;
          if (list2 == null)
            throw new IncompatibleClassChangeError();
          list1 = list2;
        }
        else
          list1 = (List) null;
        Collections.sort(list1);
        object obj4 = obj1;
        bool flag1 = false;
        Collection values1;
        if (obj4 != null)
        {
          Collection collection = obj4 as Collection;
          if (collection == null)
            throw new IncompatibleClassChangeError();
          values1 = collection;
        }
        else
          values1 = (Collection) null;
        int num2 = flag1 ? 1 : 0;
        double num3 = Statistics.calculateMean(values1, num2 != 0);
        object obj5 = obj1;
        bool flag2 = false;
        List values2;
        if (obj5 != null)
        {
          List list2 = obj5 as List;
          if (list2 == null)
            throw new IncompatibleClassChangeError();
          values2 = list2;
        }
        else
          values2 = (List) null;
        int num4 = flag2 ? 1 : 0;
        double num5 = Statistics.calculateMedian(values2, num4 != 0);
        object obj6 = obj1;
        List values3;
        if (obj6 != null)
        {
          List list2 = obj6 as List;
          if (list2 == null)
            throw new IncompatibleClassChangeError();
          values3 = list2;
        }
        else
          values3 = (List) null;
        double num6 = BoxAndWhiskerCalculator.calculateQ1(values3);
        object obj7 = obj1;
        List values4;
        if (obj7 != null)
        {
          List list2 = obj7 as List;
          if (list2 == null)
            throw new IncompatibleClassChangeError();
          values4 = list2;
        }
        else
          values4 = (List) null;
        double num7 = BoxAndWhiskerCalculator.calculateQ3(values4);
        double num8 = num7 - num6;
        double num9 = num7 + num8 * 1.5;
        double num10 = num6 - num8 * 1.5;
        double num11 = num7 + num8 * 2.0;
        double num12 = num6 - num8 * 2.0;
        double num13 = double.PositiveInfinity;
        double num14 = double.NegativeInfinity;
        double num15 = double.PositiveInfinity;
        double num16 = double.NegativeInfinity;
        ArrayList arrayList = new ArrayList();
        object obj8 = obj1;
        List list3;
        if (obj8 != null)
        {
          List list2 = obj8 as List;
          if (list2 == null)
            throw new IncompatibleClassChangeError();
          list3 = list2;
        }
        else
          list3 = (List) null;
        Iterator iterator = list3.iterator();
        while (iterator.hasNext())
        {
          Number number = (Number) iterator.next();
          double num17 = number.doubleValue();
          if (num17 > num9)
          {
            ((List) arrayList).add((object) number);
            if (num17 > num16 && num17 <= num11)
              num16 = num17;
          }
          else if (num17 < num10)
          {
            ((List) arrayList).add((object) number);
            if (num17 < num15 && num17 >= num12)
              num15 = num17;
          }
          else
          {
            num13 = Math.min(num13, num17);
            num14 = Math.max(num14, num17);
          }
          num15 = Math.min(num15, num13);
          num16 = Math.max(num16, num14);
        }
        return new BoxAndWhiskerItem((Number) new Double(num3), (Number) new Double(num5), (Number) new Double(num6), (Number) new Double(num7), (Number) new Double(num13), (Number) new Double(num14), (Number) new Double(num15), (Number) new Double(num16), (List) arrayList);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 99, (byte) 176, (byte) 106, (byte) 103, (byte) 100, (byte) 111, (byte) 100, (byte) 174, (byte) 204, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateQ1(List values)
    {
      if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = double.NaN;
        int num2 = values.size();
        if (num2 > 0)
        {
          int num3 = num2;
          int num4 = 2;
          int num5 = -1;
          num1 = (num4 != num5 ? num3 % num4 : 0) != 1 ? Statistics.calculateMedian(values, 0, num2 / 2 - 1) : (num2 <= 1 ? Statistics.calculateMedian(values, 0, 0) : Statistics.calculateMedian(values, 0, num2 / 2));
        }
        return num1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 99, (byte) 144, (byte) 106, (byte) 103, (byte) 100, (byte) 111, (byte) 100, (byte) 208, (byte) 204, (byte) 206})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateQ3(List values)
    {
      if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = double.NaN;
        int num2 = values.size();
        if (num2 > 0)
        {
          int num3 = num2;
          int num4 = 2;
          int num5 = -1;
          num1 = (num4 != num5 ? num3 % num4 : 0) != 1 ? Statistics.calculateMedian(values, num2 / 2, num2 - 1) : (num2 <= 1 ? Statistics.calculateMedian(values, 0, 0) : Statistics.calculateMedian(values, num2 / 2, num2 - 1));
        }
        return num1;
      }
    }

    [LineNumberTable((ushort) 74)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxAndWhiskerItem calculateBoxAndWhiskerStatistics(List values)
    {
      return BoxAndWhiskerCalculator.calculateBoxAndWhiskerStatistics(values, true);
    }
  }
}
