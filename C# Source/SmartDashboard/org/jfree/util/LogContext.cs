// Decompiled with JetBrains decompiler
// Type: org.jfree.util.LogContext
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class LogContext : Object
  {
    private string contextPrefix;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogContext(string contextPrefix)
    {
      base.\u002Ector();
      LogContext logContext = this;
      this.contextPrefix = contextPrefix;
    }

    [LineNumberTable((ushort) 71)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isDebugEnabled()
    {
      return (Log.isDebugEnabled() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void debug(object message)
    {
      this.log(3, message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 104, (byte) 190, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void log(int level, object message)
    {
      if (this.contextPrefix != null)
        Log.getInstance().doLog(level, (object) new Log.SimpleMessage(this.contextPrefix, (object) ":", message));
      else
        Log.getInstance().doLog(level, message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 96, (byte) 104, (byte) 255, (byte) 0, (byte) 69, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void log(int level, object message, Exception e)
    {
      if (this.contextPrefix != null)
        Log.getInstance().doLog(level, (object) new Log.SimpleMessage(this.contextPrefix, (object) ":", message), e);
      else
        Log.getInstance().doLog(level, message, e);
    }

    [LineNumberTable((ushort) 81)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isInfoEnabled()
    {
      return (Log.isInfoEnabled() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 91)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isWarningEnabled()
    {
      return (Log.isWarningEnabled() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 101)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isErrorEnabled()
    {
      return (Log.isErrorEnabled() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void debug(object message, Exception e)
    {
      this.log(3, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void info(object message)
    {
      this.log(2, message);
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void info(object message, Exception e)
    {
      this.log(2, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void warn(object message)
    {
      this.log(1, message);
    }

    [LineNumberTable(new byte[] {(byte) 109, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void warn(object message, Exception e)
    {
      this.log(1, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void error(object message)
    {
      this.log(0, message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void error(object message, Exception e)
    {
      this.log(0, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 135, (byte) 136, (byte) 115, (byte) 194, (byte) 104, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (this == o)
        return true;
      if (!(o is LogContext))
        return false;
      LogContext logContext = (LogContext) o;
      if (this.contextPrefix != null)
      {
        if (!String.instancehelper_equals(this.contextPrefix, (object) logContext.contextPrefix))
          return false;
      }
      else if (logContext.contextPrefix != null)
        return false;
      return true;
    }

    [LineNumberTable((ushort) 258)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.contextPrefix != null)
        return String.instancehelper_hashCode(this.contextPrefix);
      else
        return 0;
    }
  }
}
