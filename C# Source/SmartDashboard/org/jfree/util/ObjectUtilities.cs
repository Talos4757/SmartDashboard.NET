// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ObjectUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.net;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace org.jfree.util
{
  public sealed class ObjectUtilities : Object
  {
    private static string classLoaderSource = "ThreadContext";
    public const string THREAD_CONTEXT = "ThreadContext";
    public const string CLASS_CONTEXT = "ClassContext";
    private static ClassLoader classLoader;
    internal static Class class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ObjectUtilities()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 100, (byte) 130, (byte) 99, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool equal(object o1, object o2)
    {
      if (o1 == o2)
        return true;
      if (o1 == null)
        return false;
      return (Object.instancehelper_equals(o1, o2) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 159, (byte) 6, (byte) 103, (byte) 142, (byte) 102, (byte) 151, (byte) 109, (byte) 107, (byte) 99, (byte) 226, (byte) 69, (byte) 108, (byte) 99, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ClassLoader getClassLoader(Class c)
    {
      Class @class;
      Monitor.Enter((object) (@class = ObjectUtilities.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities != null ? ObjectUtilities.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities : (ObjectUtilities.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities = ObjectUtilities.class\u0024("org.jfree.util.ObjectUtilities"))));
      string str;
      // ISSUE: fault handler
      try
      {
        if (ObjectUtilities.classLoader != null)
        {
          ClassLoader classLoader = ObjectUtilities.classLoader;
          Monitor.Exit((object) @class);
          return classLoader;
        }
        else
        {
          str = ObjectUtilities.classLoaderSource;
          Monitor.Exit((object) @class);
        }
      }
      __fault
      {
        Monitor.Exit((object) @class);
      }
      if (String.instancehelper_equals("ThreadContext", (object) str))
      {
        ClassLoader contextClassLoader = Thread.currentThread().getContextClassLoader();
        if (contextClassLoader != null)
          return contextClassLoader;
      }
      return c.getClassLoader(ObjectUtilities.__\u003CGetCallerID\u003E()) ?? ClassLoader.getSystemClassLoader(ObjectUtilities.__\u003CGetCallerID\u003E());
    }

    public static void setClassLoaderSource(string classLoaderSource)
    {
      ObjectUtilities.classLoaderSource = classLoaderSource;
    }

    public static string getClassLoaderSource()
    {
      return ObjectUtilities.classLoaderSource;
    }

    public static ClassLoader getClassLoader()
    {
      return ObjectUtilities.classLoader;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 104, (byte) 99, (byte) 194, (byte) 149, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static InputStream getResourceRelativeAsStream(string name, Class context)
    {
      URL resourceRelative = ObjectUtilities.getResourceRelative(name, context);
      if (resourceRelative == null)
        return (InputStream) null;
      InputStream inputStream;
      try
      {
        inputStream = resourceRelative.openStream();
      }
      catch (IOException ex)
      {
        goto label_5;
      }
      return inputStream;
label_5:
      return (InputStream) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 103, (byte) 104, (byte) 105, (byte) 255, (byte) 9, (byte) 69, (byte) 2, (byte) 97, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object loadAndInstantiate(string className, Class source, Class type)
    {
      object obj;
      try
      {
        Class @class = ObjectUtilities.getClassLoader(source).loadClass(className);
        if (type.isAssignableFrom(@class))
          obj = @class.newInstance(ObjectUtilities.__\u003CGetCallerID\u003E());
        else
          goto label_6;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_5;
      }
      return obj;
label_5:
      return (object) null;
label_6:
      return (object) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 78, (byte) 127, (byte) 5, (byte) 131, (byte) 108, (byte) 159, (byte) 23, (byte) 97, (byte) 130, (byte) 225, (byte) 71, (byte) 2, (byte) 225, (byte) 71, (byte) 171, (byte) 99, (byte) 164, (byte) 104, (byte) 120, (byte) 159, (byte) 15, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isJDK14()
    {
      try
      {
        ClassLoader classLoader = ObjectUtilities.getClassLoader(ObjectUtilities.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities != null ? ObjectUtilities.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities : (ObjectUtilities.class\u0024org\u0024jfree\u0024util\u0024ObjectUtilities = ObjectUtilities.class\u0024("org.jfree.util.ObjectUtilities")));
        if (classLoader != null)
        {
          int num1;
          try
          {
            try
            {
              classLoader.loadClass("java.util.RandomAccess");
              num1 = 1;
            }
            catch (ClassNotFoundException ex)
            {
              goto label_8;
            }
          }
          catch (Exception ex)
          {
            int num2 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
              throw;
            else
              goto label_9;
          }
          return num1 != 0;
        }
        else
          goto label_11;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_10;
      }
label_8:
      return false;
label_9:
      goto label_11;
label_10:
label_11:
      int num3;
      try
      {
        string property = System.getProperty("java.vm.specification.version");
        if (property == null)
          return false;
        string[] strArray1 = ObjectUtilities.parseVersions(property);
        string[] strArray2 = new string[2];
        int index1 = 0;
        string str1 = "1";
        strArray2[index1] = str1;
        int index2 = 1;
        string str2 = "4";
        strArray2[index2] = str2;
        string[] strArray3 = strArray2;
        num3 = ArrayUtilities.compareVersionArrays((IComparable[]) strArray1, (IComparable[]) strArray3) < 0 ? 0 : 1;
      }
      catch (Exception ex)
      {
        int num1 = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num1) == null)
          throw;
        else
          goto label_17;
      }
      return num3 != 0;
label_17:
      return false;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 115, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 199, (byte) 156, (byte) 109, (byte) 255, (byte) 16, (byte) 75, (byte) 226, (byte) 56, (byte) 97, (byte) 234, (byte) 71, (byte) 226, (byte) 59, (byte) 97, (byte) 202, (byte) 2, (byte) 97, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object clone(object @object)
    {
      if (@object == null)
      {
        string str = "Null 'object' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (@object is PublicCloneable)
          return ((PublicCloneable) @object).clone();
        object obj;
        try
        {
          try
          {
            try
            {
              Method method = Object.instancehelper_getClass(@object).getMethod("clone", (Class[]) null, ObjectUtilities.__\u003CGetCallerID\u003E());
              if (Modifier.isPublic(method.getModifiers()))
                obj = method.invoke(@object, (object[]) null, ObjectUtilities.__\u003CGetCallerID\u003E());
              else
                goto label_13;
            }
            catch (NoSuchMethodException ex)
            {
              goto label_10;
            }
          }
          catch (IllegalAccessException ex)
          {
            goto label_11;
          }
        }
        catch (InvocationTargetException ex)
        {
          goto label_12;
        }
        return obj;
label_10:
        Log.warn((object) "Object without clone() method is impossible.");
        goto label_13;
label_11:
        Log.warn((object) "Object.clone(): unable to call method.");
        goto label_13;
label_12:
        Log.warn((object) "Object without clone() method is impossible.");
label_13:
        string str = "Failed to clone.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new CloneNotSupportedException(str);
      }
    }

    [LineNumberTable((ushort) 259)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, ObjectUtilities.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 213, (byte) 141, (byte) 202, (byte) 104, (byte) 170, (byte) 103, (byte) 105, (byte) 100, (byte) 162, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string convertName([In] string obj0, [In] Class obj1)
    {
      if (String.instancehelper_startsWith(obj0, "/"))
      {
        return String.instancehelper_substring(obj0, 1);
      }
      else
      {
        while (obj1.isArray())
          obj1 = obj1.getComponentType();
        string name = obj1.getName();
        int num = String.instancehelper_lastIndexOf(name, 46);
        if (num == -1)
          return obj0;
        return new StringBuffer().append(String.instancehelper_replace(String.instancehelper_substring(name, 0, num), '.', '/')).append("/").append(obj0).toString();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 103, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static URL getResource(string name, Class c)
    {
      ClassLoader classLoader = ObjectUtilities.getClassLoader(c);
      if (classLoader == null)
        return (URL) null;
      return classLoader.getResource(name);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 194, (byte) 103, (byte) 104, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static URL getResourceRelative(string name, Class c)
    {
      ClassLoader classLoader = ObjectUtilities.getClassLoader(c);
      string str = ObjectUtilities.convertName(name, c);
      if (classLoader == null)
        return (URL) null;
      return classLoader.getResource(str);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 117, (byte) 131, (byte) 167, (byte) 102, (byte) 108, (byte) 136, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string[] parseVersions([In] string obj0)
    {
      if (obj0 == null)
        return new string[0];
      ArrayList arrayList = new ArrayList();
      StringTokenizer stringTokenizer = new StringTokenizer(obj0, ".");
      while (stringTokenizer.hasMoreTokens())
        arrayList.add((object) stringTokenizer.nextToken());
      return (string[]) arrayList.toArray((object[]) new string[arrayList.size()]);
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 98, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int hashCode(object @object)
    {
      int num = 0;
      if (@object != null)
        num = Object.instancehelper_hashCode(@object);
      return num;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 99, (byte) 240, (byte) 69, (byte) 140, (byte) 102, (byte) 103, (byte) 104, (byte) 103, (byte) 99, (byte) 175, (byte) 136, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Collection deepClone(Collection collection)
    {
      if (collection == null)
      {
        string str = "Null 'collection' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Collection collection1 = (Collection) ObjectUtilities.clone((object) collection);
        collection1.clear();
        Iterator iterator = collection.iterator();
        while (iterator.hasNext())
        {
          object @object = iterator.next();
          if (@object != null)
            collection1.add(ObjectUtilities.clone(@object));
          else
            collection1.add((object) null);
        }
        return collection1;
      }
    }

    [Modifiers]
    public static void setClassLoader(ClassLoader classLoader)
    {
      lock ((object) ClassLiteral<ObjectUtilities>.Value)
        ObjectUtilities.classLoader = classLoader;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 104, (byte) 99, (byte) 194, (byte) 149, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static InputStream getResourceAsStream(string name, Class context)
    {
      URL resource = ObjectUtilities.getResource(name, context);
      if (resource == null)
        return (InputStream) null;
      InputStream inputStream;
      try
      {
        inputStream = resource.openStream();
      }
      catch (IOException ex)
      {
        goto label_5;
      }
      return inputStream;
label_5:
      return (InputStream) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 103, (byte) 104, (byte) 159, (byte) 5, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object loadAndInstantiate(string className, Class source)
    {
      object obj;
      try
      {
        obj = ObjectUtilities.getClassLoader(source).loadClass(className).newInstance(ObjectUtilities.__\u003CGetCallerID\u003E());
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_4;
      }
      return obj;
label_4:
      return (object) null;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ObjectUtilities.__\u003CcallerID\u003E == null)
        ObjectUtilities.__\u003CcallerID\u003E = (CallerID) new ObjectUtilities.__\u003CCallerID\u003E();
      return ObjectUtilities.__\u003CcallerID\u003E;
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
