// Decompiled with JetBrains decompiler
// Type: junit.extensions.TestSetup$1
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
  [Implements(new string[] {"junit.framework.Protectable"})]
  [EnclosingMethod("junit.extensions.TestSetup", "run", "(Ljunit.framework.TestResult;)V")]
  [SourceFile("TestSetup.java")]
  [Modifiers]
  internal sealed class TestSetup\u00241 : Object, Protectable
  {
    [Modifiers]
    internal TestResult val\u0024result;
    [Modifiers]
    internal TestSetup this\u00240;

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TestSetup\u00241([In] TestSetup obj0, [In] TestResult obj1)
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 107, (byte) 113, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void protect()
    {
      this.this\u00240.setUp();
      this.this\u00240.basicRun(this.val\u0024result);
      this.this\u00240.tearDown();
    }
  }
}
