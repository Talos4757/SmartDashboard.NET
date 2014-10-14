// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.client.ClientNetworkTableEntryStore
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

namespace edu.wpi.first.wpilibj.networktables2.client
{
  [SourceFile(null)]
  public class ClientNetworkTableEntryStore : AbstractNetworkTableEntryStore
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClientNetworkTableEntryStore(AbstractNetworkTableEntryStore.TableListenerManager antestlm)
      : base(antestlm)
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void sendUnknownEntries([In] NetworkTableConnection obj0)
    {
      lock (this)
      {
        Enumeration local_1 = this.__\u003C\u003EnamedEntries.elements();
        while (local_1.hasMoreElements())
        {
          NetworkTableEntry local_2 = (NetworkTableEntry) local_1.nextElement();
          if ((int) local_2.getId() == (int) ushort.MaxValue)
            obj0.sendEntryAssignment(local_2);
        }
        obj0.flush();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override bool addEntry(NetworkTableEntry nte)
    {
      lock (this)
      {
        NetworkTableEntry local_1 = (NetworkTableEntry) this.__\u003C\u003EnamedEntries.get((object) nte.__\u003C\u003Ename);
        if (local_1 != null)
        {
          if ((int) local_1.getId() != (int) nte.getId())
          {
            this.__\u003C\u003EidEntries.remove(local_1.getId());
            if ((int) nte.getId() != (int) ushort.MaxValue)
            {
              local_1.setId(nte.getId());
              this.__\u003C\u003EidEntries.put(nte.getId(), (object) local_1);
            }
          }
          local_1.forcePut(nte.getSequenceNumber(), nte.getType(), nte.getValue());
        }
        else
        {
          if ((int) nte.getId() != (int) ushort.MaxValue)
            this.__\u003C\u003EidEntries.put(nte.getId(), (object) nte);
          this.__\u003C\u003EnamedEntries.put((object) nte.__\u003C\u003Ename, (object) nte);
        }
      }
      return true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override bool updateEntry(NetworkTableEntry nte, char ch, object obj)
    {
      int num1 = (int) ch;
      ClientNetworkTableEntryStore networkTableEntryStore;
      Monitor.Enter((object) (networkTableEntryStore = this));
      int num2;
      // ISSUE: fault handler
      try
      {
        nte.forcePut((char) num1, obj);
        if ((int) nte.getId() == (int) ushort.MaxValue)
        {
          int num3 = 0;
          Monitor.Exit((object) networkTableEntryStore);
          return num3 != 0;
        }
        else
        {
          int num3 = 1;
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
