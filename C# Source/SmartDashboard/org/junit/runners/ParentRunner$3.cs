// Decompiled with JetBrains decompiler
// Type: org.junit.runners.ParentRunner$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("org.junit.runners.ParentRunner", "runChildren", "(Lorg.junit.runner.notification.RunNotifier;)V")]
  [SourceFile("ParentRunner.java")]
  [Modifiers]
  internal sealed class ParentRunner\u00243 : Object, Runnable
  {
    [Modifiers]
    internal object val\u0024each;
    [Modifiers]
    internal RunNotifier val\u0024notifier;
    [Modifiers]
    internal ParentRunner this\u00240;

    [LineNumberTable((ushort) 192)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ParentRunner\u00243([In] ParentRunner obj0, [In] object obj1, [In] RunNotifier obj2)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.this\u00240.runChild(this.val\u0024each, this.val\u0024notifier);
    }
  }
}
