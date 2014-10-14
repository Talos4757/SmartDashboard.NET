// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.PieSectionLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.text;
using org.jfree.data.general;
using System;

namespace org.jfree.chart.labels
{
  public interface PieSectionLabelGenerator
  {
    string generateSectionLabel(PieDataset pd, IComparable c);

    AttributedString generateAttributedSectionLabel(PieDataset pd, IComparable c);
  }
}
