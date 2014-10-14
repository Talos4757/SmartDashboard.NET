// Decompiled with JetBrains decompiler
// Type: org.junit.runner.notification.RunNotifier$5
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner.notification
{
  [InnerClass]
  [EnclosingMethod("org.junit.runner.notification.RunNotifier", "fireTestAssumptionFailed", "(Lorg.junit.runner.notification.Failure;)V")]
  [SourceFile("RunNotifier.java")]
  [Modifiers]
  internal sealed class RunNotifier\u00245 : RunNotifier.SafeNotifier
  {
    [Modifiers]
    internal new RunNotifier this\u00240 = obj0;
    [Modifiers]
    internal Failure val\u0024failure = obj1;

    [LineNumberTable((ushort) 118)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RunNotifier\u00245([In] RunNotifier obj0, [In] Failure obj1)
      : base(obj0, (RunNotifier\u00241) null)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 67, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void notifyListener([In] RunListener obj0)
    {
      obj0.testAssumptionFailure(this.val\u0024failure);
    }
  }
}
