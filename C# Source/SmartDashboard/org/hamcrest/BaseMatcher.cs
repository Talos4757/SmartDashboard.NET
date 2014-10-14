// Decompiled with JetBrains decompiler
// Type: org.hamcrest.BaseMatcher
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.hamcrest
{
  [Implements(new string[] {"org.hamcrest.Matcher"})]
  [Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lorg/hamcrest/Matcher<TT;>;")]
  public abstract class BaseMatcher : Object, Matcher, SelfDescribing
  {
    [LineNumberTable((ushort) 10)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseMatcher()
    {
      base.\u002Ector();
    }

    public void _dont_implement_Matcher___instead_extend_BaseMatcher_()
    {
    }

    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return StringDescription.toString((SelfDescribing) this);
    }

    [HideFromReflection]
    public abstract void describeTo([In] Description obj0);

    [HideFromReflection]
    public abstract bool matches([In] object obj0);
  }
}
