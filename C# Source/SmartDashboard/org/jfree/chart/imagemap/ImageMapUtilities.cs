// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.imagemap.ImageMapUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.entity;
using org.jfree.util;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.imagemap
{
  public class ImageMapUtilities : Object
  {
    [LineNumberTable((ushort) 65)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageMapUtilities()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 87, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeImageMap(PrintWriter writer, string name, ChartRenderingInfo info, ToolTipTagFragmentGenerator toolTipTagFragmentGenerator, URLTagFragmentGenerator urlTagFragmentGenerator)
    {
      writer.println(ImageMapUtilities.getImageMap(name, info, toolTipTagFragmentGenerator, urlTagFragmentGenerator));
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 102, (byte) 159, (byte) 38, (byte) 108, (byte) 103, (byte) 102, (byte) 103, (byte) 104, (byte) 105, (byte) 146, (byte) 171, (byte) 106, (byte) 105, (byte) 236, (byte) 55, (byte) 230, (byte) 78, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getImageMap(string name, ChartRenderingInfo info, ToolTipTagFragmentGenerator toolTipTagFragmentGenerator, URLTagFragmentGenerator urlTagFragmentGenerator)
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(new StringBuffer().append("<map id=\"").append(ImageMapUtilities.htmlEscape(name)).append("\" name=\"").append(ImageMapUtilities.htmlEscape(name)).append("\">").toString());
      stringBuffer.append(StringUtils.getLineSeparator());
      EntityCollection entityCollection = info.getEntityCollection();
      if (entityCollection != null)
      {
        int i = entityCollection.getEntityCount() - 1;
        while (i >= 0)
        {
          ChartEntity entity = entityCollection.getEntity(i);
          if (entity.getToolTipText() != null || entity.getURLText() != null)
          {
            string imageMapAreaTag = entity.getImageMapAreaTag(toolTipTagFragmentGenerator, urlTagFragmentGenerator);
            if (String.instancehelper_length(imageMapAreaTag) > 0)
            {
              stringBuffer.append(imageMapAreaTag);
              stringBuffer.append(StringUtils.getLineSeparator());
            }
          }
          i += -1;
        }
      }
      stringBuffer.append("</map>");
      return stringBuffer.toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 105, (byte) 104, (byte) 101, (byte) 142, (byte) 101, (byte) 142, (byte) 101, (byte) 174, (byte) 232, (byte) 52, (byte) 233, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string javascriptEscape(string input)
    {
      if (input == null)
      {
        string str = "Null 'input' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        StringBuffer stringBuffer = new StringBuffer();
        int num1 = String.instancehelper_length(input);
        for (int index = 0; index < num1; ++index)
        {
          int num2 = (int) String.instancehelper_charAt(input, index);
          switch (num2)
          {
            case 34:
              stringBuffer.append("\\\"");
              break;
            case 39:
              stringBuffer.append("\\'");
              break;
            case 92:
              stringBuffer.append("\\\\");
              break;
            default:
              stringBuffer.append((char) num2);
              break;
          }
        }
        return stringBuffer.toString();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 105, (byte) 104, (byte) 101, (byte) 145, (byte) 101, (byte) 145, (byte) 101, (byte) 142, (byte) 101, (byte) 142, (byte) 101, (byte) 142, (byte) 101, (byte) 174, (byte) 232, (byte) 43, (byte) 233, (byte) 88})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string htmlEscape(string input)
    {
      if (input == null)
      {
        string str = "Null 'input' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        StringBuffer stringBuffer = new StringBuffer();
        int num1 = String.instancehelper_length(input);
        for (int index = 0; index < num1; ++index)
        {
          int num2 = (int) String.instancehelper_charAt(input, index);
          switch (num2)
          {
            case 38:
              stringBuffer.append("&amp;");
              break;
            case 34:
              stringBuffer.append("&quot;");
              break;
            case 60:
              stringBuffer.append("&lt;");
              break;
            case 62:
              stringBuffer.append("&gt;");
              break;
            case 39:
              stringBuffer.append("&#39;");
              break;
            case 92:
              stringBuffer.append("&#092;");
              break;
            default:
              stringBuffer.append((char) num2);
              break;
          }
        }
        return stringBuffer.toString();
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 30, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeImageMap(PrintWriter writer, string name, ChartRenderingInfo info)
    {
      ImageMapUtilities.writeImageMap(writer, name, info, (ToolTipTagFragmentGenerator) new StandardToolTipTagFragmentGenerator(), (URLTagFragmentGenerator) new StandardURLTagFragmentGenerator());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 117, (byte) 98, (byte) 98, (byte) 99, (byte) 200, (byte) 166, (byte) 223, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void writeImageMap(PrintWriter writer, string name, ChartRenderingInfo info, bool useOverLibForToolTips)
    {
      object obj1 = (useOverLibForToolTips ? 1 : 0) == 0 ? (object) new StandardToolTipTagFragmentGenerator() : (object) new OverLIBToolTipTagFragmentGenerator();
      PrintWriter writer1 = writer;
      string name1 = name;
      ChartRenderingInfo info1 = info;
      object obj2 = obj1;
      URLTagFragmentGenerator fragmentGenerator1 = (URLTagFragmentGenerator) new StandardURLTagFragmentGenerator();
      ToolTipTagFragmentGenerator toolTipTagFragmentGenerator;
      if (obj2 != null)
      {
        ToolTipTagFragmentGenerator fragmentGenerator2 = obj2 as ToolTipTagFragmentGenerator;
        if (fragmentGenerator2 == null)
          throw new IncompatibleClassChangeError();
        toolTipTagFragmentGenerator = fragmentGenerator2;
      }
      else
        toolTipTagFragmentGenerator = (ToolTipTagFragmentGenerator) null;
      URLTagFragmentGenerator urlTagFragmentGenerator = fragmentGenerator1;
      ImageMapUtilities.writeImageMap(writer1, name1, info1, toolTipTagFragmentGenerator, urlTagFragmentGenerator);
    }

    [LineNumberTable((ushort) 151)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getImageMap(string name, ChartRenderingInfo info)
    {
      return ImageMapUtilities.getImageMap(name, info, (ToolTipTagFragmentGenerator) new StandardToolTipTagFragmentGenerator(), (URLTagFragmentGenerator) new StandardURLTagFragmentGenerator());
    }
  }
}
