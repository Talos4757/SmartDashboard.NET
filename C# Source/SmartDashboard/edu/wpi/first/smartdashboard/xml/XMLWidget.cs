// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.xml.XMLWidget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using java.util;
using java.util.logging;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.xml
{
  public class XMLWidget : Object
  {
    internal Point location;
    internal Dimension size;
    [Signature("Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/String;>;")]
    internal HashMap properties;
    internal string field;
    internal string className;
    internal DataType type;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 163, (byte) 232, (byte) 57, (byte) 103, (byte) 103, (byte) 139, (byte) 203})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XMLWidget()
    {
      base.\u002Ector();
      XMLWidget xmlWidget = this;
      this.location = (Point) null;
      this.size = (Dimension) null;
      this.properties = new HashMap();
      this.className = "";
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 130, (byte) 127, (byte) 1, (byte) 104, (byte) 145, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 127, (byte) 6, (byte) 114, (byte) 99, (byte) 151, (byte) 185, (byte) 2, (byte) 98, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DisplayElement convertToDisplayElement()
    {
      DisplayElement displayElement = (DisplayElement) null;
      Exception exception1;
      try
      {
        displayElement = (DisplayElement) Class.forName(this.className, XMLWidget.__\u003CGetCallerID\u003E()).newInstance(XMLWidget.__\u003CGetCallerID\u003E());
        if (this.field != null)
          ((Widget) displayElement).setFieldName(this.field);
        if (this.size != null)
          displayElement.setSavedSize(this.size);
        if (this.location != null)
          displayElement.setSavedLocation(this.location);
        Iterator iterator = this.properties.keySet().iterator();
        while (iterator.hasNext())
        {
          string str = (string) iterator.next();
          Property property = (Property) displayElement.getProperties().get((object) str);
          if (property != null)
            property.setSaveValue((string) this.properties.get((object) str));
        }
        goto label_15;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception1 = (Exception) m0;
      }
      Exception exception2 = exception1;
      Logger.getLogger(((Class) ClassLiteral<XMLWidget>.Value).getName()).log((Level) Level.SEVERE, (string) null, (Exception) exception2);
label_15:
      return displayElement;
    }

    public virtual DataType getType()
    {
      return this.type;
    }

    public virtual Point getLocation()
    {
      return this.location;
    }

    public virtual string getField()
    {
      return this.field;
    }

    public virtual void setField(string f)
    {
      this.field = f;
    }

    public virtual void setClass(string c)
    {
      this.className = c;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setType(string type)
    {
      this.type = DataType.getType(type, false);
    }

    public virtual void setLocation(Point p)
    {
      this.location = p;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 104, (byte) 142, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setWidth(int width)
    {
      if (this.size != null)
        this.size.width = (__Null) width;
      else
        this.size = new Dimension(width, -1);
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 104, (byte) 142, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setHeight(int height)
    {
      if (this.size != null)
        this.size.height = (__Null) height;
      else
        this.size = new Dimension(-1, height);
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addProperty(string name, string value)
    {
      this.properties.put((object) name, (object) value);
    }

    public virtual Dimension getSize()
    {
      return this.size;
    }

    public virtual string getElementClass()
    {
      return this.className;
    }

    public virtual void setSize(Dimension d)
    {
      this.size = d;
    }

    public virtual bool hasLocation()
    {
      return this.location != null;
    }

    public virtual bool hasSize()
    {
      return this.size != null;
    }

    [Signature("()Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
    public virtual Map getProperties()
    {
      return (Map) this.properties;
    }

    [LineNumberTable((ushort) 134)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return this.getField();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (XMLWidget.__\u003CcallerID\u003E == null)
        XMLWidget.__\u003CcallerID\u003E = (CallerID) new XMLWidget.__\u003CCallerID\u003E();
      return XMLWidget.__\u003CcallerID\u003E;
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
