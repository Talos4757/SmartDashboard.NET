// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.ContourPlotUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.contour;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.plot
{
  [Obsolete]
  public abstract class ContourPlotUtilities : Object
  {
    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContourPlotUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 98, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Range visibleRange(ContourDataset data, Range x, Range y)
    {
      return ((DefaultContourDataset) data).getZValueRange(x, y);
    }
  }
}
