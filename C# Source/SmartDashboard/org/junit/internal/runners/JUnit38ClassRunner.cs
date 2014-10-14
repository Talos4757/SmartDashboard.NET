// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.JUnit38ClassRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using junit.extensions;
using junit.framework;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runner.manipulation;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [Implements(new string[] {"org.junit.runner.manipulation.Filterable", "org.junit.runner.manipulation.Sortable"})]
  public class JUnit38ClassRunner : Runner, Filterable, Sortable
  {
    private Test fTest;

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit38ClassRunner(Test test)
    {
      JUnit38ClassRunner junit38ClassRunner = this;
      this.setTest(test);
    }

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 21, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit38ClassRunner(Class klass)
      : this((Test) new TestSuite(klass.asSubclass((Class) ClassLiteral<TestCase>.Value)))
    {
    }

    private void setTest([In] Test obj0)
    {
      this.fTest = obj0;
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TestListener createAdaptingListener(RunNotifier notifier)
    {
      return (TestListener) new JUnit38ClassRunner.OldTestClassAdaptingListener(this, notifier, (JUnit38ClassRunner.\u0031) null);
    }

    private Test getTest()
    {
      return this.fTest;
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104, (byte) 103, (byte) 116, (byte) 107, (byte) 103, (byte) 119, (byte) 109, (byte) 104, (byte) 105, (byte) 111, (byte) 8, (byte) 200, (byte) 98, (byte) 104, (byte) 104, (byte) 106, (byte) 104, (byte) 104, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Description makeDescription([In] Test obj0)
    {
      if (obj0 is TestCase)
      {
        TestCase testCase = (TestCase) obj0;
        return Description.createTestDescription(Object.instancehelper_getClass((object) testCase), testCase.getName());
      }
      else if (obj0 is TestSuite)
      {
        TestSuite testSuite = (TestSuite) obj0;
        Description suiteDescription = Description.createSuiteDescription(testSuite.getName() != null ? testSuite.getName() : JUnit38ClassRunner.createSuiteDescription(testSuite), new Annotation[0]);
        int num = testSuite.testCount();
        for (int index = 0; index < num; ++index)
        {
          Description description = JUnit38ClassRunner.makeDescription(testSuite.testAt(index));
          suiteDescription.addChild(description);
        }
        return suiteDescription;
      }
      else if (obj0 is Describable)
        return ((Describable) obj0).getDescription();
      else if (obj0 is TestDecorator)
        return JUnit38ClassRunner.makeDescription(((TestDecorator) obj0).getTest());
      else
        return Description.createSuiteDescription(Object.instancehelper_getClass((object) obj0));
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 103, (byte) 127, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string createSuiteDescription([In] TestSuite obj0)
    {
      int num = obj0.countTestCases();
      string str1;
      if (num == 0)
      {
        str1 = "";
      }
      else
      {
        string str2 = " [example: %s]";
        object[] objArray = new object[1];
        int index = 0;
        Test test = obj0.testAt(0);
        objArray[index] = (object) test;
        str1 = String.format(str2, objArray);
      }
      string str3 = str1;
      string str4 = "TestSuite with %s tests%s";
      object[] objArray1 = new object[2];
      int index1 = 0;
      Integer integer = Integer.valueOf(num);
      objArray1[index1] = (object) integer;
      int index2 = 1;
      string str5 = str3;
      objArray1[index2] = (object) str5;
      return String.format(str4, objArray1);
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 102, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(RunNotifier notifier)
    {
      TestResult tr = new TestResult();
      tr.addListener(this.createAdaptingListener(notifier));
      this.getTest().run(tr);
    }

    [LineNumberTable((ushort) 92)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Description getDescription()
    {
      return JUnit38ClassRunner.makeDescription(this.getTest());
    }

    [Throws(new string[] {"org.junit.runner.manipulation.NoTestsRemainException"})]
    [LineNumberTable(new byte[] {(byte) 78, (byte) 109, (byte) 108, (byte) 103, (byte) 117, (byte) 108, (byte) 108, (byte) 103, (byte) 104, (byte) 106, (byte) 111, (byte) 232, (byte) 61, (byte) 232, (byte) 69, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void filter(org.junit.runner.manipulation.Filter filter)
    {
      if (this.getTest() is Filterable)
      {
        ((Filterable) this.getTest()).filter(filter);
      }
      else
      {
        if (!(this.getTest() is TestSuite))
          return;
        TestSuite testSuite1 = (TestSuite) this.getTest();
        TestSuite testSuite2 = new TestSuite(testSuite1.getName());
        int num = testSuite1.testCount();
        for (int index = 0; index < num; ++index)
        {
          Test test = testSuite1.testAt(index);
          if (filter.shouldRun(JUnit38ClassRunner.makeDescription(test)))
            testSuite2.addTest(test);
        }
        this.setTest((Test) testSuite2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 109, (byte) 108, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sort(Sorter sorter)
    {
      if (!(this.getTest() is Sortable))
        return;
      ((Sortable) this.getTest()).sort(sorter);
    }

    [InnerClass]
    [EnclosingMethod("org.junit.internal.runners.JUnit38ClassRunner", null, null)]
    [SourceFile("JUnit38ClassRunner.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"junit.framework.TestListener"})]
    [SourceFile("JUnit38ClassRunner.java")]
    internal sealed class OldTestClassAdaptingListener : Object, TestListener
    {
      [Modifiers]
      private RunNotifier fNotifier;
      [Modifiers]
      internal JUnit38ClassRunner this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 22)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal OldTestClassAdaptingListener([In] JUnit38ClassRunner obj0, [In] RunNotifier obj1, [In] JUnit38ClassRunner.\u0031 obj2)
        : this(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 111, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private OldTestClassAdaptingListener([In] JUnit38ClassRunner obj0, [In] RunNotifier obj1)
      {
        base.\u002Ector();
        JUnit38ClassRunner.OldTestClassAdaptingListener adaptingListener = this;
        this.fNotifier = obj1;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 104, (byte) 103, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Description asDescription([In] Test obj0)
      {
        if (obj0 is Describable)
          return ((Describable) obj0).getDescription();
        else
          return Description.createTestDescription(this.getEffectiveClass(obj0), this.getName(obj0));
      }

      [Signature("(Ljunit/framework/Test;)Ljava/lang/Class<+Ljunit/framework/Test;>;")]
      [LineNumberTable((ushort) 53)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Class getEffectiveClass([In] Test obj0)
      {
        return Object.instancehelper_getClass((object) obj0);
      }

      [LineNumberTable(new byte[] {(byte) 7, (byte) 104, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private string getName([In] Test obj0)
      {
        if (obj0 is TestCase)
          return ((TestCase) obj0).getName();
        else
          return Object.instancehelper_toString((object) obj0);
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 110, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void addError([In] Test obj0, [In] Exception obj1)
      {
        this.fNotifier.fireTestFailure(new Failure(this.asDescription(obj0), obj1));
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void endTest([In] Test obj0)
      {
        this.fNotifier.fireTestFinished(this.asDescription(obj0));
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void startTest([In] Test obj0)
      {
        this.fNotifier.fireTestStarted(this.asDescription(obj0));
      }

      [LineNumberTable(new byte[] {(byte) 14, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void addFailure([In] Test obj0, [In] AssertionFailedError obj1)
      {
        this.addError(obj0, (Exception) obj1);
      }
    }
  }
}
