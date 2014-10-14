// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.StatisticalCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using System;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"org.jfree.data.category.CategoryDataset"})]
  public interface StatisticalCategoryDataset : CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    Number getMeanValue(int i1, int i2);

    Number getStdDevValue(int i1, int i2);

    Number getMeanValue(IComparable c1, IComparable c2);

    Number getStdDevValue(IComparable c1, IComparable c2);
  }
}
