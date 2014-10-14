// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.CommandButton$1
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
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.CommandButton", "init", "()V")]
  [SourceFile("CommandButton.java")]
  [Modifiers]
  internal sealed class CommandButton\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal CommandButton this\u00240;

    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CommandButton\u00241([In] CommandButton obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      CommandButton.access\u0024000(this.this\u00240).putBoolean("running", true);
    }
  }
}
