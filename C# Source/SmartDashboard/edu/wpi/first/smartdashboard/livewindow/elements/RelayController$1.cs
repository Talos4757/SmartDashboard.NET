// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.RelayController$1
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
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.RelayController", "init", "()V")]
  [SourceFile("RelayController.java")]
  [Modifiers]
  internal sealed class RelayController\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal RelayController this\u00240;

    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal RelayController\u00241([In] RelayController obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      RelayController.access\u0024100(this.this\u00240).putString("Value", Object.instancehelper_toString(RelayController.access\u0024000(this.this\u00240).getSelectedItem()));
    }
  }
}
