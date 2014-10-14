// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardPanel$RobotListener$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

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
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardPanel$RobotListener", "valueChanged", "(Ledu.wpi.first.wpilibj.tables.ITable;Ljava.lang.String;Ljava.lang.Object;Z)V")]
  [SourceFile("DashboardPanel.java")]
  [Modifiers]
  internal sealed class DashboardPanel\u0024RobotListener\u00241 : Object, ITableListener
  {
    [Modifiers]
    internal ITable val\u0024table;
    [Modifiers]
    internal string val\u0024key;
    [Modifiers]
    internal object val\u0024value;
    [Modifiers]
    internal DashboardPanel.RobotListener this\u00241;

    [LineNumberTable((ushort) 517)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardPanel\u0024RobotListener\u00241([In] DashboardPanel.RobotListener obj0, [In] ITable obj1, [In] string obj2, [In] object obj3)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 108, (byte) 237, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged([In] ITable obj0, [In] string obj1, [In] object obj2, [In] bool obj3)
    {
      this.val\u0024table.removeTableListener((ITableListener) this);
      SwingUtilities.invokeLater((Runnable) new DashboardPanel\u0024RobotListener\u00241\u00241(this));
    }
  }
}
