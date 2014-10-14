// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.Pointer
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using com.googlecode.javacpp.annotation;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.@ref;
using java.nio;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp
{
  [Opaque(new object[] {(byte) 64, "Lcom/googlecode/javacpp/annotation/Opaque;"})]
  public class Pointer : Object
  {
    [Modifiers]
    [Signature("Ljava/lang/ref/ReferenceQueue<Lcom/googlecode/javacpp/Pointer;>;")]
    internal static ReferenceQueue referenceQueue = new ReferenceQueue();
    protected internal long address;
    protected internal int position;
    private Pointer.Deallocator deallocator;
    static IntPtr __\u003Cjniptr\u003EasDirectBuffer\u0028I\u0029Ljava\u002Fnio\u002FByteBuffer\u003B;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 128)]
    static Pointer()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 232, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pointer()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 104, (byte) 99, (byte) 104, (byte) 137, (byte) 108, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pointer(Pointer p)
    {
      base.\u002Ector();
      Pointer pointer = this;
      if (p == null)
      {
        this.address = 0L;
        this.position = 0;
      }
      else
      {
        this.address = p.address;
        this.position = p.position;
      }
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 135, (byte) 98, (byte) 115, (byte) 102, (byte) 168, (byte) 104, (byte) 137, (byte) 136, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Pointer deallocator(Pointer.Deallocator deallocator)
    {
      this.deallocator = deallocator;
      Pointer.DeallocatorReference deallocatorReference;
      while ((deallocatorReference = (Pointer.DeallocatorReference) Pointer.referenceQueue.poll()) != null)
      {
        deallocatorReference.clear();
        deallocatorReference.remove();
      }
      (!(deallocator is Pointer.DeallocatorReference) ? new Pointer.DeallocatorReference(this, deallocator) : (Pointer.DeallocatorReference) deallocator).add();
      return this;
    }

    public virtual bool isNull()
    {
      return this.address == 0L;
    }

    [Modifiers]
    private ByteBuffer asDirectBuffer([In] int obj0)
    {
      JNI.Frame frame = (JNI.Frame) null;
      if (Pointer.__\u003Cjniptr\u003EasDirectBuffer\u0028I\u0029Ljava\u002Fnio\u002FByteBuffer\u003B == IntPtr.Zero)
        Pointer.__\u003Cjniptr\u003EasDirectBuffer\u0028I\u0029Ljava\u002Fnio\u002FByteBuffer\u003B = JNI.Frame.GetFuncPtr(Pointer.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/Pointer", "asDirectBuffer", "(I)Ljava/nio/ByteBuffer;");
      // ISSUE: explicit reference operation
      IntPtr num1 = ((JNI.Frame) @frame).Enter(Pointer.__\u003CGetCallerID\u003E());
      try
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        JNI.Frame& local = @frame;
        IntPtr num2 = num1;
        // ISSUE: explicit reference operation
        IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
        int num4 = obj0;
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        IntPtr num5 = __calli((__FnPtr<IntPtr (IntPtr, IntPtr, int)>) Pointer.__\u003Cjniptr\u003EasDirectBuffer\u0028I\u0029Ljava\u002Fnio\u002FByteBuffer\u003B)((int) num2, num3, (IntPtr) num4);
        return (ByteBuffer) ((JNI.Frame) local).UnwrapLocalRef(num5);
      }
      catch (object ex)
      {
        Console.WriteLine((object) "*** exception in native code ***");
        Console.WriteLine(ex);
        throw;
      }
      finally
      {
        // ISSUE: explicit reference operation
        ((JNI.Frame) @frame).Leave();
      }
    }

    [LineNumberTable(new byte[] {(byte) 127, (byte) 104, (byte) 130, (byte) 130, (byte) 103, (byte) 104, (byte) 156, (byte) 131, (byte) 103, (byte) 105, (byte) 116, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ByteBuffer asByteBuffer(int capacity)
    {
      if (this.isNull())
        return (ByteBuffer) null;
      int num1 = 1;
      try
      {
        Class @class = Object.instancehelper_getClass((object) this);
        if (@class != ClassLiteral<Pointer>.Value)
        {
          num1 = Loader.@sizeof(@class);
          goto label_8;
        }
        else
          goto label_8;
      }
      catch (Exception ex)
      {
        int num2 = 2;
        if (ByteCodeHelper.MapException<NullPointerException>(ex, (ByteCodeHelper.MapFlags) num2) == null)
          throw;
      }
label_8:
      int num3 = this.position;
      this.position = num1 * num3;
      ByteBuffer byteBuffer = this.asDirectBuffer(num1 * capacity).order(ByteOrder.nativeOrder());
      this.position = num3;
      return byteBuffer;
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void init([In] long obj0, [In] long obj1)
    {
      this.address = obj0;
      this.deallocator((Pointer.Deallocator) new Pointer.ReferenceDeallocator(this, obj0, obj1));
    }

    public virtual void setNull()
    {
      this.address = 0L;
    }

    public virtual int position()
    {
      return this.position;
    }

    public virtual Pointer position(int position)
    {
      this.position = position;
      return this;
    }

    protected internal virtual Pointer.Deallocator deallocator()
    {
      return this.deallocator;
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void deallocate()
    {
      this.deallocator.deallocate();
      this.address = 0L;
    }

    [LineNumberTable((ushort) 195)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Buffer asBuffer(int capacity)
    {
      return (Buffer) this.asByteBuffer(capacity);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 107, (byte) 98, (byte) 104, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == null && this.isNull())
        return true;
      if (!(obj is Pointer))
        return false;
      Pointer pointer = (Pointer) obj;
      return this.address == pointer.address && this.position == pointer.position;
    }

    public virtual int hashCode()
    {
      return (int) this.address;
    }

    [LineNumberTable((ushort) 214)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append(Object.instancehelper_getClass((object) this).getName()).append("[address=0x").append(Long.toHexString(this.address)).append(",position=").append(this.position).append(",deallocator=").append((object) this.deallocator).append("]").toString();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Pointer.__\u003CcallerID\u003E == null)
        Pointer.__\u003CcallerID\u003E = (CallerID) new Pointer.__\u003CCallerID\u003E();
      return Pointer.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("Pointer.java")]
    public interface Deallocator
    {
      void deallocate();
    }

    [InnerClass]
    [Signature("Ljava/lang/ref/PhantomReference<Lcom/googlecode/javacpp/Pointer;>;")]
    [SourceFile("Pointer.java")]
    internal class DeallocatorReference : PhantomReference
    {
      internal static Pointer.DeallocatorReference head = (Pointer.DeallocatorReference) null;
      internal Pointer.DeallocatorReference prev;
      internal Pointer.DeallocatorReference next;
      internal Pointer.Deallocator deallocator;

      [LineNumberTable(new byte[] {(byte) 40, (byte) 238, (byte) 69, (byte) 238, (byte) 60, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal DeallocatorReference([In] Pointer obj0, [In] Pointer.Deallocator obj1)
      {
        base.\u002Ector((object) obj0, Pointer.referenceQueue);
        Pointer.DeallocatorReference deallocatorReference = this;
        this.prev = (Pointer.DeallocatorReference) null;
        this.next = (Pointer.DeallocatorReference) null;
        this.deallocator = obj1;
      }

      [LineNumberTable(new byte[] {(byte) 73, (byte) 102, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void clear()
      {
        ((Reference) this).clear();
        this.deallocator.deallocate();
      }

      [LineNumberTable(new byte[] {(byte) 58, (byte) 114, (byte) 129, (byte) 104, (byte) 141, (byte) 145, (byte) 104, (byte) 145, (byte) 114})]
      [MethodImpl(MethodImplOptions.Synchronized)]
      internal void remove()
      {
        if (this.prev == this && this.next == this)
          return;
        if (this.prev == null)
          Pointer.DeallocatorReference.head = this.next;
        else
          this.prev.next = this.next;
        if (this.next != null)
          this.next.prev = this.prev;
        Pointer.DeallocatorReference deallocatorReference1 = this;
        Pointer.DeallocatorReference deallocatorReference2 = this;
        this.next = this;
        this.prev = this;
      }

      [LineNumberTable(new byte[] {(byte) 49, (byte) 103, (byte) 136, (byte) 107, (byte) 146})]
      [MethodImpl(MethodImplOptions.Synchronized)]
      internal void add()
      {
        if (Pointer.DeallocatorReference.head == null)
        {
          Pointer.DeallocatorReference.head = this;
        }
        else
        {
          this.next = Pointer.DeallocatorReference.head;
          this.next.prev = Pointer.DeallocatorReference.head = this;
        }
      }
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacpp.Pointer$Deallocator"})]
    [SourceFile("Pointer.java")]
    [Modifiers]
    internal sealed class ReferenceDeallocator : Pointer.DeallocatorReference, Pointer.Deallocator
    {
      private long allocatedAddress;
      private long deallocatorAddress;
      static IntPtr __\u003Cjniptr\u003Edeallocate\u0028JJ\u0029V;
      [SpecialName]
      private static CallerID __\u003CcallerID\u003E;

      [LineNumberTable(new byte[] {(byte) 17, (byte) 106, (byte) 103, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ReferenceDeallocator([In] Pointer obj0, [In] long obj1, [In] long obj2)
        : base(obj0, (Pointer.Deallocator) null)
      {
        Pointer.ReferenceDeallocator referenceDeallocator = this;
        this.deallocator = (Pointer.Deallocator) this;
        this.allocatedAddress = obj1;
        this.deallocatorAddress = obj2;
      }

      [Modifiers]
      private void deallocate([In] long obj0, [In] long obj1)
      {
        JNI.Frame frame = (JNI.Frame) null;
        if (Pointer.ReferenceDeallocator.__\u003Cjniptr\u003Edeallocate\u0028JJ\u0029V == IntPtr.Zero)
          Pointer.ReferenceDeallocator.__\u003Cjniptr\u003Edeallocate\u0028JJ\u0029V = JNI.Frame.GetFuncPtr(Pointer.ReferenceDeallocator.__\u003CGetCallerID\u003E(), "com/googlecode/javacpp/Pointer$ReferenceDeallocator", "deallocate", "(JJ)V");
        // ISSUE: explicit reference operation
        IntPtr num1 = ((JNI.Frame) @frame).Enter(Pointer.ReferenceDeallocator.__\u003CGetCallerID\u003E());
        try
        {
          IntPtr num2 = num1;
          // ISSUE: explicit reference operation
          IntPtr num3 = ((JNI.Frame) @frame).MakeLocalRef((object) this);
          long num4 = obj0;
          long num5 = obj1;
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void (IntPtr, IntPtr, long, long)>) Pointer.ReferenceDeallocator.__\u003Cjniptr\u003Edeallocate\u0028JJ\u0029V)((long) num2, (long) num3, (IntPtr) num4, (IntPtr) num5);
        }
        catch (object ex)
        {
          Console.WriteLine((object) "*** exception in native code ***");
          Console.WriteLine(ex);
          throw;
        }
        finally
        {
          // ISSUE: explicit reference operation
          ((JNI.Frame) @frame).Leave();
        }
      }

      [LineNumberTable(new byte[] {(byte) 27, (byte) 180, (byte) 114, (byte) 147})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void deallocate()
      {
        if (this.allocatedAddress == 0L || this.deallocatorAddress == 0L)
          return;
        this.deallocate(this.allocatedAddress, this.deallocatorAddress);
        Pointer.ReferenceDeallocator referenceDeallocator = this;
        long num1 = 0L;
        long num2 = num1;
        this.deallocatorAddress = num1;
        this.allocatedAddress = num2;
      }

      [SpecialName]
      private static CallerID __\u003CGetCallerID\u003E()
      {
        if (Pointer.ReferenceDeallocator.__\u003CcallerID\u003E == null)
          Pointer.ReferenceDeallocator.__\u003CcallerID\u003E = (CallerID) new Pointer.ReferenceDeallocator.__\u003CCallerID\u003E();
        return Pointer.ReferenceDeallocator.__\u003CcallerID\u003E;
      }

      private sealed class __\u003CCallerID\u003E : CallerID
      {
        internal __\u003CCallerID\u003E()
        {
          base.\u002Ector();
        }
      }
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
