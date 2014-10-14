// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.GreyPalette
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Obsolete]
  [Serializable]
  public class GreyPalette : ColorPalette, Serializable.__Interface
  {
    private const long serialVersionUID = -2120941170159987395L;

    [HideFromJava]
    static GreyPalette()
    {
      ColorPalette.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GreyPalette()
    {
      GreyPalette greyPalette = this;
      this.initialize();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GreyPalette([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GreyPalette obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 139, (byte) 112, (byte) 112, (byte) 144, (byte) 109, (byte) 109, (byte) 109, (byte) 105, (byte) 105, (byte) 137, (byte) 106, (byte) 105, (byte) 105, (byte) 233, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void initialize()
    {
      this.setPaletteName("Grey");
      this.r = new int[256];
      this.g = new int[256];
      this.b = new int[256];
      this.r[0] = (int) byte.MaxValue;
      this.g[0] = (int) byte.MaxValue;
      this.b[0] = (int) byte.MaxValue;
      this.r[1] = 0;
      this.g[1] = 0;
      this.b[1] = 0;
      for (int index = 2; index < 256; ++index)
      {
        this.r[index] = index;
        this.g[index] = index;
        this.b[index] = index;
      }
    }
  }
}
