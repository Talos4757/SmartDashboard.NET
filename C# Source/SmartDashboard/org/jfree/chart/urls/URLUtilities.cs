// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.urls.URLUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.net;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.chart.urls
{
  public class URLUtilities : Object
  {
    [Modifiers]
    private static Class[] STRING_ARGS_2;
    internal static Class class\u0024java\u0024lang\u0024String;
    internal static Class class\u0024java\u0024net\u0024URLEncoder;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 55)]
    static URLUtilities()
    {
      Class[] classArray = new Class[2];
      int index1 = 0;
      Class class1 = URLUtilities.class\u0024java\u0024lang\u0024String != null ? URLUtilities.class\u0024java\u0024lang\u0024String : (URLUtilities.class\u0024java\u0024lang\u0024String = URLUtilities.class\u0024("java.lang.String"));
      classArray[index1] = class1;
      int index2 = 1;
      Class class2 = URLUtilities.class\u0024java\u0024lang\u0024String != null ? URLUtilities.class\u0024java\u0024lang\u0024String : (URLUtilities.class\u0024java\u0024lang\u0024String = URLUtilities.class\u0024("java.lang.String"));
      classArray[index2] = class2;
      URLUtilities.STRING_ARGS_2 = classArray;
    }

    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public URLUtilities()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 127, (byte) 0, (byte) 130, (byte) 150, (byte) 255, (byte) 26, (byte) 71, (byte) 246, (byte) 59, (byte) 98, (byte) 199, (byte) 15, (byte) 98, (byte) 242, (byte) 70, (byte) 226, (byte) 61, (byte) 129, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string encode(string s, string encoding)
    {
      Class @class = URLUtilities.class\u0024java\u0024net\u0024URLEncoder != null ? URLUtilities.class\u0024java\u0024net\u0024URLEncoder : (URLUtilities.class\u0024java\u0024net\u0024URLEncoder = URLUtilities.class\u0024("java.net.URLEncoder"));
      string str1 = (string) null;
      InvocationTargetException invocationTargetException1;
      IllegalAccessException illegalAccessException1;
      try
      {
        Method declaredMethod = @class.getDeclaredMethod("encode", URLUtilities.STRING_ARGS_2, URLUtilities.__\u003CGetCallerID\u003E());
        try
        {
          try
          {
            Method method = declaredMethod;
            // ISSUE: variable of the null type
            __Null local = null;
            object[] objArray = new object[2];
            int index1 = 0;
            string str2 = s;
            objArray[index1] = (object) str2;
            int index2 = 1;
            string str3 = encoding;
            objArray[index2] = (object) str3;
            CallerID callerId = URLUtilities.__\u003CGetCallerID\u003E();
            str1 = (string) method.invoke((object) local, objArray, callerId);
            goto label_16;
          }
          catch (InvocationTargetException ex)
          {
            int num = 1;
            invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          }
        }
        catch (IllegalAccessException ex)
        {
          int num = 1;
          illegalAccessException1 = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_7;
        }
      }
      catch (NoSuchMethodException ex)
      {
        goto label_8;
      }
      InvocationTargetException invocationTargetException2 = invocationTargetException1;
      try
      {
        Throwable.instancehelper_printStackTrace((Exception) invocationTargetException2);
        goto label_16;
      }
      catch (NoSuchMethodException ex)
      {
      }
      // ISSUE: variable of the null type
      __Null local1 = null;
      goto label_15;
label_7:
      IllegalAccessException illegalAccessException2 = illegalAccessException1;
      try
      {
        Throwable.instancehelper_printStackTrace((Exception) illegalAccessException2);
        goto label_16;
      }
      catch (NoSuchMethodException ex)
      {
      }
      local1 = null;
      goto label_15;
label_8:
      local1 = null;
label_15:
      str1 = URLEncoder.encode(s);
label_16:
      return str1;
    }

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, URLUtilities.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (URLUtilities.__\u003CcallerID\u003E == null)
        URLUtilities.__\u003CcallerID\u003E = (CallerID) new URLUtilities.__\u003CCallerID\u003E();
      return URLUtilities.__\u003CcallerID\u003E;
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
