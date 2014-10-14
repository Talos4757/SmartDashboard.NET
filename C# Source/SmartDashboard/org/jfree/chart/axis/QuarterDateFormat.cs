// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.QuarterDateFormat
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class QuarterDateFormat : DateFormat, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -6738465248529797176L;
    internal static string[] __\u003C\u003EREGULAR_QUARTERS;
    internal static string[] __\u003C\u003EROMAN_QUARTERS;
    internal static string[] __\u003C\u003EGREEK_QUARTERS;
    private string[] quarters;
    private bool quarterFirst;

    [Modifiers]
    public static string[] REGULAR_QUARTERS
    {
      [HideFromJava] get
      {
        return QuarterDateFormat.__\u003C\u003EREGULAR_QUARTERS;
      }
    }

    [Modifiers]
    public static string[] ROMAN_QUARTERS
    {
      [HideFromJava] get
      {
        return QuarterDateFormat.__\u003C\u003EROMAN_QUARTERS;
      }
    }

    [Modifiers]
    public static string[] GREEK_QUARTERS
    {
      [HideFromJava] get
      {
        return QuarterDateFormat.__\u003C\u003EGREEK_QUARTERS;
      }
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 223, (byte) 12, (byte) 255, (byte) 12, (byte) 72})]
    static QuarterDateFormat()
    {
      string[] strArray1 = new string[4];
      int index1 = 0;
      string str1 = "1";
      strArray1[index1] = str1;
      int index2 = 1;
      string str2 = "2";
      strArray1[index2] = str2;
      int index3 = 2;
      string str3 = "3";
      strArray1[index3] = str3;
      int index4 = 3;
      string str4 = "4";
      strArray1[index4] = str4;
      QuarterDateFormat.__\u003C\u003EREGULAR_QUARTERS = strArray1;
      string[] strArray2 = new string[4];
      int index5 = 0;
      string str5 = "I";
      strArray2[index5] = str5;
      int index6 = 1;
      string str6 = "II";
      strArray2[index6] = str6;
      int index7 = 2;
      string str7 = "III";
      strArray2[index7] = str7;
      int index8 = 3;
      string str8 = "IV";
      strArray2[index8] = str8;
      QuarterDateFormat.__\u003C\u003EROMAN_QUARTERS = strArray2;
      string[] strArray3 = new string[4];
      int index9 = 0;
      string str9 = "Α";
      strArray3[index9] = str9;
      int index10 = 1;
      string str10 = "Β";
      strArray3[index10] = str10;
      int index11 = 2;
      string str11 = "Γ";
      strArray3[index11] = str11;
      int index12 = 3;
      string str12 = "Δ";
      strArray3[index12] = str12;
      QuarterDateFormat.__\u003C\u003EGREEK_QUARTERS = strArray3;
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuarterDateFormat(TimeZone zone)
      : this(zone, QuarterDateFormat.__\u003C\u003EREGULAR_QUARTERS)
    {
    }

    [LineNumberTable(new byte[] {(byte) 64, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuarterDateFormat(TimeZone zone, string[] quarterSymbols)
      : this(zone, quarterSymbols, false)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 66, (byte) 232, (byte) 22, (byte) 235, (byte) 107, (byte) 99, (byte) 144, (byte) 108, (byte) 103, (byte) 231, (byte) 69, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuarterDateFormat(TimeZone zone, string[] quarterSymbols, bool quarterFirst)
    {
      int num = quarterFirst ? 1 : 0;
      base.\u002Ector();
      QuarterDateFormat quarterDateFormat = this;
      this.quarters = QuarterDateFormat.__\u003C\u003EREGULAR_QUARTERS;
      if (zone == null)
      {
        string str = "Null 'zone' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.calendar = (__Null) new GregorianCalendar(zone);
        this.quarters = quarterSymbols;
        this.quarterFirst = num != 0;
        this.numberFormat = (__Null) NumberFormat.getNumberInstance();
      }
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuarterDateFormat()
      : this(TimeZone.getDefault())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected QuarterDateFormat([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] QuarterDateFormat obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] QuarterDateFormat obj0)
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

    [LineNumberTable(new byte[] {(byte) 104, (byte) 108, (byte) 109, (byte) 109, (byte) 100, (byte) 104, (byte) 111, (byte) 108, (byte) 170, (byte) 104, (byte) 108, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(Date date, StringBuffer toAppendTo, FieldPosition fieldPosition)
    {
      ((Calendar) this.calendar).setTime(date);
      int num = ((Calendar) this.calendar).get(1);
      int index = ((Calendar) this.calendar).get(2) / 3;
      if (this.quarterFirst)
      {
        toAppendTo.append(this.quarters[index]);
        toAppendTo.append(" ");
        toAppendTo.append(num);
      }
      else
      {
        toAppendTo.append(num);
        toAppendTo.append(" ");
        toAppendTo.append(this.quarters[index]);
      }
      return toAppendTo;
    }

    public virtual Date parse(string source, ParsePosition pos)
    {
      return (Date) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is QuarterDateFormat))
        return false;
      QuarterDateFormat quarterDateFormat = (QuarterDateFormat) obj;
      if (!Arrays.equals((object[]) this.quarters, (object[]) quarterDateFormat.quarters) || this.quarterFirst != quarterDateFormat.quarterFirst)
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
