﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ConsoleTest.Entity;
using ConsoleTest.LeetCode;
using Newtonsoft.Json;
using Tools.RefTools;

namespace ConsoleTest
{
  class Program
  {
    #region empty

    public static dynamic Build<T>(T instance, string[] properties)
    {
      dynamic obj = new System.Dynamic.ExpandoObject();

      var type = typeof(T);

      foreach (var prop in properties)
      {
        var propertyInfo = type.GetProperty(prop);

        if (propertyInfo != null)
        {
          ((IDictionary<string, object>) obj).Add(propertyInfo.Name, propertyInfo.GetValue(instance));
        }
      }

      return obj;
    }

    #endregion

    static void Main(string[] args)
    {
      var rand = new Random();
      CodeTimer timer = new CodeTimer();
      timer.Initialize();

      var instance = new HasGroupsSizeX();

//      Console.WriteLine(instance.Solution(new[] {1, 2, 3, 4, 4, 3, 2, 1}));
//      Console.WriteLine(instance.Solution(new[] {1, 1, 1, 2, 2, 2, 3, 3}));
//      Console.WriteLine(instance.Solution(new[] {1}));
//      Console.WriteLine(instance.Solution(new[] {1, 1}));
//      Console.WriteLine(instance.Solution(new[] {1, 1, 2, 2, 2, 2}));

      Console.WriteLine(instance.Solution(new []{1, 1, 1, 1, 2, 2, 2, 2, 2, 2}));

      Console.ReadKey(true);

      for (int i = 0; i < 100; i++)
      {
        var arrLen = rand.Next(10) + 2;

        var arr = new int[arrLen];

        for (int j = 0; j < arr.Length; j++)
        {

          arr[j] = rand.Next(4) + 2;

        }

        bool result = false;

        var codeTimerResult = timer.Time(1, (() => { result = instance.Solution(arr); }));

        Console.WriteLine("\n------------S---------------");
        Console.WriteLine($"arr:{JsonConvert.SerializeObject(arr)}");
        Console.WriteLine($"result:{result}");
        Console.WriteLine($"time:{codeTimerResult}");
        Console.WriteLine("\n------------E---------------");

      }

      Console.WriteLine("Hello World!");

      Console.ReadKey(true);
    }

    private static void ValidMountainArrayTest()
    {
      ValidMountainArray instance = new ValidMountainArray();

      Console.WriteLine(instance.Solution(new[] {2, 1}));
      Console.WriteLine(instance.Solution(new[] {3, 5, 5}));
      Console.WriteLine(instance.Solution(new[] {0, 3, 2, 1}));
      Console.WriteLine(instance.Solution(new[]
      {
        14, 82, 89, 84, 79, 70, 70, 68, 67, 66, 63, 60, 58, 54, 44, 43, 32, 28, 26, 25, 22, 15, 13, 12, 10, 8, 7, 5, 4,
        3
      }));
    }

    private static void EmptyTest()
    {
      var stu = new Student()
      {
        Age = 18,
        ClassId = 1,
        Name = "xxx"
      };

      var result = Build(stu, new[] {nameof(Student.Age), nameof(Student.Name)});

      Console.WriteLine(result.Age);
      Console.WriteLine(result.Name);
    }

