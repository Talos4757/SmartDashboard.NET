// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.DatasetUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.function;
using org.jfree.data.statistics;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.general
{
  public sealed class DatasetUtilities : Object
  {
    [LineNumberTable(new byte[] {(byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DatasetUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 99, (byte) 144, (byte) 103, (byte) 102, (byte) 103, (byte) 104, (byte) 108, (byte) 99, (byte) 105, (byte) 103, (byte) 100, (byte) 138, (byte) 105, (byte) 166, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculatePieDatasetTotal(PieDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        List keys = dataset.getKeys();
        double num1 = 0.0;
        Iterator iterator = keys.iterator();
        while (iterator.hasNext())
        {
          IComparable c = (IComparable) iterator.next();
          if (c != null)
          {
            Number number = dataset.getValue(c);
            double num2 = 0.0;
            if (number != null)
              num2 = number.doubleValue();
            if (num2 > 0.0)
              num1 += num2;
          }
        }
        return num1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 222, (byte) 99, (byte) 162, (byte) 103, (byte) 103, (byte) 102, (byte) 162, (byte) 102, (byte) 102, (byte) 106, (byte) 2, (byte) 38, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isEmptyOrNull(CategoryDataset dataset)
    {
      if (dataset == null)
        return true;
      int rowCount = dataset.getRowCount();
      int columnCount = dataset.getColumnCount();
      if (rowCount == 0 || columnCount == 0)
        return true;
      for (int i1 = 0; i1 < rowCount; ++i1)
      {
        for (int i2 = 0; i2 < columnCount; ++i2)
        {
          if (dataset.getValue(i1, i2) != null)
            return false;
        }
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 254, (byte) 99, (byte) 107, (byte) 106, (byte) 2, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isEmptyOrNull(XYDataset dataset)
    {
      if (dataset != null)
      {
        for (int i = 0; i < dataset.getSeriesCount(); ++i)
        {
          if (dataset.getItemCount(i) > 0)
            return false;
        }
      }
      return true;
    }

    [LineNumberTable((ushort) 642)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findDomainBounds(XYDataset dataset)
    {
      return DatasetUtilities.findDomainBounds(dataset, true);
    }

    [LineNumberTable((ushort) 855)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findRangeBounds(XYDataset dataset)
    {
      return DatasetUtilities.findRangeBounds(dataset, true);
    }

    [LineNumberTable((ushort) 280)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset createConsolidatedPieDataset(PieDataset source, IComparable key, double minimumPercent)
    {
      return DatasetUtilities.createConsolidatedPieDataset(source, key, minimumPercent, 2);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 99, (byte) 162, (byte) 103, (byte) 99, (byte) 162, (byte) 102, (byte) 104, (byte) 99, (byte) 104, (byte) 104, (byte) 226, (byte) 59, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isEmptyOrNull(PieDataset dataset)
    {
      if (dataset == null)
        return true;
      int itemCount = dataset.getItemCount();
      if (itemCount == 0)
        return true;
      for (int i = 0; i < itemCount; ++i)
      {
        Number number = dataset.getValue(i);
        if (number != null && number.doubleValue() > 0.0)
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 191, (byte) 162, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 103, (byte) 105, (byte) 130, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findRangeBounds(CategoryDataset dataset, List visibleSeriesKeys, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return !(dataset is CategoryRangeInfo) ? DatasetUtilities.iterateToFindRangeBounds(dataset, visibleSeriesKeys, num != 0) : ((CategoryRangeInfo) dataset).getRangeBounds(visibleSeriesKeys, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 198, (byte) 98, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 103, (byte) 104, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findRangeBounds(CategoryDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return !(dataset is RangeInfo) ? DatasetUtilities.iterateRangeBounds(dataset, num != 0) : ((RangeInfo) dataset).getRangeBounds(num != 0);
    }

    [LineNumberTable((ushort) 787)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findRangeBounds(CategoryDataset dataset)
    {
      return DatasetUtilities.findRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 170, (byte) 99, (byte) 144, (byte) 98, (byte) 106, (byte) 106, (byte) 103, (byte) 107, (byte) 100, (byte) 100, (byte) 104, (byte) 105, (byte) 108, (byte) 100, (byte) 106, (byte) 105, (byte) 136, (byte) 105, (byte) 232, (byte) 56, (byte) 232, (byte) 77, (byte) 106, (byte) 234, (byte) 46, (byte) 235, (byte) 84, (byte) 100, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findStackedRangeBounds(CategoryDataset dataset, double @base)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Range range = (Range) null;
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int columnCount = dataset.getColumnCount();
        for (int i2 = 0; i2 < columnCount; ++i2)
        {
          double num1 = @base;
          double num2 = @base;
          int rowCount = dataset.getRowCount();
          for (int i1 = 0; i1 < rowCount; ++i1)
          {
            Number number = dataset.getValue(i1, i2);
            if (number != null)
            {
              double num3 = number.doubleValue();
              if (num3 > 0.0)
                num1 += num3;
              if (num3 < 0.0)
                num2 += num3;
            }
          }
          lower = Math.min(lower, num2);
          upper = Math.max(upper, num1);
        }
        if (lower <= upper)
          range = new Range(lower, upper);
        return range;
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 216, (byte) 99, (byte) 144, (byte) 98, (byte) 162, (byte) 108, (byte) 107, (byte) 54, (byte) 230, (byte) 70, (byte) 103, (byte) 104, (byte) 136, (byte) 104, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 108, (byte) 108, (byte) 100, (byte) 98, (byte) 106, (byte) 105, (byte) 178, (byte) 105, (byte) 242, (byte) 54, (byte) 235, (byte) 80, (byte) 104, (byte) 117, (byte) 21, (byte) 232, (byte) 44, (byte) 235, (byte) 89, (byte) 99, (byte) 104, (byte) 54, (byte) 232, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findStackedRangeBounds(CategoryDataset dataset, KeyToGroupMap map)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num1 = 0;
        Range range1 = (Range) null;
        int[] numArray1 = new int[dataset.getRowCount()];
        for (int i = 0; i < dataset.getRowCount(); ++i)
          numArray1[i] = map.getGroupIndex(map.getGroup(dataset.getRowKey(i)));
        int groupCount = map.getGroupCount();
        double[] numArray2 = new double[groupCount];
        double[] numArray3 = new double[groupCount];
        int columnCount = dataset.getColumnCount();
        for (int i2 = 0; i2 < columnCount; ++i2)
        {
          double[] numArray4 = new double[groupCount];
          double[] numArray5 = new double[groupCount];
          int rowCount = dataset.getRowCount();
          for (int i1 = 0; i1 < rowCount; ++i1)
          {
            Number number = dataset.getValue(i1, i2);
            if (number != null)
            {
              num1 = 1;
              double num2 = number.doubleValue();
              if (num2 > 0.0)
                numArray4[numArray1[i1]] = numArray4[numArray1[i1]] + num2;
              if (num2 < 0.0)
                numArray5[numArray1[i1]] = numArray5[numArray1[i1]] + num2;
            }
          }
          for (int index = 0; index < groupCount; ++index)
          {
            numArray2[index] = Math.min(numArray2[index], numArray5[index]);
            numArray3[index] = Math.max(numArray3[index], numArray4[index]);
          }
        }
        if (num1 != 0)
        {
          for (int index = 0; index < groupCount; ++index)
            range1 = Range.combine(range1, new Range(numArray2[index], numArray3[index]));
        }
        return range1;
      }
    }

    [LineNumberTable((ushort) 1806)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findStackedRangeBounds(CategoryDataset dataset)
    {
      return DatasetUtilities.findStackedRangeBounds(dataset, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 225, (byte) 66, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 103, (byte) 105, (byte) 130, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findDomainBounds(XYDataset dataset, List visibleSeriesKeys, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return !(dataset is XYDomainInfo) ? DatasetUtilities.iterateToFindDomainBounds(dataset, visibleSeriesKeys, num != 0) : ((XYDomainInfo) dataset).getDomainBounds(visibleSeriesKeys, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 234, (byte) 130, (byte) 99, (byte) 176, (byte) 130, (byte) 104, (byte) 103, (byte) 104, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findDomainBounds(XYDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return !(dataset is DomainInfo) ? DatasetUtilities.iterateDomainBounds(dataset, num != 0) : ((DomainInfo) dataset).getDomainBounds(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 173, (byte) 162, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 103, (byte) 138, (byte) 130, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findRangeBounds(XYDataset dataset, List visibleSeriesKeys, Range xRange, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return !(dataset is XYRangeInfo) ? DatasetUtilities.iterateToFindRangeBounds(dataset, visibleSeriesKeys, xRange, num != 0) : ((XYRangeInfo) dataset).getRangeBounds(visibleSeriesKeys, xRange, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 181, (byte) 162, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 103, (byte) 104, (byte) 130, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findRangeBounds(XYDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return !(dataset is RangeInfo) ? DatasetUtilities.iterateRangeBounds(dataset, num != 0) : ((RangeInfo) dataset).getRangeBounds(num != 0);
    }

    [LineNumberTable((ushort) 2007)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findStackedRangeBounds(TableXYDataset dataset)
    {
      return DatasetUtilities.findStackedRangeBounds(dataset, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 162, (byte) 102, (byte) 103, (byte) 102, (byte) 106, (byte) 104, (byte) 229, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateStackTotal(TableXYDataset dataset, int item)
    {
      double num = 0.0;
      int seriesCount = dataset.getSeriesCount();
      for (int i1 = 0; i1 < seriesCount; ++i1)
      {
        double yvalue = dataset.getYValue(i1, item);
        if (!Double.isNaN(yvalue))
          num += yvalue;
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 102, (byte) 103, (byte) 102, (byte) 104, (byte) 15, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset createPieDatasetForRow(CategoryDataset dataset, int row)
    {
      DefaultPieDataset defaultPieDataset = new DefaultPieDataset();
      int columnCount = dataset.getColumnCount();
      for (int index = 0; index < columnCount; ++index)
      {
        IComparable columnKey = dataset.getColumnKey(index);
        defaultPieDataset.setValue(columnKey, dataset.getValue(row, index));
      }
      return (PieDataset) defaultPieDataset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 142, (byte) 102, (byte) 103, (byte) 102, (byte) 104, (byte) 15, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset createPieDatasetForColumn(CategoryDataset dataset, int column)
    {
      DefaultPieDataset defaultPieDataset = new DefaultPieDataset();
      int rowCount = dataset.getRowCount();
      for (int index = 0; index < rowCount; ++index)
      {
        IComparable rowKey = dataset.getRowKey(index);
        defaultPieDataset.setValue(rowKey, dataset.getValue(index, column));
      }
      return (PieDataset) defaultPieDataset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 102, (byte) 168, (byte) 103, (byte) 102, (byte) 104, (byte) 105, (byte) 110, (byte) 106, (byte) 100, (byte) 106, (byte) 104, (byte) 169, (byte) 162, (byte) 104, (byte) 103, (byte) 105, (byte) 110, (byte) 106, (byte) 100, (byte) 179, (byte) 207, (byte) 170, (byte) 133, (byte) 105, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset createConsolidatedPieDataset(PieDataset source, IComparable key, double minimumPercent, int minItems)
    {
      DefaultPieDataset defaultPieDataset = new DefaultPieDataset();
      double num1 = DatasetUtilities.calculatePieDatasetTotal(source);
      List keys = source.getKeys();
      ArrayList arrayList = new ArrayList();
      Iterator iterator1 = keys.iterator();
      while (iterator1.hasNext())
      {
        IComparable c = (IComparable) iterator1.next();
        Number number = source.getValue(c);
        if (number != null && number.doubleValue() / num1 < minimumPercent)
          arrayList.add((object) c);
      }
      Iterator iterator2 = keys.iterator();
      double num2 = 0.0;
      while (iterator2.hasNext())
      {
        IComparable comparable = (IComparable) iterator2.next();
        Number number = source.getValue(comparable);
        if (number != null)
        {
          if (arrayList.contains((object) comparable) && arrayList.size() >= minItems)
            num2 += number.doubleValue();
          else
            defaultPieDataset.setValue(comparable, number);
        }
      }
      if (arrayList.size() >= minItems)
        defaultPieDataset.setValue(key, num2);
      return (PieDataset) defaultPieDataset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 157, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 102, (byte) 144, (byte) 100, (byte) 176, (byte) 104, (byte) 108, (byte) 102, (byte) 105, (byte) 14, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYSeries sampleFunction2DToSeries(Function2D f, double start, double end, int samples, IComparable seriesKey)
    {
      if (f == null)
      {
        string str = "Null 'f' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (seriesKey == null)
      {
        string str = "Null 'seriesKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (start >= end)
      {
        string str = "Requires 'start' < 'end'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (samples < 2)
      {
        string str = "Requires 'samples' > 1";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        XYSeries xySeries = new XYSeries(seriesKey);
        double num1 = (end - start) / (double) (samples - 1);
        for (int index = 0; index < samples; ++index)
        {
          double num2 = start + num1 * (double) index;
          xySeries.add(num2, f.getValue(num2));
        }
        return xySeries;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 215, (byte) 130, (byte) 99, (byte) 144, (byte) 106, (byte) 106, (byte) 167, (byte) 113, (byte) 104, (byte) 107, (byte) 106, (byte) 105, (byte) 110, (byte) 110, (byte) 105, (byte) 138, (byte) 105, (byte) 234, (byte) 57, (byte) 11, (byte) 235, (byte) 77, (byte) 133, (byte) 107, (byte) 106, (byte) 105, (byte) 109, (byte) 100, (byte) 105, (byte) 106, (byte) 234, (byte) 59, (byte) 8, (byte) 235, (byte) 76, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateDomainBounds(XYDataset dataset, bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int seriesCount = dataset.getSeriesCount();
        if (num1 != 0 && dataset is IntervalXYDataset)
        {
          IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
          for (int index = 0; index < seriesCount; ++index)
          {
            int itemCount = dataset.getItemCount(index);
            for (int i2 = 0; i2 < itemCount; ++i2)
            {
              double startXvalue = ntervalXyDataset.getStartXValue(index, i2);
              double endXvalue = ntervalXyDataset.getEndXValue(index, i2);
              if (!Double.isNaN(startXvalue))
                lower = Math.min(lower, startXvalue);
              if (!Double.isNaN(endXvalue))
                upper = Math.max(upper, endXvalue);
            }
          }
        }
        else
        {
          for (int index = 0; index < seriesCount; ++index)
          {
            int itemCount = dataset.getItemCount(index);
            for (int i2 = 0; i2 < itemCount; ++i2)
            {
              double xvalue = dataset.getXValue(index, i2);
              double num2 = xvalue;
              if (!Double.isNaN(xvalue))
              {
                lower = Math.min(lower, xvalue);
                upper = Math.max(upper, num2);
              }
            }
          }
        }
        if (lower > upper)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 82, (byte) 66, (byte) 99, (byte) 144, (byte) 99, (byte) 208, (byte) 106, (byte) 138, (byte) 145, (byte) 103, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 106, (byte) 105, (byte) 109, (byte) 109, (byte) 105, (byte) 138, (byte) 105, (byte) 234, (byte) 57, (byte) 235, (byte) 74, (byte) 101, (byte) 165, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 106, (byte) 105, (byte) 109, (byte) 105, (byte) 106, (byte) 234, (byte) 60, (byte) 232, (byte) 71, (byte) 165, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateToFindDomainBounds(XYDataset dataset, List visibleSeriesKeys, bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (visibleSeriesKeys == null)
      {
        string str = "Null 'visibleSeriesKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        if (num1 != 0 && dataset is IntervalXYDataset)
        {
          IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_6:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int num2 = dataset.indexOf(c);
            int itemCount = dataset.getItemCount(num2);
            int i2 = 0;
            while (true)
            {
              if (i2 < itemCount)
              {
                double startXvalue = ntervalXyDataset.getStartXValue(num2, i2);
                double endXvalue = ntervalXyDataset.getEndXValue(num2, i2);
                if (!Double.isNaN(startXvalue))
                  lower = Math.min(lower, startXvalue);
                if (!Double.isNaN(endXvalue))
                  upper = Math.max(upper, endXvalue);
                ++i2;
              }
              else
                goto label_6;
            }
          }
        }
        else
        {
          Iterator iterator = visibleSeriesKeys.iterator();
label_15:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int num2 = dataset.indexOf(c);
            int itemCount = dataset.getItemCount(num2);
            int i2 = 0;
            while (true)
            {
              if (i2 < itemCount)
              {
                double xvalue = dataset.getXValue(num2, i2);
                if (!Double.isNaN(xvalue))
                {
                  lower = Math.min(lower, xvalue);
                  upper = Math.max(upper, xvalue);
                }
                ++i2;
              }
              else
                goto label_15;
            }
          }
        }
        if (lower == double.PositiveInfinity)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 157, (byte) 98, (byte) 106, (byte) 106, (byte) 103, (byte) 104, (byte) 177, (byte) 136, (byte) 107, (byte) 108, (byte) 109, (byte) 109, (byte) 114, (byte) 143, (byte) 114, (byte) 239, (byte) 57, (byte) 43, (byte) 235, (byte) 76, (byte) 165, (byte) 107, (byte) 105, (byte) 108, (byte) 100, (byte) 106, (byte) 105, (byte) 106, (byte) 234, (byte) 58, (byte) 40, (byte) 235, (byte) 77, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateRangeBounds(CategoryDataset dataset, bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      double lower = double.PositiveInfinity;
      double upper = double.NegativeInfinity;
      int rowCount = dataset.getRowCount();
      int columnCount = dataset.getColumnCount();
      if (num1 != 0 && dataset is IntervalCategoryDataset)
      {
        IntervalCategoryDataset ntervalCategoryDataset = (IntervalCategoryDataset) dataset;
        for (int i1 = 0; i1 < rowCount; ++i1)
        {
          for (int i2 = 0; i2 < columnCount; ++i2)
          {
            Number startValue = ntervalCategoryDataset.getStartValue(i1, i2);
            Number endValue = ntervalCategoryDataset.getEndValue(i1, i2);
            if (startValue != null && !Double.isNaN(startValue.doubleValue()))
              lower = Math.min(lower, startValue.doubleValue());
            if (endValue != null && !Double.isNaN(endValue.doubleValue()))
              upper = Math.max(upper, endValue.doubleValue());
          }
        }
      }
      else
      {
        for (int i1 = 0; i1 < rowCount; ++i1)
        {
          for (int i2 = 0; i2 < columnCount; ++i2)
          {
            Number number = dataset.getValue(i1, i2);
            if (number != null)
            {
              double num2 = number.doubleValue();
              if (!Double.isNaN(num2))
              {
                lower = Math.min(lower, num2);
                upper = Math.max(upper, num2);
              }
            }
          }
        }
      }
      if (lower == double.PositiveInfinity)
        return (Range) null;
      return new Range(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 142, (byte) 130, (byte) 99, (byte) 144, (byte) 99, (byte) 208, (byte) 106, (byte) 106, (byte) 103, (byte) 177, (byte) 136, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 104, (byte) 108, (byte) 109, (byte) 100, (byte) 141, (byte) 109, (byte) 100, (byte) 141, (byte) 100, (byte) 143, (byte) 100, (byte) 239, (byte) 51, (byte) 235, (byte) 80, (byte) 101, (byte) 101, (byte) 209, (byte) 136, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 107, (byte) 109, (byte) 109, (byte) 114, (byte) 143, (byte) 114, (byte) 239, (byte) 57, (byte) 235, (byte) 74, (byte) 101, (byte) 101, (byte) 209, (byte) 136, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 107, (byte) 109, (byte) 103, (byte) 103, (byte) 109, (byte) 100, (byte) 106, (byte) 105, (byte) 167, (byte) 106, (byte) 105, (byte) 109, (byte) 237, (byte) 50, (byte) 235, (byte) 82, (byte) 101, (byte) 165, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 104, (byte) 108, (byte) 100, (byte) 106, (byte) 105, (byte) 106, (byte) 234, (byte) 58, (byte) 232, (byte) 74, (byte) 133, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateToFindRangeBounds(CategoryDataset dataset, List visibleSeriesKeys, bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (visibleSeriesKeys == null)
      {
        string str = "Null 'visibleSeriesKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        int columnCount1 = dataset.getColumnCount();
        if (num1 != 0 && dataset is BoxAndWhiskerCategoryDataset)
        {
          BoxAndWhiskerCategoryDataset whiskerCategoryDataset = (BoxAndWhiskerCategoryDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_6:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int rowIndex = dataset.getRowIndex(c);
            int columnCount2 = dataset.getColumnCount();
            int i2 = 0;
            while (true)
            {
              if (i2 < columnCount2)
              {
                Number number1 = whiskerCategoryDataset.getMinRegularValue(rowIndex, i2) ?? whiskerCategoryDataset.getValue(rowIndex, i2);
                Number number2 = whiskerCategoryDataset.getMaxRegularValue(rowIndex, i2) ?? whiskerCategoryDataset.getValue(rowIndex, i2);
                if (number1 != null)
                  lower = Math.min(lower, number1.doubleValue());
                if (number2 != null)
                  upper = Math.max(upper, number2.doubleValue());
                ++i2;
              }
              else
                goto label_6;
            }
          }
        }
        else if (num1 != 0 && dataset is IntervalCategoryDataset)
        {
          IntervalCategoryDataset ntervalCategoryDataset = (IntervalCategoryDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_16:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int rowIndex = dataset.getRowIndex(c);
            int i2 = 0;
            while (true)
            {
              if (i2 < columnCount1)
              {
                Number startValue = ntervalCategoryDataset.getStartValue(rowIndex, i2);
                Number endValue = ntervalCategoryDataset.getEndValue(rowIndex, i2);
                if (startValue != null && !Double.isNaN(startValue.doubleValue()))
                  lower = Math.min(lower, startValue.doubleValue());
                if (endValue != null && !Double.isNaN(endValue.doubleValue()))
                  upper = Math.max(upper, endValue.doubleValue());
                ++i2;
              }
              else
                goto label_16;
            }
          }
        }
        else if (num1 != 0 && dataset is StatisticalCategoryDataset)
        {
          StatisticalCategoryDataset statisticalCategoryDataset = (StatisticalCategoryDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_26:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int rowIndex = dataset.getRowIndex(c);
            int i2 = 0;
            while (true)
            {
              if (i2 < columnCount1)
              {
                Number meanValue = statisticalCategoryDataset.getMeanValue(rowIndex, i2);
                if (meanValue != null)
                {
                  double num2 = 0.0;
                  Number stdDevValue = statisticalCategoryDataset.getStdDevValue(rowIndex, i2);
                  if (stdDevValue != null)
                  {
                    num2 = stdDevValue.doubleValue();
                    if (Double.isNaN(num2))
                      num2 = 0.0;
                  }
                  double num3 = meanValue.doubleValue();
                  if (!Double.isNaN(num3))
                  {
                    lower = Math.min(lower, num3 - num2);
                    upper = Math.max(upper, num3 + num2);
                  }
                }
                ++i2;
              }
              else
                goto label_26;
            }
          }
        }
        else
        {
          Iterator iterator = visibleSeriesKeys.iterator();
label_37:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int rowIndex = dataset.getRowIndex(c);
            int i2 = 0;
            while (true)
            {
              if (i2 < columnCount1)
              {
                Number number = dataset.getValue(rowIndex, i2);
                if (number != null)
                {
                  double num2 = number.doubleValue();
                  if (!Double.isNaN(num2))
                  {
                    lower = Math.min(lower, num2);
                    upper = Math.max(upper, num2);
                  }
                }
                ++i2;
              }
              else
                goto label_37;
            }
          }
        }
        if (lower == double.PositiveInfinity)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 102, (byte) 130, (byte) 106, (byte) 106, (byte) 167, (byte) 145, (byte) 104, (byte) 107, (byte) 106, (byte) 105, (byte) 110, (byte) 110, (byte) 105, (byte) 138, (byte) 105, (byte) 234, (byte) 57, (byte) 11, (byte) 235, (byte) 77, (byte) 101, (byte) 145, (byte) 104, (byte) 107, (byte) 106, (byte) 105, (byte) 110, (byte) 110, (byte) 105, (byte) 138, (byte) 105, (byte) 234, (byte) 57, (byte) 11, (byte) 235, (byte) 77, (byte) 165, (byte) 107, (byte) 106, (byte) 105, (byte) 109, (byte) 105, (byte) 106, (byte) 234, (byte) 60, (byte) 8, (byte) 235, (byte) 75, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateRangeBounds(XYDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      double lower = double.PositiveInfinity;
      double upper = double.NegativeInfinity;
      int seriesCount = dataset.getSeriesCount();
      if (num != 0 && dataset is IntervalXYDataset)
      {
        IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double startYvalue = ntervalXyDataset.getStartYValue(index, i2);
            double endYvalue = ntervalXyDataset.getEndYValue(index, i2);
            if (!Double.isNaN(startYvalue))
              lower = Math.min(lower, startYvalue);
            if (!Double.isNaN(endYvalue))
              upper = Math.max(upper, endYvalue);
          }
        }
      }
      else if (num != 0 && dataset is OHLCDataset)
      {
        OHLCDataset ohlcDataset = (OHLCDataset) dataset;
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double lowValue = ohlcDataset.getLowValue(index, i2);
            double highValue = ohlcDataset.getHighValue(index, i2);
            if (!Double.isNaN(lowValue))
              lower = Math.min(lower, lowValue);
            if (!Double.isNaN(highValue))
              upper = Math.max(upper, highValue);
          }
        }
      }
      else
      {
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double yvalue = dataset.getYValue(index, i2);
            if (!Double.isNaN(yvalue))
            {
              lower = Math.min(lower, yvalue);
              upper = Math.max(upper, yvalue);
            }
          }
        }
      }
      if (lower == double.PositiveInfinity)
        return (Range) null;
      return new Range(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 63, (byte) 66, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 99, (byte) 176, (byte) 106, (byte) 170, (byte) 145, (byte) 103, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 106, (byte) 108, (byte) 109, (byte) 106, (byte) 109, (byte) 109, (byte) 105, (byte) 138, (byte) 105, (byte) 234, (byte) 55, (byte) 235, (byte) 77, (byte) 101, (byte) 101, (byte) 145, (byte) 104, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 106, (byte) 108, (byte) 110, (byte) 106, (byte) 109, (byte) 109, (byte) 100, (byte) 143, (byte) 100, (byte) 239, (byte) 55, (byte) 235, (byte) 77, (byte) 101, (byte) 101, (byte) 145, (byte) 104, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 106, (byte) 108, (byte) 110, (byte) 106, (byte) 110, (byte) 110, (byte) 105, (byte) 138, (byte) 105, (byte) 234, (byte) 55, (byte) 235, (byte) 77, (byte) 101, (byte) 165, (byte) 104, (byte) 108, (byte) 110, (byte) 106, (byte) 106, (byte) 105, (byte) 109, (byte) 109, (byte) 106, (byte) 105, (byte) 106, (byte) 234, (byte) 58, (byte) 232, (byte) 74, (byte) 133, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateToFindRangeBounds(XYDataset dataset, List visibleSeriesKeys, Range xRange, bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (visibleSeriesKeys == null)
      {
        string str = "Null 'visibleSeriesKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (xRange == null)
      {
        string str = "Null 'xRange' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = double.PositiveInfinity;
        double upper = double.NegativeInfinity;
        if (num1 != 0 && dataset is OHLCDataset)
        {
          OHLCDataset ohlcDataset = (OHLCDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_8:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int num2 = dataset.indexOf(c);
            int itemCount = dataset.getItemCount(num2);
            int i2 = 0;
            while (true)
            {
              if (i2 < itemCount)
              {
                double xvalue = ohlcDataset.getXValue(num2, i2);
                if (xRange.contains(xvalue))
                {
                  double lowValue = ohlcDataset.getLowValue(num2, i2);
                  double highValue = ohlcDataset.getHighValue(num2, i2);
                  if (!Double.isNaN(lowValue))
                    lower = Math.min(lower, lowValue);
                  if (!Double.isNaN(highValue))
                    upper = Math.max(upper, highValue);
                }
                ++i2;
              }
              else
                goto label_8;
            }
          }
        }
        else if (num1 != 0 && dataset is BoxAndWhiskerXYDataset)
        {
          BoxAndWhiskerXYDataset whiskerXyDataset = (BoxAndWhiskerXYDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_19:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int num2 = dataset.indexOf(c);
            int itemCount = dataset.getItemCount(num2);
            int i2 = 0;
            while (true)
            {
              if (i2 < itemCount)
              {
                double xvalue = whiskerXyDataset.getXValue(num2, i2);
                if (xRange.contains(xvalue))
                {
                  Number minRegularValue = whiskerXyDataset.getMinRegularValue(num2, i2);
                  Number maxRegularValue = whiskerXyDataset.getMaxRegularValue(num2, i2);
                  if (minRegularValue != null)
                    lower = Math.min(lower, minRegularValue.doubleValue());
                  if (maxRegularValue != null)
                    upper = Math.max(upper, maxRegularValue.doubleValue());
                }
                ++i2;
              }
              else
                goto label_19;
            }
          }
        }
        else if (num1 != 0 && dataset is IntervalXYDataset)
        {
          IntervalXYDataset ntervalXyDataset = (IntervalXYDataset) dataset;
          Iterator iterator = visibleSeriesKeys.iterator();
label_30:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int num2 = dataset.indexOf(c);
            int itemCount = dataset.getItemCount(num2);
            int i2 = 0;
            while (true)
            {
              if (i2 < itemCount)
              {
                double xvalue = ntervalXyDataset.getXValue(num2, i2);
                if (xRange.contains(xvalue))
                {
                  double startYvalue = ntervalXyDataset.getStartYValue(num2, i2);
                  double endYvalue = ntervalXyDataset.getEndYValue(num2, i2);
                  if (!Double.isNaN(startYvalue))
                    lower = Math.min(lower, startYvalue);
                  if (!Double.isNaN(endYvalue))
                    upper = Math.max(upper, endYvalue);
                }
                ++i2;
              }
              else
                goto label_30;
            }
          }
        }
        else
        {
          Iterator iterator = visibleSeriesKeys.iterator();
label_40:
          while (iterator.hasNext())
          {
            IComparable c = (IComparable) iterator.next();
            int num2 = dataset.indexOf(c);
            int itemCount = dataset.getItemCount(num2);
            int i2 = 0;
            while (true)
            {
              if (i2 < itemCount)
              {
                double xvalue = dataset.getXValue(num2, i2);
                double yvalue = dataset.getYValue(num2, i2);
                if (xRange.contains(xvalue) && !Double.isNaN(yvalue))
                {
                  lower = Math.min(lower, yvalue);
                  upper = Math.max(upper, yvalue);
                }
                ++i2;
              }
              else
                goto label_40;
            }
          }
        }
        if (lower == double.PositiveInfinity)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable((ushort) 1168)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateRangeBounds(XYDataset dataset)
    {
      return DatasetUtilities.iterateRangeBounds(dataset, true);
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 115, (byte) 99, (byte) 144, (byte) 99, (byte) 99, (byte) 110, (byte) 99, (byte) 100, (byte) 104, (byte) 105, (byte) 108, (byte) 105, (byte) 105, (byte) 168, (byte) 232, (byte) 57, (byte) 232, (byte) 75, (byte) 100, (byte) 130, (byte) 101, (byte) 227, (byte) 45, (byte) 233, (byte) 86, (byte) 100, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findStackedRangeBounds(TableXYDataset dataset, double @base)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double lower = @base;
        double upper = @base;
        for (int i2 = 0; i2 < dataset.getItemCount(); ++i2)
        {
          double num1 = @base;
          double num2 = @base;
          int seriesCount = dataset.getSeriesCount();
          for (int i1 = 0; i1 < seriesCount; ++i1)
          {
            double yvalue = dataset.getYValue(i1, i2);
            if (!Double.isNaN(yvalue))
            {
              if (yvalue > 0.0)
                num1 += yvalue;
              else
                num2 += yvalue;
            }
          }
          if (num1 > upper)
            upper = num1;
          if (num2 < lower)
            lower = num2;
        }
        if (lower > upper)
          return (Range) null;
        return new Range(lower, upper);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset createPieDatasetForRow(CategoryDataset dataset, IComparable rowKey)
    {
      int rowIndex = dataset.getRowIndex(rowKey);
      return DatasetUtilities.createPieDatasetForRow(dataset, rowIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PieDataset createPieDatasetForColumn(CategoryDataset dataset, IComparable columnKey)
    {
      int columnIndex = dataset.getColumnIndex(columnKey);
      return DatasetUtilities.createPieDatasetForColumn(dataset, columnIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 102, (byte) 106, (byte) 121, (byte) 105, (byte) 122, (byte) 24, (byte) 6, (byte) 233, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryDataset createCategoryDataset(string rowKeyPrefix, string columnKeyPrefix, double[][] data)
    {
      DefaultCategoryDataset defaultCategoryDataset1 = new DefaultCategoryDataset();
      for (int index1 = 0; index1 < data.Length; ++index1)
      {
        string str1 = new StringBuffer().append(rowKeyPrefix).append(index1 + 1).toString();
        for (int index2 = 0; index2 < data[index1].Length; ++index2)
        {
          string str2 = new StringBuffer().append(columnKeyPrefix).append(index2 + 1).toString();
          DefaultCategoryDataset defaultCategoryDataset2 = defaultCategoryDataset1;
          Double.__\u003Cclinit\u003E();
          Double @double = new Double(data[index1][index2]);
          string str3 = str1;
          string str4 = str2;
          defaultCategoryDataset2.addValue((Number) @double, (IComparable) str3, (IComparable) str4);
        }
      }
      return (CategoryDataset) defaultCategoryDataset1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 102, (byte) 106, (byte) 121, (byte) 105, (byte) 122, (byte) 14, (byte) 6, (byte) 233, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryDataset createCategoryDataset(string rowKeyPrefix, string columnKeyPrefix, Number[][] data)
    {
      DefaultCategoryDataset defaultCategoryDataset = new DefaultCategoryDataset();
      for (int index1 = 0; index1 < data.Length; ++index1)
      {
        string str1 = new StringBuffer().append(rowKeyPrefix).append(index1 + 1).toString();
        for (int index2 = 0; index2 < data[index1].Length; ++index2)
        {
          string str2 = new StringBuffer().append(columnKeyPrefix).append(index2 + 1).toString();
          defaultCategoryDataset.addValue(data[index1][index2], (IComparable) str1, (IComparable) str2);
        }
      }
      return (CategoryDataset) defaultCategoryDataset;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 176, (byte) 102, (byte) 208, (byte) 98, (byte) 103, (byte) 43, (byte) 166, (byte) 101, (byte) 240, (byte) 70, (byte) 102, (byte) 103, (byte) 101, (byte) 107, (byte) 102, (byte) 26, (byte) 8, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryDataset createCategoryDataset(IComparable[] rowKeys, IComparable[] columnKeys, double[][] data)
    {
      if (rowKeys == null)
      {
        string str = "Null 'rowKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (columnKeys == null)
      {
        string str = "Null 'columnKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (ArrayUtilities.hasDuplicateItems((object[]) rowKeys))
      {
        string str = "Duplicate items in 'rowKeys'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (ArrayUtilities.hasDuplicateItems((object[]) columnKeys))
      {
        string str = "Duplicate items in 'columnKeys'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rowKeys.Length != data.Length)
      {
        string str = "The number of row keys does not match the number of rows in the data array.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = 0;
        for (int index = 0; index < data.Length; ++index)
          num = Math.max(num, data[index].Length);
        if (columnKeys.Length != num)
        {
          string str = "The number of column keys does not match the number of columns in the data array.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          DefaultCategoryDataset defaultCategoryDataset1 = new DefaultCategoryDataset();
          for (int index1 = 0; index1 < data.Length; ++index1)
          {
            IComparable comparable1 = rowKeys[index1];
            for (int index2 = 0; index2 < data[index1].Length; ++index2)
            {
              IComparable comparable2 = columnKeys[index2];
              DefaultCategoryDataset defaultCategoryDataset2 = defaultCategoryDataset1;
              Double.__\u003Cclinit\u003E();
              Double @double = new Double(data[index1][index2]);
              IComparable rowKey = comparable1;
              IComparable columnKey = comparable2;
              defaultCategoryDataset2.addValue((Number) @double, rowKey, columnKey);
            }
          }
          return (CategoryDataset) defaultCategoryDataset1;
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 102, (byte) 107, (byte) 53, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryDataset createCategoryDataset(IComparable rowKey, KeyedValues rowData)
    {
      if (rowKey == null)
      {
        string str = "Null 'rowKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rowData == null)
      {
        string str = "Null 'rowData' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        DefaultCategoryDataset defaultCategoryDataset = new DefaultCategoryDataset();
        for (int i = 0; i < rowData.getItemCount(); ++i)
          defaultCategoryDataset.addValue(rowData.getValue(i), rowKey, rowData.getKey(i));
        return (CategoryDataset) defaultCategoryDataset;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 133, (byte) 142, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYDataset sampleFunction2D(Function2D f, double start, double end, int samples, IComparable seriesKey)
    {
      return (XYDataset) new XYSeriesCollection(DatasetUtilities.sampleFunction2DToSeries(f, start, end, samples, seriesKey));
    }

    [LineNumberTable((ushort) 718)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateDomainBounds(XYDataset dataset)
    {
      return DatasetUtilities.iterateDomainBounds(dataset, true);
    }

    [Obsolete]
    [LineNumberTable((ushort) 934)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateCategoryRangeBounds(CategoryDataset dataset, bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      return DatasetUtilities.iterateRangeBounds(dataset, num != 0);
    }

    [LineNumberTable((ushort) 948)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateRangeBounds(CategoryDataset dataset)
    {
      return DatasetUtilities.iterateRangeBounds(dataset, true);
    }

    [Obsolete]
    [LineNumberTable((ushort) 1154)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range iterateXYRangeBounds(XYDataset dataset)
    {
      return DatasetUtilities.iterateRangeBounds(dataset);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 71, (byte) 99, (byte) 144, (byte) 130, (byte) 104, (byte) 103, (byte) 180, (byte) 106, (byte) 103, (byte) 105, (byte) 105, (byte) 169, (byte) 104, (byte) 136, (byte) 109, (byte) 130, (byte) 140, (byte) 105, (byte) 234, (byte) 52, (byte) 8, (byte) 233, (byte) 83, (byte) 108, (byte) 165, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMinimumDomainValue(XYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dataset is DomainInfo)
      {
        DomainInfo domainInfo = (DomainInfo) dataset;
        Double.__\u003Cclinit\u003E();
        return (Number) new Double(domainInfo.getDomainLowerBound(true));
      }
      else
      {
        double num1 = double.PositiveInfinity;
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double num2 = !(dataset is IntervalXYDataset) ? dataset.getXValue(index, i2) : ((IntervalXYDataset) dataset).getStartXValue(index, i2);
            if (!Double.isNaN(num2))
              num1 = Math.min(num1, num2);
          }
        }
        return num1 != double.PositiveInfinity ? (Number) new Double(num1) : (Number) null;
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 126, (byte) 99, (byte) 144, (byte) 130, (byte) 104, (byte) 103, (byte) 244, (byte) 69, (byte) 106, (byte) 103, (byte) 105, (byte) 105, (byte) 169, (byte) 104, (byte) 136, (byte) 109, (byte) 130, (byte) 140, (byte) 105, (byte) 234, (byte) 52, (byte) 8, (byte) 233, (byte) 82, (byte) 108, (byte) 165, (byte) 232, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMaximumDomainValue(XYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dataset is DomainInfo)
      {
        DomainInfo domainInfo = (DomainInfo) dataset;
        Double.__\u003Cclinit\u003E();
        return (Number) new Double(domainInfo.getDomainUpperBound(true));
      }
      else
      {
        double num1 = double.NegativeInfinity;
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double num2 = !(dataset is IntervalXYDataset) ? dataset.getXValue(index, i2) : ((IntervalXYDataset) dataset).getEndXValue(index, i2);
            if (!Double.isNaN(num2))
              num1 = Math.max(num1, num2);
          }
        }
        return num1 != double.NegativeInfinity ? (Number) new Double(num1) : (Number) null;
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 184, (byte) 99, (byte) 176, (byte) 104, (byte) 103, (byte) 244, (byte) 69, (byte) 106, (byte) 103, (byte) 103, (byte) 107, (byte) 136, (byte) 104, (byte) 136, (byte) 109, (byte) 130, (byte) 140, (byte) 100, (byte) 239, (byte) 53, (byte) 40, (byte) 235, (byte) 80, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMinimumRangeValue(CategoryDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dataset is RangeInfo)
      {
        RangeInfo rangeInfo = (RangeInfo) dataset;
        Double.__\u003Cclinit\u003E();
        return (Number) new Double(rangeInfo.getRangeLowerBound(true));
      }
      else
      {
        double num = double.PositiveInfinity;
        int rowCount = dataset.getRowCount();
        int columnCount = dataset.getColumnCount();
        for (int i1 = 0; i1 < rowCount; ++i1)
        {
          for (int i2 = 0; i2 < columnCount; ++i2)
          {
            Number number = !(dataset is IntervalCategoryDataset) ? dataset.getValue(i1, i2) : ((IntervalCategoryDataset) dataset).getStartValue(i1, i2);
            if (number != null)
              num = Math.min(num, number.doubleValue());
          }
        }
        if (num == double.PositiveInfinity)
          return (Number) null;
        return (Number) new Double(num);
      }
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 239, (byte) 99, (byte) 208, (byte) 104, (byte) 103, (byte) 244, (byte) 69, (byte) 106, (byte) 103, (byte) 105, (byte) 105, (byte) 172, (byte) 104, (byte) 136, (byte) 109, (byte) 98, (byte) 104, (byte) 104, (byte) 109, (byte) 130, (byte) 140, (byte) 105, (byte) 234, (byte) 48, (byte) 11, (byte) 233, (byte) 87, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMinimumRangeValue(XYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dataset is RangeInfo)
      {
        RangeInfo rangeInfo = (RangeInfo) dataset;
        Double.__\u003Cclinit\u003E();
        return (Number) new Double(rangeInfo.getRangeLowerBound(true));
      }
      else
      {
        double num1 = double.PositiveInfinity;
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double num2 = !(dataset is IntervalXYDataset) ? (!(dataset is OHLCDataset) ? dataset.getYValue(index, i2) : ((OHLCDataset) dataset).getLowValue(index, i2)) : ((IntervalXYDataset) dataset).getStartYValue(index, i2);
            if (!Double.isNaN(num2))
              num1 = Math.min(num1, num2);
          }
        }
        if (num1 == double.PositiveInfinity)
          return (Number) null;
        return (Number) new Double(num1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 44, (byte) 99, (byte) 208, (byte) 104, (byte) 103, (byte) 244, (byte) 70, (byte) 106, (byte) 103, (byte) 103, (byte) 107, (byte) 136, (byte) 104, (byte) 136, (byte) 109, (byte) 130, (byte) 140, (byte) 100, (byte) 239, (byte) 53, (byte) 40, (byte) 235, (byte) 80, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMaximumRangeValue(CategoryDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dataset is RangeInfo)
      {
        RangeInfo rangeInfo = (RangeInfo) dataset;
        Double.__\u003Cclinit\u003E();
        return (Number) new Double(rangeInfo.getRangeUpperBound(true));
      }
      else
      {
        double num = double.NegativeInfinity;
        int rowCount = dataset.getRowCount();
        int columnCount = dataset.getColumnCount();
        for (int i1 = 0; i1 < rowCount; ++i1)
        {
          for (int i2 = 0; i2 < columnCount; ++i2)
          {
            Number number = !(dataset is IntervalCategoryDataset) ? dataset.getValue(i1, i2) : ((IntervalCategoryDataset) dataset).getEndValue(i1, i2);
            if (number != null)
              num = Math.max(num, number.doubleValue());
          }
        }
        if (num == double.NegativeInfinity)
          return (Number) null;
        return (Number) new Double(num);
      }
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 100, (byte) 99, (byte) 208, (byte) 104, (byte) 103, (byte) 244, (byte) 70, (byte) 106, (byte) 103, (byte) 105, (byte) 105, (byte) 140, (byte) 104, (byte) 136, (byte) 109, (byte) 98, (byte) 104, (byte) 104, (byte) 109, (byte) 130, (byte) 140, (byte) 105, (byte) 234, (byte) 49, (byte) 11, (byte) 233, (byte) 85, (byte) 108, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMaximumRangeValue(XYDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (dataset is RangeInfo)
      {
        RangeInfo rangeInfo = (RangeInfo) dataset;
        Double.__\u003Cclinit\u003E();
        return (Number) new Double(rangeInfo.getRangeUpperBound(true));
      }
      else
      {
        double num1 = double.NegativeInfinity;
        int seriesCount = dataset.getSeriesCount();
        for (int index = 0; index < seriesCount; ++index)
        {
          int itemCount = dataset.getItemCount(index);
          for (int i2 = 0; i2 < itemCount; ++i2)
          {
            double num2 = !(dataset is IntervalXYDataset) ? (!(dataset is OHLCDataset) ? dataset.getYValue(index, i2) : ((OHLCDataset) dataset).getHighValue(index, i2)) : ((IntervalXYDataset) dataset).getEndYValue(index, i2);
            if (!Double.isNaN(num2))
              num1 = Math.max(num1, num2);
          }
        }
        if (num1 == double.NegativeInfinity)
          return (Number) null;
        return (Number) new Double(num1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 24, (byte) 99, (byte) 144, (byte) 98, (byte) 98, (byte) 102, (byte) 103, (byte) 107, (byte) 103, (byte) 104, (byte) 105, (byte) 108, (byte) 100, (byte) 98, (byte) 106, (byte) 105, (byte) 232, (byte) 58, (byte) 232, (byte) 75, (byte) 234, (byte) 50, (byte) 235, (byte) 80, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMinimumStackedRangeValue(CategoryDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Double @double = (Double) null;
        int num1 = 0;
        double num2 = 0.0;
        int columnCount = dataset.getColumnCount();
        for (int i2 = 0; i2 < columnCount; ++i2)
        {
          double num3 = 0.0;
          int rowCount = dataset.getRowCount();
          for (int i1 = 0; i1 < rowCount; ++i1)
          {
            Number number = dataset.getValue(i1, i2);
            if (number != null)
            {
              num1 = 1;
              double num4 = number.doubleValue();
              if (num4 < 0.0)
                num3 += num4;
            }
          }
          num2 = Math.min(num2, num3);
        }
        if (num1 != 0)
          @double = new Double(num2);
        return (Number) @double;
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 64, (byte) 99, (byte) 144, (byte) 98, (byte) 98, (byte) 102, (byte) 103, (byte) 107, (byte) 103, (byte) 104, (byte) 105, (byte) 108, (byte) 100, (byte) 98, (byte) 106, (byte) 105, (byte) 232, (byte) 58, (byte) 232, (byte) 74, (byte) 234, (byte) 51, (byte) 235, (byte) 79, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number findMaximumStackedRangeValue(CategoryDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Double @double = (Double) null;
        int num1 = 0;
        double num2 = 0.0;
        int columnCount = dataset.getColumnCount();
        for (int i2 = 0; i2 < columnCount; ++i2)
        {
          double num3 = 0.0;
          int rowCount = dataset.getRowCount();
          for (int i1 = 0; i1 < rowCount; ++i1)
          {
            Number number = dataset.getValue(i1, i2);
            if (number != null)
            {
              num1 = 1;
              double num4 = number.doubleValue();
              if (num4 > 0.0)
                num3 += num4;
            }
          }
          num2 = Math.max(num2, num3);
        }
        if (num1 != 0)
          @double = new Double(num2);
        return (Number) @double;
      }
    }

    [LineNumberTable(new byte[] {(byte) 167, (byte) 184, (byte) 99, (byte) 144, (byte) 130, (byte) 102, (byte) 102, (byte) 110, (byte) 103, (byte) 146, (byte) 107, (byte) 100, (byte) 98, (byte) 106, (byte) 105, (byte) 104, (byte) 106, (byte) 234, (byte) 56, (byte) 235, (byte) 61, (byte) 233, (byte) 80, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range findCumulativeRangeBounds(CategoryDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num1 = 1;
        double lower = 0.0;
        double upper = 0.0;
        for (int i1 = 0; i1 < dataset.getRowCount(); ++i1)
        {
          double num2 = 0.0;
          for (int i2 = 0; i2 <= dataset.getColumnCount() - 1; ++i2)
          {
            Number number = dataset.getValue(i1, i2);
            if (number != null)
            {
              num1 = 0;
              double num3 = number.doubleValue();
              if (!Double.isNaN(num3))
              {
                num2 += num3;
                lower = Math.min(lower, num2);
                upper = Math.max(upper, num2);
              }
            }
          }
        }
        if (num1 != 0)
          return (Range) null;
        return new Range(lower, upper);
      }
    }
  }
}
