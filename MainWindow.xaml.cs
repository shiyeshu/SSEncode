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
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                         //throw new ArgumentException("s is not valid chinese string!");
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("utf-8");
            byte[] bytes = chs.GetBytes(s);

            string str = "";

            for (int i = 0; i < bytes.Length; i++)
            {
                str +=  string.Format("{0:X}", bytes[i]);
               
            }
            TextBox.Text = str;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            String hex = TextBox.Text;
            if (hex == null)
                throw new ArgumentNullException("hex");
            hex = hex.Replace(",", "");
            hex = hex.Replace("\n", "");
            hex = hex.Replace("\\", "");
            hex = hex.Replace(" ", "");
            if (hex.Length % 2 != 0)
            {
                hex += "20";//空格
            }
            // 需要将 hex 转换成 byte 数组。 
            byte[] bytes = new byte[hex.Length / 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    // 每两个字符是一个 byte。 
                    bytes[i] = byte.Parse(hex.Substring(i * 2, 2),
                    System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    MessageBox.Show("这里出现了异常，可能是因为输入内容有误");
                    return ;  //

                }
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("utf-8");
            TextBox.Text= chs.GetString(bytes);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("版本编号V0.1");
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
            MessageBox.Show("版本V1.0 \nby:阿硕\n2020/1/13","关于");
        }
    }
}
