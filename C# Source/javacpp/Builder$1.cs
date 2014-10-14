// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Builder$1
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  [InnerClass]
  [Implements(new string[] {"java.io.FilenameFilter"})]
  [EnclosingMethod("com.googlecode.javacpp.Builder", "<init>", "(Ljava.util.Properties;)V")]
  [SourceFile("Builder.java")]
  [Modifiers]
  internal sealed class Builder\u00241 : Object, FilenameFilter
  {
    [Modifiers]
    internal string[] val\u0024jnipath;
    [Modifiers]
    internal Builder this\u00240;

    [LineNumberTable((ushort) 49)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Builder\u00241([In] Builder obj0, [In] string[] obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 114, (byte) 142, (byte) 114, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool accept([In] File obj0, [In] string obj1)
    {
      if (new File(obj0, "jni.h").exists())
        this.val\u0024jnipath[0] = obj0.getAbsolutePath();
      if (new File(obj0, "jni_md.h").exists())
        this.val\u0024jnipath[1] = obj0.getAbsolutePath();
      return (new File(obj0, obj1).isDirectory() ? 1 : 0) != 0;
    }
  }
}
