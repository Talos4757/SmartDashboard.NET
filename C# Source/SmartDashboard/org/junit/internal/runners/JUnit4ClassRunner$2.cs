// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.JUnit4ClassRunner$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit.@internal.runners;
using org.junit.runner.manipulation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [InnerClass]
  [Implements(new string[] {"java.util.Comparator"})]
  [Signature("Ljava/lang/Object;Ljava/util/Comparator<Ljava/lang/reflect/Method;>;")]
  [EnclosingMethod("org.junit.internal.runners.JUnit4ClassRunner", "sort", "(Lorg.junit.runner.manipulation.Sorter;)V")]
  [SourceFile("JUnit4ClassRunner.java")]
  [Modifiers]
  internal sealed class JUnit4ClassRunner\u00242 : Object, Comparator
  {
    [Modifiers]
    internal Sorter val\u0024sorter;
    [Modifiers]
    internal JUnit4ClassRunner this\u00240;

    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal JUnit4ClassRunner\u00242([In] JUnit4ClassRunner obj0, [In] Sorter obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 137)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare([In] Method obj0, [In] Method obj1)
    {
      return this.val\u0024sorter.compare(this.this\u00240.methodDescription(obj0), this.this\u00240.methodDescription(obj1));
    }

    [Modifiers]
    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare([In] object obj0, [In] object obj1)
    {
      return this.compare((Method) obj0, (Method) obj1);
    }

    [HideFromJava]
    bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
    {
      return Object.instancehelper_equals((object) this, obj0);
    }
  }
}
