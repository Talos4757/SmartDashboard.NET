// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$1MovedListener
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
  [EnclosingMethod("com.googlecode.javacv.CanvasFrame", "tile", "([Lcom.googlecode.javacv.CanvasFrame;)V")]
  [SourceFile("CanvasFrame.java")]
  [Modifiers]
  internal sealed class CanvasFrame\u00241MovedListener : ComponentAdapter
  {
    internal bool moved;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00241MovedListener()
    {
      base.\u002Ector();
      CanvasFrame\u00241MovedListener frame1MovedListener = this;
      this.moved = false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 103, (byte) 103, (byte) 104, (byte) 102, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void componentMoved([In] ComponentEvent obj0)
    {
      this.moved = true;
      Component component = obj0.getComponent();
      lock (component)
        Object.instancehelper_notify((object) component);
    }
  }
}
