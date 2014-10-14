// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Piper
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util.logging;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacpp
{
  public class Piper : Thread
  {
    [Modifiers]
    private static Logger logger;
    private InputStream @is;
    private OutputStream os;

    [LineNumberTable((ushort) 39)]
    static Piper()
    {
      Thread.__\u003Cclinit\u003E();
      Piper.logger = Logger.getLogger(((Class) ClassLiteral<Piper>.Value).getName());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Piper(InputStream @is, OutputStream os)
    {
      base.\u002Ector();
      Piper piper = this;
      this.@is = @is;
      this.os = os;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 139, (byte) 113, (byte) 223, (byte) 1, (byte) 2, (byte) 97, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      IOException ioException1;
      try
      {
        byte[] numArray = new byte[1024];
        int num;
        while ((num = this.@is.read(numArray)) > 0)
          this.os.write(numArray, 0, num);
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      IOException ioException2 = ioException1;
      Piper.logger.log((Level) Level.SEVERE, "Could not pipe from the InputStream to the OutputStream.", (Exception) ioException2);
    }
  }
}
