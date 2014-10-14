// Decompiled with JetBrains decompiler
// Type: org.junit.internal.requests.FilterRequest
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using org.junit.@internal.requests;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runner.manipulation;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.requests
{
  public sealed class FilterRequest : Request
  {
    [Modifiers]
    private Request fRequest;
    [Modifiers]
    private org.junit.runner.manipulation.Filter fFilter;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FilterRequest(Request classRequest, org.junit.runner.manipulation.Filter filter)
    {
      FilterRequest filterRequest = this;
      this.fRequest = classRequest;
      this.fFilter = filter;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 108, (byte) 108, (byte) 112, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner getRunner()
    {
      Runner runner1;
      try
      {
        Runner runner2 = this.fRequest.getRunner();
        this.fFilter.apply((object) runner2);
        runner1 = runner2;
      }
      catch (NoTestsRemainException ex)
      {
        goto label_3;
      }
      return runner1;
label_3:
      // ISSUE: variable of the null type
      __Null local = ClassLiteral<org.junit.runner.manipulation.Filter>.Value;
      string str1 = "No tests found matching %s from %s";
      object[] objArray = new object[2];
      int index1 = 0;
      string str2 = this.fFilter.describe();
      objArray[index1] = (object) str2;
      int index2 = 1;
      string str3 = Object.instancehelper_toString((object) this.fRequest);
      objArray[index2] = (object) str3;
      Exception exception = new Exception(String.format(str1, objArray));
      return (Runner) new ErrorReportingRunner((Class) local, (Exception) exception);
    }
  }
}
