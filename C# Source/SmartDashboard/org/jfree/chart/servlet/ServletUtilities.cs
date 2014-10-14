// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.servlet.ServletUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using org.jfree.chart;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.servlet
{
  public class ServletUtilities : Object
  {
    private static string tempFilePrefix = "jfreechart-";
    private static string tempOneTimeFilePrefix = "jfreechart-onetime-";

    [LineNumberTable((ushort) 80)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ServletUtilities()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 98, (byte) 114, (byte) 99, (byte) 144, (byte) 101, (byte) 102, (byte) 100, (byte) 134, (byte) 159, (byte) 1, (byte) 106, (byte) 100, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string saveChartAsPNG(JFreeChart chart, int width, int height, ChartRenderingInfo info, object session)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(session, __typeref (ServletUtilities), "javax.servlet.http.HttpSession");
      if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ServletUtilities.createTempDir();
        string str1 = ServletUtilities.tempFilePrefix;
        if (session == null)
          str1 = ServletUtilities.tempOneTimeFilePrefix;
        string str2 = str1;
        string str3 = ".png";
        File.__\u003Cclinit\u003E();
        File file = new File(System.getProperty("java.io.tmpdir"));
        File tempFile = File.createTempFile(str2, str3, file);
        ChartUtilities.saveChartAsPNG(tempFile, chart, width, height, info);
        if (session != null)
          ServletUtilities.registerChartForDeletion(tempFile, session);
        return tempFile.getName();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 166, (byte) 107, (byte) 99, (byte) 240, (byte) 69, (byte) 103, (byte) 104, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void createTempDir()
    {
      string property = System.getProperty("java.io.tmpdir");
      if (property == null)
      {
        string str = "Temporary directory system property (java.io.tmpdir) is null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
      {
        File file = new File(property);
        if (file.exists())
          return;
        file.mkdirs();
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 66, (byte) 113, (byte) 99, (byte) 241, (byte) 73, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void registerChartForDeletion(File tempFile, object session)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(session, __typeref (ServletUtilities), "javax.servlet.http.HttpSession");
      if (session != null)
        throw new NoClassDefFoundError("javax.servlet.http.HttpSession");
      else
        System.get_out().println("Session is null - chart will not be deleted");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 80, (byte) 178, (byte) 99, (byte) 176, (byte) 101, (byte) 102, (byte) 100, (byte) 134, (byte) 159, (byte) 1, (byte) 106, (byte) 100, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string saveChartAsJPEG(JFreeChart chart, int width, int height, ChartRenderingInfo info, object session)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(session, __typeref (ServletUtilities), "javax.servlet.http.HttpSession");
      if (chart == null)
      {
        string str = "Null 'chart' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ServletUtilities.createTempDir();
        string str1 = ServletUtilities.tempFilePrefix;
        if (session == null)
          str1 = ServletUtilities.tempOneTimeFilePrefix;
        string str2 = str1;
        string str3 = ".jpeg";
        File.__\u003Cclinit\u003E();
        File file = new File(System.getProperty("java.io.tmpdir"));
        File tempFile = File.createTempFile(str2, str3, file);
        ChartUtilities.saveChartAsJPEG(tempFile, chart, width, height, info);
        if (session != null)
          ServletUtilities.registerChartForDeletion(tempFile, session);
        return tempFile.getName();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 56, (byte) 145, (byte) 98, (byte) 103, (byte) 105, (byte) 159, (byte) 1, (byte) 136, (byte) 159, (byte) 1, (byte) 166, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void sendTempFile(File file, object response)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(response, __typeref (ServletUtilities), "javax.servlet.http.HttpServletResponse");
      string mimeType = (string) null;
      string name = file.getName();
      if (String.instancehelper_length(name) > 5)
      {
        if (String.instancehelper_equals(String.instancehelper_substring(name, String.instancehelper_length(name) - 5, String.instancehelper_length(name)), (object) ".jpeg"))
          mimeType = "image/jpeg";
        else if (String.instancehelper_equals(String.instancehelper_substring(name, String.instancehelper_length(name) - 4, String.instancehelper_length(name)), (object) ".png"))
          mimeType = "image/png";
      }
      ServletUtilities.sendTempFile(file, response, mimeType);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 49, (byte) 113, (byte) 104, (byte) 209, (byte) 99, (byte) 146, (byte) 252, (byte) 89})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void sendTempFile(File file, object response, string mimeType)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(response, __typeref (ServletUtilities), "javax.servlet.http.HttpServletResponse");
      if (file.exists())
      {
        BufferedInputStream.__\u003Cclinit\u003E();
        BufferedInputStream bufferedInputStream = new BufferedInputStream((InputStream) new FileInputStream(file));
        if (mimeType != null)
        {
          throw new NoClassDefFoundError("javax.servlet.http.HttpServletResponse");
        }
        else
        {
          String.valueOf(file.length());
          throw new NoClassDefFoundError("javax.servlet.http.HttpServletResponse");
        }
      }
      else
      {
        string absolutePath = file.getAbsolutePath();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new FileNotFoundException(absolutePath);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 55, (byte) 104, (byte) 100, (byte) 162, (byte) 102, (byte) 127, (byte) 5, (byte) 112, (byte) 223, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string searchReplace(string inputString, string searchString, string replaceString)
    {
      int num = String.instancehelper_indexOf(inputString, searchString);
      if (num == -1)
        return inputString;
      string str = new StringBuffer().append("").append(String.instancehelper_substring(inputString, 0, num)).append(replaceString).toString();
      if (num + String.instancehelper_length(searchString) < String.instancehelper_length(inputString))
        str = new StringBuffer().append(str).append(ServletUtilities.searchReplace(String.instancehelper_substring(inputString, num + String.instancehelper_length(searchString)), searchString, replaceString)).toString();
      return str;
    }

    public static string getTempFilePrefix()
    {
      return ServletUtilities.tempFilePrefix;
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 99, (byte) 144, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setTempFilePrefix(string prefix)
    {
      if (prefix == null)
      {
        string str = "Null 'prefix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        ServletUtilities.tempFilePrefix = prefix;
    }

    public static string getTempOneTimeFilePrefix()
    {
      return ServletUtilities.tempOneTimeFilePrefix;
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 99, (byte) 144, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setTempOneTimeFilePrefix(string prefix)
    {
      if (prefix == null)
      {
        string str = "Null 'prefix' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        ServletUtilities.tempOneTimeFilePrefix = prefix;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable((ushort) 150)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string saveChartAsPNG(JFreeChart chart, int width, int height, object session)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(session, __typeref (ServletUtilities), "javax.servlet.http.HttpSession");
      return ServletUtilities.saveChartAsPNG(chart, width, height, (ChartRenderingInfo) null, session);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable((ushort) 219)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string saveChartAsJPEG(JFreeChart chart, int width, int height, object session)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(session, __typeref (ServletUtilities), "javax.servlet.http.HttpSession");
      return ServletUtilities.saveChartAsJPEG(chart, width, height, (ChartRenderingInfo) null, session);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 60, (byte) 177, (byte) 118, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void sendTempFile(string filename, object response)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(response, __typeref (ServletUtilities), "javax.servlet.http.HttpServletResponse");
      File.__\u003Cclinit\u003E();
      ServletUtilities.sendTempFile(new File(System.getProperty("java.io.tmpdir"), filename), response);
    }
  }
}
