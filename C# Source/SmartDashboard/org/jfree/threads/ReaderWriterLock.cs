// Decompiled with JetBrains decompiler
// Type: org.jfree.threads.ReaderWriterLock
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.threads
{
  public class ReaderWriterLock : Object
  {
    private ArrayList waiters;

    [LineNumberTable(new byte[] {(byte) 43, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReaderWriterLock()
    {
      base.\u002Ector();
      ReaderWriterLock readerWriterLock = this;
      this.waiters = new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 108, (byte) 98, (byte) 104, (byte) 108, (byte) 105, (byte) 130, (byte) 100, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getIndex([In] Thread obj0)
    {
      Iterator iterator = this.waiters.iterator();
      int num = 0;
      while (iterator.hasNext())
      {
        if (((ReaderWriterLock.ReaderWriterNode) iterator.next()).t == obj0)
          return num;
        ++num;
      }
      return -1;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 108, (byte) 98, (byte) 104, (byte) 108, (byte) 105, (byte) 130, (byte) 100, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int firstWriter()
    {
      Iterator iterator = this.waiters.iterator();
      int num = 0;
      while (iterator.hasNext())
      {
        if (((ReaderWriterLock.ReaderWriterNode) iterator.next()).state == 1)
          return num;
        ++num;
      }
      return int.MaxValue;
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 102, (byte) 104, (byte) 100, (byte) 105, (byte) 175, (byte) 146, (byte) 143, (byte) 253, (byte) 69, (byte) 226, (byte) 61, (byte) 98, (byte) 111, (byte) 113, (byte) 130, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void lockRead()
    {
      Thread thread = Thread.currentThread();
      int index = this.getIndex(thread);
      ReaderWriterLock.ReaderWriterNode readerWriterNode;
      if (index == -1)
      {
        readerWriterNode = new ReaderWriterLock.ReaderWriterNode(thread, 0, (ReaderWriterLock.\u0031) null);
        this.waiters.add((object) readerWriterNode);
      }
      else
        readerWriterNode = (ReaderWriterLock.ReaderWriterNode) this.waiters.get(index);
      while (this.getIndex(thread) > this.firstWriter())
      {
        Exception exception1;
        try
        {
          Object.instancehelper_wait((object) this);
          continue;
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
            throw;
          else
            exception1 = (Exception) m0;
        }
        Exception exception2 = exception1;
        System.get_err().println("ReaderWriterLock.lockRead(): exception.");
        System.get_err().print(Throwable.instancehelper_getMessage((Exception) exception2));
      }
      ++readerWriterNode.nAcquires;
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 102, (byte) 104, (byte) 100, (byte) 105, (byte) 175, (byte) 114, (byte) 104, (byte) 144, (byte) 135, (byte) 137, (byte) 253, (byte) 69, (byte) 226, (byte) 61, (byte) 98, (byte) 111, (byte) 113, (byte) 130, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void lockWrite()
    {
      Thread thread = Thread.currentThread();
      int index = this.getIndex(thread);
      ReaderWriterLock.ReaderWriterNode readerWriterNode;
      if (index == -1)
      {
        readerWriterNode = new ReaderWriterLock.ReaderWriterNode(thread, 1, (ReaderWriterLock.\u0031) null);
        this.waiters.add((object) readerWriterNode);
      }
      else
      {
        readerWriterNode = (ReaderWriterLock.ReaderWriterNode) this.waiters.get(index);
        if (readerWriterNode.state == 0)
        {
          string str = "Upgrade lock";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new IllegalArgumentException(str);
        }
        else
          readerWriterNode.state = 1;
      }
      while (this.getIndex(thread) != 0)
      {
        Exception exception1;
        try
        {
          Object.instancehelper_wait((object) this);
          continue;
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
            throw;
          else
            exception1 = (Exception) m0;
        }
        Exception exception2 = exception1;
        System.get_err().println("ReaderWriterLock.lockWrite(): exception.");
        System.get_err().print(Throwable.instancehelper_getMessage((Exception) exception2));
      }
      ++readerWriterNode.nAcquires;
    }

    [LineNumberTable(new byte[] {(byte) 109, (byte) 102, (byte) 104, (byte) 105, (byte) 144, (byte) 114, (byte) 110, (byte) 104, (byte) 141, (byte) 104})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void unlock()
    {
      int index = this.getIndex(Thread.currentThread());
      if (index > this.firstWriter())
      {
        string str = "Lock not held";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ReaderWriterLock.ReaderWriterNode readerWriterNode = (ReaderWriterLock.ReaderWriterNode) this.waiters.get(index);
        --readerWriterNode.nAcquires;
        if (readerWriterNode.nAcquires == 0)
          this.waiters.remove(index);
        Object.instancehelper_notifyAll((object) this);
      }
    }

    [InnerClass]
    [SourceFile("ReaderWriterLock.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [SourceFile("ReaderWriterLock.java")]
    [Modifiers]
    internal sealed class ReaderWriterNode : Object
    {
      protected internal const int READER = 0;
      protected internal const int WRITER = 1;
      protected internal Thread t;
      protected internal int state;
      protected internal int nAcquires;

      [LineNumberTable((ushort) 56)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ReaderWriterNode([In] Thread obj0, [In] int obj1, [In] ReaderWriterLock.\u0031 obj2)
        : this(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private ReaderWriterNode([In] Thread obj0, [In] int obj1)
      {
        base.\u002Ector();
        ReaderWriterLock.ReaderWriterNode readerWriterNode = this;
        this.t = obj0;
        this.state = obj1;
        this.nAcquires = 0;
      }
    }
  }
}
