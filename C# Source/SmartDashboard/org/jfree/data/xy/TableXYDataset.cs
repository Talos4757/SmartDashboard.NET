// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.TableXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data.general;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset"})]
  public interface TableXYDataset : XYDataset, SeriesDataset, Dataset
  {
    int getItemCount();
  }
}
