// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CanvasFrame$1$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [InnerClass]
  [EnclosingMethod("com.googlecode.javacv.CanvasFrame$1", "run", "()V")]
  [SourceFile("CanvasFrame.java")]
  [Modifiers]
  [Serializable]
  internal sealed class CanvasFrame\u00241\u00241 : Canvas
  {
    [Modifiers]
    internal CanvasFrame\u00241 this\u00241;

    [HideFromJava]
    static CanvasFrame\u00241\u00241()
    {
      Canvas.__\u003Cclinit\u003E();
    }

    [LineNumberTable((ushort) 163)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal CanvasFrame\u00241\u00241([In] CanvasFrame\u00241 obj0)
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CanvasFrame\u00241\u00241([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 159, (byte) 16, (byte) 34, (byte) 97, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void paint([In] Graphics obj0)
    {
      try
      {
        try
        {
          CanvasFrame.access\u0024200(this.this\u00241.this\u00240).show();
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<NullPointerException>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
      }
      catch (IllegalStateException ex)
      {
        goto label_5;
      }
      return;
label_5:;
    }
  }
}
