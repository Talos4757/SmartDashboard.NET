// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.xml.SmartDashboardXMLWriter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.xml
{
  public class SmartDashboardXMLWriter : Object
  {
    internal string fileName;
    internal FileWriter writer;

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 104, (byte) 103, (byte) 108, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SmartDashboardXMLWriter(string fileName)
    {
      base.\u002Ector();
      SmartDashboardXMLWriter dashboardXmlWriter = this;
      this.fileName = fileName;
      this.writer = new FileWriter(fileName);
      ((Writer) this.writer).write("<xml version=\"1.0\">\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void beginSmartDashboard()
    {
      ((Writer) this.writer).write("<dashboard>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endSmartDashboard()
    {
      ((Writer) this.writer).write("</dashboard>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void beginLiveWindow()
    {
      ((Writer) this.writer).write("<live-window>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endLiveWindow()
    {
      ((Writer) this.writer).write("</live-window>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 5, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addHiddenField(string field)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t<hidden field=\"").append(field).append("\"/>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 46, (byte) 112, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      ((Writer) this.writer).write("</xml>");
      ((OutputStreamWriter) this.writer).close();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 127, (byte) 50})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void beginWidget(string field, string type, string className)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t<widget field=\"").append(field).append("\" type=\"").append(type).append("\" class=\"").append(className).append("\">\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void beginStaticWidget(string className)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t<static-widget class=\"").append(className).append("\">\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 13, (byte) 127, (byte) 50})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubWidget(string field, string type, string className)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t<widget field=\"").append(field).append("\" type=\"").append(type).append("\" class=\"").append(className).append("\">\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 21, (byte) 127, (byte) 44})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubWidgetLocation(Point p)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t\t<location x=\"").append((int) p.x).append("\" y=\"").append((int) p.y).append("\"/>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 25, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubWudgetHeight(int height)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t\t<height>").append(height).append("</height>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 29, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubWidgetWidth(int width)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t\t<width>").append(width).append("</width>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 17, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endSubWidget()
    {
      ((Writer) this.writer).write("\t\t</widget>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 9, (byte) 127, (byte) 44})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addLocation(Point p)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t<location x=\"").append((int) p.x).append("\" y=\"").append((int) p.y).append("\"/>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 33, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addWidth(int width)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t<width>").append(width).append("</width>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 37, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addHeight(int height)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t<height>").append(height).append("</height>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 41, (byte) 159, (byte) 34})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addProperty(string name, string value)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t\t<property name=\"").append(name).append("\" value=\"").append(value).append("\"/>\n").toString());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 1, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endWidget()
    {
      ((Writer) this.writer).write("\t</widget>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void endStaticWidget()
    {
      ((Writer) this.writer).write("\t</static-widget>\n");
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 127, (byte) 34})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void beginWidget(string field, string className)
    {
      ((Writer) this.writer).write(new StringBuilder().append("\t<widget field=\"").append(field).append("\" class=\"").append(className).append("\">\n").toString());
    }
  }
}
