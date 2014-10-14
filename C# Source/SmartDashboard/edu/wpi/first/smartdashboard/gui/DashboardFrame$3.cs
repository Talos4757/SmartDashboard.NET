// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardFrame$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ComponentListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardFrame", "<init>", "(Z)V")]
  [SourceFile("DashboardFrame.java")]
  [Modifiers]
  internal sealed class DashboardFrame\u00243 : Object, ComponentListener, EventListener
  {
    [Modifiers]
    internal DashboardFrame this\u00240;

    [LineNumberTable((ushort) 146)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardFrame\u00243([In] DashboardFrame obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 127, (byte) 7, (byte) 127, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void componentResized([In] ComponentEvent obj0)
    {
      DashboardFrame.access\u0024200(this.this\u00240).__\u003C\u003Ewidth.setValue((object) Integer.valueOf(((Component) this.this\u00240).getWidth()));
      DashboardFrame.access\u0024200(this.this\u00240).__\u003C\u003Eheight.setValue((object) Integer.valueOf(((Component) this.this\u00240).getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 127, (byte) 7, (byte) 127, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void componentMoved([In] ComponentEvent obj0)
    {
      DashboardFrame.access\u0024200(this.this\u00240).__\u003C\u003Ex.setValue((object) Integer.valueOf(((Component) this.this\u00240).getX()));
      DashboardFrame.access\u0024200(this.this\u00240).__\u003C\u003Ey.setValue((object) Integer.valueOf(((Component) this.this\u00240).getY()));
    }

    public virtual void componentShown([In] ComponentEvent obj0)
    {
    }

    public virtual void componentHidden([In] ComponentEvent obj0)
    {
    }
  }
}
