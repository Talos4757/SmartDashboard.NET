// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.ValueMarker
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using org.jfree.chart.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Serializable]
  public class ValueMarker : Marker
  {
    private double value;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueMarker(double value)
    {
      ValueMarker valueMarker = this;
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 113, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueMarker(double value, Paint paint, Stroke stroke, Paint outlinePaint, Stroke outlineStroke, float alpha)
      : base(paint, stroke, outlinePaint, outlineStroke, alpha)
    {
      ValueMarker valueMarker = this;
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueMarker(double value, Paint paint, Stroke stroke)
      : this(value, paint, stroke, paint, stroke, 1f)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ValueMarker([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual double getValue()
    {
      return this.value;
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(double value)
    {
      this.value = value;
      this.notifyListeners(new MarkerChangeEvent((Marker) this));
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 100, (byte) 130, (byte) 105, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      return obj == this || base.equals(obj) && obj is ValueMarker && this.value == ((ValueMarker) obj).value;
    }
  }
}
