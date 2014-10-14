// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableConnectionListenerAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.IRemoteConnectionListener"})]
  [SourceFile(null)]
  public class NetworkTableConnectionListenerAdapter : Object, IRemoteConnectionListener
  {
    [Modifiers]
    private IRemoteConnectionListener targetListener;
    [Modifiers]
    private IRemote targetSource;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableConnectionListenerAdapter(IRemote ir, IRemoteConnectionListener ircl)
    {
      base.\u002Ector();
      NetworkTableConnectionListenerAdapter connectionListenerAdapter = this;
      this.targetSource = ir;
      this.targetListener = ircl;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void connected(IRemote ir)
    {
      this.targetListener.connected(this.targetSource);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void disconnected(IRemote ir)
    {
      this.targetListener.disconnected(this.targetSource);
    }
  }
}
