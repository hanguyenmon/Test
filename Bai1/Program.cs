using Bai1;

dathuc dt1 = new dathuc();
dt1.Them(5, 4);
dt1.Them(6, 3);

Console.WriteLine("\nDa thuc 1: ");
dt1.Display();

dt1.RutGon();
Console.WriteLine("Da thuc 1 da rut gon: ");
dt1.Display();

dathuc dt2 = new dathuc();
dt2.Them(5, 4);
dt2.Them(1, 2);
dt2.Them(7, 3);
Console.WriteLine("\nDa thuc 2: ");
dt2.Display();

Console.WriteLine("\nTich hai da thuc: ");
dt1.Tich(dt2);

Console.WriteLine("\nDoi dau da thuc: ");
dt1.DoiDau();

Console.WriteLine("\nChep da thuc: ");
dt1.Chep();


