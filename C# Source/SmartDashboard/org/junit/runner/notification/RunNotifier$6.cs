﻿// Decompiled with JetBrains decompiler
// Type: org.junit.runner.notification.RunNotifier$6
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.runner;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner.notification
{
  [InnerClass]
  [EnclosingMethod("org.junit.runner.notification.RunNotifier", "fireTestIgnored", "(Lorg.junit.runner.Description;)V")]
  [SourceFile("RunNotifier.java")]
  [Modifiers]
  internal sealed class RunNotifier\u00246 : RunNotifier.SafeNotifier
  {
    [Modifiers]
    internal new RunNotifier this\u00240 = obj0;
    [Modifiers]
    internal Description val\u0024description = obj1;

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RunNotifier\u00246([In] RunNotifier obj0, [In] Description obj1)
      : base(obj0, (RunNotifier\u00241) null)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 80, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void notifyListener([In] RunListener obj0)
    {
      obj0.testIgnored(this.val\u0024description);
    }
  }
}
