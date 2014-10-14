// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.AbstractNetworkTableEntryStore
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.type;
using edu.wpi.first.wpilibj.networktables2.util;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver"})]
  [SourceFile(null)]
  public abstract class AbstractNetworkTableEntryStore : Object, IncomingEntryReceiver
  {
    internal CharacterArrayMap __\u003C\u003EidEntries;
    internal Hashtable __\u003C\u003EnamedEntries;
    internal AbstractNetworkTableEntryStore.TableListenerManager __\u003C\u003ElistenerManager;
    protected internal OutgoingEntryReceiver outgoingReceiver;
    protected internal OutgoingEntryReceiver incomingReceiver;

    [Modifiers]
    protected internal CharacterArrayMap idEntries
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EidEntries;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EidEntries = value;
      }
    }

    [Modifiers]
    protected internal Hashtable namedEntries
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EnamedEntries;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EnamedEntries = value;
      }
    }

    [Modifiers]
    protected internal AbstractNetworkTableEntryStore.TableListenerManager listenerManager
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003ElistenerManager;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003ElistenerManager = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractNetworkTableEntryStore(AbstractNetworkTableEntryStore.TableListenerManager antestlm)
    {
      base.\u002Ector();
      AbstractNetworkTableEntryStore networkTableEntryStore = this;
      this.__\u003C\u003EidEntries = new CharacterArrayMap();
      this.__\u003C\u003EnamedEntries = new Hashtable();
      this.__\u003C\u003ElistenerManager = antestlm;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NetworkTableEntry getEntry(string str)
    {
      NetworkTableEntry networkTableEntry;
      lock (this)
        networkTableEntry = (NetworkTableEntry) this.__\u003C\u003EnamedEntries.get((object) str);
      return networkTableEntry;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List keys()
    {
      List list;
      lock (this)
      {
        List local_1 = new List();
        Enumeration local_2 = this.__\u003C\u003EnamedEntries.keys();
        while (local_2.hasMoreElements())
          local_1.add(local_2.nextElement());
        list = local_1;
      }
      return list;
    }

    protected internal abstract bool addEntry(NetworkTableEntry nte);

    protected internal abstract bool updateEntry(NetworkTableEntry nte, char ch, object obj);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NetworkTableEntry getEntry(char ch)
    {
      int num = (int) ch;
      NetworkTableEntry networkTableEntry;
      lock (this)
        networkTableEntry = (NetworkTableEntry) this.__\u003C\u003EidEntries.get((char) num);
      return networkTableEntry;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearEntries()
    {
      lock (this)
      {
        this.__\u003C\u003EidEntries.clear();
        this.__\u003C\u003EnamedEntries.clear();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearIds()
    {
      lock (this)
      {
        this.__\u003C\u003EidEntries.clear();
        Enumeration local_1 = this.__\u003C\u003EnamedEntries.elements();
        while (local_1.hasMoreElements())
          ((NetworkTableEntry) local_1.nextElement()).clearId();
      }
    }

    public virtual void setOutgoingReceiver(OutgoingEntryReceiver oer)
    {
      this.outgoingReceiver = oer;
    }

    public virtual void setIncomingReceiver(OutgoingEntryReceiver oer)
    {
      this.incomingReceiver = oer;
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.networktables2.TableKeyExistsWithDifferentTypeException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putOutgoing(string str, NetworkTableEntryType ntet, object obj)
    {
      lock (this)
      {
        NetworkTableEntry local_1 = (NetworkTableEntry) this.__\u003C\u003EnamedEntries.get((object) str);
        if (local_1 == null)
        {
          NetworkTableEntry local_1_1 = new NetworkTableEntry(str, ntet, obj);
          if (!this.addEntry(local_1_1))
            return;
          local_1_1.fireListener(this.__\u003C\u003ElistenerManager);
          this.outgoingReceiver.offerOutgoingAssignment(local_1_1);
        }
        else if ((int) (sbyte) local_1.getType().__\u003C\u003Eid != (int) (sbyte) ntet.__\u003C\u003Eid)
        {
          string temp_30 = str;
          NetworkTableEntryType temp_32 = local_1.getType();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new TableKeyExistsWithDifferentTypeException(temp_30, temp_32);
        }
        else
        {
          if (this.updateEntry(local_1, (char) ((uint) local_1.getSequenceNumber() + 1U), obj))
            this.outgoingReceiver.offerOutgoingUpdate(local_1);
          local_1.fireListener(this.__\u003C\u003ElistenerManager);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putOutgoing(NetworkTableEntry nte, object obj)
    {
      lock (this)
      {
        if (this.updateEntry(nte, (char) ((uint) nte.getSequenceNumber() + 1U), obj))
          this.outgoingReceiver.offerOutgoingUpdate(nte);
        nte.fireListener(this.__\u003C\u003ElistenerManager);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerIncomingAssignment(NetworkTableEntry nte)
    {
      lock (this)
      {
        NetworkTableEntry local_1 = (NetworkTableEntry) this.__\u003C\u003EnamedEntries.get((object) nte.__\u003C\u003Ename);
        if (!this.addEntry(nte))
          return;
        if (local_1 == null)
          local_1 = nte;
        local_1.fireListener(this.__\u003C\u003ElistenerManager);
        this.incomingReceiver.offerOutgoingAssignment(local_1);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerIncomingUpdate(NetworkTableEntry nte, char ch, object obj)
    {
      int num = (int) ch;
      lock (this)
      {
        if (!this.updateEntry(nte, (char) num, obj))
          return;
        nte.fireListener(this.__\u003C\u003ElistenerManager);
        this.incomingReceiver.offerOutgoingUpdate(nte);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void notifyEntries(ITable it, ITableListener itl)
    {
      lock (this)
      {
        Enumeration local_1 = this.__\u003C\u003EnamedEntries.elements();
        while (local_1.hasMoreElements())
        {
          NetworkTableEntry local_2 = (NetworkTableEntry) local_1.nextElement();
          itl.valueChanged(it, local_2.__\u003C\u003Ename, local_2.getValue(), true);
        }
      }
    }

    [InnerClass]
    [SourceFile(null)]
    public interface TableListenerManager
    {
      void fireTableListeners(string str, object obj, bool b);
    }
  }
}
