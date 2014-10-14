// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$NewPreferenceEntryDialog$1
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

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$NewPreferenceEntryDialog", "<init>", "(Ledu.wpi.first.smartdashboard.gui.elements.RobotPreferences;)V")]
  [SourceFile("RobotPreferences.java")]
  [Modifiers]
  internal sealed class RobotPreferences\u0024NewPreferenceEntryDialog\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal RobotPreferences val\u0024this\u00240;
    [Modifiers]
    internal RobotPreferences.NewPreferenceEntryDialog this\u00241;

    [LineNumberTable((ushort) 253)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RobotPreferences\u0024NewPreferenceEntryDialog\u00241([In] RobotPreferences.NewPreferenceEntryDialog obj0, [In] RobotPreferences obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 142, (byte) 127, (byte) 3, (byte) 127, (byte) 40, (byte) 108, (byte) 173, (byte) 159, (byte) 39})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      if (!RobotPreferences.access\u0024400(this.this\u00241.this\u00240).containsKey((object) this.this\u00241.getKey()))
      {
        if (!RobotPreferences.access\u0024100(this.this\u00241.this\u00240).validateKey(this.this\u00241.getKey()) || !RobotPreferences.access\u0024100(this.this\u00241.this\u00240).validateValue(this.this\u00241.getValue()))
          return;
        this.this\u00241.canceled = false;
        ((Window) this.this\u00241).dispose();
      }
      else
        JOptionPane.showMessageDialog((Component) this.this\u00241.this\u00240, (object) new StringBuilder().append("An entry with the key ").append(this.this\u00241.getKey()).append(" already exists").toString(), "Duplicate Key", 0);
    }
  }
}
