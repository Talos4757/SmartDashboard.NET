﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.camera.VideoStreamExtension$BGThread
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
  public class VideoStreamExtension\u0024BGThread : Thread
  {
    internal bool destroyed;
    [Modifiers]
    internal object this\u00240;

    [HideFromJava]
    static VideoStreamExtension\u0024BGThread()
    {
      Thread.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 129, (byte) 113, (byte) 103, (byte) 237, (byte) 61, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VideoStreamExtension\u0024BGThread(object vse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(vse, __typeref (VideoStreamExtension\u0024BGThread), "edu.wpi.first.smartdashboard.camera.VideoStreamExtension");
      this.this\u00240 = vse;
      base.\u002Ector("Video Stream Background");
      VideoStreamExtension\u0024BGThread extensionBgThread = this;
      this.destroyed = false;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 241, (byte) 91})]
    public virtual void run()
    {
      if (this.destroyed)
        return;
      object obj = this.this\u00240;
      throw new NoClassDefFoundError("edu.wpi.first.smartdashboard.camera.VideoStreamExtension");
    }

    public virtual void destroy()
    {
      this.destroyed = true;
    }
  }
}
