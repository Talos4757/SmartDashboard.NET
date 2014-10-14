// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.LiveWindowWidgetRegistrar
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.types;
using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  public class LiveWindowWidgetRegistrar : Object
  {
    [LineNumberTable((ushort) 9)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LiveWindowWidgetRegistrar()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void init()
    {
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<LWSubsystem>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<SpeedController>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<RelayController>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<DigitalOutputController>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<SingleNumberDisplay>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<DigitalInputDisplay>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<GyroDisplay>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<EncoderDisplay>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<ServoController>.Value);
    }
  }
}
