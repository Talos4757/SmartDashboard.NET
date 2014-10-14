// Decompiled with JetBrains decompiler
// Type: org.junit.internal.builders.AnnotatedBuilder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using org.junit.@internal.builders;
using org.junit.runner;
using org.junit.runners.model;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.builders
{
  public class AnnotatedBuilder : RunnerBuilder
  {
    private const string CONSTRUCTOR_ERROR_FORMAT = "Custom runner class %s should have a public constructor with signature %s(Class testClass)";
    private RunnerBuilder fSuiteBuilder;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnnotatedBuilder(RunnerBuilder suiteBuilder)
    {
      AnnotatedBuilder annotatedBuilder = this;
      this.fSuiteBuilder = suiteBuilder;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [Signature("(Ljava/lang/Class<+Lorg/junit/runner/Runner;>;Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 159, (byte) 34, (byte) 129, (byte) 191, (byte) 51, (byte) 97, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Runner buildRunner(Class runnerClass, Class testClass)
    {
      Runner runner1;
      try
      {
        Class class1 = runnerClass;
        Class[] classArray = new Class[1];
        int index1 = 0;
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<Class>.Value;
        classArray[index1] = (Class) local;
        CallerID callerId1 = AnnotatedBuilder.__\u003CGetCallerID\u003E();
        Constructor constructor = class1.getConstructor(classArray, callerId1);
        object[] objArray = new object[1];
        int index2 = 0;
        Class class2 = testClass;
        objArray[index2] = (object) class2;
        CallerID callerId2 = AnnotatedBuilder.__\u003CGetCallerID\u003E();
        runner1 = (Runner) constructor.newInstance(objArray, callerId2);
      }
      catch (NoSuchMethodException ex)
      {
        goto label_3;
      }
      return runner1;
label_3:
      Runner runner2;
      try
      {
        Class class1 = runnerClass;
        Class[] classArray = new Class[2];
        int index1 = 0;
        // ISSUE: variable of the null type
        __Null local1 = ClassLiteral<Class>.Value;
        classArray[index1] = (Class) local1;
        int index2 = 1;
        // ISSUE: variable of the null type
        __Null local2 = ClassLiteral<RunnerBuilder>.Value;
        classArray[index2] = (Class) local2;
        CallerID callerId1 = AnnotatedBuilder.__\u003CGetCallerID\u003E();
        Constructor constructor = class1.getConstructor(classArray, callerId1);
        object[] objArray = new object[2];
        int index3 = 0;
        Class class2 = testClass;
        objArray[index3] = (object) class2;
        int index4 = 1;
        RunnerBuilder runnerBuilder = this.fSuiteBuilder;
        objArray[index4] = (object) runnerBuilder;
        CallerID callerId2 = AnnotatedBuilder.__\u003CGetCallerID\u003E();
        runner2 = (Runner) constructor.newInstance(objArray, callerId2);
      }
      catch (NoSuchMethodException ex)
      {
        goto label_7;
      }
      return runner2;
label_7:
      string simpleName = runnerClass.getSimpleName();
      string str1 = "Custom runner class %s should have a public constructor with signature %s(Class testClass)";
      object[] objArray1 = new object[2];
      int index5 = 0;
      string str2 = simpleName;
      objArray1[index5] = (object) str2;
      int index6 = 1;
      string str3 = simpleName;
      objArray1[index6] = (object) str3;
      string @string = String.format(str1, objArray1);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new InitializationError(@string);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 113, (byte) 99, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner runnerForClass(Class testClass)
    {
      RunWith runWith = (RunWith) testClass.getAnnotation((Class) ClassLiteral<RunWith>.Value);
      if (runWith == null)
        return (Runner) null;
      return this.buildRunner(runWith.value(), testClass);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AnnotatedBuilder.__\u003CcallerID\u003E == null)
        AnnotatedBuilder.__\u003CcallerID\u003E = (CallerID) new AnnotatedBuilder.__\u003CCallerID\u003E();
      return AnnotatedBuilder.__\u003CcallerID\u003E;
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
