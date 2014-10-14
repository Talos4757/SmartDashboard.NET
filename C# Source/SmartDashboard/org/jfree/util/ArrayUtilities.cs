// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ArrayUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class ArrayUtilities : Object
  {
    [LineNumberTable(new byte[] {(byte) 8, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ArrayUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 99, (byte) 135, (byte) 104, (byte) 139, (byte) 103, (byte) 100, (byte) 104, (byte) 107, (byte) 228, (byte) 60, (byte) 230, (byte) 71})]
    public static float[][] clone(float[][] array)
    {
      if (array == null)
        return (float[][]) null;
      float[][] numArray1 = new float[array.Length][];
      ByteCodeHelper.arraycopy((object) array, 0, (object) numArray1, 0, array.Length);
      for (int index = 0; index < array.Length; ++index)
      {
        float[] numArray2 = array[index];
        float[] numArray3 = new float[numArray2.Length];
        ByteCodeHelper.arraycopy_primitive_4((Array) numArray2, 0, (Array) numArray3, 0, numArray2.Length);
        numArray1[index] = numArray3;
      }
      return numArray1;
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 102, (byte) 130, (byte) 103, (byte) 101, (byte) 101, (byte) 162, (byte) 101, (byte) 101, (byte) 162, (byte) 104, (byte) 226, (byte) 52, (byte) 230, (byte) 79})]
    public static bool equalReferencesInArrays(object[] array1, object[] array2)
    {
      if (array1 == null)
      {
        return array2 == null;
      }
      else
      {
        if (array2 == null || array1.Length != array2.Length)
          return false;
        for (int index = 0; index < array1.Length; ++index)
        {
          if (array1[index] == null && array2[index] != null || array2[index] == null && array1[index] != null || array1[index] != array2[index])
            return false;
        }
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 99, (byte) 168, (byte) 99, (byte) 162, (byte) 102, (byte) 162, (byte) 103, (byte) 109, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(float[][] array1, float[][] array2)
    {
      if (array1 == null)
      {
        return array2 == null;
      }
      else
      {
        if (array2 == null || array1.Length != array2.Length)
          return false;
        for (int index = 0; index < array1.Length; ++index)
        {
          if (!Arrays.equals(array1[index], array2[index]))
            return false;
        }
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 103, (byte) 102, (byte) 100, (byte) 100, (byte) 102, (byte) 105, (byte) 226, (byte) 59, (byte) 38, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool hasDuplicateItems(object[] array)
    {
      for (int index1 = 0; index1 < array.Length; ++index1)
      {
        for (int index2 = 0; index2 < index1; ++index2)
        {
          object obj1 = array[index1];
          object obj2 = array[index2];
          if (obj1 != null && obj2 != null && Object.instancehelper_equals(obj1, obj2))
            return true;
        }
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 106, (byte) 134, (byte) 100, (byte) 100, (byte) 166, (byte) 130, (byte) 131, (byte) 130, (byte) 131, (byte) 130, (byte) 105, (byte) 132, (byte) 227, (byte) 44, (byte) 230, (byte) 87})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int compareVersionArrays(IComparable[] a1, IComparable[] a2)
    {
      int num1 = Math.min(a1.Length, a2.Length);
      for (int index = 0; index < num1; ++index)
      {
        IComparable comparable1 = a1[index];
        IComparable comparable2 = a2[index];
        if (comparable1 != null || comparable2 != null)
        {
          if (comparable1 == null)
            return 1;
          if (comparable2 == null)
            return -1;
          int num2 = Comparable.__Helper.compareTo(comparable1, (object) comparable2);
          if (num2 != 0)
            return num2;
        }
      }
      return 0;
    }
  }
}
