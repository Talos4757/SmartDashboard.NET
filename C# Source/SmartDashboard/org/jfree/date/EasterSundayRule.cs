// Decompiled with JetBrains decompiler
// Type: org.jfree.date.EasterSundayRule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace org.jfree.date
{
  public class EasterSundayRule : AnnualDateRule
  {
    [LineNumberTable(new byte[] {(byte) 14, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public EasterSundayRule()
    {
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 110, (byte) 101, (byte) 127, (byte) 5, (byte) 127, (byte) 6, (byte) 124, (byte) 102, (byte) 108, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override SerialDate getDate(int year)
    {
      int num1 = year;
      int num2 = 19;
      int num3 = -1;
      int num4 = num2 != num3 ? num1 % num2 : 0;
      int num5 = year / 100;
      int num6 = num5 - num5 / 4 - (8 * num5 + 13) / 25 + 19 * num4 + 15;
      int num7 = 30;
      int num8 = -1;
      int num9 = num7 != num8 ? num6 % num7 : 0;
      int num10 = num9;
      int num11 = num9 / 28;
      int num12 = 1;
      int num13 = num9 / 28 * 29;
      int num14 = num9 + 1;
      int num15 = -1;
      int num16 = (num14 != num15 ? num13 / num14 : -num13) * (21 - num4) / 11;
      int num17 = num12 - num16;
      int num18 = num11 * num17;
      int num19 = num10 - num18;
      int num20 = year + year / 4 + num19 + 2 - num5 + num5 / 4;
      int num21 = 7;
      int num22 = -1;
      int num23 = num21 != num22 ? num20 % num21 : 0;
      int num24 = num19 - num23;
      int month = 3 + (num24 + 40) / 44;
      return SerialDate.createInstance(num24 + 28 - 31 * (month / 4), month, year);
    }
  }
}
