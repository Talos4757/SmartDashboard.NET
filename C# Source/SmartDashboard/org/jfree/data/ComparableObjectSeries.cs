// Decompiled with JetBrains decompiler
// Type: org.jfree.data.ComparableObjectSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class ComparableObjectSeries : Series, Cloneable.__Interface, Serializable.__Interface
  {
    protected internal List data;
    private int maximumItemCount;
    private bool autoSort;
    private bool allowDuplicateXValues;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 100, (byte) 233, (byte) 33, (byte) 235, (byte) 96, (byte) 107, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComparableObjectSeries(IComparable key, bool autoSort, bool allowDuplicateXValues)
    {
      int num1 = autoSort ? 1 : 0;
      int num2 = allowDuplicateXValues ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(key);
      ComparableObjectSeries comparableObjectSeries = this;
      this.maximumItemCount = int.MaxValue;
      this.data = (List) new ArrayList();
      this.autoSort = num1 != 0;
      this.allowDuplicateXValues = num2 != 0;
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComparableObjectSeries(IComparable key)
      : this(key, true, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ComparableObjectSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] ComparableObjectSeries obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ComparableObjectSeries obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 92, (byte) 66, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void add(IComparable x, object y, bool notify)
    {
      int num = notify ? 1 : 0;
      this.add(new ComparableObjectItem(x, y), num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 89, (byte) 162, (byte) 99, (byte) 176, (byte) 107, (byte) 109, (byte) 100, (byte) 181, (byte) 139, (byte) 140, (byte) 120, (byte) 134, (byte) 110, (byte) 175, (byte) 141, (byte) 130, (byte) 176, (byte) 130, (byte) 168, (byte) 109, (byte) 100, (byte) 176, (byte) 141, (byte) 110, (byte) 141, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void add(ComparableObjectItem item, bool notify)
    {
      int num1 = notify ? 1 : 0;
      if (item == null)
      {
        string str = "Null 'item' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.autoSort)
        {
          int num2 = Collections.binarySearch(this.data, (object) item);
          if (num2 < 0)
            this.data.add(-num2 - 1, (object) item);
          else if (this.allowDuplicateXValues)
          {
            int num3 = this.data.size();
            while (num2 < num3 && item.compareTo(this.data.get(num2)) == 0)
              ++num2;
            if (num2 < this.data.size())
              this.data.add(num2, (object) item);
            else
              this.data.add((object) item);
          }
          else
          {
            string message = "X-value already exists.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new SeriesException(message);
          }
        }
        else if (!this.allowDuplicateXValues && this.indexOf(item.getComparable()) >= 0)
        {
          string message = "X-value already exists.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new SeriesException(message);
        }
        else
          this.data.add((object) item);
        if (this.getItemCount() > this.maximumItemCount)
          this.data.remove(0);
        if (num1 == 0)
          return;
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 104, (byte) 213, (byte) 112, (byte) 146, (byte) 110, (byte) 226, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(IComparable x)
    {
      if (this.autoSort)
      {
        return Collections.binarySearch(this.data, (object) new ComparableObjectItem(x, (object) null));
      }
      else
      {
        for (int index = 0; index < this.data.size(); ++index)
        {
          if (Object.instancehelper_equals((object) ((ComparableObjectItem) this.data.get(index)).getComparable(), (object) x))
            return index;
        }
        return -1;
      }
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount()
    {
      return this.data.size();
    }

    [LineNumberTable((ushort) 332)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual ComparableObjectItem getDataItem(int index)
    {
      return (ComparableObjectItem) this.data.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 0, (byte) 146, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual ComparableObjectItem remove(int index)
    {
      ComparableObjectItem comparableObjectItem = (ComparableObjectItem) this.data.remove(index);
      this.fireSeriesChanged();
      return comparableObjectItem;
    }

    public virtual bool getAutoSort()
    {
      return this.autoSort;
    }

    public virtual bool getAllowDuplicateXValues()
    {
      return this.allowDuplicateXValues;
    }

    public virtual int getMaximumItemCount()
    {
      return this.maximumItemCount;
    }

    [LineNumberTable(new byte[] {(byte) 109, (byte) 103, (byte) 98, (byte) 110, (byte) 109, (byte) 132, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumItemCount(int maximum)
    {
      this.maximumItemCount = maximum;
      int num = 0;
      while (this.data.size() > maximum)
      {
        this.data.remove(0);
        num = 1;
      }
      if (num == 0)
        return;
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void add(IComparable x, object y)
    {
      this.add(x, y, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 186, (byte) 104, (byte) 100, (byte) 191, (byte) 6, (byte) 104, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void update(IComparable x, object y)
    {
      int index = this.indexOf(x);
      if (index < 0)
      {
        string message = new StringBuffer().append("No observation for x = ").append((object) x).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SeriesException(message);
      }
      else
      {
        this.getDataItem(index).setObject(y);
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 205, (byte) 104, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void updateByIndex(int index, object y)
    {
      this.getDataItem(index).setObject(y);
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 102, (byte) 45, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void delete(int start, int end)
    {
      for (int index = start; index <= end; ++index)
        this.data.remove(start);
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 110, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      if (this.data.size() <= 0)
        return;
      this.data.clear();
      this.fireSeriesChanged();
    }

    [LineNumberTable((ushort) 385)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ComparableObjectItem remove(IComparable x)
    {
      return this.remove(this.indexOf(x));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ComparableObjectSeries) || !base.equals(obj))
        return false;
      ComparableObjectSeries comparableObjectSeries = (ComparableObjectSeries) obj;
      return this.maximumItemCount == comparableObjectSeries.maximumItemCount && this.autoSort == comparableObjectSeries.autoSort && (this.allowDuplicateXValues == comparableObjectSeries.allowDuplicateXValues && ObjectUtilities.equal((object) this.data, (object) comparableObjectSeries.data));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 167, (byte) 103, (byte) 100, (byte) 104, (byte) 140, (byte) 100, (byte) 106, (byte) 140, (byte) 100, (byte) 106, (byte) 140, (byte) 108, (byte) 114, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num = base.hashCode();
      int itemCount = this.getItemCount();
      if (itemCount > 0)
      {
        ComparableObjectItem dataItem = this.getDataItem(0);
        num = 29 * num + dataItem.hashCode();
      }
      if (itemCount > 1)
      {
        ComparableObjectItem dataItem = this.getDataItem(itemCount - 1);
        num = 29 * num + dataItem.hashCode();
      }
      if (itemCount > 2)
      {
        ComparableObjectItem dataItem = this.getDataItem(itemCount / 2);
        num = 29 * num + dataItem.hashCode();
      }
      return 29 * (29 * (29 * num + this.maximumItemCount) + (!this.autoSort ? 0 : 1)) + (!this.allowDuplicateXValues ? 0 : 1);
    }
  }
}
