// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.FlyCaptureFrameGrabber
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using java.util.logging;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  public class FlyCaptureFrameGrabber : FrameGrabber
  {
    private static Exception loadingException;
    public const int INITIALIZE = 0;
    public const int TRIGGER_INQ = 1328;
    public const int IS_CAMERA_POWER = 1024;
    public const int CAMERA_POWER = 1552;
    public const int SOFTWARE_TRIGGER = 1580;
    public const int SOFT_ASYNC_TRIGGER = 4140;
    public const int IMAGE_DATA_FORMAT = 4168;
    private object context;
    private object raw_image;
    private object conv_image;
    private object temp_image;
    private object return_image;
    private int[] regOut;
    private float[] gammaOut;

    static FlyCaptureFrameGrabber()
    {
      FrameGrabber.__\u003Cclinit\u003E();
      FlyCaptureFrameGrabber.loadingException = (Exception) null;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 34, (byte) 232, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlyCaptureFrameGrabber(int deviceNumber)
    {
      FlyCaptureFrameGrabber captureFrameGrabber1 = this;
      FlyCaptureFrameGrabber captureFrameGrabber2 = this;
      GC.KeepAlive((object) this);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.PGRFlyCapture$FlyCaptureContext");
    }

    [HideFromJava]
    ~FlyCaptureFrameGrabber()
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
    [LineNumberTable(new byte[] {(byte) 19, (byte) 103, (byte) 171, (byte) 124, (byte) 97, (byte) 104, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void tryLoad()
    {
      if (FlyCaptureFrameGrabber.loadingException != null)
        throw Throwable.__\u003Cunmap\u003E((Exception) FlyCaptureFrameGrabber.loadingException);
      Exception exception1;
      try
      {
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<PGRFlyCapture>.Value;
        throw new NoClassDefFoundError("com.googlecode.javacpp.Loader");
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception2 = exception1;
      if (exception2 is Exception)
        throw Throwable.__\u003Cunmap\u003E((Exception) (FlyCaptureFrameGrabber.loadingException = (Exception) exception2));
      else
        throw Throwable.__\u003Cunmap\u003E((Exception) (FlyCaptureFrameGrabber.loadingException = new Exception(exception2)));
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 108, (byte) 103, (byte) 159, (byte) 6, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void stop()
    {
      int num = PGRFlyCapture.flycaptureStop(this.context);
      switch (num)
      {
        case 0:
        case 1:
          this.temp_image = (object) null;
          this.return_image = (object) null;
          break;
        default:
          string str = new StringBuilder().append("flycaptureStop() Error ").append(num).toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 45, (byte) 104, (byte) 102, (byte) 108, (byte) 103, (byte) 99, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void release()
    {
      if (this.context == null)
        return;
      this.stop();
      int num = PGRFlyCapture.flycaptureDestroyContext(this.context);
      this.context = (object) null;
      if (num == 0)
        return;
      string str = new StringBuilder().append("flycaptureDestroyContext() Error ").append(num).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 134, (byte) 123, (byte) 99, (byte) 159, (byte) 6, (byte) 112, (byte) 162, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void waitForTriggerReady()
    {
      long num1 = System.currentTimeMillis();
      do
      {
        object pgrfcfcc = this.context;
        int num2 = 1580;
        int[] numArray = this.regOut;
        int i = num2;
        int[] iarr = numArray;
        int cameraRegister = PGRFlyCapture.flycaptureGetCameraRegister(pgrfcfcc, i, iarr);
        if (cameraRegister != 0)
        {
          string str = new StringBuilder().append("flycaptureGetCameraRegister() Error ").append(cameraRegister).toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
      }
      while (System.currentTimeMillis() - num1 <= (long) this.timeout && (int) ((uint) this.regOut[0] >> 31) != 0);
    }

    private int getDepth([In] int obj0)
    {
      int num1 = obj0;
      int num2 = 1;
      if (num1 != num2)
      {
        int num3 = 2;
        if (num1 != num3)
        {
          int num4 = 4;
          if (num1 != num4)
          {
            int num5 = 8;
            if (num1 != num5)
            {
              int num6 = 16;
              if (num1 != num6)
              {
                int num7 = 32;
                if (num1 != num7)
                {
                  int num8 = 64;
                  if (num1 != num8)
                  {
                    int num9 = 128;
                    if (num1 != num9)
                    {
                      int num10 = 256;
                      if (num1 != num10)
                      {
                        int num11 = 512;
                        if (num1 != num11)
                        {
                          int num12 = 1024;
                          if (num1 != num12)
                          {
                            int num13 = 268435457;
                            if (num1 != num13)
                            {
                              int num14 = 268435458;
                              if (num1 != num14)
                                goto label_16;
                              else
                                goto label_13;
                            }
                            else
                              goto label_13;
                          }
                          else
                            goto label_14;
                        }
                        else
                          goto label_13;
                      }
                    }
                    return -2147483632;
                  }
                }
label_14:
                return 16;
              }
              else
                goto label_13;
            }
          }
        }
label_16:
        return 8;
      }
label_13:
      return 8;
    }

    private int getNumChannels([In] int obj0)
    {
      int num1 = obj0;
      int num2 = 1;
      if (num1 != num2)
      {
        int num3 = 2;
        if (num1 != num3)
        {
          int num4 = 4;
          if (num1 != num4)
          {
            int num5 = 8;
            if (num1 != num5)
            {
              int num6 = 16;
              if (num1 != num6)
              {
                int num7 = 32;
                if (num1 != num7)
                {
                  int num8 = 64;
                  if (num1 != num8)
                  {
                    int num9 = 128;
                    if (num1 != num9)
                    {
                      int num10 = 256;
                      if (num1 != num10)
                      {
                        int num11 = 512;
                        if (num1 != num11)
                        {
                          int num12 = 1024;
                          if (num1 != num12)
                          {
                            int num13 = 268435457;
                            if (num1 != num13)
                            {
                              int num14 = 268435458;
                              if (num1 == num14)
                                return 4;
                              else
                                goto label_16;
                            }
                          }
                          else
                            goto label_15;
                        }
                        else
                          goto label_15;
                      }
                    }
                    else
                      goto label_15;
                  }
                }
                else
                  goto label_15;
              }
              return 3;
            }
          }
        }
label_16:
        return -1;
      }
label_15:
      return 1;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 133, (byte) 103, (byte) 103, (byte) 99, (byte) 159, (byte) 6, (byte) 100, (byte) 135, (byte) 100, (byte) 235, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getDeviceDescriptions()
    {
      FlyCaptureFrameGrabber.tryLoad();
      int[] iarr = new int[1];
      int num = PGRFlyCapture.flycaptureBusCameraCount(iarr);
      if (num != 0)
      {
        string str = new StringBuilder().append("flycaptureBusCameraCount() Error ").append(num).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        int length = iarr[0];
        string[] strArray = new string[length];
        if (length > 0)
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.PGRFlyCapture$FlyCaptureInfoEx");
        else
          return strArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 189, (byte) 2, (byte) 97, (byte) 155})]
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
      Logger.getLogger(((Class) ClassLiteral<FlyCaptureFrameGrabber>.Value).getName()).log((Level) Level.SEVERE, (string) null, (Exception) exception2);
    }

    [LineNumberTable((ushort) 130)]
    public override double getGamma()
    {
      return (double) this.gammaOut[0];
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 84, (byte) 99, (byte) 109, (byte) 104, (byte) 113, (byte) 103, (byte) 113, (byte) 103, (byte) 113, (byte) 103, (byte) 113, (byte) 100, (byte) 113, (byte) 100, (byte) 113, (byte) 100, (byte) 113, (byte) 100, (byte) 113, (byte) 162, (byte) 99, (byte) 125, (byte) 114, (byte) 104, (byte) 122, (byte) 103, (byte) 122, (byte) 104, (byte) 122, (byte) 104, (byte) 122, (byte) 104, (byte) 127, (byte) 1, (byte) 136, (byte) 112, (byte) 114, (byte) 104, (byte) 122, (byte) 115, (byte) 122, (byte) 116, (byte) 122, (byte) 113, (byte) 122, (byte) 114, (byte) 122, (byte) 240, (byte) 69, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 127, (byte) 14, (byte) 100, (byte) 159, (byte) 7, (byte) 127, (byte) 14, (byte) 100, (byte) 159, (byte) 7, (byte) 104, (byte) 198, (byte) 127, (byte) 1, (byte) 100, (byte) 191, (byte) 7, (byte) 113, (byte) 142, (byte) 141, (byte) 124, (byte) 100, (byte) 191, (byte) 7, (byte) 119, (byte) 100, (byte) 151, (byte) 100, (byte) 223, (byte) 7, (byte) 109, (byte) 125, (byte) 100, (byte) 191, (byte) 17, (byte) 124, (byte) 100, (byte) 173, (byte) 119, (byte) 100, (byte) 159, (byte) 7, (byte) 119, (byte) 100, (byte) 159, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void start()
    {
      int num1 = 11;
      if (this.frameRate <= 0.0)
        num1 = 11;
      else if (this.frameRate <= 1.876)
        num1 = 0;
      else if (this.frameRate <= 3.76)
        num1 = 1;
      else if (this.frameRate <= 7.51)
        num1 = 2;
      else if (this.frameRate <= 15.01)
        num1 = 3;
      else if (this.frameRate <= 30.01)
        num1 = 4;
      else if (this.frameRate <= 60.01)
        num1 = 6;
      else if (this.frameRate <= 120.01)
        num1 = 7;
      else if (this.frameRate <= 240.01)
        num1 = 8;
      int num2 = 16;
      if (this.colorMode == FrameGrabber.ColorMode.__\u003C\u003EBGR || this.colorMode == FrameGrabber.ColorMode.__\u003C\u003ERAW)
      {
        if (this.imageWidth <= 0 || this.imageHeight <= 0)
          num2 = 16;
        else if (this.imageWidth <= 640 && this.imageHeight <= 480)
          num2 = 4;
        else if (this.imageWidth <= 800 && this.imageHeight <= 600)
          num2 = 18;
        else if (this.imageWidth <= 1024 && this.imageHeight <= 768)
          num2 = 21;
        else if (this.imageWidth <= 1280 && this.imageHeight <= 960)
          num2 = 23;
        else if (this.imageWidth <= 1600 && this.imageHeight <= 1200)
          num2 = 51;
      }
      else if (this.colorMode == FrameGrabber.ColorMode.__\u003C\u003EGRAY)
      {
        if (this.imageWidth <= 0 || this.imageHeight <= 0)
          num2 = 16;
        else if (this.imageWidth <= 640 && this.imageHeight <= 480)
          num2 = this.bpp <= 8 ? 5 : 6;
        else if (this.imageWidth <= 800 && this.imageHeight <= 600)
          num2 = this.bpp <= 8 ? 7 : 19;
        else if (this.imageWidth <= 1024 && this.imageHeight <= 768)
          num2 = this.bpp <= 8 ? 8 : 9;
        else if (this.imageWidth <= 1280 && this.imageHeight <= 960)
          num2 = this.bpp <= 8 ? 10 : 24;
        else if (this.imageWidth <= 1600 && this.imageHeight <= 1200)
          num2 = this.bpp <= 8 ? 11 : 52;
      }
      int[] numArray1 = new int[1];
      int[] numArray2 = new int[1];
      int[] numArray3 = new int[1];
      int[] numArray4 = new int[1];
      object pgrfcfcc1 = this.context;
      // ISSUE: variable of the null type
      __Null local = null;
      int[] numArray5 = numArray1;
      int[] numArray6 = numArray2;
      int[] numArray7 = numArray3;
      int[] numArray8 = numArray4;
      int[] numArray9 = (int[]) null;
      int[] numArray10 = numArray8;
      int[] numArray11 = numArray7;
      int[] numArray12 = numArray6;
      int[] numArray13 = numArray5;
      bool[] barr = (bool[]) local;
      int[] iarr1 = numArray13;
      int[] iarr2 = numArray12;
      int[] iarr3 = numArray11;
      int[] iarr4 = numArray10;
      int[] iarr5 = numArray9;
      int trigger = PGRFlyCapture.flycaptureGetTrigger(pgrfcfcc1, barr, iarr1, iarr2, iarr3, iarr4, iarr5);
      if (trigger != 0)
      {
        string str = new StringBuilder().append("flycaptureGetTrigger() Error ").append(trigger).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        object pgrfcfcc2 = this.context;
        int num3 = this.triggerMode ? 1 : 0;
        int num4 = numArray1[0];
        int num5 = 7;
        int num6 = 0;
        int num7 = 0;
        int num8 = num6;
        int num9 = num5;
        int num10 = num4;
        int num11 = num3 != 0 ? 1 : 0;
        int i1_1 = num10;
        int i2_1 = num9;
        int i3 = num8;
        int i4 = num7;
        int num12 = PGRFlyCapture.flycaptureSetTrigger(pgrfcfcc2, num11 != 0, i1_1, i2_1, i3, i4);
        if (num12 != 0)
        {
          string str = new StringBuilder().append("flycaptureSetTrigger() Error ").append(num12).toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str);
        }
        else
        {
          if (this.triggerMode)
            this.waitForTriggerReady();
          object pgrfcfcc3 = this.context;
          int num13 = 4168;
          int[] numArray14 = this.regOut;
          int i1 = num13;
          int[] iarr = numArray14;
          int cameraRegister = PGRFlyCapture.flycaptureGetCameraRegister(pgrfcfcc3, i1, iarr);
          if (cameraRegister != 0)
          {
            string str = new StringBuilder().append("flycaptureGetCameraRegister() Error ").append(cameraRegister).toString();
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new Exception(str);
          }
          else
          {
            int num14 = !Object.instancehelper_equals((object) ByteOrder.nativeOrder(), (object) ByteOrder.BIG_ENDIAN) ? this.regOut[0] & -2 : this.regOut[0] | 1;
            object pgrfcfcc4 = this.context;
            int num15 = 4168;
            int num16 = num14;
            int i1_2 = num15;
            int i2_2 = num16;
            int num17 = PGRFlyCapture.flycaptureSetCameraRegister(pgrfcfcc4, i1_2, i2_2);
            if (num17 != 0)
            {
              string str = new StringBuilder().append("flycaptureSetCameraRegister() Error ").append(num17).toString();
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new Exception(str);
            }
            else
            {
              object pgrfcfcc5 = this.context;
              int num18 = 7;
              int num19 = 7;
              int i1_3 = num18;
              int i2_3 = num19;
              if (PGRFlyCapture.flycaptureSetBusSpeed(pgrfcfcc5, i1_3, i2_3) != 0)
              {
                object pgrfcfcc6 = this.context;
                int num20 = 8;
                int num21 = 8;
                int i1_4 = num20;
                int i2_4 = num21;
                int num22 = PGRFlyCapture.flycaptureSetBusSpeed(pgrfcfcc6, i1_4, i2_4);
                if (num22 != 0)
                {
                  string str = new StringBuilder().append("flycaptureSetBusSpeed() Error ").append(num22).toString();
                  Throwable.__\u003CsuppressFillInStackTrace\u003E();
                  throw new Exception(str);
                }
              }
              if (this.gamma != 0.0)
              {
                object pgrfcfcc6 = this.context;
                int num20 = 6;
                float num21 = (float) this.gamma;
                int i2 = num20;
                double num22 = (double) num21;
                int num23 = PGRFlyCapture.flycaptureSetCameraAbsProperty(pgrfcfcc6, i2, (float) num22);
                if (num23 != 0)
                {
                  string str = new StringBuilder().append("flycaptureSetCameraAbsProperty() Error ").append(num23).append(": Could not set gamma.").toString();
                  Throwable.__\u003CsuppressFillInStackTrace\u003E();
                  throw new Exception(str);
                }
              }
              object pgrfcfcc7 = this.context;
              int num24 = 6;
              float[] numArray15 = this.gammaOut;
              int i5 = num24;
              float[] farr = numArray15;
              if (PGRFlyCapture.flycaptureGetCameraAbsProperty(pgrfcfcc7, i5, farr) != 0)
                this.gammaOut[0] = 2.2f;
              object pgrfcfcc8 = this.context;
              int num25 = num2;
              int num26 = num1;
              int i1_5 = num25;
              int i2_5 = num26;
              int num27 = PGRFlyCapture.flycaptureStart(pgrfcfcc8, i1_5, i2_5);
              if (num27 != 0)
              {
                string str = new StringBuilder().append("flycaptureStart() Error ").append(num27).toString();
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new Exception(str);
              }
              else
              {
                int num20 = PGRFlyCapture.flycaptureSetGrabTimeoutEx(this.context, this.timeout);
                if (num20 == 0)
                  return;
                string str = new StringBuilder().append("flycaptureSetGrabTimeoutEx() Error ").append(num20).toString();
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new Exception(str);
              }
            }
          }
        }
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 102, (byte) 122, (byte) 99, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void trigger()
    {
      this.waitForTriggerReady();
      object pgrfcfcc = this.context;
      int num1 = 4140;
      int num2 = int.MinValue;
      int i1 = num1;
      int i2 = num2;
      int num3 = PGRFlyCapture.flycaptureSetCameraRegister(pgrfcfcc, i1, i2);
      if (num3 == 0)
        return;
      string str = new StringBuilder().append("flycaptureSetCameraRegister() Error ").append(num3).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 116, (byte) 99, (byte) 191, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object grab()
    {
      int num = PGRFlyCapture.flycaptureGrabImage2(this.context, this.raw_image);
      if (num != 0)
      {
        string str = new StringBuilder().append("flycaptureGrabImage2() Error ").append(num).append(" (Has start() been called?)").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        object obj = this.raw_image;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.PGRFlyCapture$FlyCaptureImage");
      }
    }
  }
}
