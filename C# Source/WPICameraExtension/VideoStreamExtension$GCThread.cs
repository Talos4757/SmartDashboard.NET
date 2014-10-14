// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.camera.VideoStreamExtension$GCThread
// Assembly: WPICameraExtension, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E385C5F-719E-43C1-951E-3EA8390C284D
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPICameraExtension.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.camera
{
  [InnerClass]
  [SourceFile("VideoStreamExtension.java")]
  public class VideoStreamExtension\u0024GCThread : Thread
  {
    internal bool destroyed;
    [Modifiers]
    internal object this\u00240;

    [HideFromJava]
    static VideoStreamExtension\u0024GCThread()
    {
      Thread.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 135, (byte) 81, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VideoStreamExtension\u0024GCThread(object vse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vse, __typeref (VideoStreamExtension\u0024GCThread), "edu.wpi.first.smartdashboard.camera.VideoStreamExtension");
      this.this\u00240 = vse;
      base.\u002Ector();
      VideoStreamExtension\u0024GCThread extensionGcThread = this;
      this.destroyed = false;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 136, (byte) 150, (byte) 34, (byte) 129, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      while (!this.destroyed)
      {
        try
        {
          Thread.sleep(10000L);
          goto label_5;
        }
        catch (InterruptedException ex)
        {
        }
label_5:
        System.gc();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void destroy()
    {
      this.destroyed = true;
      this.interrupt();
    }
  }
}
