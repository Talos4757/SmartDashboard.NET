﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$1
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
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.RobotPreferences", "init", "()V")]
  [SourceFile("RobotPreferences.java")]
  [Modifiers]
  internal sealed class RobotPreferences\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal RobotPreferences this\u00240;

    [LineNumberTable((ushort) 33)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RobotPreferences\u00241([In] RobotPreferences obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 113, (byte) 118, (byte) 104, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      RobotPreferences.NewPreferenceEntryDialog.__\u003Cclinit\u003E();
      RobotPreferences.NewPreferenceEntryDialog preferenceEntryDialog = new RobotPreferences.NewPreferenceEntryDialog(this.this\u00240);
      preferenceEntryDialog.show(((Component) RobotPreferences.access\u0024000(this.this\u00240)).getLocationOnScreen());
      if (preferenceEntryDialog.isCanceled())
        return;
      RobotPreferences.access\u0024100(this.this\u00240).put(preferenceEntryDialog.getKey(), preferenceEntryDialog.getValue());
    }
  }
}
