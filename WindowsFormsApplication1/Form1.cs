using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BUS taikhoan = new BUS();
        KetnoiCSDLDataContext db = new KetnoiCSDLDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            string url = @"http://localhost:8888/api/dsbantin/1";
            WebClient wc = new WebClient();

            wc.Encoding = System.Text.Encoding.UTF8;
            string json = wc.DownloadString(url);
            //MessageBox.Show(json.IndexOf(']').ToString());
            var kq = JsonConvert.DeserializeObject(json);
            //MessageBox.Show(json.Length.ToString());
            //string returnstr = json.Remove(0, json.IndexOf("["));
            //returnstr = returnstr.Remove(returnstr.IndexOf(']') + 1);
            textBox1.Text = json;
            MessageBox.Show(json);
            //Newtonsoft.Json.Linq.JToken token = JObject.Parse(json);
            //MessageBox.Show(token.SelectToken("id").ToString());

            //var instance = JsonConvert.DeserializeObject<List<Model.Value>>(json);
            //List<bantin_nhom> ketqua = new List<bantin_nhom>();

            //for (int i = 0; i < instance.Count; i++)
            //{
            //    bantin_nhom item = new bantin_nhom();
            //    item.idnhombantin = instance[i].idnhom;
            //    item.tennhom = instance[i].tennhom;
            //    item.mota = instance[i].mota;
            //    ketqua.Add(item);
            //}
            //dataGridView1.DataSource = ketqua;
        }

        

        public class Model
        {
            public class Value
            {
                public string id { get; set; }
                public short idnhom { get; set; }
                public string tennhom { get; set; }
                public string mota { get; set; }
            }

            public class RootObject
            {
                public List<Value> results { get; set; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.CreateDatabase();
        }

    }
}
