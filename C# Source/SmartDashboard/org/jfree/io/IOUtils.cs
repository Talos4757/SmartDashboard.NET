// Decompiled with JetBrains decompiler
// Type: org.jfree.io.IOUtils
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.io
{
  public class IOUtils : Object
  {
    private static IOUtils instance;

    [LineNumberTable(new byte[] {(byte) 24, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private IOUtils()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 114, (byte) 130, (byte) 114, (byte) 130, (byte) 114, (byte) 130, (byte) 114, (byte) 130, (byte) 114, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isFileStyleProtocol([In] URL obj0)
    {
      return String.instancehelper_equals(obj0.getProtocol(), (object) "http") || String.instancehelper_equals(obj0.getProtocol(), (object) "https") || (String.instancehelper_equals(obj0.getProtocol(), (object) "ftp") || String.instancehelper_equals(obj0.getProtocol(), (object) "file")) || String.instancehelper_equals(obj0.getProtocol(), (object) "jar");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isSameService([In] URL obj0, [In] URL obj1)
    {
      return String.instancehelper_equals(obj0.getProtocol(), (object) obj1.getProtocol()) && String.instancehelper_equals(obj0.getHost(), (object) obj1.getHost()) && obj0.getPort() == obj1.getPort();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 198, (byte) 103, (byte) 105, (byte) 100, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string getPath([In] URL obj0)
    {
      string file = obj0.getFile();
      int num = String.instancehelper_indexOf(file, 63);
      if (num == -1)
        return file;
      return String.instancehelper_substring(file, 0, num);
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 102, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 136, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List parseName([In] string obj0)
    {
      ArrayList arrayList = new ArrayList();
      StringTokenizer stringTokenizer = new StringTokenizer(obj0, "/");
      while (stringTokenizer.hasMoreElements())
      {
        string str = (string) stringTokenizer.nextElement();
        if (String.instancehelper_length(str) != 0)
          arrayList.add((object) str);
      }
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 103, (byte) 105, (byte) 100, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string getQuery([In] URL obj0)
    {
      string file = obj0.getFile();
      int num = String.instancehelper_indexOf(file, 63);
      if (num == -1)
        return (string) null;
      return String.instancehelper_substring(file, num + 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 157, (byte) 115, (byte) 130, (byte) 114, (byte) 146, (byte) 104, (byte) 244, (byte) 69, (byte) 2, (byte) 193})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isPath([In] URL obj0)
    {
      if (String.instancehelper_endsWith(this.getPath(obj0), "/"))
        return true;
      if (String.instancehelper_equals(obj0.getProtocol(), (object) "file"))
      {
        File.__\u003Cclinit\u003E();
        File file = new File(this.getPath(obj0));
        int num;
        try
        {
          if (file.isDirectory())
            num = 1;
          else
            goto label_9;
        }
        catch (SecurityException ex)
        {
          goto label_8;
        }
        return num != 0;
label_8:;
      }
label_9:
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 114, (byte) 102, (byte) 109, (byte) 109, (byte) 105, (byte) 226, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int startsWithUntil([In] List obj0, [In] List obj1)
    {
      int num = Math.min(obj1.size(), obj0.size());
      for (int index = 0; index < num; ++index)
      {
        if (!String.instancehelper_equals((string) obj0.get(index), (object) (string) obj1.get(index)))
          return index;
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 90, (byte) 102, (byte) 103, (byte) 104, (byte) 109, (byte) 104, (byte) 174, (byte) 99, (byte) 105, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string formatName([In] List obj0, [In] string obj1)
    {
      StringBuffer stringBuffer = new StringBuffer();
      Iterator iterator = obj0.iterator();
      while (iterator.hasNext())
      {
        stringBuffer.append(iterator.next());
        if (iterator.hasNext())
          stringBuffer.append("/");
      }
      if (obj1 != null)
      {
        stringBuffer.append('?');
        stringBuffer.append(obj1);
      }
      return stringBuffer.toString();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 231, (byte) 199, (byte) 104, (byte) 100, (byte) 105, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void copyStreams(InputStream @in, OutputStream @out, int buffersize)
    {
      byte[] numArray = new byte[buffersize];
      for (int index = @in.read(numArray); index > -1; index = @in.read(numArray))
        @out.write(numArray, 0, index);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 199, (byte) 104, (byte) 100, (byte) 105, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void copyWriter(Reader @in, Writer @out, int buffersize)
    {
      char[] chArray = new char[buffersize];
      for (int index = @in.read(chArray); index > -1; index = @in.read(chArray))
        @out.write(chArray, 0, index);
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOUtils getInstance()
    {
      if (IOUtils.instance == null)
        IOUtils.instance = new IOUtils();
      return IOUtils.instance;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 217, (byte) 110, (byte) 110, (byte) 136, (byte) 105, (byte) 207, (byte) 105, (byte) 180, (byte) 105, (byte) 99, (byte) 169, (byte) 233, (byte) 74, (byte) 164, (byte) 103, (byte) 110, (byte) 106, (byte) 105, (byte) 45, (byte) 232, (byte) 69, (byte) 117, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string createRelativeURL(URL url, URL baseURL)
    {
      if (url == null)
      {
        string str = "content url must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (baseURL == null)
      {
        string str = "baseURL must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (this.isFileStyleProtocol(url) && this.isSameService(url, baseURL))
      {
        List list1 = this.parseName(this.getPath(url));
        List list2 = this.parseName(this.getPath(baseURL));
        string query = this.getQuery(url);
        if (!this.isPath(baseURL))
          list2.remove(list2.size() - 1);
        if (url.equals((object) baseURL))
          return (string) list1.get(list1.size() - 1);
        int num1 = this.startsWithUntil(list1, list2);
        if (num1 == 0)
        {
          return url.toExternalForm();
        }
        else
        {
          if (num1 == list1.size())
            num1 += -1;
          ArrayList arrayList = new ArrayList();
          if (list2.size() >= list1.size())
          {
            int num2 = list2.size() - num1;
            for (int index = 0; index < num2; ++index)
              arrayList.add((object) "..");
          }
          arrayList.addAll((Collection) list1.subList(num1, list1.size()));
          return this.formatName((List) arrayList, query);
        }
      }
      else
        return url.toExternalForm();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void copyStreams(InputStream @in, OutputStream @out)
    {
      this.copyStreams(@in, @out, 4096);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void copyWriter(Reader @in, Writer @out)
    {
      this.copyWriter(@in, @out, 4096);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 31, (byte) 104, (byte) 108, (byte) 100, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getFileName(URL url)
    {
      string path = this.getPath(url);
      int num = String.instancehelper_lastIndexOf(path, "/");
      if (num < 0)
        return path;
      return String.instancehelper_substring(path, num + 1);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 140, (byte) 100, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string stripFileExtension(string file)
    {
      int num = String.instancehelper_lastIndexOf(file, ".");
      if (num < 1)
        return file;
      return String.instancehelper_substring(file, 0, num);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 62, (byte) 140, (byte) 100, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getFileExtension(string file)
    {
      int num = String.instancehelper_lastIndexOf(file, ".");
      if (num < 1)
        return "";
      return String.instancehelper_substring(file, num);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 104, (byte) 136, (byte) 98, (byte) 99, (byte) 105, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isSubDirectory(File @base, File child)
    {
      @base = @base.getCanonicalFile();
      child = child.getCanonicalFile();
      for (File file = child; file != null; file = file.getParentFile())
      {
        if (@base.equals((object) file))
          return true;
      }
      return false;
    }
  }
}
