// Decompiled with JetBrains decompiler
// Type: org.jfree.util.StackableException
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Serializable]
  public abstract class StackableException : Exception
  {
    private Exception parent;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackableException()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 30, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackableException(string message, Exception ex)
    {
      base.\u002Ector(message);
      StackableException stackableException = this;
      this.parent = ex;
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StackableException(string message)
    {
      base.\u002Ector(message);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StackableException([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    public virtual Exception getParent()
    {
      return this.parent;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 103, (byte) 104, (byte) 107, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void printStackTrace(PrintStream stream)
    {
      ((Throwable) this).printStackTrace(stream);
      if (this.getParent() == null)
        return;
      stream.println("ParentException: ");
      Throwable.instancehelper_printStackTrace((Exception) this.getParent(), stream);
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 103, (byte) 104, (byte) 107, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void printStackTrace(PrintWriter writer)
    {
      ((Throwable) this).printStackTrace(writer);
      if (this.getParent() == null)
        return;
      writer.println("ParentException: ");
      Throwable.instancehelper_printStackTrace((Exception) this.getParent(), writer);
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 108, (byte) 107, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void printStackTrace()
    {
      lock (System.get_err())
        this.printStackTrace(System.get_err());
    }
  }
}
