// Decompiled with JetBrains decompiler
// Type: junit.framework.TestResult$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.framework
{
  [InnerClass]
  [Implements(new string[] {"junit.framework.Protectable"})]
  [EnclosingMethod("junit.framework.TestResult", "run", "(Ljunit.framework.TestCase;)V")]
  [SourceFile("TestResult.java")]
  [Modifiers]
  internal sealed class TestResult\u00241 : Object, Protectable
  {
    [Modifiers]
    internal TestCase val\u0024test;
    [Modifiers]
    internal TestResult this\u00240;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TestResult\u00241([In] TestResult obj0, [In] TestCase obj1)
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 60, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void protect()
    {
      this.val\u0024test.runBare();
    }
  }
}
