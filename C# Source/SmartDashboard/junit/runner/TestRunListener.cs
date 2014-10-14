// Decompiled with JetBrains decompiler
// Type: junit.runner.TestRunListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;

namespace junit.runner
{
  public interface TestRunListener
  {
    const int STATUS_ERROR = 1;
    const int STATUS_FAILURE = 2;

    void testRunStarted(string str, int i);

    void testRunEnded(long l);

    void testRunStopped(long l);

    void testStarted(string str);

    void testEnded(string str);

    void testFailed(int i, string str1, string str2);

    [HideFromJava]
    static class __Fields
    {
      public const int STATUS_ERROR = 1;
      public const int STATUS_FAILURE = 2;
    }
  }
}
