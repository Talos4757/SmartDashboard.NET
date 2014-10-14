// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.StringBindable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  public interface StringBindable
  {
    static readonly StringBindable NULL = (StringBindable) new StringBindable\u00241();

    [LineNumberTable((ushort) 4)]
    static StringBindable()
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    void __\u003Cclinit\u003E()
    {
    }

    void setBindableValue(string str);

    [HideFromJava]
    static class __Fields
    {
      public static readonly StringBindable NULL = StringBindable.NULL;
    }
  }
}
