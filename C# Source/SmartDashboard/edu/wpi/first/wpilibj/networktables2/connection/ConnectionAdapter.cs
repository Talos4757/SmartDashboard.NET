// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.connection.ConnectionAdapter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using IKVM.Attributes;
using java.io;

namespace edu.wpi.first.wpilibj.networktables2.connection
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.IncomingEntryReceiver"})]
  [SourceFile(null)]
  public interface ConnectionAdapter : IncomingEntryReceiver
  {
    [Throws(new string[] {"java.io.IOException"})]
    void keepAlive();

    [Throws(new string[] {"java.io.IOException"})]
    void clientHello(char ch);

    [Throws(new string[] {"java.io.IOException"})]
    void protocolVersionUnsupported(char ch);

    [Throws(new string[] {"java.io.IOException"})]
    void serverHelloComplete();

    NetworkTableEntry getEntry(char ch);

    void badMessage(BadMessageException bme);

    void ioException(IOException ioe);
  }
}
