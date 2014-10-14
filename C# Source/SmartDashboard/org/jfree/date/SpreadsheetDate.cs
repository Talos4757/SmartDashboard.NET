// Decompiled with JetBrains decompiler
// Type: org.jfree.date.SpreadsheetDate
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.date
{
  [Serializable]
  public class SpreadsheetDate : SerialDate
  {
    private const long serialVersionUID = -2039586705374454461L;
    [Modifiers]
    private int serial;
    [Modifiers]
    private int day;
    [Modifiers]
    private int month;
    [Modifiers]
    private int year;

    [HideFromJava]
    static SpreadsheetDate()
    {
      SerialDate.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 136, (byte) 112, (byte) 169, (byte) 240, (byte) 69, (byte) 137, (byte) 169, (byte) 240, (byte) 69, (byte) 110, (byte) 169, (byte) 208, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpreadsheetDate(int day, int month, int year)
    {
      SpreadsheetDate spreadsheetDate = this;
      if (year >= 1900 && year <= 9999)
      {
        this.year = year;
        if (month >= 1 && month <= 12)
        {
          this.month = month;
          if (day >= 1 && day <= SerialDate.lastDayOfMonth(month, year))
          {
            this.day = day;
            this.serial = this.calcSerial(day, month, year);
          }
          else
          {
            string str = "Invalid 'day' argument.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new IllegalArgumentException(str);
          }
        }
        else
        {
          string str = "The 'month' argument must be in the range 1 to 12.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
      }
      else
      {
        string str = "The 'year' argument must be in range 1900 to 9999.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 136, (byte) 108, (byte) 169, (byte) 240, (byte) 70, (byte) 137, (byte) 110, (byte) 103, (byte) 133, (byte) 144, (byte) 101, (byte) 170, (byte) 108, (byte) 106, (byte) 102, (byte) 142, (byte) 170, (byte) 144, (byte) 167, (byte) 109, (byte) 231, (byte) 69, (byte) 99, (byte) 108, (byte) 106, (byte) 102, (byte) 142, (byte) 170, (byte) 187})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpreadsheetDate(int serial)
    {
      SpreadsheetDate spreadsheetDate = this;
      if (serial >= 2 && serial <= 2958465)
      {
        this.serial = serial;
        int num1 = this.serial - 2;
        int yyyy = 1900 + num1 / 365;
        int num2 = SerialDate.leapYearCount(yyyy);
        int num3 = 1900 + (num1 - num2) / 365;
        if (num3 == yyyy)
        {
          this.year = num3;
        }
        else
        {
          for (int index = this.calcSerial(1, 1, num3); index <= this.serial; index = this.calcSerial(1, 1, num3))
            ++num3;
          this.year = num3 - 1;
        }
        int num4 = this.calcSerial(1, 1, this.year);
        int[] numArray = SerialDate.AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH;
        if (SerialDate.isLeapYear(this.year))
          numArray = SerialDate.LEAP_YEAR_AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH;
        int index1 = 1;
        for (int index2 = num4 + numArray[index1] - 1; index2 < this.serial; index2 = num4 + numArray[index1] - 1)
          ++index1;
        this.month = index1 - 1;
        this.day = this.serial - num4 - numArray[this.month] + 1;
      }
      else
      {
        string str = "SpreadsheetDate: Serial must be in range 2 to 2958465.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SpreadsheetDate([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 80, (byte) 119, (byte) 104, (byte) 100, (byte) 104, (byte) 164, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int calcSerial([In] int obj0, [In] int obj1, [In] int obj2)
    {
      int num1 = (obj2 - 1900) * 365 + SerialDate.leapYearCount(obj2 - 1);
      int num2 = SerialDate.AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH[obj1];
      if (obj1 > 2 && SerialDate.isLeapYear(obj2))
        ++num2;
      int num3 = obj0;
      return num1 + num2 + num3 + 1;
    }

    public override int getYYYY()
    {
      return this.year;
    }

    public override int getMonth()
    {
      return this.month;
    }

    public override int getDayOfMonth()
    {
      return this.day;
    }

    public override int toSerial()
    {
      return this.serial;
    }

    [LineNumberTable((ushort) 309)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compare(SerialDate other)
    {
      return this.serial - other.toSerial();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 48, (byte) 103, (byte) 103, (byte) 104, (byte) 136, (byte) 104, (byte) 100, (byte) 143, (byte) 100, (byte) 143, (byte) 100, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isInRange(SerialDate d1, SerialDate d2, int include)
    {
      int num1 = d1.toSerial();
      int num2 = d2.toSerial();
      int num3 = Math.min(num1, num2);
      int num4 = Math.max(num1, num2);
      int num5 = this.toSerial();
      if (include == 3)
        return num5 >= num3 && num5 <= num4;
      else if (include == 1)
        return num5 >= num3 && num5 < num4;
      else if (include == 2)
        return num5 > num3 && num5 <= num4;
      else
        return num5 > num3 && num5 < num4;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 102, (byte) 125})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Date toDate()
    {
      Calendar instance = Calendar.getInstance();
      instance.set(this.getYYYY(), this.getMonth() - 1, this.getDayOfMonth(), 0, 0, 0);
      return instance.getTime();
    }

    [LineNumberTable((ushort) 264)]
    public override int getDayOfWeek()
    {
      int num1 = this.serial + 6;
      int num2 = 7;
      int num3 = -1;
      return (num2 != num3 ? num1 % num2 : 0) + 1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 104, (byte) 103, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object @object)
    {
      if (@object is SerialDate)
        return ((SerialDate) @object).toSerial() == this.toSerial();
      else
        return false;
    }

    [LineNumberTable((ushort) 296)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return this.toSerial();
    }

    [LineNumberTable((ushort) 321)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object other)
    {
      return this.compare((SerialDate) other);
    }

    [LineNumberTable((ushort) 334)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isOn(SerialDate other)
    {
      return this.serial == other.toSerial();
    }

    [LineNumberTable((ushort) 347)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isBefore(SerialDate other)
    {
      return this.serial < other.toSerial();
    }

    [LineNumberTable((ushort) 360)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isOnOrBefore(SerialDate other)
    {
      return this.serial <= other.toSerial();
    }

    [LineNumberTable((ushort) 373)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isAfter(SerialDate other)
    {
      return this.serial > other.toSerial();
    }

    [LineNumberTable((ushort) 386)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isOnOrAfter(SerialDate other)
    {
      return this.serial >= other.toSerial();
    }

    [LineNumberTable((ushort) 400)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isInRange(SerialDate d1, SerialDate d2)
    {
      return (this.isInRange(d1, d2, 3) ? 1 : 0) != 0;
    }
  }
}
