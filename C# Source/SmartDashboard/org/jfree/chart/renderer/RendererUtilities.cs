// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.RendererUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.xy;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.renderer
{
  public class RendererUtilities : Object
  {
    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RendererUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 108, (byte) 108, (byte) 100, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int[] findLiveItems(XYDataset dataset, int series, double xLow, double xHigh)
    {
      int num1 = RendererUtilities.findLiveItemsLowerBound(dataset, series, xLow, xHigh);
      int liveItemsUpperBound = RendererUtilities.findLiveItemsUpperBound(dataset, series, xLow, xHigh);
      if (num1 > liveItemsUpperBound)
        num1 = liveItemsUpperBound;
      int[] numArray = new int[2];
      int index1 = 0;
      int num2 = num1;
      numArray[index1] = num2;
      int index2 = 1;
      int num3 = liveItemsUpperBound;
      numArray[index2] = num3;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 99, (byte) 144, (byte) 102, (byte) 144, (byte) 104, (byte) 100, (byte) 130, (byte) 176, (byte) 98, (byte) 100, (byte) 106, (byte) 133, (byte) 130, (byte) 107, (byte) 134, (byte) 130, (byte) 102, (byte) 103, (byte) 108, (byte) 102, (byte) 165, (byte) 131, (byte) 98, (byte) 130, (byte) 176, (byte) 98, (byte) 100, (byte) 106, (byte) 101, (byte) 130, (byte) 107, (byte) 102, (byte) 130, (byte) 102, (byte) 103, (byte) 108, (byte) 102, (byte) 165, (byte) 131, (byte) 102, (byte) 98, (byte) 226, (byte) 70, (byte) 130, (byte) 107, (byte) 112, (byte) 100, (byte) 100, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int findLiveItemsLowerBound(XYDataset dataset, int series, double xLow, double xHigh)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (xLow >= xHigh)
      {
        string str = "Requires xLow < xHigh.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int itemCount = dataset.getItemCount(series);
        if (itemCount <= 1)
          return 0;
        if (dataset.getDomainOrder() == DomainOrder.__\u003C\u003EASCENDING)
        {
          int i2_1 = 0;
          int i2_2 = itemCount - 1;
          if (dataset.getXValue(series, i2_1) >= xLow)
            return i2_1;
          if (dataset.getXValue(series, i2_2) < xLow)
            return i2_2;
          while (i2_2 - i2_1 > 1)
          {
            int i2_3 = (i2_1 + i2_2) / 2;
            if (dataset.getXValue(series, i2_3) >= xLow)
              i2_2 = i2_3;
            else
              i2_1 = i2_3;
          }
          return i2_2;
        }
        else if (dataset.getDomainOrder() == DomainOrder.__\u003C\u003EDESCENDING)
        {
          int i2_1 = 0;
          int i2_2 = itemCount - 1;
          if (dataset.getXValue(series, i2_1) <= xHigh)
            return i2_1;
          if (dataset.getXValue(series, i2_2) > xHigh)
            return i2_2;
          while (i2_2 - i2_1 > 1)
          {
            int i2_3 = (i2_1 + i2_2) / 2;
            if (dataset.getXValue(series, i2_3) > xHigh)
              i2_1 = i2_3;
            else
              i2_2 = i2_3;
            int num = (i2_1 + i2_2) / 2;
          }
          return i2_2;
        }
        else
        {
          int i2 = 0;
          double xvalue = dataset.getXValue(series, i2);
          while (i2 < itemCount && (xvalue < xLow || xvalue > xHigh))
          {
            ++i2;
            if (i2 < itemCount)
              xvalue = dataset.getXValue(series, i2);
          }
          return Math.min(Math.max(0, i2), itemCount - 1);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 99, (byte) 144, (byte) 102, (byte) 144, (byte) 104, (byte) 100, (byte) 130, (byte) 112, (byte) 98, (byte) 100, (byte) 106, (byte) 101, (byte) 130, (byte) 107, (byte) 102, (byte) 130, (byte) 103, (byte) 102, (byte) 108, (byte) 102, (byte) 165, (byte) 131, (byte) 103, (byte) 98, (byte) 131, (byte) 176, (byte) 98, (byte) 100, (byte) 103, (byte) 107, (byte) 102, (byte) 130, (byte) 107, (byte) 102, (byte) 130, (byte) 102, (byte) 108, (byte) 102, (byte) 165, (byte) 131, (byte) 103, (byte) 98, (byte) 227, (byte) 70, (byte) 132, (byte) 107, (byte) 112, (byte) 100, (byte) 100, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int findLiveItemsUpperBound(XYDataset dataset, int series, double xLow, double xHigh)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (xLow >= xHigh)
      {
        string str = "Requires xLow < xHigh.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int itemCount = dataset.getItemCount(series);
        if (itemCount <= 1)
          return 0;
        if (dataset.getDomainOrder() == DomainOrder.__\u003C\u003EASCENDING)
        {
          int i2_1 = 0;
          int i2_2 = itemCount - 1;
          if (dataset.getXValue(series, i2_1) > xHigh)
            return i2_1;
          if (dataset.getXValue(series, i2_2) <= xHigh)
            return i2_2;
          int i2_3 = (i2_1 + i2_2) / 2;
          while (i2_2 - i2_1 > 1)
          {
            if (dataset.getXValue(series, i2_3) <= xHigh)
              i2_1 = i2_3;
            else
              i2_2 = i2_3;
            i2_3 = (i2_1 + i2_2) / 2;
          }
          return i2_3;
        }
        else if (dataset.getDomainOrder() == DomainOrder.__\u003C\u003EDESCENDING)
        {
          int i2_1 = 0;
          int i2_2 = itemCount - 1;
          int i2_3 = (i2_1 + i2_2) / 2;
          if (dataset.getXValue(series, i2_1) < xLow)
            return i2_1;
          if (dataset.getXValue(series, i2_2) >= xLow)
            return i2_2;
          while (i2_2 - i2_1 > 1)
          {
            if (dataset.getXValue(series, i2_3) >= xLow)
              i2_1 = i2_3;
            else
              i2_2 = i2_3;
            i2_3 = (i2_1 + i2_2) / 2;
          }
          return i2_3;
        }
        else
        {
          int i2 = itemCount - 1;
          double xvalue = dataset.getXValue(series, i2);
          while (i2 >= 0 && (xvalue < xLow || xvalue > xHigh))
          {
            i2 += -1;
            if (i2 >= 0)
              xvalue = dataset.getXValue(series, i2);
          }
          return Math.max(i2, 0);
        }
      }
    }
  }
}
