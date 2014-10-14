// Decompiled with JetBrains decompiler
// Type: org.junit.internal.matchers.TypeSafeMatcher
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using org.hamcrest;
using org.junit.@internal.matchers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.matchers
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public abstract class TypeSafeMatcher : BaseMatcher
  {
    [Signature("Ljava/lang/Class<*>;")]
    private Class expectedType;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 104, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal TypeSafeMatcher()
    {
      TypeSafeMatcher typeSafeMatcher = this;
      this.expectedType = TypeSafeMatcher.findExpectedType(Object.instancehelper_getClass((object) this));
    }

    [Signature("(Ljava/lang/Class<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal TypeSafeMatcher(Class expectedType)
    {
      TypeSafeMatcher typeSafeMatcher = this;
      this.expectedType = expectedType;
    }

    [Signature("(Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 106, (byte) 122, (byte) 105, (byte) 10, (byte) 38, (byte) 233, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Class findExpectedType([In] Class obj0)
    {
      for (Class @class = obj0; @class != ClassLiteral<Object>.Value; @class = @class.getSuperclass())
      {
        Method[] declaredMethods = @class.getDeclaredMethods(TypeSafeMatcher.__\u003CGetCallerID\u003E());
        int length = declaredMethods.Length;
        for (int index = 0; index < length; ++index)
        {
          Method method = declaredMethods[index];
          if (TypeSafeMatcher.isMatchesSafelyMethod(method))
            return method.getParameterTypes()[0];
        }
      }
      string str = "Cannot determine correct type for matchesSafely() method.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Error(str);
    }

    [LineNumberTable((ushort) 40)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool isMatchesSafelyMethod([In] Method obj0)
    {
      return String.instancehelper_equals(obj0.getName(), (object) "matchesSafely") && obj0.getParameterTypes().Length == 1 && !obj0.isSynthetic();
    }

    [Signature("(TT;)Z")]
    public abstract bool matchesSafely(object obj);

    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override sealed bool matches(object item)
    {
      return item != null && this.expectedType.isInstance(item) && this.matchesSafely(item);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TypeSafeMatcher.__\u003CcallerID\u003E == null)
        TypeSafeMatcher.__\u003CcallerID\u003E = (CallerID) new TypeSafeMatcher.__\u003CCallerID\u003E();
      return TypeSafeMatcher.__\u003CcallerID\u003E;
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
