// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.TextAnchor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class TextAnchor : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static TextAnchor __\u003C\u003ETOP_LEFT = new TextAnchor("TextAnchor.TOP_LEFT");
    internal static TextAnchor __\u003C\u003ETOP_CENTER = new TextAnchor("TextAnchor.TOP_CENTER");
    internal static TextAnchor __\u003C\u003ETOP_RIGHT = new TextAnchor("TextAnchor.TOP_RIGHT");
    internal static TextAnchor __\u003C\u003EHALF_ASCENT_LEFT = new TextAnchor("TextAnchor.HALF_ASCENT_LEFT");
    internal static TextAnchor __\u003C\u003EHALF_ASCENT_CENTER = new TextAnchor("TextAnchor.HALF_ASCENT_CENTER");
    internal static TextAnchor __\u003C\u003EHALF_ASCENT_RIGHT = new TextAnchor("TextAnchor.HALF_ASCENT_RIGHT");
    internal static TextAnchor __\u003C\u003ECENTER_LEFT = new TextAnchor("TextAnchor.CENTER_LEFT");
    internal static TextAnchor __\u003C\u003ECENTER = new TextAnchor("TextAnchor.CENTER");
    internal static TextAnchor __\u003C\u003ECENTER_RIGHT = new TextAnchor("TextAnchor.CENTER_RIGHT");
    internal static TextAnchor __\u003C\u003EBASELINE_LEFT = new TextAnchor("TextAnchor.BASELINE_LEFT");
    internal static TextAnchor __\u003C\u003EBASELINE_CENTER = new TextAnchor("TextAnchor.BASELINE_CENTER");
    internal static TextAnchor __\u003C\u003EBASELINE_RIGHT = new TextAnchor("TextAnchor.BASELINE_RIGHT");
    internal static TextAnchor __\u003C\u003EBOTTOM_LEFT = new TextAnchor("TextAnchor.BOTTOM_LEFT");
    internal static TextAnchor __\u003C\u003EBOTTOM_CENTER = new TextAnchor("TextAnchor.BOTTOM_CENTER");
    internal static TextAnchor __\u003C\u003EBOTTOM_RIGHT = new TextAnchor("TextAnchor.BOTTOM_RIGHT");
    private const long serialVersionUID = 8219158940496719660L;
    private string name;

    [Modifiers]
    public static TextAnchor TOP_LEFT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003ETOP_LEFT;
      }
    }

    [Modifiers]
    public static TextAnchor TOP_CENTER
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003ETOP_CENTER;
      }
    }

    [Modifiers]
    public static TextAnchor TOP_RIGHT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003ETOP_RIGHT;
      }
    }

    [Modifiers]
    public static TextAnchor HALF_ASCENT_LEFT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT;
      }
    }

    [Modifiers]
    public static TextAnchor HALF_ASCENT_CENTER
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER;
      }
    }

    [Modifiers]
    public static TextAnchor HALF_ASCENT_RIGHT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT;
      }
    }

    [Modifiers]
    public static TextAnchor CENTER_LEFT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003ECENTER_LEFT;
      }
    }

    [Modifiers]
    public static TextAnchor CENTER
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003ECENTER;
      }
    }

    [Modifiers]
    public static TextAnchor CENTER_RIGHT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003ECENTER_RIGHT;
      }
    }

    [Modifiers]
    public static TextAnchor BASELINE_LEFT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EBASELINE_LEFT;
      }
    }

    [Modifiers]
    public static TextAnchor BASELINE_CENTER
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EBASELINE_CENTER;
      }
    }

    [Modifiers]
    public static TextAnchor BASELINE_RIGHT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EBASELINE_RIGHT;
      }
    }

    [Modifiers]
    public static TextAnchor BOTTOM_LEFT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EBOTTOM_LEFT;
      }
    }

    [Modifiers]
    public static TextAnchor BOTTOM_CENTER
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EBOTTOM_CENTER;
      }
    }

    [Modifiers]
    public static TextAnchor BOTTOM_RIGHT
    {
      [HideFromJava] get
      {
        return TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 175, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207})]
    static TextAnchor()
    {
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private TextAnchor([In] string obj0)
    {
      base.\u002Ector();
      TextAnchor textAnchor = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextAnchor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextAnchor obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 100, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is TextAnchor && String.instancehelper_equals(this.name, (object) ((TextAnchor) o).name);
    }

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable((ushort) 171)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.name);
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 98, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      TextAnchor textAnchor = (TextAnchor) null;
      if (this.equals((object) TextAnchor.__\u003C\u003ETOP_LEFT))
        textAnchor = TextAnchor.__\u003C\u003ETOP_LEFT;
      else if (this.equals((object) TextAnchor.__\u003C\u003ETOP_CENTER))
        textAnchor = TextAnchor.__\u003C\u003ETOP_CENTER;
      else if (this.equals((object) TextAnchor.__\u003C\u003ETOP_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003ETOP_RIGHT;
      else if (this.equals((object) TextAnchor.__\u003C\u003EBOTTOM_LEFT))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_LEFT;
      else if (this.equals((object) TextAnchor.__\u003C\u003EBOTTOM_CENTER))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_CENTER;
      else if (this.equals((object) TextAnchor.__\u003C\u003EBOTTOM_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003EBOTTOM_RIGHT;
      else if (this.equals((object) TextAnchor.__\u003C\u003EBASELINE_LEFT))
        textAnchor = TextAnchor.__\u003C\u003EBASELINE_LEFT;
      else if (this.equals((object) TextAnchor.__\u003C\u003EBASELINE_CENTER))
        textAnchor = TextAnchor.__\u003C\u003EBASELINE_CENTER;
      else if (this.equals((object) TextAnchor.__\u003C\u003EBASELINE_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003EBASELINE_RIGHT;
      else if (this.equals((object) TextAnchor.__\u003C\u003ECENTER_LEFT))
        textAnchor = TextAnchor.__\u003C\u003ECENTER_LEFT;
      else if (this.equals((object) TextAnchor.__\u003C\u003ECENTER))
        textAnchor = TextAnchor.__\u003C\u003ECENTER;
      else if (this.equals((object) TextAnchor.__\u003C\u003ECENTER_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003ECENTER_RIGHT;
      else if (this.equals((object) TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_LEFT;
      else if (this.equals((object) TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_CENTER;
      else if (this.equals((object) TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT))
        textAnchor = TextAnchor.__\u003C\u003EHALF_ASCENT_RIGHT;
      return (object) textAnchor;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    object IObjectReference.IObjectReference\u002EGetRealObject([In] StreamingContext obj0)
    {
      return this.readResolve();
    }
  }
}
