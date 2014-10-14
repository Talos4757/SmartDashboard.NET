// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("com.googlecode.javacv.CanvasFrame", "init", "(ZLjava.awt.DisplayMode;D)V")]
  [SourceFile("CanvasFrame.java")]
  [Modifiers]
  internal sealed class CanvasFrame\u00241 : Object, Runnable
  {
    [Modifiers]
    internal DisplayMode val\u0024displayMode;
    [Modifiers]
    internal bool val\u0024fullScreen;
    [Modifiers]
    internal double val\u0024gamma;
    [Modifiers]
    internal CanvasFrame this\u00240;

    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00241([In] CanvasFrame obj0, [In] DisplayMode obj1, [In] bool obj2, [In] double obj3)
    {
      int num = obj2 ? 1 : 0;
      this.this\u00240 = obj0;
      this.val\u0024displayMode = obj1;
      this.val\u0024fullScreen = num != 0;
      this.val\u0024gamma = obj3;
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 113, (byte) 105, (byte) 113, (byte) 108, (byte) 109, (byte) 109, (byte) 109, (byte) 191, (byte) 33, (byte) 104, (byte) 108, (byte) 113, (byte) 108, (byte) 140, (byte) 108, (byte) 135, (byte) 126, (byte) 223, (byte) 5, (byte) 140, (byte) 242, (byte) 76, (byte) 104, (byte) 123, (byte) 143, (byte) 141, (byte) 124, (byte) 113, (byte) 145, (byte) 156, (byte) 242, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      GraphicsDevice device = ((Component) this.this\u00240).getGraphicsConfiguration().getDevice();
      DisplayMode displayMode1 = device.getDisplayMode();
      DisplayMode displayMode2 = (DisplayMode) null;
      if (this.val\u0024displayMode != null && displayMode1 != null)
      {
        int width = this.val\u0024displayMode.getWidth();
        int height = this.val\u0024displayMode.getHeight();
        int bitDepth = this.val\u0024displayMode.getBitDepth();
        int refreshRate = this.val\u0024displayMode.getRefreshRate();
        displayMode2 = new DisplayMode(width <= 0 ? displayMode1.getWidth() : width, height <= 0 ? displayMode1.getHeight() : height, bitDepth <= 0 ? displayMode1.getBitDepth() : bitDepth, refreshRate <= 0 ? displayMode1.getRefreshRate() : refreshRate);
      }
      if (this.val\u0024fullScreen)
      {
        ((Frame) this.this\u00240).setUndecorated(true);
        this.this\u00240.getRootPane().setWindowDecorationStyle(0);
        ((Frame) this.this\u00240).setResizable(false);
        device.setFullScreenWindow((Window) this.this\u00240);
      }
      if (displayMode2 != null && !displayMode2.equals(displayMode1))
        device.setDisplayMode(displayMode2);
      double num = this.val\u0024gamma != 0.0 ? this.val\u0024gamma : CanvasFrame.getGamma(device);
      CanvasFrame.access\u0024002(this.this\u00240, num != 0.0 ? 1.0 / num : 1.0);
      ((Window) this.this\u00240).setVisible(true);
      CanvasFrame.access\u0024102(this.this\u00240, (Canvas) new CanvasFrame\u00241\u00241(this));
      if (this.val\u0024fullScreen)
      {
        ((Component) CanvasFrame.access\u0024100(this.this\u00240)).setSize(((Component) this.this\u00240).getSize());
        CanvasFrame.access\u0024302(this.this\u00240, false);
      }
      else
        CanvasFrame.access\u0024302(this.this\u00240, true);
      this.this\u00240.getContentPane().add((Component) CanvasFrame.access\u0024100(this.this\u00240));
      ((Component) CanvasFrame.access\u0024100(this.this\u00240)).setVisible(true);
      CanvasFrame.access\u0024100(this.this\u00240).createBufferStrategy(2);
      CanvasFrame.access\u0024202(this.this\u00240, CanvasFrame.access\u0024100(this.this\u00240).getBufferStrategy());
      KeyboardFocusManager.getCurrentKeyboardFocusManager().addKeyEventDispatcher((KeyEventDispatcher) new CanvasFrame\u00241\u00242(this));
    }
  }
}
