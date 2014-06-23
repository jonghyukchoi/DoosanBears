using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Hitter hitter = new Hitter();
            string[] hitters = new string[] { "민병헌", "오재원", "김현수", "칸투", "홍성흔", "양의지", "이원석", "김재호", "정수빈" };
            int[] grades = new int[] {2, 2, 3, 3, 3, 2, 1, 1, 1};
            // PrintHitters(); // 배열을 어떻게 참조?
            string[] pitchers = new string[] { "장원삼", "윤성환", "벤덴헐크", "차우찬", "안지만", "심창민", "임창용" };
            // PrintPitchers(); // 배열을 어떻게 참조?
            for (int i = 0; i <= pitchers.Length - 1; i++)
            {
                Console.WriteLine("{0} {1}", i+1, pitchers[i]);
            }
            Console.Write("선발 투수를 선택하세요. ");
            int SelectPitcher = int.Parse(Console.ReadLine());
            hitter.NameOfPitcher = pitchers[SelectPitcher - 1];
            int NumberOfStrikes = 0;
            int NumberOfBalls = 0;
            int O = 0;
            for (int i = 0; O <= 27; i++)
            {
                hitter.NameOfHitter = hitters[i % 9];
                hitter.grade = grades[i];
                if (O % 3 == 0 && O != 0 && hitters[i % 9] != hitters[(i+1) % 9])
                {
                    Console.Write("투수를 교체하시겠습니까? (Y/N) ");
                    string YesOrNo = Console.ReadLine();
                    if (YesOrNo == "Y")
                    {
                        // PrintPitchers();
                        Console.Write("교체 투입할 투수를 선택하세요. ");
                        SelectPitcher = int.Parse(Console.ReadLine());
                        hitter.NameOfPitcher = pitchers[SelectPitcher - 1];
                        NumberOfStrikes = 0;
                        NumberOfBalls = 0;

                        for (int j = SelectPitcher - 1; j <= pitchers.Length - 1; j++)
                        {
                            if (j != pitchers.Length - 1)
                            {
                                pitchers[j] = pitchers[j + 1];
                                Console.WriteLine(pitchers[j]);
                            }
                            else
                            {
                                pitchers[j] = null;
                            }
                        }
                    }
                }
                hitter.Match(hitter.NameOfHitter, hitter.NameOfPitcher, hitter.grade, ref O, ref NumberOfStrikes, ref NumberOfBalls);
            }
        }
    }
    class Hitter
    {
        public string NameOfHitter;
        public string NameOfPitcher;
        public int grade;
        // public Hitter next;
        public int Position = 0;
        public int Score = 0;
        public void Match(string NameOfHitter, string NameOfPitcher, int grade, ref int O, ref int NumberOfStrikes, ref int NumberOfBalls)
        {
            Random ball = new Random();
            int S = 0;
            int B = 0;
            if (O % 3 == 0)
            {
                if (O != 0)
                {
                    Console.WriteLine("{0}회 공격이 끝났습니다.", O / 3);
                    Console.WriteLine("{0}회 공격은 {1} 선수부터 시작됩니다.", O / 3 + 1, NameOfHitter);
                    PrintPitchingRecord(NameOfPitcher, NumberOfStrikes, NumberOfBalls);
                }
            }
            for (int NumberOfPitched = 1; O <= 27; NumberOfPitched++)
            {
                int a = ball.Next(1, 600 / grade / NumberOfPitched); // 투구수 100개를 기록한 투수가 3등급의 타자와 만날 경우 타율이 5할이 되는 것을 기준으로 함.
                if (a <= 600 / grade / NumberOfPitched)
                {
                    NumberOfStrikes++;
                }
                else
                {
                    NumberOfBalls++;
                }
                int b = ball.Next(1, 600 / grade / NumberOfPitched); // 투구수 100개를 기록한 투수가 3등급의 타자와 만날 경우 타율이 5할이 되는 것을 기준으로 함.
                Console.Write("칠래 말래? (H/W): ");
                string HitOrWait = Console.ReadLine();
                if (a >= 1 && a <= 600 / grade / NumberOfPitched / 2) // 스트라이크가 될 확률과 볼이 될 확률을 5대 5로 둠.
                {
                    if (HitOrWait == "H")
                    {
                        if (a == b)
                        {
                            Console.WriteLine("{0} 선수 {1} 상대로 안타를 뽑아냅니다!", NameOfHitter, NameOfPitcher);
                            S = 0;
                            B = 0;
                            PrintBallCount(S, B, O, NumberOfPitched);
                            Position++;
                            if(Position >= 4)
                            {
                                Score++;
                            }
                            
                            PrintBase(NameOfHitter, Position);
                            PrintBallCount(S, B, O, NumberOfBalls);
                            break;

                        }
                        else
                        {
                            Console.WriteLine("{0} 헛스윙!", NameOfHitter);
                            if (S >= 2)
                            {
                                Console.WriteLine("삼진!");
                                O++;
                                S = 0;
                                B = 0;
                                if (O == 3)
                                {
                                    break;
                                }
                                else
                                {
                                    PrintBallCount(S, B, O, NumberOfPitched);
                                    break;
                                }
                            }
                            else
                            {
                                S++;
                                PrintBallCount(S, B, O, NumberOfPitched);
                            }
                        }
                    }
                    else if (HitOrWait == "W")
                    {
                        Console.WriteLine("{0} 선수, 스트라이크를 쳐다만 보고 있네요.", NameOfHitter);
                        if (S >= 2)
                        {
                            Console.WriteLine("루킹 삼진!");
                            O++;
                            S = 0;
                            B = 0;
                            if (O == 3)
                            {
                                break;
                            }
                            else
                            {
                                PrintBallCount(S, B, O, NumberOfPitched);
                                break;
                            }
                        }
                        else
                        {
                            S++;
                            PrintBallCount(S, B, O, NumberOfPitched);
                        }
                    }
                    else
                    {
                        Console.WriteLine("치거나 기다리거나 둘 중 하나만 하세요.");
                    }
                }
                else
                {
                    if (HitOrWait == "H")
                    {
                        if (a == b)
                        {
                            Console.WriteLine("{0} 선수, 파울로 잘 커트했네요.", NameOfHitter);
                            if (S <= 2)
                            {
                                S++;
                            }
                            PrintBallCount(S, B, O, NumberOfPitched);
                        }
                        else
                        {
                            Console.WriteLine("{0}, 저런 볼에 배트가 나오면 안 되죠", NameOfHitter);
                            if (S >= 2)
                            {
                                Console.WriteLine("헛스윙 삼진!");
                                O++;
                                S = 0;
                                B = 0;
                                if (O == 3)
                                {
                                    break;
                                }
                                else
                                {
                                    PrintBallCount(S, B, O, NumberOfPitched);
                                    break;
                                }
                            }
                            else
                            {
                                S++;
                                PrintBallCount(S, B, O, NumberOfPitched);
                            }
                        }
                    }
                    else if (HitOrWait == "W")
                    {
                        Console.WriteLine("{0} 선수 잘 참아내네요.", NameOfHitter);
                        if (B >= 3)
                        {
                            Console.WriteLine("{0} 선수 상대로 볼넷을 골라냅니다!", NameOfPitcher);
                            S = 0;
                            B = 0;
                            Position++;
                            if (Position >= 4)
                            {
                                Score++;
                            }
                            PrintBase(NameOfHitter, Position);
                            break;
                        }
                        else
                        {
                            B++;
                            PrintBallCount(S, B, O, NumberOfPitched);
                        }
                    }
                    else
                    {
                        Console.WriteLine("치거나 기다리거나 둘 중 하나만 하세요.");
                    }
                }
            }
        }
        static void PrintBallCount(int S, int B, int O, int NumberOfPitched)
        {
            Console.WriteLine("투구수: {0}", NumberOfPitched);
            Console.Write("S ");
            for (int s = 1; s <= S; s++)
            {
                Console.Write("●");
            }
            Console.WriteLine();
            Console.Write("B ");
            for (int b = 1; b <= B; b++)
            {
                Console.Write("●");
            }
            Console.WriteLine();
            Console.Write("O ");
            for (int o = 1; o <= O % 3; o++)
            {
                Console.Write("●");
            }
            Console.WriteLine();
        }
        static void PrintPitchingRecord(string NameOfPitcher, int NumberOfStrikes, int NumberOfBalls)
        {
            Console.WriteLine("{0} 현재 투구수: {1}, 스트라이크: {2}, 볼: {3}", NameOfPitcher, NumberOfStrikes + NumberOfBalls, NumberOfStrikes, NumberOfBalls);
        }
        /* public Hitter first;
        public void GetOnBase(double coef, int exp)
        {
            Hitter hitter = new Hitter();
            hitter.Position = Position;
            if (first == null)
            {
                first = hitter;
                hitter.next = null;
            }
            else
            {
                hitter.next = first;
                first = hitter;
            }
        } */
        static void PrintBase(string NameOfHitter, int Position)
        {
            /* string[,] diamond = new string[3, 3] {
            {" ", "◇", " "},
            {"◇", " ", "◇"},
            {" ", "◇", " "}

        };
            if (Position == 1)
            {
                diamond[1, 2] = "◆";
            }
            else if (Position == 2)
            {
                diamond[1, 2] = "◆";
                diamond[0, 1] = "◆";
            }
            else
            {
                diamond[1, 2] = "◆";
                diamond[0, 1] = "◆";
                diamond[1, 0] = "◆";
            } */
            Console.WriteLine("주자 {0}루까지 가있습니다!", Position);
        }
        public static void PrintPitchers(string[] pitchers)
        {
            for (int i = 0; i<=pitchers.Length - 1; i++)
            {
                Console.WriteLine(pitchers[i]);
            }
        }
        public static void PrintHitters(string[] hitters)
        {
            for (int i = 0; i <= hitters.Length - 1; i++)
            {
                Console.WriteLine(hitters[i]);
            }
        }
    }
    class Pitcher
    {
        public string NameOfPitcher;
        public int grade;
    }
    class Print
    {
        
        static void PrintScoreboard()
        {

        }
        
    }
}
