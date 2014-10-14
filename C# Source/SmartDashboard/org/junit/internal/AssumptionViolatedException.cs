// Decompiled with JetBrains decompiler
// Type: org.junit.internal.AssumptionViolatedException
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.junit.@internal
{
  [Implements(new string[] {"org.hamcrest.SelfDescribing"})]
  [Serializable]
  public class AssumptionViolatedException : RuntimeException, SelfDescribing
  {
    private const long serialVersionUID = 1L;
    [Modifiers]
    private object fValue;
    [Modifiers]
    [Signature("Lorg/hamcrest/Matcher<*>;")]
    private Matcher fMatcher;

    [Signature("(Ljava/lang/Object;Lorg/hamcrest/Matcher<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 121, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssumptionViolatedException(object value, Matcher matcher)
    {
      base.\u002Ector(!(value is Exception) ? (Exception) null : (Exception) value);
      AssumptionViolatedException violatedException = this;
      this.fValue = value;
      this.fMatcher = matcher;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssumptionViolatedException(string assumption)
      : this((object) assumption, (Matcher) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AssumptionViolatedException([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getMessage()
    {
      return StringDescription.asString((SelfDescribing) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 104, (byte) 108, (byte) 109, (byte) 108, (byte) 143, (byte) 159, (byte) 7})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void describeTo(Description description)
    {
      if (this.fMatcher != null)
      {
        description.appendText("got: ");
        description.appendValue(this.fValue);
        description.appendText(", expected: ");
        description.appendDescriptionOf((SelfDescribing) this.fMatcher);
      }
      else
        description.appendText(new StringBuilder().append("failed assumption: ").append(this.fValue).toString());
    }
  }
}
