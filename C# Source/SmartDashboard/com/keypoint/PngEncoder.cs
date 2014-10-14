// Decompiled with JetBrains decompiler
// Type: com.keypoint.PngEncoder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.image;
using java.io;
using java.lang;
using java.util.zip;
using System;
using System.Runtime.CompilerServices;

namespace com.keypoint
{
  public class PngEncoder : Object
  {
    public const bool ENCODE_ALPHA = true;
    public const bool NO_ALPHA = false;
    public const int FILTER_NONE = 0;
    public const int FILTER_SUB = 1;
    public const int FILTER_UP = 2;
    public const int FILTER_LAST = 2;
    internal static byte[] __\u003C\u003EIHDR;
    internal static byte[] __\u003C\u003EIDAT;
    internal static byte[] __\u003C\u003EIEND;
    internal static byte[] __\u003C\u003EPHYS;
    protected internal byte[] pngBytes;
    protected internal byte[] priorRow;
    protected internal byte[] leftBytes;
    protected internal Image image;
    protected internal int width;
    protected internal int height;
    protected internal int bytePos;
    protected internal int maxPos;
    protected internal CRC32 crc;
    protected internal long crcValue;
    protected internal bool encodeAlpha;
    protected internal int filter;
    protected internal int bytesPerPixel;
    private int xDpi;
    private int yDpi;
    private static float INCH_IN_METER_UNIT;
    protected internal int compressionLevel;

    [Modifiers]
    protected internal static byte[] IHDR
    {
      [HideFromJava] get
      {
        return PngEncoder.__\u003C\u003EIHDR;
      }
    }

    [Modifiers]
    protected internal static byte[] IDAT
    {
      [HideFromJava] get
      {
        return PngEncoder.__\u003C\u003EIDAT;
      }
    }

    [Modifiers]
    protected internal static byte[] IEND
    {
      [HideFromJava] get
      {
        return PngEncoder.__\u003C\u003EIEND;
      }
    }

