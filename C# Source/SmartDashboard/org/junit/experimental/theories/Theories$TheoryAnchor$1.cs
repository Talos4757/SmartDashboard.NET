// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.Theories$TheoryAnchor$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.experimental.theories.@internal;
using org.junit.runners;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  [InnerClass]
  [EnclosingMethod("org.junit.experimental.theories.Theories$TheoryAnchor", "runWithCompleteAssignment", "(Lorg.junit.experimental.theories.internal.Assignments;)V")]
  [SourceFile("Theories.java")]
  [Modifiers]
  internal sealed class Theories\u0024TheoryAnchor\u00241 : BlockJUnit4ClassRunner
  {
    [Modifiers]
    internal Theories.TheoryAnchor this\u00240 = obj0;
    [Modifiers]
    internal Assignments val\u0024complete = obj2;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 152)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Theories\u0024TheoryAnchor\u00241([In] Theories.TheoryAnchor obj0, [In] Class obj1, [In] Assignments obj2)
      : base(obj1)
    {
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    protected internal override void collectInitializationErrors([In] List obj0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Statement methodBlock([In] FrameworkMethod obj0)
    {
      return (Statement) new Theories\u0024TheoryAnchor\u00241\u00241(this, base.methodBlock(obj0));
    }

    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Statement methodInvoker([In] FrameworkMethod obj0, [In] object obj1)
    {
      return Theories.TheoryAnchor.access\u0024100(this.this\u00240, obj0, this.val\u0024complete, obj1);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 153)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object createTest()
    {
      return this.getTestClass().getOnlyConstructor().newInstance(this.val\u0024complete.getConstructorArguments(Theories.TheoryAnchor.access\u0024000(this.this\u00240)), Theories\u0024TheoryAnchor\u00241.__\u003CGetCallerID\u003E());
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Theories\u0024TheoryAnchor\u00241.__\u003CcallerID\u003E == null)
        Theories\u0024TheoryAnchor\u00241.__\u003CcallerID\u003E = (CallerID) new Theories\u0024TheoryAnchor\u00241.__\u003CCallerID\u003E();
      return Theories\u0024TheoryAnchor\u00241.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
