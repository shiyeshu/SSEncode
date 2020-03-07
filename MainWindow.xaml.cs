using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
  
        }

        public void Button1_Click(object sender, RoutedEventArgs e)
        {
            String mag = TextBox.Text.Trim();
            String mag2 = mag;
            try
            {
                byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(mag);
                String encode = Convert.ToBase64String(bytes);
               
                TextBox.Text = encode;
            }
            catch
            {
                MessageBox.Show("这里出现了异常");
            }
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Button2_Click(object sender, RoutedEventArgs e)
        {
            String mag = TextBox.Text.Trim();
            String mag2 = mag;
            try
            {
                byte[] bytes = Convert.FromBase64String(mag);
                String decode = Encoding.GetEncoding("utf-8").GetString(bytes);
                //MessageBox.Show(decode, "这里是标题");
                TextBox.Text = decode;
            }
            catch
            {
                MessageBox.Show("这里出现了异常，可能是因为输入内容不为base64");
            }
            
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            String s = TextBox.Text;
            

            string dst = "";
            char[] src = s.ToCharArray();

            for (int i = 0; i < src.Length; i++)
            {

                byte[] bytes = Encoding.BigEndianUnicode.GetBytes(src[i].ToString());
                string str = @"\u" + bytes[0].ToString("X2") + bytes[1].ToString("X2");
                dst += str;

            }
            TextBox.Text = dst;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            string dst = "";
            String hex = TextBox.Text;
            int len = hex.Length / 6;

            
            for (int i = 0; i <= len - 1; i++)
            {
                try
                {
                    string str = "";
                    str = hex.Substring(0, 6).Substring(2);
                    hex = hex.Substring(6);
                    byte[] bytes = new byte[2];
                    bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                    bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                    dst += Encoding.Unicode.GetString(bytes);
                }
                catch
                {
                    MessageBox.Show("这里出现了异常，可能是因为输入内容有误");
                    return;  //

                }

            }
           
           
                

            //System.Text.Encoding chs = System.Text.Encoding.GetEncoding("utf-8");
            TextBox.Text= dst;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String mag = TextBox.Text.Trim();
            //String mag2 = mag;
            try
            {

             String  bytes = System.Web.HttpUtility.UrlEncode(mag, System.Text.Encoding.GetEncoding("utf-8"));
               String urlencode = HttpUtility.UrlEncode(bytes);

                //MessageBox.Show(encode,"这里是标题");
                TextBox.Text = urlencode;
                
            }
            catch
            {
                MessageBox.Show("这里出现了异常");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String mag = TextBox.Text.Trim();
            //String mag2 = mag;
            try
            {

                String bytes = System.Web.HttpUtility.UrlDecode(mag, System.Text.Encoding.GetEncoding("utf-8"));
                String urlencode = HttpUtility.UrlDecode(bytes);

                //MessageBox.Show(encode,"这里是标题");
                TextBox.Text = urlencode;

            }
            catch
            {
                MessageBox.Show("这里出现了异常");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                String str = TextBox.Text;
                string r = string.Empty;
                for (int i = 0; i < str.Length; i++)
                {
                    r += "&#" + Char.ConvertToUtf32(str, i) + ";";
                }
                TextBox.Text = r;
            }
            catch
            {
                MessageBox.Show("这里出现了异常");
            }
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                String str = TextBox.Text;
                Encoding utf8 = Encoding.GetEncoding(65001);
                Encoding gb2312 = Encoding.GetEncoding("gb2312");
                byte[] temp = utf8.GetBytes(str);
                byte[] temp1 = Encoding.Convert(gb2312, utf8, temp);
                string result = utf8.GetString(temp1);
                TextBox.Text = result;
            }
            catch
            {
                MessageBox.Show("这里出现了异常");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                String str = TextBox.Text;
                Encoding utf8 = Encoding.GetEncoding("utf-8");
                Encoding gb2312 = Encoding.GetEncoding("gb2312");
                byte[] temp = gb2312.GetBytes(str);
                byte[] temp1 = Encoding.Convert(utf8, gb2312, temp);
                string result = gb2312.GetString(temp1);
                TextBox.Text = result;
            }
            catch
            {
                MessageBox.Show("这里出现了异常");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("版本V1.1 \nby:阿硕\n2020/2/29","关于");
        }





        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (this.Topmost == true)
            {
                this.Topmost = false;
                zhiding.Content = "置\n顶";
            }
            else
            {
                this.Topmost = true;
                zhiding.Content = "已\n置\n顶";
            }
        }
    }
}
