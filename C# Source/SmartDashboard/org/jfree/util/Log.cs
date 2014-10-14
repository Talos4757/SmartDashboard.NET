// Decompiled with JetBrains decompiler
// Type: org.jfree.util.Log
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class Log : Object
  {
    private int debuglevel;
    private LogTarget[] logTargets;
    private HashMap logContexts;
    private static Log singleton;

    [LineNumberTable(new byte[] {(byte) 127, (byte) 104, (byte) 107, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Log()
    {
      base.\u002Ector();
      Log log = this;
      this.logContexts = new HashMap();
      this.logTargets = new LogTarget[0];
      this.debuglevel = 100;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void info(object message)
    {
      Log.log(2, message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 218, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void warn(object message, Exception e)
    {
      Log.log(1, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 170, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void debug(object message)
    {
      Log.log(3, message);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void log(int level, object message)
    {
      Log.getInstance().doLog(level, message);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 28, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void log(int level, object message, Exception e)
    {
      Log.getInstance().doLog(level, message, e);
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 95, (byte) 108, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Log getInstance()
    {
      lock ((object) ClassLiteral<Log>.Value)
      {
        if (Log.singleton == null)
          Log.singleton = new Log();
        return Log.singleton;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 100, (byte) 131, (byte) 105, (byte) 108, (byte) 105, (byte) 8, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void doLog(int level, object message)
    {
      if (level > 3)
        level = 3;
      if (level > this.debuglevel)
        return;
      for (int index = 0; index < this.logTargets.Length; ++index)
        this.logTargets[index].log(level, message);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 100, (byte) 163, (byte) 105, (byte) 108, (byte) 105, (byte) 9, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void doLog(int level, object message, Exception e)
    {
      if (level > 3)
        level = 3;
      if (level > this.debuglevel)
        return;
      for (int index = 0; index < this.logTargets.Length; ++index)
        this.logTargets[index].log(level, message, e);
    }

    public virtual int getDebuglevel()
    {
      return this.debuglevel;
    }

    [LineNumberTable((ushort) 492)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static LogContext createContext(string context)
    {
      return Log.getInstance().internalCreateContext(context);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 133, (byte) 104, (byte) 114, (byte) 99, (byte) 103, (byte) 142, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual LogContext internalCreateContext(string context)
    {
      LogContext logContext;
      lock (this)
      {
        LogContext local_1 = (LogContext) this.logContexts.get((object) context);
        if (local_1 == null)
        {
          local_1 = new LogContext(context);
          this.logContexts.put((object) context, (object) local_1);
        }
        logContext = local_1;
      }
      return logContext;
    }

    [Modifiers]
    protected internal static void defineLog(Log log)
    {
      lock ((object) ClassLiteral<Log>.Value)
        Log.singleton = log;
    }

    protected internal virtual void setDebuglevel(int debuglevel)
    {
      this.debuglevel = debuglevel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 99, (byte) 139, (byte) 111, (byte) 117, (byte) 106, (byte) 103})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addTarget(LogTarget target)
    {
      if (target == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        LogTarget[] logTargetArray = new LogTarget[this.logTargets.Length + 1];
        ByteCodeHelper.arraycopy((object) this.logTargets, 0, (object) logTargetArray, 0, this.logTargets.Length);
        logTargetArray[this.logTargets.Length] = target;
        this.logTargets = logTargetArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 132, (byte) 99, (byte) 139, (byte) 102, (byte) 114, (byte) 136, (byte) 108, (byte) 119})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void removeTarget(LogTarget target)
    {
      if (target == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        ArrayList arrayList = new ArrayList();
        arrayList.addAll((Collection) Arrays.asList((object[]) this.logTargets));
        arrayList.remove((object) target);
        LogTarget[] logTargetArray = new LogTarget[arrayList.size()];
        this.logTargets = (LogTarget[]) arrayList.toArray((object[]) logTargetArray);
      }
    }

    [LineNumberTable((ushort) 263)]
    public virtual LogTarget[] getTargets()
    {
      return (LogTarget[]) this.logTargets.Clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 99, (byte) 139, (byte) 112})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void replaceTargets(LogTarget target)
    {
      if (target == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        LogTarget[] logTargetArray = new LogTarget[1];
        int index = 0;
        LogTarget logTarget = target;
        logTargetArray[index] = logTarget;
        this.logTargets = logTargetArray;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 180, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void debug(object message, Exception e)
    {
      Log.log(3, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void info(object message, Exception e)
    {
      Log.log(2, message, e);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 208, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void warn(object message)
    {
      Log.log(1, message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void error(object message)
    {
      Log.log(0, message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void error(object message, Exception e)
    {
      Log.log(0, message, e);
    }

    public virtual void init()
    {
    }

    [LineNumberTable((ushort) 440)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isDebugEnabled()
    {
      return Log.getInstance().getDebuglevel() >= 3;
    }

    [LineNumberTable((ushort) 450)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isInfoEnabled()
    {
      return Log.getInstance().getDebuglevel() >= 2;
    }

    [LineNumberTable((ushort) 460)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isWarningEnabled()
    {
      return Log.getInstance().getDebuglevel() >= 1;
    }

    [LineNumberTable((ushort) 470)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isErrorEnabled()
    {
      return Log.getInstance().getDebuglevel() >= 0;
    }

    [LineNumberTable((ushort) 481)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static LogContext createContext(Class context)
    {
      return Log.createContext(context.getName());
    }

    [InnerClass]
    [SourceFile("Log.java")]
    public class SimpleMessage : Object
    {
      private string message;
      private object[] param;

      [LineNumberTable(new byte[] {(byte) 72, (byte) 104, (byte) 103, (byte) 126})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SimpleMessage(string message, object param1, object param2, object param3, object param4)
      {
        base.\u002Ector();
        Log.SimpleMessage simpleMessage = this;
        this.message = message;
        object[] objArray = new object[4];
        int index1 = 0;
        object obj1 = param1;
        objArray[index1] = obj1;
        int index2 = 1;
        object obj2 = param2;
        objArray[index2] = obj2;
        int index3 = 2;
        object obj3 = param3;
        objArray[index3] = obj3;
        int index4 = 3;
        object obj4 = param4;
        objArray[index4] = obj4;
        this.param = objArray;
      }

      [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103, (byte) 112})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SimpleMessage(string message, object param1)
      {
        base.\u002Ector();
        Log.SimpleMessage simpleMessage = this;
        this.message = message;
        object[] objArray = new object[1];
        int index = 0;
        object obj = param1;
        objArray[index] = obj;
        this.param = objArray;
      }

      [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 103, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SimpleMessage(string message, object param1, object param2)
      {
        base.\u002Ector();
        Log.SimpleMessage simpleMessage = this;
        this.message = message;
        object[] objArray = new object[2];
        int index1 = 0;
        object obj1 = param1;
        objArray[index1] = obj1;
        int index2 = 1;
        object obj2 = param2;
        objArray[index2] = obj2;
        this.param = objArray;
      }

      [LineNumberTable(new byte[] {(byte) 56, (byte) 104, (byte) 103, (byte) 121})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SimpleMessage(string message, object param1, object param2, object param3)
      {
        base.\u002Ector();
        Log.SimpleMessage simpleMessage = this;
        this.message = message;
        object[] objArray = new object[3];
        int index1 = 0;
        object obj1 = param1;
        objArray[index1] = obj1;
        int index2 = 1;
        object obj2 = param2;
        objArray[index2] = obj2;
        int index3 = 2;
        object obj3 = param3;
        objArray[index3] = obj3;
        this.param = objArray;
      }

      [LineNumberTable(new byte[] {(byte) 83, (byte) 104, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SimpleMessage(string message, object[] param)
      {
        base.\u002Ector();
        Log.SimpleMessage simpleMessage = this;
        this.message = message;
        this.param = param;
      }

      [LineNumberTable(new byte[] {(byte) 94, (byte) 102, (byte) 109, (byte) 104, (byte) 108, (byte) 47, (byte) 198})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string toString()
      {
        StringBuffer stringBuffer = new StringBuffer();
        stringBuffer.append(this.message);
        if (this.param != null)
        {
          for (int index = 0; index < this.param.Length; ++index)
            stringBuffer.append(this.param[index]);
        }
        return stringBuffer.toString();
      }
    }
  }
}
