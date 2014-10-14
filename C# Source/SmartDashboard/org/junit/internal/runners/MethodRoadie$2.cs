// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.MethodRoadie$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.@internal.runners;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("org.junit.internal.runners.MethodRoadie", "runTest", "()V")]
  [SourceFile("MethodRoadie.java")]
  [Modifiers]
  internal sealed class MethodRoadie\u00242 : Object, Runnable
  {
    [Modifiers]
    internal MethodRoadie this\u00240;

    [LineNumberTable((ushort) 85)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MethodRoadie\u00242([In] MethodRoadie obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.this\u00240.runTestMethod();
    }
  }
}
