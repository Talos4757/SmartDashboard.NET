// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Loader$2
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacpp
{
  [InnerClass]
  [EnclosingMethod("com.googlecode.javacpp.Loader", null, null)]
  [SourceFile("Loader.java")]
  internal sealed class Loader\u00242 : Thread
  {
    [HideFromJava]
    static Loader\u00242()
    {
      Thread.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 365)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Loader\u00242()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 253, (byte) 108, (byte) 193, (byte) 102, (byte) 127, (byte) 11, (byte) 108, (byte) 113, (byte) 113, (byte) 113, (byte) 190, (byte) 2, (byte) 97, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      if (Loader.loadedLibraries.isEmpty())
        return;
      IOException ioException;
      try
      {
        LinkedList linkedList = new LinkedList();
        linkedList.add((object) new StringBuilder().append(System.getProperty("java.home")).append("/bin/java").toString());
        linkedList.add((object) "-classpath");
        linkedList.add((object) System.getProperty("java.class.path"));
        linkedList.add((object) ((Class) ClassLiteral<Loader>.Value).getName());
        linkedList.addAll(Loader.loadedLibraries.values());
        new ProcessBuilder((List) linkedList).start();
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      Throwable.instancehelper_printStackTrace((Exception) ioException);
    }
  }
}
