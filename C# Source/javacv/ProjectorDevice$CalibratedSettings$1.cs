// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectorDevice$CalibratedSettings$1
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [InnerClass]
  [EnclosingMethod("com.googlecode.javacv.ProjectorDevice$CalibratedSettings", null, null)]
  [SourceFile("ProjectorDevice.java")]
  [Modifiers]
  [Serializable]
  internal sealed class ProjectorDevice\u0024CalibratedSettings\u00241 : ProjectorDevice.SettingsImplementation
  {
    [Modifiers]
    internal ProjectorDevice.CalibratedSettings this\u00240 = obj0;

    [LineNumberTable((ushort) 227)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ProjectorDevice\u0024CalibratedSettings\u00241([In] ProjectorDevice.CalibratedSettings obj0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ProjectorDevice\u0024CalibratedSettings\u00241([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void firePropertyChange([In] string obj0, [In] object obj1, [In] object obj2)
    {
      this.this\u00240.firePropertyChange(obj0, obj1, obj2);
    }
  }
}
