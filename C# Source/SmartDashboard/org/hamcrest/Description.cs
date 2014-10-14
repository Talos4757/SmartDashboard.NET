// Decompiled with JetBrains decompiler
// Type: org.hamcrest.Description
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;

namespace org.hamcrest
{
  public interface Description
  {
    Description appendText(string str);

    Description appendDescriptionOf(SelfDescribing sd);

    Description appendValue(object obj);

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[TT;)Lorg/hamcrest/Description;")]
    Description appendValueList(string str1, string str2, string str3, params object[] objarr);

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Iterable<TT;>;)Lorg/hamcrest/Description;")]
    Description appendValueList(string str1, string str2, string str3, Iterable i);

    [Signature("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Iterable<+Lorg/hamcrest/SelfDescribing;>;)Lorg/hamcrest/Description;")]
    Description appendList(string str1, string str2, string str3, Iterable i);
  }
}
