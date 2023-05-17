using Bai2;

dathuc dt = new dathuc();
dt.Them(2, 1);
dt.Them(3, 2);
dt.Them(-5, 2);
dt.Them(5, 2);

Console.WriteLine("Da thuc");
dt.Display();

Console.WriteLine("\nDa thuc rut gon");
dt.RutGon();

dathuc dathuc = new dathuc();
dathuc.Them(2, 0);
dathuc.Them(3, 5);
dathuc.Them(5, 2);

Console.WriteLine("\nDa thuc 2: ");
dathuc.Display();

Console.WriteLine("\nCong hai da thuc: ");
dathuc.Cong(dt);

Console.WriteLine("\nDoi dau da thuc: ");
dt.DoiDau();

Console.WriteLine("\nNhan hai da thuc: ");
dathuc.Tich(dt);

Console.WriteLine("\nSao chep da thuc: ");
dathuc.Chep();
