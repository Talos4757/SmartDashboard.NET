// Decompiled with JetBrains decompiler
// Type: org.junit.runner.manipulation.Sorter$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.runner;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner.manipulation
{
  [InnerClass]
  [Implements(new string[] {"java.util.Comparator"})]
  [Signature("Ljava/lang/Object;Ljava/util/Comparator<Lorg/junit/runner/Description;>;")]
  [EnclosingMethod("org.junit.runner.manipulation.Sorter", null, null)]
  [SourceFile("Sorter.java")]
  [Modifiers]
  internal sealed class Sorter\u00241 : Object, Comparator
  {
    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Sorter\u00241()
    {
      base.\u002Ector();
    }

    public virtual int compare([In] Description obj0, [In] Description obj1)
    {
      return 0;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare([In] object obj0, [In] object obj1)
    {
      return this.compare((Description) obj0, (Description) obj1);
    }

    [HideFromJava]
    bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
    {
      return Object.instancehelper_equals((object) this, obj0);
    }
  }
}
