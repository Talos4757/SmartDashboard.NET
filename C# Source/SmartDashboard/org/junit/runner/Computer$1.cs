// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Computer$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner
{
  [InnerClass]
  [EnclosingMethod("org.junit.runner.Computer", "getSuite", "(Lorg.junit.runners.model.RunnerBuilder;[Ljava.lang.Class;)Lorg.junit.runner.Runner;")]
  [SourceFile("Computer.java")]
  [Modifiers]
  internal sealed class Computer\u00241 : RunnerBuilder
  {
    [Modifiers]
    internal Computer this\u00240 = obj0;
    [Modifiers]
    internal RunnerBuilder val\u0024builder = obj1;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Computer\u00241([In] Computer obj0, [In] RunnerBuilder obj1)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable((ushort) 29)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass([In] Class obj0)
    {
      return this.this\u00240.getRunner(this.val\u0024builder, obj0);
    }
  }
}
