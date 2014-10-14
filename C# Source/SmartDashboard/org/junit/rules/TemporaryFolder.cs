// Decompiled with JetBrains decompiler
// Type: org.junit.rules.TemporaryFolder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.rules
{
  public class TemporaryFolder : ExternalResource
  {
    private File folder;

    [LineNumberTable((ushort) 27)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TemporaryFolder()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 117, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void create()
    {
      this.folder = File.createTempFile("junit", "");
      this.folder.delete();
      this.folder.mkdir();
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void delete()
    {
      this.recursiveDelete(this.folder);
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 103, (byte) 99, (byte) 112, (byte) 40, (byte) 134, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void recursiveDelete([In] File obj0)
    {
      File[] fileArray1 = obj0.listFiles();
      if (fileArray1 != null)
      {
        File[] fileArray2 = fileArray1;
        int length = fileArray2.Length;
        for (int index = 0; index < length; ++index)
          this.recursiveDelete(fileArray2[index]);
      }
      obj0.delete();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void before()
    {
      this.create();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 179, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void after()
    {
      this.delete();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 4, (byte) 114, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual File newFile(string fileName)
    {
      File.__\u003Cclinit\u003E();
      File file = new File(this.folder, fileName);
      file.createNewFile();
      return file;
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 114, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual File newFolder(string folderName)
    {
      File.__\u003Cclinit\u003E();
      File file = new File(this.folder, folderName);
      file.mkdir();
      return file;
    }

    public virtual File getRoot()
    {
      return this.folder;
    }
  }
}
