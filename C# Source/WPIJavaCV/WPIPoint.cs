// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIPoint
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIPoint : Object
  {
    internal object p;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIPoint(int x, int y)
    {
      base.\u002Ector();
      WPIPoint wpiPoint1 = this;
      WPIPoint wpiPoint2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 136, (byte) 145, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIPoint([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIPoint), "com.googlecode.javacv.cpp.opencv_core$CvPoint");
      base.\u002Ector();
      WPIPoint wpiPoint = this;
      this.p = obj0;
    }

    internal virtual object getCvPoint()
    {
      return this.p;
    }

    [LineNumberTable((ushort) 35)]
    public virtual int getX()
    {
      object obj = this.p;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable((ushort) 43)]
    public virtual int getY()
    {
      object obj = this.p;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable((ushort) 52)]
    public virtual string toString()
    {
      object obj = this.p;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }
  }
}
