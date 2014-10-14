// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.ParallelComputer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner;
using org.junit.runners;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental
{
  public class ParallelComputer : Computer
  {
    [Modifiers]
    private bool fClasses;
    [Modifiers]
    private bool fMethods;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 137, (byte) 132, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParallelComputer(bool classes, bool methods)
    {
      int num1 = classes ? 1 : 0;
      int num2 = methods ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      ParallelComputer parallelComputer = this;
      this.fClasses = num1 != 0;
      this.fMethods = num2 != 0;
    }

    [Signature("<T:Ljava/lang/Object;>(Lorg/junit/runner/Runner;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 104, (byte) 240, (byte) 89})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Runner parallelize([In] Runner obj0)
    {
      if (obj0 is ParentRunner)
        ((ParentRunner) obj0).setScheduler((RunnerScheduler) new ParallelComputer\u00241());
      return obj0;
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Computer classes()
    {
      return (Computer) new ParallelComputer(true, false);
    }

    [LineNumberTable((ushort) 32)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Computer methods()
    {
      return (Computer) new ParallelComputer(false, true);
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Lorg/junit/runners/model/RunnerBuilder;[Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 18, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner getSuite(RunnerBuilder builder, Class[] classes)
    {
      Runner suite = base.getSuite(builder, classes);
      if (this.fClasses)
        return ParallelComputer.parallelize(suite);
      else
        return suite;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Lorg/junit/runners/model/RunnerBuilder;Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 25, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Runner getRunner(RunnerBuilder builder, Class testClass)
    {
      Runner runner = base.getRunner(builder, testClass);
      if (this.fMethods)
        return ParallelComputer.parallelize(runner);
      else
        return runner;
    }
  }
}
