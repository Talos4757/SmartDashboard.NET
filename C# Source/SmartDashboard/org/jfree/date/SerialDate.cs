// Decompiled with JetBrains decompiler
// Type: org.jfree.date.SerialDate
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.date
{
  [Implements(new string[] {"java.lang.Comparable", "java.io.Serializable", "org.jfree.date.MonthConstants"})]
  [Serializable]
  public abstract class SerialDate : Object, Comparable, Serializable.__Interface, MonthConstants, ISerializable
  {
    internal static DateFormatSymbols __\u003C\u003EDATE_FORMAT_SYMBOLS = new SimpleDateFormat().getDateFormatSymbols();
    private const long serialVersionUID = -293716040467423637L;
    public const int SERIAL_LOWER_BOUND = 2;
    public const int SERIAL_UPPER_BOUND = 2958465;
    public const int MINIMUM_YEAR_SUPPORTED = 1900;
    public const int MAXIMUM_YEAR_SUPPORTED = 9999;
    public const int MONDAY = 2;
    public const int TUESDAY = 3;
    public const int WEDNESDAY = 4;
    public const int THURSDAY = 5;
    public const int FRIDAY = 6;
    public const int SATURDAY = 7;
    public const int SUNDAY = 1;
    [Modifiers]
    internal static int[] LAST_DAY_OF_MONTH;
    [Modifiers]
    internal static int[] AGGREGATE_DAYS_TO_END_OF_MONTH;
    [Modifiers]
    internal static int[] AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH;
    [Modifiers]
    internal static int[] LEAP_YEAR_AGGREGATE_DAYS_TO_END_OF_MONTH;
    [Modifiers]
    internal static int[] LEAP_YEAR_AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH;
    public const int FIRST_WEEK_IN_MONTH = 1;
    public const int SECOND_WEEK_IN_MONTH = 2;
    public const int THIRD_WEEK_IN_MONTH = 3;
    public const int FOURTH_WEEK_IN_MONTH = 4;
    public const int LAST_WEEK_IN_MONTH = 0;
    public const int INCLUDE_NONE = 0;
    public const int INCLUDE_FIRST = 1;
    public const int INCLUDE_SECOND = 2;
    public const int INCLUDE_BOTH = 3;
    public const int PRECEDING = -1;
    public const int NEAREST = 0;
    public const int FOLLOWING = 1;
    private string description;

    [Modifiers]
    public static DateFormatSymbols DATE_FORMAT_SYMBOLS
    {
      [HideFromJava] get
      {
        return SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS;
      }
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 239, (byte) 109, (byte) 223, (byte) 49, (byte) 223, (byte) 73, (byte) 223, (byte) 78, (byte) 255, (byte) 73, (byte) 71})]
    static SerialDate()
    {
      int[] numArray1 = new int[13];
      int index1 = 0;
      int num1 = 0;
      numArray1[index1] = num1;
      int index2 = 1;
      int num2 = 31;
      numArray1[index2] = num2;
      int index3 = 2;
      int num3 = 28;
      numArray1[index3] = num3;
      int index4 = 3;
      int num4 = 31;
      numArray1[index4] = num4;
      int index5 = 4;
      int num5 = 30;
      numArray1[index5] = num5;
      int index6 = 5;
      int num6 = 31;
      numArray1[index6] = num6;
      int index7 = 6;
      int num7 = 30;
      numArray1[index7] = num7;
      int index8 = 7;
      int num8 = 31;
      numArray1[index8] = num8;
      int index9 = 8;
      int num9 = 31;
      numArray1[index9] = num9;
      int index10 = 9;
      int num10 = 30;
      numArray1[index10] = num10;
      int index11 = 10;
      int num11 = 31;
      numArray1[index11] = num11;
      int index12 = 11;
      int num12 = 30;
      numArray1[index12] = num12;
      int index13 = 12;
      int num13 = 31;
      numArray1[index13] = num13;
      SerialDate.LAST_DAY_OF_MONTH = numArray1;
      int[] numArray2 = new int[13];
      int index14 = 0;
      int num14 = 0;
      numArray2[index14] = num14;
      int index15 = 1;
      int num15 = 31;
      numArray2[index15] = num15;
      int index16 = 2;
      int num16 = 59;
      numArray2[index16] = num16;
      int index17 = 3;
      int num17 = 90;
      numArray2[index17] = num17;
      int index18 = 4;
      int num18 = 120;
      numArray2[index18] = num18;
      int index19 = 5;
      int num19 = 151;
      numArray2[index19] = num19;
      int index20 = 6;
      int num20 = 181;
      numArray2[index20] = num20;
      int index21 = 7;
      int num21 = 212;
      numArray2[index21] = num21;
      int index22 = 8;
      int num22 = 243;
      numArray2[index22] = num22;
      int index23 = 9;
      int num23 = 273;
      numArray2[index23] = num23;
      int index24 = 10;
      int num24 = 304;
      numArray2[index24] = num24;
      int index25 = 11;
      int num25 = 334;
      numArray2[index25] = num25;
      int index26 = 12;
      int num26 = 365;
      numArray2[index26] = num26;
      SerialDate.AGGREGATE_DAYS_TO_END_OF_MONTH = numArray2;
      int[] numArray3 = new int[14];
      int index27 = 0;
      int num27 = 0;
      numArray3[index27] = num27;
      int index28 = 1;
      int num28 = 0;
      numArray3[index28] = num28;
      int index29 = 2;
      int num29 = 31;
      numArray3[index29] = num29;
      int index30 = 3;
      int num30 = 59;
      numArray3[index30] = num30;
      int index31 = 4;
      int num31 = 90;
      numArray3[index31] = num31;
      int index32 = 5;
      int num32 = 120;
      numArray3[index32] = num32;
      int index33 = 6;
      int num33 = 151;
      numArray3[index33] = num33;
      int index34 = 7;
      int num34 = 181;
      numArray3[index34] = num34;
      int index35 = 8;
      int num35 = 212;
      numArray3[index35] = num35;
      int index36 = 9;
      int num36 = 243;
      numArray3[index36] = num36;
      int index37 = 10;
      int num37 = 273;
      numArray3[index37] = num37;
      int index38 = 11;
      int num38 = 304;
      numArray3[index38] = num38;
      int index39 = 12;
      int num39 = 334;
      numArray3[index39] = num39;
      int index40 = 13;
      int num40 = 365;
      numArray3[index40] = num40;
      SerialDate.AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH = numArray3;
      int[] numArray4 = new int[13];
      int index41 = 0;
      int num41 = 0;
      numArray4[index41] = num41;
      int index42 = 1;
      int num42 = 31;
      numArray4[index42] = num42;
      int index43 = 2;
      int num43 = 60;
      numArray4[index43] = num43;
      int index44 = 3;
      int num44 = 91;
      numArray4[index44] = num44;
      int index45 = 4;
      int num45 = 121;
      numArray4[index45] = num45;
      int index46 = 5;
      int num46 = 152;
      numArray4[index46] = num46;
      int index47 = 6;
      int num47 = 182;
      numArray4[index47] = num47;
      int index48 = 7;
      int num48 = 213;
      numArray4[index48] = num48;
      int index49 = 8;
      int num49 = 244;
      numArray4[index49] = num49;
      int index50 = 9;
      int num50 = 274;
      numArray4[index50] = num50;
      int index51 = 10;
      int num51 = 305;
      numArray4[index51] = num51;
      int index52 = 11;
      int num52 = 335;
      numArray4[index52] = num52;
      int index53 = 12;
      int num53 = 366;
      numArray4[index53] = num53;
      SerialDate.LEAP_YEAR_AGGREGATE_DAYS_TO_END_OF_MONTH = numArray4;
      int[] numArray5 = new int[14];
      int index54 = 0;
      int num54 = 0;
      numArray5[index54] = num54;
      int index55 = 1;
      int num55 = 0;
      numArray5[index55] = num55;
      int index56 = 2;
      int num56 = 31;
      numArray5[index56] = num56;
      int index57 = 3;
      int num57 = 60;
      numArray5[index57] = num57;
      int index58 = 4;
      int num58 = 91;
      numArray5[index58] = num58;
      int index59 = 5;
      int num59 = 121;
      numArray5[index59] = num59;
      int index60 = 6;
      int num60 = 152;
      numArray5[index60] = num60;
      int index61 = 7;
      int num61 = 182;
      numArray5[index61] = num61;
      int index62 = 8;
      int num62 = 213;
      numArray5[index62] = num62;
      int index63 = 9;
      int num63 = 244;
      numArray5[index63] = num63;
      int index64 = 10;
      int num64 = 274;
      numArray5[index64] = num64;
      int index65 = 11;
      int num65 = 305;
      numArray5[index65] = num65;
      int index66 = 12;
      int num66 = 335;
      numArray5[index66] = num66;
      int index67 = 13;
      int num67 = 366;
      numArray5[index67] = num67;
      SerialDate.LEAP_YEAR_AGGREGATE_DAYS_TO_END_OF_PRECEDING_MONTH = numArray5;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal SerialDate()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SerialDate([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SerialDate obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public static bool isValidMonthCode(int code)
    {
      switch (code)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
        case 10:
        case 11:
        case 12:
          return true;
        default:
          return false;
      }
    }

    [LineNumberTable((ushort) 795)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate createInstance(int day, int month, int yyyy)
    {
      return (SerialDate) new SpreadsheetDate(day, month, yyyy);
    }

    public abstract int getDayOfWeek();

    [LineNumberTable(new byte[] {(byte) 161, (byte) 201, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate addDays(int days, SerialDate @base)
    {
      return SerialDate.createInstance(@base.toSerial() + days);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 108, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SerialDate getEndOfCurrentMonth(SerialDate @base)
    {
      return SerialDate.createInstance(SerialDate.lastDayOfMonth(@base.getMonth(), @base.getYYYY()), @base.getMonth(), @base.getYYYY());
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 14, (byte) 104, (byte) 240, (byte) 71, (byte) 103, (byte) 100, (byte) 172, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate getPreviousDayOfWeek(int targetWeekday, SerialDate @base)
    {
      if (!SerialDate.isValidWeekdayCode(targetWeekday))
      {
        string str = "Invalid day-of-the-week code.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int dayOfWeek = @base.getDayOfWeek();
        return SerialDate.addDays(dayOfWeek <= targetWeekday ? Math.max(0, targetWeekday - dayOfWeek) - 7 : Math.min(0, targetWeekday - dayOfWeek), @base);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 81, (byte) 104, (byte) 240, (byte) 70, (byte) 103, (byte) 106, (byte) 100, (byte) 132, (byte) 101, (byte) 132})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate getNearestDayOfWeek(int targetDOW, SerialDate @base)
    {
      if (!SerialDate.isValidWeekdayCode(targetDOW))
      {
        string str = "Invalid day-of-the-week code.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int dayOfWeek = @base.getDayOfWeek();
        int days = -Math.abs(targetDOW - dayOfWeek);
        if (days >= 4)
          days = 7 - days;
        if (days <= -4)
          days = 7 + days;
        return SerialDate.addDays(days, @base);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 48, (byte) 104, (byte) 240, (byte) 71, (byte) 103, (byte) 100, (byte) 174, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate getFollowingDayOfWeek(int targetWeekday, SerialDate @base)
    {
      if (!SerialDate.isValidWeekdayCode(targetWeekday))
      {
        string str = "Invalid day-of-the-week code.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int dayOfWeek = @base.getDayOfWeek();
        return SerialDate.addDays(dayOfWeek <= targetWeekday ? Math.max(0, targetWeekday - dayOfWeek) : 7 + Math.min(0, targetWeekday - dayOfWeek), @base);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 65, (byte) 98, (byte) 99, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getMonths(bool shortened)
    {
      if (shortened)
        return SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getShortMonths();
      else
        return SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getMonths();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 40, (byte) 66, (byte) 104, (byte) 240, (byte) 70, (byte) 99, (byte) 173, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string monthCodeToString(int month, bool shortened)
    {
      int num = shortened ? 1 : 0;
      if (SerialDate.isValidMonthCode(month))
        return (num == 0 ? SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getMonths() : SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getShortMonths())[month - 1];
      string str = "SerialDate.monthCodeToString: month outside valid range.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 132, (byte) 110, (byte) 130, (byte) 114, (byte) 130, (byte) 111, (byte) 162})]
    public static bool isLeapYear(int yyyy)
    {
      int num1 = yyyy;
      int num2 = 4;
      int num3 = -1;
      if ((num2 != num3 ? num1 % num2 : 0) != 0)
        return false;
      int num4 = yyyy;
      int num5 = 400;
      int num6 = -1;
      if ((num5 != num6 ? num4 % num5 : 0) == 0)
        return true;
      int num7 = yyyy;
      int num8 = 100;
      int num9 = -1;
      return (num8 != num9 ? num7 % num8 : 0) != 0;
    }

    public abstract int toSerial();

    [LineNumberTable((ushort) 807)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate createInstance(int serial)
    {
      return (SerialDate) new SpreadsheetDate(serial);
    }

    public abstract int getYYYY();

    public abstract int getMonth();

    public abstract int getDayOfMonth();

    [LineNumberTable(new byte[] {(byte) 161, (byte) 177, (byte) 104, (byte) 100, (byte) 130, (byte) 104, (byte) 164})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int lastDayOfMonth(int month, int yyyy)
    {
      int num = SerialDate.LAST_DAY_OF_MONTH[month];
      if (month != 2 || !SerialDate.isLeapYear(yyyy))
        return num;
      else
        return num + 1;
    }

    public static bool isValidWeekdayCode(int code)
    {
      switch (code)
      {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
        case 6:
        case 7:
          return true;
        default:
          return false;
      }
    }

    [LineNumberTable((ushort) 388)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string monthCodeToString(int month)
    {
      return SerialDate.monthCodeToString(month, false);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 139, (byte) 139, (byte) 98, (byte) 104, (byte) 103, (byte) 107, (byte) 98, (byte) 130, (byte) 107, (byte) 98, (byte) 226, (byte) 57, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int stringToWeekdayCode(string s)
    {
      string[] shortWeekdays = SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getShortWeekdays();
      string[] weekdays = SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getWeekdays();
      int num = -1;
      s = String.instancehelper_trim(s);
      for (int index = 0; index < weekdays.Length; ++index)
      {
        if (String.instancehelper_equals(s, (object) shortWeekdays[index]))
        {
          num = index;
          break;
        }
        else if (String.instancehelper_equals(s, (object) weekdays[index]))
        {
          num = index;
          break;
        }
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string weekdayCodeToString(int weekday)
    {
      return SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getWeekdays()[weekday];
    }

    [LineNumberTable((ushort) 295)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getMonths()
    {
      return SerialDate.getMonths(false);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 191, (byte) 27, (byte) 162, (byte) 162, (byte) 162, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int monthCodeToQuarter(int code)
    {
      switch (code)
      {
        case 1:
        case 2:
        case 3:
          return 1;
        case 4:
        case 5:
        case 6:
          return 2;
        case 7:
        case 8:
        case 9:
          return 3;
        case 10:
        case 11:
        case 12:
          return 4;
        default:
          string str = "SerialDate.monthCodeToQuarter: invalid month code.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 107, (byte) 139, (byte) 98, (byte) 200, (byte) 210, (byte) 2, (byte) 225, (byte) 69, (byte) 105, (byte) 103, (byte) 107, (byte) 100, (byte) 130, (byte) 107, (byte) 100, (byte) 226, (byte) 57, (byte) 230, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int stringToMonthCode(string s)
    {
      string[] shortMonths = SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getShortMonths();
      string[] months = SerialDate.__\u003C\u003EDATE_FORMAT_SYMBOLS.getMonths();
      int num = -1;
      s = String.instancehelper_trim(s);
      try
      {
        num = Integer.parseInt(s);
        goto label_4;
      }
      catch (NumberFormatException ex)
      {
      }
label_4:
      if (num < 1 || num > 12)
      {
        for (int index = 0; index < months.Length; ++index)
        {
          if (String.instancehelper_equals(s, (object) shortMonths[index]))
          {
            num = index + 1;
            break;
          }
          else if (String.instancehelper_equals(s, (object) months[index]))
          {
            num = index + 1;
            break;
          }
        }
      }
      return num;
    }

    public static bool isValidWeekInMonthCode(int code)
    {
      switch (code)
      {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
          return true;
        default:
          return false;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 159, (byte) 106, (byte) 107, (byte) 110})]
    public static int leapYearCount(int yyyy)
    {
      return (yyyy - 1896) / 4 - (yyyy - 1800) / 100 + (yyyy - 1600) / 400;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 221, (byte) 152, (byte) 159, (byte) 4, (byte) 179})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate addMonths(int months, SerialDate @base)
    {
      int yyyy = (12 * @base.getYYYY() + @base.getMonth() + months - 1) / 12;
      int num1 = 12 * @base.getYYYY() + @base.getMonth() + months - 1;
      int num2 = 12;
      int num3 = -1;
      int month = (num2 != num3 ? num1 % num2 : 0) + 1;
      return SerialDate.createInstance(Math.min(@base.getDayOfMonth(), SerialDate.lastDayOfMonth(month, yyyy)), month, yyyy);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 243, (byte) 103, (byte) 103, (byte) 135, (byte) 100, (byte) 207})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate addYears(int years, SerialDate @base)
    {
      int yyyy1 = @base.getYYYY();
      int month = @base.getMonth();
      int dayOfMonth = @base.getDayOfMonth();
      int yyyy2 = yyyy1 + years;
      return SerialDate.createInstance(Math.min(dayOfMonth, SerialDate.lastDayOfMonth(month, yyyy2)), month, yyyy2);
    }

    public static string weekInMonthToString(int count)
    {
      switch (count)
      {
        case 0:
          return "Last";
        case 1:
          return "First";
        case 2:
          return "Second";
        case 3:
          return "Third";
        case 4:
          return "Fourth";
        default:
          return "SerialDate.weekInMonthToString(): invalid code.";
      }
    }

    public static string relativeToString(int relative)
    {
      switch (relative)
      {
        case -1:
          return "Preceding";
        case 0:
          return "Nearest";
        case 1:
          return "Following";
        default:
          return "ERROR : Relative To String";
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 193, (byte) 102, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerialDate createInstance(Date date)
    {
      GregorianCalendar gregorianCalendar = new GregorianCalendar();
      ((Calendar) gregorianCalendar).setTime(date);
      SpreadsheetDate.__\u003Cclinit\u003E();
      return (SerialDate) new SpreadsheetDate(((Calendar) gregorianCalendar).get(5), ((Calendar) gregorianCalendar).get(2) + 1, ((Calendar) gregorianCalendar).get(1));
    }

    public abstract Date toDate();

    public virtual string getDescription()
    {
      return this.description;
    }

    public virtual void setDescription(string description)
    {
      this.description = description;
    }

    [LineNumberTable((ushort) 871)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append(this.getDayOfMonth()).append("-").append(SerialDate.monthCodeToString(this.getMonth())).append("-").append(this.getYYYY()).toString();
    }

    public abstract int compare(SerialDate sd);

    public abstract bool isOn(SerialDate sd);

    public abstract bool isBefore(SerialDate sd);

    public abstract bool isOnOrBefore(SerialDate sd);

    public abstract bool isAfter(SerialDate sd);

    public abstract bool isOnOrAfter(SerialDate sd);

    public abstract bool isInRange(SerialDate sd1, SerialDate sd2);

    public abstract bool isInRange(SerialDate sd1, SerialDate sd2, int i);

    [LineNumberTable((ushort) 1008)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SerialDate getPreviousDayOfWeek(int targetDOW)
    {
      return SerialDate.getPreviousDayOfWeek(targetDOW, this);
    }

    [LineNumberTable((ushort) 1021)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SerialDate getFollowingDayOfWeek(int targetDOW)
    {
      return SerialDate.getFollowingDayOfWeek(targetDOW, this);
    }

    [LineNumberTable((ushort) 1032)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual SerialDate getNearestDayOfWeek(int targetDOW)
    {
      return SerialDate.getNearestDayOfWeek(targetDOW, this);
    }

    [HideFromReflection]
    public abstract int compareTo([In] object obj0);

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
