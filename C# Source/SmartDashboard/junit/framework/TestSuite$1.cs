// Decompiled with JetBrains decompiler
// Type: junit.framework.TestSuite$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.framework
{
  [InnerClass]
  [EnclosingMethod("junit.framework.TestSuite", "warning", "(Ljava.lang.String;)Ljunit.framework.Test;")]
  [SourceFile("TestSuite.java")]
  [Modifiers]
  internal sealed class TestSuite\u00241 : TestCase
  {
    [Modifiers]
    internal string val\u0024message = obj1;

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TestSuite\u00241([In] string obj0, [In] string obj1)
      : base(obj0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void runTest()
    {
      Assert.fail(this.val\u0024message);
    }
  }
}
