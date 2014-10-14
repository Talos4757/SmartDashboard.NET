// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPICamera
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPICamera : WPIFFmpegVideo
  {
    private const int DEFAULT_ENDING_IP = 11;

    [HideFromJava]
    static WPICamera()
    {
      WPIFFmpegVideo.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 127, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPICamera(string ip)
      : base(new StringBuilder().append("http://").append(ip).append("/mjpg/video.mjpg").toString())
    {
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 127, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPICamera(string loginName, string password, int team)
    {
      StringBuilder stringBuilder = new StringBuilder().append(loginName).append(":").append(password).append("@10.").append(team / 100).append(".");
      int num1 = team;
      int num2 = 100;
      int num3 = -1;
      int num4 = num2 != num3 ? num1 % num2 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(stringBuilder.append(num4).append(".").append(11).toString());
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 127, (byte) 49})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPICamera(int team)
    {
      StringBuilder stringBuilder = new StringBuilder().append("10.").append(team / 100).append(".");
      int num1 = team;
      int num2 = 100;
      int num3 = -1;
      int num4 = num2 != num3 ? num1 % num2 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(stringBuilder.append(num4).append(".").append(11).toString());
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 127, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPICamera(string loginName, string password, string ip)
      : this(new StringBuilder().append(loginName).append(":").append(password).append("@").append(ip).toString())
    {
      GC.KeepAlive((object) this);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }
  }
}
