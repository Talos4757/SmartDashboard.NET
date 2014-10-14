// Decompiled with JetBrains decompiler
// Type: org.junit.runner.notification.Failure
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using org.junit.runner;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.runner.notification
{
  public class Failure : Object
  {
    [Modifiers]
    private Description fDescription;
    [Modifiers]
    private Exception fThrownException;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Failure(Description description, Exception thrownException)
    {
      base.\u002Ector();
      Failure failure = this;
      this.fThrownException = thrownException;
      this.fDescription = description;
    }

    public virtual Description getDescription()
    {
      return this.fDescription;
    }

    public virtual Exception getException()
    {
      return this.fThrownException;
    }

    [LineNumberTable((ushort) 33)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getTestHeader()
    {
      return this.fDescription.getDisplayName();
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 102, (byte) 103, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getTrace()
    {
      StringWriter stringWriter = new StringWriter();
      Throwable.instancehelper_printStackTrace(this.getException(), new PrintWriter((Writer) stringWriter));
      return stringWriter.getBuffer().toString();
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 102, (byte) 127, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(new StringBuilder().append(this.getTestHeader()).append(": ").append(Throwable.instancehelper_getMessage(this.fThrownException)).toString());
      return stringBuffer.toString();
    }

    [LineNumberTable((ushort) 75)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getMessage()
    {
      return Throwable.instancehelper_getMessage(this.getException());
    }
  }
}
