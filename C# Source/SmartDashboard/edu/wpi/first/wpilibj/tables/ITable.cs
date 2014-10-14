// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.tables.ITable
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using System;

namespace edu.wpi.first.wpilibj.tables
{
  [SourceFile(null)]
  public interface ITable
  {
    void addTableListener(ITableListener itl, bool b);

    void removeTableListener(ITableListener itl);

    bool containsKey(string str);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    object getValue(string str);

    ITable getSubTable(string str);

    string getString(string str1, string str2);

    bool getBoolean(string str, bool b);

    void addTableListener(string str, ITableListener itl, bool b);

    void addSubTableListener(ITableListener itl);

    bool containsSubTable(string str);

    void putString(string str1, string str2);

    void putNumber(string str, double d);

    void putBoolean(string str, bool b);

    void retrieveValue(string str, object obj);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    string getString(string str);

    [Throws(new string[] {"java.lang.IllegalArgumentException"})]
    void putValue(string str, object obj);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    double getNumber(string str);

    double getNumber(string str, double d);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    bool getBoolean(string str);

    void addTableListener(ITableListener itl);

    [Obsolete]
    void putInt(string str, int i);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [Obsolete]
    int getInt(string str);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [Obsolete]
    int getInt(string str, int i);

    [Obsolete]
    void putDouble(string str, double d);

    [Throws(new string[] {"edu.wpi.first.wpilibj.tables.TableKeyNotDefinedException"})]
    [Obsolete]
    double getDouble(string str);

    [Obsolete]
    double getDouble(string str, double d);
  }
}
