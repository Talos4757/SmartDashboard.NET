// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.extensions.FileSniffer$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.extensions
{
  [InnerClass]
  [Implements(new string[] {"java.io.FilenameFilter"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.extensions.FileSniffer", "findExtensions", "(Ljavax.swing.ProgressMonitor;II)V")]
  [SourceFile("FileSniffer.java")]
  internal sealed class FileSniffer\u00242 : Object, FilenameFilter
  {
    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FileSniffer\u00242()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 85)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool accept([In] File obj0, [In] string obj1)
    {
      return (String.instancehelper_endsWith(obj1, ".jar") ? 1 : 0) != 0;
    }
  }
}
