// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.NumberTickUnit
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class NumberTickUnit : TickUnit, Serializable.__Interface
  {
    private const long serialVersionUID = 3849459506627654442L;
    private NumberFormat formatter;

    [LineNumberTable(new byte[] {(byte) 51, (byte) 107, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberTickUnit(double size, NumberFormat formatter, int minorTickCount)
      : base(size, minorTickCount)
    {
      NumberTickUnit numberTickUnit = this;
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.formatter = formatter;
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 106, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberTickUnit(double size, NumberFormat formatter)
      : base(size)
    {
      NumberTickUnit numberTickUnit = this;
      if (formatter == null)
      {
        string str = "Null 'formatter' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.formatter = formatter;
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberTickUnit(double size)
      : this(size, NumberFormat.getNumberInstance())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected NumberTickUnit([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] NumberTickUnit obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 116)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string valueToString(double value)
    {
      return this.formatter.format(value);
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 103, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return 29 * base.hashCode() + (this.formatter == null ? 0 : this.formatter.hashCode());
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || obj is NumberTickUnit && base.equals(obj) && this.formatter.equals((object) ((NumberTickUnit) obj).formatter);
    }

    [LineNumberTable((ushort) 149)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("[size=").append(this.valueToString(this.getSize())).append("]").toString();
    }
  }
}
