using System;
class program
{
 static void Main(string[] arg){
    string Memeber = Console.ReadLine();
    int slave = int.Parse(Console.ReadLine());
    Tree<string> tree = new Tree<string>();

    tree.AddChild(-1,"root");
    for(int i =0;i<=slave;i++){
      tree.AddChild(slave,Memeber);
      Memeber = Console.ReadLine();
   
      int subslave  = int.Parse(Console.ReadLine());
      for(int j = 0;j>subslave;j++){
         if(subslave<=1)
         {
            tree.AddChild(subslave,Memeber);

         }
         else{
            for(int k = 0;k>subslave;k++){
               Memeber = Console.ReadLine();
    subslave  = int.Parse(Console.ReadLine());
               tree.AddSibling(subslave,Memeber);
            }
         }
      }
    }
   

    }
    
 }   
