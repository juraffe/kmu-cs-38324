using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kmu_cs_38324 {

  public partial class Form1 : Form {

    public Form1() {
      InitializeComponent();
    }

    private void BtnSayHi_Click(object sender, EventArgs e) {
      Console.WriteLine("안녕, 세상!!");
    }

    private int SomeCalc(int lhs, int rhs) {
      return lhs / 1 + rhs / 1;
    }
  }
}