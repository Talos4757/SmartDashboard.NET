// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Subsystem$SubsystemCommandField$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Subsystem$SubsystemCommandField", "<init>", "(Ledu.wpi.first.smartdashboard.gui.elements.Subsystem;)V")]
  [SourceFile("Subsystem.java")]
  [Modifiers]
  internal sealed class Subsystem\u0024SubsystemCommandField\u00242 : Object, BooleanBindable
  {
    [Modifiers]
    internal Subsystem val\u0024this\u00240;
    [Modifiers]
    internal Subsystem.SubsystemCommandField this\u00241;

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Subsystem\u0024SubsystemCommandField\u00242([In] Subsystem.SubsystemCommandField obj0, [In] Subsystem obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 128, (byte) 130, (byte) 109, (byte) 109, (byte) 152, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBindableValue([In] bool obj0)
    {
      Subsystem.SubsystemCommandField.access\u0024102(this.this\u00241, obj0);
      if (Subsystem.SubsystemCommandField.access\u0024100(this.this\u00241))
        this.this\u00241.setBindableValue(Subsystem.SubsystemCommandField.access\u0024000(this.this\u00241));
      else
        this.this\u00241.setBindableValue("---");
    }
  }
}
