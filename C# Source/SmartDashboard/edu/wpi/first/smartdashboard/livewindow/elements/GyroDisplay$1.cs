// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.GyroDisplay$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
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
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.GyroDisplay", "init", "()V")]
  [SourceFile("GyroDisplay.java")]
  [Modifiers]
  internal sealed class GyroDisplay\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal GyroDisplay val\u0024self;
    [Modifiers]
    internal GridBagConstraints val\u0024c;
    [Modifiers]
    internal GyroDisplay this\u00240;

    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GyroDisplay\u00241([In] GyroDisplay obj0, [In] GyroDisplay obj1, [In] GridBagConstraints obj2)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 108, (byte) 108, (byte) 117, (byte) 118, (byte) 108, (byte) 108, (byte) 117, (byte) 124, (byte) 107, (byte) 112, (byte) 117, (byte) 118, (byte) 108, (byte) 108, (byte) 117, (byte) 124, (byte) 107, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      string str = Object.instancehelper_toString(((JComboBox) ((EventObject) obj0).getSource()).getSelectedItem());
      if (String.instancehelper_equals(str, (object) GyroDisplay.access\u0024000(this.this\u00240)[1]))
      {
        ((Container) this.val\u0024self).remove((Component) GyroDisplay.access\u0024100(this.this\u00240));
        this.val\u0024c.gridx = (__Null) 0;
        this.val\u0024c.gridy = (__Null) 2;
        this.val\u0024c.weightx = (__Null) 2.0;
        ((Container) this.val\u0024self).add((Component) GyroDisplay.access\u0024200(this.this\u00240), (object) this.val\u0024c);
        ((JComponent) this.this\u00240).revalidate();
        ((Component) this.this\u00240).repaint();
      }
      else
      {
        if (!String.instancehelper_equals(str, (object) GyroDisplay.access\u0024000(this.this\u00240)[0]))
          return;
        ((Container) this.val\u0024self).remove((Component) GyroDisplay.access\u0024200(this.this\u00240));
        this.val\u0024c.gridx = (__Null) 0;
        this.val\u0024c.gridy = (__Null) 2;
        this.val\u0024c.weightx = (__Null) 2.0;
        ((Container) this.val\u0024self).add((Component) GyroDisplay.access\u0024100(this.this\u00240), (object) this.val\u0024c);
        ((JComponent) this.this\u00240).revalidate();
        ((Component) this.this\u00240).repaint();
      }
    }
  }
}
