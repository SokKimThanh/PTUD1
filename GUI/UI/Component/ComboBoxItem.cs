namespace GUI.UI.Component
{
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name; // Hiển thị tên trong ComboBoxEdit
        }
    }
}
