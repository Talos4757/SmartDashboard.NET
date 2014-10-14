// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYSeries
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
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

namespace org.jfree.data.xy
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class XYSeries : Series, Cloneable.__Interface, Serializable.__Interface
  {
    internal const long serialVersionUID = -5908509288197150436L;
    protected internal List data;
    private int maximumItemCount;
    private bool autoSort;
    private bool allowDuplicateXValues;
    private double minX;
    private double maxX;
    private double minY;
    private double maxY;

    [LineNumberTable(new byte[] {(byte) 91, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSeries(IComparable key)
      : this(key, true, true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 68, (byte) 233, (byte) 6, (byte) 235, (byte) 123, (byte) 107, (byte) 103, (byte) 103, (byte) 112, (byte) 112, (byte) 112, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSeries(IComparable key, bool autoSort, bool allowDuplicateXValues)
    {
      int num1 = autoSort ? 1 : 0;
      int num2 = allowDuplicateXValues ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(key);
      XYSeries xySeries = this;
      this.maximumItemCount = int.MaxValue;
      this.data = (List) new ArrayList();
      this.autoSort = num1 != 0;
      this.allowDuplicateXValues = num2 != 0;
      this.minX = double.NaN;
      this.maxX = double.NaN;
      this.minY = double.NaN;
      this.maxY = double.NaN;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 98, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYSeries(IComparable key, bool autoSort)
    {
      int num = autoSort ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(key, num != 0, true);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYSeries([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYSeries obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] XYSeries obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, double y)
    {
      this.add((Number) new Double(x), (Number) new Double(y), true);
    }

    [LineNumberTable((ushort) 342)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 203, (byte) 114, (byte) 103, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataItem remove(int index)
    {
      XYDataItem xyDataItem = (XYDataItem) this.data.remove(index);
      this.updateBoundsForRemovedItem(xyDataItem);
      this.fireSeriesChanged();
      return xyDataItem;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 66, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, Number y)
    {
      this.add((Number) new Double(x), y);
    }

    public virtual bool getAllowDuplicateXValues()
    {
      return this.allowDuplicateXValues;
    }

    [LineNumberTable((ushort) 627)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getX(int index)
    {
      return this.getDataItem(index).getX();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 56, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYSeries) || !base.equals(obj))
        return false;
      XYSeries xySeries = (XYSeries) obj;
      return this.maximumItemCount == xySeries.maximumItemCount && this.autoSort == xySeries.autoSort && (this.allowDuplicateXValues == xySeries.allowDuplicateXValues && ObjectUtilities.equal((object) this.data, (object) xySeries.data));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 100, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Number x, Number y)
    {
      this.add(x, y, true);
    }

    [LineNumberTable((ushort) 616)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataItem getDataItem(int index)
    {
      return (XYDataItem) this.data.get(index);
    }

    [LineNumberTable((ushort) 590)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataItem remove(Number x)
    {
      return this.remove(this.indexOf(x));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 222, (byte) 104, (byte) 181, (byte) 112, (byte) 114, (byte) 110, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(Number x)
    {
      if (this.autoSort)
      {
        return Collections.binarySearch(this.data, (object) new XYDataItem(x, (Number) null));
      }
      else
      {
        for (int index = 0; index < this.data.size(); ++index)
        {
          if (Object.instancehelper_equals((object) ((XYDataItem) this.data.get(index)).getX(), (object) x))
            return index;
        }
        return -1;
      }
    }

    [LineNumberTable((ushort) 638)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getY(int index)
    {
      return this.getDataItem(index).getY();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 11, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYSeries xySeries = (XYSeries) base.clone();
      xySeries.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      return (object) xySeries;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 57, (byte) 105, (byte) 163, (byte) 105, (byte) 163})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double minIgnoreNaN([In] double obj0, [In] double obj1)
    {
      if (Double.isNaN(obj0))
        return obj1;
      if (Double.isNaN(obj1))
        return obj0;
      return Math.min(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 80, (byte) 105, (byte) 163, (byte) 105, (byte) 163})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double maxIgnoreNaN([In] double obj0, [In] double obj1)
    {
      if (Double.isNaN(obj0))
        return obj1;
      if (Double.isNaN(obj1))
        return obj0;
      return Math.max(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void findBoundsByIteration()
    {
      this.minX = double.NaN;
      this.maxX = double.NaN;
      this.minY = double.NaN;
      this.maxY = double.NaN;
      Iterator iterator = this.data.iterator();
      while (iterator.hasNext())
        this.updateBoundsForAddedItem((XYDataItem) iterator.next());
    }

    public virtual bool getAutoSort()
    {
      return this.autoSort;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 104, (byte) 116, (byte) 116, (byte) 104, (byte) 104, (byte) 116, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateBoundsForAddedItem([In] XYDataItem obj0)
    {
      double xvalue = obj0.getXValue();
      this.minX = this.minIgnoreNaN(this.minX, xvalue);
      this.maxX = this.maxIgnoreNaN(this.maxX, xvalue);
      if (obj0.getY() == null)
        return;
      double yvalue = obj0.getYValue();
      this.minY = this.minIgnoreNaN(this.minY, yvalue);
      this.maxY = this.maxIgnoreNaN(this.maxY, yvalue);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 17, (byte) 130, (byte) 99, (byte) 144, (byte) 107, (byte) 109, (byte) 100, (byte) 181, (byte) 139, (byte) 140, (byte) 120, (byte) 134, (byte) 110, (byte) 175, (byte) 141, (byte) 130, (byte) 176, (byte) 130, (byte) 168, (byte) 109, (byte) 100, (byte) 176, (byte) 141, (byte) 103, (byte) 110, (byte) 114, (byte) 135, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(XYDataItem item, bool notify)
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
        else if (!this.allowDuplicateXValues && this.indexOf(item.getX()) >= 0)
        {
          string message = "X-value already exists.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new SeriesException(message);
        }
        else
          this.data.add((object) item);
        this.updateBoundsForAddedItem(item);
        if (this.getItemCount() > this.maximumItemCount)
          this.updateBoundsForRemovedItem((XYDataItem) this.data.remove(0));
        if (num1 == 0)
          return;
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 20, (byte) 66, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Number x, Number y, bool notify)
    {
      int num = notify ? 1 : 0;
      this.add(new XYDataItem(x, y), num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 98, (byte) 98, (byte) 104, (byte) 104, (byte) 114, (byte) 162, (byte) 104, (byte) 104, (byte) 104, (byte) 114, (byte) 194, (byte) 99, (byte) 136, (byte) 99, (byte) 104, (byte) 115, (byte) 188, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateBoundsForRemovedItem([In] XYDataItem obj0)
    {
      int num1 = 0;
      int num2 = 0;
      double xvalue = obj0.getXValue();
      if (!Double.isNaN(xvalue) && (xvalue <= this.minX || xvalue >= this.maxX))
        num1 = 1;
      if (obj0.getY() != null)
      {
        double yvalue = obj0.getYValue();
        if (!Double.isNaN(yvalue) && (yvalue <= this.minY || yvalue >= this.maxY))
          num2 = 1;
      }
      if (num2 != 0)
      {
        this.findBoundsByIteration();
      }
      else
      {
        if (num1 == 0)
          return;
        if (this.getAutoSort())
        {
          this.minX = this.getX(0).doubleValue();
          this.maxX = this.getX(this.getItemCount() - 1).doubleValue();
        }
        else
          this.findBoundsByIteration();
      }
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 26, (byte) 168, (byte) 98, (byte) 104, (byte) 104, (byte) 151, (byte) 135, (byte) 99, (byte) 136, (byte) 99, (byte) 104, (byte) 116, (byte) 148, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(int index, Number y)
    {
      XYDataItem dataItem = this.getDataItem(index);
      int num1 = 0;
      double yvalue = dataItem.getYValue();
      if (!Double.isNaN(yvalue))
        num1 = yvalue <= this.minY || yvalue >= this.maxY ? 1 : 0;
      dataItem.setY(y);
      if (num1 != 0)
        this.findBoundsByIteration();
      else if (y != null)
      {
        double num2 = y.doubleValue();
        this.minY = this.minIgnoreNaN(this.minY, num2);
        this.maxY = this.maxIgnoreNaN(this.maxY, num2);
      }
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateByIndex(int index, Number y)
    {
      this.update(index, y);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 151, (byte) 99, (byte) 144, (byte) 104, (byte) 104, (byte) 194, (byte) 98, (byte) 104, (byte) 103, (byte) 146, (byte) 215, (byte) 2, (byte) 97, (byte) 176, (byte) 98, (byte) 105, (byte) 105, (byte) 153, (byte) 135, (byte) 99, (byte) 136, (byte) 99, (byte) 105, (byte) 117, (byte) 149, (byte) 226, (byte) 70, (byte) 104, (byte) 104, (byte) 178, (byte) 141, (byte) 167, (byte) 110, (byte) 115, (byte) 168, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataItem addOrUpdate(Number x, Number y)
    {
      if (x == null)
      {
        string str = "Null 'x' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (this.allowDuplicateXValues)
      {
        this.add(x, y);
        return (XYDataItem) null;
      }
      else
      {
        XYDataItem xyDataItem1 = (XYDataItem) null;
        int num1 = this.indexOf(x);
        if (num1 >= 0)
        {
          XYDataItem xyDataItem2 = (XYDataItem) this.data.get(num1);
          try
          {
            xyDataItem1 = (XYDataItem) xyDataItem2.clone();
            goto label_9;
          }
          catch (CloneNotSupportedException ex)
          {
          }
          string message = "Couldn't clone XYDataItem!";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new SeriesException(message);
label_9:
          int num2 = 0;
          double yvalue = xyDataItem2.getYValue();
          if (!Double.isNaN(yvalue))
            num2 = yvalue <= this.minY || yvalue >= this.maxY ? 1 : 0;
          xyDataItem2.setY(y);
          if (num2 != 0)
            this.findBoundsByIteration();
          else if (y != null)
          {
            double num3 = y.doubleValue();
            this.minY = this.minIgnoreNaN(this.minY, num3);
            this.maxY = this.minIgnoreNaN(this.maxY, num3);
          }
        }
        else
        {
          XYDataItem xyDataItem2 = new XYDataItem(x, y);
          if (this.autoSort)
            this.data.add(-num1 - 1, (object) xyDataItem2);
          else
            this.data.add((object) xyDataItem2);
          this.updateBoundsForAddedItem(xyDataItem2);
          if (this.getItemCount() > this.maximumItemCount)
            this.updateBoundsForRemovedItem((XYDataItem) this.data.remove(0));
        }
        this.fireSeriesChanged();
        return xyDataItem1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 29, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(XYDataItem item)
    {
      this.add(item, true);
    }

    public virtual double getMinX()
    {
      return this.minX;
    }

    public virtual double getMaxX()
    {
      return this.maxX;
    }

    public virtual double getMinY()
    {
      return this.minY;
    }

    public virtual double getMaxY()
    {
      return this.maxY;
    }

    [LineNumberTable((ushort) 352)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getItems()
    {
      return Collections.unmodifiableList(this.data);
    }

    public virtual int getMaximumItemCount()
    {
      return this.maximumItemCount;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 12, (byte) 103, (byte) 110, (byte) 100, (byte) 114, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumItemCount(int maximum)
    {
      this.maximumItemCount = maximum;
      int num = this.data.size() - maximum;
      if (num <= 0)
        return;
      this.data.subList(0, num).clear();
      this.findBoundsByIteration();
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 36, (byte) 66, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, double y, bool notify)
    {
      int num = notify ? 1 : 0;
      this.add((Number) new Double(x), (Number) new Double(y), num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 30, (byte) 162, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, Number y, bool notify)
    {
      int num = notify ? 1 : 0;
      this.add((Number) new Double(x), y, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 116, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void delete(int start, int end)
    {
      this.data.subList(start, end + 1).clear();
      this.findBoundsByIteration();
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 228, (byte) 110, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      if (this.data.size() <= 0)
        return;
      this.data.clear();
      this.minX = double.NaN;
      this.maxX = double.NaN;
      this.minY = double.NaN;
      this.maxY = double.NaN;
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 116, (byte) 104, (byte) 100, (byte) 191, (byte) 6, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(Number x, Number y)
    {
      int index = this.indexOf(x);
      if (index < 0)
      {
        string message = new StringBuffer().append("No observation for x = ").append((object) x).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SeriesException(message);
      }
      else
        this.updateByIndex(index, y);
    }

    [LineNumberTable((ushort) 763)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYDataItem addOrUpdate(double x, double y)
    {
      return this.addOrUpdate((Number) new Double(x), (Number) new Double(y));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 244, (byte) 103, (byte) 127, (byte) 5, (byte) 104, (byte) 116, (byte) 106, (byte) 100, (byte) 176, (byte) 239, (byte) 57, (byte) 232, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[][] toArray()
    {
      int itemCount = this.getItemCount();
      int num1 = 2;
      int num2 = itemCount;
      int[] numArray1 = new int[2];
      int num3 = num2;
      numArray1[1] = num3;
      int num4 = num1;
      numArray1[0] = num4;
      // ISSUE: type reference
      double[][] numArray2 = (double[][]) ByteCodeHelper.multianewarray(__typeref (double[][]), numArray1);
      for (int index = 0; index < itemCount; ++index)
      {
        numArray2[0][index] = this.getX(index).doubleValue();
        Number y = this.getY(index);
        numArray2[1][index] = y == null ? double.NaN : y.doubleValue();
      }
      return numArray2;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 29, (byte) 108, (byte) 107, (byte) 113, (byte) 102, (byte) 114, (byte) 140, (byte) 210, (byte) 2, (byte) 97, (byte) 239, (byte) 57, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYSeries createCopy(int start, int end)
    {
      XYSeries xySeries = (XYSeries) base.clone();
      xySeries.data = (List) new ArrayList();
      if (this.data.size() > 0)
      {
        for (int index = start; index <= end; ++index)
        {
          XYDataItem xyDataItem = (XYDataItem) ((XYDataItem) this.data.get(index)).clone();
          try
          {
            xySeries.add(xyDataItem);
            continue;
          }
          catch (SeriesException ex)
          {
          }
          System.get_err().println("Unable to add cloned data item.");
        }
      }
      return xySeries;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 87, (byte) 167, (byte) 103, (byte) 100, (byte) 104, (byte) 140, (byte) 100, (byte) 106, (byte) 140, (byte) 100, (byte) 106, (byte) 140, (byte) 108, (byte) 114, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      int num = base.hashCode();
      int itemCount = this.getItemCount();
      if (itemCount > 0)
      {
        XYDataItem dataItem = this.getDataItem(0);
        num = 29 * num + dataItem.hashCode();
      }
      if (itemCount > 1)
      {
        XYDataItem dataItem = this.getDataItem(itemCount - 1);
        num = 29 * num + dataItem.hashCode();
      }
      if (itemCount > 2)
      {
        XYDataItem dataItem = this.getDataItem(itemCount / 2);
        num = 29 * num + dataItem.hashCode();
      }
      return 29 * (29 * (29 * num + this.maximumItemCount) + (!this.autoSort ? 0 : 1)) + (!this.allowDuplicateXValues ? 0 : 1);
    }
  }
}
