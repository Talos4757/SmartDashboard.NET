// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.main
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.extensions;
using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.robot;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard
{
  public class main : Object
  {
    private static bool inCompetition = false;
    private static DashboardFrame frame;

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public main()
    {
      base.\u002Ector();
    }

    [Modifiers]
    internal static bool access\u0024100()
    {
      return main.inCompetition;
    }

    [Modifiers]
    internal static DashboardFrame access\u0024002([In] DashboardFrame obj0)
    {
      return main.frame = obj0;
    }

    [Modifiers]
    internal static DashboardFrame access\u0024000()
    {
      return main.frame;
    }

    public static bool inCompetition()
    {
      return main.inCompetition;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 255, (byte) 2, (byte) 73, (byte) 226, (byte) 61, (byte) 97, (byte) 102, (byte) 198, (byte) 183, (byte) 204, (byte) 119, (byte) 240, (byte) 72, (byte) 255, (byte) 4, (byte) 71, (byte) 226, (byte) 61, (byte) 98, (byte) 103, (byte) 230, (byte) 70, (byte) 113, (byte) 109, (byte) 107, (byte) 127, (byte) 11, (byte) 181, (byte) 107, (byte) 107, (byte) 110, (byte) 136, (byte) 108, (byte) 100, (byte) 124, (byte) 130, (byte) 126, (byte) 139, (byte) 107, (byte) 127, (byte) 2, (byte) 239, (byte) 72, (byte) 255, (byte) 5, (byte) 92, (byte) 226, (byte) 61, (byte) 98, (byte) 103, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      Exception exception1;
      try
      {
        SwingUtilities.invokeAndWait((Runnable) new main\u00241());
        goto label_5;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception1);
      System.exit(2);
label_5:
      ProgressMonitor monitor = new ProgressMonitor((Component) null, (object) "Loading SmartDashboard", "Initializing internal code...", 0, 1000);
      FileSniffer.findExtensions(monitor, 0, 490);
      string[] args1 = args;
      int num1 = 1;
      int num2 = 1;
      string[] valueArgs = new string[1];
      int index = 0;
      string str1 = "ip";
      valueArgs[index] = str1;
      ArgParser argParser = new ArgParser(args1, num1 != 0, num2 != 0, valueArgs);
      main.inCompetition = argParser.hasFlag("competition");
      Exception exception2;
      try
      {
        SwingUtilities.invokeAndWait((Runnable) new main\u00242());
        goto label_11;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num3);
        if (m0 == null)
          throw;
        else
          exception2 = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception2);
      System.exit(2);
label_11:
      IntegerProperty integerProperty = main.frame.getPrefs().__\u003C\u003Eteam;
      if (argParser.hasValue("ip"))
      {
        monitor.setProgress(650);
        monitor.setNote(new StringBuilder().append("Connecting to robot at: ").append(argParser.getValue("ip")).toString());
        Robot.setHost(argParser.getValue("ip"));
      }
      else
      {
        monitor.setProgress(600);
        monitor.setNote("Getting Team Number");
        int num3 = integerProperty.getValue().intValue();
        while (num3 <= 0)
        {
          string str2;
          try
          {
            str2 = JOptionPane.showInputDialog((object) "Input Team Number");
            if (str2 == null)
            {
              num3 = 0;
              break;
            }
            else
              goto label_20;
          }
          catch (Exception ex)
          {
            int num4 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num4) == null)
              throw;
          }
          // ISSUE: variable of the null type
          __Null local = null;
          goto label_24;
label_20:
          try
          {
            num3 = Integer.parseInt(str2);
            continue;
          }
          catch (Exception ex)
          {
            int num4 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num4) == null)
              throw;
          }
          local = null;
label_24:;
        }
        monitor.setProgress(650);
        monitor.setNote(new StringBuilder().append("Connecting to robot of team: ").append(num3).toString());
        integerProperty.setValue((object) Integer.valueOf(num3));
      }
      Exception exception3;
      try
      {
        SwingUtilities.invokeAndWait((Runnable) new main\u00243(monitor));
        return;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num3);
        if (m0 == null)
          throw;
        else
          exception3 = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception3);
      System.exit(2);
    }
  }
}
