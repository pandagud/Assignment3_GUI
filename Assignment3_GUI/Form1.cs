using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weapon_Decorator;

namespace Assignment3_GUI
{
    public partial class Form1 : Form
    {
        private Weapon firsWeapon;
        public Form1()
        {
            
            InitializeComponent();

            //Going full screen
            GoFullscreen(false);
            
             //Object to show
             firsWeapon = new Weapon();

            //initialize Views with custom settings 
            checkifElementisPickedComboBox();
            initListView();
            initComboBox();

            //Update labes. Needs to be called everytime button is pressed.
            UpdateLabels(firsWeapon);
            
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting selected item to weapon object.
            var item =  listviewofweapons.SelectedItems[0];
            Weapon currentWeapon = (Weapon) item.Tag;
            //Adding custom modificere, eg. scope.
            listviewofweapons.Items.Add("Scope", "Added a Scope", -2);
            UpdateListview();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chooseweaponcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseweaponcombobox.Items.Add(firsWeapon);
            insertObjectInListview(firsWeapon);
            checkifElementisPickedComboBox();
            UpdateListview();

        }

        public void checkifElementisPickedComboBox()
        {
            if (chooseweaponcombobox.SelectedIndex == -1)
            {
                Silencerbbt.Enabled = false;
                Scopebbt.Enabled = false;
                Caliberbbt.Enabled = false;
            }
            else
            {
                Silencerbbt.Enabled = true;
                Scopebbt.Enabled = true;
                Caliberbbt.Enabled = true;
            }
        }

        private void insertObjectInListview(Weapon weapon)
        {

            //methode to add weapon object into View.
            ListViewItem item = new ListViewItem();
            item.Text = weapon.ToString();
            item.Tag = weapon;
            item.SubItems.Add("SomeCost");
            listviewofweapons.Items.Add(item);
           
        }

        private void UpdateListview()
        {
            listviewofweapons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
           listviewofweapons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listviewofweapons.Update();
        }
        private void initListView()
        {
            listviewofweapons.View = View.Details;
            
            listviewofweapons.Columns.Add("Weapon", -2, HorizontalAlignment.Left);
            listviewofweapons.Columns.Add("Cost", -2, HorizontalAlignment.Left);
            listviewofweapons.Columns.Add("TotalCost", -2, HorizontalAlignment.Left);


        }

        private void initComboBox()
        {
            chooseweaponcombobox.Items.Add(new WeaponsNAmeMANGLERDENHERLASSe("Rifle").getName());
            chooseweaponcombobox.Items.Add(new WeaponsNAmeMANGLERDENHERLASSe("UZI").getName());

        }

        private void UpdateLabels(Weapon weapon)
        {

            //Call everytime button is pressed to update label view.
            silencervalue.Text = weapon.Loudness.ToString();
            calibervalue.Text = weapon.Velocity.ToString();
            scopevalue.Text = weapon.Accuracy.ToString();
        }

        private void GoFullscreen(bool fullscreen)
        {

            //ConsoleWindow full screen.
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

      

      
    }
}
