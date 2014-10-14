// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIMemoryPool
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public abstract class WPIMemoryPool : WPIDisposable
  {
    private int remaining;

    [LineNumberTable((ushort) 8)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIMemoryPool()
    {
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 102, (byte) 103, (byte) 118, (byte) 136})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void removeFromPool(WPIDisposable disposable)
    {
      this.validateDisposed();
      disposable.setPool((WPIMemoryPool) null);
      WPIMemoryPool wpiMemoryPool1 = this;
      int num1 = wpiMemoryPool1.remaining - 1;
      WPIMemoryPool wpiMemoryPool2 = wpiMemoryPool1;
      int num2 = num1;
      wpiMemoryPool2.remaining = num1;
      int num3 = 0;
      if (num2 > num3)
        return;
      this.dispose();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 102, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addToPool(WPIDisposable disposable)
    {
      this.validateDisposed();
      disposable.setPool(this);
      ++this.remaining;
    }
  }
}
