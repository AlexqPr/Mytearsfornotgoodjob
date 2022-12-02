using Newtonsoft.Json;
using System.Diagnostics;



using TestForWriting;

namespace Длятестов
{
    internal class Program
    {
        static string symvol;
        static int newresult;
        static List<Person> records = new List<Person>();
        static Person Polz = new Person();
        static List<Person> result = new List<Person>();
        static long newsw;
        static long b = 0;
        static string pyt = "C:\\Users\\User\\Desktop\\Records.json";

        static void Main()
        {
            //Проблема №1: я в инете не нашел как обозначаются клавиши, которые у меня в case закоменнчены(не снижайте балл плз за этот пункт) просто for real хз как найти эти клавиши
            //Проблема №2: я поставил ограничение на 10 секунд, так как если курсор уйдет за поле экрана, то мой SetCursorPosition на 203 строке выдадет ошибку
            //а вот как решить проблему №2 я не понял, долго думал, даже пытался изменить Console.SetBufferSize но все плачевно (0_0) обидно

            b = 0;
            Console.Clear();

            if(File.Exists(pyt))
            {
                Console.WriteLine("Ваши рекорды:" );
                ReadJson(pyt);
            }
            

            Console.WriteLine("Введите ваше имя:");
            Polz.Name = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Как только вы будете готовы нажмите Enter");
            ConsoleKeyInfo key2 = Console.ReadKey();
            while(key2.Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("Как только вы будете готовы нажмите Enter");
                key2 = Console.ReadKey();
            }

           
            Console.Clear();
            string[] text = new string[] { "Этот выбор мы делаем уже в детстве, когда выбираем друзей, учимся строить отношения с ровесниками, играть. Но большинство важнейших решений, определяющих жизненный путь, мы всё-таки принимаем в юности. Как считают учёные, вторая половина второго десятилетия жизни – самый ответственный период. Именно в это время человек, как правило, выбирает самое главное и на всю жизнь: ближайшего друга, круг основных интересов, профессию. Понятно, что такой выбор – дело ответственное. От него невозможно отмахнуться, его нельзя отложить на потом. Не стоит надеяться, что ошибку после можно будет исправить: успеется, вся жизнь впереди! Что-то, конечно, удастся подправить, изменить, но далеко не всё. И неверные решения без последствий не останутся. Ведь успех приходит к тем, кто знает, чего он хочет, решительно делает выбор, верит в себя и упорно достигает намеченных целей." };
            string[] text2 = new string[] { "Всё дальше уходит Великая Отечественная война в прошлое, но память о ней жива в сердцах и душах людей. В самом деле, как можно забыть наш беспримерный подвиг, наши невосполнимые жертвы, принесённые во имя победы над самым коварным и жестоким врагом – фашизмом. Четыре военных года по тяжести пережитого не могут сравниться ни с какими другими годами нашей истории. Важнейшей чертой минувшей войны был её всенародный характер, когда за общее дело на фронте, в тылу, в партизанских отрядах боролись все: от мала до велика. Пусть не все рисковали в одинаковой степени, но отдавали себя без остатка, свой опыт и труд во имя грядущей победы, которая досталась нам очень дорогой ценой. Но память человека со временем ослабевает, из нее по крупицам уходит сначала второстепенное, менее значимое и яркое, а затем и существенное. К тому же все меньше становится ветеранов, тех, кто прошел войну и мог бы рассказать о ней. Если в документах и произведениях искусства не будут отражены самопожертвование и стойкость народа, то горький опыт прошлых лет забудется. А этого нельзя допустить. Тема Великой Отечественной войны на протяжении десятилетий питает литературу и искусство. О жизни человека на войне снято немало прекрасных фильмов, созданы замечательные произведения литературы. И тут нет какой-либо преднамеренности, есть боль, не покидающая душу народа, который потерял за годы войны миллионы человеческих жизней. Но самым главным в разговоре на эту тему является сохранение меры и такта в отношении к правде войны, к ее участникам." };
            string[] text3 = new string[] { "Польза чтения книг очевидна. Книги расширяют кругозор человека, обогащают его внутренний мир, делают умнее. А ещё важно читать книги потому, что это увеличивает словарный запас человека, вырабатывает чёткое и ясное мышление. Убедиться в этом каждый может на собственном примере. Стоит только вдумчиво прочесть какое-нибудь классическое произведение, и вы заметите, как стало проще с помощью речи выражать собственные мысли, подбирать нужные слова. Читающий человек грамотнее говорит. Чтение серьёзных произведений заставляет нас постоянно думать, оно развивает логическое мышление. Не верите? А вы прочитайте что-нибудь из классики детективного жанра, например, Приключения Шерлока Холмса Конан Дойла. После прочтения вы будете соображать быстрее, ваш ум станет острее и вы поймёте, что читать полезно и выгодно." };
            Random rnd = new Random();
            int vibor = rnd.Next(1, 4);
        
            bool result;

            Thread thread = new Thread(new ThreadStart(Timer));




           
                switch (vibor)
                {
                    case 1:
                        foreach (string s in text)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 2:
                        foreach (string s in text2)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 3:
                        foreach (string s in text3)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                }

            Console.SetCursorPosition(0, 0);

                switch (vibor)
                {
                    case 1:
                        symvol = text[0];
                        break;
                    case 2:
                        symvol = text2[0];
                        break;
                    case 3:
                        symvol = text3[0];
                        break;
                }
                thread.Start();
                while (newsw != 10)
                {
                  

                for (b = 0; b < symvol.Length; b++)
                    {
                    
                        if(newsw == 10)
                        {
                      
                         Zapiz();
                        
                        }
                        ConsoleKeyInfo key = Console.ReadKey(true); //из-за этого true у нас не отображаются вводимые символы 
                        result = Proverka(char.ToLower(symvol[(int)b]), key); // char.ToLower - опускает все символы в нижний регистр
                        if (result == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(symvol[(int)b]);
                        }
                      

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(symvol[(int)b]);
                        }

                      

                    }
               

                }
            


        
        













            




        }
        static void  Zapiz()
        { 
           
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.ResetColor();
           
            Polz.Average = newresult/60;
            Polz.Amount = newresult;
            records.Add(Polz);
            JSON(pyt);
            Console.WriteLine("Ваш результат запаисан:");
            Console.WriteLine("Ваше имя:" + Polz.Name + "\nВаш результат символов в секунду: " + (Polz.Average / 60) + "\nВаш результат символов в минуту: " + Polz.Amount );
            Console.WriteLine("Если хотите пройти тест заново, то нажмите на Пробел, если хотите выйти нажмите любую клавишу");
            ConsoleKeyInfo key = Console.ReadKey();
           
             
                if(key.Key == ConsoleKey.Spacebar)
                {
                    Main();
                }
                else
                {
                    Environment.Exit(0);
                }
              
              
               
            
         
            
        }

