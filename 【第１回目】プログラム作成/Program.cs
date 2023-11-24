using System;

namespace _第１回目_プログラム作成
{
    class Program
    {
        static void Main(string[] args)
        {
            string owari = "";
            while (owari != "いいえ")
            {
                Console.WriteLine("計算をします。利用したい機能の数字を入力してください");
                Console.WriteLine("1:数字の演算　2:給与計算 3:年号計算");
                int kinou ;
                kinou = int.Parse(Console.ReadLine());
                while(kinou != 1 && kinou != 2 && kinou != 3)
                {
                    Console.WriteLine("数字が違います。利用したい機能の数字を入力してください");
                    Console.WriteLine("1:数字の演算　2:給与計算　3:年号計算");
                    kinou = int.Parse(Console.ReadLine());
                }



                if (kinou == 1)
                {
                    Test1();
                   
                }

                else if (kinou == 2)
                {
                    Test2();
                }
                else if (kinou == 3)
                {
                    Test3();
                }
                
                Console.WriteLine("計算終了！つづけて計算をしますか？");
                Console.WriteLine("はい or いいえ　を入力してください");
                owari = Console.ReadLine();
                while (owari != "はい" && owari != "いいえ")
                {
                    Console.WriteLine("はい or いいえ　を入力してください");
                    owari = Console.ReadLine();
                }


                static void Test1(){
                    {
                        //①２数の演算
                        Console.WriteLine("計算をします。数字はふたつまでです。");

                        //一つ目の数字
                        double num1;
                        Console.WriteLine("一つ目の計算したい数字を入れてください");
                        num1 = double.Parse(Console.ReadLine());

                        //演算子入力
                        string text1;
                        Console.WriteLine("計算したい『演算子記号のみ』を以下から入力してください");
                        Console.WriteLine("たし算：＋　ひき算：-　かけ算：*　わり算：/");
                        text1 = Console.ReadLine();

                        while (text1 != "+" && text1 != "-" && text1 != "*" && text1 != "/")
                        {
                            Console.WriteLine("『演算子記号のみ』を以下から入力してください");
                            Console.WriteLine("たし算：＋　ひき算：-　かけ算：*　わり算：/");
                            text1 = Console.ReadLine();
                        }

                        //演算子２つめ入力
                        double num2;
                        Console.WriteLine("計算したい数字を入れてください");
                        num2 = double.Parse(Console.ReadLine());


                        //計算
                        if (text1 == "+")
                        {
                            double plus;
                            plus = num1 + num2;
                            Console.WriteLine("計算結果は、" + (plus.ToString()) + "です！");
                            if (plus == 37564)//おまけ
                            {
                                while (true)
                                {
                                    Console.WriteLine("皆殺しはやめよう");
                                    Console.Beep();
                                }
                            }

                        }
                        else if (text1 == "-")
                        {
                            double minus;
                            minus = num1 - num2;
                            Console.WriteLine("計算結果は、" + (minus.ToString()) + "です！");

                        }
                        else if (text1 == "*")
                        {
                            double multi;
                            multi = num1 * num2;
                            Console.WriteLine("計算結果は、" + (multi.ToString()) + "です！");

                        }
                        else if (text1 == "/")
                        {
                            double dev;
                            dev = num1 / num2;
                            Console.WriteLine("計算結果は、" + (dev.ToString()) + "です！");

                        }
                        return;


                    }

                }

                static void Test2()
                {
                    //②時間の計算いれる（時給計算）
                    Console.WriteLine("何時何分に出勤しましたか？24時間で教えてください");
                    double time1;
                    double time2;

                    Console.Write("時：");
                    time1 = double.Parse(Console.ReadLine());
                    Console.Write("分：");
                    time2 = double.Parse(Console.ReadLine());
                    time2 = time2 / 60;

                    double time12 = time1 + time2;

                    Console.WriteLine("何時何分に退勤しましたか？24時間で教えてください");
                    double time3;
                    double time4;
                    Console.Write("時：");
                    time3 = double.Parse(Console.ReadLine());
                    Console.Write("分：");
                    time4 = double.Parse(Console.ReadLine());
                    time4 = time4 / 60;

                    double time34 = time3 + time4;
                    double sigoto = time34 - time12;

                    Console.WriteLine("時給はいくらですか？");
                    Console.Write("円：");
                    double zikyu;
                    zikyu = double.Parse(Console.ReadLine());

                    double nikkyu = sigoto * zikyu;
                    double nensyu = nikkyu * 240;
                    double tedori = nensyu * 0.8;


                    Console.WriteLine("あなたの日給は" + nikkyu.ToString() + "円です");
                    Console.WriteLine("あなたの年収はおおよそ、" + nensyu.ToString() + "円です");
                    Console.WriteLine("あなたがサラリーマンなら、手取り年収はおおよそ、" + tedori.ToString() + "円です");
                    return;
                }

                static void Test3()
                {
                    Console.WriteLine("どちらを計算しますか？");
                    Console.WriteLine("1：西暦から年号　　2：年号から西暦");
                    int case1;
                    case1 = int.Parse(Console.ReadLine());
                    while(case1 != 1 && case1 != 2)
                    {
                        Console.WriteLine("数字が違います。どちらを計算しますか？");
                        Console.WriteLine("1：西暦から年号　　2：年号から西暦");
                        case1 = int.Parse(Console.ReadLine());
                    }

                    if (case1 ==1) {
                        //西暦から年号を計算する
                        Console.WriteLine("西暦を年号に戻します。計算したい西暦を入力してください。");
                        int seireki;
                        seireki = int.Parse(Console.ReadLine());

                        while(seireki < 1867)
                        {
                            Console.WriteLine("それより前は江戸時代です。");
                            Console.WriteLine("西暦を年号に戻します。計算したい西暦を入力してください。");
                            seireki = int.Parse(Console.ReadLine());
                        }


                        if(seireki > 1867 && seireki < 1912)
                        {
                            int meiji1;
                            meiji1 = seireki - 1867;
                            Console.WriteLine(seireki + "は、明治" + meiji1 + "年です！") ;
                        }
                        else if (seireki > 1911 && seireki < 1926)
                        {
                            int taisyo1;
                            taisyo1 = seireki - 1911;
                            Console.WriteLine(seireki + "は、大正" + taisyo1 + "年です！");
                        }
                        else if (seireki > 1925 && seireki < 1989)
                        {
                            int syouwa1;
                            syouwa1 = seireki - 1925;
                            Console.WriteLine(seireki + "は、昭和" + syouwa1 + "年です！");
                        }
                        else if (seireki > 1988 && seireki < 2019)
                        {
                            int heisei1;
                            heisei1 = seireki - 1988;
                            Console.WriteLine(seireki + "は、昭和" + heisei1 + "年です！");
                        }
                        else if (seireki > 2018 )
                        {
                            int heisei1;
                            heisei1 = seireki - 2018;
                            Console.WriteLine(seireki + "は、昭和" + heisei1 + "年です！");
                        }


                    }
                    //年号から西暦を計算する
                    else if(case1 == 2)
                    {
                        Console.WriteLine("西暦を計算します！計算したい年号を入力してください。");
                        Console.WriteLine("選択肢：明治、大正、昭和、平成、令和");
                        string nengo;
                        nengo = Console.ReadLine();

                        while (nengo != "明治" && nengo != "大正" && nengo != "昭和" && nengo != "平成" && nengo != "令和")
                        {
                            Console.WriteLine("計算したい年号を入力してください。");
                            Console.WriteLine("選択肢：明治、大正、昭和、平成、令和");
                            nengo = Console.ReadLine();
                        }
                        Console.WriteLine("計算したいのは" + nengo + "何年かを教えてください。");
                        int num1;
                        num1 = int.Parse(Console.ReadLine());



                        if (nengo == "明治")
                        {
                            int meiji2;
                            meiji2 = 1867 + num1;
                            Console.WriteLine("明治" + num1 + "は、西暦" + meiji2 + "年です！");
                        }
                        else if (nengo == "大正")
                        {
                            int taisyo2;
                            taisyo2 = 1911 + num1;
                            Console.WriteLine("大正" + num1 + "は、西暦" + taisyo2 + "年です！");

                        }
                        else if (nengo == "昭和")
                        {
                            int syowa2;
                            syowa2 = 1925 + num1;
                            Console.WriteLine("昭和" + num1 + "は、西暦" + syowa2 + "年です！");

                        }
                        else if (nengo == "平成")
                        {
                            int heisei2;
                            heisei2 = 1988 + num1;
                            Console.WriteLine("昭和" + num1 + "は、西暦" + heisei2 + "年です！");

                        }
                        else if (nengo == "令和")
                        {
                            int reiwa2;
                            reiwa2 = 2018 + num1;
                            Console.WriteLine("昭和" + num1 + "は、西暦" + reiwa2 + "年です！");

                        }

                    }

                    return;
                }


                

            }
        }
    }
}
