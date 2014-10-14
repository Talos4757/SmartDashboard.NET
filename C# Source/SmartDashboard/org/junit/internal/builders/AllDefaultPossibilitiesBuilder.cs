// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.AllDefaultPossibilitiesBuilder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.@internal.builders;
using org.junit.runner;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.builders
{
  public class AllDefaultPossibilitiesBuilder : RunnerBuilder
  {
    [Modifiers]
    private bool fCanUseSuiteMethod;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 139, (byte) 162, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AllDefaultPossibilitiesBuilder(bool canUseSuiteMethod)
    {
      int num = canUseSuiteMethod ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      AllDefaultPossibilitiesBuilder possibilitiesBuilder = this;
      this.fCanUseSuiteMethod = num != 0;
    }

    [LineNumberTable((ushort) 49)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual IgnoredBuilder ignoredBuilder()
    {
      return new IgnoredBuilder();
    }

    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AnnotatedBuilder annotatedBuilder()
    {
      return new AnnotatedBuilder((RunnerBuilder) this);
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual RunnerBuilder suiteMethodBuilder()
    {
      if (this.fCanUseSuiteMethod)
        return (RunnerBuilder) new SuiteMethodBuilder();
      else
        return (RunnerBuilder) new NullBuilder();
    }

    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual JUnit3Builder junit3Builder()
    {
      return new JUnit3Builder();
    }

    [LineNumberTable((ushort) 37)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual JUnit4Builder junit4Builder()
    {
      return new JUnit4Builder();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 255, (byte) 26, (byte) 71, (byte) 123, (byte) 104, (byte) 99, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass(Class testClass)
    {
      RunnerBuilder[] runnerBuilderArray = new RunnerBuilder[5];
      int index1 = 0;
      IgnoredBuilder ignoredBuilder = this.ignoredBuilder();
      runnerBuilderArray[index1] = (RunnerBuilder) ignoredBuilder;
      int index2 = 1;
      AnnotatedBuilder annotatedBuilder = this.annotatedBuilder();
      runnerBuilderArray[index2] = (RunnerBuilder) annotatedBuilder;
      int index3 = 2;
      RunnerBuilder runnerBuilder = this.suiteMethodBuilder();
      runnerBuilderArray[index3] = runnerBuilder;
      int index4 = 3;
      JUnit3Builder junit3Builder = this.junit3Builder();
      runnerBuilderArray[index4] = (RunnerBuilder) junit3Builder;
      int index5 = 4;
      JUnit4Builder junit4Builder = this.junit4Builder();
      runnerBuilderArray[index5] = (RunnerBuilder) junit4Builder;
      Iterator iterator = Arrays.asList((object[]) runnerBuilderArray).iterator();
      while (iterator.hasNext())
      {
        Runner runner = ((RunnerBuilder) iterator.next()).safeRunnerForClass(testClass);
        if (runner != null)
          return runner;
      }
      return (Runner) null;
    }
  }
}
