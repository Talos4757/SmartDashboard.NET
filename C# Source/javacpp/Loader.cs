// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Loader
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using com.googlecode.javacpp.annotation;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  public class Loader : Object
  {
    internal static bool loadLibraries = true;
    [Signature("Ljava/util/Map<Ljava/lang/Class;Ljava/lang/String;>;")]
    internal static Map loadedLibraries = Collections.synchronizedMap((Map) new HashMap());
    [Signature("Ljava/util/WeakHashMap<Ljava/lang/Class<+Lcom/googlecode/javacpp/Pointer;>;Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/Integer;>;>;")]
    internal static WeakHashMap memberOffsets;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 102, (byte) 239, (byte) 160, (byte) 102, (byte) 113, (byte) 239, (byte) 99})]
    static Loader()
    {
      if (String.instancehelper_startsWith(Loader.getPlatformName(), "windows"))
        Runtime.getRuntime().addShutdownHook((Thread) new Loader\u00242());
      Loader.memberOffsets = new WeakHashMap();
    }

    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Loader()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 103, (byte) 129, (byte) 102, (byte) 115, (byte) 109, (byte) 130, (byte) 114, (byte) 151, (byte) 248, (byte) 57, (byte) 233, (byte) 73, (byte) 110, (byte) 106, (byte) 151, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void appendProperty(Properties properties, string name, string separator, params string[] values)
    {
      if (values == null || values.Length == 0)
        return;
      string str1 = "";
      string[] strArray = values;
      int length = strArray.Length;
      for (int index = 0; index < length; ++index)
      {
        string str2 = strArray[index];
        if (str2 != null && String.instancehelper_length(str2) != 0)
        {
          if (String.instancehelper_length(str1) > 0 && !String.instancehelper_endsWith(str1, separator))
            str1 = new StringBuilder().append(str1).append(separator).toString();
          str1 = new StringBuilder().append(str1).append(str2).toString();
        }
      }
      string property = properties.getProperty(name, "");
      if (String.instancehelper_length(property) > 0)
        str1 = new StringBuilder().append(str1).append(separator).toString();
      properties.setProperty(name, new StringBuilder().append(str1).append(property).toString());
    }

    [Signature("(Ljava/util/Properties;Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 49, (byte) 140, (byte) 177, (byte) 99, (byte) 113, (byte) 99, (byte) 129, (byte) 139, (byte) 98, (byte) 167, (byte) 127, (byte) 9, (byte) 127, (byte) 1, (byte) 123, (byte) 124, (byte) 112, (byte) 106, (byte) 124, (byte) 106, (byte) 102, (byte) 226, (byte) 61, (byte) 40, (byte) 232, (byte) 72, (byte) 127, (byte) 1, (byte) 116, (byte) 116, (byte) 116, (byte) 116, (byte) 116, (byte) 116, (byte) 116, (byte) 116, (byte) 244, (byte) 44, (byte) 235, (byte) 88, (byte) 109, (byte) 114, (byte) 114, (byte) 114, (byte) 111, (byte) 105, (byte) 109, (byte) 113, (byte) 106, (byte) 100, (byte) 109, (byte) 159, (byte) 7, (byte) 251, (byte) 59, (byte) 232, (byte) 72, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void appendProperties(Properties properties, Class cls)
    {
      string property1 = properties.getProperty("platform.name");
      Properties properties1 = (Properties) cls.getAnnotation((Class) ClassLiteral<Properties>.Value);
      Platform[] platformArray1;
      if (properties1 == null)
      {
        Platform platform1 = (Platform) cls.getAnnotation((Class) ClassLiteral<Platform>.Value);
        if (platform1 == null)
          return;
        Platform[] platformArray2 = new Platform[1];
        int index = 0;
        Platform platform2 = platform1;
        platformArray2[index] = platform2;
        platformArray1 = platformArray2;
      }
      else
        platformArray1 = properties1.value();
      string[] strArray1 = new string[0];
      string[] strArray2 = new string[0];
      string[] strArray3 = new string[0];
      string[] strArray4 = new string[0];
      string[] strArray5 = new string[0];
      string[] strArray6 = new string[0];
      string[] strArray7 = new string[0];
      string[] strArray8 = new string[0];
      string[] strArray9 = new string[0];
      Platform[] platformArray3 = platformArray1;
      int length1 = platformArray3.Length;
      for (int index1 = 0; index1 < length1; ++index1)
      {
        Platform platform = platformArray3[index1];
        string[][] strArray10 = new string[2][];
        int index2 = 0;
        string[] strArray11 = platform.value();
        strArray10[index2] = strArray11;
        int index3 = 1;
        string[] strArray12 = platform.not();
        strArray10[index3] = strArray12;
        string[][] strArray13 = strArray10;
        bool[] flagArray1 = new bool[2];
        int index4 = 0;
        int num1 = 0;
        flagArray1[index4] = num1 != 0;
        int index5 = 1;
        int num2 = 0;
        flagArray1[index5] = num2 != 0;
        bool[] flagArray2 = flagArray1;
        for (int index6 = 0; index6 < strArray13.Length; ++index6)
        {
          string[] strArray14 = strArray13[index6];
          int length2 = strArray14.Length;
          for (int index7 = 0; index7 < length2; ++index7)
          {
            string str = strArray14[index7];
            if (String.instancehelper_startsWith(property1, str))
            {
              flagArray2[index6] = true;
              break;
            }
          }
        }
        if ((strArray13[0].Length == 0 || flagArray2[0]) && (strArray13[1].Length == 0 || !flagArray2[1]))
        {
          if (platform.define().Length > 0)
            strArray1 = platform.define();
          if (platform.include().Length > 0)
            strArray2 = platform.include();
          if (platform.cinclude().Length > 0)
            strArray3 = platform.cinclude();
          if (platform.includepath().Length > 0)
            strArray4 = platform.includepath();
          if (platform.options().Length > 0)
            strArray5 = platform.options();
          if (platform.linkpath().Length > 0)
            strArray6 = platform.linkpath();
          if (platform.link().Length > 0)
            strArray7 = platform.link();
          if (platform.preloadpath().Length > 0)
            strArray8 = platform.preloadpath();
          if (platform.preload().Length > 0)
            strArray9 = platform.preload();
        }
      }
      string property2 = properties.getProperty("path.separator");
      Loader.appendProperty(properties, "generator.define", "\0", strArray1);
      Loader.appendProperty(properties, "generator.include", "\0", strArray2);
      Loader.appendProperty(properties, "generator.cinclude", "\0", strArray3);
      Loader.appendProperty(properties, "compiler.includepath", property2, strArray4);
      if (strArray5.Length > 0)
      {
        string property3 = properties.getProperty("compiler.options");
        properties.setProperty("compiler.options", "");
        for (int index1 = 0; index1 < strArray5.Length; ++index1)
        {
          string str1 = property3;
          if (String.instancehelper_length(strArray5[index1]) > 0)
            str1 = properties.getProperty(new StringBuilder().append("compiler.options.").append(strArray5[index1]).toString());
          Properties properties2 = properties;
          string name = "compiler.options";
          string separator = " ";
          string[] strArray10 = new string[1];
          int index2 = 0;
          string str2 = str1;
          strArray10[index2] = str2;
          Loader.appendProperty(properties2, name, separator, strArray10);
        }
      }
      Loader.appendProperty(properties, "compiler.linkpath", property2, strArray6);
      Loader.appendProperty(properties, "compiler.link", property2, strArray7);
      Loader.appendProperty(properties, "loader.preloadpath", property2, strArray6);
      Loader.appendProperty(properties, "loader.preloadpath", property2, strArray8);
      Loader.appendProperty(properties, "loader.preload", property2, strArray7);
      Loader.appendProperty(properties, "loader.preload", property2, strArray9);
    }

    [LineNumberTable((ushort) 68)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Properties getProperties()
    {
      return Loader.getProperties(Loader.getPlatformName());
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 102, (byte) 109, (byte) 127, (byte) 7, (byte) 172, (byte) 191, (byte) 17, (byte) 4, (byte) 97, (byte) 252, (byte) 79, (byte) 229, (byte) 51, (byte) 97, (byte) 103, (byte) 172, (byte) 191, (byte) 19, (byte) 4, (byte) 97, (byte) 255, (byte) 1, (byte) 69, (byte) 226, (byte) 61, (byte) 98, (byte) 223, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Properties getProperties(string name)
    {
      Properties properties = new Properties();
      ((Hashtable) properties).put((object) "platform.name", (object) name);
      name = new StringBuilder().append("properties/").append(name).append(".properties").toString();
      InputStream resourceAsStream1 = ((Class) ClassLiteral<Loader>.Value).getResourceAsStream(name);
      try
      {
        try
        {
          properties.load((Reader) new InputStreamReader(resourceAsStream1));
          goto label_27;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<NoSuchMethodError>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_7;
      }
      try
      {
        properties.load(resourceAsStream1);
        goto label_27;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      // ISSUE: variable of the null type
      __Null local = null;
      goto label_12;
label_7:
      local = null;
label_12:
      name = "properties/generic.properties";
      InputStream resourceAsStream2 = ((Class) ClassLiteral<Loader>.Value).getResourceAsStream(name);
      Exception exception1;
      try
      {
        try
        {
          properties.load((Reader) new InputStreamReader(resourceAsStream2));
          goto label_27;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<NoSuchMethodError>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception1 = (Exception) m0;
          goto label_20;
        }
      }
      Exception exception2;
      try
      {
        properties.load(resourceAsStream2);
        goto label_27;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception2 = (Exception) m0;
      }
      Exception exception3 = exception2;
      goto label_26;
label_20:
      exception3 = exception1;
label_26:
      string str1 = new StringBuilder().append("Could not even get generic properties: ").append(Throwable.instancehelper_getMessage((Exception) exception3)).toString();
      string name1 = ((Class) ClassLiteral<Loader>.Value).getName();
      string str2 = name;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new MissingResourceException(str1, name1, str2);
label_27:
      return properties;
    }

    [LineNumberTable((ushort) 188)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getLibraryName(Class cls)
    {
      return new StringBuilder().append("jni").append(cls.getSimpleName()).toString();
    }

    [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacpp/Pointer;>;)I")]
    [LineNumberTable((ushort) 421)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int @sizeof(Class type)
    {
      return ((Integer) ((HashMap) Loader.memberOffsets.get((object) type)).get((object) "sizeof")).intValue();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 112, (byte) 112, (byte) 112, (byte) 122, (byte) 104, (byte) 109, (byte) 136, (byte) 105, (byte) 100, (byte) 169, (byte) 127, (byte) 21, (byte) 104, (byte) 122, (byte) 104, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getPlatformName()
    {
      string str1 = String.instancehelper_toLowerCase(System.getProperty("java.vm.name"));
      string str2 = String.instancehelper_toLowerCase(System.getProperty("os.name"));
      string str3 = String.instancehelper_toLowerCase(System.getProperty("os.arch"));
      if (String.instancehelper_startsWith(str1, "dalvik") && String.instancehelper_startsWith(str2, "linux"))
        str2 = "android";
      else if (String.instancehelper_startsWith(str2, "mac os x"))
      {
        str2 = "macosx";
      }
      else
      {
        int num = String.instancehelper_indexOf(str2, 32);
        if (num > 0)
          str2 = String.instancehelper_substring(str2, 0, num);
      }
      if (String.instancehelper_equals(str3, (object) "i386") || String.instancehelper_equals(str3, (object) "i486") || (String.instancehelper_equals(str3, (object) "i586") || String.instancehelper_equals(str3, (object) "i686")))
        str3 = "x86";
      else if (String.instancehelper_equals(str3, (object) "amd64") || String.instancehelper_equals(str3, (object) "x86-64"))
        str3 = "x86_64";
      else if (String.instancehelper_startsWith(str3, "arm"))
        str3 = "arm";
      return new StringBuilder().append(str2).append("-").append(str3).toString();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 104, (byte) 99, (byte) 130, (byte) 98, (byte) 130, (byte) 103, (byte) 119, (byte) 137, (byte) 138, (byte) 103, (byte) 141, (byte) 110, (byte) 141, (byte) 102, (byte) 250, (byte) 70, (byte) 226, (byte) 59, (byte) 98, (byte) 102, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static File extractResource(Class cls, string name, File directory, string prefix, string suffix)
    {
      InputStream resourceAsStream = cls.getResourceAsStream(name);
      if (resourceAsStream == null)
        return (File) null;
      File file = (File) null;
      int num1 = 0;
      IOException ioException1;
      try
      {
        if (prefix == null && suffix == null)
        {
          File.__\u003Cclinit\u003E();
          file = new File(directory, new File(name).getName());
          num1 = file.exists() ? 1 : 0;
        }
        else
          file = File.createTempFile(prefix, suffix, directory);
        FileOutputStream fileOutputStream = new FileOutputStream(file);
        byte[] numArray = new byte[resourceAsStream.available()];
        int num2;
        while ((num2 = resourceAsStream.read(numArray)) > 0)
          fileOutputStream.write(numArray, 0, num2);
        resourceAsStream.close();
        fileOutputStream.close();
        goto label_14;
      }
      catch (IOException ex)
      {
        int num2 = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
      }
      IOException ioException2 = ioException1;
      if (file != null && num1 == 0)
        file.delete();
      throw Throwable.__\u003Cunmap\u003E((Exception) ioException2);
label_14:
      return file;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 235, (byte) 69, (byte) 101, (byte) 132})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Class getCallerClass(int i)
    {
      Class[] classContext = new Loader\u00241().getClassContext();
      if (i < classContext.Length)
        return classContext[i];
      else
        return (Class) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 103, (byte) 226, (byte) 71, (byte) 103, (byte) 105, (byte) 100, (byte) 233, (byte) 69, (byte) 255, (byte) 0, (byte) 69, (byte) 226, (byte) 60, (byte) 97, (byte) 109, (byte) 105, (byte) 168, (byte) 114, (byte) 100, (byte) 195, (byte) 113, (byte) 104, (byte) 110, (byte) 110, (byte) 114, (byte) 157, (byte) 110, (byte) 110, (byte) 110, (byte) 107, (byte) 100, (byte) 106, (byte) 118, (byte) 31, (byte) 1, (byte) 232, (byte) 70, (byte) 176, (byte) 195, (byte) 104, (byte) 127, (byte) 5, (byte) 110, (byte) 127, (byte) 19, (byte) 111, (byte) 132, (byte) 105, (byte) 108, (byte) 110, (byte) 255, (byte) 4, (byte) 85, (byte) 100, (byte) 58, (byte) 100, (byte) 234, (byte) 46, (byte) 108, (byte) 110, (byte) 255, (byte) 2, (byte) 79, (byte) 100, (byte) 50, (byte) 100, (byte) 238, (byte) 50, (byte) 98, (byte) 100, (byte) 136, (byte) 232, (byte) 73, (byte) 100, (byte) 236, (byte) 55, (byte) 98, (byte) 100, (byte) 136, (byte) 110, (byte) 106, (byte) 136, (byte) 100})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string load(Class cls)
    {
      if (!Loader.loadLibraries)
        return (string) null;
      string str1 = cls.getName();
      int num1 = String.instancehelper_indexOf(str1, 36);
      if (num1 > 0)
        str1 = String.instancehelper_substring(str1, 0, num1);
      ClassNotFoundException notFoundException1;
      try
      {
        cls = Class.forName(str1, Loader.__\u003CGetCallerID\u003E());
        goto label_7;
      }
      catch (ClassNotFoundException ex)
      {
        int num2 = 1;
        notFoundException1 = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
      }
      ClassNotFoundException notFoundException2 = notFoundException1;
      NoClassDefFoundError classDefFoundError = new NoClassDefFoundError(Throwable.instancehelper_toString((Exception) notFoundException2));
      Throwable.instancehelper_initCause((Exception) classDefFoundError, (Exception) notFoundException2);
      throw Throwable.__\u003Cunmap\u003E((Exception) classDefFoundError);
label_7:
      string str2 = (string) Loader.loadedLibraries.get((object) cls);
      if (str2 != null)
        return str2;
      Properties properties = (Properties) ((Hashtable) Loader.getProperties()).clone();
      Loader.appendProperties(properties, cls);
      string property1 = properties.getProperty("path.separator");
      string str3 = properties.getProperty("platform.root");
      if (str3 != null && !String.instancehelper_endsWith(str3, (string) File.separator))
        str3 = new StringBuilder().append(str3).append((string) File.separator).toString();
      string property2 = properties.getProperty("loader.preloadpath");
      string property3 = properties.getProperty("loader.preload");
      if (property2 != null && property3 != null)
      {
        string[] paths = String.instancehelper_split(property2, property1);
        if (str3 != null)
        {
          for (int index = 0; index < paths.Length; ++index)
          {
            File.__\u003Cclinit\u003E();
            if (!new File(paths[index]).isAbsolute())
              paths[index] = new StringBuilder().append(str3).append(paths[index]).toString();
          }
        }
        Loader.preload(paths, String.instancehelper_split(property3, property1));
      }
      File file = (File) null;
      string libraryName;
      string str4;
      string str5;
      UnsatisfiedLinkError unsatisfiedLinkError1;
      IOException ioException1;
      // ISSUE: fault handler
      try
      {
        try
        {
          libraryName = Loader.getLibraryName(cls);
          string prefix = new StringBuilder().append(properties.getProperty("library.prefix")).append(libraryName).toString();
          string property4 = properties.getProperty("library.suffix");
          string name = new StringBuilder().append(properties.getProperty("platform.name")).append('/').append(prefix).append(property4).toString();
          file = Loader.extractResource(cls, name, (File) null, prefix, property4);
          if (file != null)
          {
            str4 = file.getAbsolutePath();
            System.load(str4, Loader.__\u003CGetCallerID\u003E());
            Loader.loadedLibraries.put((object) cls, (object) str4);
            str5 = str4;
            goto label_31;
          }
          else
            goto label_34;
        }
        catch (Exception ex)
        {
          int num2 = 0;
          M0 m0 = ByteCodeHelper.MapException<UnsatisfiedLinkError>(ex, (ByteCodeHelper.MapFlags) num2);
          if (m0 == null)
            throw;
          else
            unsatisfiedLinkError1 = (UnsatisfiedLinkError) m0;
        }
      }
      catch (IOException ex)
      {
        int num2 = 1;
        ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
        goto label_30;
      }
      __fault
      {
        if (file != null)
          file.deleteOnExit();
      }
      UnsatisfiedLinkError unsatisfiedLinkError2 = unsatisfiedLinkError1;
      goto label_47;
label_30:
      IOException ioException2 = ioException1;
      goto label_54;
label_31:
      if (file != null)
        file.deleteOnExit();
      return str5;
label_34:
      UnsatisfiedLinkError unsatisfiedLinkError3;
      IOException ioException3;
      // ISSUE: fault handler
      try
      {
        try
        {
          System.loadLibrary(libraryName, Loader.__\u003CGetCallerID\u003E());
          Loader.loadedLibraries.put((object) cls, (object) libraryName);
          str4 = libraryName;
          goto label_44;
        }
        catch (Exception ex)
        {
          int num2 = 0;
          M0 m0 = ByteCodeHelper.MapException<UnsatisfiedLinkError>(ex, (ByteCodeHelper.MapFlags) num2);
          if (m0 == null)
            throw;
          else
            unsatisfiedLinkError3 = (UnsatisfiedLinkError) m0;
        }
      }
      catch (IOException ex)
      {
        int num2 = 1;
        ioException3 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
        goto label_43;
      }
      __fault
      {
        if (file != null)
          file.deleteOnExit();
      }
      unsatisfiedLinkError2 = unsatisfiedLinkError3;
      goto label_47;
label_43:
      ioException2 = ioException3;
      goto label_54;
label_44:
      if (file != null)
        file.deleteOnExit();
      return str4;
label_47:
      UnsatisfiedLinkError unsatisfiedLinkError4 = unsatisfiedLinkError2;
      // ISSUE: fault handler
      try
      {
        UnsatisfiedLinkError unsatisfiedLinkError5 = unsatisfiedLinkError4;
        if (file != null)
          file.delete();
        throw Throwable.__\u003Cunmap\u003E((Exception) unsatisfiedLinkError5);
      }
      __fault
      {
        if (file != null)
          file.deleteOnExit();
      }
label_54:
      IOException ioException4 = ioException2;
      // ISSUE: fault handler
      try
      {
        IOException ioException5 = ioException4;
        if (file != null)
          file.delete();
        UnsatisfiedLinkError unsatisfiedLinkError5 = new UnsatisfiedLinkError(Throwable.instancehelper_toString((Exception) ioException5));
        Throwable.instancehelper_initCause((Exception) unsatisfiedLinkError5, (Exception) ioException5);
        throw Throwable.__\u003Cunmap\u003E((Exception) unsatisfiedLinkError5);
      }
      __fault
      {
        if (file != null)
          file.deleteOnExit();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 106, (byte) 98, (byte) 106, (byte) 127, (byte) 11, (byte) 109, (byte) 130, (byte) 107, (byte) 119, (byte) 98, (byte) 225, (byte) 56, (byte) 233, (byte) 74, (byte) 131, (byte) 127, (byte) 3, (byte) 227, (byte) 49, (byte) 233, (byte) 82})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void preload(string[] paths, string[] libnames)
    {
      for (int index1 = 0; index1 < libnames.Length; ++index1)
      {
        int num1 = 0;
        for (int index2 = 0; index2 < paths.Length; ++index2)
        {
          string str = new StringBuilder().append(paths[index2]).append((string) File.separator).append(System.mapLibraryName(libnames[index1])).toString();
          if (new File(str).exists())
          {
            try
            {
              System.load(str, Loader.__\u003CGetCallerID\u003E());
              num1 = 1;
              break;
            }
            catch (Exception ex)
            {
              int num2 = 2;
              if (ByteCodeHelper.MapException<UnsatisfiedLinkError>(ex, (ByteCodeHelper.MapFlags) num2) == null)
                throw;
            }
          }
        }
        if (num1 == 0)
        {
          try
          {
            System.loadLibrary(libnames[index1], Loader.__\u003CGetCallerID\u003E());
          }
          catch (Exception ex)
          {
            int num2 = 2;
            if (ByteCodeHelper.MapException<UnsatisfiedLinkError>(ex, (ByteCodeHelper.MapFlags) num2) == null)
              throw;
          }
        }
      }
    }

    [Modifiers]
    [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacpp/Pointer;>;Ljava/lang/String;I)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 40, (byte) 76, (byte) 113, (byte) 99, (byte) 147, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void putMemberOffset([In] Class obj0, [In] string obj1, [In] int obj2)
    {
      lock ((object) ClassLiteral<Loader>.Value)
      {
        HashMap local_1 = (HashMap) Loader.memberOffsets.get((object) obj0);
        if (local_1 == null)
          Loader.memberOffsets.put((object) obj0, (object) (local_1 = new HashMap()));
        local_1.put((object) obj1, (object) Integer.valueOf(obj2));
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable((ushort) 205)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static File extractResource(Class cls, string name, File directory)
    {
      return Loader.extractResource(cls, name, directory, (string) null, (string) null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string load()
    {
      return Loader.load(Loader.getCallerClass(3));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 19, (byte) 111, (byte) 104, (byte) 146, (byte) 115, (byte) 229, (byte) 59, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      string[] strArray = args;
      int length = strArray.Length;
      for (int index = 0; index < length; ++index)
      {
        File file = new File(strArray[index]);
        while (file.exists())
        {
          if (!file.delete())
          {
            try
            {
              Thread.sleep(100L);
            }
            catch (InterruptedException ex)
            {
            }
          }
          else
            break;
        }
      }
    }

    [Throws(new string[] {"java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 127, (byte) 6, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void putMemberOffset([In] string obj0, [In] string obj1, [In] int obj2)
    {
      Loader.putMemberOffset(Class.forName(String.instancehelper_replace(obj0, '/', '.'), false, ((Class) ClassLiteral<Loader>.Value).getClassLoader(Loader.__\u003CGetCallerID\u003E()), Loader.__\u003CGetCallerID\u003E()).asSubclass((Class) ClassLiteral<Pointer>.Value), obj1, obj2);
    }

    [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacpp/Pointer;>;Ljava/lang/String;)I")]
    [LineNumberTable((ushort) 417)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int offsetof(Class type, string member)
    {
      return ((Integer) ((HashMap) Loader.memberOffsets.get((object) type)).get((object) member)).intValue();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Loader.__\u003CcallerID\u003E == null)
        Loader.__\u003CcallerID\u003E = (CallerID) new Loader.__\u003CCallerID\u003E();
      return Loader.__\u003CcallerID\u003E;
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
