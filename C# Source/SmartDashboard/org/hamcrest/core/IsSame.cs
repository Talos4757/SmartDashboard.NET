// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.IsSame
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.hamcrest.core
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class IsSame : BaseMatcher
  {
    [Modifiers]
    [Signature("TT;")]
    private object @object;

    [Signature("(TT;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsSame(object @object)
    {
      IsSame isSame = this;
      this.@object = @object;
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 37)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher sameInstance(object @object)
    {
      return (Matcher) new IsSame(@object);
    }

    public override bool matches(object arg)
    {
      return arg == this.@object;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("same(").appendValue(this.@object).appendText(")");
    }
  }
}
