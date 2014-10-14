// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  public interface NumberBindable
  {
    static readonly NumberBindable NULL = (NumberBindable) new NumberBindable\u00241();

    [LineNumberTable((ushort) 4)]
    static NumberBindable()
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    void __\u003Cclinit\u003E()
    {
    }

    void setBindableValue(double d);

    [HideFromJava]
    static class __Fields
    {
      public static readonly NumberBindable NULL = NumberBindable.NULL;
    }
  }
}
