// Decompiled with JetBrains decompiler
// Type: org.jfree.base.log.MemoryUsageMessage
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.@base.log;
using System.Runtime.CompilerServices;

namespace org.jfree.@base.log
{
  public class MemoryUsageMessage : Object
  {
    [Modifiers]
    private string message;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MemoryUsageMessage(string message)
    {
      base.\u002Ector();
      MemoryUsageMessage memoryUsageMessage = this;
      this.message = message;
    }

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append(this.message).append("Free: ").append(Runtime.getRuntime().freeMemory()).append("; ").append("Total: ").append(Runtime.getRuntime().totalMemory()).toString();
    }
  }
}
