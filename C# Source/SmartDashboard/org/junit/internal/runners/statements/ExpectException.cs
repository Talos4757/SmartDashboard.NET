// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.statements.ExpectException
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.junit.@internal.runners.statements;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.runners.statements
{
  public class ExpectException : Statement
  {
    private Statement fNext;
    [Modifiers]
    [Signature("Ljava/lang/Class<+Ljava/lang/Throwable;>;")]
    private Class fExpected;

    [Signature("(Lorg/junit/runners/model/Statement;Ljava/lang/Class<+Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExpectException(Statement next, Class expected)
    {
      ExpectException expectException = this;
      this.fNext = next;
      this.fExpected = expected;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 130, (byte) 107, (byte) 244, (byte) 72, (byte) 229, (byte) 57, (byte) 97, (byte) 115, (byte) 191, (byte) 42, (byte) 173, (byte) 99, (byte) 159, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      int num1 = 0;
      Exception exception1;
      try
      {
        this.fNext.evaluate();
        num1 = 1;
        goto label_6;
      }
      catch (Exception ex)
      {
        int num2 = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
      }
      Exception exception2 = exception1;
      if (!this.fExpected.isAssignableFrom(Object.instancehelper_getClass((object) exception2)))
      {
        string str = new StringBuilder().append("Unexpected exception, expected<").append(this.fExpected.getName()).append("> but was<").append(Object.instancehelper_getClass((object) exception2).getName()).append(">").toString();
        Exception exception3 = exception2;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str, exception3);
      }
label_6:
      if (num1 == 0)
        return;
      string str1 = new StringBuilder().append("Expected exception: ").append(this.fExpected.getName()).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new AssertionError((object) str1);
    }
  }
}
