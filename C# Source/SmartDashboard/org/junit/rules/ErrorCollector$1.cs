// Decompiled with JetBrains decompiler
// Type: org.junit.rules.ErrorCollector$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util.concurrent;
using org.hamcrest;
using org.junit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.rules
{
  [InnerClass]
  [Implements(new string[] {"java.util.concurrent.Callable"})]
  [Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<Ljava/lang/Object;>;")]
  [EnclosingMethod("org.junit.rules.ErrorCollector", "checkThat", "(Ljava.lang.Object;Lorg.hamcrest.Matcher;)V")]
  [SourceFile("ErrorCollector.java")]
  [Modifiers]
  internal sealed class ErrorCollector\u00241 : Object, Callable
  {
    [Modifiers]
    internal object val\u0024value;
    [Modifiers]
    internal Matcher val\u0024matcher;
    [Modifiers]
    internal ErrorCollector this\u00240;

    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ErrorCollector\u00241([In] ErrorCollector obj0, [In] object obj1, [In] Matcher obj2)
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 7, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object call()
    {
      Assert.assertThat(this.val\u0024value, this.val\u0024matcher);
      return this.val\u0024value;
    }
  }
}
