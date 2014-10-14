// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.server.ServerConnectionList
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.util;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.server
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.FlushableOutgoingEntryReceiver", "edu.wpi.first.wpilibj.networktables2.server.ServerAdapterManager"})]
  [SourceFile(null)]
  public class ServerConnectionList : Object, FlushableOutgoingEntryReceiver, OutgoingEntryReceiver, ServerAdapterManager
  {
    private List connections;
    [Modifiers]
    private object connectionsLock;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServerConnectionList()
    {
      base.\u002Ector();
      ServerConnectionList serverConnectionList = this;
      this.connections = new List();
      this.connectionsLock = (object) new Object();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void closeAll()
    {
      lock (this.connectionsLock)
      {
        while (this.connections.size() > 0)
          this.close((ServerConnectionAdapter) this.connections.get(0), true);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(ServerConnectionAdapter sca)
    {
      lock (this.connectionsLock)
        this.connections.add((object) sca);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close(ServerConnectionAdapter sca, bool b)
    {
      int num = b ? 1 : 0;
      lock (this.connectionsLock)
      {
        if (!this.connections.remove((object) sca))
          return;
        System.get_out().println(new StringBuilder().append("Close: ").append((object) sca).toString());
        sca.shutdown(num != 0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingAssignment(NetworkTableEntry nte)
    {
      lock (this.connectionsLock)
      {
        for (int local_1 = 0; local_1 < this.connections.size(); ++local_1)
          ((ServerConnectionAdapter) this.connections.get(local_1)).offerOutgoingAssignment(nte);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingUpdate(NetworkTableEntry nte)
    {
      lock (this.connectionsLock)
      {
        for (int local_1 = 0; local_1 < this.connections.size(); ++local_1)
          ((ServerConnectionAdapter) this.connections.get(local_1)).offerOutgoingUpdate(nte);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void flush()
    {
      lock (this.connectionsLock)
      {
        for (int local_1 = 0; local_1 < this.connections.size(); ++local_1)
          ((ServerConnectionAdapter) this.connections.get(local_1)).flush();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ensureAlive()
    {
      lock (this.connectionsLock)
      {
        for (int local_1 = 0; local_1 < this.connections.size(); ++local_1)
          ((ServerConnectionAdapter) this.connections.get(local_1)).ensureAlive();
      }
    }
  }
}
