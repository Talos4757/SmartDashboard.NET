// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.tables.IRemote
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;

namespace edu.wpi.first.wpilibj.tables
{
  [SourceFile(null)]
  public interface IRemote
  {
    void addConnectionListener(IRemoteConnectionListener ircl, bool b);

    void removeConnectionListener(IRemoteConnectionListener ircl);

    bool isConnected();

    bool isServer();
  }
}
