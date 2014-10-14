// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.BoxAndWhiskerCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using System;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"org.jfree.data.category.CategoryDataset"})]
  public interface BoxAndWhiskerCategoryDataset : CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    Number getMeanValue(int i1, int i2);

    Number getMedianValue(int i1, int i2);

    Number getMinRegularValue(int i1, int i2);

    Number getMaxRegularValue(int i1, int i2);

    Number getQ1Value(int i1, int i2);

    Number getQ3Value(int i1, int i2);

    List getOutliers(int i1, int i2);

    Number getMinOutlier(int i1, int i2);

    Number getMaxOutlier(int i1, int i2);

    Number getMeanValue(IComparable c1, IComparable c2);

    Number getMedianValue(IComparable c1, IComparable c2);

    Number getQ1Value(IComparable c1, IComparable c2);

    Number getQ3Value(IComparable c1, IComparable c2);

    Number getMinRegularValue(IComparable c1, IComparable c2);

    Number getMaxRegularValue(IComparable c1, IComparable c2);

    Number getMinOutlier(IComparable c1, IComparable c2);

    Number getMaxOutlier(IComparable c1, IComparable c2);

    List getOutliers(IComparable c1, IComparable c2);
  }
}
