// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.FFmpegFrameGrabber
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
  public class FFmpegFrameGrabber : FrameGrabber
  {
    private static Exception loadingException;
    private string filename;
    private object pFormatCtx;
    private int videoStream;
    private object pStream;
    private object pCodecCtx;
    private object pCodec;
    private object pFrame;
    private object pFrameRGB;
    private object img_convert_ctx;
    private object packet;
    private int[] frameFinished;
    private int numBytes;
    private object buffer;
    private object return_image;
    [Modifiers]
    internal static bool \u0024assertionsDisabled;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 131, (byte) 101, (byte) 149})]
    static FFmpegFrameGrabber()
    {
      FrameGrabber.__\u003Cclinit\u003E();
      FFmpegFrameGrabber.\u0024assertionsDisabled = !((Class) ClassLiteral<FFmpegFrameGrabber>.Value).desiredAssertionStatus();
      FFmpegFrameGrabber.loadingException = (Exception) null;
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 232, (byte) 100, (byte) 231, (byte) 30, (byte) 101, (byte) 101, (byte) 101, (byte) 133, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FFmpegFrameGrabber(string filename)
    {
      FFmpegFrameGrabber ffmpegFrameGrabber1 = this;
      this.return_image = (object) null;
      avcodec.avcodec_init();
      avcodec.avcodec_register_all();
      avdevice.avdevice_register_all();
      avformat.av_register_all();
      this.filename = filename;
      FFmpegFrameGrabber ffmpegFrameGrabber2 = this;
      GC.KeepAlive((object) this);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FFmpegFrameGrabber(File file)
      : this(file.getAbsolutePath())
    {
      GC.KeepAlive((object) this);
    }

    [HideFromJava]
    ~FFmpegFrameGrabber()
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
    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 104, (byte) 107, (byte) 135, (byte) 104, (byte) 107, (byte) 199, (byte) 104, (byte) 107, (byte) 199, (byte) 104, (byte) 108, (byte) 199, (byte) 249, (byte) 69, (byte) 104, (byte) 177})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void stop()
    {
      if (this.buffer != null)
      {
        avutil.av_free(this.buffer);
        this.buffer = (object) null;
      }
      if (this.pFrameRGB != null)
      {
        avutil.av_free(this.pFrameRGB);
        this.pFrameRGB = (object) null;
      }
      if (this.pFrame != null)
      {
        avutil.av_free(this.pFrame);
        this.pFrame = (object) null;
      }
      if (this.pCodecCtx != null)
      {
        avcodec.avcodec_close(this.pCodecCtx);
        this.pCodecCtx = (object) null;
      }
      if (this.pFormatCtx != null)
      {
        object obj = this.pFormatCtx;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
      }
      else
      {
        if (this.return_image == null)
          return;
        object obj = this.return_image;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 36, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      this.stop();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 103, (byte) 171, (byte) 252, (byte) 69, (byte) 97, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void tryLoad()
    {
      if (FFmpegFrameGrabber.loadingException != null)
        throw Throwable.__\u003Cunmap\u003E((Exception) FFmpegFrameGrabber.loadingException);
      Exception exception1;
      try
      {
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<avutil>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception2 = exception1;
      if (exception2 is Exception)
        throw Throwable.__\u003Cunmap\u003E((Exception) (FFmpegFrameGrabber.loadingException = (Exception) exception2));
      else
        throw Throwable.__\u003Cunmap\u003E((Exception) (FFmpegFrameGrabber.loadingException = new Exception(exception2)));
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 123, (byte) 99})]
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
    [LineNumberTable(new byte[] {(byte) 70, (byte) 98, (byte) 118, (byte) 108, (byte) 99, (byte) 191, (byte) 21, (byte) 98, (byte) 127, (byte) 9, (byte) 235, (byte) 71, (byte) 127, (byte) 1, (byte) 223, (byte) 21, (byte) 110, (byte) 208, (byte) 189, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void start()
    {
      object obj1 = (object) null;
      if (this.format != null && String.instancehelper_length(this.format) > 0)
      {
        obj1 = avformat.av_find_input_format(this.format);
        if (obj1 == null)
        {
          string str = new StringBuilder().append("Could not find input format \"").append(this.format).append("\".").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
      }
      if (this.frameRate > 0.0 || this.bpp > 0 || (this.imageWidth > 0 || this.imageHeight > 0))
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatParameters");
      object avfc1 = this.pFormatCtx;
      string str1 = this.filename;
      object obj2 = obj1;
      int num1 = 0;
      object obj3 = (object) null;
      int num2 = num1;
      object obj4 = obj2;
      string str2 = str1;
      object avif = obj4;
      int i = num2;
      object avfp = obj3;
      if (avformat.av_open_input_file(avfc1, str2, avif, i, avfp) != 0)
      {
        string str3 = new StringBuilder().append("Could not open file \"").append(this.filename).append("\".").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str3);
      }
      else if (avformat.av_find_stream_info(this.pFormatCtx) < 0)
      {
        string str3 = "Could not find stream information.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str3);
      }
      else
      {
        object avfc2 = this.pFormatCtx;
        int num3 = 0;
        string str3 = this.filename;
        int num4 = 0;
        string str4 = str3;
        int i1 = num3;
        string str5 = str4;
        int i2 = num4;
        avformat.dump_format(avfc2, i1, str5, i2);
        this.videoStream = -1;
        object obj5 = this.pFormatCtx;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void trigger()
    {
      if (this.pFormatCtx != null)
      {
        object obj = this.pFormatCtx;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
      }
      else
      {
        string str = "Could not trigger: No AVFormatContext. (Has start() been called?)";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object grab()
    {
      if (this.pFormatCtx != null)
      {
        object obj = this.pFormatCtx;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
      }
      else
      {
        string str = "Could not grab: No AVFormatContext. (Has start() been called?)";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
    }

    [InnerClass]
    [EnclosingMethod("com.googlecode.javacv.FFmpegFrameGrabber", null, null)]
    [SourceFile("FFmpegFrameGrabber.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      [Modifiers]
      internal static int[] \u0024SwitchMap\u0024com\u0024googlecode\u0024javacv\u0024FrameGrabber\u0024ColorMode = new int[FrameGrabber.ColorMode.values().Length];

      [LineNumberTable((ushort) 187)]
      static \u0031()
      {
        try
        {
          FFmpegFrameGrabber.\u0031.\u0024SwitchMap\u0024com\u0024googlecode\u0024javacv\u0024FrameGrabber\u0024ColorMode[FrameGrabber.ColorMode.__\u003C\u003EBGR.ordinal()] = 1;
          goto label_5;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<NoSuchFieldError>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
label_5:
        try
        {
          FFmpegFrameGrabber.\u0031.\u0024SwitchMap\u0024com\u0024googlecode\u0024javacv\u0024FrameGrabber\u0024ColorMode[FrameGrabber.ColorMode.__\u003C\u003EGRAY.ordinal()] = 2;
          goto label_9;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<NoSuchFieldError>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
label_9:
        try
        {
          FFmpegFrameGrabber.\u0031.\u0024SwitchMap\u0024com\u0024googlecode\u0024javacv\u0024FrameGrabber\u0024ColorMode[FrameGrabber.ColorMode.__\u003C\u003ERAW.ordinal()] = 3;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<NoSuchFieldError>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
      }

      \u0031()
      {
        throw null;
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }
    }
  }
}
