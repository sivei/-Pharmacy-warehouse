using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мед_склад
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов методов класса по именам
            Obrabotka a = new Obrabotka();
            Product pro = new Product();
            Provider pos = new Provider();
            Buyer by = new Buyer();
            Documents doc = new Documents();
            Seller sel = new Seller();

            pro.recGoodsID();
            pro.recNameGoods();
            pro.recInternationalName();
            pro.recBegin();
            pro.recEnd();
            pro.recYesMinzdrav();
            pro.recRF();
            pro.recProducer();
            pro.recBatch();
            pro.recDatePostavki();
            pro.recPrice();

            pos.recSeller();
            pos.recAddresS();
            pos.recPhonE();
            pos.recINNPost();

            by.recClient();
            by.recCompany();
            by.recAddress();
            by.recPhone();
            by.recINN();

            doc.recGoodsInvoice();
            doc.recCountNomber();
            doc.recDateStart();
            doc.recCash();
            doc.recWorker();
            doc.recInvoice();

            sel.recLastName();

            //Объявляем переменные, которые используются при                         		  
            //построение таблицы. 
            //Значения берутся из переменных полученных при 		       
            //вызове методов других классов

            ulong GID = pro.GID;
            string NG = pro.NG;
            string IN = pro.IN;
            DateTime Begin = pro.Begin;
            DateTime End = pro.End;
            string YM = pro.YM;
            ulong RF = pro.RF;
            string Pro = pro.Pro;
            string Bat = pro.Bat;
            DateTime DP = pro.DP;
            decimal Pri = pro.Pri;
            string F = pro.F;

            string Sel = pos.Sel;
            string AS = pos.AS;
            ulong PE = pos.PE;
            ulong INNP = pos.INNP;

            ulong CID = by.CID;
            string Com = by.Com;
            string Add = by.Add;
            ulong Ph = by.Ph;
            ulong INN = by.INN;

            ulong GI = doc.GI;
            ulong CN = doc.CN;
            DateTime DS = doc.DS;
            decimal SumA = pro.SumA;
            string Cash = doc.Cash;
            string Wo = doc.Wo;
            ulong Inv = doc.Inv;
            string U = pro.U;


        string LN = sel.LN;

            Console.WriteLine("");
            Console.WriteLine("");
            int j = 1;
            for (int i = 1; i < 138; i++)
            {
                if (i == 1)
                    Console.Write(" ");
                else
                    Console.Write("_");
            }
            Console.WriteLine("");
            Console.WriteLine("|{0,90}{1,47}", "Выходная наклодная ведомость", "|");
            for (int i = 0; i < 138; i++)
            {
                if (i == 137 || i == 0)
                    Console.Write("|");
                else
                    Console.Write("_");
            }
            Console.WriteLine("");
            Console.WriteLine("| № |   Наименование              {0,5}   Значение{0,88}", "|");
            a.Podch();
            //Заполняем по столбцам номер строки, название переменных и их значения
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,12}{5,0}{6,89}", "|", j++, "|", "Регистрационный номер ", "|", GID, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,18}{5,0}{6,79}", "|", j++, "|", "Название товара ", "|", NG, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,01}{5,0}{6,79}", "|", j++, "|", "Международное название лекарства ", "|", IN, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,16}{5,0}{6,89}", "|", j++, "|", "Дата производства ", "|", Begin.ToString("d"), "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,25}{5,0}{6,89}", "|", j++, "|", "Годен до ", "|", End.ToString("d"), "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,11}{5,0}{6,97}", "|", j++, "|", "Одобрено Минздравом РФ ", "|", YM, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,00}{5,0}{6,79}", "|", j++, "|", "Регистрационный номер Минздрава  ", "|", RF, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,11}{5,0}{6,39}", "|", j++, "|", "Данные о производителе ", "|", Pro, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,20}{5,0}{6,79}", "|", j++, "|", "Вид упаковки  ", "|", Bat, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,7}{5,0}{6,89}", "|", j++, "|", "Дата поступления на склад  ", "|", DP.ToString("d"), "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,22}{5,0} руб.{6,0}{7,78}", "|", j++, "|", "Цена товара ", " |", Pri,F, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,14}{5,0}{6,79}", "|", j++, "|", "Название поставщика ", " |", Sel, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,17}{5,0}{6,74}", "|", j++, "|", "Адрес поставщика ", " |", AS, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,15}{5,0}{6,86}", "|", j++, "|", "Телефон поставщика ", " |", PE, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,19}{5,0}{6,89}", "|", j++, "|", "ИНН поставщика ", " |", INNP, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,17}{5,0}{6,94}", "|", j++, "|", "Номер покупателя ", " |", CID, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,14}{5,0}{6,74}", "|", j++, "|", "Название покупателя ", " |", Com, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,17}{5,0}{6,39}", "|", j++, "|", "Адрес покупателя ", " |", Add, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,15}{5,0}{6,86}", "|", j++, "|", "Телефон покупателя ", " |", Ph, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,19}{5,0}{6,89}", "|", j++, "|", "ИНН покупателя ", " |", INN, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,07}{5,0}{6,95}", "|", j++, "|", "Номер приходной накладной  ", " |", GI, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,15}{5,0}{6,95} ", "|", j++, "|", "Номер счет-фактуры ", " |", CN, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,8}{5,0}{6,89} ", "|", j++, "|", "Дата выписки счет-фактуры ", " |", DS.ToString("d"), "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,19}{5,0} руб.{6,0}{7,78}", "|", j++, "|", "Сумма к уплате ", " |", SumA,U, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,28}{5,0}{6,91}", "|", j++, "|", "Оплата", " |", Cash, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,12}{5,0}{6,39}", "|", j++, "|", "Выдавший счет-фактуру ", " |", Wo, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,09}{5,0}{6,95}", "|", j++, "|", "Номер выходной накладной ", " |", Inv, "|");
            a.Podch();
            Console.WriteLine("{0,0}{1,2}{2,2}{3,0}{4,18}{5,0}{6,84}", "|", j++, "|", "Фамилия продавца", "|", LN, "|");
            a.Podch();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadKey();





        }
    }
    class Product
    {
        //Объявляем public переменные, которые будут использоваться в классе Program
        public ulong GID;
        public string NG;
        public string IN;
        public DateTime Begin;
        public DateTime End;
        public string YM;
        public ulong RF;
        public string Pro;
        public string Bat;
        public DateTime DP;
        public decimal Pri;
        public decimal SumA;
        public string F = " ";
        public string U = " ";

        Obrabotka a = new Obrabotka();


        public void recGoodsID()
        {
            //Задаём входные переменные для методов класса 	Obrabotka
            GID = a.Strog_InOut2("номер товара ", 10);
             Console.WriteLine();
        }
        public void recNameGoods()
        {
            //Если переменная меньше указанного значения, то мы 		  
            //добавляем пустые символы, чтобы увеличить длину 	  		 
            //этой переменной
            NG = a.InOut("Название товара ", 20);
            while (NG.Length != 20)
            {
                NG = NG + " ";
            }
            Console.WriteLine();
        }
        public void recInternationalName()
        {
            IN = a.InOut("Международное название лекарства ", 20);
            while (IN.Length != 20)
            {
                IN = IN + " ";
            }
            Console.WriteLine();

        }
        public void recBegin()
        {
            Begin = a.Date_InOut("Дата производства");
            Console.WriteLine();
        }
        public void recEnd()
        {   
            End = a.Date_InOut2("годен до");
            Console.WriteLine();
        }
        public void recYesMinzdrav()
        {
            Start:
            Console.WriteLine("Этот тавар одобрен Минздравом?");

            Console.WriteLine("'да' либо 'нет'");
            switch (Console.ReadLine())
            {
                case ("да"): YM = "да"; break;
                case ("нет"): YM = "Если товар не одобрен Минздравом,то вы не можете его продовать"; goto Start;
                default:goto Start;
            }
        }
        public void recRF()
        {
            RF = a.Strog_InOut2("номер  Минздрава РФ ", 20);
            Console.WriteLine();
        }
        public void recProducer()
        {
            Pro = a.InOut("Название производителя", 60);
            while (Pro.Length != 60)
            {
                Pro = Pro + " ";
            }
            Console.WriteLine();
        }
        public void recBatch()
        {
            Bat = a.InOut("Вид упаковки", 20);
            while (Bat.Length != 20)
            {
                Bat = Bat + " ";
            }
            Console.WriteLine();
        }
        public void recDatePostavki()
        {
            DP = a.Date_InOut3("Дату поставки");
            Console.WriteLine();
        }
        public void recPrice()
        {
         //Если decimal переменная меньше указанного 				 
         //значения, то мы увеличиваем значение string 				  
         //переменной на длину,
         //равную разнице между указанного значения и 				  
         //реального значения decimal переменной
            Pri = (decimal)a.Decim_InOut("Цену товара", 15);
            string L = Convert.ToString(Pri);
            while (L.Length != 15)
            {
                F = F + " ";
                L = L + " ";
            }
            double P = (double)Pri * 1;
            SumA = (decimal)P;
             L = Convert.ToString(SumA);
            while (L.Length != 15)
            {
                U = U + " ";
                L = L + " ";
            }
            Console.WriteLine();
        }
    }
    class Provider
    {
        //Объявляем public переменные, которые будут  	 			  
        //использоваться в классе Program
        public string Sel;
        public string AS;
        public ulong PE;
        public ulong INNP;

        Obrabotka a = new Obrabotka();
        public void recSeller()
        {
            Sel = a.InOut("Название поставщика", 20);
            while (Sel.Length != 20)
            {
                Sel = Sel + " ";
            }
            Console.WriteLine();
        }
        public void recAddresS()
        {
            //Если переменная меньше указанного значения, то мы 		 
            //добавляем пустые символы, чтобы увеличить длину 			  
            //этой переменной
            AS = a.InOut("Адрес поставщика", 25);
            while (AS.Length != 25)
            {
                AS = AS + " ";
            }
            Console.WriteLine();
        }
        public void recPhonE()
        {
            PE = a.Strog_InOut2("Телефон поставщика", 13);
            Console.WriteLine();
        }
        public void recINNPost()
        {
            INNP = a.Strog_InOut2("ИНН поставщика ", 10);
            Console.WriteLine();
        }
    }
    class Buyer
    {
        //Объявляем public переменные, которые будут 			  	   
        //использоваться в классе Program
        public ulong CID;
        public string Com;
        public string Add;
        public ulong Ph;
        public ulong INN;

        Obrabotka a = new Obrabotka();
        public void recClient()
        {
            CID = a.Strog_InOut2("Индетефикационный номер покупателя", 5);
            Console.WriteLine();

        }
        public void recCompany()
        {
            Com = a.InOut("Название покупателя", 25);
            while (Com.Length != 25)
            {
                Com = Com + " ";
            }
            Console.WriteLine();
        }
        public void recAddress()
        {
            //Если переменная меньше указанного значения, то мы 		 
            //добавляем пустые символы, чтобы увеличить длину 			  
            //этой переменной
            Add = a.InOut("Адрес покупателя", 60);
            while (Add.Length != 60)
            {
                Add = Add + " ";
            }
            Console.WriteLine();
        }
        public void recPhone()
        {
            Ph = a.Strog_InOut2("Телефон покупателя", 13);
            Console.WriteLine();
        }
        public void recINN()
        {
            INN = a.Strog_InOut2("ИНН покупателя", 10);
            Console.WriteLine();
        }

    }
    class Documents
    {//Объявляем public переменные, которые будут 				  
        //использоваться в классе Program
        public ulong GI;
        public ulong CN;
        public DateTime DS;
        public string Cash;
        public string Wo;
        public ulong Inv;

        Obrabotka a = new Obrabotka();
        public void recGoodsInvoice()
        {
            GI = a.Strog_InOut2("Номер приходной накладной ведомости ", 4);
            Console.WriteLine();
        }
        public void recCountNomber()
        {
            CN = a.Strog_InOut2("Номер счет-фактуры  ", 4);
            Console.WriteLine();
        }
        public void recDateStart()
        {
            DS = a.Date_InOut("Дата выписки счет-фактуры ");
            Console.WriteLine();
        }
        public void recCash()
        {
            Start:
            Console.WriteLine("Оплата наличными?");

            Console.WriteLine("'да' либо 'нет'");
            switch (Console.ReadLine())
            {
                case ("да"):Cash = "Безналом"; break;
                case ("нет"):Cash = "Безналом"; break;
                default:goto Start;
            }
        }
        public void recWorker()
        {
            Wo = a.InOut("Выдавший счет-фактуру  ", 60);
            while (Wo.Length != 60)
            {
                Wo = Wo + " ";
            }
            Console.WriteLine();
        }
        public void recInvoice()
        {
            Inv = a.Strog_InOut2("Номер выходной накладной  ", 4);
            Console.WriteLine();
        }
    }
    class Seller
    {//Объявляем public переменную, которая будет 		 	 	  
        //использоваться в классе Program
        public string LN;
        Obrabotka a = new Obrabotka();
        public void recLastName()
        {
            LN = a.InOut("Фамилия продовца ", 15);
            while (LN.Length != 15)
            {
                LN = LN + " ";
            }
            Console.WriteLine();
        }
    }
    class Obrabotka
    {   
        //Объявляем public переменные, которые будут 		 	 	   
        //использоваться в классе Product
        public DateTime Begin;
        public DateTime End;
        public DateTime DP;

        public string InOut(string s, int l)
        {
            string obr;
            Start:
            try
            {
                Console.WriteLine("Введите {0}", s);
                Console.WriteLine("{0} должен состоять не больше, чем из {1} символов", s, l);
                obr = Console.ReadLine();
                if (obr.Length > l)
                {
                    Console.WriteLine("Не верно введено {0}", s);
                    goto Start;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Как вы могли ошибиться?");
                Console.WriteLine("Ну ничего страшного попробуйте снова");
                goto Start;
            }
            return obr;
        }
        public ulong Strog_InOut2(string s, int l)
        {
            ulong index;
            Start:
            try
            {
                Console.WriteLine("Введите {0}", s);
                Console.WriteLine("{0} должен состоять только из {1} символов", s, l);
                string obr = Console.ReadLine();
                index = Convert.ToUInt64(obr);
                if (obr.Length != l)
                {
                    Console.WriteLine("Не верно введено {0}", s);
                    goto Start;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не числа или отрицательные числа");
                goto Start;
            }
            return index;
        }
        public decimal Decim_InOut(string s, int l)
        {
            decimal d;
            Start:
            try
            {
                Console.WriteLine("Введите {0}", s);
                Console.WriteLine("{0} не должен превышать {1}-значное число", s, l);
                string obr = Console.ReadLine();
                d = (decimal)Convert.ToDouble(obr);
                if (d < 0)
                {
                    Console.WriteLine("Не бывает отрицательной зарплаты");
                    goto Start;
                }
                if (obr.Length > l)
                {
                    Console.WriteLine("Вы не настолько незаменимый работник");
                    goto Start;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не числа");
                goto Start;
            }
            return d;
        }
        public DateTime Date_InOut(string s)
        {
            int mon;
            int day;
            int year;
            Start:
            Console.WriteLine("Введите {0}", s);
            try
            {
                Start1:
                Console.WriteLine("Введите год из четырёх чисел");
                year = Convert.ToInt32(Console.ReadLine());
                if (year > 9999 || year < 1)
                {
                    Console.WriteLine(" {0} лекарство с токим сроком,скорее убъет чем вылечит", year);
                    goto Start1;
                }
                Start2:
                Console.WriteLine("Введите месяц двумя числами");
                mon = Convert.ToInt32(Console.ReadLine());
                if (mon > 12 || mon < 1)
                {
                    Console.WriteLine("Не бывает {0}-того месяца", mon);
                    goto Start2;
                }
                Start3:
                Console.WriteLine("Введите день двумя числами");
                day = Convert.ToInt32(Console.ReadLine());
                if (day > 31 || mon < 1)
                {
                    Console.WriteLine("Не бывает {0}-того дня", day);
                    goto Start3;
                }
                Begin = new DateTime(year, mon, day);
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не числа");
                goto Start;
            }
            return Begin;
        }
        public DateTime Date_InOut2(string s)
        {
            int mon;
            int day;
            int year;
            Start:
            Console.WriteLine("Введите {0}", s);
            try
            {
                Start1:
                Console.WriteLine("Введите год из четырёх чисел");
                year = Convert.ToInt32(Console.ReadLine());

                if (year > 9999 || year < 1)
                {
                    Console.WriteLine(" {0} лекарство с токим сроком,скорее убъет чем вылечит", year);
                    goto Start1;
                }
                Start2:
                Console.WriteLine("Введите месяц двумя числами");
                mon = Convert.ToInt32(Console.ReadLine());
                if (mon > 12 || mon < 1)
                {
                    Console.WriteLine("Не бывает {0}-того месяца", mon);
                    goto Start2;
                }
                Start3:
                Console.WriteLine("Введите день двумя числами");
                day = Convert.ToInt32(Console.ReadLine());
                if (day > 31 || mon < 1)
                {
                    Console.WriteLine("Не бывает {0}-того дня", day);
                    goto Start3;
                }
                End = new DateTime(year, mon, day);

                if (End.Year - Begin.Year > 20 )
                {
                   Console.WriteLine(" {0} лекарство с токим сроком,скорее убъет чем вылечит", year);
                        goto Start1;
                }
                if(End.Year < Begin.Year)
                {
                    Console.WriteLine(" {0} срок годнасти лекарства не может быть меньше даты производства ", year);
                    goto Start1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не числа");
                goto Start;
            }
            return End;
        }
        public DateTime Date_InOut3(string s)
        {
            int mon;
            int day;
            int year;
            Start:
            Console.WriteLine("Введите {0}", s);
            try
            {
                Start1:
                Console.WriteLine("Введите год из четырёх чисел");
                year = Convert.ToInt32(Console.ReadLine());

                if (year > 9999 || year < 1)
                {
                    Console.WriteLine(" {0} лекарство с токим сроком,скорее убъет чем вылечит", year);
                    goto Start1;
                }
                Start2:
                Console.WriteLine("Введите месяц двумя числами");
                mon = Convert.ToInt32(Console.ReadLine());
                if (mon > 12 || mon < 1)
                {
                    Console.WriteLine("Не бывает {0}-того месяца", mon);
                    goto Start2;
                }
                Start3:
                Console.WriteLine("Введите день двумя числами");
                day = Convert.ToInt32(Console.ReadLine());
                if (day > 31 || mon < 1)
                {
                    Console.WriteLine("Не бывает {0}-того дня", day);
                    goto Start3;
                }
                DP = new DateTime(year, mon, day);

                if (DP.Year >= End.Year)
                {
                    Console.WriteLine(" {0} дата поставки не может быть больше срока годности", year);
                    goto Start1;
                }
                if (DP.Year < Begin.Year)
                {
                    Console.WriteLine(" {0} дата поставки не может быть меньше даты производства ", year);
                    goto Start1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не числа");
                goto Start;
            }
            return DP;
        }
        public void Podch()
        {
            for (int i = 0; i < 138; i++)
            {
                if (i == 137 || i == 0 || i == 4 || i == 38)
                    Console.Write("|");
                else
                Console.Write("_");
            }
            Console.WriteLine("");
        }
    }
}
