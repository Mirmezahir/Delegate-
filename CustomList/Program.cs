namespace CustomList
{
    
    internal class Program
    {
        static void Main(string[] args)
        {


           Customlist<string> customlist = new Customlist<string>();
            customlist.Add("a");
            customlist.Add("b");    
            customlist.Add("c");
            customlist.Add("d");
            customlist.Add("e");
            customlist.Add("f");                
            customlist.Add("g");     
            customlist.Add("h");
              
          



            Console.WriteLine(customlist.length);
            for (int i = 0;i<customlist.length;i++)
            {
                Console.WriteLine(customlist[i]);  
            }
         

         
        }

                   
    }
}
