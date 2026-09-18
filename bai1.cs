using System.Security.Cryptography;

public class DienThoai
{
    private string MaDT;
    private string TenDT;
    private int DonGia;
    private int SoLuong;
    public static int SoLuongSDT=0;
    public string TENDT
    {
        get
        {
            return TenDT;
        }
        set
        {
            TenDT=value;
        }
    }
    public string MADT
    {
        get
        {
            return MaDT;
        }
        set
        {
            MaDT=value;
        }
    
        
    }
    public int DONGIA
    {
        get
        {
            return DonGia;
        }
        set
        {
            DonGia=value;
        }
    }
    public int SOLUONG
    {
        get
        {
            return SoLuong;
        }
        set
        {
            SoLuong=value;
        }
    }
    public DienThoai()
    {
        SoLuongSDT++;
        
    }
   
    public void Nhap()
    {
        Console.WriteLine("Nhap ma dien thoai:");
        MaDT=Console.ReadLine();
        Console.WriteLine("Nhap ten dien thoai:");
        TenDT=Console.ReadLine();
        Console.WriteLine("Nhap don gia:");
        DonGia=int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so luong:");
        SoLuong=int.Parse(Console.ReadLine());
    }
    public double TinhGiaTriKho()
    {
        return DonGia * SoLuong;
    }
    public void Xuat()
    {
        Console.WriteLine("MaDT: {0} | TenDT: {1} | Don Gia: {2} | So Luong: {3} | Gia tri: {4} ",MaDT,TenDT,DonGia,SoLuong,TinhGiaTriKho());
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so dien thoai can quan ly:");
        int n=int.Parse(Console.ReadLine());
        DienThoai[] ds= new DienThoai[n]; // on lai phan nay
        for (int i =0; i < n; i++)
        {
            Console.WriteLine("Nhap so dien thoai thu:",i+1);
            ds[i]=new DienThoai();
            ds[i].Nhap();

        }
        double TongGiaTriKho=0;
        for (int i=0 ; i<n; i++)
        {
            ds[i].Xuat();
            TongGiaTriKho+=ds[i].TinhGiaTriKho();
            
        }
        Console.WriteLine("Tong gia tri ton kho: {0}",TongGiaTriKho);
        Console.WriteLine("Tong so dien thoai da tao: {0}",DienThoai.SoLuongSDT);
        
    }

}
