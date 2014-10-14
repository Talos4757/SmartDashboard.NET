// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.ExtensionFileFilter
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
  public class ExtensionFileFilter : FileFilter
  {
    private string description;
    private string extension;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExtensionFileFilter(string description, string extension)
    {
      base.\u002Ector();
      ExtensionFileFilter extensionFileFilter = this;
      this.description = description;
      this.extension = extension;
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 162, (byte) 108, (byte) 110, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool accept(File file)
    {
      return file.isDirectory() || String.instancehelper_endsWith(String.instancehelper_toLowerCase(file.getName()), this.extension);
    }

    public virtual string getDescription()
    {
      return this.description;
    }
  }
}
