﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.dial.DialScale
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;

namespace org.jfree.chart.plot.dial
{
  [Implements(new string[] {"org.jfree.chart.plot.dial.DialLayer"})]
  public interface DialScale : DialLayer
  {
    double valueToAngle(double d);

    double angleToValue(double d);
  }
}
