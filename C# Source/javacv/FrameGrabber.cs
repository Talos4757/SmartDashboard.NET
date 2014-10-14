// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.FrameGrabber
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.beans;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  public abstract class FrameGrabber : Object
  {
    [Signature("Ljava/util/List<Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;>;")]
    internal static List __\u003C\u003Elist = (List) new LinkedList();
    protected internal string format;
    protected internal int imageWidth;
    protected internal int imageHeight;
    protected internal double frameRate;
    protected internal bool triggerMode;
    protected internal int triggerFlushSize;
    protected internal int bpp;
    protected internal FrameGrabber.ColorMode colorMode;
    protected internal int timeout;
    protected internal int numBuffers;
    protected internal double gamma;
    protected internal bool deinterlace;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static List list
    {
      [HideFromJava] get
      {
        return FrameGrabber.__\u003C\u003Elist;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 170, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112})]
    static FrameGrabber()
    {
      FrameGrabber.__\u003C\u003Elist.add((object) ClassLiteral<DC1394FrameGrabber>.Value);
      FrameGrabber.__\u003C\u003Elist.add((object) ClassLiteral<FlyCaptureFrameGrabber>.Value);
      FrameGrabber.__\u003C\u003Elist.add((object) ClassLiteral<VideoInputFrameGrabber>.Value);
      FrameGrabber.__\u003C\u003Elist.add((object) ClassLiteral<OpenCVFrameGrabber>.Value);
      FrameGrabber.__\u003C\u003Elist.add((object) ClassLiteral<FFmpegFrameGrabber>.Value);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 232, (byte) 160, (byte) 74, (byte) 103, (byte) 110, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 103, (byte) 108, (byte) 231, (byte) 160, (byte) 92})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FrameGrabber()
    {
      base.\u002Ector();
      FrameGrabber frameGrabber = this;
      this.format = (string) null;
      this.imageWidth = 0;
      this.imageHeight = 0;
      this.frameRate = 0.0;
      this.triggerMode = false;
      this.triggerFlushSize = 0;
      this.bpp = 0;
      this.colorMode = FrameGrabber.ColorMode.__\u003C\u003EBGR;
      this.timeout = 10000;
      this.numBuffers = 4;
      this.gamma = 0.0;
      this.deinterlace = false;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual void setFormat(string format)
    {
      this.format = format;
    }

    public virtual void setImageWidth(int imageWidth)
    {
      this.imageWidth = imageWidth;
    }

    public virtual void setImageHeight(int imageHeight)
    {
      this.imageHeight = imageHeight;
    }

    public virtual void setFrameRate(double frameRate)
    {
      this.frameRate = frameRate;
    }

    public virtual void setTriggerMode(bool triggerMode)
    {
      this.triggerMode = triggerMode;
    }

    public virtual void setTriggerFlushSize(int triggerFlushSize)
    {
      this.triggerFlushSize = triggerFlushSize;
    }

    public virtual void setBitsPerPixel(int bitsPerPixel)
    {
      this.bpp = bitsPerPixel;
    }

    public virtual void setColorMode(FrameGrabber.ColorMode colorMode)
    {
      this.colorMode = colorMode;
    }

    public virtual void setTimeout(int timeout)
    {
      this.timeout = timeout;
    }

    public virtual void setNumBuffers(int numBuffers)
    {
      this.numBuffers = numBuffers;
    }

    public virtual void setGamma(double gamma)
    {
      this.gamma = gamma;
    }

    public virtual void setDeinterlace(bool deinterlace)
    {
      this.deinterlace = deinterlace;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 159, (byte) 0, (byte) 127, (byte) 30, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void init()
    {
      Iterator iterator = FrameGrabber.__\u003C\u003Elist.iterator();
      while (iterator.hasNext())
      {
        Class @class = (Class) iterator.next();
        try
        {
          @class.getMethod("tryLoad", new Class[0], FrameGrabber.__\u003CGetCallerID\u003E()).invoke((object) null, new object[0], FrameGrabber.__\u003CGetCallerID\u003E());
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
      }
    }

    [Signature("()Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
    [LineNumberTable(new byte[] {(byte) 3, (byte) 130, (byte) 146, (byte) 113, (byte) 127, (byte) 9, (byte) 130, (byte) 127, (byte) 19, (byte) 101, (byte) 242, (byte) 70, (byte) 253, (byte) 60, (byte) 98, (byte) 110, (byte) 183, (byte) 99, (byte) 130, (byte) 227, (byte) 46, (byte) 233, (byte) 84})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Class getDefault()
    {
      Class @class = (Class) null;
      for (int index = 0; index < FrameGrabber.__\u003C\u003Elist.size(); ++index)
      {
        int num1;
        Exception exception1;
        try
        {
          @class = (Class) FrameGrabber.__\u003C\u003Elist.get(index);
          @class.getMethod("tryLoad", new Class[0], FrameGrabber.__\u003CGetCallerID\u003E()).invoke((object) null, new object[0], FrameGrabber.__\u003CGetCallerID\u003E());
          num1 = 0;
          try
          {
            if (((string[]) @class.getMethod("getDeviceDescriptions", new Class[0], FrameGrabber.__\u003CGetCallerID\u003E()).invoke((object) null, new object[0], FrameGrabber.__\u003CGetCallerID\u003E())).Length > 0)
            {
              num1 = 1;
              goto label_15;
            }
            else
              goto label_15;
          }
          catch (Exception ex)
          {
            int num2 = 0;
            exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
          }
        }
        catch (Exception ex)
        {
          int num2 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
            throw;
          else
            goto label_9;
        }
        Exception exception2 = exception1;
        try
        {
          if (Throwable.instancehelper_getCause(exception2) is UnsupportedOperationException)
          {
            num1 = 1;
            goto label_15;
          }
          else
            goto label_15;
        }
        catch (Exception ex)
        {
          int num2 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
            throw;
        }
        // ISSUE: variable of the null type
        __Null local = null;
        goto label_16;
label_9:
        local = null;
        goto label_16;
label_15:
        if (num1 == 0)
          continue;
        else
          break;
label_16:;
      }
      return @class;
    }

    public virtual string getFormat()
    {
      return this.format;
    }

    public virtual int getImageWidth()
    {
      return this.imageWidth;
    }

    public virtual int getImageHeight()
    {
      return this.imageHeight;
    }

    public virtual double getFrameRate()
    {
      return this.frameRate;
    }

    public virtual bool isTriggerMode()
    {
      return this.triggerMode;
    }

    public virtual int getTriggerFlushSize()
    {
      return this.triggerFlushSize;
    }

    public virtual int getBitsPerPixel()
    {
      return this.bpp;
    }

    public virtual FrameGrabber.ColorMode getColorMode()
    {
      return this.colorMode;
    }

    public virtual int getTimeout()
    {
      return this.timeout;
    }

    public virtual int getNumBuffers()
    {
      return this.numBuffers;
    }

    public virtual double getGamma()
    {
      return this.gamma;
    }

    public virtual bool isDeinterlace()
    {
      return this.deinterlace;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void start();

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void stop();

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void trigger();

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract object grab();

    [Throws(new string[] {"java.lang.Exception"})]
    public abstract void release();

    [LineNumberTable((ushort) 341)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual FrameGrabber.Array createArray(FrameGrabber[] frameGrabbers)
    {
      return new FrameGrabber.Array(frameGrabbers);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (FrameGrabber.__\u003CcallerID\u003E == null)
        FrameGrabber.__\u003CcallerID\u003E = (CallerID) new FrameGrabber.__\u003CCallerID\u003E();
      return FrameGrabber.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("FrameGrabber.java")]
    public class Array : Object
    {
      private object grabbedImages;
      private long[] latencies;
      private long[] bestLatencies;
      private long lastNewestTimestamp;
      private long bestInterval;
      protected internal FrameGrabber[] frameGrabbers;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 200, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 143, (byte) 231, (byte) 55, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Array(FrameGrabber[] frameGrabbers)
      {
        base.\u002Ector();
        FrameGrabber.Array array = this;
        this.grabbedImages = (object) null;
        this.latencies = (long[]) null;
        this.bestLatencies = (long[]) null;
        this.lastNewestTimestamp = 0L;
        this.bestInterval = long.MaxValue;
        this.frameGrabbers = (FrameGrabber[]) null;
        this.setFrameGrabbers(frameGrabbers);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 103})]
      public virtual void setFrameGrabbers(FrameGrabber[] frameGrabbers)
      {
        this.frameGrabbers = frameGrabbers;
        FrameGrabber.Array array = this;
        int length = frameGrabbers.Length;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }

      public virtual FrameGrabber[] getFrameGrabbers()
      {
        return this.frameGrabbers;
      }

      [LineNumberTable((ushort) 235)]
      public virtual int size()
      {
        return this.frameGrabbers.Length;
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 116, (byte) 38, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void start()
      {
        FrameGrabber[] frameGrabberArray = this.frameGrabbers;
        int length = frameGrabberArray.Length;
        for (int index = 0; index < length; ++index)
          frameGrabberArray[index].start();
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 116, (byte) 38, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void stop()
      {
        FrameGrabber[] frameGrabberArray = this.frameGrabbers;
        int length = frameGrabberArray.Length;
        for (int index = 0; index < length; ++index)
          frameGrabberArray[index].stop();
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 136, (byte) 116, (byte) 104, (byte) 6, (byte) 230, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void trigger()
      {
        FrameGrabber[] frameGrabberArray = this.frameGrabbers;
        int length = frameGrabberArray.Length;
        for (int index = 0; index < length; ++index)
        {
          FrameGrabber frameGrabber = frameGrabberArray[index];
          if (frameGrabber.isTriggerMode())
            frameGrabber.trigger();
        }
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 106, (byte) 255, (byte) 0, (byte) 72, (byte) 99, (byte) 108, (byte) 255, (byte) 0, (byte) 69, (byte) 108, (byte) 210, (byte) 104, (byte) 157, (byte) 100, (byte) 108, (byte) 109, (byte) 13, (byte) 198, (byte) 100, (byte) 248, (byte) 70, (byte) 121, (byte) 108, (byte) 63, (byte) 4, (byte) 230, (byte) 70, (byte) 102, (byte) 108, (byte) 63, (byte) 2, (byte) 38, (byte) 230, (byte) 92, (byte) 135})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object grab()
      {
        if (this.frameGrabbers.Length == 1)
        {
          object obj = this.grabbedImages;
          this.frameGrabbers[0].grab();
          throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
        }
        else
        {
          long num1 = 0L;
          int index1 = 0;
          if (index1 < this.frameGrabbers.Length)
          {
            object obj = this.grabbedImages;
            this.frameGrabbers[index1].grab();
            throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
          }
          else if (0 < this.frameGrabbers.Length)
          {
            object obj = this.grabbedImages;
            throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
          }
          else
          {
            if (this.bestLatencies == null)
            {
              this.bestLatencies = Arrays.copyOf(this.latencies, this.latencies.Length);
            }
            else
            {
              int num2 = 0;
              int num3 = 0;
              for (int index2 = 0; index2 < this.frameGrabbers.Length; ++index2)
              {
                num2 = (int) ((long) num2 + this.latencies[index2]);
                num3 = (int) ((long) num3 + this.bestLatencies[index2]);
              }
              if (num2 < num3)
                this.bestLatencies = Arrays.copyOf(this.latencies, this.latencies.Length);
            }
            this.bestInterval = Math.min(this.bestInterval, num1 - this.lastNewestTimestamp);
            for (int index2 = 0; index2 < this.bestLatencies.Length; ++index2)
              this.bestLatencies[index2] = Math.min(this.bestLatencies[index2], this.bestInterval * 9L / 10L);
            for (int index2 = 0; index2 < 2; ++index2)
            {
              for (int index3 = 0; index3 < this.frameGrabbers.Length; ++index3)
              {
                if (!this.frameGrabbers[index3].isTriggerMode())
                {
                  object obj = this.grabbedImages;
                  throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
                }
              }
            }
            this.lastNewestTimestamp = num1;
            return this.grabbedImages;
          }
        }
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 116, (byte) 38, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void release()
      {
        FrameGrabber[] frameGrabberArray = this.frameGrabbers;
        int length = frameGrabberArray.Length;
        for (int index = 0; index < length; ++index)
          frameGrabberArray[index].release();
      }
    }

    [InnerClass]
    [Signature("Ljava/lang/Enum<Lcom/googlecode/javacv/FrameGrabber$ColorMode;>;")]
    [SourceFile("FrameGrabber.java")]
    [Modifiers]
    [Serializable]
    public sealed class ColorMode : Enum
    {
      [Modifiers]
      internal static FrameGrabber.ColorMode __\u003C\u003EBGR = new FrameGrabber.ColorMode("BGR", 0);
      [Modifiers]
      internal static FrameGrabber.ColorMode __\u003C\u003EGRAY = new FrameGrabber.ColorMode("GRAY", 1);
      [Modifiers]
      internal static FrameGrabber.ColorMode __\u003C\u003ERAW = new FrameGrabber.ColorMode("RAW", 2);
      [Modifiers]
      private static FrameGrabber.ColorMode[] \u0024VALUES;

      [Modifiers]
      public static FrameGrabber.ColorMode BGR
      {
        [HideFromJava] get
        {
          return FrameGrabber.ColorMode.__\u003C\u003EBGR;
        }
      }

      [Modifiers]
      public static FrameGrabber.ColorMode GRAY
      {
        [HideFromJava] get
        {
          return FrameGrabber.ColorMode.__\u003C\u003EGRAY;
        }
      }

      [Modifiers]
      public static FrameGrabber.ColorMode RAW
      {
        [HideFromJava] get
        {
          return FrameGrabber.ColorMode.__\u003C\u003ERAW;
        }
      }

      [LineNumberTable(new byte[] {(byte) 55, (byte) 63, (byte) 17})]
      static ColorMode()
      {
        FrameGrabber.ColorMode[] colorModeArray = new FrameGrabber.ColorMode[3];
        int index1 = 0;
        FrameGrabber.ColorMode colorMode1 = FrameGrabber.ColorMode.__\u003C\u003EBGR;
        colorModeArray[index1] = colorMode1;
        int index2 = 1;
        FrameGrabber.ColorMode colorMode2 = FrameGrabber.ColorMode.__\u003C\u003EGRAY;
        colorModeArray[index2] = colorMode2;
        int index3 = 2;
        FrameGrabber.ColorMode colorMode3 = FrameGrabber.ColorMode.__\u003C\u003ERAW;
        colorModeArray[index3] = colorMode3;
        FrameGrabber.ColorMode.\u0024VALUES = colorModeArray;
      }

      [Signature("()V")]
      [LineNumberTable((ushort) 104)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private ColorMode([In] string obj0, [In] int obj1)
      {
        base.\u002Ector(obj0, obj1);
        GC.KeepAlive((object) this);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable((ushort) 104)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static FrameGrabber.ColorMode[] values()
      {
        return (FrameGrabber.ColorMode[]) FrameGrabber.ColorMode.\u0024VALUES.Clone();
      }

      [LineNumberTable((ushort) 104)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static FrameGrabber.ColorMode valueOf(string name)
      {
        return (FrameGrabber.ColorMode) Enum.valueOf((Class) ClassLiteral<FrameGrabber.ColorMode>.Value, name);
      }

      [HideFromJava]
      [Serializable]
      public enum __Enum
      {
        BGR,
        GRAY,
        RAW,
      }
    }

    [InnerClass]
    [SourceFile("FrameGrabber.java")]
    public class PropertyEditor : PropertyEditorSupport
    {
      [LineNumberTable((ushort) 78)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PropertyEditor()
      {
        base.\u002Ector();
      }

      [LineNumberTable(new byte[] {(byte) 30, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getAsText()
      {
        Class @class = (Class) this.getValue();
        return @class != null ? @class.getSimpleName() : "null";
      }

      [LineNumberTable(new byte[] {(byte) 34, (byte) 99, (byte) 135, (byte) 111, (byte) 113, (byte) 110, (byte) 231, (byte) 61, (byte) 230, (byte) 70})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setAsText(string s)
      {
        if (s == null)
          this.setValue((object) null);
        for (int index = 0; index < FrameGrabber.__\u003C\u003Elist.size(); ++index)
        {
          Class @class = (Class) FrameGrabber.__\u003C\u003Elist.get(index);
          if (String.instancehelper_equals(s, (object) @class.getSimpleName()))
            this.setValue((object) @class);
        }
      }

      [LineNumberTable(new byte[] {(byte) 45, (byte) 112, (byte) 111, (byte) 56, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string[] getTags()
      {
        string[] strArray = new string[FrameGrabber.__\u003C\u003Elist.size()];
        for (int index = 0; index < FrameGrabber.__\u003C\u003Elist.size(); ++index)
          strArray[index] = ((Class) FrameGrabber.__\u003C\u003Elist.get(index)).getSimpleName();
        return strArray;
      }
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
