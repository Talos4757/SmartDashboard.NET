// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.MethodRoadie$1$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util.concurrent;
using org.junit.@internal.runners;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [InnerClass]
  [Implements(new string[] {"java.util.concurrent.Callable"})]
  [Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<Ljava/lang/Object;>;")]
  [EnclosingMethod("org.junit.internal.runners.MethodRoadie$1", "run", "()V")]
  [SourceFile("MethodRoadie.java")]
  [Modifiers]
  internal sealed class MethodRoadie\u00241\u00241 : Object, Callable
  {
    [Modifiers]
    internal MethodRoadie\u00241 this\u00241;

    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MethodRoadie\u00241\u00241([In] MethodRoadie\u00241 obj0)
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 12, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object call()
    {
      this.this\u00241.this\u00240.runTestMethod();
      return (object) null;
    }
  }
}
