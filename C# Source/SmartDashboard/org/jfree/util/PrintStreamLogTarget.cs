// Decompiled with JetBrains decompiler
// Type: org.jfree.util.PrintStreamLogTarget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Implements(new string[] {"org.jfree.util.LogTarget", "java.io.Serializable"})]
  [Serializable]
  public class PrintStreamLogTarget : Object, LogTarget, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 6510564403264504688L;
    private PrintStream printStream;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrintStreamLogTarget()
      : this(System.get_out())
    {
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 99, (byte) 139, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrintStreamLogTarget(PrintStream printStream)
    {
      base.\u002Ector();
      PrintStreamLogTarget printStreamLogTarget = this;
      if (printStream == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
        this.printStream = printStream;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PrintStreamLogTarget([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] PrintStreamLogTarget obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 100, (byte) 131, (byte) 114, (byte) 108, (byte) 100, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void log(int level, object message)
    {
      if (level > 3)
        level = 3;
      this.printStream.print(LogTarget.LEVELS[level]);
      this.printStream.println(message);
      if (level >= 3)
        return;
      System.get_out().flush();
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 100, (byte) 131, (byte) 114, (byte) 108, (byte) 108, (byte) 100, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void log(int level, object message, Exception e)
    {
      if (level > 3)
        level = 3;
      this.printStream.print(LogTarget.LEVELS[level]);
      this.printStream.println(message);
      Throwable.instancehelper_printStackTrace((Exception) e, this.printStream);
      if (level >= 3)
        return;
      System.get_out().flush();
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
