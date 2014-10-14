// Decompiled with JetBrains decompiler
// Type: org.jfree.data.gantt.GanttCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using System;

namespace org.jfree.data.gantt
{
  [Implements(new string[] {"org.jfree.data.category.IntervalCategoryDataset"})]
  public interface GanttCategoryDataset : IntervalCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    int getSubIntervalCount(int i1, int i2);

    Number getStartValue(int i1, int i2, int i3);

    Number getEndValue(int i1, int i2, int i3);

    Number getPercentComplete(int i1, int i2, int i3);

    Number getPercentComplete(int i1, int i2);

    Number getPercentComplete(IComparable c1, IComparable c2);

    int getSubIntervalCount(IComparable c1, IComparable c2);

    Number getStartValue(IComparable c1, IComparable c2, int i);

    Number getEndValue(IComparable c1, IComparable c2, int i);

    Number getPercentComplete(IComparable c1, IComparable c2, int i);
  }
}
