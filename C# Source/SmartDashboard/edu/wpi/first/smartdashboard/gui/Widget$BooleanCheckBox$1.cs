// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.Widget$BooleanCheckBox$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.Widget$BooleanCheckBox", "<init>", "()V")]
  [SourceFile("Widget.java")]
  [Modifiers]
  internal sealed class Widget\u0024BooleanCheckBox\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal Widget.BooleanCheckBox this\u00240;

    [LineNumberTable((ushort) 264)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Widget\u0024BooleanCheckBox\u00241([In] Widget.BooleanCheckBox obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 108, (byte) 110, (byte) 110, (byte) 143, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      int num = ((AbstractButton) this.this\u00240).isSelected() ? 1 : 0;
      if ((Widget.BooleanCheckBox.access\u0024200(this.this\u00240) ? 1 : 0) == num)
        return;
      if (this.this\u00240.setValue(num != 0))
        Widget.BooleanCheckBox.access\u0024202(this.this\u00240, num != 0);
      else
        this.this\u00240.resetValue();
    }
  }
}
