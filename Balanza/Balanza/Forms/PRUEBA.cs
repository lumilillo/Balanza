using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanza.Forms
{
    public partial class PRUEBA : Form
    {
        Bunifu.Framework.UI.BunifuThinButton2 currentButton;

        public PRUEBA()
        {
            InitializeComponent();
        }

        void SetButtonFormat()
        {
            currentButton.IdleFillColor = Color.FromArgb(255, 128, 0);
            currentButton.IdleForecolor = Color.White;
            currentButton.IdleLineColor = Color.FromArgb(255, 128, 0);
        }

        void ResetButtonsFormat()
        {
            if(btn1 != currentButton)
            {
                btn1.IdleFillColor = Color.White;
                btn1.IdleForecolor = Color.FromArgb(255, 128, 0);
                btn1.IdleLineColor = Color.FromArgb(255, 128, 0);
            }

            if (btn2 != currentButton)
            {
                btn2.IdleFillColor = Color.White;
                btn2.IdleForecolor = Color.FromArgb(255, 128, 0);
                btn2.IdleLineColor = Color.FromArgb(255, 128, 0);
            }

            if (btn3 != currentButton)
            {
                btn3.IdleFillColor = Color.White;
                btn3.IdleForecolor = Color.FromArgb(255, 128, 0);
                btn3.IdleLineColor = Color.FromArgb(255, 128, 0);
            }

            if (btn4 != currentButton)
            {
                btn4.IdleFillColor = Color.White;
                btn4.IdleForecolor = Color.FromArgb(255, 128, 0);
                btn4.IdleLineColor = Color.FromArgb(255, 128, 0);
            }

            if (btn5 != currentButton)
            {
                btn5.IdleFillColor = Color.White;
                btn5.IdleForecolor = Color.FromArgb(255, 128, 0);
                btn5.IdleLineColor = Color.FromArgb(255, 128, 0);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            currentButton = btn1;
            SetButtonFormat();
            ResetButtonsFormat();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentButton = btn2;
            SetButtonFormat();
            ResetButtonsFormat();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentButton = btn3;
            SetButtonFormat();
            ResetButtonsFormat();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentButton = btn4;
            SetButtonFormat();
            ResetButtonsFormat();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            currentButton = btn5;
            SetButtonFormat();
            ResetButtonsFormat();
        }
    }
}
