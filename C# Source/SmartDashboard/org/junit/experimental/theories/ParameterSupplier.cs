// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.ParameterSupplier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.junit.experimental.theories
{
  public abstract class ParameterSupplier : Object
  {
    [LineNumberTable((ushort) 6)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParameterSupplier()
    {
      base.\u002Ector();
    }

    [Signature("(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;")]
    public abstract List getValueSources(ParameterSignature ps);
  }
}
