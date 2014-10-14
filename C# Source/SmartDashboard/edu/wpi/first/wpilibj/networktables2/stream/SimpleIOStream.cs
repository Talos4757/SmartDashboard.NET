// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.stream.SimpleIOStream
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.stream
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.stream.IOStream"})]
  [SourceFile(null)]
  public class SimpleIOStream : Object, IOStream
  {
    [Modifiers]
    private InputStream @is;
    [Modifiers]
    private OutputStream os;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleIOStream(InputStream @is, OutputStream os)
    {
      base.\u002Ector();
      SimpleIOStream simpleIoStream = this;
      this.@is = @is;
      this.os = os;
    }

    public virtual InputStream getInputStream()
    {
      return this.@is;
    }

    public virtual OutputStream getOutputStream()
    {
      return this.os;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      try
      {
        this.@is.close();
        goto label_3;
      }
      catch (IOException ex)
      {
      }
label_3:
      try
      {
        this.os.close();
      }
      catch (IOException ex)
      {
      }
    }
  }
}
