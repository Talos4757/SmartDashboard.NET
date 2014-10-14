// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.BaseChildSettings$PropertyVetoExceptionThatNetBeansLikes$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [EnclosingMethod("com.googlecode.javacv.BaseChildSettings$PropertyVetoExceptionThatNetBeansLikes", "call", "()Ljava.lang.Object;")]
  [SourceFile("BaseChildSettings.java")]
  [Modifiers]
  internal sealed class BaseChildSettings\u0024PropertyVetoExceptionThatNetBeansLikes\u00241 : ListResourceBundle
  {
    [Modifiers]
    internal BaseChildSettings.PropertyVetoExceptionThatNetBeansLikes this\u00240;

    [HideFromJava]
    static BaseChildSettings\u0024PropertyVetoExceptionThatNetBeansLikes\u00241()
    {
      ListResourceBundle.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BaseChildSettings\u0024PropertyVetoExceptionThatNetBeansLikes\u00241([In] BaseChildSettings.PropertyVetoExceptionThatNetBeansLikes obj0)
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object[][] getContents()
    {
      object[][] objArray1 = new object[1][];
      int index1 = 0;
      object[] objArray2 = new object[2];
      int index2 = 0;
      string message1 = Throwable.instancehelper_getMessage((Exception) this.this\u00240);
      objArray2[index2] = (object) message1;
      int index3 = 1;
      string message2 = Throwable.instancehelper_getMessage((Exception) this.this\u00240);
      objArray2[index3] = (object) message2;
      objArray1[index1] = objArray2;
      return objArray1;
    }
  }
}
