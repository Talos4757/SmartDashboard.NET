// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.client.NetworkTableClient
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.client
{
  [SourceFile(null)]
  public class NetworkTableClient : NetworkTableNode
  {
    [Modifiers]
    private ClientConnectionAdapter adapter;
    [Modifiers]
    private WriteManager writeManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableClient(IOStreamFactory iosf)
      : this(iosf, new NetworkTableEntryTypeManager(), (NTThreadManager) new DefaultThreadManager())
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableClient(IOStreamFactory iosf, NetworkTableEntryTypeManager ntetm, NTThreadManager nttm)
    {
      NetworkTableClient networkTableClient = this;
      ClientNetworkTableEntryStore cntes;
      this.init((AbstractNetworkTableEntryStore) (cntes = new ClientNetworkTableEntryStore((AbstractNetworkTableEntryStore.TableListenerManager) this)));
      this.adapter = new ClientConnectionAdapter(cntes, nttm, iosf, (ClientConnectionListenerManager) this, ntetm);
      this.writeManager = new WriteManager((FlushableOutgoingEntryReceiver) this.adapter, nttm, this.getEntryStore(), 1000L);
      this.getEntryStore().setOutgoingReceiver((OutgoingEntryReceiver) new TransactionDirtier((OutgoingEntryReceiver) this.writeManager));
      this.getEntryStore().setIncomingReceiver(OutgoingEntryReceiver.NULL);
      this.writeManager.start();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void close()
    {
      this.adapter.close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void reconnect()
    {
      this.adapter.reconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void stop()
    {
      this.writeManager.stop();
      this.close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isConnected()
    {
      return (this.adapter.isConnected() ? 1 : 0) != 0;
    }

    public override bool isServer()
    {
      return false;
    }
  }
}
