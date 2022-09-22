using System;

namespace NguyenQuynhAnhBTH.Models.Process
{
    public class GiaiPhuongTrinh
    {
        //cac buoc khai bao 1 phuong thuc
        //1. Xac dinh lieur tra ve cua phuong thuc
        //2. xac dinh cac tham so dau caof cuar phuong thuc
        //3. Xay dung phan tham phuong thuc
        //4. Tra ve du luej tuong ung

        //
        public int SumInt( int a, int b)
        {
            return (a+b);
        }
        //xay dung phuong thuc giai phuong trinh bac nhat
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string message="";
            double x;
            if(a==0)
            {
                if(b == 0)
                {
                    message = "Phuong trinh co vo so nghiem";
                }
                else
                {
                    message = "Phuong trinh vo nghiem";
                }
            }
            else
            {
                x = -b/a;
                message = "Phuong trinh co nghiem x =" + x;
            }
            return message;
        }

        public string GiaiPhuongTrinhBacHai(double heSoA, double heSoB, double heSoC)
        {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            double c = Convert.ToDouble(heSoC);
            string message="";
            double x1, x2, delta;
            if(heSoA==0)
            {
                message = GiaiPhuongTrinhBacNhat(a,b);
                
            }
            else
            {
                delta = b*b - 4*a*c;
                if(delta==0)
                {
                    x1 = -b/2*a;
                    message = "Phương trình có nghiệm kép x1 = x2 = " + x1;
                }
                else
                {
                    if(delta < 0)
                    {
                        message = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta))/(2*a);
                        x2 = (-b - Math.Sqrt(delta))/(2*a);
                        message = "Phương trình có hai nghiệm x1 = " + x1 + ", x2 = " + x2 + delta;
                    }
                }
            }
            return message;
        }
    }
}