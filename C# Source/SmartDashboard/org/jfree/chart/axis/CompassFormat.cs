// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CompassFormat
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class CompassFormat : NumberFormat
  {
    private const string N = "N";
    private const string E = "E";
    private const string S = "S";
    private const string W = "W";
    internal static string[] __\u003C\u003EDIRECTIONS;

    [Modifiers]
    public static string[] DIRECTIONS
    {
      [HideFromJava] get
      {
        return CompassFormat.__\u003C\u003EDIRECTIONS;
      }
    }

    [LineNumberTable((ushort) 65)]
    static CompassFormat()
    {
      NumberFormat.__\u003Cclinit\u003E();
      string[] strArray = new string[17];
      int index1 = 0;
      string str1 = "N";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "NNE";
      strArray[index2] = str2;
      int index3 = 2;
      string str3 = "NE";
      strArray[index3] = str3;
      int index4 = 3;
      string str4 = "ENE";
      strArray[index4] = str4;
      int index5 = 4;
      string str5 = "E";
      strArray[index5] = str5;
      int index6 = 5;
      string str6 = "ESE";
      strArray[index6] = str6;
      int index7 = 6;
      string str7 = "SE";
      strArray[index7] = str7;
      int index8 = 7;
      string str8 = "SSE";
      strArray[index8] = str8;
      int index9 = 8;
      string str9 = "S";
      strArray[index9] = str9;
      int index10 = 9;
      string str10 = "SSW";
      strArray[index10] = str10;
      int index11 = 10;
      string str11 = "SW";
      strArray[index11] = str11;
      int index12 = 11;
      string str12 = "WSW";
      strArray[index12] = str12;
      int index13 = 12;
      string str13 = "W";
      strArray[index13] = str13;
      int index14 = 13;
      string str14 = "WNW";
      strArray[index14] = str14;
      int index15 = 14;
      string str15 = "NW";
      strArray[index15] = str15;
      int index16 = 15;
      string str16 = "NNW";
      strArray[index16] = str16;
      int index17 = 16;
      string str17 = "N";
      strArray[index17] = str17;
      CompassFormat.__\u003C\u003EDIRECTIONS = strArray;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompassFormat()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CompassFormat([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 111, (byte) 105, (byte) 143, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getDirectionCode(double direction)
    {
      direction %= 360.0;
      if (direction < 0.0)
        direction += 360.0;
      int index = (ByteCodeHelper.d2i(Math.floor(direction / 11.25)) + 1) / 2;
      return CompassFormat.__\u003C\u003EDIRECTIONS[index];
    }

    [LineNumberTable((ushort) 106)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(double number, StringBuffer toAppendTo, FieldPosition pos)
    {
      return toAppendTo.append(this.getDirectionCode(number));
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(long number, StringBuffer toAppendTo, FieldPosition pos)
    {
      return toAppendTo.append(this.getDirectionCode((double) number));
    }

    public virtual Number parse(string source, ParsePosition parsePosition)
    {
      return (Number) null;
    }
  }
}
