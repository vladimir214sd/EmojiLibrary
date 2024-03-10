using System;
using System.Threading;

namespace EmojiLibrary
{
    public class Pokemon : IInit
    {
        private int attack;
        private int defense;
        private int stamina;
        private double combatPower;

        public static int count = 0;

        // Конструктор без параметров
        public Pokemon()
        {
            this.Attack = 17;
            this.Defense = 32;
            this.Stamina = 1;
            count++;
        }

        // Конструктор с параметрами
        public Pokemon(int attack, int defense, int stamina)
        {
            this.Attack = attack;
            this.Defense = defense;
            this.Stamina = stamina;
            count++;
        }

        // Конструктор копирования
        public Pokemon(Pokemon other)
        {
            this.Attack = other.attack;
            this.Defense = other.defense;
            this.Stamina = other.stamina;
            count++;
        }

        // Свойства для доступа к атрибутам
        public int Attack
        {
            get => attack;
            set
            {
                if (value < 17)
                {
                    Console.WriteLine("Ошибка! Значение атаки не может быть меньше 17.");
                    attack = 17;
                }
                else if (value > 414)
                {
                    Console.WriteLine("Ошибка! Значение атаки не может быть больше 414.");
                    attack = 414;
                }
                else
                {
                    attack = value;
                }
            }
        }

        public int Defense
        {
            get => defense;
            set
            {
                if (value < 32)
                {
                    Console.WriteLine("Ошибка! Значение защиты не может быть меньше 32.");
                    defense = 32;
                }
                else if (value > 396)
                {
                    Console.WriteLine("Ошибка! Значение защиты не может быть больше 396.");
                    defense = 396;
                }
                else
                {
                    defense = value;
                }
            }
        }

        public int Stamina
        {
            get => stamina;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Ошибка! Значение выносливости не может быть меньше 1.");
                    stamina = 1;
                }
                else if (value > 496)
                {
                    Console.WriteLine("Ошибка! Значение выносливости не может быть больше 496.");
                    stamina = 496;
                }
                else
                {
                    stamina = value;
                }
            }
        }

        public double CombatPower { get; private set; }


        // Метод для увеличения характеристик покемона
        public Pokemon IncreaseStats(int attack, int defense, int stamina)
        {
            this.attack += attack;
            this.defense += defense;
            this.stamina += stamina;

            return new Pokemon(this.attack, this.defense, this.stamina);
        }

        public static Pokemon IncreaseStats(Pokemon p, int attack, int defense, int stamina)
        {
            p = p.IncreaseStats(attack, defense, stamina);
            return p;
        }

        public void Init()
        {
            this.attack = IO.InputValidNumber(17, 414);
            this.defense = IO.InputValidNumber(32,396);
            this.stamina = IO.InputValidNumber(1,496);
        }
        public void RandomInit()
        {
            Random rnd = new Random();
            this.attack = rnd.Next(17, 414);
            this.defense = rnd.Next(32, 396);
            this.stamina = rnd.Next(1, 496);
        }

        public override string ToString()
        {
            return $"Сила покемонуса равна {Attack}, Защита покемонуса равна {Defense}, Выносливость покемонуса равна {Stamina}";
        }

        public void Show()
        {
            Console.WriteLine($"Сила покемонуса равна {attack}, Защита покемонуса равна {defense}, Выносливость покемонуса равна {stamina}");
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is not Pokemon) return false;
            return ((Pokemon)obj).Attack == this.Attack && ((Pokemon)obj).Defense == this.Defense && ((Pokemon)obj).Stamina == this.Stamina;
        }

        public static Pokemon operator --(Pokemon p)
        {
            p.Stamina--;
            return p;
        }


        public static Pokemon operator ~(Pokemon p)
        {
            p.CombatPower = Math.Round((Math.Sqrt(p.Stamina) * p.Attack * Math.Sqrt(p.Defense)) / 10, 2);

            // Возвращаем Pokemon с установленным CombatPower
            return p;
        }

        public static Pokemon operator >>(Pokemon p, int buff)
        {
            p.Stamina += buff;
            return p;
        }
        public static Pokemon operator >(Pokemon p, int buff)
        {
            p.Defense += buff;
            return p;
        }
        public static Pokemon operator <(Pokemon p, int buff)
        {
            p.Attack += buff;
            return p;
        }



        public static explicit operator int(Pokemon pokemon)
        {
            return pokemon.Attack + pokemon.Defense + pokemon.Stamina;
        }

        public static implicit operator double(Pokemon pokemon)
        {
            double temp = (pokemon.Attack + pokemon.Defense + pokemon.Stamina) / 3.0;
            return Math.Round(temp, 2);
        }

    }
}