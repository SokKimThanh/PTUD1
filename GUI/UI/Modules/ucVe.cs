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
                        long id = (long)gvTickets.GetRowCellValue(i, "TK_AutoID");
                        tbl_DM_Ticket_DTO o = ticketBus.GetTicket_ByID(id);
                        tbl_DM_MovieSchedule_DTO foundSchedule = movieScheBus.GetLastMovieSchedule_ByID(o.MovieScheID);
                        tbl_DM_Movie_DTO foundMovie = movieBus.Find(foundSchedule.Movie_AutoID);
                        tbl_DM_Theater_DTO foundTheater = theaterBus.FindByID(foundSchedule.Theater_AutoID);
                        tbl_DM_Staff_DTO foundStaff = staffBus.GetStaff_ByID((int)o.StaffID);
                        txtMovieName.Text = foundMovie.MV_NAME.Trim();
                        txtPrice.Text = foundMovie.MV_PRICE.ToString().Trim();
                        txtSchedule.Text = foundSchedule.StartDate.ToString("dd/mm/yyyy HH:mm");
                        txtTheater.Text = foundTheater.Name.Trim();
                        txtStaff.Text = foundStaff.ST_NAME.Trim();
                        txtSeat.Text = o.SeatName.Trim();
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
    }
}
