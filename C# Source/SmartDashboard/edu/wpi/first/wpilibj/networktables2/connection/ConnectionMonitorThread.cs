// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.connection.ConnectionMonitorThread
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.thread;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.connection
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.thread.PeriodicRunnable"})]
  [SourceFile(null)]
  public class ConnectionMonitorThread : Object, PeriodicRunnable
  {
    [Modifiers]
    private ConnectionAdapter adapter;
    [Modifiers]
    private NetworkTableConnection connection;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConnectionMonitorThread(ConnectionAdapter ca, NetworkTableConnection ntc)
    {
      base.\u002Ector();
      ConnectionMonitorThread connectionMonitorThread = this;
      this.adapter = ca;
      this.connection = ntc;
    }

    [Throws(new string[] {"java.lang.InterruptedException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      BadMessageException bme;
      IOException ioe;
      try
      {
        try
        {
          this.connection.read(this.adapter);
          return;
        }
        catch (BadMessageException ex)
        {
          int num = 1;
          bme = (BadMessageException) ByteCodeHelper.MapException<BadMessageException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (IOException ex)
      {
        int num = 1;
        ioe = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_4;
      }
      this.adapter.badMessage(bme);
      return;
label_4:
      this.adapter.ioException(ioe);
    }
  }
}
