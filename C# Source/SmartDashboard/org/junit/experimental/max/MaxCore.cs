// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.max.MaxCore
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.lang.annotation;
using java.util;
using junit.framework;
using org.junit.@internal.requests;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runners;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.max
{
  public class MaxCore : Object
  {
    private const string MALFORMED_JUNIT_3_TEST_CLASS_PREFIX = "malformed JUnit 3 test class: ";
    [Modifiers]
    private MaxHistory fHistory;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 4, (byte) 104, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private MaxCore([In] File obj0)
    {
      base.\u002Ector();
      MaxCore maxCore = this;
      this.fHistory = MaxHistory.forFolder(obj0);
    }

    [LineNumberTable((ushort) 49)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MaxCore storedLocally(File storedResults)
    {
      return new MaxCore(storedResults);
    }

    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Request request)
    {
      return this.run(request, new JUnitCore());
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Request request, JUnitCore core)
    {
      core.addListener(this.fHistory.listener());
      return core.run(this.sortRequest(request).getRunner());
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 104, (byte) 98, (byte) 104, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Request sortRequest(Request request)
    {
      if (request is SortingRequest)
        return request;
      List leaves = this.findLeaves(request);
      Collections.sort(leaves, this.fHistory.testComparator());
      return this.constructLeafRequest(leaves);
    }

    [Signature("(Lorg/junit/runner/Request;)Ljava/util/List<Lorg/junit/runner/Description;>;")]
    [LineNumberTable(new byte[] {(byte) 104, (byte) 102, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List findLeaves([In] Request obj0)
    {
      ArrayList arrayList = new ArrayList();
      this.findLeaves((Description) null, obj0.getRunner().getDescription(), (List) arrayList);
      return (List) arrayList;
    }

    [Signature("(Ljava/util/List<Lorg/junit/runner/Description;>;)Lorg/junit/runner/Request;")]
    [LineNumberTable(new byte[] {(byte) 53, (byte) 102, (byte) 123, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Request constructLeafRequest([In] List obj0)
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator = obj0.iterator();
      while (iterator.hasNext())
      {
        Description description = (Description) iterator.next();
        ((List) arrayList).add((object) this.buildRunner(description));
      }
      return (Request) new MaxCore\u00241(this, (List) arrayList);
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 114, (byte) 104, (byte) 242, (byte) 69, (byte) 116, (byte) 103, (byte) 99, (byte) 127, (byte) 16, (byte) 103, (byte) 99, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Runner buildRunner([In] Description obj0)
    {
      if (String.instancehelper_equals(obj0.toString(), (object) "TestSuite with 0 tests"))
        return Suite.emptySuite();
      else if (String.instancehelper_startsWith(obj0.toString(), "malformed JUnit 3 test class: "))
      {
        return (Runner) new JUnit38ClassRunner((Test) new TestSuite(this.getMalformedTestClass(obj0)));
      }
      else
      {
        Class testClass = obj0.getTestClass();
        if (testClass == null)
        {
          string str = new StringBuilder().append("Can't build a runner from description [").append((object) obj0).append("]").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else
        {
          string methodName = obj0.getMethodName();
          if (methodName == null)
            return Request.aClass(testClass).getRunner();
          else
            return Request.method(testClass, methodName).getRunner();
        }
      }
    }

    [Signature("(Lorg/junit/runner/Description;)Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 88, (byte) 127, (byte) 49, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Class getMalformedTestClass([In] Description obj0)
    {
      Class @class;
      try
      {
        string str1 = obj0.toString();
        string str2 = "malformed JUnit 3 test class: ";
        object obj1 = (object) "";
        object obj2 = (object) str2;
        CharSequence charSequence1;
        charSequence1.__\u003Cref\u003E = (__Null) obj2;
        CharSequence charSequence2 = charSequence1;
        object obj3 = obj1;
        charSequence1.__\u003Cref\u003E = (__Null) obj3;
        CharSequence charSequence3 = charSequence1;
        @class = Class.forName(String.instancehelper_replace(str1, charSequence2, charSequence3), MaxCore.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        goto label_3;
      }
      return @class;
label_3:
      return (Class) null;
    }

    [Signature("(Lorg/junit/runner/Description;Lorg/junit/runner/Description;Ljava/util/List<Lorg/junit/runner/Description;>;)V")]
    [LineNumberTable(new byte[] {(byte) 110, (byte) 109, (byte) 114, (byte) 159, (byte) 15, (byte) 138, (byte) 127, (byte) 1, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void findLeaves([In] Description obj0, [In] Description obj1, [In] List obj2)
    {
      if (obj1.getChildren().isEmpty())
      {
        if (String.instancehelper_equals(obj1.toString(), (object) "warning(junit.framework.TestSuite$1)"))
          obj2.add((object) Description.createSuiteDescription(new StringBuilder().append("malformed JUnit 3 test class: ").append((object) obj0).toString(), new Annotation[0]));
        else
          obj2.add((object) obj1);
      }
      else
      {
        Iterator iterator = obj1.getChildren().iterator();
        while (iterator.hasNext())
        {
          Description description = (Description) iterator.next();
          this.findLeaves(obj1, description, obj2);
        }
      }
    }

    [Obsolete]
    [LineNumberTable((ushort) 42)]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MaxCore forFolder(string folderName)
    {
      return MaxCore.storedLocally(new File(folderName));
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Result;")]
    [LineNumberTable((ushort) 63)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Class testClass)
    {
      return this.run(Request.aClass(testClass));
    }

    [Signature("(Lorg/junit/runner/Request;)Ljava/util/List<Lorg/junit/runner/Description;>;")]
    [LineNumberTable((ushort) 150)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List sortedLeavesForTest(Request request)
    {
      return this.findLeaves(this.sortRequest(request));
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (MaxCore.__\u003CcallerID\u003E == null)
        MaxCore.__\u003CcallerID\u003E = (CallerID) new MaxCore.__\u003CCallerID\u003E();
      return MaxCore.__\u003CcallerID\u003E;
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
