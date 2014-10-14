// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.type.NetworkTableEntryType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.type
{
  [SourceFile(null)]
  public abstract class NetworkTableEntryType : Object
  {
    internal byte __\u003C\u003Eid;
    internal string __\u003C\u003Ename;

    [Modifiers]
    public byte id
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eid;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eid = value;
      }
    }

    [Modifiers]
    public string name
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Ename;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Ename = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal NetworkTableEntryType(byte b, string str)
    {
      int num = (int) (sbyte) b;
      base.\u002Ector();
      NetworkTableEntryType networkTableEntryType = this;
      this.__\u003C\u003Eid = (byte) num;
      this.__\u003C\u003Ename = str;
    }

    [Throws(new string[] {"java.io.IOException"})]
    public abstract void sendValue(object obj, DataOutputStream dos);

    [Throws(new string[] {"java.io.IOException"})]
    public abstract object readValue(DataInputStream dis);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append("NetworkTable type: ").append(this.__\u003C\u003Ename).toString();
    }
  }
}
