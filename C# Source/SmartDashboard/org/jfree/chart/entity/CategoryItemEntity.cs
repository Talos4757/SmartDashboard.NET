// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.entity.CategoryItemEntity
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using org.jfree.data.category;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.entity
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CategoryItemEntity : ChartEntity, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -8657249457902337349L;
    private CategoryDataset dataset;
    [Obsolete]
    private int series;
    [Obsolete]
    private object category;
    [Obsolete]
    private int categoryIndex;
    private IComparable rowKey;
    private IComparable columnKey;

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 79, (byte) 107, (byte) 100, (byte) 144, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 111, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryItemEntity(Shape area, string toolTipText, string urlText, CategoryDataset dataset, int series, object category, int categoryIndex)
      : base(area, toolTipText, urlText)
    {
      CategoryItemEntity categoryItemEntity = this;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dataset = dataset;
        this.series = series;
        this.category = category;
        this.categoryIndex = categoryIndex;
        this.rowKey = dataset.getRowKey(series);
        this.columnKey = dataset.getColumnKey(categoryIndex);
      }
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 107, (byte) 100, (byte) 144, (byte) 104, (byte) 104, (byte) 168, (byte) 111, (byte) 104, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryItemEntity(Shape area, string toolTipText, string urlText, CategoryDataset dataset, IComparable rowKey, IComparable columnKey)
      : base(area, toolTipText, urlText)
    {
      CategoryItemEntity categoryItemEntity = this;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dataset = dataset;
        this.rowKey = rowKey;
        this.columnKey = columnKey;
        this.series = dataset.getRowIndex(rowKey);
        this.category = (object) columnKey;
        this.categoryIndex = dataset.getColumnIndex(columnKey);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryItemEntity([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryItemEntity obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryItemEntity obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual CategoryDataset getDataset()
    {
      return this.dataset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDataset(CategoryDataset dataset)
    {
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.dataset = dataset;
    }

    public virtual IComparable getRowKey()
    {
      return this.rowKey;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 135, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRowKey(IComparable rowKey)
    {
      this.rowKey = rowKey;
      this.series = this.dataset.getRowIndex(rowKey);
    }

    public virtual IComparable getColumnKey()
    {
      return this.columnKey;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 135, (byte) 103, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setColumnKey(IComparable columnKey)
    {
      this.columnKey = columnKey;
      this.category = (object) columnKey;
      this.categoryIndex = this.dataset.getColumnIndex(columnKey);
    }

    [Obsolete]
    public virtual int getSeries()
    {
      return this.series;
    }

    [Obsolete]
    public virtual void setSeries(int series)
    {
      this.series = series;
    }

    [Obsolete]
    public virtual object getCategory()
    {
      return this.category;
    }

    [Obsolete]
    public virtual void setCategory(object category)
    {
      this.category = category;
    }

    [Obsolete]
    public virtual int getCategoryIndex()
    {
      return this.categoryIndex;
    }

    [Obsolete]
    public virtual void setCategoryIndex(int index)
    {
      this.categoryIndex = index;
    }

    [LineNumberTable((ushort) 344)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("CategoryItemEntity: rowKey=").append((object) this.rowKey).append(", columnKey=").append((object) this.columnKey).append(", dataset=").append((object) this.dataset).toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 194, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryItemEntity))
        return false;
      CategoryItemEntity categoryItemEntity = (CategoryItemEntity) obj;
      if (!Object.instancehelper_equals((object) this.rowKey, (object) categoryItemEntity.rowKey) || !Object.instancehelper_equals((object) this.columnKey, (object) categoryItemEntity.columnKey) || (!ObjectUtilities.equal((object) this.dataset, (object) categoryItemEntity.dataset) || this.categoryIndex != categoryItemEntity.categoryIndex) || (this.series != categoryItemEntity.series || !ObjectUtilities.equal(this.category, categoryItemEntity.category)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
