// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.FFmpegFrameRecorder
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class FFmpegFrameRecorder : FrameRecorder
  {
    private string filename;
    private object picture;
    private object video_outbuf;
    private int video_outbuf_size;
    private object oformat;
    private object oc;
    private object c;
    private object video_st;
    private object img_convert_ctx;
    private object pkt;
    private object tempPicture;
    public const int DEFAULT_FRAME_RATE_BASE = 1001000;

    [HideFromJava]
    static FFmpegFrameRecorder()
    {
      FrameRecorder.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 136, (byte) 133, (byte) 103, (byte) 103, (byte) 135, (byte) 107, (byte) 104, (byte) 107, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FFmpegFrameRecorder(string filename, int imageWidth, int imageHeight)
    {
      FFmpegFrameRecorder ffmpegFrameRecorder1 = this;
      avformat.av_register_all();
      this.filename = filename;
      this.imageWidth = imageWidth;
      this.imageHeight = imageHeight;
      this.pixelFormat = avutil.__\u003C\u003EPIX_FMT_RGB32;
      this.codecID = 26;
      this.bitrate = 400000;
      this.frameRate = 30.0;
      FFmpegFrameRecorder ffmpegFrameRecorder2 = this;
      GC.KeepAlive((object) this);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avcodec$AVPacket");
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FFmpegFrameRecorder(File file, int imageWidth, int imageHeight)
      : this(file.getAbsolutePath(), imageWidth, imageHeight)
    {
      GC.KeepAlive((object) this);
    }

    [HideFromJava]
    ~FFmpegFrameRecorder()
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
    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 104, (byte) 108, (byte) 242, (byte) 71, (byte) 136, (byte) 172, (byte) 241, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void stop()
    {
      if (this.video_st != null)
      {
        avcodec.avcodec_close(this.c);
        object obj = this.picture;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avcodec$AVFrame");
      }
      else
      {
        if (this.oc == null)
          return;
        avformat.av_write_trailer(this.oc);
        object obj = this.oc;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 38, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      this.stop();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 70, (byte) 81, (byte) 104, (byte) 240, (byte) 69, (byte) 229, (byte) 69, (byte) 98, (byte) 236, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void record(object frame, bool raw)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(frame, __typeref (FFmpegFrameRecorder), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (this.video_st == null)
      {
        string str = "No video output stream";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else if (frame != null)
      {
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        object obj = this.oformat;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVOutputFormat");
      }
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 123, (byte) 99})]
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

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 62, (byte) 127, (byte) 0, (byte) 115, (byte) 104, (byte) 208, (byte) 107, (byte) 104, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void start()
    {
      this.oformat = avformat.av_guess_format(this.format == null || String.instancehelper_length(this.format) == 0 ? (string) null : this.format, this.filename, (string) null);
      if (this.oformat == null)
      {
        string str = "Could not find suitable output format";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        this.oc = avformat.avformat_alloc_context();
        if (this.oc == null)
        {
          string str = "Memory error";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
        else
        {
          object obj1 = this.oc;
          object obj2 = this.oformat;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.avformat$AVFormatContext");
        }
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 71, (byte) 113, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void record(object frame)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(frame, __typeref (FFmpegFrameRecorder), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      this.record(frame, false);
    }
  }
}
