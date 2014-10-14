// Decompiled with JetBrains decompiler
// Type: org.jfree.data.DataUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data
{
  public abstract class DataUtilities : Object
  {
    [LineNumberTable((ushort) 57)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 102, (byte) 105, (byte) 99, (byte) 234, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateColumnTotal(Values2D data, int column)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num = 0.0;
        int rowCount = data.getRowCount();
        for (int i1 = 0; i1 < rowCount; ++i1)
        {
          Number number = data.getValue(i1, column);
          if (number != null)
            num += number.doubleValue();
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 103, (byte) 100, (byte) 100, (byte) 106, (byte) 100, (byte) 235, (byte) 59, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateColumnTotal(Values2D data, int column, int[] validRows)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num = 0.0;
        int rowCount = data.getRowCount();
        for (int index = 0; index < validRows.Length; ++index)
        {
          int i1 = validRows[index];
          if (i1 < rowCount)
          {
            Number number = data.getValue(i1, column);
            if (number != null)
              num += number.doubleValue();
          }
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 48, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number[] createNumberArray(double[] data)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Number[] numberArray1 = new Number[data.Length];
        for (int index1 = 0; index1 < data.Length; ++index1)
        {
          Number[] numberArray2 = numberArray1;
          int index2 = index1;
          Double.__\u003Cclinit\u003E();
          Double @double = new Double(data[index1]);
          numberArray2[index2] = (Number) @double;
        }
        return numberArray1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 102, (byte) 130, (byte) 103, (byte) 109, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(double[][] a, double[][] b)
    {
      if (a == null)
      {
        return b == null;
      }
      else
      {
        if (b == null || a.Length != b.Length)
          return false;
        for (int index = 0; index < a.Length; ++index)
        {
          if (!Arrays.equals(a[index], b[index]))
            return false;
        }
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 101, (byte) 106, (byte) 111, (byte) 228, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[][] clone(double[][] source)
    {
      if (source == null)
      {
        string str = "Null 'source' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double[][] numArray1 = new double[source.Length][];
        for (int index = 0; index < source.Length; ++index)
        {
          if (source[index] != null)
          {
            double[] numArray2 = new double[source[index].Length];
            ByteCodeHelper.arraycopy_primitive_8((Array) source[index], 0, (Array) numArray2, 0, source[index].Length);
            numArray1[index] = numArray2;
          }
        }
        return numArray1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 102, (byte) 105, (byte) 99, (byte) 234, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateRowTotal(Values2D data, int row)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num = 0.0;
        int columnCount = data.getColumnCount();
        for (int i2 = 0; i2 < columnCount; ++i2)
        {
          Number number = data.getValue(row, i2);
          if (number != null)
            num += number.doubleValue();
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 103, (byte) 100, (byte) 100, (byte) 106, (byte) 100, (byte) 235, (byte) 59, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double calculateRowTotal(Values2D data, int row, int[] validCols)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num = 0.0;
        int columnCount = data.getColumnCount();
        for (int index = 0; index < validCols.Length; ++index)
        {
          int i2 = validCols[index];
          if (i2 < columnCount)
          {
            Number number = data.getValue(row, i2);
            if (number != null)
              num += number.doubleValue();
          }
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 99, (byte) 144, (byte) 99, (byte) 103, (byte) 102, (byte) 43, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Number[][] createNumberArray2D(double[][] data)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int length = data.Length;
        Number[][] numberArray = new Number[length][];
        for (int index = 0; index < length; ++index)
          numberArray[index] = DataUtilities.createNumberArray(data[index]);
        return numberArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 99, (byte) 144, (byte) 102, (byte) 102, (byte) 107, (byte) 104, (byte) 99, (byte) 234, (byte) 61, (byte) 230, (byte) 70, (byte) 103, (byte) 109, (byte) 106, (byte) 100, (byte) 141, (byte) 247, (byte) 59, (byte) 232, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KeyedValues getCumulativePercentages(KeyedValues data)
    {
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        DefaultKeyedValues defaultKeyedValues = new DefaultKeyedValues();
        double num1 = 0.0;
        for (int i = 0; i < data.getItemCount(); ++i)
        {
          Number number = data.getValue(i);
          if (number != null)
            num1 += number.doubleValue();
        }
        double num2 = 0.0;
        for (int i = 0; i < data.getItemCount(); ++i)
        {
          Number number = data.getValue(i);
          if (number != null)
            num2 += number.doubleValue();
          defaultKeyedValues.addValue(data.getKey(i), (Number) new Double(num2 / num1));
        }
        return (KeyedValues) defaultKeyedValues;
      }
    }
  }
}
