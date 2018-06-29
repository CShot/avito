using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ipnutAdress()
        {

        }

        void ContinueButton()
        {
            foreach (HtmlElement continueButton in webBrowser1.Document.GetElementsByTagName("input"))
            {
                if (continueButton.GetAttribute("value") == "Продолжить")
                {
                    continueButton.InvokeMember("click");
                }
            }
        }

        void Close()
        {
            foreach (HtmlElement closeBut in webBrowser1.Document.GetElementsByTagName("span"))
            {
                if (closeBut.GetAttribute("class") == "header-v2-menu-icon")
                {
                    closeBut.InvokeMember("click");
                }
            }
        }

        bool trigger = false;

        private void Button1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (trigger == false)
            {
                webBrowser1.Document.GetElementById("param_2855").InnerText = "Нижний Новгород, м. Парк Культуры";

                webBrowser1.Document.GetElementById("param_44").SetAttribute("value", "144");

                webBrowser1.Document.GetElementById("param_2835").SetAttribute("value", "20056");

                webBrowser1.Document.GetElementById("description").InnerText = "Все материалы соответствуют ГОСТ! \n Работаем без выходных и праздников! \n По городу и области! \n Для расчета позвоните по телефону! \n НАШ САЙТ: наберите в поисковой системе – ПЕСКОБАЗА";

                webBrowser1.Document.GetElementById("price").InnerText = "100";

                trigger = true;
            }

        //    webBrowser1.Document.GetElementById("image_upload").SetAttribute("value", "C:/Users/Максимка/Desktop/Avito/Avito/bin/Debug/1.jpg");

          //  ContinueButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("category_id").SetAttribute("value", "19");

            webBrowser1.Document.GetElementById("title").InnerText = "Асф-я крошка чернозём доставка 10тонн 2500 нино";

            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Button1);

            ContinueButton();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Close();

        }
    }
}
