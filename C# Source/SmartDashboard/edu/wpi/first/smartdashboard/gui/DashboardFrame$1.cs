﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardFrame$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardFrame", "<init>", "(Z)V")]
  [SourceFile("DashboardFrame.java")]
  [Modifiers]
  internal sealed class DashboardFrame\u00241 : MouseAdapter
  {
    [Modifiers]
    internal DashboardFrame this\u00240;

    [LineNumberTable((ushort) 99)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardFrame\u00241([In] DashboardFrame obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 119, (byte) 123, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseMoved([In] MouseEvent obj0)
    {
      if (!DashboardFrame.access\u0024000(this.this\u00240) || obj0.getY() >= 10)
        return;
      ((Container) this.this\u00240).add((Component) DashboardFrame.access\u0024100(this.this\u00240), (object) "North");
      ((Container) this.this\u00240).validate();
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 109, (byte) 118, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseEntered([In] MouseEvent obj0)
    {
      if (!DashboardFrame.access\u0024000(this.this\u00240))
        return;
      this.this\u00240.remove((Component) DashboardFrame.access\u0024100(this.this\u00240));
      ((Container) this.this\u00240).validate();
    }
  }
}
