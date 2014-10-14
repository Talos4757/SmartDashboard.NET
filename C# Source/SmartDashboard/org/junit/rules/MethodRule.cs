// Decompiled with JetBrains decompiler
// Type: org.junit.rules.MethodRule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using org.junit.runners.model;

namespace org.junit.rules
{
  public interface MethodRule
  {
    Statement apply(Statement s, FrameworkMethod fm, object obj);
  }
}
