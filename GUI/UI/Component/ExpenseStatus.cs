namespace GUI.UI.Component
{
    public class ExpenseStatus
    {
        int eX_STATUS_ID;
        string eX_STATUS_NAME;

        public ExpenseStatus(int eX_STATUS_ID, string eX_STATUS_NAME)
        {
            this.eX_STATUS_ID = eX_STATUS_ID;
            this.eX_STATUS_NAME = eX_STATUS_NAME;
        }

        public int EX_STATUS_ID { get => eX_STATUS_ID; set => eX_STATUS_ID = value; }
        public string EX_STATUS_NAME { get => eX_STATUS_NAME; set => eX_STATUS_NAME = value; }
    }
}
