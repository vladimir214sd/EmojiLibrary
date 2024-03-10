using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmojiLibrary;
using System.Xml.Linq;

namespace EmojiLibrary
{
    public class Animal : Emoji
    {
        protected string partOfBody;
        static string[] BodyParts = { "Голова", "Шея", "Плечо", "Рука", "Грудь", "Живот", "Спина", "Нога", "Стопа", "Палец", "Колено" };

        public Animal() : base()
        {
            PartOfBody = "NoPart";

        }
        public Animal(string name, string tag, int number, string partOfBody) : base(name, tag, number)
        {
            PartOfBody = partOfBody;
        }


        public string PartOfBody { get; set; }



        public override void Init()
        {
            base.Init();
            Console.Write("Введите часть тела: ");
            PartOfBody = Console.ReadLine();
        }
        public override void RandomInit()
        {
            base.RandomInit();
            PartOfBody = BodyParts[rnd.Next(BodyParts.Length)];
        }
        public override bool Equals(object obj)
        {
            Animal f = obj as Animal;
            if (f != null)
                return f.Name == this.Name
                    && f.Tag == this.Tag
                    && f.Id.Number == this.Id.Number
                    && f.PartOfBody == this.PartOfBody;

            else
                return false;
        }
        public override string ToString()
        {
            return Id + ": " + Name + ", " + Tag + ", " + PartOfBody;
        }

        public override void Show()
        {
            Console.WriteLine($"Животное эмодзи {Id}: Название = {Name}, тэг = {Tag}, часть тела = {PartOfBody}");
        }
        public object Clone()
        {
            return new Animal(Name, Tag, Id.Number, PartOfBody);
        }
    }
}
