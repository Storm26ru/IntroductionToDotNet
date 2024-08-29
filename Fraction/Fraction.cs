﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        public int Integer { get; set; }
        public int Numerator { get; set; }
        int denominator;
        public int Denominator { get => denominator; set { if (value == 0) value = 1; denominator = value; } }
        public Fraction()
        {
            Denominator = 1;
            Console.WriteLine($"DefConstruction {this.GetHashCode()}");
        }
        public Fraction(int integer)
        {
            Integer = integer;
            Denominator = 1;
            Console.WriteLine($"Constrfction_1 {this.GetHashCode()}");
        }
        public Fraction(int integer, int numerator, int denominator)
        {
            Integer = integer; Numerator = numerator; Denominator = denominator;
            Console.WriteLine($"Construction_3 {this.GetHashCode()}");
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator; Denominator = denominator;
            Console.WriteLine($"Construction_2 {this.GetHashCode()}");
        }
        public Fraction(Fraction other)
        {
            Integer = other.Integer; Numerator = other.Numerator; Denominator = other.Denominator;
        }
        ~Fraction()
        {
            Console.WriteLine($"Destruction {this.GetHashCode()}");
        }
        //Methods
        public void Print()
        {
            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                if (Integer != 0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write("0");
            Console.WriteLine();
        }
        public Fraction ToImproper()
        {
            return new Fraction(Integer * Denominator + Numerator, Denominator);
        }
        public Fraction ToProper()
        {
            return new Fraction(Integer += Numerator / Denominator, Numerator % Denominator, Denominator);
        }
        public Fraction Invert()
        {
            Fraction Invert = ToProper();
            (Invert.Numerator, Invert.Denominator) = (Invert.Denominator, Invert.Numerator);
            return Invert;
        }
        //                    Operators
        public static Fraction operator *(Fraction Left, Fraction Right)

        {
            return new Fraction(Left.ToImproper().Numerator * Right.ToImproper().Numerator, Left.Denominator * Right.Denominator).ToProper();
        }
        public static Fraction operator /(Fraction Left, Fraction Right)
        {
            return Left * Right.Invert();
        }
        public static Fraction operator +(Fraction Left, Fraction Right)
        {
            return new Fraction(Left.ToImproper().Numerator * Right.Denominator + Right.ToImproper().Numerator * Left.Denominator,Left.Denominator*Right.Denominator).ToProper();
        }
        public static Fraction operator - (Fraction Left, Fraction Right)
        {
            return new Fraction(Left.ToImproper().Numerator * Right.Denominator - Right.ToImproper().Numerator * Left.Denominator, Left.Denominator * Right.Denominator).ToProper();
        }
        public static Fraction operator ++(Fraction other)
        {
           return new Fraction(other.Integer+1,other.Numerator,other.Denominator);
        }
        public static Fraction operator -- (Fraction other)
        {
            return new Fraction(other.Integer - 1, other.Numerator, other.Denominator);
        }
    }
}
     