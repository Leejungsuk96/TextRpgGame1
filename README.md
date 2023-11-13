# TextRpgGame
초기화면 / 캐릭터 스탯화면 / 인벤토리화면 / 장착관리화면으로 구성하였고 각각 함수로 표현하여 필요할 때 불러오려고 했다.

```enum STARTSELECT
{
    SELECTSTATUS,
    SELECTINVENTORY,
    NONESELECT
}```

```static STARTSELECT StartSelect()
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

}```

enum을 사용하여 SartSelect 함수를 만들었다.
enum을 return하는 연습을 하면서 익혔다.


