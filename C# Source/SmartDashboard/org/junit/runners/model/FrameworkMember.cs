// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.FrameworkMember
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners.model
{
  [Signature("<T:Lorg/junit/runners/model/FrameworkMember<TT;>;>Ljava/lang/Object;")]
  internal abstract class FrameworkMember : Object
  {
    [LineNumberTable((ushort) 6)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FrameworkMember()
    {
      base.\u002Ector();
    }

    internal abstract Annotation[] getAnnotations();

    [Signature("(TT;)Z")]
    internal abstract bool isShadowedBy([In] FrameworkMember obj0);

    [Signature("(Ljava/util/List<TT;>;)Z")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 123, (byte) 105, (byte) 100})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual bool isShadowedBy([In] List obj0)
    {
      Iterator iterator = obj0.iterator();
      while (iterator.hasNext())
      {
        if (this.isShadowedBy((FrameworkMember) iterator.next()))
          return true;
      }
      return false;
    }
  }
}
