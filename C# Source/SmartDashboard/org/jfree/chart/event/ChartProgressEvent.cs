// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.event.ChartProgressEvent
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
  public class ChartProgressEvent : EventObject
  {
    public const int DRAWING_STARTED = 1;
    public const int DRAWING_FINISHED = 2;
    private int type;
    private int percent;
    private JFreeChart chart;

    [LineNumberTable(new byte[] {(byte) 26, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartProgressEvent(object source, JFreeChart chart, int type, int percent)
    {
      base.\u002Ector(source);
      ChartProgressEvent chartProgressEvent = this;
      this.chart = chart;
      this.type = type;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartProgressEvent([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    public virtual JFreeChart getChart()
    {
      return this.chart;
    }

    public virtual void setChart(JFreeChart chart)
    {
      this.chart = chart;
    }

    public virtual int getType()
    {
      return this.type;
    }

    public virtual void setType(int type)
    {
      this.type = type;
    }

    public virtual int getPercent()
    {
      return this.percent;
    }

    public virtual void setPercent(int percent)
    {
      this.percent = percent;
    }
  }
}
