// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.Timeline
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.util;

namespace org.jfree.chart.axis
{
  public interface Timeline
  {
    bool containsDomainValue(Date d);

    long toTimelineValue(long l);

    long toMillisecond(long l);

    long toTimelineValue(Date d);

    bool containsDomainValue(long l);

    bool containsDomainRange(long l1, long l2);

    bool containsDomainRange(Date d1, Date d2);
  }
}
