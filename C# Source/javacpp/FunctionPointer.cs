// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.FunctionPointer
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using IKVM.Attributes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacpp
{
  public class FunctionPointer : Pointer
  {
    [HideFromJava]
    static FunctionPointer()
    {
      Pointer.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FunctionPointer()
    {
    }

    [LineNumberTable((ushort) 29)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FunctionPointer(Pointer p)
      : base(p)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 32)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual FunctionPointer position(int position)
    {
      // ISSUE: explicit non-virtual call
      return (FunctionPointer) __nonvirtual (((Pointer) this).position(position));
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pointer \u003Cbridge\u003Eposition(int x0)
    {
      return (Pointer) this.position(x0);
    }
  }
}
