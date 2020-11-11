using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XmlParser.Business.Abstract;
using XmlParser.Business.Concrete;
using XmlParser.DataAccess.Concrete.EntityFramework;

namespace XmlParser.WinForm
{
    public partial class Form1 : Form
    {
        private readonly IXmlParserService _xmlParserService;
        public Form1()
        {
            _xmlParserService = new XmlParserManager(new EfMerkezYurticiDal(), new EfMerkezYurtdisiDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _xmlParserService.Save(@"C:\Users\akilli\Downloads\ADAY GOREV\Hava Durumu");
            MessageBox.Show(result.Message);
        }
    }
}
