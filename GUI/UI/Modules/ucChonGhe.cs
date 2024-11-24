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
        private tbl_DM_MovieSchedule_BUS movieScheBus = new tbl_DM_MovieSchedule_BUS();
        private tbl_DM_Movie_BUS movieBus = new tbl_DM_Movie_BUS();
        private tbl_DM_Theater_BUS theaterBus = new tbl_DM_Theater_BUS();
        private tbl_DM_Ticket_BUS ticketBus = new tbl_DM_Ticket_BUS();
        private tbl_DM_Theater_DTO chosenTheater;

        // Biến khởi tạo
        private int rows = 0;
        private int columns = 0;
        private int couples = 0;
        private int maxLength = 50;
        private int height = 0;
        private int width = 0;
        private double price = 0;
        private double totalPrice = 0;
        private Dictionary<string, Color> colors = new Dictionary<string, Color>()
        {
            {"Gray",Color.FromArgb(115,115,115)},
            {"Green", Color.FromArgb(31,219,80)},
            { "Blue", Color.FromArgb(53,154,239)}
        };

        private Dictionary<int, string> ticketStatuses = new Dictionary<int, string>()
        {
            {0, "Mua ngay" },
            {1, "Đặt trước" },
        };
        // Các biến cấu thành các ghế 
        private int labelLength = 0;
        private int spacing = 5;
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
            tbl_DM_MovieSchedule_DTO foundSchedule = movieScheBus.GetLastMovieSchedule_ByID(CCommon.suatChieuDuocChon);

            // Hiển thị tên phim và suất chiếu
            string movieName = movieBus.Find(foundSchedule.Movie_AutoID).MV_NAME.Trim();
            lblTitle.Text = "Phim được chọn: " + movieName + " | " + foundSchedule.StartDate.ToString("HH:mm");

            // Hiển thị tên phòng chiếu
            string theatername = theaterBus.FindByID(foundSchedule.Theater_AutoID).Name.Trim();
            txtTheaterName.Text = theatername;

            // Hiện thị danh sách các ghế có thể chọn
            PrintSeats();

            // Thay đổi kích thước ghế khi kích thước xung quanh thay đổi
            if (this.Parent is FluentDesignFormContainer v_objMain_Container)
            {
                v_objMain_Container.SizeChanged += (sender, e) => PrintSeats();
            }

            // Hiện thị các trạng thái của vé đang chọn
            cboTicketStatus.Properties.DataSource = ticketStatuses;
            cboTicketStatus.ItemIndex = 0;
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
            grpSeats.Controls.Clear();

            //
            // Lấy kích thước group
            //
            height = grpSeats.Height;
            width = grpSeats.Width;
            int total = rows * columns;

            //
            // Gắn trạng thái ghế ngẫu nhiên
            // 0: Ghế đã được đặt (màu đỏ)
            // 1: Ghế đã đặt trước (màu xanh)
            // 2: Ghế trống (màu xám)
            //
            int[,] seats_Single = new int[rows, columns]; // Ghế đơn
            int[] seats_Couple = new int[couples]; // Ghế đôi
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    // Kiểm tra các vé đặt ghế đơn của suất chiếu hiện tại
                    tbl_DM_Ticket_DTO foundTicket = ticketBus.GetTicket_BySeatName(Convert.ToChar(row + 65) + String.Format("{0:00}", col + 1), CCommon.suatChieuDuocChon);
                    if (foundTicket != null)
                    {
                        seats_Single[row, col] = foundTicket.Status;
                    }
                    else
                    {
                        seats_Single[row, col] = 2;
                    }
                }
            }
            for (int couple = 0; couple < couples; couple++)
            {
                // Kiểm tra các vé đặt ghế đôi của suất chiếu hiện tại
                tbl_DM_Ticket_DTO foundTicket = ticketBus.GetTicket_BySeatName("CP" + String.Format("{0:00}", couple + 1), CCommon.suatChieuDuocChon);
                if (foundTicket != null)
                {
                    seats_Couple[couple] = foundTicket.Status;
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
                    switch (seats_Single[row, col])
                    {
                        case 0:
                            label.BackColor = Color.Red;
                            break;
                        case 1:
                            label.BackColor = colors["Blue"];
                            break;
                        default:
                            label.BackColor = colors["Gray"];
                            break;
                    }

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
                switch (seats_Couple[couple])
                {
                    case 0:
                        label.BackColor = Color.Red;
                        break;
                    case 1:
                        label.BackColor = colors["Blue"];
                        break;
                    default:
                        label.BackColor = colors["Gray"];
                        break;
                }

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
            double actualPrice = (int)cboTicketStatus.EditValue == 0 ? price : price / 2;

            if (currentPanel.BackColor == colors["Gray"])
            {
                currentPanel.BackColor = colors["Green"];
                totalPrice += actualPrice;
                if (currentPanel.Text.Contains("CP"))
                {
                    totalPrice += actualPrice;
                }
            }
            else if (currentPanel.BackColor == colors["Green"])
            {
                currentPanel.BackColor = colors["Gray"];
                totalPrice -= actualPrice;
                if (currentPanel.Text.Contains("CP"))
                {
                    totalPrice -= actualPrice;
                }
            }
            else
            {
                MessageBox.Show("Ghế đã có người đặt", "Thông báo");
            }
            int count = 0;
            foreach (Label item in grpSeats.Controls)
            {
                if (item.BackColor == colors["Green"])
                {
                    count++;
                }
            }
            txtQuantity.Text = count.ToString().Trim();
            txtTotalPrice.Text = totalPrice.ToString();
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

                        List<string> v_arrGhe_Da_Chon = new List<string>();

                        //Lấy danh sách ghế được chọn
                        for (int i = 0; i < grpSeats.Controls.Count; i++)
                        {
                            Label v_objLabel = grpSeats.Controls[i] as Label;
                            if (v_objLabel != null && v_objLabel.BackColor == colors["Green"])
                            {
                                v_arrGhe_Da_Chon.Add(v_objLabel.Text.Trim());
                            }
                        }
                        //

                        //Map vào uc kia
                        CCommon.Danh_Sach_Ghe_Da_Chon = v_arrGhe_Da_Chon;
                        CCommon.loaiVeDangDat = (int)cboTicketStatus.EditValue;

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

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grpSeats.Controls.Clear();
            PrintSeats();
            totalPrice = 0;
            txtTotalPrice.Text = totalPrice.ToString();
        }

        /// <summary>
        /// Nút hủy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }

        private void cboTicketStatus_EditValueChanged(object sender, EventArgs e)
        {
            totalPrice = (int)cboTicketStatus.EditValue == 0 ? totalPrice * 2 : totalPrice / 2;
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}
