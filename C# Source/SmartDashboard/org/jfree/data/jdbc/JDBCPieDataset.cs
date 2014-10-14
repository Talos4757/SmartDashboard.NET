// Decompiled with JetBrains decompiler
// Type: org.jfree.data.jdbc.JDBCPieDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.sql;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.jdbc
{
  [Serializable]
  public class JDBCPieDataset : DefaultPieDataset
  {
    internal const long serialVersionUID = -8753216855496746108L;
    [NonSerialized]
    private Connection connection;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 66, (byte) 104, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCPieDataset(Connection con)
    {
      JDBCPieDataset jdbcPieDataset = this;
      if (con == null)
      {
        string str = "A connection must be supplied.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
        this.connection = con;
    }

    [Throws(new string[] {"java.sql.SQLException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 53, (byte) 136, (byte) 108, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCPieDataset(string url, string driverName, string user, string password)
    {
      JDBCPieDataset jdbcPieDataset = this;
      Class.forName(driverName, JDBCPieDataset.__\u003CGetCallerID\u003E());
      this.connection = DriverManager.getConnection(url, user, password, JDBCPieDataset.__\u003CGetCallerID\u003E());
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 85, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCPieDataset(Connection con, string query)
      : this(con)
    {
      JDBCPieDataset jdbcPieDataset = this;
      this.executeQuery(query);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected JDBCPieDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 101, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void executeQuery(string query)
    {
      this.executeQuery(this.connection, query);
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 118, (byte) 98, (byte) 162, (byte) 103, (byte) 104, (byte) 135, (byte) 103, (byte) 100, (byte) 240, (byte) 69, (byte) 105, (byte) 106, (byte) 107, (byte) 105, (byte) 255, (byte) 51, (byte) 72, (byte) 106, (byte) 106, (byte) 226, (byte) 69, (byte) 105, (byte) 106, (byte) 106, (byte) 162, (byte) 239, (byte) 69, (byte) 133, (byte) 205, (byte) 131, (byte) 219, (byte) 2, (byte) 97, (byte) 175, (byte) 131, (byte) 219, (byte) 2, (byte) 97, (byte) 111, (byte) 227, (byte) 50, (byte) 131, (byte) 219, (byte) 2, (byte) 97, (byte) 175, (byte) 131, (byte) 219, (byte) 2, (byte) 97, (byte) 111, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void executeQuery(Connection con, string query)
    {
      Statement statement = (Statement) null;
      ResultSet resultSet = (ResultSet) null;
      // ISSUE: fault handler
      try
      {
        statement = con.createStatement();
        resultSet = statement.executeQuery(query);
        ResultSetMetaData metaData = resultSet.getMetaData();
        if (metaData.getColumnCount() != 2)
        {
          string str = "Invalid sql generated.  PieDataSet requires 2 columns only";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new SQLException(str);
        }
        else
        {
          int columnType = metaData.getColumnType(2);
          while (resultSet.next())
          {
            string @string = resultSet.getString(1);
            int num1 = columnType;
            int num2 = -5;
            if (num1 != num2)
            {
              int num3 = 2;
              if (num1 != num3)
              {
                int num4 = 3;
                if (num1 != num4)
                {
                  int num5 = 4;
                  if (num1 != num5)
                  {
                    int num6 = 6;
                    if (num1 != num6)
                    {
                      int num7 = 7;
                      if (num1 != num7)
                      {
                        int num8 = 8;
                        if (num1 != num8)
                        {
                          int num9 = 91;
                          if (num1 != num9)
                          {
                            int num10 = 92;
                            if (num1 != num10)
                            {
                              int num11 = 93;
                              if (num1 != num11)
                              {
                                System.get_err().println("JDBCPieDataset - unknown data type");
                                continue;
                              }
                            }
                          }
                          double num12 = (double) resultSet.getTimestamp(2).getTime();
                          this.setValue((IComparable) @string, num12);
                          continue;
                        }
                      }
                    }
                  }
                }
              }
            }
            double @double = resultSet.getDouble(2);
            this.setValue((IComparable) @string, @double);
          }
          this.fireDatasetChanged();
        }
      }
      __fault
      {
        if (resultSet != null)
        {
          try
          {
            resultSet.close();
            goto label_24;
          }
          catch (Exception exception_3)
          {
            int temp_43 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_3, (ByteCodeHelper.MapFlags) temp_43) == null)
              throw;
          }
          System.get_err().println("JDBCPieDataset: swallowing exception.");
        }
label_24:
        if (statement != null)
        {
          try
          {
            statement.close();
            goto label_29;
          }
          catch (Exception exception_2)
          {
            int temp_37 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_2, (ByteCodeHelper.MapFlags) temp_37) == null)
              throw;
          }
          System.get_err().println("JDBCPieDataset: swallowing exception.");
        }
label_29:;
      }
      if (resultSet != null)
      {
        try
        {
          resultSet.close();
          goto label_35;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
        System.get_err().println("JDBCPieDataset: swallowing exception.");
      }
label_35:
      if (statement == null)
        return;
      try
      {
        statement.close();
        return;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      System.get_err().println("JDBCPieDataset: swallowing exception.");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 223, (byte) 1, (byte) 2, (byte) 97, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      try
      {
        this.connection.close();
        return;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
      System.get_err().println("JdbcXYDataset: swallowing exception.");
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JDBCPieDataset.__\u003CcallerID\u003E == null)
        JDBCPieDataset.__\u003CcallerID\u003E = (CallerID) new JDBCPieDataset.__\u003CCallerID\u003E();
      return JDBCPieDataset.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
