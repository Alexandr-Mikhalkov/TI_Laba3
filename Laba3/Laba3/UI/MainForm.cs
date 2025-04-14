using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Laba3
{
    public partial class MainForm : Form
    {
        private CryptoSystem _rabinSystem = new CryptoSystem();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeFileType(object sender, EventArgs e)
        {
            if (plainRadioButton.Checked)
            {
                plainResRadioButton.Checked = false;
                cipherResRadioButton.Checked = true;
            }
            else
            {
                plainResRadioButton.Checked = true;
                cipherResRadioButton.Checked = false;
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            pTextBox.Clear();
            qTextBox.Clear();
            bTextBox.Clear();
            plainTextBox.Clear();
            resultTextBox.Clear();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (plainRadioButton.Checked)
            {
                PlaintextOpenFile();
            }
            else
            {
                CiphertextOpenFile();
            }
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (plainRadioButton.Checked)
            {
                CiphertextSaveFile();
            }
            else
            {
                PlaintextSaveFile();
            }
        }

        private void PlaintextOpenFile()
        {
            if (plainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(plainOpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    List<BigInteger> plaintextBytes = new List<BigInteger>();
                    while (fs.Position < fs.Length)
                    {
                        int symbol = fs.ReadByte();
                        plaintextBytes.Add(symbol);
                    }

                    StringBuilder plaintextString = new StringBuilder();
                    if (plaintextBytes.Count <= 200)
                    {
                        plaintextString.Append(string.Join(" ", plaintextBytes));
                    }
                    else
                    {
                        // 100..100
                        var firstPart = plaintextBytes.Take(100);
                        var lastPart = plaintextBytes.Skip(plaintextBytes.Count - 100);
                        plaintextString.Append(string.Join(" ", firstPart));
                        plaintextString.Append(" ... ");
                        plaintextString.Append(string.Join(" ", lastPart));
                    }

                    _rabinSystem.plaintext = plaintextBytes.ToArray();
                    plainTextBox.Text = plaintextString.ToString();
                }

                _rabinSystem.ciphertext = null;
                resultTextBox.Text = "";
            }
        }

        private void CiphertextOpenFile()
        {
            if (cipherOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                int size = 0;
                BigInteger localN = BigInteger.Parse(pTextBox.Text) * BigInteger.Parse(qTextBox.Text); 
                while (localN > 0)
                {
                    localN /= 255;
                    size++;
                }

                using (FileStream fs = new FileStream(cipherOpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    if (fs.Length % size != 0)
                    {
                        MessageBox.Show("Некорректное содержимое файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    List<BigInteger> plaintextBytes = new List<BigInteger>();
                    while (fs.Position < fs.Length)
                    {
                        BigInteger plainNumber = 0;
                        BigInteger multiplier = 1;
                        for (int i = 0; i < size; i++)
                        {
                            int byteValue = fs.ReadByte();
                            plainNumber += byteValue * multiplier;
                            multiplier *= 255;
                        }
                        plaintextBytes.Add(plainNumber);
                    }

                    StringBuilder plaintextString = new StringBuilder();
                    if (plaintextBytes.Count <= 200)
                    {
                        plaintextString.Append(string.Join(" ", plaintextBytes));
                    }
                    else
                    {
                        // 100..100
                        var firstPart = plaintextBytes.Take(100);
                        var lastPart = plaintextBytes.Skip(plaintextBytes.Count - 100);
                        plaintextString.Append(string.Join(" ", firstPart));
                        plaintextString.Append(" ... ");
                        plaintextString.Append(string.Join(" ", lastPart));
                    }

                    _rabinSystem.plaintext = plaintextBytes.ToArray();
                    plainTextBox.Text = plaintextString.ToString();
                }

                _rabinSystem.ciphertext = null;
                resultTextBox.Text = "";
            }
        }

        private void PlaintextSaveFile()
        {
            if (plainSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < _rabinSystem.ciphertext.Length; i++)
                {
                    if (_rabinSystem.ciphertext[i] < 0 || _rabinSystem.ciphertext[i] > 255)
                    {
                        MessageBox.Show("Соответствие диапазону 0..255 не выполняется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                using (FileStream fs = new FileStream(plainSaveFileDialog.FileName, FileMode.Create))
                {
                    for (int i = 0; i < _rabinSystem.ciphertext.Length; i++)
                    {
                        fs.WriteByte((byte)_rabinSystem.ciphertext[i]);
                    }
                }
            }
        }

        private void CiphertextSaveFile()
        {
            if (cipherSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int size = 0;
                BigInteger localN = BigInteger.Parse(pTextBox.Text) * BigInteger.Parse(qTextBox.Text);
                while (localN > 0)
                {
                    localN /= 255;
                    size++;
                }

                using (FileStream fs = new FileStream(cipherSaveFileDialog.FileName, FileMode.Create))
                {
                    for (int i = 0; i < _rabinSystem.ciphertext.Length; i++)
                    {
                        BigInteger cipherNumber = _rabinSystem.ciphertext[i];
                        for (int j = 0; j < size; j++)
                        {
                            fs.WriteByte((byte)(cipherNumber % 255));
                            cipherNumber /= 255;
                        }
                    }
                }
            }    
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(pTextBox.Text, out BigInteger p) || !BigInteger.TryParse(qTextBox.Text, out BigInteger q) || !BigInteger.TryParse(bTextBox.Text, out BigInteger b) || p < 1 || q < 1 || b < 1)
            {
                MessageBox.Show("Введите корректные значения p, q, b", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Utils.IsPrime(p))
            {
                MessageBox.Show("Число p не простое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Utils.IsPrime(q))
            {
                MessageBox.Show("Число q не простое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (p % 4 != 3)
            {
                MessageBox.Show("p = 3 (mod 4) не выполняется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (q % 4 != 3)
            {
                MessageBox.Show("q = 3 (mod 4) не выполняется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _rabinSystem.p = BigInteger.Parse(pTextBox.Text);
            _rabinSystem.q = BigInteger.Parse(qTextBox.Text);
            _rabinSystem.b = BigInteger.Parse(bTextBox.Text);
            _rabinSystem.n = _rabinSystem.p * _rabinSystem.q;

            if (b >= _rabinSystem.n)
            {
                MessageBox.Show("b < n не выполняется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (plainTextBox.Text == "")
            {
                MessageBox.Show("Выберите файл для работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encryptRadioButton.Checked)
            {
                _rabinSystem.Encrypt();
            }
            else
            {
                _rabinSystem.Decrypt();
            }

            var sb = new StringBuilder();
            if (_rabinSystem.ciphertext.Length <= 200)
            {
                sb.Append(string.Join(" ", _rabinSystem.ciphertext.Select(b => b.ToString())));
            }
            else
            {
                sb.Append(string.Join(" ", _rabinSystem.ciphertext.Take(100).Select(b => b.ToString())));
                sb.Append(" ... ");
                sb.Append(string.Join(" ", _rabinSystem.ciphertext.Skip(_rabinSystem.ciphertext.Length - 100).Select(b => b.ToString())));
            }

            resultTextBox.Text = sb.ToString();
        }
    }
}
