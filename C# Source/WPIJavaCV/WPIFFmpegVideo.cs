// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIFFmpegVideo
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;

namespace edu.wpi.first.wpijavacv
{
  public class WPIFFmpegVideo : WPIDisposable
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<WPIFFmpegVideo>.Value).desiredAssertionStatus();
    private object grabber;
    private object image;
    private bool readImage;
    private bool badConnection;
    [Modifiers]
    private object imageLock;
    [Modifiers]
    private object grabberLock;

    [LineNumberTable((ushort) 11)]
    static WPIFFmpegVideo()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 232, (byte) 59, (byte) 103, (byte) 103, (byte) 107, (byte) 171, (byte) 236, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIFFmpegVideo(string path)
    {
      WPIFFmpegVideo wpifFmpegVideo = this;
      this.readImage = true;
      this.badConnection = false;
      this.imageLock = (object) new Object();
      this.grabberLock = (object) new Object();
      new WPIFFmpegVideo\u00241(this, path).start();
      GC.KeepAlive((object) this);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"edu.wpi.first.wpijavacv.WPIFFmpegVideo$BadConnectionException"})]
    [LineNumberTable(new byte[] {(byte) 48, (byte) 134, (byte) 109, (byte) 235, (byte) 82, (byte) 233, (byte) 47, (byte) 144, (byte) 103, (byte) 159, (byte) 5, (byte) 228, (byte) 76, (byte) 236, (byte) 51, (byte) 97, (byte) 130, (byte) 135, (byte) 104, (byte) 107, (byte) 241, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIImage getNewImage(double timeout)
    {
      this.validateDisposed();
      object obj1;
      Monitor.Enter(obj1 = this.imageLock);
      // ISSUE: fault handler
      try
      {
        this.readImage = true;
      }
      __fault
      {
        Monitor.Exit(obj1);
      }
      while (true)
      {
        // ISSUE: fault handler
        try
        {
          if (this.readImage)
          {
            if (!this.badConnection)
            {
              try
              {
                this.badConnection = true;
                Object.instancehelper_wait(this.imageLock, ByteCodeHelper.d2l(timeout * 1000.0));
              }
              catch (InterruptedException ex)
              {
              }
            }
            else
              break;
          }
          else
            break;
        }
        __fault
        {
          Monitor.Exit(obj1);
        }
      }
      // ISSUE: fault handler
      try
      {
        this.readImage = true;
        if (this.badConnection)
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new WPIFFmpegVideo.BadConnectionException();
        }
        else
        {
          object obj2 = this.image;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        }
      }
      __fault
      {
        Monitor.Exit(obj1);
      }
    }

    [Throws(new string[] {"edu.wpi.first.wpijavacv.WPIFFmpegVideo$BadConnectionException"})]
    [LineNumberTable(new byte[] {(byte) 31, (byte) 134, (byte) 109, (byte) 104, (byte) 107, (byte) 104, (byte) 106, (byte) 241, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIImage getImage()
    {
      this.validateDisposed();
      object obj1;
      Monitor.Enter(obj1 = this.imageLock);
      // ISSUE: fault handler
      try
      {
        if (this.badConnection)
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new WPIFFmpegVideo.BadConnectionException();
        }
        else if (this.image == null)
        {
          // ISSUE: variable of the null type
          __Null local = null;
          Monitor.Exit(obj1);
          return (WPIImage) local;
        }
        else
        {
          object obj2 = this.image;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        }
      }
      __fault
      {
        Monitor.Exit(obj1);
      }
    }

    [Throws(new string[] {"edu.wpi.first.wpijavacv.WPIFFmpegVideo$BadConnectionException"})]
    [LineNumberTable((ushort) 123)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIImage getNewImage()
    {
      return this.getNewImage(0.0);
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 109, (byte) 109, (byte) 145, (byte) 103, (byte) 159, (byte) 45, (byte) 34, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void disposed()
    {
      object obj1;
      Exception exception1;
      try
      {
        Monitor.Enter(obj1 = this.imageLock);
        try
        {
          if (!WPIDisposable.isNull(this.image))
          {
            object obj2 = this.image;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
          }
          else
          {
            this.image = (object) null;
            Monitor.Exit(obj1);
            return;
          }
        }
        catch (Exception ex)
        {
          int num = 0;
          exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_8;
      }
      Exception exception2 = exception1;
      try
      {
        Exception exception3 = exception2;
        Monitor.Exit(obj1);
        throw Throwable.__\u003Cunmap\u003E(exception3);
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      // ISSUE: variable of the null type
      __Null local = null;
      goto label_13;
label_8:
      local = null;
label_13:;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 148)]
    protected internal override void finalize()
    {
      object obj = this.grabber;
      throw new NoClassDefFoundError("com.googlecode.javacv.FFmpegFrameGrabber");
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static object access\u0024002([In] WPIFFmpegVideo obj0, [In] object obj1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj1, __typeref (WPIFFmpegVideo), "com.googlecode.javacv.FFmpegFrameGrabber");
      WPIFFmpegVideo wpifFmpegVideo1 = obj0;
      object obj2 = obj1;
      WPIFFmpegVideo wpifFmpegVideo2 = wpifFmpegVideo1;
      object obj3 = obj2;
      wpifFmpegVideo2.grabber = obj2;
      return obj3;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static object access\u0024000([In] WPIFFmpegVideo obj0)
    {
      return obj0.grabber;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static object access\u0024100([In] WPIFFmpegVideo obj0)
    {
      return obj0.grabberLock;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static object access\u0024200([In] WPIFFmpegVideo obj0)
    {
      return obj0.imageLock;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static bool access\u0024302([In] WPIFFmpegVideo obj0, [In] bool obj1)
    {
      int num1 = obj1 ? 1 : 0;
      WPIFFmpegVideo wpifFmpegVideo1 = obj0;
      int num2 = num1;
      WPIFFmpegVideo wpifFmpegVideo2 = wpifFmpegVideo1;
      int num3 = num2;
      wpifFmpegVideo2.badConnection = num2 != 0;
      return num3 != 0;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static object access\u0024400([In] WPIFFmpegVideo obj0)
    {
      return obj0.image;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static object access\u0024402([In] WPIFFmpegVideo obj0, [In] object obj1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj1, __typeref (WPIFFmpegVideo), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      WPIFFmpegVideo wpifFmpegVideo1 = obj0;
      object obj2 = obj1;
      WPIFFmpegVideo wpifFmpegVideo2 = wpifFmpegVideo1;
      object obj3 = obj2;
      wpifFmpegVideo2.image = obj2;
      return obj3;
    }

    [Modifiers]
    [LineNumberTable((ushort) 11)]
    internal static bool access\u0024502([In] WPIFFmpegVideo obj0, [In] bool obj1)
    {
      int num1 = obj1 ? 1 : 0;
      WPIFFmpegVideo wpifFmpegVideo1 = obj0;
      int num2 = num1;
      WPIFFmpegVideo wpifFmpegVideo2 = wpifFmpegVideo1;
      int num3 = num2;
      wpifFmpegVideo2.readImage = num2 != 0;
      return num3 != 0;
    }

    [InnerClass]
    [SourceFile("WPIFFmpegVideo.java")]
    [Serializable]
    public class BadConnectionException : Exception
    {
      [LineNumberTable((ushort) 143)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BadConnectionException()
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BadConnectionException([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }
    }
  }
}
