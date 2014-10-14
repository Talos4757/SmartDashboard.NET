// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.DefaultEntryTypes
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public class DefaultEntryTypes : Object
  {
    internal static NetworkTableEntryType __\u003C\u003EBOOLEAN = (NetworkTableEntryType) new DefaultEntryTypes\u00241((byte) 0, "Boolean");
    internal static NetworkTableEntryType __\u003C\u003EDOUBLE = (NetworkTableEntryType) new DefaultEntryTypes\u00242((byte) 1, "Double");
    internal static NetworkTableEntryType __\u003C\u003ESTRING = (NetworkTableEntryType) new DefaultEntryTypes\u00243((byte) 2, "String");
    private const byte BOOLEAN_RAW_ID = (byte) 0;
    private const byte DOUBLE_RAW_ID = (byte) 1;
    private const byte STRING_RAW_ID = (byte) 2;

    [Modifiers]
    public static NetworkTableEntryType BOOLEAN
    {
      [HideFromJava] get
      {
        return DefaultEntryTypes.__\u003C\u003EBOOLEAN;
      }
    }

    [Modifiers]
    public static NetworkTableEntryType DOUBLE
    {
      [HideFromJava] get
      {
        return DefaultEntryTypes.__\u003C\u003EDOUBLE;
      }
    }

    [Modifiers]
    public static NetworkTableEntryType STRING
    {
      [HideFromJava] get
      {
        return DefaultEntryTypes.__\u003C\u003ESTRING;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultEntryTypes()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void registerTypes(NetworkTableEntryTypeManager ntetm)
    {
      ntetm.registerType(DefaultEntryTypes.__\u003C\u003EBOOLEAN);
      ntetm.registerType(DefaultEntryTypes.__\u003C\u003EDOUBLE);
      ntetm.registerType(DefaultEntryTypes.__\u003C\u003ESTRING);
      ntetm.registerType((NetworkTableEntryType) BooleanArray.__\u003C\u003ETYPE);
      ntetm.registerType((NetworkTableEntryType) NumberArray.__\u003C\u003ETYPE);
      ntetm.registerType((NetworkTableEntryType) StringArray.__\u003C\u003ETYPE);
    }
  }
}
