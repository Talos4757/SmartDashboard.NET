// Decompiled with JetBrains decompiler
// Type: org.jfree.base.log.PadMessage
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.@base.log;
using System.Runtime.CompilerServices;

namespace org.jfree.@base.log
{
  public class PadMessage : Object
  {
    [Modifiers]
    private object text;
    [Modifiers]
    private int length;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PadMessage(object message, int length)
    {
      base.\u002Ector();
      PadMessage padMessage = this;
      this.text = message;
      this.length = length;
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 102, (byte) 109, (byte) 110, (byte) 115, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(this.text);
      if (stringBuffer.length() < this.length)
      {
        char[] chArray = new char[this.length - stringBuffer.length()];
        Arrays.fill(chArray, ' ');
        stringBuffer.append(chArray);
      }
      return stringBuffer.toString();
    }
  }
}
