// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.SpeedController$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.SpeedController", "init", "()V")]
  [SourceFile("SpeedController.java")]
  [Modifiers]
  internal sealed class SpeedController\u00242 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal SpeedController this\u00240;

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SpeedController\u00242([In] SpeedController obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      this.this\u00240.reset();
    }
  }
}
