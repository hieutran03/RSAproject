using System.Numerics;
using System.Text;

namespace RSAproject
{
    public partial class Form1 : Form
    {
        bool flag1, flag2;
        long p;
        long q;
        long N;
        long phiN;
        long e;
        long d;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            e = Int64.Parse(tbPublicKey.Text);
        }

        private void btnGeneratePrime_Click(object sender, EventArgs e)
        {
            /*int numOfBits = int.Parse(tbNumOfBits.Text);
            long p = helper.largePrimeGenerator(numOfBits);
            long q = helper.largePrimeGenerator(numOfBits);
            tbPrimeNumberP.Text = p.ToString();
            tbPrimeNumberQ.Text = q.ToString();
            */
            using (var form = new generator())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    p = Int64.Parse(form.ReturnValue1);
                    q = Int64.Parse(form.ReturnValue2);
                    tbPrimeNumberP.Text = p.ToString();
                    tbPrimeNumberQ.Text = q.ToString();
                }
            }
        }

        private void tbPrimeNumberP_TextChanged(object sender, EventArgs e)
        {
            if (tbPrimeNumberP.Text.Length > 0)
            {
                flag1 = true;
            }
            else
            {
                flag1 = false;
            }
            if (flag1 && flag2)
            {
                calculateParams();
            }
        }

        private void tbPrimeNumberQ_TextChanged(object sender, EventArgs e)
        {
            if (tbPrimeNumberQ.Text.Length > 0)
            {
                flag2 = true;
            }
            else
            {
                flag2 = false;
            }
            if (flag2 && flag1)
            {
                calculateParams();
            }
        }
        private void calculateParams()
        {
            N = p * q;
            tbRSAmodulusN.Text = N.ToString();
            phiN = (p - 1) * (q - 1);
            tbPhiN.Text = phiN.ToString();
            d = ModInverse(e, phiN);
            tbPrivateKey.Text = d.ToString();

        }
        private static long ModInverse(long a, long m)
        {
            long m0 = m;
            long y = 0, x = 1;

            while (a > 1)
            {
                long q = a / m;
                long t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }
            x = (x % m0 + m0) % m0;

            return x;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rdoNumber.Checked)
            {
                numberEncrypt();
            }
            else
            {
                textEncrypt();
            }
        }

       

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rdoNumber.Checked)
            {
                numberDecrypt();
            }
            else
            {
                textDecrypt();
            }
        }
        private void textEncrypt()
        {
            if (!CheckParameters())
                return;

            string plaintext = tbInput.Text;
            BigInteger encryptedText = EncryptText(plaintext);

            tbOutput.Text = encryptedText.ToString();
        }

        private void numberEncrypt()
        {
            if (!CheckParameters())
                return;

            long plaintextNumber;
            if (long.TryParse(tbInput.Text, out plaintextNumber))
            {
                long encryptedNumber = EncryptNumber(plaintextNumber);

                tbOutput.Text = encryptedNumber.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for encryption.");
            }
        }

        private void textDecrypt()
        {
            if (!CheckParameters())
                return;

            BigInteger ciphertext = BigInteger.Parse(tbInput.Text);
            string decryptedText = DecryptText(ciphertext);

            tbOutput.Text = decryptedText;
        }

        private void numberDecrypt()
        {
            // Kiểm tra xem các giá trị cần thiết đã được nhập đúng chưa
            if (!CheckParameters())
                return;

            long ciphertext;
            if (long.TryParse(tbInput.Text, out ciphertext))
            {
                long decryptedNumber = DecryptNumber(ciphertext);

                tbOutput.Text = decryptedNumber.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for decryption.");
            }
        }

        private BigInteger EncryptText(string plaintext)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(plaintext);
            BigInteger plaintextNumber = new BigInteger(bytes);

            return EncryptNumber((long)plaintextNumber);
        }

        private string DecryptText(BigInteger ciphertext)
        {
            long decryptedNumber = DecryptNumber((long)ciphertext);

            byte[] bytes = BitConverter.GetBytes(decryptedNumber);
            return Encoding.UTF8.GetString(bytes);
        }

        private long EncryptNumber(long plaintextNumber)
        {
            // Mã hóa số nguyên: c = plaintext^e mod N
            return helper.expmod(plaintextNumber, e, N);
        }

        private long DecryptNumber(long ciphertext)
        {
            // Giải mã số nguyên: plaintext = ciphertext^d mod N
            return helper.expmod(ciphertext, d, N);
        }

        
         private bool CheckParameters()
         {
            if (string.IsNullOrEmpty(tbInput.Text))
            {
                MessageBox.Show("Please provide input and ensure that the parameters are calculated.");
                return false;
            }
            return true;
         }
    }
}
