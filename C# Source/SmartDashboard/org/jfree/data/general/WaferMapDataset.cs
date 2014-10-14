// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.WaferMapDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Serializable]
  public class WaferMapDataset : AbstractDataset
  {
    private DefaultKeyedValues2D data;
    private int maxChipX;
    private int maxChipY;
    private double chipSpace;
    private Double maxValue;
    private Double minValue;
    private const double DEFAULT_CHIP_SPACE = 1.0;

    [LineNumberTable(new byte[] {(byte) 48, (byte) 136, (byte) 116, (byte) 116, (byte) 139, (byte) 103, (byte) 103, (byte) 99, (byte) 174, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapDataset(int maxChipX, int maxChipY, Number chipSpace)
    {
      WaferMapDataset waferMapDataset = this;
      this.maxValue = new Double(double.NegativeInfinity);
      this.minValue = new Double(double.PositiveInfinity);
      this.data = new DefaultKeyedValues2D();
      this.maxChipX = maxChipX;
      this.maxChipY = maxChipY;
      if (chipSpace == null)
        this.chipSpace = 1.0;
      else
        this.chipSpace = chipSpace.doubleValue();
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapDataset(int maxChipX, int maxChipY)
      : this(maxChipX, maxChipY, (Number) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WaferMapDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual int getMaxChipX()
    {
      return this.maxChipX;
    }

    public virtual int getMaxChipY()
    {
      return this.maxChipY;
    }

    public virtual double getChipSpace()
    {
      return this.chipSpace;
    }

    [LineNumberTable((ushort) 191)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getChipValue(int chipx, int chipy)
    {
      return this.getChipValue((IComparable) new Integer(chipx), (IComparable) new Integer(chipy));
    }

    public virtual Number getMinValue()
    {
      return (Number) this.minValue;
    }

    public virtual Number getMaxValue()
    {
      return (Number) this.maxValue;
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 134, (byte) 112, (byte) 112, (byte) 110, (byte) 99, (byte) 232, (byte) 61, (byte) 38, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Set getUniqueValues()
    {
      TreeSet treeSet = new TreeSet();
      for (int row = 0; row < this.data.getRowCount(); ++row)
      {
        for (int column = 0; column < this.data.getColumnCount(); ++column)
        {
          Number number = this.data.getValue(row, column);
          if (number != null)
            ((Set) treeSet).add((object) number);
        }
      }
      return (Set) treeSet;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 110, (byte) 105, (byte) 140, (byte) 105, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(Number value, IComparable chipx, IComparable chipy)
    {
      this.data.setValue(value, chipx, chipy);
      if (this.isMaxValue(value))
        this.maxValue = (Double) value;
      if (!this.isMinValue(value))
        return;
      this.minValue = (Double) value;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isMaxValue(Number check)
    {
      return check.doubleValue() > this.maxValue.doubleValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isMinValue(Number check)
    {
      return check.doubleValue() < this.minValue.doubleValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 109, (byte) 100, (byte) 130, (byte) 109, (byte) 100, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getChipValue(IComparable chipx, IComparable chipy)
    {
      int rowIndex = this.data.getRowIndex(chipx);
      if (rowIndex < 0)
        return (Number) null;
      int columnIndex = this.data.getColumnIndex(chipy);
      if (columnIndex < 0)
        return (Number) null;
      return this.data.getValue(rowIndex, columnIndex);
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(Number value, IComparable chipx, IComparable chipy)
    {
      this.setValue(value, chipx, chipy);
    }

    [LineNumberTable(new byte[] {(byte) 84, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(int v, int x, int y)
    {
      this.setValue((Number) new Double((double) v), (IComparable) new Integer(x), (IComparable) new Integer(y));
    }

    [LineNumberTable((ushort) 160)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getUniqueValueCount()
    {
      return this.getUniqueValues().size();
    }

    public virtual void setMaxChipX(int maxChipX)
    {
      this.maxChipX = maxChipX;
    }

    public virtual void setMaxChipY(int maxChipY)
    {
      this.maxChipY = maxChipY;
    }

    public virtual void setChipSpace(double space)
    {
      this.chipSpace = space;
    }
  }
}
