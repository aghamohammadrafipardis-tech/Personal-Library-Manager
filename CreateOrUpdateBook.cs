using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.DataFormats;



namespace uni_project
{
    public partial class frmCreateOrUpdateBook : Form
    {
        private Book _bookToEdit = null;
        private Action<string, string, string, int, string, int, string, string> _CreateCallback;
        private Action<Book, string, string, string, int, string, int, string, string> _updateCallback;
        private string? _selectedFilePath;
        private bool _hasChanges = false;
        public frmCreateOrUpdateBook(Action<Book, string, string, string, int, string, int, string, string> callback, Book bookToEdit)
        {
            InitializeComponent();
            _updateCallback = callback;
            _bookToEdit = bookToEdit;
        }

        public frmCreateOrUpdateBook(Action<string, string, string, int, string, int, string, string> callback)
        {
            InitializeComponent();
            _CreateCallback = callback;

        }

        private void SetComboBoxSelection(ComboBox comboBox, string valueToMatch, string fallbackText = "سایر")
        {
            int index = comboBox.FindStringExact(valueToMatch);
            if (index != -1)
            {
                comboBox.SelectedIndex = index;
            }
            else
            {
                int fallbackIndex = comboBox.FindStringExact(fallbackText);
                if (fallbackIndex != -1)
                    comboBox.SelectedIndex = fallbackIndex;
                else
                    comboBox.SelectedIndex = -1;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                txtTitle.BackColor = Color.LightCoral;
                MessageBox.Show("عنوان الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                txtTitle.BackColor = SystemColors.Window;

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                txtAuthor.BackColor = Color.LightCoral;
                MessageBox.Show("نام نویسنده الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                txtAuthor.BackColor = SystemColors.Window;


            if (cmbGenre.SelectedIndex < 0)
            {
                cmbGenre.BackColor = Color.LightCoral;
                MessageBox.Show("ژانر الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                cmbGenre.BackColor = SystemColors.Window;


            if (cmbStatus.SelectedIndex < 0)
            {
                cmbStatus.BackColor = Color.LightCoral;
                MessageBox.Show("وضعیت الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                cmbStatus.BackColor = SystemColors.Window;


            if (string.IsNullOrWhiteSpace(rtxtNotes.Text))
            {
                rtxtNotes.BackColor = Color.LightCoral;
                MessageBox.Show("یادداشت شخصی الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                rtxtNotes.BackColor = SystemColors.Window;


            if (string.IsNullOrEmpty(_selectedFilePath))
            {
                MessageBox.Show("انتخاب تصویر جلد کتاب الزامی است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (_bookToEdit == null)
            {
                _CreateCallback.Invoke(txtTitle.Text, txtAuthor.Text, cmbGenre.SelectedItem.ToString(), (int)nudYear.Value, cmbStatus.SelectedItem.ToString(), trbRating.Value, rtxtNotes.Text, _selectedFilePath);

            }
            else
            {
                _updateCallback.Invoke(_bookToEdit, txtTitle.Text, txtAuthor.Text, cmbGenre.SelectedItem.ToString(), (int)nudYear.Value, cmbStatus.SelectedItem.ToString(), trbRating.Value, rtxtNotes.Text, _selectedFilePath);
            }
            this.Close();
        }

        private void frmCreateOrUpdateBook_Load(object sender, EventArgs e)
        {
            if (_bookToEdit != null)
            {
                txtTitle.Text = _bookToEdit.Title;
                txtAuthor.Text = _bookToEdit.Author;
                SetComboBoxSelection(cmbGenre, _bookToEdit.Genre);
                nudYear.Value = _bookToEdit.Year;
                SetComboBoxSelection(cmbStatus, _bookToEdit.Status);
                trbRating.Value = _bookToEdit.Rating;
                rtxtNotes.Text = _bookToEdit.Notes;
                _selectedFilePath = _bookToEdit.CoverPath;
                lblCoverPath.Text = $"تصویر جلد کتاب ({Path.GetFileName(_selectedFilePath)})";
            }
            lblRating.Text = $"امتیاز ({trbRating.Value})";


            txtTitle.TextChanged += MarkAsChanged;
            txtAuthor.TextChanged += MarkAsChanged;
            cmbGenre.TextChanged += MarkAsChanged;
            nudYear.ValueChanged += MarkAsChanged;
            cmbStatus.TextChanged += MarkAsChanged;
            trbRating.ValueChanged += MarkAsChanged;
            rtxtNotes.TextChanged += MarkAsChanged;

        }

        private void btnOpenfile_Click(object sender, EventArgs e)
        {
            if (ofdCoverPath.ShowDialog() == DialogResult.OK)
            {
                _selectedFilePath = ofdCoverPath.FileName;
                lblCoverPath.Text = $"تصویر جلد کتاب ({Path.GetFileName(_selectedFilePath)})";
                MarkAsChanged(sender,e);
            }
        }

        private void trbRating_ValueChanged(object sender, EventArgs e)
        {
            lblRating.Text = $"امتیاز ({trbRating.Value})";
        }

        private void MarkAsChanged(object sender, EventArgs e)
        {
            _hasChanges = true;
        }

        private void frmCreateOrUpdateBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_hasChanges)
                return;

            DialogResult result = MessageBox.Show(
            "شما تغییرات دخیره نشده دارید ایا میخواهید تغییرات دخیره شوند؟",
            "تغییرات دخیره نشده",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                btnSubmit.PerformClick();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
