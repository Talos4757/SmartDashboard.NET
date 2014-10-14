// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.net.TCPImageFetcher
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt.image;
using java.io;
using java.lang;
using java.net;
using javax.imageio;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.net
{
  public class TCPImageFetcher : Object
  {
    public const int MAX_IMG_SIZE_BYTES = 500000;
    public const int READ_TIMEOUT_MS = 3000;
    public const int VIDEO_TO_PC_PORT = 1180;
    private Socket m_sock;
    private InputStream m_sockistream;
    private byte[] m_imgBuffer;
    private int m_maxImgBufferSize;
    private ByteArrayInputStream m_baistream;
    private DataInputStream m_daistream;
    private bool m_initialized;
    private byte[] m_address;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 232, (byte) 47, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 231, (byte) 75, (byte) 102, (byte) 111, (byte) 125})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TCPImageFetcher(int teamNumber)
    {
      base.\u002Ector();
      TCPImageFetcher tcpImageFetcher = this;
      this.m_sock = (Socket) null;
      this.m_sockistream = (InputStream) null;
      this.m_imgBuffer = (byte[]) null;
      this.m_maxImgBufferSize = 0;
      this.m_baistream = (ByteArrayInputStream) null;
      this.m_daistream = (DataInputStream) null;
      this.m_initialized = false;
      this.m_address = (byte[]) null;
      int num1 = (int) (sbyte) (teamNumber / 100);
      int num2 = teamNumber;
      int num3 = 100;
      int num4 = -1;
      int num5 = num3 != num4 ? (int) (sbyte) (num2 % num3) : 0;
      byte[] numArray = new byte[4];
      int index1 = 0;
      int num6 = 10;
      numArray[index1] = (byte) num6;
      int index2 = 1;
      int num7 = num1;
      numArray[index2] = (byte) num7;
      int index3 = 2;
      int num8 = num5;
      numArray[index3] = (byte) num8;
      int index4 = 3;
      int num9 = 2;
      numArray[index4] = (byte) num9;
      this.m_address = numArray;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 3, (byte) 123, (byte) 112, (byte) 113, (byte) 113, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void init()
    {
      this.m_sock = new Socket(InetAddress.getByAddress(this.m_address), 1180);
      this.m_sock.setSoTimeout(3000);
      this.m_sockistream = this.m_sock.getInputStream();
      this.m_daistream = new DataInputStream(this.m_sockistream);
      this.m_initialized = true;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 76, (byte) 98, (byte) 100, (byte) 140, (byte) 100, (byte) 176, (byte) 100, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void blockingRead([In] InputStream obj0, [In] byte[] obj1, [In] int obj2)
    {
      int num1 = 0;
      while (num1 < obj2)
      {
        int num2 = obj0.read(obj1, num1, obj2 - num1);
        if (num2 < 0)
        {
          string str = "Connection interrupted";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IOException(str);
        }
        else
          num1 += num2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 105, (byte) 104, (byte) 135, (byte) 106, (byte) 113, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void resizeBuffer([In] int obj0)
    {
      if (obj0 <= this.m_maxImgBufferSize)
        return;
      if (obj0 > 500000)
        obj0 = 500000;
      this.m_maxImgBufferSize = obj0 + 100;
      this.m_imgBuffer = new byte[this.m_maxImgBufferSize];
      this.m_baistream = new ByteArrayInputStream(this.m_imgBuffer);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 16, (byte) 104, (byte) 166, (byte) 167, (byte) 174, (byte) 115, (byte) 194, (byte) 176, (byte) 204, (byte) 103, (byte) 115, (byte) 171, (byte) 159, (byte) 2, (byte) 98, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BufferedImage fetch()
    {
      if (!this.m_initialized)
        this.init();
      BufferedImage bufferedImage;
      IOException ioException1;
      try
      {
        byte[] numArray = new byte[4];
        do
        {
          this.blockingRead(this.m_sockistream, numArray, 4);
        }
        while ((int) (sbyte) numArray[0] != 1 || (int) (sbyte) numArray[1] + (int) (sbyte) numArray[2] + (int) (sbyte) numArray[3] != 0);
        do
          ;
        while (this.m_sockistream.available() < 4);
        int num = this.m_daistream.readInt();
        this.resizeBuffer(num);
        this.blockingRead(this.m_sockistream, this.m_imgBuffer, num);
        this.m_baistream.reset();
        bufferedImage = ImageIO.read((InputStream) this.m_baistream);
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_8;
      }
      return bufferedImage;
label_8:
      IOException ioException2 = ioException1;
      this.m_sock.close();
      this.m_initialized = false;
      throw Throwable.__\u003Cunmap\u003E((Exception) ioException2);
    }
  }
}
