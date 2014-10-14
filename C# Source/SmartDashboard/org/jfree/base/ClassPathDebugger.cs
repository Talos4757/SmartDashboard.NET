// Decompiled with JetBrains decompiler
// Type: org.jfree.base.ClassPathDebugger
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.@base;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base
{
  public class ClassPathDebugger : Object
  {
    internal static Class class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities;
    internal static Class class\u0024java\u0024lang\u0024String;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 42)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassPathDebugger()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 54)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, ClassPathDebugger.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 111, (byte) 127, (byte) 9, (byte) 127, (byte) 9, (byte) 127, (byte) 39, (byte) 127, (byte) 39, (byte) 127, (byte) 14, (byte) 127, (byte) 14, (byte) 170, (byte) 111, (byte) 159, (byte) 15, (byte) 136, (byte) 159, (byte) 12, (byte) 106, (byte) 111, (byte) 159, (byte) 15, (byte) 136, (byte) 255, (byte) 33, (byte) 70, (byte) 226, (byte) 61, (byte) 129, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      System.get_out().println("Listing the various classloaders:");
      System.get_out().println(new StringBuffer().append("Defined classloader source: ").append(ObjectUtilities.getClassLoaderSource()).toString());
      System.get_out().println(new StringBuffer().append("User classloader: ").append((object) ObjectUtilities.getClassLoader()).toString());
      System.get_out().println(new StringBuffer().append("Classloader for ObjectUtilities.class: ").append((object) ObjectUtilities.getClassLoader(ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities != null ? ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities : (ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities = ClassPathDebugger.class\u0024("org.jfree.util.ObjectUtilities")))).toString());
      System.get_out().println(new StringBuffer().append("Classloader for String.class: ").append((object) ObjectUtilities.getClassLoader(ClassPathDebugger.class\u0024java\u0024lang\u0024String != null ? ClassPathDebugger.class\u0024java\u0024lang\u0024String : (ClassPathDebugger.class\u0024java\u0024lang\u0024String = ClassPathDebugger.class\u0024("java.lang.String")))).toString());
      System.get_out().println(new StringBuffer().append("Thread-Context Classloader: ").append((object) Thread.currentThread().getContextClassLoader()).toString());
      System.get_out().println(new StringBuffer().append("Defined System classloader: ").append((object) ClassLoader.getSystemClassLoader(ClassPathDebugger.__\u003CGetCallerID\u003E())).toString());
      System.get_out().println();
      Exception exception;
      try
      {
        System.get_out().println("Listing sources for '/jcommon.properties':");
        Enumeration resources1 = ObjectUtilities.getClassLoader(ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities != null ? ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities : (ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities = ClassPathDebugger.class\u0024("org.jfree.util.ObjectUtilities"))).getResources("jcommon.properties");
        while (resources1.hasMoreElements())
          System.get_out().println(new StringBuffer().append(" ").append(resources1.nextElement()).toString());
        System.get_out().println();
        System.get_out().println("Listing sources for 'org/jfree/JCommonInfo.class':");
        Enumeration resources2 = ObjectUtilities.getClassLoader(ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities != null ? ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities : (ClassPathDebugger.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities = ClassPathDebugger.class\u0024("org.jfree.util.ObjectUtilities"))).getResources("org/jfree/JCommonInfo.class");
        while (resources2.hasMoreElements())
          System.get_out().println(new StringBuffer().append(" ").append(resources2.nextElement()).toString());
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ClassPathDebugger.__\u003CcallerID\u003E == null)
        ClassPathDebugger.__\u003CcallerID\u003E = (CallerID) new ClassPathDebugger.__\u003CCallerID\u003E();
      return ClassPathDebugger.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
