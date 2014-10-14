// Decompiled with JetBrains decompiler
// Type: org.junit.internal.requests.SortingRequest
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using org.junit.@internal.requests;
using org.junit.runner;
using org.junit.runner.manipulation;
using System.Runtime.CompilerServices;

namespace org.junit.@internal.requests
{
  public class SortingRequest : Request
  {
    [Modifiers]
    private Request fRequest;
    [Modifiers]
    [Signature("Ljava/util/Comparator<Lorg/junit/runner/Description;>;")]
    private Comparator fComparator;

    [Signature("(Lorg/junit/runner/Request;Ljava/util/Comparator<Lorg/junit/runner/Description;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortingRequest(Request request, Comparator comparator)
    {
      SortingRequest sortingRequest = this;
      this.fRequest = request;
      this.fComparator = comparator;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner getRunner()
    {
      Runner runner = this.fRequest.getRunner();
      Sorter.__\u003Cclinit\u003E();
      new Sorter(this.fComparator).apply((object) runner);
      return runner;
    }
  }
}
