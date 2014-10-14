// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.Parallel$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("com.googlecode.javacv.Parallel", "loop", "(IIILcom.googlecode.javacv.Parallel$Looper;)V")]
  [SourceFile("Parallel.java")]
  internal sealed class Parallel\u00241 : Object, Runnable
  {
    [Modifiers]
    internal Parallel.Looper val\u0024looper;
    [Modifiers]
    internal int val\u0024subFrom;
    [Modifiers]
    internal int val\u0024subTo;
    [Modifiers]
    internal int val\u0024looperID;

    [LineNumberTable((ushort) 76)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Parallel\u00241([In] Parallel.Looper obj0, [In] int obj1, [In] int obj2, [In] int obj3)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.val\u0024looper.loop(this.val\u0024subFrom, this.val\u0024subTo, this.val\u0024looperID);
    }
  }
}
