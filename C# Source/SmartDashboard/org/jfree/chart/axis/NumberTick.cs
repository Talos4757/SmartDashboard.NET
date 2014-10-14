// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.NumberTick
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class NumberTick : ValueTick
  {
    private Number number;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 117, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberTick(Number number, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      : base(number.doubleValue(), label, textAnchor, rotationAnchor, angle)
    {
      NumberTick numberTick = this;
      this.number = number;
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 115, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NumberTick(TickType tickType, double value, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      : base(tickType, value, label, textAnchor, rotationAnchor, angle)
    {
      NumberTick numberTick = this;
      this.number = (Number) new Double(value);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected NumberTick([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual Number getNumber()
    {
      return this.number;
    }
  }
}
