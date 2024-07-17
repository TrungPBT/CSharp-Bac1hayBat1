internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Ứng dụng giải phương trình bậc 1");

        double a, b;

        Console.Write("Hãy Nhập số a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Hãy Nhập số b: ");
        b = Convert.ToDouble(Console.ReadLine());

        string ketqua = GiaiPTBac1(a, b);
        Console.WriteLine(ketqua);
    }

    /// <summary>
    /// Hàm giải phương trình bậc 1
    /// </summary>
    /// <param name="a">Đổi số a kiểu double</param>
    /// <param name="b">Đổi số b kiểu double</param>
    /// <returns>Chuỗi kết quả</returns>

    private static string GiaiPTBac1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0) return "phương trình có vô số nghiệm";
            else return "phương trình vô nghiệm";
        }
        else return "phương trinh có 1 nghiệm là " + (-b / a).ToString();
    }

    private static void GiaiPTBac1_cach2(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0) Console.WriteLine("phương trình có vô số nghiệm");
            else Console.WriteLine("phương trình có vô số nghiệm");

        }
        else Console.WriteLine("phương trinh có 1 nghiệm là " + (-b / a).ToString());
    }
}
