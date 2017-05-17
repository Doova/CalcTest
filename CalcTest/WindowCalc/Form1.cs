using CalcLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalc
{
    public partial class Form1 : Form
    {
        private Calc Calc { get; set; }

        public Form1()
        {
            InitializeComponent();
            Calc = new Calc();
            
            cbOper.DataSource = Calc.Operations;
            cbOper.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lResult.Text = "";

            var oper = cbOper.Text;

            object result = null;

            var moreArgs = cbOper.SelectedItem is IOperationArgs;

            var args = new List<object>();

            if (moreArgs)
            {
                // "1 2 3" => new string [] {"1", "2", "3"}
                args.AddRange(tbMore.Text.Split(' '));
            }
            else
            {
                var x = tbX.Text;
                var y = tbY.Text;
                args.Add(x);
                args.Add(y);
            }

            try
            {
                result = Calc.Execute(oper, args.ToArray());
            }
            catch (DivideByZeroException ex)
            {
                lResult.Text = $"DivideByZero: {ex.Message}";
            }
            catch (Exception ex)
            {
                lResult.Text = $"Error: {ex.Message}";
            }

            if (result != null)
            {
                lResult.Text = $"{result}";
            }
        }

        private void cbOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            var moreArgs = cbOper.SelectedItem is IOperationArgs;

            panTwoArgs.Visible = !moreArgs;
            panMoreArgs.Visible = moreArgs;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ToolTip t = new ToolTip();
            //t.SetToolTip(, "Выход");
        }
    }
}
