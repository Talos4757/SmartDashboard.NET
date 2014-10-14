// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.robot.Robot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables;
using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.client;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Threading;

namespace edu.wpi.first.smartdashboard.robot
{
  public class Robot : Object
  {
    private static volatile string _host = (string) null;
    private static volatile int _port = 1735;
    public const string PREF_SAVE_FIELD = "~S A V E~";
    public const string TABLE_NAME = "SmartDashboard";
    public const string LIVE_WINDOW_NAME = "LiveWindow";
    public const string PREFERENCES_NAME = "Preferences";
    [Modifiers]
    private static IOStreamFactory configurableFactory;
    internal static NetworkTableClient __\u003C\u003Eclient;
    [Modifiers]
    private static NetworkTableProvider provider;

    [Modifiers]
    public static NetworkTableClient client
    {
      [HideFromJava] get
      {
        return Robot.__\u003C\u003Eclient;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 104, (byte) 113, (byte) 234, (byte) 72, (byte) 111, (byte) 143, (byte) 108})]
    static Robot()
    {
      Thread.MemoryBarrier();
      Robot.configurableFactory = (IOStreamFactory) new Robot\u00241();
      Robot.__\u003C\u003Eclient = new NetworkTableClient(Robot.configurableFactory);
      Robot.provider = new NetworkTableProvider((NetworkTableNode) Robot.__\u003C\u003Eclient);
      NetworkTable.setTableProvider(Robot.provider);
    }

    [LineNumberTable((ushort) 14)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Robot()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITable getTable()
    {
      return Robot.provider.getRootTable().getSubTable("SmartDashboard");
    }

    [LineNumberTable((ushort) 63)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITable getLiveWindow()
    {
      return Robot.provider.getRootTable().getSubTable("LiveWindow");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 127, (byte) 43})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setTeam(int team)
    {
      StringBuilder stringBuilder = new StringBuilder().append("10.").append(team / 100).append(".");
      int num1 = team;
      int num2 = 100;
      int num3 = -1;
      int num4 = num2 != num3 ? num1 % num2 : 0;
      Robot.setHost(stringBuilder.append(num4).append(".2").toString());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 126, (byte) 162, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void addConnectionListener(IRemoteConnectionListener listener, bool immediateNotify)
    {
      int num = immediateNotify ? 1 : 0;
      Robot.__\u003C\u003Eclient.addConnectionListener(listener, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void removeConnectionListener(IRemoteConnectionListener listener)
    {
      Robot.__\u003C\u003Eclient.removeConnectionListener(listener);
    }

    [LineNumberTable((ushort) 60)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITable getPreferences()
    {
      return Robot.provider.getRootTable().getSubTable("Preferences");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 109, (byte) 127, (byte) 5, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setHost(string host)
    {
      Robot._host = host;
      Thread.MemoryBarrier();
      System.get_out().println(new StringBuilder().append("Host: ").append(host).toString());
      Robot.__\u003C\u003Eclient.close();
    }

    [Modifiers]
    internal static string access\u0024000()
    {
      return Robot._host;
    }

    [Modifiers]
    internal static int access\u0024100()
    {
      return Robot._port;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 109, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setPort(int port)
    {
      Robot._port = port;
      Thread.MemoryBarrier();
      Robot.__\u003C\u003Eclient.close();
    }

    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITable getTable(string tableName)
    {
      return Robot.provider.getRootTable().getSubTable(tableName);
    }
  }
}
