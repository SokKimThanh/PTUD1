using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using DevExpress.XtraBars.FluentDesignSystem;
using BUS.Sys;
using BUS.Danh_Muc;
using DTO;
using DTO.Common;
using DTO.tbl_DTO;

namespace GUI.UI.Modules
{
    public partial class ucChonGhe : ucBase
    {
        // Biến khởi tạo
        private int rows = 0;
        private int columns = 0;
        private int couples = 0;
        private int maxLength = 30;
        private int height = 0;
        private int width = 0;
        private string[] chosenSeatNames = new string[0];
        private double price = 0;
        private double totalPrice = 0;
        private Dictionary<string, Color> colors = new Dictionary<string, Color>()
        {
            {"Gray",Color.FromArgb(115,115,115)},
            {"Green", Color.FromArgb(31,219,80) },
        };
        private tbl_DM_MovieSchedule_BUS movieScheBus = new tbl_DM_MovieSchedule_BUS();
        private tbl_DM_Movie_BUS movieBus = new tbl_DM_Movie_BUS();
        private tbl_DM_Theater_BUS theaterBus = new tbl_DM_Theater_BUS();
        private tbl_DM_Ticket_BUS ticketBus = new tbl_DM_Ticket_BUS();
        private tbl_DM_Theater_DTO chosenTheater;


        // Các biến cấu thành các ghế 
        private int labelLength = 0;
        private int spacing = 20;
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
            PrintSeats();
        }

        private void ucChonGhe_Load(object sender, System.EventArgs e)
        {
            chosenTheater = theaterBus.FindByID(movieScheBus.GetLastMovieSchedule_ByID(CCommon.suatChieuDuocChon).Theater_AutoID);
            price = (movieBus.Find((movieScheBus.GetLastMovieSchedule_ByID(CCommon.suatChieuDuocChon).Movie_AutoID)).MV_PRICE);
            rows = chosenTheater.Rows;
            columns = chosenTheater.Columns;
            couples = chosenTheater.Couples;
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
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    // Kiểm tra các vé đặt ghế đơn của suất chiếu hiện tại
                    if (ticketBus.SeatExist_ByMovieSchedule(Convert.ToChar(row + 65) + String.Format("{0:00}", col + 1), CCommon.suatChieuDuocChon))
                    {
                        seats_Single[row, col] = 1;
                    }
                    else
                    {
                        seats_Single[row, col] = 0;
                    }
                }
            }
            for (int couple = 0; couple < couples; couple++)
            {
                // Kiểm tra các vé đặt ghế đôi của suất chiếu hiện tại
                if (ticketBus.SeatExist_ByMovieSchedule("CP" + String.Format("{0:00}", couple + 1), CCommon.suatChieuDuocChon))
                {
                    seats_Couple[couple] = 1;
                }
                else
                {
                    seats_Couple[couple] = 0;
                }
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
            Label currentPanel = (sender as Label);
            string name = currentPanel.Name;

            //lblNotification.Text = "";
            if (currentPanel.BackColor == colors["Gray"])
            {
                currentPanel.BackColor = colors["Green"];
                totalPrice += price;
                if (currentPanel.Text.Contains("CP"))
                {
                    totalPrice += price;
                }
                txtTotalPrice.Text = totalPrice.ToString();
            }
            else if (currentPanel.BackColor == colors["Green"])
            {
                currentPanel.BackColor = colors["Gray"];
                totalPrice -= price;
                if (currentPanel.Text.Contains("CP"))
                {
                    totalPrice -= price;
                }
                txtTotalPrice.Text = totalPrice.ToString();
            }
            else
            {
                //lblNotification.Text = "Ghế đã có người đặt";
            }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonThanhToan v_objLoad = new ucChonThanhToan();

                    // Nếu UserControl đã có trong mainContainer thì đưa nó lên trước
                    if (v_objContainer.Controls.Contains(v_objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        v_objContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        v_objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        v_objContainer.Controls.Add(v_objLoad);
                        v_objLoad.Load_DataBase(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Nút hủy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //Lấy form chứa uc này ra
                if (this.Parent is FluentDesignFormContainer v_objContainer)
                {
                    ucChonPhim v_objLoad = new ucChonPhim();

                    if (v_objContainer.Controls.Contains(v_objLoad) == false)
                    {
                        // Clear toàn bộ những gì trên container
                        v_objContainer.Controls.Clear();

                        // Dock control vào container để nó chiếm toàn bộ diện tích
                        v_objLoad.Dock = DockStyle.Fill;

                        // Thêm UserControl vào main container
                        v_objContainer.Controls.Add(v_objLoad);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(LanguageController.GetLanguageDataLabel(ex.Message), LanguageController.GetLanguageDataLabel("Lỗi"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grpSeats.Controls.Clear();
            PrintSeats();
            totalPrice = 0;
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
