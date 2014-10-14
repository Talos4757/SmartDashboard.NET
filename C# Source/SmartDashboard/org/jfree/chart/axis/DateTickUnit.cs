// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.DateTickUnit
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class DateTickUnit : TickUnit, Serializable.__Interface
  {
    private const long serialVersionUID = -7289292157229621901L;
    private DateTickUnitType unitType;
    private int count;
    private DateTickUnitType rollUnitType;
    private int rollCount;
    private DateFormat formatter;
    [Obsolete]
    public const int YEAR = 0;
    [Obsolete]
    public const int MONTH = 1;
    [Obsolete]
    public const int DAY = 2;
    [Obsolete]
    public const int HOUR = 3;
    [Obsolete]
    public const int MINUTE = 4;
    [Obsolete]
    public const int SECOND = 5;
    [Obsolete]
    public const int MILLISECOND = 6;
    [Obsolete]
    private int unit;
    [Obsolete]
    private int rollUnit;

    [LineNumberTable(new byte[] {(byte) 71, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTickUnit(DateTickUnitType unitType, int multiple, DateFormat formatter)
      : this(unitType, multiple, unitType, multiple, formatter)
    {
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 112, (byte) 100, (byte) 144, (byte) 100, (byte) 144, (byte) 101, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 168, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTickUnit(DateTickUnitType unitType, int multiple, DateTickUnitType rollUnitType, int rollMultiple, DateFormat formatter)
      : base((double) DateTickUnit.getMillisecondCount(unitType, multiple))
    {
      DateTickUnit dateTickUnit = this;
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (multiple <= 0)
      {
        string str = "Requires 'multiple' > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rollMultiple <= 0)
      {
        string str = "Requires 'rollMultiple' > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.unitType = unitType;
        this.count = multiple;
        this.rollUnitType = rollUnitType;
        this.rollCount = rollMultiple;
        this.formatter = formatter;
        this.unit = DateTickUnit.unitTypeToInt(unitType);
        this.rollUnit = DateTickUnit.unitTypeToInt(rollUnitType);
      }
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 206, (byte) 158})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTickUnit(int unit, int count, int rollUnit, int rollCount, DateFormat formatter)
      : this(DateTickUnit.intToUnitType(unit), count, DateTickUnit.intToUnitType(rollUnit), rollCount, DateTickUnit.notNull(formatter))
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 175, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTickUnit(int unit, int count, DateFormat formatter)
      : this(unit, count, unit, count, formatter)
    {
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTickUnit(DateTickUnitType unitType, int multiple)
      : this(unitType, multiple, DateFormat.getDateInstance(3))
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 189, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTickUnit(int unit, int count)
      : this(unit, count, (DateFormat) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateTickUnit([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DateTickUnit obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [Obsolete]
    public virtual int getCount()
    {
      return this.count;
    }

    [LineNumberTable((ushort) 287)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getCalendarField()
    {
      return this.unitType.getCalendarField();
    }

    [Obsolete]
    public virtual int getUnit()
    {
      return this.unit;
    }

    public virtual int getMultiple()
    {
      return this.count;
    }

    [LineNumberTable((ushort) 220)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string dateToString(Date date)
    {
      return this.formatter.format(date);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 103, (byte) 103, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date addToDate(Date @base, TimeZone zone)
    {
      Calendar instance = Calendar.getInstance(zone);
      instance.setTime(@base);
      instance.add(this.unitType.getCalendarField(), this.count);
      return instance.getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 160, (byte) 103, (byte) 103, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date rollDate(Date @base, TimeZone zone)
    {
      Calendar instance = Calendar.getInstance(zone);
      instance.setTime(@base);
      instance.add(this.rollUnitType.getCalendarField(), this.rollCount);
      return instance.getTime();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 109, (byte) 141, (byte) 109, (byte) 138, (byte) 109, (byte) 138, (byte) 109, (byte) 138, (byte) 109, (byte) 138, (byte) 109, (byte) 138, (byte) 109, (byte) 163})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static long getMillisecondCount([In] DateTickUnitType obj0, [In] int obj1)
    {
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003EYEAR))
        return 31536000000L * (long) obj1;
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003EMONTH))
        return 2678400000L * (long) obj1;
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003EDAY))
        return 86400000L * (long) obj1;
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003EHOUR))
        return 3600000L * (long) obj1;
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003EMINUTE))
        return 60000L * (long) obj1;
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003ESECOND))
        return 1000L * (long) obj1;
      if (obj0.equals((object) DateTickUnitType.__\u003C\u003EMILLISECOND))
        return (long) obj1;
      string str = "The 'unit' argument has a value that is not recognised.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 254, (byte) 99, (byte) 144, (byte) 109, (byte) 130, (byte) 109, (byte) 130, (byte) 109, (byte) 130, (byte) 109, (byte) 130, (byte) 109, (byte) 130, (byte) 109, (byte) 130, (byte) 109, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int unitTypeToInt([In] DateTickUnitType obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'unitType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003EYEAR))
          return 0;
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003EMONTH))
          return 1;
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003EDAY))
          return 2;
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003EHOUR))
          return 3;
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003EMINUTE))
          return 4;
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003ESECOND))
          return 5;
        if (obj0.equals((object) DateTickUnitType.__\u003C\u003EMILLISECOND))
          return 6;
        string str = "The 'unitType' is not recognised";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 231, (byte) 127, (byte) 5, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DateTickUnitType intToUnitType([In] int obj0)
    {
      switch (obj0)
      {
        case 0:
          return DateTickUnitType.__\u003C\u003EYEAR;
        case 1:
          return DateTickUnitType.__\u003C\u003EMONTH;
        case 2:
          return DateTickUnitType.__\u003C\u003EDAY;
        case 3:
          return DateTickUnitType.__\u003C\u003EHOUR;
        case 4:
          return DateTickUnitType.__\u003C\u003EMINUTE;
        case 5:
          return DateTickUnitType.__\u003C\u003ESECOND;
        case 6:
          return DateTickUnitType.__\u003C\u003EMILLISECOND;
        default:
          string str = new StringBuffer().append("Unrecognised 'unit' value ").append(obj0).append(".").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 37, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DateFormat notNull([In] DateFormat obj0)
    {
      if (obj0 != null)
        return obj0;
      return DateFormat.getDateInstance(3);
    }

    public virtual DateTickUnitType getUnitType()
    {
      return this.unitType;
    }

    public virtual DateTickUnitType getRollUnitType()
    {
      return this.rollUnitType;
    }

    public virtual int getRollMultiple()
    {
      return this.rollCount;
    }

    [LineNumberTable((ushort) 209)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string valueToString(double milliseconds)
    {
      return this.formatter.format(new Date(ByteCodeHelper.d2l(milliseconds)));
    }

    [LineNumberTable((ushort) 255)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date rollDate(Date @base)
    {
      return this.rollDate(@base, TimeZone.getDefault());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DateTickUnit) || !base.equals(obj))
        return false;
      DateTickUnit dateTickUnit = (DateTickUnit) obj;
      return this.unitType.equals((object) dateTickUnit.unitType) && this.count == dateTickUnit.count && ObjectUtilities.equal((object) this.formatter, (object) dateTickUnit.formatter);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 99, (byte) 113, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return 37 * (37 * (37 * 19 + Object.instancehelper_hashCode((object) this.unitType)) + this.count) + this.formatter.hashCode();
    }

    [LineNumberTable((ushort) 465)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("DateTickUnit[").append(this.unitType.toString()).append(", ").append(this.count).append("]").toString();
    }

    [Obsolete]
    public virtual int getRollUnit()
    {
      return this.rollUnit;
    }

    [Obsolete]
    public virtual int getRollCount()
    {
      return this.rollCount;
    }

    [Obsolete]
    [LineNumberTable((ushort) 647)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date addToDate(Date @base)
    {
      return this.addToDate(@base, TimeZone.getDefault());
    }
  }
}
