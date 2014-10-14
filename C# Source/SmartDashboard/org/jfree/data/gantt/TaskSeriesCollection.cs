// Decompiled with JetBrains decompiler
// Type: org.jfree.data.gantt.TaskSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.data.time;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.gantt
{
  [Implements(new string[] {"org.jfree.data.gantt.GanttCategoryDataset", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class TaskSeriesCollection : AbstractSeriesDataset, GanttCategoryDataset, IntervalCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -2065799050738449903L;
    private List keys;
    private List data;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TaskSeriesCollection()
    {
      TaskSeriesCollection seriesCollection = this;
      this.keys = (List) new ArrayList();
      this.data = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TaskSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TaskSeriesCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TaskSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 104, (byte) 98, (byte) 108, (byte) 102, (byte) 114, (byte) 110, (byte) 98, (byte) 226, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable rowKey)
    {
      int num1 = -1;
      int num2 = this.data.size();
      for (int index = 0; index < num2; ++index)
      {
        if (Object.instancehelper_equals((object) ((Series) this.data.get(index)).getKey(), (object) rowKey))
        {
          num1 = index;
          break;
        }
      }
      return num1;
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TaskSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (TaskSeries) this.data.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 134)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.getRowCount();
    }

    [LineNumberTable((ushort) 155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 104, (byte) 100, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(IComparable rowKey, IComparable columnKey)
    {
      Long @long = (Long) null;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
      {
        TimePeriod duration = task.getDuration();
        if (duration != null)
        {
          Long.__\u003Cclinit\u003E();
          @long = new Long(duration.getStart().getTime());
        }
      }
      return (Number) @long;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 15, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(int row, int column)
    {
      return this.getStartValue(this.getRowKey(row), this.getColumnKey(column));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int index)
    {
      return ((Series) this.data.get(index)).getKey();
    }

    [LineNumberTable((ushort) 193)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int index)
    {
      return (IComparable) this.keys.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 30, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 104, (byte) 100, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(IComparable rowKey, IComparable columnKey)
    {
      Long @long = (Long) null;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
      {
        TimePeriod duration = task.getDuration();
        if (duration != null)
        {
          Long.__\u003Cclinit\u003E();
          @long = new Long(duration.getEnd().getTime());
        }
      }
      return (Number) @long;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 80, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(IComparable rowKey, IComparable columnKey)
    {
      Double @double = (Double) null;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
        @double = task.getPercentComplete();
      return (Number) @double;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 113, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubIntervalCount(IComparable rowKey, IComparable columnKey)
    {
      int num = 0;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
        num = task.getSubtaskCount();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 105, (byte) 100, (byte) 105, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(IComparable rowKey, IComparable columnKey, int subinterval)
    {
      Long @long = (Long) null;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
      {
        Task subtask = task.getSubtask(subinterval);
        if (subtask != null)
        {
          TimePeriod duration = subtask.getDuration();
          Long.__\u003Cclinit\u003E();
          @long = new Long(duration.getStart().getTime());
        }
      }
      return (Number) @long;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 105, (byte) 100, (byte) 105, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(IComparable rowKey, IComparable columnKey, int subinterval)
    {
      Long @long = (Long) null;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
      {
        Task subtask = task.getSubtask(subinterval);
        if (subtask != null)
        {
          TimePeriod duration = subtask.getDuration();
          Long.__\u003Cclinit\u003E();
          @long = new Long(duration.getEnd().getTime());
        }
      }
      return (Number) @long;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 229, (byte) 98, (byte) 104, (byte) 114, (byte) 109, (byte) 99, (byte) 105, (byte) 100, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(IComparable rowKey, IComparable columnKey, int subinterval)
    {
      Double @double = (Double) null;
      Task task = ((TaskSeries) this.data.get(this.getRowIndex(rowKey))).get(Object.instancehelper_toString((object) columnKey));
      if (task != null)
      {
        Task subtask = task.getSubtask(subinterval);
        if (subtask != null)
          @double = subtask.getPercentComplete();
      }
      return (Number) @double;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 1, (byte) 107, (byte) 110, (byte) 146, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 111, (byte) 101, (byte) 142, (byte) 226, (byte) 53, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void refreshKeys()
    {
      this.keys.clear();
      for (int index = 0; index < this.getSeriesCount(); ++index)
      {
        Iterator iterator = ((TaskSeries) this.data.get(index)).getTasks().iterator();
        while (iterator.hasNext())
        {
          string description = ((Task) iterator.next()).getDescription();
          if (this.keys.indexOf((object) description) < 0)
            this.keys.add((object) description);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 100, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TaskSeries getSeries(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        TaskSeries taskSeries = (TaskSeries) null;
        int rowIndex = this.getRowIndex(key);
        if (rowIndex >= 0)
          taskSeries = this.getSeries(rowIndex);
        return taskSeries;
      }
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return ((Series) this.data.get(series)).getKey();
    }

    public virtual List getRowKeys()
    {
      return this.data;
    }

    [LineNumberTable((ushort) 173)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.keys.size();
    }

    public virtual List getColumnKeys()
    {
      return this.keys;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 99, (byte) 144})]
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
        return this.keys.indexOf((object) columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 136, (byte) 99, (byte) 144, (byte) 109, (byte) 167, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 109, (byte) 100, (byte) 141, (byte) 98, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TaskSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data.add((object) series);
        series.addChangeListener((SeriesChangeListener) this);
        Iterator iterator = series.getTasks().iterator();
        while (iterator.hasNext())
        {
          string description = ((Task) iterator.next()).getDescription();
          if (this.keys.indexOf((object) description) < 0)
            this.keys.add((object) description);
        }
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(TaskSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.data.contains((object) series))
          return;
        series.removeChangeListener((SeriesChangeListener) this);
        this.data.remove((object) series);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 181, (byte) 109, (byte) 240, (byte) 69, (byte) 114, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(int series)
    {
      if (series < 0 || series >= this.getSeriesCount())
      {
        string str = "TaskSeriesCollection.remove(): index outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ((Series) this.data.get(series)).removeChangeListener((SeriesChangeListener) this);
        this.data.remove(series);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 162, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAll()
    {
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
        ((Series) iterator.next()).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 338)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable rowKey, IComparable columnKey)
    {
      return this.getStartValue(rowKey, columnKey);
    }

    [LineNumberTable((ushort) 350)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      return this.getStartValue(row, column);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 52, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(int row, int column)
    {
      return this.getEndValue(this.getRowKey(row), this.getColumnKey(column));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 66, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(int row, int column)
    {
      return this.getPercentComplete(this.getRowKey(row), this.getColumnKey(column));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 99, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubIntervalCount(int row, int column)
    {
      return this.getSubIntervalCount(this.getRowKey(row), this.getColumnKey(column));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 133, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(int row, int column, int subinterval)
    {
      return this.getStartValue(this.getRowKey(row), this.getColumnKey(column), subinterval);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(int row, int column, int subinterval)
    {
      return this.getEndValue(this.getRowKey(row), this.getColumnKey(column), subinterval);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 213, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(int row, int column, int subinterval)
    {
      return this.getPercentComplete(this.getRowKey(row), this.getColumnKey(column), subinterval);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 248, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void seriesChanged(SeriesChangeEvent @event)
    {
      this.refreshKeys();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 26, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is TaskSeriesCollection && ObjectUtilities.equal((object) this.data, (object) ((TaskSeriesCollection) obj).data);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 48, (byte) 108, (byte) 118, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      TaskSeriesCollection seriesCollection = (TaskSeriesCollection) base.clone();
      seriesCollection.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      seriesCollection.keys = (List) new ArrayList((Collection) this.keys);
      return (object) seriesCollection;
    }
  }
}
