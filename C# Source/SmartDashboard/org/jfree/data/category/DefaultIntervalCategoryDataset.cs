// Decompiled with JetBrains decompiler
// Type: org.jfree.data.category.DefaultIntervalCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.chart.util;
using org.jfree.data;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.category
{
  [Implements(new string[] {"org.jfree.data.category.IntervalCategoryDataset"})]
  [Serializable]
  public class DefaultIntervalCategoryDataset : AbstractSeriesDataset, IntervalCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    private IComparable[] seriesKeys;
    private IComparable[] categoryKeys;
    private Number[][] startData;
    private Number[][] endData;

    [LineNumberTable(new byte[] {(byte) 59, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultIntervalCategoryDataset(Number[][] starts, Number[][] ends)
      : this((IComparable[]) null, (IComparable[]) null, starts, ends)
    {
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 136, (byte) 103, (byte) 136, (byte) 141, (byte) 102, (byte) 167, (byte) 99, (byte) 102, (byte) 199, (byte) 141, (byte) 167, (byte) 131, (byte) 101, (byte) 240, (byte) 69, (byte) 169, (byte) 159, (byte) 7, (byte) 207, (byte) 102, (byte) 105, (byte) 199, (byte) 141, (byte) 99, (byte) 102, (byte) 208, (byte) 169, (byte) 159, (byte) 7, (byte) 176, (byte) 130, (byte) 108, (byte) 204})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultIntervalCategoryDataset(IComparable[] seriesKeys, IComparable[] categoryKeys, Number[][] starts, Number[][] ends)
    {
      DefaultIntervalCategoryDataset intervalCategoryDataset = this;
      this.startData = starts;
      this.endData = ends;
      if (starts == null || ends == null)
        return;
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.data.resources.DataPackageResources");
      int length1 = starts.Length;
      if (length1 != ends.Length)
      {
        string str = "DefaultIntervalCategoryDataset: the number of series in the start value dataset does not match the number of series in the end value dataset.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (length1 > 0)
      {
        if (seriesKeys != null)
        {
          if (seriesKeys.Length != length1)
          {
            string str = "The number of series keys does not match the number of series in the data.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
          else
            this.seriesKeys = seriesKeys;
        }
        else
        {
          string str = new StringBuffer().append(bundle.getString("series.default-prefix")).append(" ").toString();
          this.seriesKeys = this.generateKeys(length1, str);
        }
        int length2 = starts[0].Length;
        if (length2 != ends[0].Length)
        {
          string str = "DefaultIntervalCategoryDataset: the number of categories in the start value dataset does not match the number of categories in the end value dataset.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else if (categoryKeys != null)
        {
          if (categoryKeys.Length != length2)
          {
            string str = "The number of category keys does not match the number of categories in the data.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
          else
            this.categoryKeys = categoryKeys;
        }
        else
        {
          string str = new StringBuffer().append(bundle.getString("categories.default-prefix")).append(" ").toString();
          this.categoryKeys = this.generateKeys(length2, str);
        }
      }
      else
      {
        this.seriesKeys = new IComparable[0];
        this.categoryKeys = new IComparable[0];
      }
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultIntervalCategoryDataset(double[][] starts, double[][] ends)
      : this(DataUtilities.createNumberArray2D(starts), DataUtilities.createNumberArray2D(ends))
    {
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultIntervalCategoryDataset(string[] seriesNames, Number[][] starts, Number[][] ends)
      : this((IComparable[]) seriesNames, (IComparable[]) null, starts, ends)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultIntervalCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 226, (byte) 135, (byte) 102, (byte) 121, (byte) 4, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private IComparable[] generateKeys([In] int obj0, [In] string obj1)
    {
      IComparable[] comparableArray = new IComparable[obj0];
      for (int index = 0; index < obj0; ++index)
      {
        string str = new StringBuffer().append(obj1).append(index + 1).toString();
        comparableArray[index] = (IComparable) str;
      }
      return comparableArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 98, (byte) 104, (byte) 136})]
    public override int getSeriesCount()
    {
      int num = 0;
      if (this.startData != null)
        num = this.startData.Length;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 98, (byte) 104, (byte) 105, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getCategoryCount()
    {
      int num = 0;
      if (this.startData != null && this.getSeriesCount() > 0)
        num = this.startData[0].Length;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 98, (byte) 108, (byte) 112, (byte) 98, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSeriesIndex(IComparable seriesKey)
    {
      int num = -1;
      for (int index = 0; index < this.seriesKeys.Length; ++index)
      {
        if (Object.instancehelper_equals((object) seriesKey, (object) this.seriesKeys[index]))
        {
          num = index;
          break;
        }
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 2, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable columnKey)
    {
      if (columnKey == null)
      {
        string str = "Null 'columnKey' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.getCategoryIndex(columnKey);
    }

    [LineNumberTable((ushort) 395)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int series, int category)
    {
      return this.getEndValue(series, category);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 115, (byte) 109, (byte) 240, (byte) 69, (byte) 109, (byte) 240, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(int series, int category)
    {
      if (series < 0 || series >= this.getSeriesCount())
      {
        string str = "DefaultIntervalCategoryDataset.getValue(): series index out of range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (category >= 0 && category < this.getCategoryCount())
          return this.endData[series][category];
        string str = "DefaultIntervalCategoryDataset.getValue(): category index out of range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 109, (byte) 240, (byte) 69, (byte) 109, (byte) 240, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(int series, int category)
    {
      if (series < 0 || series >= this.getSeriesCount())
      {
        string str = "DefaultIntervalCategoryDataset.getValue(): series index out of range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (category >= 0 && category < this.getCategoryCount())
          return this.startData[series][category];
        string str = "DefaultIntervalCategoryDataset.getValue(): category index out of range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 206, (byte) 98, (byte) 108, (byte) 112, (byte) 98, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getCategoryIndex(IComparable category)
    {
      int num = -1;
      for (int index = 0; index < this.categoryKeys.Length; ++index)
      {
        if (Object.instancehelper_equals((object) category, (object) this.categoryKeys[index]))
        {
          num = index;
          break;
        }
      }
      return num;
    }

    [LineNumberTable((ushort) 705)]
    public virtual int getRowCount()
    {
      return this.seriesKeys.Length;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 141, (byte) 99, (byte) 136, (byte) 99, (byte) 130, (byte) 102, (byte) 130, (byte) 103, (byte) 109, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool equal([In] Number[][] obj0, [In] Number[][] obj1)
    {
      if (obj0 == null)
      {
        return obj1 == null;
      }
      else
      {
        if (obj1 == null || obj0.Length != obj1.Length)
          return false;
        for (int index = 0; index < obj0.Length; ++index)
        {
          if (!Arrays.equals((object[]) obj0[index], (object[]) obj1[index]))
            return false;
        }
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 166, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 100, (byte) 104, (byte) 107, (byte) 228, (byte) 60, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Number[][] clone([In] Number[][] obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'array' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Number[][] numberArray1 = new Number[obj0.Length][];
        for (int index = 0; index < obj0.Length; ++index)
        {
          Number[] numberArray2 = obj0[index];
          Number[] numberArray3 = new Number[numberArray2.Length];
          ByteCodeHelper.arraycopy((object) numberArray2, 0, (object) numberArray3, 0, numberArray2.Length);
          numberArray1[index] = numberArray3;
        }
        return numberArray1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 104, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      if (this.categoryKeys == null)
        return (List) new ArrayList();
      else
        return Collections.unmodifiableList(Arrays.asList((object[]) this.categoryKeys));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 150, (byte) 109, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      if (series < this.getSeriesCount() && series >= 0)
        return this.seriesKeys[series];
      string str = new StringBuffer().append("No such series : ").append(series).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 99, (byte) 144, (byte) 106, (byte) 176, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSeriesKeys(IComparable[] seriesKeys)
    {
      if (seriesKeys == null)
      {
        string str = "Null 'seriesKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (seriesKeys.Length != this.getSeriesCount())
      {
        string str = "The number of series keys does not match the data.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesKeys = seriesKeys;
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 99, (byte) 144, (byte) 106, (byte) 176, (byte) 103, (byte) 101, (byte) 16, (byte) 230, (byte) 71, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategoryKeys(IComparable[] categoryKeys)
    {
      if (categoryKeys == null)
      {
        string str = "Null 'categoryKeys' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (categoryKeys.Length != this.getCategoryCount())
      {
        string str = "The number of categories does not match the data.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        for (int index = 0; index < categoryKeys.Length; ++index)
        {
          if (categoryKeys[index] == null)
          {
            string str = "DefaultIntervalCategoryDataset.setCategoryKeys(): null category not permitted.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
        }
        this.categoryKeys = categoryKeys;
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 0, (byte) 104, (byte) 100, (byte) 144, (byte) 104, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable series, IComparable category)
    {
      int seriesIndex = this.getSeriesIndex(series);
      if (seriesIndex < 0)
      {
        string message = "Unknown 'series' key.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        int columnIndex = this.getColumnIndex(category);
        if (columnIndex < 0)
        {
          string message = "Unknown 'category' key.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
        else
          return this.getValue(seriesIndex, columnIndex);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 104, (byte) 100, (byte) 144, (byte) 104, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(IComparable series, IComparable category)
    {
      int seriesIndex = this.getSeriesIndex(series);
      if (seriesIndex < 0)
      {
        string message = "Unknown 'series' key.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        int columnIndex = this.getColumnIndex(category);
        if (columnIndex < 0)
        {
          string message = "Unknown 'category' key.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
        else
          return this.getStartValue(seriesIndex, columnIndex);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 93, (byte) 104, (byte) 100, (byte) 144, (byte) 104, (byte) 100, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(IComparable series, IComparable category)
    {
      int seriesIndex = this.getSeriesIndex(series);
      if (seriesIndex < 0)
      {
        string message = "Unknown 'series' key.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
      else
      {
        int columnIndex = this.getColumnIndex(category);
        if (columnIndex < 0)
        {
          string message = "Unknown 'category' key.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnknownKeyException(message);
        }
        else
          return this.getEndValue(seriesIndex, columnIndex);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 143, (byte) 111, (byte) 240, (byte) 70, (byte) 104, (byte) 100, (byte) 240, (byte) 70, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setStartValue(int series, IComparable category, Number value)
    {
      if (series < 0 || series > this.getSeriesCount() - 1)
      {
        string str = "DefaultIntervalCategoryDataset.setValue: series outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int categoryIndex = this.getCategoryIndex(category);
        if (categoryIndex < 0)
        {
          string str = "DefaultIntervalCategoryDataset.setValue: unrecognised category.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          this.startData[series][categoryIndex] = value;
          this.fireDatasetChanged();
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 176, (byte) 111, (byte) 240, (byte) 70, (byte) 104, (byte) 100, (byte) 240, (byte) 70, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEndValue(int series, IComparable category, Number value)
    {
      if (series < 0 || series > this.getSeriesCount() - 1)
      {
        string str = "DefaultIntervalCategoryDataset.setValue: series outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int categoryIndex = this.getCategoryIndex(category);
        if (categoryIndex < 0)
        {
          string str = "DefaultIntervalCategoryDataset.setValue: unrecognised category.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
        {
          this.endData[series][categoryIndex] = value;
          this.fireDatasetChanged();
        }
      }
    }

    [LineNumberTable((ushort) 615)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.categoryKeys[column];
    }

    [LineNumberTable((ushort) 644)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable rowKey)
    {
      return this.getSeriesIndex(rowKey);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 32, (byte) 104, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      if (this.seriesKeys == null)
        return (List) new ArrayList();
      else
        return Collections.unmodifiableList(Arrays.asList((object[]) this.seriesKeys));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 50, (byte) 109, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      if (row < this.getRowCount() && row >= 0)
        return this.seriesKeys[row];
      string str = "The 'row' argument is out of bounds.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 693)]
    public virtual int getColumnCount()
    {
      return this.categoryKeys.Length;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 90, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultIntervalCategoryDataset))
        return false;
      DefaultIntervalCategoryDataset intervalCategoryDataset = (DefaultIntervalCategoryDataset) obj;
      return Arrays.equals((object[]) this.seriesKeys, (object[]) intervalCategoryDataset.seriesKeys) && Arrays.equals((object[]) this.categoryKeys, (object[]) intervalCategoryDataset.categoryKeys) && (DefaultIntervalCategoryDataset.equal(this.startData, intervalCategoryDataset.startData) && DefaultIntervalCategoryDataset.equal(this.endData, intervalCategoryDataset.endData));
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 123, (byte) 140, (byte) 123, (byte) 123, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultIntervalCategoryDataset intervalCategoryDataset = (DefaultIntervalCategoryDataset) base.clone();
      intervalCategoryDataset.categoryKeys = (IComparable[]) this.categoryKeys.Clone();
      intervalCategoryDataset.seriesKeys = (IComparable[]) this.seriesKeys.Clone();
      intervalCategoryDataset.startData = DefaultIntervalCategoryDataset.clone(this.startData);
      intervalCategoryDataset.endData = DefaultIntervalCategoryDataset.clone(this.endData);
      return (object) intervalCategoryDataset;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 187, (byte) 104, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getSeries()
    {
      if (this.seriesKeys == null)
        return (List) new ArrayList();
      else
        return Collections.unmodifiableList(Arrays.asList((object[]) this.seriesKeys));
    }

    [Obsolete]
    [LineNumberTable((ushort) 829)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getCategories()
    {
      return this.getColumnKeys();
    }

    [Obsolete]
    [LineNumberTable((ushort) 840)]
    public virtual int getItemCount()
    {
      return this.categoryKeys.Length;
    }
  }
}
