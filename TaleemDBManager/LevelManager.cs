using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace TaleemDBManager
{
    public partial class LevelManager : MetroForm
    {
        public LevelManager()
        {
            InitializeComponent();
            AddPhaseBtn.Style = MetroColorStyle.Orange;
            DelPhaseBtn.Style = MetroColorStyle.Red;
            SetPhaseBtn.Style = MetroColorStyle.Purple;
            addPhonicsBtn.Style = MetroColorStyle.Green;
            delPhonicsBtn.Style = MetroColorStyle.Teal;
            addDelWordBtn.Style = MetroColorStyle.Lime;
        }

        private void AddPhaseBtn_Click(object sender, EventArgs e)
        {
            AddPhase add = new AddPhase();
            add.Show();
        }

        private void DelPhaseBtn_Click(object sender, EventArgs e)
        {
            DeletePhase delete = new DeletePhase();
            delete.Show();
        }

        private void SetPhaseBtn_Click(object sender, EventArgs e)
        {
            SetPhases set = new SetPhases();
            set.Show();
        }

        private void addPhonicsBtn_Click(object sender, EventArgs e)
        {
            AddPhonicWords add = new AddPhonicWords();
            add.Show();
        }

        private void delPhonicsBtn_Click(object sender, EventArgs e)
        {
            DeletePhonicWords del = new DeletePhonicWords();
            del.Show();
        }

        private void addDelWordBtn_Click(object sender, EventArgs e)
        {
            AddDeleteWord addDel = new AddDeleteWord();
            addDel.Show();
        }
    }
}
