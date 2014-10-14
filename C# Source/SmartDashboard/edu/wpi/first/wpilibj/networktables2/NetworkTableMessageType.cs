// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.NetworkTableMessageType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;

namespace edu.wpi.first.wpilibj.networktables2
{
  [SourceFile(null)]
  public interface NetworkTableMessageType
  {
    const int KEEP_ALIVE = 0;
    const int CLIENT_HELLO = 1;
    const int PROTOCOL_VERSION_UNSUPPORTED = 2;
    const int SERVER_HELLO_COMPLETE = 3;
    const int ENTRY_ASSIGNMENT = 16;
    const int FIELD_UPDATE = 17;

    [HideFromJava]
    static class __Fields
    {
      public const int KEEP_ALIVE = 0;
      public const int CLIENT_HELLO = 1;
      public const int PROTOCOL_VERSION_UNSUPPORTED = 2;
      public const int SERVER_HELLO_COMPLETE = 3;
      public const int ENTRY_ASSIGNMENT = 16;
      public const int FIELD_UPDATE = 17;
    }
  }
}
