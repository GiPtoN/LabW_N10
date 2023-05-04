using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabW_N10
{
    public struct Pointsw
    {
        public double kf;
        public List<double[]> Points;
    }
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public class SupportMethods
    {
        static public int NumberGraphicsForLevel2 = 0;
        public static Pointsw ReturnPoints(int Number)
        {
            var points = new Pointsw();
            List<double[]> Points = new List<double[]>();
            double a, b;
            int n;
            switch (Number)
            {
                case 1:
                    a = -Math.PI;
                    b = Math.PI;
                    n = 50;
                    for (double i = a; i <= b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = i*15;
                        point[1] = (2 * Math.Sin(i) + Math.Sin(2 * i))*15;
                        Points.Add(point);
                    }
                    points.kf = 15;
                    points.Points = Points;
                    break; 
                case 2:
                    a = 0.0;
                    b = 3 * Math.PI;
                    n = 20;
                    for (double i = a; i < b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = i*5;
                        point[1] = (i * Math.Sin(i)*5);
                        Points.Add(point);
                    }
                    points.kf = 5;
                    points.Points = Points;
                    break;
                case 3:
                    a = -2 * Math.PI;
                    b = 2 * Math.PI;
                    n = 40;
                    for (double i = a; i < b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = (float)i*5;
                        point[1] = (float)((Math.Sin(i) + 0.5 * i * i))*5;
                        Points.Add(point);
                    }
                    points.kf = 5;
                    points.Points = Points;
                    break;
                case 4:
                    a = 0.0;
                    b = 4 * Math.PI;
                    n = 40;
                    for (double i = (b-a)/n; i < b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = (float)i*4;
                        point[1] = (float)(3 * Math.Sin(i) / i)*4;
                        Points.Add(point);
                    }
                    points.kf = 4;
                    points.Points = Points;
                    break;
                case 5:
                    a = -10.0;
                    b = 10.0;
                    n = 20;
                    for (double i = a; i <= b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = (float)i;
                        point[1] = (float)(i*i - 18*i+72);
                        Points.Add(point);
                    }
                    points.kf = 0;
                    points.Points = Points;
                    break;
                case 6:
                    a = 1.0;
                    b = 10.0;
                    n = 40;
                    for (double i = a; i <= b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = (float)i*0.5;
                        point[1] = (float)(i * i * i + 5 * i * i + 14 * i)*0.5;
                        Points.Add(point);
                    }
                    points.kf = 0.5;
                    points.Points = Points;
                    break;
                case 7:
                    a = 0.5;
                    b = 1.0;
                    n = 20;
                    for (double i = a; i <= b; i+=(b-a)/n)
                    {
                        double[] point = new Double[2];
                        point[0] = (float)i*30;
                        point[1] = (float)(Math.Sqrt(i+1)-1.0/i)*30;
                        Points.Add(point);
                    }
                    points.kf = 30;
                    points.Points = Points;
                    break;
            }
            
            return points; 

        }
        
    }
}