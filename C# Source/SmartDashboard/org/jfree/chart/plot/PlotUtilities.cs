// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PlotUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.general;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.plot
{
  public class PlotUtilities : Object
  {
    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlotUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 99, (byte) 109, (byte) 104, (byte) 104, (byte) 226, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isEmptyOrNull(XYPlot plot)
    {
      if (plot != null)
      {
        int index = 0;
        for (int datasetCount = plot.getDatasetCount(); index < datasetCount; ++index)
        {
          if (!DatasetUtilities.isEmptyOrNull(plot.getDataset(index)))
            return false;
        }
      }
      return true;
    }
  }
}
