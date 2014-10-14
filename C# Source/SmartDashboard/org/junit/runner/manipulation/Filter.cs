// Decompiled with JetBrains decompiler
// Type: org.junit.runner.manipulation.Filter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner;
using System.Runtime.CompilerServices;

namespace org.junit.runner.manipulation
{
  public abstract class Filter : Object
  {
    public static Filter ALL = (Filter) new Filter\u00241();

    [LineNumberTable((ushort) 19)]
    static Filter()
    {
    }

    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Filter()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"org.junit.runner.manipulation.NoTestsRemainException"})]
    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 97, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void apply(object child)
    {
      if (!(child is Filterable))
        return;
      ((Filterable) child).filter(this);
    }

    [LineNumberTable((ushort) 36)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Filter matchMethodDescription(Description desiredDescription)
    {
      return (Filter) new Filter\u00242(desiredDescription);
    }

    public abstract bool shouldRun(Description d);

    public abstract string describe();
  }
}
