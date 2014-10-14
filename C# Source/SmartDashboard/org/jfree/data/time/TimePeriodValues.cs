// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.TimePeriodValues
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

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class TimePeriodValues : Series, Serializable.__Interface
  {
    internal const long serialVersionUID = -2210593619794989709L;
    protected internal const string DEFAULT_DOMAIN_DESCRIPTION = "Time";
    protected internal const string DEFAULT_RANGE_DESCRIPTION = "Value";
    private string domain;
    private string range;
    private List data;
    private int minStartIndex;
    private int maxStartIndex;
    private int minMiddleIndex;
    private int maxMiddleIndex;
    private int minEndIndex;
    private int maxEndIndex;

    [LineNumberTable(new byte[] {(byte) 76, (byte) 233, (byte) 26, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 88, (byte) 103, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimePeriodValues(string name, string domain, string range)
      : base((IComparable) name)
    {
      TimePeriodValues timePeriodValues = this;
      this.minStartIndex = -1;
      this.maxStartIndex = -1;
      this.minMiddleIndex = -1;
      this.maxMiddleIndex = -1;
      this.minEndIndex = -1;
      this.maxEndIndex = -1;
      this.domain = domain;
      this.range = range;
      this.data = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimePeriodValues(string name)
      : this(name, "Time", "Value")
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TimePeriodValues([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TimePeriodValues obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 202)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimePeriodValue getDataItem(int index)
    {
      return (TimePeriodValue) this.data.get(index);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 142, (byte) 108, (byte) 108, (byte) 137, (byte) 105, (byte) 156, (byte) 100, (byte) 135, (byte) 130, (byte) 167, (byte) 105, (byte) 156, (byte) 100, (byte) 135, (byte) 130, (byte) 167, (byte) 105, (byte) 156, (byte) 157, (byte) 107, (byte) 101, (byte) 135, (byte) 130, (byte) 167, (byte) 105, (byte) 156, (byte) 157, (byte) 107, (byte) 101, (byte) 135, (byte) 130, (byte) 167, (byte) 105, (byte) 156, (byte) 100, (byte) 135, (byte) 130, (byte) 167, (byte) 105, (byte) 156, (byte) 100, (byte) 135, (byte) 130, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateBounds([In] TimePeriod obj0, [In] int obj1)
    {
      long time1 = obj0.getStart().getTime();
      long time2 = obj0.getEnd().getTime();
      long num1 = time1 + (time2 - time1) / 2L;
      if (this.minStartIndex >= 0)
      {
        long time3 = this.getDataItem(this.minStartIndex).getPeriod().getStart().getTime();
        if (time1 < time3)
          this.minStartIndex = obj1;
      }
      else
        this.minStartIndex = obj1;
      if (this.maxStartIndex >= 0)
      {
        long time3 = this.getDataItem(this.maxStartIndex).getPeriod().getStart().getTime();
        if (time1 > time3)
          this.maxStartIndex = obj1;
      }
      else
        this.maxStartIndex = obj1;
      if (this.minMiddleIndex >= 0)
      {
        long time3 = this.getDataItem(this.minMiddleIndex).getPeriod().getStart().getTime();
        long time4 = this.getDataItem(this.minMiddleIndex).getPeriod().getEnd().getTime();
        long num2 = time3 + (time4 - time3) / 2L;
        if (num1 < num2)
          this.minMiddleIndex = obj1;
      }
      else
        this.minMiddleIndex = obj1;
      if (this.maxMiddleIndex >= 0)
      {
        long time3 = this.getDataItem(this.maxMiddleIndex).getPeriod().getStart().getTime();
        long time4 = this.getDataItem(this.maxMiddleIndex).getPeriod().getEnd().getTime();
        long num2 = time3 + (time4 - time3) / 2L;
        if (num1 > num2)
          this.maxMiddleIndex = obj1;
      }
      else
        this.maxMiddleIndex = obj1;
      if (this.minEndIndex >= 0)
      {
        long time3 = this.getDataItem(this.minEndIndex).getPeriod().getEnd().getTime();
        if (time2 < time3)
          this.minEndIndex = obj1;
      }
      else
        this.minEndIndex = obj1;
      if (this.maxEndIndex >= 0)
      {
        long time3 = this.getDataItem(this.maxEndIndex).getPeriod().getEnd().getTime();
        if (time2 <= time3)
          return;
        this.maxEndIndex = obj1;
      }
      else
        this.maxEndIndex = obj1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 99, (byte) 144, (byte) 109, (byte) 121, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimePeriodValue item)
    {
      if (item == null)
      {
        string str = "Null item not allowed.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data.add((object) item);
        this.updateBounds(item.getPeriod(), this.data.size() - 1);
        this.fireSeriesChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 112, (byte) 114, (byte) 13, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void recalculateBounds()
    {
      this.minStartIndex = -1;
      this.minMiddleIndex = -1;
      this.minEndIndex = -1;
      this.maxStartIndex = -1;
      this.maxMiddleIndex = -1;
      this.maxEndIndex = -1;
      for (int index = 0; index < this.data.size(); ++index)
        this.updateBounds(((TimePeriodValue) this.data.get(index)).getPeriod(), index);
    }

    public virtual string getDomainDescription()
    {
      return this.domain;
    }

    public virtual string getRangeDescription()
    {
      return this.range;
    }

    [LineNumberTable((ushort) 190)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount()
    {
      return this.data.size();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 125, (byte) 140, (byte) 107, (byte) 113, (byte) 102, (byte) 114, (byte) 140, (byte) 210, (byte) 2, (byte) 97, (byte) 239, (byte) 57, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimePeriodValues createCopy(int start, int end)
    {
      TimePeriodValues timePeriodValues = (TimePeriodValues) base.clone();
      timePeriodValues.data = (List) new ArrayList();
      if (this.data.size() > 0)
      {
        for (int index = start; index <= end; ++index)
        {
          TimePeriodValue timePeriodValue = (TimePeriodValue) ((TimePeriodValue) this.data.get(index)).clone();
          try
          {
            timePeriodValues.add(timePeriodValue);
            continue;
          }
          catch (SeriesException ex)
          {
          }
          System.get_err().println("Failed to add cloned item.");
        }
      }
      return timePeriodValues;
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 103, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDomainDescription(string description)
    {
      string str = this.domain;
      this.domain = description;
      this.firePropertyChange("Domain", (object) str, (object) description);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 103, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setRangeDescription(string description)
    {
      string str = this.range;
      this.range = description;
      this.firePropertyChange("Range", (object) str, (object) description);
    }

    [LineNumberTable((ushort) 216)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TimePeriod getTimePeriod(int index)
    {
      return this.getDataItem(index).getPeriod();
    }

    [LineNumberTable((ushort) 230)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int index)
    {
      return this.getDataItem(index).getValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimePeriod period, double value)
    {
      this.add(new TimePeriodValue(period, value));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 2, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(TimePeriod period, Number value)
    {
      this.add(new TimePeriodValue(period, value));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 14, (byte) 104, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(int index, Number value)
    {
      this.getDataItem(index).setValue(value);
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 104, (byte) 45, (byte) 166, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void delete(int start, int end)
    {
      for (int index = 0; index <= end - start; ++index)
        this.data.remove(start);
      this.recalculateBounds();
      this.fireSeriesChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 103, (byte) 105, (byte) 130, (byte) 102, (byte) 117, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TimePeriodValues) || !base.equals(obj))
        return false;
      TimePeriodValues timePeriodValues = (TimePeriodValues) obj;
      if (!ObjectUtilities.equal((object) this.getDomainDescription(), (object) timePeriodValues.getDomainDescription()) || !ObjectUtilities.equal((object) this.getRangeDescription(), (object) timePeriodValues.getRangeDescription()))
        return false;
      int itemCount = this.getItemCount();
      if (itemCount != timePeriodValues.getItemCount())
        return false;
      for (int index = 0; index < itemCount; ++index)
      {
        if (!this.getDataItem(index).equals((object) timePeriodValues.getDataItem(index)))
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 79, (byte) 119, (byte) 124, (byte) 113, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return 29 * (29 * (29 * (29 * (29 * (29 * (29 * (29 * (this.domain == null ? 0 : String.instancehelper_hashCode(this.domain)) + (this.range == null ? 0 : String.instancehelper_hashCode(this.range))) + Object.instancehelper_hashCode((object) this.data)) + this.minStartIndex) + this.maxStartIndex) + this.minMiddleIndex) + this.maxMiddleIndex) + this.minEndIndex) + this.maxEndIndex;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return (object) this.createCopy(0, this.getItemCount() - 1);
    }

    public virtual int getMinStartIndex()
    {
      return this.minStartIndex;
    }

    public virtual int getMaxStartIndex()
    {
      return this.maxStartIndex;
    }

    public virtual int getMinMiddleIndex()
    {
      return this.minMiddleIndex;
    }

    public virtual int getMaxMiddleIndex()
    {
      return this.maxMiddleIndex;
    }

    public virtual int getMinEndIndex()
    {
      return this.minEndIndex;
    }

    public virtual int getMaxEndIndex()
    {
      return this.maxEndIndex;
    }
  }
}
