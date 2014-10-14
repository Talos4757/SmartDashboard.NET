// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Loader$1
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacpp
{
  [InnerClass]
  [EnclosingMethod("com.googlecode.javacpp.Loader", "getCallerClass", "(I)Ljava.lang.Class;")]
  [SourceFile("Loader.java")]
  internal sealed class Loader\u00241 : SecurityManager
  {
    [HideFromJava]
    static Loader\u00241()
    {
      SecurityManager.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 192)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Loader\u00241()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 194)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Class[] getClassContext()
    {
      return base.getClassContext();
    }
  }
}
