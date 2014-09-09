using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cameron_Edwards_Wordguess
{
    public partial class MainWin : Form
    {
        ActiveGame game;

        public MainWin()
        {
            InitializeComponent();
        }

        private void but_new_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ip.Text) && !string.IsNullOrWhiteSpace(txt_port.Text))
            {
                clearTextBoxes();
                game = new ActiveGame(txt_ip.Text, txt_port.Text);
                Message msg = game.getLatestResponse();
                if (msg != null)
                {
                    string hint = msg.getArg(1);
                    string definition = msg.getArg(2);
                    txt_misc.Text = msg.getType();
                    txt_def.Text = definition;
                    txt_hint.Text = formatHint(hint);
                }
            }
            else
                txt_misc.Text = "ERROR: IP or Port needed";
        }

        private void but_local_Click(object sender, EventArgs e)
        {
            txt_ip.Text = "127.0.0.1";
            txt_port.Text = "12001";
        }

        private void but_course_Click(object sender, EventArgs e)
        {
            txt_ip.Text = "129.123.41.13";
            txt_port.Text = "12001";
        }    

        private void but_hint_Click(object sender, EventArgs e)
        {
            if (game != null)
            {
                Message response = game.askForHint();
                if (response != null)
                {
                    txt_hint.Text = formatHint(response.getArg(1));
                    txt_misc.Text = response.getType();
                }
            }
        }

        private string formatHint(string h)
        {
            if (h.Length > 0)
                return h + "   (" + h.Length + " letters)";
            return "";
        }

        private void clearTextBoxes()
        {
            txt_score.BackColor = Color.Tan;
            txt_score.Text = "";
            txt_guess.Text = "";
            txt_misc.Text = "";
            txt_hint.Text = "";
            txt_def.Text = "";
        }

        private void but_guess_Click(object sender, EventArgs e)
        {
            if (game != null && !string.IsNullOrEmpty(txt_guess.Text))
            {
                Message guessMsg = game.sendGuess(txt_guess.Text);
                if (guessMsg != null)
                {
                    if (guessMsg.getArg(1) == "T")
                        txt_score.BackColor = Color.SpringGreen;
                    else
                        txt_score.BackColor = Color.Red;
                    txt_score.Text = guessMsg.getArg(2);
                    txt_misc.Text = guessMsg.getType();
                }
            }
        }
    }
}
