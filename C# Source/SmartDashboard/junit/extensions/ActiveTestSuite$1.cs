// Decompiled with JetBrains decompiler
// Type: junit.extensions.ActiveTestSuite$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using junit.framework;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.extensions
{
  [InnerClass]
  [EnclosingMethod("junit.extensions.ActiveTestSuite", "runTest", "(Ljunit.framework.Test;Ljunit.framework.TestResult;)V")]
  [SourceFile("ActiveTestSuite.java")]
  [Modifiers]
  internal sealed class ActiveTestSuite\u00241 : Thread
  {
    [Modifiers]
    internal Test val\u0024test;
    [Modifiers]
    internal TestResult val\u0024result;
    [Modifiers]
    internal ActiveTestSuite this\u00240;

    [HideFromJava]
    static ActiveTestSuite\u00241()
    {
      Thread.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ActiveTestSuite\u00241([In] ActiveTestSuite obj0, [In] Test obj1, [In] TestResult obj2)
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 149, (byte) 78, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      try
      {
        this.val\u0024test.run(this.val\u0024result);
      }
      finally
      {
        this.this\u00240.runFinished();
      }
    }
  }
}
