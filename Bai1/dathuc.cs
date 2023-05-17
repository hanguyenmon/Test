using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai1
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
            soHang p = Head;
            soHang newest = new soHang(a, b);
            if (isEmpty())
            {
                Head = newest;
            }
            else
            {
                while (p.keTiep != null)
                {
                    p = p.keTiep;
                }
                p.keTiep = newest;
            }
        }

        public void Xoa(soHang a)
        {
            soHang p = Head;
            if (p == a)
                p = p.keTiep;
            else
            {
                while (p.keTiep != null)
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
            while (curr != null)
            {
                soHang p = curr;
                while (p.keTiep != null)
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
        }

        public dathuc Cong(dathuc dt1)
        {
            dathuc kq = new dathuc();
            dt1.RutGon();
            soHang p = Head;
            soHang q = dt1.Head;
            while (p != null && q != null)
            {
                if (p.soMu == q.soMu)
                {
                    kq.Them(p.heSo + q.heSo, p.soMu);
                    p = p.keTiep;
                    q = q.keTiep;
                }
                else if (p.soMu > q.soMu)
                {
                    kq.Them(p.heSo, p.soMu);
                    p = p.keTiep;
                }
            }
            while (q != null)
            {
                kq.Them(q.heSo, q.soMu);
                q = q.keTiep;
            }
            kq.Display();
            return kq;
        }

        public dathuc DoiDau()
        {
            dathuc kq = new dathuc();
            for (soHang p = Head; p != null; p = p.keTiep)
            {
                p.heSo = p.heSo * (-1);
                kq.Them(p.heSo, p.soMu);
            }
            kq.Display();
            return kq;
        }

        public dathuc Tich(dathuc dt1)
        {
            dathuc kq = new dathuc();
            soHang p = Head;
            soHang q = dt1.Head;
            for (p = Head; p != null; p = p.keTiep)
            {
                for (q = dt1.Head; q != null; q = q.keTiep)
                {
                    kq.Them(p.heSo * q.heSo, p.soMu + q.soMu);
                }
            }
            kq.RutGon();
            kq.Display();
            return kq;
        }

        public dathuc Chep()
        {
            dathuc kq = new dathuc();
            soHang p = Head;
            while (p != null)
            {
                kq.Them(p.heSo, p.soMu);
                p = p.keTiep;
            }
            kq.Display();
            return kq;
        }

        public void Display()
        {
            soHang p = Head;
            while (p != null)
            {
                Console.Write(p.heSo + "x^" + p.soMu);
                if (p.keTiep != null && p.keTiep.heSo > 0)
                    Console.Write(" + ");
                else
                    Console.Write(" ");
                p = p.keTiep;
            }
            Console.WriteLine();
        }
    }
}


