// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.extensions.FileSniffer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.types;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.net;
using java.util;
using java.util.jar;
using java.util.zip;
using javax.swing;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.extensions
{
  public class FileSniffer : Object
  {
    public const string EXTENSIONS_FOLDER = "./extensions";
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 22)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FileSniffer()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 107, (byte) 107, (byte) 107, (byte) 139, (byte) 112, (byte) 135, (byte) 130, (byte) 127, (byte) 2, (byte) 255, (byte) 2, (byte) 69, (byte) 226, (byte) 60, (byte) 98, (byte) 103, (byte) 103, (byte) 161, (byte) 127, (byte) 13, (byte) 105, (byte) 109, (byte) 133, (byte) 127, (byte) 6, (byte) 159, (byte) 2, (byte) 238, (byte) 70, (byte) 100, (byte) 109, (byte) 165, (byte) 124, (byte) 191, (byte) 6, (byte) 191, (byte) 29, (byte) 2, (byte) 98, (byte) 231, (byte) 58, (byte) 235, (byte) 74, (byte) 237, (byte) 35, (byte) 235, (byte) 96, (byte) 104, (byte) 111, (byte) 103, (byte) 161, (byte) 237, (byte) 71, (byte) 103, (byte) 124, (byte) 127, (byte) 6, (byte) 127, (byte) 18, (byte) 191, (byte) 2, (byte) 137, (byte) 127, (byte) 1, (byte) 108, (byte) 110, (byte) 137, (byte) 113, (byte) 163, (byte) 147, (byte) 147, (byte) 144, (byte) 110, (byte) 135, (byte) 255, (byte) 43, (byte) 75, (byte) 255, (byte) 21, (byte) 54, (byte) 129, (byte) 110, (byte) 135, (byte) 159, (byte) 29, (byte) 55, (byte) 193, (byte) 2, (byte) 129, (byte) 34, (byte) 161, (byte) 197, (byte) 226, (byte) 61, (byte) 98, (byte) 103, (byte) 239, (byte) 22, (byte) 235, (byte) 110, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void findExtensions(ProgressMonitor monitor, int min, int max)
    {
      monitor.setNote("Loading Extensions");
      File file1 = new File("./extensions");
      File file2 = new File("./lib");
      File file3 = new File("./extensions/lib");
      URLClassLoader urlClassLoader1 = (URLClassLoader) ClassLoader.getSystemClassLoader(FileSniffer.__\u003CGetCallerID\u003E());
      Class class1 = (Class) ClassLiteral<URLClassLoader>.Value;
      Method declaredMethod;
      Exception exception1;
      try
      {
        Class class2 = class1;
        string str = "addURL";
        Class[] classArray = new Class[1];
        int index = 0;
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<URL>.Value;
        classArray[index] = (Class) local;
        CallerID callerId = FileSniffer.__\u003CGetCallerID\u003E();
        declaredMethod = class2.getDeclaredMethod(str, classArray, callerId);
        ((AccessibleObject) declaredMethod).setAccessible(true);
        goto label_6;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception1);
      monitor.setProgress(max);
      return;
label_6:
      File[] fileArray1 = new File[3];
      int index1 = 0;
      File file4 = file2;
      fileArray1[index1] = file4;
      int index2 = 1;
      File file5 = file3;
      fileArray1[index2] = file5;
      int index3 = 2;
      File file6 = file1;
      fileArray1[index3] = file6;
      File[] fileArray2 = fileArray1;
      int length1 = fileArray2.Length;
      for (int index4 = 0; index4 < length1; ++index4)
      {
        File file7 = fileArray2[index4];
        if (!file7.exists())
        {
          monitor.setProgress(min + (max - min) / 5);
        }
        else
        {
          System.get_out().println(new StringBuilder().append("Searching Folder:").append((object) file7).toString());
          monitor.setNote(new StringBuilder().append("Searching Folder:").append((object) file7).toString());
          File[] fileArray3 = file7.listFiles((FilenameFilter) new FileSniffer\u00241());
          if (fileArray3 == null)
          {
            monitor.setProgress(min + (max - min) / 5);
          }
          else
          {
            File[] fileArray4 = fileArray3;
            int length2 = fileArray4.Length;
            for (int index5 = 0; index5 < length2; ++index5)
            {
              File file8 = fileArray4[index5];
              System.get_out().println(new StringBuilder().append("Adding Jar:").append((object) file8).toString());
              Exception exception2;
              try
              {
                Method method = declaredMethod;
                URLClassLoader urlClassLoader2 = urlClassLoader1;
                object[] objArray = new object[1];
                int index6 = 0;
                URL url = file8.toURI().toURL();
                objArray[index6] = (object) url;
                CallerID callerId = FileSniffer.__\u003CGetCallerID\u003E();
                method.invoke((object) urlClassLoader2, objArray, callerId);
                continue;
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
              Throwable.instancehelper_printStackTrace((Exception) exception2);
            }
            monitor.setProgress(min + (max - min) / 5);
          }
        }
      }
      if (!file1.exists())
      {
        System.get_out().println("No Extension Folder");
        monitor.setProgress(max);
      }
      else
      {
        File[] fileArray3 = file1.listFiles((FilenameFilter) new FileSniffer\u00242());
        double num1 = 0.0;
        File[] fileArray4 = fileArray3;
        int length2 = fileArray4.Length;
label_26:
        for (int index4 = 0; index4 < length2; ++index4)
        {
          File file7 = fileArray4[index4];
          System.get_out().println(new StringBuilder().append("Searching Jar:").append((object) file7).toString());
          monitor.setProgress(ByteCodeHelper.d2i((double) (min + max) / 2.0 * (1.0 + num1++ / (double) fileArray3.Length)));
          monitor.setNote(new StringBuilder().append("Searching Jar:").append((object) file7).toString());
          Enumeration enumeration;
          Exception exception2;
          try
          {
            enumeration = new JarFile(file7).entries();
            goto label_31;
          }
          catch (Exception ex)
          {
            int num2 = 0;
            exception2 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
          }
          Exception exception3 = exception2;
          goto label_52;
label_31:
          Exception exception4;
          Exception exception5;
          while (true)
          {
            Class class2;
            try
            {
              string name;
              do
              {
                if (enumeration.hasMoreElements())
                  name = ((ZipEntry) enumeration.nextElement()).getName();
                else
                  goto label_26;
              }
              while (!String.instancehelper_endsWith(name, ".class"));
              class2 = (Class) null;
              try
              {
                try
                {
                  try
                  {
                    class2 = Class.forName(String.instancehelper_replaceAll(String.instancehelper_substring(name, 0, String.instancehelper_length(name) - 6), "/", "."), false, (ClassLoader) urlClassLoader1, FileSniffer.__\u003CGetCallerID\u003E());
                    DisplayElementRegistry.registerWidget(class2.asSubclass((Class) ClassLiteral<Widget>.Value));
                    System.get_out().println(new StringBuilder().append("Custom Widget:").append(class2.getSimpleName()).toString());
                    continue;
                  }
                  catch (Exception ex)
                  {
                    int num2 = 2;
                    if (ByteCodeHelper.MapException<ClassCastException>(ex, (ByteCodeHelper.MapFlags) num2) == null)
                      throw;
                  }
                }
                catch (ClassNotFoundException ex)
                {
                  goto label_42;
                }
              }
              catch (Exception ex)
              {
                int num2 = 2;
                if (ByteCodeHelper.MapException<NoClassDefFoundError>(ex, (ByteCodeHelper.MapFlags) num2) == null)
                  throw;
                else
                  goto label_43;
              }
            }
            catch (Exception ex)
            {
              int num2 = 0;
              exception4 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
              break;
            }
            try
            {
              try
              {
                DisplayElementRegistry.registerStaticWidget(class2.asSubclass((Class) ClassLiteral<StaticWidget>.Value));
                System.get_out().println(new StringBuilder().append("Custom Static Widget:").append(class2.getSimpleName()).toString());
              }
              catch (Exception ex)
              {
                int num2 = 2;
                if (ByteCodeHelper.MapException<ClassCastException>(ex, (ByteCodeHelper.MapFlags) num2) == null)
                  throw;
              }
            }
            catch (Exception ex)
            {
              int num2 = 0;
              exception5 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
              goto label_51;
            }
            continue;
label_42:
            continue;
label_43:;
          }
          exception3 = exception4;
          goto label_52;
label_51:
          exception3 = exception5;
label_52:
          Throwable.instancehelper_printStackTrace(exception3);
          System.get_out().println("Error, could not add URL to system classloader");
        }
        monitor.setProgress(max);
      }
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (FileSniffer.__\u003CcallerID\u003E == null)
        FileSniffer.__\u003CcallerID\u003E = (CallerID) new FileSniffer.__\u003CCallerID\u003E();
      return FileSniffer.__\u003CcallerID\u003E;
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
