// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.server.ServerNetworkTableEntryStore
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.connection;
using IKVM.Attributes;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace edu.wpi.first.wpilibj.networktables2.server
{
  [SourceFile(null)]
  public class ServerNetworkTableEntryStore : AbstractNetworkTableEntryStore
  {
    private char nextId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServerNetworkTableEntryStore(AbstractNetworkTableEntryStore.TableListenerManager antestlm)
      : base(antestlm)
    {
      ServerNetworkTableEntryStore networkTableEntryStore = this;
      this.nextId = char.MinValue;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void sendServerHello([In] NetworkTableConnection obj0)
    {
      lock (this)
      {
        Enumeration local_1 = this.__\u003C\u003EnamedEntries.elements();
        while (local_1.hasMoreElements())
        {
          NetworkTableEntry local_2 = (NetworkTableEntry) local_1.nextElement();
          obj0.sendEntryAssignment(local_2);
        }
        obj0.sendServerHelloComplete();
        obj0.flush();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override bool addEntry(NetworkTableEntry nte)
    {
      ServerNetworkTableEntryStore networkTableEntryStore1;
      Monitor.Enter((object) (networkTableEntryStore1 = this));
      int num1;
      // ISSUE: fault handler
      try
      {
        if ((NetworkTableEntry) this.__\u003C\u003EnamedEntries.get((object) nte.__\u003C\u003Ename) == null)
        {
          NetworkTableEntry networkTableEntry = nte;
          ServerNetworkTableEntryStore networkTableEntryStore2 = this;
          num1 = (int) networkTableEntryStore2.nextId;
          ServerNetworkTableEntryStore networkTableEntryStore3 = networkTableEntryStore2;
          int num2 = num1;
          networkTableEntryStore3.nextId = (char) (num1 + 1);
          networkTableEntry.setId((char) num2);
          this.__\u003C\u003EidEntries.put(nte.getId(), (object) nte);
          this.__\u003C\u003EnamedEntries.put((object) nte.__\u003C\u003Ename, (object) nte);
          int num3 = 1;
          Monitor.Exit((object) networkTableEntryStore1);
          return num3 != 0;
        }
        else
        {
          int num2 = 0;
          Monitor.Exit((object) networkTableEntryStore1);
          num1 = num2;
        }
      }
      __fault
      {
        Monitor.Exit((object) networkTableEntryStore1);
      }
      return num1 != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override bool updateEntry(NetworkTableEntry nte, char ch, object obj)
    {
      int num1 = (int) ch;
      ServerNetworkTableEntryStore networkTableEntryStore;
      Monitor.Enter((object) (networkTableEntryStore = this));
      int num2;
      // ISSUE: fault handler
      try
      {
        if (nte.putValue((char) num1, obj))
        {
          int num3 = 1;
          Monitor.Exit((object) networkTableEntryStore);
          return num3 != 0;
        }
        else
        {
          int num3 = 0;
          Monitor.Exit((object) networkTableEntryStore);
          num2 = num3;
        }
      }
      __fault
      {
        Monitor.Exit((object) networkTableEntryStore);
      }
      return num2 != 0;
    }
  }
}
