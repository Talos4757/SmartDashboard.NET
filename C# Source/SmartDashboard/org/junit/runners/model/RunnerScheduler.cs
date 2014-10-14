// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.RunnerScheduler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.lang;

namespace org.junit.runners.model
{
  public interface RunnerScheduler
  {
    void schedule(Runnable r);

    void finished();
  }
}
