// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.RunBefores
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners.statements
{
  public class RunBefores : Statement
  {
    [Modifiers]
    private Statement fNext;
    [Modifiers]
    private object fTarget;
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;")]
    private List fBefores;

    [Signature("(Lorg/junit/runners/model/Statement;Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;Ljava/lang/Object;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RunBefores(Statement next, List befores, object target)
    {
      RunBefores runBefores = this;
      this.fNext = next;
      this.fBefores = befores;
      this.fTarget = target;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 127, (byte) 1, (byte) 117, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      Iterator iterator = this.fBefores.iterator();
      while (iterator.hasNext())
        ((FrameworkMethod) iterator.next()).invokeExplosively(this.fTarget);
      this.fNext.evaluate();
    }
  }
}
