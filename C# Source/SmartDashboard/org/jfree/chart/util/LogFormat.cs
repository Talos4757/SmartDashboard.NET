// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.util.LogFormat
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
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
  public class LogFormat : NumberFormat
  {
    private double @base;
    private double baseLog;
    private string baseLabel;
    private string powerLabel;
    private bool showBase;
    private NumberFormat formatter;

    [HideFromJava]
    static LogFormat()
    {
      NumberFormat.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogFormat()
      : this(10.0, "10", true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 117, (byte) 66, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogFormat(double @base, string baseLabel, bool showBase)
    {
      int num = showBase ? 1 : 0;
      // ISSUE: explicit constructor call
      this.\u002Ector(@base, baseLabel, "^", num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 114, (byte) 163, (byte) 232, (byte) 29, (byte) 240, (byte) 100, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 105, (byte) 114, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogFormat(double @base, string baseLabel, string powerLabel, bool showBase)
    {
      int num = showBase ? 1 : 0;
      base.\u002Ector();
      LogFormat logFormat = this;
      this.formatter = (NumberFormat) new DecimalFormat("0.0#");
      if (baseLabel == null)
      {
        string str = "Null 'baseLabel' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (powerLabel == null)
      {
        string str = "Null 'powerLabel' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.@base = @base;
        this.baseLog = Math.log(this.@base);
        this.baseLabel = baseLabel;
        this.showBase = num != 0;
        this.powerLabel = powerLabel;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LogFormat([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 162)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double calculateLog([In] double obj0)
    {
      return Math.log(obj0) / this.baseLog;
    }

    [LineNumberTable((ushort) 137)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NumberFormat getExponentFormat()
    {
      return (NumberFormat) this.formatter.clone();
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExponentFormat(NumberFormat format)
    {
      if (format == null)
      {
        string str = "Null 'format' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.formatter = format;
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 102, (byte) 104, (byte) 109, (byte) 141, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(double number, StringBuffer toAppendTo, FieldPosition pos)
    {
      StringBuffer stringBuffer = new StringBuffer();
      if (this.showBase)
      {
        stringBuffer.append(this.baseLabel);
        stringBuffer.append(this.powerLabel);
      }
      stringBuffer.append(this.formatter.format(this.calculateLog(number)));
      return stringBuffer;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 102, (byte) 104, (byte) 109, (byte) 140, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual StringBuffer format(long number, StringBuffer toAppendTo, FieldPosition pos)
    {
      StringBuffer stringBuffer = new StringBuffer();
      if (this.showBase)
      {
        stringBuffer.append(this.baseLabel);
        stringBuffer.append("^");
      }
      stringBuffer.append(this.formatter.format(this.calculateLog((double) number)));
      return stringBuffer;
    }

    public virtual Number parse(string source, ParsePosition parsePosition)
    {
      return (Number) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LogFormat))
        return false;
      LogFormat logFormat = (LogFormat) obj;
      if (this.@base != logFormat.@base || !String.instancehelper_equals(this.baseLabel, (object) logFormat.baseLabel) || (this.baseLog != logFormat.baseLog || this.showBase != logFormat.showBase) || !this.formatter.equals((object) logFormat.formatter))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 144, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      LogFormat logFormat = (LogFormat) base.clone();
      logFormat.formatter = (NumberFormat) this.formatter.clone();
      return (object) logFormat;
    }
  }
}
