// Decompiled with JetBrains decompiler
// Type: org.junit.runner.manipulation.Sorter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.runner;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runner.manipulation
{
  [Implements(new string[] {"java.util.Comparator"})]
  [Signature("Ljava/lang/Object;Ljava/util/Comparator<Lorg/junit/runner/Description;>;")]
  public class Sorter : Object, Comparator
  {
    public static Sorter NULL = new Sorter((Comparator) new Sorter\u00241());
    [Modifiers]
    [Signature("Ljava/util/Comparator<Lorg/junit/runner/Description;>;")]
    private Comparator fComparator;

    [LineNumberTable((ushort) 17)]
    static Sorter()
    {
    }

    [Signature("(Ljava/util/Comparator<Lorg/junit/runner/Description;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sorter(Comparator comparator)
    {
      base.\u002Ector();
      Sorter sorter = this;
      this.fComparator = comparator;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 179, (byte) 104, (byte) 103, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void apply(object @object)
    {
      if (!(@object is Sortable))
        return;
      ((Sortable) @object).sort(this);
    }

    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare(Description o1, Description o2)
    {
      return this.fComparator.compare((object) o1, (object) o2);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 13)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compare(object x0, object x1)
    {
      return this.compare((Description) x0, (Description) x1);
    }

    [HideFromJava]
    bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
    {
      return Object.instancehelper_equals((object) this, obj0);
    }
  }
}
