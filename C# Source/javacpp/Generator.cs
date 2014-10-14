// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Generator
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using com.googlecode.javacpp.annotation;
using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.nio;
using java.util;
using java.util.logging;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacpp
{
  [Implements(new string[] {"java.io.Closeable"})]
  public class Generator : Object, Closeable, AutoCloseable
  {
    [Modifiers]
    private static Logger logger = Logger.getLogger(((Class) ClassLiteral<Generator>.Value).getName());
    public const string JNI_VERSION = "JNI_VERSION_1_4";
    private Properties properties;
    private File file;
    private PrintWriter writer;
    private PrintWriter @out;
    [Signature("Lcom/googlecode/javacpp/Generator$LinkedListRegister<Ljava/lang/String;>;")]
    private Generator.LinkedListRegister functionDefinitions;
    [Signature("Lcom/googlecode/javacpp/Generator$LinkedListRegister<Ljava/lang/String;>;")]
    private Generator.LinkedListRegister functionPointers;
    [Signature("Lcom/googlecode/javacpp/Generator$LinkedListRegister<Ljava/lang/Class;>;")]
    private Generator.LinkedListRegister deallocators;
    [Signature("Lcom/googlecode/javacpp/Generator$LinkedListRegister<Ljava/lang/Class;>;")]
    private Generator.LinkedListRegister arrayDeallocators;
    [Signature("Lcom/googlecode/javacpp/Generator$LinkedListRegister<Ljava/lang/Class;>;")]
    private Generator.LinkedListRegister jclasses;
    [Signature("Ljava/util/HashMap<Ljava/lang/Class;Ljava/util/LinkedList<Ljava/lang/String;>;>;")]
    private HashMap members;
    private bool generatedSomethingUseful;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 87)]
    static Generator()
    {
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Generator(Properties properties, File file)
    {
      base.\u002Ector();
      Generator generator = this;
      this.properties = properties;
      this.file = file;
      this.writer = (PrintWriter) null;
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Generator(Properties properties, string filename)
      : this(properties, new File(filename))
    {
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Generator(Properties properties, PrintWriter writer)
    {
      base.\u002Ector();
      Generator generator = this;
      this.properties = properties;
      this.file = (File) null;
      this.writer = writer;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.io.FileNotFoundException"})]
    [Signature("([Ljava/lang/Class<*>;)Z")]
    [LineNumberTable(new byte[] {(byte) 60, (byte) 241, (byte) 69, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 135, (byte) 136, (byte) 127, (byte) 2, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool generate(params Class[] classes)
    {
      this.@out = new PrintWriter((Writer) new Generator\u00241(this));
      this.functionDefinitions = new Generator.LinkedListRegister();
      this.functionPointers = new Generator.LinkedListRegister();
      this.deallocators = new Generator.LinkedListRegister();
      this.arrayDeallocators = new Generator.LinkedListRegister();
      this.jclasses = new Generator.LinkedListRegister();
      this.members = new HashMap();
      this.doClasses(classes);
      if (!this.generatedSomethingUseful)
        return false;
      this.@out = this.writer == null ? new PrintWriter(this.file) : this.writer;
      this.doClasses(classes);
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 83, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      if (this.@out == null)
        return;
      this.@out.close();
    }

    [Signature("([Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 89, (byte) 112, (byte) 107, (byte) 113, (byte) 111, (byte) 122, (byte) 63, (byte) 7, (byte) 166, (byte) 139, (byte) 159, (byte) 14, (byte) 106, (byte) 118, (byte) 100, (byte) 144, (byte) 127, (byte) 8, (byte) 105, (byte) 112, (byte) 102, (byte) 108, (byte) 141, (byte) 109, (byte) 106, (byte) 108, (byte) 141, (byte) 235, (byte) 52, (byte) 235, (byte) 78, (byte) 100, (byte) 144, (byte) 235, (byte) 42, (byte) 233, (byte) 89, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 107, (byte) 127, (byte) 5, (byte) 143, (byte) 107, (byte) 127, (byte) 5, (byte) 159, (byte) 19, (byte) 107, (byte) 127, (byte) 8, (byte) 110, (byte) 105, (byte) 127, (byte) 34, (byte) 112, (byte) 112, (byte) 101, (byte) 127, (byte) 8, (byte) 110, (byte) 105, (byte) 127, (byte) 34, (byte) 112, (byte) 112, (byte) 101, (byte) 107, (byte) 112, (byte) 127, (byte) 26, (byte) 109, (byte) 98, (byte) 108, (byte) 110, (byte) 127, (byte) 31, (byte) 105, (byte) 144, (byte) 116, (byte) 110, (byte) 136, (byte) 101, (byte) 112, (byte) 127, (byte) 26, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 127, (byte) 42, (byte) 109, (byte) 108, (byte) 112, (byte) 121, (byte) 112, (byte) 109, (byte) 127, (byte) 27, (byte) 105, (byte) 178, (byte) 112, (byte) 105, (byte) 144, (byte) 101, (byte) 112, (byte) 127, (byte) 42, (byte) 109, (byte) 108, (byte) 112, (byte) 110, (byte) 116, (byte) 112, (byte) 115, (byte) 105, (byte) 115, (byte) 110, (byte) 110, (byte) 110, (byte) 135, (byte) 159, (byte) 19, (byte) 159, (byte) 34, (byte) 105, (byte) 144, (byte) 101, (byte) 112, (byte) 105, (byte) 144, (byte) 101, (byte) 112, (byte) 127, (byte) 26, (byte) 109, (byte) 105, (byte) 121, (byte) 127, (byte) 3, (byte) 105, (byte) 144, (byte) 98, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 127, (byte) 26, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 159, (byte) 31, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 107, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 127, (byte) 5, (byte) 159, (byte) 19, (byte) 127, (byte) 26, (byte) 112, (byte) 112, (byte) 112, (byte) 139, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 103, (byte) 120, (byte) 40, (byte) 200, (byte) 112, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doClasses(params Class[] _param1)
    {
      // ISSUE: unable to decompile the method.
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 37, (byte) 108, (byte) 110, (byte) 104, (byte) 126, (byte) 109, (byte) 101, (byte) 113, (byte) 101, (byte) 113, (byte) 101, (byte) 113, (byte) 106, (byte) 142, (byte) 103, (byte) 108, (byte) 123, (byte) 108, (byte) 108, (byte) 108, (byte) 232, (byte) 45, (byte) 233, (byte) 87})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string mangle(string name)
    {
      StringBuilder stringBuilder = new StringBuilder(String.instancehelper_length(name));
      for (int index = 0; index < String.instancehelper_length(name); ++index)
      {
        int num = (int) String.instancehelper_charAt(name, index);
        if (num >= 48 && num <= 57 || num >= 65 && num <= 90 || num >= 97 && num <= 122)
          stringBuilder.append((char) num);
        else if (num == 95)
          stringBuilder.append("_1");
        else if (num == 59)
          stringBuilder.append("_2");
        else if (num == 91)
          stringBuilder.append("_3");
        else if (num == 46 || num == 47)
        {
          stringBuilder.append("_");
        }
        else
        {
          string str = Integer.toHexString(num);
          stringBuilder.append("_0");
          switch (String.instancehelper_length(str))
          {
            case 1:
              stringBuilder.append("0");
              goto case 2;
            case 2:
              stringBuilder.append("0");
              goto case 3;
            case 3:
              stringBuilder.append("0");
              break;
          }
          stringBuilder.append(str);
        }
      }
      return stringBuilder.toString();
    }

    [Signature("(Ljava/lang/Class<*>;)Ljava/lang/String;")]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 154, (byte) 112, (byte) 102, (byte) 120, (byte) 102, (byte) 120, (byte) 102, (byte) 120, (byte) 102, (byte) 120, (byte) 102, (byte) 120, (byte) 102, (byte) 120, (byte) 102, (byte) 120, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 105, (byte) 109, (byte) 159, (byte) 18, (byte) 102, (byte) 102, (byte) 113, (byte) 113, (byte) 112, (byte) 145, (byte) 99, (byte) 104, (byte) 153, (byte) 136, (byte) 104, (byte) 133, (byte) 191, (byte) 3, (byte) 104, (byte) 100, (byte) 105, (byte) 159, (byte) 2, (byte) 104, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getCPPTypeName(Class type)
    {
      if (type == ClassLiteral<Buffer>.Value || type == ClassLiteral<Pointer>.Value)
        return "void*";
      if (type == ClassLiteral<byte[]>.Value || type == ClassLiteral<ByteBuffer>.Value || type == ClassLiteral<BytePointer>.Value)
        return "signed char*";
      if (type == ClassLiteral<short[]>.Value || type == ClassLiteral<ShortBuffer>.Value || type == ClassLiteral<ShortPointer>.Value)
        return "short*";
      if (type == ClassLiteral<int[]>.Value || type == ClassLiteral<IntBuffer>.Value || type == ClassLiteral<IntPointer>.Value)
        return "int*";
      if (type == ClassLiteral<long[]>.Value || type == ClassLiteral<LongBuffer>.Value || type == ClassLiteral<LongPointer>.Value)
        return "jlong*";
      if (type == ClassLiteral<float[]>.Value || type == ClassLiteral<FloatBuffer>.Value || type == ClassLiteral<FloatPointer>.Value)
        return "float*";
      if (type == ClassLiteral<double[]>.Value || type == ClassLiteral<DoubleBuffer>.Value || type == ClassLiteral<DoublePointer>.Value)
        return "double*";
      if (type == ClassLiteral<char[]>.Value || type == ClassLiteral<CharBuffer>.Value || type == ClassLiteral<CharPointer>.Value)
        return "unsigned short*";
      if (type == ClassLiteral<PointerPointer>.Value)
        return "void**";
      if (type == ClassLiteral<String>.Value)
        return "const char*";
      if (type == Byte.TYPE)
        return "signed char";
      if (type == Character.TYPE)
        return "unsigned short";
      if (type == Long.TYPE)
        return "jlong";
      if (type == Boolean.TYPE)
        return "unsigned char";
      if (type.isPrimitive())
        return type.getName();
      else if (((Class) ClassLiteral<FunctionPointer>.Value).isAssignableFrom(type))
      {
        return new StringBuilder().append("JavaCPP_").append(Generator.mangle(type.getName())).append("*").toString();
      }
      else
      {
        string str1 = "";
        for (; type != null; type = type.getDeclaringClass())
        {
          Namespace @namespace = (Namespace) type.getAnnotation((Class) ClassLiteral<Namespace>.Value);
          string str2 = @namespace == null ? "" : @namespace.value();
          if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(type))
          {
            Name name1 = (Name) type.getAnnotation((Class) ClassLiteral<Name>.Value);
            string str3;
            if (name1 == null)
            {
              string name2 = type.getName();
              str3 = String.instancehelper_substring(name2, String.instancehelper_lastIndexOf(name2, "$") + 1);
            }
            else
              str3 = name1.value();
            str2 = String.instancehelper_length(str2) != 0 ? new StringBuilder().append(str2).append("::").append(str3).toString() : str3;
          }
          if (String.instancehelper_length(str1) == 0)
            str1 = str2;
          else if (String.instancehelper_length(str2) > 0)
            str1 = new StringBuilder().append(str2).append("::").append(str1).toString();
        }
        return new StringBuilder().append(str1).append("*").toString();
      }
    }

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 65, (byte) 145, (byte) 98, (byte) 99, (byte) 120, (byte) 106, (byte) 2, (byte) 234, (byte) 69, (byte) 120, (byte) 130, (byte) 99, (byte) 161, (byte) 135, (byte) 115, (byte) 191, (byte) 16, (byte) 100, (byte) 149, (byte) 110, (byte) 205, (byte) 109, (byte) 106, (byte) 159, (byte) 3, (byte) 235, (byte) 61, (byte) 232, (byte) 71, (byte) 109, (byte) 106, (byte) 107, (byte) 109, (byte) 124, (byte) 133, (byte) 108, (byte) 100, (byte) 133, (byte) 159, (byte) 24, (byte) 159, (byte) 14, (byte) 112, (byte) 207, (byte) 103, (byte) 171, (byte) 159, (byte) 34, (byte) 105, (byte) 159, (byte) 22, (byte) 110, (byte) 146, (byte) 144, (byte) 111, (byte) 63, (byte) 37, (byte) 168, (byte) 144, (byte) 103, (byte) 107, (byte) 101, (byte) 191, (byte) 22, (byte) 104, (byte) 159, (byte) 3, (byte) 159, (byte) 44, (byte) 112, (byte) 127, (byte) 31, (byte) 112, (byte) 118, (byte) 112, (byte) 109, (byte) 159, (byte) 19, (byte) 240, (byte) 69, (byte) 111, (byte) 111, (byte) 108, (byte) 107, (byte) 111, (byte) 107, (byte) 108, (byte) 110, (byte) 144, (byte) 240, (byte) 159, (byte) 186, (byte) 235, (byte) 160, (byte) 72, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doMethods([In] Class obj0)
    {
      Properties properties = (Properties) obj0.getAnnotation((Class) ClassLiteral<Properties>.Value);
      int num1 = 0;
      if (properties != null)
      {
        Platform[] platformArray = properties.value();
        int length = platformArray.Length;
        for (int index = 0; index < length; ++index)
        {
          if (this.checkPlatform(platformArray[index]))
            num1 = 1;
        }
      }
      else if (this.checkPlatform((Platform) obj0.getAnnotation((Class) ClassLiteral<Platform>.Value)))
        num1 = 1;
      if (num1 == 0)
        return;
      this.generatedSomethingUseful = true;
      LinkedList linkedList = (LinkedList) this.members.get((object) obj0);
      if ((!obj0.isAnnotationPresent((Class) ClassLiteral<Opaque>.Value) || obj0 == ClassLiteral<Pointer>.Value) && (!((Class) ClassLiteral<FunctionPointer>.Value).isAssignableFrom(obj0) && !obj0.isAnnotationPresent((Class) ClassLiteral<NoOffset>.Value)))
      {
        if (linkedList == null)
          this.members.put((object) obj0, (object) (linkedList = new LinkedList()));
        if (!linkedList.contains((object) "sizeof"))
          linkedList.add((object) "sizeof");
      }
      Class[] declaredClasses = obj0.getDeclaredClasses(Generator.__\u003CGetCallerID\u003E());
      for (int index = 0; index < declaredClasses.Length; ++index)
      {
        if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(declaredClasses[index]) || ((Class) ClassLiteral<Pointer.Deallocator>.Value).isAssignableFrom(declaredClasses[index]))
          this.doMethods(declaredClasses[index]);
      }
      Method[] declaredMethods = obj0.getDeclaredMethods(Generator.__\u003CGetCallerID\u003E());
      bool[] flagArray1 = new bool[declaredMethods.Length];
      Method method = this.doFunctionDefinitions(obj0, flagArray1);
      for (int index1 = 0; index1 < declaredMethods.Length; ++index1)
      {
        if (this.checkPlatform((Platform) declaredMethods[index1].getAnnotation((Class) ClassLiteral<Platform>.Value)))
        {
          Generator.MethodInformation methodInformation = Generator.getMethodInformation(declaredMethods[index1]);
          if (methodInformation != null)
          {
            string str1 = new StringBuilder().append(Generator.mangle(obj0.getName())).append("_").append(Generator.mangle(methodInformation.name)).toString();
            if ((methodInformation.memberGetter || methodInformation.memberSetter) && (!methodInformation.noOffset && linkedList != null) && (!Modifier.isStatic(methodInformation.modifiers) && !linkedList.contains((object) methodInformation.memberName)))
              linkedList.add((object) methodInformation.memberName);
            if (flagArray1[index1])
              this.doCallback(obj0, method, str1);
            this.@out.print(new StringBuilder().append("JNIEXPORT ").append(Generator.getJNITypeName(methodInformation.returnType)).append(" JNICALL Java_").append(str1).toString());
            if (methodInformation.overloaded)
              this.@out.print(new StringBuilder().append("__").append(Generator.mangle(Generator.getSignature(methodInformation.parameterTypes))).toString());
            if (Modifier.isStatic(methodInformation.modifiers))
              this.@out.print("(JNIEnv *e, jclass c");
            else
              this.@out.print("(JNIEnv *e, jobject o");
            for (int index2 = 0; index2 < methodInformation.parameterTypes.Length; ++index2)
              this.@out.print(new StringBuilder().append(", ").append(Generator.getJNITypeName(methodInformation.parameterTypes[index2])).append(" p").append(index2).toString());
            this.@out.println(") {");
            if (flagArray1[index1])
            {
              this.doCallbackAllocator(obj0, method, str1);
            }
            else
            {
              if (!Modifier.isStatic(methodInformation.modifiers) && !methodInformation.allocator && (!methodInformation.arrayAllocator && !methodInformation.deallocator))
              {
                string cppTypeName = Generator.getCPPTypeName(obj0);
                string str2 = !methodInformation.bufferGetter || !String.instancehelper_equals("void*", (object) cppTypeName) ? cppTypeName : "char*";
                this.@out.println(new StringBuilder().append("    ").append(str2).append(" pointer = (").append(str2).append(")").append("jlong_to_ptr(e->GetLongField(o, JavaCPP_addressFieldID));").toString());
                this.@out.println("    if (JavaCPP_checkNull(e, (uintptr_t)pointer)) {");
                this.@out.println(new StringBuilder().append("        return").append(methodInformation.returnType != Void.TYPE ? " 0;" : ";").toString());
                this.@out.println("    }");
                if (!obj0.isAnnotationPresent((Class) ClassLiteral<Opaque>.Value) || methodInformation.bufferGetter)
                {
                  this.@out.println("    jint position = e->GetIntField(o, JavaCPP_positionFieldID);");
                  if (((Class) ClassLiteral<FunctionPointer>.Value).isAssignableFrom(obj0))
                    this.@out.println(new StringBuilder().append("    pointer = position == 0 ? pointer : (").append(str2).append(")((uintptr_t)pointer + position);").toString());
                  else
                    this.@out.println("    pointer += position;");
                }
              }
              bool[] flagArray2 = new bool[methodInformation.parameterTypes.Length];
              bool[] flagArray3 = new bool[methodInformation.parameterTypes.Length];
              this.doParametersBefore(methodInformation, flagArray2, flagArray3);
              string str3 = this.doReturnBefore(obj0, methodInformation);
              int num2 = this.doMainOperation(obj0, methodInformation, str3, flagArray2) ? 1 : 0;
              this.doReturnAfter(obj0, methodInformation, num2 != 0);
              this.doParametersAfter(methodInformation, num2 != 0, flagArray3);
              if (methodInformation.returnType != Void.TYPE)
                this.@out.println("    return r;");
              this.@out.println("}");
            }
          }
        }
      }
      this.@out.println();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 167, (byte) 99, (byte) 130, (byte) 113, (byte) 121, (byte) 111, (byte) 103, (byte) 122, (byte) 106, (byte) 100, (byte) 226, (byte) 61, (byte) 40, (byte) 230, (byte) 72, (byte) 118, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool checkPlatform(Platform platform)
    {
      if (platform == null)
        return true;
      string property = this.properties.getProperty("platform.name");
      string[][] strArray1 = new string[2][];
      int index1 = 0;
      string[] strArray2 = platform.value();
      strArray1[index1] = strArray2;
      int index2 = 1;
      string[] strArray3 = platform.not();
      strArray1[index2] = strArray3;
      string[][] strArray4 = strArray1;
      bool[] flagArray1 = new bool[2];
      int index3 = 0;
      int num1 = 0;
      flagArray1[index3] = num1 != 0;
      int index4 = 1;
      int num2 = 0;
      flagArray1[index4] = num2 != 0;
      bool[] flagArray2 = flagArray1;
      for (int index5 = 0; index5 < strArray4.Length; ++index5)
      {
        string[] strArray5 = strArray4[index5];
        int length = strArray5.Length;
        for (int index6 = 0; index6 < length; ++index6)
        {
          string str = strArray5[index6];
          if (String.instancehelper_startsWith(property, str))
          {
            flagArray2[index5] = true;
            break;
          }
        }
      }
      return (strArray4[0].Length == 0 || flagArray2[0]) && (strArray4[1].Length == 0 || !flagArray2[1]);
    }

    [Signature("(Ljava/lang/Class<*>;[Z)Ljava/lang/reflect/Method;")]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 234, (byte) 109, (byte) 130, (byte) 108, (byte) 113, (byte) 159, (byte) 11, (byte) 98, (byte) 108, (byte) 107, (byte) 107, (byte) 107, (byte) 107, (byte) 114, (byte) 130, (byte) 156, (byte) 103, (byte) 142, (byte) 229, (byte) 51, (byte) 235, (byte) 80, (byte) 102, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 107, (byte) 159, (byte) 61, (byte) 109, (byte) 113, (byte) 127, (byte) 23, (byte) 105, (byte) 253, (byte) 60, (byte) 235, (byte) 71, (byte) 159, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Method doFunctionDefinitions([In] Class obj0, [In] bool[] obj1)
    {
      if (!((Class) ClassLiteral<FunctionPointer>.Value).isAssignableFrom(obj0))
        return (Method) null;
      Method[] declaredMethods = obj0.getDeclaredMethods(Generator.__\u003CGetCallerID\u003E());
      Convention convention = (Convention) obj0.getAnnotation((Class) ClassLiteral<Convention>.Value);
      string str1 = convention != null ? new StringBuilder().append(convention.value()).append(" ").toString() : "";
      Method method = (Method) null;
      for (int index = 0; index < declaredMethods.Length; ++index)
      {
        string name = declaredMethods[index].getName();
        int modifiers = declaredMethods[index].getModifiers();
        Class[] parameterTypes = declaredMethods[index].getParameterTypes();
        Class returnType = declaredMethods[index].getReturnType();
        if (Modifier.isNative(modifiers) && !Modifier.isStatic(modifiers))
        {
          if (String.instancehelper_startsWith(name, "allocate") && returnType == Void.TYPE && parameterTypes.Length == 0)
            obj1[index] = true;
          else if (String.instancehelper_startsWith(name, "call"))
            method = declaredMethods[index];
        }
      }
      if (method != null)
      {
        Class returnType = method.getReturnType();
        Class[] parameterTypes = method.getParameterTypes();
        Annotation[] annotations = ((AccessibleObject) method).getAnnotations();
        Annotation[][] parameterAnnotations = method.getParameterAnnotations();
        string[] annotatedCppTypeName1 = Generator.getAnnotatedCPPTypeName(annotations, returnType);
        string str2 = new StringBuilder().append("typedef ").append(annotatedCppTypeName1[0]).append(annotatedCppTypeName1[1]).append(" (").append(str1).append("JavaCPP_").append(Generator.mangle(obj0.getName())).append(")(").toString();
        for (int index = 0; index < parameterTypes.Length; ++index)
        {
          string[] annotatedCppTypeName2 = Generator.getAnnotatedCPPTypeName(parameterAnnotations[index], parameterTypes[index]);
          str2 = new StringBuilder().append(str2).append(annotatedCppTypeName2[0]).append(annotatedCppTypeName2[1]).append(" p").append(index).toString();
          if (index < parameterTypes.Length - 1)
            str2 = new StringBuilder().append(str2).append(", ").toString();
        }
        this.functionDefinitions.register((object) new StringBuilder().append(str2).append(");").toString());
      }
      return method;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 200, (byte) 109, (byte) 130, (byte) 102, (byte) 103, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 113, (byte) 99, (byte) 108, (byte) 140, (byte) 108, (byte) 108, (byte) 135, (byte) 113, (byte) 99, (byte) 110, (byte) 127, (byte) 1, (byte) 98, (byte) 109, (byte) 227, (byte) 60, (byte) 232, (byte) 72, (byte) 159, (byte) 1, (byte) 191, (byte) 19, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 99, (byte) 114, (byte) 109, (byte) 103, (byte) 105, (byte) 105, (byte) 105, (byte) 137, (byte) 118, (byte) 165, (byte) 159, (byte) 31, (byte) 99, (byte) 105, (byte) 159, (byte) 32, (byte) 99, (byte) 105, (byte) 114, (byte) 135, (byte) 99, (byte) 117, (byte) 112, (byte) 3, (byte) 232, (byte) 69, (byte) 159, (byte) 6, (byte) 99, (byte) 102, (byte) 159, (byte) 11, (byte) 99, (byte) 228, (byte) 29, (byte) 235, (byte) 104, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 107, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 124, (byte) 134, (byte) 191, (byte) 53, (byte) 108, (byte) 118, (byte) 108, (byte) 118, (byte) 124, (byte) 191, (byte) 58, (byte) 108, (byte) 100, (byte) 103, (byte) 109, (byte) 100, (byte) 103, (byte) 109, (byte) 100, (byte) 103, (byte) 106, (byte) 100, (byte) 103, (byte) 170, (byte) 159, (byte) 36, (byte) 162, (byte) 107, (byte) 118, (byte) 99, (byte) 108, (byte) 172, (byte) 113, (byte) 112, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Generator.MethodInformation getMethodInformation(Method method)
    {
      if (!Modifier.isNative(method.getModifiers()))
        return (Generator.MethodInformation) null;
      Generator.MethodInformation methodInformation1 = new Generator.MethodInformation();
      methodInformation1.method = method;
      methodInformation1.annotations = ((AccessibleObject) method).getAnnotations();
      methodInformation1.modifiers = method.getModifiers();
      methodInformation1.returnType = method.getReturnType();
      methodInformation1.name = method.getName();
      methodInformation1.memberName = methodInformation1.name;
      Name name1 = (Name) method.getAnnotation((Class) ClassLiteral<Name>.Value);
      if (name1 != null)
      {
        methodInformation1.memberName = name1.value();
        methodInformation1.memberNameSuffix = name1.suffix();
      }
      methodInformation1.parameterTypes = method.getParameterTypes();
      methodInformation1.parameterAnnotations = method.getParameterAnnotations();
      Class behavior = Generator.getBehavior(method);
      int num1 = methodInformation1.returnType != Void.TYPE ? 1 : 0;
      int num2 = 1;
      for (int index = 0; index < methodInformation1.parameterTypes.Length; ++index)
      {
        if (methodInformation1.parameterTypes[index] != Integer.TYPE && methodInformation1.parameterTypes[index] != Long.TYPE)
        {
          num1 = 0;
          if (index < methodInformation1.parameterTypes.Length - 1)
            num2 = 0;
        }
      }
      int num3 = Modifier.isStatic(methodInformation1.modifiers) || methodInformation1.returnType != Void.TYPE ? 0 : 1;
      int num4 = num3 == 0 || methodInformation1.parameterTypes.Length != 1 || methodInformation1.parameterTypes[0] != Integer.TYPE && methodInformation1.parameterTypes[0] != Long.TYPE ? 0 : 1;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      int num8 = 0;
      Method method1 = (Method) null;
      foreach (Method method2 in method.getDeclaringClass().getDeclaredMethods(Generator.__\u003CGetCallerID\u003E()))
      {
        int modifiers = method2.getModifiers();
        Class returnType = method2.getReturnType();
        string name2 = method2.getName();
        Class[] parameterTypes = method2.getParameterTypes();
        if (!method.equals((object) method2) && Modifier.isNative(modifiers))
        {
          if (String.instancehelper_equals("get", (object) methodInformation1.name) && String.instancehelper_equals("put", (object) name2) && (methodInformation1.parameterTypes.Length == 0 && parameterTypes.Length == 1) && (parameterTypes[0] == methodInformation1.returnType && num1 != 0))
          {
            num5 = 1;
            method1 = method2;
          }
          else if (String.instancehelper_equals("put", (object) methodInformation1.name) && String.instancehelper_equals("get", (object) name2) && (methodInformation1.parameterTypes.Length == 1 && parameterTypes.Length == 0) && (methodInformation1.parameterTypes[0] == returnType && num2 != 0))
          {
            num6 = 1;
            method1 = method2;
          }
          else if (String.instancehelper_equals(name2, (object) methodInformation1.name))
          {
            methodInformation1.overloaded = true;
            int num9 = 1;
            for (int index = 0; index < methodInformation1.parameterTypes.Length && index < parameterTypes.Length; ++index)
            {
              if (methodInformation1.parameterTypes[index] != parameterTypes[index])
                num9 = 0;
            }
            if (num9 != 0 && parameterTypes.Length - 1 == methodInformation1.parameterTypes.Length && (methodInformation1.returnType == parameterTypes[parameterTypes.Length - 1] && num1 != 0))
            {
              num7 = 1;
              method1 = method2;
            }
            else if (num9 != 0 && methodInformation1.parameterTypes.Length - 1 == parameterTypes.Length && (returnType == methodInformation1.parameterTypes[methodInformation1.parameterTypes.Length - 1] && num2 != 0))
            {
              num8 = 1;
              method1 = method2;
            }
          }
        }
      }
      if (num1 != 0 && behavior == ClassLiteral<ValueGetter>.Value)
        methodInformation1.valueGetter = true;
      else if (num2 != 0 && behavior == ClassLiteral<ValueSetter>.Value)
        methodInformation1.valueSetter = true;
      else if (num1 != 0 && behavior == ClassLiteral<MemberGetter>.Value)
        methodInformation1.memberGetter = true;
      else if (num2 != 0 && behavior == ClassLiteral<MemberSetter>.Value)
        methodInformation1.memberSetter = true;
      else if (num3 != 0 && behavior == ClassLiteral<Allocator>.Value)
        methodInformation1.allocator = true;
      else if (num4 != 0 && behavior == ClassLiteral<ArrayAllocator>.Value)
      {
        Generator.MethodInformation methodInformation2 = methodInformation1;
        Generator.MethodInformation methodInformation3 = methodInformation1;
        int num9 = 1;
        Generator.MethodInformation methodInformation4 = methodInformation3;
        int num10 = num9;
        methodInformation4.arrayAllocator = num9 != 0;
        methodInformation2.allocator = num10 != 0;
      }
      else if (behavior == null)
      {
        if (methodInformation1.returnType == Void.TYPE && String.instancehelper_equals("deallocate", (object) methodInformation1.name) && (!Modifier.isStatic(methodInformation1.modifiers) && methodInformation1.parameterTypes.Length == 2) && (methodInformation1.parameterTypes[0] == Long.TYPE && methodInformation1.parameterTypes[1] == Long.TYPE))
          methodInformation1.deallocator = true;
        else if (num3 != 0 && String.instancehelper_equals("allocate", (object) methodInformation1.name))
          methodInformation1.allocator = true;
        else if (num4 != 0 && String.instancehelper_equals("allocateArray", (object) methodInformation1.name))
        {
          Generator.MethodInformation methodInformation2 = methodInformation1;
          Generator.MethodInformation methodInformation3 = methodInformation1;
          int num9 = 1;
          Generator.MethodInformation methodInformation4 = methodInformation3;
          int num10 = num9;
          methodInformation4.arrayAllocator = num9 != 0;
          methodInformation2.allocator = num10 != 0;
        }
        else if (methodInformation1.returnType.isAssignableFrom((Class) ClassLiteral<ByteBuffer>.Value) && String.instancehelper_equals("asDirectBuffer", (object) methodInformation1.name) && (!Modifier.isStatic(methodInformation1.modifiers) && methodInformation1.parameterTypes.Length == 1) && (methodInformation1.parameterTypes[0] == Integer.TYPE || methodInformation1.parameterTypes[0] == Long.TYPE))
          methodInformation1.bufferGetter = true;
        else if (num5 != 0)
        {
          methodInformation1.valueGetter = true;
          methodInformation1.pairedMethod = method1;
        }
        else if (num6 != 0)
        {
          methodInformation1.valueSetter = true;
          methodInformation1.pairedMethod = method1;
        }
        else if (num7 != 0)
        {
          methodInformation1.memberGetter = true;
          methodInformation1.pairedMethod = method1;
        }
        else if (num8 != 0)
        {
          methodInformation1.memberSetter = true;
          methodInformation1.pairedMethod = method1;
        }
      }
      else
      {
        Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("Method \"").append((object) method).append("\" cannot behave like a \"").append((object) behavior).append("\". No code will be generated.").toString());
        return (Generator.MethodInformation) null;
      }
      if (name1 == null && methodInformation1.pairedMethod != null)
      {
        Name name2 = (Name) methodInformation1.pairedMethod.getAnnotation((Class) ClassLiteral<Name>.Value);
        if (name2 != null)
        {
          methodInformation1.memberName = name2.value();
          methodInformation1.memberNameSuffix = name2.suffix();
        }
      }
      methodInformation1.noOffset = ((AccessibleObject) method).isAnnotationPresent((Class) ClassLiteral<NoOffset>.Value);
      if (!methodInformation1.noOffset && methodInformation1.pairedMethod != null)
        methodInformation1.noOffset = ((AccessibleObject) methodInformation1.pairedMethod).isAnnotationPresent((Class) ClassLiteral<NoOffset>.Value);
      return methodInformation1;
    }

    [Signature("(Ljava/lang/Class<*>;Ljava/lang/reflect/Method;Ljava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 23, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 114, (byte) 159, (byte) 14, (byte) 127, (byte) 17, (byte) 127, (byte) 16, (byte) 105, (byte) 127, (byte) 61, (byte) 108, (byte) 111, (byte) 127, (byte) 25, (byte) 104, (byte) 240, (byte) 60, (byte) 235, (byte) 71, (byte) 112, (byte) 103, (byte) 104, (byte) 127, (byte) 21, (byte) 135, (byte) 112, (byte) 112, (byte) 127, (byte) 21, (byte) 127, (byte) 61, (byte) 112, (byte) 104, (byte) 127, (byte) 17, (byte) 108, (byte) 115, (byte) 107, (byte) 127, (byte) 17, (byte) 127, (byte) 17, (byte) 114, (byte) 127, (byte) 19, (byte) 137, (byte) 159, (byte) 19, (byte) 159, (byte) 17, (byte) 159, (byte) 38, (byte) 114, (byte) 143, (byte) 127, (byte) 17, (byte) 127, (byte) 7, (byte) 144, (byte) 127, (byte) 17, (byte) 127, (byte) 34, (byte) 112, (byte) 127, (byte) 34, (byte) 115, (byte) 127, (byte) 51, (byte) 127, (byte) 39, (byte) 107, (byte) 191, (byte) 65, (byte) 255, (byte) 44, (byte) 31, (byte) 235, (byte) 103, (byte) 106, (byte) 157, (byte) 103, (byte) 104, (byte) 104, (byte) 159, (byte) 12, (byte) 223, (byte) 87, (byte) 108, (byte) 115, (byte) 107, (byte) 117, (byte) 127, (byte) 34, (byte) 105, (byte) 159, (byte) 9, (byte) 159, (byte) 7, (byte) 111, (byte) 119, (byte) 191, (byte) 43, (byte) 107, (byte) 255, (byte) 17, (byte) 48, (byte) 235, (byte) 84, (byte) 107, (byte) 109, (byte) 105, (byte) 223, (byte) 33, (byte) 109, (byte) 105, (byte) 159, (byte) 33, (byte) 104, (byte) 159, (byte) 23, (byte) 223, (byte) 41, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doCallback([In] Class obj0, [In] Method obj1, [In] string obj2)
    {
      Class returnType = obj1.getReturnType();
      Class[] parameterTypes = obj1.getParameterTypes();
      Annotation[] annotations = ((AccessibleObject) obj1).getAnnotations();
      Annotation[][] parameterAnnotations = obj1.getParameterAnnotations();
      Convention convention = (Convention) obj0.getAnnotation((Class) ClassLiteral<Convention>.Value);
      string str1 = convention != null ? new StringBuilder().append(convention.value()).append(" ").toString() : "";
      this.functionPointers.register((object) new StringBuilder().append("JavaCPP_").append(obj2).append("_instance").toString());
      this.@out.println(new StringBuilder().append("static jmethodID JavaCPP_").append(obj2).append("_callMethodID = NULL;").toString());
      string[] annotatedCppTypeName1 = Generator.getAnnotatedCPPTypeName(annotations, returnType);
      this.@out.print(new StringBuilder().append("static ").append(annotatedCppTypeName1[0]).append(annotatedCppTypeName1[1]).append(" ").append(str1).append("JavaCPP_").append(obj2).append("_callback(").toString());
      for (int index = 0; index < parameterTypes.Length; ++index)
      {
        string[] annotatedCppTypeName2 = Generator.getAnnotatedCPPTypeName(parameterAnnotations[index], parameterTypes[index]);
        this.@out.print(new StringBuilder().append(annotatedCppTypeName2[0]).append(annotatedCppTypeName2[1]).append(" p").append(index).toString());
        if (index < parameterTypes.Length - 1)
          this.@out.print(", ");
      }
      this.@out.println(") {");
      string str2 = "";
      if (returnType != Void.TYPE)
      {
        this.@out.println(new StringBuilder().append("    ").append(Generator.getJNITypeName(returnType)).append(" r = 0;").toString());
        str2 = "r";
      }
      this.@out.println("    JNIEnv *e;");
      this.@out.println("    if (JavaCPP_vm->AttachCurrentThread((void **)&e, NULL) != JNI_OK) {");
      this.@out.println(new StringBuilder().append("        fprintf(stderr, \"Could not attach the JavaVM to the current thread in callback for ").append(obj0.getName()).append(".\");").toString());
      this.@out.println(new StringBuilder().append("        return").append(returnType != Void.TYPE ? new StringBuilder().append(" ").append(Generator.getCast(annotations)).append("0;").toString() : ";").toString());
      this.@out.println("    }");
      if (parameterTypes.Length > 0)
      {
        this.@out.println(new StringBuilder().append("    jvalue args[").append(parameterTypes.Length).append("];").toString());
        for (int index = 0; index < parameterTypes.Length; ++index)
        {
          if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(parameterTypes[index]))
          {
            Class by = Generator.getBy(parameterAnnotations[index]);
            this.@out.println(new StringBuilder().append("    jobject o").append(index).append(" = NULL;").toString());
            this.@out.print(new StringBuilder().append("    void *pointer").append(index).append(" = (void*)").toString());
            if (by == ClassLiteral<ByVal>.Value || by == ClassLiteral<ByRef>.Value)
              this.@out.println(new StringBuilder().append("&p").append(index).append(";").toString());
            else if (by == ClassLiteral<ByPtrPtr>.Value)
              this.@out.println(new StringBuilder().append("*p").append(index).append(";").toString());
            else
              this.@out.println(new StringBuilder().append("p").append(index).append(";").toString());
            string str3 = new StringBuilder().append("    o").append(index).append(" = e->AllocObject(JavaCPP_getClass(e, ").append(this.jclasses.register((object) parameterTypes[index])).append("));").toString();
            if (by == ClassLiteral<ByPtrPtr>.Value || by == ClassLiteral<ByPtrRef>.Value)
            {
              this.@out.println(str3);
            }
            else
            {
              this.@out.println(new StringBuilder().append("    if (pointer").append(index).append(" != NULL) { ").toString());
              this.@out.println(new StringBuilder().append("    ").append(str3).toString());
              this.@out.println("    }");
            }
            this.@out.println(new StringBuilder().append("    if (o").append(index).append(" != NULL) { ").toString());
            this.@out.println(new StringBuilder().append("        e->SetLongField(o").append(index).append(", JavaCPP_addressFieldID, ptr_to_jlong(pointer").append(index).append("));").toString());
            this.@out.println("    }");
            this.@out.println(new StringBuilder().append("    args[").append(index).append("].l = o").append(index).append(";").toString());
          }
          else if (parameterTypes[index] == ClassLiteral<String>.Value)
          {
            this.@out.println(new StringBuilder().append("    jstring o").append(index).append(" = p").append(index).append(" == NULL ? NULL : e->NewStringUTF(p").append(index).append(");").toString());
            this.@out.println(new StringBuilder().append("    args[").append(index).append("].l = o").append(index).append(";").toString());
          }
          else if (parameterTypes[index].isPrimitive())
            this.@out.println(new StringBuilder().append("    args[").append(index).append("].").append(String.instancehelper_toLowerCase(Generator.getSignature(parameterTypes[index]))).append(" = p").append(index).append(";").toString());
          else
            Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("Callback \"").append((object) obj1).append("\" has unsupported parameter type \"").append(parameterTypes[index].getCanonicalName()).append("\". Compilation will most likely fail.").toString());
        }
      }
      if (String.instancehelper_length(str2) > 0)
        str2 = new StringBuilder().append(str2).append(" = ").toString();
      string str4 = "Object";
      if (returnType.isPrimitive())
      {
        string name = returnType.getName();
        str4 = new StringBuilder().append(Character.toUpperCase(String.instancehelper_charAt(name, 0))).append(String.instancehelper_substring(name, 1)).toString();
      }
      this.@out.println(new StringBuilder().append("    ").append(str2).append("e->Call").append(str4).append("MethodA(JavaCPP_").append(obj2).append("_instance, JavaCPP_").append(obj2).append("_callMethodID, ").append(parameterTypes.Length != 0 ? "args);" : "NULL);").toString());
      for (int index = 0; index < parameterTypes.Length; ++index)
      {
        if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(parameterTypes[index]))
        {
          Class by = Generator.getBy(parameterAnnotations[index]);
          if (by == ClassLiteral<ByPtrPtr>.Value || by == ClassLiteral<ByPtrRef>.Value)
          {
            this.@out.println(new StringBuilder().append("    pointer").append(index).append(" = jlong_to_ptr(e->GetLongField(o").append(index).append(", JavaCPP_addressFieldID);").toString());
            if (by == ClassLiteral<ByPtrPtr>.Value)
              this.@out.print(new StringBuilder().append("    *p").append(index).toString());
            else
              this.@out.print(new StringBuilder().append("    p").append(index).toString());
            string[] annotatedCppTypeName2 = Generator.getAnnotatedCPPTypeName(parameterAnnotations[index], parameterTypes[index]);
            this.@out.println(new StringBuilder().append(" = (").append(String.instancehelper_substring(annotatedCppTypeName2[0], 0, String.instancehelper_length(annotatedCppTypeName2[0]) - 1)).append(annotatedCppTypeName2[1]).append(")pointer").append(index).append(";").toString());
          }
        }
        if (!parameterTypes[index].isPrimitive())
          this.@out.println(new StringBuilder().append("    e->DeleteLocalRef(o").append(index).append(");").toString());
      }
      if (returnType != Void.TYPE)
      {
        if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(returnType))
        {
          string[] annotatedCppTypeName2 = Generator.getAnnotatedCPPTypeName(annotations, returnType);
          this.@out.println(new StringBuilder().append("    return r == NULL ? NULL : (").append(annotatedCppTypeName2[0]).append(annotatedCppTypeName2[1]).append(")jlong_to_ptr(e->GetLongField(r, JavaCPP_addressFieldID));").toString());
        }
        else if (((Class) ClassLiteral<Buffer>.Value).isAssignableFrom(returnType))
        {
          string[] annotatedCppTypeName2 = Generator.getAnnotatedCPPTypeName(annotations, returnType);
          this.@out.println(new StringBuilder().append("    return r == NULL ? NULL : (").append(annotatedCppTypeName2[0]).append(annotatedCppTypeName2[1]).append(")e->GetDirectBufferAddress(r);").toString());
        }
        else if (returnType.isPrimitive())
          this.@out.println(new StringBuilder().append("    return ").append(Generator.getCast(annotations)).append("r;").toString());
        else
          Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("Callback \"").append((object) obj1).append("\" has unsupported return type \"").append(returnType.getCanonicalName()).append("\". Compilation will most likely fail.").toString());
      }
      this.@out.println("}");
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 218, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getJNITypeName(Class type)
    {
      if (type == Byte.TYPE)
        return "jbyte";
      if (type == Short.TYPE)
        return "jshort";
      if (type == Integer.TYPE)
        return "jint";
      if (type == Long.TYPE)
        return "jlong";
      if (type == Float.TYPE)
        return "jfloat";
      if (type == Double.TYPE)
        return "jdouble";
      if (type == Boolean.TYPE)
        return "jboolean";
      if (type == Character.TYPE)
        return "jchar";
      if (type == ClassLiteral<byte[]>.Value)
        return "jbyteArray";
      if (type == ClassLiteral<short[]>.Value)
        return "jshortArray";
      if (type == ClassLiteral<int[]>.Value)
        return "jintArray";
      if (type == ClassLiteral<long[]>.Value)
        return "jlongArray";
      if (type == ClassLiteral<float[]>.Value)
        return "jfloatArray";
      if (type == ClassLiteral<double[]>.Value)
        return "jdoubleArray";
      if (type == ClassLiteral<bool[]>.Value)
        return "jbooleanArray";
      if (type == ClassLiteral<char[]>.Value)
        return "jcharArray";
      if (type == ClassLiteral<String>.Value)
        return "jstring";
      return type == Void.TYPE ? "void" : "jobject";
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 4, (byte) 106, (byte) 103, (byte) 47, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getSignature(params Class[] types)
    {
      StringBuilder stringBuilder = new StringBuilder(2 * types.Length);
      for (int index = 0; index < types.Length; ++index)
        stringBuilder.append(Generator.getSignature(types[index]));
      return stringBuilder.toString();
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 149, (byte) 127, (byte) 16, (byte) 127, (byte) 16, (byte) 127, (byte) 16, (byte) 127, (byte) 21, (byte) 112, (byte) 112, (byte) 191, (byte) 89, (byte) 127, (byte) 16, (byte) 127, (byte) 16, (byte) 112, (byte) 112, (byte) 127, (byte) 16, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doCallbackAllocator([In] Class obj0, [In] Method obj1, [In] string obj2)
    {
      this.@out.println(new StringBuilder().append("    e->DeleteGlobalRef(JavaCPP_").append(obj2).append("_instance);").toString());
      this.@out.println(new StringBuilder().append("    JavaCPP_").append(obj2).append("_instance = e->NewGlobalRef(o);").toString());
      this.@out.println(new StringBuilder().append("    if (JavaCPP_").append(obj2).append("_instance == NULL) {").toString());
      this.@out.println(new StringBuilder().append("        fprintf(stderr, \"Error creating global reference of ").append(obj0.getName()).append(" instance for callback.\");").toString());
      this.@out.println("        return;");
      this.@out.println("    }");
      this.@out.println(new StringBuilder().append("    JavaCPP_").append(obj2).append("_callMethodID = e->GetMethodID(e->GetObjectClass(o), \"").append(obj1.getName()).append("\", \"(").append(Generator.getSignature(obj1.getParameterTypes())).append(")").append(Generator.getSignature(obj1.getReturnType())).append("\");").toString());
      this.@out.println(new StringBuilder().append("    if (JavaCPP_").append(obj2).append("_callMethodID == NULL) {").toString());
      this.@out.println(new StringBuilder().append("        fprintf(stderr, \"Error getting method ID of function caller \\\"").append((object) obj1).append("\\\" for callback.\");").toString());
      this.@out.println("        return;");
      this.@out.println("    }");
      this.@out.println(new StringBuilder().append("    e->SetLongField(o, JavaCPP_addressFieldID, ptr_to_jlong(&JavaCPP_").append(obj2).append("_callback));").toString());
      this.@out.println("}");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 183, (byte) 111, (byte) 110, (byte) 155, (byte) 145, (byte) 100, (byte) 142, (byte) 119, (byte) 159, (byte) 80, (byte) 159, (byte) 14, (byte) 159, (byte) 48, (byte) 119, (byte) 191, (byte) 101, (byte) 159, (byte) 37, (byte) 115, (byte) 137, (byte) 111, (byte) 159, (byte) 53, (byte) 114, (byte) 110, (byte) 104, (byte) 127, (byte) 12, (byte) 159, (byte) 86, (byte) 124, (byte) 159, (byte) 82, (byte) 111, (byte) 134, (byte) 255, (byte) 53, (byte) 24, (byte) 233, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doParametersBefore([In] Generator.MethodInformation obj0, [In] bool[] obj1, [In] bool[] obj2)
    {
      for (int index = 0; index < obj0.parameterTypes.Length; ++index)
      {
        Class by = Generator.getBy(obj0.parameterAnnotations[index]);
        if (by == null && obj0.pairedMethod != null && (obj0.valueSetter || obj0.memberSetter))
          by = Generator.getBy(((AccessibleObject) obj0.pairedMethod).getAnnotations());
        obj1[index] = true;
        string cppTypeName = Generator.getCPPTypeName(obj0.parameterTypes[index]);
        if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(obj0.parameterTypes[index]))
        {
          this.@out.println(new StringBuilder().append("    ").append(cppTypeName).append(" pointer").append(index).append(" = p").append(index).append(" == NULL ? NULL : (").append(cppTypeName).append(")jlong_to_ptr(e->GetLongField(p").append(index).append(", JavaCPP_addressFieldID));").toString());
          if (!obj0.parameterTypes[index].isAnnotationPresent((Class) ClassLiteral<Opaque>.Value) && by != ClassLiteral<ByPtrPtr>.Value && by != ClassLiteral<ByPtrRef>.Value)
          {
            this.@out.println(new StringBuilder().append("    jint position").append(index).append(" = p").append(index).append(" == NULL ? 0 : e->GetIntField(p").append(index).append(", JavaCPP_positionFieldID);").toString());
            if (((Class) ClassLiteral<FunctionPointer>.Value).isAssignableFrom(obj0.parameterTypes[index]))
              this.@out.println(new StringBuilder().append("    pointer").append(index).append(" = position").append(index).append(" == 0 ? pointer").append(index).append(" : (").append(cppTypeName).append(")((uintptr_t)pointer").append(index).append(" + position").append(index).append(");").toString());
            else
              this.@out.println(new StringBuilder().append("    pointer").append(index).append(" += position").append(index).append(";").toString());
          }
          else if (by == ClassLiteral<ByPtrPtr>.Value || by == ClassLiteral<ByPtrRef>.Value)
            obj2[index] = true;
        }
        else if (obj0.parameterTypes[index] == ClassLiteral<String>.Value)
          this.@out.println(new StringBuilder().append("    const char *pointer").append(index).append(" = p").append(index).append(" == NULL ? NULL : e->GetStringUTFChars(p").append(index).append(", NULL);").toString());
        else if (obj0.parameterTypes[index].isArray())
        {
          Class componentType = obj0.parameterTypes[index].getComponentType();
          string name = componentType.getName();
          string str = new StringBuilder().append(Character.toUpperCase(String.instancehelper_charAt(name, 0))).append(String.instancehelper_substring(name, 1)).toString();
          this.@out.println(new StringBuilder().append("    ").append(Generator.getJNITypeName(componentType)).append(" *pointer").append(index).append(" = p").append(index).append(" == NULL ? NULL : e->Get").append(str).append("ArrayElements(p").append(index).append(", NULL);").toString());
        }
        else if (((Class) ClassLiteral<Buffer>.Value).isAssignableFrom(obj0.parameterTypes[index]))
          this.@out.println(new StringBuilder().append("    ").append(cppTypeName).append(" pointer").append(index).append(" = p").append(index).append(" == NULL ? NULL : (").append(cppTypeName).append(")e->GetDirectBufferAddress(p").append(index).append(");").toString());
        else if (obj0.parameterTypes[index].isPrimitive())
          obj1[index] = false;
        else
          Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("Method \"").append((object) obj0.method).append("\" has unsupported parameter type \"").append(obj0.parameterTypes[index].getCanonicalName()).append("\". Compilation will most likely fail.").toString());
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 230, (byte) 102, (byte) 112, (byte) 103, (byte) 115, (byte) 159, (byte) 27, (byte) 112, (byte) 112, (byte) 127, (byte) 16, (byte) 134, (byte) 101, (byte) 114, (byte) 112, (byte) 117, (byte) 109, (byte) 112, (byte) 112, (byte) 107, (byte) 104, (byte) 112, (byte) 112, (byte) 107, (byte) 117, (byte) 108, (byte) 112, (byte) 107, (byte) 127, (byte) 36, (byte) 112, (byte) 139, (byte) 159, (byte) 21, (byte) 104, (byte) 117, (byte) 127, (byte) 35, (byte) 102, (byte) 109, (byte) 117, (byte) 127, (byte) 35, (byte) 102, (byte) 109, (byte) 117, (byte) 127, (byte) 35, (byte) 102, (byte) 98, (byte) 127, (byte) 36, (byte) 134, (byte) 117, (byte) 127, (byte) 26, (byte) 127, (byte) 36, (byte) 136, (byte) 223, (byte) 51})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string doReturnBefore([In] Class obj0, [In] Generator.MethodInformation obj1)
    {
      string str = "";
      if (obj1.returnType == Void.TYPE)
      {
        string cppTypeName = Generator.getCPPTypeName(obj0);
        if (obj1.allocator || obj1.arrayAllocator)
        {
          this.@out.println(new StringBuilder().append("    if (!e->IsSameObject(e->GetObjectClass(o), JavaCPP_getClass(e, ").append(this.jclasses.register((object) obj0)).append("))) {").toString());
          this.@out.println("        return;");
          this.@out.println("    }");
          this.@out.println(new StringBuilder().append("    ").append(cppTypeName).append(" rpointer;").toString());
          str = "rpointer = ";
        }
      }
      else
      {
        string[] annotatedCppTypeName = Generator.getAnnotatedCPPTypeName(obj1.annotations, obj1.returnType);
        if (obj1.valueSetter || obj1.memberSetter)
          this.@out.println("    jobject r = o;");
        else if (obj1.returnType == ClassLiteral<String>.Value)
        {
          this.@out.println("    jstring r = NULL;");
          this.@out.println("    const char *rpointer;");
          str = "rpointer = ";
        }
        else if (obj1.bufferGetter)
        {
          this.@out.println("    jobject r = NULL;");
          this.@out.println("    char *rpointer;");
          str = "rpointer = ";
        }
        else if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(obj1.returnType))
        {
          Class by = Generator.getBy(obj1.annotations);
          this.@out.println("    jobject r = NULL;");
          if (by == ClassLiteral<ByVal>.Value)
          {
            this.@out.println(new StringBuilder().append("    ").append(annotatedCppTypeName[0]).append("* rpointer").append(annotatedCppTypeName[1]).append(";").toString());
            str = obj1.valueGetter || obj1.memberGetter ? "rpointer = &" : new StringBuilder().append("rpointer = new ").append(annotatedCppTypeName[0]).append(annotatedCppTypeName[1]).append("(").toString();
          }
          else if (by == ClassLiteral<ByRef>.Value)
          {
            this.@out.println(new StringBuilder().append("    ").append(String.instancehelper_substring(annotatedCppTypeName[0], 0, String.instancehelper_length(annotatedCppTypeName[0]) - 1)).append("* rpointer").append(annotatedCppTypeName[1]).append(";").toString());
            str = "rpointer = &";
          }
          else if (by == ClassLiteral<ByPtrPtr>.Value)
          {
            this.@out.println(new StringBuilder().append("    ").append(String.instancehelper_substring(annotatedCppTypeName[0], 0, String.instancehelper_length(annotatedCppTypeName[0]) - 1)).append(" rpointer").append(annotatedCppTypeName[1]).append(";").toString());
            str = "rpointer = *";
          }
          else if (by == ClassLiteral<ByPtrRef>.Value)
          {
            this.@out.println(new StringBuilder().append("    ").append(String.instancehelper_substring(annotatedCppTypeName[0], 0, String.instancehelper_length(annotatedCppTypeName[0]) - 1)).append(" rpointer").append(annotatedCppTypeName[1]).append(";").toString());
            str = "rpointer = ";
          }
          else
          {
            this.@out.println(new StringBuilder().append("    ").append(annotatedCppTypeName[0]).append(" rpointer").append(annotatedCppTypeName[1]).append(";").toString());
            str = "rpointer = ";
          }
        }
        else if (obj1.returnType.isPrimitive())
        {
          this.@out.println(new StringBuilder().append("    ").append(Generator.getJNITypeName(obj1.returnType)).append(" r = 0;").toString());
          this.@out.println(new StringBuilder().append("    ").append(annotatedCppTypeName[0]).append(" rvalue").append(annotatedCppTypeName[1]).append(";").toString());
          str = "rvalue = ";
        }
        else
          Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("Method \"").append((object) obj1.method).append("\" has unsupported return type \"").append(obj1.returnType.getCanonicalName()).append("\". Compilation will most likely fail.").toString());
      }
      return str;
    }

    [Signature("(Ljava/lang/Class<*>;Lcom/googlecode/javacpp/Generator$MethodInformation;Ljava/lang/String;[Z)Z")]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 37, (byte) 98, (byte) 103, (byte) 112, (byte) 102, (byte) 104, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 98, (byte) 159, (byte) 4, (byte) 127, (byte) 6, (byte) 159, (byte) 8, (byte) 112, (byte) 136, (byte) 134, (byte) 109, (byte) 118, (byte) 112, (byte) 159, (byte) 16, (byte) 149, (byte) 104, (byte) 127, (byte) 16, (byte) 112, (byte) 139, (byte) 112, (byte) 98, (byte) 127, (byte) 6, (byte) 109, (byte) 117, (byte) 104, (byte) 127, (byte) 31, (byte) 122, (byte) 109, (byte) 105, (byte) 155, (byte) 159, (byte) 19, (byte) 223, (byte) 21, (byte) 113, (byte) 157, (byte) 104, (byte) 145, (byte) 119, (byte) 146, (byte) 146, (byte) 191, (byte) 1, (byte) 127, (byte) 17, (byte) 165, (byte) 112, (byte) 159, (byte) 6, (byte) 146, (byte) 159, (byte) 13, (byte) 127, (byte) 22, (byte) 106, (byte) 112, (byte) 156, (byte) 146, (byte) 146, (byte) 127, (byte) 26, (byte) 105, (byte) 159, (byte) 16, (byte) 159, (byte) 14, (byte) 98, (byte) 159, (byte) 14, (byte) 109, (byte) 240, (byte) 20, (byte) 235, (byte) 112, (byte) 120, (byte) 145, (byte) 109, (byte) 159, (byte) 2, (byte) 144, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool doMainOperation([In] Class obj0, [In] Generator.MethodInformation obj1, [In] string obj2, [In] bool[] obj3)
    {
      int num = 0;
      string cppTypeName = Generator.getCPPTypeName(obj0);
      string str1 = String.instancehelper_substring(cppTypeName, 0, String.instancehelper_length(cppTypeName) - 1);
      string str2 = ");";
      if (obj1.deallocator)
      {
        this.@out.println("    void *allocatedAddress = jlong_to_ptr(p0);");
        this.@out.println("    void (*deallocatorAddress)(void *) = (void(*)(void*))jlong_to_ptr(p1);");
        this.@out.println("    if (deallocatorAddress != NULL && allocatedAddress != NULL) {");
        this.@out.println("        (*deallocatorAddress)(allocatedAddress);");
        this.@out.println("    }");
        return false;
      }
      else
      {
        if (obj1.valueGetter || obj1.valueSetter || (obj1.memberGetter || obj1.memberSetter))
        {
          this.@out.print(new StringBuilder().append("    ").append(obj2).toString());
          if ((obj1.valueSetter || obj1.memberSetter) && ClassLiteral<String>.Value == obj1.parameterTypes[obj1.parameterTypes.Length - 1])
          {
            this.@out.print("strcpy(");
            str2 = ");";
          }
          else
            str2 = ";";
          if (Modifier.isStatic(obj1.modifiers))
            this.@out.print(obj1.memberName);
          else if (obj1.memberGetter || obj1.memberSetter)
            this.@out.print(new StringBuilder().append("pointer->").append(obj1.memberName).toString());
          else
            this.@out.print("*pointer");
        }
        else if (obj1.bufferGetter)
        {
          this.@out.println(new StringBuilder().append("    ").append(obj2).append("pointer;").toString());
          this.@out.print("    jlong capacity = ");
          str2 = ";";
        }
        else
        {
          this.@out.println("    try {");
          num = 1;
          this.@out.print(new StringBuilder().append("        ").append(obj2).toString());
          if (((Class) ClassLiteral<FunctionPointer>.Value).isAssignableFrom(obj0))
            this.@out.print("(*pointer)(");
          else if (obj1.allocator)
          {
            this.@out.print(new StringBuilder().append("new ").append(str1).append(!obj1.arrayAllocator ? "(" : "[").toString());
            str2 = !obj1.arrayAllocator ? ");" : "];";
          }
          else if (Modifier.isStatic(obj1.modifiers))
          {
            if (String.instancehelper_length(str1) > 0)
              str1 = new StringBuilder().append(str1).append("::").toString();
            this.@out.print(new StringBuilder().append(str1).append(obj1.memberName).append("(").toString());
          }
          else
            this.@out.print(new StringBuilder().append("pointer->").append(obj1.memberName).append("(").toString());
        }
        for (int index = 0; index < obj1.parameterTypes.Length; ++index)
        {
          if ((obj1.memberSetter || obj1.valueSetter) && index >= obj1.parameterTypes.Length - 1)
          {
            if (obj1.memberNameSuffix != null)
              this.@out.print(obj1.memberNameSuffix);
            if (ClassLiteral<String>.Value == obj1.parameterTypes[obj1.parameterTypes.Length - 1])
              this.@out.print(", ");
            else
              this.@out.print(" = ");
          }
          else if (obj1.valueGetter || obj1.valueSetter || (obj1.memberGetter || obj1.memberSetter))
          {
            this.@out.print(new StringBuilder().append("[p").append(index).append("]").toString());
            continue;
          }
          string cast = Generator.getCast(obj1.parameterAnnotations[index]);
          if ((cast == null || String.instancehelper_length(cast) == 0) && obj1.pairedMethod != null && (obj1.valueSetter || obj1.memberSetter))
            cast = Generator.getCast(((AccessibleObject) obj1.pairedMethod).getAnnotations());
          if ((String.instancehelper_equals("(void*)", (object) cast) || String.instancehelper_equals("(void *)", (object) cast)) && obj1.parameterTypes[index] == Long.TYPE)
            this.@out.print(new StringBuilder().append("jlong_to_ptr(p").append(index).append(")").toString());
          else if (obj3[index])
          {
            Class by = Generator.getBy(obj1.parameterAnnotations[index]);
            if (by == null && obj1.pairedMethod != null && (obj1.valueSetter || obj1.memberSetter))
              by = Generator.getBy(((AccessibleObject) obj1.pairedMethod).getAnnotations());
            if (by == ClassLiteral<ByVal>.Value || by == ClassLiteral<ByRef>.Value)
              this.@out.print(new StringBuilder().append("*").append(cast).append("pointer").append(index).toString());
            else if (by == ClassLiteral<ByPtrPtr>.Value)
              this.@out.print(new StringBuilder().append(cast).append("&pointer").append(index).toString());
            else
              this.@out.print(new StringBuilder().append(cast).append("pointer").append(index).toString());
          }
          else
            this.@out.print(new StringBuilder().append(cast).append("p").append(index).toString());
          if (index < obj1.parameterTypes.Length - 1)
            this.@out.print(", ");
        }
        if (!obj1.memberSetter && !obj1.valueSetter && obj1.memberNameSuffix != null)
          this.@out.print(obj1.memberNameSuffix);
        if (Generator.getBy(obj1.annotations) == ClassLiteral<ByVal>.Value && !obj1.valueGetter && (!obj1.memberGetter && !obj1.bufferGetter))
          this.@out.print(")");
        this.@out.println(str2);
        return num != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 205, (byte) 162, (byte) 112, (byte) 112, (byte) 115, (byte) 127, (byte) 6, (byte) 127, (byte) 6, (byte) 127, (byte) 22, (byte) 104, (byte) 112, (byte) 143, (byte) 112, (byte) 141, (byte) 223, (byte) 42, (byte) 152, (byte) 112, (byte) 127, (byte) 6, (byte) 127, (byte) 6, (byte) 127, (byte) 11, (byte) 107, (byte) 127, (byte) 6, (byte) 127, (byte) 6, (byte) 127, (byte) 11, (byte) 117, (byte) 108, (byte) 159, (byte) 8, (byte) 127, (byte) 6, (byte) 127, (byte) 6, (byte) 159, (byte) 8, (byte) 159, (byte) 6, (byte) 159, (byte) 38, (byte) 159, (byte) 13, (byte) 127, (byte) 6, (byte) 127, (byte) 6, (byte) 159, (byte) 37, (byte) 159, (byte) 37, (byte) 148, (byte) 159, (byte) 6, (byte) 127, (byte) 6, (byte) 111, (byte) 191, (byte) 34})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doReturnAfter([In] Class obj0, [In] Generator.MethodInformation obj1, [In] bool obj2)
    {
      string str = !obj2 ? "    " : "        ";
      if (obj1.returnType == Void.TYPE)
      {
        if (!obj1.allocator && !obj1.arrayAllocator)
          return;
        this.@out.println(new StringBuilder().append(str).append("jvalue args[2];").toString());
        this.@out.println(new StringBuilder().append(str).append("args[0].j = ptr_to_jlong(rpointer);").toString());
        this.@out.print(new StringBuilder().append(str).append("args[1].j = ptr_to_jlong(&JavaCPP_").append(Generator.mangle(obj0.getName())).toString());
        if (obj1.arrayAllocator)
        {
          this.@out.println("_deallocateArray);");
          this.arrayDeallocators.register((object) obj0);
        }
        else
        {
          this.@out.println("_deallocate);");
          this.deallocators.register((object) obj0);
        }
        this.@out.println(new StringBuilder().append(str).append("e->CallNonvirtualVoidMethodA(o, JavaCPP_getClass(e, ").append(this.jclasses.register((object) ClassLiteral<Pointer>.Value)).append("), JavaCPP_initMethodID, args);").toString());
      }
      else
      {
        if (obj1.valueSetter || obj1.memberSetter)
          return;
        if (obj1.returnType == ClassLiteral<String>.Value)
        {
          this.@out.println(new StringBuilder().append(str).append("if (rpointer != NULL) {").toString());
          this.@out.println(new StringBuilder().append(str).append("    r = e->NewStringUTF(rpointer);").toString());
          this.@out.println(new StringBuilder().append(str).append("}").toString());
        }
        else if (obj1.bufferGetter)
        {
          this.@out.println(new StringBuilder().append(str).append("if (rpointer != NULL) {").toString());
          this.@out.println(new StringBuilder().append(str).append("    r = e->NewDirectByteBuffer(rpointer, capacity);").toString());
          this.@out.println(new StringBuilder().append(str).append("}").toString());
        }
        else if (((Class) ClassLiteral<Pointer>.Value).isAssignableFrom(obj1.returnType))
        {
          Class by = Generator.getBy(obj1.annotations);
          if (!Modifier.isStatic(obj1.modifiers) && obj0 == obj1.returnType && by != ClassLiteral<ByVal>.Value)
          {
            this.@out.println(new StringBuilder().append(str).append("if (rpointer == pointer) {").toString());
            this.@out.println(new StringBuilder().append(str).append("    r = o;").toString());
            this.@out.println(new StringBuilder().append(str).append("} else if (rpointer != NULL) {").toString());
          }
          else
            this.@out.println(new StringBuilder().append(str).append("if (rpointer != NULL) {").toString());
          this.@out.println(new StringBuilder().append(str).append("    r = e->AllocObject(JavaCPP_getClass(e, ").append(this.jclasses.register((object) obj1.returnType)).append("));").toString());
          if (by == ClassLiteral<ByVal>.Value && !obj1.valueGetter && (!obj1.memberGetter && !obj1.bufferGetter))
          {
            this.@out.println(new StringBuilder().append(str).append("    jvalue args[2];").toString());
            this.@out.println(new StringBuilder().append(str).append("    args[0].j = ptr_to_jlong(rpointer);").toString());
            this.@out.println(new StringBuilder().append(str).append("    args[1].j = ptr_to_jlong(&JavaCPP_").append(Generator.mangle(obj1.returnType.getName())).append("_deallocate);").toString());
            this.@out.println(new StringBuilder().append(str).append("    e->CallNonvirtualVoidMethodA(r, JavaCPP_getClass(e, ").append(this.jclasses.register((object) ClassLiteral<Pointer>.Value)).append("), JavaCPP_initMethodID, args);").toString());
            this.deallocators.register((object) obj1.returnType);
          }
          else
            this.@out.println(new StringBuilder().append(str).append("    e->SetLongField(r, JavaCPP_addressFieldID, ptr_to_jlong(rpointer));").toString());
          this.@out.println(new StringBuilder().append(str).append("}").toString());
        }
        else
        {
          if (!obj1.returnType.isPrimitive())
            return;
          this.@out.println(new StringBuilder().append(str).append("r = (").append(Generator.getJNITypeName(obj1.returnType)).append(")rvalue;").toString());
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 190, (byte) 130, (byte) 112, (byte) 111, (byte) 117, (byte) 31, (byte) 54, (byte) 233, (byte) 71, (byte) 99, (byte) 112, (byte) 112, (byte) 176, (byte) 111, (byte) 111, (byte) 127, (byte) 53, (byte) 114, (byte) 115, (byte) 127, (byte) 9, (byte) 255, (byte) 64, (byte) 58, (byte) 233, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doParametersAfter([In] Generator.MethodInformation obj0, [In] bool obj1, [In] bool[] obj2)
    {
      int num = obj1 ? 1 : 0;
      string str1 = num == 0 ? "" : "    ";
      for (int index = 0; index < obj0.parameterTypes.Length; ++index)
      {
        if (obj2[index] && !obj0.valueSetter && !obj0.memberSetter)
          this.@out.println(new StringBuilder().append(str1).append("    if (p").append(index).append(" != NULL) e->SetLongField(p").append(index).append(", JavaCPP_addressFieldID, ptr_to_jlong(pointer").append(index).append("));").toString());
      }
      if (num != 0)
      {
        this.@out.println("    } catch (...) {");
        this.@out.println("        JavaCPP_handleException(e);");
        this.@out.println("    }");
      }
      for (int index = 0; index < obj0.parameterTypes.Length; ++index)
      {
        if (obj0.parameterTypes[index] == ClassLiteral<String>.Value)
          this.@out.println(new StringBuilder().append("    if (p").append(index).append(" != NULL) e->ReleaseStringUTFChars(p").append(index).append(", pointer").append(index).append(");").toString());
        else if (obj0.parameterTypes[index].isArray())
        {
          string name = obj0.parameterTypes[index].getComponentType().getName();
          string str2 = new StringBuilder().append(Character.toUpperCase(String.instancehelper_charAt(name, 0))).append(String.instancehelper_substring(name, 1)).toString();
          this.@out.println(new StringBuilder().append("    if (p").append(index).append(" != NULL) e->Release").append(str2).append("ArrayElements(p").append(index).append(", pointer").append(index).append(", 0);").toString());
        }
      }
    }

    [Signature("([Ljava/lang/annotation/Annotation;)Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 93, (byte) 98, (byte) 115, (byte) 159, (byte) 14, (byte) 99, (byte) 191, (byte) 39, (byte) 227, (byte) 57, (byte) 233, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Class getBy(params Annotation[] annotations)
    {
      Annotation annotation1 = (Annotation) null;
      Annotation[] annotationArray = annotations;
      int length = annotationArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Annotation annotation2 = annotationArray[index];
        if (annotation2 is ByPtr || annotation2 is ByPtrPtr || (annotation2 is ByPtrRef || annotation2 is ByRef) || annotation2 is ByVal)
        {
          if (annotation1 != null)
            Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("\"By\" annotation \"").append((object) annotation1).append("\" already found. Ignoring superfluous annotation \"").append((object) annotation2).append("\".").toString());
          else
            annotation1 = annotation2;
        }
      }
      return annotation1 != null ? annotation1.annotationType() : (Class) null;
    }

    [Signature("([Ljava/lang/annotation/Annotation;Ljava/lang/Class<*>;)[Ljava/lang/String;")]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 127, (byte) 103, (byte) 112, (byte) 105, (byte) 13, (byte) 230, (byte) 69, (byte) 106, (byte) 105, (byte) 100, (byte) 111, (byte) 174, (byte) 104, (byte) 105, (byte) 120, (byte) 105, (byte) 127, (byte) 15, (byte) 105, (byte) 127, (byte) 0, (byte) 105, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string[] getAnnotatedCPPTypeName(Annotation[] annotations, Class type)
    {
      string str1 = Generator.getCPPTypeName(type);
      Annotation[] annotationArray = annotations;
      int length = annotationArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Annotation annotation = annotationArray[index];
        if (annotation is Cast)
          str1 = ((Cast) annotation).value();
      }
      string str2 = str1;
      string str3 = "";
      int num = String.instancehelper_indexOf(str1, 41);
      if (num > 0)
      {
        str2 = String.instancehelper_trim(String.instancehelper_substring(str1, 0, num));
        str3 = String.instancehelper_trim(String.instancehelper_substring(str1, num));
      }
      Class by = Generator.getBy(annotations);
      if (by == ClassLiteral<ByVal>.Value)
        str2 = String.instancehelper_substring(str2, 0, String.instancehelper_length(str2) - 1);
      else if (by == ClassLiteral<ByRef>.Value)
        str2 = new StringBuilder().append(String.instancehelper_substring(str2, 0, String.instancehelper_length(str2) - 1)).append("&").toString();
      else if (by == ClassLiteral<ByPtrPtr>.Value)
        str2 = new StringBuilder().append(str2).append("*").toString();
      else if (by == ClassLiteral<ByPtrRef>.Value)
        str2 = new StringBuilder().append(str2).append("&").toString();
      string[] strArray = new string[2];
      int index1 = 0;
      string str4 = str2;
      strArray[index1] = str4;
      int index2 = 1;
      string str5 = str3;
      strArray[index2] = str5;
      return strArray;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 84, (byte) 111, (byte) 104, (byte) 31, (byte) 18, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getCast(params Annotation[] annotations)
    {
      Annotation[] annotationArray = annotations;
      int length = annotationArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Annotation annotation = annotationArray[index];
        if (annotation is Cast)
          return new StringBuilder().append("(").append(((Cast) annotation).value()).append(")").toString();
      }
      return "";
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 11, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 102, (byte) 104, (byte) 159, (byte) 27})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getSignature(Class type)
    {
      if (type == Byte.TYPE)
        return "B";
      if (type == Short.TYPE)
        return "S";
      if (type == Integer.TYPE)
        return "I";
      if (type == Long.TYPE)
        return "J";
      if (type == Float.TYPE)
        return "F";
      if (type == Double.TYPE)
        return "D";
      if (type == Boolean.TYPE)
        return "Z";
      if (type == Character.TYPE)
        return "C";
      if (type == Void.TYPE)
        return "V";
      if (type.isArray())
      {
        string name = type.getName();
        string str = ".";
        object obj1 = (object) "/";
        object obj2 = (object) str;
        CharSequence charSequence1;
        charSequence1.__\u003Cref\u003E = (__Null) obj2;
        CharSequence charSequence2 = charSequence1;
        object obj3 = obj1;
        charSequence1.__\u003Cref\u003E = (__Null) obj3;
        CharSequence charSequence3 = charSequence1;
        return String.instancehelper_replace(name, charSequence2, charSequence3);
      }
      else
      {
        StringBuilder stringBuilder = new StringBuilder().append("L");
        string name = type.getName();
        string str1 = ".";
        object obj1 = (object) "/";
        object obj2 = (object) str1;
        CharSequence charSequence1;
        charSequence1.__\u003Cref\u003E = (__Null) obj2;
        CharSequence charSequence2 = charSequence1;
        object obj3 = obj1;
        charSequence1.__\u003Cref\u003E = (__Null) obj3;
        CharSequence charSequence3 = charSequence1;
        string str2 = String.instancehelper_replace(name, charSequence2, charSequence3);
        return stringBuilder.append(str2).append(";").toString();
      }
    }

    [Signature("(Ljava/lang/reflect/Method;)Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 109, (byte) 103, (byte) 98, (byte) 118, (byte) 191, (byte) 32, (byte) 99, (byte) 191, (byte) 39, (byte) 227, (byte) 56, (byte) 235, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Class getBehavior(Method method)
    {
      Annotation[] annotations = ((AccessibleObject) method).getAnnotations();
      Annotation annotation1 = (Annotation) null;
      Annotation[] annotationArray = annotations;
      int length = annotationArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Annotation annotation2 = annotationArray[index];
        if (annotation2 is Function || annotation2 is Allocator || (annotation2 is ArrayAllocator || annotation2 is ValueSetter) || (annotation2 is ValueGetter || annotation2 is MemberGetter || annotation2 is MemberSetter))
        {
          if (annotation1 != null)
            Generator.logger.log((Level) Level.WARNING, new StringBuilder().append("Behavior annotation \"").append((object) annotation1).append("\" already found. Ignoring superfluous annotation \"").append((object) annotation2).append("\".").toString());
          else
            annotation1 = annotation2;
        }
      }
      return annotation1 != null ? annotation1.annotationType() : (Class) null;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Generator.__\u003CcallerID\u003E == null)
        Generator.__\u003CcallerID\u003E = (CallerID) new Generator.__\u003CCallerID\u003E();
      return Generator.__\u003CcallerID\u003E;
    }

    [HideFromJava]
    void IDisposable.java\u002Elang\u002EAutoCloseable\u002F\u0028\u0029Vclose()
    {
      this.close();
    }

    [InnerClass]
    [Signature("<E:Ljava/lang/Object;>Ljava/util/LinkedList<TE;>;")]
    [SourceFile("Generator.java")]
    [Serializable]
    public class LinkedListRegister : LinkedList
    {
      [LineNumberTable((ushort) 97)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public LinkedListRegister()
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected LinkedListRegister([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [Signature("(TE;)I")]
      [LineNumberTable(new byte[] {(byte) 49, (byte) 104, (byte) 100, (byte) 104, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int register(object e)
      {
        int num = this.indexOf(e);
        if (num < 0)
        {
          this.add(e);
          num = this.size() - 1;
        }
        return num;
      }
    }

    [InnerClass]
    [SourceFile("Generator.java")]
    public class MethodInformation : Object
    {
      public Method method;
      public Annotation[] annotations;
      public int modifiers;
      [Signature("Ljava/lang/Class<*>;")]
      public Class returnType;
      public string name;
      public string memberName;
      public string memberNameSuffix;
      [Signature("[Ljava/lang/Class<*>;")]
      public Class[] parameterTypes;
      public Annotation[][] parameterAnnotations;
      public bool overloaded;
      public bool noOffset;
      public bool deallocator;
      public bool allocator;
      public bool arrayAllocator;
      public bool bufferGetter;
      public bool valueGetter;
      public bool valueSetter;
      public bool memberGetter;
      public bool memberSetter;
      public Method pairedMethod;

      [LineNumberTable((ushort) 1069)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public MethodInformation()
      {
        base.\u002Ector();
      }
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
