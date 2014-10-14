// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.WriteManager
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.util;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Threading;

namespace edu.wpi.first.wpilibj.networktables2
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.OutgoingEntryReceiver", "edu.wpi.first.wpilibj.networktables2.thread.PeriodicRunnable"})]
  [SourceFile(null)]
  public class WriteManager : Object, OutgoingEntryReceiver, PeriodicRunnable
  {
    [Modifiers]
    private int SLEEP_TIME;
    [Modifiers]
    private int queueSize;
    private object transactionsLock;
    private NTThread thread;
    private NTThreadManager threadManager;
    [Modifiers]
    private AbstractNetworkTableEntryStore entryStore;
    private volatile HalfQueue incomingAssignmentQueue;
    private volatile HalfQueue incomingUpdateQueue;
    private volatile HalfQueue outgoingAssignmentQueue;
    private volatile HalfQueue outgoingUpdateQueue;
    private FlushableOutgoingEntryReceiver receiver;
    private long lastWrite;
    [Modifiers]
    private long keepAliveDelay;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WriteManager(FlushableOutgoingEntryReceiver foer, NTThreadManager nttm, AbstractNetworkTableEntryStore antes, long l)
    {
      base.\u002Ector();
      WriteManager writeManager = this;
      this.SLEEP_TIME = 100;
      this.queueSize = 500;
      this.transactionsLock = (object) new Object();
      this.receiver = foer;
      this.threadManager = nttm;
      this.entryStore = antes;
      this.incomingAssignmentQueue = new HalfQueue(500);
      Thread.MemoryBarrier();
      this.incomingUpdateQueue = new HalfQueue(500);
      Thread.MemoryBarrier();
      this.outgoingAssignmentQueue = new HalfQueue(500);
      Thread.MemoryBarrier();
      this.outgoingUpdateQueue = new HalfQueue(500);
      Thread.MemoryBarrier();
      this.keepAliveDelay = l;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void stop()
    {
      if (this.thread == null)
        return;
      this.thread.stop();
    }

    [Throws(new string[] {"java.lang.InterruptedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      object obj;
      Monitor.Enter(obj = this.transactionsLock);
      // ISSUE: fault handler
      try
      {
        HalfQueue halfQueue1 = this.incomingAssignmentQueue;
        this.incomingAssignmentQueue = this.outgoingAssignmentQueue;
        this.outgoingAssignmentQueue = halfQueue1;
        Thread.MemoryBarrier();
        HalfQueue halfQueue2 = this.incomingUpdateQueue;
        this.incomingUpdateQueue = this.outgoingUpdateQueue;
        this.outgoingUpdateQueue = halfQueue2;
        Thread.MemoryBarrier();
        Monitor.Exit(obj);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
      int num1 = 0;
      int num2 = this.outgoingAssignmentQueue.size();
      object[] objArray1 = this.outgoingAssignmentQueue.__\u003C\u003Earray;
      for (int index = 0; index < num2; ++index)
      {
        NetworkTableEntry nte = (NetworkTableEntry) objArray1[index];
        AbstractNetworkTableEntryStore networkTableEntryStore;
        Monitor.Enter((object) (networkTableEntryStore = this.entryStore));
        // ISSUE: fault handler
        try
        {
          nte.makeClean();
          Monitor.Exit((object) networkTableEntryStore);
        }
        __fault
        {
          Monitor.Exit((object) networkTableEntryStore);
        }
        num1 = 1;
        this.receiver.offerOutgoingAssignment(nte);
      }
      this.outgoingAssignmentQueue.clear();
      int num3 = this.outgoingUpdateQueue.size();
      object[] objArray2 = this.outgoingUpdateQueue.__\u003C\u003Earray;
      for (int index = 0; index < num3; ++index)
      {
        NetworkTableEntry nte = (NetworkTableEntry) objArray2[index];
        lock (this.entryStore)
          nte.makeClean();
        num1 = 1;
        this.receiver.offerOutgoingUpdate(nte);
      }
      this.outgoingUpdateQueue.clear();
      if (num1 != 0)
      {
        this.receiver.flush();
        this.lastWrite = System.currentTimeMillis();
      }
      else if (System.currentTimeMillis() - this.lastWrite > this.keepAliveDelay)
        this.receiver.ensureAlive();
      Thread.sleep(100L);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void start()
    {
      if (this.thread != null)
        this.stop();
      this.lastWrite = System.currentTimeMillis();
      this.thread = this.threadManager.newBlockingPeriodicThread((PeriodicRunnable) this, "Write Manager Thread");
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingAssignment(NetworkTableEntry nte)
    {
      object obj;
      Monitor.Enter(obj = this.transactionsLock);
      // ISSUE: fault handler
      try
      {
        this.incomingAssignmentQueue.queue((object) nte);
        if (this.incomingAssignmentQueue.isFull())
        {
          try
          {
            this.run();
            goto label_6;
          }
          catch (InterruptedException ex)
          {
          }
        }
        else
          goto label_8;
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_6:
      // ISSUE: fault handler
      try
      {
        System.get_err().println("assignment queue overflowed. decrease the rate at which you create new entries or increase the write buffer size");
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_8:
      // ISSUE: fault handler
      try
      {
        Monitor.Exit(obj);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void offerOutgoingUpdate(NetworkTableEntry nte)
    {
      object obj;
      Monitor.Enter(obj = this.transactionsLock);
      // ISSUE: fault handler
      try
      {
        this.incomingUpdateQueue.queue((object) nte);
        if (this.incomingUpdateQueue.isFull())
        {
          try
          {
            this.run();
            goto label_6;
          }
          catch (InterruptedException ex)
          {
          }
        }
        else
          goto label_8;
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_6:
      // ISSUE: fault handler
      try
      {
        System.get_err().println("update queue overflowed. decrease the rate at which you update entries or increase the write buffer size");
      }
      __fault
      {
        Monitor.Exit(obj);
      }
label_8:
      // ISSUE: fault handler
      try
      {
        Monitor.Exit(obj);
      }
      __fault
      {
        Monitor.Exit(obj);
      }
    }
  }
}
