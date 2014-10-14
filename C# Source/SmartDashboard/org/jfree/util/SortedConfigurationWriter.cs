// Decompiled with JetBrains decompiler
// Type: org.jfree.util.SortedConfigurationWriter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.util
{
  public class SortedConfigurationWriter : Object
  {
    [Modifiers]
    private static string END_OF_LINE = StringUtils.getLineSeparator();
    private const int ESCAPE_KEY = 0;
    private const int ESCAPE_VALUE = 1;
    private const int ESCAPE_COMMENT = 2;
    [Modifiers]
    private static char[] HEX_CHARS;

    [LineNumberTable(new byte[] {(byte) 30, (byte) 234, (byte) 160, (byte) 214})]
    static SortedConfigurationWriter()
    {
      char[] chArray = new char[16];
      int index1 = 0;
      int num1 = 48;
      chArray[index1] = (char) num1;
      int index2 = 1;
      int num2 = 49;
      chArray[index2] = (char) num2;
      int index3 = 2;
      int num3 = 50;
      chArray[index3] = (char) num3;
      int index4 = 3;
      int num4 = 51;
      chArray[index4] = (char) num4;
      int index5 = 4;
      int num5 = 52;
      chArray[index5] = (char) num5;
      int index6 = 5;
      int num6 = 53;
      chArray[index6] = (char) num6;
      int index7 = 6;
      int num7 = 54;
      chArray[index7] = (char) num7;
      int index8 = 7;
      int num8 = 55;
      chArray[index8] = (char) num8;
      int index9 = 8;
      int num9 = 56;
      chArray[index9] = (char) num9;
      int index10 = 9;
      int num10 = 57;
      chArray[index10] = (char) num10;
      int index11 = 10;
      int num11 = 97;
      chArray[index11] = (char) num11;
      int index12 = 11;
      int num12 = 98;
      chArray[index12] = (char) num12;
      int index13 = 12;
      int num13 = 99;
      chArray[index13] = (char) num13;
      int index14 = 13;
      int num14 = 100;
      chArray[index14] = (char) num14;
      int index15 = 14;
      int num15 = 101;
      chArray[index15] = (char) num15;
      int index16 = 15;
      int num16 = 102;
      chArray[index16] = (char) num16;
      SortedConfigurationWriter.HEX_CHARS = chArray;
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SortedConfigurationWriter()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 74, (byte) 140, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void save(File file, Configuration config)
    {
      BufferedOutputStream bufferedOutputStream = new BufferedOutputStream((OutputStream) new FileOutputStream(file));
      this.save((OutputStream) bufferedOutputStream, config);
      ((FilterOutputStream) bufferedOutputStream).close();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 90, (byte) 166, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 130, (byte) 134, (byte) 172, (byte) 112, (byte) 111, (byte) 138, (byte) 106, (byte) 100, (byte) 137, (byte) 106, (byte) 107, (byte) 106, (byte) 235, (byte) 53, (byte) 235, (byte) 77, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void save(OutputStream outStream, Configuration config)
    {
      ArrayList arrayList = new ArrayList();
      Iterator propertyKeys = config.findPropertyKeys("");
      while (propertyKeys.hasNext())
      {
        string str = (string) propertyKeys.next();
        arrayList.add((object) str);
      }
      Collections.sort((List) arrayList);
      OutputStreamWriter outputStreamWriter = new OutputStreamWriter(outStream, "iso-8859-1");
      for (int index = 0; index < arrayList.size(); ++index)
      {
        string str = (string) arrayList.get(index);
        string configProperty = config.getConfigProperty(str);
        string description = this.getDescription(str);
        if (description != null)
          this.writeDescription(description, (Writer) outputStreamWriter);
        this.saveConvert(str, 0, (Writer) outputStreamWriter);
        ((Writer) outputStreamWriter).write("=");
        this.saveConvert(configProperty, 1, (Writer) outputStreamWriter);
        ((Writer) outputStreamWriter).write(SortedConfigurationWriter.END_OF_LINE);
      }
      outputStreamWriter.flush();
    }

    protected internal virtual string getDescription(string key)
    {
      return (string) null;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 104, (byte) 161, (byte) 107, (byte) 107, (byte) 103, (byte) 104, (byte) 107, (byte) 115, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeDescription([In] string obj0, [In] Writer obj1)
    {
      if (String.instancehelper_length(obj0) == 0)
        return;
      obj1.write("# ");
      obj1.write(SortedConfigurationWriter.END_OF_LINE);
      LineBreakIterator lineBreakIterator = new LineBreakIterator(obj0);
      while (lineBreakIterator.hasNext())
      {
        obj1.write("# ");
        this.saveConvert((string) lineBreakIterator.next(), 2, obj1);
        obj1.write(SortedConfigurationWriter.END_OF_LINE);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 135, (byte) 106, (byte) 100, (byte) 191, (byte) 91, (byte) 138, (byte) 136, (byte) 104, (byte) 197, (byte) 104, (byte) 104, (byte) 197, (byte) 100, (byte) 172, (byte) 104, (byte) 136, (byte) 197, (byte) 104, (byte) 104, (byte) 197, (byte) 104, (byte) 104, (byte) 197, (byte) 100, (byte) 172, (byte) 104, (byte) 136, (byte) 229, (byte) 72, (byte) 100, (byte) 172, (byte) 104, (byte) 135, (byte) 165, (byte) 106, (byte) 104, (byte) 104, (byte) 115, (byte) 114, (byte) 114, (byte) 178, (byte) 231, (byte) 159, (byte) 179, (byte) 233, (byte) 160, (byte) 81})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void saveConvert([In] string obj0, [In] int obj1, [In] Writer obj2)
    {
      char[] chArray = String.instancehelper_toCharArray(obj0);
      for (int index = 0; index < chArray.Length; ++index)
      {
        int num1 = (int) chArray[index];
        int num2 = num1;
        int num3 = 9;
        if (num2 == num3)
        {
          if (obj1 == 2)
          {
            obj2.write(num1);
          }
          else
          {
            obj2.write(92);
            obj2.write(116);
          }
        }
        else
        {
          int num4 = 10;
          if (num2 == num4)
          {
            obj2.write(92);
            obj2.write(110);
          }
          else
          {
            int num5 = 12;
            if (num2 == num5)
            {
              if (obj1 == 2)
              {
                obj2.write(num1);
              }
              else
              {
                obj2.write(92);
                obj2.write(102);
              }
            }
            else
            {
              int num6 = 13;
              if (num2 == num6)
              {
                obj2.write(92);
                obj2.write(114);
              }
              else
              {
                int num7 = 32;
                if (num2 == num7)
                {
                  if (obj1 != 2 && (index == 0 || obj1 == 0))
                    obj2.write(92);
                  obj2.write(32);
                }
                else
                {
                  int num8 = 33;
                  if (num2 != num8)
                  {
                    int num9 = 34;
                    if (num2 != num9)
                    {
                      int num10 = 35;
                      if (num2 != num10)
                      {
                        int num11 = 58;
                        if (num2 != num11)
                        {
                          int num12 = 61;
                          if (num2 != num12)
                          {
                            int num13 = 92;
                            if (num2 == num13)
                            {
                              obj2.write(92);
                              obj2.write(92);
                              continue;
                            }
                            else if (num1 < 32 || num1 > 126)
                            {
                              obj2.write(92);
                              obj2.write(117);
                              obj2.write((int) SortedConfigurationWriter.HEX_CHARS[num1 >> 12 & 15]);
                              obj2.write((int) SortedConfigurationWriter.HEX_CHARS[num1 >> 8 & 15]);
                              obj2.write((int) SortedConfigurationWriter.HEX_CHARS[num1 >> 4 & 15]);
                              obj2.write((int) SortedConfigurationWriter.HEX_CHARS[num1 & 15]);
                              continue;
                            }
                            else
                            {
                              obj2.write(num1);
                              continue;
                            }
                          }
                        }
                      }
                    }
                  }
                  if (obj1 == 2)
                  {
                    obj2.write(num1);
                  }
                  else
                  {
                    obj2.write(92);
                    obj2.write(num1);
                  }
                }
              }
            }
          }
        }
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 61, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void save(string filename, Configuration config)
    {
      this.save(new File(filename), config);
    }
  }
}
