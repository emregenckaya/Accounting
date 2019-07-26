using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Model
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Secili olan kayıt güncellenecektir.\nGüncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrar yapmak istediğinize emin misiniz?", "Kayıt Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Kayıt kalıcı olarak silinecektir.\nSilme işlemini onaylıyor musunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt başarıyla güncellenmiştir.", "Güncelleme bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Kayit(bool kayit)
        {
            MessageBox.Show("Aynı kayıt tekrardan kaydedilmiştir.", "Kayıt Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult Yazdir()
        {
            return MessageBox.Show("Kaydı yazdırmak istiyor musunuz?", "Yazdırma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
