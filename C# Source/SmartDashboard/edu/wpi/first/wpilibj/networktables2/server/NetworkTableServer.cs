// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.server.NetworkTableServer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.server
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.server.ServerIncomingConnectionListener"})]
  [SourceFile(null)]
  public class NetworkTableServer : NetworkTableNode, ServerIncomingConnectionListener
  {
    [Modifiers]
    private ServerIncomingStreamMonitor incomingStreamMonitor;
    [Modifiers]
    private WriteManager writeManager;
    [Modifiers]
    private IOStreamProvider streamProvider;
    [Modifiers]
    private ServerConnectionList connectionList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableServer(IOStreamProvider iosp, NetworkTableEntryTypeManager ntetm, NTThreadManager nttm)
    {
      NetworkTableServer networkTableServer = this;
      ServerNetworkTableEntryStore sntes;
      this.init((AbstractNetworkTableEntryStore) (sntes = new ServerNetworkTableEntryStore((AbstractNetworkTableEntryStore.TableListenerManager) this)));
      this.streamProvider = iosp;
      this.connectionList = new ServerConnectionList();
      this.writeManager = new WriteManager((FlushableOutgoingEntryReceiver) this.connectionList, nttm, this.getEntryStore(), long.MaxValue);
      this.incomingStreamMonitor = new ServerIncomingStreamMonitor(iosp, sntes, (ServerIncomingConnectionListener) this, (ServerAdapterManager) this.connectionList, ntetm, nttm);
      this.getEntryStore().setIncomingReceiver((OutgoingEntryReceiver) new TransactionDirtier((OutgoingEntryReceiver) this.writeManager));
      this.getEntryStore().setOutgoingReceiver((OutgoingEntryReceiver) new TransactionDirtier((OutgoingEntryReceiver) this.writeManager));
      this.incomingStreamMonitor.start();
      this.writeManager.start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableServer(IOStreamProvider iosp)
      : this(iosp, new NetworkTableEntryTypeManager(), (NTThreadManager) new DefaultThreadManager())
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void close()
    {
      Exception exception;
      try
      {
        this.incomingStreamMonitor.stop();
        this.writeManager.stop();
        this.connectionList.closeAll();
        Thread.sleep(1000L);
        this.streamProvider.close();
        Thread.sleep(1000L);
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void onNewConnection(ServerConnectionAdapter sca)
    {
      this.connectionList.add(sca);
    }

    public override bool isConnected()
    {
      return true;
    }

    public override bool isServer()
    {
      return true;
    }
  }
}
