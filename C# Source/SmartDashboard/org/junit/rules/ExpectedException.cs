// Decompiled with JetBrains decompiler
// Type: org.junit.rules.ExpectedException
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.hamcrest;
using org.junit;
using org.junit.matchers;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.rules
{
  [Implements(new string[] {"org.junit.rules.MethodRule"})]
  public class ExpectedException : Object, MethodRule
  {
    [Signature("Lorg/hamcrest/Matcher<Ljava/lang/Object;>;")]
    private Matcher fMatcher;

    [LineNumberTable(new byte[] {(byte) 6, (byte) 8, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ExpectedException()
    {
      base.\u002Ector();
      ExpectedException expectedException = this;
      this.fMatcher = (Matcher) null;
    }

    [Modifiers]
    [LineNumberTable((ushort) 45)]
    internal static Matcher access\u0024000([In] ExpectedException obj0)
    {
      return obj0.fMatcher;
    }

    [Signature("(Lorg/hamcrest/Matcher<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 137, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void expect(Matcher matcher)
    {
      if (this.fMatcher == null)
        this.fMatcher = matcher;
      else
        this.fMatcher = (Matcher) JUnitMatchers.both(this.fMatcher).and(matcher);
    }

    [Signature("(Lorg/hamcrest/Matcher<Ljava/lang/String;>;)V")]
    [LineNumberTable(new byte[] {(byte) 47, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void expectMessage(Matcher matcher)
    {
      this.expect(this.hasMessage(matcher));
    }

    [Signature("(Lorg/hamcrest/Matcher<Ljava/lang/String;>;)Lorg/hamcrest/Matcher<Ljava/lang/Throwable;>;")]
    [LineNumberTable((ushort) 124)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matcher hasMessage([In] Matcher obj0)
    {
      return (Matcher) new ExpectedException\u00241(this, obj0);
    }

    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ExpectedException none()
    {
      return new ExpectedException();
    }

    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Statement apply(Statement @base, FrameworkMethod method, object target)
    {
      return (Statement) new ExpectedException.ExpectedExceptionStatement(this, @base);
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 31, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void expect(Class type)
    {
      this.expect(CoreMatchers.instanceOf(type));
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void expectMessage(string substring)
    {
      this.expectMessage(JUnitMatchers.containsString(substring));
    }

    [InnerClass]
    [SourceFile("ExpectedException.java")]
    [Modifiers]
    internal sealed class ExpectedExceptionStatement : Statement
    {
      [Modifiers]
      internal ExpectedException this\u00240 = obj0;
      [Modifiers]
      private Statement fNext;

      [LineNumberTable(new byte[] {(byte) 53, (byte) 111, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ExpectedExceptionStatement([In] ExpectedException obj0, [In] Statement obj1)
      {
        ExpectedException.ExpectedExceptionStatement exceptionStatement = this;
        this.fNext = obj1;
      }

      [Throws(new string[] {"java.lang.Throwable"})]
      [LineNumberTable(new byte[] {(byte) 60, (byte) 253, (byte) 70, (byte) 226, (byte) 59, (byte) 97, (byte) 109, (byte) 103, (byte) 113, (byte) 129, (byte) 109, (byte) 159, (byte) 21})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void evaluate()
      {
        Exception exception1;
        try
        {
          this.fNext.evaluate();
          goto label_6;
        }
        catch (Exception ex)
        {
          int num = 0;
          exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
        Exception exception2 = exception1;
        if (ExpectedException.access\u0024000(this.this\u00240) == null)
          throw Throwable.__\u003Cunmap\u003E(exception2);
        Assert.assertThat((object) exception2, ExpectedException.access\u0024000(this.this\u00240));
        return;
label_6:
        if (ExpectedException.access\u0024000(this.this\u00240) == null)
          return;
        string str = new StringBuilder().append("Expected test to throw ").append(StringDescription.toString((SelfDescribing) ExpectedException.access\u0024000(this.this\u00240))).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError((object) str);
      }
    }
  }
}
