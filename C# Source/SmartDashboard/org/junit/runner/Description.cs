// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Description
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.util;
using java.util.regex;
using System.Runtime.CompilerServices;

namespace org.junit.runner
{
  public class Description : Object
  {
    internal static Description __\u003C\u003EEMPTY = new Description("No Tests", new Annotation[0]);
    internal static Description __\u003C\u003ETEST_MECHANISM = new Description("Test mechanism", new Annotation[0]);
    [Modifiers]
    [Signature("Ljava/util/ArrayList<Lorg/junit/runner/Description;>;")]
    private ArrayList fChildren;
    [Modifiers]
    private string fDisplayName;
    [Modifiers]
    private Annotation[] fAnnotations;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static Description EMPTY
    {
      [HideFromJava] get
      {
        return Description.__\u003C\u003EEMPTY;
      }
    }

    [Modifiers]
    public static Description TEST_MECHANISM
    {
      [HideFromJava] get
      {
        return Description.__\u003C\u003ETEST_MECHANISM;
      }
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 245, (byte) 71})]
    static Description()
    {
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 232, (byte) 59, (byte) 235, (byte) 70, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Description(string _param1, params Annotation[] _param2)
    {
      base.\u002Ector();
      Description description = this;
      this.fChildren = new ArrayList();
      this.fDisplayName = param0;
      this.fAnnotations = param1;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 176)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Description childlessCopy()
    {
      return new Description(this.fDisplayName, this.fAnnotations);
    }

    [Signature("()Ljava/util/ArrayList<Lorg/junit/runner/Description;>;")]
    public virtual ArrayList getChildren()
    {
      return this.fChildren;
    }

    [LineNumberTable((ushort) 168)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isEmpty()
    {
      return (this.equals((object) Description.__\u003C\u003EEMPTY) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChild(Description description)
    {
      this.getChildren().add((object) description);
    }

    [Signature("<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 116, (byte) 110, (byte) 13, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Annotation getAnnotation(Class annotationType)
    {
      Annotation[] annotationArray = this.fAnnotations;
      int length = annotationArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Annotation annotation = annotationArray[index];
        if (Object.instancehelper_equals((object) annotation.annotationType(), (object) annotationType))
          return (Annotation) annotationType.cast((object) annotation);
      }
      return (Annotation) null;
    }

    [LineNumberTable((ushort) 123)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSuite()
    {
      return !this.isTest();
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isTest()
    {
      return (this.getChildren().isEmpty() ? 1 : 0) != 0;
    }

    public virtual string getDisplayName()
    {
      return this.fDisplayName;
    }

    [LineNumberTable((ushort) 161)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return this.getDisplayName();
    }

    [Signature("()Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 88, (byte) 103, (byte) 99, (byte) 130, (byte) 122, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Class getTestClass()
    {
      string className = this.getClassName();
      if (className == null)
        return (Class) null;
      Class @class;
      try
      {
        @class = Class.forName(className, Description.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        goto label_5;
      }
      return @class;
label_5:
      return (Class) null;
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Description;")]
    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Description createSuiteDescription(Class testClass)
    {
      return new Description(testClass.getName(), testClass.getAnnotations());
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 104, (byte) 98, (byte) 98, (byte) 127, (byte) 1, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int testCount()
    {
      if (this.isTest())
        return 1;
      int num = 0;
      Iterator iterator = this.getChildren().iterator();
      while (iterator.hasNext())
      {
        Description description = (Description) iterator.next();
        num += description.testCount();
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 179, (byte) 104, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Description createSuiteDescription(string name, params Annotation[] annotations)
    {
      if (String.instancehelper_length(name) == 0)
      {
        string str = "name must have non-zero length";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new Description(name, annotations);
    }

    [Signature("(Ljava/lang/Class<*>;Ljava/lang/String;)Lorg/junit/runner/Description;")]
    [LineNumberTable((ushort) 63)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Description createTestDescription(Class clazz, string name)
    {
      return Description.createTestDescription(clazz, name, new Annotation[0]);
    }

    [LineNumberTable((ushort) 228)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getMethodName()
    {
      return this.parseMethod();
    }

    [Signature("(Ljava/lang/Class<*>;Ljava/lang/String;[Ljava/lang/annotation/Annotation;)Lorg/junit/runner/Description;")]
    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Description createTestDescription(Class clazz, string name, params Annotation[] annotations)
    {
      string str1 = "%s(%s)";
      object[] objArray = new object[2];
      int index1 = 0;
      string str2 = name;
      objArray[index1] = (object) str2;
      int index2 = 1;
      string name1 = clazz.getName();
      objArray[index2] = (object) name1;
      return new Description(String.format(str1, objArray), annotations);
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 104, (byte) 98, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (!(obj is Description))
        return false;
      Description description = (Description) obj;
      return String.instancehelper_equals(this.getDisplayName(), (object) description.getDisplayName()) && ((AbstractList) this.getChildren()).equals((object) description.getChildren());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getClassName()
    {
      Matcher matcher = this.methodStringMatcher();
      return !matcher.matches() ? this.toString() : matcher.group(2);
    }

    [LineNumberTable((ushort) 239)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Matcher methodStringMatcher()
    {
      Pattern pattern = Pattern.compile("(.*)\\((.*)\\)");
      object obj = (object) this.toString();
      CharSequence charSequence1;
      charSequence1.__\u003Cref\u003E = (__Null) obj;
      CharSequence charSequence2 = charSequence1;
      return pattern.matcher(charSequence2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 103, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string parseMethod()
    {
      Matcher matcher = this.methodStringMatcher();
      if (!matcher.matches())
        return (string) null;
      return matcher.group(1);
    }

    [LineNumberTable((ushort) 147)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.getDisplayName());
    }

    [Signature("()Ljava/util/Collection<Ljava/lang/annotation/Annotation;>;")]
    [LineNumberTable((ushort) 194)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Collection getAnnotations()
    {
      return (Collection) Arrays.asList((object[]) this.fAnnotations);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Description.__\u003CcallerID\u003E == null)
        Description.__\u003CcallerID\u003E = (CallerID) new Description.__\u003CCallerID\u003E();
      return Description.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
