using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class HoiVienGym
{
    private string maHV;
    private string hoTen;
    private int soThangDangKy;
    private double phiMoiThang;
    public string MAHV
    {
        get
        {
            return maHV;
        }
        set
        {
            maHV=value;
        }
    }
    public string HOTEN
    {
        get
        {
            return hoTen;
        }
        set
        {
            hoTen=value;
        }
    }
    public int SOTHANGDANGKY
    {
        get
        {
            return soThangDangKy;
        }
        set
        {
            if (value > 0)
            {
                soThangDangKy=value;
            }
            else
            {
                phiMoiThang=300000;
            }
        }
    }
    public double PHIMOITHANG
    {
        get
        {
            return phiMoiThang;
        }
        set
        {
            if (value > 0)
            {
                phiMoiThang =value;
            }
            else
            {
                phiMoiThang=300000;
            }
        }
    }
    public HoiVienGym()
    {
        
    }
    public HoiVienGym(string maHV,string hoTen,int soThangDangKy,double phiMoiThang)
    {
        this.maHV=maHV;
        this.hoTen=hoTen;
        this.soThangDangKy=soThangDangKy;
        this.phiMoiThang=phiMoiThang;
    }
    public void Nhap()
    {
        Console.WriteLine("Nhap ma hoc vien:");
        maHV=Console.ReadLine();
        Console.WriteLine("Nhap ho va ten:");
        hoTen=Console.ReadLine();
        int st=0;
        do
        {   Console.WriteLine("Nhap so thang dang ky:");
            st=int.Parse(Console.ReadLine());
            if (st <= 0)
                {
                 Console.WriteLine("So thang dang ky phai lon hon 0 , vui long nhap lai!!!!");
                
                }

        }while(st<=0);
        soThangDangKy=st;
        double pt=0;
        do
        {
            Console.WriteLine("Nhap so phi moi thang: ");
            pt=int.Parse(Console.ReadLine());
            if (pt <= 0)
            {
                Console.WriteLine("phi phai lon hon khong vui long nhap lai !!! ");
            }
        }while(pt<=0);
        phiMoiThang=pt;

        
    }
    public double TinhTien()
    {
        
        double tienGoc= soThangDangKy * phiMoiThang;
        if (soThangDangKy >= 12)
        {
            return tienGoc * 0.9;
        }
        else if (soThangDangKy >= 6)
        {
            return tienGoc * 0.95;
        }
        else return tienGoc;
        
        
    }
    public void Xuat()
    {
        Console.WriteLine("Ma hoi vien : {0} || Ho ten : {1} || So thang dang ky : {2} || Phi moi thang : {3} ||  Tong tien : {4}",maHV,hoTen,soThangDangKy,phiMoiThang,TinhTien());
    }
}
class Program3
{
    static void Main(string[] args)
    {   Console.WriteLine("Nhap n:");
        int n=int.Parse(Console.ReadLine());
        HoiVienGym[] ds=new HoiVienGym[n];
        for (int i=0; i < n; i++)
        {
            ds[i]=new HoiVienGym();
            ds[i].Nhap();
        }
        Console.WriteLine("Danh sach hoc vien");
        for(int i = 0; i < n; i++)
        {
            ds[i].Xuat();
        }
        HoiVienGym hvMax=ds[0];
        for(int i = 0; i < n; i++)
        {
            if (ds[i].TinhTien() > hvMax.TinhTien())
            {
                hvMax=ds[i];
            }
            
        }
        Console.WriteLine("Sinh vien co thanh toan cao nhat la:");
        hvMax.Xuat();
        int soThang12=0;
        for(int i=0; i < n; i++)
        {
            if (ds[i].SOTHANGDANGKY > 12)
            {
                soThang12++;
            }
        }
        
        Console.WriteLine(soThang12);

    }
}