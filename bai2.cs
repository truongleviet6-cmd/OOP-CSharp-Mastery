class DangKyHocPhan
{
    private string MaSV;
    private string HoTen;
    private string TenHocPhan;
    private int SoTinChi;
    private double HocPhiMotTinChi;
    public int  SOTINCHI
    {
        get
        {
            return SoTinChi;
        }
        set
        {
            if (value > 0)
            {
                 SoTinChi=value;
            }
            
        }
    }
    public double HOCPHIMOTTINCHI
    {
        get
        {
            return HocPhiMotTinChi;
        }
        set
        {
            if (value > 0)
            {
                 HocPhiMotTinChi=value;
            }
        }
            
        
    } 
    public string MASV
    {
        get
        {
            return MaSV;
        }
        set
        {
            MaSV=value;
        }
    }
    public string HOTEN
    {
        get
        {
            return HoTen;
        }
        set
        {
            HoTen=value;
        }
    }
    public string TENHOCPHAN
    {
        get
        {
            return TenHocPhan;
        }
        set
        {
            TenHocPhan=value;
        }
    }
    public DangKyHocPhan()
    {
        
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap ma sinh vien:");
        MaSV=Console.ReadLine();
        Console.WriteLine("Nhap ho ten:");
        HoTen=Console.ReadLine();
        Console.WriteLine("Nhap ten hoc phan:");
        TenHocPhan=Console.ReadLine();
        int stc=0;
        do
        {
            Console.WriteLine("Nhap so tin chi:");
            stc=int.Parse(Console.ReadLine());
            if (stc <= 0)
            {
                Console.WriteLine("So tin chi phai lon hon 0 , vui long nhap lai !!!!");
            }
        } while(stc<=0);
        SoTinChi=stc;
        double hp=0;

        do
        {
            Console.WriteLine("Nhap hoc phi mot tin chi:");
            hp=double.Parse(Console.ReadLine());
            if (hp <= 0)
            {
                Console.WriteLine("So hoc phi phai lon hon 0 , vui long nhap lai!!!");
            }

        }while(hp<=0);
        HocPhiMotTinChi=hp;
    
    }
    public double TinhHocPhi()
    {
        return SoTinChi * HocPhiMotTinChi;
    }
    public void Xuat()
    {
        Console.WriteLine("MA SINH VIEN: {0} | HO TEN: {1} | TEN HOC PHAN: {2} | SO TIN CHI: {3} | HOC PHI MOT TIN: {4} | HOC PHI: {5}",MaSV,HoTen,TenHocPhan,SoTinChi,HocPhiMotTinChi,TinhHocPhi());
    }
        
    
}
class Program1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong sinh vien can quan ly:");
        int n=int.Parse(Console.ReadLine());
        DangKyHocPhan[] ds = new DangKyHocPhan[n];
        for(int i=0 ; i < n; i++)
        {
            ds[i] = new DangKyHocPhan();
            ds[i].Nhap();

        }
        Console.WriteLine("------------DANH SACH SINH VIEN---------------");
        for(int i=0; i<n; i++)
        {
            ds[i].Xuat();
        }
        DangKyHocPhan svMax=ds[0];
        for(int i=1 ; i<n; i++)
        {
            if (ds[i].TinhHocPhi() > svMax.TinhHocPhi())
            {
                svMax=ds[i];
            }
        }
        Console.WriteLine("Sinh vien co hoc phi cao nhat la:");
        svMax.Xuat();


    
    }
}