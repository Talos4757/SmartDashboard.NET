// Decompiled with JetBrains decompiler
// Type: org.jfree.data.category.CategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data;
using org.jfree.data.general;

namespace org.jfree.data.category
{
  [Implements(new string[] {"org.jfree.data.KeyedValues2D", "org.jfree.data.general.Dataset"})]
  public interface CategoryDataset : KeyedValues2D, Values2D, Dataset
  {
  }
}
