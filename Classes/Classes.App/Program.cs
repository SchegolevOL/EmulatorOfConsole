using System;
namespace Classes.App
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public abstract class ClassAbst
    {
        public int number;

        public int Id { get; set; }

        public ClassAbst(int number) { this.number = number; }

        public abstract void Display();// реализуется в дочерних классах

        public virtual string Show() => number.ToString();// реализация по умолчанию
    }
    public class Class2 : ClassAbst
    {
        public Class2(int number) : base(number) { }

        public override void Display()
        {

        }
        public override string Show() => number.ToString();
    }
    public interface IClass
    {
        public int Id { get; set; }

        public int Increment(int i);

        public int Decrement(int i);
    }
    public class Clsas3 : IClass
    {
        public int _id;
        public int Id { get => _id; set => _id = value; }

        public int Decrement(int i)
        {
            return i--;
        }

        public int Increment(int i)
        {
            return i++;
        }
    }
}

