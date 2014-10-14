// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.NetworkTableEntryTypeManager
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.util;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public class NetworkTableEntryTypeManager : Object
  {
    [Modifiers]
    private ByteArrayMap typeMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableEntryTypeManager()
    {
      base.\u002Ector();
      NetworkTableEntryTypeManager entryTypeManager = this;
      this.typeMap = new ByteArrayMap();
      DefaultEntryTypes.registerTypes(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NetworkTableEntryType getType(byte b)
    {
      return (NetworkTableEntryType) this.typeMap.get(b);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void registerType([In] NetworkTableEntryType obj0)
    {
      this.typeMap.put(obj0.__\u003C\u003Eid, (object) obj0);
    }
  }
}
