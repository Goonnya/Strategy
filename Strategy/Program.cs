using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialNetwork1 fb = new SocialNetwork1(4, "Facebook", new Send_Meassage());
            SocialNetwork2 vk = new SocialNetwork2(4, "VKontakte", new Send_Meassage());
            fb.Do();
            fb.istrategy = new Post();
            fb.Do();

            vk.Do();
            vk.istrategy = new Post();
            vk.Do();

            Console.ReadLine();
        }
    }
    interface Istrategy
    {
        void Do();
    }

    class Send_Meassage : Istrategy
    {
        public void Do()
        {
            Console.WriteLine("Отправить сообщение");
        }
    }

    class Post : Istrategy
    {
        public void Do()
        {
            Console.WriteLine("Сделать пост");
        }
    }
    class SocialNetwork1
    {
        protected int Friends; // кол-во друзей
        protected string Name; // имя владельца странички

        public SocialNetwork1(int num, string name, Istrategy strat)
        {
            this.Friends = num;
            this.Name = name;
            istrategy = strat;
        }
        public Istrategy istrategy { private get; set; }
        public void Do()
        {
            istrategy.Do();
        }
    }
    class SocialNetwork2
    {
        protected int Friends; // кол-во друзей
        protected string Name; // имя владельца странички

        public SocialNetwork2(int num, string name, Istrategy strat)
        {
            this.Friends = num;
            this.Name = name;
            istrategy = strat;
        }
        public Istrategy istrategy { private get; set; }
        public void Do()
        {
            istrategy.Do();
        }
    }
}
