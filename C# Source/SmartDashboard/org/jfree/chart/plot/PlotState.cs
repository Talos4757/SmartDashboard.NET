// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.PlotState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.plot
{
  public class PlotState : Object
  {
    private Map sharedAxisStates;

    [LineNumberTable(new byte[] {(byte) 7, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlotState()
    {
      base.\u002Ector();
      PlotState plotState = this;
      this.sharedAxisStates = (Map) new HashMap();
    }

    public virtual Map getSharedAxisStates()
    {
      return this.sharedAxisStates;
    }
  }
}
