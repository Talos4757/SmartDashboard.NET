// Decompiled with JetBrains decompiler
// Type: org.jfree.data.contour.ContourDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using System;

namespace org.jfree.data.contour
{
  [Implements(new string[] {"org.jfree.data.xy.XYZDataset"})]
  [Obsolete]
  public interface ContourDataset : XYZDataset, XYDataset, SeriesDataset, Dataset
  {
    double getMinZValue();

    double getMaxZValue();

    bool isDateAxis(int i);

    Number[] getXValues();

    Number[] getYValues();

    Number[] getZValues();

    int[] indexX();

    int[] getXIndices();

    Range getZValueRange(Range r1, Range r2);
  }
}
