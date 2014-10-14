// Decompiled with JetBrains decompiler
// Type: org.junit.runners.ParentRunner$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.runner.notification;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [InnerClass]
  [EnclosingMethod("org.junit.runners.ParentRunner", "childrenInvoker", "(Lorg.junit.runner.notification.RunNotifier;)Lorg.junit.runners.model.Statement;")]
  [SourceFile("ParentRunner.java")]
  [Modifiers]
  internal sealed class ParentRunner\u00242 : Statement
  {
    [Modifiers]
    internal ParentRunner this\u00240 = obj0;
    [Modifiers]
    internal RunNotifier val\u0024notifier = obj1;

    [LineNumberTable((ushort) 183)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ParentRunner\u00242([In] ParentRunner obj0, [In] RunNotifier obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      ParentRunner.access\u0024000(this.this\u00240, this.val\u0024notifier);
    }
  }
}
