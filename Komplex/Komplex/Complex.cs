using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komplex
{
    public class IllegalException : Exception { }
    internal class Complex
    {
        private double re;
        private double im;

        public Complex(double re, double im) { 
            this.re = re;
            this.im = im;
        }

        public override string ToString()
        {
            string str = "";
            str += re;
            str += "+";
            str += im;
            str += "i";
            return str;
        }

        public static Complex operator+(Complex c1, Complex c2) {
            Complex c = new Complex(c1.re + c2.re, c1.im + c2.im);
            return c;
        }

        public static Complex operator-(Complex c1, Complex c2) {
            Complex c = new Complex(c1.re - c2.re, c1.im - c2.im);
            return c;
        }
        public static Complex operator*(Complex c1, Complex c2) {
            Complex c = new Complex((c1.re*c2.re) - (c1.im*c2.im), (c1.re*c2.im) + (c1.im*c2.re));
            return c;
        }
        public static Complex operator/(Complex c1, Complex c2) {
            if (c2.re == 0 && c2.im == 0) {
                throw new IllegalException();
            }
            Complex c = new Complex(((c1.re * c2.re)+(c1.im * c2.im))/((c2.re*c2.re)
                +(c2.im*c2.im)),((c1.im*c2.re)-(c1.re*c2.im))/
                ((c2.re * c2.re) +(c2.im * c2.im)));
            return c;
        }
            
    }
}
