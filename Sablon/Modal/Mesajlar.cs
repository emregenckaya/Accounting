using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Modal
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {            
            MessageBox.Show(mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir.\n Güncelleme işlemini onaylıyormusunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrardan yapmak istediğinize eminmisiniz?", "Kayıt Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyormusunuz?", "Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt başarıyla güncellenmiştir.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Kayit(bool kayit)
        {
            MessageBox.Show("Aynı kayıt tekrardan kaydedilmiştir.", "Kayıt Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public DialogResult Yazdir()
        {
            return MessageBox.Show("Kaydı yazdırmak istiyormusunuz?", "Yazdırma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
