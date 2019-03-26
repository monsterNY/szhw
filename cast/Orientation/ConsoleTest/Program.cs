﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using ConsoleTest.Domain.StructModel;
using ConsoleTest.Entity;
using ConsoleTest.LeetCode;
using ConsoleTest.MiddleQuestion;
using ConsoleTest.WeekTest;
using Newtonsoft.Json;
using Tools.RefTools;

namespace ConsoleTest
{
  class Program
  {
    #region Command

    public static void ShowConsole(Dictionary<string, object> dictionary)
    {
      Console.WriteLine($"\n-----------------S---------------------");

      foreach (var item in dictionary)
      {
        Console.WriteLine($"{item.Key}:{item.Value}");
      }

      Console.WriteLine($"-----------------E---------------------\n");
    }

    #endregion

    static void Main(string[] args)
    {
      var rand = new Random();
      CodeTimer timer = new CodeTimer();
      timer.Initialize();
      SmallestRepunitDivByK instance = new SmallestRepunitDivByK();

      //long num = 1;

      //while (num>0)
      //{
      //  instance.Test(num);
      //  num = num * 10 + 1;
      //}

      //Console.WriteLine(JsonConvert.SerializeObject(instance.list.Distinct().OrderBy(u => u)));

      //Console.WriteLine(JsonConvert.SerializeObject(instance.Dictionary.OrderBy(u => u.Key)));

      //Console.ReadKey(true);

      for (int i = 1; i < 1000; i++)
      {
        Console.WriteLine($"{i}---- result: {instance.Solution(i)}");
      }


      Console.ReadKey(true);
    }

    private static StoneGame TestStoneGame()
    {
      StoneGame instance = new StoneGame();

      Console.WriteLine(instance.Solution(new[] {5, 3, 4, 5}));
      return instance;
    }

    private static void TestIntervalIntersection()
    {
      IntervalIntersection instance = new IntervalIntersection();

      var intervals = instance.Solution(new[]
      {
        new Interval(0, 2),
        new Interval(5, 10),
        new Interval(13, 23),
        new Interval(24, 25),
      }, new[]
      {
        new Interval(1, 5),
        new Interval(8, 12),
        new Interval(15, 24),
        new Interval(25, 26),
      });

      Console.WriteLine(JsonConvert.SerializeObject(intervals));
    }

    private static void InsertIntoMaxTreeTest()
    {
      InsertIntoMaxTree instance = new InsertIntoMaxTree();

      var treeNode = instance.Solution(new TreeNode(5, new TreeNode(2, null, 1), 4), 3);

      Console.WriteLine(treeNode);
    }

    private static void TestCanThreePartsEqualSum()
    {
      CanThreePartsEqualSum instance = new CanThreePartsEqualSum();

      Console.WriteLine(instance.Solution(new[] {0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1}));

      Console.WriteLine(instance.Solution(new[] {18, 12, -18, 18, -19, -1, 10, 10}));
      Console.WriteLine(instance.Solution(new[] {18, 12, -18, 18, -19, -1, 10, 10}));

      Console.WriteLine(instance.Solution(new[] {3, 3, 6, 5, -2, 2, 5, 1, -9, 4}));

      Console.WriteLine(instance.Solution(new[] {0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1}));
    }

