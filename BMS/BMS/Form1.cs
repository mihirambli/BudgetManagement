using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu;
using System.Runtime.InteropServices;
namespace BMS
{
    public partial class home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        CalenderUserControl calenderUserControl = new CalenderUserControl();
        public home()
        {
            
           // InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void hidePanel() { 
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelRight.Visible = false;
            PanelTop.Visible = false;
            panel1.Visible = false;

            calenderUserControl.BringToFront();
            calenderUserControl.Visible = true;
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void b0_Click(object sender, EventArgs e)
        {
            //PanelCalender.Visible = false;
           // PanelCalenderTop.Visible = false;

            PanelTop.Visible = true;
            PanelRight.Visible = true;
            panel1.Visible = true;
        }   

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCategory(object sender, EventArgs e)
        {
            //ListCategory.Items.Add("added");
            using (AddDialogue addDialogue = new AddDialogue())
            {
                addDialogue.ShowDialog();
            }
        }

        private void UpdateCategory(object sender, EventArgs e)
        {
            //ListCategory.Items.Add("updated");
            using (UpdateDialogue updateDialogue = new UpdateDialogue())
            {
                updateDialogue.ShowDialog();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //ListCategory.Items.Add("added");
            using (AddDialogue addDialogue = new AddDialogue())
            {
                addDialogue.ShowDialog();
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            //ListCategory.Items.Add("updated");
            using (UpdateDialogue updateDialogue = new UpdateDialogue())
            {
                updateDialogue.ShowDialog();
            }
        }

        private void ButtonTransactionAdd_Click(object sender, EventArgs e)
        {
            using (AddTransactionDialogue addTransactionDialogue = new AddTransactionDialogue())
            {
                addTransactionDialogue.ShowDialog();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            using (UpdateTransactionDialog updateTransactionDialog = new UpdateTransactionDialog())
            {
                updateTransactionDialog.ShowDialog();
            }
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b2_Click(object sender, EventArgs e)
        {

        }
    }
}
