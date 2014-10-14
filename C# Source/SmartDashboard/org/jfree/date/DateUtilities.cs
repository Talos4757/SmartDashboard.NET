// Decompiled with JetBrains decompiler
// Type: org.jfree.date.DateUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.date
{
  public class DateUtilities : Object
  {
    [Modifiers]
    private static Calendar CALENDAR = Calendar.getInstance();

    [LineNumberTable((ushort) 63)]
    static DateUtilities()
    {
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DateUtilities()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 124, (byte) 172, (byte) 106, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Date createDate(int yyyy, int month, int day)
    {
      lock ((object) ClassLiteral<DateUtilities>.Value)
      {
        DateUtilities.CALENDAR.clear();
        DateUtilities.CALENDAR.set(yyyy, month - 1, day);
        return DateUtilities.CALENDAR.getTime();
      }
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 108, (byte) 106, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Date createDate(int yyyy, int month, int day, int hour, int min)
    {
      lock ((object) ClassLiteral<DateUtilities>.Value)
      {
        DateUtilities.CALENDAR.clear();
        DateUtilities.CALENDAR.set(yyyy, month - 1, day, hour, min);
        return DateUtilities.CALENDAR.getTime();
      }
    }
  }
}