    private static void TestReconstructQueue()
    {
      var arr = new[]
      {
        new[] {7, 0}, new[] {4, 4}, new[] {7, 1}, new[] {5, 0}, new[] {6, 1}, new[] {5, 2}
      };

      Array.Sort(arr, ((ints, ints1) => ints[0] - ints1[0]));

      Console.WriteLine(arr);

      ReconstructQueue instance = new ReconstructQueue();

      var solution = instance.Solution(new[]
      {
        new[] {7, 0}, new[] {4, 4}, new[] {7, 1}, new[] {5, 0}, new[] {6, 1}, new[] {5, 2}
      });

      Console.WriteLine(JsonConvert.SerializeObject(solution));
      solution = instance.Solution(new[]
      {
        new[] {2, 4}, new[] {3, 4}, new[] {9, 0}, new[] {0, 6}, new[] {7, 1}, new[] {6, 0}, new[] {7, 3}, new[] {2, 5},
        new[] {1, 1}, new[] {8, 0}
      });

      Console.WriteLine(JsonConvert.SerializeObject(solution));

      var simple = instance.Simple(new[]
      {
        new[] {7, 0}, new[] {4, 4}, new[] {7, 1}, new[] {5, 0}, new[] {6, 1}, new[] {5, 2}
      });

      Console.WriteLine(JsonConvert.SerializeObject(simple));
      simple = instance.Simple(new[]
      {
        new[] {2, 4}, new[] {3, 4}, new[] {9, 0}, new[] {0, 6}, new[] {7, 1}, new[] {6, 0}, new[] {7, 3}, new[] {2, 5},
        new[] {1, 1}, new[] {8, 0}
      });

      Console.WriteLine(JsonConvert.SerializeObject(simple));
    }

    private static void TestCountBits()
    {
      Console.WriteLine(1 >> 2);
      Console.WriteLine(1 << 2);

      CountBits instance = new CountBits();

      Console.WriteLine(JsonConvert.SerializeObject(instance.Solution(2)));

      var flag = 2;

      for (int i = 0; i < 100; i++)
      {
        if (i == flag * 2)
        {
          flag *= 2;
          Console.WriteLine("++++++++++++++++++");
        }

        var count = instance.Count(i);
        Console.WriteLine($"{i}------------{count}------------|{i - flag}");
      }
    }

    private static void TestComplexNumberMultiply()
    {
      ComplexNumberMultiply instance = new ComplexNumberMultiply();

      Console.WriteLine(instance.Solution("1+-1i", "1+-1i"));
    }

    private static void TestCountBattleships()
    {
      //[,]是二维数组 [][]是交叉数组 what???
      var array = new int[,] {{1, 2}, {2, 3}, {2, 3}, {2, 3}};

      array[0, 0] = 8;

      Console.WriteLine("数组的长度为{0}", array.Length);
      /*
      Console.WriteLine(array.GetLength(0));
      Console.WriteLine(array.GetLength(1));
      */
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.WriteLine(array[i, j]);
        }
      }

      Console.WriteLine("---------");

      CountBattleships instance = new CountBattleships();

