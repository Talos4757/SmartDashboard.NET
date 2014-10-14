// Decompiled with JetBrains decompiler
// Type: org.hamcrest.internal.SelfDescribingValue
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.hamcrest.@internal;
using System.Runtime.CompilerServices;

namespace org.hamcrest.@internal
{
  [Implements(new string[] {"org.hamcrest.SelfDescribing"})]
  [Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lorg/hamcrest/SelfDescribing;")]
  public class SelfDescribingValue : Object, SelfDescribing
  {
    [Signature("TT;")]
    private object value;

    [Signature("(TT;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 151, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelfDescribingValue(object value)
    {
      base.\u002Ector();
      SelfDescribingValue selfDescribingValue = this;
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void describeTo(Description description)
    {
      description.appendValue(this.value);
    }
  }
}
