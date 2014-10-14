// Decompiled with JetBrains decompiler
// Type: org.jfree.data.time.DateRange
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.data;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.time
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class DateRange : Range, Serializable.__Interface
  {
    private const long serialVersionUID = -4705682568375418157L;
    private long lowerDate;
    private long upperDate;

    [LineNumberTable(new byte[] {(byte) 59, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateRange(Range other)
      : this(other.getLowerBound(), other.getUpperBound())
    {
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 118, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateRange(Date lower, Date upper)
      : base((double) lower.getTime(), (double) upper.getTime())
    {
      DateRange dateRange = this;
      this.lowerDate = lower.getTime();
      this.upperDate = upper.getTime();
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 108, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateRange(double lower, double upper)
      : base(lower, upper)
    {
      DateRange dateRange = this;
      this.lowerDate = ByteCodeHelper.d2l(lower);
      this.upperDate = ByteCodeHelper.d2l(upper);
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateRange()
      : this(new Date(0L), new Date(1L))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateRange([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DateRange obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getLowerDate()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.lowerDate);
    }

    [LineNumberTable((ushort) 144)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getUpperDate()
    {
      Date.__\u003Cclinit\u003E();
      return new Date(this.upperDate);
    }

    public virtual long getLowerMillis()
    {
      return this.lowerDate;
    }

    public virtual long getUpperMillis()
    {
      return this.upperDate;
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      DateFormat dateTimeInstance = DateFormat.getDateTimeInstance();
      return new StringBuffer().append("[").append(dateTimeInstance.format(this.getLowerDate())).append(" --> ").append(dateTimeInstance.format(this.getUpperDate())).append("]").toString();
    }
  }
}