    private static void AddToArrayFormOfIntegerTest(CodeTimer timer)
    {
      AddToArrayFormOfInteger instance = new AddToArrayFormOfInteger();

      //      Console.WriteLine(JsonConvert.SerializeObject(instance.SimpleDeal(new[] {3, 0, 6, 7, 6, 1, 0, 5, 7, 6}, 6525)));
      //
      //      Console.ReadKey(true);

      //basic test -- success
      //      var result = instance.AddToArrayForm(new[] {1, 2, 0, 0}, 34);
      //
      //      Console.WriteLine(JsonConvert.SerializeObject(result));
      //
      //      result = instance.AddToArrayForm(new[] { 2, 7, 4 }, 181);
      //
      //      Console.WriteLine(JsonConvert.SerializeObject(result));
      //
      //      result = instance.AddToArrayForm(new[] { 2, 1, 5 }, 806);
      //
      //      Console.WriteLine(JsonConvert.SerializeObject(result));
      //
      //      result = instance.AddToArrayForm(new[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 }, 1);
      //
      //      Console.WriteLine(JsonConvert.SerializeObject(result));

      var rand = new Random();

      for (int i = 0; i < 100; i++)
      {
        var arrLen = rand.Next(10) + 1;
        var arr = new int[arrLen];
        IList<int> result = null;
        var randNum = rand.Next(10000);
        for (int j = 0; j < arr.Length; j++)
        {
          arr[j] = rand.Next(10);
        }

        var codeTimerResult = timer.Time(1, () => { result = instance.AddToArrayForm(arr, randNum); });

        Console.WriteLine("------------S-------------------");

        Console.WriteLine($@"
arr:{JsonConvert.SerializeObject(arr)}
randNum:{randNum}
result:{JsonConvert.SerializeObject(result)}
time:{codeTimerResult}
");

        //        IList<int> realResult = null;
        //        var realCodeTimerResult = timer.Time(1, () => { realResult = instance.SimpleDeal(arr, randNum); });
        //
        //        Console.WriteLine($@"
        //realResult:{JsonConvert.SerializeObject(realResult)}
        //realCodeTimerResult:{realCodeTimerResult}
        //");

        Console.WriteLine("------------E-------------------");
      }
    }

    private static void StringWithoutAaaOrBbbTest()
    {
      StringWithoutAaaOrBbb instance = new StringWithoutAaaOrBbb();

      Console.WriteLine(instance.StrWithout3a3b(1, 2));
      Console.WriteLine(instance.StrWithout3a3b(4, 1));
    }

    private static void FindTheTownJudgeTest()
    {
      FindTheTownJudge instance = new FindTheTownJudge();

      var result = instance.FindJudge(2, new[]
      {
        new[] {1, 2}
      });

      var optimize = instance.Optimize(2, new[]
      {
        new[] {1, 2}
      });

      Console.WriteLine(result);
      Console.WriteLine($"optimize:{optimize}");

      result = instance.FindJudge(3, new[]
      {
        new[] {1, 3},
        new[] {2, 3}
      });

      optimize = instance.Optimize(3, new[]
      {
        new[] {1, 3},
        new[] {2, 3}
      });

      Console.WriteLine(result);
      Console.WriteLine($"optimize:{optimize}");

      result = instance.FindJudge(3, new[]
      {
        new[] {1, 3},
        new[] {2, 3},
        new[] {3, 1},
      });

      optimize = instance.Optimize(3, new[]
      {
        new[] {1, 3},
        new[] {2, 3},
        new[] {3, 1},
      });

      Console.WriteLine(result);
      Console.WriteLine($"optimize:{optimize}");

      result = instance.FindJudge(3, new[]
      {
        new[] {1, 2},
        new[] {2, 3},
      });

      optimize = instance.Optimize(3, new[]
      {
        new[] {1, 2},
        new[] {2, 3},
      });

      Console.WriteLine(result);
      Console.WriteLine($"optimize:{optimize}");

      result = instance.FindJudge(4, new[]
      {
        new[] {1, 3},
        new[] {1, 4},
        new[] {2, 3},
        new[] {2, 4},
        new[] {4, 3},
      });

      optimize = instance.Optimize(4, new[]
      {
        new[] {1, 3},
        new[] {1, 4},
        new[] {2, 3},
        new[] {2, 4},
        new[] {4, 3},
      });

      Console.WriteLine(result);
      Console.WriteLine($"optimize:{optimize}");

      Console.WriteLine();
    }

    private static void FindCommonCharactersTest(CodeTimer timer)
    {
      var instance = new FindCommonCharacters();

      var commonChars = instance.CommonChars(new string[]
      {
        "bella", "label", "roller"
      });

      Console.WriteLine(JsonConvert.SerializeObject(commonChars));

      commonChars = instance.CommonChars(new string[]
      {
        "cool", "lock", "cook"
      });

      Console.WriteLine(JsonConvert.SerializeObject(commonChars));

      var rand = new Random();

      for (int i = 0; i < 100; i++)
      {
        var randArrNum = rand.Next(4) + 100;
        var strNum = rand.Next(5) + 100;
        IList<string> result = null;
        IList<string> rival = null;
        string[] arr = new string[randArrNum];

        for (int j = 0; j < randArrNum; j++)
        {
          StringBuilder builder = new StringBuilder();
          for (int k = 0; k < strNum; k++)
          {
            builder.Append((char) (rand.Next(26) + 97));
          }

          arr[j] = builder.ToString();
        }

        var spendTime = timer.Time(1, (() => { result = instance.CommonChars(arr); }));
        var spendTime2 = timer.Time(1, (() => { rival = instance.OtherSolution(arr); }));

        //        arr: { JsonConvert.SerializeObject(arr)}

        Console.WriteLine($@"
{spendTime}
result:{JsonConvert.SerializeObject(result)}

<rival>
{spendTime2}
result:{JsonConvert.SerializeObject(rival)}

-------------------------------------------------------------

");
      }
    }

    private static void AddBinaryTest()
    {
      AddBinary instance = new AddBinary();
      instance.OtherSolution("1010", "1011");
      instance.OtherSolution("11", "0");
    }

    private static void IntegerToRomanTest()
    {
      var instance = new IntegerToRoman();

      var testInstance = new RomanToInteger();

      var rand = new Random();

      for (int i = 0; i < 1000; i++)
      {
        var num = rand.Next(10000);
        var solution = instance.Solution(num);

        var realNum = testInstance.Optimize(solution);

        Console.WriteLine($"roman:{solution},num:{num},realNum:{realNum},success:{num == realNum}");
      }
    }

    private static void SimpleDateDiffTest()
    {
      var startDate = new DateTime(2018, 7, 1, 0, 0, 0);
      var endDate = new DateTime(2019, 2, 1, 0, 0, 0);

      var list = new List<string>();

      for (int i = startDate.Year; i <= endDate.Year; i++)
      {
        for (int j = i > startDate.Year ? 1 : startDate.Month; j <= (i == endDate.Year ? endDate.Month : 12); j++)
        {
          list.Add($"{i}{(j < 10 ? "0" : "")}{j}");
        }
      }

      Console.WriteLine(JsonConvert.SerializeObject(list));
    }

    private static void ConvertANumberToHexadecimalTest(CodeTimer timer)
    {
      //      Console.WriteLine(0xffff);
      //      Console.WriteLine(int.MaxValue);
      //
      //      Console.WriteLine(Convert.ToString(0, 16));
      //      Console.WriteLine(Convert.ToString(1, 16));
      //      Console.WriteLine(Convert.ToString(-1, 16));
      //      Console.WriteLine(Convert.ToString(-2, 16));
      //      Console.WriteLine(Convert.ToString(-3, 16));
      //      Console.WriteLine(Convert.ToString(0xffffffff, 16));

      ConvertANumberToHexadecimal instance = new ConvertANumberToHexadecimal();

      Console.WriteLine(instance.ToHex(26));

      Console.WriteLine(instance.ToHex(-1));

      var rand = new Random();

      var successCount = 0;

      for (int i = 0; i < 1000; i++)
      {
        var num = rand.Next(int.MaxValue);

        num *= rand.Next(2) == 0 ? 1 : -1;

        Console.WriteLine($"\n\n传入num:{num}");

        var result = timer.Time(1, (() => { Console.WriteLine(instance.ToHex(num)); }));

        Console.WriteLine($"耗费时间：{result}");

        var result2 = timer.Time(1, (() => { Console.WriteLine($"正确答案：{Convert.ToString(num, 16)}"); })); //使用原有帮助类处理

        Console.WriteLine($"帮助类-耗费时间：{result}");

        if (result.TimeElapsed <= result2.TimeElapsed)
        {
          successCount++;
        }
      }

      Console.WriteLine($"成功次数：{successCount}");
    }

    private static void RomanToIntegerTest(CodeTimer timer)
    {
      var instance = new RomanToInteger();

      //success
      //      Console.WriteLine(instance.RomanToInt("III"));
      //      Console.WriteLine(instance.RomanToInt("IV"));
      //      Console.WriteLine(instance.RomanToInt("IX"));
      //      Console.WriteLine(instance.RomanToInt("LVIII"));
      //      Console.WriteLine(instance.RomanToInt("MCMXCIV"));
      //
      //      Console.WriteLine(instance.RomanToInt("CXCXL"));
      //
      //      Console.ReadKey(true);

      var rand = new Random();
      var charArr = new[]
      {
        'I',
        'V',
        'X',
        'L',
        'C',
        'D',
        'M'
      };

      var randCount = 10;
      var fixCount = 4;
      for (int i = 0; i < 10; i++)
      {
        var len = rand.Next(randCount) + fixCount;

        var arr = new char[len];

        for (int j = 0; j < len; j++)
        {
          arr[j] = charArr[rand.Next(charArr.Length)];
        }

        var str = new string(arr);

        Console.WriteLine($"\n随机生成字符串：{str}\n");

        var result = timer.Time(1, (() => { Console.WriteLine($"[RomanToInt]计算结果：{instance.RomanToInt(str)}"); }));

        Console.WriteLine(result);

        Console.WriteLine("--------------------------");

        result = timer.Time(1, (() => { Console.WriteLine($"[Optimize]计算结果：{instance.Optimize(str)}"); }));

        Console.WriteLine(result);

        Console.WriteLine("--------------------------");
      }
    }

    private static void GroupCount()
    {
      var testCount = 10;

      var arr = new List<dynamic>();

      var rand = new Random();

      for (int i = 0; i < 1000000; i++)
      {
        arr.Add(new {sex = rand.Next(2), age = rand.Next(100)});
      }

      var timer = new CodeTimer();

      var result = timer.Time(testCount, (() =>
      {
        //        Console.WriteLine("-------------------------linq-----------------------");
        var enumerable = arr.GroupBy(u => u.sex).Select(u => new {u.Key, count = u.Count()});
        foreach (var item in enumerable)
        {
          //          Console.WriteLine($"性别：{(item.Key == 0 ? "女" : "男")}，数量：{item.count}");
        }

        //
        //        Console.WriteLine();
      }));

      Console.WriteLine("-------------------------linq-----------------------"); //效率最低。。。
      Console.WriteLine(result);

      result = timer.Time(testCount, (() =>
      {
        var countArr = new int[2];

        foreach (var item in arr)
        {
          countArr[item.sex == 0 ? 0 : 1]++;
        }

        foreach (var item in countArr)
        {
        }

        //        Console.WriteLine("-------------------------arr-----------------------");
        //        Console.WriteLine($"性别男，数量：{countArr[1]}");
        //        Console.WriteLine($"性别女，数量：{countArr[0]}");
        //        Console.WriteLine();
      }));

      Console.WriteLine("-------------------------arr-----------------------"); //arr效率最高
      Console.WriteLine(result);

      result = timer.Time(testCount, (() =>
      {
        //        Console.WriteLine("-------------------------dictionary-----------------------");
        var countDic = new Dictionary<int, int>();

        foreach (var item in arr)
        {
          if (countDic.ContainsKey(item.sex))
          {
            countDic[item.sex]++;
          }
          else
          {
            countDic.Add(item.sex, 1);
          }
        }

        foreach (var item in countDic)
        {
          //          Console.WriteLine($"性别：{(item.Key == 0 ? "女" : "男")}，数量：{item.Value}");
        }

        //
        //        Console.WriteLine();
      }));

      Console.WriteLine("-------------------------dictionary-----------------------"); //字典效率第二
      Console.WriteLine(result);
    }
  }
}