// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.RobotPreferences$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.robot;
using IKVM.Attributes;
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
  internal sealed class RobotPreferences\u00243 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal RobotPreferences this\u00240;

    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RobotPreferences\u00243([In] RobotPreferences obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 12, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      Robot.getPreferences().putBoolean("~S A V E~", true);
    }
  }
}
