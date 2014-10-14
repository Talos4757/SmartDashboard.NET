// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.encoders.ImageEncoderFactory
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.encoders
{
  public class ImageEncoderFactory : Object
  {
    private static Hashtable encoders = (Hashtable) null;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 6, (byte) 166, (byte) 103})]
    static ImageEncoderFactory()
    {
      ImageEncoderFactory.init();
    }

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageEncoderFactory()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 98, (byte) 113, (byte) 99, (byte) 223, (byte) 6, (byte) 108, (byte) 223, (byte) 9, (byte) 2, (byte) 98, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ImageEncoder newInstance(string format)
    {
      string str1 = (string) ImageEncoderFactory.encoders.get((object) format);
      if (str1 == null)
      {
        string str2 = new StringBuffer().append("Unsupported image format - ").append(format).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str2);
      }
      else
      {
        Exception exception;
        try
        {
          return (ImageEncoder) Class.forName(str1, ImageEncoderFactory.__\u003CGetCallerID\u003E()).newInstance(ImageEncoderFactory.__\u003CGetCallerID\u003E());
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
            throw;
          else
            exception = (Exception) m0;
        }
        string str2 = Throwable.instancehelper_toString((Exception) exception);
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 106, (byte) 66, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ImageEncoder newInstance(string format, bool encodingAlpha)
    {
      int num = encodingAlpha ? 1 : 0;
      ImageEncoder mageEncoder = ImageEncoderFactory.newInstance(format);
      mageEncoder.setEncodingAlpha(num != 0);
      return mageEncoder;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ImageEncoder newInstance(string format, float quality)
    {
      ImageEncoder mageEncoder = ImageEncoderFactory.newInstance(format);
      mageEncoder.setQuality(quality);
      return mageEncoder;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 66, (byte) 103, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ImageEncoder newInstance(string format, float quality, bool encodingAlpha)
    {
      int num = encodingAlpha ? 1 : 0;
      ImageEncoder mageEncoder = ImageEncoderFactory.newInstance(format);
      mageEncoder.setQuality(quality);
      mageEncoder.setEncodingAlpha(num != 0);
      return mageEncoder;
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 106, (byte) 181, (byte) 144, (byte) 112, (byte) 149, (byte) 255, (byte) 1, (byte) 70, (byte) 226, (byte) 61, (byte) 97, (byte) 181})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void init()
    {
      ImageEncoderFactory.encoders = new Hashtable();
      ImageEncoderFactory.encoders.put((object) "jpeg", (object) "org.jfree.chart.encoders.SunJPEGEncoderAdapter");
      try
      {
        Class.forName("javax.imageio.ImageIO", ImageEncoderFactory.__\u003CGetCallerID\u003E());
        Class.forName("org.jfree.chart.encoders.SunPNGEncoderAdapter", ImageEncoderFactory.__\u003CGetCallerID\u003E());
        ImageEncoderFactory.encoders.put((object) "png", (object) "org.jfree.chart.encoders.SunPNGEncoderAdapter");
        ImageEncoderFactory.encoders.put((object) "jpeg", (object) "org.jfree.chart.encoders.SunJPEGEncoderAdapter");
        return;
      }
      catch (ClassNotFoundException ex)
      {
      }
      ImageEncoderFactory.encoders.put((object) "png", (object) "org.jfree.chart.encoders.KeypointPNGEncoderAdapter");
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setImageEncoder(string format, string imageEncoderClassName)
    {
      ImageEncoderFactory.encoders.put((object) format, (object) imageEncoderClassName);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ImageEncoderFactory.__\u003CcallerID\u003E == null)
        ImageEncoderFactory.__\u003CcallerID\u003E = (CallerID) new ImageEncoderFactory.__\u003CCallerID\u003E();
      return ImageEncoderFactory.__\u003CcallerID\u003E;
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
