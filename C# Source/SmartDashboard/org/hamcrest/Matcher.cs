// Decompiled with JetBrains decompiler
// Type: org.hamcrest.Matcher
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;

namespace org.hamcrest
{
  [Implements(new string[] {"org.hamcrest.SelfDescribing"})]
  [Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lorg/hamcrest/SelfDescribing;")]
  public interface Matcher : SelfDescribing
  {
    bool matches(object obj);

    void _dont_implement_Matcher___instead_extend_BaseMatcher_();
  }
}
