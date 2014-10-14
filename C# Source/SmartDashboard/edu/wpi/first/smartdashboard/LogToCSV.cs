// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.LogToCSV
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.robot;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  public class LogToCSV : Object, ITableListener
  {
    [Modifiers]
    private static string s_lineSeparator = System.getProperty("line.separator");
    private long m_startTime;
    private FileWriter m_fw;
    [Modifiers]
    private DashboardFrame frame;

    [LineNumberTable((ushort) 18)]
    static LogToCSV()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogToCSV(DashboardFrame frame)
    {
      base.\u002Ector();
      LogToCSV logToCsv = this;
      this.frame = frame;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 139, (byte) 107, (byte) 108, (byte) 127, (byte) 10, (byte) 107, (byte) 254, (byte) 70, (byte) 226, (byte) 59, (byte) 97, (byte) 102, (byte) 145, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void start(string path)
    {
      if (this.m_fw != null)
        return;
      IOException ioException;
      try
      {
        this.m_startTime = System.currentTimeMillis();
        this.m_fw = new FileWriter(path);
        ((Writer) this.m_fw).write(new StringBuilder().append("Time (ms),Name,Value").append(LogToCSV.s_lineSeparator).toString());
        ((OutputStreamWriter) this.m_fw).flush();
        Robot.getTable().addTableListener((ITableListener) this, true);
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      Throwable.instancehelper_printStackTrace((Exception) ioException);
      JOptionPane.showMessageDialog((Component) null, (object) "An error occurred when attempting to open the output CSV file for writing. Please check the file path preference.", "Unable to Open CSV File", 0);
      this.frame.getPrefs().__\u003C\u003ElogToCSV.setValue((object) Boolean.valueOf(false));
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 104, (byte) 193, (byte) 189, (byte) 2, (byte) 97, (byte) 134, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void stop()
    {
      if (this.m_fw == null)
        return;
      IOException ioException;
      try
      {
        ((OutputStreamWriter) this.m_fw).close();
        goto label_5;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      Throwable.instancehelper_printStackTrace((Exception) ioException);
label_5:
      Robot.getTable().removeTableListener((ITableListener) this);
      this.m_fw = (FileWriter) null;
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 150, (byte) 109, (byte) 127, (byte) 68, (byte) 189, (byte) 2, (byte) 97, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged(ITable source, string key, object value, bool isNew)
    {
      if (value is ITable)
        return;
      if (this.m_fw == null)
        return;
      IOException ioException;
      try
      {
        ((Writer) this.m_fw).write(new StringBuilder().append(System.currentTimeMillis() - this.m_startTime).append(",").append("\"").append(key).append("\",").append("\"").append(value).append("\"").append(LogToCSV.s_lineSeparator).toString());
        ((OutputStreamWriter) this.m_fw).flush();
        return;
      }
      catch (IOException ex)
      {
        int num = 1;
        ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
      }
      Throwable.instancehelper_printStackTrace((Exception) ioException);
    }
  }
}
