// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$10
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.robot;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.MainPanel;)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  internal sealed class DashboardMenu\u002410 : Object, ITableListener
  {
    [Modifiers]
    internal DashboardFrame val\u0024frame;
    [Modifiers]
    internal MainPanel val\u0024mainPanel;
    [Modifiers]
    internal JMenuItem val\u0024resetLW;
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 153)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u002410([In] DashboardMenu obj0, [In] DashboardFrame obj1, [In] MainPanel obj2, [In] JMenuItem obj3)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 155, (byte) 238, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged([In] ITable obj0, [In] string obj1, [In] object obj2, [In] bool obj3)
    {
      SwingUtilities.invokeLater((Runnable) new DashboardMenu\u002410\u00241(this, Robot.getLiveWindow().getSubTable("~STATUS~").getBoolean("LW Enabled", false)));
    }
  }
}
