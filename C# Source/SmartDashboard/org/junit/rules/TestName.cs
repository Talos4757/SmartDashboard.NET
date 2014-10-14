// Decompiled with JetBrains decompiler
// Type: org.junit.rules.TestName
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.rules
{
  public class TestName : TestWatchman
  {
    private string fName;

    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestName()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void starting(FrameworkMethod method)
    {
      this.fName = method.getName();
    }

    public virtual string getMethodName()
    {
      return this.fName;
    }
  }
}
