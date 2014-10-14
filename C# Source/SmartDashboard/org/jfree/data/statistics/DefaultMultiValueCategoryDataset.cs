// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.DefaultMultiValueCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"org.jfree.data.statistics.MultiValueCategoryDataset", "org.jfree.data.RangeInfo", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultMultiValueCategoryDataset : AbstractDataset, MultiValueCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset, RangeInfo, PublicCloneable, Cloneable.__Interface
  {
    protected internal KeyedObjects2D data;
    private Number minimumRangeValue;
    private Number maximumRangeValue;
    private Range rangeBounds;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 107, (byte) 103, (byte) 103, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultMultiValueCategoryDataset()
    {
      DefaultMultiValueCategoryDataset valueCategoryDataset = this;
      this.data = new KeyedObjects2D();
      this.minimumRangeValue = (Number) null;
      this.maximumRangeValue = (Number) null;
      this.rangeBounds = new Range(0.0, 0.0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultMultiValueCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultMultiValueCategoryDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 108, (byte) 103, (byte) 104, (byte) 103, (byte) 104, (byte) 103, (byte) 105, (byte) 105, (byte) 168, (byte) 98, (byte) 102, (byte) 142, (byte) 108, (byte) 107, (byte) 107, (byte) 109, (byte) 111, (byte) 106, (byte) 108, (byte) 236, (byte) 60, (byte) 232, (byte) 72, (byte) 104, (byte) 143, (byte) 111, (byte) 173, (byte) 104, (byte) 143, (byte) 111, (byte) 141, (byte) 223, (byte) 2, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(List values, IComparable rowKey, IComparable columnKey)
    {
      if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rowKey == null)
      {
        string str = "Null 'rowKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (columnKey == null)
      {
        string str = "Null 'columnKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ArrayList arrayList = new ArrayList(values.size());
        ListIterator listIterator = values.listIterator();
        while (((Iterator) listIterator).hasNext())
        {
          object obj = ((Iterator) listIterator).next();
          if (obj is Number)
          {
            Number number = (Number) obj;
            if (!Double.isNaN(number.doubleValue()))
              ((List) arrayList).add((object) number);
          }
        }
        Collections.sort((List) arrayList);
        this.data.addObject((object) arrayList, rowKey, columnKey);
        if (((List) arrayList).size() > 0)
        {
          double num1 = double.NegativeInfinity;
          double num2 = double.PositiveInfinity;
          for (int index = 0; index < ((List) arrayList).size(); ++index)
          {
            double num3 = ((Number) ((List) arrayList).get(index)).doubleValue();
            num2 = Math.min(num2, num3);
            num1 = Math.max(num1, num3);
          }
          if (this.maximumRangeValue == null)
            this.maximumRangeValue = (Number) new Double(num1);
          else if (num1 > this.maximumRangeValue.doubleValue())
            this.maximumRangeValue = (Number) new Double(num1);
          if (this.minimumRangeValue == null)
            this.minimumRangeValue = (Number) new Double(num2);
          else if (num2 < this.minimumRangeValue.doubleValue())
            this.minimumRangeValue = (Number) new Double(num2);
          this.rangeBounds = new Range(this.minimumRangeValue.doubleValue(), this.maximumRangeValue.doubleValue());
        }
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 115, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getValues(int row, int column)
    {
      List list = (List) this.data.getObject(row, column);
      if (list == null)
        return (List) Collections.EMPTY_LIST;
      return Collections.unmodifiableList(list);
    }

    [LineNumberTable((ushort) 188)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getValues(IComparable rowKey, IComparable columnKey)
    {
      return Collections.unmodifiableList((List) this.data.getObject(rowKey, columnKey));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 115, (byte) 102, (byte) 98, (byte) 111, (byte) 107, (byte) 110, (byte) 107, (byte) 228, (byte) 61, (byte) 230, (byte) 69, (byte) 100, (byte) 166, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable row, IComparable column)
    {
      List list = (List) this.data.getObject(row, column);
      double num1 = 0.0;
      int num2 = 0;
      if (list != null && list.size() > 0)
      {
        for (int index = 0; index < list.size(); ++index)
        {
          Number number = (Number) list.get(index);
          num1 += number.doubleValue();
          ++num2;
        }
        if (num2 > 0)
          num1 /= (double) num2;
      }
      if (num2 == 0)
        return (Number) null;
      return (Number) new Double(num1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 115, (byte) 102, (byte) 98, (byte) 111, (byte) 107, (byte) 110, (byte) 107, (byte) 228, (byte) 61, (byte) 230, (byte) 69, (byte) 100, (byte) 166, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      List list = (List) this.data.getObject(row, column);
      double num1 = 0.0;
      int num2 = 0;
      if (list != null && list.size() > 0)
      {
        for (int index = 0; index < list.size(); ++index)
        {
          Number number = (Number) list.get(index);
          num1 += number.doubleValue();
          ++num2;
        }
        if (num2 > 0)
          num1 /= (double) num2;
      }
      if (num2 == 0)
        return (Number) null;
      return (Number) new Double(num1);
    }

    [LineNumberTable((ushort) 256)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      return this.data.getColumnIndex(key);
    }

    [LineNumberTable((ushort) 267)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.data.getColumnKey(column);
    }

    [LineNumberTable((ushort) 276)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      return this.data.getColumnKeys();
    }

    [LineNumberTable((ushort) 287)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      return this.data.getRowIndex(key);
    }

    [LineNumberTable((ushort) 298)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return this.data.getRowKey(row);
    }

    [LineNumberTable((ushort) 307)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return this.data.getRowKeys();
    }

    [LineNumberTable((ushort) 316)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.data.getRowCount();
    }

    [LineNumberTable((ushort) 325)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.data.getColumnCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeLowerBound(bool includeInterval)
    {
      double num = double.NaN;
      if (this.minimumRangeValue != null)
        num = this.minimumRangeValue.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeUpperBound(bool includeInterval)
    {
      double num = double.NaN;
      if (this.maximumRangeValue != null)
        num = this.maximumRangeValue.doubleValue();
      return num;
    }

    public virtual Range getRangeBounds(bool includeInterval)
    {
      return this.rangeBounds;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultMultiValueCategoryDataset))
        return false;
      return (this.data.equals((object) ((DefaultMultiValueCategoryDataset) obj).data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultMultiValueCategoryDataset valueCategoryDataset = (DefaultMultiValueCategoryDataset) base.clone();
      valueCategoryDataset.data = (KeyedObjects2D) this.data.clone();
      return (object) valueCategoryDataset;
    }
  }
}
