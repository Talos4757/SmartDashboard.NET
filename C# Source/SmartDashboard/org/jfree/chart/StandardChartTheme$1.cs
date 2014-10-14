// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.StandardChartTheme$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [InnerClass]
  [SourceFile("StandardChartTheme.java")]
  [Serializable]
  internal sealed class StandardChartTheme\u00241 : StandardChartTheme
  {
    [LineNumberTable((ushort) 290)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal StandardChartTheme\u00241([In] string obj0)
      : base(obj0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardChartTheme\u00241([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public override void apply([In] JFreeChart obj0)
    {
    }
  }
}
