
using System.Diagnostics.CodeAnalysis;

namespace EmojiLibrary
{
    public class IdNumber
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public IdNumber(int number)
        {
            this.number = number;
        }
        public override string ToString()
        {
            return number.ToString(); 
        }
        public override bool Equals(object? obj)
        {
            if (obj is IdNumber n)
                return this.number == n.number;
            return false;
        }
    }
    public class Emoji : IInit, IComparable, ICloneable
    {
        protected Random rnd = new Random();

        private string name;
        private string tag;

        static string[] Names = { "Улыбка", "Сияющий", "Задумчивый", "Привет", "Праздник", "Ура", "Работа", "Инструменты", "Искусство", "Настройки", "Ракета" };
        static string[] Tags = { "<smile>", "<happy>", "<thinking>", "<wave>", "<celebrate>", "<hooray>", "<work>", "<tools>", "<art>", "<settings>", "<rocket>" };
        public IdNumber Id;
        public string Name { get; set; }
        public string Tag { get; set; }

        public Emoji()
        {
            Name = "NoName";
            Tag = "<NoTag>";
            Id = new IdNumber(1);
        }
        public Emoji(string name, string tag, int number)
        {
            Id = new IdNumber(number >= 0 ? number : 0);
            Name = name;
            Tag = tag;
        }

        public virtual void Init()
        {
            Console.Write("Введите id: ");
            Id.Number = IO.InputValidNumber(0, 1000);
            Console.Write("Введите название: ");
            Name = Console.ReadLine();
            Console.Write("Введите тэг: ");
            Tag = Console.ReadLine();
        }

        public virtual void RandomInit()
        {
            Id.Number = rnd.Next(0, 1000);
            Name = Names[rnd.Next(Names.Length)];
            Tag = Tags[rnd.Next(Tags.Length)];
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Emoji e)
                return this.Name == e.Name && this.Tag == e.Tag && this.Id.Number == e.Id.Number;
            return false;
        }

        public override string ToString()
        {
            return Id + ": " + Name + ", " + Tag;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Эмодзи {Id}: Название = {Name}, тэг = {Tag}");
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return -1;
            if (obj is not Emoji) return -1;
            Emoji e = obj as Emoji;
            return String.Compare(this.Name, e.Name);
        }

        public object Clone()
        {
            return new Emoji(Name, Tag, Id.Number);
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}