// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.NetworkTableNode
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.client;
using edu.wpi.first.wpilibj.networktables2.type;
using edu.wpi.first.wpilibj.networktables2.util;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.AbstractNetworkTableEntryStore$TableListenerManager", "edu.wpi.first.wpilibj.networktables2.client.ClientConnectionListenerManager", "edu.wpi.first.wpilibj.tables.IRemote"})]
  [SourceFile(null)]
  public abstract class NetworkTableNode : Object, AbstractNetworkTableEntryStore.TableListenerManager, ClientConnectionListenerManager, IRemote
  {
    protected internal AbstractNetworkTableEntryStore entryStore;
    [Modifiers]
    private List remoteListeners;
    [Modifiers]
    private List tableListeners;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableNode()
    {
      base.\u002Ector();
      NetworkTableNode networkTableNode = this;
      this.remoteListeners = new List();
      this.tableListeners = new List();
    }

    public abstract void close();

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addConnectionListener(IRemoteConnectionListener ircl, bool b)
    {
      this.remoteListeners.add((object) ircl);
      if (this.isConnected())
        ircl.connected((IRemote) this);
      else
        ircl.disconnected((IRemote) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeConnectionListener(IRemoteConnectionListener ircl)
    {
      this.remoteListeners.remove((object) ircl);
    }

    public virtual AbstractNetworkTableEntryStore getEntryStore()
    {
      return this.entryStore;
    }

    [HideFromReflection]
    public abstract bool isConnected();

    [HideFromReflection]
    public abstract bool isServer();

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addTableListener(ITableListener itl, bool b)
    {
      int num = b ? 1 : 0;
      this.tableListeners.add((object) itl);
      if (num == 0)
        return;
      this.entryStore.notifyEntries((ITable) null, itl);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeTableListener(ITableListener itl)
    {
      this.tableListeners.remove((object) itl);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsKey(string str)
    {
      return this.entryStore.getEntry(str) != null;
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDouble(string str)
    {
      NetworkTableEntry entry = this.entryStore.getEntry(str);
      if (entry == null)
      {
        string str1 = str;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TableKeyNotDefinedException(str1);
      }
      else
        return ((Double) entry.getValue()).doubleValue();
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString(string str)
    {
      NetworkTableEntry entry = this.entryStore.getEntry(str);
      if (entry != null)
        return (string) entry.getValue();
      string str1 = str;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new TableKeyNotDefinedException(str1);
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getBoolean(string str)
    {
      NetworkTableEntry entry = this.entryStore.getEntry(str);
      if (entry == null)
      {
        string str1 = str;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new TableKeyNotDefinedException(str1);
      }
      else
        return (((Boolean) entry.getValue()).booleanValue() ? 1 : 0) != 0;
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void retrieveValue(string str, object obj)
    {
      lock (this.entryStore)
      {
        NetworkTableEntry local_1 = this.entryStore.getEntry(str);
        if (local_1 == null)
        {
          string temp_23 = str;
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new TableKeyNotDefinedException(temp_23);
        }
        else
        {
          NetworkTableEntryType local_2 = local_1.getType();
          if (!(local_2 is ComplexEntryType))
          {
            string temp_19 = str;
            NetworkTableEntryType temp_20 = local_2;
            string temp_21 = "Is not a complex data type";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new TableKeyExistsWithDifferentTypeException(temp_19, temp_20, temp_21);
          }
          else
            ((ComplexEntryType) local_2).exportValue(str, local_1.getValue(), obj);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putValue(NetworkTableEntry nte, object obj)
    {
      if (nte.getType() is ComplexEntryType)
      {
        lock (this.entryStore)
        {
          ComplexEntryType local_1 = (ComplexEntryType) nte.getType();
          this.entryStore.putOutgoing(nte, local_1.internalizeValue(nte.__\u003C\u003Ename, obj, nte.getValue()));
        }
      }
      else
        this.entryStore.putOutgoing(nte, obj);
    }

    [Throws(new string[] {"java.lang.IllegalArgumentException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putValue(string str, object obj)
    {
      if (obj is Double)
        this.putValue(str, DefaultEntryTypes.__\u003C\u003EDOUBLE, obj);
      else if (obj is string)
        this.putValue(str, DefaultEntryTypes.__\u003C\u003ESTRING, obj);
      else if (obj is Boolean)
        this.putValue(str, DefaultEntryTypes.__\u003C\u003EBOOLEAN, obj);
      else if (obj is ComplexData)
        this.putValue(str, (NetworkTableEntryType) ((ComplexData) obj).getType(), obj);
      else if (obj == null)
      {
        string str1 = "Cannot put a null value into networktables";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str1);
      }
      else
      {
        string str1 = "Invalid Type";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str1);
      }
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValue(string str)
    {
      object obj;
      lock (this.entryStore)
      {
        NetworkTableEntry local_1 = this.entryStore.getEntry(str);
        if (local_1 == null)
        {
          string temp_11 = str;
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new TableKeyNotDefinedException(temp_11);
        }
        else
          obj = local_1.getValue();
      }
      return obj;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putValue(string str, NetworkTableEntryType ntet, object obj)
    {
      if (ntet is ComplexEntryType)
      {
        lock (this.entryStore)
        {
          ComplexEntryType local_1 = (ComplexEntryType) ntet;
          NetworkTableEntry local_2 = this.entryStore.getEntry(str);
          if (local_2 != null)
            this.entryStore.putOutgoing(local_2, local_1.internalizeValue(local_2.__\u003C\u003Ename, obj, local_2.getValue()));
          else
            this.entryStore.putOutgoing(str, ntet, local_1.internalizeValue(str, obj, (object) null));
        }
      }
      else
        this.entryStore.putOutgoing(str, ntet, obj);
    }

    protected internal void init(AbstractNetworkTableEntryStore antes)
    {
      this.entryStore = antes;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putBoolean(string str, bool b)
    {
      int num = b ? 1 : 0;
      this.putValue(str, DefaultEntryTypes.__\u003C\u003EBOOLEAN, num == 0 ? (object) Boolean.FALSE : (object) Boolean.TRUE);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putDouble(string str, double d)
    {
      this.putValue(str, DefaultEntryTypes.__\u003C\u003EDOUBLE, (object) new Double(d));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putString(string str1, string str2)
    {
      this.putValue(str1, DefaultEntryTypes.__\u003C\u003ESTRING, (object) str2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putComplex(string str, ComplexData cd)
    {
      this.putValue(str, (NetworkTableEntryType) cd.getType(), (object) cd);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireConnectedEvent()
    {
      for (int i = 0; i < this.remoteListeners.size(); ++i)
        ((IRemoteConnectionListener) this.remoteListeners.get(i)).connected((IRemote) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireDisconnectedEvent()
    {
      for (int i = 0; i < this.remoteListeners.size(); ++i)
        ((IRemoteConnectionListener) this.remoteListeners.get(i)).disconnected((IRemote) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireTableListeners(string str, object obj, bool b)
    {
      int num = b ? 1 : 0;
      for (int i = 0; i < this.tableListeners.size(); ++i)
        ((ITableListener) this.tableListeners.get(i)).valueChanged((ITable) null, str, obj, num != 0);
    }
  }
}
