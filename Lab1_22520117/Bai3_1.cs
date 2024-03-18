using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_22520117
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long t = long.Parse(txtnhap.Text);//nhap vao 12 chu so vd 100.000.000.000
            long a = (t % 1000) / 100;
            long b = ((t%  1000) %100) / 10;
            long c = (t % 1000)% 10;
            string str_a="";
            string str_b = "";
            string str_c="";
            string str_d = "";
            string str_r = "";
            string str_f = "";
            string str_n = "";
            string str_m = "";
            string str_l = "";
            string str_i = "";
            string str_o = "";
            string str_p = "";
            // hang don tram 
            switch (c)
            {
                case 1:
                    { 
                    if (b != 0)
                        str_c = "mốt";
                    else if (b == 0 && c != 0)
                        str_c = "linh một";
                    else 
                        str_c = "một";
                  
                    }
                    break;
                case 2:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh hai";
                        else 
                            str_c = "hai";
                     
                    }
                        break;
                    
                case 3:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh ba";
                        else 
                            str_c = "ba";
                        
                    }
                    break;
                case 4:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh bốn";
                        else 
                            str_c = "bốn";
                      
                    }
                    break;
                case 5:
                    {
                        if (b != 0)
                            str_c = "lăm";
                        else if (b == 0 && c != 0)
                            str_c = "linh năm";
                        else 
                            str_c = "năm";
                    
                    }
                    break;
                case 6:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh sáu";
                        else 
                            str_c = "sáu";
                   
                    }
                    break;
                case 7:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh bảy";
                        else 
                            str_c = "bảy";
                   
                    }
                    break;
                case 8:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh tám";
                        else 
                            str_c = "tám";
                     
                    }
                    break;
                case 9:
                    {
                        if (b == 0 && c != 0)
                            str_c = "linh chín";
                        else 
                            str_c = "chín";
                    ;
                    }
                    break;
                default:
                    if(t < 100)
                        str_c = "không";
                    break;

            }
            switch (b)
            {
                case 1:
                    str_b = "mười";
                    break;
                case 2:
                    str_b = "hai mươi";
                    break;
                case 3:
                    str_b = "ba mươi";
                    break;
                case 4:
                    str_b = "bốn mươi";
                    break;
                case 5:
                    str_b = "năm mươi";
                    break;
                case 6:
                    str_b = "sáu mươi";
                    break;
                case 7:
                    str_b = "bảy mươi";
                    break;
                case 8:
                    str_b = "tám mươi";
                    break;
                case 9:
                    str_b = "chín mươi";
                    break;
                

            }
            switch (a)
            {
     
                case 1:
                    str_a = "một trăm";
                    break;
                case 2:
                    str_a = "hai trăm";
                    break;
                case 3:
                    str_a = "ba trăm";
                    break;
                case 4:
                    str_a = "bốn trăm";
                    break;
                case 5:
                    str_a = "năm trăm";
                    break;
                case 6:
                    str_a = "sáu trăm";
                    break;
                case 7:
                    str_a = "bảy trăm";
                    break;
                case 8:
                    str_a = "tám trăm";
                    break;
                case 9:
                    str_a = "chín trăm";
                    break;
               

            }
            long t1 = t / 1000;
            // hang ngan 
            if (t >= 1000)
            {
                long d = 0;
                long r = 0;
                long f = 0;

                long t2 = 0;
                if (t1 >= 1000)
                {
                    t2 = t1 % 100;
                    d = t2 / 100;
                    r = (t2 % 100) / 10;
                    f = t2 % 10;
                }
                else
                {
                    d = t1 / 100;
                    r = (t1 % 100) / 10;
                    f = t1 % 10;
                }


                switch (f)
                {
                    case 1:
                        {
                            if (r != 0)
                                str_f = "mốt nghìn";
                            else if (r == 0 && d != 0)
                                str_f = "linh một nghìn";
                            else 
                                str_f = "một nghìn";
                            
                        }
                        break;
                    case 2:
                        {
                              if (r == 0 && d != 0)
                                str_f = "linh hai nghìn";
                            else
                                str_f = "hai nghìn";
                          
                        }
                        break;
                    case 3:
                        {
                             if (r == 0 && d != 0)
                                str_f = "linh một nghìn";
                            else
                                str_f = "ba nghìn";
                          
                        }
                        break;
                    case 4:
                        {
                            if (r == 0 && d!= 0 )
                                str_f = "linh bốn nghìn";
                            else
                                str_f = " bốn nghìn";
                        }
                        break;
                    case 5:
                        {
                            if (r == 0)
                                str_f = "linh năm nghìn";
                            else if (r != 0)
                                str_f = "lăm nghìn";
                            else
                                str_f = "năm nghìn";
                        }
                        break;
                    case 6:
                        {
                            if (r == 0 && d != 0)
                                str_f = "linh sáu nghìn";
                            else
                                str_f = "sáu nghìn";
                        }
                        break;
                    case 7:
                        {
                            if (r == 0 && d != 0)
                                str_f = "linh bảy nghìn";
                            else
                                str_f = "bảy nghìn";
                        }
                        break;
                    case 8:
                        {
                            if (r == 0 && d != 0)
                                str_f = "linh tám nghìn";
                            else
                                str_f = "tám nghìn";
                        }
                        break;
                    case 9:
                        {
                            if (r == 0 && d != 0)
                                str_f = "linh chín nghìn";
                            else
                                str_f = "chín nghìn";
                        }
                        break;
                    default:
                        break;


                }
                switch (r)
                {
                    case 1:
                        str_r = "mươi";
                        break;
                    case 2:
                        str_r = "hai mươi";
                        break;
                    case 3:
                        str_r = "ba mươi";
                        break;
                    case 4:
                        str_r = "bốn mươi";
                        break;
                    case 5:
                        str_r = "năm mươi";
                        break;
                    case 6:
                        str_r = "sáu mươi";
                        break;
                    case 7:
                        str_r = "bảy mươi";
                        break;
                    case 8:
                        str_r = "tám mươi";
                        break;
                    case 9:
                        str_r = "chín mươi";
                        break;
                    default:
                        break;


                }
                switch (d)
                {
                    case 1:
                        str_d = "một trăm";
                        break;
                    case 2:
                        str_d = "hai trăm";
                        break;
                    case 3:
                        str_d = "ba trăm";
                        break;
                    case 4:
                        str_d = "bôn trăm";
                        break;
                    case 5:
                        str_d = "năm trăm";
                        break;
                    case 6:
                        str_d = "sáu trăm";
                        break;
                    case 7:
                        str_d = "bảy trăm";
                        break;
                    case 8:
                        str_d = "tám trăm";
                        break;
                    case 9:
                        str_d = "chín trăm";
                        break;
                    default:
                        break;


                }
            }

            // hang trieu
            long t3 = t1 / 1000;
            if (t >= 1000000)
            {
                long i = 0;
                long o = 0;
                long p = 0;
                long t4 = 0;
                if (t3 >= 1000)
                {
                    t4 = t3 % 1000;
                    i = t4 / 100;
                    o = (t4 % 100) / 10;
                    p = t4 % 10;
                }
                else
                {
                    i = t3 / 100;
                    o = (t3 % 100) / 10;
                    p = t3 % 10;
                }


                switch (p)
                {
                    case 1:
                        {
                            if (o != 0)
                                str_p = "mốt triệu";
                            else if (o == 0 && i != 0)
                                str_p = "linh một triệu";
                            else 
                                str_p = "một triệu";
                            
                        }
                        break;
                    case 2:
                        {
                            if (o == 0 && i != 0)
                                str_p = "linh hai triệu";
                            else
                                str_p = "hai triệu";
                        }
                        break;
                    case 3:
                        {
                            if (o == 0 &&i != 0)
                                str_p = "linh ba triệu";
                            else
                                str_p = "ba triệu";
                        }
                        break;
                    case 4:
                        {
                            if (o == 0 && i != 0)
                                str_p = "bốn triệu";
                            else
                                str_p = "lbốn triệu";
                        }
                        break;
                    case 5:
                        {
                            if (o == 0 && i != 0)
                                str_p = "năm triệu";
                            else if (o != 0)
                                str_p = "lăm triệu";
                            else
                                str_p = "năm triệu";
                        }
                        break;
                    case 6:
                        {
                            if (o == 0 && i != 0)
                                str_p = "linh sáu triệu";
                            else
                                str_p = "sáu triệu";
                        }
                        break;
                    case 7:
                        {
                            if (o == 0 && i != 0)
                                str_p = "linh bảy triệu";
                            else
                                str_p = "bảy triệu";
                        }
                        break;
                    case 8:
                        {
                            if (o == 0 && i != 0)
                                str_p = "linh tám triệu";
                            else
                                str_p = "tám triệu";
                        }
                        break;
                    case 9:
                        {
                            if (o == 0 && i != 0)
                                str_p = "linh chín triệu";
                            else
                                str_p = "chín triệu";
                        }
                        break;
                    default:
                        break;


                }
                switch (o)
                {
                    case 1:
                        str_o = "mười";
                        break;
                    case 2:
                        str_o = "hai mươi";
                        break;
                    case 3:
                        str_o = "ba mươi";
                        break;
                    case 4:
                        str_o = "bốn mươi";
                        break;
                    case 5:
                        str_o = "năm mươi";
                        break;
                    case 6:
                        str_o = "sáu mươi";
                        break;
                    case 7:
                        str_o = "bảy mươi";
                        break;
                    case 8:
                        str_o = "tám mươi";
                        break;
                    case 9:
                        str_o = "chín mươi";
                        break;
                    default:
                        break;


                }
                switch (i)
                {
                    case 1:
                        str_i = "một trăm";
                        break;
                    case 2:
                        str_i = "hai trăm";
                        break;
                    case 3:
                        str_i = "ba trăm";
                        break;
                    case 4:
                        str_i = "bôn trăm";
                        break;
                    case 5:
                        str_i = "năm trăm";
                        break;
                    case 6:
                        str_i = "sáu trăm";
                        break;
                    case 7:
                        str_i = "bảy trăm";
                        break;
                    case 8:
                        str_i = "tám trăm";
                        break;
                    case 9:
                        str_i = "chín trăm";
                        break;
                    default:
                        break;


                }
            }

            // hang ti
            if (t >= 1000000000)
            {


                long n = 0;
                long m = 0;
                long l = 0;
                long t5 = t3 / 1000;

                    n = t5 / 100;
                    m = (t5 % 100) / 10;
                    l = t5 % 10;
                                

                switch (l)
                {
                    case 1:
                        {
                            if (m != 0)
                                str_l = "mốt tỷ";
                            else if (m == 0 && n != 0)
                                str_l = "linh một tỷ";
                            else 
                                str_l = "một tỷ";
                            
                        }
                        break;
                    case 2:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh hai tỷ";
                            else
                                str_l = "hai tỷ";
                        }
                        break;
                    case 3:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh ba tỷ";
                            else
                                str_l = "ba tỷ";
                        }
                        break;
                    case 4:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh bốn tỷ";
                            else
                                str_l = "bốn tỷ";
                        }
                        break;
                    case 5:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh năm tỷ";
                            else if (m != 0)
                                str_l = "lăm tỷ";
                            else
                                str_l = "năm tỷ";
                        }
                        break;
                    case 6:
                        {
                            if (m == 0 && n != 0) 
                                str_l = "linh sáu tỷ";
                            else
                                str_l = "sáu tỷ";
                        }
                        break;
                    case 7:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh bảy tỷ";
                            else
                                str_l = "bảy tỷ";
                        }
                        break;
                    case 8:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh tám tỷ";
                            else
                                str_l = "tám tỷ";
                        }
                        break;
                    case 9:
                        {
                            if (m == 0 && n != 0)
                                str_l = "linh chín tỷ";
                            else
                                str_l = "chín tỷ";
                        }
                        break;
                    default:
                        break;


                }
                switch (m)
                {
                    case 1:
                        str_m = "mươi";
                        break;
                    case 2:
                        str_m = "hai mươi";
                        break;
                    case 3:
                        str_m = "ba mươi";
                        break;
                    case 4:
                        str_m = "bốn mươi";
                        break;
                    case 5:
                        str_m = "năm mươi";
                        break;
                    case 6:
                        str_m = "sáu mươi";
                        break;
                    case 7:
                        str_m = "bảy mươi";
                        break;
                    case 8:
                        str_m = "tám mươi";
                        break;
                    case 9:
                        str_m = "chín mươi";
                        break;
                    default:
                        break;


                }
                switch (n)
                {
                    case 1:
                        str_n = "một trăm";
                        break;
                    case 2:
                        str_n = "hai trăm";
                        break;
                    case 3:
                        str_n = "ba trăm";
                        break;
                    case 4:
                        str_n = "bôn trăm";
                        break;
                    case 5:
                        str_n = "năm trăm";
                        break;
                    case 6:
                        str_n = "sáu trăm";
                        break;
                    case 7:
                        str_n = "bảy trăm";
                        break;
                    case 8:
                        str_n = "tám trăm";
                        break;
                    case 9:
                        str_n = "chín trăm";
                        break;
                    default:
                        break;


                }
            }
            txtkq.Text = str_n+" "+ str_m+" "+str_l+" "+ str_i+" "+str_o+" "+str_p+" "+ str_d+" "+str_r+" "+str_f+" "+str_a+" "+str_b+" "+str_c;



        }
    }
}
