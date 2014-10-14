// Decompiled with JetBrains decompiler
// Type: junit.framework.JUnit4TestAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit;
using org.junit.runner;
using org.junit.runner.manipulation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.framework
{
  [Implements(new string[] {"junit.framework.Test", "org.junit.runner.manipulation.Filterable", "org.junit.runner.manipulation.Sortable", "org.junit.runner.Describable"})]
  public class JUnit4TestAdapter : Object, Test, Filterable, Sortable, Describable
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class fNewTestClass;
    [Modifiers]
    private Runner fRunner;
    [Modifiers]
    private JUnit4TestAdapterCache fCache;

    [Signature("(Ljava/lang/Class<*>;Ljunit/framework/JUnit4TestAdapterCache;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 104, (byte) 103, (byte) 103, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit4TestAdapter(Class newTestClass, JUnit4TestAdapterCache cache)
    {
      base.\u002Ector();
      JUnit4TestAdapter junit4TestAdapter = this;
      this.fCache = cache;
      this.fNewTestClass = newTestClass;
      this.fRunner = Request.classWithoutSuiteMethod(newTestClass).getRunner();
    }

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit4TestAdapter(Class newTestClass)
      : this(newTestClass, JUnit4TestAdapterCache.getDefault())
    {
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description getDescription()
    {
      return this.removeIgnored(this.fRunner.getDescription());
    }

    [LineNumberTable(new byte[] {(byte) 8, (byte) 105, (byte) 102, (byte) 103, (byte) 127, (byte) 1, (byte) 104, (byte) 104, (byte) 103, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Description removeIgnored([In] Description obj0)
    {
      if (this.isIgnored(obj0))
        return Description.__\u003C\u003EEMPTY;
      Description description1 = obj0.childlessCopy();
      Iterator iterator = obj0.getChildren().iterator();
      while (iterator.hasNext())
      {
        Description description2 = this.removeIgnored((Description) iterator.next());
        if (!description2.isEmpty())
          description1.addChild(description2);
      }
      return description1;
    }

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isIgnored([In] Description obj0)
    {
      return obj0.getAnnotation((Class) ClassLiteral<Ignore>.Value) != null;
    }

    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int countTestCases()
    {
      return this.fRunner.testCount();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run(TestResult result)
    {
      this.fRunner.run(this.fCache.getNotifier(result, this));
    }

    [Signature("()Ljava/util/List<Ljunit/framework/Test;>;")]
    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getTests()
    {
      return this.fCache.asTestList(this.getDescription());
    }

    [Signature("()Ljava/lang/Class<*>;")]
    public virtual Class getTestClass()
    {
      return this.fNewTestClass;
    }

    [LineNumberTable((ushort) 75)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return this.fNewTestClass.getName();
    }

    [Throws(new string[] {"org.junit.runner.manipulation.NoTestsRemainException"})]
    [LineNumberTable(new byte[] {(byte) 29, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void filter(Filter filter)
    {
      filter.apply((object) this.fRunner);
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sort(Sorter sorter)
    {
      sorter.apply((object) this.fRunner);
    }
  }
}
