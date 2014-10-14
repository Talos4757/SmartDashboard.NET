// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.IsInstanceOf
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.hamcrest.core
{
  [Signature("Lorg/hamcrest/BaseMatcher<Ljava/lang/Object;>;")]
  public class IsInstanceOf : BaseMatcher
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class theClass;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsInstanceOf(Class theClass)
    {
      IsInstanceOf isInstanceOf = this;
      this.theClass = theClass;
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/hamcrest/Matcher<Ljava/lang/Object;>;")]
    [LineNumberTable((ushort) 41)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher instanceOf(Class type)
    {
      return (Matcher) new IsInstanceOf(type);
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object item)
    {
      return (this.theClass.isInstance(item) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendText("an instance of ").appendText(this.theClass.getName());
    }
  }
}
