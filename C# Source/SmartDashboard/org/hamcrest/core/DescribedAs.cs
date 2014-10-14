// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.DescribedAs
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util.regex;
using org.hamcrest;
using System.Runtime.CompilerServices;

namespace org.hamcrest.core
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class DescribedAs : BaseMatcher
  {
    [Modifiers]
    private static Pattern ARG_PATTERN = Pattern.compile("%([0-9]+)");
    [Modifiers]
    private string descriptionTemplate;
    [Modifiers]
    [Signature("Lorg/hamcrest/Matcher<TT;>;")]
    private Matcher matcher;
    [Modifiers]
    private object[] values;

    [LineNumberTable((ushort) 20)]
    static DescribedAs()
    {
    }

    [Signature("(Ljava/lang/String;Lorg/hamcrest/Matcher<TT;>;[Ljava/lang/Object;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 104, (byte) 103, (byte) 103, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DescribedAs(string descriptionTemplate, Matcher matcher, object[] values)
    {
      DescribedAs describedAs = this;
      this.descriptionTemplate = descriptionTemplate;
      this.matcher = matcher;
      this.values = (object[]) values.Clone();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;Lorg/hamcrest/Matcher<TT;>;[Ljava/lang/Object;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 53)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher describedAs(string description, Matcher matcher, params object[] values)
    {
      return (Matcher) new DescribedAs(description, matcher, values);
    }

    [LineNumberTable((ushort) 29)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object o)
    {
      return (this.matcher.matches(o) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 159, (byte) 2, (byte) 98, (byte) 104, (byte) 121, (byte) 110, (byte) 112, (byte) 103, (byte) 130, (byte) 110, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      Pattern pattern = DescribedAs.ARG_PATTERN;
      object obj = (object) this.descriptionTemplate;
      CharSequence charSequence1;
      charSequence1.__\u003Cref\u003E = (__Null) obj;
      CharSequence charSequence2 = charSequence1;
      Matcher matcher = pattern.matcher(charSequence2);
      int num = 0;
      while (matcher.find())
      {
        description.appendText(String.instancehelper_substring(this.descriptionTemplate, num, matcher.start()));
        int index = Integer.parseInt(matcher.group(1));
        description.appendValue(this.values[index]);
        num = matcher.end();
      }
      if (num >= String.instancehelper_length(this.descriptionTemplate))
        return;
      description.appendText(String.instancehelper_substring(this.descriptionTemplate, num));
    }
  }
}