    [Modifiers]
    protected internal static byte[] PHYS
    {
      [HideFromJava] get
      {
        return PngEncoder.__\u003C\u003EPHYS;
      }
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 191, (byte) 0, (byte) 191, (byte) 0, (byte) 191, (byte) 0, (byte) 255, (byte) 0, (byte) 113})]
    static PngEncoder()
    {
      byte[] numArray1 = new byte[4];
      int index1 = 0;
      int num1 = 73;
      numArray1[index1] = (byte) num1;
      int index2 = 1;
      int num2 = 72;
      numArray1[index2] = (byte) num2;
      int index3 = 2;
      int num3 = 68;
      numArray1[index3] = (byte) num3;
      int index4 = 3;
      int num4 = 82;
      numArray1[index4] = (byte) num4;
      PngEncoder.__\u003C\u003EIHDR = numArray1;
      byte[] numArray2 = new byte[4];
      int index5 = 0;
      int num5 = 73;
      numArray2[index5] = (byte) num5;
      int index6 = 1;
      int num6 = 68;
      numArray2[index6] = (byte) num6;
      int index7 = 2;
      int num7 = 65;
      numArray2[index7] = (byte) num7;
      int index8 = 3;
      int num8 = 84;
      numArray2[index8] = (byte) num8;
      PngEncoder.__\u003C\u003EIDAT = numArray2;
      byte[] numArray3 = new byte[4];
      int index9 = 0;
      int num9 = 73;
      numArray3[index9] = (byte) num9;
      int index10 = 1;
      int num10 = 69;
      numArray3[index10] = (byte) num10;
      int index11 = 2;
      int num11 = 78;
      numArray3[index11] = (byte) num11;
      int index12 = 3;
      int num12 = 68;
      numArray3[index12] = (byte) num12;
      PngEncoder.__\u003C\u003EIEND = numArray3;
      byte[] numArray4 = new byte[4];
      int index13 = 0;
      int num13 = 112;
      numArray4[index13] = (byte) num13;
      int index14 = 1;
      int num14 = 72;
      numArray4[index14] = (byte) num14;
      int index15 = 2;
      int num15 = 89;
      numArray4[index15] = (byte) num15;
      int index16 = 3;
      int num16 = 115;
      numArray4[index16] = (byte) num16;
      PngEncoder.__\u003C\u003EPHYS = numArray4;
      PngEncoder.INCH_IN_METER_UNIT = 0.0254f;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 162, (byte) 232, (byte) 159, (byte) 171, (byte) 235, (byte) 79, (byte) 167, (byte) 231, (byte) 160, (byte) 68, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PngEncoder(Image image, bool encodeAlpha, int whichFilter, int compLevel)
    {
      int num = encodeAlpha ? 1 : 0;
      base.\u002Ector();
      PngEncoder pngEncoder = this;
      this.crc = new CRC32();
      this.xDpi = 0;
      this.yDpi = 0;
      this.image = image;
      this.encodeAlpha = num != 0;
      this.setFilter(whichFilter);
      if (compLevel < 0 || compLevel > 9)
        return;
      this.compressionLevel = compLevel;
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PngEncoder()
      : this((Image) null, false, 0, 0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PngEncoder(Image image)
      : this(image, false, 0, 0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 130, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PngEncoder(Image image, bool encodeAlpha)
    {
      int num = encodeAlpha ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(image, num != 0, 0, 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 162, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PngEncoder(Image image, bool encodeAlpha, int whichFilter)
    {
      int num = encodeAlpha ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(image, num != 0, whichFilter, 0);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual void setFilter(int whichFilter)
    {
      this.filter = 0;
      if (whichFilter > 2)
        return;
      this.filter = whichFilter;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 117, (byte) 109, (byte) 191, (byte) 7, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int writeBytes(byte[] data, int offset)
    {
      this.maxPos = Math.max(this.maxPos, offset + data.Length);
      if (data.Length + offset > this.pngBytes.Length)
        this.pngBytes = this.resizeByteArray(this.pngBytes, this.pngBytes.Length + Math.max(1000, data.Length));
      ByteCodeHelper.arraycopy_primitive_1((Array) data, 0, (Array) this.pngBytes, offset, data.Length);
      return offset + data.Length;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 122, (byte) 119, (byte) 114, (byte) 114, (byte) 120, (byte) 120, (byte) 115, (byte) 158, (byte) 115, (byte) 115, (byte) 115, (byte) 107, (byte) 122, (byte) 113, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void writeHeader()
    {
      PngEncoder pngEncoder = this;
      int num1 = this.writeInt4(13, this.bytePos);
      int num2 = num1;
      this.bytePos = num1;
      int num3 = num2;
      this.bytePos = this.writeBytes(PngEncoder.__\u003C\u003EIHDR, this.bytePos);
      this.width = this.image.getWidth((ImageObserver) null);
      this.height = this.image.getHeight((ImageObserver) null);
      this.bytePos = this.writeInt4(this.width, this.bytePos);
      this.bytePos = this.writeInt4(this.height, this.bytePos);
      this.bytePos = this.writeByte(8, this.bytePos);
      this.bytePos = this.writeByte(!this.encodeAlpha ? 2 : 6, this.bytePos);
      this.bytePos = this.writeByte(0, this.bytePos);
      this.bytePos = this.writeByte(0, this.bytePos);
      this.bytePos = this.writeByte(0, this.bytePos);
      this.crc.reset();
      this.crc.update(this.pngBytes, num3, this.bytePos - num3);
      this.crcValue = this.crc.getValue();
      this.bytePos = this.writeInt4((int) this.crcValue, this.bytePos);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 77, (byte) 152, (byte) 122, (byte) 119, (byte) 120, (byte) 120, (byte) 147, (byte) 107, (byte) 122, (byte) 113, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void writeResolution()
    {
      if (this.xDpi <= 0 || this.yDpi <= 0)
        return;
      PngEncoder pngEncoder = this;
      int num1 = this.writeInt4(9, this.bytePos);
      int num2 = num1;
      this.bytePos = num1;
      int num3 = num2;
      this.bytePos = this.writeBytes(PngEncoder.__\u003C\u003EPHYS, this.bytePos);
      this.bytePos = this.writeInt4(this.xDpi, this.bytePos);
      this.bytePos = this.writeInt4(this.yDpi, this.bytePos);
      this.bytePos = this.writeByte(1, this.bytePos);
      this.crc.reset();
      this.crc.update(this.pngBytes, num3, this.bytePos - num3);
      this.crcValue = this.crc.getValue();
      this.bytePos = this.writeInt4((int) this.crcValue, this.bytePos);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 148, (byte) 103, (byte) 226, (byte) 79, (byte) 146, (byte) 108, (byte) 139, (byte) 169, (byte) 103, (byte) 159, (byte) 6, (byte) 138, (byte) 144, (byte) 191, (byte) 1, (byte) 250, (byte) 69, (byte) 255, (byte) 6, (byte) 61, (byte) 97, (byte) 111, (byte) 153, (byte) 111, (byte) 111, (byte) 232, (byte) 71, (byte) 186, (byte) 105, (byte) 141, (byte) 105, (byte) 184, (byte) 99, (byte) 99, (byte) 115, (byte) 116, (byte) 114, (byte) 132, (byte) 122, (byte) 121, (byte) 119, (byte) 104, (byte) 186, (byte) 159, (byte) 5, (byte) 105, (byte) 144, (byte) 105, (byte) 240, (byte) 46, (byte) 235, (byte) 90, (byte) 140, (byte) 101, (byte) 101, (byte) 125, (byte) 231, (byte) 69, (byte) 104, (byte) 133, (byte) 107, (byte) 116, (byte) 119, (byte) 112, (byte) 150, (byte) 144, (byte) 113, (byte) 121, (byte) 102, (byte) 102, (byte) 156, (byte) 98, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual bool writeImageData()
    {
      int num1 = this.height;
      int num2 = 0;
      this.bytesPerPixel = !this.encodeAlpha ? 3 : 4;
      Deflater deflater = new Deflater(this.compressionLevel);
      ByteArrayOutputStream arrayOutputStream = new ByteArrayOutputStream(1024);
      DeflaterOutputStream deflaterOutputStream = new DeflaterOutputStream((OutputStream) arrayOutputStream, deflater);
      IOException ioException1;
      IOException ioException2;
      while (true)
      {
        int num3;
        int[] numArray1;
        PixelGrabber pixelGrabber;
        try
        {
          if (num1 > 0)
          {
            int num4 = (int) short.MaxValue;
            int num5 = this.width * (this.bytesPerPixel + 1);
            int num6 = -1;
            num3 = Math.max(Math.min(num5 != num6 ? num4 / num5 : -num4, num1), 1);
            numArray1 = new int[this.width * num3];
            pixelGrabber = new PixelGrabber(this.image, 0, num2, this.width, num3, numArray1, 0, this.width);
            try
            {
              pixelGrabber.grabPixels();
            }
            catch (Exception ex)
            {
              int num7 = 2;
              if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num7) == null)
                throw;
              else
                break;
            }
          }
          else
            goto label_33;
        }
        catch (IOException ex)
        {
          int num4 = 1;
          ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num4);
          goto label_8;
        }
        try
        {
          if ((pixelGrabber.getStatus() & 128) != 0)
          {
            System.get_err().println("image fetch aborted or errored");
            return false;
          }
          else
          {
            byte[] pixels = new byte[this.width * num3 * this.bytesPerPixel + num3];
            if (this.filter == 1)
              this.leftBytes = new byte[16];
            if (this.filter == 2)
              this.priorRow = new byte[this.width * this.bytesPerPixel];
            int num4 = 0;
            int startPos = 1;
            for (int index1 = 0; index1 < this.width * num3; ++index1)
            {
              int num5 = index1;
              int num6 = this.width;
              int num7 = -1;
              if ((num6 != num7 ? num5 % num6 : 0) == 0)
              {
                byte[] numArray2 = pixels;
                int index2 = num4;
                ++num4;
                int num8 = (int) (sbyte) this.filter;
                numArray2[index2] = (byte) num8;
                startPos = num4;
              }
              byte[] numArray3 = pixels;
              int index3 = num4;
              int num9 = num4 + 1;
              int num10 = (int) (sbyte) (numArray1[index1] >> 16 & (int) byte.MaxValue);
              numArray3[index3] = (byte) num10;
              byte[] numArray4 = pixels;
              int index4 = num9;
              int num11 = num9 + 1;
              int num12 = (int) (sbyte) (numArray1[index1] >> 8 & (int) byte.MaxValue);
              numArray4[index4] = (byte) num12;
              byte[] numArray5 = pixels;
              int index5 = num11;
              num4 = num11 + 1;
              int num13 = (int) (sbyte) (numArray1[index1] & (int) byte.MaxValue);
              numArray5[index5] = (byte) num13;
              if (this.encodeAlpha)
              {
                byte[] numArray2 = pixels;
                int index2 = num4;
                ++num4;
                int num8 = (int) (sbyte) (numArray1[index1] >> 24 & (int) byte.MaxValue);
                numArray2[index2] = (byte) num8;
              }
              int num14 = index1;
              int num15 = this.width;
              int num16 = -1;
              if ((num15 != num16 ? num14 % num15 : 0) == this.width - 1 && this.filter != 0)
              {
                if (this.filter == 1)
                  this.filterSub(pixels, startPos, this.width);
                if (this.filter == 2)
                  this.filterUp(pixels, startPos, this.width);
              }
            }
            deflaterOutputStream.write(pixels, 0, num4);
            num2 += num3;
            num1 -= num3;
          }
        }
        catch (IOException ex)
        {
          int num4 = 1;
          ioException2 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num4);
          goto label_32;
        }
      }
      IOException ioException3;
      try
      {
        System.get_err().println("interrupted waiting for pixels!");
        return false;
      }
      catch (IOException ex)
      {
        int num3 = 1;
        ioException3 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num3);
      }
      IOException ioException4 = ioException3;
      goto label_37;
label_8:
      ioException4 = ioException1;
      goto label_37;
label_32:
      ioException4 = ioException2;
      goto label_37;
label_33:
      int num17;
      IOException ioException5;
      try
      {
        deflaterOutputStream.close();
        byte[] data = arrayOutputStream.toByteArray();
        int length = data.Length;
        this.crc.reset();
        this.bytePos = this.writeInt4(length, this.bytePos);
        this.bytePos = this.writeBytes(PngEncoder.__\u003C\u003EIDAT, this.bytePos);
        this.crc.update(PngEncoder.__\u003C\u003EIDAT);
        this.bytePos = this.writeBytes(data, length, this.bytePos);
        this.crc.update(data, 0, length);
        this.crcValue = this.crc.getValue();
        this.bytePos = this.writeInt4((int) this.crcValue, this.bytePos);
        deflater.finish();
        deflater.end();
        num17 = 1;
      }
      catch (IOException ex)
      {
        int num3 = 1;
        ioException5 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num3);
        goto label_36;
      }
      return num17 != 0;
label_36:
      ioException4 = ioException5;
label_37:
      System.get_err().println(Throwable.instancehelper_toString((Exception) ioException4));
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 16, (byte) 115, (byte) 119, (byte) 107, (byte) 112, (byte) 113, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void writeEnd()
    {
      this.bytePos = this.writeInt4(0, this.bytePos);
      this.bytePos = this.writeBytes(PngEncoder.__\u003C\u003EIEND, this.bytePos);
      this.crc.reset();
      this.crc.update(PngEncoder.__\u003C\u003EIEND);
      this.crcValue = this.crc.getValue();
      this.bytePos = this.writeInt4((int) this.crcValue, this.bytePos);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 103, (byte) 131, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual byte[] resizeByteArray(byte[] array, int newLength)
    {
      byte[] numArray = new byte[newLength];
      int length = array.Length;
      ByteCodeHelper.arraycopy_primitive_1((Array) array, 0, (Array) numArray, 0, Math.min(length, newLength));
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 159, (byte) 16, (byte) 104, (byte) 130, (byte) 114, (byte) 242, (byte) 70, (byte) 255, (byte) 3, (byte) 69, (byte) 135, (byte) 142, (byte) 102, (byte) 134, (byte) 104, (byte) 102, (byte) 186, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual byte[] pngEncode(bool encodeAlpha)
    {
      byte[] numArray = new byte[8];
      int index1 = 0;
      int num1 = -119;
      numArray[index1] = (byte) num1;
      int index2 = 1;
      int num2 = 80;
      numArray[index2] = (byte) num2;
      int index3 = 2;
      int num3 = 78;
      numArray[index3] = (byte) num3;
      int index4 = 3;
      int num4 = 71;
      numArray[index4] = (byte) num4;
      int index5 = 4;
      int num5 = 13;
      numArray[index5] = (byte) num5;
      int index6 = 5;
      int num6 = 10;
      numArray[index6] = (byte) num6;
      int index7 = 6;
      int num7 = 26;
      numArray[index7] = (byte) num7;
      int index8 = 7;
      int num8 = 10;
      numArray[index8] = (byte) num8;
      byte[] data = numArray;
      if (this.image == null)
        return (byte[]) null;
      this.width = this.image.getWidth((ImageObserver) null);
      this.height = this.image.getHeight((ImageObserver) null);
      this.pngBytes = new byte[(this.width + 1) * this.height * 3 + 200];
      this.maxPos = 0;
      this.bytePos = this.writeBytes(data, 0);
      this.writeHeader();
      this.writeResolution();
      if (this.writeImageData())
      {
        this.writeEnd();
        this.pngBytes = this.resizeByteArray(this.pngBytes, this.maxPos);
      }
      else
        this.pngBytes = (byte[]) null;
      return this.pngBytes;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 50, (byte) 223, (byte) 28})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int writeInt4(int n, int offset)
    {
      byte[] data = new byte[4];
      int index1 = 0;
      int num1 = (int) (sbyte) (n >> 24 & (int) byte.MaxValue);
      data[index1] = (byte) num1;
      int index2 = 1;
      int num2 = (int) (sbyte) (n >> 16 & (int) byte.MaxValue);
      data[index2] = (byte) num2;
      int index3 = 2;
      int num3 = (int) (sbyte) (n >> 8 & (int) byte.MaxValue);
      data[index3] = (byte) num3;
      int index4 = 3;
      int num4 = (int) (sbyte) (n & (int) byte.MaxValue);
      data[index4] = (byte) num4;
      return this.writeBytes(data, offset);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int writeByte(int b, int offset)
    {
      byte[] data = new byte[1];
      int index = 0;
      int num = (int) (sbyte) b;
      data[index] = (byte) num;
      return this.writeBytes(data, offset);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 103, (byte) 103, (byte) 100, (byte) 105, (byte) 98, (byte) 131, (byte) 109, (byte) 108, (byte) 159, (byte) 3, (byte) 112, (byte) 242, (byte) 59, (byte) 235, (byte) 71})]
    protected internal virtual void filterSub(byte[] pixels, int startPos, int width)
    {
      int num1 = this.bytesPerPixel;
      int num2 = startPos + num1;
      int num3 = width * this.bytesPerPixel;
      int index1 = num1;
      int index2 = 0;
      for (int index3 = num2; index3 < startPos + num3; ++index3)
      {
        this.leftBytes[index1] = pixels[index3];
        byte[] numArray = pixels;
        int index4 = index3;
        int num4 = (int) (sbyte) pixels[index3] - (int) (sbyte) this.leftBytes[index2];
        int num5 = 256;
        int num6 = -1;
        int num7 = num5 != num6 ? (int) (sbyte) (num4 % num5) : 0;
        numArray[index4] = (byte) num7;
        int num8 = index1 + 1;
        int num9 = 15;
        int num10 = -1;
        index1 = num9 != num10 ? num8 % num9 : 0;
        int num11 = index2 + 1;
        int num12 = 15;
        int num13 = -1;
        index2 = num12 != num13 ? num11 % num12 : 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 128, (byte) 137, (byte) 102, (byte) 102, (byte) 159, (byte) 4, (byte) 233, (byte) 60, (byte) 230, (byte) 70})]
    protected internal virtual void filterUp(byte[] pixels, int startPos, int width)
    {
      int num1 = width * this.bytesPerPixel;
      for (int index1 = 0; index1 < num1; ++index1)
      {
        int num2 = (int) (sbyte) pixels[startPos + index1];
        byte[] numArray = pixels;
        int index2 = startPos + index1;
        int num3 = (int) (sbyte) pixels[startPos + index1] - (int) (sbyte) this.priorRow[index1];
        int num4 = 256;
        int num5 = -1;
        int num6 = num4 != num5 ? (int) (sbyte) (num3 % num4) : 0;
        numArray[index2] = (byte) num6;
        this.priorRow[index1] = (byte) num2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 116, (byte) 108, (byte) 191, (byte) 6, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int writeBytes(byte[] data, int nBytes, int offset)
    {
      this.maxPos = Math.max(this.maxPos, offset + nBytes);
      if (nBytes + offset > this.pngBytes.Length)
        this.pngBytes = this.resizeByteArray(this.pngBytes, this.pngBytes.Length + Math.max(1000, nBytes));
      ByteCodeHelper.arraycopy_primitive_1((Array) data, 0, (Array) this.pngBytes, offset, nBytes);
      return offset + nBytes;
    }

    public virtual void setImage(Image image)
    {
      this.image = image;
      this.pngBytes = (byte[]) null;
    }

    public virtual Image getImage()
    {
      return this.image;
    }

    [LineNumberTable((ushort) 278)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual byte[] pngEncode()
    {
      return this.pngEncode(this.encodeAlpha);
    }

    public virtual void setEncodeAlpha(bool encodeAlpha)
    {
      this.encodeAlpha = encodeAlpha;
    }

    public virtual bool getEncodeAlpha()
    {
      return this.encodeAlpha;
    }

    public virtual int getFilter()
    {
      return this.filter;
    }

    public virtual void setCompressionLevel(int level)
    {
      if (level < 0 || level > 9)
        return;
      this.compressionLevel = level;
    }

    public virtual int getCompressionLevel()
    {
      return this.compressionLevel;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 38, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int writeInt2(int n, int offset)
    {
      byte[] data = new byte[2];
      int index1 = 0;
      int num1 = (int) (sbyte) (n >> 8 & (int) byte.MaxValue);
      data[index1] = (byte) num1;
      int index2 = 1;
      int num2 = (int) (sbyte) (n & (int) byte.MaxValue);
      data[index2] = (byte) num2;
      return this.writeBytes(data, offset);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 31, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setXDpi(int xDpi)
    {
      this.xDpi = Math.round((float) xDpi / PngEncoder.INCH_IN_METER_UNIT);
    }

    [LineNumberTable((ushort) 667)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getXDpi()
    {
      return Math.round((float) this.xDpi * PngEncoder.INCH_IN_METER_UNIT);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 50, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setYDpi(int yDpi)
    {
      this.yDpi = Math.round((float) yDpi / PngEncoder.INCH_IN_METER_UNIT);
    }

    [LineNumberTable((ushort) 685)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getYDpi()
    {
      return Math.round((float) this.yDpi * PngEncoder.INCH_IN_METER_UNIT);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 69, (byte) 116, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDpi(int xDpi, int yDpi)
    {
      this.xDpi = Math.round((float) xDpi / PngEncoder.INCH_IN_METER_UNIT);
      this.yDpi = Math.round((float) yDpi / PngEncoder.INCH_IN_METER_UNIT);
    }
  }
}
