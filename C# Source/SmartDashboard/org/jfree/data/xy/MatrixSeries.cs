// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.MatrixSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class MatrixSeries : Series, Serializable.__Interface
  {
    private const long serialVersionUID = 7934188527308315704L;
    protected internal double[][] data;

    [LineNumberTable(new byte[] {(byte) 27, (byte) 105, (byte) 127, (byte) 10, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MatrixSeries(string name, int rows, int columns)
      : base((IComparable) name)
    {
      MatrixSeries matrixSeries = this;
      int num1 = rows;
      int num2 = columns;
      int[] numArray = new int[2];
      int num3 = num2;
      numArray[1] = num3;
      int num4 = num1;
      numArray[0] = num4;
      // ISSUE: type reference
      this.data = (double[][]) ByteCodeHelper.multianewarray(__typeref (double[][]), numArray);
      this.zeroAll();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MatrixSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MatrixSeries obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 103, (byte) 135, (byte) 102, (byte) 102, (byte) 47, (byte) 38, (byte) 230, (byte) 69, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void zeroAll()
    {
      int rowCount = this.getRowCount();
      int columnsCount = this.getColumnsCount();
      for (int index1 = 0; index1 < rowCount; ++index1)
      {
        for (int index2 = 0; index2 < columnsCount; ++index2)
          this.data[index1][index2] = 0.0;
      }
      this.fireSeriesChanged();
    }

    [LineNumberTable((ushort) 144)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemRow(int itemIndex)
    {
      int num1 = itemIndex;
      int columnsCount = this.getColumnsCount();
      int num2 = -1;
      if (columnsCount == num2)
        return -num1;
      else
        return num1 / columnsCount;
    }

    [LineNumberTable((ushort) 121)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemColumn(int itemIndex)
    {
      int num1 = itemIndex;
      int columnsCount = this.getColumnsCount();
      int num2 = -1;
      if (columnsCount == num2)
        return 0;
      else
        return num1 % columnsCount;
    }

    [LineNumberTable((ushort) 170)]
    public virtual double get(int i, int j)
    {
      return this.data[i][j];
    }

    [LineNumberTable((ushort) 88)]
    public virtual int getColumnsCount()
    {
      return this.data[0].Length;
    }

    [LineNumberTable((ushort) 154)]
    public virtual int getRowCount()
    {
      return this.data.Length;
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 104, (byte) 136, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getItem(int itemIndex)
    {
      int itemRow = this.getItemRow(itemIndex);
      int itemColumn = this.getItemColumn(itemIndex);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.get(itemRow, itemColumn));
    }

    [LineNumberTable((ushort) 131)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount()
    {
      return this.getRowCount() * this.getColumnsCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(int i, int j, double mij)
    {
      this.data[i][j] = mij;
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 107, (byte) 107, (byte) 114, (byte) 2, (byte) 38, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is MatrixSeries))
        return false;
      MatrixSeries matrixSeries = (MatrixSeries) obj;
      if (this.getRowCount() != matrixSeries.getRowCount() || this.getColumnsCount() != matrixSeries.getColumnsCount())
        return false;
      for (int i = 0; i < this.getRowCount(); ++i)
      {
        for (int j = 0; j < this.getColumnsCount(); ++j)
        {
          if (this.get(i, j) != matrixSeries.get(i, j))
            return false;
        }
      }
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
