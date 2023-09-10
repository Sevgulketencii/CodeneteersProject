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
    public partial class RestForm : Form
    {
        UserManager user = new UserManager(new UserDAL());
        RestManager rest = new RestManager(new RestDAL());
        public RestForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            DateTime baslangic = baslangicTarih.Value.Date;
            DateTime bitis = bitisTarih.Value.Date;
            TimeSpan fark = bitis - baslangic;
            var günSayisi = fark.Days;
            var result = IzınAL(baslangic, bitis, günSayisi);
            if (result == 0)
            {
                MessageBox.Show("İzin talebiniz iletilemedi.", "Uyarı!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            if (result == -1)
            {
                MessageBox.Show("İzin talebiniz iletilemedi. Başlangıç tarihi bitiş tarihinden büyük olamaz", "Uyarı!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("İzin talebiniz başarıyla iletilmiştir.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int IzınAL(DateTime bas, DateTime bit, int gun)
        {
            var User = user.GetByID(1);

            if (bas != null && bit != null & gun != 0 )
            {
                if (bas > bit) {
                    return -1;
                }

                Rest izin = new Rest()
                {
                    userID = User.ID,
                    isAccepted = false,
                    startDate = bas,
                    endDate = bit,
                    day = gun,
                    status = true,
                };
                rest.add(izin);
                return 1;
            }
            else
            {
                return 0;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
