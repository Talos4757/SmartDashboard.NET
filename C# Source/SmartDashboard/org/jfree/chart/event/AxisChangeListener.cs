﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.event.AxisChangeListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.jfree.chart.@event;

namespace org.jfree.chart.@event
{
  [Implements(new string[] {"java.util.EventListener"})]
  public interface AxisChangeListener : EventListener
  {
    void axisChanged(AxisChangeEvent ace);
  }
}
