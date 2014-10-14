// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.MovingAverage
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.time
{
  public class MovingAverage : Object
  {
    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MovingAverage()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 99, (byte) 144, (byte) 100, (byte) 240, (byte) 69, (byte) 135, (byte) 236, (byte) 69, (byte) 181, (byte) 176, (byte) 104, (byte) 104, (byte) 137, (byte) 136, (byte) 99, (byte) 103, (byte) 108, (byte) 99, (byte) 131, (byte) 111, (byte) 103, (byte) 140, (byte) 105, (byte) 105, (byte) 105, (byte) 102, (byte) 100, (byte) 109, (byte) 200, (byte) 163, (byte) 139, (byte) 101, (byte) 176, (byte) 233, (byte) 26, (byte) 233, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TimeSeries createMovingAverage(TimeSeries source, string name, int periodCount, int skip)
    {
      if (source == null)
      {
        string str = "Null source.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (periodCount < 1)
      {
        string str = "periodCount must be greater than or equal to 1.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TimeSeries timeSeries = new TimeSeries((IComparable) name);
        if (source.getItemCount() > 0)
        {
          long num1 = source.getDataItem(0).getPeriod().getSerialIndex() + (long) skip;
          int index1 = source.getItemCount() - 1;
          while (index1 >= 0)
          {
            RegularTimePeriod period1 = source.getDataItem(index1).getPeriod();
            if (period1.getSerialIndex() >= num1)
            {
              int num2 = 0;
              double num3 = 0.0;
              long num4 = period1.getSerialIndex() - (long) periodCount;
              int num5 = 0;
              for (int index2 = 0; num5 < periodCount && index2 == 0; ++num5)
              {
                if (index1 - num5 >= 0)
                {
                  TimeSeriesDataItem dataItem = source.getDataItem(index1 - num5);
                  RegularTimePeriod period2 = dataItem.getPeriod();
                  Number number = dataItem.getValue();
                  if (period2.getSerialIndex() > num4)
                  {
                    if (number != null)
                    {
                      num3 += number.doubleValue();
                      ++num2;
                    }
                  }
                  else
                    index2 = 1;
                }
              }
              if (num2 > 0)
                timeSeries.add(period1, num3 / (double) num2);
              else
                timeSeries.add(period1, (Number) null);
            }
            index1 += -1;
          }
        }
        return timeSeries;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 99, (byte) 176, (byte) 134, (byte) 107, (byte) 159, (byte) 9, (byte) 231, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYDataset createMovingAverage(XYDataset source, string suffix, double period, double skip)
    {
      if (source == null)
      {
        string str = "Null source (XYDataset).";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        XYSeriesCollection seriesCollection = new XYSeriesCollection();
        for (int index = 0; index < source.getSeriesCount(); ++index)
        {
          XYSeries movingAverage = MovingAverage.createMovingAverage(source, index, new StringBuffer().append((object) source.getSeriesKey(index)).append(suffix).toString(), period, skip);
          seriesCollection.addSeries(movingAverage);
        }
        return (XYDataset) seriesCollection;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 99, (byte) 144, (byte) 109, (byte) 144, (byte) 106, (byte) 208, (byte) 135, (byte) 205, (byte) 142, (byte) 177, (byte) 138, (byte) 135, (byte) 99, (byte) 103, (byte) 103, (byte) 99, (byte) 131, (byte) 103, (byte) 103, (byte) 110, (byte) 109, (byte) 102, (byte) 100, (byte) 109, (byte) 200, (byte) 131, (byte) 130, (byte) 131, (byte) 139, (byte) 101, (byte) 175, (byte) 232, (byte) 28, (byte) 233, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYSeries createMovingAverage(XYDataset source, int series, string name, double period, double skip)
    {
      if (source == null)
      {
        string str = "Null source (XYDataset).";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (period < 4.94065645841247E-324)
      {
        string str = "period must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (skip < 0.0)
      {
        string str = "skip must be >= 0.0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        XYSeries xySeries = new XYSeries((IComparable) name);
        if (source.getItemCount(series) > 0)
        {
          double num1 = source.getXValue(series, 0) + skip;
          int i2 = source.getItemCount(series) - 1;
          while (i2 >= 0)
          {
            double xvalue1 = source.getXValue(series, i2);
            if (xvalue1 >= num1)
            {
              int num2 = 0;
              double num3 = 0.0;
              double num4 = xvalue1 - period;
              int num5 = 0;
              int num6 = 0;
              while (num6 == 0)
              {
                if (i2 - num5 >= 0)
                {
                  double xvalue2 = source.getXValue(series, i2 - num5);
                  Number y = source.getY(series, i2 - num5);
                  if (xvalue2 > num4)
                  {
                    if (y != null)
                    {
                      num3 += y.doubleValue();
                      ++num2;
                    }
                  }
                  else
                    num6 = 1;
                }
                else
                  num6 = 1;
                ++num5;
              }
              if (num2 > 0)
                xySeries.add(xvalue1, num3 / (double) num2);
              else
                xySeries.add(xvalue1, (Number) null);
            }
            i2 += -1;
          }
        }
        return xySeries;
      }
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 99, (byte) 144, (byte) 100, (byte) 208, (byte) 102, (byte) 107, (byte) 104, (byte) 159, (byte) 5, (byte) 231, (byte) 60, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TimeSeriesCollection createMovingAverage(TimeSeriesCollection source, string suffix, int periodCount, int skip)
    {
      if (source == null)
      {
        string str = "Null 'source' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (periodCount < 1)
      {
        string str = "periodCount must be greater than or equal to 1.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TimeSeriesCollection seriesCollection = new TimeSeriesCollection();
        for (int series1 = 0; series1 < source.getSeriesCount(); ++series1)
        {
          TimeSeries series2 = source.getSeries(series1);
          TimeSeries movingAverage = MovingAverage.createMovingAverage(series2, new StringBuffer().append((object) series2.getKey()).append(suffix).toString(), periodCount, skip);
          seriesCollection.addSeries(movingAverage);
        }
        return seriesCollection;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 99, (byte) 144, (byte) 100, (byte) 208, (byte) 103, (byte) 102, (byte) 142, (byte) 104, (byte) 104, (byte) 143, (byte) 134, (byte) 139, (byte) 144, (byte) 108, (byte) 98, (byte) 102, (byte) 236, (byte) 49, (byte) 233, (byte) 82})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TimeSeries createPointMovingAverage(TimeSeries source, string name, int pointCount)
    {
      if (source == null)
      {
        string str = "Null 'source'.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (pointCount < 2)
      {
        string str = "periodCount must be greater than or equal to 2.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        TimeSeries timeSeries = new TimeSeries((IComparable) name);
        double num = 0.0;
        for (int index = 0; index < source.getItemCount(); ++index)
        {
          TimeSeriesDataItem dataItem1 = source.getDataItem(index);
          RegularTimePeriod period = dataItem1.getPeriod();
          num += dataItem1.getValue().doubleValue();
          if (index > pointCount - 1)
          {
            TimeSeriesDataItem dataItem2 = source.getDataItem(index - pointCount);
            num -= dataItem2.getValue().doubleValue();
            timeSeries.add(period, num / (double) pointCount);
          }
          else if (index == pointCount - 1)
            timeSeries.add(period, num / (double) pointCount);
        }
        return timeSeries;
      }
    }

    [LineNumberTable((ushort) 244)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYDataset createMovingAverage(XYDataset source, string suffix, long period, long skip)
    {
      return MovingAverage.createMovingAverage(source, suffix, (double) period, (double) skip);
    }
  }
}
