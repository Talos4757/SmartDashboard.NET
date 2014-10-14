// Decompiled with JetBrains decompiler
// Type: junit.runner.BaseTestRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.text;
using java.util;
using junit.framework;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.runner
{
  [Implements(new string[] {"junit.framework.TestListener"})]
  public abstract class BaseTestRunner : Object, TestListener
  {
    internal static int fgMaxMessageLength = 500;
    internal static bool fgFilterStack = true;
    public const string SUITE_METHODNAME = "suite";
    private static Properties fPreferences;
    internal bool fLoading;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 106, (byte) 230, (byte) 161, (byte) 27, (byte) 116})]
    static BaseTestRunner()
    {
      BaseTestRunner.fgMaxMessageLength = BaseTestRunner.getPreference("maxmessage", BaseTestRunner.fgMaxMessageLength);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 232, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseTestRunner()
    {
      base.\u002Ector();
      BaseTestRunner baseTestRunner = this;
      this.fLoading = true;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public abstract void testStarted(string str);

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 130, (byte) 112, (byte) 116, (byte) 246, (byte) 71, (byte) 226, (byte) 58, (byte) 129, (byte) 99, (byte) 145, (byte) 34, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void readPreferences()
    {
      FileInputStream fileInputStream = (FileInputStream) null;
      try
      {
        FileInputStream.__\u003Cclinit\u003E();
        fileInputStream = new FileInputStream(BaseTestRunner.getPreferencesFile());
        Properties.__\u003Cclinit\u003E();
        BaseTestRunner.setPreferences(new Properties(BaseTestRunner.getPreferences()));
        BaseTestRunner.getPreferences().load((InputStream) fileInputStream);
        return;
      }
      catch (IOException ex)
      {
      }
      try
      {
        if (fileInputStream == null)
          return;
        ((InputStream) fileInputStream).close();
      }
      catch (IOException ex)
      {
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static File getPreferencesFile()
    {
      return new File(System.getProperty("user.home"), "junit.properties");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 103, (byte) 106, (byte) 117, (byte) 117, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static Properties getPreferences()
    {
      if (BaseTestRunner.fPreferences == null)
      {
        BaseTestRunner.fPreferences = new Properties();
        ((Hashtable) BaseTestRunner.fPreferences).put((object) "loading", (object) "true");
        ((Hashtable) BaseTestRunner.fPreferences).put((object) "filterstack", (object) "true");
        BaseTestRunner.readPreferences();
      }
      return BaseTestRunner.fPreferences;
    }

    public abstract void testEnded(string str);

    public abstract void testFailed(int i, Test t1, Exception t2);

    protected internal virtual void clearStatus()
    {
    }

    [Throws(new string[] {"java.lang.ClassNotFoundException"})]
    [Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
    [LineNumberTable((ushort) 207)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Class loadSuiteClass(string suiteClassName)
    {
      return Class.forName(suiteClassName, BaseTestRunner.__\u003CGetCallerID\u003E());
    }

    protected internal abstract void runFailed(string str);

    public virtual void setLoading(bool enable)
    {
      this.fLoading = enable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 109, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string extractClassName(string className)
    {
      if (!String.instancehelper_startsWith(className, "Default package for"))
        return className;
      return String.instancehelper_substring(className, String.instancehelper_lastIndexOf(className, ".") + 1);
    }

    [LineNumberTable((ushort) 241)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getPreference(string key)
    {
      return BaseTestRunner.getPreferences().getProperty(key);
    }

    protected internal static void setPreferences(Properties preferences)
    {
      BaseTestRunner.fPreferences = preferences;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 158, (byte) 103, (byte) 130, (byte) 102, (byte) 103, (byte) 103, (byte) 199, (byte) 107, (byte) 105, (byte) 221, (byte) 2, (byte) 97, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getFilteredTrace(string stack)
    {
      if (BaseTestRunner.showStackRaw())
        return stack;
      StringWriter stringWriter = new StringWriter();
      PrintWriter printWriter = new PrintWriter((Writer) stringWriter);
      BufferedReader bufferedReader = new BufferedReader((Reader) new StringReader(stack));
      try
      {
        string str;
        while ((str = bufferedReader.readLine()) != null)
        {
          if (!BaseTestRunner.filterLine(str))
            printWriter.println(str);
        }
        goto label_9;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      return stack;
label_9:
      return stringWriter.toString();
    }

    [LineNumberTable((ushort) 293)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static bool showStackRaw()
    {
      return !String.instancehelper_equals(BaseTestRunner.getPreference("filterstack"), (object) "true") || !BaseTestRunner.fgFilterStack;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 183, (byte) 255, (byte) 40, (byte) 74, (byte) 103, (byte) 108, (byte) 2, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool filterLine([In] string obj0)
    {
      string[] strArray = new string[8];
      int index1 = 0;
      string str1 = "junit.framework.TestCase";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "junit.framework.TestResult";
      strArray[index2] = str2;
      int index3 = 2;
      string str3 = "junit.framework.TestSuite";
      strArray[index3] = str3;
      int index4 = 3;
      string str4 = "junit.framework.Assert.";
      strArray[index4] = str4;
      int index5 = 4;
      string str5 = "junit.swingui.TestRunner";
      strArray[index5] = str5;
      int index6 = 5;
      string str6 = "junit.awtui.TestRunner";
      strArray[index6] = str6;
      int index7 = 6;
      string str7 = "junit.textui.TestRunner";
      strArray[index7] = str7;
      int index8 = 7;
      string str8 = "java.lang.reflect.Method.invoke(";
      strArray[index8] = str8;
      foreach (string str9 in strArray)
      {
        if (String.instancehelper_indexOf(obj0, str9) > 0)
          return true;
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 103, (byte) 98, (byte) 99, (byte) 130, (byte) 146, (byte) 34, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int getPreference(string key, int dflt)
    {
      string preference = BaseTestRunner.getPreference(key);
      int num = dflt;
      if (preference == null)
        return num;
      try
      {
        num = Integer.parseInt(preference);
        goto label_5;
      }
      catch (NumberFormatException ex)
      {
      }
label_5:
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void startTest(Test test)
    {
      this.testStarted(Object.instancehelper_toString((object) test));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 7, (byte) 144, (byte) 148, (byte) 73, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void savePreferences()
    {
      FileOutputStream.__\u003Cclinit\u003E();
      FileOutputStream fileOutputStream = new FileOutputStream(BaseTestRunner.getPreferencesFile());
      try
      {
        BaseTestRunner.getPreferences().store((OutputStream) fileOutputStream, "");
      }
      finally
      {
        fileOutputStream.close();
      }
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setPreference(string key, string value)
    {
      ((Hashtable) BaseTestRunner.getPreferences()).put((object) key, (object) value);
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 110})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void endTest(Test test)
    {
      this.testEnded(Object.instancehelper_toString((object) test));
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 107})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addError(Test test, Exception t)
    {
      this.testFailed(1, test, t);
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 107})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addFailure(Test test, AssertionFailedError t)
    {
      this.testFailed(2, test, (Exception) t);
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 105, (byte) 102, (byte) 130, (byte) 130, (byte) 255, (byte) 12, (byte) 74, (byte) 226, (byte) 55, (byte) 97, (byte) 104, (byte) 100, (byte) 99, (byte) 127, (byte) 12, (byte) 98, (byte) 98, (byte) 127, (byte) 7, (byte) 130, (byte) 130, (byte) 255, (byte) 14, (byte) 69, (byte) 226, (byte) 60, (byte) 129, (byte) 102, (byte) 135, (byte) 110, (byte) 107, (byte) 130, (byte) 130, (byte) 127, (byte) 0, (byte) 100, (byte) 255, (byte) 16, (byte) 73, (byte) 226, (byte) 57, (byte) 98, (byte) 127, (byte) 12, (byte) 130, (byte) 98, (byte) 127, (byte) 7, (byte) 162, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Test getTest(string suiteClassName)
    {
      if (String.instancehelper_length(suiteClassName) <= 0)
      {
        this.clearStatus();
        return (Test) null;
      }
      else
      {
        Class theClass;
        ClassNotFoundException notFoundException;
        Exception exception;
        try
        {
          try
          {
            theClass = this.loadSuiteClass(suiteClassName);
            goto label_10;
          }
          catch (ClassNotFoundException ex)
          {
            int num = 1;
            notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
          {
            throw;
          }
          else
          {
            exception = (Exception) m0;
            goto label_9;
          }
        }
        this.runFailed(new StringBuilder().append("Class not found \"").append(Throwable.instancehelper_getMessage((Exception) notFoundException) ?? suiteClassName).append("\"").toString());
        return (Test) null;
label_9:
        this.runFailed(new StringBuilder().append("Error: ").append(Throwable.instancehelper_toString((Exception) exception)).toString());
        return (Test) null;
label_10:
        Method method;
        try
        {
          method = theClass.getMethod("suite", new Class[0], BaseTestRunner.__\u003CGetCallerID\u003E());
          goto label_15;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
        this.clearStatus();
        return (Test) new TestSuite(theClass);
label_15:
        if (!Modifier.isStatic(method.getModifiers()))
        {
          this.runFailed("Suite() method must be static");
          return (Test) null;
        }
        else
        {
          Test test1;
          Test test2;
          InvocationTargetException invocationTargetException;
          IllegalAccessException illegalAccessException;
          try
          {
            try
            {
              test1 = (Test) method.invoke((object) null, (object[]) new Class[0], BaseTestRunner.__\u003CGetCallerID\u003E());
              if (test1 == null)
                test2 = test1;
              else
                goto label_25;
            }
            catch (InvocationTargetException ex)
            {
              int num = 1;
              invocationTargetException = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
              goto label_23;
            }
          }
          catch (IllegalAccessException ex)
          {
            int num = 1;
            illegalAccessException = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
            goto label_24;
          }
          return test2;
label_23:
          this.runFailed(new StringBuilder().append("Failed to invoke suite():").append(Throwable.instancehelper_toString(invocationTargetException.getTargetException())).toString());
          return (Test) null;
label_24:
          this.runFailed(new StringBuilder().append("Failed to invoke suite():").append(Throwable.instancehelper_toString((Exception) illegalAccessException)).toString());
          return (Test) null;
label_25:
          this.clearStatus();
          return test1;
        }
      }
    }

    [LineNumberTable((ushort) 146)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string elapsedTimeAsString(long runTime)
    {
      return NumberFormat.getInstance().format((double) runTime / 1000.0);
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 98, (byte) 106, (byte) 111, (byte) 108, (byte) 111, (byte) 104, (byte) 111, (byte) 103, (byte) 142, (byte) 111, (byte) 134, (byte) 228, (byte) 52, (byte) 233, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string processArguments(string[] args)
    {
      string str = (string) null;
      for (int index = 0; index < args.Length; ++index)
      {
        if (String.instancehelper_equals(args[index], (object) "-noloading"))
          this.setLoading(false);
        else if (String.instancehelper_equals(args[index], (object) "-nofilterstack"))
          BaseTestRunner.fgFilterStack = false;
        else if (String.instancehelper_equals(args[index], (object) "-c"))
        {
          if (args.Length > index + 1)
            str = this.extractClassName(args[index + 1]);
          else
            System.get_out().println("Missing Test class name");
          ++index;
        }
        else
          str = args[index];
      }
      return str;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 117, (byte) 127, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string truncate(string s)
    {
      if (BaseTestRunner.fgMaxMessageLength != -1 && String.instancehelper_length(s) > BaseTestRunner.fgMaxMessageLength)
        s = new StringBuilder().append(String.instancehelper_substring(s, 0, BaseTestRunner.fgMaxMessageLength)).append("...").toString();
      return s;
    }

    [LineNumberTable((ushort) 217)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual bool useReloadingTestSuiteLoader()
    {
      return String.instancehelper_equals(BaseTestRunner.getPreference("loading"), (object) "true") && this.fLoading;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 102, (byte) 103, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getFilteredTrace(Exception t)
    {
      StringWriter stringWriter = new StringWriter();
      PrintWriter printWriter = new PrintWriter((Writer) stringWriter);
      Throwable.instancehelper_printStackTrace(t, printWriter);
      return BaseTestRunner.getFilteredTrace(stringWriter.getBuffer().toString());
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (BaseTestRunner.__\u003CcallerID\u003E == null)
        BaseTestRunner.__\u003CcallerID\u003E = (CallerID) new BaseTestRunner.__\u003CCallerID\u003E();
      return BaseTestRunner.__\u003CcallerID\u003E;
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
