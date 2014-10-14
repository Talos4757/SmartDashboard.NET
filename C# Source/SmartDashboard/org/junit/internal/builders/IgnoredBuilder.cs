// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.IgnoredBuilder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using org.junit;
using org.junit.@internal.builders;
using org.junit.runner;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.builders
{
  public class IgnoredBuilder : RunnerBuilder
  {
    [LineNumberTable((ushort) 10)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IgnoredBuilder()
    {
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass(Class testClass)
    {
      if (testClass.getAnnotation((Class) ClassLiteral<Ignore>.Value) == null)
        return (Runner) null;
      return (Runner) new IgnoredClassRunner(testClass);
    }
  }
}
