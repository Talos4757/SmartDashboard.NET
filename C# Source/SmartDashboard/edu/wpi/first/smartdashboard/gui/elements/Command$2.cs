// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Command$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

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
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Command", "init", "()V")]
  [SourceFile("Command.java")]
  [Modifiers]
  internal sealed class Command\u00242 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal Command this\u00240;

    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Command\u00242([In] Command obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      Command.access\u0024100(this.this\u00240).putBoolean("running", false);
    }
  }
}
