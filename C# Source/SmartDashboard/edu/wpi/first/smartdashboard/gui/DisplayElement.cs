// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DisplayElement
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.properties;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using java.lang.reflect;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Implements(new string[] {"edu.wpi.first.smartdashboard.properties.PropertyHolder"})]
  [Serializable]
  public abstract class DisplayElement : JPanel, PropertyHolder
  {
    private Point savedLocation;
    private Dimension savedDimension;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/properties/Property;>;")]
    private Map properties;
    private bool resizable;
    private bool obstruction;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [HideFromJava]
    static DisplayElement()
    {
      JPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 232, (byte) 50, (byte) 141, (byte) 141, (byte) 139, (byte) 135, (byte) 231, (byte) 71, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DisplayElement()
    {
      base.\u002Ector();
      DisplayElement displayElement = this;
      this.savedLocation = new Point(0, 0);
      this.savedDimension = new Dimension(-1, -1);
      this.properties = (Map) new LinkedHashMap();
      this.resizable = true;
      this.obstruction = true;
      ((JComponent) this).setOpaque(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DisplayElement([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 103)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Dimension getSavedSize()
    {
      Dimension.__\u003Cclinit\u003E();
      return new Dimension(this.savedDimension);
    }

    [Signature("()Ljava/util/Map<Ljava/lang/String;Ledu/wpi/first/smartdashboard/properties/Property;>;")]
    public virtual Map getProperties()
    {
      return this.properties;
    }

    [LineNumberTable((ushort) 95)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Point getSavedLocation()
    {
      return new Point(this.savedLocation);
    }

    [Signature("(Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/DisplayElement;>;)Ljava/lang/String;")]
    [LineNumberTable(new byte[] {(byte) 101, (byte) 113, (byte) 103, (byte) 104, (byte) 112, (byte) 104, (byte) 144, (byte) 112, (byte) 191, (byte) 15, (byte) 34, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getName(Class clazz)
    {
      string str1;
      try
      {
        Field declaredField = clazz.getDeclaredField("NAME", DisplayElement.__\u003CGetCallerID\u003E());
        int modifiers = declaredField.getModifiers();
        if (!Modifier.isStatic(modifiers))
        {
          string str2 = "TYPES must be static";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str2);
        }
        else if (!Modifier.isFinal(modifiers))
        {
          string str2 = "TYPES must be final";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str2);
        }
        else if (Modifier.isStatic(modifiers))
        {
          if (Modifier.isFinal(modifiers))
            str1 = (string) declaredField.get((object) null, DisplayElement.__\u003CGetCallerID\u003E());
          else
            goto label_11;
        }
        else
          goto label_11;
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_10;
      }
      return str1;
label_10:
label_11:
      return clazz.getSimpleName();
    }

    public abstract void init();

    public virtual void setSavedLocation(Point p)
    {
      this.savedLocation = p;
    }

    public virtual bool isObstruction()
    {
      return this.obstruction;
    }

    public virtual void disconnect()
    {
    }

    [HideFromReflection]
    public abstract void propertyChanged([In] Property obj0);

    public virtual bool validatePropertyChange(Property property, object value)
    {
      return true;
    }

    public virtual void setObstruction(bool obstruction)
    {
      this.obstruction = obstruction;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSavedSize(Dimension d)
    {
      this.savedDimension = new Dimension(d);
    }

    public virtual bool isResizable()
    {
      return this.resizable;
    }

    public virtual void setResizable(bool resizable)
    {
      this.resizable = resizable;
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 104, (byte) 105, (byte) 104, (byte) 104, (byte) 137, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void update(Property property, object defaultValue)
    {
      if (property.hasDefault())
        this.propertyChanged(property);
      else if (property.hasValue())
      {
        property.setDefault(defaultValue);
        this.propertyChanged(property);
      }
      else
        property.setDefault(defaultValue);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (DisplayElement.__\u003CcallerID\u003E == null)
        DisplayElement.__\u003CcallerID\u003E = (CallerID) new DisplayElement.__\u003CCallerID\u003E();
      return DisplayElement.__\u003CcallerID\u003E;
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
