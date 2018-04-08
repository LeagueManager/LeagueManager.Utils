using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManager.Utils
{
    public class CompararPontos : IComparer
    {
        private int columnindex = 1;
        public int Compare(object x, object y)
        {
            return - String.Compare(((ListViewItem)x).SubItems[columnindex].Text, ((ListViewItem)y).SubItems[columnindex].Text);
        }
    }
}
