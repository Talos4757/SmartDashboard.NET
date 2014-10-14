// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.JUnit4Builder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner;
using org.junit.runners;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.builders
{
  public class JUnit4Builder : RunnerBuilder
  {
    [LineNumberTable((ushort) 10)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit4Builder()
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable((ushort) 13)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass(Class testClass)
    {
      return (Runner) new BlockJUnit4ClassRunner(testClass);
    }
  }
}
