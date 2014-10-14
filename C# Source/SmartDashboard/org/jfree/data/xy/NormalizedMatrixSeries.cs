// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.NormalizedMatrixSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Serializable]
  public class NormalizedMatrixSeries : MatrixSeries
  {
    public const double DEFAULT_SCALE_FACTOR = 1.0;
    private double m_scaleFactor;
    private double m_totalSum;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 235, (byte) 51, (byte) 236, (byte) 85, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NormalizedMatrixSeries(string name, int rows, int columns)
      : base(name, rows, columns)
    {
      NormalizedMatrixSeries normalizedMatrixSeries = this;
      this.m_scaleFactor = 1.0;
      this.m_totalSum = 4.94065645841247E-324;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected NormalizedMatrixSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 104, (byte) 136, (byte) 113, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getItem(int itemIndex)
    {
      double num = this.get(this.getItemRow(itemIndex), this.getItemColumn(itemIndex)) * this.m_scaleFactor;
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(num / this.m_totalSum);
    }

    public virtual void setScaleFactor(double factor)
    {
      this.m_scaleFactor = factor;
    }

    public virtual double getScaleFactor()
    {
      return this.m_scaleFactor;
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 118, (byte) 144, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void update(int i, int j, double mij)
    {
      this.m_totalSum -= this.get(i, j);
      this.m_totalSum += mij;
      base.update(i, j, mij);
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zeroAll()
    {
      this.m_totalSum = 0.0;
      base.zeroAll();
    }
  }
}
