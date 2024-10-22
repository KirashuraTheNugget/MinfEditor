namespace MinfEditor_Reattempt
{
    public partial class Form1 : Form
    {
        private string filepath;
        private const int FrameStart = 0x4C;
        private const int FrameEnd = 0x50;
        private const int Action = 0x1C;
        private const int DataSize = 4;
        //Hi Zura and Math
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.mtninf|";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filepath = dialog.FileName;
                byte[] data = File.ReadAllBytes(filepath);
                if (data.Length >= FrameEnd + DataSize)
                {
                    UpdateNumericUpdown(data);
                    UpdateTextBox(data);
                }
                else
                {
                    MessageBox.Show($"Mtninf Failed to Load");
                }

            }
        }

        private void UpdateNumericUpdown(byte[] data)
        {
            using (BinaryReader reader = new BinaryReader(new MemoryStream(data)))
            {
                reader.BaseStream.Seek(FrameStart, SeekOrigin.Begin);
                int StartFrame = reader.ReadInt32();
                numericUpDown1.Value = StartFrame;
            }
            using (BinaryReader reader = new BinaryReader(new MemoryStream(data)))
            {
                reader.BaseStream.Seek(FrameEnd, SeekOrigin.Begin);
                int EndFrame = reader.ReadInt32();
                numericUpDown2.Value = EndFrame;
            }
        }
        private void UpdateTextBox(byte[] data)
        {
            byte[] ActionHash = new byte[4];
            Array.Copy(data, 0x1C, ActionHash, 0, 4);
            textBox1.Text = BitConverter.ToString(ActionHash).Replace("-", " ");
        }
        //admittedly, i used AI for the saving prompt. i just couldn't figure it out myself. if you have any advice, let me know.
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string newFilePath = sfd.FileName;

                try
                {
                    byte[] data = File.ReadAllBytes(filepath);
                    int updatedStartFrame = (int)numericUpDown1.Value;
                    int updatedEndFrame = (int)numericUpDown2.Value;
                    Array.Copy(BitConverter.GetBytes(updatedStartFrame), 0, data, FrameStart, 4);
                    Array.Copy(BitConverter.GetBytes(updatedEndFrame), 0, data, FrameEnd, 4);
                    string actionHashText = textBox1.Text.Replace(" ", "");
                    byte[] actionHashBytes = new byte[4];
                    for (int i = 0; i < 4; i++)
                    {
                        actionHashBytes[i] = Convert.ToByte(actionHashText.Substring(i * 2, 2), 16);
                    }
                    Array.Copy(actionHashBytes, 0, data, Action, 4);
                    File.WriteAllBytes(newFilePath, data);
                    MessageBox.Show("Congrats. Your mtninf didn't fail to save!", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"awwww.... damn: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

