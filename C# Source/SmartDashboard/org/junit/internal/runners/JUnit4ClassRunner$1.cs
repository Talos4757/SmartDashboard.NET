// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.JUnit4ClassRunner$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.runners;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("org.junit.internal.runners.JUnit4ClassRunner", "run", "(Lorg.junit.runner.notification.RunNotifier;)V")]
  [SourceFile("JUnit4ClassRunner.java")]
  [Modifiers]
  internal sealed class JUnit4ClassRunner\u00241 : Object, Runnable
  {
    [Modifiers]
    internal RunNotifier val\u0024notifier;
    [Modifiers]
    internal JUnit4ClassRunner this\u00240;

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal JUnit4ClassRunner\u00241([In] JUnit4ClassRunner obj0, [In] RunNotifier obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 4, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.this\u00240.runMethods(this.val\u0024notifier);
    }
  }
}
