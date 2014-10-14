// Decompiled with JetBrains decompiler
// Type: org.jfree.data.category.CategoryToPieDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.category
{
  [Implements(new string[] {"org.jfree.data.general.PieDataset", "org.jfree.data.general.DatasetChangeListener"})]
  [Serializable]
  public class CategoryToPieDataset : AbstractDataset, PieDataset, KeyedValues, Values, Dataset, DatasetChangeListener, EventListener
  {
    internal const long serialVersionUID = 5516396319762189617L;
    private CategoryDataset source;
    private TableOrder extract;
    private int index;

    [LineNumberTable(new byte[] {(byte) 43, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 104, (byte) 140, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryToPieDataset(CategoryDataset source, TableOrder extract, int index)
    {
      CategoryToPieDataset categoryToPieDataset = this;
      if (extract == null)
      {
        string str = "Null 'extract' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.source = source;
        if (this.source != null)
          this.source.addChangeListener((DatasetChangeListener) this);
        this.extract = extract;
        this.index = index;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryToPieDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 98, (byte) 104, (byte) 109, (byte) 142, (byte) 109, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      int num = 0;
      if (this.source != null)
      {
        if (this.extract == TableOrder.__\u003C\u003EBY_ROW)
          num = this.source.getColumnCount();
        else if (this.extract == TableOrder.__\u003C\u003EBY_COLUMN)
          num = this.source.getRowCount();
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 98, (byte) 104, (byte) 109, (byte) 143, (byte) 109, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndex(IComparable key)
    {
      int num = -1;
      if (this.source != null)
      {
        if (this.extract == TableOrder.__\u003C\u003EBY_ROW)
          num = this.source.getColumnIndex(key);
        else if (this.extract == TableOrder.__\u003C\u003EBY_COLUMN)
          num = this.source.getRowIndex(key);
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 98, (byte) 141, (byte) 159, (byte) 6, (byte) 109, (byte) 143, (byte) 109, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getKey(int index)
    {
      IComparable comparable = (IComparable) null;
      if (index < 0 || index >= this.getItemCount())
      {
        string str = new StringBuffer().append("Invalid 'index': ").append(index).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException(str);
      }
      else
      {
        if (this.extract == TableOrder.__\u003C\u003EBY_ROW)
          comparable = this.source.getColumnKey(index);
        else if (this.extract == TableOrder.__\u003C\u003EBY_COLUMN)
          comparable = this.source.getRowKey(index);
        return comparable;
      }
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 98, (byte) 141, (byte) 176, (byte) 109, (byte) 149, (byte) 109, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int item)
    {
      Number number = (Number) null;
      if (item < 0 || item >= this.getItemCount())
      {
        string str = "The 'item' index is out of bounds.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IndexOutOfBoundsException(str);
      }
      else
      {
        if (this.extract == TableOrder.__\u003C\u003EBY_ROW)
          number = this.source.getValue(this.index, item);
        else if (this.extract == TableOrder.__\u003C\u003EBY_COLUMN)
          number = this.source.getValue(item, this.index);
        return number;
      }
    }

    public virtual CategoryDataset getUnderlyingDataset()
    {
      return this.source;
    }

    public virtual TableOrder getExtractType()
    {
      return this.extract;
    }

    public virtual int getExtractIndex()
    {
      return this.index;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 102, (byte) 104, (byte) 109, (byte) 142, (byte) 109, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getKeys()
    {
      List list = (List) Collections.EMPTY_LIST;
      if (this.source != null)
      {
        if (this.extract == TableOrder.__\u003C\u003EBY_ROW)
          list = this.source.getColumnKeys();
        else if (this.extract == TableOrder.__\u003C\u003EBY_COLUMN)
          list = this.source.getRowKeys();
      }
      return list;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 98, (byte) 104, (byte) 100, (byte) 109, (byte) 149, (byte) 109, (byte) 179})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable key)
    {
      Number number = (Number) null;
      int index = this.getIndex(key);
      if (index != -1)
      {
        if (this.extract == TableOrder.__\u003C\u003EBY_ROW)
          number = this.source.getValue(this.index, index);
        else if (this.extract == TableOrder.__\u003C\u003EBY_COLUMN)
          number = this.source.getValue(index, this.index);
      }
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void datasetChanged(DatasetChangeEvent @event)
    {
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 103, (byte) 105, (byte) 130, (byte) 105, (byte) 104, (byte) 105, (byte) 106, (byte) 162, (byte) 105, (byte) 105, (byte) 100, (byte) 100, (byte) 194, (byte) 107, (byte) 226, (byte) 48, (byte) 233, (byte) 84})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PieDataset))
        return false;
      PieDataset pieDataset = (PieDataset) obj;
      int itemCount = this.getItemCount();
      if (pieDataset.getItemCount() != itemCount)
        return false;
      for (int index = 0; index < itemCount; ++index)
      {
        if (!Object.instancehelper_equals((object) this.getKey(index), (object) pieDataset.getKey(index)))
          return false;
        Number number1 = this.getValue(index);
        Number number2 = pieDataset.getValue(index);
        if (number1 == null)
        {
          if (number2 != null)
            return false;
        }
        else if (!Object.instancehelper_equals((object) number1, (object) number2))
          return false;
      }
      return true;
    }
  }
}
