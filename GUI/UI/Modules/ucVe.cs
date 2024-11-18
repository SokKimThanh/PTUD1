using BUS.Danh_Muc;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTO;
using DTO.tbl_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.UI.Modules
{
    public partial class ucVe : ucBase
    {
        private tbl_DM_Ticket_BUS ticketBus = new tbl_DM_Ticket_BUS();
        private tbl_DM_Movie_BUS movieBus = new tbl_DM_Movie_BUS();
        private tbl_DM_Theater_BUS theaterBus = new tbl_DM_Theater_BUS();
        private tbl_DM_Staff_BUS staffBus = new tbl_DM_Staff_BUS();
        private tbl_DM_MovieSchedule_BUS movieScheBus = new tbl_DM_MovieSchedule_BUS();

        private long selectedTicketID = -1;

        public ucVe()
        {
            InitializeComponent();
            lblTitle.Text = "VÉ";
        }

        public void LoadData()
        {
            try
            {
                dgvTickets.DataSource = ticketBus.GetList();
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
                        selectedTicketID = (long)gvTickets.GetRowCellValue(i, "AutoID");
                        // Lấy các dữ liệu từ các bảng khác
                        tbl_DM_Ticket_DTO o = ticketBus.GetTicket_ByID(selectedTicketID);
                        tbl_DM_MovieSchedule_DTO foundSchedule = movieScheBus.GetLastMovieSchedule_ByID(o.MovieScheID);
                        tbl_DM_Movie_DTO foundMovie = movieBus.Find(foundSchedule.Movie_AutoID);
                        tbl_DM_Theater_DTO foundTheater = theaterBus.FindByID(foundSchedule.Theater_AutoID);
                        tbl_DM_Staff_DTO foundStaff = staffBus.GetStaff_ByID((int)o.StaffID);

                        // Gán thông tin lên các trường dữ liệu
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
            DialogResult result = MessageBox.Show("Bạn có muốn in vé 'txtTicketID.Text'?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
