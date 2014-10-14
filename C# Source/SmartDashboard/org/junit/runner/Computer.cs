// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Computer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runners;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.runner
{
  public class Computer : Object
  {
    [LineNumberTable((ushort) 12)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Computer()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 17)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Computer serial()
    {
      return new Computer();
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Lorg/junit/runners/model/RunnerBuilder;[Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Runner getSuite(RunnerBuilder builder, Class[] classes)
    {
      return (Runner) new Suite((RunnerBuilder) new Computer\u00241(this, builder), classes);
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Lorg/junit/runners/model/RunnerBuilder;Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Runner getRunner(RunnerBuilder builder, Class testClass)
    {
      return builder.runnerForClass(testClass);
    }
  }
}
