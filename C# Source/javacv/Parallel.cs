// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.Parallel
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class Parallel : Object
  {
    internal static int __\u003C\u003EnumCores = Runtime.getRuntime().availableProcessors();
    [Modifiers]
    private static ExecutorService threadPool = Executors.newCachedThreadPool();

    [Modifiers]
    public static int numCores
    {
      [HideFromJava] get
      {
        return Parallel.__\u003C\u003EnumCores;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 143})]
    static Parallel()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 232, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Parallel()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 106, (byte) 103, (byte) 102, (byte) 114, (byte) 117, (byte) 99, (byte) 238, (byte) 60, (byte) 230, (byte) 74, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void loop(int from, int to, int numThreads, Parallel.Looper looper)
    {
      int length = Math.min(to - from, numThreads);
      Runnable[] runnableArray = new Runnable[length];
      for (int index = 0; index < length; ++index)
      {
        int num1 = (to - from) * index;
        int num2 = length;
        int num3 = -1;
        int num4 = (num2 != num3 ? num1 / num2 : -num1) + from;
        int num5 = (to - from) * (index + 1);
        int num6 = length;
        int num7 = -1;
        int num8 = (num6 != num7 ? num5 / num6 : -num5) + from;
        int num9 = index;
        runnableArray[index] = (Runnable) new Parallel\u00241(looper, num4, num8, num9);
      }
      Parallel.run(runnableArray);
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void loop(int from, int to, Parallel.Looper looper)
    {
      Parallel.loop(from, to, Parallel.__\u003C\u003EnumCores, looper);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 179, (byte) 101, (byte) 104, (byte) 161, (byte) 104, (byte) 103, (byte) 48, (byte) 198, (byte) 130, (byte) 117, (byte) 105, (byte) 8, (byte) 250, (byte) 71, (byte) 2, (byte) 98, (byte) 163, (byte) 99, (byte) 117, (byte) 41, (byte) 168, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void run(params Runnable[] runnables)
    {
      if (runnables.Length == 1)
      {
        runnables[0].run();
      }
      else
      {
        Future[] futureArray1 = new Future[runnables.Length];
        for (int index = 0; index < runnables.Length; ++index)
          futureArray1[index] = Parallel.threadPool.submit(runnables[index]);
        Exception exception1 = (Exception) null;
        Exception exception2;
        try
        {
          Future[] futureArray2 = futureArray1;
          int length = futureArray2.Length;
          for (int index = 0; index < length; ++index)
          {
            Future future = futureArray2[index];
            if (!future.isDone())
              future.get();
          }
          goto label_14;
        }
        catch (Exception ex)
        {
          int num = 0;
          exception2 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
        exception1 = exception2;
label_14:
        if (exception1 == null)
          return;
        Future[] futureArray3 = futureArray1;
        int length1 = futureArray3.Length;
        for (int index = 0; index < length1; ++index)
          futureArray3[index].cancel(true);
        Exception exception3 = exception1;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(exception3);
      }
    }

    [InnerClass]
    [SourceFile("Parallel.java")]
    public interface Looper
    {
      void loop(int i1, int i2, int i3);
    }
  }
}
