// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ColorCalibrator
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class ColorCalibrator : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ColorCalibrator>.Value).desiredAssertionStatus();
    private ProjectiveDevice device;

    [LineNumberTable((ushort) 31)]
    static ColorCalibrator()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorCalibrator(ProjectiveDevice device)
    {
      base.\u002Ector();
      ColorCalibrator colorCalibrator = this;
      this.device = device;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 152, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calibrate(Color[] referenceColors, Color[] deviceColors)
    {
      if (!ColorCalibrator.\u0024assertionsDisabled && referenceColors.Length != deviceColors.Length)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
      else
      {
        this.device.getRGBColorOrder();
        int num = referenceColors.Length * 3;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }
  }
}
