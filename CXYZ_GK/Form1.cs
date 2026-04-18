using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CXYZ
{
    public enum GameTheme
    {
        City,
        ForestDark,
        Flame,
        SnowWhite
    }
    public partial class Form1 : Form
    {
        int speed = 3;
        int gravity = 1;
        int score = 0;

        private bool soundCheck = true;
        private SoundPlayer starSound;
        private SoundPlayer pointSound;
        private SoundPlayer overSound;

        private bool hasScored = false;
        private Random random = new Random();
        private bool foodActive = false;

        private bool foodSpawned = false; // Đánh dấu đã spawn food cho ống hiện tại chưa

        private int lastGapCenterY = 0;
        private Image originalFlappyBirdImage;

        private const int PIPE_GAP_INITIAL = 200; // Khoảng cách khe hở dọc

        //Khoảng cách ngang giữa ống trước và sau
        private const int PIPE_DISTANCE_INITIAL = 10;

        private const float MAX_SCREEN_HEIGHT_RATIO = 0.8f;
        private const float MIN_SCREEN_HEIGHT_RATIO = 0.1f;
        private const int MAX_GAP_OFFSET = 100; //độ lệch tạo khoảng cách giữa ống của trước và sau
        private const int MIN_SAFE_HEIGHT_FROM_GROUND = 100;
        private GameTheme currentTheme = GameTheme.City;
        private const string SCORE_FILE_NAME = "./playerlog.text";
        private string playerNameForScore;

        //Áp dụng chủ đề chơi
        private void ApplyTheme(GameTheme theme)
        {

            switch (theme)
            {
                case GameTheme.City:
                    {
                        this.BackgroundImage = Properties.Resources.citybg;
                        ground.Image = Properties.Resources.ground;
                        pipeTop.Image = Properties.Resources.pipetop;
                        pipeBottom.Image = Properties.Resources.pipebottom;
                        food.Image = Properties.Resources.apple;
                        break;
                    }
                case GameTheme.ForestDark:
                    {
                        this.BackgroundImage = Properties.Resources.forestbg;
                        ground.Image = Properties.Resources.forestdarkground;
                        pipeTop.Image = Properties.Resources.forestdarkpipetop;
                        pipeBottom.Image = Properties.Resources.forestdarkpipebottom;
                        food.Image = Properties.Resources.pumpkin;
                        break;
                    }

                case GameTheme.Flame:
                    {
                        this.BackgroundImage = Properties.Resources.flamebg;
                        ground.Image = Properties.Resources.flameground;
                        pipeTop.Image = Properties.Resources.flamepipetop;
                        pipeBottom.Image = Properties.Resources.flamepipebottom;
                        food.Image = Properties.Resources.water;
                        break;
                    }

                case GameTheme.SnowWhite:
                    {
                        this.BackgroundImage = Properties.Resources.snowbg;
                        ground.Image = Properties.Resources.snowwhiteground;
                        pipeTop.Image = Properties.Resources.snowwhitepipetop;
                        pipeBottom.Image = Properties.Resources.snowwhitepipebottom;
                        food.Image = Properties.Resources.bread;
                        break;

                    }
            }

            // Đảm bảo ảnh nền được kéo giãn/đặt đúng
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private Image RotateImage(Image img, float angle)
        {
            // Kiểm tra nếu hình ảnh chưa được gán
            if (img == null) return null;

            // Tạo một bitmap mới với kích thước ban đầu
            Bitmap rotatedImage = new Bitmap(img.Width, img.Height);

            // Tạo đối tượng Graphics từ bitmap mới
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Đặt chất lượng cao hơn cho kết quả xoay
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Đặt điểm xoay ở giữa hình ảnh
                g.TranslateTransform(img.Width / 2, img.Height / 2);

                // Thực hiện xoay
                g.RotateTransform(angle);

                // Đặt lại vị trí dịch chuyển và vẽ hình ảnh gốc
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);
                g.DrawImage(img, new Point(0, 0));
            }

            return rotatedImage;
        }

        // Tạo thức ăn
        private void createFood()
        {
            // Kiểm tra nếu ống đã đến giữa màn hình và chưa spawn food
            int screenMiddle = this.Width / 2;

            if (pipeTop.Left <= screenMiddle && pipeTop.Right > screenMiddle && !foodSpawned && !foodActive)
            {
                foodActive = true;
                food.Visible = true;

                // Đặt food xuất hiện từ mép phải màn hình
                food.Left = this.Width;

                // Tính toán khoảng không gian an toàn cho food
                int groundTop = this.Height - ground.Height;
                int minY = 50; // Cách top ít nhất 50px
                int maxY = groundTop - food.Height - 50; // Cách ground ít nhất 50px

                // Random tọa độ Y trong khoảng an toàn
                if (maxY > minY)
                {
                    food.Top = random.Next(minY, maxY);
                }
                else
                {
                    food.Top = this.Height / 2 - food.Height / 2;
                }
                foodSpawned = true; // Đánh dấu đã xử lý
            }
        }

        public Form1()
        {
            InitializeComponent();
            starSound = new SoundPlayer(Properties.Resources.starsound);
            pointSound = new SoundPlayer(Properties.Resources.pointsound);
            overSound = new SoundPlayer(Properties.Resources.endgamesound);
        }

        // --- SỰ KIỆN LOAD ---
        private void Form1_Load(object sender, EventArgs e)
        {
            if (flappyBird.Image != null)
            {
                originalFlappyBirdImage = (Image)flappyBird.Image.Clone();
            }

            food.Visible = false;
            ShowThemeSelectionMenu();
        }


        // Xử lí nhấn phím/chuột
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                gravity = -4;

            }
        }

        private void mouseisdown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gravity = -4;

            }
        }
        private void mouseisup(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gravity = 2;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                gravity = 2;
            }
        }

        //Lưu điểm
        private void saveScore()
        {
            //Lấy thông tin cần thiết
            string timestamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            string playerName = playerNameForScore;

            // Dữ liệu cần lưu: Tên người chơi, Điểm, Thời điểm chơi
            string dataLine = $"{playerName} | {score} | {timestamp}";

            try
            {
                bool fileExists = File.Exists(SCORE_FILE_NAME);

                // Ghi tiếp vào cuối file
                using (StreamWriter sw = new StreamWriter(SCORE_FILE_NAME, true))
                {
                    // Nếu file chưa tồn tại, thêm dòng tiêu đề
                    if (!fileExists)
                    {
                        sw.WriteLine("Tên người chơi | Điểm | Thời điểm chơi");
                    }

                    // Ghi dữ liệu của lượt chơi hiện tại
                    sw.WriteLine(dataLine);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu không thể ghi file
                MessageBox.Show($"Lỗi khi lưu file điểm: {ex.Message}", "Lỗi IO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Khởi động lại game
        private void ResetGame()
        {
            gameTimer.Stop();

            // Đặt lại các biến
            score = 0;
            gravity = 1;
            speed = 3;
            scoreText.Text = "Điểm: 0";
            hasScored = false;

            foodActive = false;
            foodSpawned = false;
            food.Visible = false;

            lastGapCenterY = this.Height / 2;

            flappyBird.Left = (int)(this.Width * 0.4f);
            flappyBird.Top = (int)(this.Height * 0.3f);

            // Đặt ống ra ngoài màn hình để sẵn sàng xuất hiện
            pipeTop.Left = -this.Width;
            pipeBottom.Left = -this.Width;

            // Đặt lại góc xoay
            if (originalFlappyBirdImage != null)
            {
                flappyBird.Image = originalFlappyBirdImage;
            }
        }

        //Hiện hướng dẫn
        private void showGuide()
        {
            using (Form5 guideNoti = new Form5())
            {
                guideNoti.ShowDialog();
            }
        }

        //Hiện menu chọn chủ đề
        private void ShowThemeSelectionMenu()
        {
            if (gameTimer.Enabled) gameTimer.Stop();
            this.Hide();
            using (Form2 menu = new Form2())
            {
                DialogResult result = menu.ShowDialog();
                if (result == DialogResult.OK)
                {
                    currentTheme = menu.SelectedTheme;
                    playerNameForScore = menu.playerName;

                    soundCheck = menu.soundStatus;
                    ApplyTheme(currentTheme);
                    this.Show();
                    showGuide();
                    ResetGame();

                    if (soundCheck)
                    {
                        starSound.Play();
                    }
                    gameTimer.Start();

                }
                else
                {
                    Application.Exit();
                }
            }
        }

        //Kết thúc game
        private void endGame()
        {
            gameTimer.Stop();

            if (soundCheck)
            {
                overSound.Play();
            }
            saveScore();

            ShowGameOverMenu(score);
        }

        //Hiện menu kết thúc
        private void ShowGameOverMenu(int score)
        {
            using (Form3 gameOverMenu = new Form3(score))
            {
                DialogResult result = gameOverMenu.ShowDialog();

                // Kiểm tra kết quả
                if (result == DialogResult.Retry)
                {
                    ResetGame();
                    gameTimer.Start();
                }
                else if (result == DialogResult.Abort)
                {
                    ShowThemeSelectionMenu();
                }
                else if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }


        private void gameTimerEvent(object sender, EventArgs e)
        {

            int currentSpeed = (int)(speed);
            flappyBird.Top += gravity;
            pipeBottom.Left -= currentSpeed;
            pipeTop.Left -= currentSpeed;
            scoreText.Text = "Điểm: " + score;

            if (originalFlappyBirdImage != null)
            {
                float angle = 0;

                if (gravity < 0) // Bay lên
                {
                    angle = -20; // Ngước lên tối đa -20 độ
                }
                else if (gravity > 0)// Rơi xuống
                {
                    // Góc xoay tăng dần theo tốc độ rơi (gravity)
                    angle = gravity * 5;
                    if (angle > 90) angle = 90; // Giới hạn tối đa 90 độ (cắm đầu xuống)
                }

                flappyBird.Image = RotateImage(originalFlappyBirdImage, angle);
            }


            // XỬ LÝ ỐNG XUẤT HIỆN
            if (pipeTop.Right < 0)
            {
                hasScored = false;
                foodSpawned = false;

                int newDistance = PIPE_DISTANCE_INITIAL;

                int newPipeXPosition = this.Width - (int)(newDistance);

                int currentPipeGap = (int)(PIPE_GAP_INITIAL);

                int newCenterY = lastGapCenterY;

                if (newCenterY == 0)
                {
                    newCenterY = this.Height / 2; // Đặt ở giữa màn hình nếu chưa có khe hở trước
                }

                int currentMaxOffset = (int)(MAX_GAP_OFFSET);
                // Tạo offset ngẫu nhiên trong phạm vi [-Offset, +Offset]
                int randomOffset = random.Next(-currentMaxOffset, currentMaxOffset + 1);
                int gapCenterY = newCenterY + randomOffset;

                //Tính Chiều cao Ống trên dựa trên tâm khe hở
                int pipeTopBottomPosition = gapCenterY - (currentPipeGap / 2);
                int newPipeTopHeight = pipeTopBottomPosition;

                //Tính toán và áp dụng Giới hạn An toàn
                int minSafePosition = (int)(this.Height * MIN_SCREEN_HEIGHT_RATIO);
                int maxSafePosition = (int)(this.Height * MAX_SCREEN_HEIGHT_RATIO) - currentPipeGap - ground.Height;

                int minBottomSafety = (int)(this.Height - ground.Height - (MIN_SAFE_HEIGHT_FROM_GROUND));
                // Giới hạn ống
                if (newPipeTopHeight > minBottomSafety)
                {
                    maxSafePosition = minBottomSafety;
                }
                if (newPipeTopHeight < minSafePosition)
                {
                    newPipeTopHeight = minSafePosition;
                }
                else if (newPipeTopHeight > maxSafePosition)
                {
                    newPipeTopHeight = maxSafePosition;
                }

                //Ống đơn ngẫu nhiên (20% cơ hội)
                int singlePipeChance = random.Next(1, 11);

                if (singlePipeChance == 1) // 10% cơ hội chỉ có ống dưới
                {
                    newPipeTopHeight = 0;
                }
                else if (singlePipeChance == 2) // 10% cơ hội chỉ có ống trên
                {
                    // Ống trên chiếm hết không gian, chỉ để khe hở phía dưới
                    int groundTopPosition = this.Height - ground.Height;
                    newPipeTopHeight = groundTopPosition - currentPipeGap;
                }

                else
                {
                    if (newPipeTopHeight < minSafePosition)
                    {
                        newPipeTopHeight = minSafePosition;
                    }
                    else if (newPipeTopHeight > maxSafePosition)
                    {
                        newPipeTopHeight = maxSafePosition;
                    }
                }
                //Thiết lập Ống trên
                pipeTop.Left = newPipeXPosition; // VỊ TRÍ X MỚI
                pipeTop.Height = newPipeTopHeight;
                pipeTop.Top = 0;

                //Thiết lập Ống dưới
                pipeBottom.Left = newPipeXPosition; // VỊ TRÍ X MỚI
                pipeBottom.Top = pipeTop.Bottom + currentPipeGap;

                lastGapCenterY = pipeTop.Bottom + (currentPipeGap / 2);

                int groundTop = this.Height - ground.Height;

                // Ống dưới KHÔNG ĐƯỢC vượt quá vị trí ground
                int maxAllowedHeight = groundTop - pipeBottom.Top;

                if (maxAllowedHeight > 0)
                {
                    pipeBottom.Height = maxAllowedHeight;
                }
                else
                {
                    // Xử lý trường hợp không đủ chỗ cho ống dưới
                    pipeBottom.Height = 0;
                    pipeBottom.Top = groundTop;
                }
            }

            // Di chuyển và xử lý thức ăn
            if (foodActive)
            {
                food.Left -= currentSpeed;

                // Kiểm tra va chạm với food
                if (flappyBird.Bounds.IntersectsWith(food.Bounds))
                {
                    score += 2;
                    foodActive = false;
                    food.Visible = false;

                    if (soundCheck)
                    {
                        pointSound.Play();
                    }
                }

                // Ẩn food khi ra khỏi màn hình bên trái
                if (food.Right < 0)
                {
                    foodActive = false;
                    food.Visible = false;
                }
            }

            createFood();

            //Tăng điểm
            if (flappyBird.Left > pipeTop.Right && hasScored == false)
            {
                score++;
                if (soundCheck)
                {
                    pointSound.Play();
                }
                scoreText.Text = "Điểm: " + score;
                hasScored = true;

                if (score > 0 && score % 5 == 0)
                {
                    speed+=1;
                }
            }

            //Kiểm tra va chạm
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < 0
                )
            {
                endGame();
            }
        }
    }
}