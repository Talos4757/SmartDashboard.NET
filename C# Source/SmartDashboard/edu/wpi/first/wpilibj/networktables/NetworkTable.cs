// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.util;
using edu.wpi.first.wpilibj.tables;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITable", "edu.wpi.first.wpilibj.tables.IRemote"})]
  [SourceFile(null)]
  public class NetworkTable : Object, ITable, IRemote
  {
    [Modifiers]
    private static NTThreadManager threadManager = (NTThreadManager) new DefaultThreadManager();
    private static NetworkTableProvider staticProvider = (NetworkTableProvider) null;
    private static NetworkTableMode mode = NetworkTableMode.__\u003C\u003EServer;
    private static int port = 1735;
    private static string ipAddress = (string) null;
    public const char PATH_SEPARATOR = '/';
    public const int DEFAULT_PORT = 1735;
    [Modifiers]
    private string path;
    [Modifiers]
    private NetworkTable.EntryCache entryCache;
    [Modifiers]
    private NetworkTable.NetworkTableKeyCache absoluteKeyCache;
    [Modifiers]
    private NetworkTableProvider provider;
    [Modifiers]
    private NetworkTableNode node;
    [Modifiers]
    private Hashtable connectionListenerMap;
    [Modifiers]
    private Hashtable listenerMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal NetworkTable([In] string obj0, [In] NetworkTableProvider obj1)
    {
      base.\u002Ector();
      NetworkTable networkTable = this;
      this.connectionListenerMap = new Hashtable();
      this.listenerMap = new Hashtable();
      this.path = obj0;
      this.entryCache = new NetworkTable.EntryCache(this, obj0);
      this.absoluteKeyCache = new NetworkTable.NetworkTableKeyCache(obj0);
      this.provider = obj1;
      this.node = obj1.getNode();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setTableProvider(NetworkTableProvider ntp)
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        NetworkTable.checkInit();
        NetworkTable.staticProvider = ntp;
      }
    }

    [Modifiers]
    internal static NetworkTableNode access\u0024100([In] NetworkTable obj0)
    {
      return obj0.node;
    }

    [Modifiers]
    internal static NetworkTable.NetworkTableKeyCache access\u0024000([In] NetworkTable obj0)
    {
      return obj0.absoluteKeyCache;
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void checkInit()
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        if (NetworkTable.staticProvider == null)
          return;
        string temp_3 = "Network tables has already been initialized";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(temp_3);
      }
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setIPAddress(string str)
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        NetworkTable.checkInit();
        NetworkTable.ipAddress = str;
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void initialize()
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        NetworkTable.checkInit();
        NetworkTable.staticProvider = new NetworkTableProvider(NetworkTable.mode.createNode(NetworkTable.ipAddress, NetworkTable.port, NetworkTable.threadManager));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addTableListener(ITableListener itl, bool b)
    {
      int num = b ? 1 : 0;
      List list = (List) this.listenerMap.get((object) itl);
      if (list == null)
      {
        list = new List();
        this.listenerMap.put((object) itl, (object) list);
      }
      NetworkTableListenerAdapter tableListenerAdapter = new NetworkTableListenerAdapter(new StringBuilder().append(this.path).append('/').toString(), (ITable) this, itl);
      list.add((object) tableListenerAdapter);
      this.node.addTableListener((ITableListener) tableListenerAdapter, num != 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putValue(string str, object obj)
    {
      NetworkTableEntry nte = this.entryCache.get(str);
      if (nte != null)
        this.node.putValue(nte, obj);
      else
        this.node.putValue(this.absoluteKeyCache.get(str), obj);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putNumber(string str, double d)
    {
      this.putValue(str, (object) new Double(d));
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getNumber(string str)
    {
      return this.node.getDouble(this.absoluteKeyCache.get(str));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getNumber(string str, double d)
    {
      double @double;
      try
      {
        @double = this.node.getDouble(this.absoluteKeyCache.get(str));
      }
      catch (TableKeyNotDefinedException ex)
      {
        goto label_3;
      }
      return @double;
label_3:
      return d;
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setServerMode()
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        NetworkTable.checkInit();
        NetworkTable.mode = NetworkTableMode.__\u003C\u003EServer;
      }
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setClientMode()
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        NetworkTable.checkInit();
        NetworkTable.mode = NetworkTableMode.__\u003C\u003EClient;
      }
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setTeam(int i)
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        StringBuilder temp_9 = new StringBuilder().append("10.").append(i / 100).append(".");
        int temp_10 = i;
        int temp_11 = 100;
        int temp_12 = -1;
        int temp_13 = temp_11 != temp_12 ? temp_10 % temp_11 : 0;
        NetworkTable.setIPAddress(temp_9.append(temp_13).append(".2").toString());
      }
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static NetworkTable getTable(string str)
    {
      lock ((object) ClassLiteral<NetworkTable>.Value)
      {
        if (NetworkTable.staticProvider == null)
        {
          IOException local_1;
          try
          {
            NetworkTable.initialize();
            goto label_5;
          }
          catch (IOException exception_0)
          {
            int temp_13 = 1;
            local_1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) exception_0, (ByteCodeHelper.MapFlags) temp_13);
          }
          IOException local_2 = local_1;
          string temp_26 = new StringBuilder().append("NetworkTable could not be initialized: ").append((object) local_2).append(": ").append(Throwable.instancehelper_getMessage((Exception) local_2)).toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(temp_26);
        }
label_5:
        return (NetworkTable) NetworkTable.staticProvider.getTable(new StringBuilder().append('/').append(str).toString());
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append("NetworkTable: ").append(this.path).toString();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isConnected()
    {
      return (this.node.isConnected() ? 1 : 0) != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isServer()
    {
      return (this.node.isServer() ? 1 : 0) != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addConnectionListener(IRemoteConnectionListener ircl, bool b)
    {
      int num = b ? 1 : 0;
      if ((NetworkTableConnectionListenerAdapter) this.connectionListenerMap.get((object) ircl) != null)
      {
        string str = "Cannot add the same listener twice";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
      else
      {
        NetworkTableConnectionListenerAdapter connectionListenerAdapter = new NetworkTableConnectionListenerAdapter((IRemote) this, ircl);
        this.connectionListenerMap.put((object) ircl, (object) connectionListenerAdapter);
        this.node.addConnectionListener((IRemoteConnectionListener) connectionListenerAdapter, num != 0);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeConnectionListener(IRemoteConnectionListener ircl)
    {
      NetworkTableConnectionListenerAdapter connectionListenerAdapter = (NetworkTableConnectionListenerAdapter) this.connectionListenerMap.get((object) ircl);
      if (connectionListenerAdapter == null)
        return;
      this.node.removeConnectionListener((IRemoteConnectionListener) connectionListenerAdapter);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addTableListener(ITableListener itl)
    {
      this.addTableListener(itl, false);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addTableListener(string str, ITableListener itl, bool b)
    {
      int num = b ? 1 : 0;
      List list = (List) this.listenerMap.get((object) itl);
      if (list == null)
      {
        list = new List();
        this.listenerMap.put((object) itl, (object) list);
      }
      NetworkTableKeyListenerAdapter keyListenerAdapter = new NetworkTableKeyListenerAdapter(str, this.absoluteKeyCache.get(str), this, itl);
      list.add((object) keyListenerAdapter);
      this.node.addTableListener((ITableListener) keyListenerAdapter, num != 0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubTableListener(ITableListener itl)
    {
      List list = (List) this.listenerMap.get((object) itl);
      if (list == null)
      {
        list = new List();
        this.listenerMap.put((object) itl, (object) list);
      }
      NetworkTableSubListenerAdapter subListenerAdapter = new NetworkTableSubListenerAdapter(this.path, this, itl);
      list.add((object) subListenerAdapter);
      this.node.addTableListener((ITableListener) subListenerAdapter, true);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeTableListener(ITableListener itl)
    {
      List list = (List) this.listenerMap.get((object) itl);
      if (list == null)
        return;
      for (int i = 0; i < list.size(); ++i)
        this.node.removeTableListener((ITableListener) list.get(i));
      list.clear();
    }

    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    private NetworkTableEntry getEntry([In] string obj0)
    {
      return this.entryCache.get(obj0);
    }

    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual ITable getSubTable(string str)
    {
      return this.provider.getTable(this.absoluteKeyCache.get(str));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsKey(string str)
    {
      return (this.node.containsKey(this.absoluteKeyCache.get(str)) ? 1 : 0) != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool containsSubTable(string str)
    {
      string str1 = new StringBuilder().append(this.absoluteKeyCache.get(str)).append('/').toString();
      List list = this.node.getEntryStore().keys();
      for (int i = 0; i < list.size(); ++i)
      {
        if (String.instancehelper_startsWith((string) list.get(i), str1))
          return true;
      }
      return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putString(string str1, string str2)
    {
      this.putValue(str1, (object) str2);
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString(string str)
    {
      return this.node.getString(this.absoluteKeyCache.get(str));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getString(string str1, string str2)
    {
      string @string;
      try
      {
        @string = this.node.getString(this.absoluteKeyCache.get(str1));
      }
      catch (TableKeyNotDefinedException ex)
      {
        goto label_3;
      }
      return @string;
label_3:
      return str2;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putBoolean(string str, bool b)
    {
      int num = b ? 1 : 0;
      this.putValue(str, num == 0 ? (object) Boolean.FALSE : (object) Boolean.TRUE);
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getBoolean(string str)
    {
      return (this.node.getBoolean(this.absoluteKeyCache.get(str)) ? 1 : 0) != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getBoolean(string str, bool b)
    {
      int num1 = b ? 1 : 0;
      int num2;
      try
      {
        num2 = this.node.getBoolean(this.absoluteKeyCache.get(str)) ? 1 : 0;
      }
      catch (TableKeyNotDefinedException ex)
      {
        goto label_4;
      }
      return num2 != 0;
label_4:
      return num1 != 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void retrieveValue(string str, object obj)
    {
      this.node.retrieveValue(this.absoluteKeyCache.get(str), obj);
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValue(string str)
    {
      return this.node.getValue(this.absoluteKeyCache.get(str));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getValue(string str, object obj)
    {
      object obj1;
      try
      {
        obj1 = this.node.getValue(this.absoluteKeyCache.get(str));
      }
      catch (TableKeyNotDefinedException ex)
      {
        goto label_3;
      }
      return obj1;
label_3:
      return obj;
    }

    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putInt(string str, int i)
    {
      this.putNumber(str, (double) i);
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getInt(string str)
    {
      return ByteCodeHelper.d2i(this.getNumber(str));
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getInt(string str, int i)
    {
      int num;
      try
      {
        num = ByteCodeHelper.d2i(this.getNumber(str));
      }
      catch (NoSuchElementException ex)
      {
        goto label_3;
      }
      return num;
label_3:
      return i;
    }

    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void putDouble(string str, double d)
    {
      this.putNumber(str, d);
    }

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDouble(string str)
    {
      return this.getNumber(str);
    }

    [Obsolete]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDouble(string str, double d)
    {
      return this.getNumber(str, d);
    }

    [InnerClass]
    [SourceFile(null)]
    [Modifiers]
    internal sealed class EntryCache : Object
    {
      [Modifiers]
      private Hashtable cache;
      [Modifiers]
      private string path;
      [Modifiers]
      internal NetworkTable this\u00240;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EntryCache([In] NetworkTable obj0, [In] string obj1)
      {
        base.\u002Ector();
        NetworkTable.EntryCache entryCache = this;
        this.cache = new Hashtable();
        this.path = obj1;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual NetworkTableEntry get([In] string obj0)
      {
        NetworkTableEntry networkTableEntry = (NetworkTableEntry) this.cache.get((object) obj0);
        if (networkTableEntry == null)
        {
          networkTableEntry = NetworkTable.access\u0024100(this.this\u00240).getEntryStore().getEntry(NetworkTable.access\u0024000(this.this\u00240).get(obj0));
          if (networkTableEntry != null)
            this.cache.put((object) obj0, (object) networkTableEntry);
        }
        return networkTableEntry;
      }
    }

    [InnerClass]
    [SourceFile(null)]
    [Modifiers]
    internal sealed class NetworkTableKeyCache : StringCache
    {
      [Modifiers]
      private string path;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public NetworkTableKeyCache([In] string obj0)
      {
        NetworkTable.NetworkTableKeyCache networkTableKeyCache = this;
        this.path = obj0;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string calc([In] string obj0)
      {
        return new StringBuilder().append(this.path).append('/').append(obj0).toString();
      }
    }
  }
}
