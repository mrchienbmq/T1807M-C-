using System;
using System.Collections.Generic;

namespace Session{
  class Session1
   {
      public static void Main(String[] args)
      {
          /*Console.WriteLine("Hello C#");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("x ="+x);
          
          int y =Int32.Parse(Console.ReadLine());
          Console.WriteLine("y ="+y);
          
          for (int i = 0; i < 10; i++)
          {
              Console.WriteLine("I = "+i);
          }
          SessionDemo2 sd = new SessionDemo2(1,"chien");
          List<String> str = new List<string>();
          str.Add("haha");
          str.Add("hehe");
          Console.WriteLine(str[0]);

          foreach (String s in str)
          {
              Console.WriteLine(s);
              
          }
          List<int> ints = new List<int>();
          ints.Add(21);
          Console.WriteLine(ints[0]++);*/
          
          SessionDemo2 ss2 = new SessionDemo2();
          /*SessionDemo2 ss3 = new SessionDemo2(18,"chien");*/
          ss2.setInfo();
          ss2.ShowInfo();
      }
    
   }

    public  class SessionDemo2
      {
          public int age;
          public String name;

          public SessionDemo2()
          {
              
          }
          public SessionDemo2(int age, string name)
          {
              this.age = age;
              this.name = name;
          }

          public int Age {
              get
              {
                  return Age;
                  
              }
              set
              {
                  age = value;
              }
          }

          public string Name
          {
              get => name;
              set => name = value;
          }

          public virtual void ShowInfo()
          {
             this.setInfo();
              
          }

          public void setInfo()
          {
              this.Name = Convert.ToString(Console.WriteLine());
          }
      }

    class  SessionDemo3 : SessionDemo2,DemoInterface
    {
        public override void ShowInfo()
        {
            
        }


        
    }

    interface DemoInterface
    {
        
    }

}