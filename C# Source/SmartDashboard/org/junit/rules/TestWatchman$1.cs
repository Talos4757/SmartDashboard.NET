// Decompiled with JetBrains decompiler
// Type: org.junit.rules.TestWatchman$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.rules
{
  [InnerClass]
  [EnclosingMethod("org.junit.rules.TestWatchman", "apply", "(Lorg.junit.runners.model.Statement;Lorg.junit.runners.model.FrameworkMethod;Ljava.lang.Object;)Lorg.junit.runners.model.Statement;")]
  [SourceFile("TestWatchman.java")]
  [Modifiers]
  internal sealed class TestWatchman\u00241 : Statement
  {
    [Modifiers]
    internal TestWatchman this\u00240 = obj0;
    [Modifiers]
    internal FrameworkMethod val\u0024method = obj1;
    [Modifiers]
    internal Statement val\u0024base = obj2;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TestWatchman\u00241([In] TestWatchman obj0, [In] FrameworkMethod obj1, [In] Statement obj2)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 145, (byte) 107, (byte) 254, (byte) 69, (byte) 87, (byte) 113, (byte) 228, (byte) 59, (byte) 97, (byte) 114, (byte) 135, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      this.this\u00240.starting(this.val\u0024method);
      Exception exception1;
      // ISSUE: fault handler
      try
      {
        this.val\u0024base.evaluate();
        this.this\u00240.succeeded(this.val\u0024method);
        goto label_5;
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      __fault
      {
        this.this\u00240.finished(this.val\u0024method);
      }
      Exception exception2 = exception1;
      // ISSUE: fault handler
      try
      {
        Exception e = exception2;
        this.this\u00240.failed(e, this.val\u0024method);
        throw Throwable.__\u003Cunmap\u003E(e);
      }
      __fault
      {
        this.this\u00240.finished(this.val\u0024method);
      }
label_5:
      this.this\u00240.finished(this.val\u0024method);
    }
  }
}
