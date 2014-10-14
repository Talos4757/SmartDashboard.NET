// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  public interface BooleanBindable
  {
    static readonly BooleanBindable NULL = (BooleanBindable) new BooleanBindable\u00241();

    [LineNumberTable((ushort) 4)]
    static BooleanBindable()
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    void __\u003Cclinit\u003E()
    {
    }

    void setBindableValue(bool b);

    [HideFromJava]
    static class __Fields
    {
      public static readonly BooleanBindable NULL = BooleanBindable.NULL;
    }
  }
}