      Console.WriteLine(
        instance.Solution(new char[,] {{'X', '.', '.', 'X'}, {'.', '.', '.', 'X'}, {'.', '.', '.', 'X'}}));
    }

    private static void DistributeCoinsTest()
    {
      DistributeCoins instance = new DistributeCoins();

      Console.WriteLine(instance.Solution(
        new TreeNode(4, null,
          new TreeNode(0, new TreeNode(0, null, new TreeNode(0, null, 2)), 0
          ))
      )); //6

      Console.WriteLine(instance.Solution(
        new TreeNode(0, new TreeNode(1, 3, 0), null)
      )); //4

      Console.WriteLine(instance.Solution(
        new TreeNode(1, new TreeNode(0, null, 3), 0)
      )); //4

      Console.WriteLine(instance.Solution(
        new TreeNode(4,
          new TreeNode(0, null,
            new TreeNode(0, null, 0)), null)
      )); //6

      Console.WriteLine(instance.Solution(
        new TreeNode(0,
          new TreeNode(1, 3, 0), null)
      )); //4

      Console.ReadKey(true);

      Console.WriteLine(instance.Solution(
        new TreeNode(3, 0, 0)
      ));
      Console.WriteLine(instance.Solution(
        new TreeNode(0, 3, 0)
      ));
      Console.WriteLine(instance.Solution(
        new TreeNode(1, 0, 2)
      ));
      Console.WriteLine(instance.Solution(
        new TreeNode(1, new TreeNode(0, null, 3), 0)
      ));
    }

    private static void TestMinAddToMakeValid()
    {
      MinAddToMakeValid instance = new MinAddToMakeValid();

      Console.WriteLine(instance.Solution("((())"));
    }

    private static void FindAndReplacePatternTest()
    {
      FindAndReplacePattern instance = new FindAndReplacePattern();

      var solution = instance.Solution(new[]
      {
        "abc", "deq", "mee", "aqq", "dkd", "ccc"
      }, "abb");

      Console.WriteLine(JsonConvert.SerializeObject(solution));
    }

    private static void TestDeckRevealedIncreasing(CodeTimer timer)
    {
      DeckRevealedIncreasing instance = new DeckRevealedIncreasing();

      instance.Solution(new[] {1, 2, 3, 4, 5, 6, 7});

      Console.ReadKey(true);

      List<int> list = new List<int>();
      for (int i = 1; i < 20; i++)
      {
        list.Add(i);

        int[] arr = null;

        var codeTimerResult = timer.Time(1, action: (() => { arr = instance.Simple(list.ToArray()); }));

        ShowConsole(new Dictionary<string, object>()
        {
          {nameof(list), JsonConvert.SerializeObject(list)},
          {nameof(arr), JsonConvert.SerializeObject(arr)},
          {nameof(codeTimerResult), codeTimerResult}
        });

        instance.Check(arr);
      }
    }

    [Obsolete]
    private static void TestInsertIntoBST()
    {
      InsertIntoBST instance = new InsertIntoBST();

      var treeNode = instance.Solution(new TreeNode(4,
        new TreeNode(2, 1, 3),
        7
      ), 5);

      Console.WriteLine(treeNode);
    }

    private static void ConstructMaximumBinaryTreeTest()
    {
      ConstructMaximumBinaryTree instance = new ConstructMaximumBinaryTree();

      var treeNode = instance.Solution(new[] {3, 2, 1, 6, 0, 5});

      Console.WriteLine(treeNode);
    }

    private static void RangeSumBSTTest()
    {
      RangeSumBST instance = new RangeSumBST();

      Console.WriteLine(instance.Solution(new TreeNode(10,
        new TreeNode(5,
          new TreeNode(3), new TreeNode(7)),
        new TreeNode(15,
          null, new TreeNode(18))
      ), 7, 15));

      Console.WriteLine(instance.Solution(new TreeNode(10,
        new TreeNode(5,
          new TreeNode(3, 1, null), new TreeNode(7, 6, null)),
        new TreeNode(15,
          new TreeNode(13), new TreeNode(18))
      ), 6, 10));
    }

    #region empty

    public void Empty()
    {
      //先进后出
      Stack<int> stack = new Stack<int>();
      stack.Push(1);
      stack.Push(2);
      stack.Push(3);
      stack.Push(4);

      //返回最后一个 不删除
      Console.WriteLine(stack.Peek());
      Console.WriteLine(stack.Peek());
      //返回最后一个 删除
      Console.WriteLine(stack.Pop());
      Console.WriteLine(stack.Pop());

      //先进先出
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Enqueue(4);

      Console.WriteLine(queue.Dequeue());
      Console.WriteLine(queue.Dequeue());

      Console.WriteLine(queue.Peek());
      Console.WriteLine(queue.Peek());

      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0xF8, 2));
      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 ^ 0xF8, 2));
      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 & 0xF8, 2));
      Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 | 0xF8, 2));

      Console.WriteLine((int) 'a');
      Console.WriteLine((int) 'A');

      Console.WriteLine($"{{rand}}");

      var type = typeof(Types);

      var propertyInfos = type.GetProperties();
      var fieldInfos = type.GetFields(BindingFlags.Static | BindingFlags.Public);

      var descriptionAttribute = fieldInfos[1].GetCustomAttribute<DescriptionAttribute>();

      var strings = Enum.GetNames(type);

      var values = Enum.GetValues(type);
    }

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

    enum Types
    {
      [Description("正常")] Normal = 0,
      Special = 1,
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

    #endregion
  }
}