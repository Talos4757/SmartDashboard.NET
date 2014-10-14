// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.MethodValidator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
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
  public class MethodValidator : Object
  {
    [Modifiers]
    [Signature("Ljava/util/List<Ljava/lang/Throwable;>;")]
    private List fErrors;
    private TestClass fTestClass;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 232, (byte) 60, (byte) 235, (byte) 69, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MethodValidator(TestClass testClass)
    {
      base.\u002Ector();
      MethodValidator methodValidator = this;
      this.fErrors = (List) new ArrayList();
      this.fTestClass = testClass;
    }

    [Signature("()Ljava/util/List<Ljava/lang/Throwable;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 102, (byte) 102, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List validateMethodsForDefaultRunner()
    {
      this.validateNoArgConstructor();
      this.validateStaticMethods();
      this.validateInstanceMethods();
      return this.fErrors;
    }

    [Throws(new string[] {"org.junit.internal.runners.InitializationError"})]
    [LineNumberTable(new byte[] {(byte) 5, (byte) 109, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void assertValid()
    {
      if (this.fErrors.isEmpty())
        return;
      List errors = this.fErrors;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new InitializationError(errors);
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;Z)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 125, (byte) 98, (byte) 141, (byte) 126, (byte) 110, (byte) 113, (byte) 191, (byte) 44, (byte) 114, (byte) 159, (byte) 32, (byte) 109, (byte) 159, (byte) 27, (byte) 109, (byte) 159, (byte) 27, (byte) 105, (byte) 191, (byte) 32})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void validateTestMethods([In] Class obj0, [In] bool obj1)
    {
      int num = obj1 ? 1 : 0;
      Iterator iterator = this.fTestClass.getAnnotatedMethods(obj0).iterator();
      while (iterator.hasNext())
      {
        Method method = (Method) iterator.next();
        if ((Modifier.isStatic(method.getModifiers()) ? 1 : 0) != num)
        {
          string str = num == 0 ? "should not" : "should";
          this.fErrors.add((object) new Exception(new StringBuilder().append("Method ").append(method.getName()).append("() ").append(str).append(" be static").toString()));
        }
        if (!Modifier.isPublic(method.getDeclaringClass().getModifiers()))
          this.fErrors.add((object) new Exception(new StringBuilder().append("Class ").append(method.getDeclaringClass().getName()).append(" should be public").toString()));
        if (!Modifier.isPublic(method.getModifiers()))
          this.fErrors.add((object) new Exception(new StringBuilder().append("Method ").append(method.getName()).append(" should be public").toString()));
        if (method.getReturnType() != Void.TYPE)
          this.fErrors.add((object) new Exception(new StringBuilder().append("Method ").append(method.getName()).append(" should be void").toString()));
        if (method.getParameterTypes().Length != 0)
          this.fErrors.add((object) new Exception(new StringBuilder().append("Method ").append(method.getName()).append(" should have no parameters").toString()));
      }
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 191, (byte) 4, (byte) 2, (byte) 97, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validateNoArgConstructor()
    {
      Exception exception;
      try
      {
        this.fTestClass.getConstructor();
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
      this.fErrors.add((object) new Exception("Test class should have public zero-argument constructor", (Exception) exception));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validateStaticMethods()
    {
      this.validateTestMethods((Class) ClassLiteral<BeforeClass>.Value, true);
      this.validateTestMethods((Class) ClassLiteral<AfterClass>.Value, true);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 108, (byte) 108, (byte) 140, (byte) 113, (byte) 104, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validateInstanceMethods()
    {
      this.validateTestMethods((Class) ClassLiteral<After>.Value, false);
      this.validateTestMethods((Class) ClassLiteral<Before>.Value, false);
      this.validateTestMethods((Class) ClassLiteral<Test>.Value, false);
      if (this.fTestClass.getAnnotatedMethods((Class) ClassLiteral<Test>.Value).size() != 0)
        return;
      this.fErrors.add((object) new Exception("No runnable methods"));
    }
  }
}
