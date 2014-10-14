// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.JUnit3Builder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using junit.framework;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.builders
{
  public class JUnit3Builder : RunnerBuilder
  {
    [LineNumberTable((ushort) 10)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit3Builder()
    {
    }

    [Signature("(Ljava/lang/Class<*>;)Z")]
    [LineNumberTable((ushort) 19)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual bool isPre4Test([In] Class obj0)
    {
      return (((Class) ClassLiteral<TestCase>.Value).isAssignableFrom(obj0) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass(Class testClass)
    {
      if (!this.isPre4Test(testClass))
        return (Runner) null;
      return (Runner) new JUnit38ClassRunner(testClass);
    }
  }
}
