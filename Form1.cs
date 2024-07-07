using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Latih10_KonekDataBase
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DaftarSiswa();
        }
        public string gender = "";

        public void DaftarSiswa()
        {
            var db = new SekolahDbContext();
            var ListSiswa = db.siswa1.ToList();
            dataGridView1.DataSource = ListSiswa;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            NewSiswa();
        }

        public void NewSiswa()
        {
            var NewSiswa = new SiswaModel();
            using var db = new SekolahDbContext();
            db.siswa1.Add(NewSiswa);
            db.SaveChanges();

            ShowInput(NewSiswa);
        }

        public void ShowInput(SiswaModel siswa)
        {
            txtSiswaID.Text = siswa.SiswaID.ToString();
            txtSiswaName.Text = siswa.SiswaName;
            txtNIS.Text = siswa.NIS;
            txtTempatLahir.Text = siswa.TempatLahir;
            dateTimePicker1.Value = siswa.TanggalLahir;

            txtAlamat.Text = siswa.Alamat;
            txtKota.Text = siswa.Kota;

            tabControl1.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            ListData();
        }
        public void ListData()
        {
            using var db = new SekolahDbContext();
            var listSiswa = db.siswa1.ToList();
            dataGridView1.DataSource = listSiswa;
            tabControl1.SelectedIndex = 0;
        }
        public void SaveData()
        {
            using var db = new SekolahDbContext();
            var siswa = db.siswa1.Find(int.Parse(txtSiswaID.Text));

            siswa.SiswaName = txtSiswaName.Text;
            siswa.NIS = txtNIS.Text;
            siswa.TanggalLahir = dateTimePicker1.Value;
            siswa.TempatLahir = txtTempatLahir.Text;
            siswa.Gender = gender;
            siswa.Alamat = txtAlamat.Text;
            siswa.Kota = txtKota.Text;

            db.SaveChanges();
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var siswaID = dataGridView1.CurrentRow.Cells["SiswaID"].Value.ToString();
            if (siswaID is null)
                return;

            using var db = new SekolahDbContext();
            var Siswa = db.siswa1.Find(int.Parse(siswaID));
            ShowInput(Siswa);
        }



        private void radioLaki_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Laki-Laki";
        }

        private void radioPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Perempuan";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Delete();
            ListData();
        }

        public void Delete()
        {
            var siswaID = dataGridView1.CurrentRow.Cells["SiswaID"].Value.ToString();
            using var db = new SekolahDbContext();
            var siswa = db.siswa1.Find(int.Parse(siswaID));

            if (siswa != null)
            {
                db.siswa1.Remove(siswa);
                db.SaveChanges();
                dataGridView1.Refresh();
                tabControl1.SelectedIndex  = 0;
                
            }
           
        }
    }
}
