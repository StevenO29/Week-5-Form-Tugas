using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_WinForm
{
    public partial class FormTugas : Form
    {
        public FormTugas()
        {
            InitializeComponent();
        }

        private void FormTugas_Load(object sender, EventArgs e)
        {
            leftListBox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem == null)
                MessageBox.Show("Mode belum dipilih!");
            else if (comboBoxMode.SelectedItem.ToString() == "Add")
            {
                if (TxtBoxData.Text == null)
                    MessageBox.Show("Input belum diisi!");
                else
                    leftListBox.Items.Add(TxtBoxData.Text);
            }
            else if (comboBoxMode.SelectedItem.ToString() == "Replace")
            {
                if (leftListBox.SelectedItem == null)
                    MessageBox.Show("Pilih data dulu!");
                else if (leftListBox.SelectedItems.Count == 1)
                {
                    leftListBox.Items.RemoveAt(leftListBox.SelectedIndex);
                    leftListBox.Items.Insert(leftListBox.SelectedIndex, TxtBoxData.Text);
                }
                else
                    MessageBox.Show("Replace hanya dapat mengganti 1 data saja");
            }
        }

        private void chBoxBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxBlock.Checked == true)
            {
                btnMoveAllToLeft.Enabled = false;
                btnMoveAllToRight.Enabled = false;
                btnMoveToLeft.Enabled = false;
                btnMoveToRight.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnMoveAllToLeft.Enabled = true;
                btnMoveAllToRight.Enabled = true;
                btnMoveToLeft.Enabled = true;
                btnMoveToRight.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnMoveAllToRight_Click(object sender, EventArgs e)
        {
            while (leftListBox.Items.Count > 0)
            {
                string item = (string)leftListBox.Items[0];
                listBoxRight.Items.Add(item);
                leftListBox.Items.Remove(item);
            }
        }

        private void btnMoveToRight_Click(object sender, EventArgs e)
        {
            string item = leftListBox.SelectedItem.ToString();
            listBoxRight.Items.Add(item);
            leftListBox.Items.Remove(item);
        }

        private void btnMoveToLeft_Click(object sender, EventArgs e)
        {
            string item = listBoxRight.SelectedItem.ToString();
            leftListBox.Items.Add(item);
            listBoxRight.Items.Remove(item);
        }

        private void btnMoveAllToLeft_Click(object sender, EventArgs e)
        {
            while (listBoxRight.Items.Count > 0)
            {
                string item = (string)listBoxRight.Items[0];
                leftListBox.Items.Add(item);
                listBoxRight.Items.Remove(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            leftListBox.Items.Remove(leftListBox.SelectedItem);
            listBoxRight.Items.Remove(listBoxRight.SelectedItem);

        }
    }
}
