// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.MainPanel;)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  internal sealed class DashboardMenu\u00242 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal MainPanel val\u0024mainPanel;
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u00242([In] DashboardMenu obj0, [In] MainPanel obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      MainPanel mainPanel = this.val\u0024mainPanel;
      MainPanel.getPanel("SmartDashboard").clear();
    }
  }
}
