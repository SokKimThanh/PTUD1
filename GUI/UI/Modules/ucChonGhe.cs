using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace GUI.UI.Modules
{
    public partial class ucChonGhe : ucBase
    {
        //Initial variables
        private int rows = 12;
        private int columns = 20;
        private int couples = 2;
        private int maxLength = 30;
        private int height = 0;
        private int width = 0;
        private string[] chosenSeatNames = new string[0];
        private Dictionary<string, Color> colors = new Dictionary<string, Color>()
        {
            {"Gray",Color.FromArgb(115,115,115)},
            {"Green", Color.FromArgb(31,219,80) },
        };


        //Label-creating variables
        private int labelLength = 0;
        private int spacing = 10;
        private int paddingTopBottom = 0;
        private int paddingLeftRight = 0;
        private int paddingLeftRight_Couples = 0;
        private int minPadding = 20;
        private Point previousPanelPoint;

        public ucChonGhe()
        {
            InitializeComponent();
        }
        protected override void Load_Data()
        {
            if (strFunctionCode != "")
                lblTitle.Text = strFunctionCode.ToUpper().Trim();
        }

        private void ucChonGhe_Load(object sender, System.EventArgs e)
        {
            PrintSeats();
        }

        //Methods

        public void PrintSeats()
        {
            //
            // Lấy kích thước group
            //
            height = grpSeats.Height;
            width = grpSeats.Width;
            int total = rows * columns;

            //
            // Gắn trạng thái ghế ngẫu nhiên
            // 0: Ghế trống (màu xám)
            // 1: Ghế đã được đặt (màu đỏ)
            //
            int[,] seats_Single = new int[rows, columns]; // Ghế đơn
            int[] seats_Couple = new int[couples]; // Ghế đôi
            Random random = new Random();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    seats_Single[row, col] = random.Next(0, 2);
                }
            }
            for (int couple = 0; couple < couples; couple++)
            {
                seats_Couple[couple] = random.Next(0, 2); ;
            }

            //
            // Tính kích thước ghế và khoảng cách viền
            //
            int panelHeight = (height - (spacing * rows) - (minPadding * 2)) / (rows + 1);
            int panelWidth = (width - (spacing * columns) - (minPadding * 2)) / columns;

            if (panelWidth > panelHeight)
            {
                labelLength = panelHeight;
            }
            else
            {
                labelLength = panelWidth;
            }
            labelLength = labelLength > maxLength ? maxLength : labelLength;
            //labelLength = maxLength;

            paddingTopBottom = ((grpSeats.Height - (labelLength * rows) - ((spacing * rows) - 1)) / 2);
            paddingLeftRight = (grpSeats.Width - (labelLength * columns) - (spacing * (columns - 1))) / 2;
            paddingLeftRight_Couples = (grpSeats.Width - (labelLength * 2 * couples) - (spacing * (columns - 1))) / 2;

            //
            // Tạo ghế đơn
            //
            for (int row = 0; row < rows; row++)
            {
                int X = 0;
                int Y = 0;
                for (int col = 0; col < columns; col++)
                {
                    Label label = new Label();

                    //
                    // Ghế trên cùng bên trái
                    //
                    if (row == 0 && col == 0)
                    {
                        label.Location = new Point(paddingLeftRight, paddingTopBottom);
                    }
                    //
                    // Các ghế sau
                    //
                    else
                    {
                        X = previousPanelPoint.X;
                        Y = previousPanelPoint.Y;
                        if (col != 0)
                        {
                            X += labelLength + spacing;
                        }
                        label.Location = new Point(X, Y);
                    }
                    label.Text = Convert.ToChar(row + 65) + String.Format("{0:00}", col + 1);
                    label.Font = new Font("Times New Roman", ((float)labelLength) / 4);
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Name = "pnlSeat" + label.Text;
                    label.Size = new Size(labelLength, labelLength);
                    label.TabIndex = 0;

                    //
                    // Gắn sự kiện
                    //
                    label.Click += new EventHandler(ChoosingSeat);

                    //
                    // Tô màu ô dựa theo trạng thái của ghế
                    //
                    label.BackColor = seats_Single[row, col] != 0 ? Color.Red : colors["Gray"];

                    //
                    // Lưu vị trí ghế vừa thêm
                    //
                    previousPanelPoint = label.Location;

                    //
                    // Thêm ghế vào view
                    //
                    grpSeats.Controls.Add(label);
                }

                //
                // Xuống hàng ghế khác
                //
                X = paddingLeftRight;
                Y = previousPanelPoint.Y + spacing + labelLength;
                previousPanelPoint = new Point(X, Y);
            }

            //
            // Tạo ghế đôi
            //
            for (int couple = 0; couple < couples; couple++)
            {
                // Các biến thành phần
                int X = 0;
                int Y = 0;
                Label label = new Label();

                // Tạo label
                if (couple == 0)
                {
                    X = paddingLeftRight_Couples - spacing + labelLength;
                }
                else
                {
                    X = previousPanelPoint.X + (labelLength * 2) + spacing;
                }
                Y = previousPanelPoint.Y;
                label.Text = "CP" + String.Format("{0:00}", couple + 1);
                label.Font = new Font("Times New Roman", ((float)labelLength) / 4);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(X, Y);
                label.Name = "pnlSeat" + label.Text;
                label.Size = new Size(labelLength * 2, labelLength);
                label.TabIndex = 0;

                //
                // Gắn sự kiện
                //
                label.Click += new EventHandler(ChoosingSeat);

                //
                // Tô màu ô dựa theo trạng thái của ghế
                //
                label.BackColor = seats_Couple[couple] != 0 ? Color.Red : colors["Gray"];

                //
                // Lưu vị trí ghế vừa thêm
                //
                previousPanelPoint = label.Location;

                //
                // Thêm ghế vào view
                //
                grpSeats.Controls.Add(label);
            }

        }

        private void ChoosingSeat(object sender, EventArgs e)
        {
            //Label currentPanel = (sender as Label);
            //string name = currentPanel.Name;

            //lblNotification.Text = "";
            //if (currentPanel.BackColor == colors["Gray"])
            //{
            //    currentPanel.BackColor = colors["Green"];
            //}
            //else if (currentPanel.BackColor == colors["Green"])
            //{
            //    currentPanel.BackColor = colors["Gray"];
            //}
            //else
            //{
            //    lblNotification.Text = "Ghế đã có người đặt";
            //}
            //lblSeat.Text = name;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control ctrl in grpSeats.Controls)
            {
                if ((ctrl as Label).BackColor == colors["Green"])
                {
                    Array.Resize(ref chosenSeatNames, chosenSeatNames.Length + 1);
                    chosenSeatNames[count] = ctrl.Text.Trim();
                    count++;
                }
            }
            string text = "";
            foreach (string item in chosenSeatNames)
            {
                text += item + "\n";
            }

            MessageBox.Show(text);
        }
    }
}
