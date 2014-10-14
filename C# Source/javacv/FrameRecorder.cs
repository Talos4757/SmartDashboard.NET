// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.FrameRecorder
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public abstract class FrameRecorder : Object
  {
    [Signature("Ljava/util/List<Ljava/lang/Class<+Lcom/googlecode/javacv/FrameRecorder;>;>;")]
    internal static List __\u003C\u003Elist = (List) new LinkedList();
    protected internal string format;
    protected internal int imageWidth;
    protected internal int imageHeight;
    protected internal int pixelFormat;
    protected internal int codecID;
    protected internal int bitrate;
    protected internal double frameRate;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static List list
    {
      [HideFromJava] get
      {
        return FrameRecorder.__\u003C\u003Elist;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 170, (byte) 112, (byte) 112})]
    static FrameRecorder()
    {
      FrameRecorder.__\u003C\u003Elist.add((object) ClassLiteral<FFmpegFrameRecorder>.Value);
      FrameRecorder.__\u003C\u003Elist.add((object) ClassLiteral<OpenCVFrameRecorder>.Value);
    }

    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FrameRecorder()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 159, (byte) 0, (byte) 127, (byte) 30, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void init()
    {
      Iterator iterator = FrameRecorder.__\u003C\u003Elist.iterator();
      while (iterator.hasNext())
      {
        Class @class = (Class) iterator.next();
        try
        {
          @class.getMethod("tryLoad", new Class[0], FrameRecorder.__\u003CGetCallerID\u003E()).invoke((object) null, new object[0], FrameRecorder.__\u003CGetCallerID\u003E());
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
      }
    }

    public virtual string getFormat()
    {
      return this.format;
    }

    public virtual void setFormat(string format)
    {
      this.format = format;
    }

    public virtual int getImageWidth()
    {
      return this.imageWidth;
    }

    public virtual void setImageWidth(int imageWidth)
    {
      this.imageWidth = imageWidth;
    }

    public virtual int getImageHeight()
    {
      return this.imageHeight;
    }

    public virtual void setImageHeight(int imageHeight)
    {
      this.imageHeight = imageHeight;
    }

    public virtual int getPixelFormat()
    {
      return this.pixelFormat;
    }

    public virtual void setPixelFormat(int pixelFormat)
    {
      this.pixelFormat = pixelFormat;
    }

    public virtual int getCodecID()
    {
      return this.codecID;
    }

    public virtual void setCodecID(int codecID)
    {
      this.codecID = codecID;
    }

    public virtual int getBitrate()
    {
      return this.bitrate;
    }

    public virtual void setBitrate(int bitrate)
    {
      this.bitrate = bitrate;
    }

    public virtual double getFrameRate()
    {
      return this.frameRate;
    }

    public virtual void setFrameRate(double frameRate)
    {
      this.frameRate = frameRate;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void start();

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void stop();

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void record(object ii);

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void release();

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (FrameRecorder.__\u003CcallerID\u003E == null)
        FrameRecorder.__\u003CcallerID\u003E = (CallerID) new FrameRecorder.__\u003CCallerID\u003E();
      return FrameRecorder.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
