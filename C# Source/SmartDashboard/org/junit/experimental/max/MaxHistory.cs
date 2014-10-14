// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.max.MaxHistory
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using org.junit.runner;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.junit.experimental.max
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class MaxHistory : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 1L;
    [Modifiers]
    [Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/Long;>;")]
    private Map fDurations;
    [Modifiers]
    [Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/Long;>;")]
    private Map fFailureTimestamps;
    [Modifiers]
    private File fHistoryStore;

    [LineNumberTable(new byte[] {(byte) 19, (byte) 232, (byte) 58, (byte) 139, (byte) 235, (byte) 69, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private MaxHistory([In] File obj0)
    {
      base.\u002Ector();
      MaxHistory maxHistory = this;
      this.fDurations = (Map) new HashMap();
      this.fFailureTimestamps = (Map) new HashMap();
      this.fHistoryStore = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MaxHistory([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MaxHistory obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 136, (byte) 124, (byte) 97, (byte) 102, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MaxHistory forFolder(File file)
    {
      if (file.exists())
      {
        MaxHistory maxHistory;
        CouldNotReadCoreException readCoreException;
        try
        {
          maxHistory = MaxHistory.readHistory(file);
        }
        catch (CouldNotReadCoreException ex)
        {
          int num = 1;
          readCoreException = (CouldNotReadCoreException) ByteCodeHelper.MapException<CouldNotReadCoreException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_4;
        }
        return maxHistory;
label_4:
        Throwable.instancehelper_printStackTrace((Exception) readCoreException);
        file.delete();
      }
      return new MaxHistory(file);
    }

    [LineNumberTable((ushort) 156)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RunListener listener()
    {
      return (RunListener) new MaxHistory.RememberingListener(this, (MaxHistory.\u0031) null);
    }

    [Signature("()Ljava/util/Comparator<Lorg/junit/runner/Description;>;")]
    [LineNumberTable((ushort) 164)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Comparator testComparator()
    {
      return (Comparator) new MaxHistory.TestComparator(this, (MaxHistory.\u0031) null);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 24, (byte) 155, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void save()
    {
      ObjectOutputStream.__\u003Cclinit\u003E();
      FileOutputStream.__\u003Cclinit\u003E();
      ObjectOutputStream objectOutputStream = new ObjectOutputStream((OutputStream) new FileOutputStream(this.fHistoryStore));
      objectOutputStream.writeObject((object) this);
      objectOutputStream.close();
    }

    [Throws(new string[] {"org.junit.experimental.max.CouldNotReadCoreException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 135, (byte) 135, (byte) 155, (byte) 182, (byte) 255, (byte) 20, (byte) 61, (byte) 191, (byte) 18, (byte) 159, (byte) 4, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static MaxHistory readHistory([In] File obj0)
    {
      FileInputStream fileInputStream;
      ObjectInputStream objectInputStream;
      MaxHistory maxHistory;
      Exception exception1;
      Exception exception2;
      Exception exception3;
      try
      {
        fileInputStream = new FileInputStream(obj0);
        try
        {
          objectInputStream = new ObjectInputStream((InputStream) fileInputStream);
          try
          {
            maxHistory = (MaxHistory) objectInputStream.readObject();
          }
          catch (Exception ex)
          {
            int num = 0;
            exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
            goto label_10;
          }
          objectInputStream.close();
        }
        catch (Exception ex)
        {
          int num = 0;
          exception2 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          goto label_11;
        }
        fileInputStream.close();
        goto label_13;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception3 = (Exception) m0;
          goto label_12;
        }
      }
label_10:
      Exception exception4 = exception1;
      Exception exception5;
      Exception exception6;
      try
      {
        Exception exception7 = exception4;
        try
        {
          Exception exception8 = exception7;
          objectInputStream.close();
          throw Throwable.__\u003Cunmap\u003E(exception8);
        }
        catch (Exception ex)
        {
          int num = 0;
          exception5 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception6 = (Exception) m0;
          goto label_21;
        }
      }
      Exception exception9 = exception5;
      goto label_22;
label_21:
      Exception exception10 = exception6;
      goto label_28;
label_11:
      exception9 = exception2;
      goto label_22;
label_12:
      exception10 = exception3;
      goto label_28;
label_13:
      return maxHistory;
label_22:
      Exception exception11 = exception9;
      Exception exception12;
      try
      {
        fileInputStream.close();
        throw Throwable.__\u003Cunmap\u003E(exception11);
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception12 = (Exception) m0;
      }
      exception10 = exception12;
label_28:
      Exception exception13 = exception10;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new CouldNotReadCoreException((Exception) exception13);
    }

    [LineNumberTable((ushort) 81)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual Long getFailureTimestamp([In] Description obj0)
    {
      return (Long) this.fFailureTimestamps.get((object) obj0.toString());
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void putTestFailureTimestamp([In] Description obj0, [In] long obj1)
    {
      this.fFailureTimestamps.put((object) obj0.toString(), (object) Long.valueOf(obj1));
    }

    [LineNumberTable((ushort) 89)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual bool isNewTest([In] Description obj0)
    {
      return !this.fDurations.containsKey((object) obj0.toString());
    }

    [LineNumberTable((ushort) 93)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual Long getTestDuration([In] Description obj0)
    {
      return (Long) this.fDurations.get((object) obj0.toString());
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void putTestDuration([In] Description obj0, [In] long obj1)
    {
      this.fDurations.put((object) obj0.toString(), (object) Long.valueOf(obj1));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [Modifiers]
    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u0024000([In] MaxHistory obj0)
    {
      obj0.save();
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [InnerClass]
    [EnclosingMethod("org.junit.experimental.max.MaxHistory", null, null)]
    [SourceFile("MaxHistory.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [SourceFile("MaxHistory.java")]
    internal sealed class RememberingListener : RunListener
    {
      [Modifiers]
      internal MaxHistory this\u00240 = obj0;
      private long overallStart;
      [Signature("Ljava/util/Map<Lorg/junit/runner/Description;Ljava/lang/Long;>;")]
      private Map starts;

      [Modifiers]
      [LineNumberTable((ushort) 100)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal RememberingListener([In] MaxHistory obj0, [In] MaxHistory.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable(new byte[] {(byte) 50, (byte) 111, (byte) 139})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private RememberingListener([In] MaxHistory obj0)
      {
        MaxHistory.RememberingListener rememberingListener = this;
        this.overallStart = System.currentTimeMillis();
        this.starts = (Map) new HashMap();
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 57, (byte) 151})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testStarted([In] Description obj0)
      {
        this.starts.put((object) obj0, (object) Long.valueOf(System.nanoTime()));
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 63, (byte) 102, (byte) 119, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testFinished([In] Description obj0)
      {
        long num1 = System.nanoTime();
        long num2 = ((Long) this.starts.get((object) obj0)).longValue();
        this.this\u00240.putTestDuration(obj0, num1 - num2);
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 70, (byte) 121})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testFailure([In] Failure obj0)
      {
        this.this\u00240.putTestFailureTimestamp(obj0.getDescription(), this.overallStart);
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 75, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void testRunFinished([In] Result obj0)
      {
        MaxHistory.access\u0024000(this.this\u00240);
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.util.Comparator"})]
    [Signature("Ljava/lang/Object;Ljava/util/Comparator<Lorg/junit/runner/Description;>;")]
    [SourceFile("MaxHistory.java")]
    [Modifiers]
    internal sealed class TestComparator : Object, Comparator
    {
      [Modifiers]
      internal MaxHistory this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 129)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal TestComparator([In] MaxHistory obj0, [In] MaxHistory.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 129)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private TestComparator([In] MaxHistory obj0)
      {
        base.\u002Ector();
      }

      [LineNumberTable(new byte[] {(byte) 94, (byte) 109, (byte) 99, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private Long getFailure([In] Description obj0)
      {
        Long failureTimestamp = this.this\u00240.getFailureTimestamp(obj0);
        if (failureTimestamp != null)
          return failureTimestamp;
        return Long.valueOf(0L);
      }

      [LineNumberTable(new byte[] {(byte) 82, (byte) 110, (byte) 98, (byte) 110, (byte) 130, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int compare([In] Description obj0, [In] Description obj1)
      {
        if (this.this\u00240.isNewTest(obj0))
          return -1;
        if (this.this\u00240.isNewTest(obj1))
          return 1;
        int num = this.getFailure(obj1).compareTo(this.getFailure(obj0));
        return num == 0 ? this.this\u00240.getTestDuration(obj0).compareTo(this.this\u00240.getTestDuration(obj1)) : num;
      }

      [Modifiers]
      [LineNumberTable((ushort) 129)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int compare([In] object obj0, [In] object obj1)
      {
        return this.compare((Description) obj0, (Description) obj1);
      }

      [HideFromJava]
      bool Comparator.java\u002Eutil\u002EComparator\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029Zequals([In] object obj0)
      {
        return Object.instancehelper_equals((object) this, obj0);
      }
    }
  }
}
