// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.DateTick
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class DateTick : ValueTick
  {
    private Date date;

    [LineNumberTable(new byte[] {(byte) 44, (byte) 120, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTick(TickType tickType, Date date, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      : base(tickType, (double) date.getTime(), label, textAnchor, rotationAnchor, angle)
    {
      DateTick dateTick = this;
      this.date = date;
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTick(Date date, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      : this(TickType.__\u003C\u003EMAJOR, date, label, textAnchor, rotationAnchor, angle)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DateTick([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual Date getDate()
    {
      return this.date;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DateTick) || !ObjectUtilities.equal((object) this.date, (object) ((DateTick) obj).date))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 135)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return this.date.hashCode();
    }
  }
}
