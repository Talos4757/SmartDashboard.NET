// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.ChartFrame
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Serializable]
  public class ChartFrame : JFrame
  {
    private ChartPanel chartPanel;

    [HideFromJava]
    static ChartFrame()
    {
      JFrame.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 66, (byte) 105, (byte) 103, (byte) 108, (byte) 99, (byte) 184, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartFrame(string title, JFreeChart chart, bool scrollPane)
    {
      int num = scrollPane ? 1 : 0;
      base.\u002Ector(title);
      ChartFrame chartFrame = this;
      this.setDefaultCloseOperation(2);
      this.chartPanel = new ChartPanel(chart);
      if (num != 0)
      {
        JScrollPane.__\u003Cclinit\u003E();
        this.setContentPane((Container) new JScrollPane((Component) this.chartPanel));
      }
      else
        this.setContentPane((Container) this.chartPanel);
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChartFrame(string title, JFreeChart chart)
      : this(title, chart, false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ChartFrame([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual ChartPanel getChartPanel()
    {
      return this.chartPanel;
    }
  }
}
