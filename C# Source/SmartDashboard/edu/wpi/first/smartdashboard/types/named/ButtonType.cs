// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.types.named.ButtonType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements;
using edu.wpi.first.smartdashboard.types;
using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.types.named
{
  public class ButtonType : NamedDataType
  {
    public const string LABEL = "Button";

    [HideFromJava]
    static ButtonType()
    {
      NamedDataType.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ButtonType()
      : base("Button", (Class) ClassLiteral<Button>.Value, new DataType[0])
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 108, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static NamedDataType get()
    {
      if (NamedDataType.get("Button") != null)
        return NamedDataType.get("Button");
      else
        return (NamedDataType) new ButtonType();
    }
  }
}
