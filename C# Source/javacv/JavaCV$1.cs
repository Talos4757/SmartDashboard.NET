// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.JavaCV$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.nio;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"com.googlecode.javacv.Parallel$Looper"})]
  [EnclosingMethod("com.googlecode.javacv.JavaCV", "adaptiveBinarization", "(Lcom.googlecode.javacv.cpp.opencv_core$IplImage;Lcom.googlecode.javacv.cpp.opencv_core$IplImage;Lcom.googlecode.javacv.cpp.opencv_core$IplImage;Lcom.googlecode.javacv.cpp.opencv_core$IplImage;ZIIDD)V")]
  [SourceFile("JavaCV.java")]
  internal sealed class JavaCV\u00241 : Object, Parallel.Looper
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<JavaCV>.Value).desiredAssertionStatus();
    [Modifiers]
    internal int val\u0024w;
    [Modifiers]
    internal int val\u0024maxwindow;
    [Modifiers]
    internal int val\u0024minwindow;
    [Modifiers]
    internal int val\u0024h;
    [Modifiers]
    internal DoubleBuffer val\u0024sumbuf;
    [Modifiers]
    internal int val\u0024sumstep;
    [Modifiers]
    internal DoubleBuffer val\u0024sqsumbuf;
    [Modifiers]
    internal int val\u0024sqsumstep;
    [Modifiers]
    internal double val\u0024targetvar;
    [Modifiers]
    internal int val\u0024srcdepth;
    [Modifiers]
    internal ByteBuffer val\u0024srcbuf;
    [Modifiers]
    internal int val\u0024srcstep;
    [Modifiers]
    internal bool val\u0024invert;
    [Modifiers]
    internal double val\u0024k;
    [Modifiers]
    internal ByteBuffer val\u0024dstbuf;
    [Modifiers]
    internal int val\u0024dststep;

    [LineNumberTable((ushort) 355)]
    static JavaCV\u00241()
    {
    }

    [LineNumberTable((ushort) 355)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal JavaCV\u00241([In] int obj0, [In] int obj1, [In] int obj2, [In] int obj3, [In] DoubleBuffer obj4, [In] int obj5, [In] DoubleBuffer obj6, [In] int obj7, [In] double obj8, [In] int obj9, [In] ByteBuffer obj10, [In] int obj11, [In] bool obj12, [In] double obj13, [In] ByteBuffer obj14, [In] int obj15)
    {
      int num = obj12 ? 1 : 0;
      this.val\u0024w = obj0;
      this.val\u0024maxwindow = obj1;
      this.val\u0024minwindow = obj2;
      this.val\u0024h = obj3;
      this.val\u0024sumbuf = obj4;
      this.val\u0024sumstep = obj5;
      this.val\u0024sqsumbuf = obj6;
      this.val\u0024sqsumstep = obj7;
      this.val\u0024targetvar = obj8;
      this.val\u0024srcdepth = obj9;
      this.val\u0024srcbuf = obj10;
      this.val\u0024srcstep = obj11;
      this.val\u0024invert = num != 0;
      this.val\u0024k = obj13;
      this.val\u0024dstbuf = obj14;
      this.val\u0024dststep = obj15;
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 105, (byte) 110, (byte) 114, (byte) 103, (byte) 104, (byte) 99, (byte) 106, (byte) 110, (byte) 149, (byte) 110, (byte) 149, (byte) 223, (byte) 74, (byte) 106, (byte) 223, (byte) 75, (byte) 108, (byte) 201, (byte) 111, (byte) 194, (byte) 106, (byte) 133, (byte) 164, (byte) 107, (byte) 106, (byte) 133, (byte) 103, (byte) 105, (byte) 127, (byte) 5, (byte) 106, (byte) 124, (byte) 106, (byte) 220, (byte) 146, (byte) 136, (byte) 127, (byte) 0, (byte) 127, (byte) 1, (byte) 130, (byte) 107, (byte) 255, (byte) 1, (byte) 4, (byte) 41, (byte) 233, (byte) 160, (byte) 65})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void loop([In] int obj0, [In] int obj1, [In] int obj2)
    {
      for (int index1 = obj0; index1 < obj1; ++index1)
      {
        for (int index2 = 0; index2 < this.val\u0024w; ++index2)
        {
          double num1 = 0.0;
          int num2 = this.val\u0024maxwindow;
          int num3 = this.val\u0024minwindow;
          int num4 = num2;
          while (num2 - num3 > 2)
          {
            int num5 = Math.max(index2 - num4 / 2, 0);
            int num6 = Math.min(index2 + num4 / 2 + 1, this.val\u0024w);
            int num7 = Math.max(index1 - num4 / 2, 0);
            int num8 = Math.min(index1 + num4 / 2 + 1, this.val\u0024h);
            num1 = (this.val\u0024sumbuf.get(num8 * this.val\u0024sumstep / 8 + num6) - this.val\u0024sumbuf.get(num8 * this.val\u0024sumstep / 8 + num5) - this.val\u0024sumbuf.get(num7 * this.val\u0024sumstep / 8 + num6) + this.val\u0024sumbuf.get(num7 * this.val\u0024sumstep / 8 + num5)) / (double) (num4 * num4);
            double num9 = (this.val\u0024sqsumbuf.get(num8 * this.val\u0024sqsumstep / 8 + num6) - this.val\u0024sqsumbuf.get(num8 * this.val\u0024sqsumstep / 8 + num5) - this.val\u0024sqsumbuf.get(num7 * this.val\u0024sqsumstep / 8 + num6) + this.val\u0024sqsumbuf.get(num7 * this.val\u0024sqsumstep / 8 + num5)) / (double) (num4 * num4) - num1 * num1;
            if (num4 != num2 || num9 >= this.val\u0024targetvar)
            {
              if (num9 > this.val\u0024targetvar)
                num2 = num4;
              else
                num3 = num4;
              num4 = (num3 + (num2 - num3) / 2) / 2 * 2 + 1;
            }
            else
              break;
          }
          double num10 = 0.0;
          if (this.val\u0024srcdepth == 8)
            num10 = (double) ((int) (sbyte) this.val\u0024srcbuf.get(index1 * this.val\u0024srcstep + index2) & (int) byte.MaxValue);
          else if (this.val\u0024srcdepth == 32)
            num10 = (double) this.val\u0024srcbuf.getFloat(index1 * this.val\u0024srcstep + 4 * index2);
          else if (this.val\u0024srcdepth == 64)
            num10 = this.val\u0024srcbuf.getDouble(index1 * this.val\u0024srcstep + 8 * index2);
          else if (!JavaCV\u00241.\u0024assertionsDisabled)
          {
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new AssertionError();
          }
          if (this.val\u0024invert)
          {
            double num5 = (double) byte.MaxValue - ((double) byte.MaxValue - num1) * this.val\u0024k;
            this.val\u0024dstbuf.put(index1 * this.val\u0024dststep + index2, num10 >= num5 ? (byte) 0 : byte.MaxValue);
          }
          else
          {
            double num5 = num1 * this.val\u0024k;
            this.val\u0024dstbuf.put(index1 * this.val\u0024dststep + index2, num10 <= num5 ? (byte) 0 : byte.MaxValue);
          }
        }
      }
    }
  }
}
