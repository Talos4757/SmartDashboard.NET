// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.FilesystemFilter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using javax.swing.filechooser;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.io.FilenameFilter"})]
  public class FilesystemFilter : FileFilter, FilenameFilter
  {
    private string[] fileext;
    private string descr;
    private bool accDirs;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 66, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FilesystemFilter(string fileext, string descr, bool accDirs)
    {
      int num1 = accDirs ? 1 : 0;
      string[] fileext1 = new string[1];
      int index = 0;
      string str = fileext;
      fileext1[index] = str;
      string descr1 = descr;
      int num2 = num1;
      // ISSUE: explicit constructor call
      this.\u002Ector(fileext1, descr1, num2 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 66, (byte) 104, (byte) 118, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FilesystemFilter(string[] fileext, string descr, bool accDirs)
    {
      int num = accDirs ? 1 : 0;
      base.\u002Ector();
      FilesystemFilter filesystemFilter = this;
      this.fileext = (string[]) fileext.Clone();
      this.descr = descr;
      this.accDirs = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FilesystemFilter(string fileext, string descr)
      : this(fileext, descr, true)
    {
    }

    public virtual bool acceptsDirectories()
    {
      return this.accDirs;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 104, (byte) 112, (byte) 162, (byte) 108, (byte) 112, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool accept(File dir, string name)
    {
      if (new File(dir, name).isDirectory() && this.acceptsDirectories())
        return true;
      for (int index = 0; index < this.fileext.Length; ++index)
      {
        if (String.instancehelper_endsWith(name, this.fileext[index]))
          return true;
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 112, (byte) 162, (byte) 108, (byte) 117, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool accept(File dir)
    {
      if (dir.isDirectory() && this.acceptsDirectories())
        return true;
      for (int index = 0; index < this.fileext.Length; ++index)
      {
        if (String.instancehelper_endsWith(dir.getName(), this.fileext[index]))
          return true;
      }
      return false;
    }

    public virtual string getDescription()
    {
      return this.descr;
    }

    public virtual void acceptDirectories(bool b)
    {
      this.accDirs = b;
    }
  }
}
