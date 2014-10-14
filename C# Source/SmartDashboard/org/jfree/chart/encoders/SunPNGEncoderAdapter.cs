// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.encoders.SunPNGEncoderAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.image;
using java.io;
using java.lang;
using javax.imageio;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.encoders
{
  [Implements(new string[] {"org.jfree.chart.encoders.ImageEncoder"})]
  public class SunPNGEncoderAdapter : Object, ImageEncoder
  {
    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SunPNGEncoderAdapter()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 71, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void encode(BufferedImage bufferedImage, OutputStream outputStream)
    {
      if (bufferedImage == null)
      {
        string str = "Null 'image' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (outputStream == null)
      {
        string str = "Null 'outputStream' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        ImageIO.write((RenderedImage) bufferedImage, "png", outputStream);
    }

    public virtual float getQuality()
    {
      return 0.0f;
    }

    public virtual void setQuality(float quality)
    {
    }

    public virtual bool isEncodingAlpha()
    {
      return false;
    }

    public virtual void setEncodingAlpha(bool encodingAlpha)
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 57, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual byte[] encode(BufferedImage bufferedImage)
    {
      ByteArrayOutputStream arrayOutputStream = new ByteArrayOutputStream();
      this.encode(bufferedImage, (OutputStream) arrayOutputStream);
      return arrayOutputStream.toByteArray();
    }
  }
}
