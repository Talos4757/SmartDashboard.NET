// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.OpenCVFrameRecorder
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class OpenCVFrameRecorder : FrameRecorder
  {
    [Modifiers]
    private static bool windows;
    private string filename;
    private object writer;

    [LineNumberTable((ushort) 52)]
    static OpenCVFrameRecorder()
    {
      FrameRecorder.__\u003Cclinit\u003E();
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 232, (byte) 85, (byte) 231, (byte) 44, (byte) 103, (byte) 103, (byte) 135, (byte) 103, (byte) 117, (byte) 103, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OpenCVFrameRecorder(string filename, int imageWidth, int imageHeight)
    {
      OpenCVFrameRecorder openCvFrameRecorder = this;
      this.writer = (object) null;
      this.filename = filename;
      this.imageWidth = imageWidth;
      this.imageHeight = imageHeight;
      this.pixelFormat = 1;
      this.codecID = !OpenCVFrameRecorder.windows ? opencv_highgui.__\u003C\u003ECV_FOURCC_DEFAULT : -1;
      this.bitrate = 0;
      this.frameRate = 30.0;
      GC.KeepAlive((object) this);
    }

    [HideFromJava]
    ~OpenCVFrameRecorder()
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
    [LineNumberTable(new byte[] {(byte) 14, (byte) 104, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void stop()
    {
      if (this.writer == null)
        return;
      opencv_highgui.cvReleaseVideoWriter(this.writer);
      this.writer = (object) null;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      this.stop();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 123, (byte) 99})]
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
    [LineNumberTable(new byte[] {(byte) 7, (byte) 127, (byte) 23, (byte) 104, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void start()
    {
      this.writer = opencv_highgui.cvCreateVideoWriter(this.filename, this.codecID, this.frameRate, opencv_core.cvSize(this.imageWidth, this.imageHeight), this.pixelFormat);
      if (this.writer != null)
        return;
      string str = "cvCreateVideoWriter(): Could not create a writer";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 125, (byte) 177, (byte) 104, (byte) 112, (byte) 176, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void record(object frame)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(frame, __typeref (OpenCVFrameRecorder), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (this.writer != null)
      {
        if (opencv_highgui.cvWriteFrame(this.writer, frame) != 0)
          return;
        string str = "cvWriteFrame(): Could not record frame";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        string str = "Cannot record: There is no writer";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
    }
  }
}
