// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.VideoInputFrameGrabber
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class VideoInputFrameGrabber : FrameGrabber
  {
    private static Exception loadingException;
    private int deviceNumber;
    private object myVideoInput;
    private object bgrImage;
    private object grayImage;
    private object bgrImageData;

    static VideoInputFrameGrabber()
    {
      FrameGrabber.__\u003Cclinit\u003E();
      VideoInputFrameGrabber.loadingException = (Exception) null;
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 232, (byte) 76, (byte) 103, (byte) 103, (byte) 110, (byte) 231, (byte) 50, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VideoInputFrameGrabber(int deviceNumber)
    {
      VideoInputFrameGrabber inputFrameGrabber = this;
      this.deviceNumber = 0;
      this.myVideoInput = (object) null;
      this.bgrImage = (object) null;
      this.grayImage = (object) null;
      this.bgrImageData = (object) null;
      this.deviceNumber = deviceNumber;
      GC.KeepAlive((object) this);
    }

    [HideFromJava]
    ~VideoInputFrameGrabber()
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
    [LineNumberTable(new byte[] {(byte) 2, (byte) 103, (byte) 171, (byte) 124, (byte) 97, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void tryLoad()
    {
      if (VideoInputFrameGrabber.loadingException != null)
        throw Throwable.__\u003Cunmap\u003E((Exception) VideoInputFrameGrabber.loadingException);
      Exception exception1;
      try
      {
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<videoInputLib>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception2 = exception1;
      if (exception2 is Exception)
        throw Throwable.__\u003Cunmap\u003E((Exception) (VideoInputFrameGrabber.loadingException = (Exception) exception2));
      else
        throw Throwable.__\u003Cunmap\u003E((Exception) (VideoInputFrameGrabber.loadingException = new Exception(exception2)));
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 79, (byte) 104, (byte) 183})]
    public override void stop()
    {
      if (this.myVideoInput == null)
        return;
      object obj = this.myVideoInput;
      int num = this.deviceNumber;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.videoInputLib$videoInput");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 21, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      this.stop();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getDeviceDescriptions()
    {
      VideoInputFrameGrabber.tryLoad();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.videoInputLib$videoInput");
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 123, (byte) 99})]
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
    [LineNumberTable((ushort) 94)]
    public override void start()
    {
      VideoInputFrameGrabber inputFrameGrabber = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.videoInputLib$videoInput");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 86, (byte) 104, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void trigger()
    {
      if (this.myVideoInput == null)
      {
        string str = "videoInput is null. (Has start() been called?)";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        object obj = this.myVideoInput;
        int num = this.deviceNumber;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.videoInputLib$videoInput");
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 101, (byte) 104, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object grab()
    {
      if (this.myVideoInput == null)
      {
        string str = "videoInput is null. (Has start() been called?)";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        object obj = this.myVideoInput;
        int num = this.deviceNumber;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.videoInputLib$videoInput");
      }
    }
  }
}
