// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.util.HexNumberFormat
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

namespace org.jfree.chart.util
{
  [Serializable]
  public class HexNumberFormat : NumberFormat
  {
    public const int BYTE = 2;
    public const int WORD = 4;
    public const int DWORD = 8;
    public const int QWORD = 16;
    private int m_numDigits;

    [HideFromJava]
    static HexNumberFormat()
    {
      NumberFormat.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 232, (byte) 49, (byte) 231, (byte) 80, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HexNumberFormat(int digits)
    {
      base.\u002Ector();
      HexNumberFormat hexNumberFormat = this;
      this.m_numDigits = 8;
      this.m_numDigits = digits;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HexNumberFormat()
      : this(8)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HexNumberFormat([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 140, (byte) 110, (byte) 137, (byte) 107, (byte) 102, (byte) 40, (byte) 166, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(long number, StringBuffer toAppendTo, FieldPosition pos)
    {
      string str = String.instancehelper_toUpperCase(Long.toHexString(number));
      int num1 = this.m_numDigits - String.instancehelper_length(str);
      int num2 = 0 >= num1 ? 0 : num1;
      StringBuffer stringBuffer = new StringBuffer("0x");
      for (int index = 0; index < num2; ++index)
        stringBuffer.append(0);
      stringBuffer.append(str);
      return stringBuffer;
    }

    public int getNumberOfDigits()
    {
      return this.m_numDigits;
    }

    public virtual void setNumberOfDigits(int digits)
    {
      this.m_numDigits = digits;
    }

    [LineNumberTable((ushort) 117)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(double number, StringBuffer toAppendTo, FieldPosition pos)
    {
      return this.format(ByteCodeHelper.d2l(number), toAppendTo, pos);
    }

    public virtual Number parse(string source, ParsePosition parsePosition)
    {
      return (Number) null;
    }
  }
}
