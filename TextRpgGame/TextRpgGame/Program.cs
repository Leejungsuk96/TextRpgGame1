﻿using static TextRpgGame.Program;

namespace TextRpgGame
{
    internal class Program
    {
        enum STARTSELECT
        {
            SELECTSTATUS,
            SELECTINVENTORY,
            NONESELECT
        }

        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>>");

            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            Console.WriteLine("");

            switch (KeyInfo.Key)
            {
                case ConsoleKey.D1:
                    return STARTSELECT.SELECTSTATUS;
                case ConsoleKey.D2:
                    return STARTSELECT.SELECTINVENTORY;
                default:
                    Console.WriteLine("잘못된 선택입니다. 다시 선택해주세요");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }

        }

        public class Player
        {
            public string Name { get; }
            public string Job { get; }
            public int Level { get; }
            public int Atk { get; }
            public int Def { get; }
            public int Hp { get; }
            public int Gold { get; }
            public int BaseAtkValue { get; }
            public int BaseDefValue {  get; }

            public Player(string _name, string _Job, int _Level, int _Atk, int _Def, int _Hp, int _Gold)
            {
                Name = _name;
                Job = _Job;
                Level = _Level;
                Atk = _Atk;
                Def = _Def;
                Hp = _Hp;
                Gold = _Gold;
                BaseAtkValue = _Atk;
                BaseDefValue = _Def;
            }
        }
        public static void DisplayStatus()
        {
            Console.Clear();
            Player player = new Player("Chad", "전사", 1, 10, 5, 100, 1500);
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보르 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk}");
            Console.WriteLine($"방어력 : {player.Def}");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    StartSelect();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    DisplayStatus();
                    break;
            }
        }




        static void DisplayInventory()
        {
            Console.Clear();
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템목록]");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. 장착관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>>");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    StartSelect();
                    break;
                case ConsoleKey.D1:
                    DisplayInvenManager();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    DisplayInventory();
                    break;
            }
        }
        static void DisplayInvenManager()
        {
            Console.Clear();
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("0. 나가기");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D0:
                    DisplayInventory();
                    break;
                case ConsoleKey.D1:

                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    DisplayInvenManager();
                    break;
            }
        }
        static List<ItemData> itemsInDatabase = new List<ItemData>();
        static void InitItemDatabase()
        {
            itemsInDatabase.Add(new ItemData(0, "낡은 검", 2, 0, "쉽게 볼 수 있는 낡은 검입니다."));
            itemsInDatabase.Add(new ItemData(1, "천 갑옷", 0, 2, "질긴 천을 덧대어 제작한 낡은 갑옷입니다."));
        }
        public class ItemData
        {
            public int ItemId;
            public bool IsItemEquipped;
            public string ItemName;
            public int ItemAtk;
            public int ItemDef;
            public string ItemComm;

            public ItemData(int _itemId, string _itemName, int _itemAtk, int _itemDef, string _itemComm)
            {
                ItemId = _itemId;
                ItemName = _itemName;
                ItemAtk = _itemAtk;
                ItemDef = _itemDef;
                ItemComm = _itemComm;
                IsItemEquipped = false;
            }
        }

        static void Main(string[] args)
        {


            while (true)
            {
                STARTSELECT SelectCheck = StartSelect();

                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTSTATUS:

                        DisplayStatus();
                        break;
                    case STARTSELECT.SELECTINVENTORY:
                        DisplayInventory();
                        break;
                }
            }
        }
    }
}
         
