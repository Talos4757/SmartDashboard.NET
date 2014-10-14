// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.RunnerBuilder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.junit.@internal.runners;
using org.junit.runner;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners.model
{
  public abstract class RunnerBuilder : Object
  {
    [Modifiers]
    [Signature("Ljava/util/Set<Ljava/lang/Class<*>;>;")]
    private Set parents;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RunnerBuilder()
    {
      base.\u002Ector();
      RunnerBuilder runnerBuilder = this;
      this.parents = (Set) new HashSet();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    public abstract Runner runnerForClass(Class c);

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;[Ljava/lang/Class<*>;)Ljava/util/List<Lorg/junit/runner/Runner;>;")]
    [LineNumberTable(new byte[] {(byte) 31, (byte) 168, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List runners(Class parent, Class[] children)
    {
      this.addParent(parent);
      try
      {
        return this.runners(children);
      }
      finally
      {
        this.removeParent(parent);
      }
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 14, (byte) 110, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual Class addParent([In] Class obj0)
    {
      if (this.parents.add((object) obj0))
        return obj0;
      string str = "class '%s' (possibly indirectly) contains itself as a SuiteClass";
      object[] objArray = new object[1];
      int index = 0;
      string name = obj0.getName();
      objArray[index] = (object) name;
      string @string = String.format(str, objArray);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new InitializationError(@string);
    }

    [Signature("([Ljava/lang/Class<*>;)Ljava/util/List<Lorg/junit/runner/Runner;>;")]
    [LineNumberTable(new byte[] {(byte) 41, (byte) 102, (byte) 112, (byte) 106, (byte) 100, (byte) 233, (byte) 61, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List runners([In] Class[] obj0)
    {
      ArrayList arrayList = new ArrayList();
      Class[] classArray = obj0;
      int length = classArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Runner runner = this.safeRunnerForClass(classArray[index]);
        if (runner != null)
          arrayList.add((object) runner);
      }
      return (List) arrayList;
    }

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 20, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void removeParent([In] Class obj0)
    {
      this.parents.remove((object) obj0);
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Runner;")]
    [LineNumberTable(new byte[] {(byte) 7, (byte) 125, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Runner safeRunnerForClass(Class testClass)
    {
      Runner runner;
      Exception exception;
      try
      {
        runner = this.runnerForClass(testClass);
      }
      catch (Exception ex)
      {
        int num = 0;
        exception = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return runner;
label_3:
      Exception cause = exception;
      return (Runner) new ErrorReportingRunner(testClass, cause);
    }
  }
}
