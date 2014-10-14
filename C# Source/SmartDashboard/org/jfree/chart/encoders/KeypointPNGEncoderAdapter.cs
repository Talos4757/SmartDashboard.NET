// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.encoders.KeypointPNGEncoderAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using com.keypoint;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.image;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.encoders
{
  [Implements(new string[] {"org.jfree.chart.encoders.ImageEncoder"})]
  public class KeypointPNGEncoderAdapter : Object, ImageEncoder
  {
    private int quality;
    private bool encodingAlpha;

    [LineNumberTable(new byte[] {(byte) 5, (byte) 168, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public KeypointPNGEncoderAdapter()
    {
      base.\u002Ector();
      KeypointPNGEncoderAdapter pngEncoderAdapter = this;
      this.quality = 9;
      this.encodingAlpha = false;
    }

    public virtual float getQuality()
    {
      return (float) this.quality;
    }

    public virtual void setQuality(float quality)
    {
      this.quality = ByteCodeHelper.f2i(quality);
    }

    public virtual bool isEncodingAlpha()
    {
      return this.encodingAlpha;
    }

    public virtual void setEncodingAlpha(bool encodingAlpha)
    {
      this.encodingAlpha = encodingAlpha;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 63, (byte) 99, (byte) 144, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual byte[] encode(BufferedImage bufferedImage)
    {
      if (bufferedImage == null)
      {
        string str = "Null 'image' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        PngEncoder.__\u003Cclinit\u003E();
        return new PngEncoder((Image) bufferedImage, this.encodingAlpha, 0, this.quality).pngEncode();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 81, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 153, (byte) 110})]
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
      {
        PngEncoder.__\u003Cclinit\u003E();
        PngEncoder pngEncoder = new PngEncoder((Image) bufferedImage, this.encodingAlpha, 0, this.quality);
        outputStream.write(pngEncoder.pngEncode());
      }
    }
  }
}
