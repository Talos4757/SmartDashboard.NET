// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.server.ServerConnectionAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.connection;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2.server
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.connection.ConnectionAdapter", "edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver", "edu.wpi.first.wpilibj.networktables2.FlushableOutgoingEntryReceiver"})]
  [SourceFile(null)]
  public class ServerConnectionAdapter : Object, ConnectionAdapter, IncomingEntryReceiver, FlushableOutgoingEntryReceiver, OutgoingEntryReceiver
  {
    [Modifiers]
    private ServerNetworkTableEntryStore entryStore;
    [Modifiers]
    private IncomingEntryReceiver transactionReceiver;
    [Modifiers]
    private ServerAdapterManager adapterListener;
    internal NetworkTableConnection __\u003C\u003Econnection;
    [Modifiers]
    private NTThread readThread;
    private ServerConnectionState connectionState;

    [Modifiers]
    public NetworkTableConnection connection
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Econnection;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Econnection = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServerConnectionAdapter(IOStream ios, ServerNetworkTableEntryStore sntes, IncomingEntryReceiver ier, ServerAdapterManager sam, NetworkTableEntryTypeManager ntetm, NTThreadManager nttm)
    {
      base.\u002Ector();
      ServerConnectionAdapter connectionAdapter = this;
      this.__\u003C\u003Econnection = new NetworkTableConnection(ios, ntetm);
      this.entryStore = sntes;
      this.transactionReceiver = ier;
      this.adapterListener = sam;
      this.gotoState(ServerConnectionState.__\u003C\u003EGOT_CONNECTION_FROM_CLIENT);
      this.readThread = nttm.newBlockingPeriodicThread((PeriodicRunnable) new ConnectionMonitorThread((ConnectionAdapter) this, this.__\u003C\u003Econnection), "Server Connection Reader Thread");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gotoState([In] ServerConnectionState obj0)
    {
      if (this.connectionState == obj0)
        return;
      System.get_out().println(new StringBuilder().append((object) this).append(" entered connection state: ").append((object) obj0).toString());
      this.connectionState = obj0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ioException(IOException ioe)
    {
      if (ioe is EOFException)
        this.gotoState(ServerConnectionState.__\u003C\u003ECLIENT_DISCONNECTED);
      else
        this.gotoState((ServerConnectionState) new ServerConnectionState.Error((Exception) ioe));
      this.adapterListener.close(this, false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void badMessage(BadMessageException bme)
    {
      this.gotoState((ServerConnectionState) new ServerConnectionState.Error((Exception) bme));
      this.adapterListener.close(this, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void shutdown(bool b)
    {
      int num = b ? 1 : 0;
      this.readThread.stop();
      if (num == 0)
        return;
      this.__\u003C\u003Econnection.close();
    }

    [Throws(new string[] {"java.io.IOException"})]
    public virtual void keepAlive()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clientHello(char ch)
    {
      int num = (int) ch;
      if (this.connectionState != ServerConnectionState.__\u003C\u003EGOT_CONNECTION_FROM_CLIENT)
      {
        string str = "A server should not receive a client hello after it has already connected/entered an error state";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new BadMessageException(str);
      }
      else if (num != 512)
      {
        this.__\u003C\u003Econnection.sendProtocolVersionUnsupported();
        string str = new StringBuilder().append("Client Connected with bad protocol revision: 0x").append(Integer.toHexString(num)).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new BadMessageException(str);
      }
      else
      {
        this.entryStore.sendServerHello(this.__\u003C\u003Econnection);
        this.gotoState(ServerConnectionState.__\u003C\u003ECONNECTED_TO_CLIENT);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void protocolVersionUnsupported(char ch)
    {
      string str = "A server should not receive a protocol version unsupported message";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new BadMessageException(str);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void serverHelloComplete()
    {
      string str = "A server should not receive a server hello complete message";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new BadMessageException(str);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerIncomingAssignment(NetworkTableEntry nte)
    {
      this.transactionReceiver.offerIncomingAssignment(nte);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerIncomingUpdate(NetworkTableEntry nte, char ch, object obj)
    {
      int num = (int) ch;
      this.transactionReceiver.offerIncomingUpdate(nte, (char) num, obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NetworkTableEntry getEntry(char ch)
    {
      return this.entryStore.getEntry(ch);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingAssignment(NetworkTableEntry nte)
    {
      IOException ioe;
      try
      {
        if (this.connectionState != ServerConnectionState.__\u003C\u003ECONNECTED_TO_CLIENT)
          return;
        this.__\u003C\u003Econnection.sendEntryAssignment(nte);
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioe = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      this.ioException(ioe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingUpdate(NetworkTableEntry nte)
    {
      IOException ioe;
      try
      {
        if (this.connectionState != ServerConnectionState.__\u003C\u003ECONNECTED_TO_CLIENT)
          return;
        this.__\u003C\u003Econnection.sendEntryUpdate(nte);
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioe = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      this.ioException(ioe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void flush()
    {
      IOException ioe;
      try
      {
        this.__\u003C\u003Econnection.flush();
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioe = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      this.ioException(ioe);
    }

    public virtual ServerConnectionState getConnectionState()
    {
      return this.connectionState;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ensureAlive()
    {
      IOException ioe;
      try
      {
        this.__\u003C\u003Econnection.sendKeepAlive();
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioe = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      this.ioException(ioe);
    }
  }
}
