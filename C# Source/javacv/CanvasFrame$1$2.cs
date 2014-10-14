// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$1$2
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
  [Implements(new string[] {"java.awt.KeyEventDispatcher"})]
  [EnclosingMethod("com.googlecode.javacv.CanvasFrame$1", "run", "()V")]
  [SourceFile("CanvasFrame.java")]
  [Modifiers]
  internal sealed class CanvasFrame\u00241\u00242 : Object, KeyEventDispatcher
  {
    [Modifiers]
    internal CanvasFrame\u00241 this\u00241;

    [LineNumberTable((ushort) 188)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00241\u00242([In] CanvasFrame\u00241 obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 109, (byte) 114, (byte) 114, (byte) 112, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool dispatchKeyEvent([In] KeyEvent obj0)
    {
      if (((AWTEvent) obj0).getID() == 401)
      {
        lock (this.this\u00241.this\u00240)
        {
          CanvasFrame.access\u0024402(this.this\u00241.this\u00240, obj0);
          Object.instancehelper_notify((object) this.this\u00241.this\u00240);
        }
      }
      return false;
    }
  }
}
