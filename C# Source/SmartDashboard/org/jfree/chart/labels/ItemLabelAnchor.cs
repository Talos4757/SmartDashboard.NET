// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.ItemLabelAnchor
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

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public sealed class ItemLabelAnchor : Object, Serializable.__Interface, ISerializable, IObjectReference
  {
    internal static ItemLabelAnchor __\u003C\u003ECENTER = new ItemLabelAnchor("ItemLabelAnchor.CENTER");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE1 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE1");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE2 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE2");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE3 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE3");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE4 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE4");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE5 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE5");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE6 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE6");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE7 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE7");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE8 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE8");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE9 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE9");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE10 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE10");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE11 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE11");
    internal static ItemLabelAnchor __\u003C\u003EINSIDE12 = new ItemLabelAnchor("ItemLabelAnchor.INSIDE12");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE1 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE1");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE2 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE2");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE3 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE3");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE4 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE4");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE5 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE5");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE6 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE6");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE7 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE7");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE8 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE8");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE9 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE9");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE10 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE10");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE11 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE11");
    internal static ItemLabelAnchor __\u003C\u003EOUTSIDE12 = new ItemLabelAnchor("ItemLabelAnchor.OUTSIDE12");
    private const long serialVersionUID = -1233101616128695658L;
    private string name;

    [Modifiers]
    public static ItemLabelAnchor CENTER
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003ECENTER;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE1
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE1;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE2
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE2;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE3
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE3;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE4
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE4;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE5
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE5;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE6
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE6;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE7
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE7;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE8
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE8;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE9
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE9;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE10
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE10;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE11
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE11;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor INSIDE12
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EINSIDE12;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE1
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE1;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE2
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE2;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE3
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE3;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE4
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE4;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE5
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE5;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE6
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE6;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE7
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE7;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE8
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE8;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE9
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE9;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE10
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE10;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE11
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE11;
      }
    }

    [Modifiers]
    public static ItemLabelAnchor OUTSIDE12
    {
      [HideFromJava] get
      {
        return ItemLabelAnchor.__\u003C\u003EOUTSIDE12;
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207, (byte) 207})]
    static ItemLabelAnchor()
    {
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ItemLabelAnchor([In] string obj0)
    {
      base.\u002Ector();
      ItemLabelAnchor itemLabelAnchor = this;
      this.name = obj0;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ItemLabelAnchor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ItemLabelAnchor obj0)
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

    public virtual string toString()
    {
      return this.name;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is ItemLabelAnchor && String.instancehelper_equals(this.name, (object) ((ItemLabelAnchor) o).toString());
    }

    [Throws(new string[] {"java.io.ObjectStreamException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 98, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object readResolve()
    {
      ItemLabelAnchor itemLabelAnchor = (ItemLabelAnchor) null;
      if (this.equals((object) ItemLabelAnchor.__\u003C\u003ECENTER))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003ECENTER;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE1))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE1;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE2))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE2;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE3))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE3;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE4))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE4;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE5))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE5;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE6))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE6;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE7))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE7;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE8))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE8;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE9))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE9;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE10))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE10;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE11))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE11;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EINSIDE12))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EINSIDE12;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE1))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE1;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE2))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE2;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE3))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE3;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE4))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE4;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE5))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE5;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE6))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE6;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE7))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE7;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE8))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE8;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE9))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE9;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE10))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE10;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE11))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE11;
      else if (this.equals((object) ItemLabelAnchor.__\u003C\u003EOUTSIDE12))
        itemLabelAnchor = ItemLabelAnchor.__\u003C\u003EOUTSIDE12;
      return (object) itemLabelAnchor;
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
