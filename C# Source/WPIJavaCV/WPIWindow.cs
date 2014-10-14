// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIWindow
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIWindow : Object
  {
    private static int count = 0;
    private string name;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 104, (byte) 140, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIWindow()
    {
      base.\u002Ector();
      WPIWindow wpiWindow = this;
      ++WPIWindow.count;
      this.name = new StringBuilder().append("Window ").append(WPIWindow.count).toString();
      string str = this.name;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIWindow(string name)
    {
      base.\u002Ector();
      WPIWindow wpiWindow = this;
      this.name = name;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 99, (byte) 119})]
    public virtual void showImage(WPIImage image)
    {
      if (image != null)
      {
        string str = this.name;
        object obj = image.image;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
      }
      else
      {
        string str = this.name;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_highgui");
      }
    }
  }
}
