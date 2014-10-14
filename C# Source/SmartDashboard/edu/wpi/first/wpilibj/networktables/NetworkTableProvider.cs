// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableProvider
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableProvider"})]
  [SourceFile(null)]
  public class NetworkTableProvider : Object, ITableProvider
  {
    [Modifiers]
    private NetworkTableNode node;
    [Modifiers]
    private Hashtable tables;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableProvider(NetworkTableNode ntn)
    {
      base.\u002Ector();
      NetworkTableProvider networkTableProvider = this;
      this.tables = new Hashtable();
      this.node = ntn;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ITable getRootTable()
    {
      return this.getTable("");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ITable getTable(string str)
    {
      if (this.tables.containsKey((object) str))
        return (ITable) this.tables.get((object) str);
      NetworkTable networkTable = new NetworkTable(str, this);
      this.tables.put((object) str, (object) networkTable);
      return (ITable) networkTable;
    }

    public virtual NetworkTableNode getNode()
    {
      return this.node;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      this.node.close();
    }
  }
}
