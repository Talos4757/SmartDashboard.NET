// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.FrameworkMethod$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using org.junit.@internal.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners.model
{
  [InnerClass]
  [EnclosingMethod("org.junit.runners.model.FrameworkMethod", "invokeExplosively", "(Ljava.lang.Object;[Ljava.lang.Object;)Ljava.lang.Object;")]
  [SourceFile("FrameworkMethod.java")]
  [Modifiers]
  internal sealed class FrameworkMethod\u00241 : ReflectiveCallable
  {
    [Modifiers]
    internal FrameworkMethod this\u00240 = obj0;
    [Modifiers]
    internal object val\u0024target = obj1;
    [Modifiers]
    internal object[] val\u0024params = obj2;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"java.lang.reflect.InvocationTargetException", "java.lang.IllegalAccessException"})]
    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FrameworkMethod\u00241([In] FrameworkMethod obj0, [In] object obj1, [In] object[] obj2)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object runReflectiveCall()
    {
      return this.this\u00240.fMethod.invoke(this.val\u0024target, this.val\u0024params, FrameworkMethod\u00241.__\u003CGetCallerID\u003E());
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (FrameworkMethod\u00241.__\u003CcallerID\u003E == null)
        FrameworkMethod\u00241.__\u003CcallerID\u003E = (CallerID) new FrameworkMethod\u00241.__\u003CCallerID\u003E();
      return FrameworkMethod\u00241.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
