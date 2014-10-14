// Decompiled with JetBrains decompiler
// Type: org.junit.runners.ParentRunner$4
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [InnerClass]
  [Implements(new string[] {"java.util.Comparator"})]
  [Signature("Ljava/lang/Object;Ljava/util/Comparator<TT;>;")]
  [EnclosingMethod("org.junit.runners.ParentRunner", "comparator", "()Ljava.util.Comparator;")]
  [SourceFile("ParentRunner.java")]
  [Modifiers]
  internal sealed class ParentRunner\u00244 : Object, Comparator
  {
    [Modifiers]
    internal ParentRunner this\u00240;

    [LineNumberTable((ushort) 304)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ParentRunner\u00244([In] ParentRunner obj0)
    {
      base.\u002Ector();
    }

    [Signature("(TT;TT;)I")]
    [LineNumberTable((ushort) 305)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare([In] object obj0, [In] object obj1)
    {
      return ParentRunner.access\u0024100(this.this\u00240).compare(this.this\u00240.describeChild(obj0), this.this\u00240.describeChild(obj1));
    }

    [HideFromJava]
    bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
    {
      return Object.instancehelper_equals((object) this, obj0);
    }
  }
}
