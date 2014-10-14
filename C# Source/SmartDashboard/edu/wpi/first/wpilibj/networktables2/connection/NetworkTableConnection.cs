// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.connection.NetworkTableConnection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2.connection
{
  [SourceFile(null)]
  public class NetworkTableConnection : Object
  {
    public const char PROTOCOL_REVISION = 'Ȁ';
    [Modifiers]
    private object WRITE_LOCK;
    [Modifiers]
    private DataInputStream @is;
    [Modifiers]
    private DataOutputStream os;
    internal IOStream __\u003C\u003Estream;
    [Modifiers]
    private NetworkTableEntryTypeManager typeManager;
    private bool isValid;

    [Modifiers]
    public IOStream stream
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Estream;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Estream = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NetworkTableConnection(IOStream ios, NetworkTableEntryTypeManager ntetm)
    {
      base.\u002Ector();
      NetworkTableConnection networkTableConnection = this;
      this.WRITE_LOCK = (object) new Object();
      this.__\u003C\u003Estream = ios;
      this.typeManager = ntetm;
      BufferedInputStream.__\u003Cclinit\u003E();
      this.@is = new DataInputStream((InputStream) new BufferedInputStream(ios.getInputStream()));
      this.os = new DataOutputStream((OutputStream) new BufferedOutputStream(ios.getOutputStream()));
      this.isValid = true;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendEntryAssignment(NetworkTableEntry nte)
    {
      lock (this.WRITE_LOCK)
      {
        this.sendMessageHeader(16);
        this.os.writeUTF(nte.__\u003C\u003Ename);
        this.os.writeByte((int) (sbyte) nte.getType().__\u003C\u003Eid);
        this.os.writeChar((int) nte.getId());
        this.os.writeChar((int) nte.getSequenceNumber());
        nte.sendValue(this.os);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendClientHello()
    {
      lock (this.WRITE_LOCK)
      {
        this.sendMessageHeader(1);
        this.os.writeChar(512);
        this.flush();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      if (!this.isValid)
        return;
      this.isValid = false;
      this.__\u003C\u003Estream.close();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendEntryUpdate(NetworkTableEntry nte)
    {
      lock (this.WRITE_LOCK)
      {
        this.sendMessageHeader(17);
        this.os.writeChar((int) nte.getId());
        this.os.writeChar((int) nte.getSequenceNumber());
        nte.sendValue(this.os);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void flush()
    {
      lock (this.WRITE_LOCK)
        this.os.flush();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendKeepAlive()
    {
      lock (this.WRITE_LOCK)
      {
        this.sendMessageHeader(0);
        this.flush();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void read(ConnectionAdapter ca)
    {
      IOException ioException;
      try
      {
        int num1 = (int) (sbyte) this.@is.readByte();
        switch (num1)
        {
          case 0:
            ca.keepAlive();
            return;
          case 1:
            int num2 = (int) this.@is.readChar();
            ca.clientHello((char) num2);
            return;
          case 2:
            int num3 = (int) this.@is.readChar();
            ca.protocolVersionUnsupported((char) num3);
            return;
          case 3:
            ca.serverHelloComplete();
            return;
          case 16:
            string str1 = this.@is.readUTF();
            int num4 = (int) (sbyte) this.@is.readByte();
            NetworkTableEntryType type = this.typeManager.getType((byte) num4);
            if (type == null)
            {
              string str2 = new StringBuilder().append("Unknown data type: 0x").append(Integer.toHexString(num4)).toString();
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new BadMessageException(str2);
            }
            else
            {
              int num5 = (int) this.@is.readChar();
              int num6 = (int) this.@is.readChar();
              object obj = type.readValue(this.@is);
              ca.offerIncomingAssignment(new NetworkTableEntry((char) num5, str1, (char) num6, type, obj));
              return;
            }
          case 17:
            int num7 = (int) this.@is.readChar();
            int num8 = (int) this.@is.readChar();
            NetworkTableEntry entry = ca.getEntry((char) num7);
            if (entry == null)
            {
              string str2 = new StringBuilder().append("Received update for unknown entry id: ").append(num7).toString();
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new BadMessageException(str2);
            }
            else
            {
              object obj = entry.getType().readValue(this.@is);
              ca.offerIncomingUpdate(entry, (char) num8, obj);
              return;
            }
          default:
            string str3 = new StringBuilder().append("Unknown Network Table Message Type: ").append(num1).toString();
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new BadMessageException(str3);
        }
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      throw Throwable.__\u003Cunmap\u003E((Exception) ioException);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void sendMessageHeader([In] int obj0)
    {
      lock (this.WRITE_LOCK)
        this.os.writeByte(obj0);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendServerHelloComplete()
    {
      lock (this.WRITE_LOCK)
      {
        this.sendMessageHeader(3);
        this.flush();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sendProtocolVersionUnsupported()
    {
      lock (this.WRITE_LOCK)
      {
        this.sendMessageHeader(2);
        this.os.writeChar(512);
        this.flush();
      }
    }
  }
}
