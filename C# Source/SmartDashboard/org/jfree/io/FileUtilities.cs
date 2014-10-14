// Decompiled with JetBrains decompiler
// Type: org.jfree.io.FileUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.io
{
  public class FileUtilities : Object
  {
    [LineNumberTable(new byte[] {(byte) 10, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private FileUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 107, (byte) 139, (byte) 136, (byte) 107, (byte) 135, (byte) 104, (byte) 137, (byte) 105, (byte) 116, (byte) 105, (byte) 131, (byte) 130, (byte) 106, (byte) 105, (byte) 195, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static File findFileOnClassPath(string name)
    {
      StringTokenizer stringTokenizer = new StringTokenizer(System.getProperty("java.class.path"), System.getProperty("path.separator"));
      while (stringTokenizer.hasMoreTokens())
      {
        File file1 = new File(stringTokenizer.nextToken());
        File absoluteFile = file1.getAbsoluteFile();
        if (absoluteFile.isFile())
        {
          File.__\u003Cclinit\u003E();
          File file2 = new File(absoluteFile.getParent(), name);
          if (file2.exists())
            return file2;
        }
        else
        {
          File file2 = new File(file1, name);
          if (file2.exists())
            return file2;
        }
      }
      return (File) null;
    }
  }
}
