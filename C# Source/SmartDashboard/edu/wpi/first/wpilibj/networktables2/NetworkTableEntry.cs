// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.NetworkTableEntry
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.connection;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;
using System.Threading;

namespace edu.wpi.first.wpilibj.networktables2
{
  [SourceFile(null)]
  public class NetworkTableEntry : Object
  {
    public const char UNKNOWN_ID = '\xFFFF';
    private char id;
    private char sequenceNumber;
    internal string __\u003C\u003Ename;
    private NetworkTableEntryType type;
    private object value;
    private volatile bool isNew;
    private volatile bool isDirty;
    private const char HALF_OF_CHAR = '耀';

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
    public NetworkTableEntry(string str, NetworkTableEntryType ntet, object obj)
      : this(char.MaxValue, str, char.MinValue, ntet, obj)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableEntry(char ch1, string str, char ch2, NetworkTableEntryType ntet, object obj)
    {
      int num1 = (int) ch1;
      int num2 = (int) ch2;
      base.\u002Ector();
      NetworkTableEntry networkTableEntry = this;
      this.isNew = true;
      this.isDirty = false;
      Thread.MemoryBarrier();
      this.id = (char) num1;
      this.__\u003C\u003Ename = str;
      this.sequenceNumber = (char) num2;
      this.type = ntet;
      this.value = obj;
    }

    public virtual void clearId()
    {
      this.id = char.MaxValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireListener(AbstractNetworkTableEntryStore.TableListenerManager antestlm)
    {
      antestlm.fireTableListeners(this.__\u003C\u003Ename, this.value, this.isNew);
      this.isNew = false;
      Thread.MemoryBarrier();
    }

    public virtual NetworkTableEntryType getType()
    {
      return this.type;
    }

    public virtual char getSequenceNumber()
    {
      return this.sequenceNumber;
    }

    public virtual object getValue()
    {
      return this.value;
    }

    public virtual void forcePut(char ch, object obj)
    {
      int num = (int) ch;
      this.value = obj;
      this.sequenceNumber = (char) num;
    }

    public virtual char getId()
    {
      return this.id;
    }

    public virtual bool putValue(char ch, object obj)
    {
      int num = (int) ch;
      if (((int) this.sequenceNumber >= num || num - (int) this.sequenceNumber >= 32768) && ((int) this.sequenceNumber <= num || (int) this.sequenceNumber - num <= 32768))
        return false;
      this.value = obj;
      this.sequenceNumber = (char) num;
      return true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void forcePut(char ch, NetworkTableEntryType ntet, object obj)
    {
      int num = (int) ch;
      this.type = ntet;
      this.forcePut((char) num, obj);
    }

    public virtual void makeDirty()
    {
      this.isDirty = true;
      Thread.MemoryBarrier();
    }

    public virtual void makeClean()
    {
      this.isDirty = false;
      Thread.MemoryBarrier();
    }

    public virtual bool isDirty()
    {
      return this.isDirty;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendValue(DataOutputStream dos)
    {
      this.type.sendValue(this.value, dos);
    }

    [Throws(new string[] {"java.lang.IllegalStateException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setId(char ch)
    {
      int num = (int) ch;
      if ((int) this.id != (int) ushort.MaxValue)
      {
        string str = "Cannot set the Id of a table entry that already has a valid id";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException(str);
      }
      else
        this.id = (char) num;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void send(NetworkTableConnection ntc)
    {
      ntc.sendEntryAssignment(this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append("Network Table ").append(this.type.__\u003C\u003Ename).append(" entry: ").append(this.__\u003C\u003Ename).append(": ").append((int) this.getId()).append(" - ").append((int) this.getSequenceNumber()).append(" - ").append(this.getValue()).toString();
    }
  }
}
