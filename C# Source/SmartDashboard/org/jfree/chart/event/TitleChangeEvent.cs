// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.event.TitleChangeEvent
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.chart.@event;
using org.jfree.chart.title;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.@event
{
  [Serializable]
  public class TitleChangeEvent : ChartChangeEvent
  {
    private Title title;

    [LineNumberTable(new byte[] {(byte) 14, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TitleChangeEvent(Title title)
      : base((object) title)
    {
      TitleChangeEvent titleChangeEvent = this;
      this.title = title;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TitleChangeEvent([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual Title getTitle()
    {
      return this.title;
    }
  }
}
