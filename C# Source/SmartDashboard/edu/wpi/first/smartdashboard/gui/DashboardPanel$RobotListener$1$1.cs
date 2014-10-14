// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardPanel$RobotListener$1$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardPanel$RobotListener$1", "valueChanged", "(Ledu.wpi.first.wpilibj.tables.ITable;Ljava.lang.String;Ljava.lang.Object;Z)V")]
  [SourceFile("DashboardPanel.java")]
  [Modifiers]
  internal sealed class DashboardPanel\u0024RobotListener\u00241\u00241 : Object, Runnable
  {
    [Modifiers]
    internal DashboardPanel\u0024RobotListener\u00241 this\u00242;

    [LineNumberTable((ushort) 520)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardPanel\u0024RobotListener\u00241\u00241([In] DashboardPanel\u0024RobotListener\u00241 obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 152, (byte) 127, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.this\u00242.this\u00241.this\u00240.setField(this.this\u00242.val\u0024key, (Class) null, this.this\u00242.val\u0024value, (Point) null);
    }
  }
}
