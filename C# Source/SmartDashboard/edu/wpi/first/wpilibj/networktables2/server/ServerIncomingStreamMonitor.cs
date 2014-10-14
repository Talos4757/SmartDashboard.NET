// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.server.ServerIncomingStreamMonitor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.server
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.thread.PeriodicRunnable"})]
  [SourceFile(null)]
  public class ServerIncomingStreamMonitor : Object, PeriodicRunnable
  {
    [Modifiers]
    private IOStreamProvider streamProvider;
    [Modifiers]
    private ServerIncomingConnectionListener incomingListener;
    [Modifiers]
    private ServerNetworkTableEntryStore entryStore;
    [Modifiers]
    private ServerAdapterManager adapterListener;
    private NTThread monitorThread;
    private NTThreadManager threadManager;
    [Modifiers]
    private NetworkTableEntryTypeManager typeManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServerIncomingStreamMonitor(IOStreamProvider iosp, ServerNetworkTableEntryStore sntes, ServerIncomingConnectionListener sicl, ServerAdapterManager sam, NetworkTableEntryTypeManager ntetm, NTThreadManager nttm)
    {
      base.\u002Ector();
      ServerIncomingStreamMonitor incomingStreamMonitor = this;
      this.streamProvider = iosp;
      this.entryStore = sntes;
      this.incomingListener = sicl;
      this.adapterListener = sam;
      this.typeManager = ntetm;
      this.threadManager = nttm;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void start()
    {
      if (this.monitorThread != null)
        this.stop();
      this.monitorThread = this.threadManager.newBlockingPeriodicThread((PeriodicRunnable) this, "Server Incoming Stream Monitor Thread");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void stop()
    {
      if (this.monitorThread == null)
        return;
      this.monitorThread.stop();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      try
      {
        IOStream ios = this.streamProvider.accept();
        if (ios == null)
          return;
        this.incomingListener.onNewConnection(new ServerConnectionAdapter(ios, this.entryStore, (IncomingEntryReceiver) this.entryStore, this.adapterListener, this.typeManager, this.threadManager));
      }
      catch (IOException ex)
      {
      }
    }
  }
}
