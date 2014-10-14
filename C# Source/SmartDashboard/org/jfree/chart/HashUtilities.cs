// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.HashUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.chart
{
  public class HashUtilities : Object
  {
    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HashUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 99, (byte) 130, (byte) 130, (byte) 107, (byte) 103, (byte) 102, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 226, (byte) 69, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCodeForPaint(Paint p)
    {
      if (p == null)
        return 0;
      int num;
      if (p is GradientPaint)
      {
        GradientPaint gradientPaint = (GradientPaint) p;
        num = 37 * (37 * (37 * (37 * 193 + gradientPaint.getColor1().hashCode()) + gradientPaint.getPoint1().hashCode()) + gradientPaint.getColor2().hashCode()) + gradientPaint.getPoint2().hashCode();
      }
      else
        num = Object.instancehelper_hashCode((object) p);
      return num;
    }

    public static int hashCode(int pre, int i)
    {
      return 37 * pre + i;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, IComparable c)
    {
      int num = c == null ? 0 : Object.instancehelper_hashCode((object) c);
      return 37 * pre + num;
    }

    [LineNumberTable((ushort) 172)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, Paint p)
    {
      return 37 * pre + HashUtilities.hashCodeForPaint(p);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 72, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, Stroke s)
    {
      int num = s == null ? 0 : Object.instancehelper_hashCode((object) s);
      return 37 * pre + num;
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 99, (byte) 130, (byte) 134, (byte) 103, (byte) 105, (byte) 13, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCodeForDoubleArray(double[] a)
    {
      if (a == null)
        return 0;
      int num1 = 193;
      for (int index = 0; index < a.Length; ++index)
      {
        long num2 = Double.doubleToLongBits(a[index]);
        num1 = 29 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      }
      return num1;
    }

    public static int hashCode(int pre, bool b)
    {
      int num = b ? 1 : 0;
      return 37 * pre + (num == 0 ? 1 : 0);
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, double d)
    {
      long num = Double.doubleToLongBits(d);
      return 37 * pre + (int) (num ^ (long) ((ulong) num >> 32));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, string s)
    {
      int num = s == null ? 0 : String.instancehelper_hashCode(s);
      return 37 * pre + num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, object obj)
    {
      int num = obj == null ? 0 : Object.instancehelper_hashCode(obj);
      return 37 * pre + num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 99, (byte) 130, (byte) 99, (byte) 103, (byte) 200, (byte) 100, (byte) 110, (byte) 100, (byte) 144, (byte) 100, (byte) 240, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, BooleanList list)
    {
      if (list == null)
        return pre;
      int pre1 = (int) sbyte.MaxValue;
      int i = list.size();
      int pre2 = HashUtilities.hashCode(pre1, i);
      if (i > 0)
      {
        pre2 = HashUtilities.hashCode(pre2, (IComparable) list.getBoolean(0));
        if (i > 1)
        {
          pre2 = HashUtilities.hashCode(pre2, (IComparable) list.getBoolean(i - 1));
          if (i > 2)
            pre2 = HashUtilities.hashCode(pre2, (IComparable) list.getBoolean(i / 2));
        }
      }
      return 37 * pre + pre2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 174, (byte) 99, (byte) 130, (byte) 99, (byte) 103, (byte) 200, (byte) 100, (byte) 110, (byte) 100, (byte) 144, (byte) 100, (byte) 240, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, PaintList list)
    {
      if (list == null)
        return pre;
      int pre1 = (int) sbyte.MaxValue;
      int i = list.size();
      int pre2 = HashUtilities.hashCode(pre1, i);
      if (i > 0)
      {
        pre2 = HashUtilities.hashCode(pre2, list.getPaint(0));
        if (i > 1)
        {
          pre2 = HashUtilities.hashCode(pre2, list.getPaint(i - 1));
          if (i > 2)
            pre2 = HashUtilities.hashCode(pre2, list.getPaint(i / 2));
        }
      }
      return 37 * pre + pre2;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 99, (byte) 130, (byte) 99, (byte) 103, (byte) 200, (byte) 100, (byte) 110, (byte) 100, (byte) 144, (byte) 100, (byte) 240, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(int pre, StrokeList list)
    {
      if (list == null)
        return pre;
      int pre1 = (int) sbyte.MaxValue;
      int i = list.size();
      int pre2 = HashUtilities.hashCode(pre1, i);
      if (i > 0)
      {
        pre2 = HashUtilities.hashCode(pre2, list.getStroke(0));
        if (i > 1)
        {
          pre2 = HashUtilities.hashCode(pre2, list.getStroke(i - 1));
          if (i > 2)
            pre2 = HashUtilities.hashCode(pre2, list.getStroke(i / 2));
        }
      }
      return 37 * pre + pre2;
    }
  }
}
