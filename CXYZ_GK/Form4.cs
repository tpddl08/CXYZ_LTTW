using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CXYZ
{
    public partial class Form4 : Form
    {
        private const string SCORE_FILE_NAME = "./playerlog.text";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdatePlayerList();
        }

        private List<(string PlayerName, int Score, string Timestamp)> ReadPlayerData()
        {
            List<(string PlayerName, int Score, string Timestamp)> players = new List<(string, int, string)>();

            try
            {
                if (File.Exists(SCORE_FILE_NAME))
                {
                    string[] lines = File.ReadAllLines(SCORE_FILE_NAME);

                    // Bỏ qua dòng tiêu đề (dòng đầu tiên)
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        // Tách các giá trị bằng ký tự phân tách '|'
                        string[] parts = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length >= 3 && int.TryParse(parts[1].Trim(), out int score))
                        {
                            // Trích xuất dữ liệu an toàn
                            string playerName = parts[0].Trim();
                            string timestamp = parts[2].Trim();

                            players.Add((playerName, score, timestamp));
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc tệp: {ex.Message}", "Lỗi IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return players;
        }

        private void UpdatePlayerList()
        {
            playerLb.Items.Clear();
            var players = ReadPlayerData();

            if (players.Count == 0)
            {
                playerLb.Items.Add("Không có người chơi nào trong tệp!");
                return;
            }

            // Sắp xếp theo điểm số giảm dần
            players = players.OrderByDescending(p => p.Score).ToList();

            // Hiển thị dữ liệu
            // Thêm dòng tiêu đề cho ListBox để dễ đọc
            playerLb.Items.Add("HẠNG | TÊN NGƯỜI CHƠI | ĐIỂM | THỜI ĐIỂM CHƠI");
            playerLb.Items.Add("------------------------------------------------------------------");

            for (int i = 0; i < players.Count; i++)
            {
                var player = players[i];
                int rank = i + 1;

                // Định dạng và thêm vào ListBox
                playerLb.Items.Add($" {rank}   {player.PlayerName.PadRight(10).PadLeft(15)}  {player.Score.ToString().PadLeft(5).PadRight(8)}  {player.Timestamp}");
            }
        }

        private void closeChartBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}