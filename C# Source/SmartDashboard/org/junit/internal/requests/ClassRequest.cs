// Decompiled with JetBrains decompiler
// Type: org.junit.internal.requests.ClassRequest
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.builders;
using org.junit.@internal.requests;
using org.junit.runner;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.requests
{
  public class ClassRequest : Request
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class fTestClass;
    private bool fCanUseSuiteMethod;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassRequest(Class testClass)
      : this(testClass, true)
    {
    }

    [Signature("(Ljava/lang/Class<*>;Z)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 139, (byte) 98, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassRequest(Class testClass, bool canUseSuiteMethod)
    {
      int num = canUseSuiteMethod ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      ClassRequest classRequest = this;
      this.fTestClass = testClass;
      this.fCanUseSuiteMethod = num != 0;
    }

    [LineNumberTable((ushort) 24)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner getRunner()
    {
      return new AllDefaultPossibilitiesBuilder(this.fCanUseSuiteMethod).safeRunnerForClass(this.fTestClass);
    }
  }
}
