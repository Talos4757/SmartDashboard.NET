// Decompiled with JetBrains decompiler
// Type: org.jfree.data.jdbc.JDBCXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.sql;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.jdbc
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset", "org.jfree.data.xy.TableXYDataset", "org.jfree.data.RangeInfo"})]
  [Serializable]
  public class JDBCXYDataset : AbstractXYDataset, XYDataset, SeriesDataset, Dataset, TableXYDataset, RangeInfo
  {
    [NonSerialized]
    private Connection connection;
    private string[] columnNames;
    private ArrayList rows;
    private double maxValue;
    private double minValue;
    private bool isTimeSeries;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 76, (byte) 232, (byte) 46, (byte) 236, (byte) 70, (byte) 172, (byte) 172, (byte) 231, (byte) 71, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JDBCXYDataset()
    {
      JDBCXYDataset jdbcxyDataset = this;
      this.columnNames = new string[0];
      this.maxValue = 0.0;
      this.minValue = 0.0;
      this.isTimeSeries = false;
      this.rows = new ArrayList();
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 112, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCXYDataset(Connection con)
      : this()
    {
      JDBCXYDataset jdbcxyDataset = this;
      this.connection = con;
    }

    [Throws(new string[] {"java.sql.SQLException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 98, (byte) 104, (byte) 108, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCXYDataset(string url, string driverName, string user, string password)
      : this()
    {
      JDBCXYDataset jdbcxyDataset = this;
      Class.forName(driverName, JDBCXYDataset.__\u003CGetCallerID\u003E());
      this.connection = DriverManager.getConnection(url, user, password, JDBCXYDataset.__\u003CGetCallerID\u003E());
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 126, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JDBCXYDataset(Connection con, string query)
      : this(con)
    {
      JDBCXYDataset jdbcxyDataset = this;
      this.executeQuery(query);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected JDBCXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void executeQuery(string query)
    {
      this.executeQuery(this.connection, query);
    }

    [Throws(new string[] {"java.sql.SQLException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 99, (byte) 240, (byte) 69, (byte) 98, (byte) 130, (byte) 103, (byte) 104, (byte) 135, (byte) 103, (byte) 99, (byte) 104, (byte) 234, (byte) 160, (byte) 152, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 235, (byte) 159, (byte) 92, (byte) 108, (byte) 255, (byte) 72, (byte) 78, (byte) 102, (byte) 103, (byte) 130, (byte) 255, (byte) 53, (byte) 70, (byte) 249, (byte) 71, (byte) 236, (byte) 160, (byte) 118, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 243, (byte) 159, (byte) 121, (byte) 98, (byte) 102, (byte) 232, (byte) 160, (byte) 119, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 225, (byte) 159, (byte) 90, (byte) 237, (byte) 160, (byte) 152, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 230, (byte) 159, (byte) 128, (byte) 101, (byte) 240, (byte) 70, (byte) 143, (byte) 99, (byte) 104, (byte) 103, (byte) 147, (byte) 230, (byte) 60, (byte) 232, (byte) 73, (byte) 104, (byte) 114, (byte) 116, (byte) 7, (byte) 200, (byte) 203, (byte) 218, (byte) 103, (byte) 130, (byte) 231, (byte) 70, (byte) 107, (byte) 103, (byte) 107, (byte) 108, (byte) 255, (byte) 74, (byte) 73, (byte) 106, (byte) 226, (byte) 69, (byte) 126, (byte) 130, (byte) 130, (byte) 111, (byte) 230, (byte) 41, (byte) 235, (byte) 91, (byte) 110, (byte) 165, (byte) 109, (byte) 103, (byte) 104, (byte) 103, (byte) 14, (byte) 232, (byte) 69, (byte) 206, (byte) 110, (byte) 108, (byte) 177, (byte) 114, (byte) 112, (byte) 112, (byte) 117, (byte) 116, (byte) 104, (byte) 107, (byte) 100, (byte) 143, (byte) 106, (byte) 137, (byte) 106, (byte) 233, (byte) 55, (byte) 8, (byte) 235, (byte) 82, (byte) 173, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 227, (byte) 50, (byte) 131, (byte) 219, (byte) 2, (byte) 193, (byte) 131, (byte) 219, (byte) 2, (byte) 129, (byte) 194})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void executeQuery(Connection con, string query)
    {
      if (con == null)
      {
        string str = "There is no database to execute the query.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new SQLException(str);
      }
      else
      {
        ResultSet resultSet = (ResultSet) null;
        Statement statement = (Statement) null;
        ResultSetMetaData metaData;
        int columnCount;
        int num1;
        int[] numArray;
        int index1;
        // ISSUE: fault handler
        try
        {
          statement = con.createStatement();
          resultSet = statement.executeQuery(query);
          metaData = resultSet.getMetaData();
          columnCount = metaData.getColumnCount();
          num1 = 0;
          numArray = new int[columnCount];
          index1 = 0;
        }
        __fault
        {
          if (resultSet != null)
          {
            try
            {
              resultSet.close();
              goto label_9;
            }
            catch (Exception exception_12)
            {
              int temp_320 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_12, (ByteCodeHelper.MapFlags) temp_320) == null)
                throw;
            }
          }
label_9:
          if (statement != null)
          {
            try
            {
              statement.close();
              goto label_14;
            }
            catch (Exception exception_11)
            {
              int temp_316 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_11, (ByteCodeHelper.MapFlags) temp_316) == null)
                throw;
            }
          }
label_14:;
        }
        SQLException sqlException1;
        while (true)
        {
          // ISSUE: fault handler
          try
          {
            if (index1 < columnCount)
            {
              try
              {
                int columnType = metaData.getColumnType(index1 + 1);
                int num2 = columnType;
                int num3 = -7;
                if (num2 != num3)
                {
                  int num4 = -5;
                  if (num2 != num4)
                  {
                    int num5 = 2;
                    if (num2 != num5)
                    {
                      int num6 = 3;
                      if (num2 != num6)
                      {
                        int num7 = 4;
                        if (num2 != num7)
                        {
                          int num8 = 5;
                          if (num2 != num8)
                          {
                            int num9 = 6;
                            if (num2 != num9)
                            {
                              int num10 = 7;
                              if (num2 != num10)
                              {
                                int num11 = 8;
                                if (num2 != num11)
                                {
                                  int num12 = 91;
                                  if (num2 != num12)
                                  {
                                    int num13 = 92;
                                    if (num2 != num13)
                                    {
                                      int num14 = 93;
                                      if (num2 != num14)
                                      {
                                        Log.warn((object) new StringBuffer().append("Unable to load column ").append(index1).append(" (").append(columnType).append(",").append(metaData.getColumnClassName(index1 + 1)).append(")").toString());
                                        numArray[index1] = 0;
                                        goto label_55;
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
                ++num1;
                numArray[index1] = columnType;
              }
              catch (SQLException ex)
              {
                int num2 = 1;
                sqlException1 = (SQLException) ByteCodeHelper.MapException<SQLException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
                break;
              }
            }
            else
              goto label_67;
          }
          __fault
          {
            if (resultSet != null)
            {
              try
              {
                resultSet.close();
                goto label_36;
              }
              catch (Exception exception_10)
              {
                int temp_304 = 2;
                if (ByteCodeHelper.MapException<Exception>(exception_10, (ByteCodeHelper.MapFlags) temp_304) == null)
                  throw;
              }
            }
label_36:
            if (statement != null)
            {
              try
              {
                statement.close();
                goto label_41;
              }
              catch (Exception exception_9)
              {
                int temp_300 = 2;
                if (ByteCodeHelper.MapException<Exception>(exception_9, (ByteCodeHelper.MapFlags) temp_300) == null)
                  throw;
              }
            }
label_41:;
          }
label_55:
          // ISSUE: fault handler
          try
          {
            ++index1;
          }
          __fault
          {
            if (resultSet != null)
            {
              try
              {
                resultSet.close();
                goto label_61;
              }
              catch (Exception exception_5)
              {
                int temp_275 = 2;
                if (ByteCodeHelper.MapException<Exception>(exception_5, (ByteCodeHelper.MapFlags) temp_275) == null)
                  throw;
              }
            }
label_61:
            if (statement != null)
            {
              try
              {
                statement.close();
                goto label_66;
              }
              catch (Exception exception_4)
              {
                int temp_271 = 2;
                if (ByteCodeHelper.MapException<Exception>(exception_4, (ByteCodeHelper.MapFlags) temp_271) == null)
                  throw;
              }
            }
label_66:;
          }
        }
        SQLException sqlException2 = sqlException1;
        // ISSUE: fault handler
        try
        {
          SQLException sqlException3 = sqlException2;
          numArray[index1] = 0;
          throw Throwable.__\u003Cunmap\u003E((Exception) sqlException3);
        }
        __fault
        {
          if (resultSet != null)
          {
            try
            {
              resultSet.close();
              goto label_49;
            }
            catch (Exception exception_8)
            {
              int temp_294 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_8, (ByteCodeHelper.MapFlags) temp_294) == null)
                throw;
            }
          }
label_49:
          if (statement != null)
          {
            try
            {
              statement.close();
              goto label_54;
            }
            catch (Exception exception_7)
            {
              int temp_290 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_7, (ByteCodeHelper.MapFlags) temp_290) == null)
                throw;
            }
          }
label_54:;
        }
label_67:
        // ISSUE: fault handler
        try
        {
          if (num1 <= 1)
          {
            string str = "Not enough valid columns where generated by query.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new SQLException(str);
          }
          else
          {
            this.columnNames = new string[num1 - 1];
            int index2 = 0;
            for (int index3 = 1; index3 < columnCount; ++index3)
            {
              if (numArray[index3] != 0)
              {
                this.columnNames[index2] = metaData.getColumnLabel(index3 + 1);
                ++index2;
              }
            }
            if (this.rows != null)
            {
              for (int index3 = 0; index3 < this.rows.size(); ++index3)
                ((ArrayList) this.rows.get(index3)).clear();
              this.rows.clear();
            }
            switch (numArray[0])
            {
              case 91:
              case 92:
              case 93:
                this.isTimeSeries = true;
                break;
              default:
                this.isTimeSeries = false;
                break;
            }
            while (resultSet.next())
            {
              ArrayList arrayList1 = new ArrayList();
              for (int index3 = 0; index3 < columnCount; ++index3)
              {
                object @object = resultSet.getObject(index3 + 1);
                int num2 = numArray[index3];
                int num3 = -5;
                if (num2 != num3)
                {
                  int num4 = 0;
                  if (num2 != num4)
                  {
                    int num5 = 2;
                    if (num2 != num5)
                    {
                      int num6 = 3;
                      if (num2 != num6)
                      {
                        int num7 = 4;
                        if (num2 != num7)
                        {
                          int num8 = 5;
                          if (num2 != num8)
                          {
                            int num9 = 6;
                            if (num2 != num9)
                            {
                              int num10 = 7;
                              if (num2 != num10)
                              {
                                int num11 = 8;
                                if (num2 != num11)
                                {
                                  int num12 = 91;
                                  if (num2 != num12)
                                  {
                                    int num13 = 92;
                                    if (num2 != num13)
                                    {
                                      int num14 = 93;
                                      if (num2 != num14)
                                      {
                                        System.get_err().println("Unknown data");
                                        numArray[index3] = 0;
                                        continue;
                                      }
                                    }
                                  }
                                  ArrayList arrayList2 = arrayList1;
                                  Long.__\u003Cclinit\u003E();
                                  Long @long = new Long(((Date) @object).getTime());
                                  arrayList2.add((object) @long);
                                  continue;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                  else
                    continue;
                }
                arrayList1.add(@object);
              }
              this.rows.add((object) arrayList1);
            }
            if (this.rows.size() == 0)
            {
              ArrayList arrayList = new ArrayList();
              for (int index3 = 0; index3 < columnCount; ++index3)
              {
                if (numArray[index3] != 0)
                  arrayList.add((object) new Integer(0));
              }
              this.rows.add((object) arrayList);
            }
            if (this.rows.size() < 1)
            {
              this.maxValue = 0.0;
              this.minValue = 0.0;
            }
            else
            {
              ArrayList arrayList1 = (ArrayList) this.rows.get(0);
              this.maxValue = double.NegativeInfinity;
              this.minValue = double.PositiveInfinity;
              for (int index3 = 0; index3 < this.rows.size(); ++index3)
              {
                ArrayList arrayList2 = (ArrayList) this.rows.get(index3);
                for (int index4 = 1; index4 < columnCount; ++index4)
                {
                  object obj = arrayList2.get(index4);
                  if (obj != null)
                  {
                    double num2 = ((Number) obj).doubleValue();
                    if (num2 < this.minValue)
                      this.minValue = num2;
                    if (num2 > this.maxValue)
                      this.maxValue = num2;
                  }
                }
              }
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
              goto label_128;
            }
            catch (Exception exception_3)
            {
              int temp_81 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_3, (ByteCodeHelper.MapFlags) temp_81) == null)
                throw;
            }
          }
label_128:
          if (statement != null)
          {
            try
            {
              statement.close();
              goto label_133;
            }
            catch (Exception exception_2)
            {
              int temp_77 = 2;
              if (ByteCodeHelper.MapException<Exception>(exception_2, (ByteCodeHelper.MapFlags) temp_77) == null)
                throw;
            }
          }
label_133:;
        }
        if (resultSet != null)
        {
          try
          {
            resultSet.close();
            goto label_139;
          }
          catch (Exception ex)
          {
            int num2 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
              throw;
          }
        }
label_139:
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
    }

    [LineNumberTable((ushort) 462)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int seriesIndex)
    {
      return this.rows.size();
    }

    [LineNumberTable((ushort) 484)]
    public override int getSeriesCount()
    {
      return this.columnNames.Length;
    }

    public virtual bool isTimeSeries()
    {
      return this.isTimeSeries;
    }

    public virtual void setTimeSeries(bool timeSeries)
    {
      this.isTimeSeries = timeSeries;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 63, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int seriesIndex, int itemIndex)
    {
      return (Number) ((ArrayList) this.rows.get(itemIndex)).get(0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 78, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int seriesIndex, int itemIndex)
    {
      return (Number) ((ArrayList) this.rows.get(itemIndex)).get(seriesIndex + 1);
    }

    [LineNumberTable((ushort) 472)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.getItemCount(0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 148, (byte) 169})]
    public override IComparable getSeriesKey(int seriesIndex)
    {
      if (seriesIndex < this.columnNames.Length && this.columnNames[seriesIndex] != null)
        return (IComparable) this.columnNames[seriesIndex];
      else
        return (IComparable) "";
    }

    [Obsolete]
    [LineNumberTable((ushort) 519)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getLegendItemCount()
    {
      return this.getSeriesCount();
    }

    [Obsolete]
    public virtual string[] getLegendItemLabels()
    {
      return this.columnNames;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 171, (byte) 223, (byte) 1, (byte) 2, (byte) 97, (byte) 175})]
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

    public virtual double getRangeLowerBound(bool includeInterval)
    {
      return this.minValue;
    }

    public virtual double getRangeUpperBound(bool includeInterval)
    {
      return this.maxValue;
    }

    [LineNumberTable((ushort) 582)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getRangeBounds(bool includeInterval)
    {
      return new Range(this.minValue, this.maxValue);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JDBCXYDataset.__\u003CcallerID\u003E == null)
        JDBCXYDataset.__\u003CcallerID\u003E = (CallerID) new JDBCXYDataset.__\u003CCallerID\u003E();
      return JDBCXYDataset.__\u003CcallerID\u003E;
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
