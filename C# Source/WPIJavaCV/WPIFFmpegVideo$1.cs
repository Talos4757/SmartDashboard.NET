// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIFFmpegVideo$1
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpijavacv
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.wpijavacv.WPIFFmpegVideo", "<init>", "(Ljava.lang.String;)V")]
  [SourceFile("WPIFFmpegVideo.java")]
  [Modifiers]
  internal sealed class WPIFFmpegVideo\u00241 : Thread
  {
    [Modifiers]
    internal string val\u0024path;
    [Modifiers]
    internal WPIFFmpegVideo this\u00240;

    [HideFromJava]
    static WPIFFmpegVideo\u00241()
    {
      Thread.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIFFmpegVideo\u00241([In] WPIFFmpegVideo obj0, [In] string obj1)
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 25)]
    public virtual void run()
    {
      WPIFFmpegVideo wpifFmpegVideo = this.this\u00240;
      throw new NoClassDefFoundError("com.googlecode.javacv.FFmpegFrameGrabber");
    }
  }
}
