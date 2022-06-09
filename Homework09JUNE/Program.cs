using System;

namespace Homework09JUNE
{
    class Program
    {
        static void Main(string[] args)
        {


            Library library = new Library();
            string answer;

            do
            { 
                Console.WriteLine("1. Kitab elave et...");
                Console.WriteLine("2. Journal elave ele...");
                Console.WriteLine("3. Productlara bax...");
                Console.WriteLine("4. Limiti deyis...");
                Console.WriteLine("5. Menudan cix...");
                

                do
                {
                    answer = Console.ReadLine();

                } while ((answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "5") || answer == null);

            
                switch (answer)
                {
                    case "1":
                        if (library.Products.Length < library.ProductLimit)
                        {
                            Console.Write("Kitabin adini daxil ele ... ");
                            string bookname = Console.ReadLine();
                            Console.Write("Kitabin janrini daxil ele ... ");
                            string bookgenre = Console.ReadLine();
                            Console.Write("Kitabin authorunu daxil ele ... ");
                            string bookauthor = Console.ReadLine();
                            if (bookname != null && bookgenre !=null && bookauthor != null )
                            {
                                Book bookAdded = new Book()
                                {
                                    Name = bookname,
                                    Genre = bookgenre,
                                    Author = bookauthor
                                };

                                library.AddProduct(bookAdded);

                                Console.WriteLine("Kitab elave olundu.....");
                            }
                            else
                            {
                                goto case "1";
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Product limitine catmisiniz...");
                        }
                        break;

                    case "2":
                        if (library.Products.Length < library.ProductLimit)
                        {
                            Console.Write("Jurnalin adini daxil ele ... ");
                            string journalname = Console.ReadLine();
                            Console.Write("Jurnalin companysini daxil ele ... ");
                            string journalcompany = Console.ReadLine();
                            if (journalname != null && journalcompany != null)
                            {
                                Journal journalAdded = new Journal()
                                {
                                    Name = journalname,
                                    Company = journalcompany

                                };

                                library.AddProduct(journalAdded);

                                Console.WriteLine("Jurnal elave olundu.....");
                            }
                            else
                            {
                                goto case "2";
                            }

                            
                        }
                        else
                        {
                            Console.WriteLine("Product limitine catmisiniz...");
                        }
                        break;

                    case "3":
                        Console.Write("Hansina baxmaq isteyirsen jurnallar yoxsa kitablar (jurnal ya da kitab yaz)..");
                        string answerType = Console.ReadLine().ToUpper();
                        if (answerType == "KITAB")
                        {
                            foreach (Book item in library.Products)
                            {
                                if (item is Book)
                                {
                                    Console.WriteLine($"Kitabin adi: {item.Name}, {item.Author} , {item.Genre}");
                                }
                            }
                        } else if(answerType == "JURNAL")
                        {
                            foreach (Journal item in library.Products)
                            {
                                if (item is Journal)
                                {
                                    Console.WriteLine($"Jurnalin adi: {item.Name}, {item.Company}");
                                }
                            }
                        }
                        else
                        {
                            goto case "3";
                        }
                        break;

                    case "4":
                        Console.WriteLine($"Bu deq olan product limiti : {library.ProductLimit}");
                        Console.Write("Limiti neecye deyismek isteyirsen??");
                        int newLimit = Convert.ToInt32(Console.ReadLine());
                        if (library.Products.Length < newLimit)
                        {
                            library.ProductLimit = newLimit;
                            Console.WriteLine($"limitin {library.ProductLimit} ededine deyisildi");
                        }
                        else
                        {
                            Console.WriteLine("Limitin bu deq olan product siyahindaki product sayindan daha azdi basqa limit yaz...");
                            goto case "4";
                        }
                        break;

                    

                    default:
                        break;
                }


            } while (answer !="5");


            Product product1 = new Journal()
            {
                Name = "Wall Street Journal",
                Company = "Wall Street"

            };

            Product product2 = new Book()
            {
                Name = "Senanin maceralari",
                Genre = "Horror"

            };

            Product product3 = new Journal()
            {
                Name = "NY Times",
                Company = "Wall Street"

            };

            Product product4 = new Book()
            {
                Name = " maceralari",
                Genre = "Horror / Adventure"

            };

             
           
        }
    }
}

