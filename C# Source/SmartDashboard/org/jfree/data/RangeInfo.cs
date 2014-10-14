// Decompiled with JetBrains decompiler
// Type: org.jfree.data.RangeInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

namespace org.jfree.data
{
  public interface RangeInfo
  {
    double getRangeLowerBound(bool b);

    double getRangeUpperBound(bool b);

    Range getRangeBounds(bool b);
  }
}
