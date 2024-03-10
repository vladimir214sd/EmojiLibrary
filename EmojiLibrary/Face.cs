using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmojiLibrary;
using System.Xml.Linq;

namespace EmojiLibrary
{
    public class Face : Emoji
    {
        static string[] Expressions = { ":-)", "^_^", ":-|", "\\o/", "\\o\\", "XD", "<3", ":-D", ":*", "O_o", ":-P", ":-)" };

        public Face() : base()
        {
            Power = 0;
            Expression = ":)";

        }
        public Face(string name, string tag, int number, double power, string expression) : base(name, tag, number)
        {
            Power = power;
            Expression = expression;
        }


        protected double power;
        protected string expression;

        public string Expression { get; set; }
        public double Power
        {
            get => power;
            set
            {
                if (value < 0)
                    power = 0;
                else if (value > 10)
                    power = 10;
                else
                    power = value;
            }
        }

        public override void Init()
        {
            base.Init();
            Console.Write("Введите описание символами: ");
            Expression = Console.ReadLine();
            Console.Write("Введите силу эмодзи(от 0 до 10): ");
            Power = IO.InputValidNumber(0, 10);

        }
        public override void RandomInit()
        {
            base.RandomInit();
            Expression = Expressions[rnd.Next(Expressions.Length)];
            Power = rnd.Next(0, 11);
        }
        public override bool Equals(object obj)
        {
            Face f = obj as Face;
            if (f != null)
                return f.Name == this.Name
                    && f.Tag == this.Tag
                    && f.Id.Number == this.Id.Number
                    && f.Power == this.Power
                    && f.Expression == this.Expression;
            else
                return false;
        }
        public override string ToString()
        {
            return Id + ": " + Name + ", " + Tag + ", " + Power + ", " + Expression;
        }

        public override void Show()
        {
            Console.WriteLine($"Лицевое эмодзи {Id}: Название = {Name}, тэг = {Tag}, сила эмодзи = {Power}, описание символами = {Expression}");
        }
        public object Clone()
        {
            return new Face(Name, Tag, Id.Number, Power, Expression);
        }
    }
}
