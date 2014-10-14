// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.JavaCvErrorCallback$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("com.googlecode.javacv.JavaCvErrorCallback", "call", "(ILjava.lang.String;Ljava.lang.String;Ljava.lang.String;ILcom.googlecode.javacpp.Pointer;)I")]
  [SourceFile("JavaCvErrorCallback.java")]
  [Modifiers]
  internal sealed class JavaCvErrorCallback\u00241 : Object, Runnable
  {
    [Modifiers]
    internal string val\u0024message;
    [Modifiers]
    internal object this\u00240;

    [LineNumberTable((ushort) 73)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal JavaCvErrorCallback\u00241([In] object obj0, [In] string obj1)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (JavaCvErrorCallback\u00241), "com.googlecode.javacv.JavaCvErrorCallback");
      this.this\u00240 = obj0;
      this.val\u0024message = obj1;
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 75)]
    public virtual void run()
    {
      object obj = this.this\u00240;
      throw new NoClassDefFoundError("com.googlecode.javacv.JavaCvErrorCallback");
    }
  }
}
