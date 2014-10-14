// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.LWSubsystem$1$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.LWSubsystem$1", "valueChanged", "(Ledu.wpi.first.wpilibj.tables.ITable;Ljava.lang.String;Ljava.lang.Object;Z)V")]
  [SourceFile("LWSubsystem.java")]
  [Modifiers]
  internal sealed class LWSubsystem\u00241\u00241 : Object, Runnable
  {
    [Modifiers]
    internal LWSubsystem\u00241 this\u00241;

    [LineNumberTable((ushort) 125)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal LWSubsystem\u00241\u00241([In] LWSubsystem\u00241 obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 127, (byte) 9})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      LWSubsystem.access\u0024000(this.this\u00241.this\u00240, this.this\u00241.val\u0024key, this.this\u00241.val\u0024table);
    }
  }
}
