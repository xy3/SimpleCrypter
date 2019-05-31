using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SimpleCrypter
{
    public partial class SimpleCrypter : Form
    {
        public SimpleCrypter()
        {
            InitializeComponent();
            tb_password.Text = RandomString(15);
            tb_outdir.Text = Directory.GetCurrentDirectory();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tb_file.Text))
                lbl_status.Text = "The file does not exist.";
            if (tb_outfile.Text.Length == 0)
                lbl_status.Text = "Enter an output filename.";
            if (tb_password.Text.Length == 0)
                lbl_status.Text = "Enter a password.";

            string outfile = tb_outdir.Text + tb_outfile.Text;
            try
            {
                encrypt(tb_file.Text, tb_password.Text, outfile);
                lbl_status.Text = "Successfully encrypted the file." + $"\nSaved file to: {outfile}";
            }
            catch (Exception)
            {
                lbl_status.Text = "Failed to encrypt the file.";
            }
        }

        private void encrypt(String file, String pass, String outfile)
        {
            byte[] plainBytes = File.ReadAllBytes(file);
            byte[] encodedBytes = encodeBytes(plainBytes, pass);

            File.WriteAllBytes(outfile, encodedBytes);
        }

        private static byte[] encodeBytes(byte[] bytes, String pass)
        {
            byte[] XorBytes = Encoding.Unicode.GetBytes(pass);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] ^= XorBytes[i % 16];
            }

            return bytes;
        }

        private void btn_randpw_Click(object sender, EventArgs e)
        {
            tb_password.Text = RandomString(15);
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                tb_file.Text = filedialog.FileName;
            }
        }

        private void btn_outfile_Click(object sender, EventArgs e)
        {
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                tb_outdir.Text = folder_dialog.SelectedPath;
            }
        }
    }
}


