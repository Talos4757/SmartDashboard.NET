// Decompiled with JetBrains decompiler
// Type: org.jfree.data.category.IntervalCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.general;
using System;

namespace org.jfree.data.category
{
  [Implements(new string[] {"org.jfree.data.category.CategoryDataset"})]
  public interface IntervalCategoryDataset : CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    Number getStartValue(int i1, int i2);

    Number getEndValue(int i1, int i2);

    Number getStartValue(IComparable c1, IComparable c2);

    Number getEndValue(IComparable c1, IComparable c2);
  }
}
