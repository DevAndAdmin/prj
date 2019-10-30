using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharp_less1
{
    public Form1()
    {
        InitializeComponent();
    }

    class gpu
    {
        string name;
        string ram;
        int cores;
        float freq;
        public string Name {
            get {
                return name;
            }
        }
        public gpu(){
            name = "";
            ram = "";
            cores = 0;
            calc();
        }
        public gpu(string name, string ram, int cores)
        {
            this.name = name;
            this.ram = ram;
            this.cores = cores;
            calc();
        }
        public void calc() {
            freq = cores * 5;
        }
    }

    class s_gpu : gpu {
    }
    public partial class Form1 : Form
    {
        

        private void Button1_Click(object sender, EventArgs e)
        {
            gpu vcard = new gpu("rtx2080ti", "12Gb", 4000);
           // vcard.name = "rtx 2080ti";
           // vcard.cores = 4000;
            label1.Text = vcard.Name;
        }
    }
}
