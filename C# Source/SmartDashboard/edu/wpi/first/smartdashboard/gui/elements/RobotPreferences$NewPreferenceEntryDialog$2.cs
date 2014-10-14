// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$NewPreferenceEntryDialog$2
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

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$NewPreferenceEntryDialog", "<init>", "(Ledu.wpi.first.smartdashboard.gui.elements.RobotPreferences;)V")]
  [SourceFile("RobotPreferences.java")]
  [Modifiers]
  internal sealed class RobotPreferences\u0024NewPreferenceEntryDialog\u00242 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal RobotPreferences val\u0024this\u00240;
    [Modifiers]
    internal RobotPreferences.NewPreferenceEntryDialog this\u00241;

    [LineNumberTable((ushort) 269)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RobotPreferences\u0024NewPreferenceEntryDialog\u00242([In] RobotPreferences.NewPreferenceEntryDialog obj0, [In] RobotPreferences obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      ((Window) this.this\u00241).dispose();
    }
  }
}
