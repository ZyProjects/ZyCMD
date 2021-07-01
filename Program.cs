Console.WriteLine("Welcome " + Environment.UserName + "!\n");
            System.Threading.Thread.Sleep(1);
            while (true)
            {
                var answer = Console.ReadLine();
                var loweredancher = answer.ToLower();
                if (loweredancher == "shutdown")
                {
                    System.Diagnostics.Process.Start("shutdown", "/s 0");
                    Console.Write("\n");

                }

                if (loweredancher == "restart")
                {
                    System.Diagnostics.Process.Start("shutdown", "/r 0");
                    Console.Write("\n");
                }
                if (loweredancher == "machinename")
                {
                    Console.WriteLine(Environment.MachineName);
                    Console.Write("\n");
                }
                if (loweredancher == "username")
                {
                    Console.WriteLine(Environment.UserName);
                    Console.Write("\n");
                }
                if (loweredancher == "clear")
                {
                    Console.Clear();
                    Console.Write("Welcome " + Environment.UserName + "!\n");
                }
                if (loweredancher == "credits")
                {
                    Console.WriteLine("Made by SnoDev aka Zy on github!");
                    Console.Write("\n");
                }
                if (loweredancher == "version")
                {
                    Console.WriteLine("1.0");
                    Console.Write("\n");
                }
