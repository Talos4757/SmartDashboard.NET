// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.XYZToolTipGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data.xy;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYToolTipGenerator"})]
  public interface XYZToolTipGenerator : XYToolTipGenerator
  {
    string generateToolTip(XYZDataset xyzd, int i1, int i2);
  }
}
