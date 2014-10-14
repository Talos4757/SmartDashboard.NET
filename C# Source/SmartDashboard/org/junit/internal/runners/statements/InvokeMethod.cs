// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.InvokeMethod
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners.statements
{
  public class InvokeMethod : Statement
  {
    [Modifiers]
    private FrameworkMethod fTestMethod;
    private object fTarget;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InvokeMethod(FrameworkMethod testMethod, object target)
    {
      InvokeMethod invokeMethod = this;
      this.fTestMethod = testMethod;
      this.fTarget = target;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      this.fTestMethod.invokeExplosively(this.fTarget);
    }
  }
}
