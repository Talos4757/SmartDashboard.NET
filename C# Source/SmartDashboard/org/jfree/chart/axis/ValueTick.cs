// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.ValueTick
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public abstract class ValueTick : Tick
  {
    private double value;
    private TickType tickType;

    [LineNumberTable(new byte[] {(byte) 47, (byte) 112, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueTick(TickType tickType, double value, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      : base(label, textAnchor, rotationAnchor, angle)
    {
      ValueTick valueTick = this;
      this.value = value;
      this.tickType = tickType;
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 118, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueTick(double value, string label, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
      : this(TickType.__\u003C\u003EMAJOR, value, label, textAnchor, rotationAnchor, angle)
    {
      ValueTick valueTick = this;
      this.value = value;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ValueTick([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual double getValue()
    {
      return this.value;
    }

    public virtual TickType getTickType()
    {
      return this.tickType;
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ValueTick))
        return false;
      ValueTick valueTick = (ValueTick) obj;
      if (this.value != valueTick.value || !this.tickType.equals((object) valueTick.tickType))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
