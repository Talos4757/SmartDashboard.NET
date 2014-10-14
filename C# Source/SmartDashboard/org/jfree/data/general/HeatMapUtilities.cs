// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.HeatMapUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.image;
using java.lang;
using org.jfree.chart.renderer;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.general
{
  public abstract class HeatMapUtilities : Object
  {
    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HeatMapUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 103, (byte) 103, (byte) 102, (byte) 53, (byte) 166, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYDataset extractRowFromHeatMapDataset(HeatMapDataset dataset, int row, IComparable seriesName)
    {
      XYSeries series = new XYSeries(seriesName);
      int xsampleCount = dataset.getXSampleCount();
      for (int index = 0; index < xsampleCount; ++index)
        series.add(dataset.getXValue(index), dataset.getZValue(index, row));
      return (XYDataset) new XYSeriesCollection(series);
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 103, (byte) 103, (byte) 102, (byte) 53, (byte) 166, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static XYDataset extractColumnFromHeatMapDataset(HeatMapDataset dataset, int column, IComparable seriesName)
    {
      XYSeries series = new XYSeries(seriesName);
      int ysampleCount = dataset.getYSampleCount();
      for (int index = 0; index < ysampleCount; ++index)
        series.add(dataset.getYValue(index), dataset.getZValue(column, index));
      return (XYDataset) new XYSeriesCollection(series);
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 137, (byte) 103, (byte) 104, (byte) 104, (byte) 109, (byte) 106, (byte) 104, (byte) 240, (byte) 60, (byte) 40, (byte) 235, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BufferedImage createHeatMapImage(HeatMapDataset dataset, PaintScale paintScale)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (paintScale == null)
      {
        string str = "Null 'paintScale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int xsampleCount = dataset.getXSampleCount();
        int ysampleCount = dataset.getYSampleCount();
        BufferedImage bufferedImage = new BufferedImage(xsampleCount, ysampleCount, 2);
        Graphics2D graphics = bufferedImage.createGraphics();
        for (int i1 = 0; i1 < xsampleCount; ++i1)
        {
          for (int i2 = 0; i2 < ysampleCount; ++i2)
          {
            double zvalue = dataset.getZValue(i1, i2);
            Paint paint = paintScale.getPaint(zvalue);
            graphics.setPaint(paint);
            ((Graphics) graphics).fillRect(i1, ysampleCount - i2 - 1, 1, 1);
          }
        }
        return bufferedImage;
      }
    }
  }
}
