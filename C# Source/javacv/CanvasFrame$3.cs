// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$3
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
  internal sealed class CanvasFrame\u00243 : Object, Runnable
  {
    [Modifiers]
    internal CanvasFrame[] val\u0024frames;
    [Modifiers]
    internal int val\u0024n;
    [Modifiers]
    internal CanvasFrame\u00241MovedListener val\u0024movedListener;
    [Modifiers]
    internal int val\u0024x;
    [Modifiers]
    internal int val\u0024y;

    [LineNumberTable((ushort) 379)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00243([In] CanvasFrame[] obj0, [In] int obj1, [In] CanvasFrame\u00241MovedListener obj2, [In] int obj3, [In] int obj4)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 11, (byte) 120, (byte) 127, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      ((Component) this.val\u0024frames[this.val\u0024n]).addComponentListener((ComponentListener) this.val\u0024movedListener);
      ((Window) this.val\u0024frames[this.val\u0024n]).setLocation(this.val\u0024x, this.val\u0024y);
    }
  }
}
