﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Scheduler$1$1$1
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
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Scheduler$1$1", "run", "()V")]
  [SourceFile("Scheduler.java")]
  [Modifiers]
  internal sealed class Scheduler\u00241\u00241\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal int val\u0024index;
    [Modifiers]
    internal Scheduler\u00241\u00241 this\u00242;

    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Scheduler\u00241\u00241\u00241([In] Scheduler\u00241\u00241 obj0, [In] int obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 127, (byte) 21, (byte) 127, (byte) 27, (byte) 127, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      Scheduler.access\u0024000(this.this\u00242.this\u00241.this\u00240).retrieveValue("Cancel", (object) Scheduler.access\u0024500(this.this\u00242.this\u00241.this\u00240));
      Scheduler.access\u0024500(this.this\u00242.this\u00241.this\u00240).add(Scheduler.access\u0024200(this.this\u00242.this\u00241.this\u00240).get(this.val\u0024index));
      Scheduler.access\u0024000(this.this\u00242.this\u00241.this\u00240).putValue("Cancel", (object) Scheduler.access\u0024500(this.this\u00242.this\u00241.this\u00240));
    }
  }
}