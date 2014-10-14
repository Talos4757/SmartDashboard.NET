// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$2
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
  [EnclosingMethod("com.googlecode.javacv.CanvasFrame", "showImage", "(Ljava.awt.Image;II)V")]
  [SourceFile("CanvasFrame.java")]
  [Modifiers]
  internal sealed class CanvasFrame\u00242 : Object, Runnable
  {
    [Modifiers]
    internal int val\u0024w;
    [Modifiers]
    internal int val\u0024h;
    [Modifiers]
    internal CanvasFrame this\u00240;

    [LineNumberTable((ushort) 297)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00242([In] CanvasFrame obj0, [In] int obj1, [In] int obj2)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.this\u00240.setCanvasSize(this.val\u0024w, this.val\u0024h);
    }
  }
}
