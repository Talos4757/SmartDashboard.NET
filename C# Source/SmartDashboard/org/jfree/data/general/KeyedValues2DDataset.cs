// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.KeyedValues2DDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data;
using org.jfree.data.category;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.category.CategoryDataset"})]
  public interface KeyedValues2DDataset : CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
  }
}
