// Decompiled with JetBrains decompiler
// Type: org.jfree.data.jdbc.JDBCCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.sql;
using java.util;
using org.jfree.data.category;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.jdbc
{
  [Serializable]
  public class JDBCCategoryDataset : DefaultCategoryDataset
  {
    internal const long serialVersionUID = -3080395327918844965L;
    [NonSerialized]
    private Connection connection;
    private bool transpose;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 86, (byte) 232, (byte) 34, (byte) 231, (byte) 95, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCCategoryDataset(Connection connection)
    {
      JDBCCategoryDataset jdbcCategoryDataset = this;
      this.transpose = true;
      if (connection == null)
      {
        string str = "A connection must be supplied.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
        this.connection = connection;
    }

    [Throws(new string[] {"java.lang.ClassNotFoundException", "java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 75, (byte) 232, (byte) 45, (byte) 231, (byte) 85, (byte) 108, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCCategoryDataset(string url, string driverName, string user, string passwd)
    {
      JDBCCategoryDataset jdbcCategoryDataset = this;
      this.transpose = true;
      Class.forName(driverName, JDBCCategoryDataset.__\u003CGetCallerID\u003E());
      this.connection = DriverManager.getConnection(url, user, passwd, JDBCCategoryDataset.__\u003CGetCallerID\u003E());
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 104, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCCategoryDataset(Connection connection, string query)
      : this(connection)
    {
      JDBCCategoryDataset jdbcCategoryDataset = this;
      this.executeQuery(query);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected JDBCCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 77, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void executeQuery(string query)
    {
      this.executeQuery(this.connection, query);
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 98, (byte) 130, (byte) 103, (byte) 104, (byte) 135, (byte) 135, (byte) 100, (byte) 240, (byte) 70, (byte) 104, (byte) 107, (byte) 239, (byte) 160, (byte) 72, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 227, (byte) 159, (byte) 173, (byte) 136, (byte) 105, (byte) 239, (byte) 160, (byte) 66, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 240, (byte) 159, (byte) 178, (byte) 106, (byte) 138, (byte) 255, (byte) 109, (byte) 74, (byte) 111, (byte) 104, (byte) 177, (byte) 140, (byte) 229, (byte) 69, (byte) 111, (byte) 115, (byte) 104, (byte) 177, (byte) 140, (byte) 226, (byte) 69, (byte) 175, (byte) 105, (byte) 104, (byte) 174, (byte) 247, (byte) 69, (byte) 236, (byte) 77, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 235, (byte) 35, (byte) 161, (byte) 226, (byte) 10, (byte) 237, (byte) 160, (byte) 66, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 230, (byte) 45, (byte) 133, (byte) 173, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 227, (byte) 50, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void executeQuery(Connection con, string query)
    {
      Statement statement = (Statement) null;
      ResultSet resultSet = (ResultSet) null;
      ResultSetMetaData metaData;
      int columnCount;
      // ISSUE: fault handler
      try
      {
        statement = con.createStatement();
        resultSet = statement.executeQuery(query);
        metaData = resultSet.getMetaData();
        columnCount = metaData.getColumnCount();
        if (columnCount < 2)
        {
          string str = "JDBCCategoryDataset.executeQuery() : insufficient columns returned from the database.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new SQLException(str);
        }
        else
        {
          int rowCount = this.getRowCount();
          while (true)
          {
            rowCount += -1;
            if (rowCount >= 0)
              this.removeRow(rowCount);
            else
              break;
          }
        }
      }
      __fault
      {
        if (resultSet != null)
        {
          try
          {
            resultSet.close();
            goto label_11;
          }
          catch (Exception exception_12)
          {
            int temp_161 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_12, (ByteCodeHelper.MapFlags) temp_161) == null)
              throw;
          }
        }
label_11:
        if (statement != null)
        {
          try
          {
            statement.close();
            goto label_16;
          }
          catch (Exception exception_11)
          {
            int temp_157 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_11, (ByteCodeHelper.MapFlags) temp_157) == null)
              throw;
          }
        }
label_16:;
      }
label_17:
      string @string;
      int num1;
      // ISSUE: fault handler
      try
      {
        if (resultSet.next())
        {
          @string = resultSet.getString(1);
          num1 = 2;
        }
        else
          goto label_81;
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
          catch (Exception exception_10)
          {
            int temp_149 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_10, (ByteCodeHelper.MapFlags) temp_149) == null)
              throw;
          }
        }
label_24:
        if (statement != null)
        {
          try
          {
            statement.close();
            goto label_29;
          }
          catch (Exception exception_9)
          {
            int temp_145 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_9, (ByteCodeHelper.MapFlags) temp_145) == null)
              throw;
          }
        }
label_29:;
      }
      while (true)
      {
        // ISSUE: fault handler
        try
        {
          if (num1 <= columnCount)
          {
            string columnName = metaData.getColumnName(num1);
            int columnType = metaData.getColumnType(num1);
            int num2 = -6;
            if (columnType != num2)
            {
              int num3 = -5;
              if (columnType != num3)
              {
                int num4 = -1;
                if (columnType != num4)
                {
                  int num5 = 1;
                  if (columnType != num5)
                  {
                    int num6 = 2;
                    if (columnType != num6)
                    {
                      int num7 = 3;
                      if (columnType != num7)
                      {
                        int num8 = 4;
                        if (columnType != num8)
                        {
                          int num9 = 5;
                          if (columnType != num9)
                          {
                            int num10 = 6;
                            if (columnType != num10)
                            {
                              int num11 = 7;
                              if (columnType != num11)
                              {
                                int num12 = 8;
                                if (columnType != num12)
                                {
                                  int num13 = 12;
                                  if (columnType != num13)
                                  {
                                    int num14 = 91;
                                    if (columnType != num14)
                                    {
                                      int num15 = 92;
                                      if (columnType != num15)
                                      {
                                        int num16 = 93;
                                        if (columnType != num16)
                                          goto label_69;
                                      }
                                    }
                                    Date date = (Date) resultSet.getObject(num1);
                                    Long.__\u003Cclinit\u003E();
                                    Long @long = new Long(((Date) date).getTime());
                                    if (this.transpose)
                                    {
                                      this.setValue((Number) @long, (IComparable) columnName, (IComparable) @string);
                                      goto label_69;
                                    }
                                    else
                                    {
                                      this.setValue((Number) @long, (IComparable) @string, (IComparable) columnName);
                                      goto label_69;
                                    }
                                  }
                                }
                                else
                                  goto label_46;
                              }
                              else
                                goto label_46;
                            }
                            else
                              goto label_46;
                          }
                          else
                            goto label_46;
                        }
                        else
                          goto label_46;
                      }
                      else
                        goto label_46;
                    }
                    else
                      goto label_46;
                  }
                }
                string str = (string) resultSet.getObject(num1);
                try
                {
                  Double @double = Double.valueOf(str);
                  if (this.transpose)
                  {
                    this.setValue((Number) @double, (IComparable) columnName, (IComparable) @string);
                    goto label_69;
                  }
                  else
                  {
                    this.setValue((Number) @double, (IComparable) @string, (IComparable) columnName);
                    goto label_69;
                  }
                }
                catch (NumberFormatException ex)
                {
                  goto label_68;
                }
              }
            }
label_46:
            Number number = (Number) resultSet.getObject(num1);
            if (this.transpose)
            {
              this.setValue(number, (IComparable) columnName, (IComparable) @string);
              goto label_69;
            }
            else
            {
              this.setValue(number, (IComparable) @string, (IComparable) columnName);
              goto label_69;
            }
          }
          else
            goto label_17;
        }
        __fault
        {
          if (resultSet != null)
          {
            try
            {
              resultSet.close();
              goto label_62;
            }
            catch (Exception exception_7)
            {
              int temp_91 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_7, (ByteCodeHelper.MapFlags) temp_91) == null)
                throw;
            }
          }
label_62:
          if (statement != null)
          {
            try
            {
              statement.close();
              goto label_67;
            }
            catch (Exception exception_6)
            {
              int temp_87 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_6, (ByteCodeHelper.MapFlags) temp_87) == null)
                throw;
            }
          }
