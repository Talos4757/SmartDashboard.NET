// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.EntityCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.util;

namespace org.jfree.chart.entity
{
  public interface EntityCollection
  {
    ChartEntity getEntity(double d1, double d2);

    void clear();

    void add(ChartEntity ce);

    void addAll(EntityCollection ec);

    ChartEntity getEntity(int i);

    int getEntityCount();

    Collection getEntities();

    Iterator iterator();
  }
}
