// Decompiled with JetBrains decompiler
// Type: junit.textui.TestRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using junit.framework;
using junit.runner;
using System;
using System.Runtime.CompilerServices;

namespace junit.textui
{
  public class TestRunner : BaseTestRunner
  {
    private ResultPrinter fPrinter;
    public const int SUCCESS_EXIT = 0;
    public const int FAILURE_EXIT = 1;
    public const int EXCEPTION_EXIT = 2;

    [HideFromJava]
    static TestRunner()
    {
      BaseTestRunner.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestRunner(PrintStream writer)
      : this(new ResultPrinter(writer))
    {
    }

    [LineNumberTable(new byte[] {(byte) 4, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestRunner(ResultPrinter printer)
    {
      TestRunner testRunner = this;
      this.fPrinter = printer;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestRunner()
      : this(System.get_out())
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TestResult run(Test test)
    {
      return new TestRunner().doRun(test);
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TestResult doRun(Test test)
    {
      return this.doRun(test, false);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 114, (byte) 98, (byte) 103, (byte) 108, (byte) 102, (byte) 103, (byte) 102, (byte) 101, (byte) 142, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TestResult doRun(Test suite, bool wait)
    {
      int num1 = wait ? 1 : 0;
      TestResult testResult = this.createTestResult();
      testResult.addListener((TestListener) this.fPrinter);
      long num2 = System.currentTimeMillis();
      suite.run(testResult);
      long num3 = System.currentTimeMillis() - num2;
      this.fPrinter.print(testResult, num3);
      this.pause(num1 != 0);
      return testResult;
    }

    [LineNumberTable((ushort) 105)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual TestResult createTestResult()
    {
      return new TestResult();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 130, (byte) 100, (byte) 139, (byte) 191, (byte) 1, (byte) 34, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void pause(bool wait)
    {
      if (!wait)
        return;
      this.fPrinter.printWaitPrompt();
      try
      {
        System.get_in().read();
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 103, (byte) 102, (byte) 102, (byte) 130, (byte) 106, (byte) 111, (byte) 103, (byte) 111, (byte) 115, (byte) 111, (byte) 105, (byte) 107, (byte) 107, (byte) 108, (byte) 113, (byte) 159, (byte) 21, (byte) 228, (byte) 51, (byte) 233, (byte) 80, (byte) 109, (byte) 176, (byte) 109, (byte) 109, (byte) 105, (byte) 127, (byte) 13, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TestResult start(string[] args)
    {
      string str1 = "";
      string method = "";
      int num1 = 0;
      for (int index1 = 0; index1 < args.Length; ++index1)
      {
        if (String.instancehelper_equals(args[index1], (object) "-wait"))
          num1 = 1;
        else if (String.instancehelper_equals(args[index1], (object) "-c"))
        {
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          str1 = this.extractClassName(strArray[index2]);
        }
        else if (String.instancehelper_equals(args[index1], (object) "-m"))
        {
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          string str2 = strArray[index2];
          int num2 = String.instancehelper_lastIndexOf(str2, 46);
          str1 = String.instancehelper_substring(str2, 0, num2);
          method = String.instancehelper_substring(str2, num2 + 1);
        }
        else if (String.instancehelper_equals(args[index1], (object) "-v"))
          System.get_err().println(new StringBuilder().append("JUnit ").append(junit.runner.Version.id()).append(" by Kent Beck and Erich Gamma").toString());
        else
          str1 = args[index1];
      }
      if (String.instancehelper_equals(str1, (object) ""))
      {
        string str2 = "Usage: TestRunner [-wait] testCaseName, where name is the name of the TestCase class";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str2);
      }
      else
      {
        TestResult testResult;
        Exception exception;
        try
        {
          if (!String.instancehelper_equals(method, (object) ""))
            return this.runSingleMethod(str1, method, num1 != 0);
          testResult = this.doRun(this.getTest(str1), num1 != 0);
        }
        catch (Exception ex)
        {
          int num2 = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
          if (m0 == null)
          {
            throw;
          }
          else
          {
            exception = (Exception) m0;
            goto label_21;
          }
        }
        return testResult;
label_21:
        string str2 = new StringBuilder().append("Could not create and run test suite: ").append((object) exception).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str2);
      }
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 96, (byte) 162, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual TestResult runSingleMethod(string testCase, string method, bool wait)
    {
      int num = wait ? 1 : 0;
      return this.doRun(TestSuite.createTest(this.loadSuiteClass(testCase).asSubclass((Class) ClassLiteral<TestCase>.Value), method), num != 0);
    }

    [Signature("(Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
    [LineNumberTable(new byte[] {(byte) 12, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void run(Class testClass)
    {
      TestRunner.run((Test) new TestSuite(testClass));
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 102, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void runAndWait(Test suite)
    {
      new TestRunner().doRun(suite, true);
    }

    public override void testFailed(int status, Test test, Exception t)
    {
    }

    public override void testStarted(string testName)
    {
    }

    public override void testEnded(string testName)
    {
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 134, (byte) 104, (byte) 104, (byte) 102, (byte) 221, (byte) 226, (byte) 61, (byte) 97, (byte) 112, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      TestRunner testRunner = new TestRunner();
      Exception exception;
      try
      {
        if (!testRunner.start(args).wasSuccessful())
          System.exit(1);
        System.exit(0);
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
      System.get_err().println(Throwable.instancehelper_getMessage((Exception) exception));
      System.exit(2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void runFailed(string message)
    {
      System.get_err().println(message);
      System.exit(1);
    }

    public virtual void setPrinter(ResultPrinter printer)
    {
      this.fPrinter = printer;
    }
  }
}
