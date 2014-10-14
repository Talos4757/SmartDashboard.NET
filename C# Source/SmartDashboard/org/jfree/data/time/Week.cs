// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Week
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class Week : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1856387786939865061L;
    public const int FIRST_WEEK_IN_YEAR = 1;
    public const int LAST_WEEK_IN_YEAR = 53;
    private short year;
    private byte week;
    private long firstMillisecond;
    private long lastMillisecond;

    [HideFromJava]
    static Week()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Week(Date time)
      : this(time, TimeZone.getDefault(), Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 104, (byte) 231, (byte) 69, (byte) 104, (byte) 143, (byte) 103, (byte) 178, (byte) 111, (byte) 168, (byte) 148, (byte) 132, (byte) 136, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Week(Date time, TimeZone zone, Locale locale)
    {
      Week week = this;
      if (time == null)
      {
        string str = "Null 'time' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (zone == null)
      {
        string str = "Null 'zone' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (locale == null)
      {
        string str = "Null 'locale' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Calendar instance = Calendar.getInstance(zone, locale);
        instance.setTime(time);
        int num1 = instance.get(3);
        if (num1 == 1 && instance.get(2) == 11)
        {
          this.week = (byte) 1;
          this.year = (short) (instance.get(1) + 1);
        }
        else
        {
          this.week = (byte) Math.min(num1, 53);
          int num2 = instance.get(1);
          if (instance.get(2) == 0 && (int) (sbyte) this.week >= 52)
            num2 += -1;
          this.year = (short) num2;
        }
        this.peg(instance);
      }
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 104, (byte) 105, (byte) 176, (byte) 104, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Week(int week, int year)
    {
      Week week1 = this;
      if (week < 1 && week > 53)
      {
        string str = "The 'week' argument must be in the range 1 - 53.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.week = (byte) week;
        this.year = (short) year;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 104, (byte) 105, (byte) 176, (byte) 104, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Week(int week, Year year)
    {
      Week week1 = this;
      if (week < 1 && week > 53)
      {
        string str = "The 'week' argument must be in the range 1 - 53.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.week = (byte) week;
        this.year = (short) year.getYear();
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Week()
      : this(new Date())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Week(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Week([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Week obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 15, (byte) 108, (byte) 102, (byte) 109, (byte) 110, (byte) 109, (byte) 105, (byte) 105, (byte) 105, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      Calendar calendar1 = (Calendar) calendar.clone();
      calendar1.clear();
      calendar1.set(1, (int) this.year);
      calendar1.set(3, (int) (sbyte) this.week);
      calendar1.set(7, calendar1.getFirstDayOfWeek());
      calendar1.set(10, 0);
      calendar1.set(12, 0);
      calendar1.set(13, 0);
      calendar1.set(14, 0);
      return calendar1.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 108, (byte) 102, (byte) 109, (byte) 112, (byte) 109, (byte) 105, (byte) 105, (byte) 105, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      Calendar calendar1 = (Calendar) calendar.clone();
      calendar1.clear();
      calendar1.set(1, (int) this.year);
      calendar1.set(3, (int) (sbyte) this.week + 1);
      calendar1.set(7, calendar1.getFirstDayOfWeek());
      calendar1.set(10, 0);
      calendar1.set(12, 0);
      calendar1.set(13, 0);
      calendar1.set(14, 0);
      return calendar1.getTime().getTime() - 1L;
    }

    [LineNumberTable((ushort) 235)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Year getYear()
    {
      Year.__\u003Cclinit\u003E();
      return new Year((int) this.year);
    }

    public virtual int getWeek()
    {
      return (int) (sbyte) this.week;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 222, (byte) 105, (byte) 100, (byte) 137, (byte) 100, (byte) 137, (byte) 100, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int findSeparator([In] string obj0)
    {
      int num = String.instancehelper_indexOf(obj0, 45);
      if (num == -1)
        num = String.instancehelper_indexOf(obj0, 44);
      if (num == -1)
        num = String.instancehelper_indexOf(obj0, 32);
      if (num == -1)
        num = String.instancehelper_indexOf(obj0, 46);
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 246, (byte) 130, (byte) 210, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Year evaluateAsYear([In] string obj0)
    {
      Year year = (Year) null;
      try
      {
        year = Year.parseYear(obj0);
        goto label_4;
      }
      catch (TimePeriodFormatException ex)
      {
      }
label_4:
      return year;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 10, (byte) 98, (byte) 108, (byte) 136, (byte) 103, (byte) 105, (byte) 237, (byte) 69, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int stringToWeek([In] string obj0)
    {
      int num = -1;
      obj0 = String.instancehelper_replace(obj0, 'W', ' ');
      obj0 = String.instancehelper_trim(obj0);
      try
      {
        num = Integer.parseInt(obj0);
        if (num >= 1)
        {
          if (num <= 53)
            goto label_6;
        }
        num = -1;
        goto label_6;
      }
      catch (NumberFormatException ex)
      {
      }
label_6:
      return num;
    }

    public virtual int getYearValue()
    {
      return (int) this.year;
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 194, (byte) 106, (byte) 215, (byte) 109, (byte) 105, (byte) 102, (byte) 107, (byte) 142, (byte) 130, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      Week week;
      if ((int) (sbyte) this.week != 1)
        week = new Week((int) (sbyte) this.week - 1, (int) this.year);
      else if ((int) this.year > 1900)
      {
        int year = (int) this.year - 1;
        Calendar instance = Calendar.getInstance();
        instance.set(year, 11, 31);
        week = new Week(instance.getActualMaximum(3), year);
      }
      else
        week = (Week) null;
      return (RegularTimePeriod) week;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 107, (byte) 186, (byte) 102, (byte) 112, (byte) 136, (byte) 106, (byte) 183, (byte) 109, (byte) 177, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      Week week;
      if ((int) (sbyte) this.week < 52)
      {
        week = new Week((int) (sbyte) this.week + 1, (int) this.year);
      }
      else
      {
        Calendar instance = Calendar.getInstance();
        instance.set((int) this.year, 11, 31);
        week = (int) (sbyte) this.week >= instance.getActualMaximum(3) ? ((int) this.year >= 9999 ? (Week) null : new Week(1, (int) this.year + 1)) : new Week((int) (sbyte) this.week + 1, (int) this.year);
      }
      return (RegularTimePeriod) week;
    }

    public override long getSerialIndex()
    {
      return (long) this.year * 53L + (long) (sbyte) this.week;
    }

    [LineNumberTable((ushort) 431)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("Week ").append((int) (sbyte) this.week).append(", ").append((int) this.year).toString();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 112, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Week))
        return false;
      Week week = (Week) obj;
      return (int) (sbyte) this.week == (int) (sbyte) week.week && (int) this.year == (int) week.year;
    }

    public virtual int hashCode()
    {
      return 37 * (37 * 17 + (int) (sbyte) this.week) + (int) this.year;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 125, (byte) 104, (byte) 103, (byte) 115, (byte) 99, (byte) 143, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      int num;
      if (o1 is Week)
      {
        Week week = (Week) o1;
        num = (int) this.year - week.getYear().getYear();
        if (num == 0)
          num = (int) (sbyte) this.week - week.getWeek();
      }
      else
        num = !(o1 is RegularTimePeriod) ? 1 : 0;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 164, (byte) 98, (byte) 166, (byte) 136, (byte) 103, (byte) 103, (byte) 110, (byte) 149, (byte) 136, (byte) 100, (byte) 104, (byte) 101, (byte) 176, (byte) 172, (byte) 104, (byte) 100, (byte) 104, (byte) 101, (byte) 176, (byte) 172, (byte) 240, (byte) 69, (byte) 130, (byte) 240, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Week parseWeek(string s)
    {
      Week week1 = (Week) null;
      if (s != null)
      {
        s = String.instancehelper_trim(s);
        int separator = Week.findSeparator(s);
        if (separator != -1)
        {
          string str1 = String.instancehelper_trim(String.instancehelper_substring(s, 0, separator));
          string str2 = String.instancehelper_trim(String.instancehelper_substring(s, separator + 1, String.instancehelper_length(s)));
          Year year1 = Week.evaluateAsYear(str1);
          if (year1 != null)
          {
            int week2 = Week.stringToWeek(str2);
            if (week2 == -1)
            {
              string message = "Can't evaluate the week.";
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new TimePeriodFormatException(message);
            }
            else
              week1 = new Week(week2, year1);
          }
          else
          {
            Year year2 = Week.evaluateAsYear(str2);
            if (year2 != null)
            {
              int week2 = Week.stringToWeek(str1);
              if (week2 == -1)
              {
                string message = "Can't evaluate the week.";
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new TimePeriodFormatException(message);
              }
              else
                week1 = new Week(week2, year2);
            }
            else
            {
              string message = "Can't evaluate the year.";
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new TimePeriodFormatException(message);
            }
          }
        }
        else
        {
          string message = "Could not find separator.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new TimePeriodFormatException(message);
        }
      }
      return week1;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
