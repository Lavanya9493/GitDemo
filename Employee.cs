using System;

namespace Lavanya
{
    class Employee
    {
        int _eno;
        public int Eno
        {
            get{return _eno;}
            set{_eno=value;}
        }
        string _ename;
        public string Ename
        {
            get{return _ename;}
            set{_ename=value;}
        }
        double _esal;
        public double Esal
        {
            get{return _esal;}
            set{_esal=value;}
        }

        public override string ToString()
        {
            return $"{Eno}\t{Ename}\t{Esal}";
        }
    }
}