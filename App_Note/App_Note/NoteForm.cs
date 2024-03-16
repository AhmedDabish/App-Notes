using Newtonsoft.Json;
using System.Data;
//using System.Xml;

namespace App_Note
{
    public partial class NoteForm : Form
    {
        DataTable table;
        List<NoteEntry> noteEntries;
        public NoteForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormClosing += NoteForm_FormClosing;
        }



        private void NoteForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));
            savedNotesTable.DataSource = table;
            savedNotesTable.Columns["Messages"].Visible = false;
            savedNotesTable.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            savedNotesTable.Columns["Title"].FillWeight = 100;
            LoadDataFromJsonFile();
        }


        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToJsonFile();
        }

        private void LoadDataFromJsonFile()
        {
            string filePath = "storage.json";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }


            string json = File.ReadAllText("storage.json");
            noteEntries = JsonConvert.DeserializeObject<List<NoteEntry>>(json);
            table.Rows.Clear();
            foreach (NoteEntry entry in noteEntries)
            {
                table.Rows.Add(entry.Title, entry.Message);
            }
        }

        private void SaveDataToJsonFile()
        {
            noteEntries = new List<NoteEntry>();
            foreach (DataGridViewRow row in savedNotesTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    NoteEntry entry = new NoteEntry
                    {
                        Title = row.Cells["Title"].Value.ToString(),
                        Message = row.Cells["Messages"].Value.ToString()
                    };
                    noteEntries.Add(entry);
                }
            }
            string json = JsonConvert.SerializeObject(noteEntries, Formatting.Indented);
            File.WriteAllText("storage.json", json);
        }




        private void NewBtn_Click(object sender, EventArgs e)
        {
            TitleEntryBox.Clear();
            MessageEntryBox.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            table.Rows.Add(TitleEntryBox.Text, MessageEntryBox.Text);

            TitleEntryBox.Clear();
            MessageEntryBox.Clear();
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
            }
            else
            {
                int index = savedNotesTable.CurrentCell.RowIndex;
                TitleEntryBox.Clear();
                MessageEntryBox.Clear();
                TitleEntryBox.Text = table.Rows[index].ItemArray[0].ToString();
                MessageEntryBox.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count == 0)
            {
            }
            else
            {
                TitleEntryBox.Clear();
                MessageEntryBox.Clear();

                int selectedRowIndex = savedNotesTable.CurrentCell.RowIndex;

                savedNotesTable.Rows.RemoveAt(selectedRowIndex);
                if (savedNotesTable.Rows.Count > 0)
                {
                    if (selectedRowIndex >= savedNotesTable.Rows.Count)
                    {
                        savedNotesTable.Rows[savedNotesTable.Rows.Count - 1].Selected = true;
                    }
                    else
                    {
                        savedNotesTable.Rows[selectedRowIndex].Selected = true;
                    }
                }
            }
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void TitleEntryBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
