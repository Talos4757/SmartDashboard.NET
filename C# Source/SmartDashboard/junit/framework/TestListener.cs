﻿// Decompiled with JetBrains decompiler
// Type: junit.framework.TestListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using System;

namespace junit.framework
{
  public interface TestListener
  {
    void addError(Test t1, Exception t2);

    void addFailure(Test t, AssertionFailedError afe);

    void endTest(Test t);

    void startTest(Test t);
  }
}
