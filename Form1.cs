using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        Field f;
        public Form1()
        {
            InitializeComponent();
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            winner_label.Text = "";
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                    ((TextBox)c).BackColor = Color.White;
                }
            }
            f = new Field();
            p11.Text = f.Matrixp[1, 1].ToString();
            p10.Text = f.Matrixp[1, 0].ToString();
            p20.Text = f.Matrixp[2, 0].ToString();
            p21.Text = f.Matrixp[2, 1].ToString();
            p03.Text = f.Matrixp[0, 3].ToString();
            p04.Text = f.Matrixp[0, 4].ToString();
            p14.Text = f.Matrixp[1, 4].ToString();
            p25.Text = f.Matrixp[2, 5].ToString();
            p06.Text = f.Matrixp[0, 6].ToString();
            p08.Text = f.Matrixp[0, 8].ToString();
            p17.Text = f.Matrixp[1, 7].ToString();
            p26.Text = f.Matrixp[2, 6].ToString();

            p30.Text = f.Matrixp[3, 0].ToString();
            p31.Text = f.Matrixp[3, 1].ToString();
            p33.Text = f.Matrixp[3, 3].ToString();
            p37.Text = f.Matrixp[3, 7].ToString();
            p42.Text = f.Matrixp[4, 2].ToString();
            p43.Text = f.Matrixp[4, 3].ToString();
            p45.Text = f.Matrixp[4, 5].ToString();
            p46.Text = f.Matrixp[4, 6].ToString();
            p51.Text = f.Matrixp[5, 1].ToString();
            p55.Text = f.Matrixp[5, 5].ToString();
            p57.Text = f.Matrixp[5, 7].ToString();
            p58.Text = f.Matrixp[5, 8].ToString();

            p62.Text = f.Matrixp[6, 2].ToString();
            p63.Text = f.Matrixp[6, 3].ToString();
            p67.Text = f.Matrixp[6, 7].ToString();
            p68.Text = f.Matrixp[6, 8].ToString();
            p71.Text = f.Matrixp[7, 1].ToString();
            p74.Text = f.Matrixp[7, 4].ToString();
            p77.Text = f.Matrixp[7, 7].ToString();
            p78.Text = f.Matrixp[7, 8].ToString();
            p80.Text = f.Matrixp[8, 0].ToString();
            p82.Text = f.Matrixp[8, 2].ToString();
            p84.Text = f.Matrixp[8, 4].ToString();
            p85.Text = f.Matrixp[8, 5].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p00.Text = f.Matrixp[0, 0].ToString();
            p01.Text = f.Matrixp[0, 1].ToString();
            p02.Text = f.Matrixp[0, 2].ToString();
            p03.Text = f.Matrixp[0, 3].ToString();
            p04.Text = f.Matrixp[0, 4].ToString();
            p05.Text = f.Matrixp[0, 5].ToString();
            p06.Text = f.Matrixp[0, 6].ToString();
            p07.Text = f.Matrixp[0, 7].ToString();
            p08.Text = f.Matrixp[0, 8].ToString();
            p10.Text = f.Matrixp[1, 0].ToString();
            p11.Text = f.Matrixp[1, 1].ToString();
            p12.Text = f.Matrixp[1, 2].ToString();
            p13.Text = f.Matrixp[1, 3].ToString();
            p14.Text = f.Matrixp[1, 4].ToString();
            p15.Text = f.Matrixp[1, 5].ToString();
            p16.Text = f.Matrixp[1, 6].ToString();
            p17.Text = f.Matrixp[1, 7].ToString();
            p18.Text = f.Matrixp[1, 8].ToString();
            p20.Text = f.Matrixp[2, 0].ToString();
            p21.Text = f.Matrixp[2, 1].ToString();
            p22.Text = f.Matrixp[2, 2].ToString();
            p23.Text = f.Matrixp[2, 3].ToString();
            p24.Text = f.Matrixp[2, 4].ToString();
            p25.Text = f.Matrixp[2, 5].ToString();
            p26.Text = f.Matrixp[2, 6].ToString();
            p27.Text = f.Matrixp[2, 7].ToString();
            p28.Text = f.Matrixp[2, 8].ToString();
            p30.Text = f.Matrixp[3, 0].ToString();
            p31.Text = f.Matrixp[3, 1].ToString();
            p32.Text = f.Matrixp[3, 2].ToString();
            p33.Text = f.Matrixp[3, 3].ToString();
            p34.Text = f.Matrixp[3, 4].ToString();
            p35.Text = f.Matrixp[3, 5].ToString();
            p36.Text = f.Matrixp[3, 6].ToString();
            p37.Text = f.Matrixp[3, 7].ToString();
            p38.Text = f.Matrixp[3, 8].ToString();
            p40.Text = f.Matrixp[4, 0].ToString();
            p41.Text = f.Matrixp[4, 1].ToString();
            p42.Text = f.Matrixp[4, 2].ToString();
            p43.Text = f.Matrixp[4, 3].ToString();
            p44.Text = f.Matrixp[4, 4].ToString();
            p45.Text = f.Matrixp[4, 5].ToString();
            p46.Text = f.Matrixp[4, 6].ToString();
            p47.Text = f.Matrixp[4, 7].ToString();
            p48.Text = f.Matrixp[4, 8].ToString();
            p50.Text = f.Matrixp[5, 0].ToString();
            p51.Text = f.Matrixp[5, 1].ToString();
            p52.Text = f.Matrixp[5, 2].ToString();
            p53.Text = f.Matrixp[5, 3].ToString();
            p54.Text = f.Matrixp[5, 4].ToString();
            p55.Text = f.Matrixp[5, 5].ToString();
            p56.Text = f.Matrixp[5, 6].ToString();
            p57.Text = f.Matrixp[5, 7].ToString();
            p58.Text = f.Matrixp[5, 8].ToString();
            p60.Text = f.Matrixp[6, 0].ToString();
            p61.Text = f.Matrixp[6, 1].ToString();
            p62.Text = f.Matrixp[6, 2].ToString();
            p63.Text = f.Matrixp[6, 3].ToString();
            p64.Text = f.Matrixp[6, 4].ToString();
            p65.Text = f.Matrixp[6, 5].ToString();
            p66.Text = f.Matrixp[6, 6].ToString();
            p67.Text = f.Matrixp[6, 7].ToString();
            p68.Text = f.Matrixp[6, 8].ToString();
            p70.Text = f.Matrixp[7, 0].ToString();
            p71.Text = f.Matrixp[7, 1].ToString();
            p72.Text = f.Matrixp[7, 2].ToString();
            p73.Text = f.Matrixp[7, 3].ToString();
            p74.Text = f.Matrixp[7, 4].ToString();
            p75.Text = f.Matrixp[7, 5].ToString();
            p76.Text = f.Matrixp[7, 6].ToString();
            p77.Text = f.Matrixp[7, 7].ToString();
            p78.Text = f.Matrixp[7, 8].ToString();
            p80.Text = f.Matrixp[8, 0].ToString();
            p81.Text = f.Matrixp[8, 1].ToString();
            p82.Text = f.Matrixp[8, 2].ToString();
            p83.Text = f.Matrixp[8, 3].ToString();
            p84.Text = f.Matrixp[8, 4].ToString();
            p85.Text = f.Matrixp[8, 5].ToString();
            p86.Text = f.Matrixp[8, 6].ToString();
            p87.Text = f.Matrixp[8, 7].ToString();
            p88.Text = f.Matrixp[8, 8].ToString();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (p00.Text == f.Matrixp[0, 0].ToString())
                p00.BackColor = Color.Green;
            else
                p00.BackColor = Color.Red;
            if(p01.Text == f.Matrixp[0, 1].ToString())
                p01.BackColor = Color.Green;
            else
                p01.BackColor = Color.Red;
            if(p02.Text == f.Matrixp[0, 2].ToString())
                p02.BackColor = Color.Green;
            else
                p02.BackColor = Color.Red;
            if(p03.Text == f.Matrixp[0, 3].ToString())
                p03.BackColor = Color.Green;
            else
                p03.BackColor = Color.Red;
            if(p04.Text == f.Matrixp[0, 4].ToString())
                p04.BackColor = Color.Green;
            else
                p04.BackColor = Color.Red;
            if(p05.Text == f.Matrixp[0, 5].ToString())
                p05.BackColor = Color.Green;
            else
                p05.BackColor = Color.Red;
            if(p06.Text == f.Matrixp[0, 6].ToString())
                p06.BackColor = Color.Green;
            else
                p06.BackColor = Color.Red;
            if(p07.Text == f.Matrixp[0, 7].ToString())
                p07.BackColor = Color.Green;
            else
                p07.BackColor = Color.Red;
            if(p08.Text == f.Matrixp[0, 8].ToString())
                p08.BackColor = Color.Green;
            else
                p08.BackColor = Color.Red;
            if(p10.Text == f.Matrixp[1, 0].ToString())
                p10.BackColor = Color.Green;
            else
                p10.BackColor = Color.Red;
            if(p11.Text == f.Matrixp[1, 1].ToString())
                p11.BackColor = Color.Green;
            else
                p11.BackColor = Color.Red;
            if(p12.Text == f.Matrixp[1, 2].ToString())
                p12.BackColor = Color.Green;
            else
                p12.BackColor = Color.Red;
            if(p13.Text == f.Matrixp[1, 3].ToString())
                p13.BackColor = Color.Green;
            else
                p13.BackColor = Color.Red;
            if(p14.Text == f.Matrixp[1, 4].ToString())
                p14.BackColor = Color.Green;
            else
                p14.BackColor = Color.Red;
            if(p15.Text == f.Matrixp[1, 5].ToString())
                p15.BackColor = Color.Green;
            else
                p15.BackColor = Color.Red;
            if(p16.Text == f.Matrixp[1, 6].ToString())
                p16.BackColor = Color.Green;
            else
                p16.BackColor = Color.Red;
            if(p17.Text == f.Matrixp[1, 7].ToString())
                p17.BackColor = Color.Green;
            else
                p17.BackColor = Color.Red;
            if(p18.Text == f.Matrixp[1, 8].ToString())
                p18.BackColor = Color.Green;
            else
                p18.BackColor = Color.Red;
            if(p20.Text == f.Matrixp[2, 0].ToString())
                p20.BackColor = Color.Green;
            else
                p20.BackColor = Color.Red;
            if (p21.Text == f.Matrixp[2, 1].ToString())
                p21.BackColor = Color.Green;
            else
                p21.BackColor = Color.Red;
            if (p22.Text == f.Matrixp[2, 2].ToString())
                p22.BackColor = Color.Green;
            else
                p22.BackColor = Color.Red;
            if (p23.Text == f.Matrixp[2, 3].ToString())
                p23.BackColor = Color.Green;
            else
                p23.BackColor = Color.Red;
            if (p24.Text == f.Matrixp[2, 4].ToString())
                p24.BackColor = Color.Green;
            else
                p24.BackColor = Color.Red;
            if(p25.Text == f.Matrixp[2, 5].ToString())
                p25.BackColor = Color.Green;
            else
                p25.BackColor = Color.Red;
            if (p26.Text == f.Matrixp[2, 6].ToString())
                p26.BackColor = Color.Green;
            else
                p26.BackColor = Color.Red;
            if (p27.Text == f.Matrixp[2, 7].ToString())
                p27.BackColor = Color.Green;
            else
                p27.BackColor = Color.Red;
            if (p28.Text == f.Matrixp[2, 8].ToString())
                p28.BackColor = Color.Green;
            else
                p28.BackColor = Color.Red;
            if (p30.Text == f.Matrixp[3, 0].ToString())
                p30.BackColor = Color.Green;
            else
                p30.BackColor = Color.Red;
            if (p31.Text == f.Matrixp[3, 1].ToString())
                p31.BackColor = Color.Green;
            else
                p31.BackColor = Color.Red;
            if (p32.Text == f.Matrixp[3, 2].ToString())
                p32.BackColor = Color.Green;
            else
                p32.BackColor = Color.Red;
            if (p33.Text == f.Matrixp[3, 3].ToString())
                p33.BackColor = Color.Green;
            else
                p33.BackColor = Color.Red;
            if (p34.Text == f.Matrixp[3, 4].ToString())
                p34.BackColor = Color.Green;
            else
                p34.BackColor = Color.Red;
            if(p35.Text == f.Matrixp[3, 5].ToString())
                p35.BackColor = Color.Green;
            else
                p35.BackColor = Color.Red;
            if (p36.Text == f.Matrixp[3, 6].ToString())
                p36.BackColor = Color.Green;
            else
                p36.BackColor = Color.Red;
            if (p37.Text == f.Matrixp[3, 7].ToString())
                p37.BackColor = Color.Green;
            else
                p37.BackColor = Color.Red;
            if(p38.Text == f.Matrixp[3, 8].ToString())
                p38.BackColor = Color.Green;
            else
                p38.BackColor = Color.Red;
            if(p40.Text == f.Matrixp[4, 0].ToString())
                p40.BackColor = Color.Green;
            else
                p40.BackColor = Color.Red;
            if(p41.Text == f.Matrixp[4, 1].ToString())
                p41.BackColor = Color.Green;
            else
                p41.BackColor = Color.Red;
            if (p42.Text == f.Matrixp[4, 2].ToString())
                p42.BackColor = Color.Green;
            else
                p42.BackColor = Color.Red;
            if (p43.Text == f.Matrixp[4, 3].ToString())
                p43.BackColor = Color.Green;
            else
                p43.BackColor = Color.Red;
            if (p44.Text == f.Matrixp[4, 4].ToString())
                p44.BackColor = Color.Green;
            else
                p44.BackColor = Color.Red;
            if (p45.Text == f.Matrixp[4, 5].ToString())
                p45.BackColor = Color.Green;
            else
                p45.BackColor = Color.Red;
            if (p46.Text == f.Matrixp[4, 6].ToString())
                p46.BackColor = Color.Green;
            else
                p46.BackColor = Color.Red;
            if(p47.Text == f.Matrixp[4, 7].ToString())
                p47.BackColor = Color.Green;
            else
                p47.BackColor = Color.Red;
            if(p48.Text == f.Matrixp[4, 8].ToString())
                p48.BackColor = Color.Green;
            else
                p48.BackColor = Color.Red;
            if(p50.Text == f.Matrixp[5, 0].ToString())
                p50.BackColor = Color.Green;
            else
                p50.BackColor = Color.Red;
            if(p51.Text == f.Matrixp[5, 1].ToString())
                p51.BackColor = Color.Green;
            else
                p51.BackColor = Color.Red;
            if(p52.Text == f.Matrixp[5, 2].ToString())
                p52.BackColor = Color.Green;
            else
                p52.BackColor = Color.Red;
            if(p53.Text == f.Matrixp[5, 3].ToString())
                p53.BackColor = Color.Green;
            else
                p53.BackColor = Color.Red;
            if(p54.Text == f.Matrixp[5, 4].ToString())
                p54.BackColor = Color.Green;
            else
                p54.BackColor = Color.Red;
            if(p55.Text == f.Matrixp[5, 5].ToString())
                p55.BackColor = Color.Green;
            else
                p55.BackColor = Color.Red;
            if(p56.Text == f.Matrixp[5, 6].ToString())
                p56.BackColor = Color.Green;
            else
                p56.BackColor = Color.Red;
            if(p57.Text == f.Matrixp[5, 7].ToString())
                p57.BackColor = Color.Green;
            else
                p57.BackColor = Color.Red;
            if(p58.Text == f.Matrixp[5, 8].ToString())
                p58.BackColor = Color.Green;
            else
                p58.BackColor = Color.Red;
            if(p60.Text == f.Matrixp[6, 0].ToString())
                p60.BackColor = Color.Green;
            else
                p60.BackColor = Color.Red;
            if(p61.Text == f.Matrixp[6, 1].ToString())
                p61.BackColor = Color.Green;
            else
                p61.BackColor = Color.Red;
            if(p62.Text == f.Matrixp[6, 2].ToString())
                p62.BackColor = Color.Green;
            else
                p62.BackColor = Color.Red;
            if(p63.Text == f.Matrixp[6, 3].ToString())
                p63.BackColor = Color.Green;
            else
                p63.BackColor = Color.Red;
            if(p64.Text == f.Matrixp[6, 4].ToString())
                p64.BackColor = Color.Green;
            else
                p64.BackColor = Color.Red;
            if(p65.Text == f.Matrixp[6, 5].ToString())
                p65.BackColor = Color.Green;
            else
                p65.BackColor = Color.Red;
            if(p66.Text == f.Matrixp[6, 6].ToString())
                p66.BackColor = Color.Green;
            else
                p66.BackColor = Color.Red;
            if(p67.Text == f.Matrixp[6, 7].ToString())
                p67.BackColor = Color.Green;
            else
                p67.BackColor = Color.Red;
            if(p68.Text == f.Matrixp[6, 8].ToString())
                p68.BackColor = Color.Green;
            else
                p68.BackColor = Color.Red;
            if(p70.Text == f.Matrixp[7, 0].ToString())
                p70.BackColor = Color.Green;
            else
                p70.BackColor = Color.Red;
            if (p71.Text == f.Matrixp[7, 1].ToString())
                p71.BackColor = Color.Green;
            else
                p71.BackColor = Color.Red;
            if (p72.Text == f.Matrixp[7, 2].ToString())
                p72.BackColor = Color.Green;
            else
                p72.BackColor = Color.Red;
            if (p73.Text == f.Matrixp[7, 3].ToString())
                p73.BackColor = Color.Green;
            else
                p73.BackColor = Color.Red;
            if (p74.Text == f.Matrixp[7, 4].ToString())
                p74.BackColor = Color.Green;
            else
                p74.BackColor = Color.Red;
            if (p75.Text == f.Matrixp[7, 5].ToString())
                p75.BackColor = Color.Green;
            else
                p75.BackColor = Color.Red;
            if (p76.Text == f.Matrixp[7, 6].ToString())
                p76.BackColor = Color.Green;
            else
                p76.BackColor = Color.Red;
            if (p77.Text == f.Matrixp[7, 7].ToString())
                p77.BackColor = Color.Green;
            else
                p77.BackColor = Color.Red;
            if (p78.Text == f.Matrixp[7, 8].ToString())
                p78.BackColor = Color.Green;
            else
                p78.BackColor = Color.Red;
            if (p80.Text == f.Matrixp[8, 0].ToString())
                p80.BackColor = Color.Green;
            else
                p80.BackColor = Color.Red;
            if (p81.Text == f.Matrixp[8, 1].ToString())
                p81.BackColor = Color.Green;
            else
                p81.BackColor = Color.Red;
            if (p82.Text == f.Matrixp[8, 2].ToString())
                p82.BackColor = Color.Green;
            else
                p82.BackColor = Color.Red;
            if (p83.Text == f.Matrixp[8, 3].ToString())
                p83.BackColor = Color.Green;
            else
                p83.BackColor = Color.Red;
            if (p84.Text == f.Matrixp[8, 4].ToString())
                p84.BackColor = Color.Green;
            else
                p84.BackColor = Color.Red;
            if (p85.Text == f.Matrixp[8, 5].ToString())
                p85.BackColor = Color.Green;
            else
                p85.BackColor = Color.Red;
            if (p86.Text == f.Matrixp[8, 6].ToString())
                p86.BackColor = Color.Green;
            else
                p86.BackColor = Color.Red;
            if (p87.Text == f.Matrixp[8, 7].ToString())
                p87.BackColor = Color.Green;
            else
                p87.BackColor = Color.Red;
            if (p88.Text == f.Matrixp[8, 8].ToString())
                p88.BackColor = Color.Green;
            else
                p88.BackColor = Color.Red;
            int k = 0;
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).BackColor == Color.Green)
                        k++;
                }
            }
            if (k == 81)
                winner_label.Text = "Congratulations! You won!";
        }
    }
}
