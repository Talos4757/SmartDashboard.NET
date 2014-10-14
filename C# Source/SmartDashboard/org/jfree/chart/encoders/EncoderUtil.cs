// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.encoders.EncoderUtil
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.image;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.encoders
{
  public class EncoderUtil : Object
  {
    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public EncoderUtil()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 83, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImage(BufferedImage image, string format, OutputStream outputStream)
    {
      ImageEncoderFactory.newInstance(format).encode(image, outputStream);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 99, (byte) 137, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImage(BufferedImage image, string format, OutputStream outputStream, float quality)
    {
      ImageEncoderFactory.newInstance(format, quality).encode(image, outputStream);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 96, (byte) 131, (byte) 138, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImage(BufferedImage image, string format, OutputStream outputStream, float quality, bool encodeAlpha)
    {
      int num = encodeAlpha ? 1 : 0;
      ImageEncoderFactory.newInstance(format, quality, num != 0).encode(image, outputStream);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 15, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] encode(BufferedImage image, string format)
    {
      return ImageEncoderFactory.newInstance(format).encode(image);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 130, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] encode(BufferedImage image, string format, float quality, bool encodeAlpha)
    {
      int num = encodeAlpha ? 1 : 0;
      return ImageEncoderFactory.newInstance(format, quality, num != 0).encode(image);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 98, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] encode(BufferedImage image, string format, bool encodeAlpha)
    {
      int num = encodeAlpha ? 1 : 0;
      return ImageEncoderFactory.newInstance(format, num != 0).encode(image);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 48, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] encode(BufferedImage image, string format, float quality)
    {
      return ImageEncoderFactory.newInstance(format, quality).encode(image);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 101, (byte) 130, (byte) 136, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImage(BufferedImage image, string format, OutputStream outputStream, bool encodeAlpha)
    {
      int num = encodeAlpha ? 1 : 0;
      ImageEncoderFactory.newInstance(format, num != 0).encode(image, outputStream);
    }
  }
}
