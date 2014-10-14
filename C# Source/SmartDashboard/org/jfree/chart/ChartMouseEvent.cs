// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartMouseEvent
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.io;
using java.util;
using org.jfree.chart.entity;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class ChartMouseEvent : EventObject, Serializable.__Interface
  {
    private const long serialVersionUID = -682393837314562149L;
    private JFreeChart chart;
    private MouseEvent trigger;
    private ChartEntity entity;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 105, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartMouseEvent(JFreeChart chart, MouseEvent trigger, ChartEntity entity)
    {
      base.\u002Ector((object) chart);
      ChartMouseEvent chartMouseEvent = this;
      this.chart = chart;
      this.trigger = trigger;
      this.entity = entity;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartMouseEvent([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ChartMouseEvent obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual JFreeChart getChart()
    {
      return this.chart;
    }

    public virtual MouseEvent getTrigger()
    {
      return this.trigger;
    }

    public virtual ChartEntity getEntity()
    {
      return this.entity;
    }
  }
}