label_67:;
        }
label_68:
label_69:
        // ISSUE: fault handler
        try
        {
          ++num1;
        }
        __fault
        {
          if (resultSet != null)
          {
            try
            {
              resultSet.close();
              goto label_75;
            }
            catch (Exception exception_5)
            {
              int temp_81 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_5, (ByteCodeHelper.MapFlags) temp_81) == null)
                throw;
            }
          }
label_75:
          if (statement != null)
          {
            try
            {
              statement.close();
              goto label_80;
            }
            catch (Exception exception_4)
            {
              int temp_77 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_4, (ByteCodeHelper.MapFlags) temp_77) == null)
                throw;
            }
          }
label_80:;
        }
      }
label_81:
      // ISSUE: fault handler
      try
      {
        this.fireDatasetChanged();
      }
      __fault
      {
        if (resultSet != null)
        {
          try
          {
            resultSet.close();
            goto label_87;
          }
          catch (Exception exception_3)
          {
            int temp_40 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_3, (ByteCodeHelper.MapFlags) temp_40) == null)
              throw;
          }
        }
label_87:
        if (statement != null)
        {
          try
          {
            statement.close();
            goto label_92;
          }
          catch (Exception exception_2)
          {
            int temp_36 = 2;
            if (ByteCodeHelper.MapException<Exception>(exception_2, (ByteCodeHelper.MapFlags) temp_36) == null)
              throw;
          }
        }
label_92:;
      }
      if (resultSet != null)
      {
        try
        {
          resultSet.close();
          goto label_98;
        }
        catch (Exception ex)
        {
          int num2 = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
            throw;
        }
      }
label_98:
      if (statement == null)
        return;
      try
      {
        statement.close();
      }
      catch (Exception ex)
      {
        int num2 = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
          throw;
      }
    }

    public virtual bool getTranspose()
    {
      return this.transpose;
    }

    public virtual void setTranspose(bool transpose)
    {
      this.transpose = transpose;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JDBCCategoryDataset.__\u003CcallerID\u003E == null)
        JDBCCategoryDataset.__\u003CcallerID\u003E = (CallerID) new JDBCCategoryDataset.__\u003CCallerID\u003E();
      return JDBCCategoryDataset.__\u003CcallerID\u003E;
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
