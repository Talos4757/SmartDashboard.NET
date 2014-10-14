// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.DC1394FrameGrabber
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.logging;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  public class DC1394FrameGrabber : FrameGrabber
  {
    private static Exception loadingException;
    [Modifiers]
    private static bool linux;
    private object d;
    private object camera;
    private object fds;
    private bool oneShotMode;
    private bool resetDone;
    private object raw_image;
    private object conv_image;
    private object frame;
    private object enqueue_image;
    private object temp_image;
    private object return_image;
    private float[] gammaOut;
    [Modifiers]
    internal static bool \u0024assertionsDisabled;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 165, (byte) 245, (byte) 100, (byte) 230, (byte) 122})]
    static DC1394FrameGrabber()
    {
      FrameGrabber.__\u003Cclinit\u003E();
      DC1394FrameGrabber.\u0024assertionsDisabled = !((Class) ClassLiteral<DC1394FrameGrabber>.Value).desiredAssertionStatus();
      DC1394FrameGrabber.loadingException = (Exception) null;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 42, (byte) 232, (byte) 106, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DC1394FrameGrabber(int deviceNumber)
    {
      DC1394FrameGrabber dc1394FrameGrabber1 = this;
      this.d = (object) null;
      this.camera = (object) null;
      DC1394FrameGrabber dc1394FrameGrabber2 = this;
      GC.KeepAlive((object) this);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.dc1394$pollfd");
    }

    [HideFromJava]
    ~DC1394FrameGrabber()
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
    [LineNumberTable(new byte[] {(byte) 27, (byte) 103, (byte) 171, (byte) 124, (byte) 97, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void tryLoad()
    {
      if (DC1394FrameGrabber.loadingException != null)
        throw Throwable.__\u003Cunmap\u003E((Exception) DC1394FrameGrabber.loadingException);
      Exception exception1;
      try
      {
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<dc1394>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception2 = exception1;
      if (exception2 is Exception)
        throw Throwable.__\u003Cunmap\u003E((Exception) (DC1394FrameGrabber.loadingException = (Exception) exception2));
      else
        throw Throwable.__\u003Cunmap\u003E((Exception) (DC1394FrameGrabber.loadingException = new Exception(exception2)));
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 218, (byte) 103, (byte) 103, (byte) 135, (byte) 111, (byte) 99, (byte) 159, (byte) 16, (byte) 108, (byte) 104, (byte) 159, (byte) 16, (byte) 112, (byte) 111, (byte) 99, (byte) 191, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void stop()
    {
      this.enqueue_image = (object) null;
      this.temp_image = (object) null;
      this.return_image = (object) null;
      int num1 = dc1394.dc1394_video_set_transmission(this.camera, 0);
      if (num1 != 0)
      {
        string str = new StringBuilder().append("dc1394_video_set_transmission() Error ").append(num1).append(": Could not stop the camera?").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        int num2 = dc1394.dc1394_capture_stop(this.camera);
        switch (num2)
        {
          case 0:
          case -10:
            if (!this.triggerMode || this.oneShotMode)
              break;
            int num3 = dc1394.dc1394_external_trigger_set_power(this.camera, 0);
            if (num3 == 0)
              break;
            string str1 = new StringBuilder().append("dc1394_external_trigger_set_power() Error ").append(num3).append(": Could not switch off external trigger.").toString();
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new Exception(str1);
          default:
            string str2 = new StringBuilder().append("dc1394_capture_stop() Error ").append(num2).append(": Could not stop the camera?").toString();
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new Exception(str2);
        }
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 65, (byte) 104, (byte) 102, (byte) 107, (byte) 135, (byte) 104, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      if (this.camera != null)
      {
        this.stop();
        dc1394.dc1394_camera_free(this.camera);
        this.camera = (object) null;
      }
      if (this.d == null)
        return;
      dc1394.dc1394_free(this.d);
      this.d = (object) null;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 164, (byte) 98, (byte) 125, (byte) 114, (byte) 103, (byte) 122, (byte) 104, (byte) 122, (byte) 104, (byte) 122, (byte) 104, (byte) 122, (byte) 104, (byte) 127, (byte) 1, (byte) 136, (byte) 112, (byte) 114, (byte) 103, (byte) 122, (byte) 117, (byte) 122, (byte) 117, (byte) 122, (byte) 114, (byte) 122, (byte) 114, (byte) 122, (byte) 208, (byte) 132, (byte) 103, (byte) 113, (byte) 164, (byte) 99, (byte) 109, (byte) 104, (byte) 113, (byte) 105, (byte) 113, (byte) 105, (byte) 113, (byte) 105, (byte) 113, (byte) 102, (byte) 113, (byte) 102, (byte) 113, (byte) 102, (byte) 113, (byte) 102, (byte) 113, (byte) 164, (byte) 133, (byte) 104, (byte) 114, (byte) 198, (byte) 103, (byte) 107, (byte) 114, (byte) 132, (byte) 137, (byte) 117, (byte) 118, (byte) 132, (byte) 103, (byte) 241, (byte) 69, (byte) 118, (byte) 99, (byte) 118, (byte) 100, (byte) 178, (byte) 103, (byte) 114, (byte) 100, (byte) 223, (byte) 17, (byte) 114, (byte) 100, (byte) 191, (byte) 17, (byte) 108, (byte) 223, (byte) 17, (byte) 103, (byte) 191, (byte) 17, (byte) 115, (byte) 100, (byte) 223, (byte) 17, (byte) 124, (byte) 100, (byte) 223, (byte) 27, (byte) 109, (byte) 127, (byte) 2, (byte) 100, (byte) 191, (byte) 17, (byte) 127, (byte) 1, (byte) 100, (byte) 173, (byte) 103, (byte) 188, (byte) 104, (byte) 114, (byte) 100, (byte) 255, (byte) 34, (byte) 78, (byte) 78, (byte) 103, (byte) 230, (byte) 52, (byte) 130, (byte) 107, (byte) 108, (byte) 104, (byte) 103, (byte) 138, (byte) 170, (byte) 74, (byte) 98, (byte) 130, (byte) 106, (byte) 104, (byte) 134, (byte) 242, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void start(bool tryReset, bool try1394b)
    {
      int num1 = try1394b ? 1 : 0;
      int num2 = tryReset ? 1 : 0;
      int i1 = -1;
      if (this.colorMode == FrameGrabber.ColorMode.__\u003C\u003EBGR || this.colorMode == FrameGrabber.ColorMode.__\u003C\u003ERAW)
      {
        if (this.imageWidth <= 0 || this.imageHeight <= 0)
          i1 = -1;
        else if (this.imageWidth <= 640 && this.imageHeight <= 480)
          i1 = 68;
        else if (this.imageWidth <= 800 && this.imageHeight <= 600)
          i1 = 72;
        else if (this.imageWidth <= 1024 && this.imageHeight <= 768)
          i1 = 75;
        else if (this.imageWidth <= 1280 && this.imageHeight <= 960)
          i1 = 80;
        else if (this.imageWidth <= 1600 && this.imageHeight <= 1200)
          i1 = 83;
      }
      else if (this.colorMode == FrameGrabber.ColorMode.__\u003C\u003EGRAY)
      {
        if (this.imageWidth <= 0 || this.imageHeight <= 0)
          i1 = -1;
        else if (this.imageWidth <= 640 && this.imageHeight <= 480)
          i1 = this.bpp <= 8 ? 69 : 70;
        else if (this.imageWidth <= 800 && this.imageHeight <= 600)
          i1 = this.bpp <= 8 ? 73 : 77;
        else if (this.imageWidth <= 1024 && this.imageHeight <= 768)
          i1 = this.bpp <= 8 ? 76 : 78;
        else if (this.imageWidth <= 1280 && this.imageHeight <= 960)
          i1 = this.bpp <= 8 ? 81 : 85;
        else if (this.imageWidth <= 1600 && this.imageHeight <= 1200)
          i1 = this.bpp <= 8 ? 84 : 86;
      }
      if (i1 == -1)
      {
        int[] iarr = new int[1];
        dc1394.dc1394_video_get_mode(this.camera, iarr);
        i1 = iarr[0];
      }
      int i2 = -1;
      if (this.frameRate <= 0.0)
        i2 = -1;
      else if (this.frameRate <= 1.876)
        i2 = 32;
      else if (this.frameRate <= 3.76)
        i2 = 33;
      else if (this.frameRate <= 7.51)
        i2 = 34;
      else if (this.frameRate <= 15.01)
        i2 = 35;
      else if (this.frameRate <= 30.01)
        i2 = 36;
      else if (this.frameRate <= 60.01)
        i2 = 37;
      else if (this.frameRate <= 120.01)
        i2 = 38;
      else if (this.frameRate <= 240.01)
        i2 = 39;
      if (i2 == -1)
      {
        int[] iarr = new int[1];
        dc1394.dc1394_video_get_framerate(this.camera, iarr);
        i2 = iarr[0];
      }
      Exception exception1;
      // ISSUE: fault handler
      try
      {
        this.oneShotMode = false;
        if (this.triggerMode)
        {
          if (dc1394.dc1394_external_trigger_set_power(this.camera, 1) != 0)
          {
            this.oneShotMode = true;
          }
          else
          {
            dc1394.dc1394_external_trigger_set_mode(this.camera, 384);
            if (dc1394.dc1394_external_trigger_set_source(this.camera, 580) != 0)
            {
              this.oneShotMode = true;
              dc1394.dc1394_external_trigger_set_power(this.camera, 0);
            }
          }
        }
        int num3 = dc1394.dc1394_video_set_operation_mode(this.camera, 480);
        if (num1 != 0)
        {
          num3 = dc1394.dc1394_video_set_operation_mode(this.camera, 481);
          if (num3 == 0)
            num3 = dc1394.dc1394_video_set_iso_speed(this.camera, 3);
        }
        if (num3 != 0 || num1 == 0)
        {
          int num4 = dc1394.dc1394_video_set_iso_speed(this.camera, 2);
          if (num4 != 0)
          {
            string str = new StringBuilder().append("dc1394_video_set_iso_speed() Error ").append(num4).append(": Could not set maximum iso speed.").toString();
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new Exception(str);
          }
        }
        int num5 = dc1394.dc1394_video_set_mode(this.camera, i1);
        if (num5 != 0)
        {
          string str = new StringBuilder().append("dc1394_video_set_mode() Error ").append(num5).append(": Could not set video mode.").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
        else
        {
          if (dc1394.dc1394_is_video_mode_scalable(i1) == 1)
          {
            object obj = this.camera;
            int num4 = i1;
            int num6 = -1;
            int num7 = -1;
            int num8 = -1;
            int num9 = -1;
            int num10 = -1;
            int num11 = -1;
            int num12 = num10;
            int num13 = num9;
            int num14 = num8;
            int num15 = num7;
            int num16 = num6;
            int i1_1 = num4;
            int i2_1 = num16;
            int i3 = num15;
            int i4 = num14;
            int i5 = num13;
            int i6 = num12;
            int i7 = num11;
            int num17 = dc1394.dc1394_format7_set_roi(obj, i1_1, i2_1, i3, i4, i5, i6, i7);
            if (num17 != 0)
            {
              string str = new StringBuilder().append("dc1394_format7_set_roi() Error ").append(num17).append(": Could not set format7 mode.").toString();
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new Exception(str);
            }
          }
          else
          {
            int num4 = dc1394.dc1394_video_set_framerate(this.camera, i2);
            if (num4 != 0)
            {
              string str = new StringBuilder().append("dc1394_video_set_framerate() Error ").append(num4).append(": Could not set framerate.").toString();
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new Exception(str);
            }
          }
          object obj1 = this.camera;
          int num18 = this.numBuffers;
          int num19 = 4;
          int i1_2 = num18;
          int i2_2 = num19;
          int num20 = dc1394.dc1394_capture_setup(obj1, i1_2, i2_2);
          if (num20 != 0)
          {
            string str = new StringBuilder().append("dc1394_capture_setup() Error ").append(num20).append(": Could not setup camera-\n").append("make sure that the video mode and framerate are\nsupported by your camera.").toString();
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new Exception(str);
          }
          else
          {
            if (this.gamma != 0.0)
            {
              object obj2 = this.camera;
              int num4 = 422;
              float num6 = (float) this.gamma;
              int i3 = num4;
              double num7 = (double) num6;
              int num8 = dc1394.dc1394_feature_set_absolute_value(obj2, i3, (float) num7);
              if (num8 != 0)
              {
                string str = new StringBuilder().append("dc1394_feature_set_absolute_value() Error ").append(num8).append(": Could not set gamma.").toString();
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new Exception(str);
              }
            }
            object obj3 = this.camera;
            int num9 = 422;
            float[] numArray = this.gammaOut;
            int i4 = num9;
            float[] farr = numArray;
            if (dc1394.dc1394_feature_get_absolute_value(obj3, i4, farr) != 0)
              this.gammaOut[0] = 2.2f;
            if (DC1394FrameGrabber.linux)
            {
              object obj2 = this.fds;
              dc1394.dc1394_capture_get_fileno(this.camera);
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.dc1394$pollfd");
            }
            else if (!this.oneShotMode)
            {
              int num4 = dc1394.dc1394_video_set_transmission(this.camera, 1);
              if (num4 != 0)
              {
                string str = new StringBuilder().append("dc1394_video_set_transmission() Error ").append(num4).append(": Could not start camera iso transmission.").toString();
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new Exception(str);
              }
              else
                goto label_83;
            }
            else
              goto label_83;
          }
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num3);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      __fault
      {
        this.resetDone = false;
      }
      Exception exception2 = exception1;
      try
      {
        Exception exception3 = exception2;
        if (num2 == 0 || this.resetDone)
          throw Throwable.__\u003Cunmap\u003E((Exception) exception3);
        dc1394.dc1394_reset_bus(this.camera);
        Thread.sleep(100L);
        this.resetDone = true;
        this.start(false, num1 != 0);
        goto label_89;
      }
      finally
      {
        this.resetDone = false;
      }
label_83:
      this.resetDone = false;
label_89:
      if (!DC1394FrameGrabber.linux || num1 == 0)
        return;
      if (this.triggerMode)
        this.trigger();
      object obj4 = this.fds;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.dc1394$pollfd");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 102, (byte) 104, (byte) 111, (byte) 99, (byte) 159, (byte) 16, (byte) 101, (byte) 102, (byte) 135, (byte) 113, (byte) 112, (byte) 162, (byte) 102, (byte) 112, (byte) 100, (byte) 191, (byte) 17})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void trigger()
    {
      this.enqueue();
      if (this.oneShotMode)
      {
        int num = dc1394.dc1394_video_set_one_shot(this.camera, 1);
        if (num == 0)
          return;
        string str = new StringBuilder().append("dc1394_video_set_one_shot() Error ").append(num).append(": Could not set camera into one-shot mode.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        long num1 = System.currentTimeMillis();
        int[] iarr = new int[1];
        do
        {
          dc1394.dc1394_software_trigger_get_power(this.camera, iarr);
        }
        while (System.currentTimeMillis() - num1 <= (long) this.timeout && iarr[0] == 1);
        int num2 = dc1394.dc1394_software_trigger_set_power(this.camera, 1);
        if (num2 == 0)
          return;
        string str = new StringBuilder().append("dc1394_software_trigger_set_power() Error ").append(num2).append(": Could not trigger camera.").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 20, (byte) 102, (byte) 103, (byte) 242, (byte) 69, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object grab()
    {
      this.enqueue();
      if (DC1394FrameGrabber.linux)
      {
        object obj = this.fds;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.dc1394$pollfd");
      }
      else
      {
        object obj1 = this.camera;
        object obj2 = this.raw_image;
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.dc1394$dc1394video_frame_t;");
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void enqueue()
    {
      this.enqueue(this.enqueue_image);
      this.enqueue_image = (object) null;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 53, (byte) 113, (byte) 99, (byte) 111, (byte) 99, (byte) 191, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void enqueue([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (DC1394FrameGrabber), "com.googlecode.javacv.cpp.dc1394$dc1394video_frame_t");
      if (obj0 == null)
        return;
      int num = dc1394.dc1394_capture_enqueue(this.camera, obj0);
      if (num == 0)
        return;
      string str = new StringBuilder().append("dc1394_capture_enqueue() Error ").append(num).append(": Could not release a frame.").toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 133, (byte) 102, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getDeviceDescriptions()
    {
      DC1394FrameGrabber.tryLoad();
      if (dc1394.dc1394_new() != null)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.dc1394$dc1394camera_list_t");
      string str = "dc1394_new() Error: Failed to initialize libdc1394.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 189, (byte) 2, (byte) 97, (byte) 155})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void finalize()
    {
      Exception exception1;
      try
      {
        this.release();
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      Exception exception2 = exception1;
      Logger.getLogger(((Class) ClassLiteral<DC1394FrameGrabber>.Value).getName()).log((Level) Level.SEVERE, (string) null, (Exception) exception2);
    }

    [LineNumberTable((ushort) 148)]
    public override double getGamma()
    {
      return (double) this.gammaOut[0];
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 102, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void start()
    {
      this.start(true, true);
    }
  }
}
