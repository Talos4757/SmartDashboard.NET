// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimePeriod
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.lang.Comparable"})]
  public interface TimePeriod : Comparable
  {
    Date getStart();

    Date getEnd();
  }
}
