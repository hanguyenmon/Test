using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class soHang
    {
        public double heSo;
        public int soMu;
        public soHang keTiep;

        public soHang(double a, int b)
        {
            heSo = a;
            soMu = b;
            keTiep = null;
        }
    }

    public class dathuc
    {
        public soHang Head;

        public dathuc()
        {
            Head = null;
        }

        public bool isEmpty()
        {
            bool check = false;
            if (Head == null)
                check = true;
            return check;
        }

        public void Them(double a, int b)
        {
            soHang newest = new soHang(a, b);
            if (Head == null)
            {
                Head = newest;
                Head.keTiep = Head;
            }
            else
            {
                soHang p = Head;
                while (p.keTiep != Head)
                {
                    p = p.keTiep;
                }
                p.keTiep = newest;
                newest.keTiep = Head;
            }
        }

        public void Xoa(soHang a)
        {
            soHang p = Head;
            if (p == a)
                p = p.keTiep;
            else
            {
                while (p.keTiep != Head)
                {
                    if (p.keTiep == a)
                    {
                        p.keTiep = p.keTiep.keTiep;
                        break;
                    }
                    else
                        p = p.keTiep;
                }
            }
        }

        public void RutGon()
        {
            soHang curr = Head;
            do
            {
                soHang p = curr;
                while (p.keTiep != Head)
                {
                    if (curr.soMu == p.keTiep.soMu)
                    {
                        curr.heSo += p.keTiep.heSo;
                        p.keTiep = p.keTiep.keTiep;
                    }
                    else
                    {
                        p = p.keTiep;
                    }
                    if (curr.heSo == 0)
                    {
                        soHang del = curr;
                        Xoa(del);
                    }
                }
                curr = curr.keTiep;
            }
            while (curr != Head);
            Display();
        }

        public dathuc Cong(dathuc dt1)
        {
            dathuc kq = new dathuc();
            soHang p = Head;
            soHang q = dt1.Head;
            do
            {
                if (p.soMu > q.soMu)
                {
                    kq.Them(p.heSo, p.soMu);
                    p = p.keTiep;
                }
                else if (p.soMu < q.soMu)
                {
                    kq.Them(q.heSo, q.soMu);
                    q = q.keTiep;
                }
                else
                {
                    kq.Them(p.heSo + q.heSo, p.soMu);
                    p = p.keTiep;
                    q = q.keTiep;
                }
            }
            while (p != Head || q != dt1.Head);
            kq.Display();
            return kq;
        }

        public dathuc DoiDau()
        {
            dathuc kq = new dathuc();
            soHang p = Head;
            while (true)
            {
                p.heSo = p.heSo * (-1);
                kq.Them(p.heSo, p.soMu);
                p = p.keTiep;
                if (p == Head)
                    break;
            }
            kq.Display();
            return kq;
        }

        public dathuc Tich(dathuc dt1)
        {
            dathuc kq = new dathuc();
            soHang p = Head;
            soHang q = dt1.Head;
            do
            {
                do
                {
                    kq.Them(p.heSo * q.heSo, p.soMu + q.soMu);
                    q = q.keTiep;
                }
                while (q != dt1.Head);
                p = p.keTiep;
            }
            while (p != Head);
            kq.Display();
            return kq;
        }

        public dathuc Chep()
        {
            dathuc kq = new dathuc();
            soHang p = Head;
            while (true)
            {
                kq.Them(p.heSo, p.soMu);
                p = p.keTiep;
                if (p == Head)
                    break;
            }
            kq.Display();
            return kq;
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Da thuc rong!");
                return;
            }
            else
            {
                soHang p = Head;
                while (true)
                {
                    Console.Write(p.heSo + "x^" + p.soMu);
                    if (p.keTiep.heSo > 0 && p.keTiep != Head)
                        Console.Write(" + ");
                    else
                        Console.Write(" ");
                    p = p.keTiep;
                    if (p == Head)
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

