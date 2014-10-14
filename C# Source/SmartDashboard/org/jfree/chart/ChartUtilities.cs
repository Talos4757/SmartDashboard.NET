// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.awt.image;
using java.io;
using java.lang;
using org.jfree.chart.encoders;
using org.jfree.chart.imagemap;
using System.Runtime.CompilerServices;

namespace org.jfree.chart
{
  public abstract class ChartUtilities : Object
  {
    [LineNumberTable((ushort) 107)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartUtilities()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsPNG(File file, JFreeChart chart, int width, int height)
    {
      ChartUtilities.saveChartAsPNG(file, chart, width, height, (ChartRenderingInfo) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 99, (byte) 144, (byte) 139, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsPNG(OutputStream @out, JFreeChart chart, int width, int height, ChartRenderingInfo info)
    {
      if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        EncoderUtil.writeBufferedImage(chart.createBufferedImage(width, height, info), "png", @out);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 90, (byte) 99, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 140, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsPNG(OutputStream @out, JFreeChart chart, int width, int height, ChartRenderingInfo info, bool encodeAlpha, int compression)
    {
      int num = encodeAlpha ? 1 : 0;
      if (@out == null)
      {
        string str = "Null 'out' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        BufferedImage bufferedImage = chart.createBufferedImage(width, height, 2, info);
        ChartUtilities.writeBufferedImageAsPNG(@out, bufferedImage, num != 0, compression);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 158, (byte) 241, (byte) 66, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImageAsPNG(OutputStream @out, BufferedImage image, bool encodeAlpha, int compression)
    {
      int num = encodeAlpha ? 1 : 0;
      EncoderUtil.writeBufferedImage(image, "png", @out, (float) compression, num != 0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable((ushort) 642)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] encodeAsPNG(BufferedImage image)
    {
      return EncoderUtil.encode(image, "png");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 99, (byte) 144, (byte) 140, (byte) 175, (byte) 73, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsPNG(File file, JFreeChart chart, int width, int height, ChartRenderingInfo info)
    {
      if (file == null)
      {
        string str = "Null 'file' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        BufferedOutputStream bufferedOutputStream = new BufferedOutputStream((OutputStream) new FileOutputStream(file));
        try
        {
          ChartUtilities.writeChartAsPNG((OutputStream) bufferedOutputStream, chart, width, height, info);
        }
        finally
        {
          ((OutputStream) bufferedOutputStream).close();
        }
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 99, (byte) 144, (byte) 140, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsJPEG(OutputStream @out, JFreeChart chart, int width, int height, ChartRenderingInfo info)
    {
      if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        EncoderUtil.writeBufferedImage(chart.createBufferedImage(width, height, 1, info), "jpeg", @out);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 99, (byte) 144, (byte) 141, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsJPEG(OutputStream @out, float quality, JFreeChart chart, int width, int height, ChartRenderingInfo info)
    {
      if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        EncoderUtil.writeBufferedImage(chart.createBufferedImage(width, height, 1, info), "jpeg", @out, quality);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 140, (byte) 175, (byte) 73, (byte) 98, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsJPEG(File file, JFreeChart chart, int width, int height, ChartRenderingInfo info)
    {
      if (file == null)
      {
        string str = "Null 'file' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        BufferedOutputStream bufferedOutputStream = new BufferedOutputStream((OutputStream) new FileOutputStream(file));
        try
        {
          ChartUtilities.writeChartAsJPEG((OutputStream) bufferedOutputStream, chart, width, height, info);
        }
        finally
        {
          ((OutputStream) bufferedOutputStream).close();
        }
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 179, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 172, (byte) 178, (byte) 73, (byte) 98, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsJPEG(File file, float quality, JFreeChart chart, int width, int height, ChartRenderingInfo info)
    {
      if (file == null)
      {
        string str = "Null 'file' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        BufferedOutputStream bufferedOutputStream = new BufferedOutputStream((OutputStream) new FileOutputStream(file));
        try
        {
          ChartUtilities.writeChartAsJPEG((OutputStream) bufferedOutputStream, quality, chart, width, height, info);
        }
        finally
        {
          ((OutputStream) bufferedOutputStream).close();
        }
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 225, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImageAsJPEG(OutputStream @out, float quality, BufferedImage image)
    {
      EncoderUtil.writeBufferedImage(image, "jpeg", @out, quality);
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void applyCurrentTheme(JFreeChart chart)
    {
      ChartFactory.getChartTheme().apply(chart);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 86, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsPNG(OutputStream @out, JFreeChart chart, int width, int height)
    {
      ChartUtilities.writeChartAsPNG(@out, chart, width, height, (ChartRenderingInfo) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 103, (byte) 99, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsPNG(OutputStream @out, JFreeChart chart, int width, int height, bool encodeAlpha, int compression)
    {
      int num = encodeAlpha ? 1 : 0;
      ChartUtilities.writeChartAsPNG(@out, chart, width, height, (ChartRenderingInfo) null, num != 0, compression);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 102, (byte) 102, (byte) 99, (byte) 99, (byte) 163, (byte) 106, (byte) 163, (byte) 102, (byte) 134, (byte) 148, (byte) 137, (byte) 100, (byte) 105, (byte) 112, (byte) 155, (byte) 105, (byte) 103, (byte) 130, (byte) 187, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeScaledChartAsPNG(OutputStream @out, JFreeChart chart, int width, int height, int widthScaleFactor, int heightScaleFactor)
    {
      if (@out == null)
      {
        string str = "Null 'out' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = (double) (width * widthScaleFactor);
        double num2 = (double) (height * heightScaleFactor);
        double num3 = (double) width;
        double num4 = (double) height;
        int num5 = 0;
        if (widthScaleFactor != 1 || heightScaleFactor != 1)
          num5 = 1;
        double num6 = num1 / num3;
        double num7 = num2 / num4;
        BufferedImage image = new BufferedImage(ByteCodeHelper.d2i(num1), ByteCodeHelper.d2i(num2), 2);
        Graphics2D graphics = image.createGraphics();
        if (num5 != 0)
        {
          AffineTransform transform = graphics.getTransform();
          graphics.transform(AffineTransform.getScaleInstance(num6, num7));
          chart.draw(graphics, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, num3, num4), (Point2D) null, (ChartRenderingInfo) null);
          graphics.setTransform(transform);
          ((Graphics) graphics).dispose();
        }
        else
          chart.draw(graphics, (Rectangle2D) new Rectangle2D.Double(0.0, 0.0, num3, num4), (Point2D) null, (ChartRenderingInfo) null);
        @out.write(ChartUtilities.encodeAsPNG(image));
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 56, (byte) 163, (byte) 99, (byte) 144, (byte) 99, (byte) 176, (byte) 140, (byte) 210, (byte) 73, (byte) 98, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsPNG(File file, JFreeChart chart, int width, int height, ChartRenderingInfo info, bool encodeAlpha, int compression)
    {
      int num = encodeAlpha ? 1 : 0;
      if (file == null)
      {
        string str = "Null 'file' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        BufferedOutputStream bufferedOutputStream = new BufferedOutputStream((OutputStream) new FileOutputStream(file));
        try
        {
          ChartUtilities.writeChartAsPNG((OutputStream) bufferedOutputStream, chart, width, height, info, num != 0, compression);
        }
        finally
        {
          ((OutputStream) bufferedOutputStream).close();
        }
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsJPEG(OutputStream @out, JFreeChart chart, int width, int height)
    {
      ChartUtilities.writeChartAsJPEG(@out, chart, width, height, (ChartRenderingInfo) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 30, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeChartAsJPEG(OutputStream @out, float quality, JFreeChart chart, int width, int height)
    {
      ChartUtilities.writeChartAsJPEG(@out, quality, chart, width, height, (ChartRenderingInfo) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsJPEG(File file, JFreeChart chart, int width, int height)
    {
      ChartUtilities.saveChartAsJPEG(file, chart, width, height, (ChartRenderingInfo) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 123, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void saveChartAsJPEG(File file, float quality, JFreeChart chart, int width, int height)
    {
      ChartUtilities.saveChartAsJPEG(file, quality, chart, width, height, (ChartRenderingInfo) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 209, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImageAsJPEG(OutputStream @out, BufferedImage image)
    {
      ChartUtilities.writeBufferedImageAsJPEG(@out, 0.75f, image);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 240, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeBufferedImageAsPNG(OutputStream @out, BufferedImage image)
    {
      EncoderUtil.writeBufferedImage(image, "png", @out);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable((ushort) 659)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] encodeAsPNG(BufferedImage image, bool encodeAlpha, int compression)
    {
      int num = encodeAlpha ? 1 : 0;
      return EncoderUtil.encode(image, "png", (float) compression, num != 0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 158, (byte) 228, (byte) 66, (byte) 98, (byte) 99, (byte) 200, (byte) 166, (byte) 223, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeImageMap(PrintWriter writer, string name, ChartRenderingInfo info, bool useOverLibForToolTips)
    {
      object obj1 = (useOverLibForToolTips ? 1 : 0) == 0 ? (object) new StandardToolTipTagFragmentGenerator() : (object) new OverLIBToolTipTagFragmentGenerator();
      PrintWriter writer1 = writer;
      string name1 = name;
      ChartRenderingInfo info1 = info;
      object obj2 = obj1;
      URLTagFragmentGenerator fragmentGenerator1 = (URLTagFragmentGenerator) new StandardURLTagFragmentGenerator();
      ToolTipTagFragmentGenerator toolTipTagFragmentGenerator;
      if (obj2 != null)
      {
        ToolTipTagFragmentGenerator fragmentGenerator2 = obj2 as ToolTipTagFragmentGenerator;
        if (fragmentGenerator2 == null)
          throw new IncompatibleClassChangeError();
        toolTipTagFragmentGenerator = fragmentGenerator2;
      }
      else
        toolTipTagFragmentGenerator = (ToolTipTagFragmentGenerator) null;
      URLTagFragmentGenerator urlTagFragmentGenerator = fragmentGenerator1;
      ImageMapUtilities.writeImageMap(writer1, name1, info1, toolTipTagFragmentGenerator, urlTagFragmentGenerator);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 90, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeImageMap(PrintWriter writer, string name, ChartRenderingInfo info, ToolTipTagFragmentGenerator toolTipTagFragmentGenerator, URLTagFragmentGenerator urlTagFragmentGenerator)
    {
      writer.println(ImageMapUtilities.getImageMap(name, info, toolTipTagFragmentGenerator, urlTagFragmentGenerator));
    }

    [LineNumberTable((ushort) 732)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getImageMap(string name, ChartRenderingInfo info)
    {
      return ImageMapUtilities.getImageMap(name, info, (ToolTipTagFragmentGenerator) new StandardToolTipTagFragmentGenerator(), (URLTagFragmentGenerator) new StandardURLTagFragmentGenerator());
    }

    [LineNumberTable((ushort) 757)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getImageMap(string name, ChartRenderingInfo info, ToolTipTagFragmentGenerator toolTipTagFragmentGenerator, URLTagFragmentGenerator urlTagFragmentGenerator)
    {
      return ImageMapUtilities.getImageMap(name, info, toolTipTagFragmentGenerator, urlTagFragmentGenerator);
    }
  }
}
