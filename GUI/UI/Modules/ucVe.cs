using BUS.Danh_Muc;
using DevExpress.XtraReports.UI;
using DTO;
using DTO.tbl_DTO;
using GUI.UI.Component;
using GUI.UI.ReportDesign;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.UI.Modules
{
    public partial class ucVe : ucBase
    {
        private tbl_DM_Ticket_BUS ticketBus = new tbl_DM_Ticket_BUS();
        private tbl_DM_Movie_BUS movieBus = new tbl_DM_Movie_BUS();
        private tbl_DM_Theater_BUS theaterBus = new tbl_DM_Theater_BUS();
        private tbl_DM_Staff_BUS staffBus = new tbl_DM_Staff_BUS();
        private tbl_DM_MovieSchedule_BUS movieScheBus = new tbl_DM_MovieSchedule_BUS();

        Dictionary<int, string> status = new Dictionary<int, string>()
        {
            {0, "Mua tại quầy" },
            {1, "Đặt trước" },
        };
        private long selectedTicketID = -1;

        // Component grid view layout custom
        GridViewLayoutCustom gridViewLayoutCustom = new GridViewLayoutCustom();

        // Component Barmanager menu layout custom
        BarManagerLayoutCustom barManagerLayoutCustom = new BarManagerLayoutCustom();

        // Component layout allow show/hide control menu customize
        LayoutControlCustom layoutControlCustom = new LayoutControlCustom();

        public ucVe()
        {
            InitializeComponent();
            lblTitle.Text = "VÉ";
            cboStatusTicket.Properties.DataSource = status;
            cboStatusTicket.EditValue = 0;

            // Ngăn không cho phép sửa dữ liệu trực tiếp trên GridView
            gvTickets.OptionsBehavior.Editable = false;

            barManagerLayoutCustom.BarManagerCustom = barManager1;

            // Tùy chỉnh hiển thị find panel trên grid view
            gridViewLayoutCustom.ConfigureFindPanel(gvTickets);

            // Tùy chỉnh vô hiệu hóa chuột phải design mode trên menu
            barManagerLayoutCustom.DisableCustomization();

            // Tùy chỉnh vô hiệu hóa kéo thu nhỏ di chuyển menu
            barManagerLayoutCustom.DisableMoving();

            // Tùy chỉnh vô hiệu hóa design mode menu con của layout control 
            layoutControlCustom.DisableLayoutCustomization(layoutForm);
        }

        public void LoadData()
        {
            try
            {
                dgvTickets.DataSource = ticketBus.GetTicket_ForShow((int)cboStatusTicket.EditValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvTickets_Click(object sender, EventArgs e)
        {
            int[] dong = gvTickets.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        selectedTicketID = (long)gvTickets.GetRowCellValue(i, "ID");

                        // Lấy các dữ liệu từ các bảng khác
                        tbl_DM_Ticket_DTO o = ticketBus.GetTicket_ByID(selectedTicketID);
                        tbl_DM_MovieSchedule_DTO foundSchedule = movieScheBus.GetLastMovieSchedule_ByID(o.MovieScheID);
                        tbl_DM_Movie_DTO foundMovie = movieBus.Find(foundSchedule.Movie_AutoID);
                        tbl_DM_Theater_DTO foundTheater = theaterBus.FindByID(foundSchedule.Theater_AutoID);
                        tbl_DM_Staff_DTO foundStaff = staffBus.GetStaff_ByID((int)o.StaffID);

                        // Gán thông tin lên các trường dữ liệu
                        txtTicketID.Text = selectedTicketID.ToString().Trim();
                        txtCreateDate.Text = o.Created.ToString("dd/MM/yyyy HH:mm:ss");
                        txtMovieName.Text = foundMovie.MV_NAME.Trim();
                        cboStatusTicket.Text = foundMovie.MV_PRICE.ToString().Trim();
                        txtMovieScheduleDate.Text = foundSchedule.StartDate.ToString("dd/MM/yyyy HH:mm");
                        txtTheaterName.Text = foundTheater.Name.Trim();
                        //txtStaff.Text = foundStaff.ST_NAME.Trim();
                        txtSeatName.Text = o.SeatName.Trim();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void ucVe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selectedTicketID != -1)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thông tin vé dưới đây khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ticketBus.RemoveData(selectedTicketID);
                        selectedTicketID = -1;
                        LoadData();
                        MessageBox.Show("Xóa thông tin vé thành công", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 vé trong danh sách để thực hiện xóa", "Thông báo");
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (selectedTicketID != -1)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn in vé " + txtTicketID.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Tạo vé
                    RP_PrintTicket report = new RP_PrintTicket();
                    report.BindParameter(selectedTicketID.ToString());
                    report.CreateDocument();

                    // In vé không cần review
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.Print();
                    MessageBox.Show("Đã in thành công", "Thông báo");
                }
            }
        }

        private void cboStatusTicket_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
