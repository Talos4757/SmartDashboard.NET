// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardFrame$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardFrame", "<init>", "(Z)V")]
  [SourceFile("DashboardFrame.java")]
  [Modifiers]
  internal sealed class DashboardFrame\u00242 : WindowAdapter
  {
    [Modifiers]
    internal DashboardFrame this\u00240;

    [LineNumberTable((ushort) 137)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardFrame\u00242([In] DashboardFrame obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void windowClosing([In] WindowEvent obj0)
    {
      this.this\u00240.exit();
    }
  }
}
