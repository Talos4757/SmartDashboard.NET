// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.Quarter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.date;
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
  public class Quarter : RegularTimePeriod, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 3810061714380888671L;
    public const int FIRST_QUARTER = 1;
    public const int LAST_QUARTER = 4;
    internal static int[] __\u003C\u003EFIRST_MONTH_IN_QUARTER;
    internal static int[] __\u003C\u003ELAST_MONTH_IN_QUARTER;
    private short year;
    private byte quarter;
    private long firstMillisecond;
    private long lastMillisecond;

    [Modifiers]
    public static int[] FIRST_MONTH_IN_QUARTER
    {
      [HideFromJava] get
      {
        return Quarter.__\u003C\u003EFIRST_MONTH_IN_QUARTER;
      }
    }

    [Modifiers]
    public static int[] LAST_MONTH_IN_QUARTER
    {
      [HideFromJava] get
      {
        return Quarter.__\u003C\u003ELAST_MONTH_IN_QUARTER;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 120, (byte) 101, (byte) 255, (byte) 1, (byte) 70})]
    static Quarter()
    {
      RegularTimePeriod.__\u003Cclinit\u003E();
      int[] numArray1 = new int[5];
      int index1 = 0;
      int num1 = 0;
      numArray1[index1] = num1;
      int index2 = 1;
      int num2 = 1;
      numArray1[index2] = num2;
      int index3 = 2;
      int num3 = 4;
      numArray1[index3] = num3;
      int index4 = 3;
      int num4 = 7;
      numArray1[index4] = num4;
      int index5 = 4;
      int num5 = 10;
      numArray1[index5] = num5;
      Quarter.__\u003C\u003EFIRST_MONTH_IN_QUARTER = numArray1;
      int[] numArray2 = new int[5];
      int index6 = 0;
      int num6 = 0;
      numArray2[index6] = num6;
      int index7 = 1;
      int num7 = 3;
      numArray2[index7] = num7;
      int index8 = 2;
      int num8 = 6;
      numArray2[index8] = num8;
      int index9 = 3;
      int num9 = 9;
      numArray2[index9] = num9;
      int index10 = 4;
      int num10 = 12;
      numArray2[index10] = num10;
      Quarter.__\u003C\u003ELAST_MONTH_IN_QUARTER = numArray2;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quarter(Date time)
      : this(time, TimeZone.getDefault())
    {
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 121, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quarter(Date time, TimeZone zone)
      : this(time, zone, Locale.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 104, (byte) 104, (byte) 103, (byte) 106, (byte) 109, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quarter(Date time, TimeZone zone, Locale locale)
    {
      Quarter quarter = this;
      Calendar instance = Calendar.getInstance(zone, locale);
      instance.setTime(time);
      this.quarter = (byte) SerialDate.monthCodeToQuarter(instance.get(2) + 1);
      this.year = (short) instance.get(1);
      this.peg(instance);
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quarter(int quarter, int year)
    {
      Quarter quarter1 = this;
      if (quarter < 1 || quarter > 4)
      {
        string str = "Quarter outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.year = (short) year;
        this.quarter = (byte) quarter;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 104, (byte) 104, (byte) 144, (byte) 109, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quarter(int quarter, Year year)
    {
      Quarter quarter1 = this;
      if (quarter < 1 || quarter > 4)
      {
        string str = "Quarter outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.year = (short) year.getYear();
        this.quarter = (byte) quarter;
        this.peg(Calendar.getInstance());
      }
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quarter()
      : this(new Date())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Quarter([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Quarter obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void peg(Calendar calendar)
    {
      this.firstMillisecond = this.getFirstMillisecond(calendar);
      this.lastMillisecond = this.getLastMillisecond(calendar);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 110, (byte) 115, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getFirstMillisecond(Calendar calendar)
    {
      int num = Quarter.__\u003C\u003EFIRST_MONTH_IN_QUARTER[(int) (sbyte) this.quarter];
      calendar.set((int) this.year, num - 1, 1, 0, 0, 0);
      calendar.set(14, 0);
      return calendar.getTime().getTime();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 73, (byte) 110, (byte) 109, (byte) 118, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long getLastMillisecond(Calendar calendar)
    {
      int month = Quarter.__\u003C\u003ELAST_MONTH_IN_QUARTER[(int) (sbyte) this.quarter];
      int num = SerialDate.lastDayOfMonth(month, (int) this.year);
      calendar.set((int) this.year, month - 1, num, 23, 59, 59);
      calendar.set(14, 999);
      return calendar.getTime().getTime();
    }

    public virtual int getQuarter()
    {
      return (int) (sbyte) this.quarter;
    }

    public virtual int getYearValue()
    {
      return (int) this.year;
    }

    [LineNumberTable((ushort) 208)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Year getYear()
    {
      Year.__\u003Cclinit\u003E();
      return new Year((int) this.year);
    }

    public override long getFirstMillisecond()
    {
      return this.firstMillisecond;
    }

    public override long getLastMillisecond()
    {
      return this.lastMillisecond;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 106, (byte) 183, (byte) 109, (byte) 177, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod previous()
    {
      return (int) (sbyte) this.quarter <= 1 ? ((int) this.year <= 1900 ? (RegularTimePeriod) null : (RegularTimePeriod) new Quarter(4, (int) this.year - 1)) : (RegularTimePeriod) new Quarter((int) (sbyte) this.quarter - 1, (int) this.year);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 106, (byte) 183, (byte) 109, (byte) 177, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override RegularTimePeriod next()
    {
      return (int) (sbyte) this.quarter >= 4 ? ((int) this.year >= 9999 ? (RegularTimePeriod) null : (RegularTimePeriod) new Quarter(1, (int) this.year + 1)) : (RegularTimePeriod) new Quarter((int) (sbyte) this.quarter + 1, (int) this.year);
    }

    public override long getSerialIndex()
    {
      return (long) this.year * 4L + (long) (sbyte) this.quarter;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 99, (byte) 104, (byte) 103, (byte) 223, (byte) 3, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == null || !(obj is Quarter))
        return false;
      Quarter quarter = (Quarter) obj;
      return (int) (sbyte) this.quarter == quarter.getQuarter() && (int) this.year == quarter.getYearValue();
    }

    public virtual int hashCode()
    {
      return 37 * (37 * 17 + (int) (sbyte) this.quarter) + (int) this.year;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 6, (byte) 104, (byte) 103, (byte) 110, (byte) 99, (byte) 143, (byte) 194, (byte) 136, (byte) 228, (byte) 71, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int compareTo(object o1)
    {
      int num;
      if (o1 is Quarter)
      {
        Quarter quarter = (Quarter) o1;
        num = (int) this.year - quarter.getYearValue();
        if (num == 0)
          num = (int) (sbyte) this.quarter - quarter.getQuarter();
      }
      else
        num = !(o1 is RegularTimePeriod) ? 1 : 0;
      return num;
    }

    [LineNumberTable((ushort) 408)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuffer().append("Q").append((int) (sbyte) this.quarter).append("/").append((int) this.year).toString();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 95, (byte) 108, (byte) 100, (byte) 176, (byte) 107, (byte) 176, (byte) 109, (byte) 103, (byte) 191, (byte) 13, (byte) 107, (byte) 107, (byte) 171, (byte) 109, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Quarter parseQuarter(string s)
    {
      int num = String.instancehelper_indexOf(s, "Q");
      if (num == -1)
      {
        string message = "Missing Q.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TimePeriodFormatException(message);
      }
      else
      {
        if (num != String.instancehelper_length(s) - 1)
          return new Quarter(Integer.parseInt(String.instancehelper_substring(s, num + 1, num + 2)), Year.parseYear(String.instancehelper_trim(String.instancehelper_replace(String.instancehelper_replace(String.instancehelper_replace(new StringBuffer().append(String.instancehelper_substring(s, 0, num)).append(String.instancehelper_substring(s, num + 2, String.instancehelper_length(s))).toString(), '/', ' '), ',', ' '), '-', ' '))));
        string message = "Q found at end of string.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TimePeriodFormatException(message);
      }
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
