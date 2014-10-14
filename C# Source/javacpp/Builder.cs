// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Builder
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.net;
using java.util;
using java.util.jar;
using java.util.zip;
using System;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacpp
{
  public class Builder : Object
  {
    private Properties properties;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 104, (byte) 167, (byte) 103, (byte) 232, (byte) 75, (byte) 117, (byte) 127, (byte) 7, (byte) 127, (byte) 3, (byte) 127, (byte) 0, (byte) 63, (byte) 7, (byte) 40, (byte) 43, (byte) 235, (byte) 72, (byte) 114, (byte) 132, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Builder(Properties properties)
    {
      base.\u002Ector();
      Builder builder = this;
      this.properties = properties;
      string[] strArray = new string[2];
      Builder\u00241 builder1 = new Builder\u00241(this, strArray);
      File.__\u003Cclinit\u003E();
      File[] fileArray1 = new File(System.getProperty("java.home")).getParentFile().listFiles((FilenameFilter) builder1);
      int length1 = fileArray1.Length;
      for (int index1 = 0; index1 < length1; ++index1)
      {
        File[] fileArray2 = fileArray1[index1].listFiles((FilenameFilter) builder1);
        int length2 = fileArray2.Length;
        for (int index2 = 0; index2 < length2; ++index2)
        {
          File[] fileArray3 = fileArray2[index2].listFiles((FilenameFilter) builder1);
          int length3 = fileArray3.Length;
          for (int index3 = 0; index3 < length3; ++index3)
          {
            File[] fileArray4 = fileArray3[index3].listFiles((FilenameFilter) builder1);
            int length4 = fileArray4.Length;
            for (int index4 = 0; index4 < length4; ++index4)
            {
              File file = fileArray4[index4];
            }
          }
        }
      }
      if (strArray[0] != null && String.instancehelper_equals(strArray[0], (object) strArray[1]))
        strArray[1] = (string) null;
      Loader.appendProperty(properties, "compiler.includepath", properties.getProperty("path.separator"), strArray);
    }

    [LineNumberTable((ushort) 79)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string mapLibraryName(string libname)
    {
      return new StringBuilder().append(this.properties.getProperty("library.prefix", "")).append(libname).append(this.properties.getProperty("library.suffix", "")).toString();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.InterruptedException"})]
    [LineNumberTable(new byte[] {(byte) 35, (byte) 134, (byte) 113, (byte) 113, (byte) 112, (byte) 187, (byte) 113, (byte) 112, (byte) 151, (byte) 136, (byte) 114, (byte) 116, (byte) 127, (byte) 3, (byte) 113, (byte) 153, (byte) 110, (byte) 255, (byte) 19, (byte) 59, (byte) 235, (byte) 74, (byte) 136, (byte) 114, (byte) 110, (byte) 184, (byte) 114, (byte) 110, (byte) 184, (byte) 159, (byte) 2, (byte) 138, (byte) 191, (byte) 8, (byte) 114, (byte) 116, (byte) 127, (byte) 3, (byte) 113, (byte) 153, (byte) 110, (byte) 255, (byte) 19, (byte) 59, (byte) 235, (byte) 74, (byte) 114, (byte) 116, (byte) 127, (byte) 0, (byte) 63, (byte) 45, (byte) 232, (byte) 70, (byte) 127, (byte) 0, (byte) 113, (byte) 100, (byte) 143, (byte) 108, (byte) 100, (byte) 143, (byte) 111, (byte) 101, (byte) 138, (byte) 109, (byte) 123, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int build(string sourceFilename, string outputFilename)
    {
      LinkedList linkedList = new LinkedList();
      string property1 = this.properties.getProperty("path.separator");
      string str1 = this.properties.getProperty("platform.root");
      if (str1 != null && !String.instancehelper_endsWith(str1, (string) File.separator))
        str1 = new StringBuilder().append(str1).append((string) File.separator).toString();
      string str2 = this.properties.getProperty("compiler.path");
      if (str1 != null && !new File(str2).isAbsolute())
        str2 = new StringBuilder().append(str1).append(str2).toString();
      linkedList.add((object) str2);
      string property2 = this.properties.getProperty("compiler.includepath");
      if (property2 != null && String.instancehelper_length(property2) > 0)
      {
        string[] strArray = String.instancehelper_split(property2, property1);
        int length = strArray.Length;
        for (int index = 0; index < length; ++index)
        {
          string str3 = strArray[index];
          if (str1 != null && !new File(str3).isAbsolute())
            str3 = new StringBuilder().append(str1).append(str3).toString();
          if (new File(str3).isDirectory())
            linkedList.add((object) new StringBuilder().append(this.properties.getProperty("compiler.includepath.prefix", "")).append(str3).toString());
        }
      }
      linkedList.add((object) sourceFilename);
      string property3 = this.properties.getProperty("compiler.options");
      if (property3 != null && String.instancehelper_length(property3) > 0)
        linkedList.addAll((Collection) Arrays.asList((object[]) String.instancehelper_split(property3, " ")));
      string property4 = this.properties.getProperty("compiler.output.prefix");
      if (property4 != null && String.instancehelper_length(property4) > 0)
        linkedList.addAll((Collection) Arrays.asList((object[]) String.instancehelper_split(property4, " ")));
      if (property4 == null || String.instancehelper_length(property4) == 0 || (int) String.instancehelper_charAt(property4, String.instancehelper_length(property4) - 1) == 32)
        linkedList.add((object) outputFilename);
      else
        linkedList.add((object) new StringBuilder().append((string) linkedList.removeLast()).append(outputFilename).toString());
      string property5 = this.properties.getProperty("compiler.linkpath");
      if (property5 != null && String.instancehelper_length(property5) > 0)
      {
        string[] strArray = String.instancehelper_split(property5, property1);
        int length = strArray.Length;
        for (int index = 0; index < length; ++index)
        {
          string str3 = strArray[index];
          if (str1 != null && !new File(str3).isAbsolute())
            str3 = new StringBuilder().append(str1).append(str3).toString();
          if (new File(str3).isDirectory())
            linkedList.add((object) new StringBuilder().append(this.properties.getProperty("compiler.linkpath.prefix", "")).append(str3).toString());
        }
      }
      string property6 = this.properties.getProperty("compiler.link");
      if (property6 != null && String.instancehelper_length(property6) > 0)
      {
        string[] strArray = String.instancehelper_split(property6, property1);
        int length = strArray.Length;
        for (int index = 0; index < length; ++index)
        {
          string str3 = strArray[index];
          linkedList.add((object) new StringBuilder().append(this.properties.getProperty("compiler.link.prefix", "")).append(str3).append(this.properties.getProperty("compiler.link.suffix", "")).toString());
        }
      }
      Iterator iterator = ((AbstractSequentialList) linkedList).iterator();
      while (iterator.hasNext())
      {
        string str3 = (string) iterator.next();
        int num = String.instancehelper_indexOf(str3, " ") > 0 ? 1 : 0;
        if (num != 0)
          System.get_out().print("\"");
        System.get_out().print(str3);
        if (num != 0)
          System.get_out().print("\"");
        System.get_out().print(" ");
      }
      System.get_out().println();
      Process process = new ProcessBuilder((List) linkedList).start();
      Piper.__\u003Cclinit\u003E();
      new Piper(process.getErrorStream(), (OutputStream) System.get_err()).start();
      Piper.__\u003Cclinit\u003E();
      new Piper(process.getInputStream(), (OutputStream) System.get_out()).start();
      return process.waitFor();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 111, (byte) 106, (byte) 111, (byte) 106, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 111, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void printHelp()
    {
      System.get_err().println("Usage: java -jar javacpp.jar [options] <classes>");
      System.get_err().println();
      System.get_err().println("where options include:");
      System.get_err().println();
      System.get_err().println("    -classpath <path>      Load user classes from path");
      System.get_err().println("    -d <directory>         Dump all output files in directory");
      System.get_err().println("    -cpp                   Do not build or delete the generated .cpp files");
      System.get_err().println("    -o <name>              Output everything in a file named after given name");
      System.get_err().println("    -jarprefix <prefix>    Also create a JAR file named \"<prefix>-<platform.name>.jar\"");
      System.get_err().println("    -properties <resource> Load all properties from resource");
      System.get_err().println("    -propertyfile <file>   Load all properties from file");
      System.get_err().println("    -D<property>=<value>   Set property to value");
      System.get_err().println();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.InterruptedException", "java.net.URISyntaxException"})]
    [Signature("([Ljava/lang/Class;Ljava/util/Properties;Ljava/io/File;Ljava/lang/String;Z)Ljava/util/LinkedList<Ljava/io/File;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 99, (byte) 67, (byte) 102, (byte) 109, (byte) 115, (byte) 40, (byte) 200, (byte) 102, (byte) 104, (byte) 127, (byte) 12, (byte) 120, (byte) 121, (byte) 127, (byte) 9, (byte) 98, (byte) 119, (byte) 191, (byte) 9, (byte) 159, (byte) 8, (byte) 104, (byte) 135, (byte) 127, (byte) 6, (byte) 106, (byte) 106, (byte) 135, (byte) 103, (byte) 102, (byte) 104, (byte) 117, (byte) 127, (byte) 6, (byte) 119, (byte) 100, (byte) 104, (byte) 139, (byte) 135, (byte) 98, (byte) 171, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static LinkedList generateAndBuild(Class[] classes, Properties properties, File outputDirectory, string outputName, bool build)
    {
      int num1 = build ? 1 : 0;
      LinkedList linkedList = new LinkedList();
      properties = (Properties) ((Hashtable) properties).clone();
      Class[] classArray = classes;
      int length = classArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Class cls = classArray[index];
        Loader.appendProperties(properties, cls);
      }
      File file1;
      if (outputDirectory == null)
      {
        if (classes.Length == 1)
        {
          URL resource = classes[0].getResource(new StringBuilder().append(classes[0].getSimpleName()).append(".class").toString());
          File.__\u003Cclinit\u003E();
          File parentFile = new File(resource.toURI()).getParentFile();
          File.__\u003Cclinit\u003E();
          outputDirectory = new File(parentFile, properties.getProperty("platform.name"));
          File.__\u003Cclinit\u003E();
          file1 = new File(parentFile, new StringBuilder().append(outputName).append(".cpp").toString());
        }
        else
        {
          File.__\u003Cclinit\u003E();
          outputDirectory = new File(properties.getProperty("platform.name"));
          File.__\u003Cclinit\u003E();
          file1 = new File(new StringBuilder().append(outputName).append(".cpp").toString());
        }
      }
      else
      {
        File.__\u003Cclinit\u003E();
        file1 = new File(outputDirectory, new StringBuilder().append(outputName).append(".cpp").toString());
      }
      if (!outputDirectory.exists())
        outputDirectory.mkdirs();
      System.get_out().println(new StringBuilder().append("Generating source file: ").append((object) file1).toString());
      Generator generator = new Generator(properties, file1);
      int num2 = generator.generate(classes) ? 1 : 0;
      generator.close();
      if (num2 != 0)
      {
        if (num1 != 0)
        {
          Builder builder = new Builder(properties);
          File.__\u003Cclinit\u003E();
          File file2 = new File(outputDirectory, builder.mapLibraryName(outputName));
          System.get_out().println(new StringBuilder().append("Building library file: ").append((object) file2).toString());
          int num3 = builder.build(file1.getPath(), file2.getPath());
          if (num3 == 0)
          {
            file1.delete();
            linkedList.add((object) file2);
          }
          else
            System.exit(num3);
        }
        else
          linkedList.add((object) file1);
      }
      else
        System.get_out().println(new StringBuilder().append("No need to generate source file: ").append((object) file1).toString());
      return linkedList;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [Signature("(Ljava/io/File;[Ljava/lang/String;Ljava/util/LinkedList<Ljava/io/File;>;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 127, (byte) 5, (byte) 108, (byte) 126, (byte) 103, (byte) 198, (byte) 105, (byte) 105, (byte) 117, (byte) 106, (byte) 244, (byte) 61, (byte) 232, (byte) 71, (byte) 106, (byte) 121, (byte) 6, (byte) 232, (byte) 70, (byte) 116, (byte) 109, (byte) 104, (byte) 104, (byte) 142, (byte) 111, (byte) 141, (byte) 103, (byte) 166, (byte) 101, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void createJar(File jarFile, string[] classpath, LinkedList files)
    {
      System.get_out().println(new StringBuilder().append("Creating jar file: ").append((object) jarFile).toString());
      JarOutputStream jarOutputStream = new JarOutputStream((OutputStream) new FileOutputStream(jarFile));
      Iterator iterator = ((AbstractSequentialList) files).iterator();
      while (iterator.hasNext())
      {
        File file = (File) iterator.next();
        string str = file.getPath();
        if (classpath != null)
        {
          string[] strArray = new string[classpath.Length];
          for (int index = 0; index < classpath.Length; ++index)
          {
            File.__\u003Cclinit\u003E();
            string canonicalPath = new File(classpath[index]).getCanonicalPath();
            if (String.instancehelper_startsWith(str, canonicalPath))
              strArray[index] = String.instancehelper_substring(str, String.instancehelper_length(canonicalPath) + 1);
          }
          for (int index = 0; index < strArray.Length; ++index)
          {
            if (strArray[index] != null && String.instancehelper_length(strArray[index]) < String.instancehelper_length(str))
              str = strArray[index];
          }
        }
        ZipEntry zipEntry = new ZipEntry(String.instancehelper_replace(str, (char) File.separatorChar, '/'));
        zipEntry.setTime(file.lastModified());
        jarOutputStream.putNextEntry(zipEntry);
        FileInputStream fileInputStream = new FileInputStream(file);
        byte[] numArray = new byte[fileInputStream.available()];
        int num;
        while ((num = fileInputStream.read(numArray)) > 0)
          ((ZipOutputStream) jarOutputStream).write(numArray, 0, num);
        fileInputStream.close();
        ((ZipOutputStream) jarOutputStream).closeEntry();
      }
      ((ZipOutputStream) jarOutputStream).close();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 180, (byte) 100, (byte) 101, (byte) 166, (byte) 102, (byte) 98, (byte) 100, (byte) 99, (byte) 103, (byte) 135, (byte) 108, (byte) 127, (byte) 1, (byte) 101, (byte) 107, (byte) 127, (byte) 17, (byte) 127, (byte) 0, (byte) 112, (byte) 122, (byte) 112, (byte) 104, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 118, (byte) 115, (byte) 118, (byte) 137, (byte) 191, (byte) 4, (byte) 2, (byte) 97, (byte) 137, (byte) 103, (byte) 120, (byte) 109, (byte) 101, (byte) 141, (byte) 110, (byte) 111, (byte) 116, (byte) 140, (byte) 117, (byte) 127, (byte) 8, (byte) 101, (byte) 139, (byte) 102, (byte) 111, (byte) 110, (byte) 179, (byte) 112, (byte) 213, (byte) 226, (byte) 61, (byte) 97, (byte) 127, (byte) 6, (byte) 230, (byte) 14, (byte) 235, (byte) 120, (byte) 99, (byte) 103, (byte) 127, (byte) 1, (byte) 223, (byte) 9, (byte) 223, (byte) 6, (byte) 114, (byte) 127, (byte) 34, (byte) 105, (byte) 105, (byte) 136, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      if (args.Length == 0)
      {
        Builder.printHelp();
        System.exit(1);
      }
      Builder.UserClassLoader userClassLoader1 = new Builder.UserClassLoader();
      File outputDirectory1 = (File) null;
      string outputName = (string) null;
      string str1 = (string) null;
      int num1 = 1;
      Properties properties1 = Loader.getProperties();
      LinkedList linkedList1 = new LinkedList();
      for (int index1 = 0; index1 < args.Length; ++index1)
      {
        if (String.instancehelper_equals("-help", (object) args[index1]) || String.instancehelper_equals("--help", (object) args[index1]))
        {
          Builder.printHelp();
          System.exit(0);
        }
        else if (String.instancehelper_equals("-classpath", (object) args[index1]) || String.instancehelper_equals("-cp", (object) args[index1]) || String.instancehelper_equals("-lib", (object) args[index1]))
        {
          Builder.UserClassLoader userClassLoader2 = userClassLoader1;
          string[] strArray1 = args;
          ++index1;
          int index2 = index1;
          string[] strArray2 = String.instancehelper_split(strArray1[index2], (string) File.pathSeparator);
          userClassLoader2.addPaths(strArray2);
        }
        else if (String.instancehelper_equals("-d", (object) args[index1]))
        {
          File.__\u003Cclinit\u003E();
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          outputDirectory1 = new File(strArray[index2]);
        }
        else if (String.instancehelper_equals("-cpp", (object) args[index1]))
          num1 = 0;
        else if (String.instancehelper_equals("-o", (object) args[index1]))
        {
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          outputName = strArray[index2];
        }
        else if (String.instancehelper_equals("-jarprefix", (object) args[index1]))
        {
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          str1 = strArray[index2];
        }
        else if (String.instancehelper_equals("-properties", (object) args[index1]))
        {
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          properties1 = Loader.getProperties(strArray[index2]);
        }
        else if (String.instancehelper_equals("-propertyfile", (object) args[index1]))
        {
          FileInputStream.__\u003Cclinit\u003E();
          string[] strArray = args;
          ++index1;
          int index2 = index1;
          FileInputStream fileInputStream = new FileInputStream(strArray[index2]);
          properties1 = new Properties(properties1);
          try
          {
            properties1.load((Reader) new InputStreamReader((InputStream) fileInputStream));
            goto label_24;
          }
          catch (Exception ex)
          {
            int num2 = 2;
            if (ByteCodeHelper.MapException<NoSuchMethodError>(ex, (ByteCodeHelper.MapFlags) num2) == null)
              throw;
          }
          properties1.load((InputStream) fileInputStream);
label_24:
          fileInputStream.close();
        }
        else if (String.instancehelper_startsWith(args[index1], "-D"))
        {
          int num2 = String.instancehelper_indexOf(args[index1], 61);
          if (num2 < 0)
            num2 = String.instancehelper_indexOf(args[index1], 58);
          string str2 = String.instancehelper_substring(args[index1], 2, num2);
          string str3 = String.instancehelper_substring(args[index1], num2 + 1);
          if (String.instancehelper_length(str2) > 0 && String.instancehelper_length(str3) > 0)
            ((Hashtable) properties1).put((object) str2, (object) str3);
        }
        else if (String.instancehelper_startsWith(args[index1], "-"))
        {
          System.get_err().println(new StringBuilder().append("Invalid option: ").append(args[index1]).toString());
          Builder.printHelp();
          System.exit(1);
        }
        else
        {
          Loader.loadLibraries = false;
          string str2 = String.instancehelper_replace(args[index1], '/', '.');
          if (String.instancehelper_endsWith(str2, ".class"))
            str2 = String.instancehelper_substring(str2, 0, String.instancehelper_length(str2) - 6);
          try
          {
            Class @class = Class.forName(str2, true, (ClassLoader) userClassLoader1, Builder.__\u003CGetCallerID\u003E());
            linkedList1.add((object) @class);
            continue;
          }
          catch (ClassNotFoundException ex)
          {
          }
          System.get_err().println(new StringBuilder().append("Class not found: ").append(str2).toString());
          System.exit(1);
        }
      }
      LinkedList files;
      if (outputName == null)
      {
        files = new LinkedList();
        Iterator iterator = ((AbstractSequentialList) linkedList1).iterator();
        while (iterator.hasNext())
        {
          Class cls = (Class) iterator.next();
          LinkedList linkedList2 = files;
          Class[] classes = new Class[1];
          int index = 0;
          Class @class = cls;
          classes[index] = @class;
          Properties properties2 = properties1;
          File outputDirectory2 = outputDirectory1;
          string libraryName = Loader.getLibraryName(cls);
          int num2 = num1;
          LinkedList linkedList3 = Builder.generateAndBuild(classes, properties2, outputDirectory2, libraryName, num2 != 0);
          linkedList2.addAll((Collection) linkedList3);
        }
      }
      else
        files = Builder.generateAndBuild((Class[]) linkedList1.toArray((object[]) new Class[linkedList1.size()]), properties1, outputDirectory1, outputName, num1 != 0);
      if (str1 == null || ((AbstractCollection) files).isEmpty())
        return;
      File.__\u003Cclinit\u003E();
      File jarFile = new File(new StringBuilder().append(str1).append("-").append(((Hashtable) properties1).get((object) "platform.name")).append(".jar").toString());
      File parentFile = jarFile.getParentFile();
      if (!parentFile.exists())
        parentFile.mkdir();
      Builder.createJar(jarFile, outputDirectory1 != null ? (string[]) null : userClassLoader1.getPaths(), files);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Builder.__\u003CcallerID\u003E == null)
        Builder.__\u003CcallerID\u003E = (CallerID) new Builder.__\u003CCallerID\u003E();
      return Builder.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("Builder.java")]
    public class UserClassLoader : URLClassLoader
    {
      [Signature("Ljava/util/LinkedList<Ljava/lang/String;>;")]
      private LinkedList paths;

      [HideFromJava]
      static UserClassLoader()
      {
        URLClassLoader.__\u003Cclinit\u003E();
      }

      [Throws(new string[] {"java.net.MalformedURLException"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 14, (byte) 171, (byte) 123})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public UserClassLoader()
      {
        base.\u002Ector(new URL[0]);
        Builder.UserClassLoader userClassLoader = this;
        this.paths = new LinkedList();
        string[] strArray = new string[1];
        int index = 0;
        string property = System.getProperty("user.dir");
        strArray[index] = property;
        this.addPaths(strArray);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [Throws(new string[] {"java.net.MalformedURLException"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 111, (byte) 109, (byte) 22, (byte) 198})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void addPaths(params string[] paths)
      {
        string[] strArray = paths;
        int length = strArray.Length;
        for (int index = 0; index < length; ++index)
        {
          string str = strArray[index];
          this.paths.add((object) str);
          this.addURL(new File(str).toURI().toURL());
        }
      }

      [LineNumberTable((ushort) 273)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string[] getPaths()
      {
        return (string[]) this.paths.toArray((object[]) new string[this.paths.size()]);
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
