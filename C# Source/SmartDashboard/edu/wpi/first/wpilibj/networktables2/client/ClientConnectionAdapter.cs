// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.client.ClientConnectionAdapter
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
using System.Threading;

namespace edu.wpi.first.wpilibj.networktables2.client
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.connection.ConnectionAdapter", "edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver", "edu.wpi.first.wpilibj.networktables2.FlushableOutgoingEntryReceiver"})]
  [SourceFile(null)]
  public class ClientConnectionAdapter : Object, ConnectionAdapter, IncomingEntryReceiver, FlushableOutgoingEntryReceiver, OutgoingEntryReceiver
  {
    [Modifiers]
    private ClientNetworkTableEntryStore entryStore;
    [Modifiers]
    private IOStreamFactory streamFactory;
    [Modifiers]
    private NTThreadManager threadManager;
    private NetworkTableConnection connection;
    private NTThread readThread;
    private ClientConnectionState connectionState;
    [Modifiers]
    private ClientConnectionListenerManager connectionListenerManager;
    [Modifiers]
    private object connectionLock;
    [Modifiers]
    private NetworkTableEntryTypeManager typeManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClientConnectionAdapter(ClientNetworkTableEntryStore cntes, NTThreadManager nttm, IOStreamFactory iosf, ClientConnectionListenerManager cclm, NetworkTableEntryTypeManager ntetm)
    {
      base.\u002Ector();
      ClientConnectionAdapter connectionAdapter = this;
      this.connectionState = ClientConnectionState.__\u003C\u003EDISCONNECTED_FROM_SERVER;
      this.connectionLock = (object) new Object();
      this.entryStore = cntes;
      this.streamFactory = iosf;
      this.threadManager = nttm;
      this.connectionListenerManager = cclm;
      this.typeManager = ntetm;
    }

    public virtual ClientConnectionState getConnectionState()
    {
      return this.connectionState;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      this.close(ClientConnectionState.__\u003C\u003EDISCONNECTED_FROM_SERVER);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void gotoState([In] ClientConnectionState obj0)
    {
      lock (this.connectionLock)
      {
        if (this.connectionState == obj0)
          return;
        System.get_out().println(new StringBuilder().append((object) this).append(" entered connection state: ").append((object) obj0).toString());
        if (obj0 == ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER)
          this.connectionListenerManager.fireConnectedEvent();
        if (this.connectionState == ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER)
          this.connectionListenerManager.fireDisconnectedEvent();
        this.connectionState = obj0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close(ClientConnectionState ccs)
    {
      lock (this.connectionLock)
      {
        this.gotoState(ccs);
        if (this.readThread != null)
        {
          this.readThread.stop();
          this.readThread = (NTThread) null;
        }
        if (this.connection != null)
        {
          this.connection.close();
          this.connection = (NetworkTableConnection) null;
        }
        this.entryStore.clearIds();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void reconnect()
    {
      object obj;
      Monitor.Enter(obj = this.connectionLock);
      // ISSUE: fault handler
      try
      {
        this.close();
        IOStream stream;
        try
        {
          stream = this.streamFactory.createStream();
          if (stream != null)
            goto label_6;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
          else
            goto label_10;
        }
        Monitor.Exit(obj);
        return;
label_6:
        try
        {
          this.connection = new NetworkTableConnection(stream, this.typeManager);
          this.readThread = this.threadManager.newBlockingPeriodicThread((PeriodicRunnable) new ConnectionMonitorThread((ConnectionAdapter) this, this.connection), "Client Connection Reader Thread");
          this.connection.sendClientHello();
          this.gotoState(ClientConnectionState.__\u003C\u003ECONNECTED_TO_SERVER);
          goto label_15;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
          else
            goto label_11;
        }
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_10:
      // ISSUE: variable of the null type
      __Null local = null;
      goto label_12;
label_11:
      local = null;
label_12:
      // ISSUE: fault handler
      try
      {
        this.close();
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_15:
      // ISSUE: fault handler
      try
      {
        Monitor.Exit(obj);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ioException(IOException ioe)
    {
      if (this.connectionState == ClientConnectionState.__\u003C\u003EDISCONNECTED_FROM_SERVER)
        return;
      this.reconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isConnected()
    {
      return this.getConnectionState() == ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void badMessage(BadMessageException bme)
    {
      this.close((ClientConnectionState) new ClientConnectionState.Error((Exception) bme));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NetworkTableEntry getEntry(char ch)
    {
      return this.entryStore.getEntry(ch);
    }

    [Throws(new string[] {"java.io.IOException"})]
    public virtual void keepAlive()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clientHello(char ch)
    {
      string str = "A client should not receive a client hello message";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new BadMessageException(str);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void protocolVersionUnsupported(char ch)
    {
      int num = (int) ch;
      this.close();
      this.gotoState((ClientConnectionState) new ClientConnectionState.ProtocolUnsuppotedByServer((char) num));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void serverHelloComplete()
    {
      if (this.connectionState == ClientConnectionState.__\u003C\u003ECONNECTED_TO_SERVER)
      {
        IOException ioe;
        try
        {
          this.gotoState(ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER);
          this.entryStore.sendUnknownEntries(this.connection);
          return;
        }
        catch (IOException ex)
        {
          int num = 1;
          ioe = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        this.ioException(ioe);
      }
      else
      {
        string str = "A client should only receive a server hello complete once and only after it has connected to the server";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new BadMessageException(str);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerIncomingAssignment(NetworkTableEntry nte)
    {
      this.entryStore.offerIncomingAssignment(nte);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerIncomingUpdate(NetworkTableEntry nte, char ch, object obj)
    {
      int num = (int) ch;
      this.entryStore.offerIncomingUpdate(nte, (char) num, obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingAssignment(NetworkTableEntry nte)
    {
      object obj;
      Exception exception1;
      IOException ioException1;
      try
      {
        Monitor.Enter(obj = this.connectionLock);
        try
        {
          if (this.connection != null && this.connectionState == ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER)
            this.connection.sendEntryAssignment(nte);
          Monitor.Exit(obj);
          return;
        }
        catch (Exception ex)
        {
          int num = 0;
          exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_7;
      }
      Exception exception2 = exception1;
      IOException ioException2;
      try
      {
        Exception exception3 = exception2;
        Monitor.Exit(obj);
        throw Throwable.__\u003Cunmap\u003E(exception3);
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException2 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      IOException ioe = ioException2;
      goto label_11;
label_7:
      ioe = ioException1;
label_11:
      this.ioException(ioe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingUpdate(NetworkTableEntry nte)
    {
      object obj;
      Exception exception1;
      IOException ioException1;
      try
      {
        Monitor.Enter(obj = this.connectionLock);
        try
        {
          if (this.connection != null && this.connectionState == ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER)
            this.connection.sendEntryUpdate(nte);
          Monitor.Exit(obj);
          return;
        }
        catch (Exception ex)
        {
          int num = 0;
          exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_7;
      }
      Exception exception2 = exception1;
      IOException ioException2;
      try
      {
        Exception exception3 = exception2;
        Monitor.Exit(obj);
        throw Throwable.__\u003Cunmap\u003E(exception3);
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException2 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      IOException ioe = ioException2;
      goto label_11;
label_7:
      ioe = ioException1;
label_11:
      this.ioException(ioe);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void flush()
    {
      object obj;
      Monitor.Enter(obj = this.connectionLock);
      IOException ioException;
      // ISSUE: fault handler
      try
      {
        if (this.connection != null)
        {
          try
          {
            this.connection.flush();
            goto label_8;
          }
          catch (IOException ex)
          {
            int num = 1;
            ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        else
          goto label_8;
      }
      __fault
      {
        Monitor.Exit(obj);
      }
      IOException ioe = ioException;
      // ISSUE: fault handler
      try
      {
        this.ioException(ioe);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_8:
      // ISSUE: fault handler
      try
      {
        Monitor.Exit(obj);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ensureAlive()
    {
      object obj;
      Monitor.Enter(obj = this.connectionLock);
      IOException ioException;
      // ISSUE: fault handler
      try
      {
        if (this.connection != null)
        {
          try
          {
            this.connection.sendKeepAlive();
            goto label_10;
          }
          catch (IOException ex)
          {
            int num = 1;
            ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        else
          goto label_8;
      }
      __fault
      {
        Monitor.Exit(obj);
      }
      IOException ioe = ioException;
      // ISSUE: fault handler
      try
      {
        this.ioException(ioe);
        goto label_10;
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_8:
      // ISSUE: fault handler
      try
      {
        this.reconnect();
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_10:
      // ISSUE: fault handler
      try
      {
        Monitor.Exit(obj);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
    }
  }
}
