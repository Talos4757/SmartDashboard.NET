// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.Regression
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.xy;
using System.Runtime.CompilerServices;

namespace org.jfree.data.statistics
{
  public abstract class Regression : Object
  {
    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Regression()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 99, (byte) 100, (byte) 176, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 102, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 232, (byte) 56, (byte) 235, (byte) 74, (byte) 107, (byte) 108, (byte) 103, (byte) 135, (byte) 104, (byte) 106, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] getOLSRegression(double[][] data)
    {
      int length = data.Length;
      if (length < 2)
      {
        string str = "Not enough data.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        for (int index = 0; index < length; ++index)
        {
          double num5 = data[index][0];
          double num6 = data[index][1];
          num1 += num5;
          num2 += num6;
          double num7 = num5 * num5;
          num3 += num7;
          double num8 = num5 * num6;
          num4 += num8;
        }
        double num9 = num3 - num1 * num1 / (double) length;
        double num10 = num4 - num1 * num2 / (double) length;
        double num11 = num1 / (double) length;
        double num12 = num2 / (double) length;
        double[] numArray = new double[2]
        {
          0.0,
          num10 / num9
        };
        numArray[0] = num12 - numArray[1] * num11;
        return numArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 104, (byte) 100, (byte) 176, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 107, (byte) 108, (byte) 108, (byte) 102, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 232, (byte) 56, (byte) 235, (byte) 74, (byte) 107, (byte) 108, (byte) 103, (byte) 135, (byte) 104, (byte) 106, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] getOLSRegression(XYDataset data, int series)
    {
      int itemCount = data.getItemCount(series);
      if (itemCount < 2)
      {
        string str = "Not enough data.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        for (int i2 = 0; i2 < itemCount; ++i2)
        {
          double xvalue = data.getXValue(series, i2);
          double yvalue = data.getYValue(series, i2);
          num1 += xvalue;
          num2 += yvalue;
          double num5 = xvalue * xvalue;
          num3 += num5;
          double num6 = xvalue * yvalue;
          num4 += num6;
        }
        double num7 = num3 - num1 * num1 / (double) itemCount;
        double num8 = num4 - num1 * num2 / (double) itemCount;
        double num9 = num1 / (double) itemCount;
        double num10 = num2 / (double) itemCount;
        double[] numArray = new double[2]
        {
          0.0,
          num8 / num7
        };
        numArray[0] = num10 - numArray[1] * num9;
        return numArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 99, (byte) 100, (byte) 176, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 107, (byte) 110, (byte) 110, (byte) 102, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 232, (byte) 56, (byte) 235, (byte) 74, (byte) 107, (byte) 108, (byte) 103, (byte) 135, (byte) 104, (byte) 106, (byte) 158})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] getPowerRegression(double[][] data)
    {
      int length = data.Length;
      if (length < 2)
      {
        string str = "Not enough data.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        for (int index = 0; index < length; ++index)
        {
          double num5 = Math.log(data[index][0]);
          double num6 = Math.log(data[index][1]);
          num1 += num5;
          num2 += num6;
          double num7 = num5 * num5;
          num3 += num7;
          double num8 = num5 * num6;
          num4 += num8;
        }
        double num9 = num3 - num1 * num1 / (double) length;
        double num10 = num4 - num1 * num2 / (double) length;
        double num11 = num1 / (double) length;
        double num12 = num2 / (double) length;
        double[] numArray = new double[2]
        {
          0.0,
          num10 / num9
        };
        numArray[0] = Math.pow(Math.exp(1.0), num12 - numArray[1] * num11);
        return numArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 104, (byte) 100, (byte) 176, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 107, (byte) 113, (byte) 113, (byte) 102, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 232, (byte) 56, (byte) 235, (byte) 74, (byte) 107, (byte) 108, (byte) 103, (byte) 135, (byte) 104, (byte) 106, (byte) 158})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] getPowerRegression(XYDataset data, int series)
    {
      int itemCount = data.getItemCount(series);
      if (itemCount < 2)
      {
        string str = "Not enough data.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        double num3 = 0.0;
        double num4 = 0.0;
        for (int i2 = 0; i2 < itemCount; ++i2)
        {
          double num5 = Math.log(data.getXValue(series, i2));
          double num6 = Math.log(data.getYValue(series, i2));
          num1 += num5;
          num2 += num6;
          double num7 = num5 * num5;
          num3 += num7;
          double num8 = num5 * num6;
          num4 += num8;
        }
        double num9 = num3 - num1 * num1 / (double) itemCount;
        double num10 = num4 - num1 * num2 / (double) itemCount;
        double num11 = num1 / (double) itemCount;
        double num12 = num2 / (double) itemCount;
        double[] numArray = new double[2]
        {
          0.0,
          num10 / num9
        };
        numArray[0] = Math.pow(Math.exp(1.0), num12 - numArray[1] * num11);
        return numArray;
      }
    }
  }
}
