// Decompiled with JetBrains decompiler
// Type: org.junit.runners.BlockJUnit4ClassRunner$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.@internal.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [InnerClass]
  [EnclosingMethod("org.junit.runners.BlockJUnit4ClassRunner", "methodBlock", "(Lorg.junit.runners.model.FrameworkMethod;)Lorg.junit.runners.model.Statement;")]
  [SourceFile("BlockJUnit4ClassRunner.java")]
  [Modifiers]
  internal sealed class BlockJUnit4ClassRunner\u00241 : ReflectiveCallable
  {
    [Modifiers]
    internal BlockJUnit4ClassRunner this\u00240 = obj0;

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 257)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BlockJUnit4ClassRunner\u00241([In] BlockJUnit4ClassRunner obj0)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 258)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object runReflectiveCall()
    {
      return this.this\u00240.createTest();
    }
  }
}
