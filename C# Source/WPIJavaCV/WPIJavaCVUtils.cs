// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIJavaCVUtils
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIJavaCVUtils : Object
  {
    [LineNumberTable((ushort) 14)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIJavaCVUtils()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 21)]
    public static void waitForKey(char key)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
    }

    [LineNumberTable((ushort) 29)]
    public static char waitForAnyKey()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
    }

    [LineNumberTable((ushort) 39)]
    public static bool keyIsPressed(char key, int timeoutMillis)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
    }
  }
}
