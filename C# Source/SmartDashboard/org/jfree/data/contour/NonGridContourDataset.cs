// Decompiled with JetBrains decompiler
// Type: org.jfree.data.contour.NonGridContourDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.contour
{
  [Obsolete]
  [Serializable]
  public class NonGridContourDataset : DefaultContourDataset
  {
    internal const int DEFAULT_NUM_X = 50;
    internal const int DEFAULT_NUM_Y = 50;
    internal const int DEFAULT_POWER = 4;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonGridContourDataset()
    {
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonGridContourDataset(string seriesName, object[] xData, object[] yData, object[] zData)
      : base((IComparable) seriesName, xData, yData, zData)
    {
      NonGridContourDataset gridContourDataset = this;
      this.buildGrid(50, 50, 4);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NonGridContourDataset(string seriesName, object[] xData, object[] yData, object[] zData, int numX, int numY, int power)
      : base((IComparable) seriesName, xData, yData, zData)
    {
      NonGridContourDataset gridContourDataset = this;
      this.buildGrid(numX, numY, power);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected NonGridContourDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 100, (byte) 103, (byte) 103, (byte) 167, (byte) 107, (byte) 110, (byte) 56, (byte) 200, (byte) 107, (byte) 110, (byte) 56, (byte) 200, (byte) 107, (byte) 110, (byte) 56, (byte) 200, (byte) 107, (byte) 110, (byte) 56, (byte) 200, (byte) 107, (byte) 139, (byte) 104, (byte) 168, (byte) 111, (byte) 175, (byte) 103, (byte) 107, (byte) 100, (byte) 166, (byte) 136, (byte) 103, (byte) 104, (byte) 105, (byte) 102, (byte) 100, (byte) 166, (byte) 136, (byte) 230, (byte) 55, (byte) 232, (byte) 56, (byte) 235, (byte) 86, (byte) 108, (byte) 103, (byte) 105, (byte) 113, (byte) 113, (byte) 113, (byte) 117, (byte) 100, (byte) 140, (byte) 106, (byte) 105, (byte) 205, (byte) 139, (byte) 139, (byte) 159, (byte) 5, (byte) 232, (byte) 45, (byte) 235, (byte) 85, (byte) 236, (byte) 40, (byte) 235, (byte) 92, (byte) 250, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void buildGrid(int numX, int numY, int power)
    {
      int length = numX * numY;
      double[] data1 = new double[length];
      double[] data2 = new double[length];
      double[] data3 = new double[length];
      double lower1 = 1E+20;
      for (int index = 0; index < this.xValues.Length; ++index)
        lower1 = Math.min(lower1, this.xValues[index].doubleValue());
      double upper1 = -1E+20;
      for (int index = 0; index < this.xValues.Length; ++index)
        upper1 = Math.max(upper1, this.xValues[index].doubleValue());
      double lower2 = 1E+20;
      for (int index = 0; index < this.yValues.Length; ++index)
        lower2 = Math.min(lower2, this.yValues[index].doubleValue());
      double upper2 = -1E+20;
      for (int index = 0; index < this.yValues.Length; ++index)
        upper2 = Math.max(upper2, this.yValues[index].doubleValue());
      Range range1 = new Range(lower1, upper1);
      Range range2 = new Range(lower2, upper2);
      range1.getLength();
      range2.getLength();
      double num1 = range1.getLength() / (double) (numX - 1);
      double num2 = range2.getLength() / (double) (numY - 1);
      double num3 = 0.0;
      for (int index1 = 0; index1 < numX; ++index1)
      {
        if (index1 == 0)
          num3 = lower1;
        else
          num3 += num1;
        double num4 = 0.0;
        for (int index2 = 0; index2 < numY; ++index2)
        {
          int index3 = numY * index1 + index2;
          data1[index3] = num3;
          if (index2 == 0)
            num4 = lower2;
          else
            num4 += num2;
          data2[index3] = num4;
        }
      }
      for (int index1 = 0; index1 < data1.Length; ++index1)
      {
        double num4 = 0.0;
        data3[index1] = 0.0;
        for (int index2 = 0; index2 < this.xValues.Length; ++index2)
        {
          double num5 = this.distance(this.xValues[index2].doubleValue(), this.yValues[index2].doubleValue(), data1[index1], data2[index1]);
          if (power != 1)
            num5 = Math.pow(num5, (double) power);
          double num6 = Math.sqrt(num5);
          double num7 = num6 <= 0.0 ? 1E+20 : 1.0 / num6;
          if (this.zValues[index2] != null)
          {
            double[] numArray1 = data3;
            int index3 = index1;
            double[] numArray2 = numArray1;
            numArray2[index3] = numArray2[index3] + this.zValues[index2].doubleValue() * num7;
          }
          num4 += num7;
        }
        data3[index1] = data3[index1] / num4;
      }
      this.initialize(DefaultContourDataset.formObjectArray(data1), DefaultContourDataset.formObjectArray(data2), DefaultContourDataset.formObjectArray(data3));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double distance(double xDataPt, double yDataPt, double xGrdPt, double yGrdPt)
    {
      double num1 = xDataPt - xGrdPt;
      double num2 = yDataPt - yGrdPt;
      return Math.sqrt(num1 * num1 + num2 * num2);
    }
  }
}
