// Decompiled with JetBrains decompiler
// Type: junit.framework.TestSuite
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.framework
{
  [Implements(new string[] {"junit.framework.Test"})]
  public class TestSuite : Object, Test
  {
    private string fName;
    [Signature("Ljava/util/Vector<Ljunit/framework/Test;>;")]
    private Vector fTests;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 78, (byte) 232, (byte) 50, (byte) 237, (byte) 79, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSuite(Class theClass)
    {
      base.\u002Ector();
      TestSuite testSuite = this;
      this.fTests = new Vector(10);
      this.addTestsFromTestCase(theClass);
    }

    [Signature("([Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 127, (byte) 232, (byte) 1, (byte) 237, (byte) 160, (byte) 64, (byte) 112, (byte) 46, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSuite(params Class[] classes)
    {
      base.\u002Ector();
      TestSuite testSuite = this;
      this.fTests = new Vector(10);
      Class[] classArray = classes;
      int length = classArray.Length;
      for (int index = 0; index < length; ++index)
        this.addTest(this.testCaseForClass(classArray[index]));
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 232, (byte) 59, (byte) 237, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSuite()
    {
      base.\u002Ector();
      TestSuite testSuite = this;
      this.fTests = new Vector(10);
    }

    [Signature("(Ljava/lang/Class<+Ljunit/framework/TestCase;>;Ljava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 112, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSuite(Class theClass, string name)
      : this(theClass)
    {
      TestSuite testSuite = this;
      this.setName(name);
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 232, (byte) 9, (byte) 237, (byte) 120, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSuite(string name)
    {
      base.\u002Ector();
      TestSuite testSuite = this;
      this.fTests = new Vector(10);
      this.setName(name);
    }

    [Signature("([Ljava/lang/Class<+Ljunit/framework/TestCase;>;Ljava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSuite(Class[] classes, string name)
      : this(classes)
    {
      TestSuite testSuite = this;
      this.setName(name);
    }

    [Throws(new string[] {"java.lang.NoSuchMethodException"})]
    [Signature("(Ljava/lang/Class<*>;)Ljava/lang/reflect/Constructor<*>;")]
    [LineNumberTable(new byte[] {(byte) 33, (byte) 127, (byte) 9, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Constructor getTestConstructor(Class theClass)
    {
      Constructor constructor;
      try
      {
        Class @class = theClass;
        Class[] classArray = new Class[1];
        int index = 0;
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<String>.Value;
        classArray[index] = (Class) local;
        CallerID callerId = TestSuite.__\u003CGetCallerID\u003E();
        constructor = @class.getConstructor(classArray, callerId);
      }
      catch (NoSuchMethodException ex)
      {
        goto label_3;
      }
      return constructor;
label_3:
      return theClass.getConstructor(new Class[0], TestSuite.__\u003CGetCallerID\u003E());
    }

    [LineNumberTable((ushort) 94)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Test warning(string message)
    {
      return (Test) new TestSuite\u00241("warning", message);
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 102, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string exceptionToString([In] Exception obj0)
    {
      StringWriter stringWriter = new StringWriter();
      PrintWriter printWriter = new PrintWriter((Writer) stringWriter);
      Throwable.instancehelper_printStackTrace(obj0, printWriter);
      return stringWriter.toString();
    }

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 83, (byte) 140, (byte) 210, (byte) 226, (byte) 61, (byte) 97, (byte) 127, (byte) 21, (byte) 161, (byte) 109, (byte) 127, (byte) 21, (byte) 161, (byte) 98, (byte) 102, (byte) 109, (byte) 125, (byte) 42, (byte) 136, (byte) 137, (byte) 109, (byte) 127, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addTestsFromTestCase([In] Class obj0)
    {
      this.fName = obj0.getName();
      try
      {
        TestSuite.getTestConstructor(obj0);
        goto label_5;
      }
      catch (NoSuchMethodException ex)
      {
      }
      this.addTest(TestSuite.warning(new StringBuilder().append("Class ").append(obj0.getName()).append(" has no public constructor TestCase(String name) or TestCase()").toString()));
      return;
label_5:
      if (!Modifier.isPublic(obj0.getModifiers()))
      {
        this.addTest(TestSuite.warning(new StringBuilder().append("Class ").append(obj0.getName()).append(" is not public").toString()));
      }
      else
      {
        Class @class = obj0;
        ArrayList arrayList = new ArrayList();
        for (; ((Class) ClassLiteral<Test>.Value).isAssignableFrom(@class); @class = @class.getSuperclass())
        {
          Method[] declaredMethods = @class.getDeclaredMethods(TestSuite.__\u003CGetCallerID\u003E());
          int length = declaredMethods.Length;
          for (int index = 0; index < length; ++index)
            this.addTestMethod(declaredMethods[index], (List) arrayList, obj0);
        }
        if (this.fTests.size() != 0)
          return;
        this.addTest(TestSuite.warning(new StringBuilder().append("No tests found in ").append(obj0.getName()).toString()));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addTest(Test test)
    {
      this.fTests.add((object) test);
    }

    [Signature("(Ljava/lang/reflect/Method;Ljava/util/List<Ljava/lang/String;>;Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 103, (byte) 105, (byte) 97, (byte) 105, (byte) 105, (byte) 127, (byte) 44, (byte) 129, (byte) 104, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addTestMethod([In] Method obj0, [In] List obj1, [In] Class obj2)
    {
      string name = obj0.getName();
      if (obj1.contains((object) name))
        return;
      if (!this.isPublicTestMethod(obj0))
      {
        if (!this.isTestMethod(obj0))
          return;
        this.addTest(TestSuite.warning(new StringBuilder().append("Test method isn't public: ").append(obj0.getName()).append("(").append(obj2.getCanonicalName()).append(")").toString()));
      }
      else
      {
        obj1.add((object) name);
        this.addTest(TestSuite.createTest(obj2, name));
      }
    }

    public virtual void setName(string name)
    {
      this.fName = name;
    }

    [Signature("(Ljava/lang/Class<*>;)Ljunit/framework/Test;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 109, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Test testCaseForClass([In] Class obj0)
    {
      if (((Class) ClassLiteral<TestCase>.Value).isAssignableFrom(obj0))
        return (Test) new TestSuite(obj0.asSubclass((Class) ClassLiteral<TestCase>.Value));
      else
        return TestSuite.warning(new StringBuilder().append(obj0.getCanonicalName()).append(" does not extend TestCase").toString());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void runTest(Test test, TestResult result)
    {
      test.run(result);
    }

    public virtual string getName()
    {
      return this.fName;
    }

    [LineNumberTable((ushort) 298)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isPublicTestMethod([In] Method obj0)
    {
      return this.isTestMethod(obj0) && Modifier.isPublic(obj0.getModifiers());
    }

    [LineNumberTable((ushort) 302)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isTestMethod([In] Method obj0)
    {
      return obj0.getParameterTypes().Length == 0 && String.instancehelper_startsWith(obj0.getName(), "test") && Object.instancehelper_equals((object) obj0.getReturnType(), (object) Void.TYPE);
    }

    [Signature("(Ljava/lang/Class<*>;Ljava/lang/String;)Ljunit/framework/Test;")]
    [LineNumberTable(new byte[] {(byte) 4, (byte) 178, (byte) 2, (byte) 97, (byte) 223, (byte) 16, (byte) 105, (byte) 114, (byte) 104, (byte) 142, (byte) 255, (byte) 38, (byte) 72, (byte) 229, (byte) 58, (byte) 98, (byte) 127, (byte) 33, (byte) 98, (byte) 127, (byte) 38, (byte) 98, (byte) 159, (byte) 33})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Test createTest(Class theClass, string name)
    {
      Constructor testConstructor;
      try
      {
        testConstructor = TestSuite.getTestConstructor(theClass);
        goto label_3;
      }
      catch (NoSuchMethodException ex)
      {
      }
      return TestSuite.warning(new StringBuilder().append("Class ").append(theClass.getName()).append(" has no public constructor TestCase(String name) or TestCase()").toString());
label_3:
      object obj;
      InstantiationException instantiationException1;
      InvocationTargetException invocationTargetException1;
      IllegalAccessException illegalAccessException1;
      try
      {
        try
        {
          try
          {
            if (testConstructor.getParameterTypes().Length == 0)
            {
              obj = testConstructor.newInstance(new object[0], TestSuite.__\u003CGetCallerID\u003E());
              if (obj is TestCase)
              {
                ((TestCase) obj).setName(name);
                goto label_13;
              }
              else
                goto label_13;
            }
            else
            {
              Constructor constructor = testConstructor;
              object[] objArray = new object[1];
              int index = 0;
              string str = name;
              objArray[index] = (object) str;
              CallerID callerId = TestSuite.__\u003CGetCallerID\u003E();
              obj = constructor.newInstance(objArray, callerId);
              goto label_13;
            }
          }
          catch (InstantiationException ex)
          {
            int num = 1;
            instantiationException1 = (InstantiationException) ByteCodeHelper.MapException<InstantiationException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        catch (InvocationTargetException ex)
        {
          int num = 1;
          invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_11;
        }
      }
      catch (IllegalAccessException ex)
      {
        int num = 1;
        illegalAccessException1 = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_12;
      }
      InstantiationException instantiationException2 = instantiationException1;
      return TestSuite.warning(new StringBuilder().append("Cannot instantiate test case: ").append(name).append(" (").append(TestSuite.exceptionToString((Exception) instantiationException2)).append(")").toString());
label_11:
      InvocationTargetException invocationTargetException2 = invocationTargetException1;
      return TestSuite.warning(new StringBuilder().append("Exception in constructor: ").append(name).append(" (").append(TestSuite.exceptionToString(invocationTargetException2.getTargetException())).append(")").toString());
label_12:
      IllegalAccessException illegalAccessException2 = illegalAccessException1;
      return TestSuite.warning(new StringBuilder().append("Cannot access test case: ").append(name).append(" (").append(TestSuite.exceptionToString((Exception) illegalAccessException2)).append(")").toString());
label_13:
      return (Test) obj;
    }

    [Signature("(Ljava/lang/Class<+Ljunit/framework/TestCase;>;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addTestSuite(Class testClass)
    {
      this.addTest((Test) new TestSuite(testClass));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 98, (byte) 127, (byte) 1, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int countTestCases()
    {
      int num = 0;
      Iterator iterator = this.fTests.iterator();
      while (iterator.hasNext())
      {
        Test test = (Test) iterator.next();
        num += test.countTestCases();
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 127, (byte) 1, (byte) 104, (byte) 98, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run(TestResult result)
    {
      Iterator iterator = this.fTests.iterator();
      while (iterator.hasNext())
      {
        Test test = (Test) iterator.next();
        if (result.shouldStop())
          break;
        this.runTest(test, result);
      }
    }

    [LineNumberTable((ushort) 258)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Test testAt(int index)
    {
      return (Test) this.fTests.get(index);
    }

    [LineNumberTable((ushort) 265)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int testCount()
    {
      return this.fTests.size();
    }

    [Signature("()Ljava/util/Enumeration<Ljunit/framework/Test;>;")]
    [LineNumberTable((ushort) 272)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Enumeration tests()
    {
      return this.fTests.elements();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      if (this.getName() != null)
        return this.getName();
      else
        return base.toString();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TestSuite.__\u003CcallerID\u003E == null)
        TestSuite.__\u003CcallerID\u003E = (CallerID) new TestSuite.__\u003CCallerID\u003E();
      return TestSuite.__\u003CcallerID\u003E;
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
