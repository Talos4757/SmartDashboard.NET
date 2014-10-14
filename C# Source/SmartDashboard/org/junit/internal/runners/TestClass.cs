// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.TestClass
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit;
using org.junit.@internal.runners;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [Obsolete]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  public class TestClass : Object
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class fClass;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestClass(Class klass)
    {
      base.\u002Ector();
      TestClass testClass = this;
      this.fClass = klass;
    }

    [Signature("()Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual List getBefores()
    {
      return this.getAnnotatedMethods((Class) ClassLiteral<BeforeClass>.Value);
    }

    [Signature("()Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual List getAfters()
    {
      return this.getAnnotatedMethods((Class) ClassLiteral<AfterClass>.Value);
    }

    [Signature("()Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getTestMethods()
    {
      return this.getAnnotatedMethods((Class) ClassLiteral<Test>.Value);
    }

    [Signature("()Ljava/lang/Class<*>;")]
    public virtual Class getJavaClass()
    {
      return this.fClass;
    }

    [LineNumberTable((ushort) 99)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getName()
    {
      return this.fClass.getName();
    }

    [Throws(new string[] {"java.lang.SecurityException", "java.lang.NoSuchMethodException"})]
    [Signature("()Ljava/lang/reflect/Constructor<*>;")]
    [LineNumberTable((ushort) 91)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Constructor getConstructor()
    {
      return this.fClass.getConstructor(new Class[0], TestClass.__\u003CGetCallerID\u003E());
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 102, (byte) 127, (byte) 10, (byte) 108, (byte) 120, (byte) 106, (byte) 111, (byte) 233, (byte) 61, (byte) 232, (byte) 69, (byte) 101, (byte) 105, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getAnnotatedMethods(Class annotationClass)
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator = this.getSuperClasses(this.fClass).iterator();
label_1:
      while (iterator.hasNext())
      {
        Method[] declaredMethods = ((Class) iterator.next()).getDeclaredMethods(TestClass.__\u003CGetCallerID\u003E());
        int length = declaredMethods.Length;
        int index = 0;
        while (true)
        {
          if (index < length)
          {
            Method method = declaredMethods[index];
            if (method.getAnnotation(annotationClass) != null && !this.isShadowed(method, (List) arrayList))
              ((List) arrayList).add((object) method);
            ++index;
          }
          else
            goto label_1;
        }
      }
      if (this.runsTopToBottom(annotationClass))
        Collections.reverse((List) arrayList);
      return (List) arrayList;
    }

    [Signature("(Ljava/lang/Class<*>;)Ljava/util/List<Ljava/lang/Class<*>;>;")]
    [LineNumberTable(new byte[] {(byte) 31, (byte) 102, (byte) 98, (byte) 99, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getSuperClasses([In] Class obj0)
    {
      ArrayList arrayList = new ArrayList();
      for (Class @class = obj0; @class != null; @class = @class.getSuperclass())
        arrayList.add((object) @class);
      return (List) arrayList;
    }

    [Signature("(Ljava/lang/reflect/Method;Ljava/util/List<Ljava/lang/reflect/Method;>;)Z")]
    [LineNumberTable(new byte[] {(byte) 11, (byte) 123, (byte) 106, (byte) 132})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isShadowed([In] Method obj0, [In] List obj1)
    {
      Iterator iterator = obj1.iterator();
      while (iterator.hasNext())
      {
        Method method = (Method) iterator.next();
        if (this.isShadowed(obj0, method))
          return true;
      }
      return false;
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
    [LineNumberTable((ushort) 57)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool runsTopToBottom([In] Class obj0)
    {
      return Object.instancehelper_equals((object) obj0, (object) ClassLiteral<Before>.Value) || Object.instancehelper_equals((object) obj0, (object) ClassLiteral<BeforeClass>.Value);
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 115, (byte) 98, (byte) 112, (byte) 98, (byte) 108, (byte) 119, (byte) 2, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isShadowed([In] Method obj0, [In] Method obj1)
    {
      if (!String.instancehelper_equals(obj1.getName(), (object) obj0.getName()) || obj1.getParameterTypes().Length != obj0.getParameterTypes().Length)
        return false;
      for (int index = 0; index < obj1.getParameterTypes().Length; ++index)
      {
        if (!Object.instancehelper_equals((object) obj1.getParameterTypes()[index], (object) obj0.getParameterTypes()[index]))
          return false;
      }
      return true;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TestClass.__\u003CcallerID\u003E == null)
        TestClass.__\u003CcallerID\u003E = (CallerID) new TestClass.__\u003CCallerID\u003E();
      return TestClass.__\u003CcallerID\u003E;
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
