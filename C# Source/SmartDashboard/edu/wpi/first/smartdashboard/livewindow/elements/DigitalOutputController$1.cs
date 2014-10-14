// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.DigitalOutputController$1
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

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.DigitalOutputController", "init", "()V")]
  [SourceFile("DigitalOutputController.java")]
  [Modifiers]
  internal sealed class DigitalOutputController\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal DigitalOutputController this\u00240;

    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DigitalOutputController\u00241([In] DigitalOutputController obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 127, (byte) 15, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      ((AbstractButton) DigitalOutputController.access\u0024000(this.this\u00240)).setText(!((AbstractButton) DigitalOutputController.access\u0024000(this.this\u00240)).isSelected() ? "Off" : "On");
      DigitalOutputController.access\u0024100(this.this\u00240).putBoolean("Value", String.instancehelper_equals(((AbstractButton) DigitalOutputController.access\u0024000(this.this\u00240)).getText(), (object) "On"));
    }
  }
}
