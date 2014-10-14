// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.OpenCVFrameGrabber
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class OpenCVFrameGrabber : FrameGrabber
  {
    private static Exception loadingException;
    [Modifiers]
    private static bool macosx;
    private int deviceNumber;
    private string filename;
    private object capture;
    private object return_image;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 132, (byte) 69, (byte) 230, (byte) 99})]
    static OpenCVFrameGrabber()
    {
      FrameGrabber.__\u003Cclinit\u003E();
      OpenCVFrameGrabber.loadingException = (Exception) null;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 232, (byte) 77, (byte) 103, (byte) 103, (byte) 103, (byte) 231, (byte) 49, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OpenCVFrameGrabber(string filename)
    {
      OpenCVFrameGrabber openCvFrameGrabber = this;
      this.deviceNumber = 0;
      this.filename = (string) null;
      this.capture = (object) null;
      this.return_image = (object) null;
      this.filename = filename;
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 232, (byte) 83, (byte) 103, (byte) 103, (byte) 103, (byte) 231, (byte) 43, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OpenCVFrameGrabber(int deviceNumber)
    {
      OpenCVFrameGrabber openCvFrameGrabber = this;
      this.deviceNumber = 0;
      this.filename = (string) null;
      this.capture = (object) null;
      this.return_image = (object) null;
      this.deviceNumber = deviceNumber;
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OpenCVFrameGrabber(File file)
      : this(file.getAbsolutePath())
    {
      GC.KeepAlive((object) this);
    }

    [HideFromJava]
    ~OpenCVFrameGrabber()
    {
      if (ByteCodeHelper.SkipFinalizer())
        return;
      try
      {
        this.finalize();
      }
      catch
      {
      }
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 103, (byte) 171, (byte) 124, (byte) 97, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void tryLoad()
    {
      if (OpenCVFrameGrabber.loadingException != null)
        throw Throwable.__\u003Cunmap\u003E((Exception) OpenCVFrameGrabber.loadingException);
      Exception exception1;
      try
      {
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<opencv_highgui>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception2 = exception1;
      if (exception2 is Exception)
        throw Throwable.__\u003Cunmap\u003E((Exception) (OpenCVFrameGrabber.loadingException = (Exception) exception2));
      else
        throw Throwable.__\u003Cunmap\u003E((Exception) (OpenCVFrameGrabber.loadingException = new Exception(exception2)));
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 85, (byte) 104, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void stop()
    {
      if (this.capture == null)
        return;
      opencv_highgui.cvReleaseCapture(this.capture);
      this.capture = (object) null;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 17, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      this.stop();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 92, (byte) 107, (byte) 44, (byte) 166, (byte) 108, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void trigger()
    {
      for (int index = 0; index < this.triggerFlushSize; ++index)
        opencv_highgui.cvQueryFrame(this.capture);
      if (opencv_highgui.cvGrabFrame(this.capture) != 0)
        return;
      string str = "cvGrabFrame() Error: Could not grab frame. (Has start() been called?)";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getDeviceDescriptions()
    {
      OpenCVFrameGrabber.tryLoad();
      string str = "Device enumeration not support by OpenCV.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new UnsupportedOperationException(str);
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 123, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void finalize()
    {
      try
      {
        this.release();
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
    }

    public override double getGamma()
    {
      if (this.gamma == 0.0)
        return 2.2;
      else
        return this.gamma;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 41, (byte) 118, (byte) 113, (byte) 104, (byte) 176, (byte) 113, (byte) 104, (byte) 176, (byte) 105, (byte) 121, (byte) 185, (byte) 105, (byte) 121, (byte) 185, (byte) 109, (byte) 151, (byte) 105, (byte) 152, (byte) 159, (byte) 12, (byte) 167, (byte) 98, (byte) 127, (byte) 4, (byte) 202, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void start()
    {
      if (this.filename != null && String.instancehelper_length(this.filename) > 0)
      {
        this.capture = opencv_highgui.cvCreateFileCapture(this.filename);
        if (this.capture == null)
        {
          string str = "cvCreateFileCapture() Error: Could not create camera capture.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
      }
      else
      {
        this.capture = opencv_highgui.cvCreateCameraCapture(this.deviceNumber);
        if (this.capture == null)
        {
          string str = "cvCreateCameraCapture() Error: Could not create camera capture.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
      }
      if (this.imageWidth > 0)
      {
        object cc1 = this.capture;
        int num1 = 3;
        double num2 = (double) this.imageWidth;
        int i1 = num1;
        double d1 = num2;
        if (opencv_highgui.cvSetCaptureProperty(cc1, i1, d1) == 0)
        {
          object cc2 = this.capture;
          int num3 = 9;
          double num4 = (double) this.imageWidth;
          int i2 = num3;
          double d2 = num4;
          opencv_highgui.cvSetCaptureProperty(cc2, i2, d2);
        }
      }
      if (this.imageHeight > 0)
      {
        object cc1 = this.capture;
        int num1 = 4;
        double num2 = (double) this.imageHeight;
        int i1 = num1;
        double d1 = num2;
        if (opencv_highgui.cvSetCaptureProperty(cc1, i1, d1) == 0)
        {
          object cc2 = this.capture;
          int num3 = 9;
          double num4 = (double) this.imageHeight;
          int i2 = num3;
          double d2 = num4;
          opencv_highgui.cvSetCaptureProperty(cc2, i2, d2);
        }
      }
      if (this.frameRate > 0.0)
      {
        object cc = this.capture;
        int num1 = 5;
        double num2 = this.frameRate;
        int i = num1;
        double d = num2;
        opencv_highgui.cvSetCaptureProperty(cc, i, d);
      }
      if (this.bpp > 0)
      {
        object cc = this.capture;
        int num1 = 8;
        double num2 = (double) this.bpp;
        int i = num1;
        double d = num2;
        opencv_highgui.cvSetCaptureProperty(cc, i, d);
      }
      object cc3 = this.capture;
      int num5 = 16;
      double num6 = this.colorMode != FrameGrabber.ColorMode.__\u003C\u003EBGR ? 0.0 : 1.0;
      int i3 = num5;
      double d3 = num6;
      opencv_highgui.cvSetCaptureProperty(cc3, i3, d3);
      if (OpenCVFrameGrabber.macosx)
      {
        int num1 = 0;
        while (true)
        {
          int num2 = num1;
          ++num1;
          int num3 = 100;
          if (num2 < num3 && opencv_highgui.cvGrabFrame(this.capture) != 0 && opencv_highgui.cvRetrieveFrame(this.capture) == null)
            Thread.sleep(100L);
          else
            break;
        }
      }
      if (this.triggerMode)
        return;
      this.trigger();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 102, (byte) 108, (byte) 99, (byte) 144, (byte) 104, (byte) 166, (byte) 249, (byte) 69, (byte) 249, (byte) 70, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object grab()
    {
      object obj1 = opencv_highgui.cvRetrieveFrame(this.capture);
      if (obj1 == null)
      {
        string str = "cvRetrieveFrame() Error: Could not retrieve frame. (Has start() been called?)";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        if (!this.triggerMode)
          this.trigger();
        if (this.colorMode == FrameGrabber.ColorMode.__\u003C\u003EGRAY)
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        else if (this.colorMode == FrameGrabber.ColorMode.__\u003C\u003EBGR)
        {
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        }
        else
        {
          this.return_image = obj1;
          object obj2 = this.return_image;
          Math.round(opencv_highgui.cvGetCaptureProperty(this.capture, 0) * 1000.0);
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        }
      }
    }
  }
}
