using BusinessLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeneteersProject
{
    public partial class WishAndSuggestionForm : Form
    {
        SuggestionsManager suggestionsManager = new SuggestionsManager(new SuggestionsDAL());
        PermissionsManager permissions = new PermissionsManager(new PermissionsDAL());
        Suggestion suggestion;

        private void ClearInputs()
        {
            issueTextBox.Text = string.Empty;
            messageTextBox.Text = string.Empty;
        }

        public WishAndSuggestionForm()
        {
            InitializeComponent();
        }

        private void WishAndSuggestionForm_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(issueTextBox.Text) || !string.IsNullOrEmpty(messageTextBox.Text))
            {
                suggestion = new Suggestion();
                suggestion.title = issueTextBox.Text;
                suggestion.description = messageTextBox.Text;
                suggestion.companyID = 1;
                suggestion.status = true;
                suggestionsManager.add(suggestion);
                MessageBox.Show("Kayıt başarı ile eklendi", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                //goToDashboard
            }

            else
            {
                switch (MessageBox.Show("Konu ya da ileti alanı boş bırakılamaz.", "Uyarı!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Cancel:
                        ClearInputs();
                        //goToDashboard
                        break;
                    case DialogResult.Retry:
                        ClearInputs();
                        break;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
