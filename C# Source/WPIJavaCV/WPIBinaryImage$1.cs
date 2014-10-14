// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIBinaryImage$1
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpijavacv
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.wpijavacv.WPIBinaryImage", "findContours", "()[Ledu.wpi.first.wpijavacv.WPIContour;")]
  [SourceFile("WPIBinaryImage.java")]
  [Modifiers]
  internal sealed class WPIBinaryImage\u00241 : WPIMemoryPool
  {
    [Modifiers]
    internal object val\u0024storage;
    [Modifiers]
    internal WPIBinaryImage this\u00240;

    [LineNumberTable((ushort) 254)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIBinaryImage\u00241([In] WPIBinaryImage obj0, [In] object obj1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj1, __typeref (WPIBinaryImage\u00241), "com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
      this.this\u00240 = obj0;
      this.val\u0024storage = obj1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      GC.KeepAlive((object) this);
    }

    [LineNumberTable((ushort) 258)]
    protected internal override void disposed()
    {
      object obj = this.val\u0024storage;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }
  }
}
