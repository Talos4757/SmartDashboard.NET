// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.FailOnTimeout$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.junit.@internal.runners.statements;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners.statements
{
  [InnerClass]
  [EnclosingMethod("org.junit.internal.runners.statements.FailOnTimeout", "evaluate", "()V")]
  [SourceFile("FailOnTimeout.java")]
  [Modifiers]
  internal sealed class FailOnTimeout\u00241 : Thread
  {
    [Modifiers]
    internal FailOnTimeout this\u00240;

    [HideFromJava]
    static FailOnTimeout\u00241()
    {
      Thread.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FailOnTimeout\u00241([In] FailOnTimeout obj0)
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 112, (byte) 191, (byte) 0, (byte) 2, (byte) 97, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      Exception exception;
      try
      {
        FailOnTimeout.access\u0024000(this.this\u00240).evaluate();
        FailOnTimeout.access\u0024102(this.this\u00240, true);
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        exception = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      FailOnTimeout.access\u0024202(this.this\u00240, exception);
    }
  }
}
