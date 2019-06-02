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
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            lbl_status.Text = "Encrypting...";
            if (!File.Exists(tb_file.Text))
                lbl_status.Text = "The file does not exist.";
            if (tb_password.Text.Length == 0)
                lbl_status.Text = "Enter a password.";

            try
            {
                string outfile = encrypt(tb_file.Text, tb_password.Text);
                lbl_status.Text = "Successfully encrypted the file." + $"\nSaved file to: {outfile}";
            }
            catch (Exception)
            {
                lbl_status.Text = "Failed to encrypt the file.";
            }
        }

        private string encrypt(String file, String pass)
        {
            byte[] plainBytes = File.ReadAllBytes(file);
            byte[] encodedBytes = encodeBytes(plainBytes, pass);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, encodedBytes);
            }

            return saveFileDialog.FileName;
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
    }
}


