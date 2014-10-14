// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.Theories
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit;
using org.junit.@internal;
using org.junit.experimental.theories.@internal;
using org.junit.runners;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  public class Theories : BlockJUnit4ClassRunner
  {
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Theories(Class klass)
      : base(klass)
    {
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 150, (byte) 112, (byte) 124, (byte) 31, (byte) 23, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void validateDataPointFields([In] List obj0)
    {
      Field[] declaredFields = this.getTestClass().getJavaClass().getDeclaredFields(Theories.__\u003CGetCallerID\u003E());
      int length = declaredFields.Length;
      for (int index = 0; index < length; ++index)
      {
        Field field = declaredFields[index];
        if (field.getAnnotation((Class) ClassLiteral<DataPoint>.Value) != null && !Modifier.isStatic(field.getModifiers()))
          obj0.add((object) new Error(new StringBuilder().append("DataPoint field ").append(field.getName()).append(" must be static").toString()));
      }
    }

    [Signature("()Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;")]
    [LineNumberTable(new byte[] {(byte) 8, (byte) 103, (byte) 113, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List computeTestMethods()
    {
      List testMethods = base.computeTestMethods();
      List annotatedMethods = this.getTestClass().getAnnotatedMethods((Class) ClassLiteral<Theory>.Value);
      testMethods.removeAll((Collection) annotatedMethods);
      testMethods.addAll((Collection) annotatedMethods);
      return testMethods;
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void collectInitializationErrors(List errors)
    {
      base.collectInitializationErrors(errors);
      this.validateDataPointFields(errors);
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void validateConstructor(List errors)
    {
      this.validateOnlyOneConstructor(errors);
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 127, (byte) 1, (byte) 109, (byte) 138, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void validateTestMethods(List errors)
    {
      Iterator iterator = this.computeTestMethods().iterator();
      while (iterator.hasNext())
      {
        FrameworkMethod frameworkMethod = (FrameworkMethod) iterator.next();
        if (frameworkMethod.getAnnotation((Class) ClassLiteral<Theory>.Value) != null)
          frameworkMethod.validatePublicVoid(false, errors);
        else
          frameworkMethod.validatePublicVoidNoArg(false, errors);
      }
    }

    [LineNumberTable((ushort) 67)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Statement methodBlock(FrameworkMethod method)
    {
      return (Statement) new Theories.TheoryAnchor(method, this.getTestClass());
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Theories.__\u003CcallerID\u003E == null)
        Theories.__\u003CcallerID\u003E = (CallerID) new Theories.__\u003CCallerID\u003E();
      return Theories.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("Theories.java")]
    public class TheoryAnchor : Statement
    {
      private int successes;
      private FrameworkMethod fTestMethod;
      private TestClass fTestClass;
      [Signature("Ljava/util/List<Lorg/junit/internal/AssumptionViolatedException;>;")]
      private List fInvalidParameters;

      [LineNumberTable(new byte[] {(byte) 28, (byte) 232, (byte) 57, (byte) 231, (byte) 69, (byte) 171, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public TheoryAnchor(FrameworkMethod method, TestClass testClass)
      {
        Theories.TheoryAnchor theoryAnchor = this;
        this.successes = 0;
        this.fInvalidParameters = (List) new ArrayList();
        this.fTestMethod = method;
        this.fTestClass = testClass;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 110})]
      protected internal virtual void handleDataPointSuccess()
      {
        ++this.successes;
      }

      [LineNumberTable(new byte[] {(byte) 126, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void handleAssumptionViolation(AssumptionViolatedException e)
      {
        this.fInvalidParameters.add((object) e);
      }

      [Modifiers]
      [LineNumberTable((ushort) 70)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static bool access\u0024000([In] Theories.TheoryAnchor obj0)
      {
        return (obj0.nullsOk() ? 1 : 0) != 0;
      }

      [Throws(new string[] {"java.lang.Throwable"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 100, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void reportParameterizedError(Exception e, params object[] @params)
      {
        if (@params.Length == 0)
          throw Throwable.__\u003Cunmap\u003E(e);
        Exception targetException = e;
        string name = this.fTestMethod.getName();
        object[] objArray = @params;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ParameterizedAssertionError(targetException, name, objArray);
      }

      [Modifiers]
      [LineNumberTable((ushort) 70)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static Statement access\u0024100([In] Theories.TheoryAnchor obj0, [In] FrameworkMethod obj1, [In] Assignments obj2, [In] object obj3)
      {
        return obj0.methodCompletesWithParameters(obj1, obj2, obj3);
      }

      [LineNumberTable((ushort) 161)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Statement methodCompletesWithParameters([In] FrameworkMethod obj0, [In] Assignments obj1, [In] object obj2)
      {
        return (Statement) new Theories\u0024TheoryAnchor\u00242(this, obj1, obj0, obj2);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 155, (byte) 99, (byte) 98})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool nullsOk()
      {
        Theory theory = (Theory) this.fTestMethod.getMethod().getAnnotation((Class) ClassLiteral<Theory>.Value);
        if (theory == null)
          return false;
        return (theory.nullsAccepted() ? 1 : 0) != 0;
      }

      private TestClass getTestClass()
      {
        return this.fTestClass;
      }

      [Throws(new string[] {"java.lang.Throwable"})]
      [LineNumberTable(new byte[] {(byte) 50, (byte) 104, (byte) 137, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void runWithAssignment(Assignments parameterAssignment)
      {
        if (!parameterAssignment.isComplete())
          this.runWithIncompleteAssignment(parameterAssignment);
        else
          this.runWithCompleteAssignment(parameterAssignment);
      }

      [Throws(new string[] {"java.lang.InstantiationException", "java.lang.IllegalAccessException", "java.lang.Throwable"})]
      [LineNumberTable(new byte[] {(byte) 61, (byte) 127, (byte) 1, (byte) 143})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void runWithIncompleteAssignment(Assignments incomplete)
      {
        Iterator iterator = incomplete.potentialsForNextUnassigned().iterator();
        while (iterator.hasNext())
        {
          PotentialAssignment source = (PotentialAssignment) iterator.next();
          this.runWithAssignment(incomplete.assignNext(source));
        }
      }

      [Throws(new string[] {"java.lang.InstantiationException", "java.lang.IllegalAccessException", "java.lang.reflect.InvocationTargetException", "java.lang.NoSuchMethodException", "java.lang.Throwable"})]
      [LineNumberTable(new byte[] {(byte) 69, (byte) 255, (byte) 5, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void runWithCompleteAssignment(Assignments complete)
      {
        new Theories\u0024TheoryAnchor\u00241(this, this.getTestClass().getJavaClass(), complete).methodBlock(this.fTestMethod).evaluate();
      }

      [Throws(new string[] {"java.lang.Throwable"})]
      [LineNumberTable(new byte[] {(byte) 39, (byte) 188, (byte) 104, (byte) 191, (byte) 7})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void evaluate()
      {
        this.runWithAssignment(Assignments.allUnassigned(this.fTestMethod.getMethod(), this.getTestClass()));
        if (this.successes != 0)
          return;
        Assert.fail(new StringBuilder().append("Never found parameters that satisfied method assumptions.  Violated assumptions: ").append((object) this.fInvalidParameters).toString());
      }
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
