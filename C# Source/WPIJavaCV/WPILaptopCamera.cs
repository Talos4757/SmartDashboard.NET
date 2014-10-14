// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPILaptopCamera
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPILaptopCamera : WPIDisposable
  {
    internal object cam;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPILaptopCamera()
    {
      WPILaptopCamera wpiLaptopCamera1 = this;
      WPILaptopCamera wpiLaptopCamera2 = this;
      GC.KeepAlive((object) this);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
    }

    [LineNumberTable((ushort) 21)]
    public virtual WPIColorImage getCurrentFrame()
    {
      object obj = this.cam;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
    }

    protected internal override void disposed()
    {
    }
  }
}
