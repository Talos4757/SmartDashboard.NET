// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.awt.color;
using java.awt.image;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace com.googlecode.javacv
{
  [Serializable]
  public class CanvasFrame : JFrame
  {
    public static CanvasFrame global;
    public const long DEFAULT_LATENCY = 120L;
    private long latency;
    private KeyEvent keyEvent;
    private Canvas canvas;
    private bool needInitialResize;
    private BufferStrategy bufferStrategy;
    private double invgamma;

    static CanvasFrame()
    {
      JFrame.__\u003Cclinit\u003E();
      CanvasFrame.global = (CanvasFrame) null;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 233, (byte) 160, (byte) 109, (byte) 137, (byte) 135, (byte) 103, (byte) 103, (byte) 231, (byte) 159, (byte) 142, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasFrame(string title, double gamma)
    {
      base.\u002Ector(title);
      CanvasFrame canvasFrame = this;
      this.latency = 120L;
      this.keyEvent = (KeyEvent) null;
      this.canvas = (Canvas) null;
      this.needInitialResize = false;
      this.bufferStrategy = (BufferStrategy) null;
      this.init(false, (DisplayMode) null, gamma);
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 234, (byte) 160, (byte) 101, (byte) 137, (byte) 135, (byte) 103, (byte) 103, (byte) 231, (byte) 159, (byte) 150, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasFrame(string title, GraphicsConfiguration gc, double gamma)
    {
      base.\u002Ector(title, gc);
      CanvasFrame canvasFrame = this;
      this.latency = 120L;
      this.keyEvent = (KeyEvent) null;
      this.canvas = (Canvas) null;
      this.needInitialResize = false;
      this.bufferStrategy = (BufferStrategy) null;
      this.init(false, (DisplayMode) null, gamma);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 77, (byte) 244, (byte) 160, (byte) 93, (byte) 137, (byte) 135, (byte) 103, (byte) 103, (byte) 231, (byte) 159, (byte) 158, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasFrame(string title, int screenNumber, DisplayMode displayMode, double gamma)
    {
      base.\u002Ector(title, CanvasFrame.getScreenDevice(screenNumber).getDefaultConfiguration());
      CanvasFrame canvasFrame = this;
      this.latency = 120L;
      this.keyEvent = (KeyEvent) null;
      this.canvas = (Canvas) null;
      this.needInitialResize = false;
      this.bufferStrategy = (BufferStrategy) null;
      this.init(true, displayMode, gamma);
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasFrame(string title)
      : this(title, 0.0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasFrame(string title, GraphicsConfiguration gc)
      : this(title, gc, 0.0)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 74, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CanvasFrame(string title, int screenNumber, DisplayMode displayMode)
      : this(title, screenNumber, displayMode, 0.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CanvasFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static BufferStrategy access\u0024200([In] CanvasFrame obj0)
    {
      return obj0.bufferStrategy;
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static KeyEvent access\u0024402([In] CanvasFrame obj0, [In] KeyEvent obj1)
    {
      CanvasFrame canvasFrame1 = obj0;
      KeyEvent keyEvent1 = obj1;
      CanvasFrame canvasFrame2 = canvasFrame1;
      KeyEvent keyEvent2 = keyEvent1;
      canvasFrame2.keyEvent = keyEvent1;
      return keyEvent2;
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 113, (byte) 104, (byte) 170, (byte) 127, (byte) 17, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getGamma(GraphicsDevice screen)
    {
      ColorSpace colorSpace = screen.getDefaultConfiguration().getColorModel().getColorSpace();
      if (colorSpace.isCS_sRGB())
        return 2.2;
      double num1;
      try
      {
        num1 = (double) ((ICC_ProfileRGB) ((ICC_ColorSpace) colorSpace).getProfile()).getGamma(0);
      }
      catch (Exception ex)
      {
        int num2 = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
          throw;
        else
          goto label_6;
      }
      return num1;
label_6:
      return 0.0;
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static double access\u0024002([In] CanvasFrame obj0, [In] double obj1)
    {
      CanvasFrame canvasFrame1 = obj0;
      double num1 = obj1;
      CanvasFrame canvasFrame2 = canvasFrame1;
      double num2 = num1;
      canvasFrame2.invgamma = num1;
      return num2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static Canvas access\u0024102([In] CanvasFrame obj0, [In] Canvas obj1)
    {
      CanvasFrame canvasFrame1 = obj0;
      Canvas canvas1 = obj1;
      CanvasFrame canvasFrame2 = canvasFrame1;
      Canvas canvas2 = canvas1;
      canvasFrame2.canvas = canvas1;
      return canvas2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static Canvas access\u0024100([In] CanvasFrame obj0)
    {
      return obj0.canvas;
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static bool access\u0024302([In] CanvasFrame obj0, [In] bool obj1)
    {
      int num1 = obj1 ? 1 : 0;
      CanvasFrame canvasFrame1 = obj0;
      int num2 = num1;
      CanvasFrame canvasFrame2 = canvasFrame1;
      int num3 = num2;
      canvasFrame2.needInitialResize = num2 != 0;
      return num3 != 0;
    }

    [Modifiers]
    [LineNumberTable((ushort) 58)]
    internal static BufferStrategy access\u0024202([In] CanvasFrame obj0, [In] BufferStrategy obj1)
    {
      CanvasFrame canvasFrame1 = obj0;
      BufferStrategy bufferStrategy1 = obj1;
      CanvasFrame canvasFrame2 = canvasFrame1;
      BufferStrategy bufferStrategy2 = bufferStrategy1;
      canvasFrame2.bufferStrategy = bufferStrategy1;
      return bufferStrategy2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 103, (byte) 109, (byte) 102, (byte) 113, (byte) 109, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCanvasSize(int width, int height)
    {
      ((Frame) this).setExtendedState(0);
      ((Component) this.canvas).setSize(width, height);
      ((Window) this).pack();
      ((Component) this.canvas).setSize(width + 1, height + 1);
      ((Component) this.canvas).setSize(width, height);
      this.needInitialResize = false;
    }

    [LineNumberTable((ushort) 104)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GraphicsDevice[] getScreenDevices()
    {
      return GraphicsEnvironment.getLocalGraphicsEnvironment().getScreenDevices();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 66, (byte) 235, (byte) 160, (byte) 65, (byte) 103, (byte) 168, (byte) 123, (byte) 131})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void init([In] bool obj0, [In] DisplayMode obj1, [In] double obj2)
    {
      int num1 = obj0 ? 1 : 0;
      CanvasFrame\u00241 canvasFrame1 = new CanvasFrame\u00241(this, obj1, num1 != 0, obj2);
      if (EventQueue.isDispatchThread())
      {
        ((Runnable) canvasFrame1).run();
      }
      else
      {
        try
        {
          EventQueue.invokeAndWait((Runnable) canvasFrame1);
        }
        catch (Exception ex)
        {
          int num2 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
            throw;
        }
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 46, (byte) 102, (byte) 101, (byte) 191, (byte) 43})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GraphicsDevice getScreenDevice(int screenNumber)
    {
      GraphicsDevice[] screenDevices = CanvasFrame.getScreenDevices();
      if (screenNumber < screenDevices.Length)
        return screenDevices[screenNumber];
      string str = new StringBuilder().append("CanvasFrame Error: Screen number ").append(screenNumber).append(" not found. ").append("There are only ").append(screenDevices.Length).append(" screens.").toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    public virtual long getLatency()
    {
      return this.latency;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 103, (byte) 115, (byte) 99, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual KeyEvent waitKey(int delay)
    {
      try
      {
        this.keyEvent = (KeyEvent) null;
        Object.instancehelper_wait((object) this, (long) delay);
        goto label_3;
      }
      catch (InterruptedException ex)
      {
      }
label_3:
      KeyEvent keyEvent = this.keyEvent;
      this.keyEvent = (KeyEvent) null;
      return keyEvent;
    }

    [LineNumberTable((ushort) 264)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Graphics2D createGraphics()
    {
      return (Graphics2D) this.bufferStrategy.getDrawGraphics();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 102, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void releaseGraphics(Graphics2D g)
    {
      ((Graphics) g).dispose();
      this.bufferStrategy.show();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 99, (byte) 97, (byte) 112, (byte) 103, (byte) 170, (byte) 255, (byte) 3, (byte) 69, (byte) 163, (byte) 103, (byte) 127, (byte) 2, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void showImage(Image image, int w, int h)
    {
      if (image == null)
        return;
      if (((Frame) this).isResizable() && this.needInitialResize)
      {
        if (EventQueue.isDispatchThread())
        {
          this.setCanvasSize(w, h);
        }
        else
        {
          try
          {
            EventQueue.invokeAndWait((Runnable) new CanvasFrame\u00242(this, w, h));
            goto label_9;
          }
          catch (Exception ex)
          {
            int num = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
              throw;
          }
        }
      }
label_9:
      Graphics2D graphics = this.createGraphics();
      ((Graphics) graphics).drawImage(image, 0, 0, ((Component) this.canvas).getWidth(), ((Component) this.canvas).getHeight(), (ImageObserver) null);
      this.releaseGraphics(graphics);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 99, (byte) 97, (byte) 114, (byte) 114, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void showImage(Image image, double scale)
    {
      if (image == null)
        return;
      int w = (int) Math.round((double) image.getWidth((ImageObserver) null) * scale);
      int h = (int) Math.round((double) image.getHeight((ImageObserver) null) * scale);
      this.showImage(image, w, h);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void showImage(Image image)
    {
      this.showImage(image, 1.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 222, (byte) 103, (byte) 103, (byte) 126, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void showColor(Color color)
    {
      Graphics2D graphics = this.createGraphics();
      ((Graphics) graphics).setColor(color);
      ((Graphics) graphics).fillRect(0, 0, ((Component) this.canvas).getWidth(), ((Component) this.canvas).getHeight());
      this.releaseGraphics(graphics);
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 102, (byte) 104, (byte) 103, (byte) 43, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getScreenDescriptions()
    {
      GraphicsDevice[] screenDevices = CanvasFrame.getScreenDevices();
      string[] strArray = new string[screenDevices.Length];
      for (int index = 0; index < screenDevices.Length; ++index)
        strArray[index] = screenDevices[index].getIDstring();
      return strArray;
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 102, (byte) 105, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DisplayMode getDisplayMode(int screenNumber)
    {
      GraphicsDevice[] screenDevices = CanvasFrame.getScreenDevices();
      if (screenNumber < 0 || screenNumber >= screenDevices.Length)
        return (DisplayMode) null;
      return screenDevices[screenNumber].getDisplayMode();
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 102, (byte) 105, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double getGamma(int screenNumber)
    {
      GraphicsDevice[] screenDevices = CanvasFrame.getScreenDevices();
      if (screenNumber < 0 || screenNumber >= screenDevices.Length)
        return 0.0;
      return CanvasFrame.getGamma(screenDevices[screenNumber]);
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void dispose()
    {
      this.bufferStrategy.dispose();
      ((Window) this).dispose();
    }

    [LineNumberTable((ushort) 211)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DisplayMode getDisplayMode()
    {
      return ((Component) this).getGraphicsConfiguration().getDevice().getDisplayMode();
    }

    public virtual void setLatency(long latency)
    {
      this.latency = latency;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 118, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void waitLatency()
    {
      try
      {
        Thread.sleep(this.getLatency());
      }
      catch (InterruptedException ex)
      {
      }
    }

    [LineNumberTable((ushort) 244)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual KeyEvent waitKey()
    {
      return this.waitKey(0);
    }

    public virtual Canvas getCanvas()
    {
      return this.canvas;
    }

    public virtual BufferStrategy getBufferStrategy()
    {
      return this.bufferStrategy;
    }

    [LineNumberTable((ushort) 272)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension getCanvasSize()
    {
      return ((Component) this.canvas).getSize();
    }

    [LineNumberTable((ushort) 323)]
    public virtual void showImage(object image, int w, int h)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (CanvasFrame), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      CanvasFrame canvasFrame = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 327)]
    public virtual void showImage(object image, double scale)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (CanvasFrame), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      CanvasFrame canvasFrame = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 331)]
    public virtual void showImage(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (CanvasFrame), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      CanvasFrame canvasFrame = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 342)]
    public virtual void showColor(object color)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(color, __typeref (CanvasFrame), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      CanvasFrame canvasFrame = this;
      Color.__\u003Cclinit\u003E();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 166, (byte) 111, (byte) 231, (byte) 69, (byte) 132, (byte) 100, (byte) 99, (byte) 108, (byte) 100, (byte) 99, (byte) 131, (byte) 103, (byte) 242, (byte) 70, (byte) 123, (byte) 237, (byte) 69, (byte) 108, (byte) 108, (byte) 127, (byte) 60, (byte) 139, (byte) 255, (byte) 4, (byte) 69, (byte) 99, (byte) 116, (byte) 124, (byte) 113, (byte) 98, (byte) 227, (byte) 31, (byte) 235, (byte) 100})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void tile(CanvasFrame[] frames)
    {
      CanvasFrame\u00241MovedListener frame1MovedListener = new CanvasFrame\u00241MovedListener();
      int num1 = (int) Math.round(Math.sqrt((double) frames.Length));
      if (num1 * num1 < frames.Length)
        ++num1;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      for (int index1 = 0; index1 < frames.Length; ++index1)
      {
        int index2 = index1;
        int num5 = num2;
        int num6 = num3;
        int num7;
        try
        {
          frame1MovedListener.moved = false;
          EventQueue.invokeAndWait((Runnable) new CanvasFrame\u00243(frames, index2, frame1MovedListener, num5, num6));
          num7 = 0;
          goto label_9;
        }
        catch (Exception ex)
        {
          int num8 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num8) == null)
            throw;
        }
        // ISSUE: variable of the null type
        __Null local = null;
        goto label_28;
label_9:
        CanvasFrame canvasFrame;
        Exception exception1;
        while (true)
        {
          try
          {
            if (!frame1MovedListener.moved)
            {
              if (num7 < 5)
              {
                Monitor.Enter((object) (canvasFrame = frames[index2]));
                try
                {
                  Object.instancehelper_wait((object) frames[index2], 100L);
                  Monitor.Exit((object) canvasFrame);
                }
                catch (Exception ex)
                {
                  int num8 = 0;
                  exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num8);
                  break;
                }
              }
              else
                goto label_23;
            }
            else
              goto label_23;
          }
          catch (Exception ex)
          {
            int num8 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num8) == null)
              throw;
            else
              goto label_17;
          }
          ++num7;
        }
        Exception exception2 = exception1;
        try
        {
          Exception exception3 = exception2;
          Monitor.Exit((object) canvasFrame);
          throw Throwable.__\u003Cunmap\u003E(exception3);
        }
        catch (Exception ex)
        {
          int num8 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num8) == null)
            throw;
        }
        local = null;
        goto label_28;
label_17:
        local = null;
        goto label_28;
label_23:
        try
        {
          EventQueue.invokeAndWait((Runnable) new CanvasFrame\u00244(frames, index2, frame1MovedListener));
          goto label_29;
        }
        catch (Exception ex)
        {
          int num8 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num8) == null)
            throw;
        }
        local = null;
label_28:
label_29:
        num2 = ((Component) frames[index1]).getX() + ((Component) frames[index1]).getWidth();
        num4 = Math.max(num4, ((Component) frames[index1]).getY() + ((Component) frames[index1]).getHeight());
        int num9 = index1 + 1;
        int num10 = num1;
        int num11 = -1;
        if ((num10 != num11 ? num9 % num10 : 0) == 0)
        {
          num2 = 0;
          num3 = num4;
        }
      }
    }
  }
}
