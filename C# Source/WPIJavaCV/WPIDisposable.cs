// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIDisposable
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.wpijavacv
{
  public abstract class WPIDisposable : Object
  {
    private WPIMemoryPool pool;
    private bool disposed;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 153, (byte) 168, (byte) 167, (byte) 231, (byte) 160, (byte) 90})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIDisposable()
    {
      base.\u002Ector();
      WPIDisposable wpiDisposable = this;
      this.pool = (WPIMemoryPool) null;
      this.disposed = false;
      GC.KeepAlive((object) this);
    }

    [HideFromJava]
    ~WPIDisposable()
    {
      if (ByteCodeHelper.SkipFinalizer())
        return;
      try
      {
        this.finalize();
      }
      catch
      {
      }
    }

    protected internal abstract void disposed();

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 104, (byte) 103, (byte) 102, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void dispose()
    {
      if (this.disposed)
        return;
      this.disposed = true;
      this.disposed();
      if (this.pool == null)
        return;
      this.pool.removeFromPool(this);
    }

    protected internal virtual void setPool(WPIMemoryPool pool)
    {
      this.pool = pool;
    }

    protected internal virtual WPIMemoryPool getPool()
    {
      return this.pool;
    }

    public virtual bool isDisposed()
    {
      return this.disposed;
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateDisposed()
    {
      if (!this.disposed)
        return;
      string message = new StringBuilder().append((object) this).append(" has been disposed").toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new WPIDisposable.DisposedException(message);
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateDisposed(string message)
    {
      if (!this.disposed)
        return;
      string message1 = message;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new WPIDisposable.DisposedException(message1);
    }

    [LineNumberTable((ushort) 90)]
    protected internal static bool isNull(object pointer)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pointer, __typeref (WPIDisposable), "com.googlecode.javacpp.Pointer");
      if (pointer == null)
        return true;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Pointer");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 118, (byte) 145, (byte) 175})]
    protected internal static void free(object pointer)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(pointer, __typeref (WPIDisposable), "com.googlecode.javacpp.Pointer");
      if (pointer == null)
        return;
      throw new NoClassDefFoundError("com.googlecode.javacpp.Pointer");
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 66, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void finalize()
    {
      this.dispose();
      base.finalize();
    }

    [InnerClass]
    [SourceFile("WPIDisposable.java")]
    [Serializable]
    public class DisposedException : RuntimeException
    {
      [LineNumberTable(new byte[] {(byte) 60, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public DisposedException(string message)
      {
        base.\u002Ector(message);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected DisposedException([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }
    }
  }
}
