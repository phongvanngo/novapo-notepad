using Microsoft.VisualBasic;
using Notepad.Forms;
using NotepadBackEnd;
using NotepadBackEnd.MyFunction;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainForm : Form
    {

        FileManipulation fileManipulation;
        EditManipulation editManipulation;
        Timer timer;
        FormFind formFind;
        FormReplace formReplace;

        public EditManipulation EditManipulation { get => editManipulation; set => editManipulation = value; }

        public MainForm()
        {
            InitializeComponent();
            fileManipulation = new FileManipulation();
            editManipulation = new EditManipulation();

            fileManipulation.InitializeNewFile();
            this.Text = fileManipulation.Filename;

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 500;

            txtContent.HideSelection = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            editManipulation.Add_UndoRedo(txtContent.Text);
            UpdateView();
            findnextEditMenu.Enabled = findEditMenu.Enabled;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtContent.WordWrap = wordwrapFormatMenu.Checked;
            statusbarViewMenu.Enabled = !wordwrapFormatMenu.Checked;
            if (statusbarViewMenu.Enabled)
                statusbarViewMenu.Checked = true;
            statusContent.Visible = statusbarViewMenu.Checked;
        }

        private void txtContent_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatus();
        }
        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            fileManipulation.IsFileSaved = false;
            if (editManipulation.TxtContent_TextChangeRequired)
            {
                timer.Start();
            }
            else
            {
                editManipulation.TxtContent_TextChangeRequired = false;
            }
            UpdateView();
        }


        //file menu-----------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        private void newFileMenu_Click(object sender, System.EventArgs e)
        {
            // file da save -> tao moi file
            if (fileManipulation.IsFileSaved)
            {
                fileManipulation.InitializeNewFile();
                txtContent.Text = "";
                UpdateView();
            }
            // file chua save -> save request
            else
            {
                DialogResult result = MessageBox.Show("Do you need save changes to " + fileManipulation.Filename, "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //user click yes to save
                if (result == DialogResult.Yes)
                {
                    //file save for the frist time.
                    if (fileManipulation.FileLocation == "")
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Text(*.txt)|*.txt";
                        if (newFileSave.ShowDialog() == DialogResult.OK)
                        {
                            fileManipulation.SaveFile(newFileSave.FileName, txtContent.Lines);
                            UpdateView();
                        }
                    }
                    //file already save 
                    else
                    {
                        fileManipulation.SaveFile(fileManipulation.Filename, txtContent.Lines);
                        UpdateView();
                    }

                    txtContent.Text = "";
                    fileManipulation.InitializeNewFile();
                    UpdateView();

                }
                //user chon not to save -> initialize a new file
                else if (result == DialogResult.No)
                {
                    txtContent.Text = "";
                    fileManipulation.InitializeNewFile();
                    UpdateView();
                }

            }
        }

        private void UpdateView()
        {
            this.Text = !fileManipulation.IsFileSaved ? fileManipulation.Filename + "*" : fileManipulation.Filename;
            undoEditMenu.Enabled = editManipulation.CanUndo() ? true : false;
        }

        
        private void openFileMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text(*.txt)|*.txt";
            openFile.InitialDirectory = "D:";
            openFile.Title = "Open File";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtContent.TextChanged -= txtContent_TextChanged;
                txtContent.Text = fileManipulation.OpenFile(openFile.FileName);
                txtContent.TextChanged += txtContent_TextChanged;
                UpdateView();
            }
        }
        private void SaveFile()
        {
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.Filter = "Text(*.txt)|*.txt";
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                fileManipulation.SaveFile(fileSave.FileName, txtContent.Lines);
                UpdateView();
            }
        }

        private void saveFileMenu_Click(object sender, EventArgs e)
        {
            if (!fileManipulation.IsFileSaved)
            {
                //if (!this.Text.Contains("Untitled.txt"))
                if (fileManipulation.FileLocation != "")
                {
                    fileManipulation.SaveFile(fileManipulation.FileLocation, txtContent.Lines);
                    UpdateView();
                }
                else
                {
                    SaveFile();
                }
            }
        }

        private void exitFileMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtContent.Text, new Font("Arial", 20), Brushes.Black, 12, 20);
        }

        private void printFileMenu_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void pagesetupFileMenu_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        //edit menu-----------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        private void editMenu_Click(object sender, EventArgs e)
        {
            cutEditMenu.Enabled = txtContent.SelectedText.Length > 0 ? true : false;
            copyEditMenu.Enabled = txtContent.SelectedText.Length > 0 ? true : false;
            pasteEditMenu.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);
        }

        private void editMenu_MouseEnter(object sender, EventArgs e)
        {
            //truong hop bam mot menu khac, hover qua menu Edit thi Cut copy van duoc kich hoat
            editMenu_Click(sender, e);
        }
        private void cutEditMenu_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
            pasteEditMenu.Enabled = true;
        }

        private void copyEditMenu_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
            pasteEditMenu.Enabled = true;
        }

        private void pasteEditMenu_Click_1(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
                txtContent.Paste();
        }

        private void selectallEditMenu_Click(object sender, EventArgs e)
        {
            txtContent.SelectAll();
        }

        private void deleteEditMenu_Click(object sender, EventArgs e)
        {
            txtContent.Text = txtContent.Text.Remove(txtContent.SelectionStart, txtContent.SelectionLength);
        }

        private void timedateEditMenu_Click(object sender, EventArgs e)
        {
            txtContent.Text = txtContent.Text.Insert(txtContent.SelectionStart, editManipulation.DateTime_Now());
        }

        private void undoEditMenu_Click(object sender, EventArgs e)
        {
            if (!editManipulation.CanUndo()) return;
            txtContent.Text = editManipulation.UndoClicked();
            UpdateView();
        }

        private void gotoEditMenu_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Line Number", "Go To", "1");
            try
            {
                int line = Convert.ToInt32(input);
                if (line > txtContent.Lines.Length)
                {
                    MessageBox.Show("Total lines in the file is " + txtContent.Lines.Length, "Can't Reach",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] lines = txtContent.Lines;
                    int len = 0;
                    for (int i = 0; i < line - 1; i++)
                    {
                        len = len + lines[i].Length + 1;
                    }
                    txtContent.Focus();
                    txtContent.Select(len, 0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid Integer", "Wrong Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void findEditMenu_Click(object sender, EventArgs e)
        {
            if (formFind == null)
            {
                formFind = new FormFind(this);
                formFind.Editor = txtContent;
            }
            formFind.Show();
        }

        private void findnextEditMenu_Click(object sender, EventArgs e)
        {
            formFind.UpdateSearchQuery();
            if (formFind.Qry.SearchString.Length == 0)
            {
                formFind.Show();
            }
            else
            {
                FindNextResult result = editManipulation.FindNext(formFind.Qry);
                if (result.SearchStatus)
                    txtContent.Select(result.SelectionStart, formFind.Qry.SearchString.Length);
            }
        }

        private void replaceEditMenu_Click_1(object sender, EventArgs e)
        {
            if (formReplace == null)
            {
                formReplace = new FormReplace();
                formReplace.Editor = txtContent;
                formReplace.editManipulation = editManipulation;
            }
            formReplace.Show();
        }



        //key shortcut manager-----------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        private void txtContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        e.SuppressKeyPress = true;
                        undoEditMenu_Click(null, null);
                        break;
                    case Keys.C:
                        e.SuppressKeyPress = true;
                        copyEditMenu_Click(null, null);
                        break;                    
                    case Keys.V:
                        e.SuppressKeyPress = true;
                        pasteEditMenu_Click_1(null, null);
                        break;


                }
            }
        }


        //view menu-----------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
    
        private void wordwrapFormatMenu_CheckedChanged(object sender, EventArgs e)
        {
            txtContent.WordWrap = wordwrapFormatMenu.Checked;
            statusbarViewMenu.Enabled = !wordwrapFormatMenu.Checked;
            statusbarViewMenu.Checked = true;
            statusContent.Visible = statusbarViewMenu.Checked;
        }

        private void statusbarViewMenu_CheckedChanged(object sender, EventArgs e)
        {
            statusContent.Visible = statusbarViewMenu.Checked;
        }

        private void UpdateStatus()
        {
            int pos = txtContent.SelectionStart;
            int line = txtContent.GetLineFromCharIndex(pos) + 1;
            int col = pos - txtContent.GetFirstCharIndexOfCurrentLine() + 1;

            PositionStatus.Text = "Ln " + line + ", Col " + col;
        }

        //format menu-----------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------
        private void fontFormatMenu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = txtContent.Font;
            fontDialog.Color = txtContent.ForeColor;
            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtContent.Font = fontDialog.Font;
                txtContent.ForeColor = fontDialog.Color;
            }
        }

        private void aboutnotepadHelpMenu_Click(object sender, EventArgs e)
        {
            FormAbout aboutForm = new FormAbout();
            aboutForm.ShowDialog();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/search?source=hp&ei=5y7vWtHkJsrxvgT34reADg&q=notepad+using+c%23&oq=notepad+using+c%23&gs_l=psy-ab.3..0j0i22i30k1l9.100016.102766.0.103103.18.14.0.0.0.0.277.2296.0j5j6.11.0....0...1.1.64.psy-ab..7.11.2293.0..35i39k1j0i131k1j0i3k1.0.vqO-K4vUFLU");
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm newWindow = new MainForm();
            newWindow.Show();
        }

        


        //Zoom feature

        private float zoomFactor = 1.0f;
        private int int_zoom_factor = 100;
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zoomFactor<5)
            {
                zoomFactor += 0.5f;
                txtContent.ZoomFactor = zoomFactor;
                int_zoom_factor += 50;
                status_zoom_factor.Text = int_zoom_factor.ToString()+"%";

            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zoomFactor > 1)
            {
                zoomFactor -= 0.5f;
                txtContent.ZoomFactor = zoomFactor;
                int_zoom_factor -= 50;
                status_zoom_factor.Text = int_zoom_factor.ToString()+"%";

            }
        }

        private void restoreDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor = 1.0f;
            status_zoom_factor.Text = "100%";
        }
    }
}
