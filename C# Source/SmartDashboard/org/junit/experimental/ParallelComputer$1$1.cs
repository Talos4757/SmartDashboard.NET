// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.ParallelComputer$1$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util.concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental
{
  [InnerClass]
  [Implements(new string[] {"java.util.concurrent.Callable"})]
  [Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<Ljava/lang/Object;>;")]
  [EnclosingMethod("org.junit.experimental.ParallelComputer$1", "schedule", "(Ljava.lang.Runnable;)V")]
  [SourceFile("ParallelComputer.java")]
  [Modifiers]
  internal sealed class ParallelComputer\u00241\u00241 : Object, Callable
  {
    [Modifiers]
    internal Runnable val\u0024childStatement;
    [Modifiers]
    internal ParallelComputer\u00241 this\u00240;

    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ParallelComputer\u00241\u00241([In] ParallelComputer\u00241 obj0, [In] Runnable obj1)
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object call()
    {
      this.val\u0024childStatement.run();
      return (object) null;
    }
  }
}
