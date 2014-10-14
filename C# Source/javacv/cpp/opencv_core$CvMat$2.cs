// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.cpp.opencv_core$CvMat$2
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv.cpp
{
  [InnerClass]
  [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
  [EnclosingMethod("com.googlecode.javacv.cpp.opencv_core$CvMat", "createHeaderThreadLocal", "(III)Ljava.lang.ThreadLocal;")]
  [SourceFile("opencv_core.java")]
  internal sealed class opencv_core\u0024CvMat\u00242 : ThreadLocal
  {
    [Modifiers]
    internal int val\u0024rows;
    [Modifiers]
    internal int val\u0024cols;
    [Modifiers]
    internal int val\u0024type;

    [HideFromJava]
    static opencv_core\u0024CvMat\u00242()
    {
      ThreadLocal.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 1095)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal opencv_core\u0024CvMat\u00242([In] int obj0, [In] int obj1, [In] int obj2)
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 1096)]
    protected internal virtual object initialValue()
    {
      int num1 = this.val\u0024rows;
      int num2 = this.val\u0024cols;
      int num3 = this.val\u0024type;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [Modifiers]
    [LineNumberTable((ushort) 1095)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object initialValue()
    {
      return this.initialValue();
    }
  }
}
