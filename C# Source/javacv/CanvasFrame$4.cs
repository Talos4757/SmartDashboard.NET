// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$4
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("com.googlecode.javacv.CanvasFrame", "tile", "([Lcom.googlecode.javacv.CanvasFrame;)V")]
  [SourceFile("CanvasFrame.java")]
  internal sealed class CanvasFrame\u00244 : Object, Runnable
  {
    [Modifiers]
    internal CanvasFrame[] val\u0024frames;
    [Modifiers]
    internal int val\u0024n;
    [Modifiers]
    internal CanvasFrame\u00241MovedListener val\u0024movedListener;

    [LineNumberTable((ushort) 396)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00244([In] CanvasFrame[] obj0, [In] int obj1, [In] CanvasFrame\u00241MovedListener obj2)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      ((Component) this.val\u0024frames[this.val\u0024n]).removeComponentListener((ComponentListener) this.val\u0024movedListener);
    }
  }
}
