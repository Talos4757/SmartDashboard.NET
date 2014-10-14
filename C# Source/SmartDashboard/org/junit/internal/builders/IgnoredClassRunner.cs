// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.IgnoredClassRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.builders;
using org.junit.runner;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.builders
{
  public class IgnoredClassRunner : Runner
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class fTestClass;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 155, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IgnoredClassRunner(Class testClass)
    {
      IgnoredClassRunner ignoredClassRunner = this;
      this.fTestClass = testClass;
    }

    [LineNumberTable((ushort) 24)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Description getDescription()
    {
      return Description.createSuiteDescription(this.fTestClass);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(RunNotifier notifier)
    {
      notifier.fireTestIgnored(this.getDescription());
    }
  }
}
