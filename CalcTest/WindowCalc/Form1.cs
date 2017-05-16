using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCalc
{
    public partial class Form1 : Form
    {
        private CalcLibrary.Calc Calc { get; set; }
        public Form1()
        {
            InitializeComponent();
            Calc = new CalcLibrary.Calc();

            CBoper.Items.AddRange(Calc.Operations.Select(o => o.Name).ToArray());
        }
        private void button1_Click(object Sender, EventArgs e)
        {
            Result.Text = "";
            var x = TBx.Text;
            var y = TBy.Text;
            var oper = CBoper.Text;
            object result=null;
            try
            {
                Calc.Execute(oper, new object[] { x, y });
            }
            catch (DivideByZeroException ex)
            {
                Result.Text = $"Divide by zero: {ex.Message}";
            }
            catch (Exception ex)
            {
                Result.Text = $"Error: {ex.Message}";
            }
            if (result != null)
            Result.Text = $"{x} {oper} {y} = {result}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