        static void Timer()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while ((sw.ElapsedMilliseconds/1000) != 11)
            {
                Console.ResetColor();
                newsw = sw.ElapsedMilliseconds/1000;
                
                Console.SetCursorPosition(0, 15);
                Console.WriteLine("Осталось:" + (60 - (sw.ElapsedMilliseconds / 1000)));


                Console.SetCursorPosition((int)b, 0);
                

                Thread.Sleep(100);
            }
            sw.Stop();
            
        }



        static bool Proverka(char a, ConsoleKeyInfo key)
        {
            switch (a)
            {
                case ' ':
                    if(key.Key == ConsoleKey.Spacebar)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'а':
                    if (key.Key == ConsoleKey.F)
                    {
                        newresult++;
                        return true;

                    }
                    break;
                //case 'б':                                //не знаю  что это за клавиша в ConsoleKey
                //    if (key.Key == ConsoleKey.)
                //    {
                //        newresult++;
                //        return true;
                //    }
                //    break;
                case 'в':
                    if (key.Key == ConsoleKey.D)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'г':
                    if (key.Key == ConsoleKey.U)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'д':
                    if (key.Key == ConsoleKey.L)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'е':
                    if (key.Key == ConsoleKey.T)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'ё':
                    if (key.Key == ConsoleKey.T)
                    {
                        newresult++;
                        return true;
                    }
                    break;

                //case 'ж':                               //не знаю  что это за клавиша в ConsoleKey
                //    if (key.Key == ConsoleKey.)
                //    {
                //        newresult++;
                //        return true;
                //    }
                //    break;
                case 'з':
                    if (key.Key == ConsoleKey.P)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'и':
                    if (key.Key == ConsoleKey.B)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'й':
                    if (key.Key == ConsoleKey.Q)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'к':
                    if (key.Key == ConsoleKey.R)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'л':
                    if (key.Key == ConsoleKey.K)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'м':
                    if (key.Key == ConsoleKey.V)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'н':
                    if (key.Key == ConsoleKey.Y)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'о':
                    if (key.Key == ConsoleKey.J)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'п':
                    if (key.Key == ConsoleKey.G)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'р':
                    if (key.Key == ConsoleKey.H)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'с':
                    if (key.Key == ConsoleKey.C)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'т':
                    if (key.Key == ConsoleKey.N)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'у':
                    if (key.Key == ConsoleKey.E)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'ф':
                    if (key.Key == ConsoleKey.A)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                //case 'х':                               //не знаю  что это за клавиша в ConsoleKey
                //    if (key.Key == ConsoleKey.)
                //    {
                //        newresult++;
                //        return true;
                //    }
                //    break;
                case 'ц':
                    if (key.Key == ConsoleKey.W)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'ч':
                    if (key.Key == ConsoleKey.X)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'ш':
                    if (key.Key == ConsoleKey.I)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'щ':
                    if (key.Key == ConsoleKey.O)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                //case 'ъ':                                         //не знаю  что это за клавиша в ConsoleKey
                //    if (key.Key == ConsoleKey.)
                //    {
                //        newresult++;
                //        return true;
                //    }
                //    break;
                case 'ы':
                    if (key.Key == ConsoleKey.S)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                case 'ь':
                    if (key.Key == ConsoleKey.M)
                    {
                        newresult++;
                        return true;
                    }
                    break;
                //case 'э':                                             //не знаю  что это за клавиша в ConsoleKey
                //    if (key.Key == ConsoleKey.)
                //    {
                //        newresult++;
                //        return true;
                //    }
                //    break;
                //case 'ю':
                //    if (key.Key == ConsoleKey.)
                //    {
                //        newresult++;
                //        return true;
                //    }
                //    break;
                case 'я':
                    if (key.Key == ConsoleKey.Z)
                    {
                        newresult++;
                        return true;
                    }
                    break;
            }
            return false;
        }


        static void JSON(string pyt) //запись рекордов в файл на рабочем столе
        {
            string json = JsonConvert.SerializeObject(records);
            if (File.Exists(pyt))
            {
                File.AppendAllText(pyt, json);
            }
            else
            {
                File.WriteAllText(pyt, "");
                File.AppendAllText(pyt, json);
            }
        }

        static void ReadJson(string pyt) //метод для чтения файла Json
        {
            if (File.Exists(pyt))
            {
                string text = File.ReadAllText(pyt);
                result = JsonConvert.DeserializeObject<List<Person>>(text);
                foreach (Person s in result)
                {
                    Console.WriteLine("Имя:"  + s.Name);
                    Console.WriteLine("Количество символов в секунду" +  s.Average);
                    Console.WriteLine("Количество символов в минуту" + s.Amount);
                }
            }
            else
            {
                Console.WriteLine("Таблица рекордов пустая(");
            }
        }
    }
}