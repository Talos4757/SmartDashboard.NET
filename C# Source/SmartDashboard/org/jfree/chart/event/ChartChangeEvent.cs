// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.event.ChartChangeEvent
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.@event
{
  [Serializable]
  public class ChartChangeEvent : EventObject
  {
    private ChartChangeEventType type;
    private JFreeChart chart;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartChangeEvent(object source)
      : this(source, (JFreeChart) null, ChartChangeEventType.__\u003C\u003EGENERAL)
    {
    }

    [LineNumberTable(new byte[] {(byte) 43, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartChangeEvent(object source, JFreeChart chart, ChartChangeEventType type)
    {
      base.\u002Ector(source);
      ChartChangeEvent chartChangeEvent = this;
      this.chart = chart;
      this.type = type;
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartChangeEvent(object source, JFreeChart chart)
      : this(source, chart, ChartChangeEventType.__\u003C\u003EGENERAL)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartChangeEvent([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    public virtual void setChart(JFreeChart chart)
    {
      this.chart = chart;
    }

    public virtual JFreeChart getChart()
    {
      return this.chart;
    }

    public virtual ChartChangeEventType getType()
    {
      return this.type;
    }

    public virtual void setType(ChartChangeEventType type)
    {
      this.type = type;
    }
  }
}
