// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.encoders.SunJPEGEncoderAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.image;
using java.io;
using java.lang;
using java.util;
using javax.imageio;
using javax.imageio.metadata;
using javax.imageio.stream;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.encoders
{
  [Implements(new string[] {"org.jfree.chart.encoders.ImageEncoder"})]
  public class SunJPEGEncoderAdapter : Object, ImageEncoder
  {
    private float quality;

    [LineNumberTable(new byte[] {(byte) 24, (byte) 232, (byte) 59, (byte) 235, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SunJPEGEncoderAdapter()
    {
      base.\u002Ector();
      SunJPEGEncoderAdapter jpegEncoderAdapter = this;
      this.quality = 0.95f;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 108, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 107, (byte) 108, (byte) 103, (byte) 103, (byte) 108, (byte) 103, (byte) 103, (byte) 112, (byte) 102, (byte) 102, (byte) 104})]
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
        ImageWriter imageWriter = (ImageWriter) ImageIO.getImageWritersByFormatName("jpeg").next();
        ImageWriteParam defaultWriteParam = imageWriter.getDefaultWriteParam();
        defaultWriteParam.setCompressionMode(2);
        defaultWriteParam.setCompressionQuality(this.quality);
        ImageOutputStream imageOutputStream = ImageIO.createImageOutputStream((object) outputStream);
        imageWriter.setOutput((object) imageOutputStream);
        imageWriter.write((IIOMetadata) null, new IIOImage((RenderedImage) bufferedImage, (List) null, (IIOMetadata) null), defaultWriteParam);
        ((ImageInputStream) imageOutputStream).flush();
        imageWriter.dispose();
        ((ImageInputStream) imageOutputStream).close();
      }
    }

    public virtual float getQuality()
    {
      return this.quality;
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 114, (byte) 176, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setQuality(float quality)
    {
      if ((double) quality < 0.0 || (double) quality > 1.0)
      {
        string str = "The 'quality' must be in the range 0.0f to 1.0f";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.quality = quality;
    }

    public virtual bool isEncodingAlpha()
    {
      return false;
    }

    public virtual void setEncodingAlpha(bool encodingAlpha)
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 89, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual byte[] encode(BufferedImage bufferedImage)
    {
      ByteArrayOutputStream arrayOutputStream = new ByteArrayOutputStream();
      this.encode(bufferedImage, (OutputStream) arrayOutputStream);
      return arrayOutputStream.toByteArray();
    }
  }
}
