// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.RunAfters
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.util;
using org.junit.@internal.runners.model;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners.statements
{
  public class RunAfters : Statement
  {
    [Modifiers]
    private Statement fNext;
    [Modifiers]
    private object fTarget;
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;")]
    private List fAfters;

    [Signature("(Lorg/junit/runners/model/Statement;Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;Ljava/lang/Object;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RunAfters(Statement next, List afters, object target)
    {
      RunAfters runAfters = this;
      this.fNext = next;
      this.fAfters = afters;
      this.fTarget = target;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 102, (byte) 134, (byte) 222, (byte) 159, (byte) 1, (byte) 191, (byte) 8, (byte) 2, (byte) 98, (byte) 105, (byte) 235, (byte) 59, (byte) 159, (byte) 5, (byte) 191, (byte) 9, (byte) 2, (byte) 98, (byte) 105, (byte) 98, (byte) 233, (byte) 55, (byte) 98, (byte) 144, (byte) 159, (byte) 1, (byte) 191, (byte) 8, (byte) 2, (byte) 98, (byte) 105, (byte) 229, (byte) 59, (byte) 159, (byte) 5, (byte) 191, (byte) 9, (byte) 2, (byte) 98, (byte) 105, (byte) 98, (byte) 98, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      ArrayList arrayList = new ArrayList();
      ((List) arrayList).clear();
      Exception exception1;
      // ISSUE: fault handler
      try
      {
        this.fNext.evaluate();
        goto label_11;
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      __fault
      {
        Iterator local_2 = this.fAfters.iterator();
        while (local_2.hasNext())
        {
          FrameworkMethod local_3 = (FrameworkMethod) local_2.next();
          Exception local_4;
          try
          {
            local_3.invokeExplosively(this.fTarget);
            continue;
          }
          catch (Exception exception_4)
          {
            int temp_86 = 0;
            local_4 = (Exception) ByteCodeHelper.MapException<Exception>(exception_4, (ByteCodeHelper.MapFlags) temp_86);
          }
          Exception local_5 = local_4;
          ((List) arrayList).add((object) local_5);
        }
      }
      Exception exception2 = exception1;
      // ISSUE: fault handler
      try
      {
        Exception exception3 = exception2;
        ((List) arrayList).add((object) exception3);
      }
      __fault
      {
        Iterator local_2_1 = this.fAfters.iterator();
        while (local_2_1.hasNext())
        {
          FrameworkMethod local_3_1 = (FrameworkMethod) local_2_1.next();
          Exception local_10_1;
          try
          {
            local_3_1.invokeExplosively(this.fTarget);
            continue;
          }
          catch (Exception exception_3)
          {
            int temp_66 = 0;
            local_10_1 = (Exception) ByteCodeHelper.MapException<Exception>(exception_3, (ByteCodeHelper.MapFlags) temp_66);
          }
          Exception local_5_1 = local_10_1;
          ((List) arrayList).add((object) local_5_1);
        }
      }
      Iterator iterator1 = this.fAfters.iterator();
      while (iterator1.hasNext())
      {
        FrameworkMethod frameworkMethod = (FrameworkMethod) iterator1.next();
        Exception exception3;
        try
        {
          frameworkMethod.invokeExplosively(this.fTarget);
          continue;
        }
        catch (Exception ex)
        {
          int num = 0;
          exception3 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
        Exception exception4 = exception3;
        ((List) arrayList).add((object) exception4);
      }
      goto label_31;
label_11:
      Iterator iterator2 = this.fAfters.iterator();
      while (iterator2.hasNext())
      {
        FrameworkMethod frameworkMethod = (FrameworkMethod) iterator2.next();
        Exception exception3;
        try
        {
          frameworkMethod.invokeExplosively(this.fTarget);
          continue;
        }
        catch (Exception ex)
        {
          int num = 0;
          exception3 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
        Exception exception4 = exception3;
        ((List) arrayList).add((object) exception4);
      }
label_31:
      MultipleFailureException.assertEmpty((List) arrayList);
    }
  }
}
