// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.DefaultDisplayElementRegistrar
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.types;
using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  public class DefaultDisplayElementRegistrar : Object
  {
    [LineNumberTable((ushort) 9)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultDisplayElementRegistrar()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 138, (byte) 106, (byte) 106, (byte) 106, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void init()
    {
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<CommandButton>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<BooleanBox>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<Compass>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<Button>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<FormattedField>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<LinePlot>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<ProgressBar>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<SimpleDial>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<TextBox>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<CheckBox>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<PIDEditor>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<Chooser>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<Subsystem>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<Command>.Value);
      DisplayElementRegistry.registerWidget((Class) ClassLiteral<Scheduler>.Value);
      DisplayElementRegistry.registerStaticWidget((Class) ClassLiteral<Image>.Value);
      DisplayElementRegistry.registerStaticWidget((Class) ClassLiteral<ConnectionIndicator>.Value);
      DisplayElementRegistry.registerStaticWidget((Class) ClassLiteral<Label>.Value);
      DisplayElementRegistry.registerStaticWidget((Class) ClassLiteral<RobotPreferences>.Value);
    }
  }
}
