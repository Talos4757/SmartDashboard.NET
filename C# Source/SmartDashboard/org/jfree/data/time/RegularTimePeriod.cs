// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.RegularTimePeriod
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using org.jfree.date;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.data.time
{
  [Implements(new string[] {"org.jfree.data.time.TimePeriod", "java.lang.Comparable", "org.jfree.date.MonthConstants"})]
  public abstract class RegularTimePeriod : Object, TimePeriod, Comparable, MonthConstants
  {
    [Obsolete]
    internal static TimeZone __\u003C\u003EDEFAULT_TIME_ZONE = TimeZone.getDefault();
    [Obsolete]
    internal static Calendar __\u003C\u003EWORKING_CALENDAR = Calendar.getInstance(RegularTimePeriod.__\u003C\u003EDEFAULT_TIME_ZONE);
    internal static Class class\u0024java\u0024util\u0024Date;
    internal static Class class\u0024java\u0024util\u0024TimeZone;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Year;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Month;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Day;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Second;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static TimeZone DEFAULT_TIME_ZONE
    {
      [HideFromJava] get
      {
        return RegularTimePeriod.__\u003C\u003EDEFAULT_TIME_ZONE;
      }
    }

    [Modifiers]
    public static Calendar WORKING_CALENDAR
    {
      [HideFromJava] get
      {
        return RegularTimePeriod.__\u003C\u003EWORKING_CALENDAR;
      }
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 234, (byte) 71})]
    static RegularTimePeriod()
    {
    }

    [LineNumberTable((ushort) 71)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RegularTimePeriod()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public abstract RegularTimePeriod previous();

    public abstract void peg(Calendar c);

    public abstract long getFirstMillisecond();

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getMiddleMillisecond()
    {
      long firstMillisecond = this.getFirstMillisecond();
      long lastMillisecond = this.getLastMillisecond();
      return firstMillisecond + (lastMillisecond - firstMillisecond) / 2L;
    }

    public abstract long getLastMillisecond();

    [LineNumberTable((ushort) 194)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getStart()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.getFirstMillisecond());
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 127, (byte) 7, (byte) 159, (byte) 0, (byte) 127, (byte) 7, (byte) 159, (byte) 0, (byte) 127, (byte) 7, (byte) 159, (byte) 0, (byte) 127, (byte) 7, (byte) 159, (byte) 0, (byte) 127, (byte) 7, (byte) 159, (byte) 0, (byte) 127, (byte) 7, (byte) 159, (byte) 0, (byte) 127, (byte) 7, (byte) 191, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Class downsize(Class c)
    {
      if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Year != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Year : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Year = RegularTimePeriod.class\u0024("org.jfree.data.time.Year"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter = RegularTimePeriod.class\u0024("org.jfree.data.time.Quarter");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter;
      }
      else if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Quarter = RegularTimePeriod.class\u0024("org.jfree.data.time.Quarter"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month = RegularTimePeriod.class\u0024("org.jfree.data.time.Month");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month;
      }
      else if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Month = RegularTimePeriod.class\u0024("org.jfree.data.time.Month"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Day == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Day = RegularTimePeriod.class\u0024("org.jfree.data.time.Day");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Day;
      }
      else if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Day != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Day : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Day = RegularTimePeriod.class\u0024("org.jfree.data.time.Day"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour = RegularTimePeriod.class\u0024("org.jfree.data.time.Hour");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour;
      }
      else if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Hour = RegularTimePeriod.class\u0024("org.jfree.data.time.Hour"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute = RegularTimePeriod.class\u0024("org.jfree.data.time.Minute");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute;
      }
      else if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Minute = RegularTimePeriod.class\u0024("org.jfree.data.time.Minute"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second = RegularTimePeriod.class\u0024("org.jfree.data.time.Second");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second;
      }
      else if (Object.instancehelper_equals((object) c, RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second != null ? (object) RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second : (object) (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Second = RegularTimePeriod.class\u0024("org.jfree.data.time.Second"))))
      {
        if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond == null)
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond = RegularTimePeriod.class\u0024("org.jfree.data.time.Millisecond");
        else
          return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond;
      }
      else if (RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond == null)
        return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond = RegularTimePeriod.class\u0024("org.jfree.data.time.Millisecond");
      else
        return RegularTimePeriod.class\u0024org\u0024jfree\u0024data\u0024time\u0024Millisecond;
    }

    public abstract RegularTimePeriod next();

    [LineNumberTable((ushort) 348)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return String.valueOf((object) this.getStart());
    }

    [LineNumberTable((ushort) 89)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, RegularTimePeriod.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    public abstract long getFirstMillisecond(Calendar c);

    public abstract long getLastMillisecond(Calendar c);

    [LineNumberTable(new byte[] {(byte) 36, (byte) 130, (byte) 159, (byte) 53, (byte) 255, (byte) 21, (byte) 69, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static RegularTimePeriod createInstance(Class c, Date millisecond, TimeZone zone)
    {
      RegularTimePeriod regularTimePeriod = (RegularTimePeriod) null;
      try
      {
        Class class1 = c;
        Class[] classArray = new Class[2];
        int index1 = 0;
        Class class2 = RegularTimePeriod.class\u0024java\u0024util\u0024Date != null ? RegularTimePeriod.class\u0024java\u0024util\u0024Date : (RegularTimePeriod.class\u0024java\u0024util\u0024Date = RegularTimePeriod.class\u0024("java.util.Date"));
        classArray[index1] = class2;
        int index2 = 1;
        Class class3 = RegularTimePeriod.class\u0024java\u0024util\u0024TimeZone != null ? RegularTimePeriod.class\u0024java\u0024util\u0024TimeZone : (RegularTimePeriod.class\u0024java\u0024util\u0024TimeZone = RegularTimePeriod.class\u0024("java.util.TimeZone"));
        classArray[index2] = class3;
        CallerID callerId1 = RegularTimePeriod.__\u003CGetCallerID\u003E();
        Constructor declaredConstructor = class1.getDeclaredConstructor(classArray, callerId1);
        object[] objArray = new object[2];
        int index3 = 0;
        Date date = millisecond;
        objArray[index3] = (object) date;
        int index4 = 1;
        TimeZone timeZone = zone;
        objArray[index4] = (object) timeZone;
        CallerID callerId2 = RegularTimePeriod.__\u003CGetCallerID\u003E();
        regularTimePeriod = (RegularTimePeriod) declaredConstructor.newInstance(objArray, callerId2);
        goto label_5;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
label_5:
      return regularTimePeriod;
    }

    public abstract long getSerialIndex();

    [LineNumberTable((ushort) 206)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getEnd()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.getLastMillisecond());
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getFirstMillisecond(TimeZone zone)
    {
      return this.getFirstMillisecond(Calendar.getInstance(zone));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getLastMillisecond(TimeZone zone)
    {
      return this.getLastMillisecond(Calendar.getInstance(zone));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 208, (byte) 103, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getMiddleMillisecond(TimeZone zone)
    {
      Calendar instance = Calendar.getInstance(zone);
      long firstMillisecond = this.getFirstMillisecond(instance);
      long lastMillisecond = this.getLastMillisecond(instance);
      return firstMillisecond + (lastMillisecond - firstMillisecond) / 2L;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getMiddleMillisecond(Calendar calendar)
    {
      long firstMillisecond = this.getFirstMillisecond(calendar);
      long lastMillisecond = this.getLastMillisecond(calendar);
      return firstMillisecond + (lastMillisecond - firstMillisecond) / 2L;
    }

    [HideFromReflection]
    public abstract int compareTo([In] object obj0);

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (RegularTimePeriod.__\u003CcallerID\u003E == null)
        RegularTimePeriod.__\u003CcallerID\u003E = (CallerID) new RegularTimePeriod.__\u003CCallerID\u003E();
      return RegularTimePeriod.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
